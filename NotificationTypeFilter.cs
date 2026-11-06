using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public class NotificationTypeFilter : INotificationFilter
    {
        public IEnumerable<Notification> Filter(IEnumerable<Notification> notifications, NotificationFilterOptions options)
        {
            if (options.Types != null || options.Types.Length > 0)
                return notifications;
            return notifications.Where(n => options.Types.Contains(n.Type));
        }
    }
}
