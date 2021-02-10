using Rosbridge.Client;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RosbridgeTest
{
    public partial class MainWindow : Form
    {
        private MessageDispatcher _md;
        private List<IChildWindow> _childWindows = new List<IChildWindow>();
        private bool _isConnected = false;
        public MainWindow()
        {
            InitializeComponent();
            ToggleConnected();
        }
        private void ToggleConnected()
        {
            if (_isConnected)
            {
                ConnectButton.Text = "Disconnect";
                URITextBox.Enabled = false;
                PublisherButton.Enabled = true;
                SubscriberButton.Enabled = true;
                ServiceButton.Enabled = true;
            }
            else
            {
                ConnectButton.Text = "Connect";
                URITextBox.Enabled = true;
                PublisherButton.Enabled = false;
                SubscriberButton.Enabled = false;
                ServiceButton.Enabled = false;
            }
        }

        private void SubscriberButton_Click(object sender, EventArgs e)
        {
            var subscriberWindow = new SubscriberWindow(new Subscriber(subTopicText.Text, subMessageText.Text, _md));
            subscriberWindow.Show();

            _childWindows.Add(subscriberWindow);
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            if (_isConnected)
            {
                foreach (var f in _childWindows)
                {
                    await f.CleanUp();
                    (f as Form).Close();
                }
                _childWindows.Clear();

                await _md.StopAsync();
                _md = null;

                _isConnected = false;
            }
            else
            {
                try
                {
                    _md = new MessageDispatcher(new Socket(new Uri(URITextBox.Text)), new MessageSerializerV2_0());
                    await _md.StartAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "connect error");
                    _md = null;
                    return;
                }

                _isConnected = true;
            }

            ToggleConnected();
        }

        private void PublisherButton_Click(object sender, EventArgs e)
        {
            var publisherWindow = new PublisherWindow(new Publisher(pubTopicText.Text, pubMessageText.Text, _md));
            publisherWindow.Show();

            _childWindows.Add(publisherWindow);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            var serviceClientWindow = new ServiceClientWindow(new ServiceClient(serviceTopicText.Text, _md));
            serviceClientWindow.Show();

            _childWindows.Add(serviceClientWindow);
        }
    }
}
