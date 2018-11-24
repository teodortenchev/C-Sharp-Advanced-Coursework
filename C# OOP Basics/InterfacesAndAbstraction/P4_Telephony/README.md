Telephony
---------

You have a business - **manufacturing cell phones**. But you have no software
developers, so you call some friends of yours and ask them to help you create a
cell phone software. They have already agreed and you started working on the
project. The project consists of one main **model – a Smartphone**. Each of your
smartphones should have functionalities of **calling other phones** and
**browsing in the world wide web.**

These friends of yours though are very busy, so you decide to write the code on
your own. Here is the mandatory assignment:

You should have a **model** - **Smartphone** and two separate functionalities
which your smartphone has - to **call other phones** and to **browse in the
world wide web**. You should end up with **one class** and **two interfaces**.

### Input

The input comes from the console. It will hold two lines:

-   **First line**: **phone numbers** to call (string), separated by spaces.

-   **Second line: sites** to visit (string), separated by spaces.

### Output

-   First **call all numbers** in the order of input then **browse all sites**
    in order of input

-   The functionality of calling phones is printing on the console the number
    which are being called in the format:

>   **Calling... \<number\>**

-   The functionality of the browser should print on the console the site in
    format:

>   **Browsing: \<site\>!**

-   If there is a number in the input of the URLs, print: **"Invalid URL!"** and
    continue printing the rest of the URLs.

-   If there is a character different from a digit in a number, print:
    **"Invalid number!"** and continue to the next number.

### Constraints

-   Each site's URL should consist only of letters and symbols (**No digits are
    allowed** in the URL address)

### Examples

| **Input**                                                                                                   | **Output**                                                                                                                                                                                 |
|-------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 0882134215 0882134333 08992134215 0558123 3333 1 http://softuni.bg http://youtube.com http://www.g00gle.com | Calling... 0882134215 Calling... 0882134333 Calling... 08992134215 Calling... 0558123 Calling... 3333 Calling... 1 Browsing: http://softuni.bg! Browsing: http://youtube.com! Invalid URL! |