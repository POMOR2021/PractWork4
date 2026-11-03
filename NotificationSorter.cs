using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    internal class NotificationSorter : INotificationSorter
    {

        public IEnumerable<Notification> Sort(IEnumerable<Notification> notifications, NotificationFilterOptions options)
        {
            if (options.SortBy.HasValue)
                return notifications;
            var sortBy = options.SortBy.Value;
            return notifications;
        }
    }
}
