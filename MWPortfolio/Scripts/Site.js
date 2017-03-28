//Navbar//

$(window).scroll(function () {
    if ($(window).scrollTop() > 100) {
        $('.main').addClass('sticky');
    } else {
        $('.main').removeClass('sticky');
    }
});