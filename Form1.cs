using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ProiectB5
{
    public partial class Form1 : Form
    {
        //path fisiere trace
        String FBUBBLE = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FBUBBLE.TRA";
        String FMATRIX = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FMATRIX.TRA";
        String FPERM = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FPERM.TRA";
        String FPUZZLE = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FPUZZLE.TRA";
        String FQUEENS = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FQUEENS.TRA";
        String FSORT = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FSORT.TRA";
        String FTOWER = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FTOWER.TRA";
        String FTREE = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\FTREE.TRA";

        List<String> traces = new List<String>();

        Predictie predictie;
        int nr_Perceptroni = 0, istorie_Globala = 0, prag = 0;

        int ct_salturi_predictionate_corect = 0;
        int ct_salturi_predictionate_incorect = 0;
        int ct_salturi = 0;

        int[] salturi; //fiecare element contine numarul de salturi aferent fisierului TRACE de pe aceeasi pozitie din lista de trace-uri
        int[] salturi_corecte;

        Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        public void Populare_lista_traces()
        {
            for (int i = 0; i < lista_Trace.Items.Count; i++)
            {
                if (lista_Trace.GetItemChecked(i))
                {
                    switch (lista_Trace.Items[i].ToString())
                    {
                        case "FBUBBLE.TRA":
                            traces.Add(FBUBBLE);
                            break;
                        case "FMATRIX.TRA":
                            traces.Add(FMATRIX);
                            break;
                        case "FPERM.TRA":
                            traces.Add(FPERM);
                            break;
                        case "FPUZZLE.TRA":
                            traces.Add(FPUZZLE);
                            break;
                        case "FQUEENS.TRA":
                            traces.Add(FQUEENS);
                            break;
                        case "FSORT.TRA":
                            traces.Add(FSORT);
                            break;
                        case "FTOWER.TRA":
                            traces.Add(FTOWER);
                            break;
                        case "FTREE.TRA":
                            traces.Add(FTREE);
                            break;
                    }
                }
            }

            //initializare vectori salturi
            salturi = new int[traces.Count];
            salturi_corecte = new int[traces.Count];
        }

        public void Predictioanare_fiecare_salt(List<String> traces, int N, int h, int tip_perceptron)
        {
            System.IO.StreamReader file;
            String line;
            bool val_asteptata;

            for (int i = 0; i < traces.Count; i++)
            {
                ct_salturi_predictionate_corect = 0;
                ct_salturi_predictionate_incorect = 0;
                ct_salturi = 0;

                file = new System.IO.StreamReader(traces[i]);
                //citire fiecare linie
                while ((line = file.ReadLine()) != null)
                {
                    //incrementare contor salturi
                    ct_salturi++;

                    //preluare valoare dorita (Taken/ Not Taken)
                    String[] impartire_linie = line.Split(' ');
                    String tip_salt = impartire_linie[0];
                    int PC = int.Parse(impartire_linie[1]);

                    if (tip_salt[0] == 'B')
                    {
                        val_asteptata = true;
                    }
                    else
                    {
                        val_asteptata = false;
                    }

                    //predictionare salt
                    bool pred = false;
                    switch (tip_perceptron)
                    {
                        case 0: //simplu
                            pred = predictie.MecanismPredictie(PC, val_asteptata);
                            break;
                        case 1: 
                            break;
                    }


                    //verificare daca s-a predictionat corect sau nu
                    if (pred == val_asteptata)
                    {
                        //predictie corecta
                        ct_salturi_predictionate_corect++;
                    }
                    else
                    {
                        //predictie incorecta
                        ct_salturi_predictionate_incorect++;
                    }

                    //salvare rezultate
                    salturi[i] = ct_salturi;
                    salturi_corecte[i] = ct_salturi_predictionate_corect;

                }
            }
        }

        public void Predictioanare_salt_conditionat(List<String> traces, int N, int h, int tip_perceptron)
        {
            System.IO.StreamReader file;
            String line;
            bool val_asteptata;

            for (int i = 0; i < traces.Count; i++)
            {
                ct_salturi_predictionate_corect = 0;
                ct_salturi_predictionate_incorect = 0;
                ct_salturi = 0;

                file = new System.IO.StreamReader(traces[i]);
                //citire fiecare linie
                while ((line = file.ReadLine()) != null)
                {
                    //preluare valoare dorita (Taken/ Not Taken)
                    String[] impartire_linie = line.Split(' ');
                    String tip_salt = impartire_linie[0];
                    int PC = int.Parse(impartire_linie[1]);

                    if (tip_salt[1] == 'T' || tip_salt[1] == 'F')
                    {
                        //incrementare contor salturi
                        ct_salturi++;

                        if (tip_salt[0] == 'B')
                        {
                            val_asteptata = true;
                        }
                        else
                        {
                            val_asteptata = false;
                        }

                        //predictionare salt
                        bool pred = false;
                        switch (tip_perceptron)
                        {
                            case 0: //simplu
                                pred = predictie.MecanismPredictie(PC, val_asteptata);
                                break;
                            case 1: 
                                break;
                            
                        }

                        //verificare daca s-a predictionat corect sau nu
                        if (pred == val_asteptata)
                        {
                            //predictie corecta
                            ct_salturi_predictionate_corect++;
                        }
                        else
                        {
                            //predictie incorecta
                            ct_salturi_predictionate_incorect++;
                        }

                        //salvare rezultate
                        salturi[i] = ct_salturi;
                        salturi_corecte[i] = ct_salturi_predictionate_corect;
                    }
                }
            }
        }

        private void buton_Sterge_Click(object sender, EventArgs e)
        {
            textBox_Rezultate.Text = "";
        }

        private void buton_Grafic_Click(object sender, EventArgs e)
        {
            buton_Grafic.Enabled = false;
            form2 = new Form2();

            for (int i = 0; i < traces.Count; i++)
            {
                String[] nume_tra = traces[i].Split('\\');
                String nume_trace = nume_tra[nume_tra.Length - 1];
                nume_trace = nume_trace.Replace(".TRA", "");

                form2.chart1.Series["Ap"].Points.AddXY(nume_trace, Math.Round((((double)salturi_corecte[i] / (double)salturi[i]) * 100.0), 2));
            }

            //afisare medie pe grafic
            form2.chart1.Series["Ap"].Points.AddXY("Medie", Medie_AP(salturi, salturi_corecte));
            form2.chart1.Series["Ap"].Points[form2.chart1.Series["Ap"].Points.Count - 1].Color = Color.Red;
            //afisare valori pe grafic
            form2.chart1.Series["Ap"].IsValueShownAsLabel = true;

            form2.label1.Text = "Acuratetea predictiei (nr_Perceptroni=" + nr_Perceptroni + ", istorie_Globala=" + istorie_Globala + ", prag=" + prag + ")";

            //afisare grafic
            form2.Show();
        }

        public double Medie_AP(int[] salturi, int[] salturi_corecte)
        {
            double medie = 0;
            double suma = 0;

            for (int i = 0; i < salturi.Length; i++)
            {
                suma += (((double)salturi_corecte[i] / (double)salturi[i]) * 100.0);
            } 
            medie = suma / salturi.Length;

            return Math.Round(medie, 2);
        }
        private void buton_Simulare_Click(object sender, EventArgs e)
        {
            //enable buton grafice
            buton_Grafic.Enabled = true;

            traces.Clear();
            //preluare trace-uri bifate
            Populare_lista_traces();


            //initializare parametrii
            if (textBox_N.Text != null && textBox_h != null && textBox_prag != null)
            {
                nr_Perceptroni = int.Parse(textBox_N.Text);
                istorie_Globala = int.Parse(textBox_h.Text);
                prag = int.Parse(textBox_prag.Text);

                predictie = new Predictie(nr_Perceptroni, istorie_Globala, prag);
            }
            else
            {
                predictie = new Predictie();
            }

            //preluare tip salt
            int tip_salt = 0;
            if (radioButton_Psimplu.Checked == true)
            {
                tip_salt = 0;
            }

            if (radioButton_ALL.Checked == true)
            {
                //parcurgere fisiere selectate si predictionare fiecare salt
                Predictioanare_fiecare_salt(traces, nr_Perceptroni, istorie_Globala, tip_salt);
                for (int i = 0; i < traces.Count; i++)
                {
                    String[] nume_tra = traces[i].Split('\\');
                    textBox_Rezultate.Text += (nume_tra[nume_tra.Length - 1] + " (nr_Perceptroni=" + nr_Perceptroni.ToString()
                                                                           + ", istorie_Globala=" + istorie_Globala.ToString()
                                                                           + ", prag=" + prag.ToString() + ")" + Environment.NewLine);

                    textBox_Rezultate.Text += ("Acuratetea predictiei [%] = " + Math.Round((((double)salturi_corecte[i] / (double)salturi[i]) * 100.0), 2).ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += ("Numar total de salturi = " + salturi[i].ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += ("Numar de salturi predictionate corect = " + salturi_corecte[i].ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += Environment.NewLine;

                }
            }
            else if (radioButton_saltConditionat.Checked == true)
            {
                //parcurgere fisiere selectate si predictionare doar salturile conditionate
                Predictioanare_salt_conditionat(traces, nr_Perceptroni, istorie_Globala, tip_salt);

                for (int i = 0; i < traces.Count; i++)
                {
                    String[] nume_tra = traces[i].Split('\\');
                    textBox_Rezultate.Text += (nume_tra[nume_tra.Length - 1] + " (nr_Perceptroni=" + nr_Perceptroni.ToString()
                                                                           + ", istorie_Globala=" + istorie_Globala.ToString()
                                                                           + ", prag=" + prag.ToString() + ")" + Environment.NewLine);
                    textBox_Rezultate.Text += ("Acuratetea predictiei [%] = " + Math.Round((((double)salturi_corecte[i] / (double)salturi[i]) * 100.0), 2).ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += ("Numar total de salturi conditionate = " + salturi[i].ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += ("Numar de salturi conditionate predictionate corect = " + salturi_corecte[i].ToString() + Environment.NewLine);
                    textBox_Rezultate.Text += Environment.NewLine;

                }
            }
            
        }

    }
}

