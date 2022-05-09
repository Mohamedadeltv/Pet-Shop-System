using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace petshopforworkers
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Desktop\petshopforworkers\petshopforworkers\testpetshop.mdf;Integrated Security=True;Connect Timeout=30");
        Person theperson;
        public static double x=0;
        List<Item> items = new List<Item>();
        public Form2()
        {
            InitializeComponent();
        }



        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedItem== "Meow Mix Kitten Cat Food 510 Gm")
            //{

            //}
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {











        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
     

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                groupBox4.Hide();
                groupBox5.Hide();
                label5.Hide();
            }
            else
            {
                label5.Show();
                groupBox4.Show();
                groupBox5.Show();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Hide();
                groupBox2.Hide();
                groupBox3.Hide();
            }
            else
            {
                label3.Show();
                groupBox3.Show();
                groupBox2.Show();
            }


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                label3.Show();
                groupBox3.Show();
                groupBox2.Show();
                label5.Show();
                groupBox4.Show();
                groupBox5.Show();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (checkBox5.Checked)
                {
                    if (double.Parse(textBox4.Text) <= 0 || double.Parse(textBox4.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox5.Text, double.Parse(textBox4.Text), checkBox5.Text);
                        items.Add(first);
                    }
                }
                if (checkBox4.Checked)
                {

                    if (double.Parse(textBox5.Text) <= 0 || double.Parse(textBox5.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox4.Text, double.Parse(textBox5.Text), checkBox4.Text);
                        items.Add(first);
                    }
                }
                if (checkBox2.Checked)
                {
                    if (double.Parse(textBox7.Text) <= 0 || double.Parse(textBox7.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox2.Text, double.Parse(textBox7.Text), checkBox2.Text);
                        items.Add(first);
                    }
                }
                if (checkBox8.Checked)
                {
                    if (double.Parse(textBox10.Text) <= 0 || double.Parse(textBox10.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox8.Text, double.Parse(textBox10.Text), checkBox8.Text);
                        items.Add(first);
                    }
                }
                if (checkBox7.Checked)
                {
                    if (double.Parse(textBox12.Text) <= 0 || double.Parse(textBox12.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox7.Text, double.Parse(textBox12.Text), checkBox7.Text);
                        items.Add(first);
                    }
                }
                if (checkBox1.Checked)
                {
                    if (double.Parse(textBox11.Text) <= 0 || double.Parse(textBox11.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox1.Text, double.Parse(textBox11.Text), checkBox1.Text);
                        items.Add(first);
                    }
                }
            }
            else  if (radioButton2.Checked)
            {
                if (checkBox11.Checked)
                {
                    if (double.Parse(textBox13.Text) <= 0 || double.Parse(textBox13.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        if (double.Parse(textBox13.Text) >= 4)
                        {
                            //Item i1 = new dog();                           
                            Item first = new dog(checkBox11.Text, double.Parse(textBox13.Text), checkBox11.Text);
                            items.Add(first);
                            x = (first as dog).bavarondiscount();
                        }
                        else
                        {
                            Item first = new dog(checkBox11.Text, double.Parse(textBox13.Text), checkBox11.Text);
                            items.Add(first);
                        }
                        
                    }
                }
                if (checkBox3.Checked)
                {
                    if (double.Parse(textBox14.Text) <= 0 || double.Parse(textBox14.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox3.Text, double.Parse(textBox14.Text), checkBox3.Text);
                        items.Add(first);
                    }
                }
                if (checkBox9.Checked)
                {
                    if (double.Parse(textBox9.Text) <= 0 || double.Parse(textBox9.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox9.Text, double.Parse(textBox9.Text), checkBox9.Text);
                        items.Add(first);
                    }
                }
                if (checkBox14.Checked)
                {
                    if (double.Parse(textBox16.Text) <= 0 || double.Parse(textBox16.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox14.Text, double.Parse(textBox16.Text), checkBox14.Text);
                        items.Add(first);
                    }
                }
                if (checkBox13.Checked)
                {
                    if (double.Parse(textBox18.Text) <= 0 || double.Parse(textBox18.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox13.Text, double.Parse(textBox18.Text), checkBox13.Text);
                        items.Add(first);
                    }
                }
                if (checkBox12.Checked)
                {
                    if (double.Parse(textBox17.Text) <= 0 || double.Parse(textBox17.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox12.Text, double.Parse(textBox17.Text), checkBox12.Text);
                        items.Add(first);
                    }
                }
            }
   
            else
            {
                if (checkBox5.Checked)
                {
                    if (double.Parse(textBox4.Text) <= 0 || double.Parse(textBox4.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox5.Text, double.Parse(textBox4.Text), checkBox5.Text);
                        items.Add(first);
                    }
                }
                if (checkBox4.Checked)
                {

                    if (double.Parse(textBox5.Text) <= 0 || double.Parse(textBox5.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox4.Text, double.Parse(textBox5.Text), checkBox4.Text);
                        items.Add(first);
                    }
                }
                if (checkBox2.Checked)
                {
                    if (double.Parse(textBox7.Text) <= 0 || double.Parse(textBox7.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox2.Text, double.Parse(textBox7.Text), checkBox2.Text);
                        items.Add(first);
                    }
                }
                if (checkBox8.Checked)
                {
                    if (double.Parse(textBox10.Text) <= 0 || double.Parse(textBox10.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox8.Text, double.Parse(textBox10.Text), checkBox8.Text);
                        items.Add(first);
                    }
                }
                if (checkBox7.Checked)
                {
                    if (double.Parse(textBox12.Text) <= 0 || double.Parse(textBox12.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox7.Text, double.Parse(textBox12.Text), checkBox7.Text);
                        items.Add(first);
                    }
                }
                if (checkBox1.Checked)
                {
                    if (double.Parse(textBox11.Text) <= 0 || double.Parse(textBox11.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new cat(checkBox1.Text, double.Parse(textBox11.Text), checkBox1.Text);
                        items.Add(first);
                    }
                }
                if (checkBox11.Checked)
                {
                    if (double.Parse(textBox13.Text) <= 0 || double.Parse(textBox13.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        if (double.Parse(textBox13.Text) >= 4)
                        {
                            //Item i1 = new dog();                           
                            Item first = new dog(checkBox11.Text, double.Parse(textBox13.Text), checkBox11.Text);
                            items.Add(first);
                            x = (first as dog).bavarondiscount();
                        }
                        else
                        {
                            Item first = new dog(checkBox11.Text, double.Parse(textBox13.Text), checkBox11.Text);
                            items.Add(first);
                        }

                    }
                }
                if (checkBox3.Checked)
                {
                    if (double.Parse(textBox14.Text) <= 0 || double.Parse(textBox14.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox3.Text, double.Parse(textBox14.Text), checkBox3.Text);
                        items.Add(first);
                    }
                }
                if (checkBox9.Checked)
                {
                    if (double.Parse(textBox9.Text) <= 0 || double.Parse(textBox9.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox9.Text, double.Parse(textBox9.Text), checkBox9.Text);
                        items.Add(first);
                    }
                }
                if (checkBox14.Checked)
                {
                    if (double.Parse(textBox16.Text) <= 0 || double.Parse(textBox16.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox14.Text, double.Parse(textBox16.Text), checkBox14.Text);
                        items.Add(first);
                    }
                }
                if (checkBox13.Checked)
                {
                    if (double.Parse(textBox18.Text) <= 0 || double.Parse(textBox18.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox13.Text, double.Parse(textBox18.Text), checkBox13.Text);
                        items.Add(first);
                    }
                }
                if (checkBox12.Checked)
                {
                    if (double.Parse(textBox17.Text) <= 0 || double.Parse(textBox17.Text) >= 10)
                    {
                        MessageBox.Show("you are only allowed to buy between 1 to 9 items");

                    }
                    else
                    {
                        Item first = new dog(checkBox12.Text, double.Parse(textBox17.Text), checkBox12.Text);
                        items.Add(first);
                    }
                }

            }
            checkBox5.Checked = false; textBox4.Text = " "; 
            checkBox4.Checked = false; textBox5.Text = " ";
            checkBox2.Checked = false; textBox7.Text = " ";
            checkBox8.Checked = false; textBox10.Text = " ";
            checkBox7.Checked = false; textBox12.Text = " ";
            checkBox1.Checked = false; textBox11.Text = " ";
            checkBox11.Checked = false; textBox13.Text = " ";
            checkBox3.Checked = false; textBox14.Text = " ";
            checkBox9.Checked = false; textBox9.Text = " "; 
            checkBox14.Checked = false; textBox16.Text = " ";
            checkBox13.Checked = false; textBox18.Text = " ";
            checkBox12.Checked = false; textBox17.Text = " ";
            summ();
        
            richTextBox1.Clear();
            foreach(Item i in items)
            {
                richTextBox1.AppendText(i.name + " quantity = " + i.Quantity +"\n");              
            }
   
        }
        public void summ()
        {
            double sum = 0;
            foreach (Item i in items)
            {
                sum += i.pricing();
            }
            //if(Convert.ToInt32(textBox13.Text) >= 4)
            //{
            //    Item parent = new dog();

            //    textBox3.Text = (sum-(200*double.Parse(textBox13.Text))+ (parent as dog).bavarondiscount()).ToString();
            //}
            //if (double.Parse(textBox13.Text) != 4)
      
                textBox3.Text = sum.ToString();


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //Item x = new cat("async", 23, "dsa");
            //x.
           
           //theperson = new  Discountmembers(textBox1.Text, textBox2.Text, textBox6.Text);
           // double discount1 = (double.Parse(textBox3.Text) - (double.Parse(textBox3.Text) * theperson.dsa()));
           // richTextBox2.AppendText("before= " + textBox3.Text + "\n "+ discount1 );

           
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            theperson = new Discountmembers(textBox1.Text, textBox2.Text, textBox6.Text);
            double discount1 = (double.Parse(textBox3.Text) - (double.Parse(textBox3.Text) * theperson.dsa()));
            if (discount1 == double.Parse(textBox3.Text))
            {
                MessageBox.Show("this promocode is invalid");
            }
            else
            {
                MessageBox.Show("this promocode is valid");
            }

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
                groupBox6.Show();
            if(checkBox6.Checked== false)
            {
                groupBox6.Hide();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            theperson = new Discountmembers(textBox1.Text, textBox2.Text, textBox6.Text);
            double discount1 = (double.Parse(textBox3.Text) - (double.Parse(textBox3.Text) * theperson.dsa()));
            if (discount1 == double.Parse(textBox3.Text))
            {
                if (x > 0)
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("inital price= " + textBox3.Text + "\n" + "price with taxes(bravo discount included) = " + (discount1 * 1.14-x));
                }
                else {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("inital price= " + textBox3.Text + "\n" + "price with taxes = " + (discount1 * 1.14));
                }
          
            }
            else
            {
                if (x > 0)
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("inital price= " + textBox3.Text + "\n" + "price with taxes =" + (double.Parse(textBox3.Text) * 1.14) + "\ntotal price (promocode+bravo discount included) = " + (discount1 * 1.14-x));
                }
                else
                {
                    richTextBox2.Clear();
                    richTextBox2.AppendText("inital price= " + textBox3.Text + "\n" + "price with taxes =" + (double.Parse(textBox3.Text) * 1.14) + "\ntotal price (promocode included) = " + (discount1 * 1.14));
                }
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            theperson = new Discountmembers(textBox1.Text, textBox2.Text, textBox6.Text);
            double discount1 = (double.Parse(textBox3.Text) - (double.Parse(textBox3.Text) * theperson.dsa()));
            if (discount1 == double.Parse(textBox3.Text))
            {
                if (x > 0)
                    textBox8.Text = (discount1 * 1.14 - x).ToString();
                else
                    textBox8.Text = (discount1 * 1.14).ToString();
            }
            else
            {
                if (x > 0)
                
                    textBox8.Text = (discount1 * 1.14 - x).ToString();
                else
                    textBox8.Text = (discount1 * 1.14).ToString();

            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("you have entered the customeers name");
                if (textBox2.Text == "")
                    MessageBox.Show("you have entered the customeers phone number");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("you have entered the customeers phone number");
                if (textBox1.Text == "")
                    MessageBox.Show("you have entered the customeers name");
            }
            else
            {


                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into test values ('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + dateTimePicker1.Text + "','"+textBox8.Text+"')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("name: " + textBox1.Text + "\nnumber: " + textBox2.Text + "\n" + richTextBox2.Text);
                richTextBox1.Text = "";
                items.Clear();
            }
            x = 0;
        }

    
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
