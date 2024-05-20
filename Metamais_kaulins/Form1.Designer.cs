namespace Programma83
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picMetamaisKaulins = new System.Windows.Forms.PictureBox();
            this.labPunkti = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picMetamaisKaulins)).BeginInit();
            this.SuspendLayout();
            // 
            // picMetamaisKaulins
            // 
            this.picMetamaisKaulins.Image = global::Programma83.Properties.Resources.dice1;
            this.picMetamaisKaulins.Location = new System.Drawing.Point(144, 131);
            this.picMetamaisKaulins.Name = "picMetamaisKaulins";
            this.picMetamaisKaulins.Size = new System.Drawing.Size(100, 100);
            this.picMetamaisKaulins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMetamaisKaulins.TabIndex = 0;
            this.picMetamaisKaulins.TabStop = false;
            this.picMetamaisKaulins.Click += new System.EventHandler(this.picMetamaisKaulins_Click);
            // 
            // labPunkti
            // 
            this.labPunkti.AutoSize = true;
            this.labPunkti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPunkti.Location = new System.Drawing.Point(12, 9);
            this.labPunkti.Name = "labPunkti";
            this.labPunkti.Size = new System.Drawing.Size(58, 13);
            this.labPunkti.TabIndex = 1;
            this.labPunkti.Text = "Punkti: 1";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 305);
            this.Controls.Add(this.labPunkti);
            this.Controls.Add(this.picMetamaisKaulins);
            this.Name = "Form1";
            this.Text = "Metamais kauliņš";
            ((System.ComponentModel.ISupportInitialize)(this.picMetamaisKaulins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMetamaisKaulins;
        private System.Windows.Forms.Label labPunkti;
        private System.Windows.Forms.Timer timer;
    }
}

