using Banquemanagment.models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Banquemanagment
{
    internal class Comptes
    {
        public static List<CompteCourant> aComptes = new List<CompteCourant>();
        public static List<Client> aClients = new List<Client>();

        // Méthode de chargement des données au 
        public static void ChargerDonnees()
        {
            try
            {

                if (File.Exists(@"liste_clients.xml"))// Sil existe un fichier de gestion de clients
                {
                    using (StreamReader reader = new StreamReader(@"liste_clients.xml"))// et on initie le flux de lecteure pour lire le fichier 
                    {

                        if (!reader.EndOfStream)// Si on n est pas a la fin de fichier
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>));// on instancie un objet de désérialisation
                            Comptes.aClients = (List<Client>)deserializer.Deserialize(reader); // on désérialise les objets du fichier Xml et
                            reader.Close(); // on ferme le flux de données 
                            reader.Dispose(); //    On le detruit
                        }
                        else // si on est en fin de fichier 
                        {
                            reader.Close();
                            reader.Dispose();
                        }
                    }

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode de sauvegarde de s données

        public static void SauvegardeDonnees()
        {

            try
            {

                if (Comptes.aClients.Count != 0)
                {

                    if (!File.Exists(@"liste_clients.xml"))

                    {
                        File.Create(@"liste_clients.xml");
                    }

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));

                    using (StreamWriter writer = new StreamWriter(@"liste_clients.xml"))
                    {
                        serializer.Serialize(writer, Comptes.aClients);
                        writer.Close();
                        writer.Dispose();

                    }
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));

                    using (StreamWriter writer = new StreamWriter(@"liste_clients.xml"))
                    {
                        serializer.Serialize(writer, Comptes.aClients);
                        writer.Close();
                        writer.Dispose();

                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public static void SauvegardeComptes()
        {

            try
            {

                if (Comptes.aComptes.Count != 0)
                {

                    if (!File.Exists(@"liste_comptes.xml"))

                    {
                        File.Create(@"liste_comptes.xml");
                    }
                    XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));

                    using (StreamWriter writer = new StreamWriter(@"liste_comptes.xml"))
                    {
                        serializer.Serialize(writer, Comptes.aComptes);
                        writer.Close();
                        writer.Dispose();

                    }
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));

                    using (StreamWriter writer = new StreamWriter(@"liste_comptes.xml"))
                    {
                        serializer.Serialize(writer, Comptes.aComptes);
                        writer.Close();
                        writer.Dispose();

                    }
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

    }
}
