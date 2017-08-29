namespace GenAdxCDE.Source.View
{
    partial class ConsumerHistoryMgr
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
            this.consumerIDtextBox = new System.Windows.Forms.TextBox();
            this.preferenceIDtextBox = new System.Windows.Forms.TextBox();
            this.prefDatetextBox = new System.Windows.Forms.TextBox();
            this.prefChoicetextBox = new System.Windows.Forms.TextBox();
            this.adIDtextBox = new System.Windows.Forms.TextBox();
            this.couponIDtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            // consumerIDtextBox
            // 
            this.consumerIDtextBox.Location = new System.Drawing.Point(347, 684);
            this.consumerIDtextBox.Name = "consumerIDtextBox";
            this.consumerIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.consumerIDtextBox.TabIndex = 3;
            this.consumerIDtextBox.TextChanged += new System.EventHandler(this.consumerIDtextBox_TextChanged);
            // 
            // preferenceIDtextBox
            // 
            this.preferenceIDtextBox.Location = new System.Drawing.Point(347, 730);
            this.preferenceIDtextBox.Name = "preferenceIDtextBox";
            this.preferenceIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.preferenceIDtextBox.TabIndex = 4;
            this.preferenceIDtextBox.TextChanged += new System.EventHandler(this.FirstNametextBox_TextChanged);
            // 
            // prefDatetextBox
            // 
            this.prefDatetextBox.Location = new System.Drawing.Point(347, 780);
            this.prefDatetextBox.Name = "prefDatetextBox";
            this.prefDatetextBox.Size = new System.Drawing.Size(361, 31);
            this.prefDatetextBox.TabIndex = 5;
            this.prefDatetextBox.TextChanged += new System.EventHandler(this.MiddleInitialtextBox_TextChanged);
            // 
            // prefChoicetextBox
            // 
            this.prefChoicetextBox.Location = new System.Drawing.Point(1004, 681);
            this.prefChoicetextBox.Name = "prefChoicetextBox";
            this.prefChoicetextBox.Size = new System.Drawing.Size(361, 31);
            this.prefChoicetextBox.TabIndex = 6;
            this.prefChoicetextBox.TextChanged += new System.EventHandler(this.LastNametextBox_TextChanged);
            // 
            // adIDtextBox
            // 
            this.adIDtextBox.Location = new System.Drawing.Point(1004, 730);
            this.adIDtextBox.Name = "adIDtextBox";
            this.adIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.adIDtextBox.TabIndex = 7;
            this.adIDtextBox.TextChanged += new System.EventHandler(this.AddresstextBox_TextChanged);
            // 
            // couponIDtextBox
            // 
            this.couponIDtextBox.Location = new System.Drawing.Point(1004, 780);
            this.couponIDtextBox.Name = "couponIDtextBox";
            this.couponIDtextBox.Size = new System.Drawing.Size(361, 31);
            this.couponIDtextBox.TabIndex = 8;
            this.couponIDtextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 691);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Consumer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Preference ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 790);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Preference Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(783, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Preference Choice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(795, 737);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Advertisement ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(863, 790);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Coupon ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
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
            // ConsumerHistoryMgr
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.couponIDtextBox);
            this.Controls.Add(this.adIDtextBox);
            this.Controls.Add(this.prefChoicetextBox);
            this.Controls.Add(this.prefDatetextBox);
            this.Controls.Add(this.preferenceIDtextBox);
            this.Controls.Add(this.consumerIDtextBox);
            this.Controls.Add(this.add1button);
            this.Name = "ConsumerHistoryMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Consumer History Manager";
            this.Load += new System.EventHandler(this.FormConsumerHistoryMgr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerManagerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add1button;
        private System.Windows.Forms.TextBox consumerIDtextBox;
        private System.Windows.Forms.TextBox preferenceIDtextBox;
        private System.Windows.Forms.TextBox prefDatetextBox;
        private System.Windows.Forms.TextBox prefChoicetextBox;
        private System.Windows.Forms.TextBox adIDtextBox;
        private System.Windows.Forms.TextBox couponIDtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button retrievebutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource consumerManagerBindingSource;
        private System.Windows.Forms.Button clearbutton;
    }
}

