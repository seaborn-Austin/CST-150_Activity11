using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity11
{
    public partial class diceRollForm : Form
    {
        public diceRollForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();
            Random r2 = new Random();
            int a = r1.Next(20);
            int b = r2.Next(20);
            dice d1 = new dice(4);
            dice d2 = new dice(4);

            int count = 0;

            //Consistently roll the dice as long as neither dice is equal to 1
            do
            {
                dice1Txt.Text = d1.rollDie().ToString();
                dice2Txt.Text = d2.rollDie().ToString();
                count+=1;
                if (d1.rollDie() == 1 && d2.rollDie() == 1)
                {
                    MessageBox.Show("It took " + count + " attempts to get snake eyes!");
                }
            }
            while (d1.rollDie() != 1 || d2.rollDie() != 1);
           


        }
        
        //Make dice class   
        class dice
        {
            //Number of sides for the dice
            private int diceSides;

            //Random number
            Random r = new Random();
            
            //The constructor takes one argument and compares it to the diceSides variable
            public dice(int a)
            {
                diceSides = a;

                //If the number of sides are less than 4 and greater than 20
                //Inform user that sides need to be between 4 and 20
                if(a < 4 || a > 20)
                {
                    MessageBox.Show("Sides should be between 4 and 20.");
                }
                this.diceSides = a;

            }
            //Generate a random number for the dice shakes before it is thrown
            public int rollDie()
            {
                return r.Next(1, diceSides + 1);
            }
        }

       

    }
}
