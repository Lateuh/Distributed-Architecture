using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP_WS_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            int nbPlacesVoulu = Convert.ToInt32(cBNbLits.SelectedItem);
            String dArrS = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            String dDepS = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            DateTime dArr = DateTime.Parse(dArrS);
            DateTime dDep = DateTime.Parse(dDepS);
            DateTime aujourdhui = DateTime.Now;
            if (cBNbLits.SelectedIndex == -1)
            {
                MessageBox.Show("Choissisez le nombre de couchage désiré");
            }
            else
            {
                if(dArr.Date < aujourdhui.Date)
                {
                    MessageBox.Show("La date d'arrivée doit être supérieure ou égale à aujourd'hui");
                }
                else if (dDep.Date <= dArr.Date)
                {
                    MessageBox.Show("La date de départ doit être supérieure à celle d'arrivée");
                }
                else
                {
                    ServiceHotel.WebService1SoapClient SH = new ServiceHotel.WebService1SoapClient();
                    List<String> lS = SH.GetDispo("touraco1", "azerty09", nbPlacesVoulu, dArr, dDep);
                    Form2 f2 = new Form2(lS, dArr, dDep, nbPlacesVoulu,this);
                    f2.Show();
                    this.Hide();
                }
            }

        }

    }
}
