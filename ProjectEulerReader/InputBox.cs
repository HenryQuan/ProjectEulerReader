using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEulerReader
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        private void inputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int n;
                if (int.TryParse(inputText.Text, out n))
                {
                    var text = Convert.ToInt32(inputText.Text);
                    if (text >= 0 && text <= 9999)
                    {
                        ProjectEuler.curQuestion = text;
                    }
                }
                else
                {
                    MessageBox.Show("Not valid");
                }
                Close();
            }
        }
    }
}
