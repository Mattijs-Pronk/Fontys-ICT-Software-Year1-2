using System;
using System.Collections.Generic;
using System.Text;

namespace Trafficlight_with_enum
{
    class TrafficLight
    {
        public enum TrafficlightColors
        {
            Red,
            Orange,
            Green
        }

        int i;
        string CurrentColor;

        internal void NextState()
        {
            i ++;

            if (i > 2)
            {
                i = 0;
            }

        }

        public string GetCurrentColor()
        {
            TrafficlightColors rood = TrafficlightColors.Red;
            TrafficlightColors oranje = TrafficlightColors.Orange;
            TrafficlightColors groen= TrafficlightColors.Green;

            if (i < 1)
            {
                CurrentColor = Convert.ToString(rood);
            }

            else if (i < 2)
            {
                CurrentColor = Convert.ToString(oranje);
            }

            else if (i < 3)
            {
                CurrentColor = Convert.ToString(groen);
            }

            return CurrentColor;
        }
    }
}
