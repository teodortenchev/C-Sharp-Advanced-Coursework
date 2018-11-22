*Mordor’s Cruel Plan
---------------------

Gandalf the Gray is a great wizard but he also loves to eat and the food makes
him loose his capability of fighting the dark. The Mordor’s orcs have asked you
to design them a program that calculates Gandalf’s mood, so they can predict the
battles between them and try to beat The Gray Wizard. When Gandalf is hungry, he
gets angry and he cannot fight well. The orcs’ spy has revealed to them the
foods that Gandalf is eating and the result on his mood after he had eaten each
of them. Here is the list:

-   **Cram**: 2 points of happiness;

-   **Lembas**: 3 points of happiness;

-   **Apple**: 1 point of happiness;

-   **Melon**: 1 point of happiness;

-   **HoneyCake**: 5 points of happiness;

-   **Mushrooms**: -10 points of happiness;

-   **Everything else**: -1 point of happiness;

Gandalf’s moods are:

-   **Angry** - below -5 points of happiness;

-   **Sad** - from -5 to 0 points of happiness;

-   **Happy** - from 1 to 15 points of happiness;

-   **JavaScript** - when happiness points are more than 15;

The task is simple. Model an application that calculates the happiness points
Gandalf has after eating all the food passed in the input. After you are done,
print on the first line – total happiness points Gandalf had collected. On the
second line – print the **Mood’s** name, which corresponds to the points.

### Input

The input comes from the console. It will hold a single line: all of the foods
Gandalf has eaten separated by a whitespace.

### Output

Print on the console Gandalf\`s happiness points and the **Mood’s** name which
is corresponding to the points.

### Constraints

-   The characters in the input string will be no more than: **1000.**

-   The food count would be in the range **[1…100]**.

-   Time limit: 0.3 sec. Memory limit: 16 MB.

### Note

Try to implement a factory pattern. You should have two factory classes –
**FoodFactory** and **MoodFactory**. And their task is to produce objects (e.g.
**FoodFactory**, produces – **Food** and the **MoodFactory** - **Mood**). Try to
implement abstract classes (e.g. classes which can’t be instantiated directly)

### Examples

| **Input**                               | **Output** |
|-----------------------------------------|------------|
| Cram melon honeyCake Cake               | 7 Happy    |
| gosho, pesho, meze, Melon, HoneyCake\@; | \-5 Sad    |
