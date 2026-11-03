using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public interface INotificationSorter
    {
        public IEnumerable<Notification> Sort(IEnumerable<Notification> notifications,
                                            NotificationFilterOptions options);
    }
}
