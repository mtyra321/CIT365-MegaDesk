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
    public partial class SearchQuotes : Form
    {
        private MainMenu main;
        private List<DeskQuote> deskQuoteList;

        public SearchQuotes(MainMenu m)
        {
            

            InitializeComponent();
            main = m;
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            var file = @"quotes.json";
            if (File.Exists(file))
            {
                using (StreamReader reader = new StreamReader(file))
                {



                    string jsonData = reader.ReadToEnd();

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

                    })
                        
                .ToList();
                }
            }
        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            main.Show();
        }

        private void FilterBox_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void filter()
        {
            

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

            })
                        .Where(d => d.SurfaceMaterial == FilterBox.Text)
                .ToList();
            //dv.DefaultView.RowFilter = string.Format("[SurfaceMaterial] LIKE '%{0}%'", FilterBox.SelectedItem);
            //quoteGrid.DataSource = dv;
            //            quoteGrid.Refresh();

        }

        private void FilterBox_Click(object sender, EventArgs e)
        {
            FilterBox.DroppedDown = true;

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
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
