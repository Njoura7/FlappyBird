using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MagicBird : Form
    {
        int pipeSpeed = 10;
        int gravity = 10;
        int score = 0;
        int n = 2;
        int x = 1;



        public MagicBird()
        {
            InitializeComponent();
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            downside.Left -= pipeSpeed;
            upside.Left -= pipeSpeed;
            Score.Text ="Score: "+ score;

            if (downside.Left < -50)
            {
                downside.Left = 600;
                score++;
            }
            if (upside.Left < -80)
            {
                upside.Left = 600;
                score++;
            }
            if (bird.Bounds.IntersectsWith(downside.Bounds) || bird.Bounds.IntersectsWith(upside.Bounds) || bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
             }



            if (score > 5)
            {
                pipeSpeed = 15 ;
            }
            if (score > 10)
            {
                pipeSpeed = 20;
            }
            if (score > 15)
            {
                pipeSpeed = 25;
            }




            if (bird.Top < -20)
            {
                endGame();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -12  ;
            }


        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }


        }
        private void endGame()
        {
            gameTimer.Stop();
            Score.Text += "game over";
        }

        private void MagicBird_Load(object sender, EventArgs e)
        {

        }
    }
}
