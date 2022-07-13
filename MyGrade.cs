using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyOwn;

namespace MyOwn
{
    public partial class MyGrade : Form
    {
        public MyGrade()
        {
            InitializeComponent();
        }
        List<MyClass> mylist = new List<MyClass>();
        MyClass[] MC = new MyClass[300];
        Random rnd=new Random();
        int i;

        private int student_count
        {
            get { return mylist.Count; }
        }
        private void btnRnd_Click(object sender, EventArgs e)
        {
            i = student_count;
            MC[i] = new MyClass()
            {
                name = rnd.Next(101).ToString(),
                arr = new int[] { rnd.Next(101), rnd.Next(0, 101), rnd.Next(0, 101) }
            };
            mylist.Add(MC[i]);
            labName.Text += MC[i].ToString()+"\n";
            labCount.Text = student_count.ToString();
        }

        private void btnRnd20_Click(object sender, EventArgs e)
        {
            for (int i =0; i<20; i++)
            {
                MC[i] = new MyClass()
                {
                    name = rnd.Next(101).ToString(),
                    arr = new int[] { rnd.Next(101), rnd.Next(0, 101), rnd.Next(0, 101) }
                };
                labName.Text += MC[i].ToString() + "\n";
                mylist.Add(MC[i]);
            }
 
            labCount.Text = student_count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mylist.Clear();
            labName.Text = "";
            labCount.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MC[i] = new MyClass();
            if (txtName.Text=="")
            {
                MessageBox.Show("請輸入姓名");
                return;
            }
            MC[i].na_string = txtName.Text;
            MC[i].ch_string = txtChinese.Text;
            MC[i].en_string = txtEnglish.Text;
            MC[i].ma_string = txtMath.Text;
            if (MC[i].ch == -1 || MC[i].en == -1 || MC[i].ma == -1)
            {
                MessageBox.Show("字串輸入錯誤");
                if (MC[i].ch == -1) txtChinese.Clear();
                else if (MC[i].en == -1) txtEnglish.Clear();
                else if (MC[i].ma == -1) txtMath.Clear();
                return;
            }
            if (MC[i].ch == -2 || MC[i].en == -2 || MC[i].ma == -2)
            {
                MessageBox.Show("數字輸入錯誤");
                if (MC[i].ch == -2) txtChinese.Clear();
                else if (MC[i].en == -2) txtEnglish.Clear();
                else if (MC[i].ma == -2) txtMath.Clear();
                return;
            }
            i = student_count;
            MC[i] = new MyClass()
            {
                name = txtName.Text,
                arr = new int[] { int.Parse(txtChinese.Text), int.Parse(txtEnglish.Text), int.Parse(txtMath.Text) }
            };
            mylist.Add(MC[i]);
            labName.Text += MC[i].ToString() + "\n";
            labCount.Text = student_count.ToString();
        }


        void MyLayout()
        {
            int ch, en, ma;
            labName.Text = "";
            for (int i = 0; i < student_count; i++)
            {
                string na = mylist[i].na_string;
                ch = mylist[i].ch;
                en = mylist[i].en;
                ma = mylist[i].ma;

                int total = ch + en + ma;
                string high = "";
                int high_num = 0;
                string low = "";
                int low_num = 0;
                double avg = Math.Round(((double)total) / 3, 2);


                labName.Text += na + " " + ch + " " + en + " " + ma + "          " + (ch + en + ma) + "          " + ((ch + en + ma) / 3) + (low + low_num)+ (high + high_num)+ "\n";
                //labName.Text += $"{na.PadRight(13)}{ch.ToString().PadRight(7)}{en.ToString().PadRight(7)}{ma.ToString().PadRight(7)}" +
                //                $"{total.ToString().PadRight(7)}{avg.ToString().PadRight(7)}{(low + low_num).PadRight(7)}{(high + high_num).PadRight(0)}\n";
            }
            
        }
        private void label5_Layout(object sender, LayoutEventArgs e)
        {
            label5.Text = $"{"姓名".PadRight(9)}{"國文".PadRight(7)}{"英文".PadRight(7)}{"數學".PadRight(7)}" +
                          $"{"總分".PadRight(7)}{"平均".PadRight(7)}{"最低".PadRight(7)}{"最高".PadRight(0)}";
        }

    }
}
