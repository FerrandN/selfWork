using ClassMetier;

namespace DelegateTraining
{
    public partial class Form1 : Form
    {
        ClassMetier.Class1 c = new ClassMetier.Class1();
        int tabI = 0;
        public Form1()
        {
            InitializeComponent();
            c.valueChanged += Class1_ValueChanged;
        }

        private void Class1_ValueChanged(Class1 sender)
        {
            if (InvokeRequired)
            {
                Invoke(Update);
            }
            else
                Update();
        }

        private void Update()
        {
            if (tabI == label1.TabIndex)
            {
                label1.Text = c.value.ToString();
            }
            else if (tabI == label2.TabIndex)
            {
                label2.Text = c.value.ToString();
            }
            else
            {
                label3.Text = c.value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tabIndex();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(c.b == true)
            c.b = false;
            else
            c.b = true;
        }

        private void tabIndex()
        {
            if(tabI == 3)
            {
                tabI = 1;
            }
            else
            {
                tabI++;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(c.t.ThreadState == ThreadState.Unstarted)
            {
                c.Method();
            }
        }
    }
}