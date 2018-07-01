namespace Sort
{
    partial class SortForm
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
            this.buttonUbiv = new System.Windows.Forms.Button();
            this.buttonVozr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonUbiv
            // 
            this.buttonUbiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUbiv.Location = new System.Drawing.Point(169, 183);
            this.buttonUbiv.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUbiv.Name = "buttonUbiv";
            this.buttonUbiv.Size = new System.Drawing.Size(104, 49);
            this.buttonUbiv.TabIndex = 7;
            this.buttonUbiv.Text = "По убыванию";
            this.buttonUbiv.UseVisualStyleBackColor = true;
            this.buttonUbiv.Click += new System.EventHandler(this.buttonUbiv_Click);
            // 
            // buttonVozr
            // 
            this.buttonVozr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVozr.Location = new System.Drawing.Point(169, 59);
            this.buttonVozr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVozr.Name = "buttonVozr";
            this.buttonVozr.Size = new System.Drawing.Size(104, 49);
            this.buttonVozr.TabIndex = 6;
            this.buttonVozr.Text = "По возрастанию";
            this.buttonVozr.UseVisualStyleBackColor = true;
            this.buttonVozr.Click += new System.EventHandler(this.buttonVozr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Points:";
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Location = new System.Drawing.Point(11, 45);
            this.textBoxPoints.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPoints.Multiline = true;
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(130, 232);
            this.textBoxPoints.TabIndex = 4;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 317);
            this.Controls.Add(this.buttonUbiv);
            this.Controls.Add(this.buttonVozr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPoints);
            this.Name = "SortForm";
            this.Text = "SortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUbiv;
        private System.Windows.Forms.Button buttonVozr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPoints;
    }
}

