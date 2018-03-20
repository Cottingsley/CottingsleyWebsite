var URLs = {
    ContactUs: '/School/ContactUs',
    Registration: '/School/Registration'
};
$(function () {
    $("#btnContactUsmodal,#btnDemo").click(function () {
        var $buttonClicked = $(this);
        var id = $buttonClicked.attr('data-target');
        var options = { "backdrop": "static", keyboard: true };
        $.ajax({
            type: "GET",
            url: URLs.ContactUs,
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
var registrationSubmitClick = function () {
    var $submitButton = $(this);
    var $form = $("#registrationForm");
    var $thankyouModal = $("#subscribe-modal");
    var $registrationModal = $("#contact-us-modal");
    var d = {
        "Name": $form.find("#Name").val(),
        "SchoolName": $form.find("#SchoolName").val(),
        "Designation": $form.find("#Designation").val(),
        "SchoolLocation": $form.find("#SchoolLocation").val(),
        "Telephone": $form.find("#Telephone").val(),
        "EmailAddress": $form.find("#EmailAddress").val()
    }
    $.post(URLs.Registration,d,
    function (data, status) {
        $registrationModal.modal("hide");
        $thankyouModal.css("display","block").modal("show");
    });
}