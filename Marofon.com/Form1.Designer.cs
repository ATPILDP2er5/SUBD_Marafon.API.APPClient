namespace Marofon.com
{
    partial class FormAvtorizate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvtorizate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_Login = new System.Windows.Forms.TextBox();
            this.tBox_Pass = new System.Windows.Forms.TextBox();
            this.link_Redactor = new System.Windows.Forms.LinkLabel();
            this.But_Next = new System.Windows.Forms.Button();
            this.pBoxVizitor = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVizitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(398, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(106, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // tBox_Login
            // 
            this.tBox_Login.Location = new System.Drawing.Point(59, 151);
            this.tBox_Login.Name = "tBox_Login";
            this.tBox_Login.Size = new System.Drawing.Size(226, 22);
            this.tBox_Login.TabIndex = 3;
            // 
            // tBox_Pass
            // 
            this.tBox_Pass.Location = new System.Drawing.Point(59, 211);
            this.tBox_Pass.Name = "tBox_Pass";
            this.tBox_Pass.Size = new System.Drawing.Size(203, 22);
            this.tBox_Pass.TabIndex = 4;
            // 
            // link_Redactor
            // 
            this.link_Redactor.AutoSize = true;
            this.link_Redactor.Location = new System.Drawing.Point(56, 327);
            this.link_Redactor.Name = "link_Redactor";
            this.link_Redactor.Size = new System.Drawing.Size(260, 16);
            this.link_Redactor.TabIndex = 5;
            this.link_Redactor.TabStop = true;
            this.link_Redactor.Text = "Зарегистрирйтесь, если у вас нет учетной записи";
            this.link_Redactor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_Redactor_LinkClicked);
            // 
            // But_Next
            // 
            this.But_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(156)))), ((int)(((byte)(26)))));
            this.But_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.But_Next.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.But_Next.Location = new System.Drawing.Point(259, 268);
            this.But_Next.Name = "But_Next";
            this.But_Next.Size = new System.Drawing.Size(75, 35);
            this.But_Next.TabIndex = 6;
            this.But_Next.Text = "Войти";
            this.But_Next.UseVisualStyleBackColor = false;
            this.But_Next.Click += new System.EventHandler(this.But_Next_Click);
            // 
            // pBoxVizitor
            // 
            this.pBoxVizitor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBoxVizitor.Image = global::Marofon.com.Properties.Resources.Невидит;
            this.pBoxVizitor.Location = new System.Drawing.Point(259, 211);
            this.pBoxVizitor.Name = "pBoxVizitor";
            this.pBoxVizitor.Size = new System.Drawing.Size(26, 22);
            this.pBoxVizitor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxVizitor.TabIndex = 7;
            this.pBoxVizitor.TabStop = false;
            this.pBoxVizitor.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormAvtorizate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 388);
            this.Controls.Add(this.pBoxVizitor);
            this.Controls.Add(this.But_Next);
            this.Controls.Add(this.link_Redactor);
            this.Controls.Add(this.tBox_Pass);
            this.Controls.Add(this.tBox_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAvtorizate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД Марафон";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAvtorizate_FormClosing);
            this.Load += new System.EventHandler(this.FormAvtorizate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxVizitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_Login;
        private System.Windows.Forms.TextBox tBox_Pass;
        private System.Windows.Forms.LinkLabel link_Redactor;
        private System.Windows.Forms.Button But_Next;
        private System.Windows.Forms.PictureBox pBoxVizitor;
    }
}

