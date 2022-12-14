using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsieurJournée
{
    public partial class Form1 : Form
    {
        string answer;
        Temps temps = new Temps();
        Homme homme = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserAnswerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidButton_Click(object sender, EventArgs e)
        {
            answer = this.UserAnswerBox.Text;
            string[] textSplit = this.UserAnswerBox.Text.Split(' ');
            if (textSplit.Length == 2 && homme == null)
            {
                homme = new Homme(int.Parse(textSplit[0]), textSplit[1]);
            }
        }
    }
}
