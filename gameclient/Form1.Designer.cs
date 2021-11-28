
namespace gameclient
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
            this.cube1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).BeginInit();
            this.SuspendLayout();
            // 
            // cube1
            // 
            this.cube1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cube1.Location = new System.Drawing.Point(401, 241);
            this.cube1.Name = "cube1";
            this.cube1.Size = new System.Drawing.Size(100, 50);
            this.cube1.TabIndex = 0;
            this.cube1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(686, 428);
            this.Controls.Add(this.cube1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cube1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cube1;
        
    }
}

