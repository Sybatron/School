using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mind_Break
{
    public partial class MainMenu : Form
    {
        //Games Forms
        Hangman.Hangman Hangman_Form = new Hangman.Hangman();
        PuzzleGame.PuzzleGame PuzzleGame_Form = new PuzzleGame.PuzzleGame();

        //Main Menu Code
        Information infoForm = new Information();
        int oldScroll = 0;

        public string isNewGame;
        public MainMenu()
        {
            InitializeComponent();
        }
        //Changing Colors when you are over the button and when you leave the button
        private void normalColor_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightGray;
        }

        private void onMouseColor_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
        }
        //CGpanel 215;105 || Movable 250:115 Location 12;210
        private void CGScrollBar_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar nowScroll = (ScrollBar)sender;
            int changeValue = 0;
            if (nowScroll.Value != oldScroll)
            {
                changeValue = nowScroll.Value - oldScroll;
                changeValue *= -1;
            }
            try
            {
                foreach (Button btn in CGpanel.Controls)
                {
                    btn.Location = new Point(btn.Location.X, btn.Location.Y + changeValue);
                }
            }
            catch (Exception)
            {
            }
            oldScroll = nowScroll.Value;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            openForm();
        }
        public void openForm()
        {
            isNewGame = File.ReadAllText(".\\isNewGame.txt");
            if (isNewGame=="true")
            {
                isNewGame = "false";
                string name = File.ReadAllText(".\\FormToOpen.txt");
                switch (name)
                {
                    case "Hangman":
                        File.WriteAllText(".\\FormToOpen.txt", "");
                        File.WriteAllText(".\\isNewGame.txt","false");
                        MainMenu.ActiveForm.Hide();
                        break;
                    case "Puzzle":
                        File.WriteAllText(".\\FormToOpen.txt", "");
                        File.WriteAllText(".\\isNewGame.txt", "false");
                        MainMenu.ActiveForm.Hide();
                        break;
                    case "Snake":
                        File.WriteAllText(".\\FormToOpen.txt", "");
                        File.WriteAllText(".\\isNewGame.txt", "false");
                        MainMenu.ActiveForm.Hide();
                        break;
                    case "SnakesAndLadders":
                        File.WriteAllText(".\\FormToOpen.txt", "");
                        File.WriteAllText(".\\isNewGame.txt", "false");
                        MainMenu.ActiveForm.Hide();
                        break;
                    default:
                        MessageBox.Show("Nothing To Show");
                        break;
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            infoForm.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(".\\FormToOpen.txt", "");
            File.WriteAllText(".\\isNewGame.txt", "false");
            Application.Exit();
        }

        private void CGButton_Click(object sender, EventArgs e)
        {
            CG_MovablePanel.Location = new Point(12, 210);
        }

        private void snakeButton_Click(object sender, EventArgs e)
        {

        }

        private void SnakesAndLaddersButton_Click(object sender, EventArgs e)
        {

        }

        private void puzzleButton_Click(object sender, EventArgs e)
        {
            PuzzleGame_Form.Show();
            Hide();
        }

        private void hangmanButton_Click(object sender, EventArgs e)
        {
            Hangman_Form.Show();
            Hide();
        }
    }
}
