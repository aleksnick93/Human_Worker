namespace Human_Worker
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
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.thirdnameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.maiLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.surnameTBox = new System.Windows.Forms.TextBox();
            this.nameTBox = new System.Windows.Forms.TextBox();
            this.thirdnameTBox = new System.Windows.Forms.TextBox();
            this.phoneTBox = new System.Windows.Forms.TextBox();
            this.maiTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            this.surnameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(193, 13);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 1;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // nameLabel
            // 
            this.nameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(193, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Имя:";
            // 
            // thirdnameLabel
            // 
            this.thirdnameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.thirdnameLabel.AutoSize = true;
            this.thirdnameLabel.Location = new System.Drawing.Point(193, 58);
            this.thirdnameLabel.Name = "thirdnameLabel";
            this.thirdnameLabel.Size = new System.Drawing.Size(57, 13);
            this.thirdnameLabel.TabIndex = 3;
            this.thirdnameLabel.Text = "Отчество:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(193, 140);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 13);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Телефон:";
            // 
            // maiLabel
            // 
            this.maiLabel.AutoSize = true;
            this.maiLabel.Location = new System.Drawing.Point(193, 162);
            this.maiLabel.Name = "maiLabel";
            this.maiLabel.Size = new System.Drawing.Size(107, 13);
            this.maiLabel.TabIndex = 5;
            this.maiLabel.Text = "Электронная почта:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Human_Worker.Properties.Resources.seminar_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(196, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PhotoBox
            // 
            this.PhotoBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.PhotoBox.BackColor = System.Drawing.Color.White;
            this.PhotoBox.BackgroundImage = global::Human_Worker.Properties.Resources._4;
            this.PhotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoBox.Location = new System.Drawing.Point(13, 13);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(153, 162);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 0;
            this.PhotoBox.TabStop = false;
            // 
            // surnameTBox
            // 
            this.surnameTBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.surnameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.surnameTBox.Location = new System.Drawing.Point(259, 10);
            this.surnameTBox.Name = "surnameTBox";
            this.surnameTBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTBox.TabIndex = 7;
            // 
            // nameTBox
            // 
            this.nameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.nameTBox.Location = new System.Drawing.Point(259, 33);
            this.nameTBox.Name = "nameTBox";
            this.nameTBox.Size = new System.Drawing.Size(100, 20);
            this.nameTBox.TabIndex = 8;
            // 
            // thirdnameTBox
            // 
            this.thirdnameTBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.thirdnameTBox.BackColor = System.Drawing.SystemColors.Control;
            this.thirdnameTBox.Location = new System.Drawing.Point(259, 55);
            this.thirdnameTBox.Name = "thirdnameTBox";
            this.thirdnameTBox.Size = new System.Drawing.Size(100, 20);
            this.thirdnameTBox.TabIndex = 9;
            // 
            // phoneTBox
            // 
            this.phoneTBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.phoneTBox.BackColor = System.Drawing.SystemColors.Control;
            this.phoneTBox.Location = new System.Drawing.Point(311, 137);
            this.phoneTBox.Name = "phoneTBox";
            this.phoneTBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTBox.TabIndex = 10;
            // 
            // maiTBox
            // 
            this.maiTBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.maiTBox.BackColor = System.Drawing.SystemColors.Control;
            this.maiTBox.Location = new System.Drawing.Point(311, 159);
            this.maiTBox.Name = "maiTBox";
            this.maiTBox.Size = new System.Drawing.Size(100, 20);
            this.maiTBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(505, 427);
            this.Controls.Add(this.maiTBox);
            this.Controls.Add(this.phoneTBox);
            this.Controls.Add(this.thirdnameTBox);
            this.Controls.Add(this.nameTBox);
            this.Controls.Add(this.surnameTBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maiLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.thirdnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.PhotoBox);
            this.Name = "Form1";
            this.Text = "Учёт эффективности сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label thirdnameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label maiLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox surnameTBox;
        private System.Windows.Forms.TextBox nameTBox;
        private System.Windows.Forms.TextBox thirdnameTBox;
        private System.Windows.Forms.TextBox phoneTBox;
        private System.Windows.Forms.TextBox maiTBox;
    }
}

