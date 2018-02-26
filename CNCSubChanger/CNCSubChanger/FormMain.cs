using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSubChanger
{
    public partial class FormMain : Form
    {
        private FileHandler fh;
        private ConfigurationHandler cfh;
        private CNCHandler ch;

        public FormMain(string configfile)
        {
            try
            {
                InitializeComponent();
                cfh = new ConfigurationHandler(new FileHandler(configfile));
                btnFile.Enabled = !Properties.Settings.Default.pathReadonly;
                txtFile.Text = cfh.ReturnConfig("path");
                txtFile.Enabled = !Properties.Settings.Default.pathReadonly;
                txtOldSub.Text = cfh.ReturnConfig("oldsub");
                txtOldSub.Enabled = !Properties.Settings.Default.oldsubReadonly;
                txtNewSub.Text = cfh.ReturnConfig("newsub");
                txtNewSub.Enabled = !Properties.Settings.Default.newsubReadonly;
                txtSubRef.Text = cfh.ReturnConfig("subref");
                txtSubRef.Enabled = !Properties.Settings.Default.subrefReadonly;

                if (Properties.Settings.Default.btnSaveHide)
                    btnSave.Hide();

                btnSave.Enabled = !Properties.Settings.Default.pathReadonly || !Properties.Settings.Default.oldsubReadonly || !Properties.Settings.Default.newsubReadonly || !Properties.Settings.Default.subrefReadonly;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Close();
                Application.Exit();
            }
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                fh = new FileHandler(cfh.ReturnConfig("path"));
                ch = new CNCHandler(fh.Read());
                fh.WriteCNC(ch.ChangeSub(cfh.ReturnConfig("oldhead"), cfh.ReturnConfig("newhead"), txtOldSub.Text, txtNewSub.Text, txtSubRef.Text, cfh.ReturnConfig("subcall"), cfh.ReturnConfig("increment")));
                
                if (txtFile.Enabled)
                    cfh.ChangeConfig("path", txtFile.Text);

                if (txtOldSub.Enabled)
                    cfh.ChangeConfig("oldsub", txtOldSub.Text);

                if (txtNewSub.Enabled)
                    cfh.ChangeConfig("newsub", txtNewSub.Text);

                if (txtSubRef.Enabled)
                    cfh.ChangeConfig("subref", txtSubRef.Text);

                cfh.SaveChanges();
                
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            if (dialog.FileName != "")
                txtFile.Text = dialog.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFile.Enabled)
                    cfh.ChangeConfig("path", txtFile.Text);

                if (txtOldSub.Enabled)
                    cfh.ChangeConfig("oldsub", txtOldSub.Text);

                if (txtNewSub.Enabled)
                cfh.ChangeConfig("newsub", txtNewSub.Text);

                if (txtSubRef.Enabled)
                    cfh.ChangeConfig("subref", txtSubRef.Text);

                cfh.SaveChanges();

                MessageBox.Show("Changes to config file saved.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong. Config changes not saved.");
            }
        }

        private void AllowDoubleOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void AllowIntOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
