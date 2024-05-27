using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Borrowing
    {
        private string BorrowingId;
        private int ReaderId;
        private DateTime BorrowingDate;

        public string _BorrowingId
        {
            get { return BorrowingId; }
            set { BorrowingId = value; }
        }

        public int _ReaderId
        {
            get { return ReaderId; }
            set { ReaderId = value; }
        }

        public DateTime _BorrowingDate
        {
            get { return BorrowingDate; }
            set { BorrowingDate = value; }
        }

        public DTO_Borrowing(string BorrowingId, int ReaderId, DateTime BorrowingDate)
        {
            this.BorrowingId = BorrowingId;
            this.ReaderId = ReaderId;
            this.BorrowingDate = BorrowingDate;
        }

    }
    public class DTO_CTPM
    {
        private string BorrowingId;
        private int BookId;
        private DateTime ReturnDate;

        public string _BorrowingId
        {
            get { return BorrowingId; }
            set { BorrowingId = value; }
        }

        public int _BookId
        {
            get { return BookId; }
            set { BookId = value; }
        }

        public DateTime _ReturnDate
        {
            get { return ReturnDate; }
            set { ReturnDate = value; }
        }

        public DTO_CTPM(string BorrowingId, int BookId, DateTime ReturnDate)
        {
            this.BorrowingId = BorrowingId;
            this.BookId = BookId;
            this.ReturnDate = ReturnDate;
        }
    }

    public class DTO_Readers
    {
        private int ReaderId;
        private string Name;
        private DateTime Dob;

        public int _ReaderId
        {
            get { return ReaderId; }
            set { ReaderId = value; }
        }

        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public DateTime _Dob
        {
            get { return Dob; }
            set { Dob = value; }
        }

        public DTO_Readers(int ReaderId, string Name, DateTime Dob)
        {
            this.ReaderId = ReaderId;
            this.Name = Name;
            this.Dob = Dob;
        }
    }

    public class DTO_Books
    {
        private int BookId;
        private string Title;
        private string Author;
        private string Publisher;
        private string Genre;

        public int _BookId
        {
            get { return BookId; }
            set { BookId = value; }
        }

        public string _Title
        {
            get { return Title; }
            set { Title = value; }
        }

        public string _Author
        {
            get { return Author; }
            set { Author = value; }
        }

        public string _Publisher
        {
            get { return Publisher; }
            set { Publisher = value; }
        }

        public string _Genre
        {
            get { return Genre; }
            set { Genre = value; }
        }

        public DTO_Books(int BookId, string Title, string Author, string Publisher, string Genre)
        {
            this.BookId = BookId;
            this.Title = Title;
            this.Author = Author;
            this.Publisher = Publisher;
            this.Genre = Genre;
        }
    }








}
