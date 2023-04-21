namespace MyPersonClass
{
    partial class Main
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
            this.Head = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Head
            // 
            this.Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Head.ForeColor = System.Drawing.Color.White;
            this.Head.Location = new System.Drawing.Point(12, 18);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(416, 37);
            this.Head.TabIndex = 0;
            this.Head.Text = "Введите имя, фамилию и дату рождения";
            this.Head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.Black;
            this.close.Location = new System.Drawing.Point(410, -1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 19);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.CadetBlue;
            this.name.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(132, 73);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(185, 33);
            this.name.TabIndex = 2;
            this.name.Text = "Имя";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.CadetBlue;
            this.surname.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(132, 124);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(185, 33);
            this.surname.TabIndex = 3;
            this.surname.Text = "Фамилия";
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
  
            // 
            // date
            // 
            this.date.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(153)))), ((int)(((byte)(195)))));
            this.date.CalendarTitleBackColor = System.Drawing.Color.Aquamarine;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.Location = new System.Drawing.Point(102, 174);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(244, 26);
            this.date.TabIndex = 4;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.Location = new System.Drawing.Point(106, 227);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(235, 35);
            this.view.TabIndex = 5;
            this.view.Text = "Отобразить запись";
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.View_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(427, 356);
            this.Controls.Add(this.view);
            this.Controls.Add(this.date);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Head);
            this.ForeColor = System.Drawing.Color.Gray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonClass";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Head;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button view;
    }
}

