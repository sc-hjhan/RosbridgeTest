
namespace RosbridgeTest
{
    partial class ServiceClientWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ArgsText = new System.Windows.Forms.TextBox();
            this.CallButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.argsResultList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Argument";
            // 
            // ArgsText
            // 
            this.ArgsText.Location = new System.Drawing.Point(112, 25);
            this.ArgsText.Name = "ArgsText";
            this.ArgsText.Size = new System.Drawing.Size(100, 23);
            this.ArgsText.TabIndex = 1;
            // 
            // CallButton
            // 
            this.CallButton.Location = new System.Drawing.Point(217, 24);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(95, 23);
            this.CallButton.TabIndex = 2;
            this.CallButton.Text = "Call Service";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // argsResultList
            // 
            this.argsResultList.FormattingEnabled = true;
            this.argsResultList.ItemHeight = 15;
            this.argsResultList.Location = new System.Drawing.Point(13, 102);
            this.argsResultList.Name = "argsResultList";
            this.argsResultList.Size = new System.Drawing.Size(447, 349);
            this.argsResultList.TabIndex = 4;
            // 
            // ServiceClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 463);
            this.Controls.Add(this.argsResultList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.ArgsText);
            this.Controls.Add(this.label1);
            this.Name = "ServiceClientWindow";
            this.Text = "Service Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ServiceClientWindow_FormClosed);
            this.Load += new System.EventHandler(this.ServiceClientWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArgsText;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox argsResultList;
    }
}