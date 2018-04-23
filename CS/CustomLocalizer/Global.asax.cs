using System;

namespace CustomLocalizer {

    public class Global : System.Web.HttpApplication {

        protected void Application_Start(object sender, EventArgs e) {
            MyWebLocalizer.Activate();
            MyEditorsLocalizer.Activate();
            MyGridLocalizer.Activate();
        }

    }
}