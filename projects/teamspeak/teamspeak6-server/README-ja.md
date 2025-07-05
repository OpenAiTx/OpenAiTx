# TeamSpeak 6 サーバー - ベータリリース README

TeamSpeak 6 サーバーのベータリリースへようこそ！次世代の TeamSpeak をご体験いただけることを大変嬉しく思います。本書では、導入手順および現在のベータ版に関する重要な詳細についてご案内します。

本バージョンはベータ版であるため、一部の機能はまだ開発中であり、バグに遭遇する可能性があります。皆さまからのフィードバックはとても重要であり、より安定した完成版のリリースに向けて役立てさせていただきます。

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;TeamSpeak について</h2>

約25年間にわたり試行・検証を重ねてきた当社は、あらゆるニーズに対応するソリューションを提供しています。TeamSpeak は、ゲーミング、教育・トレーニング、企業内コミュニケーション、そしてご家族やご友人との連絡手段として理想的な音声通信を実現します。私たちの主な目標は、使いやすさ、高いセキュリティ基準、優れた音声品質、そして低いシステム・帯域幅使用量を兼ね備えたソリューションをお届けすることです。

## ℹ️ ベータ版の状況 & 既知の問題
**これはベータリリースです。主な目的は、多様なフィードバックを収集し、安定版リリース前に潜在的な問題を特定することです。**

**セルフホストサーバーファイル：** TeamSpeak 6 用の専用サーバーソフトウェアは現在も積極的に開発中であり、まだすべての機能が実装されているわけではありません。セルフホストサーバー向けの完全な TS6 体験の提供に向けて取り組んでいます。

**機能の不安定性：** 新機能の一部は不安定であったり、今後変更される可能性があります。

**フィードバックの重要性：** 皆さまの体験とご意見は、私たちにとって非常に貴重です。問題の報告やご提案は [コミュニティフォーラム](https://community.teamspeak.com/c/teamspeak-6-server/45) または [GitHub](https://github.com/teamspeak/teamspeak6-server/issues) でお寄せください。

**制限事項：** **TeamSpeak 3 サーバーライセンスは TeamSpeak 6 サーバーとは互換性がありません**のでご注意ください。また、現時点では**両バージョン間での移行パスも提供されていません**。

**プレビューライセンス：** 皆さまからのご意見を受け、評価期間中により柔軟にご利用いただくため、サーバーには**一時的な32スロットのプレビューライセンス**が付与されています。このライセンスは**2か月間のみ有効**ですのでご注意ください。

さらに、**現時点では TeamSpeak 6 用のより大きなライセンスを取得またはアップグレードすることはできません**。

今後、皆さまのニーズをよりよくサポートするためのソリューションの開発を続けてまいりますので、ご理解とご協力をお願い申し上げます。

## 👇 TS6 のはじめかた
TeamSpeak 6 クライアントの導入を始めるには、[ダウンロードページ](https://teamspeak.com/en/downloads/) にアクセスしてください。

セルフホストについての情報は、下記の簡易ガイドをご覧ください。最新情報や発表、TeamSpeak コミュニティとの交流には [コミュニティフォーラム](https://community.teamspeak.com/) や [Twitter](https://x.com/teamspeak) をぜひご利用ください。

セルフホストを希望しない、または簡単に TeamSpeak 6 を始めたい場合は、[TeamSpeak Communities](https://www.myteamspeak.com/communities) にて公式の TeamSpeak 6 サーバーをレンタルすることも可能です。

## ⚙️ 設定
### サーバーの設定方法は主に3つあります：

1. **コマンドライン引数** サーバー起動時に直接オプションを指定します（例：./tsserver --default-voice-port 9987）。一時的な変更やスクリプトでの利用に便利です。

2. **環境変数：** サーバー起動前に環境変数を設定します。Docker 利用時やコマンドラインを煩雑にしたくない場合に有効です。

3. **YAML 設定ファイル：** 永続的な設定には tsserver.yaml ファイルの利用を強く推奨します。--write-config-file フラグでデフォルト設定ファイルを生成できます。

制御可能な主な設定には、ネットワークポート（音声、ファイル転送）、データベース接続（SQLite および MariaDB をサポート）、IP バインディング、ログオプションなどがあります。

利用可能なオプションの一覧については、サーバーを `--help` フラグ付きで実行するか、[CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md) をご参照ください。

### バイナリによるサーバーの起動
Docker を利用しない場合は、OS 上で直接サーバーを実行できます。

<h2><img width="22" src="/icons/linux.svg">&nbsp;Linuxの場合：</h2>

サーバーバイナリに実行権限を付与します：
```sh
chmod +x tsserver
```

ライセンスに同意してサーバーをターミナルから起動します：

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Windowsの場合：</h2>

コマンドプロンプトまたは PowerShell を開き、サーバーファイルを展開したディレクトリに移動します。

ライセンスに同意してサーバー実行ファイルを起動します：
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Dockerでサーバーを実行（推奨）：</h2>
Docker は、TeamSpeak 6 サーバーを分離された管理しやすい環境で実行する最も簡単な方法です。

### 1. シンプルな docker run コマンド：

すぐに始めたい場合は、docker run コマンドを利用できます。

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. docker-compose.yaml を利用（永続運用向け）：
サーバーを継続的に運用する場合は、docker-compose.yaml ファイルの作成がベストプラクティスです：

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # 音声ポート
      - "30033:30033/tcp" # ファイル転送
      # - "10080:10080/tcp" # Web クエリ
    environment:
```
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 便利なリンク
[公式ウェブサイト](https://teamspeak.com/en/)<br>
[コミュニティフォーラム](https://community.teamspeak.com)<br>
[GitHub イシュー](https://github.com/teamspeak/teamspeak6-server/issues)<br>

皆様のご参加とフィードバックが TeamSpeak の未来を形作る手助けとなります！💙<br>
TeamSpeak 6 ベータプログラムにご参加いただき、またその進歩にご協力いただきありがとうございます！🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---