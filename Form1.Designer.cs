namespace xRel
{
    partial class Releasefinder_v1
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
            this.txtb_title = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Quality = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listbox_releasetitle = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbx_number = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_title
            // 
            this.txtb_title.Location = new System.Drawing.Point(3, 16);
            this.txtb_title.MaxLength = 30;
            this.txtb_title.Name = "txtb_title";
            this.txtb_title.Size = new System.Drawing.Size(171, 20);
            this.txtb_title.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quality";
            // 
            // comboBox_Quality
            // 
            this.comboBox_Quality.FormattingEnabled = true;
            this.comboBox_Quality.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox_Quality.Items.AddRange(new object[] {
            "1080p",
            "720p"});
            this.comboBox_Quality.Location = new System.Drawing.Point(180, 16);
            this.comboBox_Quality.Name = "comboBox_Quality";
            this.comboBox_Quality.Size = new System.Drawing.Size(70, 21);
            this.comboBox_Quality.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listbox_releasetitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 301);
            this.panel1.TabIndex = 10;
            // 
            // listbox_releasetitle
            // 
            this.listbox_releasetitle.FormattingEnabled = true;
            this.listbox_releasetitle.Location = new System.Drawing.Point(3, 50);
            this.listbox_releasetitle.Name = "listbox_releasetitle";
            this.listbox_releasetitle.Size = new System.Drawing.Size(454, 251);
            this.listbox_releasetitle.TabIndex = 12;
            this.listbox_releasetitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_releasetitle_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtbx_number);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox_Quality);
            this.panel2.Controls.Add(this.txtb_title);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 42);
            this.panel2.TabIndex = 11;
            // 
            // txtbx_number
            // 
            this.txtbx_number.Location = new System.Drawing.Point(259, 16);
            this.txtbx_number.Name = "txtbx_number";
            this.txtbx_number.Size = new System.Drawing.Size(51, 20);
            this.txtbx_number.TabIndex = 9;
            this.txtbx_number.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount";
            // 
            // Releasefinder_v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 325);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Releasefinder_v1";
            this.Text = "Releasefinder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Quality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listbox_releasetitle;
        private System.Windows.Forms.TextBox txtbx_number;
        private System.Windows.Forms.Label label3;
    }
}

