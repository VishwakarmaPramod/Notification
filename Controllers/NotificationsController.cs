using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Notification.IService;
using Notification.Models;

namespace Notification.Controllers
{
    public class NotificationsController : Controller
    {
        private readonly INotiService notiService;
        List<Noti> _oNotifications = new List<Noti>();

        public NotificationsController(INotiService notiService)
        {
            this.notiService = notiService;
        }
        public IActionResult AllNotifications()
        {
            return View();
        }

        public JsonResult GetNotifications(bool bIsGetOnlyUnread=false)
        {
            int nToUserId = 3;
            _oNotifications = new List<Noti>();
            _oNotifications = notiService.GetNotifications(nToUserId,bIsGetOnlyUnread);
            return Json(_oNotifications);
        }
    }
}
