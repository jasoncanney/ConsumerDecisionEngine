namespace GenAdxCDE.Source.View
{
    partial class CouponMgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add1button = new System.Windows.Forms.Button();
            this.couponIDtextBox = new System.Windows.Forms.TextBox();
            this.TitletextBox = new System.Windows.Forms.TextBox();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.ValuetextBox = new System.Windows.Forms.TextBox();
            this.StartActtextBox = new System.Windows.Forms.TextBox();
            this.EndActtextBox = new System.Windows.Forms.TextBox();
            this.ActZiptextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.deletebutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.retrievebutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.consumerManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerManagerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // add1button
            // 
            this.add1button.Location = new System.Drawing.Point(133, 917);
            this.add1button.Name = "add1button";
            this.add1button.Size = new System.Drawing.Size(269, 56);
            this.add1button.TabIndex = 0;
            this.add1button.Text = "Add";
            this.add1button.UseVisualStyleBackColor = true;
            this.add1button.Click += new System.EventHandler(this.button1_Click);
            // 
            // couponIDtextBox
            // 
            this.couponIDtextBox.Location = new System.Drawing.Point(232, 688);
            this.couponIDtextBox.Name = "couponIDtextBox";
            this.couponIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.couponIDtextBox.TabIndex = 3;
            this.couponIDtextBox.TextChanged += new System.EventHandler(this.consumerIDtextBox_TextChanged);
            // 
            // TitletextBox
            // 
            this.TitletextBox.Location = new System.Drawing.Point(232, 734);
            this.TitletextBox.Name = "TitletextBox";
            this.TitletextBox.Size = new System.Drawing.Size(361, 31);
            this.TitletextBox.TabIndex = 4;
            this.TitletextBox.TextChanged += new System.EventHandler(this.FirstNametextBox_TextChanged);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Location = new System.Drawing.Point(232, 784);
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.Size = new System.Drawing.Size(361, 31);
            this.DescriptiontextBox.TabIndex = 5;
            this.DescriptiontextBox.TextChanged += new System.EventHandler(this.MiddleInitialtextBox_TextChanged);
            // 
            // ValuetextBox
            // 
            this.ValuetextBox.Location = new System.Drawing.Point(232, 835);
            this.ValuetextBox.Name = "ValuetextBox";
            this.ValuetextBox.Size = new System.Drawing.Size(361, 31);
            this.ValuetextBox.TabIndex = 6;
            this.ValuetextBox.TextChanged += new System.EventHandler(this.LastNametextBox_TextChanged);
            // 
            // StartActtextBox
            // 
            this.StartActtextBox.Location = new System.Drawing.Point(855, 688);
            this.StartActtextBox.Name = "StartActtextBox";
            this.StartActtextBox.Size = new System.Drawing.Size(361, 31);
            this.StartActtextBox.TabIndex = 7;
            this.StartActtextBox.TextChanged += new System.EventHandler(this.AddresstextBox_TextChanged);
            // 
            // EndActtextBox
            // 
            this.EndActtextBox.Location = new System.Drawing.Point(855, 737);
            this.EndActtextBox.Name = "EndActtextBox";
            this.EndActtextBox.Size = new System.Drawing.Size(361, 31);
            this.EndActtextBox.TabIndex = 8;
            this.EndActtextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ActZiptextBox
            // 
            this.ActZiptextBox.Location = new System.Drawing.Point(855, 784);
            this.ActZiptextBox.Name = "ActZiptextBox";
            this.ActZiptextBox.Size = new System.Drawing.Size(361, 31);
            this.ActZiptextBox.TabIndex = 9;
            this.ActZiptextBox.TextChanged += new System.EventHandler(this.StatetextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 692);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Coupon ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 744);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 791);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(111, 842);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(648, 698);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Start Active Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(656, 741);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "End Active Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(717, 791);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Active Zip";
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(730, 917);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(269, 56);
            this.deletebutton.TabIndex = 32;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(439, 917);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(269, 56);
            this.updatebutton.TabIndex = 33;
            this.updatebutton.Text = "Update";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // retrievebutton
            // 
            this.retrievebutton.Location = new System.Drawing.Point(1016, 917);
            this.retrievebutton.Name = "retrievebutton";
            this.retrievebutton.Size = new System.Drawing.Size(269, 56);
            this.retrievebutton.TabIndex = 34;
            this.retrievebutton.Text = "Retrieve";
            this.retrievebutton.UseVisualStyleBackColor = true;
            this.retrievebutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Location = new System.Drawing.Point(39, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1676, 507);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // consumerManagerBindingSource
            // 
            this.consumerManagerBindingSource.DataSource = typeof(GenAdxCDE.Source.Model.Business.consumerManager);
            this.consumerManagerBindingSource.CurrentChanged += new System.EventHandler(this.consumerManagerBindingSource_CurrentChanged);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(1300, 917);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(269, 56);
            this.clearbutton.TabIndex = 36;
            this.clearbutton.Text = "Clear Form";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // CouponMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1763, 1032);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.retrievebutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActZiptextBox);
            this.Controls.Add(this.EndActtextBox);
            this.Controls.Add(this.StartActtextBox);
            this.Controls.Add(this.ValuetextBox);
            this.Controls.Add(this.DescriptiontextBox);
            this.Controls.Add(this.TitletextBox);
            this.Controls.Add(this.couponIDtextBox);
            this.Controls.Add(this.add1button);
            this.Name = "CouponMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Coupon Manager";
            this.Load += new System.EventHandler(this.CouponMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add1button;
        private System.Windows.Forms.TextBox couponIDtextBox;
        private System.Windows.Forms.TextBox TitletextBox;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.TextBox ValuetextBox;
        private System.Windows.Forms.TextBox StartActtextBox;
        private System.Windows.Forms.TextBox EndActtextBox;
        private System.Windows.Forms.TextBox ActZiptextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button retrievebutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource consumerManagerBindingSource;
        private System.Windows.Forms.Button clearbutton;
    }
}

