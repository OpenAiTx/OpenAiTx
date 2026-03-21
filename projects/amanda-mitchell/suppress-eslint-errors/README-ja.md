# suppress-eslint-errors

![Release](https://github.com/amanda-mitchell/suppress-eslint-errors/workflows/Release/badge.svg)

新しいeslintルールを有効にしようとして、既存のコードベースに数百または数千のエラーがあるのを見て落胆したことはありませんか？
私たちもそうでした。

時には、特に大規模なレガシーコードベースでは、既存の（動作している！）コードをすべて更新するための十分なビジネス上の理由がないことがあります。
そんな時に、`suppress-eslint-errors` が役立ちます。

## 使い方

`suppress-eslint-errors` は [jscodeshift](https://github.com/facebook/jscodeshift) 用のコードモッドで、既存のコードに対してeslintを実行します。
見つかった各eslintエラーに対して、小さなスニペットを追加します：

```javascript
// TODO: Fix this the next time the file is edited.
// eslint-disable-next-line cool-new-rule
```
この方法で、新しいコードにルールの利点を取り入れつつ、大量の未処理分をすぐに処理する必要がなくなります。

## 使用法

`suppress-eslint-errors` にはラッパースクリプトが付属しており、追加のインストールなしで直接呼び出すことができます：


```bash
npx suppress-eslint-errors [jscodeshift options] PATH...
```
ラッパーは、トランスフォーマーおよび渡されたその他の引数とともに `jscodeshift` を呼び出します。  
ローカルディレクトリに `.gitignore` が検出されると、それを `--ignore-config` として指定します。  

`suppress-eslint-errors` はローカルにインストールされた `eslint` のコピーとともに使用する必要があります。  
見つからない場合は、早期に処理を中断します。  

_注:_ `jscodeshift` は `.gitignore` ファイルの処理に関していくつかのバグがあり、全ファイルを無視してしまうことがあります。  
このツールが `.gitignore` に問題のあるパターンを検出した場合、`--ignore-config` オプションはスキップされます。  

場合によっては、このコードモッドによって生成されたコードが望ましくないインデントを行うことがあります。  
コミット前に必ず使用しているコードフォーマットツールを再実行してください！  

## オプション  

**--message**: eslint-disable-next-line コメントの上に追加するコメントを設定します。  

**--rules**: 無効にする ESLint ルールIDのカンマ区切りリスト。指定すると、このセットにないルール違反はそのまま残ります。  

## 例  

カスタムコメントを使って `index.js` ファイル内の全てのエラーを抑制:  


```bash
npx suppress-eslint-errors ./index.js --message="TODO: Issue #123"
```

`src`ディレクトリ内の.tsおよび.tsxファイルで`eqeqeq`および`@typescript-eslint/no-explicit-any`ルールの違反を抑制する:

```bash
npx suppress-eslint-errors ./src --extensions=ts,tsx --parser=tsx --rules=eqeqeq,@typescript-eslint/no-explicit-any
```

## ニュアンス

ツール名が示す通り、これは eslint の _エラー_ のみを抑制します。
警告を抑制したい場合は、ツールを実行する前に eslint の設定を変更して警告をエラーに変えるか、`--rules` フラグでルールを指定してください。

## 完璧ですか？

決してそうではありません。遭遇したあらゆるエッジケースについての PR を歓迎します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---