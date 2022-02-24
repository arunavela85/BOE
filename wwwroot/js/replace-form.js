function replaceForm(event) {
    console.log("siva");
    event.preventDefault();
    var form = event.target;
    console.log("aruna");
    console.log($(form).serialize());

    $.ajax({
        method: "POST",
        url: form.action,
        data: $(form).serialize(),
        success: function (data) {
            $(form).replaceWith(data);
        }
    });
}