using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliWebServ
{
    public class Client
    {
        public String Nom
        {
            get;
            set;
        }

        public String Prenom
        {
            get;
            set;
        }

        public String InfoCB
        {
            get;
            set;
        }

        public Client(String nom, String prenom, String info)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.InfoCB = info;
        }

        public Client()
        {
            this.Nom = null;
            this.Prenom = null;
            this.InfoCB = null;
        }
    }
}