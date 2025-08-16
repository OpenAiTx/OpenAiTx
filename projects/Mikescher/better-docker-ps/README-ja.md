# ./dops - より良い `docker ps`
デフォルトの docker-ps の代替で、端末の幅内に収まるように非常に工夫しています。

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/main.png)

## 理由

デフォルトでは、私の `docker ps` の出力は非常に横幅が広く、各行が三行に折り返されます。
これは（明らかに）表形式の表示を壊し、すべてを混沌とさせます。  
（*特に、1つのコンテナに複数のポートマッピングがあり、それらがすべて1行で表示される場合はひどくなります*）
近い将来に改善された出力が得られる見込みはなさそうなので（[moby#7477](https://github.com/moby/moby/issues/7477)参照）、自分でドロップイン置換を作ることにしました。  

## 機能

 - docker-ps の通常のコマンドラインフラグ／オプションは *(ほぼ)* 同じように動作します。
 - 複数の値を持つデータ（複数のポートマッピング、複数のネットワークなど）を連結せずに複数行に書き出します。
 - STATE と STATUS 列に色を付けます（緑／黄／赤）。
 - 現在の端末幅に収まるまで、出力の列を自動的に削除します。
 - `--sort` 引数で出力をソートします。
 - `--watch` 引数で監視モードに入ります。

デフォルトの docker-ps からのその他の変更点：
 - デフォルトで引数なしのコンテナコマンドを表示します。
 - デフォルトで ImageName をレジストリのプレフィックスなしで表示し、ImageName と ImageTag を2つの列に分割します。
 - デフォルトの列セットに IP と NETWORK の列を追加しました（収まる場合）。
 - 新しいいくつかの列に対応しました（`--format` 経由）：  
   `{{.ImageName}`, `{{.ImageTag}`, `{{.Tag}`, `{{.ImageRegistry}`, `{{.Registry}`, `{{.ShortCommand}`, `{{.LabelKeys}`, `{{.IP}`                         
 - カラー出力の制御、使用するソケット、タイムゾーンや時刻フォーマットなどのオプションを追加しました（`./dops --help` を参照）。

## はじめに

### 一般的な Linux（例：Debian/Fedora/...）
 - [リリースページ](https://github.com/Mikescher/better-docker-ps/releases)から最新のバイナリをダウンロードし、PATH（例：/usr/local/bin）に置きます。
 - 以下のワンライナーを使うこともできます（これでどこでも `dops` コマンドが使えます）：
```
$> sudo wget "https://github.com/Mikescher/better-docker-ps/releases/latest/download/dops_linux-amd64-static" -O "/usr/local/bin/dops" && sudo chmod +x "/usr/local/bin/dops"
```
### ArchLinux
 - 代替として、AURパッケージのいずれかを使用することもできます（Arch Linuxの場合）:
    * https://aur.archlinux.org/packages/dops-bin （`dops` をPATHにインストールします）
    * https://aur.archlinux.org/packages/dops-git （`dops` をPATHにインストールします）
 - またはhomebrewパッケージを利用してください: 
    * `brew tap mikescher/tap && brew install dops`

### オプションの手順
 - docker ps コマンドを `dops` にエイリアス設定する（[以下のセクション](#usage-as-drop-in-replacement)を参照）

## スクリーンショット

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/fullsize.png)  
すべての（デフォルト）カラムが表示されている状態

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/default.png)  
中サイズのターミナルでの出力

&nbsp;

![](https://raw.githubusercontent.com/Mikescher/better-docker-ps/master/readme.d/small.png)  
小サイズのターミナルでの出力

&nbsp;

## 置き換え用としての使用方法

`.bashrc` / `.zshrc` にシェル関数を作成して、docker ps を完全に置き換えることができます...

~~~sh
docker() {
  case $1 in
    ps)
      shift
      command dops "$@"
      ;;
    *)

      command docker "$@";;
  esac
}
~~~

これはすべての `docker ps ...` の呼び出しを `dops ...` にエイリアスします（PATHにdopsバイナリがあることを確認してください）。

fish-shellを使用している場合は、（同様の）関数を作成する必要があります：

~~~fish
function docker
    if test -n "$argv[1]"
        switch $argv[1]
            case ps
                dops $argv[2..-1]
            case '*'
                command docker $argv[1..-1]
        end
    end
end
~~~

## 出力形式の変更

デフォルトではdopsは「インテリジェント」に動作し、端末の幅に最適な出力形式を探します。
現在の出力形式（＝テーブルの列）は[options.go](https://github.com/Mikescher/better-docker-ps/blob/master/cli/options.go)で定義されています。
端末幅に収まる最初の形式が使用されます。

しかし、`--format`パラメータを指定することで上書きも可能です。複数の`--format`パラメータを指定した場合は、端末幅に収まる最初のものが使用されます（デフォルトのロジックと同じです…）。

通常はシンプルなカラム、すなわち `{{.Status}}` のみがサポートされています。  
しかし、完全なgolangテンプレート構文（例：`{{ printf "%.15s" .Command }}`）も使用できます。
この場合、カラムヘッダーをコロンでプレフィックスして指定すると便利です（例：`SHORTENED NAME:{{ printf "%.10s" (join .Names ";") }}`）。

これらのテンプレートで定義されている関数（および[標準のgo関数](https://pkg.go.dev/text/template)）は以下の通りです：
 - `join`: strings.Join
 - `array_last`: v\[-1\]
 - `array_slice`: v\[a..b\] 
 - `in_array`: v1.contains(v2)
 - `json`: json.Marshal(v)
 - `json_indent`: json.MarshalIndent(v, "", "  ")
 - `json_pretty`:  json.Indent(v, "", "  ")
 - `coalesce`: v1 ?? v2
 - `to_string`: fmt.Sprintf("%v", v)
 - `deref`: *v
 - `now`: time.Now()
 - `uniqid`: UUID

Examples:
~~~~
$ ./dops --format "table {{.ID}}"
$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"

$ ./dops --format "idlist"

$ ./dops --format "table {{.ID}}\\t{{.Names}}\\t{{.State}}"  --format "table {{.ID}}\\t{{.Names}}" --format "table {{.ID}}"

$ ./dops --format "ID: {{.ID}}; Name: {{.Names}}"

$ ./dops -aq

$ ./dops --sort "IP" --sort-direction "ASC"

$ ./dops --format "table {{.ID}}\\tCMD:{{ printf \"%.15s\" .Command }}"
$ ./dops --format "table {{.ID}}\\tNAME:{{ printf \"%.10s\" (join .Names \";\") }}"

~~~~

## 永続的な設定

一部またはほとんどのオプションは設定ファイルで構成することもできます。  
TOML形式のファイルを`$HOME/.config/dops.conf` または `$XDG_CONFIG_HOME/dops.conf` に配置してください。

サポートされているキーは以下の通りです:
 - verbose
 - silent
 - timezone
 - timeformat
 - timeformat-header
 - color
 - ソケット
 - すべて
 - サイズ
 - フィルター（= 文字列配列）
 - フォーマット（= 文字列配列）
 - 最後
 - 最新
 - 切り詰め
 - ヘッダー（= true / false / simple）
 - ソート（= 文字列配列）
 - ソート方向（= 文字列配列）

例：
```toml
verbose = 0

timezone = "Europe/Berlin"

format = [
   "table {{.ID}}\t{{.Names}}\t{{.State}}\t{{.Status}}",
   "table {{.ID}}\t{{.Names}}\t{{.State}}",
   "table {{.ID}}\t{{.Names}}",
   "table {{.ID}}",
]

header = "simple"
```
## マニュアル

`./dops --help` の出力:

~~~~~~
better-docker-ps

使用法:
  dops [OPTIONS]                     Dockerコンテナの一覧表示

オプション（デフォルト）:
  -h, --help                         この画面を表示する。
  --version                          バージョンを表示する。
  --all , -a                         すべてのコンテナを表示（デフォルトは実行中のみ）
  --filter <ftr>, -f <ftr>           条件に基づいて出力をフィルタリングする
  --format <fmt>                     Goテンプレートを使ってコンテナを整形表示する
  --last , -n                        最後に作成されたn個のコンテナを表示（すべての状態を含む）
  --latest , -l                      最新に作成されたコンテナを表示（すべての状態を含む）
  --no-trunc                         出力を切り詰めない（例：コンテナID、Sha256イメージ参照、コマンドライン）
  --quiet , -q                       コンテナIDのみを表示
  --size , -s                        ファイルサイズの合計を表示

オプション（追加 | `docker ps`には存在しない）:
  --silent                           出力を一切表示しない
  --timezone                         日付出力のタイムゾーンを指定する
  --color <true|false>               ターミナルのカラー出力を有効/無効にする
  --no-color                         ターミナルのカラー出力を無効にする
  --socket <filepath>                Dockerソケットの場所を指定（デフォルト：`auto` - docker cliでソケットを決定）
  --timeformat <go-time-fmt>         日時出力フォーマットを指定（golang構文）
  --no-header                        テーブルのヘッダーを表示しない
  --simple-header                    ヘッダー下の線を表示しない
  --format <fmt>                     複数のフォーマットを指定でき、端末幅に合う最初のものが使用される
  --sort <col>                       特定の列で出力をソート、--formatの識別子を使用、テーブル形式でのみ有効
  --sort-direction <ASC|DESC>        ソート方向、--sortと組み合わせてのみ有効
  --watch <interval>, -w <interval>  出力を定期的に自動更新（間隔は任意、デフォルト：2秒）

利用可能な --format キー（デフォルト）:
  {{.ID}}                            コンテナID
  {{.Image}}                         イメージID

  {{.Command}}                       引用されたコマンド
  {{.CreatedAt}}                     コンテナが作成された日時。
  {{.RunningFor}}                    コンテナが起動してからの経過時間。
  {{.Ports}}                         公開されたポート。([!] docker CLIとは異なり、これは公開されたポートのみ)
  {{.State}}                         コンテナの状態
  {{.Status}}                        詳細付きのコンテナの状態
  {{.Size}}                          コンテナのディスクサイズ。
  {{.Names}}                         コンテナ名。
  {{.Labels}}                        コンテナに割り当てられたすべてのラベル。
  {{.Label}}                         [!] サポートされていません
  {{.Mounts}}                        このコンテナにマウントされたボリュームの名前。
  {{.Networks}}                      このコンテナに接続されたネットワークの名前。

利用可能な --format キー（追加 | `docker ps`には存在しません）:
  {{.ImageName}}                     イメージID（タグおよびレジストリなし）
  {{.ImageTag}}, {{.Tag}}            イメージタグ
  {{.ImageRegistry}}, {{.Registry}}  イメージレジストリ
  {{.ShortCommand}}                  引数なしのコマンド
  {{.LabelKeys}}                     コンテナに割り当てられたすべてのラベル（キーのみ）
  {{.ShortPublishedPorts}}           公開されたポート、{{.Ports}}より短い出力
  {{.LongPublishedPorts}}            公開されたポート、IPを含む完全な出力
  {{.ExposedPorts}}                  エクスポートされたポート
  {{.PublishedPorts}}                公開されたポート
  {{.NotPublishedPorts}}             エクスポートされているが公開されていないポート
  {{.PublicPorts}}                   公開されたポートのうちパブリックな部分のみ
  {{.IP}}                            内部IPアドレス
~~~~~~


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-16

---