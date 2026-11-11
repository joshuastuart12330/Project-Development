namespace AssetTrackingPrototype
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSystemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.Label();
            this.txtAssetType = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Scan Hardware";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSystemName
            // 
            this.txtSystemName.AutoSize = true;
            this.txtSystemName.Location = new System.Drawing.Point(62, 60);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(35, 13);
            this.txtSystemName.TabIndex = 6;
            this.txtSystemName.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Asset Details";
            // 
            // txtModel
            // 
            this.txtModel.AutoSize = true;
            this.txtModel.Location = new System.Drawing.Point(62, 102);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(36, 13);
            this.txtModel.TabIndex = 8;
            this.txtModel.Text = "Model";
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.AutoSize = true;
            this.txtManufacturer.Location = new System.Drawing.Point(62, 142);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(70, 13);
            this.txtManufacturer.TabIndex = 9;
            this.txtManufacturer.Text = "Manufacturer";
            // 
            // txtAssetType
            // 
            this.txtAssetType.AutoSize = true;
            this.txtAssetType.Location = new System.Drawing.Point(62, 180);
            this.txtAssetType.Name = "txtAssetType";
            this.txtAssetType.Size = new System.Drawing.Size(31, 13);
            this.txtAssetType.TabIndex = 10;
            this.txtAssetType.Text = "Type";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.AutoSize = true;
            this.txtIPAddress.Location = new System.Drawing.Point(62, 218);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(58, 13);
            this.txtIPAddress.TabIndex = 11;
            this.txtIPAddress.Text = "IP Address";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(323, 57);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(150, 45);
            this.txtComment.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Comments (optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Date of Purchase (optional)";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(323, 197);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(150, 20);
            this.txtEmpID.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Employee ID (required)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 65);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtAssetType);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSystemName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtSystemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtModel;
        private System.Windows.Forms.Label txtManufacturer;
        private System.Windows.Forms.Label txtAssetType;
        private System.Windows.Forms.Label txtIPAddress;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

