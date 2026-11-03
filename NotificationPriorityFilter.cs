using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public class NotificationPriorityFilter : INotificationFilter
    {
        public IEnumerable<Notification> Filter(IEnumerable<Notification> notifications, NotificationFilterOptions options)
        {
            if (options.MinPriority.HasValue)
                return notifications;
            return notifications.Where(n => n.Priority >= options.MinPriority.Value);
        }
    }
}
