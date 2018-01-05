namespace OOD2
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnANDgate = new System.Windows.Forms.Button();
			this.btnNotGate = new System.Windows.Forms.Button();
			this.btnOrGate = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnSource = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.Lbl = new System.Windows.Forms.Label();
			this.btn0 = new System.Windows.Forms.RadioButton();
			this.btn1 = new System.Windows.Forms.RadioButton();
			this.srcvalue = new System.Windows.Forms.GroupBox();
			this.btnCalc = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.srcvalue.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 57);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(555, 267);
			this.dataGridView1.TabIndex = 1;
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(6, 14);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 0;
			this.button6.Text = "Save";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(87, 14);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 1;
			this.button5.Text = "Load";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(249, 14);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 2;
			this.button4.Text = "Reset";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnNew);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Location = new System.Drawing.Point(12, 326);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(430, 37);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Menu";
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(168, 14);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "Remove";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnANDgate);
			this.groupBox1.Controls.Add(this.btnNotGate);
			this.groupBox1.Controls.Add(this.btnOrGate);
			this.groupBox1.Location = new System.Drawing.Point(587, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(72, 204);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gates";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// btnANDgate
			// 
			this.btnANDgate.BackColor = System.Drawing.Color.White;
			this.btnANDgate.BackgroundImage = global::OOD2.Properties.Resources.AND_Gate;
			this.btnANDgate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnANDgate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnANDgate.Location = new System.Drawing.Point(6, 19);
			this.btnANDgate.Name = "btnANDgate";
			this.btnANDgate.Size = new System.Drawing.Size(55, 55);
			this.btnANDgate.TabIndex = 2;
			this.btnANDgate.Text = "AND";
			this.btnANDgate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnANDgate.UseVisualStyleBackColor = false;
			this.btnANDgate.Click += new System.EventHandler(this.btnANDgate_Click);
			// 
			// btnNotGate
			// 
			this.btnNotGate.BackColor = System.Drawing.Color.White;
			this.btnNotGate.BackgroundImage = global::OOD2.Properties.Resources.NOT_Gate;
			this.btnNotGate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnNotGate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnNotGate.Location = new System.Drawing.Point(7, 144);
			this.btnNotGate.Name = "btnNotGate";
			this.btnNotGate.Size = new System.Drawing.Size(54, 56);
			this.btnNotGate.TabIndex = 2;
			this.btnNotGate.Text = "NOT";
			this.btnNotGate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnNotGate.UseVisualStyleBackColor = false;
			// 
			// btnOrGate
			// 
			this.btnOrGate.BackColor = System.Drawing.Color.White;
			this.btnOrGate.BackgroundImage = global::OOD2.Properties.Resources.OR_Gate;
			this.btnOrGate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnOrGate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnOrGate.Location = new System.Drawing.Point(7, 80);
			this.btnOrGate.Name = "btnOrGate";
			this.btnOrGate.Size = new System.Drawing.Size(55, 58);
			this.btnOrGate.TabIndex = 1;
			this.btnOrGate.Text = "OR";
			this.btnOrGate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnOrGate.UseVisualStyleBackColor = false;
			this.btnOrGate.Click += new System.EventHandler(this.btnOrGate_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(5, 94);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(68, 26);
			this.button7.TabIndex = 4;
			this.button7.Text = "Sink Node";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button7);
			this.groupBox3.Controls.Add(this.btnCalc);
			this.groupBox3.Controls.Add(this.btnSource);
			this.groupBox3.Controls.Add(this.button9);
			this.groupBox3.Location = new System.Drawing.Point(577, 214);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(88, 149);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Nodes and Connection";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// btnSource
			// 
			this.btnSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSource.Location = new System.Drawing.Point(6, 63);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(67, 25);
			this.btnSource.TabIndex = 6;
			this.btnSource.Text = "Source Node";
			this.btnSource.UseVisualStyleBackColor = false;
			this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
			// 
			// button9
			// 
			this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button9.Location = new System.Drawing.Point(6, 32);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(67, 25);
			this.button9.TabIndex = 5;
			this.button9.Text = "Connect";
			this.button9.UseVisualStyleBackColor = false;
			// 
			// Lbl
			// 
			this.Lbl.AutoSize = true;
			this.Lbl.BackColor = System.Drawing.Color.Transparent;
			this.Lbl.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Lbl.Location = new System.Drawing.Point(166, 9);
			this.Lbl.Name = "Lbl";
			this.Lbl.Size = new System.Drawing.Size(276, 45);
			this.Lbl.TabIndex = 8;
			this.Lbl.Text = "Logical Circuit";
			this.Lbl.Click += new System.EventHandler(this.Lbl_Click);
			// 
			// btn0
			// 
			this.btn0.AutoSize = true;
			this.btn0.Location = new System.Drawing.Point(6, 16);
			this.btn0.Name = "btn0";
			this.btn0.Size = new System.Drawing.Size(31, 17);
			this.btn0.TabIndex = 9;
			this.btn0.TabStop = true;
			this.btn0.Text = "0";
			this.btn0.UseVisualStyleBackColor = true;
			// 
			// btn1
			// 
			this.btn1.AutoSize = true;
			this.btn1.Location = new System.Drawing.Point(43, 16);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(31, 17);
			this.btn1.TabIndex = 10;
			this.btn1.TabStop = true;
			this.btn1.Text = "1";
			this.btn1.UseVisualStyleBackColor = true;
			// 
			// srcvalue
			// 
			this.srcvalue.Controls.Add(this.btn0);
			this.srcvalue.Controls.Add(this.btn1);
			this.srcvalue.Location = new System.Drawing.Point(478, 326);
			this.srcvalue.Name = "srcvalue";
			this.srcvalue.Size = new System.Drawing.Size(89, 37);
			this.srcvalue.TabIndex = 11;
			this.srcvalue.TabStop = false;
			this.srcvalue.Text = "Source Value";
			// 
			// btnCalc
			// 
			this.btnCalc.Location = new System.Drawing.Point(5, 122);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(68, 23);
			this.btnCalc.TabIndex = 12;
			this.btnCalc.Text = "Calculate";
			this.btnCalc.UseVisualStyleBackColor = true;
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(330, 13);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 4;
			this.btnNew.Text = "New";
			this.btnNew.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 369);
			this.Controls.Add(this.srcvalue);
			this.Controls.Add(this.Lbl);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Logical Circuits";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.srcvalue.ResumeLayout(false);
			this.srcvalue.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button btnOrGate;
		private System.Windows.Forms.Button btnNotGate;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button9;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Button btnSource;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label Lbl;
		private System.Windows.Forms.RadioButton btn0;
		private System.Windows.Forms.RadioButton btn1;
		private System.Windows.Forms.GroupBox srcvalue;
		private System.Windows.Forms.Button btnANDgate;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnCalc;
	}
}

