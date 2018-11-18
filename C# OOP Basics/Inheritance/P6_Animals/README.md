Animals
-------

Create a hierarchy of **Animals**. Your program should have three different
animals – **Dog**, **Frog** and **Cat**. Deeper in the hierarchy you should have
two additional classes – **Kitten** and **Tomcat**. **Kittens are female and
Tomcats are male!**

All types of animals should be able to produce some kind of sound
(**ProduceSound()**). For example, the dog should be able to bark.

Your task is to model the hierarchy and test its functionality. Create an animal
of each kind and make them all produce sound.

You will be given some lines of input. Each two lines will represent an animal.
On the first line will be the type of animal and on the second – the name, the
age and the gender. When the command "**Beast!**" is given, stop the input and
print all the animals in the format shown below.

### Output

-   Print the information for each animal on three lines. On the first line,
    print: "\<**AnimalType**\>"

-   On the second line print: "\<**Name**\> \<**Age**\> \<**Gender**\>"

-   On the third line print the sounds it produces: "\<**ProduceSound()**\>"

### Constraints

-   Each **Animal** should have a **name**, an **age** and a **gender**

-   **All** input values should **not be blank** (e.g. name, age and so on…)

-   If you receive an input for the **gender** of a **Tomcat** or a **Kitten**,
    ignore it but **create** the animal

-   If the input is invalid for one of the properties, throw an exception with
    message: "I**nvalid input!**"

-   Each animal should have the functionality to **ProduceSound()**

-   Here is the type of sound each animal should produce:

    -   **Dog: "Woof!"**

    -   **Cat: "Meow meow"**

    -   **Frog: "Ribbit"**

    -   **Kittens: "Meow"**

    -   **Tomcat: "MEOW"**

### Examples

| **Input**                                     | **Output**                                         |
|-----------------------------------------------|----------------------------------------------------|
| Cat Tom 12 Male Dog Sharo 132 Male Beast!     | Cat Tom 12 Male Meow meow Dog Sharo 132 Male Woof! |
| Frog Kermit 12 Male Beast!                    | Frog Kermit 12 Male Ribbit                         |
| Frog Sashko -2 Male Frog Sashko 2 Male Beast! | Invalid input! Frog Sashko 2 Male Ribbit           |