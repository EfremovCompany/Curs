namespace Maze
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.NewGame = new System.Windows.Forms.Button();
            this.SoundON = new System.Windows.Forms.Button();
            this.SoundOFF = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewGame.BackgroundImage")));
            this.NewGame.Location = new System.Drawing.Point(183, 26);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(197, 55);
            this.NewGame.TabIndex = 0;
            this.NewGame.UseVisualStyleBackColor = true;
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // SoundON
            // 
            this.SoundON.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundON.BackgroundImage")));
            this.SoundON.Location = new System.Drawing.Point(183, 259);
            this.SoundON.Name = "SoundON";
            this.SoundON.Size = new System.Drawing.Size(197, 135);
            this.SoundON.TabIndex = 1;
            this.SoundON.UseVisualStyleBackColor = true;
            this.SoundON.Click += new System.EventHandler(this.SoundON_Click);
            // 
            // SoundOFF
            // 
            this.SoundOFF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SoundOFF.BackgroundImage")));
            this.SoundOFF.Location = new System.Drawing.Point(183, 259);
            this.SoundOFF.Name = "SoundOFF";
            this.SoundOFF.Size = new System.Drawing.Size(197, 135);
            this.SoundOFF.TabIndex = 2;
            this.SoundOFF.UseVisualStyleBackColor = true;
            this.SoundOFF.Click += new System.EventHandler(this.SoundOFF_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Info;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.Location = new System.Drawing.Point(183, 141);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(197, 55);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(597, 406);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.SoundOFF);
            this.Controls.Add(this.SoundON);
            this.Controls.Add(this.NewGame);
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Name = "Menu";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button SoundON;
        private System.Windows.Forms.Button SoundOFF;
        private System.Windows.Forms.Button Exit;
    }
}

