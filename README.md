# BankingSystem

A robust C# Console Application designed to manage bank accounts, calculate yearly interest, and handle client data using Object-Oriented Programming (OOP) principles.

## 🏗 Project Overview
This project represents a transition from luxury retail management into technical software engineering. It applies the precision and attention to detail required in high-end retail to the world of backend development. The system allows a "Bank Manager" to create accounts, store multilingual client information, search for specific records, and perform batch financial operations.

---

## 🛠 Technical Concepts Implemented

### 1. Object-Oriented Programming (OOP) & Composition
The project follows a "Composition" model where objects are built from other objects.
* **AccountOwner:** A standalone class managing personal details (ID, Name).
* **BankAccount:** Composes the `AccountOwner` into a financial structure, managing balances and transaction history.
* **BankingSystem:** Acts as the "Engine," holding a `List<BankAccount>` and providing the logic for adding, searching, and calculating interest.

### 2. The Application Loop (State Management)
The program uses a `while` loop and a `switch` statement to create a persistent user interface. 
* **State:** A boolean variable controls the application lifecycle.
* **Menu Logic:** Provides a clean terminal interface that responds to user input and clears the screen between operations for a professional feel.

### 3. Data Types and Financial Precision
Precision is vital in fintech. This project demonstrates:
* **Decimal Type:** Used for currency and interest rates to avoid the binary rounding errors associated with `float` or `double`.
* **Type Conversion:** Successfully converting `string` inputs from `Console.ReadLine()` into `int` and `decimal` to perform calculations.
* **Format Specifiers:** Utilizing `:C` to automatically format numbers as British Currency (£).

### 4. Search and Null Safety
The search logic implements a safety check to prevent the application from crashing if an account is not found:
* **Null Checking:** Verifying if a search result is not null before attempting to access properties, ensuring a "crash-free" user experience.

---

## 📂 Project Structure

- **Program.cs**: The main entry point and UI control loop handling user interaction.
- **BankingSystem.cs**: The core engine logic for managing the collection of accounts.
- **BankAccount.cs**: The data model for individual financial records.
- **AccountOwner.cs**: The data model for client personal data.
- **Notification.cs**: A utility class providing visual feedback (Success/Failure) with custom dwell times and colours.

### Choice of Structure
* **Separation of Concerns:** Each class has a single responsibility. The `Notification` class handles all visual feedback, while `BankingSystem` handles all data logic.
* **Scalability:** By keeping the `AccountOwner` separate, the system is prepared for future features like joint accounts or linking multiple accounts to a single owner.

---

## 🚀 How to Run
This project was built and tested on **Windows 11 Pro** using **PowerShell 7.5.4**.

1. Clone this repository to your local machine.
2. Open your terminal (PowerShell recommended) and navigate to the project folder.
3. Run the following command:
   ```powershell
   dotnet run