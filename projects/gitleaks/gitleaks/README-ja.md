
#### Dir

`dir`（エイリアスには `files` や `directory` も含まれます）コマンドを使用すると、ディレクトリやファイルをスキャンできます。例：`gitleaks dir -v path_to_directory_or_file`  
位置引数としてターゲットが指定されていない場合、gitleaks はカレントワーキングディレクトリをスキャンします。

#### Stdin

`stdin` コマンドを使って、データを gitleaks にストリームすることも可能です。例：`cat some_file | gitleaks -v stdin`

### ベースラインの作成

大規模なリポジトリや履歴の長いリポジトリをスキャンする際には、ベースラインを使用するのが便利です。ベースラインを使用すると、gitleaks はベースラインに存在する古い検出結果を無視します。ベースラインは任意の gitleaks レポートを使用できます。gitleaks レポートを作成するには、`--report-path` パラメータを指定して gitleaks を実行します。

```
gitleaks git --report-path gitleaks-report.json # このコマンドで gitleaks-report.json というファイルにレポートが保存されます
```

ベースラインを作成したら、再度 detect コマンドを実行する際に適用できます：

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

--baseline-path パラメータを指定して detect コマンドを実行すると、レポート出力（findings.json）には新たな問題のみが含まれます。

## Pre-Commit フック

`pre-commit.py` のサンプルスクリプトを `.git/hooks/` ディレクトリにコピーすることで、Gitleaks を pre-commit フックとして実行できます。

## 設定ファイルの読み込み

優先順位の順序は以下の通りです：

1. `--config/-c` オプション:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. 環境変数 `GITLEAKS_CONFIG` にファイルパスを指定:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. 環境変数 `GITLEAKS_CONFIG_TOML` にファイル内容を指定:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. ターゲットパス内の `.gitleaks.toml` ファイル:
      ```bash
      gitleaks git .
      ```

上記の4つのオプションがいずれも使用されていない場合、gitleaks はデフォルトの設定を使用します。

## 設定

Gitleaks は独自のシークレット検出ルールを書くための設定フォーマットを提供します：

```toml
# gitleaks 設定ファイルのタイトル
title = "Custom Gitleaks configuration"

# カスタム設定には基本的に2つの方法があります:
#
# 1. 独自の設定を定義し、デフォルトルールは適用しない
#
#    例：デフォルト設定を出発点として利用
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. 設定を拡張し、ルールを上書きまたは追加する
#
#    設定を拡張する場合、拡張されたルールがデフォルトルールよりも優先されます。
#    つまり、拡張設定とデフォルト設定の両方に同じルールが存在する場合、拡張設定のルールやその属性がデフォルトルールを上書きします。
#    また、拡張設定を使用する場合、2段階まで複数の設定ファイルを連鎖させることができます。Allowlist 配列は追加され、重複を含むことができます。

# useDefault と path は同時に使用できません。どちらか一方を選択してください。
[extend]
# useDefault はバイナリに組み込まれているデフォルトの gitleaks 設定を拡張します
# 最新バージョンは以下にあります：
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# または、拡張元となる設定ファイルへのパスを指定することもできます。
# パスは gitleaks を起動した場所からの相対パスとなります。
# path = "common_config.toml"
# 継承したくないルールがある場合は、ここで指定できます。
disabledRules = [ "generic-api-key"]

# シークレット検出方法を定義する情報を含むテーブルの配列
[[rules]]
# このルールの一意な識別子
id = "awesome-rule-1"

# ルールの簡単な説明
description = "awesome rule 1"

# シークレット検出に使う Golang の正規表現。Golang の正規表現エンジンは lookahead をサポートしていない点に注意。
regex = '''one-go-style-regex-for-this-rule'''

# 正規表現マッチからシークレットを抽出する際に使われる整数値。entropy が設定されている場合、このグループのエントロピーが確認されます。
secretGroup = 3

# 正規表現グループがシークレットと見なされるための最小シャノンエントロピー値を表す浮動小数点数
entropy = 3.5

# パスにマッチさせる Golang 正規表現。このルール単独でも、`regex` エントリと組み合わせても利用できます。
path = '''a-file-path-regex'''

# キーワードは事前の正規表現チェックフィルタリングに使われます。キーワードを含むルールは、スキャン対象のコンテンツ内にキーワードが存在するかを高速に比較チェックします。理想的には、これらの値は識別子の一部か、そのルールの正規表現に特有のユニークな文字列であるべきです（v8.6.0 で導入）。
keywords = [
  "auth",
  "password",
  "token",
]

# メタデータやレポート用途で使われる文字列配列
tags = ["tag","another tag"]

    # ⚠️ v8.21.0 で `[rules.allowlist]` は `[[rules.allowlists]]` に置き換えられました。
    # この変更は後方互換性があります：`[rules.allowlist]` も引き続き動作します。
    #
    # ルールごとに複数の allowlist を定義して、誤検出を減らすことができます。
    # _いずれかの_ `[[rules.allowlists]]` がマッチすれば、検出結果は無視されます。
    [[rules.allowlists]]
    description = "ignore commit A"
    # 複数の条件を定義した場合、デフォルトの条件は "OR" です。
    # 例：|commits| または |paths| または |stopwords| のいずれかにマッチします。
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # 注意：stopwords は抽出されたシークレットを対象とし、正規表現全体のマッチではありません（stopwords は 8.8.0 で導入）。
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # "AND" 条件を使うと、すべての条件が一致した場合のみマッチします。
    # 例：|regexes| および |paths| の両方が満たされた場合にマッチします。
    condition = "AND"
    # 注意：|regexes| のデフォルトは検出結果の _Secret_ をチェックします。
    # 許容される値は "secret"（デフォルト）、"match"、"line" です。
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# デフォルト設定の特定のルールを拡張することもできます。例：gitlab-pat
# GitLab インスタンスでカスタムトークンプレフィックスを定義している場合など
[[rules]]
id = "gitlab-pat"
# デフォルトルールから他の属性はすべて継承されます

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ v8.25.0 で `[allowlist]` は `[[allowlists]]` に置き換えられました。
#
# グローバル allowlists はルール固有の allowlists よりも優先度が高くなります。
# 下記の `commits` フィールドにリストされているコミットが検出された場合、そのコミットはスキップされ、そのコミットに対してはシークレットが検出されません。同様のロジックが regexes や paths にも適用されます。
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# 注意：（グローバル）regexTarget のデフォルトは検出結果の _Secret_ をチェックします。
# 許容値は "match" と "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# 注意：stopwords は抽出されたシークレットを対象とし、正規表現全体のマッチではありません（stopwords は 8.8.0 で導入）。
stopwords = [
  '''client''',
```markdown
'''endpoint''',
]

# ⚠️ v8.25.0 では、`[[allowlists]]` に新しいフィールド |targetRules| が追加されました。
#
# 共通の許可リストは一度定義し、複数のルールに |targetRules| を使って割り当てることができます。
# これは指定されたルールでのみ実行され、グローバルには実行されません。
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "テスト資産がいくつかのルールで誤検出を引き起こします。"
paths = ['''tests/expected/._\.json$''']
```

例についてはデフォルトの [gitleaks config](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) を参照するか、デフォルト設定に貢献したい場合は [contributing guidelines](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) に従ってください。さらに、[この gitleaks ブログ記事](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) では高度な設定について解説しています。

### 追加設定

#### gitleaks:allow

gitleaks が検知することが分かっているテスト用シークレットをコミットする場合、その行に `gitleaks:allow` コメントを追加することで
gitleaks にそのシークレットを無視させることができます。例:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

特定の検出結果を無視するには、リポジトリのルートに `.gitleaksignore` ファイルを作成します。v8.10.0 から Gitleaks のレポートに `Fingerprint` 値が追加されました。各リークや検出には、秘密を一意に識別するフィンガープリントがあります。このフィンガープリントを `.gitleaksignore` ファイルに追加すると、その特定の秘密を無視できます。例は Gitleaks の [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) を参照してください。注意：この機能は実験的であり、将来的に変更される可能性があります。

#### デコード

時には秘密情報がエンコードされており、正規表現だけでは検出が困難な場合があります。
gitleaks にエンコードされたテキストを自動的に検出・デコードさせることができます。`--max-decode-depth` フラグでこの機能を有効にします（デフォルト値 "0" では無効です）。

デコードしたテキストにもさらにエンコードテキストが含まれる場合があるため、再帰的なデコードがサポートされています。`--max-decode-depth` フラグで再帰の上限を設定します。新たなエンコードテキストが見つからなくなるまで再帰を続けるため、非常に大きな最大深度を指定しても、その回数だけ処理が行われるわけではありません。必要な回数だけデコード処理が行われます。全体として、デコードによるスキャン時間の増加は最小限です。

エンコードテキストの検出結果は、通常の検出結果と以下の点で異なります：

- ロケーションはエンコードテキストの範囲を指します
  - ルールがエンコードテキスト外でマッチした場合、範囲はそれも含むように調整されます
- マッチおよびシークレットはデコード値を含みます
- `decoded:<encoding>` および `decode-depth:<depth>` の 2 つのタグが追加されます

現在サポートされているエンコード:

- **percent** - 任意の印字可能な ASCII パーセントエンコード値
- **hex** - 32 文字以上の印字可能な ASCII 16進数エンコード値
- **base64** - 16 文字以上の印字可能な ASCII base64 エンコード値

#### アーカイブスキャン

時には秘密情報が zip ファイルや tarball などのアーカイブファイル内に格納されていることがあり、発見が困難な場合があります。gitleaks にアーカイブの内容を自動的に抽出してスキャンさせることができます。`--max-archive-depth` フラグでこの機能を有効にします（`dir` および `git` スキャンタイプの両方で利用可能）。デフォルト値 "0" では無効です。

アーカイブ内にさらにアーカイブが含まれる場合があるため、再帰的なスキャンがサポートされています。`--max-archive-depth` フラグで再帰の上限を設定します。新たなアーカイブがなくなるまで再帰を続けますので、非常に大きな最大深度を指定しても、その深さまで必ずスキャンされるわけではありません。必要な深さまでだけ処理が行われます。

アーカイブ内で検出された秘密情報の結果には、アーカイブ内のファイルまでのパスが含まれます。内部パスは `!` で区切られます。

検出例（簡略）:

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

これは `testdata/archives/nested.tar.gz` 内の `archives/files.tar` 内の `files/.env.prod.` の4行目で秘密情報が検出されたことを意味します。

現在サポートされているフォーマット：

[compression](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats)
および [archive](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats)
の各フォーマットは mholt の [archives パッケージ](https://github.com/mholt/archives) に準拠しています。

#### レポート出力

Gitleaks は複数のレポートフォーマットに対応しています：[`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json)、[`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1)、[`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml)、[`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif)。

これらのフォーマットが要件に合わない場合は、[Go の `text/template` .tmpl ファイル](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) と `--report-template` フラグで独自のレポートフォーマットを作成できます。テンプレートは [`Masterminds/sprig` テンプレートライブラリの拡張機能](https://masterminds.github.io/sprig/)も利用できます。

例えば、次のテンプレートはカスタム JSON 出力を提供します:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

使い方:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## スポンサー

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>

## 終了コード

リークが検出された際の終了コードは --exit-code フラグで常に設定できます。デフォルトの終了コードは以下の通りです:

```
0 - リークなし
1 - リークまたはエラーを検出
126 - 不明なフラグ
```
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---