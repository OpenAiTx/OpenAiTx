# gig

Gigはgleamで書かれたgleamコンパイラです。

## 使い方

### サンプルファイルのコンパイルと実行：

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
- これはファイル `samples/hello_world.gleam` を `samples/hello_world.c` にコンパイルし、その後 C コンパイラを使用してバイナリを `samples/hello_world.exe` に作成します。
- Gig はソースディレクトリとの一般的な名前の競合を避けるために `.exe` 拡張子を追加します。

### gig をコンパイルする:


```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

### gigバイナリを使用してプロジェクトをコンパイルする方法：

- `gig`実行ファイルをパスに追加するか、プロジェクトにコピーしてください。
- `patch`ディレクトリをプロジェクトにコピーしてください。

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
- プロジェクトのルートディレクトリからgigを実行する必要があります。  
- Gigはメインモジュールのディレクトリ、`patch`ディレクトリ、およびダウンロードされた依存関係の各ソースディレクトリ（例：`build/packages/<package_name>/src`）からソースファイルを含みます。  
- `gleam deps download`を使って依存関係をダウンロードしてください。  
- メインモジュールはネストされていない、すなわち`src`ディレクトリに直接存在する必要があります。  

### gigをパス依存関係として使ってプロジェクトをコンパイルする  

- `gleam.toml`ファイルにgigをパス依存関係として追加します：`gig = { path = "../gig" }`。  
- `patch`ディレクトリをプロジェクトにコピーしてください。


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
### オプションフラグ:

- `--release`: 最適化を有効にします。
- `--gc`: ガベージコレクションを有効にします（無効の場合はガベージコレクションなし）。
- `--debug`: デバッグシンボルを含めます。
- `--headers`: FFI関数用のヘッダーファイルを生成します。
- `--compiler=name`: Cコンパイラの名前またはパスを指定します。
- `-c`: Cファイルのみを生成します（バイナリは生成しません）。

> [!重要]
> スタックオーバーフローが発生する可能性が高いため、スタックサイズを増やしてください。これらはしばしばセグフォルトとして現れます。
>
> ```
> ulimit -s unlimited
> ```

## 必須依存関係:

- Cコンパイラ（clangが最も適しているようです）
- `--gc`用にBoehm GC（別名 `libgc`）が必要です

## 標準ライブラリ

標準ライブラリの多くは `@external` 呼び出しで実装されているため、現時点ではすべての関数が利用できるわけではありません。
いくつかの関数はすでにパッチで再実装されています。詳細は `patch` ディレクトリを参照してください。未実装の関数が使用されるとコンパイラは警告を表示し、関数本体は「todo」として扱われます。

## パッチシステム

gigはサードパーティプロジェクトのため、一般に流通している多くのgleamライブラリは
対応していない可能性があります。このような場合に対応するために、
動作しないモジュールを上書きできるパッチシステムがあります。
これを行うには、修正したいモジュール名を `x` として、
`x.patch.gleam` というモジュールを作成してください。パッチは元のモジュールとマージされるため、
壊れている関数だけを実装すれば十分です。
パッチは `patch` ディレクトリまたは任意のソースディレクトリに配置できます。

より良いC言語サポートのために、プロジェクトに `.clangd` と
`compile_flags.txt` ファイルを追加できます。


`.clangd`:

```
CompileFlags:
  Add: [-Ipatch]
```

`compile_flags.txt`: (空ファイル)

## FFI

`@external(c, "", "function_name")` アノテーションを使用して、通常の gleam の FFI と同様に C 関数を定義できます。
これを行った後、`--headers` オプションを付けてコンパイラを実行すると、
外部関数を実装するために必要な関数および型宣言を含むヘッダーファイルが生成されます。
実装する C ファイルはこのヘッダーファイルを `#include` し、
ヘッダーファイルと同じ名前である必要があります。
関数はできるだけ名前空間を付けて、例えば `module_name_function_name()` のようにしてください。

## 機能 / Todo リスト

### 基本

- [x] Bool
- [x] Int
- [x] Float
- [x] 10進数以外の数値フォーマット
- [x] String
- [x] List
- [x] 等価性
- [x] 代入
- [x] 破棄パターン
- [x] 型推論
- [x] 型注釈
- [x] モジュール（注：モジュールはターゲットファイルを基準に解決されます）
- [x] 依存関係
- [x] 修飾されていないインポート
- [x] 型エイリアス
- [x] ブロック
- [x] 定数
- [x] メモリ管理（GC/RC）

### 関数

- [x] 関数
- [x] 高階関数

- [x] 無名関数  
- [x] 関数のキャプチャ  
- [x] ジェネリック関数  
- [x] パイプライン  
- [x] ラベル付き引数  
- [ ] ドキュメンテーションコメント（無視）  
- [ ] 廃止予定（無視）  

### フロー制御  

- [x] case式  
- [x] 変数パターン  
- [x] コンストラクタパターン  
- [x] 文字列パターン  
- [x] リストパターン  
- [x] 再帰  
- [ ] 尾再帰呼び出し（注：Cコンパイラがこれを行う可能性あり）  
- [x] 複数のサブジェクト  
- [x] 代替パターン  
- [x] パターンエイリアス  
- [x] ガード  
- [ ] 網羅性チェック  

### その他のデータ型  

- [x] タプル  
- [x] カスタム型  
- [x] レコード  
- [x] レコードアクセサ  
- [x] レコード更新  
- [x] ジェネリックカスタム型  
- [x] 結果型  
- [ ] ビット配列（部分サポート）  

### 高度な機能  

- [ ] 不透明型  
- [x] use  
- [x] todo  
- [x] panic
- [x] let assert
- [x] 外部モジュール

## 貢献について

現時点ではコードの貢献は受け付けていません。問題提起、提案、または議論は自由に行ってください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---