using System;
using System.Collections.Generic;
using System.Text;

namespace TD1_Héritage
{
    class CompteBancaireRemunere : CompteBancaire
    {
        private string _prenom;
        private double _taux;
        private double _solde;

        public CompteBancaireRemunere(string titulaire, string prenom, int numero, double solde, double taux) :
        base (titulaire, numero, solde)
        {
            _prenom = prenom;
            _taux = taux;
            _solde = solde;
        }

        public void afficher_remunere()
        {
            base.afficherInformation();
            Console.WriteLine("Le prénom du titulaire est: " + _prenom);
            Console.WriteLine("Le taux est de : " + _taux + " %.");
            Console.WriteLine("Voici le nouveau solde (rémunérateur) : " + _solde);
        }
        public void crediter_rémunerateur(double solde2)
        {
            _solde = _solde + (solde2 * _taux);
        }
    }
}
