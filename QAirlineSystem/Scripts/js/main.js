$(document).ready(function () {
    $("#sign-in-account").click(function () {
        $("#signInModel").modal("hide");
        $("#signUpModal").modal();
    });

    $("#sign-up-account").click(function () {
        $("#signUpModal").modal("hide");
        $("#signInModel").modal();
    });
});