using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementDataa
{
    public class UserDAL
    {
        public List<ReceivedBook> receivedBooks = new List<ReceivedBook>();

        public List<RequestedBook> requestedBooks = new List<RequestedBook>();

        public List<User> users = new List<User>();
        /*        User user1 = new User("chandan@gmail", 1, "chandan", "12345@");
                User user2 = new User("kiran@gmail", 2, "kiran", "56789@");*/
        //User user=new User();
     
        
        public void AcceptRequestDAL()
        {

        }
        public void AddUsersDAL(User user)
        {
    
            users.Add(user);
            Console.WriteLine("user added successfully");
            Console.Read();
            



        }
        public void DeleteReceivedDAL()
        {

        }

        public void GetAllUserssDAL()
        {

        }

        public void GetReceivedBookDAL()
        {

        }

        public void GetRequestBookDAL()
        {

         }
        public void RemoveUsersDAL()
        {

        }
        public void RequestBookDAL()
        {

        }

        public void UsersDAL()
        {

        }
    }
}
