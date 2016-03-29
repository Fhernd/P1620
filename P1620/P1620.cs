using System.Windows.Forms;

namespace P1620
{
    public partial class P1620 : Form
    {
        public P1620()
        {
            InitializeComponent();
        }

        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
