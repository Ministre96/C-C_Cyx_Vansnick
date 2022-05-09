using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickCollect_Cyx_Vansnick.Models.POCO
{
    public class Article
    {
        private int idArticle;
        private string name;
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int IdArticle
        {
            get { return idArticle; }
            set { idArticle = value; }
        }
        public Article(string n, double p)
        {
            name = n;
            price = p;
        }
    }
}
