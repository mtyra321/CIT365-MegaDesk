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
        public DisplayQuote()
        {
            InitializeComponent();
        }


        public void DisplayQuote_Load(object sender, EventArgs e)
        {
            desk = AddQuote.desk;
            String customerName = "";
            int prodTime = 00;
            MaterialValue.Text = desk.SurfaceMaterial;
            widthValue.Text = desk.Width.ToString();
            depthValue.Text = desk.Depth.ToString();
            drawersValue.Text = desk.DrawerNum.ToString();
            surfaceAreaLabel.Text = desk.SurfaceArea.ToString();
            quote = new DeskQuote(desk, prodTime, customerName);
            quote.calcPrice();
            drawerPrice.Text = "$ "+ quote.DrawerPrice.ToString();
            materialPrice.Text = "$ " + quote.MaterialPrice.ToString();
            prodPrice.Text = "$ " + quote.DrawerPrice.ToString();
            surfaceAreaPrice.Text = "$ " + quote.SurfaceAreaPrice.ToString();
            totalPrice.Text = "$ " + quote.TotalCost.ToString();

        }


    }
}
