using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _100_solved_tasks
{
    internal class Functions
    {
        public void max(int a,int b)
        {
            if (a > b)
                MessageBox.Show(a.ToString());
            else MessageBox.Show(b.ToString());
        }

    }
}
