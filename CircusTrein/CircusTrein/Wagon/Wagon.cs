using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        public int WagonId { get; set; }
        public int Capacity { get; set; }

        public Wagon()
        {

        }

        public Wagon(int wagonId, int capacity)
        {
            this.WagonId = wagonId;
            this.Capacity = capacity;
        }

        public int GetCapacity()
        {
            StaticId.WagonI += 1;
            this.WagonId = StaticId.WagonI;
            this.Capacity = 10;

            return Capacity;
        }

        public void AddWagon()
        {
            GetCapacity();
            Wagon wagon = new Wagon(WagonId, Capacity);
        }
    }
}
