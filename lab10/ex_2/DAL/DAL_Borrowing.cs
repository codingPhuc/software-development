using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Borrowing
    {
        DTO_Borrowing p;

        public DAL_Borrowing(string BorrowingId, int ReaderId, DateTime BorrowingDate)
        {
            p = new DTO_Borrowing(BorrowingId, ReaderId, BorrowingDate);
        }

        public void addQuery()
        {
            string query = "INSERT INTO Borrowing VALUES ('" + p._BorrowingId + "', " + p._ReaderId + ", '" + p._BorrowingDate.ToString("yyyy-MM-dd") + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE Borrowing SET ReaderId = " + p._ReaderId + ", BorrowingDate = '" + p._BorrowingDate.ToString("yyyy-MM-dd") + "' WHERE BorrowingId = '" + p._BorrowingId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Borrowing WHERE BorrowingId = '" + p._BorrowingId + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM Borrowing";
            return Connection.selectQuery(query);
        }

        //get Datatable desc order
        public DataTable getBorrowingDesc()
        {
            string s = "select top 1 BorrowingId from Borrowing order by BorrowingId desc";
            return Connection.selectQuery(s);
        }
    } 

    public class DAL_CTPM
    {
        DTO_CTPM p;

        public DAL_CTPM(string BorrowingId, int BookId, DateTime ReturnDate)
        {
            p = new DTO_CTPM(BorrowingId, BookId, ReturnDate);
        }

        public void addQuery()
        {
            string query = "INSERT INTO CTPM VALUES ('" + p._BorrowingId + "', " + p._BookId + ", '" + p._ReturnDate.ToString("yyyy-MM-dd") + "')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE CTPM SET BookId = " + p._BookId + ", ReturnDate = '" + p._ReturnDate.ToString("yyyy-MM-dd") + "' WHERE BorrowingId = '" + p._BorrowingId + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM CTPM WHERE BorrowingId = '" + p._BorrowingId + "'";
            Connection.actionQuery(query);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM CTPM";
            return Connection.selectQuery(query);
        }

        //get Datatable desc order
        public DataTable getCTPMDesc()
        {
            string s = "select top 1 BorrowingId from CTPM order by BorrowingId desc";
            return Connection.selectQuery(s);
        }
    }
    public class DAL_Reader
    {
        DTO_Readers p;

        public DAL_Reader(int ReaderId, string Name , DateTime birthdate)
        {
            p = new DTO_Readers(ReaderId, Name, birthdate);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM Readers";
            return Connection.selectQuery(query);
        }

    }
    public class DAL_Books
    {
        DTO_Books p;

        public DAL_Books(int BookId, string Title, string Author, string Publisher, string Genre)
        {
            p = new DTO_Books(BookId, Title, Author, Publisher, Genre);
        }

        public DataTable selectQuery()
        {
            string query = "SELECT * FROM Books";
            return Connection.selectQuery(query);
        }
    }


}
