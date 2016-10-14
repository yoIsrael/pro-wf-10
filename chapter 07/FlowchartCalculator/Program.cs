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
using System.Activities;
using System.Collections.Generic;

namespace FlowchartCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an expression or 'quit' to exit");
                String expression = Console.ReadLine();
                if (!String.IsNullOrEmpty(expression))
                {
                    if (expression.Trim().ToLower() == "quit")
                    {
                        Console.WriteLine("Exiting program");
                        return;
                    }
                }

                FlowchartCalculator wf = new FlowchartCalculator();
                wf.ArgExpression = expression;

                try
                {
                    IDictionary<String, Object> results =
                        WorkflowInvoker.Invoke(wf);
                    Console.WriteLine("Result = {0}", results["Result"]);
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine(exception.Message.ToString());
                }
            }
        }
    }
}
