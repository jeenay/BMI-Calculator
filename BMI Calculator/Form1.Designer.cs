﻿namespace BMI_Calculator
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
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(107, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(675, 78);
			this.label1.TabIndex = 0;
			this.label1.Text = "BODY INDEX MASS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(114, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Weight";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(114, 227);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(192, 36);
			this.label3.TabIndex = 2;
			this.label3.Text = "Enter Height";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(114, 298);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(193, 36);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sum Up BMI";
			// 
			// txtWeight
			// 
			this.txtWeight.Location = new System.Drawing.Point(413, 158);
			this.txtWeight.Multiline = true;
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(263, 36);
			this.txtWeight.TabIndex = 1;
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(413, 227);
			this.txtHeight.Multiline = true;
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(263, 36);
			this.txtHeight.TabIndex = 5;
			// 
			// SumupBMI
			// 
			this.SumupBMI.Location = new System.Drawing.Point(413, 298);
			this.SumupBMI.Multiline = true;
			this.SumupBMI.Name = "SumupBMI";
			this.SumupBMI.Size = new System.Drawing.Size(263, 36);
			this.SumupBMI.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(120, 406);
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
			this.button2.Location = new System.Drawing.Point(343, 406);
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
			this.button3.Location = new System.Drawing.Point(574, 406);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(194, 57);
			this.button3.TabIndex = 9;
			this.button3.Text = "Exit BMI";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1155, 505);
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
	}
}
