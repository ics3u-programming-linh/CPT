using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGameLinhH
{
    public partial class frmPlatformGame : Form
    {
        // declare variables and set bool variables 
        bool goleft = false;
        bool goright = false;
        bool jumping = false;

        int jumpSpeed = 10;
        int force = 8;
        int score = 0;
        public frmPlatformGame()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            // if left key is pressed, set goleft to true
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            // if right key is pressed, set goright to true
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            // if space key is pressed, set jumping to true
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            // if left key is pressed, set goleft to false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            // if right key is pressed, set goright to false
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            // if space key is pressed, set jumping to true
            if (jumping)
            {
                jumping = false;
            }
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            // continously drop player towards the platform (the ground)
            picPlayer.Top += jumpSpeed;

            // if jumping and force is less than 0, create a gravity effect
            if (jumping && force < 0)
            {
                // make jumping false
                jumping = false;
            }

            if (goleft)
            {
                // push character towards left of screen
                picPlayer.Left -= 5;
            }

            if (goright)
            {
                // push character towards right of screen
                picPlayer.Left += 5;
            }

            if (jumping)
            {
                // set force to 1, jumpspeed to -12
                jumpSpeed = -12;
                force -= 1;
            }
            // if it's not jumping set speed to 12
            else
            {
                jumpSpeed = 12;
            }

            // look through whole form to find picture boxes that player interacts with, in order to land on top of it.
            foreach (Control x in this.Controls)
            {
               // continue if x is a picturebox and the tag equals to the platform
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        // set force to 8, and player is going to be above the platform
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        this.Controls.Remove(x);
                        score++;
                    }
                }

                // if player touches the door, stop timer and display you win
                if (picPlayer.Bounds.IntersectsWith(picDoor.Bounds))
                {
                    tmrTimer.Stop();
                    MessageBox.Show("You Win");
                    // restart the game
                    Application.Restart();
                }
            }
        }
    }
}
