# Sord

## 概要

Sordは[**So**rbet](https://sorbet.org)と[YA**RD**](https://yardoc.org/)
のクロスオーバーです。**YARDドキュメントのコメントに指定された型情報**を参照して、
**RBIおよびRBS型のシグネチャファイルを自動生成**できます。

もしあなたのプロジェクトがすでにYARDでドキュメント化されているなら、
ほとんどの型シグネチャをこのツールで生成できます！

Sordは、SorbetのRBI形式やRuby 3/SteepのRBS形式のいずれを使うにしても、
プロジェクトで型導入を始めるのに最適な方法です。

**Sordをオンラインで試す: [sord.aaronc.cc](https://sord.aaronc.cc)**

Sordの特徴は以下の通りです:
  - モジュール、クラス、メソッドのシグネチャを自動生成
  - 複数のパラメータ型や戻り値型のサポート（`T.any`/`|`）
  - YARD型情報が欠落している場合も適切に処理（`T.untyped`/`untyped`）
  - セッターのパラメータ型を対応するゲッターの戻り値型から推論可能
  - ミキシン（`include`と`extend`）を認識
  - `Array<T>`や`Hash<K, V>`のようなジェネリック型をサポート
  - 名前空間付きクラスの推論可能（`[Bar]`が`GemName::Foo::Bar`になる）
  - `nil`を許容する戻り値型を処理（`T.nilable`/`untyped`）
  - ダックタイピング型を処理（`T.untyped`/`untyped`）
  - 順序付きリスト型をサポート（`[Array(Integer, Symbol)]`が`[Integer, Symbol]`になる）
  - ブール型をサポート（`[true, false]`が`T::Boolean`/`bool`になる）
  - `&block`パラメータを`@yieldparam`および`@yieldreturn`でドキュメント化可能

## 使い方

`gem install sord`でSordをインストールします。

Sordはコマンドラインツールです。プロジェクトのルートディレクトリでターミナルを開き、
`-sord`コマンドを実行し、出力先のパスを渡してください（既存のファイルは上書きされます）:


```
sord defs.rbi
```
SordはYARDドキュメントを生成し、実行中に推論した情報を出力します。  
YARDドキュメントの問題は修正することを推奨します。生成されたファイルに加えた編集は、Sordを再実行すると置き換えられます。  

出力タイプは使用するファイル拡張子から推論されますが、`--rbi`や`--rbs`で明示的に指定することも可能です。  

## RBIタイプの配布  

Sordで生成されたRBIファイルは主に二つの方法で利用されます：  

- [gem自体に同梱する](https://sorbet.org/docs/rbi#rbis-within-gems)。  
- [sorbet-typed](https://github.com/sorbet/sorbet-typed)に貢献する。  

一般的には、可能であればgemに型シグネチャを同梱すべきです。  
sorbet-typedは、更新が停止されたgemや、メンテナが型シグネチャをgemに同梱したくない場合のための場所です。  

### フラグ  

Sordは生成されるファイルを変更するためのいくつかのフラグを受け取ります：  

  - `--rbi`/`--rbs`：ファイル拡張子から推論される出力形式を上書きします。  
  - `--no-sord-comments`：警告・推論・エラーに関するSordのコメントなしでファイルを生成します。（元のファイルのコメントは引き続き含まれます。）  
  - `--no-regenerate`：デフォルトではSordはリポジトリのYARDドキュメントを再生成しますが、このオプションで再生成をスキップします。  
  - `--break-params`：シグネチャが単一行から複数行ブロックに変わるパラメータの数を決定します。（デフォルト: 4）  
  - `--replace-errors-with-untyped`：`SORD_ERROR_*`定数の代わりに`T.untyped`を使います。  
  - `--replace-unresolved-with-untyped`：Sordが定数を解決できない場合に`T.untyped`を使います。  
  - `--include-messages`および`--exclude-messages`：Sordのログメッセージをフィルターするために使います。`--include-messages`はホワイトリストとして機能し、指定したログ種別のメッセージのみを出力し、`--exclude-messages`は














    指定されたログ種類をブラックリストとして扱い、抑制します。両方のフラグはカンマ区切りのログ種類リストを取ります。例：`omit,infer`。
    `--include-messages`を使用すると、`done`種類はデフォルトで含まれます。
    （`--include-messages`と`--exclude-messages`を同時に指定することはできません。）
  - `--exclude-untyped`: 戻り値が型指定されていないメソッドと属性を除外します。
  - `--tags TAGS`: `yard`コマンドで理解されるカンマ区切りタグのリストを提供します。例：`--tags 'mytag:My Description,mytag2:My New Description'`

## 例

次のファイルがあるとします。名前は`test.rb`です：




```ruby
module Example
  class Person
    # @param name [String] The name of the Person to create.
    # @param age [Integer] The age of the Person to create.
    # @return [Example::Person]
    def initialize(name, age)
      @name = name
      @age = age
    end

    # @return [String]
    attr_accessor :name

    # @return [Integer]
    attr_accessor :age

    # @param possible_names [Array<String>] An array of potential names to choose from.
    # @param possible_ages [Array<Integer>] An array of potential ages to choose from.
    # @return [Example::Person]
    def self.construct_randomly(possible_names, possible_ages)
      Person.new(possible_names.sample, possible_ages.sample)
    end
  end
end
```
まず、`yardoc test.rb`を実行してYARDレジストリを生成します。次に、`sord test.rbi`を実行してRBIファイルを生成できます。（コードファイルを上書きしないよう注意してください！拡張子は`.rbi`です。）これを行うと、Sordは次のように表示します：




```
[INFER] Assuming from filename you wish to generate in RBI format
[DONE ] Processed 8 objects (2 namespaces and 6 methods)
```
`test.rbi` ファイルには、`test.rb` の完全な RBI ファイルが含まれています:


```ruby
# typed: strong
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    sig { params(name: String, age: Integer).void }
    def initialize(name, age); end

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    sig { params(possible_names: T::Array[String], possible_ages: T::Array[Integer]).returns(Example::Person) }
    def self.construct_randomly(possible_names, possible_ages); end

    sig { returns(String) }
    attr_accessor :name

    sig { returns(Integer) }
    attr_accessor :age
  end
end
```
もし代わりに `test.rbs` を生成していた場合、RBS形式のこのファイルが得られます:


```ruby
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    def initialize: (String name, Integer age) -> void

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    def self.construct_randomly: (Array[String] possible_names, Array[Integer] possible_ages) -> Example::Person

    attr_accessor name: String

    attr_accessor age: Integer
  end
end
```

## 注意点

型変換の一般的なルールは以下の通りです：

  - SordがYARDの型を理解できる場合、それはRBIまたはRBSの型に変換されます。
  - YARDの型が存在しない場合、Sordは`T.untyped`を補います。
  - YARDの型が理解できない場合、Sordは未知のYARD型に似た名前の未定義Ruby定数を作成します。例えば、明らかに無効なYARD型`A%B`は`SORD_ERROR_AB`という定数になります。生成されたファイル内で`SORD_ERROR`を検索し、修正してください。

## 貢献について

バグ報告やプルリクエストはGitHubの https://github.com/AaronC81/sord で歓迎します。このプロジェクトは安全で歓迎的な共同作業の場を目指しており、貢献者は[Contributor Covenant](http://contributor-covenant.org)の行動規範を遵守することが期待されています。

貢献中にSordの変更結果を確認したい場合は、`examples:seed` Rakeタスクを使用できます。このタスクはSordを使って、Bundler、Haml、Rouge、RSpecなどの複数のオープンソースRuby gemの型を生成します。`rake examples:seed`（ファイルを再生成するには`rake examples:reseed`）は、これらのgemのリポジトリを`sord_examples/`にクローンし、同じディレクトリにファイルを生成します。

## ライセンス

このgemは[MITライセンス](https://opensource.org/licenses/MIT)の条件のもとオープンソースとして提供されています。

## 行動規範

Sordプロジェクトのコードベース、イシュートラッカー、チャットルーム、メーリングリストに関わるすべての人は、[行動規範](https://github.com/AaronC81/sord/blob/master/CODE_OF_CONDUCT.md)を遵守することが期待されています。












---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---