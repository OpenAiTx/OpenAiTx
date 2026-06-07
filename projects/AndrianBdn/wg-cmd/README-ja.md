# WG Commander 

別名 "wg-cmd" — WireGuard設定ファイル管理のためのTUI

<a href="https://github.com/andrianbdn/wg-cmd/releases/latest"><img src="https://img.shields.io/github/v/release/andrianbdn/wg-cmd" /></a>
<a href="./LICENSE"><img src="https://img.shields.io/github/license/andrianbdn/wg-cmd" /></a>
<a href="./go.mod"><img src="https://img.shields.io/github/go-mod/go-version/andrianbdn/wg-cmd" /></a>
[![Go Report Card](https://goreportcard.com/badge/github.com/andrianbdn/wg-cmd)](https://goreportcard.com/report/github.com/andrianbdn/wg-cmd)

![スクリーンショット](https://user-images.githubusercontent.com/994900/218720566-e5b3ab22-d7fc-4df7-a777-ad9b6280ada8.png)

# 機能
- ブラウザやHTTPポート不要 - ターミナル上で動作、SSH経由でも使用可能
- 使いやすいセットアップウィザード付き
- ピア管理のためのテキストベースユーザーインターフェース
- ターミナル内でQRコードを表示
- クリップボードへ設定をコピー（OSC 52対応）
- sysctl、systemd、NATを自動的に設定

## 現在の制限事項
- シンプルなクライアント・サーバー型WireGuardセットアップのみ対応
- 主にLinux向け（iptables、systemd、sysctlが利用可能であることが前提）— [Linux以外のOS](#other-os-besides-linux)セクション参照
- 既存のWireGuard設定は管理できない（同じホスト上で新規WireGuardインターフェースの作成は可能）

# インストール 

WireGuardとiptablesがインストールされていることを確認してください  
（Ubuntu / Debianでは`apt install wireguard-tools`、Rocky/Alma 9では`dnf install wireguard-tools iptables`）。  

curlを使ってダウンロードするには、以下を実行してください：
```shell
# for x86_64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-amd64 -o /usr/local/bin/wg-cmd

# for arm64 
curl -SL https://github.com/andrianbdn/wg-cmd/releases/download/v0.1.7/wg-cmd-0.1.7-linux-arm64 -o /usr/local/bin/wg-cmd
```
適切な権限を設定し、ツールを実行してください:  

```
chmod 755 /usr/local/bin/wg-cmd
wg-cmd
```
もし`/usr/local/bin`が$PATHに含まれていない場合は、  
`/usr/local/bin/wg-cmd`コマンドをフルパスで実行する必要があります。  

WG Commanderはsysctlの自動調整、systemdユニットの作成、/etc/wireguardへの書き込みのためにroot権限を必要とします。  

# 使用方法  

初回起動時、WG Commanderはセットアップウィザードを表示し、新しいWireGuardインターフェースを対話的に設定できます。  

2回目以降の起動（ウィザードが成功した場合）は、管理用のTUIを表示します。  

QRコードに関する注意：一部のデバイス（Android？）ではより高品質のQRコードが必要な場合があります。WG Commanderはターミナルウィンドウの解像度を大きく（フォントを小さく、ウィンドウを大きく）すると自動的に品質を向上させます。  

## 高度な使用法  

権限を変更し、sysctl/systemdを手動で設定すれば、非rootユーザーとしてWG Commanderを実行できます。  

WG Commanderは自身のUI設定を`~/.config/wg-cmd/wg-cmd.toml`に保持します。  

最も重要なオプションは次の通りです：


```toml
WireguardDir = "/etc/wireguard"
# directory for WireGuard configuration files 

DatabaseDir = "/etc/wireguard"
# directory for WG Commander database files (wgc-<interface-name>)
```
これらのオプションは、書き込みアクセス権のあるディレクトリを指すように変更できます。

### 特別なオプション

`wg-cmd new` を実行すると、新しいインターフェース構成のウィザードが開始されます。

`wg-cmd <wg-interface>` を実行すると、特定のインターフェースに切り替えます（事前に wg-cmd で作成されている必要があります）。

`wg-cmd <wg-interface> make` を実行すると、UIを表示せずにWireguard構成を生成します。

### 設定

WG Commander はディレクトリを「データベース」として使用します。  
インターフェース構成は /etc/wireguard/wgc-<interface-name> ディレクトリに保存されます。

設定は [TOML](https://toml.io) ファイル形式で保存されます。

ほとんどの設定キーは WireGuard のものに似ています。

#### サーバー構成 (0001-server.toml)  
この構成ファイルの一部のキーは、実際にはクライアント構成ファイルの生成に使用されます。

`ClientRoute` - クライアント構成の AllowedIPs

`ClientDNS` - 全クライアントの DNS 設定値

`ClientServerEndpoint` - クライアント構成のエンドポイント

`ClientPersistentKeepalive` - クライアント構成の PersistentKeepalive

`MTU` - サーバーとクライアントの MTU（0 — WireGuard に選択させる）

#### クライアント構成 (nnnn-%client%.toml)

`ClientRoute` - サーバー構成の `ClientRoute` を完全に上書きする

`AddServerRoute` - サーバー側でクライアントの AllowedIPs に追加のネットワークを加える（  
特定のクライアントのトラフィックを別のクライアントのネットワークへサーバー経由でルーティングしたい場合に便利）


`MTU` - このクライアントのためにサーバーのMTUを異なる値で上書きします。-1に設定すると、このWireGuardクライアント設定からMTUを省略します。

`DNS` - すべてのクライアントに対してサーバーの`ClientDNS`設定を上書きします。カンマ区切りのIPリストを指定してください。  
`no`または`none`に設定すると、このWireGuardクライアント設定からDNSを省略します。

クライアント設定ファイルには`PrivateKey`フィールドが含まれています。  
これを受け入れられない場合は、クライアントに設定（またはQRコード）をエクスポートした後にファイルから削除できます。

### Linux以外のOS

WG Commanderはprocfs、systemd、iptables、sysctlを使用するためLinuxでの動作を想定しています。  
しかし、純粋なGoで書かれているため、Goがサポートする任意のOSで動作するはずです。

- バイナリは自分でコンパイルする必要があります。  
- 起動時のLinux固有のチェックを無効にするには環境変数`WG_CMD_NO_DEPS`を1に設定してください。  
- 0001-server.tomlを編集し、PostUp4/PostUp6/PostDown4/PostDown6フィールドにOSコマンドを設定してください。  
- WireGuardの設定をリロードする必要があります。何か変更した場合は手動で、または/etc/wireguard/wg*.confファイルの変更を監視して自動的にリロードしてください。

他のOSのサポートを追加するPRは歓迎します。

### Dockerでの実行

可能ではありますが、WG CommanderをDockerで実行することは推奨されません。

セットアップウィザードは正常に動作しません。systemdユニットの作成やsysctlの変更が必要なためです。

### アンインストール

WG Commanderをアンインストールするには、/usr/local/bin/wg-cmdからバイナリを削除してください。  
また、/etc/wireguard/wgc-*および~/.config/wg-cmdディレクトリも削除できます。

systemdユニットを作成している場合は、手動で削除する必要があります。

以下はWG Commanderが管理するインターフェースwg7を削除する例です。  
（削除したいインターフェース名に変更してください）:





```sh
systemctl stop wgc-wg7.{path,service}
systemctl disable wgc-wg7.{path,service}
rm /etc/systemd/system/wgc-wg7.{path,service}
systemctl stop wg-quick@wg7.service
systemctl disable wg-quick@wg7.service
rm /etc/wireguard/wg7.conf
rm -Rf /etc/wireguard/wgc-wg7
```

# テスト済み
WG Commanderは、WireGuard、iptables、sysctl、procfsが利用可能なsystemdベースのLinux
ディストリビューション上で問題なく動作するはずです。

以下の環境でテスト済みです：
- Ubuntu 24.04（v0.1.7は2026年4月9日にテスト済み）
- Ubuntu 20.04
- Ubuntu 22.04
- Rocky Linux 9
- Debian 11
- Debian 12

# 貢献について

貢献は歓迎します。ガイドラインやAI開示ポリシーについては[CONTRIBUTING.md](https://raw.githubusercontent.com/AndrianBdn/wg-cmd/main/CONTRIBUTING.md)をご覧ください。

# 注意事項
WG Commanderには商業的な目的はありません。
本プロジェクトは
[MITライセンス](https://github.com/andrianbdn/wg-cmd/blob/master/LICENSE)の下でライセンスされています。

本プロジェクトはWireGuard®の作者とは無関係です。
WG CommanderプロジェクトはWireGuard®やWireGuard®コミュニティによって
承認、スポンサー、または提携されていません。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---