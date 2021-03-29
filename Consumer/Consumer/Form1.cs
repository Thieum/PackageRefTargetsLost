using ProxyDLL;
using System.Windows.Forms;

namespace Consumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CefSharp.OffScreen.CefSettings test = new Class1().Test();
        }
    }
}
