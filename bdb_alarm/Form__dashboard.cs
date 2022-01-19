using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//using System.Diagnostics;

namespace bdb_alarm
{
    public partial class Form__dashboard : Form
    {
        public Form__dashboard()
        {
            InitializeComponent();

            label__now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label__now.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");

            string now = DateTime.Now.ToString("HH시 mm분");

            //==============================================================================
            // 변경 전
            //------------------------------------------------------------------------------
            //foreach (string value in listBox__alarm_list.Items)
            //{
            //    if (now == value)
            //    {
            //        button__alarm.PerformClick();
            //    }
            //}
            //------------------------------------------------------------------------------
            // 변경 후
            //------------------------------------------------------------------------------
            char[] boundary = { '/' };

            for (int count = 0; count < listBox__alarm_list.Items.Count; count++)
            {
                string value = listBox__alarm_list.Items[count].ToString();
                string[] result = value.Split(boundary);

                if (now == result[0])
                {
                    //button__alarm.PerformClick();
                    alarm(result[0], result[1]);
                    listBox__alarm_list.Items.RemoveAt(count);
                }
            }
            //==============================================================================
        }

        private void alarm(string time, string note)
        {
            //foreach (Form value in Application.OpenForms)
            //{
            //    if (value.Name == "Form__display")
            //    {
            //        if (value.WindowState == FormWindowState.Minimized)
            //        {
            //            value.WindowState = FormWindowState.Normal;
            //            value.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            //        }

            //        value.Activate();

            //        return;
            //    }
            //}

            Form__display display__ = new Form__display();

            display__.label__display_time.Text = time;
            display__.label__display_note.Text = note;

            display__.Show();
            //display__.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int length = Encoding.Default.GetBytes(this.textBox__add_time.Text).Length;

            if (length == 4)
            {
                if (textBox__add_time.Text != "")
                {
                    string time = textBox__add_time.Text.Substring(0,2) + "시" + " " + textBox__add_time.Text.Substring(2, 2) + "분";

                    listBox__alarm_list.Items.Add(time + "/" + comboBox__add_note.Text);
                    textBox__add_time.Text = "";

                    if (comboBox__add_note.Items.Count == 0)
                    {
                        comboBox__add_note.Items.Add(comboBox__add_note.Text);
                    }
                    else
                    {
                        int add = 0;

                        for (int count = 0; count < comboBox__add_note.Items.Count; count++)
                        {
                            string value = comboBox__add_note.Items[count].ToString();

                            if (comboBox__add_note.Text == value)
                            {
                                add = 0;
                            }
                            else
                            {
                                add = 1;
                            }
                        }

                        if(add == 1)
                        {
                            comboBox__add_note.Items.Add(comboBox__add_note.Text);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void button_add_clean_Click(object sender, EventArgs e)
        {
            textBox__add_time.Text = "";
            comboBox__add_note.Text = "";
        }

        private void textBox__add_time_KeyPress(object sender, KeyPressEventArgs e)
        {
            // '숫자'와 'backspace'만 입력 가능
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != 8) // 8: backspace
            {
                e.Handled = true;
            }

            if (e.KeyChar == '\r') // '\r': enter
            {
                button_add.PerformClick();
            }
        }

        private void comboBox__add_note_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // '\r': enter
            {
                button_add.PerformClick();
            }
        }

        private void button__list_save_Click(object sender, EventArgs e)
        {
            StreamWriter file;

            file = new StreamWriter("alarm_list_file.txt");

            for (int count = 0; count < listBox__alarm_list.Items.Count; count++)
            {
                listBox__alarm_list.Items[count] += "\r\n";

                file.Write(listBox__alarm_list.Items[count]);

            }

            file.Close();
        }

        private void button__delete_Click(object sender, EventArgs e)
        {
            listBox__alarm_list.Items.Remove(listBox__alarm_list.SelectedItem);
        }

        private void button__list_read_Click(object sender, EventArgs e)
        {
            string list;

            System.IO.StreamReader file = new System.IO.StreamReader("alarm_list_file.txt");

            listBox__alarm_list.Items.Clear();

            while ((list = file.ReadLine()) != null)
            {
                listBox__alarm_list.Items.Add(list);
            }

            file.Close();
        }
    }
}
