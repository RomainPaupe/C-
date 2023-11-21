using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql
{
    internal class Client
    {
        int id;
        string nom = "";
        string prenom = "";
        string tel = "";
        string mail = "";
        string mdp = "";
        string adresse = "";
        string carte = "";
        string statut_fidelite = "";

        public Client(string mail, MySqlConnection maConnexion)
        {
            MySqlCommand getClientInfo = maConnexion.CreateCommand();
            getClientInfo.CommandText = $"select * from clients where courriel = '{mail}'";

            MySqlDataReader ClientInfoReader = getClientInfo.ExecuteReader();
            while (ClientInfoReader.Read())
            {
                this.id = Convert.ToInt32(ClientInfoReader.GetString(0));
                this.nom = ClientInfoReader.GetString(1);
                this.prenom = ClientInfoReader.GetString(2);
                this.tel = ClientInfoReader.GetString(3);
                this.mail = ClientInfoReader.GetString(4);
                this.mdp = ClientInfoReader.GetString(5);
                this.adresse = ClientInfoReader.GetString(6);
                this.carte = ClientInfoReader.GetString(7);
                this.statut_fidelite = ClientInfoReader.GetString(8);
            }
            ClientInfoReader.Close();
            getClientInfo.Dispose();
        }

        public int getId() { return id; }
        public string getNom() { return nom; }
        public string getPrenom() {  return prenom; }
        public string getTel() { return tel; }
        public string getMail() { return mail; }
        public string getmdp() { return mdp; }
        public string getAdresse() { return adresse; }
        public string getCarte() {  return carte; }
        public string getStatut_fidelite() { return statut_fidelite; }
        public void setStatut_fidelite(string value) { statut_fidelite = value; }
    }
}
