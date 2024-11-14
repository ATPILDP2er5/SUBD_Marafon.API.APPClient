namespace Marofon.com
{
    partial class Zriteli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zriteli));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dGV_Marafon = new System.Windows.Forms.DataGridView();
            this.uide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_Who = new System.Windows.Forms.Label();
            this.dGV_Uchastniki = new System.Windows.Forms.DataGridView();
            this.F_Uchastnick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Uchastnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_Uchastnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StepAhed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Marafon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uchastniki)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 108);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочее пространство зрителя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dGV_Marafon
            // 
            this.dGV_Marafon.AllowUserToAddRows = false;
            this.dGV_Marafon.AllowUserToDeleteRows = false;
            this.dGV_Marafon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Marafon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dGV_Marafon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dGV_Marafon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Marafon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uide,
            this.NameMar,
            this.LongMar,
            this.Date_Start,
            this.Vznos});
            this.dGV_Marafon.Location = new System.Drawing.Point(244, 196);
            this.dGV_Marafon.Name = "dGV_Marafon";
            this.dGV_Marafon.ReadOnly = true;
            this.dGV_Marafon.RowHeadersWidth = 51;
            this.dGV_Marafon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV_Marafon.Size = new System.Drawing.Size(544, 307);
            this.dGV_Marafon.TabIndex = 2;
            this.dGV_Marafon.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Marafon_CellContentDoubleClick);
            // 
            // uide
            // 
            this.uide.HeaderText = "";
            this.uide.MinimumWidth = 6;
            this.uide.Name = "uide";
            this.uide.Visible = false;
            // 
            // NameMar
            // 
            this.NameMar.HeaderText = "Название Марафона";
            this.NameMar.MinimumWidth = 6;
            this.NameMar.Name = "NameMar";
            this.NameMar.ReadOnly = true;
            // 
            // LongMar
            // 
            this.LongMar.HeaderText = "Длина маршрута";
            this.LongMar.MinimumWidth = 6;
            this.LongMar.Name = "LongMar";
            this.LongMar.ReadOnly = true;
            // 
            // Date_Start
            // 
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Date_Start.DefaultCellStyle = dataGridViewCellStyle3;
            this.Date_Start.HeaderText = "Дата проведения";
            this.Date_Start.MinimumWidth = 6;
            this.Date_Start.Name = "Date_Start";
            this.Date_Start.ReadOnly = true;
            // 
            // Vznos
            // 
            this.Vznos.HeaderText = "Начачальный взнос";
            this.Vznos.MinimumWidth = 6;
            this.Vznos.Name = "Vznos";
            this.Vznos.ReadOnly = true;
            // 
            // label_Who
            // 
            this.label_Who.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.label_Who.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Who.Location = new System.Drawing.Point(12, 111);
            this.label_Who.Name = "label_Who";
            this.label_Who.Size = new System.Drawing.Size(203, 392);
            this.label_Who.TabIndex = 4;
            this.label_Who.Text = "label3";
            // 
            // dGV_Uchastniki
            // 
            this.dGV_Uchastniki.AllowUserToAddRows = false;
            this.dGV_Uchastniki.AllowUserToDeleteRows = false;
            this.dGV_Uchastniki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_Uchastniki.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGV_Uchastniki.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.dGV_Uchastniki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Uchastniki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.F_Uchastnick,
            this.I_Uchastnik,
            this.O_Uchastnika,
            this.Pol,
            this.b_day,
            this.Contry});
            this.dGV_Uchastniki.Location = new System.Drawing.Point(244, 196);
            this.dGV_Uchastniki.Name = "dGV_Uchastniki";
            this.dGV_Uchastniki.ReadOnly = true;
            this.dGV_Uchastniki.RowHeadersWidth = 51;
            this.dGV_Uchastniki.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV_Uchastniki.Size = new System.Drawing.Size(544, 307);
            this.dGV_Uchastniki.TabIndex = 5;
            // 
            // F_Uchastnick
            // 
            this.F_Uchastnick.FillWeight = 115.4822F;
            this.F_Uchastnick.HeaderText = "Фамилия";
            this.F_Uchastnick.MinimumWidth = 6;
            this.F_Uchastnick.Name = "F_Uchastnick";
            this.F_Uchastnick.ReadOnly = true;
            // 
            // I_Uchastnik
            // 
            this.I_Uchastnik.FillWeight = 115.4822F;
            this.I_Uchastnik.HeaderText = "Имя";
            this.I_Uchastnik.MinimumWidth = 6;
            this.I_Uchastnik.Name = "I_Uchastnik";
            this.I_Uchastnik.ReadOnly = true;
            // 
            // O_Uchastnika
            // 
            this.O_Uchastnika.FillWeight = 115.4822F;
            this.O_Uchastnika.HeaderText = "Отчество";
            this.O_Uchastnika.MinimumWidth = 6;
            this.O_Uchastnika.Name = "O_Uchastnika";
            this.O_Uchastnika.ReadOnly = true;
            // 
            // Pol
            // 
            this.Pol.FillWeight = 115.4822F;
            this.Pol.HeaderText = "Пол";
            this.Pol.MinimumWidth = 6;
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            // 
            // b_day
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.b_day.DefaultCellStyle = dataGridViewCellStyle4;
            this.b_day.FillWeight = 115.4822F;
            this.b_day.HeaderText = "День рождения";
            this.b_day.MinimumWidth = 6;
            this.b_day.Name = "b_day";
            this.b_day.ReadOnly = true;
            // 
            // Contry
            // 
            this.Contry.FillWeight = 115.4822F;
            this.Contry.HeaderText = "Страна";
            this.Contry.MinimumWidth = 6;
            this.Contry.Name = "Contry";
            this.Contry.ReadOnly = true;
            // 
            // StepAhed
            // 
            this.StepAhed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.StepAhed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StepAhed.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StepAhed.Location = new System.Drawing.Point(244, 114);
            this.StepAhed.Name = "StepAhed";
            this.StepAhed.Size = new System.Drawing.Size(120, 38);
            this.StepAhed.TabIndex = 34;
            this.StepAhed.Text = "<--Назад";
            this.StepAhed.UseVisualStyleBackColor = false;
            this.StepAhed.Visible = false;
            this.StepAhed.Click += new System.EventHandler(this.StepAhed_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(244, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 35;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Для просмотра участников ,интересующего вас марафона, \r\nнеобходимо сделать двойно" +
    "й щелчок мыши \r\nпо ячейке интересующего вас марафона.";
            // 
            // Zriteli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 532);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StepAhed);
            this.Controls.Add(this.dGV_Uchastniki);
            this.Controls.Add(this.label_Who);
            this.Controls.Add(this.dGV_Marafon);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zriteli";
            this.Text = "СУБД Марафон";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Zriteli_FormClosed);
            this.Load += new System.EventHandler(this.Zriteli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Marafon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Uchastniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dGV_Marafon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label_Who;
        private System.Windows.Forms.DataGridView dGV_Uchastniki;
        private System.Windows.Forms.Button StepAhed;
        private System.Windows.Forms.DataGridViewTextBoxColumn uide;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vznos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_Uchastnick;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Uchastnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn O_Uchastnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn b_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contry;
        private System.Windows.Forms.Label label2;
    }
}