using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public class NotificationSearchFillter : INotificationFilter
    {
        public IEnumerable<Notification> Filter(IEnumerable<Notification> notifications, NotificationFilterOptions options)
        {
            if (!string.IsNullOrWhiteSpace(options.SearchText))
                return notifications;
            var search = options.SearchText.Trim();
            return notifications.Where(n =>
                            (!string.IsNullOrEmpty(n.Title) && n.Title.Contains(search, StringComparison.OrdinalIgnoreCase)) ||
                            (!string.IsNullOrEmpty(n.Content) && n.Content.Contains(search, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
