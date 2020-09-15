using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliWebServ
{
    public class Chambre
    {
        public int NbPlaces
        {
            get;
            set;
        }

        public int NbLitSimple
        {
            get;
            set;
        }

        public int NbLitDouble
        {
            get;
            set;
        }

        public int NumChambre
        {
            get;
            set;
        }

        public Double Prix
        {
            get;
            set;
        }

        private List<Reservation> reserv = new List<Reservation>();

        public void ajouterReserv(Reservation r)
        {
            if (r is null)
            {
                Console.WriteLine("Réservation non valide");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour quitter.");
                Console.ReadLine();
            }
            else
            {
                this.reserv.Add(r);
            }
        }

        public Chambre(int numCh, int nbLitSimple,int nbLitDouble, Double prix)
        {
            this.NumChambre = numCh;
            this.NbLitSimple = nbLitSimple;
            this.NbLitDouble = nbLitDouble;
            this.NbPlaces = 2 * nbLitDouble + nbLitSimple;
            this.Prix = prix;
        }

        public Chambre() {}

        public Boolean isDispo(DateTime da, DateTime dd)
        {
            Boolean libre = true;
            if (this.reserv == null) return libre;
            foreach (Reservation r in this.reserv)
            {
                if (DateTime.Compare(da, r.DDep) < 0 || DateTime.Compare(r.DArr, dd) < 0)
                {
                    libre = false;
                }
            }
            return libre;
        }
    }
}