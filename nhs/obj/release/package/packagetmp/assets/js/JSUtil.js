// Numeric only control handler
jQuery.fn.ForceNumericOnly =
function () {
    return this.each(function () {
        $(this).keydown(function (e) {
            var key = e.charCode || e.keyCode || 0;
            // allow backspace, tab, delete, arrows, numbers and keypad numbers ONLY
            // home, end, period, and numpad decimal
            return (
                key == 8 ||
                key == 9 ||
                key == 46 ||
                key == 110 ||
                key == 190 ||
                (key >= 35 && key <= 40) ||
                (key >= 48 && key <= 57) ||
                (key >= 96 && key <= 105));
        });
    });
};

jQuery.fn.ForceNumericOnlyWithoutPeriod =
function () {
    return this.each(function () {
        $(this).keydown(function (e) {
            var key = e.charCode || e.keyCode || 0;
            // allow backspace, tab, delete, arrows, numbers and keypad numbers ONLY
            // home, end, period, and numpad decimal

            return (
                key == 8 ||
                key == 9 ||
                key == 46 ||
                //key == 110 ||
                //key == 190 ||
                (key >= 35 && key <= 40) ||
                (key >= 48 && key <= 57) ||
                (key >= 96 && key <= 105));
        });
    });
};


jQuery.fn.ForceTextOnly =
function () {
    return this.each(function () {
        $(this).keydown(function (e) {
            var key = e.charCode || e.keyCode || 0;
            // allow backspace, tab, delete, arrows, numbers and keypad numbers ONLY
            // home, end, period, and numpad decimal
            return (
                key == 8 ||
                key == 9 ||
                key == 32 ||
                key == 35 ||
                key == 36 ||
                key == 46 ||
                key == 37 ||
                key == 39 ||
                key == 110 ||
                key == 190 ||
                (key >= 48 && key <= 57) ||
                (key >= 97 && key <= 122) ||
                (key >= 65 && key <= 90) ||
                (key >= 96 && key <= 105));
        });
    });
};

function IsNullOrEmptyString(e) {
    e = $.trim(e);

    switch (e) {
        case "":
        case 0:
        case "0":
        case null:
        case false:
        case typeof this == "undefined":
            return true;
        default: return false;
    }
}

function ScrollToTop() {
    $('html, body').animate({ scrollTop: $('body').position().top }, 'slow');
}


function ValidateEmail(email) {
    var expr = /^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$/;
    return expr.test(email);
};

function IsValidURL(pValue) {
    return /^(https?|ftp):\/\/(((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:)*@@)?(((\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5])\.(\d|[1-9]\d|1\d\d|2[0-4]\d|25[0-5]))|((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?)(:\d*)?)(\/((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@@)+(\/(([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@@)*)*)?)?(\?((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@@)|[\uE000-\uF8FF]|\/|\?)*)?(\#((([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(%[\da-f]{2})|[!\$&'\(\)\*\+,;=]|:|@@)|\/|\?)*)?$/i.test(pValue);
}

jQuery.fn.ForceCharecterOnly =
function () {
    return this.each(function () {
        $(this).keydown(function (e) {

            var key = e.keyCode;
            /* return (
             key == 8 ||
             key == 9 ||
             key == 46 ||
             key == 110 ||
             key == 190 ||
             (key >= 33 && key <= 47) ||
             (key >= 58 && key <= 126));*/
            if (e.Shiftkey || e.altKey) {
                e.preventDefault();
            }
            if ((key >= 48 && key <= 57) || (key >= 96 && key <= 105)) {
                return false;
            }


        });
    });
};

jQuery.fn.ForcePassword =
function () {
    return this.each(function () {
        $(this).keydown(function (e) {
            var key = e.charCode || e.keyCode || 0;

            if (e.Shiftkey || e.altKey) {
                e.preventDefault();
            }


            return (
                key == 8 ||
                key == 9 ||
                key == 110 ||
                (key >= 35 && key <= 40) ||
                (key >= 48 && key <= 57) ||
                (key >= 96 && key <= 105) ||
                 (key >= 65 && key <= 90));
        });
    });
};

function ScrollTopAnimate() {
  var animate =   $('body,html').animate({
        scrollTop: 0
  }, 800);

  return animate;
}

function ScrollToElement(element) {
    $('html, body').animate({ scrollTop: $(element).position().top }, 800);
}

//$.validator.addMethod('filesize', function (value, element, param) {
//    return this.optional(element) || (element.files[0].size <= param)
//}, 'video should be of 4MB in size');