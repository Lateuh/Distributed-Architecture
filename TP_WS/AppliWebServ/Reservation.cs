using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliWebServ
{
    public class Reservation
    {
        public Client Cl
        {
            get;
            set;
        }

        public Chambre Ch
        {
            get;
            set;
        }

        public DateTime DArr
        {
            get;
            set;
        }

        public DateTime DDep
        {
            get;
            set;
        }

        public Reservation(Client client, Chambre chambre, DateTime da, DateTime dd)
        {
            this.Cl = client;
            this.Ch = chambre;
            this.DArr = da;
            this.DDep = dd;
        }

        public Reservation()
        {
            this.Cl = null;
            this.Ch = null;
        }

        public String toString()
        {
            return "Réservation confirmée pour M. " + this.Cl.Nom + " " + this.Cl.Prenom + " de la chambre " + this.Ch.NumChambre + " pour " +
                this.Ch.NbPlaces + " personnes." ;
        }
    }
}