﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace ASPModule.Infrastructure
{
    public class DayModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication context)
        {

            context.PostMapRequestHandler += (src, args) =>
            {
                if (context.Context.Handler is IRequiresDate)   //handler identify by additional interface
                {
                    context.Context.Items["DayModule_Time"] = DateTime.Now;
                }
            };
        //  context.BeginRequest+= (src, args) => { context.Context.Items["DayModule_Time"] = DateTime.Now; }
        }
    }
}