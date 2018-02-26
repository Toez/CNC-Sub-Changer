using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNCSubChanger
{
    public partial class FormMain : Form
    {
        private FileHandler fh;
        private CNCHandler ch;
        private XmlHandler xh;

        public FormMain()
        {
            InitializeComponent();
            xh = new XmlHandler();
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            fh = new FileHandler(@xh.ReadXml(@".\Config.xml", "path"));
            ch = new CNCHandler(fh.Read());
            fh.Write(ch.ChangeSub(txtOldSub.Text, txtNewSub.Text, "P"));
            
            MessageBox.Show("Done");
        }
    }
}
