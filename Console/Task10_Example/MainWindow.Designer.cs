namespace Task10_Example
{
    partial class MainWindow
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
            this.InputStudentsDGV = new System.Windows.Forms.DataGridView();
            this.SortStudentsBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.InputStudentsDGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputStudentsDGV_Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InputStudentsDGV_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputStudentsDGV
            // 
            this.InputStudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputStudentsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InputStudentsDGV_Name,
            this.InputStudentsDGV_Points,
            this.InputStudentsDGV_Course});
            this.InputStudentsDGV.Location = new System.Drawing.Point(12, 39);
            this.InputStudentsDGV.Name = "InputStudentsDGV";
            this.InputStudentsDGV.Size = new System.Drawing.Size(482, 327);
            this.InputStudentsDGV.TabIndex = 0;
            // 
            // SortStudentsBtn
            // 
            this.SortStudentsBtn.Location = new System.Drawing.Point(13, 372);
            this.SortStudentsBtn.Name = "SortStudentsBtn";
            this.SortStudentsBtn.Size = new System.Drawing.Size(481, 34);
            this.SortStudentsBtn.TabIndex = 1;
            this.SortStudentsBtn.Text = "Сортировать";
            this.SortStudentsBtn.UseVisualStyleBackColor = true;
            this.SortStudentsBtn.Click += new System.EventHandler(this.SortStudentsBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuFileOpen,
            this.MainMenuFileSave});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MainMenuFileOpen
            // 
            this.MainMenuFileOpen.Name = "MainMenuFileOpen";
            this.MainMenuFileOpen.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileOpen.Text = "Открыть";
            this.MainMenuFileOpen.Click += new System.EventHandler(this.MainMenuFileOpen_Click);
            // 
            // MainMenuFileSave
            // 
            this.MainMenuFileSave.Name = "MainMenuFileSave";
            this.MainMenuFileSave.Size = new System.Drawing.Size(132, 22);
            this.MainMenuFileSave.Text = "Сохранить";
            this.MainMenuFileSave.Click += new System.EventHandler(this.MainMenuFileSave_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // InputStudentsDGV_Name
            // 
            this.InputStudentsDGV_Name.HeaderText = "Имя  фамилия и отчество студента";
            this.InputStudentsDGV_Name.Name = "InputStudentsDGV_Name";
            this.InputStudentsDGV_Name.Width = 200;
            // 
            // InputStudentsDGV_Points
            // 
            this.InputStudentsDGV_Points.HeaderText = "Группа";
            this.InputStudentsDGV_Points.Name = "InputStudentsDGV_Points";
            // 
            // InputStudentsDGV_Course
            // 
            this.InputStudentsDGV_Course.HeaderText = "Курс";
            this.InputStudentsDGV_Course.Name = "InputStudentsDGV_Course";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 411);
            this.Controls.Add(this.SortStudentsBtn);
            this.Controls.Add(this.InputStudentsDGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Заготовка для задачи 10";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InputStudentsDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputStudentsDGV;
        private System.Windows.Forms.Button SortStudentsBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem MainMenuFileSave;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_Points;
        private System.Windows.Forms.DataGridViewTextBoxColumn InputStudentsDGV_Course;
    }
}

