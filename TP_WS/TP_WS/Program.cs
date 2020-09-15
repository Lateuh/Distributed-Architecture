using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WS
{
    class Program
    {
        static void Main(string[] args)
        {
            //TP_WS.WSMeteo.ndfdXMLPortTypeClient meteo = new WSMeteo.ndfdXMLPortTypeClient("https://graphical.weather.gov:443/xml/SOAP_server/ndfdXMLserver.php");
            TP_WS.WSMeteo.ndfdXMLPortTypeClient meteo = new WSMeteo.ndfdXMLPortTypeClient();

            decimal latitude = new decimal(27.344808);
            decimal longitude = new decimal(-80.293768);
            DateTime st = new DateTime(2020,03,03,8,20,10);
            DateTime et = new DateTime(2020, 03, 03, 10, 30, 30);
            String prod = "time-series";
            String unit = "m";
            WSMeteo.weatherParametersType wpt = new WSMeteo.weatherParametersType();


            try
            {
                String retour = meteo.NDFDgen(latitude, longitude, prod, st, et, unit, wpt);
                Console.WriteLine(retour);
            }
            catch (System.ServiceModel.Security.MessageSecurityException e)
            {
                Console.WriteLine("la meteo ne fonctionne pas :( ");
            }

            


            Calcu.CalculatorSoapClient calc = new Calcu.CalculatorSoapClient();

            Console.WriteLine(calc.Add(10, 5));
            Console.ReadLine();


        }
    }
}
