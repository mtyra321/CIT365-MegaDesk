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
    public partial class DisplayQuote : Form
    {
        Desk desk;
        DeskQuote quote;
        String customerName;
        int productionTime;
        MainMenu main;
        public DisplayQuote(MainMenu m, Desk desk, String name, int time)
        {
            InitializeComponent();
            main = m;
            
            customerName = name;
            productionTime = time;
            this.desk = desk;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public int ProductionTime { get => productionTime; set => productionTime = value; }

        public void DisplayQuote_Load(object sender, EventArgs e)
        {
            name.Text = customerName;
            MaterialValue.Text = desk.SurfaceMaterial;
            widthValue.Text = desk.Width.ToString();
            depthValue.Text = desk.Depth.ToString();
            drawersValue.Text = desk.DrawerNum.ToString();
           
            quote = new DeskQuote(desk, productionTime, customerName);
            quote.calcPrice();
            prodTime.Text = quote.ProductionTime.ToString() + " days";
            drawerPrice.Text = "$ "+ quote.DrawerPrice.ToString();
            materialPrice.Text = "$ " + quote.MaterialPrice.ToString();
            prodPrice.Text = "$ " + quote.ShippingPrice.ToString();

            surfaceAreaPrice.Text = "$ " + quote.SurfaceAreaPrice.ToString();
            totalPrice.Text = "$ " + quote.TotalCost.ToString();


        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainForm = new MainMenu();
            mainForm.Show();
            this.Hide();
        }

        private void saveQuoteBtn_Click(object sender, EventArgs e)
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
            deskQuoteList.Add(quote);

            string json = JsonConvert.SerializeObject(deskQuoteList.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"quotes.json", json);
            main.Show();
            this.Hide();
        }
    }
}
