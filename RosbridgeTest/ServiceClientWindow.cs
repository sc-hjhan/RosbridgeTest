using Newtonsoft.Json.Linq;
using Rosbridge.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosbridgeTest
{
    public partial class ServiceClientWindow : Form, IChildWindow
    {
        private ServiceClient _serviceClient;
        delegate void ctrl_Invoke(String message, String Netmessage);
        public ServiceClientWindow(ServiceClient serviceClient)
        {
            InitializeComponent();
            _serviceClient = serviceClient;
        }

        public Task CleanUp()
        {
            if (null != _serviceClient)
            {
                _serviceClient = null;
            }
            return Task.Delay(0);
        }

        private void ServiceClientWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "Service: \"" + _serviceClient.Service.Replace("_", "__") + "\"";
        }

        private async void ServiceClientWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CleanUp();
        }

        private async void CallButton_Click(object sender, EventArgs e)
        {
            JArray argsList = JArray.Parse(ArgsText.Text);

            var result = await _serviceClient.Call(argsList.ToObject<List<dynamic>>());
            if (result != null)
            {
                argsResultList.Items.Add(result.ToString());
            }
        }
    }
}
