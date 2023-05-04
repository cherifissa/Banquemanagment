
namespace Banquemanagment
{
     public class Client
    {
        private int cNumeroUser = 1; // variable d instance pour les users
        private int numeroUser; // Variable d instance pour le numero de chaque user
        private int numeroPiece;
        private string typePiece;
        private string nomUser;
        private string prenomUser;
        private string telephoneUser;
        private string adresseUser;
       

        //Constructeur par defaut

        public Client()
        {

        }

   
        //Construceteur surchargé d initialisation
        public Client( int pNumeroPiece, string pTypePice, string pNomUser, string pPrenomUser, string pTelephoneUser, string pAdresseUser)
        {
            this.NumeroUser = cNumeroUser + 1;
            this.numeroPiece = pNumeroPiece;
            this.typePiece = pTypePice;
            this.nomUser = pNomUser;
            this.prenomUser = pPrenomUser;
            this.telephoneUser = pTelephoneUser;
            this.adresseUser = pAdresseUser;

        }
        // Creation des propriétés
        public int NumeroUser
        {

            get { return this.numeroUser; }
            set { this.numeroUser = value; }
        }

        public string NumeroPiece
        {

            get { return this.typePiece; }
            set { this.typePiece = value; }
        }

        public string NomUser
        {

            get { return this.nomUser; }
            set { this.nomUser = value; }
        }

        public string PrenomUser
        {

            get { return this.prenomUser; }
            set { this.prenomUser = value; }
        }

        public string TelephoneUser
        {

            get { return this.telephoneUser; }
            set { this.telephoneUser = value; }
        }

        public string AdresseUser
        {

            get { return this.adresseUser; }
            set { this.adresseUser = value; }
        }

    }

}
