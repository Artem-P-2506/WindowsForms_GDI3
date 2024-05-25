namespace WindowsForms_GDI3
{
    partial class Game
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
            this.pictureBoxKnight = new System.Windows.Forms.PictureBox();
            this.pictureBoxSkeleton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkeleton)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxKnight
            // 
            this.pictureBoxKnight.Location = new System.Drawing.Point(36, 334);
            this.pictureBoxKnight.Name = "pictureBoxKnight";
            this.pictureBoxKnight.Size = new System.Drawing.Size(168, 226);
            this.pictureBoxKnight.TabIndex = 0;
            this.pictureBoxKnight.TabStop = false;
            this.pictureBoxKnight.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBoxSkeleton
            // 
            this.pictureBoxSkeleton.Location = new System.Drawing.Point(856, 353);
            this.pictureBoxSkeleton.Name = "pictureBoxSkeleton";
            this.pictureBoxSkeleton.Size = new System.Drawing.Size(194, 207);
            this.pictureBoxSkeleton.TabIndex = 1;
            this.pictureBoxSkeleton.TabStop = false;
            this.pictureBoxSkeleton.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSkeleton_Paint);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 596);
            this.Controls.Add(this.pictureBoxSkeleton);
            this.Controls.Add(this.pictureBoxKnight);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSkeleton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKnight;
        private System.Windows.Forms.PictureBox pictureBoxSkeleton;
    }
}

