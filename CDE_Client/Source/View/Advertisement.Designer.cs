namespace GenAdxCDE.Source.View
{
    partial class Advertisement
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
            this.createbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.adIDtextBox = new System.Windows.Forms.TextBox();
            this.adTitletextBox = new System.Windows.Forms.TextBox();
            this.adDemo01textBox = new System.Windows.Forms.TextBox();
            this.adDemo02textBox = new System.Windows.Forms.TextBox();
            this.adDemo03textBox = new System.Windows.Forms.TextBox();
            this.adDemo04textBox = new System.Windows.Forms.TextBox();
            this.adDescriptiontextBox = new System.Windows.Forms.TextBox();
            this.adID = new System.Windows.Forms.Label();
            this.AdTitle = new System.Windows.Forms.Label();
            this.addemo01 = new System.Windows.Forms.Label();
            this.addemo02 = new System.Windows.Forms.Label();
            this.addemo03 = new System.Windows.Forms.Label();
            this.addemo04 = new System.Windows.Forms.Label();
            this.AdDescription = new System.Windows.Forms.Label();
            this.adOwnertextBox = new System.Windows.Forms.TextBox();
            this.AdOwner = new System.Windows.Forms.Label();
            this.adCaTypeCodetextBox = new System.Windows.Forms.TextBox();
            this.AdCATypeCode = new System.Windows.Forms.Label();
            this.adBrandTextBox = new System.Windows.Forms.TextBox();
            this.adGsSegmentTextBox = new System.Windows.Forms.TextBox();
            this.AdBrand = new System.Windows.Forms.Label();
            this.AdGsSegment = new System.Windows.Forms.Label();
            this.AdCAValueCode = new System.Windows.Forms.Label();
            this.adCaValueCodeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(266, 435);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(269, 56);
            this.createbutton.TabIndex = 0;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(709, 435);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(269, 56);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Clear Form";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // adIDtextBox
            // 
            this.adIDtextBox.Location = new System.Drawing.Point(180, 101);
            this.adIDtextBox.Name = "adIDtextBox";
            this.adIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.adIDtextBox.TabIndex = 3;
            this.adIDtextBox.TextChanged += new System.EventHandler(this.consumerIDtextBox_TextChanged);
            // 
            // adTitletextBox
            // 
            this.adTitletextBox.Location = new System.Drawing.Point(180, 147);
            this.adTitletextBox.Name = "adTitletextBox";
            this.adTitletextBox.Size = new System.Drawing.Size(361, 31);
            this.adTitletextBox.TabIndex = 4;
            this.adTitletextBox.TextChanged += new System.EventHandler(this.FirstNametextBox_TextChanged);
            // 
            // adDemo01textBox
            // 
            this.adDemo01textBox.Location = new System.Drawing.Point(180, 198);
            this.adDemo01textBox.Name = "adDemo01textBox";
            this.adDemo01textBox.Size = new System.Drawing.Size(361, 31);
            this.adDemo01textBox.TabIndex = 5;
            this.adDemo01textBox.TextChanged += new System.EventHandler(this.MiddleInitialtextBox_TextChanged);
            // 
            // adDemo02textBox
            // 
            this.adDemo02textBox.Location = new System.Drawing.Point(180, 251);
            this.adDemo02textBox.Name = "adDemo02textBox";
            this.adDemo02textBox.Size = new System.Drawing.Size(361, 31);
            this.adDemo02textBox.TabIndex = 6;
            this.adDemo02textBox.TextChanged += new System.EventHandler(this.LastNametextBox_TextChanged);
            // 
            // adDemo03textBox
            // 
            this.adDemo03textBox.Location = new System.Drawing.Point(180, 308);
            this.adDemo03textBox.Name = "adDemo03textBox";
            this.adDemo03textBox.Size = new System.Drawing.Size(361, 31);
            this.adDemo03textBox.TabIndex = 7;
            this.adDemo03textBox.TextChanged += new System.EventHandler(this.AddresstextBox_TextChanged);
            // 
            // adDemo04textBox
            // 
            this.adDemo04textBox.Location = new System.Drawing.Point(180, 359);
            this.adDemo04textBox.Name = "adDemo04textBox";
            this.adDemo04textBox.Size = new System.Drawing.Size(361, 31);
            this.adDemo04textBox.TabIndex = 8;
            this.adDemo04textBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // adDescriptiontextBox
            // 
            this.adDescriptiontextBox.Location = new System.Drawing.Point(795, 104);
            this.adDescriptiontextBox.Name = "adDescriptiontextBox";
            this.adDescriptiontextBox.Size = new System.Drawing.Size(361, 31);
            this.adDescriptiontextBox.TabIndex = 9;
            this.adDescriptiontextBox.TextChanged += new System.EventHandler(this.StatetextBox_TextChanged);
            // 
            // adID
            // 
            this.adID.AutoSize = true;
            this.adID.Enabled = false;
            this.adID.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adID.Location = new System.Drawing.Point(86, 108);
            this.adID.Name = "adID";
            this.adID.Size = new System.Drawing.Size(64, 24);
            this.adID.TabIndex = 25;
            this.adID.Text = "Ad ID";
            this.adID.Click += new System.EventHandler(this.label2_Click);
            // 
            // AdTitle
            // 
            this.AdTitle.AutoSize = true;
            this.AdTitle.Enabled = false;
            this.AdTitle.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdTitle.Location = new System.Drawing.Point(64, 154);
            this.AdTitle.Name = "AdTitle";
            this.AdTitle.Size = new System.Drawing.Size(86, 24);
            this.AdTitle.TabIndex = 26;
            this.AdTitle.Text = "Ad Title";
            // 
            // addemo01
            // 
            this.addemo01.AutoSize = true;
            this.addemo01.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemo01.Location = new System.Drawing.Point(19, 205);
            this.addemo01.Name = "addemo01";
            this.addemo01.Size = new System.Drawing.Size(133, 24);
            this.addemo01.TabIndex = 12;
            this.addemo01.Text = "Ad Demo 01";
            this.addemo01.Click += new System.EventHandler(this.label4_Click);
            // 
            // addemo02
            // 
            this.addemo02.AutoSize = true;
            this.addemo02.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemo02.Location = new System.Drawing.Point(19, 258);
            this.addemo02.Name = "addemo02";
            this.addemo02.Size = new System.Drawing.Size(133, 24);
            this.addemo02.TabIndex = 13;
            this.addemo02.Text = "Ad Demo 02";
            // 
            // addemo03
            // 
            this.addemo03.AutoSize = true;
            this.addemo03.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemo03.Location = new System.Drawing.Point(19, 315);
            this.addemo03.Name = "addemo03";
            this.addemo03.Size = new System.Drawing.Size(133, 24);
            this.addemo03.TabIndex = 14;
            this.addemo03.Text = "Ad Demo 03";
            // 
            // addemo04
            // 
            this.addemo04.AutoSize = true;
            this.addemo04.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addemo04.Location = new System.Drawing.Point(19, 366);
            this.addemo04.Name = "addemo04";
            this.addemo04.Size = new System.Drawing.Size(133, 24);
            this.addemo04.TabIndex = 15;
            this.addemo04.Text = "Ad Demo 04";
            this.addemo04.Click += new System.EventHandler(this.label7_Click);
            // 
            // AdDescription
            // 
            this.AdDescription.AutoSize = true;
            this.AdDescription.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdDescription.Location = new System.Drawing.Point(599, 111);
            this.AdDescription.Name = "AdDescription";
            this.AdDescription.Size = new System.Drawing.Size(159, 24);
            this.AdDescription.TabIndex = 16;
            this.AdDescription.Text = "Ad Description";
            // 
            // adOwnertextBox
            // 
            this.adOwnertextBox.Location = new System.Drawing.Point(795, 163);
            this.adOwnertextBox.Name = "adOwnertextBox";
            this.adOwnertextBox.Size = new System.Drawing.Size(361, 31);
            this.adOwnertextBox.TabIndex = 10;
            this.adOwnertextBox.TextChanged += new System.EventHandler(this.ZiptextBox_TextChanged);
            // 
            // AdOwner
            // 
            this.AdOwner.AutoSize = true;
            this.AdOwner.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdOwner.Location = new System.Drawing.Point(650, 170);
            this.AdOwner.Name = "AdOwner";
            this.AdOwner.Size = new System.Drawing.Size(108, 24);
            this.AdOwner.TabIndex = 18;
            this.AdOwner.Text = "Ad Owner";
            // 
            // adCaTypeCodetextBox
            // 
            this.adCaTypeCodetextBox.Location = new System.Drawing.Point(795, 310);
            this.adCaTypeCodetextBox.Name = "adCaTypeCodetextBox";
            this.adCaTypeCodetextBox.Size = new System.Drawing.Size(361, 31);
            this.adCaTypeCodetextBox.TabIndex = 13;
            this.adCaTypeCodetextBox.TextChanged += new System.EventHandler(this.SOCEmailtextBox_TextChanged);
            // 
            // AdCATypeCode
            // 
            this.AdCATypeCode.AutoSize = true;
            this.AdCATypeCode.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdCATypeCode.Location = new System.Drawing.Point(565, 317);
            this.AdCATypeCode.Name = "AdCATypeCode";
            this.AdCATypeCode.Size = new System.Drawing.Size(185, 24);
            this.AdCATypeCode.TabIndex = 20;
            this.AdCATypeCode.Text = "Ad CA Type Code";
            // 
            // adBrandTextBox
            // 
            this.adBrandTextBox.Location = new System.Drawing.Point(795, 216);
            this.adBrandTextBox.Name = "adBrandTextBox";
            this.adBrandTextBox.Size = new System.Drawing.Size(361, 31);
            this.adBrandTextBox.TabIndex = 11;
            // 
            // adGsSegmentTextBox
            // 
            this.adGsSegmentTextBox.Location = new System.Drawing.Point(795, 263);
            this.adGsSegmentTextBox.Name = "adGsSegmentTextBox";
            this.adGsSegmentTextBox.Size = new System.Drawing.Size(361, 31);
            this.adGsSegmentTextBox.TabIndex = 12;
            // 
            // AdBrand
            // 
            this.AdBrand.AutoSize = true;
            this.AdBrand.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdBrand.Location = new System.Drawing.Point(650, 223);
            this.AdBrand.Name = "AdBrand";
            this.AdBrand.Size = new System.Drawing.Size(105, 24);
            this.AdBrand.TabIndex = 29;
            this.AdBrand.Text = "Ad Brand";
            // 
            // AdGsSegment
            // 
            this.AdGsSegment.AutoSize = true;
            this.AdGsSegment.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdGsSegment.Location = new System.Drawing.Point(590, 270);
            this.AdGsSegment.Name = "AdGsSegment";
            this.AdGsSegment.Size = new System.Drawing.Size(168, 24);
            this.AdGsSegment.TabIndex = 30;
            this.AdGsSegment.Text = "Ad Gs Segment";
            // 
            // AdCAValueCode
            // 
            this.AdCAValueCode.AutoSize = true;
            this.AdCAValueCode.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdCAValueCode.Location = new System.Drawing.Point(558, 363);
            this.AdCAValueCode.Name = "AdCAValueCode";
            this.AdCAValueCode.Size = new System.Drawing.Size(192, 24);
            this.AdCAValueCode.TabIndex = 32;
            this.AdCAValueCode.Text = "Ad CA Value Code";
            // 
            // adCaValueCodeTextbox
            // 
            this.adCaValueCodeTextbox.Location = new System.Drawing.Point(795, 356);
            this.adCaValueCodeTextbox.Name = "adCaValueCodeTextbox";
            this.adCaValueCodeTextbox.Size = new System.Drawing.Size(361, 31);
            this.adCaValueCodeTextbox.TabIndex = 14;
            // 
            // Advertisement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 543);
            this.Controls.Add(this.adCaValueCodeTextbox);
            this.Controls.Add(this.AdCAValueCode);
            this.Controls.Add(this.AdGsSegment);
            this.Controls.Add(this.AdBrand);
            this.Controls.Add(this.adGsSegmentTextBox);
            this.Controls.Add(this.adBrandTextBox);
            this.Controls.Add(this.AdCATypeCode);
            this.Controls.Add(this.adCaTypeCodetextBox);
            this.Controls.Add(this.AdOwner);
            this.Controls.Add(this.adOwnertextBox);
            this.Controls.Add(this.AdDescription);
            this.Controls.Add(this.addemo04);
            this.Controls.Add(this.addemo03);
            this.Controls.Add(this.addemo02);
            this.Controls.Add(this.addemo01);
            this.Controls.Add(this.AdTitle);
            this.Controls.Add(this.adID);
            this.Controls.Add(this.adDescriptiontextBox);
            this.Controls.Add(this.adDemo04textBox);
            this.Controls.Add(this.adDemo03textBox);
            this.Controls.Add(this.adDemo02textBox);
            this.Controls.Add(this.adDemo01textBox);
            this.Controls.Add(this.adTitletextBox);
            this.Controls.Add(this.adIDtextBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.createbutton);
            this.Name = "Advertisement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Advertisement Create";
            this.Load += new System.EventHandler(this.Advertisement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox adIDtextBox;
        private System.Windows.Forms.TextBox adTitletextBox;
        private System.Windows.Forms.TextBox adDemo01textBox;
        private System.Windows.Forms.TextBox adDemo02textBox;
        private System.Windows.Forms.TextBox adDemo03textBox;
        private System.Windows.Forms.TextBox adDemo04textBox;
        private System.Windows.Forms.TextBox adDescriptiontextBox;
        private System.Windows.Forms.Label adID;
        private System.Windows.Forms.Label AdTitle;
        private System.Windows.Forms.Label addemo01;
        private System.Windows.Forms.Label addemo02;
        private System.Windows.Forms.Label addemo03;
        private System.Windows.Forms.Label addemo04;
        private System.Windows.Forms.Label AdDescription;
        private System.Windows.Forms.TextBox adOwnertextBox;
        private System.Windows.Forms.Label AdOwner;
        private System.Windows.Forms.TextBox adCaTypeCodetextBox;
        private System.Windows.Forms.Label AdCATypeCode;
        private System.Windows.Forms.TextBox adBrandTextBox;
        private System.Windows.Forms.TextBox adGsSegmentTextBox;
        private System.Windows.Forms.Label AdBrand;
        private System.Windows.Forms.Label AdGsSegment;
        private System.Windows.Forms.Label AdCAValueCode;
        private System.Windows.Forms.TextBox adCaValueCodeTextbox;
    }
}

