using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var jsonData = System.IO.File.ReadAllText(@"quotes.json");
            List<DeskQuote> deskQuoteList;
            if (jsonData.Length == 0)
            {
                deskQuoteList = new List<DeskQuote>();

            }
            else
            {
                deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
            }
            quoteGrid.DataSource = deskQuoteList;
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            this.Hide();
            mainForm.Show();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            this.Close();
            mainForm.Show();
        }
    }
}
