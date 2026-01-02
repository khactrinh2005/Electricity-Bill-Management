# Electricity Bill Management Application ⚡

A Windows Forms desktop application designed to manage customer data, electricity meters, and monthly billing calculations. This project demonstrates the practical application of **C# .NET**, **3-Layer Architecture**, and **Binary Serialization** for data persistence.

## 🚀 Key Features

* **Customer Management:** Add, edit, delete, and search for customer information.
* **Electricity Meter Management:** Manage meter details and associate them with customers.
* **Billing System:** Record electricity usage and automatically calculate monthly bills based on consumption.
* **Data Persistence:** Uses **Binary Serialization** to save/load all data to/from a local file (`.dat`), making the app portable.
* **MDI Interface:** Supports Multiple Document Interface, allowing users to work with multiple forms simultaneously.

## 🛠️ Technology Stack

* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Architecture:** 3-Layer (Data Access, Business Logic, Presentation)
* **Data Storage:** Binary File (.dat) via Serialization
* **Data Structures:** Generic List Collections (`List<T>`)
* **IDE:** Visual Studio

## 📂 Project Structure

The solution is organized into logical layers:
* **GUI (Presentation Layer):** Windows Forms handling user interaction and data display.
* **BLL (Business Logic Layer):** Classes that handle core logic, calculations, and communicate between GUI and DAL.
* **DAL (Data Access Layer):** Class responsible for serializing and deserializing data to/from the storage file (`.dat`).
* **DTO (Data Transfer Object):** Classes used to transfer data between the three layers above.

## ⚙️ How to Run

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/YOUR_USERNAME/Electricity-Bill-Management.git](https://github.com/YOUR_USERNAME/Electricity-Bill-Management.git)
    ```
2.  **Open the project:**
    * Launch Visual Studio.
    * Open the `DATH_DH52302115.sln` solution file.
3.  **Build and Run:**
    * Press `F5` or click **Start** to run the application.
    * *Note: The app will automatically generate a data file upon the first save.*

## 👨‍💻 Author

**Nguyen Khac Trinh**
* **Role:** Full-stack Developer (Personal Project)

---
*This project was developed to demonstrate proficiency in Object-Oriented Programming and Windows Application Development.*