using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IUser
    {
        public bool EditOneUserById(UserDTO dto);

        public bool ChangeSubscription(UserDTO dto);
    }
}
