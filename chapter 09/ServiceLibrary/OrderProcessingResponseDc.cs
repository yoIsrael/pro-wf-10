﻿//--------------------------------------------------------------------------------
// This file is part of the downloadable code for the Apress book:
// Pro WF: Windows Workflow in .NET 4.0
// Copyright (c) Bruce Bukovics.  All rights reserved.
//
// This code is provided as is without warranty of any kind, either expressed
// or implied, including but not limited to fitness for any particular purpose. 
// You may use the code for any commercial or noncommercial purpose, and combine 
// it with your own code, but cannot reproduce it in whole or in part for 
// publication purposes without prior approval. 
//--------------------------------------------------------------------------------      
using System;
using System.Runtime.Serialization;

namespace ServiceLibrary
{
    [DataContract]
    public class OrderProcessingResponseDc
    {
        [DataMember]
        public Int32 OrderId { get; set; }
        [DataMember]
        public DateTime ShipDate { get; set; }
        [DataMember]
        public String CreditAuthCode { get; set; }
        [DataMember]
        public Boolean IsSuccessful { get; set; }
    }
}