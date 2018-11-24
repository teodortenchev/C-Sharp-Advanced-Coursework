Define an Interface IPerson
---------------------------

**NOTE**: You need a public **StartUp** class with the namespace **PersonInfo**.

Define an interface **IPerson** with properties for **Name** and **Age**. Define
a class **Citizen** which implements **IPerson** and has a constructor which
takes a **string** name and an **int** age.

Try to create a new Person like this:

| string name = Console.ReadLine(); int age = int.Parse(Console.ReadLine()); IPerson person = new Citizen(name, age); Console.WriteLine(person.Name); Console.WriteLine(person.Age); |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|


### Examples

| **Input** | **Output** |
|-----------|------------|
| Pesho 25  | Pesho 25   |