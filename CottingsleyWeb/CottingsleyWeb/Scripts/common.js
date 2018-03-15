var ContactUsURL = '/School/ContactUs';
$(function () {
    $("#btnContactUsmodal").click(function () {
        var $buttonClicked = $(this);
        var id = $buttonClicked.attr('data-target');
        var options = { "backdrop": "static", keyboard: true };
        $.ajax({
            type: "GET",
            url: ContactUsURL,
            contentType: "application/json; charset=utf-8",
            datatype: "json",
            success: function (data) {
                $(id).find('.modal-content').html(data);
               
                $(id).modal('show');

            },
            error: function () {
                alert("Dynamic content load failed.");
            }
        });
    });
});