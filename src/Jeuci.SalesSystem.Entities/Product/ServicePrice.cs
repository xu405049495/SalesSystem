﻿using Abp.Domain.Entities;
using Jeuci.SalesSystem.Entities.Common.Enums;

namespace Jeuci.SalesSystem.Entities
{
    public class ServicePrice : Entity<int>
    {
        public int ServiceId { get; set; }

        public virtual ServiceInfo ServerInfo { get; set; }

        public decimal Price { get; set; }

        public decimal AgentPrice { get; set; }

        public int? DateYear { get; set; }

        public int DateMonth { get; set; }

        public int DateDay { get; set; }

        public string AuthDesc { get; set; }

        public int AuthType { get; set; }

        public string Description { get; set; }

        public State State { get; set; }

        public bool IsLifeLongVersion
        {
            get
            {
                //为空的时候是终身版本
                return !DateYear.HasValue;
            }
        }


    }
}
