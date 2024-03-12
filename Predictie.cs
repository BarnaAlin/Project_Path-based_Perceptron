using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectB5
{
    class Predictie
    {
        int nr_Perceptroni; //numar de perceptroni
        int istorie_Globala; //lungime istorie globala
        int prag;
        public bool[] registru_Istorie; //registru istorie globala
        public sbyte[,] pondere_Matrice; //matrice ponderi = numere 8 biti


        public Predictie()
        {
            this.nr_Perceptroni = 40;
            this.istorie_Globala = 4;
            this.prag = 50;
            this.registru_Istorie = new bool[istorie_Globala];
            this.pondere_Matrice = new sbyte[nr_Perceptroni, istorie_Globala + 1];
        }

        public Predictie(int N, int h, int prag)
        {
            this.nr_Perceptroni = N;
            this.istorie_Globala = h;
            this.prag = prag;
            this.registru_Istorie = new bool[h];
            this.pondere_Matrice = new sbyte[N, h + 1];
        }

        private int SumaPonderi(int indexPerceptron, int start, int stop)
        {
            int rez = 0;

            for (int j = start; j < stop; j++)
            {
                if (registru_Istorie[j] == true)
                {
                    rez += this.pondere_Matrice[indexPerceptron, j];
                }
                else
                {
                    rez += (0 - this.pondere_Matrice[indexPerceptron, j]);
                }
            }

            return rez;
        }

        private void ActualizareRegistru(bool val_asteptata)
        {
            //shiftare valori la stanga
            for (int i = 0; i < istorie_Globala - 1; i++)
            {
                registru_Istorie[i] = registru_Istorie[i + 1];
            }

            registru_Istorie[istorie_Globala - 1] = val_asteptata;
        }

        //********* PERCEPTRON SIMPLU ****************
        public bool MecanismPredictie(int PC, bool val_asteptata)
        {
            bool predictie = true; //true = TAKEN , false = NOT TAKEN

            int i = PC % nr_Perceptroni;
            int Yout;
            Yout = pondere_Matrice[i, 0] + SumaPonderi(i, 0, istorie_Globala);

            if (Yout >= 0)
            {
                predictie = true;
            }
            else
            {
                predictie = false;
            }

            ModificarePonderi(i, Yout, predictie, val_asteptata);

            return predictie;
        }

        public void ModificarePonderi(int indexPerceptron, int Yout, bool predictie, bool val_asteptata)
        {
            if (predictie != val_asteptata || Yout <= this.prag)
            {
                if (val_asteptata == true)
                {
                    pondere_Matrice[indexPerceptron, 0] = (sbyte)(pondere_Matrice[indexPerceptron, 0] + 1);
                }
                else
                {
                    pondere_Matrice[indexPerceptron, 0] = (sbyte)(pondere_Matrice[indexPerceptron, 0] - 1);
                }

                for (int j = 1; j < istorie_Globala; j++)
                {
                    if (val_asteptata == this.registru_Istorie[j])
                    {
                        pondere_Matrice[indexPerceptron, j] = (sbyte)(pondere_Matrice[indexPerceptron, j] + 1);
                    }
                    else
                    {
                        pondere_Matrice[indexPerceptron, j] = (sbyte)(pondere_Matrice[indexPerceptron, j] - 1);
                    }
                }
            }

            //actualizare registru_Istorie
            ActualizareRegistru(val_asteptata);

        }

    }
}
