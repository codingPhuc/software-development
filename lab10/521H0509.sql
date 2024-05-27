create database Final_Exam ; 

use Final_Exam   ; 


CREATE TABLE Readers (
    reader_id INT  PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(100),
    dob DATE
);

CREATE TABLE Books (
    book_id INT  PRIMARY KEY IDENTITY(1,1) ,
    title VARCHAR(100),
    author VARCHAR(100),
    publisher VARCHAR(100),
    genre VARCHAR(100)
);

CREATE TABLE Borrowing (
    borrowing_id VARCHAR(50) PRIMARY KEY,
    reader_id int,
    borrowing_date DATE,
    FOREIGN KEY (reader_id) REFERENCES Readers(reader_id)
);

CREATE TABLE CTPM (
	PRIMARY KEY (borrowing_id, book_id), 
	borrowing_id VARCHAR(50) ,
    book_id int,
    return_date DATE,
    FOREIGN KEY (book_id) REFERENCES Books(book_id),
	FOREIGN KEY (borrowing_id) REFERENCES Borrowing(borrowing_id)
);




-- Inserting into the Readers table
INSERT INTO Readers (name, dob) VALUES
('Alice Johnson', '1990-05-15'),
('Bob Smith', '1985-10-20'),
('Charlie Brown', '1992-03-08'),
('Diana Wilson', '1988-07-25'),
('Eva Davis', '1995-12-12');

-- Inserting into the Books table
INSERT INTO Books (title, author, publisher, genre) VALUES
('To Kill a Mockingbird', 'Harper Lee', 'J.B. Lippincott & Co.', 'Fiction'),
('1984', 'George Orwell', 'Secker & Warburg', 'Dystopian'),
('Pride and Prejudice', 'Jane Austen', 'T. Egerton, Whitehall', 'Romance'),
('The Great Gatsby', 'F. Scott Fitzgerald', 'Charles Scribner''s Sons', 'Fiction'),
('The Catcher in the Rye', 'J.D. Salinger', 'Little, Brown and Company', 'Coming-of-age');



-- Inserting into the Borrowing table
INSERT INTO Borrowing (borrowing_id, reader_id, borrowing_date) VALUES
('B1', 1, '2024-04-20'),
('B2', 3, '2024-04-21'),
('B3', 5, '2024-04-22'),
('B4', 2, '2024-04-23'),
('B5', 4, '2024-04-24');

-- Inserting into the CTPM table
INSERT INTO CTPM (borrowing_id, book_id, return_date) VALUES
('B1', 1, '2024-04-25'),
('B2', 2, '2024-04-26'),
('B3', 3, '2024-04-27'),
('B4', 4, '2024-04-28'),
('B5', 5, '2024-04-29');
