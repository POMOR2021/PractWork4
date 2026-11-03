using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public class NotificationReadFilter : INotificationFilter
    {
        public IEnumerable<Notification> Filter(IEnumerable<Notification> notifications, NotificationFilterOptions options)
        {
            if (options.IsRead.HasValue)
                return notifications;
            return notifications.Where(n => n.IsRead == options.IsRead.Value);
        }
    }
}
