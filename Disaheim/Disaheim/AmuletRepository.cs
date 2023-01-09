using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();


        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            Amulet amulet = null;
            foreach (Amulet a in amulets)
            {
                if(a.ItemId == itemId)
                {
                    amulet = a;
                }

            }

            return amulet;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility util = new Utility();


            if (amulets != null)
            {
                foreach (Amulet amulet in amulets)
                {
                    totalValue += util.GetValueOfAmulet(amulet);
                }
            }
            return totalValue;
        }
    }
}
