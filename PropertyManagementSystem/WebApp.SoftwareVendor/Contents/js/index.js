(function($, window, document) {

    "use strict"; // a stric mode 

    // initiall functions  ...
    var tp_obj = {

        menu_animation: function() {
            // menu animation  ............

            $(".tp-menu").on({
                mouseenter: function() {
                    var _this = $(this);

                    if (_this.parents(".tp-mainmenu-mobile").length !== 1) {
                        if (_this.hasClass("has-sub")) {
                            _this.addClass("tagpoint_menu_active");
                            _this.find(">ul.sub-menu").slideDown(200);
                        }
                    }

                },
                mouseleave: function() {
                    var _this = $(this);

                    if (_this.parents(".tp-mainmenu-mobile").length !== 1) {
                        if (_this.hasClass("has-sub")) {
                            _this.removeClass("tagpoint_menu_active");
                            _this.find(">ul.sub-menu").slideUp(0);
                        }
                    }
                }

            }, ".tagpoint-main-menu li.has-sub");
        },

        sticky_header: function() {
            var header = $('body').find('.tp-main-menu');
            if (header.hasClass("sticky-header")) {

                var headerscroll = $(window).scrollTop();

                if (headerscroll >= 230) {
                    if (header.hasClass("header-menu-1")) {
                        header.addClass("tp-fixed-nav-1");
                        header.find(".tp-menu-1").addClass("tp-fixed-menu-1");
                        //jQuery(".supMmain_menu ").fadeIn();
                    } else if (header.hasClass("header-menu-3")) {

                        header.addClass("tp-fixed-nav-3");
                        header.find(".tp-menu-2").addClass("tp-fixed-menu-3");

                    }

                } else {

                    if (header.hasClass("header-menu-1")) {
                        header.removeClass("tp-fixed-nav-1");
                        header.find(".tp-menu-1").removeClass("tp-fixed-menu-1");
                        //jQuery(".header-menu-2").fadeIn();
                    } else if (header.hasClass("header-menu-3")) {
                        header.removeClass("tp-fixed-nav-3");
                        header.find(".tp-menu-2").removeClass("tp-fixed-menu-3");

                    }
                }

            }
        },

        search_popup: function() {


            // search pupup form
            $(".tp-main-menu").on("click", ".tp-seachicon-icon", function(e) {
                var _this = $(this);
                e.preventDefault();

                if (_this.hasClass("tagpoint_search_active")) {
                    _this.removeClass("tagpoint_search_active");
                    _this.removeClass("bx-x").addClass("bx-search");
                    _this.next(".search-content").slideUp(100);
                    return false;
                } else {
                    _this.addClass("tagpoint_search_active")
                    _this.next(".search-content").slideDown(200);
                    _this.removeClass("fa-search").addClass("bx-x");
                    _this.find("#lns-search").trigger("focus");
                    return false;
                }
            });

            // close search popup
            $(document).on("click", "body", function(e) {
                if ($(".tagpoint_search_active").length) {
                    var search_icon = $(".tp-seachicon-icon");

                    if ($(e.target).parents(".search-content").length === 1 || $(e.target).hasClass("search-content")) {

                        if ($(e.target).hasClass("tp_close_search_icon")) {
                            $(".search-content").slideUp(100);
                            search_icon.removeClass("tagpoint_search_active");
                            search_icon.removeClass("bx-x").addClass("bx-search");
                        }


                    } else {

                        $(".search-content").slideUp(100);
                        search_icon.removeClass("tagpoint_search_active");
                        search_icon.removeClass("bx-x").addClass("bx-search");
                    }
                }

            });


        },

        tp_accordein: function() {
            // FQA toggle - accorrdein

            $(".faq-wrap-list").on("click", ".faq-wrap-head", function() {
                var $this = $(this);
                jQuery(".faq-wrap-text").find(".faq-toggle-icon").removeClass("faq-icon-open")
                $this.children(".faq-toggle-icon").addClass("faq-icon-open");
                if ($this.next(".faq-wrap-para").hasClass("faq-open")) {
                    $this.next(".faq-wrap-para").removeClass("faq-open").slideUp();
                    $this.children(".faq-toggle-icon").removeClass("faq-icon-open");
                    $this.find(".bx").removeClass("bx-chevron-down").addClass("bx-chevron-up");
                } else {
                    $(".faq-wrap-head").find(".bx").removeClass("bx-chevron-up").addClass("bx-chevron-down");
                    $this.find(".bx").removeClass("bx-chevron-down").addClass("bx-chevron-up");
                    $(".faq-wrap-text").find(".faq-wrap-para").slideUp().removeClass("faq-open");

                    $this.next(".faq-wrap-para").addClass("faq-open").slideDown();
                }
            });

        },
        tp_ajax: function(data) {
            return $.ajax({
                type: "POST",
                url: "php/contact-form.php",
                data: data
            });
        },

        phone_menu: function() {
            // phone menu ==========
            // 
            $(".tp-main-menu ").on("click", ".phone_menu", function(e) {

                var item = $(this);



                item.toggleClass("ltm_icon_active");



                if (!item.hasClass("ltm_icon_active")) {

                    item.find("i").removeClass("bx-x").addClass("bx-menu");

                    item.closest(".tp-main-menu").find(".tp-menu").removeClass("tp-mainmenu-mobile");
                } else {

                    item.find("i").removeClass("bx-menu").addClass("bx-x");
                    item.closest(".tp-main-menu").find(".tp-menu").addClass("tp-mainmenu-mobile")
                }


            });

            $(document).on("click", "body", function(e) {
                var $_this = $(this);

                if ($(e.target).parents(".tp-menu").length === 1 || $(e.target).parents(".tagpoint-wrap-logo").length === 1 || $(e.target).parents(".tp-main-menu").length === 1) {


                } else {


                    $_this.find(".tp-menu").removeClass("tp-mainmenu-mobile");
                    $_this.find(".phone_menu").removeClass("ltm_icon_active");
                    $_this.find(".phone_menu i").removeClass("bx-x").addClass("bx-menu");

                }

            });

            //phone dropdown 

            $(".tp-main-menu").on("click", ".tp_phone_dropdown", function(e) {


                var _this = $(this);
                if (_this.hasClass("active")) {
                    _this.removeClass("bx-chevron-up").removeClass("active").addClass("bx-chevron-down");
                    _this.closest("li.has-sub").find(">ul").slideUp("fast");

                } else {
                    _this.addClass("active").addClass("bx-chevron-up").removeClass("bx-chevron-down");
                    _this.closest("li.has-sub").find(">ul").slideDown("fast");

                }

            });
        }

    }


    // Dom Ready Function

    jQuery(document).ready(function() {
        (function($) {

            tp_obj.menu_animation();
            tp_obj.search_popup();
            tp_obj.tp_accordein();
            tp_obj.phone_menu();

            // counter  

            window.odometerOptions = {
                format: "d",
                selector: ".tp-counter"
            };

            var item = jQuery("body").find(".tp-counter");
            item.each(function(index, el) {
                var _this = jQuery(this);
                var max_value = _this.attr("data-to");
                max_value = parseInt(max_value, 10);

                _this.appear(function() {

                    _this.html(max_value);

                });


            });


            // ajax contact form

            $("body").on("submit", "#tp-form", function(event) {
                // cancels the form submission
                event.preventDefault();
                var form = $(this);
                var data = form.serialize();

                var validated = true;
                form.find("input[required=true],textarea[required=true]").each(function() {

                    if (!jQuery.trim(jQuery(this).val())) { //if this field is empty
                        jQuery(this).css("border-color", "red"); //change border color to red  
                        validated = false; //set do not proceed flag
                    }
                    //check invalid email
                    var pattren = /^\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b$/i;
                    if (jQuery(this).attr("type") == "email" && !pattren.test(jQuery.trim(jQuery(this).val()))) {
                        jQuery(this).css("border-color", "red"); //change border color to red  
                        validated = false; //set do not proceed flag             
                    }
                });

                if (validated) {

                    tp_obj.tp_ajax(data).done(function(text) {
                        form.find(".tpsend-btn").after("<p class='msg_feadback'> " + text + "</p> ");
                    });

                }


            });




        })(jQuery);
    });

    // on window scroll sticky header function 
    $(window).on("scroll", function() {

        tp_obj.sticky_header();

    });

    /* perload fuction */

    $(window).on("load", function() {

        var item = $("body").find(".tp-per-load");

        if (item.length) {
            item.delay(200).fadeOut("slow");
            item.css("visibility", "hidden");

        }

    });

    // end of use strict function

}(window.jQuery, window, document));