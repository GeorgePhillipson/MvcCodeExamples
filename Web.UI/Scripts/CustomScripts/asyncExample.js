$(document).ready(function () {
    $("#param").on("change", function (e) {
        e.preventDefault();
        $("#ajaxFindDetails").hide();
        $("#ajaxFindDetails").html("");
        jQuery.ajax({
            url: "/AsyncExample/Result",
            type: "POST",
            data: { 'param': $("#param").val() },

            success: function (result) {
                if (result.Confirm) {
                    $("#ajaxFindDetails").append(result.message).show();
                } else {
                    $("#ajaxFindDetails").append(result.message).show();
                }
            },
            error: function () {
                $("#ajaxFindDetails").html("Failed to find details");
            }
        });
    });
});