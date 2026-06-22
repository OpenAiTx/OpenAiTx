# Fansly スクレイパー

> [!IMPORTANT]
> **プロジェクト状況更新**
>
> 最近の健康問題により、このプロジェクトは私の生活の中で非常に後回しの優先順位となっています。今後しばらくの間、更新やサポートは非常に限定的になります。ご理解のほどよろしくお願いいたします。
>
> より積極的にメンテナンスされている、フルWebUI、ライブダッシュボードとVODプレーヤー、自動バックグラウンド監視およびアーカイブ機能を備えた代替案をお探しの場合は、**[Accerso](https://accesro.one)** をご覧ください。

> [!WARNING]
> **‼️ Windows Defenderの誤検知**（なぜこれが発生しているのか全く不明です）
>
> このプログラムのWindows実行ファイルは、Windows Defenderや他のアンチウイルスによって頻繁に **`Trojan:Script/Wacatac.B!ml`** として検出されます。これは**誤検知**です。
>
> **なぜこれが起こるのか？**
> 検出名の `!ml` は、これは人間ではなく機械学習モデルによってフラグ付けされたことを意味します。このプログラムは署名されていないオープンソースのスクレイパーツールで、多数のインターネットリクエストを行うため、自動システムが誤って疑わしいものとして検出しています。これはGoやRustベースの多くのコマンドラインツールでよくある問題です。
>
> **推奨される解決策 - Go経由でインストール（おそらくAV問題を回避可能）：**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **できること：**
> 1.  **プログラムを信頼する:** Windows Defenderを一時的に無効にしてプログラムをダウンロードおよび実行し、その後例外として追加できます。
> 2.  **ソースからビルドする:** Goがインストールされていれば、自分でビルドできます。ローカルでコンパイルするかgo経由でインストールするとプログラムは検出されません。
>
> コードは完全にオープンソースで、検査可能です。安全に使用できますが、AV警告が心配な場合はご理解ください。

Fanslyクリエイターのコンテンツをダウンロードおよび監視するためのシンプルなオールインワンツールです。

> **⚠️ 現在開発中** - 一部の機能は完全には動作しない場合があります。下記の[既知の問題](#known-issues)を参照してください。


## 必要条件

- **オプションだが強く推奨**：ライブストリーム録画およびより高品質な動画保存のための [ffmpeg](https://ffmpeg.org/)。Windowsでシステムパスにインストールするには、[このガイド](https://phoenixnap.com/kb/ffmpeg-windows)に従ってください。
- **オプション**：より良いコンタクトシート用の [mt](https://github.com/mutschler/mt)

## クイックスタート

### 1. ダウンロード
- **簡単な方法**: [ダウンロードページ](https://agnosto.github.io/projects/fansly-scraper/)にアクセス（システムを自動検出）
- **手動での方法**: [GitHubリリース](https://github.com/agnosto/fansly-scraper/releases)から取得
- **Goでインストール**:
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. プログラムの実行
```bash
./fansly-scraper
```
初回起動時、セットアップウィザードがすべての設定を手助けします。'a'キーを押すと自動ログインを使用します：Fanslyを開き、DevToolsコンソールに貼り付けるための一行スニペットを提供します。あなたのトークンとユーザーエージェントは自動的に取得され、設定に保存されます。

## 基本的な使い方

### インタラクティブモード（初心者に推奨）

```bash
./fansly-scraper
```

メインメニューから以下ができます：
- セットアップウィザードの実行（保存場所の選択、自動ログイン）
- 設定のリセット（デフォルトに戻す、ウィザードの再実行）

### コマンドラインモード
```bash
# Download all content from a creator
./fansly-scraper -u {creator-name}

# Download specific content types
./fansly-scraper -u {creator-name} -d [all|timeline|messages|stories]

# Monitor for live streams
./fansly-scraper -m {creator-name}

# Start/stop monitoring
./fansly-scraper monitor [start|stop]
```

**注意**: ライブモニタリングは端末セッションをアクティブに保つ必要があります。バックグラウンドでモニタリングを実行するには、Linux/WSL上で [tmux](https://github.com/tmux/tmux/wiki) や [zellij](https://github.com/zellij-org/zellij) のような端末マルチプレクサの使用を検討してください。v0.6.3以降、既存のモニタープロセスを再起動せずに、別の端末インスタンスで `-m creator` を実行して追加のクリエイターを監視できます。

### プログラムの更新
```bash
./fansly-scraper update
```

## プロジェクトロードマップと高度な設定

私たちの開発は**[プロジェクトロードマップ](https://github.com/users/agnosto/projects/1)**で公開追跡されています。現在取り組んでいること、将来の計画、そして議論に参加できます。

- **設定ガイド**: **[公式ウィキ](https://github.com/agnosto/fansly-scraper/wiki)**をご覧ください
- **ソースからビルドする**:
  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```
## 貢献について

貢献は大歓迎であり、大変感謝しています！バグの報告、機能提案、プルリクエストの提出など、あなたの協力は非常に価値があります。

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

開始する前に、[貢献ガイドライン](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md)をお読みください。
[Issuesタブ](https://github.com/agnosto/fansly-scraper/issues)で、取り組みたいタスクがあるか確認してください。

## 既知の問題

- **再ダウンロード**: v0.8.3以降、ファイル命名規則が変更され、メディアの再ダウンロードが発生することがあります。
- **チャット記録**: 再接続時にメッセージが一部欠落することがあります。
- **MacOSユーザー**: [システム設定](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049)で通知を許可する必要がある場合があります。
- **ライブステータス**: TUIで `r` を押してライブステータスを更新してください。
- **重複ファイル**: FanslyのAPI構造のため、同じ画像が二重に表示されることがあります。
- **ライブストリームファイル名の日付形式**: ストリームが中断されて録画を再試行する場合、日付形式が十分に特定されていない（例：タイムスタンプなし）と、両方のVODが同じ名前になるため保存に失敗します。現在は以下のいずれかを使用してください：`2006-01-02_15:04:05` または `20060102_150405`

## プロジェクトを支援する

このツールが役立った場合、GitHubでスポンサーになることを検討してください：

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

または、暗号通貨による一度限りの寄付も可能です：

<table>
  <tr>
    <td align="center"><strong>ビットコイン (BTC)</strong></td>
    <td align="center"><strong>ソラナ (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Bitcoin QRコード" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">

      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="Solana QRコード" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **免責事項**: このツールはFanslyまたはSelect Media LLCとは提携していません。自己責任でご利用ください。このスクリプトの開発者は、エンドユーザーの行動やエンドユーザーのアカウントに対して取られる可能性のある結果について一切責任を負いません。自己責任でご利用ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---