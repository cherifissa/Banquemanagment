using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquemanagment.models
{
    class CompteBloque : CompteCourant
    {
        private String oDateDeblocage;

        // Constructeur par défaut

        public CompteBloque() : base()
        {

        }
        // Constructeur surchargé pour initialiser la durée de blocage
        public CompteBloque(int pNumeroUser, string pNumeroGuichet, double pSolde, string pCodeSecret, string pTypeCompte, string pDateDeblocage)
            : base(pNumeroUser, pNumeroGuichet, pSolde, pCodeSecret, pTypeCompte)
        {
            this.oDateDeblocage = pDateDeblocage;
        }

        // Creation des proprietes

        public string DateDeblocage
        {
            get { return this.oDateDeblocage; }
            set { this.oDateDeblocage = value; }

        }
        //reecriture de la methode
        public override bool Debiter(double pMontant)
        {
            base.Debiter(pMontant);
            if (DateTime.Today >= DateTime.Parse(this.oDateDeblocage))
            {
                this.oSolde -= pMontant;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
