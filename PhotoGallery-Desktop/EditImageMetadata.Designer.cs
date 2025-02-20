namespace PhotoGallery_Desktop
{
	partial class EditImageMetadata
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.picBxPerson = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAddName = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdBtnMale = new System.Windows.Forms.RadioButton();
			this.rdBtnFemale = new System.Windows.Forms.RadioButton();
			this.btnAddEvent = new System.Windows.Forms.Button();
			this.comBxEvent = new System.Windows.Forms.ComboBox();
			this.dtPickerEventDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtPickerCaptureDate = new System.Windows.Forms.DateTimePicker();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblHeaderName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.btnSave = new System.Windows.Forms.Button();
			this.picBxInfo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBxPerson)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.Location = new System.Drawing.Point(32, 161);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(161, 20);
			this.textBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Person";
			// 
			// picBxPerson
			// 
			this.picBxPerson.Location = new System.Drawing.Point(32, 90);
			this.picBxPerson.Name = "picBxPerson";
			this.picBxPerson.Size = new System.Drawing.Size(67, 58);
			this.picBxPerson.TabIndex = 3;
			this.picBxPerson.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 278);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Event";
			// 
			// btnAddName
			// 
			this.btnAddName.BackColor = System.Drawing.Color.SandyBrown;
			this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddName.ForeColor = System.Drawing.Color.Black;
			this.btnAddName.Location = new System.Drawing.Point(199, 159);
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.Size = new System.Drawing.Size(33, 23);
			this.btnAddName.TabIndex = 6;
			this.btnAddName.Text = "+";
			this.btnAddName.UseVisualStyleBackColor = false;
			this.btnAddName.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.rdBtnMale);
			this.groupBox1.Controls.Add(this.rdBtnFemale);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(32, 198);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(161, 62);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gender";
			// 
			// rdBtnMale
			// 
			this.rdBtnMale.AutoSize = true;
			this.rdBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnMale.Location = new System.Drawing.Point(94, 29);
			this.rdBtnMale.Name = "rdBtnMale";
			this.rdBtnMale.Size = new System.Drawing.Size(55, 20);
			this.rdBtnMale.TabIndex = 1;
			this.rdBtnMale.TabStop = true;
			this.rdBtnMale.Text = "Male";
			this.rdBtnMale.UseVisualStyleBackColor = true;
			// 
			// rdBtnFemale
			// 
			this.rdBtnFemale.AutoSize = true;
			this.rdBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdBtnFemale.Location = new System.Drawing.Point(14, 29);
			this.rdBtnFemale.Name = "rdBtnFemale";
			this.rdBtnFemale.Size = new System.Drawing.Size(71, 20);
			this.rdBtnFemale.TabIndex = 0;
			this.rdBtnFemale.TabStop = true;
			this.rdBtnFemale.Text = "Female";
			this.rdBtnFemale.UseVisualStyleBackColor = true;
			// 
			// btnAddEvent
			// 
			this.btnAddEvent.BackColor = System.Drawing.Color.SandyBrown;
			this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddEvent.ForeColor = System.Drawing.Color.Black;
			this.btnAddEvent.Location = new System.Drawing.Point(199, 304);
			this.btnAddEvent.Name = "btnAddEvent";
			this.btnAddEvent.Size = new System.Drawing.Size(33, 23);
			this.btnAddEvent.TabIndex = 8;
			this.btnAddEvent.Text = "+";
			this.btnAddEvent.UseVisualStyleBackColor = false;
			// 
			// comBxEvent
			// 
			this.comBxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comBxEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comBxEvent.ForeColor = System.Drawing.Color.Teal;
			this.comBxEvent.FormattingEnabled = true;
			this.comBxEvent.Location = new System.Drawing.Point(32, 304);
			this.comBxEvent.Name = "comBxEvent";
			this.comBxEvent.Size = new System.Drawing.Size(161, 21);
			this.comBxEvent.TabIndex = 9;
			// 
			// dtPickerEventDate
			// 
			this.dtPickerEventDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtPickerEventDate.Location = new System.Drawing.Point(32, 364);
			this.dtPickerEventDate.Name = "dtPickerEventDate";
			this.dtPickerEventDate.Size = new System.Drawing.Size(200, 20);
			this.dtPickerEventDate.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(29, 335);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Event Date";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(29, 400);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 16);
			this.label5.TabIndex = 13;
			this.label5.Text = "Capture Date";
			// 
			// dtPickerCaptureDate
			// 
			this.dtPickerCaptureDate.Location = new System.Drawing.Point(32, 429);
			this.dtPickerCaptureDate.Name = "dtPickerCaptureDate";
			this.dtPickerCaptureDate.Size = new System.Drawing.Size(200, 20);
			this.dtPickerCaptureDate.TabIndex = 12;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
			this.panel1.Controls.Add(this.picBxInfo);
			this.panel1.Controls.Add(this.lblHeaderName);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(801, 51);
			this.panel1.TabIndex = 14;
			// 
			// lblHeaderName
			// 
			this.lblHeaderName.AutoSize = true;
			this.lblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeaderName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHeaderName.Location = new System.Drawing.Point(25, 11);
			this.lblHeaderName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblHeaderName.Name = "lblHeaderName";
			this.lblHeaderName.Size = new System.Drawing.Size(131, 29);
			this.lblHeaderName.TabIndex = 1;
			this.lblHeaderName.Text = "Aafi Sardar";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(520, 65);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 16);
			this.label3.TabIndex = 16;
			this.label3.Text = "Select Location";
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocationName.Location = new System.Drawing.Point(467, 459);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.Size = new System.Drawing.Size(115, 16);
			this.lblLocationName.TabIndex = 18;
			this.lblLocationName.Text = "Selected Location";
			// 
			// webViewMap
			// 
			this.webViewMap.AllowExternalDrop = true;
			this.webViewMap.CreationProperties = null;
			this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
			this.webViewMap.Location = new System.Drawing.Point(396, 85);
			this.webViewMap.Name = "webViewMap";
			this.webViewMap.Size = new System.Drawing.Size(364, 371);
			this.webViewMap.TabIndex = 19;
			this.webViewMap.ZoomFactor = 1D;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.BackgroundImage = global::PhotoGallery_Desktop.Properties.Resources.button;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(342, 464);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(114, 34);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.button5_Click_1);
			// 
			// picBxInfo
			// 
			this.picBxInfo.Image = global::PhotoGallery_Desktop.Properties.Resources.info;
			this.picBxInfo.Location = new System.Drawing.Point(754, 8);
			this.picBxInfo.Margin = new System.Windows.Forms.Padding(2);
			this.picBxInfo.Name = "picBxInfo";
			this.picBxInfo.Size = new System.Drawing.Size(35, 35);
			this.picBxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBxInfo.TabIndex = 2;
			this.picBxInfo.TabStop = false;
			// 
			// EditImageMetadata
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 508);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.webViewMap);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtPickerCaptureDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtPickerEventDate);
			this.Controls.Add(this.comBxEvent);
			this.Controls.Add(this.btnAddEvent);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAddName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picBxPerson);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditImageMetadata";
			this.Text = "EditImageMetadata";
			((System.ComponentModel.ISupportInitialize)(this.picBxPerson)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox picBxPerson;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAddName;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdBtnMale;
		private System.Windows.Forms.RadioButton rdBtnFemale;
		private System.Windows.Forms.Button btnAddEvent;
		private System.Windows.Forms.ComboBox comBxEvent;
		private System.Windows.Forms.DateTimePicker dtPickerEventDate;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtPickerCaptureDate;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblHeaderName;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLocationName;
		private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox picBxInfo;
	}
}