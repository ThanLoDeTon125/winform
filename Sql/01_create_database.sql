-- CafeQuanLy — DB gọn 15 bảng (LocalDB / Express)
IF DB_ID(N'CafeQuanLy') IS NULL
BEGIN
    CREATE DATABASE CafeQuanLy COLLATE Vietnamese_CI_AS;
END
GO
