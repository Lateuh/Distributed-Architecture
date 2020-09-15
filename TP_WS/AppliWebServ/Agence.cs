using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppliWebServ
{
    public class Agence
    {
        public String id
        {
            get;
            set;
        }

        public String mdp
        {
            get;
            set;
        }

        public Double pourcentage
        {
            get;
            set;
        }

        public Agence(String id, String mdp, int pourcentage)
        {
            this.id = id;
            this.mdp = mdp;
            this.pourcentage = pourcentage;
        }
    }
}