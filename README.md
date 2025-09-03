# QuanLyNetSieuCapVipPro

A Windows Forms (WinForms) management application for an Internet cafe (quán net). The project is written in C# targeting .NET 6 and provides user / account management, computer (station) control, service (dich vu) and transaction history, plus simple chat and time-tracking features.

---

## Key features

- Manage user accounts (create, edit, change password, deposit time).
- Manage services (add/update/remove service items and prices).
- Manage user groups / pricing (NhomNguoiDung).
- Track and update computer station states and play time.
- Simple internal chat between stations (frmGuiTinNhan).
- Transaction / order history logging and database backup/restore helpers.

Relevant forms and controls:
- frmMayTinh — station UI (login, time tracking, services, chat)
- frmThemThanhVien — create / edit member accounts
- frmThemDichVu — add / edit services
- frmCreateAccountAdmin — admin account creation
- frmDoiMatKhauUser — change user password
- NhomNguoiDung UserControl — group list and management

The application uses a Database helper class (Database) that encapsulates SQLite operations. The default DB connection string used in code: `Data Source=QuanLyNet123.db`.

---

## Requirements

- Windows OS
- .NET 6 SDK (runtime + targeting pack)
- Visual Studio 2022 (recommended) or later with .NET desktop development workload

---

## Getting started

1. Clone the repository:
   - git clone https://github.com/duynguyen020304/QuanLyNetSieuCapVipPro

2. Open the solution:
   - In Visual Studio: __File > Open > Project/Solution__, then open the `.sln`.

3. Restore NuGet packages:
   - Visual Studio will usually restore automatically. Or use CLI:
     - dotnet restore QuanLyNetSieuCapVipPro.sln

4. Build:
   - In Visual Studio: __Build > Build Solution__.
   - Or CLI: dotnet build QuanLyNetSieuCapVipPro.sln

5. Run:
   - In Visual Studio: __Debug > Start Debugging__ (F5) or __Debug > Start Without Debugging__ (Ctrl+F5).
   - Or CLI from the project folder: dotnet run --project QuanLyNetSieuCapVipPro

---

## Database notes

- The app expects a SQLite file named `QuanLyNet123.db` (connection string shown in Database class).
- If a database file does not exist, the Database helper includes CreateDatabase() and other helpers (Backup / Restore). You can call `Database.CreateDatabase()` programmatically or provide the `QuanLyNet123.db` file in the application folder.
- Important tables and methods exposed by Database (non-exhaustive):
  - GetUserPassword / UpdateUserPassword
  - InsertDataIntoNGUOICHOI / UpdateNguoiChoiTableUserData
  - InsertDataIntoDichVu / updateItemInDICHVU / RemoveItemFromDICHVU
  - GetAllItemsFromMAYTINH / UpdateComputerStateInMAYTINH
  - Backup / Restore

---

## Configuration & localization

- UI text is in Vietnamese. You can localize strings by updating form resources and labels in the designer.
- Adjust connection file name or path in the Database class if you move the DB file.

---

## Troubleshooting

- "Cannot find database" — ensure `QuanLyNet123.db` is present next to the executable or call `Database.CreateDatabase()` before other DB operations.
- "Missing .NET runtime" — install .NET 6 runtime and ensure Visual Studio has the .NET desktop workload.

---

## Contributing

- Open an issue or a pull request on the repository.
- Follow existing code style, keep logic inside forms/delegates consistent with current patterns.

---

## License

This project is released under the MIT License.