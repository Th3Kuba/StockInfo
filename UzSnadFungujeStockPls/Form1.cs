using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzSnadFungujeStockPls
{
    public partial class Form1 : Form
    {
        Stocks.Root stock = new Stocks.Root();
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            ApiConsumer ac = new ApiConsumer();
            string template = "https://stock-market-data.p.rapidapi.com/stock/quote?ticker_symbol={0}";
            string data = TBSymbol.Text;
            ac.URL = string.Format(template, data);
            string a = await ac.ApiConsume();
            Console.WriteLine(a);
            stock = JsonConvert.DeserializeObject<Stocks.Root>(a);
            labPrice.Text = stock.quote.CurrentPrice.ToString() + "$";
            labName.Text = stock.quote.CompanyName;
            CheckTodaysProfit();
            labTodaysProfit.Text = stock.quote.TodaySChange.ToString();
            Console.WriteLine(stock.quote.CurrentPrice);
        }
        private void CheckTodaysProfit()
        {
            if(stock.quote.TodaySChange < 0)
            {
                labTodaysProfit.BackColor = Color.FromArgb(150, 255, 0, 0);
            } else
            {
                labTodaysProfit.BackColor = Color.FromArgb(150, 0, 255, 0);
            }
        }



    }

}
