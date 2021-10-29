using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace storyGame
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            outputlabel.Text = "You are lost in the dark and cant see anything but a tiny light in the distance";
            button1.Text = "go towards the light?";
            button2.Text = "stay put";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            { page = 2; }
            else if (page == 2)
            { page = 4; }
            else if (page == 3)
            { page = 1; }
            else if (page == 4)
            { page = 8; }
            else if (page == 5)
            { page = 6; }
            else if (page == 6)
            { page = 1; }
            else if (page == 7)
            { page = 1; }
            else if (page == 8)
            { page = 10; }
            else if (page ==9)
            { page = 1; }
            else if (page == 10)
            { page = 1; }
            else if (page ==11)
            { page = 1; }

            DisplayPage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            { page = 3; }
            else if (page == 2)
            { page = 5; }
            else if (page == 3)
            { page = 99; }
            else if (page == 4)
            { page = 9; }
            else if (page == 5)
            { page = 7; }
            else if (page == 6)
            { page = 99; }
            else if (page == 7)
            { page = 99; }
            else if (page == 8)
            { page = 11; }
            else if (page == 9)
            { page = 99; }
            else if (page == 10)
            { page = 99; }
            else if (page == 11)
            { page = 99; }

            DisplayPage();
        }
        public void DisplayPage()
        {
            switch (page)
            {
                case 1:
                    outputlabel.Text = "you are lost in the dark and cant see anything but a tiny light in the distance.";
                    button1.Text = "go towards the light?";
                    button2.Text = "stay put?";

                    break;
                case 2:
                    outputlabel.Text = "you start getting closer and you realize its just a floating ball of light";
                    button1.Text = "touch the ball?";
                    button2.Text = "leave it alone?";
                    imageBox.Image = Properties.Resources.white_ball;


                    break;
                case 3:
                    outputlabel.Text = "you decide to stay put and you starve to death... play again?";
                    button1.Text = "yes";
                    button2.Text = "no";
                    imageBox.Image = Properties.Resources.dead;
                    break;
                case 4:
                    outputlabel.Text = "you touch the ball and you blackout, you wake up but dont know where you are";
                    button1.Text = "explore?";
                    button2.Text = "yell for help?";

                    break;
                case 5:
                    outputlabel.Text = "you decide to leave the ball alone. out of no where a weird looking creature pops out and starts threatening you";
                    button1.Text = "fight the creature?";
                    button2.Text = "run for your life?";
                    imageBox.Image = Properties.Resources.creature;

                    break;
                case 6:
                    outputlabel.Text = "you attemp to fight the creature but you are unsuccessful. the creature rips your head off. youre dead. play again?";
                    button1.Text = "yes";
                    button2.Text = "no";

                    break;
                case 7:
                    outputlabel.Text = "you start to run for your life but the creature is too fast and catches up with you, it rips you apart limb by limb. youre dead. play again?";
                    button1.Text = "yes";
                    button2.Text = "no";

                    break;
                case 8:
                    outputlabel.Text = "you decide to explore but end up face to face with a frog who has the map out of here";
                    button1.Text = "kill the frog";
                    button2.Text = "ignore it and forget about the map";

                    break;
                case 9:
                    outputlabel.Text = "you decide to yell for help but you attract the attention of a giant moth, it picks you up and flys 100 feet into the air, it drops you and you die. play again?";
                    button1.Text = "yes";
                    button2.Text = "no";
                    imageBox.Image = Properties.Resources.dead;
                    break;
                case 10:
                    outputlabel.Text = "youre attempt the kill the frog was successful, you get the map and proceed to escape. YOU WIN!! play again?";
                    button1.Text = "yes";
                    button2.Text = "no";

                    break;
                case 11:
                    outputlabel.Text = "you decide to ignore the frog, as youre walking away it mistakes you for a fly and eats you alive. play again?";
                    button1.Text = "yes";
                    button2.Text = "no";
                    imageBox.Image = Properties.Resources.dead;
                    break;
                case 99:
                    outputlabel.Text = "thanks for playing";
                    button1.Visible = false;
                    button2.Visible = false;
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;


            }
        }

        private void imageBox_Click(object sender, EventArgs e)
        {

        }
    }
}
