﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace Jeuci.SalesSystem.Entities
{
    public class AgentInfo: Entity
    {
        public AgentInfo()
        {
            UserId = Id;
        }

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }

        public int State { get; set; }

        public decimal Discount { get; set; }

        public string AgentType { get; set; }

        public string AuthType { get; set; }

        public string Website { get; set; }

    }
}
