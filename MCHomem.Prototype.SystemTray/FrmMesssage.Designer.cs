namespace MCHomem.Prototype.SystemTray
{
    partial class FrmMesssage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMesssage));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerShowForm = new System.Windows.Forms.Timer(this.components);
            this.timerHideForm = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Notification service";
            this.notifyIcon.Visible = true;
            // 
            // timerShowForm
            // 
            this.timerShowForm.Tick += new System.EventHandler(this.TimerShowForm_Tick);
            // 
            // timerHideForm
            // 
            this.timerHideForm.Tick += new System.EventHandler(this.TimerHideForm_Tick);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(484, 111);
            this.panel.TabIndex = 0;
            // 
            // FrmMesssage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 111);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMesssage";
            this.ShowInTaskbar = false;
            this.Text = "Notification service";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMesssage_FormClosing);
            this.Load += new System.EventHandler(this.FrmMesssage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer timerShowForm;
        private System.Windows.Forms.Timer timerHideForm;
        private System.Windows.Forms.Panel panel;
    }
}