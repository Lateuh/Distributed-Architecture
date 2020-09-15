using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliWebServ
{
    public class Hotel
    {
        public int Etoile
        {
            get;
            set;
        }

        public String Pays
        {
            get;
            set;
        }

        public String Ville
        {
            get;
            set;
        }

        public String Rue
        {
            get;
            set;
        }

        public int NumRue
        {
            get;
            set;
        }

        public String NomHotel
        {
            get;
            set;
        }

        public int GeoX
        {
            get;
            set;
        }

        public int GeoY
        {
            get;
            set;
        }

        private List<Chambre> ListeChambre = new List<Chambre>();

        public List<Chambre> getListeChambre()
        {
            return this.ListeChambre;
        }

        public Hotel(String nom, String pays, String ville, int numrue, String rue, int nbEtoile)
        {
            this.NomHotel = nom;
            this.Pays = pays;
            this.Ville = ville;
            this.NumRue = numrue;
            this.Rue = rue;
            this.Etoile = nbEtoile;
        }

        public void ajouterChambre(Chambre ch)
        {
            this.ListeChambre.Add(ch);
        }
    }
}