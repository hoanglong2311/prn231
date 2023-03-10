CREATE TABLE [dbo].[STUDENTS](
    [ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [FULLNAME] [varchar](100) NOT NULL,
    [AGE] [int] NOT NULL,
    [ADDRESS] [nvarchar](100) NULL)

INSERT INTO STUDENTS (FULLNAME,AGE, ADDRESS)
VALUES
    ('John Doe', 22, '123 Main Street, Anytown, USA 12345'),
    ('Jane Doe', 20, '456 Elm Street, Anytown, USA 12345'),
    ('Bob Smith', 25, '789 Oak Street, Anytown, USA 12345'),
    ('Amy Johnson', 21, '111 Maple Street, Anytown, USA 12345'),
    ('Tom Brown', 23, '222 Pine Street, Anytown, USA 12345'),
    ('Sara Lee', 19, '333 Cedar Street, Anytown, USA 12345'),
    ('Mike Green', 24, '444 Birch Street, Anytown, USA 12345'),
    ('Kim Black', 21, '555 Rose Street, Anytown, USA 12345'),
    ('David White', 22, '666 Daisy Street, Anytown, USA 12345'),
    ('Emily Davis', 20, '777 Sunflower Street, Anytown, USA 12345'),
    ('James Wilson', 26, '888 Violet Street, Anytown, USA 12345'),
    ('Jessica Taylor', 25, '999 Tulip Street, Anytown, USA 12345'),
    ('William Brown', 24, '111 Daffodil Street, Anytown, USA 12345'),
    ('Ashley Clark', 19, '222 Marigold Street, Anytown, USA 12345'),
    ('Ryan Adams', 21, '333 Narcissus Street, Anytown, USA 12345');