namespace KvalEgzPM01
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открыть_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выход_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.Стчатус_Расчёта_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Статус_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Cheak_button = new System.Windows.Forms.Button();
            this.X_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.X_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Y_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открыть_ToolStripMenuItem,
            this.выход_ToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открыть_ToolStripMenuItem
            // 
            this.открыть_ToolStripMenuItem.Name = "открыть_ToolStripMenuItem";
            this.открыть_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.открыть_ToolStripMenuItem.Text = "Открыть";
            this.открыть_ToolStripMenuItem.Click += new System.EventHandler(this.открыть_ToolStripMenuItem_Click);
            // 
            // выход_ToolStripMenuItem
            // 
            this.выход_ToolStripMenuItem.Name = "выход_ToolStripMenuItem";
            this.выход_ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.выход_ToolStripMenuItem.Text = "Выход";
            this.выход_ToolStripMenuItem.Click += new System.EventHandler(this.выход_ToolStripMenuItem_Click);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.опрограммеToolStripMenuItem.Text = "Опрограмме";
            this.опрограммеToolStripMenuItem.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Стчатус_Расчёта_toolStripStatusLabel,
            this.Статус_toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 529);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1104, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // Стчатус_Расчёта_toolStripStatusLabel
            // 
            this.Стчатус_Расчёта_toolStripStatusLabel.Name = "Стчатус_Расчёта_toolStripStatusLabel";
            this.Стчатус_Расчёта_toolStripStatusLabel.Size = new System.Drawing.Size(109, 20);
            this.Стчатус_Расчёта_toolStripStatusLabel.Text = "Статус русчёта";
            // 
            // Статус_toolStripStatusLabel
            // 
            this.Статус_toolStripStatusLabel.Name = "Статус_toolStripStatusLabel";
            this.Статус_toolStripStatusLabel.Size = new System.Drawing.Size(0, 20);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(0, 31);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1104, 374);
            this.webBrowser.TabIndex = 2;
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Cheak_button
            // 
            this.Cheak_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cheak_button.Location = new System.Drawing.Point(343, 435);
            this.Cheak_button.Name = "Cheak_button";
            this.Cheak_button.Size = new System.Drawing.Size(300, 73);
            this.Cheak_button.TabIndex = 5;
            this.Cheak_button.Text = "Проверка принадлежности точки к области";
            this.Cheak_button.UseVisualStyleBackColor = true;
            this.Cheak_button.Click += new System.EventHandler(this.Cheak_button_Click);
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_label.Location = new System.Drawing.Point(12, 430);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(141, 24);
            this.X_label.TabIndex = 6;
            this.X_label.Text = "Координата x";
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_label.Location = new System.Drawing.Point(11, 484);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(142, 24);
            this.Y_label.TabIndex = 7;
            this.Y_label.Text = "Координата y";
            // 
            // X_numericUpDown
            // 
            this.X_numericUpDown.DecimalPlaces = 1;
            this.X_numericUpDown.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X_numericUpDown.Location = new System.Drawing.Point(183, 428);
            this.X_numericUpDown.Name = "X_numericUpDown";
            this.X_numericUpDown.Size = new System.Drawing.Size(120, 32);
            this.X_numericUpDown.TabIndex = 8;
            // 
            // Y_numericUpDown
            // 
            this.Y_numericUpDown.DecimalPlaces = 1;
            this.Y_numericUpDown.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y_numericUpDown.Location = new System.Drawing.Point(183, 482);
            this.Y_numericUpDown.Name = "Y_numericUpDown";
            this.Y_numericUpDown.Size = new System.Drawing.Size(120, 32);
            this.Y_numericUpDown.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 554);
            this.Controls.Add(this.Y_numericUpDown);
            this.Controls.Add(this.X_numericUpDown);
            this.Controls.Add(this.Y_label);
            this.Controls.Add(this.X_label);
            this.Controls.Add(this.Cheak_button);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Автоматизация расчёта";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ToolStripMenuItem открыть_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выход_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel Стчатус_Расчёта_toolStripStatusLabel;
        private System.Windows.Forms.Button Cheak_button;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.NumericUpDown X_numericUpDown;
        private System.Windows.Forms.NumericUpDown Y_numericUpDown;
        private System.Windows.Forms.ToolStripStatusLabel Статус_toolStripStatusLabel;
    }
}

