# Soulseek CLI

[![Build Status](https://travis-ci.org/aeyoll/soulseek-cli.svg?branch=develop)](https://travis-ci.org/aeyoll/soulseek-cli)

SoulseekのCLIクライアント。

Requirements
---

NodeJS >= 20

Installation
---

```sh
npm install -g soulseek-cli
```
### Linuxの場合

soulseek-cliの依存関係の一つである([node-keytar](https://github.com/atom/node-keytar))はlibsecretを使用しているため、`npm install`を実行する前にインストールする必要があります。

ディストリビューションによって、以下のコマンドを実行してください:

- Debian/Ubuntu: `sudo apt-get install libsecret-1-dev`
- Red Hat系: `sudo yum install libsecret-devel`
- Arch Linux: `sudo pacman -S libsecret`

### ヘッドレスLinuxの場合

Linux上で、[node-keytar](https://github.com/atom/node-keytar)はLinux SecretService APIを使用します。X11サーバーが利用できないLinuxシステムでもSecretServiceバックエンドを使用することが可能です（D-Busのみが必要です）。この場合、以下のようにします（例はDebian環境です）:

#### 依存関係のインストール


```sh
apt install gnome-keyring --no-install-recommends # Install the GNOME Keyring daemon. "no-install-recommends" prevents X11 install
```

#### 使用法

```sh
dbus-run-session -- $SHELL # Start a D-Bus session
echo 'root' | /usr/bin/gnome-keyring-daemon -r -d --unlock # Unlock GNOME Keyring
soulseek ... # Use soulseek-cli normally
```

コマンド
---

### ログイン

検索を行う前に、ログインする必要があります。

使用法:
```
soulseek login
```

SoulseekのログインIDとパスワードの入力を求められます。認証情報はシステムのキーチェーンに保存され、暗号化されます。

または、環境変数を設定してログインすることも可能です：

```sh
export SOULSEEK_ACCOUNT=youraccount
export SOULSEEK_PASSWORD=yourpassword
soulseek download "..."
```

### ダウンロード

必要なクエリでダウンロードします。

使用法：
```
soulseek download|d [options] [query...]
```

:warning: このコマンドはバージョン0.1.0以前では `search` と呼ばれていました。

オプション:

| オプション                 | 説明                                                                        |
| ------------------------- | ----------------------------------------------------------------------------- |
| -d --destination <folder> | ダウンロード先のフォルダー                                                    |
| -q --quality <quality>    | 指定した品質のmp3のみを表示                                                  |
| -m --mode <mode>          | 取得するファイルの種類をフィルタリング（利用可能: "mp3", "flac", デフォルト: "mp3"） |
| -h --help                 | コマンドのヘルプを表示                                                      |

例:

```sh
soulseek download "Your query" # Download in the current folder
soulseek download "Your query" --destination=/path/to/directory # Download in a defined folder (relative or absolute)
soulseek download "Your query" --quality=320 # Filter by quality
soulseek download "Your query" --mode=flac # Filter by file type
```

### クエリ

必要なクエリで検索しますが、何もダウンロードしません。結果が見つかった場合、戻り値は0になります。そうでなければ、
戻り値は1になります（スクリプト作成に便利です）

使用法：

```
soulseek query|q [options] [query...]
```

オプション:

| オプション              | 説明                                                                        |
| ---------------------- | ---------------------------------------------------------------------------- |
| -q --quality <quality> | 指定した品質のmp3のみを表示                                                |
| -m --mode <mode>       | 取得したいファイルの種類をフィルタリング（利用可能: "mp3", "flac", デフォルト: "mp3"） |
| -h --help              | コマンドのヘルプを表示                                                     |



貢献
---

[CONTRIBUTING.md](https://raw.githubusercontent.com/aeyoll/soulseek-cli/main/CONTRIBUTING.md) を参照してください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-27

---