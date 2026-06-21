# ARGOS — ベータ版
<img align="right" width="86" height="150" src="https://github.com/SOsintOps/Argos/blob/master/multimedia/images/scribblenauts-argos.png">

> **警告：ベータ版**
> このスクリプトはUbuntu 24.04 LTSおよびUbuntu Budgie 24.04 LTS向けに更新されています。
> 現在テスト中です。実運用前に必ずクリーンなVMで実行してください。
> 問題があればIssueを開いて報告してください。

Argosは、クリーンなUbuntu 24.04 LTS仮想マシンからオープンソースのOSINTワークステーションを自動構成します。

ベストプラクティスとして、各OSINT調査ごとに専用のVMを使用することが推奨されます。
このスクリプトは、Michael Bazzellの[Open Source Intelligence Techniques](https://inteltechniques.com/book1.html)で説明されている手法に従っています。

## 目次
- [要件](#requirements)
- [ツール](#tools)
- [インストール](#installation)
- [インストールログ](#installation-log)
- [今後の予定](#to-do)
- [リソース](#resources)
- [クレジット](#credits)
- [ライセンス](#licences)
- [バージョン履歴](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/VERSION_HISTORY.md)
- [OSINT解析ガイドライン](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/guidelines.md)
- [FAQ](https://raw.githubusercontent.com/SOsintOps/Argos/master/docs/faq.md)

---

## 要件

- Ubuntu **24.04 LTS** または **Ubuntu Budgie 24.04 LTS**（VMまたはワークステーション）
- 任意のLinuxユーザー名（以前の`osint`ユーザー限定の要件は削除されました）
- システム言語：**英語**
- インストール中に有効なインターネット接続
- **VirtualBox Guest Additionsが事前にインストール済み** — スクリプトはこれをインストールしません。`setup.sh`を実行する前にGuest Additionsをインストールして、クリップボード共有、ドラッグ＆ドロップ、フルスクリーン対応を有効にしてください。

> このスクリプトはVirtualBox向けに最適化されています。VMware Tools用のコードはコメント内にあります。

**テスト環境:**
- Ubuntu Budgie 24.04 LTS（VM）
- Ubuntu 24.04 LTS (VM)

**サポート終了:**
- Ubuntu 22.04 LTS（一部依存関係が非互換）
- Ubuntu 20.04 LTS

---

## ツール

### OSINT

| ツール | ステータス | 備考 |
|------|--------|-------|
| [Amass](https://github.com/owasp-amass/amass) | 稼働中 | サブドメイン列挙 |
| [Instaloader](https://instaloader.github.io/) | 稼働中 | Instagram OSINT |
| [Toutatis](https://github.com/megadose/toutatis) | 制限あり | InstagramセッションIDが必要 |
| [HTTrack](https://www.httrack.com/) | 稼働中 | ウェブクロール＆ミラーリング |
| [MediaInfo](https://mediaarea.net/en/MediaInfo) | 稼働中 | メディアメタデータ解析 |
| [ExifTool](https://exiftool.org/) | 稼働中 | ドキュメント・画像のメタデータ |
| [EyeWitness](https://github.com/FortyNorthSecurity/EyeWitness) | 稼働中 | ウェブサイトのスクリーンショット |
| [The Harvester](https://github.com/laramies/theHarvester) | 稼働中 | メール・ドメイン情報収集 |
| [Metagoofil](https://github.com/opsdisk/metagoofil) | 稼働中 | 公開ドキュメントのメタデータ |
| [recon-ng](https://github.com/lanmaster53/recon-ng) | 稼働中 | モジュール式OSINTフレームワーク |
| [Sherlock](https://github.com/sherlock-project/sherlock) | 稼働中 | ユーザー名検索 |
| [SpiderFoot](https://github.com/smicallef/spiderfoot) | 稼働中 | OSINT自動化 |
| [blackbird](https://github.com/p1ngul1n0/blackbird) | 稼働中 | 高度なユーザー名検索 |
| [holehe](https://github.com/megadose/holehe) | 稼働中 | メールOSINT |
| [maigret](https://github.com/soxoj/maigret) | 稼働中 | ユーザー名検索（Sherlockの高度フォーク） |
| [Maltego](https://www.maltego.com/) | 稼働中 | リンク解析（アカウント要） |
| [yt-dlp](https://github.com/yt-dlp/yt-dlp) | 稼働中 | 動画ダウンローダー（youtube-dlの代替） |

**削除済みツール（放棄または終了）:**
- ~~Instalooter~~: Instaloaderを使用してください
- ~~Sublist3r~~: Amassを使用してください
- ~~Photon~~: KatanaまたはGoSpiderを使用してください
- ~~youtube-dl~~: yt-dlpに置き換えられました
- ~~Moriarty-Project~~: PhoneInfogaを使用してください
- ~~Elasticsearch-Crawler~~: Shodan CLIを使用してください
- ~~Atom Editor~~（2022年12月終了）: VSCodiumに置き換えられました
### 一般ツール

| ツール | ステータス |
|------|--------|
| [VLC](https://www.videolan.org/vlc/) | アクティブ |
| [Google Earth Pro](https://www.google.com/earth/versions/#earth-pro) | アクティブ |
| [VSCodium](https://vscodium.com/) | アクティブ（Atomの代替） |
| [CherryTree](https://www.giuspen.com/cherrytree/) | アクティブ |
| [KeePassXC](https://keepassxc.org/) | アクティブ |
| [Kazam](https://launchpad.net/kazam) | アクティブ |
| [Audacity](https://www.audacityteam.org/) | アクティブ |
| [Tor Browser](https://www.torproject.org/) | アクティブ |
| [OpenShot](https://www.openshot.org/) | アクティブ |
| [Obsidian](https://obsidian.md/) | アクティブ（最新バージョンを動的に取得） |
| [Ripgrep](https://github.com/BurntSushi/ripgrep) | アクティブ |
| [Threat Intelligence Resources](https://github.com/pstirparo/threatintel-resources) | アクティブ |

---

## インストール

1. ターミナルを開きます。

2. Gitがまだインストールされていない場合はインストールします：

    ```bash
    sudo apt install -y git
    ```

3. リポジトリを `Downloads` ディレクトリにクローンします:
    ```bash
    git clone https://github.com/SOsintOps/Argos ~/Downloads/Argos
    ```

4. スクリプトを実行可能にする:
    ```bash
    chmod +x ~/Downloads/Argos/setup.sh
    ```

5. スクリプトを実行します:
    ```bash
    ~/Downloads/Argos/setup.sh
    ```

    > Firefoxは手動で閉じたり開いたりする必要はありません。スクリプトは、まだ作成されていない場合、自動的にFirefoxプロファイルを初期化します。

---

## インストールログ

スクリプトは自動的にダウンロードディレクトリにログファイルを生成します：

```
~/Downloads/argos_install_YYYYMMDD_HHMMSS.log
```
ログにはタイムスタンプ付きの完全なインストール出力が含まれています。エラーが発生した場合、正確な行番号がログに記録されます。

---

## やること

- Moriarty-Projectの代替としてPhoneInfogaを追加
- Photonの代替としてKatanaまたはGoSpiderを追加
- OSINT調査用のLibreOfficeレポートテンプレートを更新
- Ubuntu Budgie 24.04 LTS VMでのエンドツーエンドテストを完了
- holehe、maigretスタンドアロン、blackbirdスタンドアロンのショートカットを追加

---

## リソース

- [OSIntOpsウェブサイト](https://osintops.com/en/)
- [Argosプロジェクト紹介（イタリア語）](https://osintops.com/progetto-argos/)
- [OSIntデイリーニュース](https://t.me/Osintlatestnews)
- [Michael BazzellによるOpen Source Intelligence Techniques](https://inteltechniques.com/book1.html)

---

## クレジット

- オリジナルのOSINT_VM_Setupスクリプト作成者 Skykn0t
- スクリプト名提供者 [oh6hay](https://github.com/oh6hay)
- 壁紙スクリプト作成者 [pinkevilpimp](https://github.com/pinkevilpimp)

---

## ライセンス

リポジトリに含まれるライセンスファイルをご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-21

---