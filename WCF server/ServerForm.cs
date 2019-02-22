using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ServiceModel.Description;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;

namespace WCF_test
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();

            /*Test programmatically add endpoint and behavior*/
            WebHttpBehavior web_beh = new WebHttpBehavior();
            web_beh.HelpEnabled = true;
            web_beh.DefaultOutgoingRequestFormat = System.ServiceModel.Web.WebMessageFormat.Json;
            web_beh.DefaultOutgoingResponseFormat = System.ServiceModel.Web.WebMessageFormat.Json;
            web_beh.DefaultBodyStyle = System.ServiceModel.Web.WebMessageBodyStyle.Bare;

            ServiceEndpoint endpoint = host.AddServiceEndpoint("WCF_test.ITestService", new WebHttpBinding(), "http://localhost:8737/TestService/");
            endpoint.Behaviors.Add(web_beh);
        }

        private ServiceHost host = new ServiceHost(typeof(TestService));

        private void start_button_Click(object sender, EventArgs e)
        {
            if (this.host.State == CommunicationState.Created)
            {
                this.host.Open();
                this.status_label.Text = "Started at " + DateTime.Now.ToString();
            }

            //this.Invoke((MethodInvoker)delegate
            //{
            //    this.status_label.Text = "Status:";
            //});
        }
    }
}
