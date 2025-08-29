# EʅɾαՇισ
<a href="https://liamswayne.github.io/elratio/security.mp4">
    <img src="https://img.shields.io/badge/Visitor_IP_address-66.122.23.197-blue" height="25">
</a>

# ~~最終更新。~~ [逆最終更新。](https://github.com/LiamSwayne/Elratio/blob/main/announcements.md)

RubyのパフォーマンスとPerlの可読性を組み合わせたPythonベースのプログラミング言語。

> 「アセンブリへの解決策」

独自のElratioプログラムを書くには、[template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py)をダウンロードし、指定されたスペースにプログラムを書いてください。

# 特徴
Elratioは他のすべての言語に対して多くの利点を提供します！

## 新しい大胆な空白行
現代の言語は空行が空であることを示す指示を提供しません。Elratioは`empty`キーワードで空白を大胆に新しい方向へ導きます。
###### Python/Java/R/C/Go/JavaScript:
<pre>

</pre>
###### Elratio:
```python
empty;
```
Elratioは空行を許可しません。すべての空行にはキーワード`empty`を含める必要があります。

## 行の終了とプログラムの終了
多くの現代のプログラミング言語は時流に乗り、無味乾燥な行末の構文を流行らせました。  
一方でElratioは、明確に定義された `;` 記号を使って行の終了を定義します（ただし `:` で終わる行は除く）。

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
さらに、すべてのプログラムは `end` キーワードで終了しなければなりません。改めて、Elratio は競合を圧倒します。
###### Python/R/JavaScript:
<pre>

</pre>
###### Elratio:

```python
end;
```

## 逆インデント
mainで実行された行を一段下げる必要があったため、逆インデントのシステムを導入しました。

```python
        while True:
    if True:
1000;
```
もう二度と、周囲の素晴らしい行を疑うことなく行のインデントを心配する必要はありません。

## 創造の力そのもの
Elratioは`create`キーワードで神のように遊ぶことを可能にします。数字を作成することで無限の数値の可能性を解き放ちます。
<pre>
SystemOutPrint(7);
>>> 1行目での誤り: SystemOutPrint(7);
>>> 冗談ですか？数字「7」はまだ作成されていません。まず「create 7」を使用してください。
</pre>

```python
create 7;
SystemOutPrint(7);
>>> 7
```
しかし、数字を作成する前に、`create`を作成しなければなりません。

```python
create create;
```
多くの言語にはクラス作成の明確な指標がありませんが、それでもエルラティオにとっては連続ヒットのようなものです。

```python
    create class book:
pass;
```

## 画期的なコメント
`#` 記号は長い間、特定の行がコメントであり実行されるべきではないことを示すために使われてきました。Elratioを設計する際、私たちはコメントを根本から再構築し、`comment` キーワードを考案しました。
```python
comment rewrite this segment;
```
`comment`、スペースキー、コメント、セミコロンと、とても簡単です。

## `def` の再定義
`def` は手早く使えて便利ですが、スパゲッティコードにつながることがあるため、`definition` に置き換えました。
```python
    definition doNothing:
pass;
```

## 改良された印刷構文
Python は不明瞭な構文 `print()` を使用して印刷します。Elratio は明確さのために `systemOutPrint()` を使用します。
<pre>
print(10);
>>> 私は原則のコンパイラです。print() は受け付けません。代わりに systemOutPrint() を使用してください。
</pre>
```python
systemOutPrint(10);
>>> 10
```
この変更のきっかけはJavaに感謝してください。

## コンパイラからのパーソナライズされたフィードバック
Elratioは次世代文字列技術を活用し、ユーザーに独自でわかりやすいエラーメッセージを提供します。
<pre>
>>> 空のプログラムです。次回はそんなクソみたいなものを送らないでください、バカ！
</pre>
<pre>
>>> 31行目のエラー：空です
>>> コロンで終わらない文はASCII（2^6）-5で終わらなければなりません。
</pre>
<pre>
>>> 42行目の大失敗：print(44);
>>> バカですか？数字の「4」はまだ作成されていません。まず「create 4」を使ってください。
</pre>

# 例
例題プログラムは[examples](examples)フォルダにあります。以下はElratioで書かれた時間表示プログラムの例です：
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
念のためお知らせしますが、[template.py](https://raw.githubusercontent.com/LiamSwayne/Elratio/main/template.py) をダウンロードしてプログラムを書き始めれば、**今すぐ** Elratio でコーディングを開始できます！


# パッケージサポート
Elratio は既存のすべての Python パッケージをサポートしています！パッケージは Elratio にインポートするために修正する必要はありません。

# スポンサー ❤️
<a href="https://liamswayne.github.io/elratio/antarctica_public_school.jpeg"><img src="/sponsors/antarctica_public_schools.jpg" height="150"></a> <a href="https://liamswayne.github.io/elratio/enron_guy.png"><img src="/sponsors/enron.png" height="150"></a> <a href="https://liamswayne.github.io/elratio/sbf_link.png"><img src="/sponsors/sam_bankman_reeee.png" height="150"></a>

# ライセンス
Elratio は GPL 3.0 ライセンスの下にあり、すべての Elratio プログラムはオープンソースである必要があります。お使いのコンピュータに Elratio プログラムがあり、オンラインで自由に利用できるミラーが存在しない場合、それはこのライセンス違反となります。暴力に訴えざるを得ない事態は避けてください。

<!--
まだここにいるの？もう終わりだ。家に帰れ。
-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---