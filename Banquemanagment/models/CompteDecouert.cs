using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquemanagment.models
{
    class CompteDecouvert : CompteCourant
    {
        private double oDecouvert;

        //constructeur par defaut
        public CompteDecouvert()
        {

        }
        //constructeur qui initialise le decouvert a 15
        public CompteDecouvert(int pNumeroUser, string pNumeroGuichet, double pSolde, string pTypeCompte, string pCodeSecret, double pDecouvert)
            : base(pNumeroUser, pNumeroGuichet, pSolde, pCodeSecret, pTypeCompte)
        {
            this.oDecouvert = pDecouvert;

        }

        //creation des proprietes

        public double Decouvert
        {
            get { return this.oDecouvert; }
            set { this.oDecouvert = value; }
        }

        //surcharge de la methode debiter

        public override bool Debiter(double pMontant)
        {
            if ((this.oSolde - pMontant) < this.oDecouvert)
            {
                return false;
            }
            else
            {
                this.Solde -= pMontant;
                return true;
            }
        }

    }

}
