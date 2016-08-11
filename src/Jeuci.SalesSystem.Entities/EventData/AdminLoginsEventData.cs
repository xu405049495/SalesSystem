﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Events.Bus.Entities;

namespace Jeuci.SalesSystem.Entities.EventData
{
    public class AdminLoginsEventData : EntityCreatedEventData<AdminLoginHistory>
    {
        public AdminLoginsEventData(AdminLoginHistory entity) : base(entity)
        {
        }
    }
}