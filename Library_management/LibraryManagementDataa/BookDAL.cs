using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;
using System.Data.SqlClient;

namespace LibraryManagementDataa
{
    public class BookDAL
    {
        List<Book> books;

        public static string sqlcon = "Data Source=VDC01LTC2179;Initial Catalog=LibraryManagementService;Integrated Security=True";
        public string AddBooksDAL(Book book)
        {
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("insert into book values('"+book.BookAuthor+"',"+book.BookCopies+","+book.BookId+",'"+book.BookName+"')", con);
            con.Open();
            int row =cmd.ExecuteNonQuery();
            con.Close();
            if (row > 0)
                msg = "inserted";
          

            return msg;
        }

        public List<Book> GetAllBooksDAL()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand cmd = new SqlCommand("select * from book", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            books = new List<Book>();   
            while (dr.Read())
            {
                books.Add(new Book
                {
                    BookId = Convert.ToInt32(dr["BookId"]),
                    BookName = dr["BookName"].ToString(),
                    BookAuthor = dr["BookAuthor"].ToString(),
                    BookCopies = Convert.ToInt32(dr["BookCopies"])
                }) ;
            }
            
            con.Close();
            return books;

        }

        public void RemoveBooksDAL()
        {

        }
        public void UpdaeBooksDAL()
        {
            
        }

    }
}
