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
        private MainMenu main;

        public AddQuote(MainMenu m)
        {
           InitializeComponent(); 
            main = m;

            
        }

        public Desk desk;

        public Desk Desk { get => desk; set => desk = value; }



      
        public  void buildDeskBtn_Click(object sender, EventArgs e)
        {
            desk = new Desk((int)widthInput.Value, (int)depthInput.Value, (int)drawersInput.Value,woodTypes.Text);
            String customerName = "";
            int prodTime =Convert.ToInt32(prod.Text);
            //try
            //{
                 customerName = nameInput.Text;
            //}catch (Exception we) when (customerName == "")
            //{
            //    throw;
            //}
            DisplayQuote d = new DisplayQuote(main, desk, customerName, prodTime);
            this.Hide();
            d.Show();
        }

        public Desk GetDesk()
        {
            return desk;
        }


        private void AddQuote_FormClosed(object sender, EventArgs e)
        {
            main.Show();
            this.Hide();

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

        private void prod_Click(object sender, EventArgs e)
        {
            prod.DroppedDown = true;
        }

        private void woodTypes_Click(object sender, EventArgs e)
        {
            woodTypes.DroppedDown = true;

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            prod.Text = "14";
            woodTypes.Text = "Oak";
        }
    }
}
