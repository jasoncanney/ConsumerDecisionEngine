namespace GenAdxCDE.Source.View
{
    partial class Coupon
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
            this.couponIDtextBox = new System.Windows.Forms.TextBox();
            this.couponTitletextBox = new System.Windows.Forms.TextBox();
            this.couponDesctextBox = new System.Windows.Forms.TextBox();
            this.CouponValuetextBox = new System.Windows.Forms.TextBox();
            this.couponStarttextBox = new System.Windows.Forms.TextBox();
            this.couponEndtextBox = new System.Windows.Forms.TextBox();
            this.couponLocationtextBox = new System.Windows.Forms.TextBox();
            this.couponIDlabel = new System.Windows.Forms.Label();
            this.couponTitlelabel = new System.Windows.Forms.Label();
            this.couponDescriptionlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(56, 531);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(269, 56);
            this.createbutton.TabIndex = 0;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Location = new System.Drawing.Point(499, 531);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(269, 56);
            this.exitbutton.TabIndex = 1;
            this.exitbutton.Text = "Clear Form";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // couponIDtextBox
            // 
            this.couponIDtextBox.Location = new System.Drawing.Point(381, 103);
            this.couponIDtextBox.Name = "couponIDtextBox";
            this.couponIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.couponIDtextBox.TabIndex = 3;
            this.couponIDtextBox.TextChanged += new System.EventHandler(this.consumerIDtextBox_TextChanged);
            // 
            // couponTitletextBox
            // 
            this.couponTitletextBox.Location = new System.Drawing.Point(381, 149);
            this.couponTitletextBox.Name = "couponTitletextBox";
            this.couponTitletextBox.Size = new System.Drawing.Size(361, 31);
            this.couponTitletextBox.TabIndex = 4;
            this.couponTitletextBox.TextChanged += new System.EventHandler(this.FirstNametextBox_TextChanged);
            // 
            // couponDesctextBox
            // 
            this.couponDesctextBox.Location = new System.Drawing.Point(381, 204);
            this.couponDesctextBox.Name = "couponDesctextBox";
            this.couponDesctextBox.Size = new System.Drawing.Size(361, 31);
            this.couponDesctextBox.TabIndex = 5;
            this.couponDesctextBox.TextChanged += new System.EventHandler(this.MiddleInitialtextBox_TextChanged);
            // 
            // CouponValuetextBox
            // 
            this.CouponValuetextBox.Location = new System.Drawing.Point(381, 257);
            this.CouponValuetextBox.Name = "CouponValuetextBox";
            this.CouponValuetextBox.Size = new System.Drawing.Size(361, 31);
            this.CouponValuetextBox.TabIndex = 6;
            this.CouponValuetextBox.TextChanged += new System.EventHandler(this.LastNametextBox_TextChanged);
            // 
            // couponStarttextBox
            // 
            this.couponStarttextBox.Location = new System.Drawing.Point(381, 314);
            this.couponStarttextBox.Name = "couponStarttextBox";
            this.couponStarttextBox.Size = new System.Drawing.Size(361, 31);
            this.couponStarttextBox.TabIndex = 7;
            this.couponStarttextBox.TextChanged += new System.EventHandler(this.AddresstextBox_TextChanged);
            // 
            // couponEndtextBox
            // 
            this.couponEndtextBox.Location = new System.Drawing.Point(381, 365);
            this.couponEndtextBox.Name = "couponEndtextBox";
            this.couponEndtextBox.Size = new System.Drawing.Size(361, 31);
            this.couponEndtextBox.TabIndex = 8;
            this.couponEndtextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // couponLocationtextBox
            // 
            this.couponLocationtextBox.Location = new System.Drawing.Point(381, 418);
            this.couponLocationtextBox.Name = "couponLocationtextBox";
            this.couponLocationtextBox.Size = new System.Drawing.Size(361, 31);
            this.couponLocationtextBox.TabIndex = 9;
            this.couponLocationtextBox.TextChanged += new System.EventHandler(this.StatetextBox_TextChanged);
            // 
            // couponIDlabel
            // 
            this.couponIDlabel.AutoSize = true;
            this.couponIDlabel.Enabled = false;
            this.couponIDlabel.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponIDlabel.Location = new System.Drawing.Point(209, 110);
            this.couponIDlabel.Name = "couponIDlabel";
            this.couponIDlabel.Size = new System.Drawing.Size(116, 24);
            this.couponIDlabel.TabIndex = 25;
            this.couponIDlabel.Text = "Coupon ID";
            this.couponIDlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // couponTitlelabel
            // 
            this.couponTitlelabel.AutoSize = true;
            this.couponTitlelabel.Enabled = false;
            this.couponTitlelabel.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponTitlelabel.Location = new System.Drawing.Point(187, 156);
            this.couponTitlelabel.Name = "couponTitlelabel";
            this.couponTitlelabel.Size = new System.Drawing.Size(138, 24);
            this.couponTitlelabel.TabIndex = 26;
            this.couponTitlelabel.Text = "Coupon Title";
            // 
            // couponDescriptionlabel
            // 
            this.couponDescriptionlabel.AutoSize = true;
            this.couponDescriptionlabel.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponDescriptionlabel.Location = new System.Drawing.Point(114, 211);
            this.couponDescriptionlabel.Name = "couponDescriptionlabel";
            this.couponDescriptionlabel.Size = new System.Drawing.Size(211, 24);
            this.couponDescriptionlabel.TabIndex = 12;
            this.couponDescriptionlabel.Text = "Coupon Description";
            this.couponDescriptionlabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Coupon Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Coupon Start Active";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Coupon End Active";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(208, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "CouponLocationZip";
            // 
            // Coupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.couponDescriptionlabel);
            this.Controls.Add(this.couponTitlelabel);
            this.Controls.Add(this.couponIDlabel);
            this.Controls.Add(this.couponLocationtextBox);
            this.Controls.Add(this.couponEndtextBox);
            this.Controls.Add(this.couponStarttextBox);
            this.Controls.Add(this.CouponValuetextBox);
            this.Controls.Add(this.couponDesctextBox);
            this.Controls.Add(this.couponTitletextBox);
            this.Controls.Add(this.couponIDtextBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.createbutton);
            this.Name = "Coupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Coupon Create";
            this.Load += new System.EventHandler(this.Coupon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.TextBox couponIDtextBox;
        private System.Windows.Forms.TextBox couponTitletextBox;
        private System.Windows.Forms.TextBox couponDesctextBox;
        private System.Windows.Forms.TextBox CouponValuetextBox;
        private System.Windows.Forms.TextBox couponStarttextBox;
        private System.Windows.Forms.TextBox couponEndtextBox;
        private System.Windows.Forms.TextBox couponLocationtextBox;
        private System.Windows.Forms.Label couponIDlabel;
        private System.Windows.Forms.Label couponTitlelabel;
        private System.Windows.Forms.Label couponDescriptionlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

