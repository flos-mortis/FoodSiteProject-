$(document).ready(function () {
    $(".slider").slick({
        arrows:false,
        dots:true,
        speed:1500,
        autoplay:true,
        autoplaySpeed:5000,
    });
});

$(function(){
    var $button    = $('.js-button'),
        $container = $('.js-container');

    $button.on('click', function(){
        var toggleText = $(this).data('toggle-text');

        $(this).data('toggle-text', $(this).text())
            .text(toggleText);

        $container.toggleClass('hidden');
    });
});

jQuery(($) => {
    $('.select').on('click', '.select__head', function () {
        if ($(this).hasClass('open')) {
            $(this).removeClass('open');
            $(this).next().fadeOut();
        } else {
            $('.select__head').removeClass('open');
            $('.select__list').fadeOut();
            $(this).addClass('open');
            $(this).next().fadeIn();
        }
    });

    $('.select').on('click', '.select__item', function () {
        $('.select__head').removeClass('open');
        $(this).parent().fadeOut();
        $(this).parent().prev().text($(this).text());
        $(this).parent().prev().prev().val($(this).text());
    });

    $(document).click(function (e) {
        if (!$(e.target).closest('.select').length) {
            $('.select__head').removeClass('open');
            $('.select__list').fadeOut();
        }
    });
});

function priceFilter1(){
    document.getElementById("price_up1").style.border = "1px solid rgba(0, 0, 0, 0.6)";
    document.getElementById("price_up2").style.borderBottom = "12px solid #000";
    document.getElementById("price_down2").style.borderTop = "12px solid #FFFFFF";
    document.getElementById("price_down1").style.border = "none";
    document.getElementById("price_up1").style.background = "#FFFFFF";
    document.getElementById("price_down1").style.background = "rgba(254, 0, 0, 0.7)";
}

function priceFilter2(){
    document.getElementById("price_up2").style.borderBottom = "12px solid #FFFFFF";
    document.getElementById("price_down2").style.borderTop = "12px solid #000";
    document.getElementById("price_down1").style.border = "1px solid rgba(0, 0, 0, 0.6)";
    document.getElementById("price_up1").style.border = "none";
    document.getElementById("price_up1").style.background = "rgba(254, 0, 0, 0.7)";
    document.getElementById("price_down1").style.background = "#FFFFFF";
}

function viewDiv(){
    if (document.getElementById("filter2").style.display === 'flex') {
        document.getElementById("block1").style.display = "block";
        document.getElementById("block2").style.display = "none";
        document.getElementById("filter2").style.display = "none";
        document.getElementById("filter1").style.display = "flex";
    }
    else {
        document.getElementById("block2").style.display = "block";
        document.getElementById("block1").style.display = "none";
        document.getElementById("filter1").style.display = "none";
        document.getElementById("filter2").style.display = "flex";
    }
}

function viewDivTime(){
    if (document.getElementById("filter4").style.display === 'flex') {
        document.getElementById("filter4").style.display = "none";
        document.getElementById("filter3").style.display = "flex";
    }
    else {
        document.getElementById("filter3").style.display = "none";
        document.getElementById("filter4").style.display = "flex";
    }
}

function revPay(){
    if (document.getElementById("pay2").style.display === 'block') {
        document.getElementById("pay2").style.display = "none";
        document.getElementById("pay1").style.display = "block";
    }
    else {
        document.getElementById("pay1").style.display = "none";
        document.getElementById("pay2").style.display = "block";
    }
}







