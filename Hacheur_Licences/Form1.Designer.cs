namespace Hacheur_Licences
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tbEncryptionKey = new System.Windows.Forms.TextBox();
            this.btnGenerateFile = new System.Windows.Forms.Button();
            this.tbLicenceStr = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbExpiration = new System.Windows.Forms.TextBox();
            this.tbNbVariables = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParamClientsOui = new System.Windows.Forms.RadioButton();
            this.rbParamClientsNon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbNotifOui = new System.Windows.Forms.RadioButton();
            this.rbNotifNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbRapportOui = new System.Windows.Forms.RadioButton();
            this.rbRapportNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbAideMaintenanceOui = new System.Windows.Forms.RadioButton();
            this.rbAideMaintenanceNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParamVariablesOui = new System.Windows.Forms.RadioButton();
            this.rbParamVariablesNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParamEquipementsOui = new System.Windows.Forms.RadioButton();
            this.rbParamEquipementsNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParamAteliersOui = new System.Windows.Forms.RadioButton();
            this.rbParamAteliersNon = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.rbParamSitesOui = new System.Windows.Forms.RadioButton();
            this.rbParamSitesNon = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNbEquipements = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDecryptKey = new System.Windows.Forms.TextBox();
            this.tbOriginalString = new System.Windows.Forms.TextBox();
            this.tbDecryptEncryptedString = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pathToKeyFileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tbFileName);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tbEncryptionKey);
            this.tabPage1.Controls.Add(this.btnGenerateFile);
            this.tabPage1.Controls.Add(this.tbLicenceStr);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Encrypteur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Nom du fichier";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(87, 330);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(223, 20);
            this.tbFileName.TabIndex = 28;
            this.tbFileName.TextChanged += new System.EventHandler(this.checkGenerateConditions);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Générer clé";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.generateEncryptionKey);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(349, 333);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Clé de cryptage";
            // 
            // tbEncryptionKey
            // 
            this.tbEncryptionKey.Location = new System.Drawing.Point(436, 330);
            this.tbEncryptionKey.Name = "tbEncryptionKey";
            this.tbEncryptionKey.ReadOnly = true;
            this.tbEncryptionKey.Size = new System.Drawing.Size(241, 20);
            this.tbEncryptionKey.TabIndex = 25;
            this.tbEncryptionKey.TextChanged += new System.EventHandler(this.checkGenerateConditions);
            // 
            // btnGenerateFile
            // 
            this.btnGenerateFile.Enabled = false;
            this.btnGenerateFile.Location = new System.Drawing.Point(683, 354);
            this.btnGenerateFile.Name = "btnGenerateFile";
            this.btnGenerateFile.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateFile.TabIndex = 24;
            this.btnGenerateFile.Text = "Générer";
            this.btnGenerateFile.UseVisualStyleBackColor = true;
            this.btnGenerateFile.Click += new System.EventHandler(this.generateEncryptedString);
            // 
            // tbLicenceStr
            // 
            this.tbLicenceStr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLicenceStr.Location = new System.Drawing.Point(6, 356);
            this.tbLicenceStr.Name = "tbLicenceStr";
            this.tbLicenceStr.ReadOnly = true;
            this.tbLicenceStr.Size = new System.Drawing.Size(671, 20);
            this.tbLicenceStr.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tbExpiration, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.tbNbVariables, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel7, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNbEquipements, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 10);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(761, 307);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tbExpiration
            // 
            this.tbExpiration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExpiration.Location = new System.Drawing.Point(383, 273);
            this.tbExpiration.Name = "tbExpiration";
            this.tbExpiration.Size = new System.Drawing.Size(375, 20);
            this.tbExpiration.TabIndex = 22;
            this.tbExpiration.TextChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // tbNbVariables
            // 
            this.tbNbVariables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNbVariables.Location = new System.Drawing.Point(383, 246);
            this.tbNbVariables.Name = "tbNbVariables";
            this.tbNbVariables.Size = new System.Drawing.Size(375, 20);
            this.tbNbVariables.TabIndex = 21;
            this.tbNbVariables.TextChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.rbParamClientsOui);
            this.flowLayoutPanel1.Controls.Add(this.rbParamClientsNon);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(383, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // rbParamClientsOui
            // 
            this.rbParamClientsOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbParamClientsOui.AutoSize = true;
            this.rbParamClientsOui.Location = new System.Drawing.Point(3, 3);
            this.rbParamClientsOui.Name = "rbParamClientsOui";
            this.rbParamClientsOui.Size = new System.Drawing.Size(44, 17);
            this.rbParamClientsOui.TabIndex = 11;
            this.rbParamClientsOui.TabStop = true;
            this.rbParamClientsOui.Text = "OUI";
            this.rbParamClientsOui.UseVisualStyleBackColor = true;
            this.rbParamClientsOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbParamClientsNon
            // 
            this.rbParamClientsNon.AutoSize = true;
            this.rbParamClientsNon.Location = new System.Drawing.Point(53, 3);
            this.rbParamClientsNon.Name = "rbParamClientsNon";
            this.rbParamClientsNon.Size = new System.Drawing.Size(49, 17);
            this.rbParamClientsNon.TabIndex = 12;
            this.rbParamClientsNon.TabStop = true;
            this.rbParamClientsNon.Text = "NON";
            this.rbParamClientsNon.UseVisualStyleBackColor = true;
            this.rbParamClientsNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paramétrage Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel8.Controls.Add(this.rbNotifOui);
            this.flowLayoutPanel8.Controls.Add(this.rbNotifNon);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(383, 192);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel8.TabIndex = 19;
            // 
            // rbNotifOui
            // 
            this.rbNotifOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNotifOui.AutoSize = true;
            this.rbNotifOui.Location = new System.Drawing.Point(3, 3);
            this.rbNotifOui.Name = "rbNotifOui";
            this.rbNotifOui.Size = new System.Drawing.Size(44, 17);
            this.rbNotifOui.TabIndex = 11;
            this.rbNotifOui.TabStop = true;
            this.rbNotifOui.Text = "OUI";
            this.rbNotifOui.UseVisualStyleBackColor = true;
            this.rbNotifOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbNotifNon
            // 
            this.rbNotifNon.AutoSize = true;
            this.rbNotifNon.Location = new System.Drawing.Point(53, 3);
            this.rbNotifNon.Name = "rbNotifNon";
            this.rbNotifNon.Size = new System.Drawing.Size(49, 17);
            this.rbNotifNon.TabIndex = 12;
            this.rbNotifNon.TabStop = true;
            this.rbNotifNon.Text = "NON";
            this.rbNotifNon.UseVisualStyleBackColor = true;
            this.rbNotifNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.Controls.Add(this.rbRapportOui);
            this.flowLayoutPanel7.Controls.Add(this.rbRapportNon);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(383, 165);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel7.TabIndex = 18;
            // 
            // rbRapportOui
            // 
            this.rbRapportOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRapportOui.AutoSize = true;
            this.rbRapportOui.Location = new System.Drawing.Point(3, 3);
            this.rbRapportOui.Name = "rbRapportOui";
            this.rbRapportOui.Size = new System.Drawing.Size(44, 17);
            this.rbRapportOui.TabIndex = 11;
            this.rbRapportOui.TabStop = true;
            this.rbRapportOui.Text = "OUI";
            this.rbRapportOui.UseVisualStyleBackColor = true;
            this.rbRapportOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbRapportNon
            // 
            this.rbRapportNon.AutoSize = true;
            this.rbRapportNon.Location = new System.Drawing.Point(53, 3);
            this.rbRapportNon.Name = "rbRapportNon";
            this.rbRapportNon.Size = new System.Drawing.Size(49, 17);
            this.rbRapportNon.TabIndex = 12;
            this.rbRapportNon.TabStop = true;
            this.rbRapportNon.Text = "NON";
            this.rbRapportNon.UseVisualStyleBackColor = true;
            this.rbRapportNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.Controls.Add(this.rbAideMaintenanceOui);
            this.flowLayoutPanel6.Controls.Add(this.rbAideMaintenanceNon);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(383, 138);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel6.TabIndex = 17;
            // 
            // rbAideMaintenanceOui
            // 
            this.rbAideMaintenanceOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAideMaintenanceOui.AutoSize = true;
            this.rbAideMaintenanceOui.Location = new System.Drawing.Point(3, 3);
            this.rbAideMaintenanceOui.Name = "rbAideMaintenanceOui";
            this.rbAideMaintenanceOui.Size = new System.Drawing.Size(44, 17);
            this.rbAideMaintenanceOui.TabIndex = 11;
            this.rbAideMaintenanceOui.TabStop = true;
            this.rbAideMaintenanceOui.Text = "OUI";
            this.rbAideMaintenanceOui.UseVisualStyleBackColor = true;
            this.rbAideMaintenanceOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbAideMaintenanceNon
            // 
            this.rbAideMaintenanceNon.AutoSize = true;
            this.rbAideMaintenanceNon.Location = new System.Drawing.Point(53, 3);
            this.rbAideMaintenanceNon.Name = "rbAideMaintenanceNon";
            this.rbAideMaintenanceNon.Size = new System.Drawing.Size(49, 17);
            this.rbAideMaintenanceNon.TabIndex = 12;
            this.rbAideMaintenanceNon.TabStop = true;
            this.rbAideMaintenanceNon.Text = "NON";
            this.rbAideMaintenanceNon.UseVisualStyleBackColor = true;
            this.rbAideMaintenanceNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.rbParamVariablesOui);
            this.flowLayoutPanel5.Controls.Add(this.rbParamVariablesNon);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(383, 111);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel5.TabIndex = 16;
            // 
            // rbParamVariablesOui
            // 
            this.rbParamVariablesOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbParamVariablesOui.AutoSize = true;
            this.rbParamVariablesOui.Location = new System.Drawing.Point(3, 3);
            this.rbParamVariablesOui.Name = "rbParamVariablesOui";
            this.rbParamVariablesOui.Size = new System.Drawing.Size(44, 17);
            this.rbParamVariablesOui.TabIndex = 11;
            this.rbParamVariablesOui.TabStop = true;
            this.rbParamVariablesOui.Text = "OUI";
            this.rbParamVariablesOui.UseVisualStyleBackColor = true;
            this.rbParamVariablesOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbParamVariablesNon
            // 
            this.rbParamVariablesNon.AutoSize = true;
            this.rbParamVariablesNon.Location = new System.Drawing.Point(53, 3);
            this.rbParamVariablesNon.Name = "rbParamVariablesNon";
            this.rbParamVariablesNon.Size = new System.Drawing.Size(49, 17);
            this.rbParamVariablesNon.TabIndex = 12;
            this.rbParamVariablesNon.TabStop = true;
            this.rbParamVariablesNon.Text = "NON";
            this.rbParamVariablesNon.UseVisualStyleBackColor = true;
            this.rbParamVariablesNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.rbParamEquipementsOui);
            this.flowLayoutPanel4.Controls.Add(this.rbParamEquipementsNon);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(383, 84);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel4.TabIndex = 15;
            // 
            // rbParamEquipementsOui
            // 
            this.rbParamEquipementsOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbParamEquipementsOui.AutoSize = true;
            this.rbParamEquipementsOui.Location = new System.Drawing.Point(3, 3);
            this.rbParamEquipementsOui.Name = "rbParamEquipementsOui";
            this.rbParamEquipementsOui.Size = new System.Drawing.Size(44, 17);
            this.rbParamEquipementsOui.TabIndex = 11;
            this.rbParamEquipementsOui.TabStop = true;
            this.rbParamEquipementsOui.Text = "OUI";
            this.rbParamEquipementsOui.UseVisualStyleBackColor = true;
            this.rbParamEquipementsOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbParamEquipementsNon
            // 
            this.rbParamEquipementsNon.AutoSize = true;
            this.rbParamEquipementsNon.Location = new System.Drawing.Point(53, 3);
            this.rbParamEquipementsNon.Name = "rbParamEquipementsNon";
            this.rbParamEquipementsNon.Size = new System.Drawing.Size(49, 17);
            this.rbParamEquipementsNon.TabIndex = 12;
            this.rbParamEquipementsNon.TabStop = true;
            this.rbParamEquipementsNon.Text = "NON";
            this.rbParamEquipementsNon.UseVisualStyleBackColor = true;
            this.rbParamEquipementsNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.rbParamAteliersOui);
            this.flowLayoutPanel3.Controls.Add(this.rbParamAteliersNon);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(383, 57);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // rbParamAteliersOui
            // 
            this.rbParamAteliersOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbParamAteliersOui.AutoSize = true;
            this.rbParamAteliersOui.Location = new System.Drawing.Point(3, 3);
            this.rbParamAteliersOui.Name = "rbParamAteliersOui";
            this.rbParamAteliersOui.Size = new System.Drawing.Size(44, 17);
            this.rbParamAteliersOui.TabIndex = 11;
            this.rbParamAteliersOui.TabStop = true;
            this.rbParamAteliersOui.Text = "OUI";
            this.rbParamAteliersOui.UseVisualStyleBackColor = true;
            this.rbParamAteliersOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbParamAteliersNon
            // 
            this.rbParamAteliersNon.AutoSize = true;
            this.rbParamAteliersNon.Location = new System.Drawing.Point(53, 3);
            this.rbParamAteliersNon.Name = "rbParamAteliersNon";
            this.rbParamAteliersNon.Size = new System.Drawing.Size(49, 17);
            this.rbParamAteliersNon.TabIndex = 12;
            this.rbParamAteliersNon.TabStop = true;
            this.rbParamAteliersNon.Text = "NON";
            this.rbParamAteliersNon.UseVisualStyleBackColor = true;
            this.rbParamAteliersNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.rbParamSitesOui);
            this.flowLayoutPanel2.Controls.Add(this.rbParamSitesNon);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(383, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(375, 21);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // rbParamSitesOui
            // 
            this.rbParamSitesOui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbParamSitesOui.AutoSize = true;
            this.rbParamSitesOui.Location = new System.Drawing.Point(3, 3);
            this.rbParamSitesOui.Name = "rbParamSitesOui";
            this.rbParamSitesOui.Size = new System.Drawing.Size(44, 17);
            this.rbParamSitesOui.TabIndex = 11;
            this.rbParamSitesOui.TabStop = true;
            this.rbParamSitesOui.Text = "OUI";
            this.rbParamSitesOui.UseVisualStyleBackColor = true;
            this.rbParamSitesOui.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // rbParamSitesNon
            // 
            this.rbParamSitesNon.AutoSize = true;
            this.rbParamSitesNon.Location = new System.Drawing.Point(53, 3);
            this.rbParamSitesNon.Name = "rbParamSitesNon";
            this.rbParamSitesNon.Size = new System.Drawing.Size(49, 17);
            this.rbParamSitesNon.TabIndex = 12;
            this.rbParamSitesNon.TabStop = true;
            this.rbParamSitesNon.Text = "NON";
            this.rbParamSitesNon.UseVisualStyleBackColor = true;
            this.rbParamSitesNon.CheckedChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rapport";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(374, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nombre de variables";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(374, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Notification";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre d\'équipements";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aide à la Maintenance";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paramétrage Equipements";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paramétrage Variables";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paramétrage Ateliers";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paramétrage Sites";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNbEquipements
            // 
            this.tbNbEquipements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNbEquipements.Location = new System.Drawing.Point(383, 219);
            this.tbNbEquipements.Name = "tbNbEquipements";
            this.tbNbEquipements.Size = new System.Drawing.Size(375, 20);
            this.tbNbEquipements.TabIndex = 20;
            this.tbNbEquipements.TextChanged += new System.EventHandler(this.onChangeGenerateLicenceString);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(374, 37);
            this.label10.TabIndex = 9;
            this.label10.Text = "Expiration de la licence (jj/MM/aaaa)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.tbDecryptKey);
            this.tabPage2.Controls.Add(this.tbOriginalString);
            this.tabPage2.Controls.Add(this.tbDecryptEncryptedString);
            this.tabPage2.Controls.Add(this.btnSelectFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Décrypteur";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(267, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Chaine originale";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Clé";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Chaine Crypter";
            // 
            // tbDecryptKey
            // 
            this.tbDecryptKey.Location = new System.Drawing.Point(355, 184);
            this.tbDecryptKey.Name = "tbDecryptKey";
            this.tbDecryptKey.Size = new System.Drawing.Size(295, 20);
            this.tbDecryptKey.TabIndex = 3;
            // 
            // tbOriginalString
            // 
            this.tbOriginalString.Location = new System.Drawing.Point(355, 218);
            this.tbOriginalString.Name = "tbOriginalString";
            this.tbOriginalString.Size = new System.Drawing.Size(295, 20);
            this.tbOriginalString.TabIndex = 2;
            // 
            // tbDecryptEncryptedString
            // 
            this.tbDecryptEncryptedString.Location = new System.Drawing.Point(355, 150);
            this.tbDecryptEncryptedString.Name = "tbDecryptEncryptedString";
            this.tbDecryptEncryptedString.Size = new System.Drawing.Size(295, 20);
            this.tbDecryptEncryptedString.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(25, 184);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(175, 20);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "Selectioner Fichier";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.decryptFile);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files (*.icone)|*.icone|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerateFile;
        private System.Windows.Forms.TextBox tbLicenceStr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbExpiration;
        private System.Windows.Forms.TextBox tbNbVariables;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton rbParamClientsOui;
        private System.Windows.Forms.RadioButton rbParamClientsNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.RadioButton rbNotifOui;
        private System.Windows.Forms.RadioButton rbNotifNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.RadioButton rbRapportOui;
        private System.Windows.Forms.RadioButton rbRapportNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.RadioButton rbAideMaintenanceOui;
        private System.Windows.Forms.RadioButton rbAideMaintenanceNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.RadioButton rbParamVariablesOui;
        private System.Windows.Forms.RadioButton rbParamVariablesNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton rbParamEquipementsOui;
        private System.Windows.Forms.RadioButton rbParamEquipementsNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.RadioButton rbParamAteliersOui;
        private System.Windows.Forms.RadioButton rbParamAteliersNon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RadioButton rbParamSitesOui;
        private System.Windows.Forms.RadioButton rbParamSitesNon;
        private System.Windows.Forms.TextBox tbNbEquipements;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbEncryptionKey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog pathToKeyFileDialog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbDecryptKey;
        private System.Windows.Forms.TextBox tbOriginalString;
        private System.Windows.Forms.TextBox tbDecryptEncryptedString;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

