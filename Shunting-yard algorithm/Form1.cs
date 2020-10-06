using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shunting_yard_algorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<double> cisla = new Stack<double>(); //vytvořím zásobník na čísla
        Stack<char> operace = new Stack<char>(); //vytvořím zásobník na operace

        private void btStart_Click(object sender, EventArgs e) //zapnu program
        {
            for (int i = 0; i < tbVstup.Text.Length; i++) //projdu program
            {
                if (tbVstup.Text[i] > 47 && tbVstup.Text[i] < 58) //cislo
                {
                    cisla.Push(tbVstup.Text[i] - 48); //pridam cislo do zasobniku
                }
                else
                {
                    if (tbVstup.Text[i] == '(') //pokud dojde na zavorku
                    {
                        operace.Push('(');
                    }
                    else
                    {
                        if (tbVstup.Text[i] == '*' ||tbVstup.Text[i] =='/') //dojde na znamenka vyssi priority
                            {
                                while (operace.Count > 0 && (operace.Peek() == '*' || operace.Peek() == '/')) //odkud muzu vystrilim zasobnik
                                {
                                pocitej(operace.Pop());
                                }
                                operace.Push(tbVstup.Text[i]); //pridam nakonec
                            }
                        else
                        {
                            if (tbVstup.Text[i] == '+' || tbVstup.Text[i] == '-') //dojde na znemenka nizsi priority
                            {
                                while (operace.Count > 0 && operace.Peek() != '(') //odkud muzu vystrilim zasobnik
                                {
                                    pocitej(operace.Pop());
                                }
                                operace.Push(tbVstup.Text[i]); //pridam nakonec
                            }
                            else
                            {
                                if(tbVstup.Text[i] == ')') //dostanu pravou zavorku
                                {
                                    while(operace.Count > 0 && operace.Peek() != '(') //projdu zasobnik az do leve zavorky
                                    {
                                        pocitej(operace.Pop()); //vystrilim
                                    }
                                    if (operace.Count > 0)
                                    {
                                        operace.Pop(); //zbavim se leve zavorky
                                    }
                                }
                            }
                        }
                    }
                }
            }
            while (operace.Count > 0) //vystrilim zbytek zasobniku
            {
                pocitej(operace.Pop());
            }
            tbVstup.Text =(cisla.Pop()).ToString(); //vypisu
        }
        public void pocitej(char znamenko) //funkce pocitej
        {
            if (znamenko == '+') //pro scitani
            {
                cisla.Push(cisla.Pop() + cisla.Pop());
            }
            else
            {
                if (znamenko == '-') //pro odcitani
                {
                    double a = cisla.Pop();
                    cisla.Push(cisla.Pop() - a);
                }
                else
                {
                    if (znamenko == '*') //pro nasobeni
                    {
                        cisla.Push(cisla.Pop() * cisla.Pop());
                    }
                    else //pro deleni
                    {
                        double a = cisla.Pop();
                        cisla.Push(cisla.Pop() / a);
                    }
                }
            }
        }
    }
}
