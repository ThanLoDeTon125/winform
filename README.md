# winform cuoi ki — Quản lý cafe (15 bảng + 10 form)

Project WinForms .NET 8, namespace `winform_cuoi_ki`. Mỗi form: `.cs` + `.Designer.cs` + `.resx`.

## 10 form

| Form | File |
|------|------|
| Đăng nhập | `Forms/frmLogin.*` |
| Main | `Forms/frmMain.*` |
| Bán hàng | `Forms/frmBanHang.*` |
| Sản phẩm | `Forms/frmSanPham.*` |
| Danh mục | `Forms/frmDanhMuc.*` |
| Nguyên liệu | `Forms/frmNguyenLieu.*` |
| Nhập kho | `Forms/frmNhapKho.*` |
| Hóa đơn | `Forms/frmHoaDon.*` |
| Nhân viên | `Forms/frmNhanVien.*` |
| Khách hàng | `Forms/frmKhachHang.*` |

## 15 bảng SQL (`CafeQuanLy`)

Chạy lần lượt `Sql/01_create_database.sql` → `02_schema.sql` → `03_seed.sql` trên LocalDB.

## Mở trong VS

1. Mở `winform cuoi ki.csproj` **hoặc** Add Existing Item các file `Forms/*` vào project hiện có.
2. F5 → form Đăng nhập (stub, bấm Đăng nhập là vào Main).
