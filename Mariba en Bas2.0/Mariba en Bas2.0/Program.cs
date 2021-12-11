using System;

namespace Mariba_en_Bas2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Marimba marimba = new Marimba();
            BassGuitar bassGuitar = new BassGuitar();
            bassGuitar.PlayNote("a");
            marimba.PlayNote("e");
            bassGuitar.PlayNote("g");
            marimba.PlayNote("d#");
            bassGuitar.PlayNote("f");
            marimba.PlayNote("e");
            marimba.PlayNote("d#");
            bassGuitar.PlayNote("e");
            marimba.PlayNote("e");
        }
    }
}
