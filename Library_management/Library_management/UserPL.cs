using LibraryManagementBusinesss;
using LibraryManagementDataa;
using LibraryManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management
{
    public class UserPL
    {
        public string user;

        UserDAL userDALObj=new UserDAL();
        public void AddUser()
        {
            User user = new User();
            Console.WriteLine("Enter user details");
            Console.Write("User Id :");
            user.UserId = Convert.ToInt32(Console.ReadLine());
            Console.Write("User Name :");
            string UserName= Console.ReadLine();
            Console.Write("User Email :");
            string UserEmail = Console.ReadLine();
            Console.Write("User Password :");
            string UserPassword = Console.ReadLine();
            userDALObj.AddUsersDAL(user); 
            
        }
        public void DeleteReceive()
        {

        }
        public void GetAllUser()
        {
            Console.WriteLine("-------------------------------UsersList----------------------------");
            Console.WriteLine("--Id-----------Name--------Email-------------------Password---------");
            foreach (var item in userDALObj.users)
            {

                Console.WriteLine("  "+item.UserId+"  "+ item.UserName +" "+ item.UserEmail+" "+ item.UserPassword);
                
            }

        }
        public void GetReceivedBook()
        {

        }
        public void GetRequestBook()
        {

        }

        public void GetUserHomeMenu()
        {



        }

        public void GetUserMenu()
        {

        }

        public void GetUserReceivedBook()
        {

        }
        public void GetUserRequestBook()
        {

        }

        public void ReceiveSection()
        {

        }
        public void RemoveUser()
        {

        }

        public void RequestBook()
        {

        }

        public void RequestSection()
        {

        }
        
        public void UpdateUser()
        {

        }
        public void UserHomeSection()
        {

        }

        public void UserLogin()
        {
            string UserEmail;
            string UserPassword;
            Console.Write("Email :");
            UserEmail = Console.ReadLine();
            Console.Write("Password :");
            UserPassword = Console.ReadLine();
            UserBLL userBLLObj = new UserBLL();

            bool flag = userBLLObj.UserLogin(UserEmail, UserPassword);
            if (flag)
            {
                Console.WriteLine("Logged in Successfully as user");

            }
            else
            {
                Console.WriteLine("Invalid credentials");
            }
        }

        public bool UserSection(bool flag)
        {
            Console.WriteLine("Welcome-to-User-Section");
            int codeentered;
            // int codebooksection, usersection, requestsection, acceptedsection, logout;
            Console.WriteLine("Press 1 to add a user");
            Console.WriteLine("Press 2 to update a user");
            Console.WriteLine("Press 3 to delete a user");
            Console.WriteLine("Press 4 to show all user");
            Console.WriteLine("Press 5 to exit");
            codeentered = Convert.ToInt32(Console.ReadLine());
            UserPL userPLObj = new UserPL();
            switch (codeentered)
            {
                case 1:
                    
                    userPLObj.AddUser();
                    return true;
                    break;
                case 2:
                    userPLObj.UpdateUser();
                    return true;
                    break;
                case 3:
                    userPLObj.RemoveUser();
                    return true;
                    break;
                case 4:
                    userPLObj.GetAllUser();
                    return true;
                    break;
                case 5:
                    flag = false;
                    return flag;
                    break;
                default:
                    Console.WriteLine("invalid code");
                    return false;
                    break;
                    
                    

            }

        }





    }
}
