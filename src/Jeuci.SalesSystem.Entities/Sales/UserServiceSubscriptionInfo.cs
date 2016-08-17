﻿using System;
using Abp.Domain.Entities;
using Abp.Runtime.Session;
using Jeuci.SalesSystem.Entities.Common.Enums;

namespace Jeuci.SalesSystem.Entities
{
    public class UserServiceSubscriptionInfo : Entity<int>
    {
        public UserServiceSubscriptionInfo()
        {
            CreateTime = DateTime.Now;
            AdminId = (int) NullAbpSession.Instance.UserId;
        }

        public int UId { get; set; }

        public int SId { get; set; }

        public decimal Cost { get; set; }

        public decimal Profit { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime AuthExpiration { get; set; }

        public string Remarks { get; set; }

        public OrderState State { get; set; }

        public int AuthType { get; set; }

        public int AgentId { get; set; }

        public int AdminId { get; set; }

        public int Puid { get; set; }

        public string OrderId { get; set; }
    }
}
