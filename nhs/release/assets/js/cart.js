var _shoppingCallFor = [];

function AddItemToShoppingCart(ProductID, ParentProductID, ServiceDate) {

    var shoppingCartCall;

    if (IsNullOrEmptyString(ParentProductID)) {
        ParentProductID = 0;
    }

    var dataActionUrl = _contentRoot + "Cart/ManageCartItem";
    _shoppingCartCall = $.ajax({
        url: dataActionUrl,
        type: 'POST',
        data: {
            ProductID: ProductID,
            ParentProductID: ParentProductID,
            Quantity: 1,
            ServiceDate: ServiceDate
        },
        success: function (data) {
            if (data != "ERROR") {
                $("#header-shoppingcart-wrapper").empty().html(data);
                // DisplayMessage("error", errorMessage);

                //var pathName = $(location)[0].pathname.toLowerCase();
                //if (pathName.indexOf('cart') >= 0)
                //    //window.location = pathName;
                //    SelectShippingMethod();
                //else
                //    ShowOperationalMessage("Service successfully added to cart.");



                if (IsNullOrEmptyString(ParentProductID)) {
                    window.location.href = _contentRoot + "cart";
                }
                //else
                //ShowOperationalMessage("Service successfully added to cart.");


                var serviceDuration = $("#Duration").val();
                if (IsNullOrEmptyString(serviceDuration)) serviceDuration = 0;

                if (ParentProductID > 0) {
                    var addOnDuration = $("#AddOnDuration-" + ProductID).val();
                    var totalDuration = parseInt(serviceDuration) + parseInt(addOnDuration);
                    $("#Duration").val(totalDuration);

                    ServicetimeChange();
                }

            }
            else {
                ShowOperationalMessage("Something went wrong.");
            }
        },
        error: function (data) {
        }
    });

    _shoppingCallFor.push({ "ProductID": ProductID, "Call": _shoppingCartCall });
}

function ShowOperationalMessage(message) {
    $('#cartOperationMessage').text(message);
    $('#cartOperationModal').modal('show');
}

function RemoveItemFromCart(ProductID) {
    var dataActionUrl = _contentRoot + "Cart/RemoveCartItem";
    $.ajax({
        url: dataActionUrl,
        data: { ProductID: ProductID },
        success: function (data) {
            if (data != "ERROR") {
                var deleteButtonObject = $('#btnUserCartRemoveProduct-' + ProductID);
                $("#header-shoppingcart-wrapper").empty().html(data);

                var pathName = $(location)[0].pathname.toLowerCase();
                if (pathName.indexOf('cart') >= 0)
                    //window.location = pathName;
                    SelectShippingMethod();
                //else
                //    ShowOperationalMessage("Service successfully removed from cart.");

                var serviceDuration = $("#Duration").val();
                if (IsNullOrEmptyString(serviceDuration)) serviceDuration = 0;


                var addOnDuration = $("#AddOnDuration-" + ProductID).val();

                if (!IsNullOrEmptyString(addOnDuration)) {
                    var totalDuration = parseInt(serviceDuration) - parseInt(addOnDuration);
                    $("#Duration").val(totalDuration);

                    ServicetimeChange()
                }
            }
            else {
                //DisplayMessage("error", "Unable to remove product.");                
                ShowOperationalMessage("Unable to remove service.");
            }
        },
        error: function (data) {
            //DisplayMessage("error", "Unable to remove product.");

            ShowOperationalMessage("Unable to remove service.");
        }
    });
}

function AddonSelection(element) {
    var selectedProductID = $(element).attr('data-productid');
    var parentproductid = $(element).attr('data-parentproductid');

    if ($(element).prop('checked'))
        AddItemToShoppingCart(selectedProductID, parentproductid);
    else
        RemoveItemFromCart(selectedProductID);
}

function ReloadTopHeader() {
    var dataActionUrl = _contentRoot + "Home/GetTopHeader";

    $.ajax({
        url: dataActionUrl,
        success: function (data) {
            $("#top-header-wrapper").empty().html(data);
        },
        error: function (data) {
        }
    });
}

function ReloadCartHeader() {
    var actionUrl = _contentRoot + "cart/GetHeaderShoppingCart";
    $.ajax({
        url: actionUrl,
        success: function (response) {
            $('#header-shoppingcart-wrapper').empty().html(response);
        }
    });
}