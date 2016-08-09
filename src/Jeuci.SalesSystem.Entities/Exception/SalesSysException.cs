﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Abp;

namespace Jeuci.SalesSystem.Entities.Exception
{
    public class SalesSysException : AbpException
    {
        public SalesSysException()
        {
        }

        public SalesSysException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {
        }

        /// <summary>
        /// Creates a new <see cref="T:Abp.AbpException" /> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public SalesSysException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="T:Abp.AbpException" /> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public SalesSysException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
