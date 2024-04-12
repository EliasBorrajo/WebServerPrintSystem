
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
            this.SuspendLayout();
            // 
            // btnPayOnline
            // 
            this.btnPayOnline.Location = new System.Drawing.Point(472, 283);
            this.btnPayOnline.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayOnline.Name = "btnPayOnline";
            this.btnPayOnline.Size = new System.Drawing.Size(123, 48);
            this.btnPayOnline.TabIndex = 8;
            this.btnPayOnline.Text = "Pay Online";
            this.btnPayOnline.UseVisualStyleBackColor = true;
            this.btnPayOnline.Click += new System.EventHandler(this.btnPayOnline_Click);
            // 
            // lblEntrees
            // 
            this.lblEntrees.AutoSize = true;
            this.lblEntrees.Location = new System.Drawing.Point(496, 28);
            this.lblEntrees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntrees.Name = "lblEntrees";
            this.lblEntrees.Size = new System.Drawing.Size(65, 20);
            this.lblEntrees.TabIndex = 1;
            this.lblEntrees.Text = "Entrées";
            // 
            // btnFaculties
            // 
            this.btnFaculties.Location = new System.Drawing.Point(137, 283);
            this.btnFaculties.Margin = new System.Windows.Forms.Padding(2);
            this.btnFaculties.Name = "btnFaculties";
            this.btnFaculties.Size = new System.Drawing.Size(123, 48);
            this.btnFaculties.TabIndex = 6;
            this.btnFaculties.Text = "Faculties";
            this.btnFaculties.UseVisualStyleBackColor = true;
            this.btnFaculties.Click += new System.EventHandler(this.btnFaculties_Click);
            // 
            // btnPayementDB
            // 
            this.btnPayementDB.Location = new System.Drawing.Point(802, 283);
            this.btnPayementDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayementDB.Name = "btnPayementDB";
            this.btnPayementDB.Size = new System.Drawing.Size(123, 48);
            this.btnPayementDB.TabIndex = 9;
            this.btnPayementDB.Text = "Payement DB";
            this.btnPayementDB.UseVisualStyleBackColor = true;
            this.btnPayementDB.Click += new System.EventHandler(this.btnPayementDB_Click);
            // 
            // lblUID
            // 
            this.lblUID.AutoSize = true;
            this.lblUID.Location = new System.Drawing.Point(179, 157);
            this.lblUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUID.Name = "lblUID";
            this.lblUID.Size = new System.Drawing.Size(38, 20);
            this.lblUID.TabIndex = 4;
            this.lblUID.Text = "UID";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(179, 107);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(472, 105);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(124, 26);
            this.txtBoxUsername.TabIndex = 0;
            // 
            // lblAmountAdd
            // 
            this.lblAmountAdd.AutoSize = true;
            this.lblAmountAdd.Location = new System.Drawing.Point(179, 199);
            this.lblAmountAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountAdd.Name = "lblAmountAdd";
            this.lblAmountAdd.Size = new System.Drawing.Size(159, 20);
            this.lblAmountAdd.TabIndex = 7;
            this.lblAmountAdd.Text = "Amount to add [CHF]";
            // 
            // txtBoxAmountAdd
            // 
            this.txtBoxAmountAdd.Location = new System.Drawing.Point(472, 199);
            this.txtBoxAmountAdd.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAmountAdd.Name = "txtBoxAmountAdd";
            this.txtBoxAmountAdd.Size = new System.Drawing.Size(124, 26);
            this.txtBoxAmountAdd.TabIndex = 3;
            this.txtBoxAmountAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAmountAdd_KeyPress);
            // 
            // txtBoxUID
            // 
            this.txtBoxUID.Location = new System.Drawing.Point(472, 157);
            this.txtBoxUID.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUID.Name = "txtBoxUID";
            this.txtBoxUID.Size = new System.Drawing.Size(124, 26);
            this.txtBoxUID.TabIndex = 2;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(496, 370);
            this.lblResults.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(69, 20);
            this.lblResults.TabIndex = 10;
            this.lblResults.Text = "Résultat";
            // 
            // lblOutputUID
            // 
            this.lblOutputUID.AutoSize = true;
            this.lblOutputUID.Location = new System.Drawing.Point(179, 467);
            this.lblOutputUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputUID.Name = "lblOutputUID";
            this.lblOutputUID.Size = new System.Drawing.Size(38, 20);
            this.lblOutputUID.TabIndex = 11;
            this.lblOutputUID.Text = "UID";
            // 
            // lblOutputTotalAmount
            // 
            this.lblOutputTotalAmount.AutoSize = true;
            this.lblOutputTotalAmount.Location = new System.Drawing.Point(179, 519);
            this.lblOutputTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputTotalAmount.Name = "lblOutputTotalAmount";
            this.lblOutputTotalAmount.Size = new System.Drawing.Size(149, 20);
            this.lblOutputTotalAmount.TabIndex = 13;
            this.lblOutputTotalAmount.Text = "Total Amount [CHF]";
            // 
            // lblOutputUsername
            // 
            this.lblOutputUsername.AutoSize = true;
            this.lblOutputUsername.Location = new System.Drawing.Point(179, 415);
            this.lblOutputUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputUsername.Name = "lblOutputUsername";
            this.lblOutputUsername.Size = new System.Drawing.Size(83, 20);
            this.lblOutputUsername.TabIndex = 12;
            this.lblOutputUsername.Text = "Username";
            // 
            // lblOutputFeuillesImprimables
            // 
            this.lblOutputFeuillesImprimables.AutoSize = true;
            this.lblOutputFeuillesImprimables.Location = new System.Drawing.Point(179, 575);
            this.lblOutputFeuillesImprimables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputFeuillesImprimables.Name = "lblOutputFeuillesImprimables";
            this.lblOutputFeuillesImprimables.Size = new System.Drawing.Size(228, 20);
            this.lblOutputFeuillesImprimables.TabIndex = 14;
            this.lblOutputFeuillesImprimables.Text = "Nombre de feuilles imprimables";
            // 
            // lblResUsername
            // 
            this.lblResUsername.AutoSize = true;
            this.lblResUsername.Location = new System.Drawing.Point(496, 415);
            this.lblResUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResUsername.Name = "lblResUsername";
            this.lblResUsername.Size = new System.Drawing.Size(29, 20);
            this.lblResUsername.TabIndex = 15;
            this.lblResUsername.Text = "[...]";
            // 
            // lblResFeuillesImprimables
            // 
            this.lblResFeuillesImprimables.AutoSize = true;
            this.lblResFeuillesImprimables.Location = new System.Drawing.Point(496, 575);
            this.lblResFeuillesImprimables.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResFeuillesImprimables.Name = "lblResFeuillesImprimables";
            this.lblResFeuillesImprimables.Size = new System.Drawing.Size(29, 20);
            this.lblResFeuillesImprimables.TabIndex = 17;
            this.lblResFeuillesImprimables.Text = "[...]";
            // 
            // lblResTotalAmount
            // 
            this.lblResTotalAmount.AutoSize = true;
            this.lblResTotalAmount.Location = new System.Drawing.Point(496, 519);
            this.lblResTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResTotalAmount.Name = "lblResTotalAmount";
            this.lblResTotalAmount.Size = new System.Drawing.Size(29, 20);
            this.lblResTotalAmount.TabIndex = 18;
            this.lblResTotalAmount.Text = "[...]";
            // 
            // lblResUID
            // 
            this.lblResUID.AutoSize = true;
            this.lblResUID.Location = new System.Drawing.Point(496, 467);
            this.lblResUID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResUID.Name = "lblResUID";
            this.lblResUID.Size = new System.Drawing.Size(29, 20);
            this.lblResUID.TabIndex = 19;
            this.lblResUID.Text = "[...]";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(472, 650);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 48);
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
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(662, 419);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(410, 164);
            this.listBox.TabIndex = 23;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 732);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}

