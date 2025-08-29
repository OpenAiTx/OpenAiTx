# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~Final update.~~ [Reverse-final update.](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

A Python-based programming language that combines the performance of Ruby with the readability of Perl.

> "The solution to Assembly"

To write your own Elratio program, download [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) and write your program in the indicated space.

# Features
Elratio provides numerous advantages over every other language!

## Bold new whitespace
No modern language provides indication that an empty line is empty. Elratio takes whitespace in a bold new direction with the `empty` keyword.
###### Python/Java/R/C/Go/JavaScript:
<pre>

</pre>
###### Elratio:
```python
empty;
```
Elratio does not permit blank lines. Every empty line must contain the keyword `empty`.

## Clear line and program endings
Many modern programming languages have gone woke and popularized uninspired syntax for line endings. Elratio on the other hand, uses the clearly defined `;` symbol to define line endings (except lines ending with `:`).

###### Python:
<pre>
if True:
    pass
</pre>

###### Elratio:
```python
    if True:
pass;
```

In addition, every program must end with the `end` keyword. Once again, Elratio smashes the competition.
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:
```python
end;
```

## Inverted indentation
Lines executed in main needed to be taken down a peg, so we introduced a system of inverted indentation.

```python
        while True:
    if True:
1000;
```
Never again will you have to worry about indenting a line without questioning the incredible lines around it.

## The power of creation itself
Elratio allows you to play god with the `create` keyword. Unlock unlimited numerical possibilities by creating numbers.
<pre>
SystemOutPrint(7);
>>> Blunder on line 1: SystemOutPrint(7);
>>> Is this a joke? The digit "7" has not been created yet. Use "create 7" first.
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```
But before creating numbers, you must create `create`.

```python
create create;
```
Many languages lack a clear indicator of class creation, but again it's just home run after home run for Elratio.

```python
    create class book:
pass;
```
## Groundbreaking comments
The `#` symbol has long been used to indicate that certain lines are comments and should not be executed. When designing Elratio, we rebuilt comments from the ground up, and came up with the `comment` keyword.

```python
comment rewrite this segment;
```
It's as simple as `comment`, spacebar, your comment, and a semicolon.

## Redefining `def`
While `def` can be convenient on the fly, it can lead to spaghetti code, so we've replaced it with `definition`.
```python
    definition doNothing:
pass;
```

## Improved printing syntax
Python uses the unclear syntax `print()` to print. Elratio uses `systemOutPrint()` for clarity.
<pre>
print(10);
>>> I am a compiler of principle. I do not accept print(). Use systemOutPrint() instead.
</pre>
```python
systemOutPrint(10);
>>> 10
```
You can thank Java for inspiring this change.

## Personalized feedback from the compiler
Elratio utilizes next-gen string technology to provide the user with unique, descriptive error messages.
<pre>
>>> Empty program. Don't send me that crap next time, jerk!
</pre>
<pre>
>>> Error on line 31: empty
>>> Statements that do not end with a colon must end with ASCII (2^6)-5.
</pre>
<pre>
>>> Blunder on line 42: print(44);
>>> Are you stupid? The digit "4" has not been created yet. Use "create 4" first.
</pre>

# Examples
You can find example programs in the [examples](examples) folder. Here is an example of a time printing program written in Elratio:
```python
        comment imports;
        import time;
        comment create number;
        create create;
        create 1;
        empty;
        definition print_formatted_time(current_time, format_string):
    formatted_time = time.strftime(format_string, current_time);
    systemOutPrint("Formatted time:", formatted_time);
    empty;
        definition main():
    systemOutPrint("Welcome to the Simple Time Printer!");
    systemOutPrint("Select an option:");
    create 2;
    systemOutPrint("1. Print current time in default format");
    systemOutPrint("2. Print current time in custom format");
    choice = input("Enter your choice: ");
    empty;
    comment get the current time;
    current_time = time.localtime();
    empty;
    if choice == 1:
comment print the time with formatting;
print_formatted_time(current_time, "%Y-%m-%d %H:%M:%S");
    elif choice == 2:
custom_format = input("Enter your custom format (e.g., %Y/%m/%d %I:%M %p): ");
print_formatted_time(current_time, custom_format);
    else:
systemOutPrint("Invalid choice.");
    empty;
        if __name__ == "__main__":
    main();
        end;
>>> Welcome to the Simple Time Printer!
>>> Select an option:
>>> 1. Print current time in default format
>>> 2. Print current time in custom format
>>> Enter your choice: 1
>>> ('Formatted time:', '2023-08-26 00:34:10')
```
As a reminder, you can start coding in Elratio **right now** by downloading [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) and writing your program!


# Package support
Elratio supports all existing Python packages! Packages do not need to be modified in order to be imported into Elratio.

# Sponsors ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# License
Elratio is under the GPL 3.0 license, meaning every Elratio program is required to be open source. Having an Elratio program on your computer without a freely available mirror online is a violation of this license. Do not make us resort to violence.

<!--
You're still here? It's over. Go home.
-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---