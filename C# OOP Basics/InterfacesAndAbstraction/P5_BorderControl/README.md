Border Control
--------------

It’s the future, you’re the ruler of a totalitarian dystopian society inhabited
by **citizens** and **robots**, since you’re afraid of rebellions you decide to
implement strict control of who enters your city. Your soldiers check the
**Id**s of everyone who enters and leaves.

You will receive an unknown amount of lines from the console until the command
“**End**” is received, on each line there will be a piece of information for
either a citizen or a robot who tries to enter your city in the format
**“\<name\> \<age\> \<id\>**” for **citizens** and “**\<model\> \<id\>**” for
**robots**. After the end command on the next line you will receive a single
number representing **the last digits of fake ids**, all citizens or robots
whose **Id** ends with the specified digits must be detained.

The output of your program should consist of all detained **Id**s each on a
separate line in the **order** of **input**.

### Input

The input comes from the console. Every commands’ parameters before the command
“**End**” will be separated by a **single space**.

### Examples

| **Input**                                                                                            | **Output**          |
|------------------------------------------------------------------------------------------------------|---------------------|
| Pesho 22 9010101122 MK-13 558833251 MK-12 33283122 End 122                                           | 9010101122 33283122 |
| Toncho 31 7801211340 Penka 29 8007181534 IV-228 999999 Stamat 54 3401018380 KKK-666 80808080 End 340 | 7801211340          |