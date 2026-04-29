# Amnezia-WG 2.0（v1.88.2+）対応 Tailscale

[![GitHub Release](https://img.shields.io/github/v/release/LiuTangLei/tailscale)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![Platform Support](https://img.shields.io/badge/platform-Linux%20|%20macOS%20|%20Windows%20|%20OpenWrt%20|%20Android-blue)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![License](https://img.shields.io/badge/license-BSD--3--Clause-green)](LICENSE)

Amnezia-WG 2.0による難読化を備えた強化版Tailscaleクライアント：ジャンクトラフィック、プロトコル署名、ハンドシェイク/ヘッダーの偽装によりDPIやブロックに対抗します。AWG設定を有効にするまでは標準のTailscaleとして動作します。

対応言語: [English](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/README.md) | [中文](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-zh.md) | [فارسی](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-fa.md) | [Русский](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-ru.md)

AWG v1.5のドキュメントは [doc/README-awg-v1.5.md](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-awg-v1.5.md) を参照してください。

## インストール

| プラットフォーム | コマンド / 操作 |
| --- | --- |
| Linux | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh \| bash` |
| macOS* | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh \| bash` |
| Windows (管理者PowerShell) | `iwr -useb https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1 \| iex` |
| OpenWrt | [OpenWrtインストール](#openwrt-installation) を参照 |
| Android | [releases](https://github.com/LiuTangLei/tailscale-android/releases) からAPKをダウンロード |

- macOS: インストーラーはCLI専用の`tailscaled`を使用します。公式のTailscale.appが検出された場合は、競合を避けるために削除を促されます。
- Androidは現状AWG設定同期のみ対応しています。アプリ内のSyncボタンを使用してください。

![Android AWG Sync Example](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/sync1.jpg)

## Docker Compose

このリポジトリにはAWG対応の`tailscaled`を実行するための`docker-compose.yml`が含まれています。

- 状態はcomposeファイルと同じ階層の`./tailscale-state`に保存されるため、ノード状態やAWG設定はコンテナの再起動やホストの再起動後も保持されます。
- 旧バインドマウント `/var/lib/tailscale:/var/lib/tailscale` からアップグレードする場合は、既存の状態を先にコピーしてください：

```bash
docker compose down
cp -a /var/lib/tailscale ./tailscale-state
# update docker-compose.yml
docker compose up -d
```
基本的な手順：

1. サービスを起動する: `docker compose up -d`
2. コンテナ内で認証する: `docker compose exec tailscaled tailscale up`
3. 同様にAWGコマンドを実行する。例: `docker compose exec tailscaled tailscale awg sync`

Headscaleを使用する場合は、`tailscale up` に `--login-server https://your-headscale-domain` を追加してください。

オプションのホストエイリアス：


```bash
alias tailscale='docker exec -it tailscaled tailscale'
```

そのエイリアスは現在のシェルにのみ適用されます。再起動や新しいターミナルセッション後も保持するには、`~/.bashrc` または `~/.zshrc` に追加し、シェルをリロードしてください。

## OpenWrt インストール

デフォルトコマンド:

```bash
wget -O /usr/bin/install.sh https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install_en.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

GitHubアクセス制限されたリージョン向けのミラーコマンド：

```bash
wget -O /usr/bin/install.sh https://ghfast.top/https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```
このスクリプトは[GuNanOvO/openwrt-tailscale](https://github.com/GuNanOvO/openwrt-tailscale)からフォークされています。

## ミラー

GitHubが遅いまたはブロックされている場合、`https://your-mirror-site.com`のようなプレフィックスミラーをセルフホストできます：


```bash
# Linux
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh | bash -s -- --mirror https://your-mirror-site.com

# macOS
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh | bash -s -- --mirror https://your-mirror-site.com
```

```powershell
# Windows
$scriptContent = (iwr -useb https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1).Content; $scriptBlock = [scriptblock]::Create($scriptContent); & $scriptBlock -MirrorPrefix 'https://your-mirror-site.com/'
```

PowerShellが実行をブロックする場合は、`Set-ExecutionPolicy RemoteSigned` または `Bypass -Scope Process` を使用してください。

## クイックスタート

ヒント：`tailscale amnezia-wg` は `tailscale awg` と同じです。

1. ログイン：

```bash
# Official control server
tailscale up

# Headscale
tailscale up --login-server https://your-headscale-domain
```

2. AWGの設定:

```bash
tailscale awg set
```

自動生成プロンプトで Enter を押すと、`i1`～`i5` を除くすべての推奨値が生成されます。

3. 他のデバイスで、すでに設定済みのノードから同じ AWG 設定を同期します：

- デスクトップ：他のデバイスで `tailscale awg sync` を実行
- Android：他のデバイスのアプリで同期をタップ

4. 必要に応じて確認またはリセットします：

```bash
tailscale awg get
tailscale awg reset
```
## 設定プリセット

| 目的 | 例 | 互換性 |
| --- | --- | --- |
| 基本ジャンクトラフィック | `tailscale awg set '{"jc":4,"jmin":64,"jmax":256}'` | 標準のTailscaleピアで動作 |
| ジャンクトラフィック＋署名付き | `tailscale awg set '{"jc":2,"jmin":64,"jmax":128,"i1":"<b 0x40><r 12>"}'` | 標準のTailscaleピアで動作 |
| ハンドシェイク偽装 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0}'` | すべてのAWGノードが同じ`s1`〜`s4`を使用 |
| 完全偽装 | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000}}'` | すべてのAWGノードが同じ`s1`〜`s4`と`h1`〜`h4`を使用 |
| 完全偽装＋署名付き | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000},"i1":"<b 0xc0><r 32><c><t>"}'` | `i1`〜`i5`はノードごとに異なってよい；`s1`〜`s4`と`h1`〜`h4`は一致必須 |

## パラメータリファレンス

- `jc` と `jmin`、`jmax`：ジャンクパケット数とサイズ範囲。
- `i1`〜`i5`：任意のCPS（カスタムプロトコル署名）チェーンで、カスタムプロトコル模倣パケット用。
- `s1`〜`s4`：ハンドシェイクのパディングまたはプレフィックスフィールド；すべてのAWGノードで一致必須。
- `h1`〜`h4`：`{"min": 最小値, "max": 最大値}`形式のヘッダーフィールド範囲；4つすべて設定するか全く設定しないか。範囲は重複しないこと、かつすべてのAWGノードで一致必須。

非常に大きなジャンク数や長い署名チェーンは遅延と帯域幅使用量を増加させます。

## プラットフォームサポート

| プラットフォーム | アーキテクチャ | ステータス |
| --- | --- | --- |
| Linux | x86_64, ARM64 | ✅ フル対応 |
| macOS | Intel, Apple Silicon | ✅ フル対応 |
| Windows | x86_64, ARM64 | ✅ インストーラー |
| OpenWrt | 各種 | ✅ スクリプト |
| Android | ARM64, ARM | ✅ APK（同期専用AWG） |

## 上級者向け：CPSプロトコル署名

CPSはカスタムプロトコル署名（Custom Protocol Signature）の略です。任意のプロトコルヘッダーを模倣可能なカスタム難読化パケットを組み立てることができ、特定のプロトコルに限定されません。

CPS形式：


```text
i{n} = <tag1><tag2>...<tagN>
```

タグ:

- `<b 0xHEX>`: 静的バイト
- `<r N>`: セキュアランダムバイト
- `<c>`: カウンター
- `<t>`: タイムスタンプ

例:

```text
i1 = <b 0xf6ab3267fa><c><b 0xf6ab><t><r 10>
```

もし `i1` が未設定の場合、`i2` から `i5` はスキップされます。

## トラブルシューティング

インストールを確認してください：

```bash
tailscale version
tailscale awg get
```
接続が切断された場合は、標準のWireGuardにリセットし、シンプルなプリセットから開始してください：


```bash
tailscale awg reset
tailscale awg set '{"jc":2,"jmin":64,"jmax":128}'
sudo journalctl -u tailscaled -f
```

Windows PowerShell では、JSON のエスケープ問題を避けるために対話型セットアップを推奨します:

```powershell
tailscale awg set
```
## Links & Support

- リリース: <https://github.com/LiuTangLei/tailscale/releases>
- Android APK: <https://github.com/LiuTangLei/tailscale-android/releases>
- インストーラーの問題: <https://github.com/LiuTangLei/tailscale-awg-installer/issues>
- Amnezia-WG ドキュメント: <https://docs.amnezia.org/documentation/instructions/new-amneziawg-selfhosted/#how-to-extract-a-protocol-signature-for-amneziawg-manually>

## License

BSD 3-Clause License、upstream Tailscale と同じです。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---