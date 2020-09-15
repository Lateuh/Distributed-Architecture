using System;
using System.Collections.Generic;
using System.Web.Services;

namespace AppliWebServ
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private List<Hotel> listHotel = new List<Hotel>();
        private Dictionary<String, Agence> listAgence = new Dictionary<string, Agence>(); 

        public WebService1()
        {
            Hotel h1 = new Hotel("Ibis", "France", "Narbonne", 34, "Rue Les olivettes", 2);
            Hotel h2 = new Hotel("F1", "France", "Narbonne", 15, "Rue Les olivettes", 1);
            Hotel h3 = new Hotel("Mercure", "France", "Montpellier", 2, "Place de la comédie", 3);
            Hotel h4 = new Hotel("Hilton", "France", "Paris", 118, "Rue Rivoli", 4);

            h1.ajouterChambre(new Chambre(101,1,1, 40));
            h1.ajouterChambre(new Chambre(102,1,1, 40));
            h1.ajouterChambre(new Chambre(103,1,1, 40));
            h1.ajouterChambre(new Chambre(104,1,1, 40));
            h1.ajouterChambre(new Chambre(105,1,0, 35));
            h1.ajouterChambre(new Chambre(204,1,1, 40));
            h1.ajouterChambre(new Chambre(206,1,1, 40));
            h1.ajouterChambre(new Chambre(301,1,2, 50));
            h1.ajouterChambre(new Chambre(307,1,1, 40));
            h1.ajouterChambre(new Chambre(309,1,1, 40));

            h2.ajouterChambre(new Chambre(101,0,1,30));
            h2.ajouterChambre(new Chambre(102,0,1, 30));
            h2.ajouterChambre(new Chambre(103,1,0, 35));
            h2.ajouterChambre(new Chambre(104,1,0, 35));
            h2.ajouterChambre(new Chambre(201,1,1, 40));
            h2.ajouterChambre(new Chambre(203,1,1, 40));
            h2.ajouterChambre(new Chambre(203,1,1, 40));
            h2.ajouterChambre(new Chambre(301,1,2, 50));
            h2.ajouterChambre(new Chambre(302,1,2, 50));
            h2.ajouterChambre(new Chambre(302,1,2, 50));
            h2.ajouterChambre(new Chambre(302,1,2, 50));

            h3.ajouterChambre(new Chambre(101, 0, 1, 50));
            h3.ajouterChambre(new Chambre(102, 0, 1, 50));
            h3.ajouterChambre(new Chambre(103, 0, 1, 50));
            h3.ajouterChambre(new Chambre(104, 1, 0, 55));
            h3.ajouterChambre(new Chambre(104, 1, 0, 55));
            h3.ajouterChambre(new Chambre(201, 1, 1, 60));
            h3.ajouterChambre(new Chambre(203, 1, 1, 60));
            h3.ajouterChambre(new Chambre(203, 1, 1, 60));
            h3.ajouterChambre(new Chambre(301, 1, 2, 65));

            h4.ajouterChambre(new Chambre(101, 0, 1, 100));
            h4.ajouterChambre(new Chambre(111, 1, 0, 150));
            h4.ajouterChambre(new Chambre(201, 1, 1, 200));
            h4.ajouterChambre(new Chambre(211, 1, 1, 200));
            h4.ajouterChambre(new Chambre(300, 1, 2, 250));
        

            listHotel.Add(h1);
            listHotel.Add(h2);
            listHotel.Add(h3);
            listHotel.Add(h4);

            Agence Touraco = new Agence("touraco1", "azerty09", 10);

            listAgence["touraco1"] = Touraco; // == listAgence.Add("touraco1",Touraco);

        }

        [WebMethod]
        public List<String>  GetDispo(String idAgence, String mdpAgence,int nbPers, DateTime dA, DateTime dD)
        {
            List<String> lS = new List<string>();
            Agence A = listAgence[idAgence];
            if(A != null && A.mdp == mdpAgence)
            {
                int numOffre = 1;
                foreach(Hotel h in listHotel)
                {
                    foreach(Chambre c in h.getListeChambre())
                    {
                        if(c.isDispo(dA, dD) && c.NbPlaces == nbPers)
                        {
                            lS.Add("Dispo n° " + numOffre + " : " + h.NomHotel + " " + h.Etoile +  " étoiles en " + h.Pays + " à " + h.Ville + " " + h.Rue 
                                + " avec " + c.NbLitDouble + " lit double et " + c.NbLitSimple + " lit simple. PORTE - "
                                + c.NumChambre + " PRIX : " + (c.Prix + (c.Prix * A.pourcentage / (double)100)) + " €");
                            numOffre++;
                        }
                    }
                }
            }
            else
            {
                lS.Add("Agence introuvable");
            }

            return lS;
        }


        [WebMethod]
        public String GetImg(String choix)
        {

            System.Drawing.Image img=null;
            if (choix.Contains("Hilton"))
            {
                img = System.Drawing.Image.FromFile(Server.MapPath("images") + @"\hilton.png");
            }else if (choix.Contains("Mercure"))
            {
                img = System.Drawing.Image.FromFile(Server.MapPath("images") + @"\mercure.png");
            }
            else if (choix.Contains("Ibis"))
            {
                img = System.Drawing.Image.FromFile(Server.MapPath("images") + @"\ibis.png");
            }
            else if (choix.Contains("F1"))
            {
                img = System.Drawing.Image.FromFile(Server.MapPath("images") + @"\f1.png");
            }

            System.IO.MemoryStream stream = new System.IO.MemoryStream();
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            Byte[] imgByte = stream.ToArray();
            String imgStr = Convert.ToBase64String(imgByte);
            img.Dispose();
            stream.Dispose();
            return imgStr;
        }

        public String extractNomHotel(String s)
        {
            String ret = null;

            if (s.Contains("Hilton"))
            {
                ret = "Hilton";
            }
            else if (s.Contains("Mercure"))
            {
                ret = "Mercure";
            }
            else if (s.Contains("Ibis"))
            {
                ret = "Ibis";
            }
            else if (s.Contains("F1"))
            {
                ret = "F1";
            }
            return ret;
        }


        public int extractNumChambre(String s)
        {
            String ret = s.Substring(s.IndexOf("-"),5);
            ret = ret.Substring(2, 3);
            return Convert.ToInt32(ret);
        }


        [WebMethod]
        public String Reserver(String nom, String prenom, String numCB, String choixChambre,String idAgence, String mdpAgence, int nbPlace, DateTime dArr, DateTime dDep)
        {
            String ret = "Réservation échouée";
            List<String> lDispo = GetDispo(idAgence, mdpAgence, nbPlace, dArr, dDep);
            foreach(String offre in lDispo)
            {
                if(offre.Contains("n° " + choixChambre))
                {
                    String nomH = extractNomHotel(offre);
                    int numChamb = extractNumChambre(offre);
                    List<Chambre> lC = null;
                    foreach(Hotel h in listHotel)
                    {
                        if(h.NomHotel == nomH)
                        {
                            lC = h.getListeChambre();
                            foreach(Chambre c in lC)
                            {
                                if(c.NumChambre == numChamb)
                                {
                                    Reservation resa = new Reservation(new Client(nom, prenom, numCB), c, dArr, dDep);
                                    c.ajouterReserv(resa);
                                    ret = resa.toString();
                                    return ret;
                                }
                            }
                        }
                    }
                }
            }

            return ret;
        }
    }
}
