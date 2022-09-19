using System;
using System.Collections.Generic;
using System.Text;

namespace Trafficlight
{
    class TrafficLight
    {
        int i;
        string CurrentColor;

        internal void NextState()
        {
            i = i + 1;

            if (i > 2)
            {
                i = 0;
            }

        }

        public string GetCurrentColor()
        {
            if (i < 1)
            {
                CurrentColor = "Red";
            }
            else if (i < 2)
            {
                CurrentColor = "Orange";
            }

            else if(i < 3)
            {
                CurrentColor = "Green";
            }

            return CurrentColor;
        }
    }

}
