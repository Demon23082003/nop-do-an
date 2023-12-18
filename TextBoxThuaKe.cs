using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ungdunghoctumoi
{
    public partial class TextBoxThuaKe :  TextBox
    {
        public TextBoxThuaKe()
        {
            InitializeComponent();
            this.KeyPress += TextBox_KeyPress;
           
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' && (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        public TextBoxThuaKe(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

    }
}
