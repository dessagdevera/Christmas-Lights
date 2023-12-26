using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Timerworkingoverall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int count;
        public string but = "";                                          // button number
        public string color = "";                                         // color name
        public string palit = "";                                    // equals to color name convert to actual color 
        public List<string> list = new List<string>();              // storage of changed color
        public List<Object> list2 = new List<Object>();

        //new cor each button para di magbaliktaran ng blink ang new colors sa mga button
        string def = "SystemColors.Window";                         // default second color
        string cor = "SystemColors.Window";                  // default colors
        string cor2 = "SystemColors.Window";
        string cor3 = "SystemColors.Window";
        string cor4 = "SystemColors.Window";
        string cor5 = "SystemColors.Window";
        string cor6 = "SystemColors.Window";
        string cor7 = "SystemColors.Window";
        string cor8 = "SystemColors.Window";

        //color click stop
        public bool btn1 = true;
        public bool btn2 = true;
        public bool btn3 = true;
        public bool btn4 = true;
        public bool btn5 = true;
        public bool btn6 = true;
        public bool btn7 = true;
        public bool btn8 = true;
        public bool clearMe = true;

        //color exchange places
        public bool stop = false;
        public bool stop2 = false;
        public bool stop3 = false;
        public bool stop4 = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            list2.Add(button1);
            list2.Add(button2);
            list2.Add(button3);
            list2.Add(button4);
            list2.Add(button5);
            list2.Add(button6);
            list2.Add(button7);
            list2.Add(button8);

        }
            

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            label3.Text = "" + count;

            if (count % 2 == 0)
            {

                if (btn1)
                {
                    change1(button1);
                }
                if (btn2)
                {
                    blink(button2);
                }

                if (btn3)
                {
                    change3(button3);
                }
                if (btn4)
                {
                    blink(button4);
                }

                if (btn5)
                {
                    change5(button5);
                }
                if (btn6)
                {
                    blink(button6);
                }

                if (btn7)
                {
                    change7(button7);
                }
                if (btn8)
                {
                    blink(button8);
                }


            }
            else
            {
                if (btn1)
                {
                    blink(button1);
                }

                if (btn2)
                {
                    change2(button2);
                }
                if (btn3)
                {
                    blink(button3);
                }

                if (btn4)
                {
                    change4(button4);
                }
                if (btn6)
                {
                    change6(button6);
                }
                if (btn5)
                {
                    blink(button5);
                }
                if (btn8)
                {
                    change8(button8);
                }

                if (btn7)
                {
                    blink(button7);
                }
            }
            if (count % 2 == 0)
            {
                if (stop)
                {
                    change5(button1);
                    change1(button5);
                }
                if (stop2)
                {
                    change2(button6);
                    change6(button2);
                }
                if (stop3)
                {
                    change3(button7);
                    change7(button3);
                }
                if (stop4)
                {
                    change4(button8);
                    change8(button4);
                }
            }
            //if (hello)
            //{
            //    Flow();
            //}
            //else
            //{

            //}
        }

        //bool hello = false;
        private void button9_Click(object sender, EventArgs e)
        {
            but = textBox1.Text;    // get value
            color = textBox2.Text;   // get value
            palit = color;      // change new color

            //for rechecking if naadd na ba sa list mga colors
            list.Add(palit);
            //label4.Text = "";

            //foreach (string s in list)
            //{
            //    label4.Text = label4.Text + s + "\n";
            //}

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1 = !btn1;
        }



        // wala munang laman ang color, magkakaron lang sa declaration ko sa taas then will be change into new colors sa input ni user
        public void change1(Button mima)
        {
            if (but.Equals("1") && !palit.Equals(""))
            {
                cor = palit;
                mima.BackColor = Color.FromName(cor);            // convert default to color
              //  btn1 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor);
            }
        }
        public void change2(Button mima)
        {
            if (but.Equals("2") && !palit.Equals(""))
            {
                cor2 = palit;
                mima.BackColor = Color.FromName(cor2);            // convert default to color
               // btn2 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor2);
            }
        }
        public void change3(Button mima)
        {
            if (but.Equals("3") && !palit.Equals(""))
            {
                cor3 = palit;
                mima.BackColor = Color.FromName(cor3);            // convert default to color
               // btn3 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor3);
            }
        }
        public void change4(Button mima)
        {
            if (but.Equals("4") && !palit.Equals(""))
            {
                cor4 = palit;
                mima.BackColor = Color.FromName(cor4);            // convert default to color
               // btn4 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor4);
            }
        }
        public void change5(Button mima)
        {
            if (but.Equals("5") && !palit.Equals(""))
            {
                cor5 = palit;
                mima.BackColor = Color.FromName(cor5);            // convert default to color
               // btn5 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor5);
            }

        }

        public void change6(Button mima)
        {
            if (but.Equals("6") && !palit.Equals(""))
            {
                cor6 = palit;
                mima.BackColor = Color.FromName(cor6);            // convert default to color
                //btn6 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor6);
            }
        }
        public void change7(Button mima)
        {
            if (but.Equals("7") && !palit.Equals(""))
            {
                cor7 = palit;
                mima.BackColor = Color.FromName(cor7);            // convert default to color
               // btn7 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor7);
            }
        }
        public void change8(Button mima)
        {
            if (but.Equals("8") && !palit.Equals(""))
            {
                cor8 = palit;
                mima.BackColor = Color.FromName(cor8);            // convert default to color
               // btn8 = true;
            }
            else
            {
                mima.BackColor = Color.FromName(cor8);
            }
        }

        public void blink(Button blinker)  // second default color
        {
            blinker.BackColor = Color.FromName(def);            // convert default to color
        }


        private void button2_Click(object sender, EventArgs e)
        {
            btn2 = !btn2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn3 = !btn3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn4 = !btn4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn5 = !btn5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn6 = !btn6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btn7 = !btn7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            btn8 = !btn8;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //exchange color ng magkakatapat
            stop = !stop;
            stop2 = !stop2;
            stop3 = !stop3;
            stop4 = !stop4;
          
        }

        //private void button11_Click(object sender, EventArgs e)
        //{
        //    hello = !hello;
        //    count = 0;

        //    button1.BackColor = Color.FromName(palit);
        //}
        //public void Flow()
        //{

        //    if (count == 1)
        //    {
        //        button1.BackColor = Color.FromName(palit);

        //    }
        //    else if (count == 2)
        //    {
        //        button1.BackColor = default(Color);
        //        button2.BackColor = Color.Blue;
        //    }
        //    else if (count == 3)
        //    {
        //        button2.BackColor = default(Color);
        //        button3.BackColor = Color.Green;
        //    }
        //    else if (count == 4)
        //    {
        //        button3.BackColor = default(Color);
        //        button4.BackColor = Color.Pink;
        //    }
        //    else

        //    {
        //        button4.BackColor = default(Color);
        //        button1.BackColor = Color.FromName(palit);
        //        count = 1;
        //    }
        //}
    }
}

