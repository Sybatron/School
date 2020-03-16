namespace Mind_Break
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.aboutButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.CGpanel = new System.Windows.Forms.Panel();
            this.SnakesAndLaddersButton = new System.Windows.Forms.Button();
            this.snakeButton = new System.Windows.Forms.Button();
            this.puzzleButton = new System.Windows.Forms.Button();
            this.hangmanButton = new System.Windows.Forms.Button();
            this.CGScrollBar = new System.Windows.Forms.VScrollBar();
            this.CG_MovablePanel = new System.Windows.Forms.Panel();
            this.CGpanel.SuspendLayout();
            this.CG_MovablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            this.aboutButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.aboutButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // CGpanel
            // 
            this.CGpanel.Controls.Add(this.SnakesAndLaddersButton);
            this.CGpanel.Controls.Add(this.snakeButton);
            this.CGpanel.Controls.Add(this.puzzleButton);
            this.CGpanel.Controls.Add(this.hangmanButton);
            resources.ApplyResources(this.CGpanel, "CGpanel");
            this.CGpanel.Name = "CGpanel";
            // 
            // SnakesAndLaddersButton
            // 
            resources.ApplyResources(this.SnakesAndLaddersButton, "SnakesAndLaddersButton");
            this.SnakesAndLaddersButton.Name = "SnakesAndLaddersButton";
            this.SnakesAndLaddersButton.UseVisualStyleBackColor = true;
            this.SnakesAndLaddersButton.Click += new System.EventHandler(this.SnakesAndLaddersButton_Click);
            this.SnakesAndLaddersButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.SnakesAndLaddersButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // snakeButton
            // 
            resources.ApplyResources(this.snakeButton, "snakeButton");
            this.snakeButton.Name = "snakeButton";
            this.snakeButton.UseVisualStyleBackColor = true;
            this.snakeButton.Click += new System.EventHandler(this.snakeButton_Click);
            this.snakeButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.snakeButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // puzzleButton
            // 
            resources.ApplyResources(this.puzzleButton, "puzzleButton");
            this.puzzleButton.Name = "puzzleButton";
            this.puzzleButton.UseVisualStyleBackColor = true;
            this.puzzleButton.Click += new System.EventHandler(this.puzzleButton_Click);
            this.puzzleButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.puzzleButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // hangmanButton
            // 
            resources.ApplyResources(this.hangmanButton, "hangmanButton");
            this.hangmanButton.Name = "hangmanButton";
            this.hangmanButton.UseVisualStyleBackColor = true;
            this.hangmanButton.Click += new System.EventHandler(this.hangmanButton_Click);
            this.hangmanButton.MouseEnter += new System.EventHandler(this.onMouseColor_MouseEnter);
            this.hangmanButton.MouseLeave += new System.EventHandler(this.normalColor_MouseLeave);
            // 
            // CGScrollBar
            // 
            resources.ApplyResources(this.CGScrollBar, "CGScrollBar");
            this.CGScrollBar.Maximum = 120;
            this.CGScrollBar.Name = "CGScrollBar";
            this.CGScrollBar.SmallChange = 10;
            this.CGScrollBar.ValueChanged += new System.EventHandler(this.CGScrollBar_ValueChanged);
            // 
            // CG_MovablePanel
            // 
            this.CG_MovablePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CG_MovablePanel.Controls.Add(this.CGpanel);
            this.CG_MovablePanel.Controls.Add(this.CGScrollBar);
            resources.ApplyResources(this.CG_MovablePanel, "CG_MovablePanel");
            this.CG_MovablePanel.Name = "CG_MovablePanel";
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CG_MovablePanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.aboutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.CGpanel.ResumeLayout(false);
            this.CG_MovablePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel CGpanel;
        private System.Windows.Forms.Button snakeButton;
        private System.Windows.Forms.Button puzzleButton;
        private System.Windows.Forms.Button hangmanButton;
        private System.Windows.Forms.VScrollBar CGScrollBar;
        private System.Windows.Forms.Panel CG_MovablePanel;
        private System.Windows.Forms.Button SnakesAndLaddersButton;
    }
}

