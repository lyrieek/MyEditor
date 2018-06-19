using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
    public partial class Set : Form
    {

        public static Encoding stringEncoding = Encoding.Default;
        public static string md5key = "--------";

        public Set()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            switch (cbx_Encoding.Text)
            {
                case "Default":
                    stringEncoding = Encoding.Default;
                    break;
                case "ASCII":
                    stringEncoding = Encoding.ASCII;
                    break;
                case "Unicode":
                    stringEncoding = Encoding.Unicode;
                    break;
                case "UTF-7":
                    stringEncoding = Encoding.UTF7;
                    break;
                case "UTF-8":
                    stringEncoding = Encoding.UTF8;
                    break;
                case "UTF-16(BigEndianUnicode)":
                    stringEncoding = Encoding.BigEndianUnicode;
                    break;
                case "UTF-32":
                    stringEncoding = Encoding.UTF32;
                    break;
            }
            if (txt_md5key.Text.Length == 8)
                md5key = txt_md5key.Text;
            else
                MessageBox.Show("MD5密钥必须等于8位数");
            this.Hide();
        }

        private void Set_Load(object sender, EventArgs e)
        {
            cbx_Encoding.SelectedIndex = 0;
        }
    }
}
