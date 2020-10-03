function LoadCart(data) {
    var htmlString = "";
    var totalQuantity = 0;
    var totalAmount = 0;
    if (data.length != 0) {
        for (i in data) {

                


            
            totalQuantity += data[i].soLuong;
            totalAmount += data[i].soLuong * data[i].giaBan;
            htmlString += '<div class="shipping-item">' +
                '<span class="cross-icon" > <i class="fa fa-times-circle"></i></span>' +
                '<div class="shipping-item-image">' +
                '<a href="#"><img src="user/products/' + data[i].hinhAnh +'" alt="shoppingimage" style="width:30px;height:30px;"/></a>' +
                '</div>' +
                '<div class="shipping-item-text">' +
                '<span>' + data[i].soLuong+ '<span class="pro-quan-x">x</span> <a href="#" class="pro-cat">'+ data[i].tenThucDon +'</a></span>' +
                
                '<p>' + data[i].giaBan + '</p>' +
                '</div>' +
                '</div>';
        }
        htmlString += '<div class="shipping-total-bill">' +
            '<div class="cart-prices">' +
            '<span class="shipping-cost">0,00</span>' +
            '<span>Shipping</span>' +
            '</div>' +
            '<div class="total-shipping-prices">' +
            '<span class="shipping-total total-price"></span>' +
            '<span>Total</span>' +
            '</div>' +
            '<div class="shipping-checkout-btn"><a href="/checkout">Check out<i class="fa fa-chevron-right"></i></a></div >';
            
    }
    else {
        htmlString += '<li class="none-item"><p>Chưa có sản phẩm trong giỏ</p></li>';

    }
    //$("#cart_hidden li.none-item").remove();
    //$("#cart_hidden li.item-in-cart").remove();
    //$("#cart_hidden li.item-total").before(htmlString);

    $(".shipping-cart-overly").html(htmlString);
    $("#soluonggg").html(totalQuantity);
    $(".total-price").html(totalAmount.toFixed(2)+ "(VNĐ)");
}

function LoadHiddenCart() {
    $.ajax({
        type: "GET",
        url: '/Cart/LoadCartHidden',
        dataType: 'json',
        success: function (response) {
            LoadCart(response);
        },
        error: function (error) {
        }
    });
}
$(document).ready(function () {

    LoadHiddenCart();

    function ResetButton(that) {
        $(that).html('<i class="fas fa-check"></i>');
    }

    $(document).on('click', '.order-button button', function (event) {
        event.preventDefault();
        
        var product_id = $(this).attr("data-id");
        var $this = $(this);
        //alert("Đã click: " + product_id);
        //$(this).html('<i class="fas fa-check"></i>');
        //setTimeout(function () {
        //    console.log($this.text());
        //    $this.html('Mua hàng');
        //}, 1000);
        $.ajax({
            type: "GET",
            url: '/Cart/AddToCart?id=' + product_id,
            dataType: 'json',
            success: function (response) {
                LoadCart(response);
            },
            error: function (error) {
            }
        });
    });

    $(document).on('click', '.button-add-to-cart a', function (event) {
        event.preventDefault();
        console.log("da click");
        var product_id = $(this).attr("data-id");
        var $this = $(this);
        $(this).html('<i class="fas fa-check"></i>');
        setTimeout(function () {
            $this.html('THÊM VÀO GIỎ');
        }, 1000);
        $.ajax({
            type: "GET",
            url: '/Cart/AddToCart?id=' + product_id,
            dataType: 'json',
            success: function (response) {
                LoadCart(response);
            },
            error: function (error) {
            }
        });
    });
});