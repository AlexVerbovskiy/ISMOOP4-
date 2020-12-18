
namespace OOP4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDisks = new System.Windows.Forms.DataGridView();
            this.buttonDisks = new System.Windows.Forms.Button();
            this.dataGridViewDiskInfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewCatalogInfo = new System.Windows.Forms.DataGridView();
            this.buttonDiskInfo = new System.Windows.Forms.Button();
            this.buttonCatalogInfo = new System.Windows.Forms.Button();
            this.labelDiskText = new System.Windows.Forms.Label();
            this.textBoxCatalog = new System.Windows.Forms.TextBox();
            this.textBoxDisk = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonFileInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateCreate = new System.Windows.Forms.Label();
            this.labelTextLen = new System.Windows.Forms.Label();
            this.labelLen = new System.Windows.Forms.Label();
            this.labelDateChange = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelCatalogText = new System.Windows.Forms.Label();
            this.labelNameDisk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiskInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisks
            // 
            this.dataGridViewDisks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisks.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewDisks.Name = "dataGridViewDisks";
            this.dataGridViewDisks.RowHeadersWidth = 51;
            this.dataGridViewDisks.RowTemplate.Height = 24;
            this.dataGridViewDisks.Size = new System.Drawing.Size(776, 164);
            this.dataGridViewDisks.TabIndex = 0;
            // 
            // buttonDisks
            // 
            this.buttonDisks.Location = new System.Drawing.Point(220, 4);
            this.buttonDisks.Name = "buttonDisks";
            this.buttonDisks.Size = new System.Drawing.Size(122, 26);
            this.buttonDisks.TabIndex = 1;
            this.buttonDisks.Text = "Обрахувати";
            this.buttonDisks.UseVisualStyleBackColor = true;
            this.buttonDisks.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewDiskInfo
            // 
            this.dataGridViewDiskInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiskInfo.Location = new System.Drawing.Point(444, 247);
            this.dataGridViewDiskInfo.Name = "dataGridViewDiskInfo";
            this.dataGridViewDiskInfo.RowHeadersWidth = 100;
            this.dataGridViewDiskInfo.RowTemplate.Height = 24;
            this.dataGridViewDiskInfo.Size = new System.Drawing.Size(315, 111);
            this.dataGridViewDiskInfo.TabIndex = 0;
            // 
            // dataGridViewCatalogInfo
            // 
            this.dataGridViewCatalogInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogInfo.Location = new System.Drawing.Point(444, 364);
            this.dataGridViewCatalogInfo.Name = "dataGridViewCatalogInfo";
            this.dataGridViewCatalogInfo.RowHeadersWidth = 100;
            this.dataGridViewCatalogInfo.RowTemplate.Height = 24;
            this.dataGridViewCatalogInfo.Size = new System.Drawing.Size(315, 111);
            this.dataGridViewCatalogInfo.TabIndex = 0;
            // 
            // buttonDiskInfo
            // 
            this.buttonDiskInfo.Location = new System.Drawing.Point(290, 290);
            this.buttonDiskInfo.Name = "buttonDiskInfo";
            this.buttonDiskInfo.Size = new System.Drawing.Size(148, 41);
            this.buttonDiskInfo.TabIndex = 2;
            this.buttonDiskInfo.Text = "Обрахувати";
            this.buttonDiskInfo.UseVisualStyleBackColor = true;
            this.buttonDiskInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCatalogInfo
            // 
            this.buttonCatalogInfo.Location = new System.Drawing.Point(290, 396);
            this.buttonCatalogInfo.Name = "buttonCatalogInfo";
            this.buttonCatalogInfo.Size = new System.Drawing.Size(148, 41);
            this.buttonCatalogInfo.TabIndex = 3;
            this.buttonCatalogInfo.Text = "Обрахувати";
            this.buttonCatalogInfo.UseVisualStyleBackColor = true;
            this.buttonCatalogInfo.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelDiskText
            // 
            this.labelDiskText.AutoSize = true;
            this.labelDiskText.Location = new System.Drawing.Point(12, 9);
            this.labelDiskText.Name = "labelDiskText";
            this.labelDiskText.Size = new System.Drawing.Size(202, 17);
            this.labelDiskText.TabIndex = 4;
            this.labelDiskText.Text = "Інформація про наявні диски:\r\n";
            // 
            // textBoxCatalog
            // 
            this.textBoxCatalog.Location = new System.Drawing.Point(175, 405);
            this.textBoxCatalog.Name = "textBoxCatalog";
            this.textBoxCatalog.Size = new System.Drawing.Size(109, 22);
            this.textBoxCatalog.TabIndex = 5;
            this.textBoxCatalog.Text = "Шлях каталога";
            // 
            // textBoxDisk
            // 
            this.textBoxDisk.Location = new System.Drawing.Point(178, 302);
            this.textBoxDisk.Name = "textBoxDisk";
            this.textBoxDisk.Size = new System.Drawing.Size(106, 22);
            this.textBoxDisk.TabIndex = 6;
            this.textBoxDisk.Text = "Ім`я диску";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(223, 493);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(93, 22);
            this.textBoxFile.TabIndex = 7;
            this.textBoxFile.Text = "Шлях файла";
            // 
            // buttonFileInfo
            // 
            this.buttonFileInfo.Location = new System.Drawing.Point(322, 481);
            this.buttonFileInfo.Name = "buttonFileInfo";
            this.buttonFileInfo.Size = new System.Drawing.Size(148, 41);
            this.buttonFileInfo.TabIndex = 8;
            this.buttonFileInfo.Text = "Обрахувати";
            this.buttonFileInfo.UseVisualStyleBackColor = true;
            this.buttonFileInfo.Click += new System.EventHandler(this.buttonFileInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 558);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата створення файла:";
            // 
            // labelDateCreate
            // 
            this.labelDateCreate.AutoSize = true;
            this.labelDateCreate.Location = new System.Drawing.Point(182, 558);
            this.labelDateCreate.Name = "labelDateCreate";
            this.labelDateCreate.Size = new System.Drawing.Size(0, 17);
            this.labelDateCreate.TabIndex = 10;
            // 
            // labelTextLen
            // 
            this.labelTextLen.AutoSize = true;
            this.labelTextLen.Location = new System.Drawing.Point(10, 527);
            this.labelTextLen.Name = "labelTextLen";
            this.labelTextLen.Size = new System.Drawing.Size(103, 17);
            this.labelTextLen.TabIndex = 9;
            this.labelTextLen.Text = "Розмір файла:";
            // 
            // labelLen
            // 
            this.labelLen.AutoSize = true;
            this.labelLen.Location = new System.Drawing.Point(119, 527);
            this.labelLen.Name = "labelLen";
            this.labelLen.Size = new System.Drawing.Size(0, 17);
            this.labelLen.TabIndex = 10;
            // 
            // labelDateChange
            // 
            this.labelDateChange.AutoSize = true;
            this.labelDateChange.Location = new System.Drawing.Point(212, 587);
            this.labelDateChange.Name = "labelDateChange";
            this.labelDateChange.Size = new System.Drawing.Size(0, 17);
            this.labelDateChange.TabIndex = 12;
            this.labelDateChange.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата останньої зміни файла:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(10, 493);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(211, 17);
            this.labelF.TabIndex = 13;
            this.labelF.Text = "Введіть шлях файла(в байтах):";
            // 
            // labelCatalogText
            // 
            this.labelCatalogText.AutoSize = true;
            this.labelCatalogText.Location = new System.Drawing.Point(9, 408);
            this.labelCatalogText.Name = "labelCatalogText";
            this.labelCatalogText.Size = new System.Drawing.Size(160, 17);
            this.labelCatalogText.TabIndex = 14;
            this.labelCatalogText.Text = "Введіть шлях каталогу:";
            // 
            // labelNameDisk
            // 
            this.labelNameDisk.AutoSize = true;
            this.labelNameDisk.Location = new System.Drawing.Point(12, 302);
            this.labelNameDisk.Name = "labelNameDisk";
            this.labelNameDisk.Size = new System.Drawing.Size(160, 17);
            this.labelNameDisk.TabIndex = 15;
            this.labelNameDisk.Text = "Введіть шлях каталогу:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.labelNameDisk);
            this.Controls.Add(this.labelCatalogText);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelDateChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelLen);
            this.Controls.Add(this.labelDateCreate);
            this.Controls.Add(this.labelTextLen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFileInfo);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxDisk);
            this.Controls.Add(this.textBoxCatalog);
            this.Controls.Add(this.labelDiskText);
            this.Controls.Add(this.buttonCatalogInfo);
            this.Controls.Add(this.buttonDiskInfo);
            this.Controls.Add(this.dataGridViewCatalogInfo);
            this.Controls.Add(this.dataGridViewDiskInfo);
            this.Controls.Add(this.buttonDisks);
            this.Controls.Add(this.dataGridViewDisks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiskInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisks;
        private System.Windows.Forms.Button buttonDisks;
        private System.Windows.Forms.DataGridView dataGridViewDiskInfo;
        private System.Windows.Forms.DataGridView dataGridViewCatalogInfo;
        private System.Windows.Forms.Button buttonDiskInfo;
        private System.Windows.Forms.Button buttonCatalogInfo;
        private System.Windows.Forms.Label labelDiskText;
        private System.Windows.Forms.TextBox textBoxCatalog;
        private System.Windows.Forms.TextBox textBoxDisk;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonFileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateCreate;
        private System.Windows.Forms.Label labelTextLen;
        private System.Windows.Forms.Label labelLen;
        private System.Windows.Forms.Label labelDateChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelCatalogText;
        private System.Windows.Forms.Label labelNameDisk;
    }
}

