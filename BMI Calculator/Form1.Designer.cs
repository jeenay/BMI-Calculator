namespace BMI_Calculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.SumupBMI = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnequals = new System.Windows.Forms.Button();
			this.btn0 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn6 = new System.Windows.Forms.Button();
			this.btn5 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.btn9 = new System.Windows.Forms.Button();
			this.btn8 = new System.Windows.Forms.Button();
			this.btn7 = new System.Windows.Forms.Button();
			this.lblMetric = new System.Windows.Forms.RadioButton();
			this.lblImperial = new System.Windows.Forms.RadioButton();
			this.txtRemarks = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(600, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "BODY INDEX MASS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(30, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Weight";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 156);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "Enter Height";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(30, 227);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 36);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sum Up BMI";
			// 
			// txtWeight
			// 
			this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtWeight.Location = new System.Drawing.Point(329, 87);
			this.txtWeight.Multiline = true;
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(263, 36);
			this.txtWeight.TabIndex = 1;
			this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtHeight
			// 
			this.txtHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHeight.Location = new System.Drawing.Point(329, 156);
			this.txtHeight.Multiline = true;
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(263, 36);
			this.txtHeight.TabIndex = 5;
			this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// SumupBMI
			// 
			this.SumupBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SumupBMI.Location = new System.Drawing.Point(329, 227);
			this.SumupBMI.Multiline = true;
			this.SumupBMI.Name = "SumupBMI";
			this.SumupBMI.Size = new System.Drawing.Size(263, 36);
			this.SumupBMI.TabIndex = 6;
			this.SumupBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(737, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(194, 57);
			this.button1.TabIndex = 7;
			this.button1.Text = "Check BMI";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(735, 146);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(194, 57);
			this.button2.TabIndex = 8;
			this.button2.Text = "Reset BMI";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(735, 227);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(194, 57);
			this.button3.TabIndex = 9;
			this.button3.Text = "Exit BMI";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.tableLayoutPanel1.Controls.Add(this.btnequals, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(36, 288);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(651, 205);
			this.tableLayoutPanel1.TabIndex = 10;
			// 
			// btnequals
			// 
			this.btnequals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnequals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnequals.Location = new System.Drawing.Point(436, 156);
			this.btnequals.Name = "btnequals";
			this.btnequals.Size = new System.Drawing.Size(212, 46);
			this.btnequals.TabIndex = 11;
			this.btnequals.Text = "=";
			this.btnequals.UseVisualStyleBackColor = true;
			// 
			// btn0
			// 
			this.btn0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn0.Location = new System.Drawing.Point(219, 156);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(211, 46);
			this.btn0.TabIndex = 10;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			// 
			// btn3
			// 
			this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn3.Location = new System.Drawing.Point(436, 105);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(212, 45);
			this.btn3.TabIndex = 8;
			this.btn3.Text = "3";
			this.btn3.UseVisualStyleBackColor = true;
			// 
			// btn2
			// 
			this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn2.Location = new System.Drawing.Point(219, 105);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(211, 45);
			this.btn2.TabIndex = 7;
			this.btn2.Text = "2";
			this.btn2.UseVisualStyleBackColor = true;
			// 
			// btn1
			// 
			this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn1.Location = new System.Drawing.Point(3, 105);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(210, 45);
			this.btn1.TabIndex = 6;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// btn6
			// 
			this.btn6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn6.Location = new System.Drawing.Point(436, 54);
			this.btn6.Name = "btn6";
			this.btn6.Size = new System.Drawing.Size(212, 45);
			this.btn6.TabIndex = 5;
			this.btn6.Text = "6";
			this.btn6.UseVisualStyleBackColor = true;
			this.btn6.Click += new System.EventHandler(this.Button8_Click);
			// 
			// btn5
			// 
			this.btn5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn5.Location = new System.Drawing.Point(219, 54);
			this.btn5.Name = "btn5";
			this.btn5.Size = new System.Drawing.Size(211, 45);
			this.btn5.TabIndex = 4;
			this.btn5.Text = "5";
			this.btn5.UseVisualStyleBackColor = true;
			// 
			// btn4
			// 
			this.btn4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn4.Location = new System.Drawing.Point(3, 54);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(210, 45);
			this.btn4.TabIndex = 3;
			this.btn4.Text = "4";
			this.btn4.UseVisualStyleBackColor = true;
			// 
			// btn9
			// 
			this.btn9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn9.Location = new System.Drawing.Point(436, 3);
			this.btn9.Name = "btn9";
			this.btn9.Size = new System.Drawing.Size(212, 45);
			this.btn9.TabIndex = 2;
			this.btn9.Text = "9";
			this.btn9.UseVisualStyleBackColor = true;
			this.btn9.Click += new System.EventHandler(this.Button5_Click);
			// 
			// btn8
			// 
			this.btn8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn8.Location = new System.Drawing.Point(219, 3);
			this.btn8.Name = "btn8";
			this.btn8.Size = new System.Drawing.Size(211, 45);
			this.btn8.TabIndex = 1;
			this.btn8.Text = "8";
			this.btn8.UseVisualStyleBackColor = true;
			// 
			// btn7
			// 
			this.btn7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn7.Location = new System.Drawing.Point(3, 3);
			this.btn7.Name = "btn7";
			this.btn7.Size = new System.Drawing.Size(210, 45);
			this.btn7.TabIndex = 0;
			this.btn7.Text = "7";
			this.btn7.UseVisualStyleBackColor = true;
			// 
			// lblMetric
			// 
			this.lblMetric.AutoSize = true;
			this.lblMetric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMetric.Location = new System.Drawing.Point(616, 131);
			this.lblMetric.Name = "lblMetric";
			this.lblMetric.Size = new System.Drawing.Size(92, 29);
			this.lblMetric.TabIndex = 11;
			this.lblMetric.TabStop = true;
			this.lblMetric.Text = "Metric";
			this.lblMetric.UseVisualStyleBackColor = true;
			// 
			// lblImperial
			// 
			this.lblImperial.AutoSize = true;
			this.lblImperial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImperial.Location = new System.Drawing.Point(616, 205);
			this.lblImperial.Name = "lblImperial";
			this.lblImperial.Size = new System.Drawing.Size(109, 29);
			this.lblImperial.TabIndex = 12;
			this.lblImperial.TabStop = true;
			this.lblImperial.Text = "Imperial";
			this.lblImperial.UseVisualStyleBackColor = true;
			// 
			// txtRemarks
			// 
			this.txtRemarks.Location = new System.Drawing.Point(735, 405);
			this.txtRemarks.Multiline = true;
			this.txtRemarks.Name = "txtRemarks";
			this.txtRemarks.Size = new System.Drawing.Size(369, 46);
			this.txtRemarks.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(732, 370);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(96, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "Remarks";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 505);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtRemarks);
			this.Controls.Add(this.lblImperial);
			this.Controls.Add(this.lblMetric);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.SumupBMI);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox SumupBMI;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnequals;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.RadioButton lblMetric;
		private System.Windows.Forms.RadioButton lblImperial;
		private System.Windows.Forms.TextBox txtRemarks;
		private System.Windows.Forms.Label label5;
	}
}

