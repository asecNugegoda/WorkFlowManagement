

$(function () {
    $(".nav-item").click(function () {
        var currentItem = $(this);
        var menuLinks = $(".nav-item");
        menuLinks.not(currentItem).removeClass(' active');
        currentItem.addClass(' active');
    });
});
