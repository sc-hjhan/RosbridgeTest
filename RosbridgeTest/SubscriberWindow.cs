using Rosbridge.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosbridgeTest
{
    public partial class SubscriberWindow : Form, IChildWindow
    {
        private Subscriber _subscriber;
        public SubscriberWindow(Subscriber subscriber)
        {
            InitializeComponent();
            _subscriber = subscriber;
        }

        public async Task CleanUp()
        {
            if (null != _subscriber)
            {
                _subscriber.MessageReceived -= _subscriber_MessageReceived;
                await _subscriber.UnsubscribeAsync();
                _subscriber = null;
            }
        }

        private async void SubscriberWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "Subscribe to \"" + _subscriber.Topic.Replace("_", "__") + "\" (" + _subscriber.Type.Replace("_", "__") + ")";
            _subscriber.MessageReceived += _subscriber_MessageReceived;
            await _subscriber.SubscribeAsync();
        }

        private void _subscriber_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            var message = e.Message;
            string tmp = e.Message["msg"].ToString();

            if (this.listBox1.InvokeRequired == true)
                this.listBox1.Invoke((MethodInvoker)delegate
                {
                    listBox1.Items.Add(tmp);
                });
        }

        private async void SubscriberWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CleanUp();
        }
    }
}
