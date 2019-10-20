namespace Armng_Pjkt
{
    partial class Armor_Picker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armor_Picker));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.accept_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.type_l = new System.Windows.Forms.Label();
            this.avc_l = new System.Windows.Forms.Label();
            this.avp_l = new System.Windows.Forms.Label();
            this.avb_l = new System.Windows.Forms.Label();
            this.coverage_txtbox = new System.Windows.Forms.TextBox();
            this.pp_l = new System.Windows.Forms.Label();
            this.quality_textbox = new System.Windows.Forms.TextBox();
            this.wt_L = new System.Windows.Forms.Label();
            this.cost_l = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "AVP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "AVB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Coverage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Qualities:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "PP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Wt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(289, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cost:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Helmets",
            "Visors",
            "Non-Helmet Head",
            "Neck",
            "Torso",
            "Arms",
            "Legs"});
            this.comboBox.Location = new System.Drawing.Point(12, 33);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(258, 21);
            this.comboBox.TabIndex = 9;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(15, 64);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(255, 290);
            this.listBox.TabIndex = 10;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // accept_button
            // 
            this.accept_button.Location = new System.Drawing.Point(276, 326);
            this.accept_button.Name = "accept_button";
            this.accept_button.Size = new System.Drawing.Size(124, 32);
            this.accept_button.TabIndex = 11;
            this.accept_button.TabStop = false;
            this.accept_button.Text = "Add";
            this.accept_button.UseVisualStyleBackColor = true;
            this.accept_button.Click += new System.EventHandler(this.accept_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(406, 326);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(120, 32);
            this.cancel_button.TabIndex = 12;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // type_l
            // 
            this.type_l.AutoSize = true;
            this.type_l.Location = new System.Drawing.Point(330, 41);
            this.type_l.Name = "type_l";
            this.type_l.Size = new System.Drawing.Size(19, 13);
            this.type_l.TabIndex = 13;
            this.type_l.Text = "----";
            // 
            // avc_l
            // 
            this.avc_l.AutoSize = true;
            this.avc_l.Location = new System.Drawing.Point(330, 64);
            this.avc_l.Name = "avc_l";
            this.avc_l.Size = new System.Drawing.Size(19, 13);
            this.avc_l.TabIndex = 14;
            this.avc_l.Text = "----";
            // 
            // avp_l
            // 
            this.avp_l.AutoSize = true;
            this.avp_l.Location = new System.Drawing.Point(330, 86);
            this.avp_l.Name = "avp_l";
            this.avp_l.Size = new System.Drawing.Size(19, 13);
            this.avp_l.TabIndex = 15;
            this.avp_l.Text = "----";
            // 
            // avb_l
            // 
            this.avb_l.AutoSize = true;
            this.avb_l.Location = new System.Drawing.Point(330, 108);
            this.avb_l.Name = "avb_l";
            this.avb_l.Size = new System.Drawing.Size(19, 13);
            this.avb_l.TabIndex = 16;
            this.avb_l.Text = "----";
            // 
            // coverage_txtbox
            // 
            this.coverage_txtbox.Location = new System.Drawing.Point(292, 156);
            this.coverage_txtbox.Multiline = true;
            this.coverage_txtbox.Name = "coverage_txtbox";
            this.coverage_txtbox.ReadOnly = true;
            this.coverage_txtbox.Size = new System.Drawing.Size(234, 38);
            this.coverage_txtbox.TabIndex = 17;
            // 
            // pp_l
            // 
            this.pp_l.AutoSize = true;
            this.pp_l.Location = new System.Drawing.Point(319, 267);
            this.pp_l.Name = "pp_l";
            this.pp_l.Size = new System.Drawing.Size(19, 13);
            this.pp_l.TabIndex = 18;
            this.pp_l.Text = "----";
            // 
            // quality_textbox
            // 
            this.quality_textbox.Location = new System.Drawing.Point(292, 222);
            this.quality_textbox.Multiline = true;
            this.quality_textbox.Name = "quality_textbox";
            this.quality_textbox.ReadOnly = true;
            this.quality_textbox.Size = new System.Drawing.Size(234, 38);
            this.quality_textbox.TabIndex = 19;
            // 
            // wt_L
            // 
            this.wt_L.AutoSize = true;
            this.wt_L.Location = new System.Drawing.Point(319, 280);
            this.wt_L.Name = "wt_L";
            this.wt_L.Size = new System.Drawing.Size(19, 13);
            this.wt_L.TabIndex = 20;
            this.wt_L.Text = "----";
            // 
            // cost_l
            // 
            this.cost_l.AutoSize = true;
            this.cost_l.Location = new System.Drawing.Point(319, 293);
            this.cost_l.Name = "cost_l";
            this.cost_l.Size = new System.Drawing.Size(19, 13);
            this.cost_l.TabIndex = 21;
            this.cost_l.Text = "----";
            // 
            // Armor_Picker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 370);
            this.Controls.Add(this.cost_l);
            this.Controls.Add(this.wt_L);
            this.Controls.Add(this.quality_textbox);
            this.Controls.Add(this.pp_l);
            this.Controls.Add(this.coverage_txtbox);
            this.Controls.Add(this.avb_l);
            this.Controls.Add(this.avp_l);
            this.Controls.Add(this.avc_l);
            this.Controls.Add(this.type_l);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.accept_button);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Armor_Picker";
            this.Text = "Select a piece of armor...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button accept_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Label type_l;
        private System.Windows.Forms.Label avc_l;
        private System.Windows.Forms.Label avp_l;
        private System.Windows.Forms.Label avb_l;
        private System.Windows.Forms.TextBox coverage_txtbox;
        private System.Windows.Forms.Label pp_l;
        private System.Windows.Forms.TextBox quality_textbox;
        private System.Windows.Forms.Label wt_L;
        private System.Windows.Forms.Label cost_l;
    }
}