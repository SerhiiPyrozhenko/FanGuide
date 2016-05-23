namespace OOP_FanGuide
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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoxer = new System.Windows.Forms.Button();
            this.btnBodyBuilder = new System.Windows.Forms.Button();
            this.btnFotballer = new System.Windows.Forms.Button();
            this.btnDelAllocated = new System.Windows.Forms.Button();
            this.btbDeleteAll = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DGV8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.btnBoxer);
            this.panel2.Controls.Add(this.btnBodyBuilder);
            this.panel2.Controls.Add(this.btnFotballer);
            this.panel2.Controls.Add(this.btnDelAllocated);
            this.panel2.Controls.Add(this.btbDeleteAll);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 611);
            this.panel2.TabIndex = 0;
            // 
            // btnBoxer
            // 
            this.btnBoxer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBoxer.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxer.Location = new System.Drawing.Point(35, 223);
            this.btnBoxer.Name = "btnBoxer";
            this.btnBoxer.Size = new System.Drawing.Size(163, 32);
            this.btnBoxer.TabIndex = 27;
            this.btnBoxer.Text = "Boxer";
            this.btnBoxer.UseVisualStyleBackColor = false;
            this.btnBoxer.Click += new System.EventHandler(this.btnBoxer_Click);
            // 
            // btnBodyBuilder
            // 
            this.btnBodyBuilder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBodyBuilder.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBodyBuilder.Location = new System.Drawing.Point(34, 154);
            this.btnBodyBuilder.Name = "btnBodyBuilder";
            this.btnBodyBuilder.Size = new System.Drawing.Size(164, 33);
            this.btnBodyBuilder.TabIndex = 26;
            this.btnBodyBuilder.Text = "Tennis player";
            this.btnBodyBuilder.UseVisualStyleBackColor = false;
            this.btnBodyBuilder.Click += new System.EventHandler(this.btnBodyBuilder_Click);
            // 
            // btnFotballer
            // 
            this.btnFotballer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFotballer.Font = new System.Drawing.Font("Lucida Fax", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotballer.Location = new System.Drawing.Point(35, 85);
            this.btnFotballer.Name = "btnFotballer";
            this.btnFotballer.Size = new System.Drawing.Size(163, 33);
            this.btnFotballer.TabIndex = 25;
            this.btnFotballer.Text = "Footballer";
            this.btnFotballer.UseVisualStyleBackColor = false;
            this.btnFotballer.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelAllocated
            // 
            this.btnDelAllocated.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDelAllocated.Font = new System.Drawing.Font("Lucida Fax", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAllocated.Location = new System.Drawing.Point(47, 482);
            this.btnDelAllocated.Name = "btnDelAllocated";
            this.btnDelAllocated.Size = new System.Drawing.Size(138, 41);
            this.btnDelAllocated.TabIndex = 24;
            this.btnDelAllocated.Text = "Delete allocated";
            this.btnDelAllocated.UseVisualStyleBackColor = false;
            this.btnDelAllocated.Click += new System.EventHandler(this.btnDelAllocated_Click);
            // 
            // btbDeleteAll
            // 
            this.btbDeleteAll.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btbDeleteAll.Font = new System.Drawing.Font("Lucida Fax", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbDeleteAll.Location = new System.Drawing.Point(76, 424);
            this.btbDeleteAll.Name = "btbDeleteAll";
            this.btbDeleteAll.Size = new System.Drawing.Size(75, 41);
            this.btbDeleteAll.TabIndex = 22;
            this.btbDeleteAll.Text = "Delete all";
            this.btbDeleteAll.UseVisualStyleBackColor = false;
            this.btbDeleteAll.Click += new System.EventHandler(this.button3_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(2, 364);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(225, 22);
            this.label21.TabIndex = 17;
            this.label21.Text = "Delete the sportsman";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Fax", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(209, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "Add new sportsmen";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV8,
            this.DGV1,
            this.DGV2,
            this.DGV3,
            this.DGV5,
            this.DGV4,
            this.DGV6,
            this.DGV7,
            this.DGV9,
            this.DGV10,
            this.DGV11,
            this.DGV12,
            this.DGV13,
            this.DGV14,
            this.DGV15,
            this.DGV16,
            this.DGV17});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(234, 38);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1095, 611);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1334, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGV8
            // 
            this.DGV8.HeaderText = "Sport";
            this.DGV8.Name = "DGV8";
            this.DGV8.ReadOnly = true;
            this.DGV8.Width = 70;
            // 
            // DGV1
            // 
            this.DGV1.HeaderText = "Name";
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.Width = 75;
            // 
            // DGV2
            // 
            this.DGV2.HeaderText = "Surname";
            this.DGV2.Name = "DGV2";
            this.DGV2.ReadOnly = true;
            this.DGV2.Width = 75;
            // 
            // DGV3
            // 
            this.DGV3.HeaderText = "Nationality";
            this.DGV3.Name = "DGV3";
            this.DGV3.ReadOnly = true;
            this.DGV3.Width = 70;
            // 
            // DGV5
            // 
            this.DGV5.HeaderText = "Career(years)";
            this.DGV5.Name = "DGV5";
            this.DGV5.ReadOnly = true;
            this.DGV5.Width = 75;
            // 
            // DGV4
            // 
            this.DGV4.HeaderText = "Age";
            this.DGV4.Name = "DGV4";
            this.DGV4.ReadOnly = true;
            this.DGV4.Width = 50;
            // 
            // DGV6
            // 
            this.DGV6.HeaderText = "Height";
            this.DGV6.Name = "DGV6";
            this.DGV6.ReadOnly = true;
            this.DGV6.Width = 50;
            // 
            // DGV7
            // 
            this.DGV7.HeaderText = "Weight";
            this.DGV7.Name = "DGV7";
            this.DGV7.ReadOnly = true;
            this.DGV7.Width = 50;
            // 
            // DGV9
            // 
            this.DGV9.HeaderText = "Medals";
            this.DGV9.Name = "DGV9";
            this.DGV9.ReadOnly = true;
            this.DGV9.Width = 50;
            // 
            // DGV10
            // 
            this.DGV10.HeaderText = "Wins";
            this.DGV10.Name = "DGV10";
            this.DGV10.ReadOnly = true;
            this.DGV10.Width = 50;
            // 
            // DGV11
            // 
            this.DGV11.HeaderText = "Losses";
            this.DGV11.Name = "DGV11";
            this.DGV11.ReadOnly = true;
            this.DGV11.Width = 50;
            // 
            // DGV12
            // 
            this.DGV12.HeaderText = "Knockout";
            this.DGV12.Name = "DGV12";
            this.DGV12.ReadOnly = true;
            this.DGV12.Width = 60;
            // 
            // DGV13
            // 
            this.DGV13.HeaderText = "Team";
            this.DGV13.Name = "DGV13";
            this.DGV13.ReadOnly = true;
            this.DGV13.Width = 75;
            // 
            // DGV14
            // 
            this.DGV14.HeaderText = "Salary($)";
            this.DGV14.Name = "DGV14";
            this.DGV14.ReadOnly = true;
            this.DGV14.Width = 70;
            // 
            // DGV15
            // 
            this.DGV15.HeaderText = "SeriesOfWin";
            this.DGV15.Name = "DGV15";
            this.DGV15.ReadOnly = true;
            this.DGV15.Width = 70;
            // 
            // DGV16
            // 
            this.DGV16.HeaderText = "Attack";
            this.DGV16.Name = "DGV16";
            this.DGV16.ReadOnly = true;
            this.DGV16.Width = 55;
            // 
            // DGV17
            // 
            this.DGV17.HeaderText = "Defence";
            this.DGV17.Name = "DGV17";
            this.DGV17.ReadOnly = true;
            this.DGV17.Width = 55;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1334, 661);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btbDeleteAll;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDelAllocated;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnFotballer;
        private System.Windows.Forms.Button btnBoxer;
        private System.Windows.Forms.Button btnBodyBuilder;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV17;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV16;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV15;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV14;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV13;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV10;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV5;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV8;
    }
}

