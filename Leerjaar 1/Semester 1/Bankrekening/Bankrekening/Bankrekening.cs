using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Bankrekening
    {
        private int rekeningnummer;
        private string naam;
        private int saldo;
        private static int volgendeVrijeRekeningnummer = 2001;

        public int Rekeningnummer
        {
            get { return rekeningnummer; }
        }

        public string Naam
        {
            get { return naam; }
        }

        public int Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        public Bankrekening(string naam)
        {
            this.naam = naam;
            saldo = 0;
            rekeningnummer = volgendeVrijeRekeningnummer;

            ++volgendeVrijeRekeningnummer;
        }

        public Bankrekening(string naam, int saldo)
        {
            this.naam = naam;
            saldo = saldo;
        }

        public void NeemOp(int bedrag)
        {
            if (bedrag > 0)
            {
                if (saldo >= bedrag)
                {
                    saldo = saldo - bedrag;
                }
            }
        }

        public void Stort(int bedrag)
        {
            if (bedrag > 0)
            {
                if (saldo >= bedrag)
                {
                    saldo = saldo - bedrag;
                }
            }
        }

        public void MaakOver(Bankrekening andereRekening, int bedrag)
        {
            if (bedrag > 0)
            {
                if (saldo >= bedrag)
                {
                    saldo = saldo - bedrag;
                }
            }
        }
    }
}
