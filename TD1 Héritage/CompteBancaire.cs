using System;
using System.Collections.Generic;
using System.Text;

namespace TD1_Héritage
{
    class CompteBancaire
    {
        private string _titulaire;
        private int _numero = 1000;
        private double _solde;

        public CompteBancaire(string titulaire, int numero, double solde)
        {
            _titulaire = titulaire;
            _numero = numero;
            _solde = solde;
        }

        public string getTitulaire()
        {return _titulaire;}
        public int getNumero()
        {return _numero;}
        public double getSolde()
        {return _solde;}
        public void crediter(double solde)
        {
            _solde = _solde + solde;
        }
        public void debiter(double debit)
        {
            _solde = (_solde - debit);
        }
        public void afficherInformation()
        {
            Console.WriteLine("Titulaire: " + _titulaire);
            Console.WriteLine("Solde actuel: " + _solde);
            Console.WriteLine("Numéro de compte: " + _numero);
        }
    }
}
