using Notification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.IService
{
   public interface INotiService
    {
        List<Noti> GetNotifications(int nToUserId, bool bIsgetOnlyUnread);
    }
}
