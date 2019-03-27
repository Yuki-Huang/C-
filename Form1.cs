using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMark
{
    public partial class Form1 : Form
    {

        class MenuMaker
        {
            public Random Randomizer;
            string[] Meat = { "Roast beef", "Salamt", "Turkey", "Ham", "Pastrami" };
            string[] Condiments = { "yellow","honey", "mayo" };
            string[] Breads = { "rye", "white","wheat" };
            public string GetMenuItem()
            {
                string randomMeat = Meat[Randomizer.Next(Meat.Length)];
                string randomCond = Condiments[Randomizer.Next(Condiments.Length)];
                string randomBreads = Breads[Randomizer.Next(Breads.Length)];
                return randomMeat+"肉類" + randomCond+"醬料" + randomBreads+"麵包";
            }

        }
        public Form1()
        {
            InitializeComponent();
            MenuMaker menu = new MenuMaker() { Randomizer = new Random() };
            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
