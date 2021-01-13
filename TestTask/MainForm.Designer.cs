namespace TestTask {
	partial class MainForm {
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.buttonStartFind = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioByte = new System.Windows.Forms.RadioButton();
            this.radioText = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(140, 23);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(420, 20);
            this.textBoxFolder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стартовая директория";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(140, 59);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(420, 20);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаблон названия файла";
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(587, 20);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(122, 23);
            this.buttonOpenFolder.TabIndex = 4;
            this.buttonOpenFolder.Text = "Открыть";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // buttonStartFind
            // 
            this.buttonStartFind.Location = new System.Drawing.Point(587, 59);
            this.buttonStartFind.Name = "buttonStartFind";
            this.buttonStartFind.Size = new System.Drawing.Size(122, 23);
            this.buttonStartFind.TabIndex = 5;
            this.buttonStartFind.Text = "Найти";
            this.buttonStartFind.UseVisualStyleBackColor = true;
            this.buttonStartFind.Click += new System.EventHandler(this.buttonStartFind_Click);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 441);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 13);
            this.Status.TabIndex = 7;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(189, 142);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(599, 296);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(5, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 290);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioByte
            // 
            this.radioByte.AutoSize = true;
            this.radioByte.Location = new System.Drawing.Point(652, 119);
            this.radioByte.Name = "radioByte";
            this.radioByte.Size = new System.Drawing.Size(57, 17);
            this.radioByte.TabIndex = 10;
            this.radioByte.Tag = "showFormat";
            this.radioByte.Text = "Байты";
            this.radioByte.UseVisualStyleBackColor = true;
            // 
            // radioText
            // 
            this.radioText.AutoSize = true;
            this.radioText.Checked = true;
            this.radioText.Location = new System.Drawing.Point(733, 119);
            this.radioText.Name = "radioText";
            this.radioText.Size = new System.Drawing.Size(55, 17);
            this.radioText.TabIndex = 11;
            this.radioText.TabStop = true;
            this.radioText.Tag = "showFormat";
            this.radioText.Text = "Текст";
            this.radioText.UseVisualStyleBackColor = true;
            this.radioText.CheckedChanged += new System.EventHandler(this.radioText_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.radioText);
            this.Controls.Add(this.radioByte);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.buttonStartFind);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "Open Finder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxFolder;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxFileName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.Button buttonOpenFolder;
		private System.Windows.Forms.Button buttonStartFind;
		private System.Windows.Forms.Label Status;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.RadioButton radioByte;
		private System.Windows.Forms.RadioButton radioText;
	}
}

