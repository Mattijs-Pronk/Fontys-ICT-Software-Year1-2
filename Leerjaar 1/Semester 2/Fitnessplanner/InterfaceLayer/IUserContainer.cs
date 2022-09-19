using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLayer
{
    public interface IUserContainer
    {
        public bool AddOneUser(UserDTO dto);

        public bool DeleteOneUserById(int id);

        public bool CheckForPermission(int id);

        public bool UserExists(string email);

        public List<UserDTO> GetAllUsers();

        public UserDTO GetOneUserById(int id);

        public UserDTO GetOneUserByEmail(string SearchPhrase);
    }
}
