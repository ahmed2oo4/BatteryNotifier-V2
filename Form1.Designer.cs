namespace BatteryNotifier
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDownPlugIn;
        private System.Windows.Forms.NumericUpDown numericUpDownRemoveCharger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDownPlugIn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRemoveCharger = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlugIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveCharger)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();

            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = System.Drawing.SystemIcons.Information;
            this.notifyIcon1.Text = "Battery Notifier";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // 
            // numericUpDownPlugIn
            // 
            this.numericUpDownPlugIn.Location = new System.Drawing.Point(170, 20);
            this.numericUpDownPlugIn.Name = "numericUpDownPlugIn";
            this.numericUpDownPlugIn.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownPlugIn.TabIndex = 0;
            this.numericUpDownPlugIn.Value = 20;

            // 
            // numericUpDownRemoveCharger
            // 
            this.numericUpDownRemoveCharger.Location = new System.Drawing.Point(170, 60);
            this.numericUpDownRemoveCharger.Name = "numericUpDownRemoveCharger";
            this.numericUpDownRemoveCharger.Size = new System.Drawing.Size(60, 22);
            this.numericUpDownRemoveCharger.TabIndex = 1;
            this.numericUpDownRemoveCharger.Value = 80;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plug in Threshold (%):";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remove Charger (%):";

            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(80, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start Monitoring";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 150);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownRemoveCharger);
            this.Controls.Add(this.numericUpDownPlugIn);
            this.Name = "Form1";
            this.Text = "Battery Notifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);

            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlugIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRemoveCharger)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
