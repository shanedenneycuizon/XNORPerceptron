namespace PerceptronAlgorithm_XNOR
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
            this.w1 = new System.Windows.Forms.TextBox();
            this.w2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.create_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.train_btn = new System.Windows.Forms.Button();
            this.output_txt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // w1
            // 
            this.w1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w1.Location = new System.Drawing.Point(420, 73);
            this.w1.Name = "w1";
            this.w1.Size = new System.Drawing.Size(100, 32);
            this.w1.TabIndex = 1;
            // 
            // w2
            // 
            this.w2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.w2.Location = new System.Drawing.Point(420, 115);
            this.w2.Name = "w2";
            this.w2.Size = new System.Drawing.Size(100, 32);
            this.w2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "w1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "w2";
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(334, 259);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(186, 41);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create Model";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Learning Rate";
            // 
            // lr
            // 
            this.lr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lr.Location = new System.Drawing.Point(420, 157);
            this.lr.Name = "lr";
            this.lr.Size = new System.Drawing.Size(100, 32);
            this.lr.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bias";
            // 
            // b
            // 
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b.Location = new System.Drawing.Point(420, 209);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 32);
            this.b.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "XNOR TRUTH TABLE";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label19, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label18, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label16, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 183);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "x1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "x2";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(157, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "y\'";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "-1";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(87, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "-1";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(162, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "1";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "-1";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(90, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "1";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(159, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 20);
            this.label14.TabIndex = 8;
            this.label14.Text = "-1";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "1";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(87, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "-1";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(159, 116);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "-1";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 20);
            this.label18.TabIndex = 12;
            this.label18.Text = "1";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(90, 153);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 20);
            this.label19.TabIndex = 13;
            this.label19.Text = "1";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(162, 153);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(331, 369);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 16);
            this.label21.TabIndex = 13;
            this.label21.Text = "y OUTPUT VALUES:";
            // 
            // train_btn
            // 
            this.train_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.train_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.train_btn.Location = new System.Drawing.Point(86, 353);
            this.train_btn.Name = "train_btn";
            this.train_btn.Size = new System.Drawing.Size(122, 41);
            this.train_btn.TabIndex = 14;
            this.train_btn.Text = "TRAIN";
            this.train_btn.UseVisualStyleBackColor = false;
            this.train_btn.Click += new System.EventHandler(this.train_btn_Click);
            // 
            // output_txt
            // 
            this.output_txt.AutoSize = true;
            this.output_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_txt.Location = new System.Drawing.Point(501, 340);
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(19, 80);
            this.output_txt.TabIndex = 15;
            this.output_txt.Text = "0\r\n0\r\n0\r\n0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 458);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.train_btn);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.w2);
            this.Controls.Add(this.w1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox w1;
        private System.Windows.Forms.TextBox w2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button train_btn;
        private System.Windows.Forms.Label output_txt;
    }
}

