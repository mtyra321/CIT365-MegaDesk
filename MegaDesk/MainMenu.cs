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

        AddQuote addForm;
        ViewAllQuotes viewForm;
        SearchQuotes searchForm;
        public AddQuote AddForm { get => addForm; set => addForm = value; }
        public ViewAllQuotes ViewForm { get => viewForm; set => viewForm = value; }
        public SearchQuotes SearchForm { get => searchForm; set => searchForm = value; }

        public MainMenu()
        {
            

            InitializeComponent(); 
             addForm = new AddQuote(this);
            viewForm = new ViewAllQuotes(this);
            searchForm = new SearchQuotes(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            addForm = new AddQuote(this);

            addForm.Show();
            this.Hide();
        }
        private void viewQuoteBtn_Click(object sender, EventArgs e)
        {
            viewForm = new ViewAllQuotes(this);

            viewForm.Show();
            this.Hide();
        }

        private void searchQuotesBtn_Click(object sender, EventArgs e)
        {
            searchForm = new SearchQuotes(this);

            searchForm.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
