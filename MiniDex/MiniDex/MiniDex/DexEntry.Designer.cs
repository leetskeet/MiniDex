namespace MiniDex
{
    partial class DexEntry
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
            this.pokeLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.dexPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dexPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pokeLabel
            // 
            this.pokeLabel.AutoSize = true;
            this.pokeLabel.Location = new System.Drawing.Point(140, 193);
            this.pokeLabel.Name = "pokeLabel";
            this.pokeLabel.Size = new System.Drawing.Size(0, 13);
            this.pokeLabel.TabIndex = 1;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(102, 332);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(127, 40);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // dexPic
            // 
            this.dexPic.BackColor = System.Drawing.Color.White;
            this.dexPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dexPic.Location = new System.Drawing.Point(112, 39);
            this.dexPic.Name = "dexPic";
            this.dexPic.Size = new System.Drawing.Size(111, 115);
            this.dexPic.TabIndex = 0;
            this.dexPic.TabStop = false;
            // 
            // DexEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(328, 397);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.pokeLabel);
            this.Controls.Add(this.dexPic);
            this.Name = "DexEntry";
            this.Text = "DexEntry";
            ((System.ComponentModel.ISupportInitialize)(this.dexPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dexPic;
        private System.Windows.Forms.Label pokeLabel;
        private System.Windows.Forms.Button menuButton;
    }
}