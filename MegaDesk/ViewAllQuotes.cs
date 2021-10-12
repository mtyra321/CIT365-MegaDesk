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
using System.IO;


namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        private MainMenu main;
        public ViewAllQuotes(MainMenu m)
        {
            InitializeComponent();
            main = m;

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            var file = @"quotes.json";
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {



                    string jsonData = reader.ReadToEnd();
                    List<DeskQuote> deskQuoteList;

                    deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);

                    quoteGrid.DataSource = deskQuoteList.Select(d => new
                    {
                        Date = d.Date,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.DrawerNum,
                        SurfaceMaterial = d.Desk.SurfaceMaterial,
                        DeliveryType = d.ProductionTime,
                        QuoteAmount = d.TotalCost.ToString("c")

                    }
                    ).ToList();
                }
        }
        }
    }
}
