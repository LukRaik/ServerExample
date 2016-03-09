namespace ServerDrawOnline
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_send = new System.Windows.Forms.Button();
            this.tx_send = new System.Windows.Forms.TextBox();
            this.num_port = new System.Windows.Forms.NumericUpDown();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.tx_log = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.users_list = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.UserSeeker = new System.ComponentModel.BackgroundWorker();
            this.PackageSender = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(6, 20);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_send);
            this.tabPage1.Controls.Add(this.tx_send);
            this.tabPage1.Controls.Add(this.num_port);
            this.tabPage1.Controls.Add(this.bt_stop);
            this.tabPage1.Controls.Add(this.bt_start);
            this.tabPage1.Controls.Add(this.tx_log);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(648, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serwer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(308, 6);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(72, 21);
            this.bt_send.TabIndex = 6;
            this.bt_send.Text = "Wyslij";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // tx_send
            // 
            this.tx_send.Location = new System.Drawing.Point(6, 6);
            this.tx_send.Name = "tx_send";
            this.tx_send.Size = new System.Drawing.Size(296, 20);
            this.tx_send.TabIndex = 5;
            // 
            // num_port
            // 
            this.num_port.Location = new System.Drawing.Point(580, 6);
            this.num_port.Maximum = new decimal(new int[] {
            6543,
            0,
            0,
            0});
            this.num_port.Name = "num_port";
            this.num_port.Size = new System.Drawing.Size(62, 20);
            this.num_port.TabIndex = 4;
            this.num_port.Value = new decimal(new int[] {
            1243,
            0,
            0,
            0});
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(483, 6);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(91, 21);
            this.bt_stop.TabIndex = 3;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(386, 6);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(91, 21);
            this.bt_start.TabIndex = 2;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // tx_log
            // 
            this.tx_log.Location = new System.Drawing.Point(3, 33);
            this.tx_log.Name = "tx_log";
            this.tx_log.Size = new System.Drawing.Size(642, 302);
            this.tx_log.TabIndex = 0;
            this.tx_log.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.users_list);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(648, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // users_list
            // 
            this.users_list.FormattingEnabled = true;
            this.users_list.Location = new System.Drawing.Point(356, 9);
            this.users_list.Name = "users_list";
            this.users_list.Size = new System.Drawing.Size(278, 316);
            this.users_list.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(648, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(648, 341);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(648, 341);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(648, 341);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // UserSeeker
            // 
            this.UserSeeker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UserSeeker_DoWork);
            this.UserSeeker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.UserSeeker_RunWorkerCompleted);
            // 
            // PackageSender
            // 
            this.PackageSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PackageSender_DoWork);
            this.PackageSender.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.PackageSender_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 390);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Serwer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_port)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox tx_log;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.TextBox tx_send;
        private System.Windows.Forms.NumericUpDown num_port;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.ListBox users_list;
        private System.ComponentModel.BackgroundWorker UserSeeker;
        private System.ComponentModel.BackgroundWorker PackageSender;


    }
}

