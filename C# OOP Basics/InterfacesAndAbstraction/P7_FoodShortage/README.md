Food Shortage
-------------

Your totalitarian dystopian society suffers a shortage of food, so many rebels
appear. Extend the code from your previous task with new functionality to solve
this task.

Define a class **Rebel** which has a **name**, **age** and **group**
(string)**,** names are **unique -** there will never be 2 Rebels/Citizens or a
Rebel and Citizen with the same name**.** Define an interface **IBuyer** which
defines a method **BuyFood()** and an integer property **Food**. Implement the
**IBuyer** interface in the **Citizen** and **Rebel** class, both Rebels and
Citizens **start with 0 food**, when a Rebel buys food his **Food** increases by
**5**, when a Citizen buys food his **Food** increases by **10**.

On the first line of the input you will receive an integer **N** - the number of
people, on each of the next **N** lines you will receive information in one of
the following formats “**\<name\> \<age\> \<id\> \<birthdate\>**” for a Citizen
or “**\<name\> \<age\>\<group\>**” for a Rebel. After the **N** lines until the
command “**End**” is received, you will receive names of people who bought food,
each on a new line. Note that not all names may be valid, in case of an
incorrect name - nothing should happen.

### Output

The **output** consists of only **one line** on which you should print the
**total** amount of food purchased.

### Examples

| **Input**                                                                                                                                     | **Output** |
|-----------------------------------------------------------------------------------------------------------------------------------------------|------------|
| 2 Pesho 25 8904041303 04/04/1989 Stancho 27 WildMonkeys Pesho Gosho Pesho End                                                                 | 20         |
| 4 Stamat 23 TheSwarm Toncho 44 7308185527 18/08/1973 Joro 31 Terrorists Penka 27 881222212 22/12/1988 Jiraf Jo ro Jiraf Joro Stamat Penka End | 20         |
