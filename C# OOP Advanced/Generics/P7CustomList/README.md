Custom List
-----------

Create a generic data structure that can store **any** type that **can** be
compared. Implement functions:

-   **void Add(T element)**

-   **T Remove(int index)**

-   **bool Contains(T element)**

-   **void Swap(int index1, int index2)**

-   **int CountGreaterThan(T element)**

-   **T Max()**

-   **T Min()**

Create a command interpreter that reads commands and modifies the custom list
that you have created. Set the custom list’s type to string. Implement the
commands:

-   **Add \<element\>** - Adds the given element to the end of the list

-   **Remove \<index\>** - Removes the element at the given index

-   **Contains \<element\>** - Prints if the list contains the given element
    **(True or False)**

-   **Swap \<index\> \<index\>** - Swaps the elements at the given indexes

-   **Greater \<element\>** - Counts the elements that are greater than the
    given element and prints their count

-   **Max** - Prints the maximum element in the list

-   **Min** - Prints the minimum element in the list

-   **Print** - Prints all of the elements in the list, each on a separate line

-   **END** - stops the reading of commands

There will **not** be any **invalid** input commands.

### Examples

| **Input**                                                              | **Output**            |
|------------------------------------------------------------------------|-----------------------|
| Add aa Add bb Add cc Max Min Greater aa Swap 0 2 Contains aa Print END | cc aa 2 True cc bb aa |