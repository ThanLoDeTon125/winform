USE CafeQuanLy;
GO

INSERT INTO dbo.VaiTro (Code, Name) VALUES
 (N'Admin', N'Quản trị'),
 (N'ThuNgan', N'Thu ngân'),
 (N'Kho', N'Nhân viên kho');
GO

-- Mật khẩu demo: 123456 — thay bằng hash thật trong BLL; placeholder tạm
INSERT INTO dbo.NhanVien (RoleId, Username, PasswordHash, FullName, Phone)
SELECT Id, N'admin', N'TODO_HASH_123456', N'Quản trị viên', N'0900000000'
FROM dbo.VaiTro WHERE Code = N'Admin';
GO

INSERT INTO dbo.DanhMuc (Name, DisplayOrder) VALUES
 (N'Cà phê', 1), (N'Trà', 2), (N'Bánh', 3);
GO

INSERT INTO dbo.SanPham (CategoryId, Code, Name, Price, IsSelling)
SELECT d.Id, v.Code, v.Name, v.Price, 1
FROM (VALUES
 (N'Cà phê', N'CF01', N'Cà phê đen', 25000),
 (N'Cà phê', N'CF02', N'Cà phê sữa', 30000),
 (N'Trà', N'TR01', N'Trà đào', 35000),
 (N'Bánh', N'BA01', N'Bánh mì que', 15000)
) v(Cat, Code, Name, Price)
JOIN dbo.DanhMuc d ON d.Name = v.Cat;
GO

INSERT INTO dbo.NguyenLieu (Code, Name, Unit, QuantityOnHand, MinQuantity) VALUES
 (N'NL01', N'Cà phê bột', N'g', 2000, 200),
 (N'NL02', N'Sữa tươi', N'ml', 5000, 500),
 (N'NL03', N'Đào miếng', N'g', 1000, 100);
GO

INSERT INTO dbo.CongThuc (ProductId, IngredientId, QuantityUsed)
SELECT sp.Id, nl.Id, x.Qty
FROM (VALUES (N'CF01', N'NL01', 18.0), (N'CF02', N'NL01', 16.0), (N'CF02', N'NL02', 50.0), (N'TR01', N'NL03', 40.0))
 x(PCode, ICode, Qty)
JOIN dbo.SanPham sp ON sp.Code = x.PCode
JOIN dbo.NguyenLieu nl ON nl.Code = x.ICode;
GO

INSERT INTO dbo.CauHinhCuaHang (Id, StoreName, Address, Phone, VatPercent, PointsPerThousand)
VALUES (1, N'Cafe Win Demo', N'123 Nguyễn Huệ', N'0900111222', 0, 1);
GO
