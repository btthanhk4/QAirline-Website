$(document).on("click", "a[data-confirm]", function () {
    event.preventDefault();
    var result = confirm($(this).attr("data-confirm"));
    if (result == true) {
        window.location = $(this).attr("href");
    }
})