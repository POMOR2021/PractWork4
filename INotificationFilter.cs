namespace PractWork4._1
{
    public interface INotificationFilter
    {
        public IEnumerable<Notification> Filter(IEnumerable<Notification> notifications,
                                            NotificationFilterOptions options);
    }
}
