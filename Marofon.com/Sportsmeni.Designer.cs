namespace Marofon.com
{
    partial class Sportsmeni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sportsmeni));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Who = new System.Windows.Forms.Label();
            this.dGV_Marafon = new System.Windows.Forms.DataGridView();
            this.uide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LongMar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uchastie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Marafon)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 132);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Рабочее пространство спортсмена";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(325, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 47);
            this.button1.TabIndex = 41;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Who
            // 
            this.label_Who.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.label_Who.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Who.Location = new System.Drawing.Point(16, 150);
            this.label_Who.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Who.Name = "label_Who";
            this.label_Who.Size = new System.Drawing.Size(301, 482);
            this.label_Who.TabIndex = 38;
            this.label_Who.Text = "label3";
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
            this.Vznos,
            this.Uchastie});
            this.dGV_Marafon.Location = new System.Drawing.Point(325, 204);
            this.dGV_Marafon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGV_Marafon.Name = "dGV_Marafon";
            this.dGV_Marafon.ReadOnly = true;
            this.dGV_Marafon.RowHeadersWidth = 51;
            this.dGV_Marafon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV_Marafon.Size = new System.Drawing.Size(792, 428);
            this.dGV_Marafon.TabIndex = 37;
            this.dGV_Marafon.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Marafon_CellContentDoubleClick);
            // 
            // uide
            // 
            this.uide.HeaderText = "";
            this.uide.MinimumWidth = 6;
            this.uide.Name = "uide";
            this.uide.ReadOnly = true;
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
            // Uchastie
            // 
            this.Uchastie.HeaderText = "Ваше участвие на марафоне";
            this.Uchastie.MinimumWidth = 6;
            this.Uchastie.Name = "Uchastie";
            this.Uchastie.ReadOnly = true;
            this.Uchastie.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 32);
            this.label2.TabIndex = 42;
            this.label2.Text = "Для записи на участие или отписки от участия в любом марафоне \r\nнеобходимо сделат" +
    "ь двойной щелчок мыши по ячейке интересующего вас марафона.";
            // 
            // Sportsmeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 673);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Who);
            this.Controls.Add(this.dGV_Marafon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Sportsmeni";
            this.Text = "СУБД Марафон";
            this.Load += new System.EventHandler(this.Sportsmeni_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Marafon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Who;
        private System.Windows.Forms.DataGridView dGV_Marafon;
        private System.Windows.Forms.DataGridViewTextBoxColumn uide;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn LongMar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uchastie;
        private System.Windows.Forms.Label label2;
    }
}