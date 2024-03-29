﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neeley_MegaDesk1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            Form addQuote = new AddQuote();
            addQuote.Show();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            Form viewQuotes = new ViewAllQuotes();
            viewQuotes.Show();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            Form searchQuotes = new SearchQuotes();
            searchQuotes.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Exit Application?", "Confirm Close", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

