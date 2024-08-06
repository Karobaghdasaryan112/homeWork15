using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork15
{
    internal class Admin
    {
        private int _code = 1234;
        private int _inputCode;
        public bool ValidAdmin(int code)
        {
            if (_code == code)
            {
                return true;
            }
            return false;
        }
    }
}
