
# C# Fundamentals Demonstration

This project contains multiple C# examples illustrating key object-oriented and .NET programming concepts including:

- Method and operator overloading
- Anonymous types
- Extension methods
- Indexers
- Type conversions

These are common foundational topics for learning C# in a university or self-study setting.

---

## 📁 Project Structure

```
LU1Theme2/
├── LU1Theme2.sln                   # Visual Studio solution file
└── LU1Theme2/
    ├── AnonymousType.cs            # Demonstrates use of anonymous types
    ├── BasicClass.cs               # Basic class with properties
    ├── BasicOverloading.cs        # Method overloading examples
    ├── ConversionClass.cs         # Convert and TryParse usage
    ├── Extension.cs               # Extension method examples
    ├── IndexerLog.cs              # Indexer demonstration
    ├── Money.cs                   # Operator overloading with normalization
    ├── OverloadBasicClass.cs      # Operator overloading for a point class
    ├── Program.cs                 # Main execution and examples
    ├── WeekDays.cs                # Enum usage (likely)
    └── LU1Theme2.csproj           # Project file
```

---

## 🚀 How to Run

1. Open the `LU1Theme2.sln` file in **Visual Studio 2022+**.
2. Set `LU1Theme2` as the startup project.
3. Uncomment the desired example block in `Program.cs`.
4. Run the project using `F5` or the **Start Debugging** option.

---

## ✅ Key Features & Concepts

| Feature               | File                    | Description |
|----------------------|-------------------------|-------------|
| **Method Overloading**     | `BasicOverloading.cs`       | Shows multiple `Add` methods with different parameters |
| **Operator Overloading**   | `OverloadBasicClass.cs`, `Money.cs` | Adds custom `+` operator for custom classes |
| **Anonymous Types**        | `AnonymousType.cs`          | Demonstrates anonymous object creation |
| **Extension Methods**      | `Extension.cs`              | Adds methods to `string` type like `.GetLength()` |
| **Type Conversion**        | `ConversionClass.cs`        | Demonstrates use of `Convert` and `TryParse` |
| **Indexers**               | `IndexerLog.cs`             | Shows how indexers allow object array-like access |
| **Indexers**               | `WeekDays.cs`               | Shows how indexers allow object array-like access  |

---

## 📦 Requirements

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio 2022 or later with C# support

---

## 🧪 Sample Execution Flow

To run a specific demo:
```csharp
// In Program.cs, uncomment a block like below
var object3 = new OverloadBasicClass(10, 30);
var object4 = new OverloadBasicClass(20, 30);
var result2 = object3 + object4;
Console.WriteLine($"The new point is {result2.X},{result2.Y}");
```

Then run the program to see the results in the console.

---

## 📚 Educational Use

This solution is ideal for:
- **Lecturers or trainers** teaching C# OOP concepts.
- **Students** practicing foundational programming patterns.
- **Self-learners** experimenting with small modular examples.
