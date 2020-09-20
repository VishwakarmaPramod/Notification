$(document).ready(function () {
    $.ajax({

        type: "GET",
        dataType: "json",
        url: "/Notifications/GetNotifications",
        traditional: true,
        contentType: "application/json;charset=uft-8",
        success: function (data) {
            var notifications = data;
            $.map(notifications, function (notification) {
                debugger;
                $('#tblNotification tbody').append("<tr>"

                    + "<td>" + notification.fromUserName + "</td>"
                    + "<td>" + notification.notiHeader + "</td>"
                    + "<td>" + notification.notiBody + "</td>"
                    + "<td>" + notification.isReadSt + "</td>"
                    + "<td>" + notification.createdDateSt + "</td>"
                    + "</tr>"
                )
            })
        }
    });
});