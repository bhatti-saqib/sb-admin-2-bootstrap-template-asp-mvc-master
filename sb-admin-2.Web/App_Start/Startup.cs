﻿
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sb_admin_2.Web.Startup))]


namespace sb_admin_2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}