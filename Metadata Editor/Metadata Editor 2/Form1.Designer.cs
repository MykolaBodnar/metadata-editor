namespace Metadata_Editor_2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGanre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.виконавецьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.альбомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кількістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зображенняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.буферToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAlbum,
            this.ColumnArtist,
            this.ColumnGanre,
            this.ColumnTN,
            this.ColumnTC,
            this.ColumnYear});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(216, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 200;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(883, 431);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Назва";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 130;
            // 
            // ColumnAlbum
            // 
            this.ColumnAlbum.HeaderText = "Альбом";
            this.ColumnAlbum.Name = "ColumnAlbum";
            this.ColumnAlbum.Width = 130;
            // 
            // ColumnArtist
            // 
            this.ColumnArtist.HeaderText = "Виконавець";
            this.ColumnArtist.Name = "ColumnArtist";
            this.ColumnArtist.Width = 130;
            // 
            // ColumnGanre
            // 
            this.ColumnGanre.HeaderText = "Жанр";
            this.ColumnGanre.Name = "ColumnGanre";
            // 
            // ColumnTN
            // 
            this.ColumnTN.HeaderText = "Номер";
            this.ColumnTN.Name = "ColumnTN";
            this.ColumnTN.Width = 50;
            // 
            // ColumnTC
            // 
            this.ColumnTC.HeaderText = "К-сть";
            this.ColumnTC.Name = "ColumnTC";
            this.ColumnTC.Width = 50;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Рік";
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 431);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(10, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Копіювати до буфера";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(10, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 29);
            this.button3.TabIndex = 8;
            this.button3.Text = "Вставити з буфера";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(109, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Зберегти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(10, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Вибрати зображення";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File name";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(7, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Розмір:  500x500";
            this.label2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(11, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Відкрити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.виконавецьToolStripMenuItem,
            this.альбомToolStripMenuItem,
            this.жанрToolStripMenuItem,
            this.рікToolStripMenuItem,
            this.кількістьToolStripMenuItem,
            this.зображенняToolStripMenuItem,
            this.очиститиToolStripMenuItem,
            this.буферToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 180);
            // 
            // виконавецьToolStripMenuItem
            // 
            this.виконавецьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.виконавецьToolStripMenuItem.Name = "виконавецьToolStripMenuItem";
            this.виконавецьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.виконавецьToolStripMenuItem.Text = "Виконавець";
            this.виконавецьToolStripMenuItem.Click += new System.EventHandler(this.виконавецьToolStripMenuItem_Click);
            // 
            // альбомToolStripMenuItem
            // 
            this.альбомToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.альбомToolStripMenuItem.Name = "альбомToolStripMenuItem";
            this.альбомToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.альбомToolStripMenuItem.Text = "Альбом";
            this.альбомToolStripMenuItem.Click += new System.EventHandler(this.альбомToolStripMenuItem_Click);
            // 
            // жанрToolStripMenuItem
            // 
            this.жанрToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.жанрToolStripMenuItem.Name = "жанрToolStripMenuItem";
            this.жанрToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.жанрToolStripMenuItem.Text = "Жанр";
            this.жанрToolStripMenuItem.Click += new System.EventHandler(this.жанрToolStripMenuItem_Click);
            // 
            // рікToolStripMenuItem
            // 
            this.рікToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.рікToolStripMenuItem.Name = "рікToolStripMenuItem";
            this.рікToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.рікToolStripMenuItem.Text = "Рік";
            this.рікToolStripMenuItem.Click += new System.EventHandler(this.рікToolStripMenuItem_Click);
            // 
            // кількістьToolStripMenuItem
            // 
            this.кількістьToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.кількістьToolStripMenuItem.Name = "кількістьToolStripMenuItem";
            this.кількістьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.кількістьToolStripMenuItem.Text = "Кількість";
            this.кількістьToolStripMenuItem.Click += new System.EventHandler(this.кількістьToolStripMenuItem_Click);
            // 
            // зображенняToolStripMenuItem
            // 
            this.зображенняToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.зображенняToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.зображенняToolStripMenuItem.Name = "зображенняToolStripMenuItem";
            this.зображенняToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.зображенняToolStripMenuItem.Text = "Зображення";
            this.зображенняToolStripMenuItem.Click += new System.EventHandler(this.зображенняToolStripMenuItem_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // буферToolStripMenuItem
            // 
            this.буферToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.буферToolStripMenuItem.Name = "буферToolStripMenuItem";
            this.буферToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.буферToolStripMenuItem.Text = "Буфер";
            this.буферToolStripMenuItem.Click += new System.EventHandler(this.буферToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.BackColor = System.Drawing.Color.Black;
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.ShowImageMargin = false;
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(102, 22);
            this.toolStripMenuItem6.Text = "Очистити";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1099, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Metadata Editor 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGanre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem виконавецьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem альбомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рікToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кількістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem зображенняToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem буферToolStripMenuItem;
    }
}

