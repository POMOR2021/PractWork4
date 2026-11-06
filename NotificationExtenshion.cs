namespace PractWork4._1
{
    class NotificationExtenshion
    {
        public IEnumerable<Notification> FilterAndSort(IEnumerable<Notification> notifications,
                                            NotificationFilterOptions options)
        {
            if (notifications == null)
                throw new ArgumentNullException(nameof(notifications));

            var query = notifications.AsQueryable();

            if (options == null)
                return query;

            if (options.Types != null && options.Types.Length > 0)
                query = query.Where(n => options.Types.Contains(n.Type));

            if (options.MinPriority.HasValue)
                query = query.Where(n => n.Priority >= options.MinPriority.Value);

            if (!string.IsNullOrWhiteSpace(options.SearchText))
            {
                var search = options.SearchText.Trim();
                query = query.Where(n =>
                                (!string.IsNullOrEmpty(n.Title) && n.Title.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                                (!string.IsNullOrEmpty(n.Content) && n.Content.Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            if (options.IsRead.HasValue)
                query = query.Where(n => n.IsRead == options.IsRead.Value);

            if (options.SortBy.HasValue)
                query = options.SortBy.Value switch
                {
                    SortNotificationBy.Date => options.Descending ? query.OrderByDescending(n => n.CreatedAt) : query.OrderBy(n => n.CreatedAt),
                    SortNotificationBy.Title => options.Descending ? query.OrderByDescending(n => n.Title) : query.OrderBy(n => n.Title),
                    SortNotificationBy.Priority => options.Descending ? query.OrderByDescending(n => n.Priority) : query.OrderBy(n => n.Priority),
                    _ => query
                };
            return query.ToList();
        }
    }
}
