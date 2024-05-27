using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Borrowing
    {
        DAL_Borrowing p;

        public BUS_Borrowing(string BorrowingId, int ReaderId, DateTime BorrowingDate)
        {
            p = new DAL_Borrowing(BorrowingId, ReaderId, BorrowingDate);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }

    public class BUS_CTPM
    {
        DAL_CTPM p;

        public BUS_CTPM(string BorrowingId, int BookId, DateTime ReturnDate)
        {
            p = new DAL_CTPM(BorrowingId, BookId, ReturnDate);
        }

        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }

    public class BUS_Books
    {
        DAL_Books p;

        public BUS_Books(int BookId, string Title, string Author, string Publisher, string Genre)
        {
            p = new DAL_Books(BookId, Title, Author, Publisher, Genre);
        }

      /*  public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }*/

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }
    public class BUS_Readers
    {
        DAL_Reader p;

        public BUS_Readers(int ReaderId, string Name, DateTime Dob)
        {
            p = new DAL_Reader(ReaderId, Name, Dob);
        }

  
        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
    }



}
