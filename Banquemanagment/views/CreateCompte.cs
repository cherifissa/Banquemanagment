using Banquemanagment.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banquemanagment.views
{
    public partial class CreateCompte : Form
    {
        public CreateCompte()
        {
            InitializeComponent();
        }

       
        private void rdCompteDecouvert_CheckedChanged(object sender, EventArgs e)
        {
            // gestion de champs si decouvert est cochet
            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouvert.Enabled = true;
            dtDate.Enabled = false;
            txtPrenom.Enabled = false;
        }

        private void rdCompteBloque_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouvert.Enabled = false;
            dtDate.Enabled = false;
            txtPrenom.Enabled = true;
        }

        private void rdCompteEntreprise_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouvert.Enabled = false;
            dtDate.Enabled = false;
            txtPrenom.Enabled = false;
        }

        private void rbCompteCourant_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodeVersement.Enabled = false;
            txtSeuilDecouvert.Enabled = false;
            dtDate.Enabled = false;
            txtPrenom.Enabled = true;
        }
        private void rdCompteEVP_CheckedChanged(object sender, EventArgs e)
        {
            txtPeriodeVersement.Enabled = true;
            txtSeuilDecouvert.Enabled = false;
            dtDate.Enabled = false;
            txtPrenom.Enabled = true;
        }



        private void CreateCompte_Load(object sender, EventArgs e)
        {

            // 
            rdbCompteCourant.Checked = true;
            cmbTypepiece.Items.Add("Passport");
            cmbTypepiece.Items.Add("Carte Natinale Id");
            cmbTypepiece.Items.Add("Carte Consulaire");
            cmbTypepiece.SelectedIndex = 1;
           

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            //cntroe de validaton de saisi pour le compte courant et entreprise ;
            if (rdbCompteCourant.Checked == true || rdbCompteEnrteprie.Checked == true) //<---si le compte courant ou entreprse est choisi 
            {
                if (string.IsNullOrEmpty(txtNumeroPiece.Text))//n fait verif
                {
                    MessageBox.Show("Le champs numéro de compte est oligatoire ", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                if (string.IsNullOrEmpty(txtSoldeinitial.Text))//n fait verif
                {
                    MessageBox.Show("Le champs solde inititial est oligatoire ", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (string.IsNullOrEmpty(txtTelephone.Text))//n fait verif
                {
                    MessageBox.Show("Le champs numero de telephone est oligatoire ", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (string.IsNullOrEmpty(txtAdesses.Text))//n fait verif
                {
                    MessageBox.Show("Le champs solde inititial est oligatoire ", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                try
                {
                    Convert.ToInt64(txtNumeroPiece.Text);
                }
                catch
                {
                    MessageBox.Show("le champ numéro de piece ne doit contenir que des entiers","Eurrer de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Convert.ToInt64(txtTelephone.Text);
                }
                catch
                {
                    MessageBox.Show("le champ numéro de telephone ne doit contenir que des entiers", "Eurrer de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    Convert.ToInt64(txtNumeroGuichet.Text);
                }
                catch
                {
                    MessageBox.Show("le champ numéro guichet ne doit contenir que des entiers", "Eurrer de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Convert.ToInt64(txtSoldeinitial.Text);
                }
                catch
                {
                    MessageBox.Show("le champ solde initial ne doit contenir que des entiers", "Eurrer de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //---- Fin verificaton------------

                //creation des objets compte courant ou entreprise
                if(rdbCompteCourant.Checked)//si le compte est de type courant
                    {
                    if (string.IsNullOrEmpty(txtPrenom.Text))//n fait verif
                    {
                        MessageBox.Show("Le champs prenom est oligatoire ", "Erreur de saisi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    try
                        {
                            //on cree un nouveau client et un nouveau compte et on le met chacun dans sa liste
                            Client lClient = new Client(int.Parse(txtNumeroPiece.Text), cmbTypepiece.SelectedItem.ToString(), txtNom.Text,
                                txtPrenom.Text, txtTelephone.Text, txtAdesses.Text);
                            CompteCourant lCompteCourant = new CompteCourant(lClient.NumeroUser, txtNumeroGuichet.Text,
                                double.Parse(txtSoldeinitial.Text), txtCodeSecret.Text, rdbCompteCourant.Text);
                            Comptes.aClients.Add(lClient);
                            Comptes.aComptes.Add(lCompteCourant);
                            Comptes.SauvegardeDonnees();
                            Comptes.SauvegardeComptes();
                        if (Comptes.aComptes.Count != 0)
                            {
                                MessageBox.Show("le compte a ete crée avec succes", "Operation reusi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Une erreur s'est produite lors de la creation du compte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                           
                            rdbCompteCourant.Checked = true;
                            txtNumeroPiece.Text = "";
                            cmbTypepiece.Text = Convert.ToString(cmbTypepiece.Items[0]);
                            txtNom.Text = "";
                            txtPrenom.Text = "";
                            txtTelephone.Text = "";
                            txtAdesses.Text = "";
                            txtNumeroGuichet.Text = "";
                            txtSoldeinitial.Text = "";
                            txtCodeSecret.Text = "";
                            txtCodeSecret.Enabled = true;
                          
                        }
                        catch
                        {
                            MessageBox.Show("Une erreur s'est produite lors de la creation du compte", "Erreur de", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }



                    }
               
                if (rdbCompteEnrteprie.Checked)//si le compte est de type courant
                {
                    try
                    {
                        //on cree un nouveau client et un nouveau compte et on le met chacun dans sa liste
                        Client lClient = new Client(int.Parse(txtNumeroPiece.Text), cmbTypepiece.SelectedItem.ToString(), txtNom.Text, "", txtTelephone.Text, txtAdesses.Text);
                        CompteEntreprise lCompteEntreprise = new CompteEntreprise(lClient.NumeroUser, rdbCompteCourant.Text, double.Parse(txtSoldeinitial.Text), txtNumeroGuichet.Text, txtCodeSecret.Text);
                        Comptes.aClients.Add(lClient);
                        Comptes.aComptes.Add(lCompteEntreprise);
                        Comptes.SauvegardeDonnees();
                        Comptes.SauvegardeComptes();
                        if (Comptes.aComptes.Count != 0)
                        {
                            MessageBox.Show("le compte a ete crée avec succes", "Operation reusi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Une erreur s'est produite lors de la creation du compte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        rdbCompteCourant.Checked = true;
                        txtNumeroPiece.Text = "";
                        cmbTypepiece.Text = Convert.ToString(cmbTypepiece.Items[0]);
                        txtNom.Text = "";
                        txtTelephone.Text = "";
                        txtAdesses.Text = "";
                        txtNumeroGuichet.Text = "";
                        txtSoldeinitial.Text = "";
                        txtCodeSecret.Text = "";
                        txtCodeSecret.Enabled = true;
                    }
                    catch
                    {
                        MessageBox.Show("Une erreur s'est produite lors de la creation du compte", "Erreur de", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


    }
}
