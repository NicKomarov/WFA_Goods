using System.Data;
using System.Windows.Forms;

namespace WFA_Goods
{
    public partial class Form1 : Form
    {
        public List<Goods> GoodsList { get; set; }
        public static DataTable table = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(id);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GoodsList = new List<Goods>()
            {
                new Products(10.0, "Ukraine", "milk", new DateTime(2022, 8, 11), "5%", new DateTime(2022, 8, 11), 8, "l"),
                new Books(200.0, "UK", "1984", new DateTime(2022, 8, 11), "antiutopia", 300, "Books in UK", "George Orwell"),
                new Books(250.0, "Poland", "The Witcher", new DateTime(2022, 8, 11), "fantasy", 270, "Warsaw Book Fair", "Andrzej Sapkowski"),
                new Products(12.0, "Ukraine", "apple", new DateTime(2022, 8, 11), "yellow", new DateTime(2022, 8, 11), 30, "kg")
            };

            table.Columns.Add("Назва", typeof(string));
            table.Columns.Add("Ціна", typeof(double));
            table.Columns.Add("Дата пакування", typeof(DateTime));
            table.Columns.Add("Країна походження", typeof(string));
            table.Columns.Add("Опис", typeof(string));

            foreach (var item in GoodsList)
            {
                table.Rows.Add(item.Name, item.Price, item.PackingDate, item.CountryOfOrigin, item.Description);
            }

            dataGridView1.DataSource = table;
        }
    }
}