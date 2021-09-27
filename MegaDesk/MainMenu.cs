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
    public partial class MainMenu : Form
    {
        AddQuote addForm = new AddQuote();
        ViewAllQuotes viewForm = new ViewAllQuotes();
        DisplayQuote displayForm = new DisplayQuote();
        SearchQuotes searchForm = new SearchQuotes();
       // MainMenu mainForm = new MainMenu();
        public MainMenu()
        {
            

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            addForm.Show();
            this.Hide();
        }
        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            viewForm.Show();
            this.Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            searchForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
