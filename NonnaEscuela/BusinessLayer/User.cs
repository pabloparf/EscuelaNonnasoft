using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;


namespace BusinessLayer
{
    public class User
    {
        DB db = new DB();
        
        public void UserLogin(string login, string password)
        {
            _User usuario = new _User();
            usuario =  db.CheckLogin(login, password);      
        }
          
    }
}
