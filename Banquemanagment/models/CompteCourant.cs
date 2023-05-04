namespace Banquemanagment.models
{
   public class CompteCourant
    {

        static int cNumeroCompte = 1;
        protected string oNumeroCompte;
        protected string oNumeroGuichet;
        protected double oSolde;
        protected string oCodeSecret;
        protected string oTypeCompte;
        protected int oNumeroUser;
       

        // Constructeur par defaut 

        public CompteCourant()
        {

        }

        //Construceteur surchargé d initialisation
        public CompteCourant(int pNumeroUser, string pNumeroGuichet, double pSolde, string pCodeSecret, string pTypeCompte)
        {
            this.oNumeroUser = pNumeroUser;
            this.oNumeroGuichet = pNumeroGuichet;
            this.oSolde = pSolde;
            this.oTypeCompte = pTypeCompte;
            this.oCodeSecret = pCodeSecret;
        }
        //Création des proprietes

        public string NumeroCompte
        {

            get { return this.oNumeroCompte; }
            set { this.oNumeroCompte = value; }
        }
        public int NumeroUser
        {
            get { return this.oNumeroUser; }
            set { this.oNumeroUser = value; }
        }
        public string NumeroGuichet
        {
            get { return this.oNumeroGuichet; }
            set { this.oNumeroGuichet = value; }
        }
        public double Solde
        {
            get { return this.oSolde; }
            set { this.oSolde = value; }
        }
        public string CodeSecret
        {
            get { return this.oCodeSecret; }
            set { this.oCodeSecret = value; }
        }
        public string TypeCompte
        {
            get { return this.oTypeCompte; }
            set { this.oTypeCompte = value; }
        }
        //methode de crediter un compte
        public void Crediter(double pMontant)
        {
            this.oSolde += pMontant;
        }
        //methode pour debiter le compte
        public virtual bool Debiter(double pMontant)
        {
            if (this.oSolde - pMontant > 0)
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
