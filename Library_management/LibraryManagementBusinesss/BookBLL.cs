using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementBusinesss;
using LibraryManagementDataa;
using LibraryManagementEntity;

namespace LibraryManagementBusinesss
{
    public  class BookBLL
    {
        public string AddBookBLL(Book book)
        { 
           BookDAL bookDALObj=new BookDAL();

            string  msg=bookDALObj.AddBooksDAL(book);
            return msg;
        }
    }
}
