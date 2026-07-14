# mozcdict-ext

Convert external words into Mozc system dictionary

# 概要

本ツール群は当初 Mozc-UT (Mozcdic-UT) を失ったことによる損失を埋めるための「緊急避難」として使うために作られた。
現在はMozc-UTとは異なるアプローチによって、より快適な変換環境を構築することを目指している。

本ツール群はMozc外部のリソースからMozcシステム辞書を構築する。
これをMozcに組み込んでビルドすることにより、Mozcの語彙力を増加させることができる。

本ソフトウェアにそのようにして生成された辞書は *含まない* 。
また、 *Mozc本体も含まない* 。

もとは緊急回避的な「つなぎ」として作られたソフトウェアであったが、現在はMozc-UTとは少し異なる方針のもとで開発されている。

Mozcdic-UTとの大きな違いは以下になる

* オープンなプロジェクトであり、ライセンスがGPL v3である
* ソフトウェアは辞書生成のためのツールであり、生成された辞書ではない
* Mozcdic-UTは一般名詞のみを対象とするが、Mozcdict-EXTは品詞を制限しない
* web辞書コンバータ以外に人の手で編纂されたByHand辞書を持つ

# 使い方

## 生成の基本

各ディレクトリの `mkdict.zsh` または `mkdict.rb` は変換された辞書を生成し、標準出力に吐く。

この時以下の前提を満たす必要がある。

* スクリプトの実行はスクリプトがあるディレクトリをカレントディレクトリとして実行する
* 環境変数 `$MOZC_ID_FILE` にMozcの`id.def`ファイルのパスを入れておく必要がある

`id.def` ファイルはMozcの`src/data/dictionary_oss/id.def`に存在している。
このファイルは *本ソフトウェアには含まれない。*
ビルドにどのみちMozcが必要となるので、先にMozcのリポジトリを入手・更新しておくことが望ましい。

このようにして標準出力に吐かれた内容はMozcのシステム辞書として扱うことができ、システム辞書に組み込んでビルドすれば含めることができる。
おすすめは `src/data/dictionary_oss/dictionary09.txt` に追記することだ。

## 最後の整形

複数の辞書を生成した場合、複数の辞書にまたがる整形作業を加えるとより良い。

`.dev.utils/uniqword.rb` は`ARGF`から辞書を読み、品詞を含めて同一の語があれば除外してSTDOUTに出力する。
重複した語はSTDERRに吐かれる。

```bash
ruby uniqword.rb ~/dict/neologd.txt ~/dict/sudachi.txt > ~/dict/unified.txt
```

Mozcdic-UTと違い、固有名詞の生成を行うので、この作業はやったほうが良い。

## Archlinuxの場合

本プロジェクトとは別に `fcitx5-mozc-ext-neologd` というAURパッケージを用意している。

ARUからこのパッケージをインストールすることで外部辞書を含む形でMozcをビルドしてインストールすることができる。

なお、当該パッケージは本プロジェクトとは別のものである。

# 環境変数

## `$MOZC_ID_FILE`

必須。MOZCの `id.def` の所在を示す。

## `$WORDCLASS_ROUND`

厳密に一致する品詞がない場合に、よりおおまかな品詞に丸める。
`no`を指定するとこの処理を行わない。
次の辞書ツールで機能する。

* sudachi

## `$ERROR_ON_UNEXPECTED_CLASS`

品詞が不明な語がある場合にエラーを発生させる。
デフォルトでは発生させず、`yes`を指定した場合に発生させる。
次の辞書ツールで機能する。

* sudachi

# 実行オプション

## -e / --english

通常、このツールは「英語への変換」を除外する。
`-e` あるいは `--english` オプションをつけると、英語の変換結果を許容する。

## --english-proper

`--english`をつけておらず、`--english-proper`をつけた場合、英語は固有名詞である場合のみ許容する。

## -P / --no-proper

固有名詞を除外する。

## -w / --fullwidth-english (neologd, sudachi)

全角英数と半角カナへの変換を除外しない。

より正確には通常はOnigmoの正規表現 `/^[\p{Symbol}\p{In_CJK_Symbols_and_Punctuation}\p{Punctuation}\p{White_Space}\p{In_Halfwidth_and_Fullwidth_Forms}]+$/` にマッチする場合除外されるが、これによる除外を停止する。

## -W / --exclude-containing-fullwidth-english (byhand)

全角英数あるいは半角カナが含まれる場合は除外する。

## --fullwidth-english-proper (neologd, sudachi)

`--fullwidth-english`をつけていない場合に固有名詞のみ許容する。

## -s / --symbol

通常、このツールは変換時に支障をきたす「きごう」を変換する記号を除外するが、
`-s` あるいは `--symbol` オプションをつけると、強制的に生成に含める。

# オプションのデフォルト

コマンドラインオプションを使用せずにデフォルトのオプションを変更したい場合、設定ディレクトリ(`${XDG_CONFIG_HOME:-$HOME/.config}/mozcdict-ext`)の`config.yaml`によってデフォルトオプションを与えることができる。

例えば`--fullwidth-english`を常に有効にしたい場合は、次のようにする。

```yaml
fullwidth-english: true
```

# 除外

設定ディレクトリの`exclude.txt`ファイルを用いて、辞書への追加を回避したいパターンを指定することができる。

除外リストは、1行あたり1パターンで、読みパターンと原形パターンを1個以上の連続するホワイトスペースで区切ったものである。

パターンはそれぞれ`File.fnmatch`によってチェックされる。

例えば`ゃ`で始まる読みで変換されるすべての候補を除外したい場合は

```
ゃ*    *
```

とする。

# IssueとPR

何か問題があれば、Issueに書くか、Pull Requestを生成してほしい。

ただ、私は既にかなり手出ししている中で善意で本ソフトウェアを作っていることを理解してほしい。
つまり、IssueやPull Requestにまで手が回るかは分からない。
(少なくとも、なるべく対応したいとは思っている。)

# ByHand辞書への語彙追加と欠如している語彙の報告

最新のMozcと、本ソフトウェアのすべての辞書を有効にした状態で変換できない語があれば、[Mozcdict Ext 語彙欠如報告](https://mozc.chienomi.org)にて申請してほしい。

同ページから申請できないものについてはissueにて報告して欲しい。
また、具体的なMozc品詞を指定できる場合も、同ページではなくissueを立てて欲しい。

# ライセンスとパッケージング

このソフトウェアはGPL v3でライセンスされている。
ソフトウェアは「自由に」コピーして使って良い。

一方、このソフトウェアに何か問題があったり、あるいは不足があったりしたとしても私は一切の責任を負うことはできない。
誰もがよく知っている通り、ABSOLUTELY NO WARRANTYである。

本ソフトウェアが提供するのはあくまでも辞書生成ツールである。
しかし、恐らくディストリビューションとして配布したいとすれば、それによってビルドされたMozcだろう。
このようにしてビルドされたMozcは本ツールのライセンスとは全く関係がない。
なぜならば、そのMozcに本ツールは含まれないからだ。
そのようなパッケージは、Mozcと、外部辞書として使われたリソースのライセンス・規約に従うことになるだろう。
そのようにして配布が可能であることもまた、本ソフトウェアおよび私は保証しない。

# 現在の進捗

* NEologd - 機能する
* Sudachi - 一部の品詞についてのみ生成される (実験的・開発中)

# 注意事項

* 本ソフトウェアによって生成される辞書のライセンス、および正当性について本ソフトウェアは一切関知しない

# 特に貢献を求めているもの

sudachiの`clsmap.yaml` (Sudachiの品詞分類からMozcの品詞分類への変換)

`utils/dev-by-cls.rb` を使うと品詞ごとの具体的なワードに分類して`.dev.reference/sudachi-cls`以下に吐く(`.gitignore`で指定されている)ので、これを参考に品詞分類を固める作業が進行中である。

# Dependency

* Ruby >= 3.0
* Zsh
* xz(1)
* curl(1)
* Git (Submodules)

# 辞書について

## neologd

mecab-ipadic-NEologdをベースとした辞書である。

## sudachi

形態素解析ソフトウェアSudachiの辞書を流用したものである。

名詞以外についても利用する予定だが、現在停滞中である。

## byhand

neologd, sudachiを使っても変換できない、もしくは変換が困難な語について手動で編纂されている辞書である。

原則として国語小辞典に掲載されるような一般語のみを収録し、固有名詞は収録しない。

## Mozc Common User Dict

[Mozc Common User Dict](https://github.com/reasonset/mozc-common-user-dict)は本プロジェクトを補完する一般語のユーザー辞書である。

byhandへの収録が何らかの理由で難しいものはこちらに収録される。