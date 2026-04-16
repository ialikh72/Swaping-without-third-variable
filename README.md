# 🔄 Swap Two Numbers Without Using a Third Variable (C#)

## 📌 Description

This C# program demonstrates how to swap two integer values **without using a temporary (third) variable**. It uses basic arithmetic operations to perform the swap.

---

## 💡 How It Works

The program uses the following logic:

1. Add both numbers and store the result in `a`
2. Subtract `b` from `a` to get the original value of `a`
3. Subtract new `b` from `a` to get the original value of `b`

### Steps:

```
a = a + b;
b = a - b;
a = a - b;
```

---

## 🧾 Code

```csharp
using System;

class Quiz
{
    static void Main()
    {
        int a = 5;
        int b = 9;

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("a={0} and b={1}", a, b);
    }
}
```

---

## ▶️ Output

```
a=9 and b=5
```

---

## 🚀 Key Concept

This program is based on **value manipulation using arithmetic operations**, avoiding the need for an extra variable.

---

## ⚠️ Note

* This method works well for small numbers.
* For very large numbers, it may cause **integer overflow**.

---

## 📚 Learning Outcome

* Understanding variable swapping techniques
* Practicing arithmetic operations in C#
* Improving logical thinking
