using System;

namespace TD1_Héritage
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 0;
            CompteBancaire compte1 = new CompteBancaire("Pollet", 1001, 12350);
            CompteBancaire compte2 = new CompteBancaire("Boyer", 1002, 8547.28);
            CompteBancaire compte3 = new CompteBancaire("Morel", 1003, 854.87);
            CompteBancaireRemunere compte4 = new CompteBancaireRemunere("Mallet", "Antoine", 1004, 1000, 10.00);

            Console.WriteLine("--------------------Menu----------------------");
            Console.WriteLine("Choissisez le numéro");
            Console.WriteLine("1 - Afficher les informations des comptes");
            Console.WriteLine("2 - Crediter de l'argent sur un compte");
            Console.WriteLine("3 - Débiter de l'argent sur un compte ");
            Console.WriteLine("4 - Créditer le compte rémunérateur ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Indiquez votre choix : ");
            choix = Int32.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    compte1.afficherInformation();
                    compte2.afficherInformation();
                    compte3.afficherInformation();
                    break;

                case 2:
                    int numCompte = 0;
                    double montant = 0;
                    Console.WriteLine("Indiquez le numéro de compte: ");
                    numCompte = int.Parse(Console.ReadLine());

                    if (numCompte == 1001)
                    {
                        Console.WriteLine("Indiquez le montant à créditer: ");
                        montant = double.Parse(Console.ReadLine());
                        compte1.crediter(montant);
                        compte1.afficherInformation();
                    }
                    else
                    {
                        if(numCompte == 1002)
                        {
                            Console.WriteLine("Indiquez le montant à créditer: ");
                            montant = double.Parse(Console.ReadLine());
                            compte2.crediter(montant);
                            compte2.afficherInformation();
                        }
                        else
                        {
                            if
                            (numCompte == 1003)
                            {
                                Console.WriteLine("Indiquez le montant à créditer: ");
                                montant = double.Parse(Console.ReadLine());
                                compte3.crediter(montant);
                                compte1.afficherInformation();
                            }
                        }
                    }
                    break;

                case 3:
                    int numCompte2 = 0;
                    double montant2 = 0;
                    Console.WriteLine("Indiquez le numéro de compte: ");
                    numCompte2 = int.Parse(Console.ReadLine());

                    if(numCompte2 == 1001)
                    {
                        Console.WriteLine("Indiquez le montant à débiter: ");
                        montant2 = double.Parse(Console.ReadLine());
                        compte1.debiter(montant2);
                        compte1.afficherInformation();
                    }
                    else
                    {
                        if(numCompte2 == 1002)
                        {
                            Console.WriteLine("Indiquez le montant à débiter: ");
                            montant2 = double.Parse(Console.ReadLine());
                            compte2.debiter(montant2);
                            compte2.afficherInformation();
                        }
                        else
                        {
                            if(numCompte2 == 1003)
                            {
                                Console.WriteLine("Indiquez le montant à débiter: ");
                                montant2 = double.Parse(Console.ReadLine());
                                compte3.debiter(montant2);
                                compte1.afficherInformation();
                            }
                        }
                    }
                    break;

                case 4:
                    double montant3 = 0;
                    Console.WriteLine("Indiquez le montant à créditer: ");
                    montant3 = double.Parse(Console.ReadLine());
                    compte4.crediter_rémunerateur(montant3);
                    compte4.afficher_remunere();
                    break                    ;
            }
            Console.ReadLine();
        }
        }
    }
