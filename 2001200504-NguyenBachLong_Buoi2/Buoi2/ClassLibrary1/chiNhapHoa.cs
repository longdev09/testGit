using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClassLibrary1
{
   public class chiNhapHoa: TextBox
    {
       public chiNhapHoa()
       {
           KeyPress += chiNhapHoa_KeyPress;
       }

       void chiNhapHoa_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (!char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
           {
               e.Handled = true;
           } 
       }
    }
}
