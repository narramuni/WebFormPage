using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormPage
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string log = "";
        protected void Page_PreInit(object sender, EventArgs e)
        {
            log += "page_preinit()<br>";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            log += "page_init()<br>";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            log += "page_initComplete()<br>";

        }
        protected override void OnPreLoad(EventArgs e)
        {
            log += "OnPreload()<br>";

        }
        
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            log += "page_laodComplete()<br>";

        }
        protected override void OnPreRender(EventArgs e)
        {
            log += "page_prerender()<br>";

        }
        protected override void OnSaveStateComplete(EventArgs e)
        {
            log += "OnSaveStateComplete()<br>";


        }


        protected void Page_UnLoad(object sender, EventArgs e)
        {
            // nothing will be displayed once page unloads
        }


        protected override void OnLoad(EventArgs e)
        {
            // Custom code for Load stage
            base.OnLoad(e);

            // Output to console
            Console.WriteLine("Load stage");

            // Output to debug window
            System.Diagnostics.Debug.WriteLine("Load stage");

            // Output to the page (if you have a label or literal control)
            lblOutput.Text += "Load stage<br />";
        }
    }


}