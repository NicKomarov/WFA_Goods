using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Goods
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.table.Rows.Add(textBoxName.Text, Convert.ToDouble(textBoxPrice.Text), dateTimePickerPackingDate.Value, 
                                     textBoxCountryOfOrigin.Text, textBoxDescription.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }
            Close();
        }
    }
}
