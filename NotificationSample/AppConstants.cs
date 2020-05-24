namespace NotificationSample
{
    public static class AppConstants
    {
        public static string NotificationChannelName { get; set; } = "XamarinNotifyChannel";
        public static string NotificationHubName { get; set; } = "[get from Azure]";
        public static string ListenConnectionString { get; set; } = "[get from Azure]";
        public static string DebugTag { get; set; } = "XamarinNotify";
        public static string[] SubscriptionTags { get; set; } = { "default" };
        public static string FCMTemplateBody { get; set; } = "{\"data\":{\"message\":\"$(messageParam)\"}}";
        public static string APNTemplateBody { get; set; } = "{\"aps\":{\"alert\":\"$(messageParam)\"}}";
    }
}