namespace ClassMetier
{
    public class Class1
    {
        public Thread t;
        public bool b = true;
        public int value;

        public event ValueChanged valueChanged;
        public delegate void ValueChanged(Class1 sender);

        public Class1()
        {
            value = 0;
            t = new Thread(new ThreadStart(DoSomething));
        }
        public void Method()
        {
            t.Start();
        }

        public void DoSomething()
        {
            while(b)
            {
                lock (this)
                value++;
                if (valueChanged != null)
                    valueChanged(this);
            }
        }
    }
}