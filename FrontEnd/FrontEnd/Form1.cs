using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("User Interface");
            comboBox1.Items.Add("Web Services");
        }


        private void Push_Click(object sender, EventArgs e)
        {
            if (!by.Text.Equals(string.Empty) && !comboBox1.SelectedItem.Equals(string.Empty) && !maskedTextBox1.Text.Equals(string.Empty))
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        string URI = string.Format("http://localhost:3680/api/WebAPI/Push");
                        string[] x = { by.Text.ToString(), comboBox1.SelectedItem.ToString(), DateTime.Parse(maskedTextBox1.Text).ToString("MM/dd/yyyy") };
                       //MessageBox.Show(comboBox1.SelectedItem.ToString()+ "  "+by.Text+" "+maskedTextBox1.Text);
                        var serializedProduct = JsonConvert.SerializeObject(x);
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        var result = client.PostAsync(URI, content).Result;
                        Pull();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
            else MessageBox.Show("please fill all fields first");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void by_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
            if (by.Text.Equals(string.Empty))
            {
                MessageBox.Show("you must enter something");
                by.Clear();
                by.Focus();
            }
            else
            {
                comboBox1.Focus();
                comboBox1.AllowDrop = true;
            }
        }
            }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                try
                {
                    if (comboBox1.SelectedItem.Equals(string.Empty))
                        comboBox1.Focus();
                    else
                    {
                        maskedTextBox1.Focus();
                    }
                }
                catch (Exception e1)
                {
                    comboBox1.Focus();
                }
                }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (!string.IsNullOrEmpty(maskedTextBox1.Text))
                {
                      string date = DateTime.Parse(maskedTextBox1.Text).ToString("dd/MM/yyyy");
                        DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                        Push.Focus();
                   // }
                   
                     //   maskedTextBox1.Clear();
                     //   maskedTextBox1.Focus();
                      //  MessageBox.Show(e1.ToString());
                    
                }
                else
                {
                    MessageBox.Show("Please enter the date");
                    maskedTextBox1.Clear();
                    maskedTextBox1.Focus();
                }
            }
        }

        private void Pull_Click(object sender, EventArgs e)
        {
          
        }

        private void Free_Click(object sender, EventArgs e)
        {

            try
            {
                using (var client = new HttpClient())
                {
                    var s = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                  //  MessageBox.Show(s.ToString());
                    string URI = string.Format("http://localhost:3680/api/WebAPI/Free/{0}", s);
                    var result = client.DeleteAsync(URI).Result;
                    Pull();
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Please select a row first");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!by.Text.Equals(string.Empty) && !comboBox1.SelectedItem.Equals(string.Empty) && !maskedTextBox1.Text.Equals(string.Empty))
            {

                try
                {
                    using (var client = new HttpClient())
                    {
                        string URI = string.Format("http://localhost:3680/api/WebAPI/Change");
                        var s =  Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        string[] param = { by.Text, comboBox1.SelectedItem.ToString(),DateTime.Parse(maskedTextBox1.Text).ToString("MM/dd/yyyy"), s.ToString() };
                        var serializedProduct = JsonConvert.SerializeObject(param);
                        var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");
                        var result = client.PutAsync(URI, content).Result;
                        Pull();
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
            }
            else MessageBox.Show("please fill all fields first");
            {

            }
        }

        private void Pull()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string URI = "http://localhost:3680/api/WebAPI/Pull/";
                    using (var response = client.GetAsync(URI).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var productJsonString = response.Content.ReadAsStringAsync().Result;
                            DataTable table = JsonConvert.DeserializeObject<DataTable>(productJsonString);
                          //  MessageBox.Show(table.Rows.Count.ToString());
                            dataGridView1.DataSource = table;

                        }

                    }

                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        
        }

        private void Poll_Click(object sender, EventArgs e)
        {
            Pull();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            by.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            comboBox1.SelectedItem = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            maskedTextBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }  
    }
}
