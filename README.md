# winform cuoi ki — UI WinForms (.cs + .Designer.cs + .resx)

Mã giao diện Designer-first cho app quản lý cafe. **Namespace: `winform_cuoi_ki`** (khớp project VS của bạn).

Mỗi form/UC có bộ ba giống `Form1` trong Solution Explorer:

```
frmLogin.cs
  ├─ frmLogin.Designer.cs
  └─ frmLogin.resx
```

## Cấu trúc trong repo

```
Forms/
  frmLogin.cs + frmLogin.Designer.cs + frmLogin.resx
  frmMain.cs + frmMain.Designer.cs + frmMain.resx
  frmAbout.* / frmPos.* / frmPayment.*
  frmProductList.* / frmProductEdit.* / frmCategoryList.*
  frmIngredientList.* / frmStockIn.* / frmStockAdjust.*
  frmOrderHistory.* / frmOrderDetail.*
  frmEmployeeList.* / frmShiftOpen.* / frmShiftClose.*
  frmCustomerList.* / frmReports.* / frmSettings.*
Controls/
  ucProductGrid.cs + .Designer.cs + .resx
  ucCartPanel.cs + .Designer.cs + .resx
Program.cs          ← mở frmLogin → frmMain
winform cuoi ki.csproj
```

## Cách copy vào Visual Studio (project đang mở Form1)

1. Trong Solution Explorer → project `winform cuoi ki` → chuột phải → **Add → New Folder** → `Forms`, rồi `Controls`.
2. Chuột phải folder `Forms` → **Add → Existing Item…** → chọn **cả 3 file** mỗi form (`.cs`, `.Designer.cs`, `.resx`). Lặp lại cho mọi form.
3. Tương tự với `Controls/` (`ucProductGrid`, `ucCartPanel`).
4. Thay nội dung `Program.cs` bằng file trong repo (hoặc Add Existing rồi xóa Program cũ).
5. Có thể **xóa Form1** nếu không dùng.
6. **Build** (`Ctrl+Shift+B`) → F5: hiện form Đăng nhập.

> Tip: trong Solution Explorer, VS sẽ gom `.Designer.cs` và `.resx` dưới `.cs` giống `Form1` nếu tên khớp.

## Ghi chú

- Handler stub (`TODO` / `MessageBox`) — **chưa SQL/BLL**.
- DB LocalDB `CafeManagement` gắn sau khi có DAL.
- Nếu mở trực tiếp repo này: double-click `winform cuoi ki.csproj` (cần .NET 8 + Windows).
