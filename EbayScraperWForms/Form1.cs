﻿using System;
using System.Windows.Forms;
using ScrapySharp.Network;
using System.Net;

namespace EbayScraperWForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helpers.Demo demo = new Helpers.Demo();
            string response = demo.DownloadPage("https://www.ebay.co.uk/b/Samsung-Galaxy-S8/9355/bn_75787856?LH_ItemCondition=2000&LH_BIN=1");

            /*
            ScrapingBrowser browser = new ScrapingBrowser();
            browser.AllowAutoRedirect = true;
            browser.AllowMetaRedirect = true;
            WebPage PageResult = browser.NavigateToPage(new Uri("https://www.ebay.co.uk/b/Samsung-Galaxy-S8/9355/bn_75787856?LH_ItemCondition=2000&LH_BIN=1"));
            textBox1.Text = PageResult.ToString();
            */
        }
    }
}
