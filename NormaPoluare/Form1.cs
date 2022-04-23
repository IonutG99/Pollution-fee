using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormaPoluare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void Norma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Norma.SelectedItem.ToString() == "Hibride, electrice, Euro 6" || Norma.SelectedItem.ToString() == "Euro 2, Euro 1, Non-Euro")
            {

                EmisiaCO2.Text = "";
                EmisiaCO2.Enabled = false;
            }
            else EmisiaCO2.Enabled = true;

            if (Norma.SelectedItem.ToString() == "Hibride, electrice, Euro 6")
            {

                CapacitateCilindrica.Enabled = false;
                CapacitateCilindrica.Text = "";
            }
            else
            {
                CapacitateCilindrica.Enabled = true;

            }

        }

        private void CalculeazaTaxa_Click(object sender, EventArgs e)
        {
            double A = 0, B = 0, C = 0, D = 0, E = 0;
            try
            {
                switch (AnFabricatie.SelectedItem.ToString())
                {
                    case "nou":
                        E = 0;
                        break;
                    case "< 1 an":
                        E = 10;
                        break;
                    case "< 3 ani":
                        E = 30;
                        break;
                    case "< 5 ani":
                        E = 40;
                        break;
                    case "< 10 ani":
                        E = 60;
                        break;
                    case "Peste 10 ani":
                        E = 80;
                        break;
                    default:

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selectati un an de fabricatie!");
            }

            try
            {
                switch (Norma.SelectedItem.ToString())
                {
                    case "Hibride, electrice, Euro 6":
                        A = 1;
                        B = 0;
                        C = 1;
                        D = 0;
                        break;
                    case "Euro5":
                        try
                        {
                            A = Convert.ToDouble(EmisiaCO2.Text);
                            if (A <= 120) B = 0;
                            else if (A >= 121 && A <= 210) B = 1;
                            else if (A >= 211 && A <= 270) B = 4;
                            else if (A >= 271) B = 8;
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o emisie de CO2!");
                        }

                        try
                        {
                            C = Convert.ToDouble(CapacitateCilindrica.Text);
                            if (C <= 2000) D = 1.3;
                            else D = 0.39;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o capacitate cilindrica!");
                        }

                        break;
                    case "Euro4":
                        try
                        {
                            A = Convert.ToDouble(EmisiaCO2.Text);
                            if (A <= 120) B = 0;
                            else if (A >= 121 && A <= 210) B = 1;
                            else if (A >= 211 && A <= 270) B = 4;
                            else if (A >= 271) B = 8;
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o emisie de CO2!");
                        }

                        try
                        {
                            C = Convert.ToDouble(CapacitateCilindrica.Text);
                            if (C <= 2000) D = 0.13;
                            else D = 3;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o capacitate cilindrica!");
                        }

                        break;
                    case "Euro3":
                        try
                        {
                            A = Convert.ToDouble(EmisiaCO2.Text);
                            if (A <= 120) B = 0;
                            else if (A >= 121 && A <= 210) B = 1;
                            else if (A >= 211 && A <= 270) B = 4;
                            else if (A >= 271) B = 8;
                        }

                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o emisie de CO2!");
                        }
                        try
                        {
                            C = Convert.ToDouble(CapacitateCilindrica.Text);
                            if (C <= 2000) D = 9;
                            else D = 16;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o capacitate cilindrica!");
                        }


                        break;
                    case "Euro 2, Euro 1, Non-Euro":
                        A = 1;
                        B = 16;
                        try
                        {
                            C = Convert.ToDouble(CapacitateCilindrica.Text);
                            if (C <= 2000) D = 9;
                            else D = 16;

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Introdu o capacitate cilindrica!");
                        }


                        break;
                    default:

                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selectati o norma de poluare!");
            }

            //Suma de plată ={ [(A x B x 30%) + (C x D x 70%)] x (100 - E) %}/100,
            double Taxa;
            Taxa = (((A * B * 30 / 100) + (C * D * 70 / 100)) * (100 - E) / 100) / 100;
            ValoareTaxa.Enabled = true;
            ValoareTaxa.Text = Taxa.ToString();
            ValoareTaxa.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Norma.Items.Add("Hibride, electrice, Euro 6");
            Norma.Items.Add("Euro5");
            Norma.Items.Add("Euro4");
            Norma.Items.Add("Euro3");
            Norma.Items.Add("Euro 2, Euro 1, Non-Euro");

            ValoareTaxa.Enabled = false;

            AnFabricatie.Items.Add("nou");
            AnFabricatie.Items.Add("< 1 an");
            AnFabricatie.Items.Add("< 3 ani");
            AnFabricatie.Items.Add("< 5 ani");
            AnFabricatie.Items.Add("< 10 ani");
            AnFabricatie.Items.Add("Peste 10 ani");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}