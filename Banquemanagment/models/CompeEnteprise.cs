using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquemanagment.models
{
    class CompteEntreprise : CompteCourant
    {
        // contructeur par defaut
        public CompteEntreprise()
        {

        }
        // contructeur qui initialise
        public CompteEntreprise(int pNumeroUser, string pNumeroGuichet, double pSolde, string pTypeCompte, string pCodeSecret)
            : base(pNumeroUser, pNumeroGuichet, pSolde, pCodeSecret, pTypeCompte)
        {


        }

    }
}
