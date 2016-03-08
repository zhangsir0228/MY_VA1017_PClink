namespace WindowsFormsApplication2
{
    partial class ComSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComSet));
            this.labelInterval = new System.Windows.Forms.Label();
            this.lableCOM = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar_interval = new System.Windows.Forms.TrackBar();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelInterval.Location = new System.Drawing.Point(13, 13);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(70, 14);
            this.labelInterval.TabIndex = 0;
            this.labelInterval.Text = "Interval:";
            // 
            // lableCOM
            // 
            this.lableCOM.AutoSize = true;
            this.lableCOM.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lableCOM.Location = new System.Drawing.Point(33, 81);
            this.lableCOM.Name = "lableCOM";
            this.lableCOM.Size = new System.Drawing.Size(35, 14);
            this.lableCOM.TabIndex = 1;
            this.lableCOM.Text = "COM:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar_interval
            // 
            this.trackBar_interval.Location = new System.Drawing.Point(86, 12);
            this.trackBar_interval.Maximum = 120;
            this.trackBar_interval.Minimum = 1;
            this.trackBar_interval.Name = "trackBar_interval";
            this.trackBar_interval.Size = new System.Drawing.Size(417, 45);
            this.trackBar_interval.TabIndex = 4;
            this.trackBar_interval.Value = 2;
            this.trackBar_interval.ValueChanged += new System.EventHandler(this.trackBar_interval_ValueChanged);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(86, 80);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(69, 20);
            this.comboBoxCOM.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "S";
            // 
            // ComSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 162);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.trackBar_interval);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lableCOM);
            this.Controls.Add(this.labelInterval);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComSet";
            this.Text = "ComSet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComSet_FormClosing);
            this.Load += new System.EventHandler(this.ComSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label lableCOM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar_interval;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}