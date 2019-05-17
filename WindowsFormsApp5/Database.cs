using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp5
{
    class Database
    {
        SqlConnection con;
        public Database()
        {
            con = new SqlConnection("server=.database = Kütüphane;Integrated Security = true");
        }
        #region Books
        public bool AddBook(string BookName, string Writer, string Exp, int stock)
        {
            bool durum = false;
            SqlCommand cmd = new SqlCommand("insert into Books(BookName,BookExp,BookWriter,BookStok)values(@BookName,@Exp,@BookWriter,@BookStock)", con);
            cmd.Parameters.AddWithValue("@BookName", BookName);
            cmd.Parameters.AddWithValue("@Exp", Exp);
            cmd.Parameters.AddWithValue("@BookWriter", Writer);
            cmd.Parameters.AddWithValue("@BookStock", stock);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                durum = true;
            }
            catch
            {

            }
            con.Close();
            return durum;
        }
        public bool UpgBook(int ID, string BookName, string Writer, string Exp, int stock)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand("update Books set BookName = @BookName,BookExp = @BookExp,BookWriter = @BookWriter,BookStok = BookStok where Books.BookID = @ID", con);
            cmd.Parameters.AddWithValue("@BookName", BookName);
            cmd.Parameters.AddWithValue("@BookExp", Exp);
            cmd.Parameters.AddWithValue("@BookWriter", Writer);
            cmd.Parameters.AddWithValue("@BookStok", stock);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        public bool DelBook(int ID)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand(@"delete from Books where Books.BookID = @ID
delete from User_Book where BookID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        #endregion

        #region Users
        public bool AddUser(string Name_Surname, string PhoneNo, string TCNo, string Address)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand("insert into Users(UserName_Surname,UserPhone,UserTC,UserAddress)values(@Name,@Phone,@TC,@Address)", con);
            cmd.Parameters.AddWithValue("@Name", Name_Surname);
            cmd.Parameters.AddWithValue("@Phone", PhoneNo);
            cmd.Parameters.AddWithValue("@TC", TCNo);
            cmd.Parameters.AddWithValue("@Address", Address);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        public bool AddUser(int ID,string Name_Surname, string PhoneNo, string TCNo, string Address)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand("upgrade Users set UserName_Surname = @Name,UserPhone_No= @PhoneNo,UserTCNo = @TCNo,UserAddress = @Address where Users.UserID = @ID", con);
            cmd.Parameters.AddWithValue("@Name", Name_Surname);
            cmd.Parameters.AddWithValue("@PhoneNo", PhoneNo);
            cmd.Parameters.AddWithValue("@TCNo", TCNo);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        public bool DelUser(int ID)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand(@"delete from Users where Users.UserID = @ID
delete from User_Book where UserID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        #endregion

        #region Deposit
        public bool AddDeposit(string Name_Surname, string BookName,string TakenDate, string ReturnDate)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand(@"declare @UserID int = 1 , @BookID int = 1, @TakenDate varchar(50) = @Taken, @ReturnDate varchar(50) = @Return
select @BookID = Books.BookID from Books where Books.BookName = @BookName
select @UserID = Users.UserID from Users where Users.UserName_Surname = @UserName
----------
insert into Kisi_Kitap(UserID,BookID,TakenDate,ReturnDate)values(@UserID,@BookID,@TakenDate,@ReturnDate)", con);
            cmd.Parameters.AddWithValue("@Taken", TakenDate);
            cmd.Parameters.AddWithValue("@Return", ReturnDate);
            cmd.Parameters.AddWithValue("@BookName", BookName);
            cmd.Parameters.AddWithValue("@UserName", Name_Surname);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
                return situ;
        }
        public bool UpdDeposit(int ID,string UserName, string BookName, string TakenDate, string ReturnDate)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand(@"declare @ReturnDate varchar(50) = @Return, @TakenDate varchar(50) = @Taken
declare @UserName_Surname varchar(50)=@UserName, BookName varchar(50) = @BookName
update Kisi_Kitap set UserID = ( select Users.UserID from Users where Users.UserName_Surname = @UserName_Surname),
BookID = (select Books.BookID from Books where Books.BookName = @BookName),
TakenDate = @TakenDate,
ReturnDate = @ReturnDate
where Kisi_Kitap.ID = @ID", con);
            cmd.Parameters.AddWithValue("@Taken", TakenDate);
            cmd.Parameters.AddWithValue("@Return", ReturnDate);
            cmd.Parameters.AddWithValue("@BookName", BookName);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@ID", ID);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        public bool DelDeposit(int ID)
        {
            bool situ = false;
            SqlCommand cmd = new SqlCommand("delete from Kisi_Kitap where Kisi_Kitap.ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                situ = true;
            }
            catch
            {

            }
            con.Close();
            return situ;
        }
        #endregion

        #region List
        public DataTable AllBooks()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(" select * from Books", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch
            {

            }
            con.Close();
            return tbl;
        }
        public DataTable AllUsers()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(" select * from Users", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch
            {

            }
            con.Close();
            return tbl;
        }
        public DataTable AllDeposit()
        {
            DataTable tbl = new DataTable();
            SqlCommand cmd = new SqlCommand(" select * from Kisi_Kitap", con);
            con.Open();
            try
            {
                SqlDataReader sr = cmd.ExecuteReader();
                tbl.Load(sr);
            }
            catch
            {

            }
            con.Close();
            return tbl;
        }
        #endregion
    }
}
