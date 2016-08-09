﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus.Entities;

namespace Jeuci.SalesSystem.Entities.EventData
{
    public class UserInfoIsAgentorEventData : EntityCreatedEventData<UserInfo>
    {
        public UserInfoIsAgentorEventData(UserInfo entity) : base(entity)
        {
        }

        public bool IsAgentor { get; set; }

        public AgentInfo AgentInfo { get; set; }
    }
}
