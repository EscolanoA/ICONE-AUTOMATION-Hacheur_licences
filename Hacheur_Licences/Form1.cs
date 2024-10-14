using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Security.Cryptography;
using System.IO;

namespace Hacheur_Licences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void generateLicenceString()
        {
            String licenceStr = "";

            //Parametrage clients ?
            if (rbParamClientsOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            } else if (rbParamClientsNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            } else
            {
                licenceStr = licenceStr + "null;";
            }

            //Parametrage sites ?
            if (rbParamSitesOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbParamSitesNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Parametrage ateliers ?
            if (rbParamAteliersOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbParamAteliersNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Parametrage equipements ?
            if (rbParamEquipementsOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbParamEquipementsNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Parametrage variables ?
            if (rbParamVariablesOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbParamVariablesNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Aide à la maintenance ?
            if (rbAideMaintenanceOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbAideMaintenanceNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Rapport ?
            if (rbRapportOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbRapportNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Notification ?
            if (rbNotifOui.Checked == true)
            {
                licenceStr = licenceStr + "true;";
            }
            else if (rbNotifNon.Checked == true)
            {
                licenceStr = licenceStr + "false;";
            }
            else
            {
                licenceStr = licenceStr + "null;";
            }

            //Nombres d'équipements ?
            if (tbNbEquipements.Text == "")
            {
                licenceStr = licenceStr + "null;";
            }
            else
            {
                licenceStr = licenceStr + tbNbEquipements.Text + ";";
            }

            //Nombres de variables ?
            if (tbNbVariables.Text == "")
            {
                licenceStr = licenceStr + "null;";
            }
            else
            {
                licenceStr = licenceStr + tbNbVariables.Text + ";";
            }

            String dateString = tbExpiration.Text;
            String format = "dd/MM/yyyy";
            CultureInfo provider = new CultureInfo("fr-FR");

            try
            {
                DateTime result = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
                licenceStr = licenceStr + result.ToString().Remove(10, 9);
            }
            catch (FormatException)
            {
                licenceStr = licenceStr + "null";
            }

            tbLicenceStr.Text = licenceStr;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateLicenceString();
        }

        public void onChangeGenerateLicenceString(Object sender, EventArgs args)
        {
            generateLicenceString();
        }

        public void generateEncryptedString(Object sender, EventArgs args)
        {
            Crypteur crypteur = new Crypteur();
            String str = tbLicenceStr.Text;
            String key = tbEncryptionKey.Text;
            String encryptedString = crypteur.EncryptString(key, str);
            String decryptedString = crypteur.DecryptString(key, encryptedString);

            pathToKeyFileDialog.ShowDialog();
            String path = pathToKeyFileDialog.SelectedPath;
            String name = tbFileName.Text;
            String fileName = path + "/" + name + ".icone";

            if (File.Exists(fileName))
            {
                MessageBox.Show("Nom de fichier déja utilisé");
                return;
            }

            using (StreamWriter sw = File.CreateText(fileName))
            {
                sw.WriteLine(encryptedString);
                sw.WriteLine(key);
            }
            rbParamClientsOui.Checked = false;
            rbParamClientsNon.Checked = false;
            rbParamSitesOui.Checked = false;
            rbParamSitesNon.Checked = false;
            rbParamAteliersOui.Checked = false;
            rbParamAteliersNon.Checked = false;
            rbParamEquipementsOui.Checked = false;
            rbParamEquipementsNon.Checked = false;
            rbParamVariablesOui.Checked = false;
            rbParamVariablesNon.Checked = false;
            rbAideMaintenanceOui.Checked = false;
            rbAideMaintenanceNon.Checked = false;
            rbRapportOui.Checked = false;
            rbRapportNon.Checked = false;
            rbNotifOui.Checked = false;
            rbNotifNon.Checked = false;
            tbNbEquipements.Text = "";
            tbNbVariables.Text = "";
            tbExpiration.Text = "";
            tbEncryptionKey.Text = "";
            tbFileName.Text = "";
            onChangeGenerateLicenceString(null, null);
            MessageBox.Show("Fichier creé avec succes");
        }

        public void generateEncryptionKey (Object sender, EventArgs args)
        {
            using (Aes aesAlgorithm = Aes.Create())
            {
                aesAlgorithm.KeySize = 128;
                aesAlgorithm.GenerateKey();
                string keyBase64 = Convert.ToBase64String(aesAlgorithm.Key);
                tbEncryptionKey.Text = keyBase64;
            }
        }

        public void checkGenerateConditions(Object sender, EventArgs agrs)
        {
            if (tbFileName.Text != "" && tbEncryptionKey.Text != "")
            {
                btnGenerateFile.Enabled = true;
            } else
            {
                btnGenerateFile.Enabled = false;
            }
        }

        public void decryptFile(Object sender, EventArgs args)
        {
            openFileDialog.ShowDialog();
            String file = openFileDialog.FileName;
            if (file != null && file != "")
            {
                string[] lines = File.ReadAllLines(file);
                Crypteur crypteur = new Crypteur();
                String encryptedString = lines[0];
                String key = lines[1];
                String originalString = crypteur.DecryptString(key, encryptedString);
                tbDecryptEncryptedString.Text = encryptedString;
                tbDecryptKey.Text = key;
                tbOriginalString.Text = originalString;
            } else
            {
                MessageBox.Show("Erreur de chargement du ficher");
            }
        }
    }
}
