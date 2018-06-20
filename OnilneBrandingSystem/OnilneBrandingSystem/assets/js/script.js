$(document).ready(function(){
    //JQuery Method Goes Here
    //BAnner Slider CodeStarts
    $('.bxslider').bxSlider({
            auto:true,
            captions:true,
            responsive:true,
            pager:false,
            infiniteLoop: true,
            touchEnabled: true
        });//BxSLider Closed
    //Banner Slide rCode Ends
    
    //FAncy box Starts
    $("a.group").fancybox({
        openEffect	: 'elastic',
    	closeEffect	: 'elastic',
		'transitionIn'	:	'elastic',
		'transitionOut'	:	'elastic',
		'speedIn'		:	600, 
		'speedOut'		:	200, 
		'overlayShow'	:	false
	});
    //Fancy Box Ends
    
    //Toggle Navigation
    jQuery (".menu-trigger").click(function(){
        jQuery(".navbar").slideToggle(400,function(){
            jQuery(this).toggleClass("nav-expanded").css('display','');
        });
    });
    
    //Toggle Navigation
    jQuery (".menu-trigger-admin").click(function(){
        jQuery(".navbar").slideToggle(400,function(){
            jQuery(this).toggleClass("nav-expanded").css('display','');
        });
    });
    
    //Password Change Drop
    //Toggle Navigation
    jQuery (".menu-trigger-drop").click(function(){
        jQuery(".toggle-box").slideToggle(400,function(){
            jQuery(this).toggleClass("drop-expanded").css('display','');
        });
    });
    //Search Tabs
    //Flight Tab
    $('.tab_content').hide();
    $('#tab_flights_content').show();
    
    $('#tab_flights').click(function(){
        $('.tab_content').hide();
        
        $('#tab_flights_content').show();
        
    });
    
    //Hotels
    $('#tab_hotels').click(function(){
        $('.tab_content').hide();
        
        $('#tab_hotels_content').show();
        
    });
    
    $('#tab_tours').click(function(){
        $('.tab_content').hide();
        
        $('#tab_tours_content').show();
        
    });
    
    //Cars
    $('#tab_car').click(function(){
        $('.tab_content').hide();
        
        $('#tab_car_content').show();
        
    });
    });//Document Ready End