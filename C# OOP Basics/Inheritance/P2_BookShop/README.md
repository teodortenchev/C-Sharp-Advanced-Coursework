Book Shop
---------

You are working in a library. You are sick of writing descriptions for books by
hand, so you wish to use the computer to speed up the process. The task is
simple - your program should have two classes – one for the ordinary books –
**Book**, and another for the special ones – **GoldenEditionBook**. So let’s get
started! We need two classes:

-   **Book** - represents a book that holds **title**, **author** and **price**.
    A book should offer **information** about itself in the format shown in the
    output below.

-   **GoldenEditionBook** - represents a special book that holds the same
    properties as any **Book**, but its **price** is always **30% higher**.

### Constraints

-   If the author’s second name is starting with a digit – the exception’s
    message is: **"Author not valid!"**

-   If the title’s length is less than 3 symbols – the exception’s message is:
    **"Title not valid!"**

-   If the price is zero or it is negative – the exception’s message is:
    **"Price not valid!"**

-   Price must be formatted to **two** symbols after the decimal separator