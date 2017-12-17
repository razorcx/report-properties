namespace ReportProperties
{
	partial class ReportPropertiesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportPropertiesForm));
			this.buttonString = new System.Windows.Forms.Button();
			this.buttonInt = new System.Windows.Forms.Button();
			this.buttonDouble = new System.Windows.Forms.Button();
			this.richTextBoxString = new System.Windows.Forms.RichTextBox();
			this.richTextBoxInt = new System.Windows.Forms.RichTextBox();
			this.richTextBoxDouble = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listBoxString = new System.Windows.Forms.ListBox();
			this.listBoxInt = new System.Windows.Forms.ListBox();
			this.listBoxDouble = new System.Windows.Forms.ListBox();
			this.buttonSelectPart = new System.Windows.Forms.Button();
			this.textBoxPart = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonString
			// 
			this.buttonString.Location = new System.Drawing.Point(12, 373);
			this.buttonString.Name = "buttonString";
			this.buttonString.Size = new System.Drawing.Size(159, 51);
			this.buttonString.TabIndex = 0;
			this.buttonString.Text = "Get String Properties";
			this.buttonString.UseVisualStyleBackColor = true;
			this.buttonString.Click += new System.EventHandler(this.buttonString_Click);
			// 
			// buttonInt
			// 
			this.buttonInt.Location = new System.Drawing.Point(178, 373);
			this.buttonInt.Name = "buttonInt";
			this.buttonInt.Size = new System.Drawing.Size(159, 51);
			this.buttonInt.TabIndex = 1;
			this.buttonInt.Text = "Get Int Properties";
			this.buttonInt.UseVisualStyleBackColor = true;
			this.buttonInt.Click += new System.EventHandler(this.buttonInt_Click);
			// 
			// buttonDouble
			// 
			this.buttonDouble.Location = new System.Drawing.Point(342, 373);
			this.buttonDouble.Name = "buttonDouble";
			this.buttonDouble.Size = new System.Drawing.Size(159, 51);
			this.buttonDouble.TabIndex = 2;
			this.buttonDouble.Text = "Get Double Properties";
			this.buttonDouble.UseVisualStyleBackColor = true;
			this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
			// 
			// richTextBoxString
			// 
			this.richTextBoxString.Location = new System.Drawing.Point(13, 156);
			this.richTextBoxString.Name = "richTextBoxString";
			this.richTextBoxString.Size = new System.Drawing.Size(158, 102);
			this.richTextBoxString.TabIndex = 3;
			this.richTextBoxString.Text = "";
			// 
			// richTextBoxInt
			// 
			this.richTextBoxInt.Location = new System.Drawing.Point(178, 155);
			this.richTextBoxInt.Name = "richTextBoxInt";
			this.richTextBoxInt.Size = new System.Drawing.Size(158, 102);
			this.richTextBoxInt.TabIndex = 4;
			this.richTextBoxInt.Text = "";
			// 
			// richTextBoxDouble
			// 
			this.richTextBoxDouble.Location = new System.Drawing.Point(341, 155);
			this.richTextBoxDouble.Name = "richTextBoxDouble";
			this.richTextBoxDouble.Size = new System.Drawing.Size(158, 102);
			this.richTextBoxDouble.TabIndex = 5;
			this.richTextBoxDouble.Text = "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ReportProperties.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(159, 51);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "String";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(176, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Int";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(340, 135);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Double";
			// 
			// listBoxString
			// 
			this.listBoxString.FormattingEnabled = true;
			this.listBoxString.ItemHeight = 16;
			this.listBoxString.Location = new System.Drawing.Point(12, 267);
			this.listBoxString.Name = "listBoxString";
			this.listBoxString.Size = new System.Drawing.Size(159, 100);
			this.listBoxString.TabIndex = 10;
			// 
			// listBoxInt
			// 
			this.listBoxInt.FormattingEnabled = true;
			this.listBoxInt.ItemHeight = 16;
			this.listBoxInt.Location = new System.Drawing.Point(178, 267);
			this.listBoxInt.Name = "listBoxInt";
			this.listBoxInt.Size = new System.Drawing.Size(159, 100);
			this.listBoxInt.TabIndex = 11;
			// 
			// listBoxDouble
			// 
			this.listBoxDouble.FormattingEnabled = true;
			this.listBoxDouble.ItemHeight = 16;
			this.listBoxDouble.Location = new System.Drawing.Point(342, 267);
			this.listBoxDouble.Name = "listBoxDouble";
			this.listBoxDouble.Size = new System.Drawing.Size(159, 100);
			this.listBoxDouble.TabIndex = 12;
			// 
			// buttonSelectPart
			// 
			this.buttonSelectPart.Location = new System.Drawing.Point(12, 80);
			this.buttonSelectPart.Name = "buttonSelectPart";
			this.buttonSelectPart.Size = new System.Drawing.Size(158, 35);
			this.buttonSelectPart.TabIndex = 13;
			this.buttonSelectPart.Text = "Select Part";
			this.buttonSelectPart.UseVisualStyleBackColor = true;
			this.buttonSelectPart.Click += new System.EventHandler(this.buttonSelectPart_Click);
			// 
			// textBoxPart
			// 
			this.textBoxPart.Location = new System.Drawing.Point(179, 86);
			this.textBoxPart.Name = "textBoxPart";
			this.textBoxPart.Size = new System.Drawing.Size(158, 22);
			this.textBoxPart.TabIndex = 14;
			// 
			// ReportPropertiesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(512, 433);
			this.Controls.Add(this.textBoxPart);
			this.Controls.Add(this.buttonSelectPart);
			this.Controls.Add(this.listBoxDouble);
			this.Controls.Add(this.listBoxInt);
			this.Controls.Add(this.listBoxString);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.richTextBoxDouble);
			this.Controls.Add(this.richTextBoxInt);
			this.Controls.Add(this.richTextBoxString);
			this.Controls.Add(this.buttonDouble);
			this.Controls.Add(this.buttonInt);
			this.Controls.Add(this.buttonString);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ReportPropertiesForm";
			this.Text = "Report Properties";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonString;
		private System.Windows.Forms.Button buttonInt;
		private System.Windows.Forms.Button buttonDouble;
		private System.Windows.Forms.RichTextBox richTextBoxString;
		private System.Windows.Forms.RichTextBox richTextBoxInt;
		private System.Windows.Forms.RichTextBox richTextBoxDouble;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxString;
		private System.Windows.Forms.ListBox listBoxInt;
		private System.Windows.Forms.ListBox listBoxDouble;
		private System.Windows.Forms.Button buttonSelectPart;
		private System.Windows.Forms.TextBox textBoxPart;
	}
}

