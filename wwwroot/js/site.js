// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    //Initialization
    $("#noti_Container").ikrNotificationSetup();
    debugger;
    $.ajax({
        type:"GET",
        dataType:"json",
        url:"/Notifications/GetNotifications",
        traditional:true,
        contentType:"application/json;charset=uft-8",
        success: function (data) {
            var notifications = data;
            $("#noti_Container").ikrNotificationCount({
                NotificationList: notifications,
                NotiFromPropName: "FromUserName",
                ListTitlePropName: "NotiHeader",
                ListBodyPropName: "NotiBody",
                ControllerName: "Notifications",
                ActionName: "AllNotifications"
            });
        },
        error: function (xhr, status, error) {

        }
    });
});
