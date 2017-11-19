using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AltınProblemi
{
    public partial class frmAltinProblemi : Form
    {
        public frmAltinProblemi()
        {
            InitializeComponent();
        }

        private void btnHasarliAltinBul_Click(object sender, EventArgs e)
        {
            ulong AltinSayisi = Convert.ToUInt64(txtAltinSayisi.Text);
            Altin a = new Altin(AltinSayisi);
            MessageBox.Show(a.CalismaZamani());
        }
        private void txtAltinSayisi_Leave(object sender, EventArgs e)
        {
            if (txtAltinSayisi.Text == "")
            {
                MessageBox.Show("Lütfen altın sayısını giriniz.");
                txtAltinSayisi.Focus();
            }
            else if (Convert.ToUInt64(txtAltinSayisi.Text) < 2)
            {
                MessageBox.Show("Lütfen altın sayısını 2 veya 2'den büyük giriniz.");
                txtAltinSayisi.Text = "";
                txtAltinSayisi.Focus();
            }        
        }
        int i = 0;
        private void txtAltinSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if(txtAltinSayisi.Text == "")
            {
                i = 0;
            }
            if(e.KeyChar == 8)
            {
                if(txtAltinSayisi.SelectionLength == 0)
                {
                    i -= 1;
                }
                else
                {
                    i -= txtAltinSayisi.SelectionLength;
                }
            }
           
            if ((e.KeyChar >= 48 )  && (e.KeyChar <= 57))
            {
                i++;
                i -= txtAltinSayisi.SelectedText.Length;
             
                if (i > 9)
                {
                    MessageBox.Show("Lütfen altın sayısını 9 veya 9 basamaklıdan daha küçük giriniz.");
                    txtAltinSayisi.Text = "";
                    txtAltinSayisi.Focus();
                    i = 0;
                    e.Handled = true;
                }
            }
          
        }

        
    }
}
