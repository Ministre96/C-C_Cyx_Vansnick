using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClickCollect_Cyx_Vansnick.Models.POCO
{
    public class Command
    {
        private int idCommand;
        private DateTime orderPickUp;
        private int nbrBox;
        private bool paid;

        public bool Paid
        {
            get { return paid; }
            set { paid = value; }
        }

        public int NbrBox
        {
            get { return nbrBox; }
            set { nbrBox = value; }
        }

        public DateTime MyProperty
        {
            get { return orderPickUp; }
            set { orderPickUp = value; }
        }

        public int IdCommand
        {
            get { return idCommand; }
            set { idCommand = value; }
        }

        public Command()
        {

        }
    }
}
