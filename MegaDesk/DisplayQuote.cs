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
        public DisplayQuote()
        {
            InitializeComponent();
        }


        public void DisplayQuote_Load(object sender, EventArgs e)
        {
            // desk = AddQuote.desk;
            MaterialValue.Text = desk.SurfaceMaterial;
            widthValue.Text = desk.Width.ToString();
            depthValue.Text = desk.Depth.ToString();
            drawersValue.Text = desk.DrawerNum.ToString();

        }


    }
}
