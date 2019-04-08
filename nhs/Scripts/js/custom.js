// JavaScript Document
$(document).ready(function(e) {
    handleBrowser();
	$('.input_datepicker').datepicker({
		autoclose: true,
		todayHighlight: true,
		dateFormat: 'dd-mm-yy'
	});
});
//Theme loader
$(window).on("load", function() {
      $("#loader-wrapper").fadeOut();
	  $("#loader").delay(400).fadeOut("slow");
});

function handleBrowser(){//for handle ie browser
	var appVersion = navigator.appVersion, root = $('html');
	var clas= $('p.class')
	if(appVersion.indexOf("MSIE 6.") !== -1){root.addClass('ie ltie11 ltie10 ltie9 ltie8 ltie7 ie6'); clas.text('Browser is ie6'); } 
	if(appVersion.indexOf("MSIE 7.") !== -1){root.addClass('ie ltie11 ltie10 ltie9 ltie8 ie7'); clas.text('Browser is ie7'); } 
	if(appVersion.indexOf("MSIE 8.") !== -1){root.addClass('ie ltie11 ltie10 ltie9 ie8'); clas.text('Browser is ie8');} else
	if(appVersion.indexOf("MSIE 9.") !== -1){root.addClass('ie ltie11 ltie10 ie9'); clas.text('Browser is ie9');} else
	if(appVersion.indexOf("MSIE 10.")!== -1){root.addClass('ie ltie11 ie10'); clas.text('Browser is ie10');} else
	if(appVersion.indexOf("MSIE 11.")!== -1){root.addClass('ie ie11'); clas.text('Browser is ie11');}
}