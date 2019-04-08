
var ShippingMethodAjax = null;

var selectedPaymentMethod = 'Stripe';

// INITIALIZE CREADIT CARD PLUGIN
//new Card({
//    form: document.querySelector('#frm-checkout'),
//    container: '.card-wrapper'
//});


new Card({
    form: document.querySelector('#frm-checkout'),
    container: '.stripe-card-wrapper'
});

// Load event of checkout page
$(document).ready(function () {

    //var allowTimes = ['10:00 AM', '10:15 AM', '10:30 AM', '10:45 AM', '11:00 AM', '11:15 AM', '11:30 AM', '11:45 AM', '12:00 PM', '12:15 PM', '12:30 PM', '12:45 PM', '01:00 PM', '01:15 PM', '01:30 PM', '01:45 PM', '02:00 PM', '02:15 PM', '02:30 PM', '02:45 PM', '03:00 PM', '03:15 PM', '03:30 PM', '03:45 PM', '04:00 PM', '04:15 PM', '04:30 PM', '04:45 PM', '05:00 PM', '05:15 PM', '05:30 PM', '05:45 PM', '06:00 PM', '06:15 PM', '06:30 PM', '06:45 PM', '07:00 PM', '07:15 PM', '07:30 PM', '07:45 PM'];

    //$('#OrderDateTime').datetimepicker({
    //    //defaultDate: "+1w",
    //    format: 'd-m-Y h:i',
    //    changeMonth: true,
    //    numberOfMonths: 3,
    //    minDate: new Date(),
    //    allowTimes: allowTimes
    //});

    InitCouponCodeValidation();

    $("#OrderDateTime").datetimepicker({
        autoclose: true,
        format: "MM dd yyyy - hh:ii",
        minDate: 0,
        pickerPosition: "bottom-right"
    });

    $('#OrderDateTime').datetimepicker('setStartDate', new Date());

    $("#ShippingUserContactID").val("");

    if ($("#ShippingUserContactID option").length > 1) {

        $("#ShippingUserContactID").val($('#ShippingUserContactID option:eq(1)').val());
        $("#ShippingUserContactID").trigger("change");
    }

    //$("#BillingUserContactID").val("");


    InitValidation();

    RemoveCardValidation();

    $("#CustomerPaypalEmail").focus();
});

// THIS FUNCTION IS USED FOR SELECT SAME BILLING ADRESS AS SHIPPING ADDRESS
function BillingAdressSameAsShipingChange(ele) {

    //  $("#checkout-page").find(".panel-collapse").removeClass("in");

    if ($(ele).is(":checked")) {
        $("#payment-address-content").removeClass("in");
        $("#chkbillsametoggle").addClass("collapsed");

        $("#payment-address-content").attr("aria-expanded", false);
        $("#payment-address-content").css("height", "auto");

        //Remove Name Propery
        //$("#txtBillingFirstName").removeAttr("name");
        //$("#txtBillingLastName").removeAttr("name");
        //$("#txtBillingTelePhone").removeAttr("name");
        //$("#txtBillingAddress").removeAttr("name");
        //$("#ddlBillingCountry").removeAttr("name");
        //$("#ddlBillingState").removeAttr("name");
        //$("#txtBillingcity").removeAttr("name");
        //$("#txtBillingPostalCode").removeAttr("name");

        $("#chkbillsametoggle").attr("href", "javascript:void(0);");
        $("#chkbillsametoggle").removeAttr("data-toggle");
        $("#chkbillsametoggle").removeAttr("data-parent");

    }
    else {
        $("#payment-address-content").addClass("in");
        $("#chkbillsametoggle").removeClass("collapsed");

        $("#payment-address-content").attr("aria-expanded", true);
        $("#payment-address-content").css("height", "auto");

        //Add Name Propery
        //$("#txtBillingFirstName").attr("name", "BillingFirstName");
        //$("#txtBillingLastName").attr("name", "BillingLastName");
        //$("#txtBillingTelePhone").attr("name", "BillingTelePhone");
        //$("#txtBillingAddress").attr("name", "BillingAddress");
        //$("#ddlBillingCountry").attr("name", "BillingCountry");
        //$("#ddlBillingState").attr("name", "BillingState");
        //$("#txtBillingcity").attr("name", "Billingcity");
        //$("#txtBillingPostalCode").attr("name", "BillingPostalCode");

        $("#chkbillsametoggle").attr("href", "#payment-address-content");
        $("#chkbillsametoggle").attr("data-toggle", "collapse");
        //$("#chkbillsametoggle").attr("data-parent", "#checkout-page");


    }

    $("#payment-address").find(".has-success").removeClass("has-success");
    $("#payment-address").find(".has-error").removeClass("has-error");
    $("#payment-address").find(".help-block").remove();
    $("#payment-address").find(".panel-error").removeClass("panel-error");
    $("#payment-address").find(".panel-tittle-error").removeClass("panel-tittle-error");

}

// THIS FUNCTION IS USED FOR VALIDATE STREET LEVEL ADDRESS. IF ADDRESS IS VALID THEN WE ARE GETTING PAYMENT METHOD WITH SHIPPING RATES
function AddressValidationAndBindPaymentMethod(ShowAddressLoader) {

    if (IsNullOrEmptyString(ShowAddressLoader)) {
        ShowAddressLoader = true;
    }

    var ShippingAddress = $("#txtShippingAddress").val();
    var CountryCode = $('#ddlShippingCountry option:selected').attr('data-code');
    var StateProvince = $('#ddlShippingState option:selected').attr('data-code');
    var City = $("#txtShippingcity").val();
    var PostalCode = $("#txtShippingPostalCode").val();
    var FullName = $("#txtShippingFirstName").val() + " " + $("#txtShippingLastName").val();

    if (!IsNullOrEmptyString(ShippingAddress) && !IsNullOrEmptyString(CountryCode) && !IsNullOrEmptyString(StateProvince) && !IsNullOrEmptyString(City) && !IsNullOrEmptyString(PostalCode)) {

        if (ShippingMethodAjax != null) {
            ShippingMethodAjax.abort();
        }


        $("#SuggestedAddressWrapper").hide();
        $("#ShippingMethodListWrapper").hide();
        $("#default-shipping-method-message").hide();
        $("#ShippingMethodList").html("");
        var url = _contentRoot + "CheckOut/AddressValidationAndBindPaymentMethod"

        var ShippingAddress = {
            AddressLine1: ShippingAddress,
            City: City,
            CountryCode: CountryCode,
            PostalCode: PostalCode,
            ReceiverName: FullName,
            StateProvince: StateProvince,
        }

        $("#shipping-loader").show();

        if (ShowAddressLoader) {
            $("#suggested-shipping-address-loader").show();
        }



        ShippingMethodAjax = $.ajax({
            type: 'POST',
            url: url,
            data: JSON.stringify(ShippingAddress),
            contentType: "application/json",
            dataType: "JSON",
            success: function (data) {

                $("#shipping-loader").hide();
                $("#suggested-shipping-address-loader").hide();


                $("#ShippingMethodList").html("");

                if (data.IsValidAddress) {

                    $("#ShippingMethodListWrapper").show();
                    $("#default-shipping-method-message").hide();
                    if (!data.ShippingMethodListAndRate.length) {
                        $("#ShippingMethodList").html("<span class='text-warning'>Shipping method is not available for this address.</span>");
                    }

                    $.each(data.ShippingMethodListAndRate, function (index, item) {
                        $("#ShippingMethodList").append("<div class=\"radio-list\"><label><input type=\"radio\" name=\"ShippingMethod\" data-method='" + item.ServiceDescription + "' value='" + item.TotalCharges + "' onclick='SelectShippingMethod(this);' />" + item.ServiceDescription + " <small class='text-success'>$" + item.TotalCharges + "</small></label></div>");
                    });

                    if (!IsNullOrEmptyString($("#hdnSelectedShippingMethod").val())) {

                        $("input[data-method='" + $("#hdnSelectedShippingMethod").val() + "']").attr("checked", true);
                    }

                    SelectShippingMethod();

                    //$("#ShippingMethodList input[type=radio]").uniform();

                } else {
                    $("#default-shipping-method-message").show();

                    $("#SuggestedAddressWrapper").show();
                    $("#ddlSuggestedAddress").html("<option>--SELECT--</option>");
                    $.each(data.SuggestedAddressList, function (index, item) {

                        var fullAddess = item.AddressLine1 + ", " + item.City + ", " + item.StateProvince + ", " + item.PostalCode + ", " + item.CountryCode;

                        if (!$('#ddlSuggestedAddress option:contains(' + fullAddess + ')').length) {

                            $("#ddlSuggestedAddress").append("<option data-AddressLine1='" + item.AddressLine1 + "' data-City='" + item.City + "' data-StateProvince='" + item.StateProvince + "' data-PostalCode='" + item.PostalCode + "' data-CountryCode='" + item.CountryCode + "'>" + fullAddess + "</option>");
                        }
                    });
                    $("#hdnSelectedShippingMethod").val("");
                    SelectShippingMethod();
                }
            }
        });
    } else {
        $("#SuggestedAddressWrapper").hide();
        $("#ShippingMethodListWrapper").hide();
        $("#default-shipping-method-message").show();
        $("#ShippingMethodList").html("");
        $("#hdnSelectedShippingMethod").val("");
        SelectShippingMethod();

    }
}

// THIS METHOD IS USED WHEN USER SELECT CREADIT CARD OPTION
function chkCreaditCardMethodChange(ele) {
    if ($(ele).is(":checked")) {
        $("#creadit-card-wrapper").show();
        $("#select-payment-method-message").hide();
        $("#paypal-approval-key-message").hide();

        $("#txtCreditCardNumber").attr("name", "number");
        $("#txtCreditCardHolderName").attr("name", "name");
        $("#txtCreditCardExpiryTime").attr("name", "expiry");
        $("#txtCreditCardcvcCode").attr("name", "cvc");

        if ($("#creaditcard-control .has-error").length) {
            $("#payment-method-panel").addClass("panel-error");
        }

        selectedPaymentMethod = 'CreditCard';
    }
}

// THIS METHOD IS USED WHEN USER SELECT STRIPE PAYMENT OPTION
function chkCreaditCardMethodChange(ele) {
    if ($(ele).is(":checked")) {
        $("#stripe_creadit-card-wrapper").show();
        $("#select-payment-method-message").hide();
        $("#paypal-approval-key-message").hide();

        $("#txtStripeCreditCardNumber").attr("name", "number");
        $("#txtStripeCreditCardHolderName").attr("name", "name");
        $("#txtStripeCreditCardExpiryTime").attr("name", "expiry");
        $("#txtStripeCreditCardcvcCode").attr("name", "cvc");

        if ($("#stripe_creaditcard-control .has-error").length) {
            $("#payment-method-panel").addClass("panel-error");
        }

        selectedPaymentMethod = 'Stripe';
    }
}

// THIS METHOD IS USED WHEN USER SELECT PAYPAL OPTION
function chkPaypalMethodChange(ele) {

    if ($(ele).is(":checked")) {
        $("#creadit-card-wrapper").hide();
        $("#select-payment-method-message").hide();

        if ($("#CustomerPaypalEmail").valid()) {


            var url = _contentRoot + "cart/GetPreAprovalKeyFromDB"
            $("#paypal-preapproval-loader").show();
            $.ajax({
                url: url,
                data: { UserID: _LoginUserID },
                dataType: 'JSON',
                success: function (data) {
                    if (data.ResultCode == "SUCCESS") {
                        if (!IsNullOrEmptyString(data.ResultObject)) {
                            _PaypalPreApprovalKey = data.ResultObject;
                            $("#paypal-approval-key-message").hide();
                        } else {
                            //$("#paypal-approval-key-message").text(data.ResultMessage).show();
                            // DisplayMessage("warning", data.ResultMessage);
                        }

                    } else {
                        DisplayMessage("error", data.ResultMessage);
                    }

                    $("#paypal-preapproval-loader").hide();

                }
            });

            $("#txtCreditCardNumber").removeAttr("name");
            $("#txtCreditCardHolderName").removeAttr("name");
            $("#txtCreditCardExpiryTime").removeAttr("name");
            $("#txtCreditCardcvcCode").removeAttr("name");

            $("#payment-method-panel").removeClass("panel-error");

        } else {
            $('html, body').animate({
                scrollTop: $("#CustomerPaypalEmail").offset().top - 150
            }, 10);
        }

        selectedPaymentMethod = 'Paypal';
    }
}

// THIS METHOD IS USED WHEN USER ENTER CREADIT CARD NUMBER THEN CHECK WETHER THIS IS VALID OR NOT
function CheckCreaditCard() {

    if (!IsNullOrEmptyString($("#txtCreditCardNumber").val()) && IsNullOrEmptyString($("#CardType").val())) {

        setTimeout(function () {
            $(".creadit-card-payment").find(".invalid-card-error").show();
        }, 500);


        setTimeout(function () {
            $(".creadit-card-payment").find(".invalid-card-error").hide();
        }, 3000);
    }
}

function CheckStripeCreaditCard() {

    if (!IsNullOrEmptyString($("#txtCreditCardNumber").val()) && IsNullOrEmptyString($("#CardType").val())) {

        setTimeout(function () {
            $("#stripe_creadit-card-wrapper").find(".invalid-card-error").show();
        }, 500);


        setTimeout(function () {
            $("#stripe_creadit-card-wrapper").find(".invalid-card-error").hide();
        }, 3000);
    }
}

// Get Paypal Pre Approval key and open approval url in pop up window
function GetPreApproveKey(ele) {
    //$("#chkPaypalPreApproval").attr("checked", true);
    if ($("#chkPaypalPreApproval").is(":checked")) {
        var validator = $("#frm-checkout").validate();
        if (validator.element("#CustomerPaypalEmail")) {

            $("#creadit-card-wrapper").hide();
            $("#paypal-preapproval-wrapper").show();
            var url = _contentRoot + "cart/GetPreAprovalKeyFromPaypal"
            $("#paypal-preapproval-loader").show();
            $.ajax({
                url: url,
                data: { CustomerPaypalEmail: $("#CustomerPaypalEmail").val() },
                dataType: 'JSON',
                success: function (data) {

                    $("#paypal-preapproval-loader").hide();

                    if (data.ResultCode == "SUCCESS" && !IsNullOrEmptyString(data.ReturnURL)) {
                        $("#paypal-approval-key-message").hide();
                        window.open(data.ReturnURL, null, "height=600,width=1000,left=150,top=50,status=yes,toolbar=no,menubar=no,location=no");

                    } else {

                        var errorhtml = "";
                        if (data.ErrorMessages.length > 0) {
                            errorhtml = "- " + data.ErrorMessages[0];

                            for (var i = 1; i < data.ErrorMessages.length; i++) {
                                errorhtml += "<br/> - " + data.ErrorMessages[i];
                            }
                        }

                        $("#paypal-approval-key-message").html(errorhtml).show();
                        //DisplayMessage("error", data.ResultMessage);
                    }
                }
            });
        } else {
            //DisplayMessage("error", "Please enter paypal email address.");
            $('html, body').animate({
                scrollTop: $("#CustomerPaypalEmail").offset().top - 150
            }, 10);
        }

    } else {
        //$("#select-payment-method-message").show();
    }
}

// Initilize form validation on checkout page
function InitValidation() {

    jQuery.validator.addMethod("ValidateExpiryVerify", function (value, element) {
        var today = new Date();
        var year = parseInt(today.getFullYear().toString().substr(2, 2));

        if (!IsNullOrEmptyString(value)) {

            var val = value.split('/');
            if (val.length && parseInt(val[0]) > 12) {
                return false;
            }
            if (val.length > 1 && $.trim(val[1]).length < 2) {
                return false;
            }
            else if (parseInt(val[1]) < year) {
                return false;
            }

            if (value.length == 1) {
                return false;
            }
        }
        return true;
    }, "Please enter valid expiry time");

    jQuery.validator.addMethod("ValidatePhoneNumber", function (value, element) {
        for (var i = 0, len = value.length; i < len; i++) {
            if (parseInt(value[i]) > 0) {
                return true;
            }
        }
        return false;
    }, "Please enter valid number");

    var formElement = $("#frm-checkout");
    var error = $('.alert-danger', formElement);
    var success = $('.alert-success', formElement);

    formElement.validate({
        errorClass: "help-block help-block-error", // You can add help-block instead of help-inline if you like validation messages under the inputs
        errorElement: "span",
        highlight: function (element) { // hightlight error inputs
            $(element).closest('.form-group').removeClass("has-success").addClass('has-error'); // set error class to the control group

            //$("#shipping-address").addClass("panel-error");
        },
        success: function (element) {
            $(element).closest('.form-group').removeClass('has-error').addClass('has-success'); // set success class to the control group

            if (!$(element).closest('.panel').find('.has-error').length) {

                if ($(element).closest('.panel').find(".chksameadd").length) {
                    $(element).closest('.panel').find(".chksameadd").closest(".row").removeClass("panel-error");
                    $(element).closest('.panel').find(".accordion-toggle").removeClass("panel-tittle-error");
                } else {
                    $(element).closest('.panel').find(".accordion-toggle").removeClass("panel-error");
                }
            }
        },
        ignore: ".ignore",
        rules: {
            CustomerPaypalEmail: {
                required: true,
                email: true
            },
            CustomerPaypalPassword: {
                required: true
            },
            ShippingFirstName: {
                required: true
            },
            ShippingLastName: {
                required: true
            },
            ShippingTelephone: {
                required: true,
                ValidatePhoneNumber: true
            },
            ShippingAddress: {
                required: true
            },
            ShippingCountry: {
                required: true
            },
            ShippingState: {
                required: true
            },
            Shippingcity: {
                required: true
            },
            ShippingPostalCode: {
                required: true
            },
            number: {
                required: true
            },
            name: {
                required: true
            },
            expiry: {
                required: true,
                ValidateExpiryVerify: true
            },
            cvc: {
                required: true
            },
            BillingFirstName: {
                required: true
            },
            BillingLastName: {
                required: true
            },
            BillingTelePhone: {
                required: true,
                ValidatePhoneNumber: true
            },
            BillingAddress: {
                required: true
            },
            BillingCountry: {
                required: true
            },
            BillingState: {
                required: true
            },
            Billingcity: {
                required: true
            },
            BillingPostalCode: {
                required: true
            },
            OrderDateTime: {
                required: true
            },
            chkTermsAndConditions: {
                required: true
            }
        },
        messages: {
            CustomerPaypalEmail: {
                required: "Please enter email",
                email: "Please enter valid email"
            },
            CustomerPaypalPassword: {
                required: "Please enter password"
            },
            ShippingFirstName: {
                required: "Please enter first name"
            },
            ShippingLastName: {
                required: "Please enter last name"
            },
            ShippingTelephone: {
                required: "Please enter telephone number"
            },
            ShippingAddress: {
                required: "Please enter shipping address"
            },
            ShippingCountry: {
                required: "Please select country"
            },
            ShippingState: {
                required: "Please select state"
            },
            Shippingcity: {
                required: "Please enter city"
            },
            ShippingPostalCode: {
                required: "Please enter postal code"
            },
            number: {
                required: "Please enter card number"
            },
            name: {
                required: "Please enter card holder name"
            },
            expiry: {
                required: "Please enter expiry time"
            },
            cvc: {
                required: "Please enter cvc code"
            },
            BillingFirstName: {
                required: "Please enter first name"
            },
            BillingLastName: {
                required: "Please enter last name"
            },
            BillingTelePhone: {
                required: "Please enter telephone number"
            },
            BillingAddress: {
                required: "Please enter address"
            },
            BillingCountry: {
                required: "Please select country"
            },
            BillingState: {
                required: "Please select state"
            },
            Billingcity: {
                required: "Please enter city"
            },
            BillingPostalCode: {
                required: "Please enter postal code"
            },
            OrderDateTime: {
                required: "Please select order date"
            },
            chkTermsAndConditions: {
                required: 'Please tick the checkbox of terms of service'
            }
        },
        invalidHandler: function (event, validator) {
            //error.show();
        },
        submitHandler: function (formElement) {
            error.hide();
        },
        errorPlacement: function (error, element) {


            $(element).closest(".form-group").find(".help-block").remove();

            //error.insertAfter(element);
            $(element).closest("div").append(error);

            if ($(element).closest('.panel').find(".chksameadd").length) {
                $(element).closest('.panel').find(".chksameadd").closest(".row").addClass("panel-error");
                $(element).closest('.panel').find(".accordion-toggle").addClass("panel-tittle-error");
            } else {
                $(element).closest('.panel').find(".accordion-toggle").addClass("panel-error");
            }
        }

    });
}

// THIS METHOD ISUSED TO CHECK WHETHER USER WITH EMAIL IS EXISTS OR NOT
function CheckEmailExists() {
    var Email = $("#CustomerPaypalEmail").val();

    if (!IsNullOrEmptyString(Email) && $("#CustomerPaypalEmail").valid()) {
        $("#email-loader").show();
        _PaypalPreApprovalKey = "";
        var dataActionUrl = _contentRoot + "Account/IsEmailExists";

        $.ajax({
            url: dataActionUrl,
            type: 'POST',
            data: { Email: Email, IsSessionExpire: true },
            success: function (data) {
                if (data.ResultCode == "SUCCESS" && data.ResultObjectID > 0 && _LoginUserID != data.ResultObjectID) {
                    $("#divCheckoutPasswordWrapper").show();
                    $("#CustomerPaypalPassword").removeClass("ignore");
                    $("#email-loader").hide();
                }
                else {

                    $('#btnLoginNext').removeClass('hide');

                    $("#divCheckoutPasswordWrapper").hide();
                    $("#CustomerPaypalPassword").addClass("ignore");
                    $("#email-loader").hide();

                    if (data.ResultObjectID == 0) {

                        _LoginUserID = 0;

                        ///Function In main.js to reload the top header menu on ajax loading
                        ReloadTopHeader();

                        if (IsNullOrEmptyString($('#ClientID').val())) {
                            if (!IsNullOrEmptyString($("#ShippingUserContactID").val())) {
                                $("#txtShippingFirstName").val("").removeAttr("readonly");
                                $("#txtShippingLastName").val("").removeAttr("readonly");
                                $("#txtShippingTelePhone").val("").removeAttr("readonly");
                                $("#txtShippingAddress").val("").removeAttr("readonly");
                                $("#ddlShippingCountry").val("").removeAttr("disabled");
                                $("#ddlShippingState").val("").removeAttr("disabled");
                                $("#txtShippingcity").val("").removeAttr("readonly");
                                $("#txtShippingPostalCode").val("").removeAttr("readonly");

                                $("#SuggestedAddressWrapper").hide();
                                $("#ShippingMethodListWrapper").hide();
                                $("#default-shipping-method-message").show();
                                $("#ShippingMethodList").html("");
                            }


                            if (!IsNullOrEmptyString($("#BillingUserContactID").val())) {
                                $("#txtBillingFirstName").val("").removeAttr("readonly");
                                $("#txtBillingLastName").val("").removeAttr("readonly");
                                $("#txtBillingTelePhone").val("").removeAttr("readonly");
                                $("#txtBillingAddress").val("").removeAttr("readonly");
                                $("#ddlBillingCountry").val("").removeAttr("disabled");
                                $("#ddlBillingState").val("").removeAttr("disabled");
                                $("#txtBillingcity").val("").removeAttr("readonly");
                                $("#txtBillingPostalCode").val("").removeAttr("readonly");
                            }



                            $("#BillingUserContactID").html("<option value=''>--Select--</option>");
                            $("#billing-dropdown-wrapper").hide();

                            $("#ShippingUserContactID").html("<option value=''>--Select--</option>");
                            $("#shipping-dropdown-wrapper").hide();


                            if (!IsNullOrEmptyString($("#hdnSelectedShippingMethod").val())) {
                                $("#hdnSelectedShippingMethod").val("");
                                SelectShippingMethod();
                            }
                        }

                        $("#Rewardpoint-Container").empty();
                        $("#spaecial-order-information .panel-title a").text("Step 6: Special Information");
                        $("#OrderConfirmation-wraper .panel-title a").text(" Step 4: Confirm Order");
                    }
                }
            },
            error: function (data) {
                $("#divCheckoutPasswordWrapper").hide();
                $("#CustomerPaypalPassword").addClass("ignore");
                $("#email-loader").hide();
            }
        });
    }
}

// THIS METHOD IS USED FOR SIGNIN WITH AJAX
function AjaxLogin() {
    $("#login-error-message").hide();
    var $btn = $("#CheckOutLogin").button('loading');
    _PaypalPreApprovalKey = "";
    var customerEmail = $("#CustomerPaypalEmail").val();
    var customerpassword = $("#CustomerPaypalPassword").val();
    var dataActionUrl = _contentRoot + "Account/AjaxSignIn";
    $.ajax({
        url: dataActionUrl,
        type: 'POST',
        data: { Email: customerEmail, Password: customerpassword },
        success: function (data) {

            if (data.Status == "success") {
                $("#divCheckoutPasswordWrapper").hide();
                $("#CustomerPaypalPassword").addClass("ignore");

                $("#login-failmessage-wrapper").hide();

                ///Function In main.js to reload the top header menu on ajax loading
                ReloadTopHeader();

                //FUNCTION FOR BIND THE CONTACT ADDRESS DROPDOWN FOR LOGIN USER
                if (IsNullOrEmptyString($('#ClientID').val())) {
                    //GetUserAddressDropDown();
                } else {
                    $('#txtBillingFirstName').val(data.FirstName);
                    $('#txtBillingLastName').val(data.LastName);
                }


                // FUNCTION IS FOR UPDATE PAYPAL KEY
                if ($("#chkPaypalPreApproval").is(":checked")) {
                    $("#chkPaypalPreApproval").trigger("click");
                }

                $('#btnLoginNext').removeClass('hide');
                ReloadRewardsPoints();
                SelectShippingMethod();
                ReloadCartHeader();
                ReloadPaymentMethod();
            }
            else {
                $("#login-failmessage-wrapper").show();
                $btn.button('reset');
            }

            //Set the loginUserId Value in layout Variable
            _LoginUserID = data.UserID;
        },
        error: function (data) {
            $btn.button('reset');
        }
    });
}

// THIS METHOD IS USED FOR VALIDATE LOGIN FIELDS AND SIGNIN WITH AJAX
function ValidateAndLogin() {
    if ($("#CustomerPaypalEmail").valid() && $("#CustomerPaypalPassword").valid()) {
        AjaxLogin();
    }
}

// THIS METHOD IS USED FOR SELECT ADDRESS FROM ADDRESSES SUGGESTED BY UPS SERVICE
function SelectSuggestedAddress(ele) {

    if (!IsNullOrEmptyString($(ele).val())) {

        var countryId = $("#ddlShippingCountry option[data-code='" + $("#ddlSuggestedAddress option:selected").attr("data-CountryCode") + "']").val();
        var stateId = $("#ddlShippingState option[data-code='" + $("#ddlSuggestedAddress option:selected").attr("data-StateProvince") + "']").val();

        $("#txtShippingAddress").val($("#ddlSuggestedAddress option:selected").attr("data-AddressLine1"));
        $("#txtShippingcity").val($("#ddlSuggestedAddress option:selected").attr("data-City"));
        $("#ddlShippingState").val(stateId);
        $("#txtShippingPostalCode").val($("#ddlSuggestedAddress option:selected").attr("data-PostalCode"));
        $("#ddlShippingCountry").val(countryId);

        AddressValidationAndBindPaymentMethod(false);

    } else {
        $("#txtShippingAddress").val("");
        $("#txtShippingcity").val("");
        $("#ddlShippingState").val("");
        $("#txtShippingPostalCode").val("");
        $("#ddlShippingCountry").val("");
    }
}

// THIS METHOD IS USED FOR SELECT SHIPPING METHOD AND UPDATE ORDER INFO
function SelectShippingMethod(ele) {

    $("#shippingmethod-error-message").hide();

    var shippingRate = $("input[name=ShippingMethod]:checked").val();

    $("#hdnSelectedShippingMethod").val($("input[name=ShippingMethod]:checked").attr("data-method"));

    if (IsNullOrEmptyString(shippingRate)) {
        shippingRate = 0;
    }

    var shippingCountryID = $("#ddlShippingCountry").val();
    var shippingRegionID = $("#ddlShippingState").val();

    if (IsNullOrEmptyString(shippingCountryID)) {
        shippingCountryID = 0;
    }

    if (IsNullOrEmptyString(shippingRegionID)) {
        shippingRegionID = 0;
    }

    var isUsedRewardPoint = $("#rewardPointRadioUsed").is(":checked");

    var selectedShippingMethodName = $("#hdnSelectedShippingMethod").val();

    $("#order-confirmation-loader").show();
    var dataActionUrl = _contentRoot + "cart/GetConfirmOrderInfo";
    $.ajax({
        url: dataActionUrl,
        type: 'POST',
        data: { CountryID: shippingCountryID, RegionID: shippingRegionID, ShippingRate: shippingRate, ShippingMethodName: selectedShippingMethodName, IsRewardPointUsed: isUsedRewardPoint },
        success: function (data) {
            $("#OrderConfirmation-wraper").html("");
            $("#OrderConfirmation-wraper").html(data);

            $("#order-confirmation-loader").hide();
        }
    });
}

// THIS METHOD IS USED FOR OPEN BILLING ADDRESS PANEL BASED ON SAME ADDRESS OR NOT
function OpenBillingAddressPanel(event) {
    if ($(event.target).hasClass("checkbox")) {
        $('#chkbillsametoggle').click();
    }
}

// THIS METHOD IS USED FOR BIND FULL SHIPPING ADDRESS FROM EXISTING ADDRESS
function ShippingUserContactChange(ele) {
    var contactAddressID = $(ele).val();
    if (!IsNullOrEmptyString(contactAddressID)) {
        $("#shipping-address-loader").show();
        var dataActionUrl = _contentRoot + "cart/GetContactAddressByID";
        $.ajax({
            url: dataActionUrl,
            type: 'POST',
            data: { ContactAddressID: contactAddressID },
            success: function (data) {

                $("#txtShippingFirstName").val(data.FirstName).attr("readonly", "readonly");
                $("#txtShippingLastName").val(data.LastName).attr("readonly", "readonly");
                $("#txtShippingTelePhone").val(data.Phone).attr("readonly", "readonly");
                $("#txtShippingAddress").val(data.Address1).attr("readonly", "readonly");
                $("#ddlShippingCountry").val(data.CountryID).attr("disabled", "disabled");
                $("#ddlShippingState").attr("disabled", "disabled");
                $("#txtShippingcity").val(data.City).attr("readonly", "readonly");
                $("#txtShippingPostalCode").val(data.PostCode).attr("readonly", "readonly");

                GetRegionByCountry(data.CountryID, $("#ddlShippingState"), $("#shippingState-loader"), data.RegionID, true);

                $("#shipping-address-loader").hide();
            }
        });

    } else {

        $("#txtShippingFirstName").val("").removeAttr("readonly");
        $("#txtShippingLastName").val("").removeAttr("readonly");
        $("#txtShippingTelePhone").val("").removeAttr("readonly");
        $("#txtShippingAddress").val("").removeAttr("readonly");
        $("#ddlShippingCountry").val("").removeAttr("disabled");
        $("#ddlShippingState").val("").removeAttr("disabled");
        $("#txtShippingcity").val("").removeAttr("readonly");
        $("#txtShippingPostalCode").val("").removeAttr("readonly");

        AddressValidationAndBindPaymentMethod();

    }
}

// THIS METHOD IS USED FOR BIND FULL BILLING ADDRESS FROM EXISTING ADDRESS
function BillingUserContactChange(ele) {
    
    var contactAddressID = $(ele).val();
    if (!IsNullOrEmptyString(contactAddressID)) {
        $("#billing-address-loader").show();
        var dataActionUrl = _contentRoot + "cart/GetContactAddressByID";
        $.ajax({
            url: dataActionUrl,
            type: 'POST',
            data: { ContactAddressID: contactAddressID },
            success: function (data) {

                //$("#hdfValidAddress").val(true);
                $("#txtBillingFirstName").val(data.FirstName);//.attr("readonly", "readonly");
                $("#txtBillingLastName").val(data.LastName);//.attr("readonly", "readonly");
                $("#txtBillingTelePhone").val(data.Phone);//.attr("readonly", "readonly");
                $("#txtBillingAddress").val(data.Address1);//.attr("readonly", "readonly");
                $("#txtBillingAddress2").val(data.Address2);
                $("#txtBillingAddress3").val(data.Address3);
                $("#ddlBillingCountry").val(data.CountryID);//.attr("disabled", "disabled");
                //$("#ddlBillingState").attr("disabled", "disabled");
                $("#txtBillingcity").val(data.City);//.attr("readonly", "readonly");
                $("#txtBillingPostalCode").val(data.PostCode);//.attr("readonly", "readonly");

                GetRegionByCountry(data.CountryID, $("#ddlBillingState"), $("#billingState-loader"), data.RegionID, false);

                $("#billing-address-loader").hide();
            }
        });

    } else {

        //$("#hdfValidAddress").val(false);
        $("#txtBillingFirstName").val("").removeAttr("readonly");
        $("#txtBillingLastName").val("").removeAttr("readonly");
        $("#txtBillingTelePhone").val("").removeAttr("readonly");
        $("#txtBillingAddress").val("").removeAttr("readonly");
        $("#txtBillingAddress2").val("").removeAttr("readonly");
        $("#txtBillingAddress3").val("").removeAttr("readonly");
        $("#ddlBillingCountry").val("").removeAttr("disabled");
        $("#ddlBillingState").val("").removeAttr("disabled");
        $("#txtBillingcity").val("").removeAttr("readonly");
        $("#txtBillingPostalCode").val("").removeAttr("readonly");

    }

}

// THIS METHOD IS USED FOR BIND CASCADING REGION BASED ON BILLING COUNTRY
function BillingCountryChange(ele) {

    if (!IsNullOrEmptyString($(ele).val())) {
        GetRegionByCountry($(ele).val(), $("#ddlBillingState"), $("#billingState-loader"), 0, false);
    } else {

        $("#ddlBillingState").empty();
        $("#ddlBillingState").append($("<option/>").val('').text("--Select--"));
    }


}

// THIS METHOD IS USED FOR BIND CASCADING REGION BASED ON SHIPPING COUNTRY
function ShippingCountryChange(ele) {

    if (!IsNullOrEmptyString($(ele).val())) {
        GetRegionByCountry($(ele).val(), $("#ddlShippingState"), $("#shippingState-loader"), 0, false);
    } else {

        $("#ddlShippingState").empty();
        $("#ddlShippingState").append($("<option/>").val('').text("--Select--"));
    }

    AddressValidationAndBindPaymentMethod();
}

// Confirm & place order
function ConfirmOrder() {

    $("#payment-method-panel").removeClass('panel-error');
    var isValidAddress = $("#hdfValidAddress").val();
    if ($("#frm-checkout").valid() && isValidAddress == "true") {

        //var selectedDate = $('#OrderDateTime').data("datetimepicker").getDate();
        //var dateFormated = (parseInt(selectedDate.getMonth()) + 1) + '-' + selectedDate.getDate() + '-' + selectedDate.getFullYear() + ' ' + selectedDate.getHours() + ':' + selectedDate.getMinutes();
        //$('#hdfOrderDate').val(dateFormated);

        if ($("#divCheckoutPasswordWrapper").css("display") == "block" || !$("#divCheckoutPasswordWrapper").is(':hidden')) {
            //DisplayMessage("error", "Your email is already exists in system please login to continue");

            $("#login-error-message").show();

            $("#CheckOut-Login").click();

            $('html, body').animate({
                scrollTop: $("#CheckOut-Login").offset().top - 50
            }, 10);
            return false;
        }

        //if (IsNullOrEmptyString($("#hdnSelectedShippingMethod").val())) {
        //    $("#shippingmethod-error-message").show();

        //    $("#shipping-method-wrapper").click();
        //    $('html, body').animate({
        //        scrollTop: $("#shipping-method-wrapper").offset().top - 50
        //    }, 10);

        //    return false;
        //}

        if ($("#chkPaypalPreApproval").is(':checked') && IsNullOrEmptyString(_PaypalPreApprovalKey) && selectedPaymentMethod == 'Paypal') {

            $("#paypal-approval-key-message").empty().text("Please approve your paypal account").show();
            $("#payment-method-content").click();

            $('html, body').animate({
                scrollTop: $("#payment-method-content").offset().top - 50
            }, 10);

            return false;
        }

        if ($("#chkPaymentMethod").is(':checked') && IsNullOrEmptyString($("#CardType").val()) && selectedPaymentMethod == 'CreditCard') {

            //$("#payment-method-content").click();

            //$('html, body').animate({
            //    scrollTop: $("#payment-method-content").offset().top - 50
            //}, 10);

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

        $("#ddlShippingCountry").removeAttr("disabled");
        $("#ddlShippingState").removeAttr("disabled");

        $('#hdfStripeCardID').val($('input[name="Card"]:checked').val());

        $("#ddlBillingCountry").removeAttr("disabled");
        $("#ddlBillingState").removeAttr("disabled");

        $("#button-confirm, #btnBooking").button('loading');

        $("#frm-checkout")[0].submit();

    } else {

        if (isValidAddress == "false") {
            var postCode = $("#txtBillingPostalCode").val();
            if (IsNullOrEmptyString(postCode)) {
                ShowOperationalMessage('Please search your address.')
            } else {
                ShowOperationalMessage('The postcode you entered is outside of the area we serve.')
            }
        }

        //$('#frm-checkout .panel-collapse').each(function (index, object) {
        //    if (!$(object).hasClass('in')) {
        //        $(object).closest('.panel-default').find('.accordion-toggle').click();
        //    }
        //});

        //ScrollToTop();
        if ($('.panel-error').length > 0) {
            var errorPanel = $('.panel-error').first().attr('id')
            ScrollToElement("#"+errorPanel);
        }        

        return false;
    }
}

//FUNCTION FOR BIND THE CONTACT ADDRESS DROPDOWN FOR LOGIN USER WHILE LOGIN WITH AJAX
function GetUserAddressDropDown() {

    $("#txtShippingFirstName").val("").removeAttr("readonly");
    $("#txtShippingLastName").val("").removeAttr("readonly");
    $("#txtShippingTelePhone").val("").removeAttr("readonly");
    $("#txtShippingAddress").val("").removeAttr("readonly");
    $("#ddlShippingCountry").val("").removeAttr("disabled");
    $("#ddlShippingState").val("").removeAttr("disabled");
    $("#txtShippingcity").val("").removeAttr("readonly");
    $("#txtShippingPostalCode").val("").removeAttr("readonly");

    $("#txtBillingFirstName").val("").removeAttr("readonly");
    $("#txtBillingLastName").val("").removeAttr("readonly");
    $("#txtBillingTelePhone").val("").removeAttr("readonly");
    $("#txtBillingAddress").val("").removeAttr("readonly");
    $("#ddlBillingCountry").val("").removeAttr("disabled");
    $("#ddlBillingState").val("").removeAttr("disabled");
    $("#txtBillingcity").val("").removeAttr("readonly");
    $("#txtBillingPostalCode").val("").removeAttr("readonly");

    $("#SuggestedAddressWrapper").hide();
    $("#ShippingMethodListWrapper").hide();
    $("#default-shipping-method-message").show();
    $("#ShippingMethodList").html("");

    if (!IsNullOrEmptyString($("#hdnSelectedShippingMethod").val())) {
        $("#hdnSelectedShippingMethod").val("");
        SelectShippingMethod();
    }

    var dataActionUrl = _contentRoot + "cart/GetUserAddressDropDown";
    $.ajax({
        url: dataActionUrl,
        success: function (data) {
            //Bind Billing Contact address dropdown
            var bliingDropDownElement = $("#BillingUserContactID");
            bliingDropDownElement.empty();
            bliingDropDownElement.append($("<option/>").val('').text("--Select--"));

            var optionHtml;
            $.each(data.BillingAddressList, function () {
                optionHtml = '<option value="' + this.ID + '">' + this.Name + '</option>';
                bliingDropDownElement.append(optionHtml);
            });
            $("#billing-dropdown-wrapper").show();

            //Bind Shipping Contact address dropdown
            //var shippingDropDownElement = $("#ShippingUserContactID");
            //shippingDropDownElement.empty();
            //shippingDropDownElement.append($("<option/>").val('').text("--Select--"));

            //$.each(data.ShippingAddressList, function () {
            //    optionHtml = '<option value="' + this.ID + '">' + this.Name + '</option>';
            //    shippingDropDownElement.append(optionHtml);
            //});
            //$("#shipping-dropdown-wrapper").show();

            $("#CheckOutLogin").button('reset');


            //$("#ShippingUserContactID").val("");

            //if ($("#ShippingUserContactID option").length > 1) {

            //    $("#ShippingUserContactID").val($('#ShippingUserContactID option:eq(1)').val());
            //    $("#ShippingUserContactID").trigger("change");
            //}

            $("#BillingUserContactID").val("");
            if (!$("#chkbillsame").is(":checked")) {

                if ($("#BillingUserContactID option").length > 1) {

                    $("#BillingUserContactID").val($('#BillingUserContactID option:eq(1)').val());
                    $("#BillingUserContactID").trigger("change");

                }
            }
        },
        error: function (data) {
            $("#CheckOutLogin").button('reset');
        }
    });
}

//THIS METHOD IS USED FOR REOLAD THE REWARD POINTSC DETAILS FOR USER
function ReloadRewardsPoints() {
    var dataActionUrl = _contentRoot + "cart/GetRewardPointsForUser";
    $.ajax({
        url: dataActionUrl,
        success: function (data) {
            $("#Rewardpoint-Container").empty().html(data);
            //$(".userewardpoint").uniform();

            //$("#spaecial-order-information .panel-title a").text("Step 7: Special Information");
            $("#OrderConfirmation-wraper .panel-title a").text(" Step 4: Confirm Booking");
        },
        error: function (data) {
        }
    });
}

function GetRegionByCountry(CountryID, RegionDropDownElement, LoaderElement, SelectedRegion) {
    if (!IsNullOrEmptyString(CountryID)) {
        LoaderElement.show();

        var dataActionUrl = _contentRoot + "AddressBook/GetRegionByCountryID";
        $.ajax({
            url: dataActionUrl,
            type: 'POST',
            data: { CountryID: CountryID },
            success: function (data) {
                ///Set the option in region dropdown
                RegionDropDownElement.empty();
                RegionDropDownElement.append($("<option/>").val('').text("--Select--"));

                var optionHtml;
                $.each(data, function () {
                    optionHtml = '<option value="' + this.ID + '" data-code="' + this.ExtraInfo.trim() + '" >' + this.Name + '</option>';
                    RegionDropDownElement.append(optionHtml);
                });

                LoaderElement.hide();

                if (SelectedRegion > 0) {
                    RegionDropDownElement.val(SelectedRegion);
                }

            },
            error: function (data) {
                LoaderElement.hide();
            }
        });
    }
    else {
        RegionDropDownElement.empty();
        RegionDropDownElement.append($("<option/>").val('').text("--Select--"));
    }
}

function ParkingSpaceAvailableChange(element) {
    if ($(element).val() == "1")
        $("#dvParkingAvailable").hide();
    else
        $('#dvParkingAvailable').show();
}

function AddCouponCode(element) {

    $('#dvCouponCodeError').hide();
    $('#dvCouponCodeSuccess').hide();
    var couponCode = $("#txtCouponCode").val();

    if (!IsNullOrEmptyString(couponCode)) {

        var $btn = $(element).button('loading');
        $("#coupon-code-loader").show();
        var dataActionUrl = _contentRoot + "Cart/AddCouponToCart";

        $.ajax({
            url: dataActionUrl,
            type: "POST",
            dataType: "JSON",
            data: { CouponCode: couponCode },
            success: function (data) {
                if (data.ResultCode != "ERROR") {
                    //ShowOperationalMessage("Coupon successfully applied.");
                    //DisplayMessage("success", "Coupon successfully applied.");
                    //$('#dvCouponCodeSuccess').show();
                    $('#dvCouponCodeError').hide();
                    //$('#spnCouponCodeSuccessMessage').text('Promo code applied');
                    UpdateCartService();
                }
                else {
                    //DisplayMessage("error", data.ResultMessage);
                    //ShowOperationalMessage(data.ResultMessage);

                    $('#dvCouponCodeError').show();
                    $('#spnCouponCodeErrorMessage').text(data.ResultMessage);
                }
                $btn.button('reset');
                $("#coupon-code-loader").hide();
            },
            error: function (data) {
                $btn.button('reset');
                $("#promotional-code-loader").hide();
            }
        });

    }
}

function InitCouponCodeValidation() {

    var formElement = $("#frm-coupon-code");
    var error = $('.alert-danger', formElement);
    var success = $('.alert-success', formElement);

    formElement.validate({
        errorClass: "help-block help-block-error", // You can add help-block instead of help-inline if you like validation messages under the inputs
        errorElement: "span",
        highlight: function (element) { // hightlight error inputs
            $(element).closest('.form-group').removeClass("has-success").addClass('has-error'); // set error class to the control group
        },
        success: function (element) {
            $(element).closest('.form-group').removeClass('has-error').addClass('has-success'); // set success class to the control group
        },
        rules: {
            CouponCode: {
                required: true
            }
        },
        messages: {
            CouponCode: {
                required: "Please enter coupon code"
            }
        },
        invalidHandler: function (event, validator) {
            error.show();
        },
        submitHandler: function (formElement) {
            error.hide();
        },
        errorPlacement: function (error, element) {
            $(element).closest(".form-group").find(".help-block").remove();
            error.insertAfter(element);
        }
    });
}

function UpdateCartService() {
    var actionURL = _contentRoot + "Cart/UpdateCartServices";

    $.ajax({
        url: actionURL,
        success: function (response) {
            if (response != "ERROR") {
                $("#OrderConfirmation-wraper").empty().html(response);
                RemoveCardValidation();
            }
        }
    });
}

function NextCollapse(element) {
    setTimeout(function () {
        if (!$(element).hasClass('collapsed')) {            
            var scrollElement = $(element).attr('href');
            ScrollToElement(scrollElement);
        }
    }, 200);
}

function RemoveCardValidation() {
    if (grandTotal <= 0) {
        $('#txtCreditCardNumber').rules('remove', 'required');
        $('#txtCreditCardHolderName').rules('remove', 'required');
        $('#txtCreditCardExpiryTime').rules('remove', 'required');
        $('#txtCreditCardcvcCode').rules('remove', 'required');

        $('#payment-method').find('.panel-error').removeClass('panel-error');
        $('#payment-method').find('.has-error').removeClass('has-error');
        $('#payment-method').find('.has-success').removeClass('has-success');
        $('#payment-method').find('.help-block-error').remove();
    }
}

function AddNewCard(element) {

    $('#txtCreditCardNumber').addClass('ignore');
    $('#txtCreditCardHolderName').addClass('ignore');
    $('#txtCreditCardExpiryTime').addClass('ignore');
    $('#txtCreditCardcvcCode').addClass('ignore');

    if ($(element).val() == "-1") {
        $("#stripe_creadit-card-wrapper").slideDown('medium');

        $('#txtCreditCardNumber').removeClass('ignore');
        $('#txtCreditCardHolderName').removeClass('ignore');
        $('#txtCreditCardExpiryTime').removeClass('ignore');
        $('#txtCreditCardcvcCode').removeClass('ignore');
    }
    else {
        $("#stripe_creadit-card-wrapper").slideUp('medium');
    }
}

function ReloadPaymentMethod() {

    var ajaxUrl = _contentRoot + "Cart/GetCardDetails";
    $.ajax({
        url: ajaxUrl,
        success: function (response) {
            $("#payment-method").empty().html(response);

            new Card({
                form: document.querySelector('#frm-checkout'),
                container: '.stripe-card-wrapper'
            });
        }
    });
}