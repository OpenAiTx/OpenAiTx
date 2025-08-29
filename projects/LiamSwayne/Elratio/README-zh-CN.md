# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~最终更新。~~ [逆向最终更新。](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

一种基于 Python 的编程语言，结合了 Ruby 的性能和 Perl 的可读性。

> “汇编语言的解决方案”

要编写自己的 Elratio 程序，请下载 [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) 并在指定位置编写程序。

# 特性
Elratio 相较于其他语言提供了众多优势！

## 大胆的新空白符
没有现代语言会指明空行是空的。Elratio 用 `empty` 关键字大胆地开辟了空白符的新方向。
###### Python/Java/R/C/Go/JavaScript：
<pre>

</pre>
###### Elratio：
```python
empty;
```
Elratio 不允许空行。每个空行必须包含关键字 `empty`。

## 清晰的行和程序结尾
许多现代编程语言已经变得觉醒化并推广了无趣的行结尾语法。另一方面，Elratio 使用明确定义的 `;` 符号来定义行结尾（除了以 `:` 结尾的行）。

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
此外，每个程序必须以 `end` 关键字结束。埃尔拉提欧再次碾压了竞争对手。
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:

```python
end;
```

## 反向缩进
主程序中执行的代码行需要降低层级，因此我们引入了反向缩进系统。

```python
        while True:
    if True:
1000;
```
你再也不用担心在不了解周围代码的情况下缩进一行了。

## 创造力的力量
Elratio 允许你通过 `create` 关键字扮演上帝。通过创造数字，解锁无限的数值可能性。
<pre>
SystemOutPrint(7);
>>> 第 1 行错误：SystemOutPrint(7);
>>> 这是个玩笑吗？数字“7”尚未被创造。请先使用“create 7”。
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```
但在创建数字之前，你必须先创建 `create`。

```python
create create;
```
许多语言缺乏明确的类创建指示符，但对于 Elratio 来说，这又是一次又一次的全垒打。

```python
    create class book:
pass;
```

## 突破性的注释
`#` 符号长期以来一直用于表示某些行是注释，不应被执行。设计 Elratio 时，我们从头重构了注释，提出了 `comment` 关键字。
```python
comment rewrite this segment;
```
就像输入 `comment`，空格键，您的注释，然后是分号一样简单。

## 重新定义 `def`
虽然 `def` 在临时使用时很方便，但它可能导致意大利面条式代码，因此我们用 `definition` 代替了它。
```python
    definition doNothing:
pass;
```

## 改进的打印语法
Python 使用不够清晰的语法 `print()` 来打印。Elratio 使用 `systemOutPrint()` 以增强清晰度。
<pre>
print(10);
>>> 我是一个原则性的编译器。我不接受 print()。请使用 systemOutPrint()。
</pre>
```python
systemOutPrint(10);
>>> 10
```
你可以感谢 Java 激发了这一变化。

## 编译器的个性化反馈
Elratio 利用下一代字符串技术，为用户提供独特且描述性的错误信息。
<pre>
>>> 空程序。下次别给我发这种垃圾，混蛋！
</pre>
<pre>
>>> 第 31 行错误：空
>>> 不以冒号结尾的语句必须以 ASCII (2^6)-5 结尾。
</pre>
<pre>
>>> 第 42 行大错特错：print(44);
>>> 你傻吗？数字“4”还没被创建。请先使用“create 4”。
</pre>

# 示例
你可以在 [examples](examples) 文件夹中找到示例程序。以下是一个用 Elratio 编写的时间打印程序示例：
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
作为提醒，您现在就可以通过下载 [template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) 并编写您的程序来开始使用 Elratio 编程！

# 包支持
Elratio 支持所有现有的 Python 包！导入到 Elratio 中的包无需修改。

# 赞助商 ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# 许可
Elratio 采用 GPL 3.0 许可证，这意味着每个 Elratio 程序都必须开源。在您的计算机上拥有 Elratio 程序而没有在线免费镜像，是违反该许可证的行为。别逼我们动手。

<!--
你还在这？结束了，回家吧。
-->



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---