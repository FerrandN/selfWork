using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        Banque lyon;
        public Form1()
        {
            InitializeComponent();
            lyon = new Banque("LBP", "lyon", "Banque de Lyon");
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string id = this.idTextBox.Text;
            string name = this.nameTextBox.Text;
            string balance = this.balanceTextBox.Text;
            string overdraft = this.overdraftTextBox.Text;

            Account account = new Account(int.Parse(id), name, double.Parse(balance), double.Parse(overdraft));
            lyon.AddSetAccount(account);
           
            List<string> ls = ((List<string>)listBox1.DataSource)??new List<string>();

            ls.Add(lyon.BanqueAccount[lyon.BanqueAccount.Count() - 1].owner);
            listBox1.DataSource = new List<string>(ls);
            
            List<string> lis = ((List<string>)listBox2.DataSource)??new List<string>();

            lis.Add(lyon.BanqueAccount[lyon.BanqueAccount.Count() - 1].ToString());
            listBox2.DataSource = new List<string>(lis);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TransfertMoney_Click(object sender, EventArgs e)
        {
            
        }
    }
}
