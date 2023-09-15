using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibrary1
{
    public class email:TextBox
    {
        ErrorProvider a = new ErrorProvider();
        public email()
        {
            KeyPress += email_KeyPress;
        }

        void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }   
}
