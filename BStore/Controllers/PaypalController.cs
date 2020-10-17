using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BraintreeHttp;
using BStore.Models;
using BStore.Models.Paypal;
using Microsoft.AspNetCore.Mvc;
using PayPal.Core;
using PayPal.v1.Payments;

namespace BStore.Controllers
{
    public class PaypalController : Controller
    {
     
    
        public async System.Threading.Tasks.Task<IActionResult> CheckoutPaypal(CartInfoAction CommandAction)
        {
            var environment = new SandboxEnvironment("AdX8qU2NUs8gZiMTuJ3Fgsd-NlZGgmLQpSROXn6LMepUYEtP51Yn9pjN54LPT7wlwj_0wOt43tWYN8vK", "EK5ofEBT0AnZIyKVdG1j2pIr4FvWD3Q-hBDFvNCAsWO87yMb2Da3MtpeOY7CNLQKFBjVKaQP8_F6coal");
            var client = new PayPalHttpClient(environment);

            #region Create payment (just example)
            var itemList = new ItemList()
            {
                Items = new List<Item>()
            };
            int TyGiaUSD = 23;
            var total = Math.Round((double)SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart").Sum(p => p.SoLuong * p.GiaBan)/TyGiaUSD,2);
            //var total = myCart.Sum(p => p.Total);
            var myCart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
            foreach (var item in myCart)
            {
                itemList.Items.Add(new Item()
                {
                    Name = item.TenThucDon,
                    Currency = "USD",
                    Price = Math.Round((double)item.GiaBan/TyGiaUSD,2).ToString(),
                    Quantity = item.SoLuong.ToString(),
                    Sku = "sku",
                    Tax = "0"
                });
            }
            #endregion
            var paypalOrderID = DateTime.Now.Ticks;
            var payment = new Payment()
            {
                Intent = "sale",
                Transactions = new List<Transaction>() {
                    new Transaction()
                    {
                        Amount = new Amount()
                        {
                            Total = total.ToString(),
                            Currency = "USD",
                            Details = new AmountDetails
                            {
                                Tax = "0",
                                Shipping = "0",
                                Subtotal = total.ToString()
                            }
                        },
                        ItemList = itemList,
                        Description = $"Invoice #{paypalOrderID}",
                        InvoiceNumber = paypalOrderID.ToString()
                    }
                },
                RedirectUrls = new RedirectUrls()
                {
                    CancelUrl = "https://localhost:44390/Paypal/CheckoutFail",
                    ReturnUrl = "https://localhost:44390/Paypal/CheckoutSuccess"
                },
                Payer = new Payer()
                {
                    PaymentMethod = "paypal"
                }
            };

            PaymentCreateRequest request = new PaymentCreateRequest();
            request.RequestBody(payment);

            try
            {
                var response = await client.Execute(request);
                var statusCode = response.StatusCode;
                Payment result = response.Result<Payment>();

                var links = result.Links.GetEnumerator();
                string paypalRedirectUrl = null;
                while (links.MoveNext())
                {
                    LinkDescriptionObject lnk = links.Current;
                    if (lnk.Rel.ToLower().Trim().Equals("approval_url"))
                    {
                        //saving the payapalredirect URL to which user will be redirected for payment  
                        paypalRedirectUrl = lnk.Href;
                    }
                }

                return Redirect(paypalRedirectUrl);
            }
            catch (HttpException httpException)
            {
                var statusCode = httpException.StatusCode;
                var debugId = httpException.Headers.GetValues("PayPal-Debug-Id").FirstOrDefault();

                //Process when Checkout with Paypal fails
                return Redirect("/Paypal/CheckoutFail");
            }
        }

        //[HttpPost]
        //public IActionResult CheckoutPaypal(CartInfoAction CommandAction)
        //{

        //    return View();
        //}

        public IActionResult CheckoutFail()
        {
            return View();
        }

        public IActionResult CheckoutSuccess()
        {
            return View();
        }
    }
}
