namespace PhotoGallery_Desktop
{
	partial class SearchImage
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdBtnMale = new System.Windows.Forms.RadioButton();
			this.rdBtnFemale = new System.Windows.Forms.RadioButton();
			this.comBxEvent = new System.Windows.Forms.ComboBox();
			this.dtPicker = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.picBxInfo = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
			this.btnAddDate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnAddName = new System.Windows.Forms.Button();
			this.flowPanelName = new System.Windows.Forms.FlowLayoutPanel();
			this.flowPanelDate = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
			this.SuspendLayout();
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.Location = new System.Drawing.Point(42, 112);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(161, 20);
			this.txtName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Person";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Event";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.rdBtnMale);
			this.groupBox1.Controls.Add(this.rdBtnFemale);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(42, 190);
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
			// comBxEvent
			// 
			this.comBxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.comBxEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comBxEvent.ForeColor = System.Drawing.Color.Teal;
			this.comBxEvent.FormattingEnabled = true;
			this.comBxEvent.Location = new System.Drawing.Point(42, 296);
			this.comBxEvent.Name = "comBxEvent";
			this.comBxEvent.Size = new System.Drawing.Size(161, 21);
			this.comBxEvent.TabIndex = 9;
			// 
			// dtPicker
			// 
			this.dtPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dtPicker.Location = new System.Drawing.Point(42, 356);
			this.dtPicker.Name = "dtPicker";
			this.dtPicker.Size = new System.Drawing.Size(200, 20);
			this.dtPicker.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 327);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Date";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.picBxInfo);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(801, 51);
			this.panel1.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new System.Drawing.Point(25, 11);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 29);
			this.label6.TabIndex = 1;
			this.label6.Text = "Search";
			// 
			// picBxInfo
			// 
			this.picBxInfo.Image = global::PhotoGallery_Desktop.Properties.Resources.info;
			this.picBxInfo.Location = new System.Drawing.Point(744, 7);
			this.picBxInfo.Margin = new System.Windows.Forms.Padding(2);
			this.picBxInfo.Name = "picBxInfo";
			this.picBxInfo.Size = new System.Drawing.Size(35, 35);
			this.picBxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picBxInfo.TabIndex = 0;
			this.picBxInfo.TabStop = false;
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
			// btnAddDate
			// 
			this.btnAddDate.BackColor = System.Drawing.Color.White;
			this.btnAddDate.BackgroundImage = global::PhotoGallery_Desktop.Properties.Resources.tick;
			this.btnAddDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddDate.ForeColor = System.Drawing.Color.White;
			this.btnAddDate.Location = new System.Drawing.Point(248, 354);
			this.btnAddDate.Name = "btnAddDate";
			this.btnAddDate.Size = new System.Drawing.Size(22, 22);
			this.btnAddDate.TabIndex = 20;
			this.btnAddDate.UseVisualStyleBackColor = false;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.BackgroundImage = global::PhotoGallery_Desktop.Properties.Resources.button;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.Location = new System.Drawing.Point(334, 465);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(114, 34);
			this.btnSearch.TabIndex = 15;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			// 
			// btnAddName
			// 
			this.btnAddName.BackColor = System.Drawing.Color.White;
			this.btnAddName.BackgroundImage = global::PhotoGallery_Desktop.Properties.Resources.tick;
			this.btnAddName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddName.ForeColor = System.Drawing.Color.White;
			this.btnAddName.Location = new System.Drawing.Point(209, 110);
			this.btnAddName.Name = "btnAddName";
			this.btnAddName.Size = new System.Drawing.Size(22, 22);
			this.btnAddName.TabIndex = 6;
			this.btnAddName.UseVisualStyleBackColor = false;
			this.btnAddName.Click += new System.EventHandler(this.button1_Click);
			// 
			// flowPanelName
			// 
			this.flowPanelName.Location = new System.Drawing.Point(42, 148);
			this.flowPanelName.Name = "flowPanelName";
			this.flowPanelName.Size = new System.Drawing.Size(288, 32);
			this.flowPanelName.TabIndex = 23;
			// 
			// flowPanelDate
			// 
			this.flowPanelDate.Location = new System.Drawing.Point(42, 392);
			this.flowPanelDate.Name = "flowPanelDate";
			this.flowPanelDate.Size = new System.Drawing.Size(288, 32);
			this.flowPanelDate.TabIndex = 24;
			// 
			// SearchImage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 508);
			this.Controls.Add(this.flowPanelDate);
			this.Controls.Add(this.flowPanelName);
			this.Controls.Add(this.btnAddDate);
			this.Controls.Add(this.webViewMap);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtPicker);
			this.Controls.Add(this.comBxEvent);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAddName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Name = "SearchImage";
			this.Text = "EditImageMetadata";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBxInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdBtnMale;
		private System.Windows.Forms.RadioButton rdBtnFemale;
		private System.Windows.Forms.ComboBox comBxEvent;
		private System.Windows.Forms.DateTimePicker dtPicker;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox picBxInfo;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblLocationName;
		private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
		private System.Windows.Forms.Button btnAddName;
		private System.Windows.Forms.Button btnAddDate;
		private System.Windows.Forms.FlowLayoutPanel flowPanelName;
		private System.Windows.Forms.FlowLayoutPanel flowPanelDate;
	}
}