namespace TaskTrees
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RandomBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DepthTBox = new System.Windows.Forms.TextBox();
            this.GetPathsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(315, 58);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(769, 593);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RandomBtn
            // 
            this.RandomBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RandomBtn.Location = new System.Drawing.Point(433, 12);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(216, 27);
            this.RandomBtn.TabIndex = 1;
            this.RandomBtn.Text = "Сгенерировать рандомное дерево";
            this.RandomBtn.UseVisualStyleBackColor = false;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите максимальную глубину дерева";
            // 
            // DepthTBox
            // 
            this.DepthTBox.Location = new System.Drawing.Point(315, 16);
            this.DepthTBox.Name = "DepthTBox";
            this.DepthTBox.Size = new System.Drawing.Size(44, 20);
            this.DepthTBox.TabIndex = 3;
            // 
            // GetPathsBtn
            // 
            this.GetPathsBtn.Location = new System.Drawing.Point(17, 71);
            this.GetPathsBtn.Name = "GetPathsBtn";
            this.GetPathsBtn.Size = new System.Drawing.Size(183, 23);
            this.GetPathsBtn.TabIndex = 6;
            this.GetPathsBtn.Text = "Получить список путей";
            this.GetPathsBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 663);
            this.Controls.Add(this.GetPathsBtn);
            this.Controls.Add(this.DepthTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RandomBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DepthTBox;
        private System.Windows.Forms.Button GetPathsBtn;
    }
}

