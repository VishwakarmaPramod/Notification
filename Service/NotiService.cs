using Dapper;
using Notification.Common;
using Notification.IService;
using Notification.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.Service
{
    public class NotiService : INotiService
    {

        List<Noti> _oNotifications = new List<Noti>();
        public List<Noti> GetNotifications(int nToUserId, bool bIsgetOnlyUnread)
        {
            _oNotifications = new List<Noti>();
            using (IDbConnection con= new SqlConnection(Global.ConnectionString))
            {
                if (con.State == ConnectionState.Closed) con.Open();

                var oNotis = con.Query<Noti>("SELECT * FROM View_Notification WHERE ToUserId=" + nToUserId).ToList();
                if (oNotis!=null && oNotis.Count>0)
                {
                    _oNotifications = oNotis;
                }
                return _oNotifications;
            }
        }
    }
}
