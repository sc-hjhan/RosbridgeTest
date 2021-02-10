
using Newtonsoft.Json.Linq;
using Rosbridge.Client;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RosbridgeTest
{
    public partial class PublisherWindow : Form, IChildWindow
    {
        private Publisher _publisher;

        public PublisherWindow(Publisher publisher)
        {
            InitializeComponent();
            _publisher = publisher;
        }

        private async void PublisherWindow_Load(object sender, EventArgs e)
        {
            label1.Text = "Publish to \"" + _publisher.Topic.Replace("_", "__") + "\" (" + _publisher.Type.Replace("_", "__") + ")";

            await _publisher.AdvertiseAsync();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var obj = JObject.Parse(MessageTextBox.Text);
            await _publisher.PublishAsync(obj);
        }
        public async Task CleanUp()
        {
            if (null != _publisher)
            {
                await _publisher.UnadvertiseAsync();
                _publisher = null;
            }
        }

        private async void PublisherWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CleanUp();
        }
    }

}
