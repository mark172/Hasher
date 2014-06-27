using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HashLibrary;

namespace Hasher
{
    public partial class frmHash : Form
    {
        public frmHash()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            txtHash.Text = HashLibrary.Hasher.HashString(txtText.Text.Trim());
        }
    }
}
