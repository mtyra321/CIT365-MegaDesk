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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        public Desk desk;

        public Desk Desk { get => desk; set => desk = value; }

        //   internal Desk Desk { get => desk; set => desk = value; }


        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
        public  void buildDeskBtn_Click(object sender, EventArgs e)
        {
            desk = new Desk((int)widthInput.Value, (int)depthInput.Value, (int)drawersInput.Value,woodTypes.Text);

            int prodTime =Convert.ToInt32(prod.Text);
            String customerName =nameInput.Text;
        }

        public Desk GetDesk()
        {
            return desk;
        }
      

     


































  private void label1_Click(object sender, EventArgs e)
        {

        }


        private void widthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void depthInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void drawersInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void prod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
