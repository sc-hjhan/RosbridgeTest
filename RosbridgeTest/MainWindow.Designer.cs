
namespace RosbridgeTest
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pubTopicText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pubMessageText = new System.Windows.Forms.TextBox();
            this.PublisherButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SubscriberButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.serviceTopicText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.serviceMessageText = new System.Windows.Forms.TextBox();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.subTopicText = new System.Windows.Forms.TextBox();
            this.subMessageText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rosbridge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rosbridge Server URI";
            // 
            // URITextBox
            // 
            this.URITextBox.Location = new System.Drawing.Point(183, 60);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(315, 23);
            this.URITextBox.TabIndex = 2;
            this.URITextBox.Text = "ws://192.168.20.58:9090";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(519, 59);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(133, 23);
            this.ConnectButton.TabIndex = 3;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publish";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(51, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Topic";
            // 
            // pubTopicText
            // 
            this.pubTopicText.Location = new System.Drawing.Point(97, 142);
            this.pubTopicText.Name = "pubTopicText";
            this.pubTopicText.Size = new System.Drawing.Size(118, 23);
            this.pubTopicText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Message Type";
            // 
            // pubMessageText
            // 
            this.pubMessageText.Location = new System.Drawing.Point(330, 142);
            this.pubMessageText.Name = "pubMessageText";
            this.pubMessageText.Size = new System.Drawing.Size(168, 23);
            this.pubMessageText.TabIndex = 8;
            // 
            // PublisherButton
            // 
            this.PublisherButton.Location = new System.Drawing.Point(519, 141);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(133, 23);
            this.PublisherButton.TabIndex = 9;
            this.PublisherButton.Text = "Publisher Start";
            this.PublisherButton.UseVisualStyleBackColor = true;
            this.PublisherButton.Click += new System.EventHandler(this.PublisherButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(40, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Subscribe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(51, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Topic";
            // 
            // SubscriberButton
            // 
            this.SubscriberButton.Location = new System.Drawing.Point(519, 232);
            this.SubscriberButton.Name = "SubscriberButton";
            this.SubscriberButton.Size = new System.Drawing.Size(133, 23);
            this.SubscriberButton.TabIndex = 16;
            this.SubscriberButton.Text = "Subscriber Start";
            this.SubscriberButton.UseVisualStyleBackColor = true;
            this.SubscriberButton.Click += new System.EventHandler(this.SubscriberButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(40, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Services";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(51, 321);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Topic";
            // 
            // serviceTopicText
            // 
            this.serviceTopicText.Location = new System.Drawing.Point(97, 319);
            this.serviceTopicText.Name = "serviceTopicText";
            this.serviceTopicText.Size = new System.Drawing.Size(118, 23);
            this.serviceTopicText.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(242, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "Message Type";
            // 
            // serviceMessageText
            // 
            this.serviceMessageText.Location = new System.Drawing.Point(330, 319);
            this.serviceMessageText.Name = "serviceMessageText";
            this.serviceMessageText.Size = new System.Drawing.Size(168, 23);
            this.serviceMessageText.TabIndex = 21;
            // 
            // ServiceButton
            // 
            this.ServiceButton.Location = new System.Drawing.Point(519, 318);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(133, 23);
            this.ServiceButton.TabIndex = 22;
            this.ServiceButton.Text = "Service Client Start\r\n";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // subTopicText
            // 
            this.subTopicText.Location = new System.Drawing.Point(97, 229);
            this.subTopicText.Name = "subTopicText";
            this.subTopicText.Size = new System.Drawing.Size(118, 23);
            this.subTopicText.TabIndex = 12;
            this.subTopicText.Text = "robot_state";
            // 
            // subMessageText
            // 
            this.subMessageText.Location = new System.Drawing.Point(330, 229);
            this.subMessageText.Name = "subMessageText";
            this.subMessageText.Size = new System.Drawing.Size(168, 23);
            this.subMessageText.TabIndex = 15;
            this.subMessageText.Text = "syscon_msgs/RobotState";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(230, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Message Type";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 372);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.serviceMessageText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.serviceTopicText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SubscriberButton);
            this.Controls.Add(this.subMessageText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.subTopicText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PublisherButton);
            this.Controls.Add(this.pubMessageText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pubTopicText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.URITextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox URITextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pubTopicText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pubMessageText;
        private System.Windows.Forms.Button PublisherButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SubscriberButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox serviceTopicText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox serviceMessageText;
        private System.Windows.Forms.Button ServiceButton;
        private System.Windows.Forms.TextBox subTopicText;
        private System.Windows.Forms.TextBox subMessageText;
        private System.Windows.Forms.Label label9;
    }
}

