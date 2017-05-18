$(document).ready(function () {
    $("#login").change(function () {
        $("#message").html("Logging in...");
        var data = {
            "category": $("#category").val(), 
        };
        $.ajax({
            url: "/submitAd/getCategoryItem",
            type: "POST",
            data: JSON.stringify(data),
            dataType: "json",
            contentType: "application/json",
            success: function (status) {
                $("#message").html(status.Message);
                if (status.Success)
                {
                    window.location.href = status.TargetURL;
                }
            },
            error: function () {$("#message").html("Error while authenticating user credentials!");
            }
        });
    });
});
