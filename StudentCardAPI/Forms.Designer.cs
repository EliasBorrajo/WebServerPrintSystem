
namespace StudentCardAPI
{
    partial class FormClient
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
            this.btnPayOnline = new System.Windows.Forms.Button();
            this.lblEntrees = new System.Windows.Forms.Label();
            this.btnFaculties = new System.Windows.Forms.Button();
            this.btnPayementDB = new System.Windows.Forms.Button();
            this.lblUID = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.lblAmountAdd = new System.Windows.Forms.Label();
            this.txtBoxAmountAdd = new System.Windows.Forms.TextBox();
            this.txtBoxUID = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblOutputUID = new System.Windows.Forms.Label();
            this.lblOutputTotalAmount = new System.Windows.Forms.Label();
            this.lblOutputUsername = new System.Windows.Forms.Label();
            this.lblOutputFeuillesImprimables = new System.Windows.Forms.Label();
            this.lblResUsername = new System.Windows.Forms.Label();
            this.lblResFeuillesImprimables = new System.Windows.Forms.Label();
            this.lblResTotalAmount = new System.Windows.Forms.Label();
            this.lblResUID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.txtBoxPagesRemove = new System.Windows.Forms.TextBox();
            this.lblRemoveQuota = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBoxCardID = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPayOnline
            // 
            this.btnPayOnline.Location = new System.Drawing.Point(420, 227);
            this.btnPayOnline.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPayOnline.Name = "btnPayOnline";
            this.btnPayOnline.Size = new System.Drawing.Size(109, 39);
            this.btnPayOnline.TabIndex = 8;
            this.btnPayOnline.Text = "Pay Online";
            this.btnPayOnline.UseVisualStyleBackColor = true;
            this.btnPayOnline.Click += new System.EventHandler(this.btnPayOnline_Click);
            // 
            // lblEntrees
            // 
            this.lblEntrees.AutoSize = true;
            this.lblEntrees.Location = new System.Drawing.Point(441, 23);
            this.lblEntrees.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblEntrees.Name = "lblEntrees";
            this.lblEntrees.Size = new System.Drawing.Size(57, 17);
            this.lblEntrees.TabIndex = 1;
            this.lblEntrees.Text = "Entrées";
            // 
            // btnFaculties
            // 
            this.btnFaculties.Location = new System.Drawing.Point(121, 227);
            this.btnFaculties.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnFaculties.Name = "btnFaculties";
            this.btnFaculties.Size = new System.Drawing.Size(109, 39);
            this.btnFaculties.TabIndex = 6;
            this.btnFaculties.Text = "Faculties";
            this.btnFaculties.UseVisualStyleBackColor = true;
            this.btnFaculties.Click += new System.EventHandler(this.btnFaculties_Click);
            // 
            // btnPayementDB
            // 
            this.btnPayementDB.Location = new System.Drawing.Point(713, 227);
            this.btnPayementDB.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnPayementDB.Name = "btnPayementDB";
            this.btnPayementDB.Size = new System.Drawing.Size(109, 39);
            this.btnPayementDB.TabIndex = 9;
            this.btnPayementDB.Text = "Payement DB";
            this.btnPayementDB.UseVisualStyleBackColor = true;
            this.btnPayementDB.Click += new System.EventHandler(this.btnPayementDB_Click);
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(159, 125);
            this.lblUID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(31, 17);
            this.lblUID.TabIndex = 4;
            this.lblUID.Text = "UID";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(159, 85);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(420, 84);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(111, 22);
            this.txtBoxUsername.TabIndex = 0;
            // 
            // lblAmountAdd
            // 
            this.lblAmountAdd.AutoSize = true;
            this.lblAmountAdd.Location = new System.Drawing.Point(159, 159);
            this.lblAmountAdd.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblAmountAdd.Name = "lblAmountAdd";
            this.lblAmountAdd.Size = new System.Drawing.Size(139, 17);
            this.lblAmountAdd.TabIndex = 7;
            this.lblAmountAdd.Text = "Amount to add [CHF]";
            // 
            // txtBoxAmountAdd
            // 
            this.txtBoxAmountAdd.Location = new System.Drawing.Point(420, 159);
            this.txtBoxAmountAdd.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBoxAmountAdd.Name = "txtBoxAmountAdd";
            this.txtBoxAmountAdd.Size = new System.Drawing.Size(111, 22);
            this.txtBoxAmountAdd.TabIndex = 3;
            this.txtBoxAmountAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAmountAdd_KeyPress);
            // 
            // txtBoxUID
            // 
            this.txtBoxUID.Location = new System.Drawing.Point(420, 125);
            this.txtBoxUID.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBoxUID.Name = "txtBoxUID";
            this.txtBoxUID.Size = new System.Drawing.Size(111, 22);
            this.txtBoxUID.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(441, 296);
            this.lblResults.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(60, 17);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Résultat";
            // 
            // lblOutputUID
            // 
            this.lblOutputUID.AutoSize = true;
            this.lblOutputUID.Location = new System.Drawing.Point(159, 373);
            this.lblOutputUID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOutputUID.Name = "lblOutputUID";
            this.lblOutputUID.Size = new System.Drawing.Size(31, 17);
            this.lblOutputUID.TabIndex = 11;
            this.lblOutputUID.Text = "UID";
            // 
            // lblOutputTotalAmount
            // 
            this.lblOutputTotalAmount.AutoSize = true;
            this.lblOutputTotalAmount.Location = new System.Drawing.Point(159, 415);
            this.lblOutputTotalAmount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOutputTotalAmount.Name = "lblOutputTotalAmount";
            this.lblOutputTotalAmount.Size = new System.Drawing.Size(131, 17);
            this.lblOutputTotalAmount.TabIndex = 13;
            this.lblOutputTotalAmount.Text = "Total Amount [CHF]";
            // 
            // lblOutputUsername
            // 
            this.lblOutputUsername.AutoSize = true;
            this.lblOutputUsername.Location = new System.Drawing.Point(159, 332);
            this.lblOutputUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOutputUsername.Name = "lblOutputUsername";
            this.lblOutputUsername.Size = new System.Drawing.Size(73, 17);
            this.lblOutputUsername.TabIndex = 12;
            this.lblOutputUsername.Text = "Username";
            // 
            // lblOutputFeuillesImprimables
            // 
            this.lblOutputFeuillesImprimables.AutoSize = true;
            this.lblOutputFeuillesImprimables.Location = new System.Drawing.Point(159, 460);
            this.lblOutputFeuillesImprimables.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblOutputFeuillesImprimables.Name = "lblOutputFeuillesImprimables";
            this.lblOutputFeuillesImprimables.Size = new System.Drawing.Size(205, 17);
            this.lblOutputFeuillesImprimables.TabIndex = 14;
            this.lblOutputFeuillesImprimables.Text = "Nombre de feuilles imprimables";
            // 
            // lblResUsername
            // 
            this.lblResUsername.AutoSize = true;
            this.lblResUsername.Location = new System.Drawing.Point(441, 332);
            this.lblResUsername.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResUsername.Name = "lblResUsername";
            this.lblResUsername.Size = new System.Drawing.Size(28, 17);
            this.lblResUsername.TabIndex = 15;
            this.lblResUsername.Text = "[...]";
            // 
            // lblResFeuillesImprimables
            // 
            this.lblResFeuillesImprimables.AutoSize = true;
            this.lblResFeuillesImprimables.Location = new System.Drawing.Point(441, 460);
            this.lblResFeuillesImprimables.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResFeuillesImprimables.Name = "lblResFeuillesImprimables";
            this.lblResFeuillesImprimables.Size = new System.Drawing.Size(28, 17);
            this.lblResFeuillesImprimables.TabIndex = 17;
            this.lblResFeuillesImprimables.Text = "[...]";
            // 
            // lblResTotalAmount
            // 
            this.lblResTotalAmount.AutoSize = true;
            this.lblResTotalAmount.Location = new System.Drawing.Point(441, 415);
            this.lblResTotalAmount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResTotalAmount.Name = "lblResTotalAmount";
            this.lblResTotalAmount.Size = new System.Drawing.Size(28, 17);
            this.lblResTotalAmount.TabIndex = 18;
            this.lblResTotalAmount.Text = "[...]";
            // 
            // lblResUID
            // 
            this.lblResUID.AutoSize = true;
            this.lblResUID.Location = new System.Drawing.Point(441, 373);
            this.lblResUID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblResUID.Name = "lblResUID";
            this.lblResUID.Size = new System.Drawing.Size(28, 17);
            this.lblResUID.TabIndex = 19;
            this.lblResUID.Text = "[...]";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(420, 520);
            this.btnClear.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 39);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Info;
            this.listBox.Enabled = false;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(588, 335);
            this.listBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(365, 132);
            this.listBox.TabIndex = 23;
            // 
            // txtBoxPagesRemove
            // 
            this.txtBoxPagesRemove.Location = new System.Drawing.Point(420, 191);
            this.txtBoxPagesRemove.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtBoxPagesRemove.Name = "txtBoxPagesRemove";
            this.txtBoxPagesRemove.Size = new System.Drawing.Size(111, 22);
            this.txtBoxPagesRemove.TabIndex = 24;
            // 
            // lblRemoveQuota
            // 
            this.lblRemoveQuota.AutoSize = true;
            this.lblRemoveQuota.Location = new System.Drawing.Point(159, 191);
            this.lblRemoveQuota.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblRemoveQuota.Name = "lblRemoveQuota";
            this.lblRemoveQuota.Size = new System.Drawing.Size(177, 17);
            this.lblRemoveQuota.TabIndex = 25;
            this.lblRemoveQuota.Text = "Pages to remove [QUOTA]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 189);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Remove Pages";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRemovePages);
            // 
            // txtBoxCardID
            // 
            this.txtBoxCardID.Location = new System.Drawing.Point(420, 49);
            this.txtBoxCardID.Margin = new System.Windows.Forms.Padding(1);
            this.txtBoxCardID.Name = "txtBoxCardID";
            this.txtBoxCardID.Size = new System.Drawing.Size(111, 22);
            this.txtBoxCardID.TabIndex = 27;
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(159, 50);
            this.lblCardID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(55, 17);
            this.lblCardID.TabIndex = 28;
            this.lblCardID.Text = "Card ID";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(588, 58);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(109, 39);
            this.btnAddUser.TabIndex = 29;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 585);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtBoxCardID);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxPagesRemove);
            this.Controls.Add(this.lblRemoveQuota);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResUID);
            this.Controls.Add(this.lblResTotalAmount);
            this.Controls.Add(this.lblResFeuillesImprimables);
            this.Controls.Add(this.lblResUsername);
            this.Controls.Add(this.lblOutputFeuillesImprimables);
            this.Controls.Add(this.lblOutputTotalAmount);
            this.Controls.Add(this.lblOutputUsername);
            this.Controls.Add(this.lblOutputUID);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtBoxUID);
            this.Controls.Add(this.txtBoxAmountAdd);
            this.Controls.Add(this.lblAmountAdd);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUID);
            this.Controls.Add(this.btnPayementDB);
            this.Controls.Add(this.btnFaculties);
            this.Controls.Add(this.lblEntrees);
            this.Controls.Add(this.btnPayOnline);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "FormClient";
            this.Text = "Client of API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPayOnline;
        private System.Windows.Forms.Label lblEntrees;
        private System.Windows.Forms.Button btnFaculties;
        private System.Windows.Forms.Button btnPayementDB;
        private System.Windows.Forms.Label lblUID;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Label lblAmountAdd;
        private System.Windows.Forms.TextBox txtBoxAmountAdd;
        private System.Windows.Forms.TextBox txtBoxUID;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblOutputUID;
        private System.Windows.Forms.Label lblOutputTotalAmount;
        private System.Windows.Forms.Label lblOutputUsername;
        private System.Windows.Forms.Label lblOutputFeuillesImprimables;
        private System.Windows.Forms.Label lblResUsername;
        private System.Windows.Forms.Label lblResFeuillesImprimables;
        private System.Windows.Forms.Label lblResTotalAmount;
        private System.Windows.Forms.Label lblResUID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox txtBoxPagesRemove;
        private System.Windows.Forms.Label lblRemoveQuota;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBoxCardID;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Button btnAddUser;
    }
}

