﻿using Sitecore.XConnect;

namespace Sitecore.HabitatHome.Fitness.Automation.Services
{
    public interface IEventNotificationService
    {
        void SendInitialEventNotification(Contact contact, string token);
    }
}