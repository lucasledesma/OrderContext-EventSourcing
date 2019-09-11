﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace OrderContext.Application.Commands
{ 
    [DataContract]
    public class PayOrderCommand : IRequest
    {
        [DataMember]
        public string OrderNumber { get; }

        public PayOrderCommand(string orderNumber)
        {
            OrderNumber = orderNumber;
        }
    }
}
