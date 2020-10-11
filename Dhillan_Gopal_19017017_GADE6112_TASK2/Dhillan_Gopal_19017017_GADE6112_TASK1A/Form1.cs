using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhillan_Gopal_19017017_GADE6112_TASK1A
{
	public partial class Form1 : Form
	{
        
        public Form1()
		{
			InitializeComponent();
            
        }
    
        private void startGame(int min_width, int max_width, int min_height, int max_height, int num_enemies)
        {
            lblErrorMessage.Text = "";

            PlayGame gp = new PlayGame(min_width, max_width, min_height, max_height, num_enemies,false);
            gp.setCaller(this);
            gp.Show();
            this.Hide();
        }

		private void btnStartGame_Click(object sender, EventArgs e)
		{
            try
            {

                int minwidth = Convert.ToInt32(edtMinWidth.Text);
                int maxwidth = Convert.ToInt32(edtMaxWidth.Text);
                int minheight = Convert.ToInt32(edtMinHeight.Text);
                int maxheight = Convert.ToInt32(edtMaxHeight.Text);
                int enemies = Convert.ToInt32(edtEnemies.Text);

                startGame(minwidth, maxwidth, minheight, maxheight, enemies);

            }
            catch (FormatException)
            {
                lblErrorMessage.Text = "Please input numbers";
            }
        }

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btnLoadGame_Click(object sender, EventArgs e)
		{
			
            PlayGame gp = new PlayGame(0, 0, 0, 0, 0,true);
            gp.setCaller(this);
            gp.Show();
            this.Hide();

        }
	}
}
