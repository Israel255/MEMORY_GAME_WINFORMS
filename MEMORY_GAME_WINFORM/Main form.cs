using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEMORY_GAME_WINFORM
{
    public partial class mainForm : Form
    {
        Random numbers = new Random();
        int points = 0;
        int high_score = 5;
        string message = "Do you want to close this window?";
        string title = "Close Window";
        int game_num = 1;
        DateTime start = DateTime.Now;
        DateTime finish = DateTime.Now;
        public mainForm()
        {
            InitializeComponent();
            Lbl_number_change();
            lock_the_txtbox();
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            start = DateTime.Now;
            //Lbl_visible_change();
            Lbl_visible_change_to(false);
            unlock_the_txtbox();
        }
        //private void finishBtn_Click(object sender, EventArgs e)
        //{
            //Txtbx_check();
            //lock_the_txtbox();
            //highScoreLbx.Items.Add("Game Score: " + points);
            //messeges();
            //points = 0;
        //}
        private void newGameMenuMs_Click(object sender, EventArgs e)
        {
            game_num++;
            points = 0;
            clean_txtbox();
            Lbl_number_change();
            Lbl_visible_change_to(true);
            //lbl_not_visible();
            white_txtbox();
            lock_the_txtbox();
        }
        private void exitMenuMs_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void unlock_the_txtbox()
        {
            firstNumTxtbx.ReadOnly = false;
            secondNumTxtbx.ReadOnly = true;
            thirdNumTxtbx.ReadOnly = true;
            fourthNumTxtbx.ReadOnly = true;
            fifthNumTxtbx.ReadOnly = true;
        }
        private void Lbl_number_change()
        {
            firstNumLbl.Text = Convert.ToString(numbers.Next(1, 10));
            secondNumLbl.Text = Convert.ToString(numbers.Next(1, 10));
            thirdNumLbl.Text = Convert.ToString(numbers.Next(1, 10));
            fourthNumLbl.Text = Convert.ToString(numbers.Next(1, 10));
            fifthNumLbl.Text = Convert.ToString(numbers.Next(1, 10));
        }
        private void Lbl_visible_change_to(bool tovalue)
        {
            firstNumLbl.Visible = tovalue;
            secondNumLbl.Visible = tovalue;
            thirdNumLbl.Visible = tovalue;
            fourthNumLbl.Visible = tovalue;
            fifthNumLbl.Visible = tovalue;
        }
        private void Lbl_visible_change()
        {
            firstNumLbl.Visible = false;
            secondNumLbl.Visible = false;
            thirdNumLbl.Visible = false;
            fourthNumLbl.Visible = false;
            fifthNumLbl.Visible = false;
        }
        private void lbl_not_visible()
        {
            firstNumLbl.Visible = true;
            secondNumLbl.Visible = true;
            thirdNumLbl.Visible = true;
            fourthNumLbl.Visible = true;
            fifthNumLbl.Visible = true;
        }

        private void Txtbx_check()
        {
             if (firstNumTxtbx.Text == firstNumLbl.Text)
            {
                points++;
            }
             else
            {
                firstNumTxtbx.BackColor = Color.Red;
            }
             if (secondNumTxtbx.Text == secondNumLbl.Text)
            {
                points++;
            }
            else
            {
                secondNumTxtbx.BackColor = Color.Red;
            }
            if (thirdNumTxtbx.Text == thirdNumLbl.Text)
            {
                points++;
            }
            else
            {
                thirdNumTxtbx.BackColor = Color.Red;
            }
            if (fourthNumTxtbx.Text == fourthNumLbl.Text)
            {
                points++;
            }
            else
            {
                fourthNumTxtbx.BackColor = Color.Red;
            }
            if (fifthNumTxtbx.Text == fifthNumLbl.Text)
            {
                points++;
            }
            else
            {
                fifthNumTxtbx.BackColor = Color.Red;
            }
        }
        private void messeges()
        {
            if (points == high_score)
            {
                MessageBox.Show("You are the best!!");
            }
            else if (points < high_score)
            {
                MessageBox.Show("You need to practice");
            }
        }
        private void lock_the_txtbox()
        {
            firstNumTxtbx.ReadOnly = true;
            secondNumTxtbx.ReadOnly = true;
            thirdNumTxtbx.ReadOnly = true;
            fourthNumTxtbx.ReadOnly = true;
            fifthNumTxtbx.ReadOnly = true;
        }
        private void clean_txtbox()
        {
            firstNumTxtbx.Clear();
            secondNumTxtbx.Clear();
            thirdNumTxtbx.Clear();
            fourthNumTxtbx.Clear();
            fifthNumTxtbx.Clear();
        }
        private void white_txtbox ()
        {
            firstNumTxtbx.BackColor = SystemColors.Window;
            secondNumTxtbx.BackColor = SystemColors.Window;
            thirdNumTxtbx.BackColor = SystemColors.Window;
            fourthNumTxtbx.BackColor = SystemColors.Window;
            fifthNumTxtbx.BackColor = SystemColors.Window;
        }

        private void firstNumTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (firstNumTxtbx.Text == firstNumLbl.Text)
            {
                points++;
            }
            else
            {
                firstNumTxtbx.BackColor = Color.Red;
            }
            firstNumTxtbx.ReadOnly = true;
            secondNumTxtbx.ReadOnly = false;
        }

        private void secondNumTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (secondNumTxtbx.Text == secondNumLbl.Text)
            {
                points++;
            }
            else
            {
                secondNumTxtbx.BackColor = Color.Red;
            }
            secondNumTxtbx.ReadOnly = true;
            thirdNumTxtbx.ReadOnly = false;
        }

        private void thirdNumTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (thirdNumTxtbx.Text == thirdNumLbl.Text)
            {
                points++;
            }
            else
            {
                thirdNumTxtbx.BackColor = Color.Red;
            }
            thirdNumTxtbx.ReadOnly = true;
            fourthNumTxtbx.ReadOnly = false;
        }

        private void fourthNumTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (fourthNumTxtbx.Text == fourthNumLbl.Text)
            {
                points++;
            }
            else
            {
                fourthNumTxtbx.BackColor = Color.Red;
            }
            fourthNumTxtbx.ReadOnly = true;
            fifthNumTxtbx.ReadOnly = false;
        }

        private void fifthNumTxtbx_TextChanged(object sender, EventArgs e)
        {
            finish = DateTime.Now;
            int seconds = Convert.ToInt32((finish.Second - start.Second));
            if (fifthNumTxtbx.Text == fifthNumLbl.Text)
            {
                points++;
            }
            else
            {
                fifthNumTxtbx.BackColor = Color.Red;
            }
            fifthNumTxtbx.ReadOnly = true;
            if (points == high_score && seconds <= 10 && seconds > 0)
            {
                MessageBox.Show("You are the best!! you did it in " + seconds + " seconds!");
                highScoreLbx.Items.Add("game number " + game_num + " : " + points + " points || " + seconds + " seconds");
            }
            else if (points == high_score && seconds > 10)
            {
                MessageBox.Show("You won! but be faster please!! it's took you " + seconds + " seconds!");
                highScoreLbx.Items.Add("game number " + game_num + " : " + points + " points || " + seconds + " seconds");
            }
            else if (points == high_score && seconds <= 0)
            {
                MessageBox.Show("You won! but be faster please!! it's took you very long time!");
                highScoreLbx.Items.Add("game number " + game_num + " : " + points + " points || too much seconds!!!");
            }
        }
    }
}