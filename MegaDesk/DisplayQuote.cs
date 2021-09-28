using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        Desk desk;
        DeskQuote quote;
        String customerName;
        int productionTime;
        public DisplayQuote(Desk desk, String name, int time)
        {            
            InitializeComponent();
            customerName = name;
            productionTime = time;
            this.desk = desk;
        }

        public string CustomerName { get => customerName; set => customerName = value; }
        public int ProductionTime { get => productionTime; set => productionTime = value; }

        public void DisplayQuote_Load(object sender, EventArgs e)
        {
           // desk = AddQuote.desk;
            MaterialValue.Text = desk.SurfaceMaterial;
            widthValue.Text = desk.Width.ToString();
            depthValue.Text = desk.Depth.ToString();
            drawersValue.Text = desk.DrawerNum.ToString();
           // surfaceAreaLabel.Text = desk.SurfaceArea.ToString();
           
            quote = new DeskQuote(desk, productionTime, customerName);
            quote.calcPrice();
            prodTime.Text = quote.ProductionTime.ToString() + " days";
            drawerPrice.Text = "$ "+ quote.DrawerPrice.ToString();
            materialPrice.Text = "$ " + quote.MaterialPrice.ToString();
            prodPrice.Text = "$ " + quote.DrawerPrice.ToString();
            surfaceAreaPrice.Text = "$ " + quote.SurfaceAreaPrice.ToString();
            totalPrice.Text = "$ " + quote.TotalCost.ToString();


        }


    }
}
