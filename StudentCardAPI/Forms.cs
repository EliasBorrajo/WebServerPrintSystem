using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// API
using Client.ServiceStudentCardDeploy;

namespace StudentCardAPI
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void btnFaculties_Click(object sender, EventArgs e)
        {
            try
            {
                // 0) Se connecter à l'API
                ServiceAccountClient clientAPI = new ServiceAccountClient();
                Account account = new Account();

                // 1) Vérification des entrées
                if (txtBoxUsername.Text != String.Empty &&
                     txtBoxAmountAdd.Text != String.Empty)
                {
                    // 2) Récuperer le contenu des textbox
                    string username = txtBoxUsername.Text;
                    double amountToAdd = Convert.ToDouble(txtBoxAmountAdd.Text);

                    string service = "Faculties";

                    // 3) Apeller la methode de l'API & Get le résultat
                    account = clientAPI.AddAmountByUsername(username, amountToAdd, service);

                    if (account == null)
                    {
                        listBox.Items.Clear();
                        listBox.Items.Add("Compte non valide");

                        return;
                    }

                    // 4) Utiliser le resultat pour changer GUI
                    // 4.1) Afficher le nouveau quotas
                    lblResTotalAmount.Text = Convert.ToString(account.AccountAmount);
                    lblResFeuillesImprimables.Text = Convert.ToString(account.NewQuotaFeuille);

                    // 4.2) Afficher le user qui a été affecté
                    lblResUsername.Text = account.Username;
                    lblResUID.Text = account.UID;

                    // 4.2) Afficher l'historique des transactions pour tel user 
                    listBox.Items.Clear();
                    listBox.Items.Add("Historique des transactions");

                    if (account.ListeTransac.Length < 5)
                    {
                        for (int i = 0; i < account.ListeTransac.Length; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                }
                else 
                {
                    listBox.Items.Clear();
                    listBox.Items.Add("Username ou montant vide");
                }
            }
            catch ( Exception execption )
            {
                Console.WriteLine("ERROR - BUTTON FACULTIES");
                throw execption;
            }  
        }

        private void btnPayOnline_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceAccountClient clientAPI = new ServiceAccountClient();
                Account account = new Account();

                if (txtBoxUsername.Text != String.Empty &&
                     txtBoxAmountAdd.Text != String.Empty)
                {
                    string username = txtBoxUsername.Text;
                    double amountToAdd = Convert.ToDouble(txtBoxAmountAdd.Text);

                    string service = "PayOnline";

                    account = clientAPI.AddAmountByUsername(username, amountToAdd, service);

                    if (account == null)
                    {
                        listBox.Items.Clear();
                        listBox.Items.Add("Compte non valide");

                        return;
                    }


                    lblResTotalAmount.Text = Convert.ToString(account.AccountAmount);
                    lblResFeuillesImprimables.Text = Convert.ToString(account.NewQuotaFeuille);

                    
                    lblResUsername.Text = account.Username;
                    lblResUID.Text = account.UID;

                    listBox.Items.Clear();
                    listBox.Items.Add("Historique des transactions");

                    if (account.ListeTransac.Length < 5)
                    {
                        for (int i = 0; i < account.ListeTransac.Length; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                }
                else
                {
                    listBox.Items.Clear();
                    listBox.Items.Add("Username ou montant vide");
                }
            }
            catch (Exception execption)
            {
                Console.WriteLine("ERROR - BUTTON FACULTIES");
                throw execption;
            }
        }

        private void btnPayementDB_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceAccountClient clientAPI = new ServiceAccountClient();
                Account account = new Account();

                if (txtBoxUID.Text != String.Empty &&
                     txtBoxAmountAdd.Text != String.Empty)
                {
                    string uid = txtBoxUID.Text;
                    double amountToAdd = Convert.ToDouble(txtBoxAmountAdd.Text);

                    string service = "PaymentDB";

                    account = clientAPI.AddAmountByUID(uid, amountToAdd, service);

                    if (account == null)
                    {
                        listBox.Items.Clear();
                        listBox.Items.Add("Compte non valide");

                        return;
                    }

                    lblResTotalAmount.Text = Convert.ToString(account.AccountAmount);
                    lblResFeuillesImprimables.Text = Convert.ToString(account.NewQuotaFeuille);

                    lblResUsername.Text = account.Username;
                    lblResUID.Text = account.UID;


                    listBox.Items.Clear();
                    listBox.Items.Add("Historique des transactions");

                    if (account.ListeTransac.Length < 5)
                    {
                        for (int i = 0; i < account.ListeTransac.Length; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            listBox.Items.Add(account.ListeTransac[i].TranAmount + " CHF, le " + account.ListeTransac[i].TranDateHour + " de " + account.ListeTransac[i].Services);
                        }
                    }
                }
                else
                {
                    listBox.Items.Clear();
                    listBox.Items.Add("UID ou montant vide");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("ERROR - BUTTON PaymentDB");
                throw exception;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Text     = "";
            txtBoxUID.Text               = "";
            txtBoxAmountAdd.Text  = "";

            lblResUsername.Text     = "[...]";
            lblResUID.Text               = "[...]";
            lblResTotalAmount.Text = "[...]";
            lblResFeuillesImprimables.Text = "[...]";

            listBox.Items.Clear();
        }

        private void txtBoxAmountAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
