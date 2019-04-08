var _shoppingCallFor = [];
var currentNodes;
var currentNodeID;
var currentChildNodes;
var serviceDate;

$(document).ready(function () {
    //*employee select services*//

    var hdnCategoriesJSON = $("#hdnCategoriesJSON").val();
    var treedata = JSON.parse(hdnCategoriesJSON);

    var $categoriesTree = $('#categoriestree').treeview({
        levels: 1,
        data: treedata,
        highlightSelected: false,
        //nodeIcon: "glyphicon glyphicon-user",
        showIcon: true,
        showCheckbox: true,
        onNodeChecked: function (event, node) {

            //alert(node.Name);
            //alert(node.ID);
            //alert(node.SitePrice);
            //alert(JSON.stringify(node.nodes));

            currentNodes = node;
            currentNodeID = node.nodeId;
            currentChildNodes = node.nodes;
            if (currentChildNodes != 'undefined' && currentChildNodes != undefined) {
                $.each(currentChildNodes, function (e, newnode) {
                    $('#categoriestree').treeview('checkNode', [newnode.nodeId, { silent: true }]);
                });
            }
            else {
                if (currentNodes.parentId > 0) {
                    $('#categoriestree').treeview('checkNode', [currentNodes.parentId, { silent: true }]);
                }
            }

            //$("#modalServices").modal("show");
            $("#modalServices").modal({ backdrop: 'static', keyboard: false });

            //var tdObject = $('#EmployeeBookingOrderDateTime .datepicker-days table td.day:first').not('.disabled').not('.disabled-date');
            $($('#EmployeeBookingOrderDateTime .datepicker-days table td.day').not('.disabled').not('.disabled-date').first()).click();
        },
        onNodeUnchecked: function (event, node) {
            //alert(node.Name);
            //alert(node.ID);

            currentNodes = node;
            currentNodeID = node.nodeId;
            currentChildNodes = node.nodes;
            if (currentChildNodes != 'undefined' && currentChildNodes != undefined) {
                $.each(currentChildNodes, function (e, newnode) {
                    $('#categoriestree').treeview('uncheckNode', [newnode.nodeId, { silent: true }]);
                });
            }

            var removeCartProductID = currentNodes.ID;
            if (currentNodes.RelatedProductID != 'undefined' && currentNodes.RelatedProductID != undefined) {
                removeCartProductID = currentNodes.RelatedProductID;
            }

            /// Remove product item from cart
            RemoveItemFromCart(removeCartProductID);
        }
    });

    /*Set client Availabilities dates*/
    var clientAvailabilitiesJSONSring = $("#ClientAvailabilitiesJSON").val();

    var weekday = new Array(7);
    weekday["Monday"] = "1";
    weekday["Tuesday"] = "2";
    weekday["Wednesday"] = "3";
    weekday["Thursday"] = "4";
    weekday["Friday"] = "5";
    weekday["Saturday"] = "6";
    weekday["Sunday"] = "0";

    var daysOfWeekDisabled = [];
    $.each(JSON.parse(clientAvailabilitiesJSONSring), function (index, object) {
        var dayOfWeek = weekday[object.Day];
        daysOfWeekDisabled.push(dayOfWeek);
    });

    //alert(JSON.stringify(daysOfWeekDisabled));

    var daysOfWeekDisabledArrys = [];
    for (var i = 0; i < 7; i++) {
        var returnedData = $.grep(daysOfWeekDisabled, function (element, index) {
            return element == i;
        });

        if (returnedData.length == 0) daysOfWeekDisabledArrys.push(i);
    }

    //*employee select booking day*//
    $("#EmployeeBookingOrderDateTime").datepicker({
        format: "MM-dd-yyyy",
        daysOfWeekDisabled: daysOfWeekDisabledArrys
    });

    $('#EmployeeBookingOrderDateTime').datepicker('setStartDate', new Date());

    $('#EmployeeBookingOrderDateTime').datepicker().on('changeDate', ServicetimeChange);


    //*end*//

    $(document).on('click', '.minute', function () {

        if ($(this).closest('td').hasClass('booked')) return false;

        var selectedAddons = [];
        $('.minute').removeClass('active');
        $('.hour').removeClass('active');
        $(this).addClass('active');
        $(this).closest('.hour-container').find('.hour').addClass('active');

        var serviceID = currentNodes.ID;

        $.each(currentNodes.nodes, function (inedx, object) {
            selectedAddons.push(object.RelatedProductID);
        });

        var actionURL = _contentRoot + "Service/CheckCorporateServiceAvailability";
        var serviceDateTime = $('#EmployeeBookingOrderDateTime').data('datepicker').getFormattedDate('mm-dd-yyyy');
        var clientId = $('#ClientID').val();

        if (!IsNullOrEmptyString(serviceDateTime)) {
            var selectedHour = $('.hour.active').attr('data-hour');
            var selectedMinute = $('.minute.active').attr('data-minute');

            serviceDateTime = serviceDateTime + ' ' + selectedHour + ':' + PadString(selectedMinute, 2);
        }

        ShowPortletLoader('.datetimepicker-hours');

        $.ajax({
            url: actionURL,
            data: {
                pServiceID: serviceID,
                pServiceDateTime: serviceDateTime,
                pSelectedAddons: selectedAddons.toString(),
                pClientId: clientId
            },
            success: function (response) {

                if (response == 0) {
                    $('#btnBooking').attr('disabled', 'disabled');
                    ShowOperationalMessage('Insufficient time to book this request. Please select another time.');
                } else {
                    $('#btnBooking').removeAttr('disabled');
                }

                HidePortletLoader('.datetimepicker-hours');
            }
        });

    });

    $(document).on("change", "#CustomerPaypalEmail", function () {
        ValidateDomain();
    });
});

function ValidateDomain() {
    //*------- employee order place by client slug  ---------*//
    var Email = $("#CustomerPaypalEmail").val();
    var domainName = $("#DomainName").val();
    if (!IsNullOrEmptyString(domainName) && !IsNullOrEmptyString(Email)) {
        var splittedDomains = domainName.split(',');

        var isValidEmailAddress = false;
        var checkEmailString = Email.toLowerCase();

        $.each(splittedDomains, function (index, object) {

            if (checkEmailString.indexOf("@" + object) >= 0) {
                isValidEmailAddress = true;
                return false;
            }
        });

        if (!isValidEmailAddress) {
            $("#alert-domain-error").show();
            $(".button-confirm").hide();
        }
        else {
            $("#alert-domain-error").hide();
            $(".button-confirm").show();
        }
    }
    //*------- End ---------*//

}

function ShowEmployeeBookingPanel(element) {

    if (element == "dvEmployeeDetails") {
        var nodecheckedlength = $("#categoriestree").find("li.node-checked").length;
        if (nodecheckedlength > 0) {
            $(".employeeBookingPanel").hide();

            var clientID = $('#ClientID').val();
            var dataActionUrl = _contentRoot + "Cart/ConfirmOrderDetails";
            _shoppingCartCall = $.ajax({
                url: dataActionUrl,
                type: 'POST',
                data: {
                    pClientId: clientID
                },
                success: function (data) {
                    if (data != "ERROR") {
                        $("#dvEmployeeDetails_container").empty().html(data);

                        InitializeCard();
                        InitializeAddressIO();
                        ValidateDomain();
                        $("#" + element).show();
                        $("#hdfValidAddress").val(true);

                        InitValidation();
                    }
                    else {
                        ShowOperationalMessage("Something went wrong.");
                    }
                },
                error: function (data) {
                }
            });
        }
        else {

            ScrollToTop();
            $("#alert-service").show();
            setTimeout(function () {
                $("#alert-service").hide();
            }, 10000);
        }


    }
    else {
        $(".employeeBookingPanel").hide();
        $("#" + element).show();
    }


}

function InitializeCard() {
    new Card({
        form: document.querySelector('#dvEmployeeDetails'),
        container: '.stripe-card-wrapper'
    });
}

function InitializeAddressIO() {
    $('#postcode_lookup').getAddress({
        api_key: '3HPQjeU_7EGEpP832__OiA422',
        output_fields: {
            line_1: '#txtBillingAddress',
            line_2: '#txtBillingAddress2',
            line_3: '#txtBillingAddress3',
            post_town: '#txtBillingcity',
            postcode: '#txtBillingPostalCode'
        },
        //<!--  Optionally register callbacks at specific stages -->
        onLookupSuccess: function (data) { },
        onLookupError: function () {/* Your custom code */ },
        onAddressSelected: function (elem, index) {
            elem = elem.toLowerCase().replace(/ /g, '');
            var orderCitiesArray = _OrderCities.replace(/ /g, '').toLowerCase().split(',');
            var addressSelected = elem.replace(/ /g, '').split(',');

            var isValidCity = false;
            $(orderCitiesArray).each(function (index, object) {
                if (addressSelected.indexOf(object) > 0) {
                    isValidCity = true;
                    return false;
                }
            });

            if (!isValidCity) {
                $("#hdfValidAddress").val(false);
                ShowOperationalMessage('The postcode you entered is outside of the area we serve.');
            } else {
                $("#hdfValidAddress").val(true);
            }
        }
    });

}

function CancelServiceConfirmation(element) {

    $('#categoriestree').treeview('uncheckNode', [currentNodeID, { silent: true }]);
    if (currentChildNodes != 'undefined' && currentChildNodes != undefined) {
        $.each(currentChildNodes, function (e, newnode) {
            $('#categoriestree').treeview('uncheckNode', [newnode.nodeId, { silent: true }]);
        });
    }

    $("#modalServices").modal("hide");
}

function ConfirmEmployeeService(element) {

    var selectedHour = $('.hour.active').attr('data-hour');
    var selectedMinute = $('.minute.active').attr('data-minute');
    var selectedDate = $('#EmployeeBookingOrderDateTime').data('datepicker').getFormattedDate('dd/MM/yyyy');

    serviceDate = selectedDate + ' ' + selectedHour + ':' + selectedMinute;

    if (IsNullOrEmptyString(selectedHour) || IsNullOrEmptyString(selectedDate) || selectedMinute == undefined) {
        ScrollToTop();
        $('#alert-service-datetime').show();
        setTimeout(function () {
            $('#alert-service-datetime').hide();
        }, 10000);
    } else {

        $('#alert-service-datetime').hide();


        var cartJSON = [];
        var parentProductID = 0;
        var productID = currentNodes.ID;

        if (currentNodes.RelatedProductID != 'undefined' && currentNodes.RelatedProductID != undefined) {
            var parentProductID = currentNodes.ID;
            var productID = currentNodes.RelatedProductID;
        }

        /// current node value added in json
        cartJSON.push({
            ProductID: productID,
            ParentProductID: parentProductID,
            Quantity: 1
        });

        if (currentChildNodes != 'undefined' && currentChildNodes != undefined) {
            $.each(currentChildNodes, function (e, newnode) {

                /// current child node value added in json
                cartJSON.push({
                    ProductID: newnode.RelatedProductID,
                    ParentProductID: newnode.ID,
                    Quantity: 1
                });
            });
        }

        var cartjsonstring = JSON.stringify(cartJSON);
        AddItemToShoppingCart(productID, cartjsonstring, serviceDate);
    }
}

function AddItemToShoppingCart(productID, cartJSONString, serviceDate) {

    var dataActionUrl = _contentRoot + "Cart/ManageEmployeeBookingCartItem";
    var clientId = $('#ClientID').val();

    if (IsNullOrEmptyString(clientId))
        clientId = 0;

    $('#btnBooking').attr('disabled', 'disabled');
    _shoppingCartCall = $.ajax({
        url: dataActionUrl,
        type: 'POST',
        data: {
            EmployeeCartJsonString: cartJSONString,
            ServiceDate: serviceDate,
            ClientId: clientId
        },
        success: function (data) {
            $('#btnBooking').removeAttr('disabled');
            if (data != "ERROR" && data != "INSUFFICIENT") {
                $("#header-shoppingcart-wrapper").empty().html(data);

                $("#modalServices").modal("hide");
                //ShowOperationalMessage("Service successfully added to cart.");
            }
            else if (data == "INSUFFICIENT") {
                $('#btnBooking').attr('disabled', 'disabled');
                ShowOperationalMessage("Insufficient time to book this request. Please select another time.");
            }
            else {
                ShowOperationalMessage("Something went wrong.");
            }
        },
        error: function (data) {
        }
    });

    _shoppingCallFor.push({ "ProductID": productID, "Call": _shoppingCartCall });
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

                // ShowOperationalMessage("Service successfully removed from cart.");
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

function ShowOperationalMessage(message) {
    $('#cartOperationMessage').text(message);
    $('#cartOperationModal').modal('show');
}

function ConfirmOrderBooking(element) {

    $("#OrderDateTime").val(serviceDate);

    var clientID = $('#ClientID').val();
    var actionUrl = _contentRoot + "Service/CheckCorporateBookingAvailability";

    $.ajax({
        url: actionUrl,
        data: {
            pClientID: clientID
        },
        success: function (response) {
            if (response > 0) {
                ConfirmOrder(element);
            }
            else {
                ShowOperationalMessage('Your service is already booked for this order, Please select another time for service.');
            }
        }
    });
}

function SaveEmployeeBookingData(element) {
    var isValidAddress = $("#hdfValidAddress").val();

    if ($("#frmEmployeeBooking").valid() && isValidAddress == "true") {

        if ($("#divCheckoutPasswordWrapper").css("display") == "block" || !$("#divCheckoutPasswordWrapper").is(':hidden')) {
            $("#login-error-message").show();
            $("#CheckOut-Login").click();

            $('html, body').animate({
                scrollTop: $("#CheckOut-Login").offset().top - 50
            }, 10);
            return false;
        }


        if ($("#chkPaymentMethod").is(':checked') && IsNullOrEmptyString($("#CardType").val()) && selectedPaymentMethod == 'CreditCard') {
            $("#payment-method-content").click();
            $('html, body').animate({
                scrollTop: $("#payment-method-content").offset().top - 50
            }, 10);

            setTimeout(function () {
                $(".invalid-card-error").show();
            }, 500);
            setTimeout(function () {
                $(".invalid-card-error").hide();
            }, 3000);
            return false;
        }

        $("#hdfPaypalPreApprovalKey").val(_PaypalPreApprovalKey);
        $("#hdfLoginUserID").val(_LoginUserID);


        $("#button-confirm").button('loading');

        //var selectedNode =  $('#categoriestree').treeview('getSelected', nodeId);
        //alert(selectedNode);
    }
    else {

        if (isValidAddress == "false") {
            var postCode = $("#txtBillingPostalCode").val();
            if (IsNullOrEmptyString(postCode)) {
                ShowOperationalMessage('Please search your address.')
            } else {
                ShowOperationalMessage('The postcode you entered is outside of the area we serve.')
            }
        }

        $('#frm-checkout .panel-collapse').each(function (index, object) {
            if (!$(object).hasClass('in')) {
                $(object).closest('.panel-default').find('.accordion-toggle').click();
            }
        });

        ScrollToTop();

        return false;
    }
}

function ServicetimeChange() {

    var selectedDate = $('#EmployeeBookingOrderDateTime').data('datepicker').getFormattedDate('mm-dd-yyyy');

    var productID = currentNodes.ID;
    var duration = parseInt(currentNodes.Duration);

    if (IsNullOrEmptyString(duration)) duration = 0;


    $.each(currentNodes.nodes, function (inedx, object) {
        duration = duration + parseInt(object.Duration);
    });

    var serviceId = $("#ServiceID").val();
    //var duration = $("#Duration").val();
    var clientId = $('#ClientID').val();

    var actionUrl = _contentRoot + "Service/GetClientAvailability";

    ShowPortletLoader(".datetimepicker-hours");

    $.ajax({
        url: actionUrl,
        data: {
            pServiceID: productID,
            pServiceDateTime: selectedDate,
            pClientID: clientId,
            pServiceDuration: duration
        },
        success: function (response) {
            HidePortletLoader('.datetimepicker-hours');
            $('#serviceAvailabilityContainer').empty().html(response);

            $("#EmployeeBookingOrderDateTime").datepicker({
                format: "MM-dd-yyyy",
            });

            //$('#OrderDateTime').datepicker('setStartDate', new Date());

            $(document).find('.booked').popover({
                container: 'body',
                content: 'Your chosen treatments in the cart have been booked for this time.',
                placement: 'top',
                title: 'Chosen time',
                trigger: 'hover'
            });
        }
    });
}

function PadString(str, max) {
    str = str.toString();
    return str.length < max ? PadString("0" + str, max) : str;
}