using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface ILogin
    {
        public LoginDTO LoginUser(LoginDTO dto);

        public bool LoginUserExists(LoginDTO dto);
    }
}
