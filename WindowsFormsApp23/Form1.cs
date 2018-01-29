using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int top = 10;
            int num = 0;
           for(int i = 0; i < 5; i++)
            {
             int left = 80;

            for(int j = 0; j < 5; j++)
            {

              Button btn = new Button();

                    btn.Width = 30;
                    btn.Height = 25;
                    btn.Left = left;
                    btn.Top = top;
                    btn.Visible = true;
                    btn.BackColor = SystemColors.Control;
                    Controls.Add(btn);
                    num++;

                    btn.Text = num.ToString();
                    btn.Click += new EventHandler(btn_Click);
                    Form form = new Form();
                    
                    left += 50;
            }
                    top += 30;

            }
        }
       
        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.BackColor == SystemColors.Control)
            {
                button.BackColor = Color.Red;
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = SystemColors.Control;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var listSelected = Controls.OfType<Button>().Where(x => x.BackColor == Color.Red);

            foreach (Button item in listSelected)
            {
                item.BackColor = Color.Green;
            }
            
        }
    }
}
