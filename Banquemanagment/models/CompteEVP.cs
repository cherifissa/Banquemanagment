using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banquemanagment.models
{
    class CompteEVP:CompteCourant
    {
        private string oPeriodeVersement;
        //contructeur par defaut
        public CompteEVP()
        {

        }
        //constructeur surcharge qui initialise la periode de versement
        public CompteEVP(int pNumeroUser, string pNumeroGuichet, double pSolde, string pTypeCompte, string pCodeSecret, string pPeriodeVersement)
            : base(pNumeroUser, pNumeroGuichet, pSolde, pCodeSecret, pTypeCompte)
        {
            this.oPeriodeVersement = pPeriodeVersement;


        }
        //creation ed proprietes
        public string PeriodeVersement
        {
            get { return this.oPeriodeVersement; }
            set { this.oPeriodeVersement = value; }
        }
    }
}
