using System;
using System.Collections.Generic;
using System.Text;

namespace PractWork4._1
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Content { get; set; }
        public NotificationType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Priority { get; set; }
        public bool IsRead { get; set; }
    }

    public enum NotificationType
    {
        Info,
        Warning,
        Error,
        System
    }
}
