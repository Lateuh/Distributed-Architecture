using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_WS_WF
{
    public partial class Form2 : Form
    {
        private DateTime dArr;
        private DateTime dDep;
        private int nbPlaces;
        private Form1 f1;

        public Form2(List<String> lS, DateTime dA, DateTime dD, int nbLits, Form1 f1)
        {
            InitializeComponent();
            this.dArr = dA;
            this.dDep = dD;
            this.nbPlaces = nbLits;
            listOffres.DataSource = lS;
            this.f1 = f1;
        }

        private void ButtonRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.f1.Show();
        }

        private void ButtonVoir_Click(object sender, EventArgs e)
        {
            String choix = Convert.ToString(listOffres.SelectedItem);
            Form3 f3 = new Form3(choix);
            f3.Show();

        }

        private void ButtonReserver_Click(object sender, EventArgs e)
        {
            ServiceHotel.WebService1SoapClient SH = new ServiceHotel.WebService1SoapClient();

            if (!String.IsNullOrEmpty(TBNom.Text) && !String.IsNullOrEmpty(TBPrenom.Text) && !String.IsNullOrEmpty(TBNumCB.Text) && !String.IsNullOrEmpty(listOffres.SelectedItem.ToString()) )
            {
                String numChambre = listOffres.SelectedItem.ToString().Substring(9,2);
                if(numChambre.Contains(" "))
                {
                    numChambre = numChambre.Substring(0, 1);
                }
                String reference = SH.Reserver(TBNom.Text, TBPrenom.Text, TBNumCB.Text, numChambre, "touraco1", "azerty09", nbPlaces, dArr, dDep);
                Form3 f4 = new Form3(listOffres.SelectedItem.ToString(), reference);
                f4.Show();
                //MessageBox.Show(reference);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs s'il vous plaît");
            }

        }
    }
}
