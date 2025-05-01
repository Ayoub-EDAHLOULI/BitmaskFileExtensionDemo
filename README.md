# Bitmask File Extension Demo

This project is a simple C# console application that demonstrates how to use **bitmasks** to manage accepted file extensions for different document categories.

## 📌 Purpose

Instead of storing multiple extensions in a list or separate records, we use a single 32-bit integer to efficiently represent which extensions are allowed using bit flags (`[Flags]` enum).

## 🚀 Features

- Define up to 32 file extensions using `[Flags]` enum.
- Assign and store multiple accepted extensions as a single integer value.
- Easily check which extensions are accepted using bitwise operations.
- Simulate adding and querying document categories without a database.

## 📂 Structure

- `FileExtensions` enum: defines each extension as a unique bit flag.
- `DocumentCategory` class: holds a name and its accepted extensions.
- `Program.cs`: demonstrates usage, including how to combine, store, and read extension permissions.

## 🔢 Example Output

Document Category: Identity Documents
Accepted Extensions
- PNG
- JPG
- PDF
- XLSX
Stored Bitmask Value: 15

Document Category: Text Documents
Accepted Extensions
- DOCX
- TXT
Stored Bitmask Value: 48

Identity Documents does not accept TXT


## 🛠 How to Run

1. Open the solution in Visual Studio or VS Code.
2. Build and run the console application.
3. Modify `Main()` to test different combinations of extensions.

## 📘 Learn More

- [Microsoft Docs: Enum Flags](https://learn.microsoft.com/en-us/dotnet/api/system.flagsattribute)
- [Bitwise Operators in C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators)

---

Enjoy and feel free to fork and modify this for learning or practical usage!
