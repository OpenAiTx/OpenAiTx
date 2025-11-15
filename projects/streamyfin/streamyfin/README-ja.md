<a href="https://www.buymeacoffee.com/fredrikbur3" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/.github/refs/heads/main/streamyfin-github-banner.png" alt="Streamyfin" width="100%">
</p>

**StreamyfinはExpoで構築されたユーザーフレンドリーなJellyfinビデオストリーミングクライアントです。他のJellyfinクライアントの代替として設計されており、スムーズで信頼性の高いストリーミング体験を提供することを目指しています。メディアストリーミングツールの有益な追加としてご活用いただければ幸いです。**

---

<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot1.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot3.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot2.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/jellyseerr.PNG" width="21%">
</p>


## 🌟 機能

- 🚀 **イントロ／クレジットスキップ対応**: 再生中にイントロやクレジットを素早くスキップ可能
- 🖼️ **トリックプレイ画像**: シーク時のチャプタープレビューの新しいゴールデンスタンダード
- 📥 **メディアのダウンロード**: メディアをローカルに保存してオフライン視聴可能
- ⚙️ **設定管理**: プラグインを通じて全ユーザーのアプリ設定を管理
- 🤖 **Seerr（旧Jellyseerr）統合**: アプリ内で直接メディアリクエストが可能
- 👁️ **セッションビュー**: サーバーで現在ストリーミング中の全アクティブセッションを表示
- 📡 **Chromecast対応**: メディアをChromecast対応デバイスにキャスト可能

## 🧪 実験的機能

Streamyfinは、メディアのダウンロードやChromecast対応などのエキサイティングな実験的機能を提供しています。これらの機能は現在積極的に開発中であり、皆様のフィードバックとご理解が、より良いものにするための助けとなります。

### 📥 ダウンロード

ダウンロードはFFmpegを使用してHLSストリームをデバイス上のビデオファイルに変換することで動作します。これにより、ストリーミング可能なあらゆるコンテンツをダウンロードして視聴できます。変換はダウンロード中にサーバー上のJellyfinでリアルタイムに処理されます。これにより少し時間がかかる場合がありますが、サーバーがトランスコード可能なファイルとの互換性が保証されます。

### 🧩 Streamyfin プラグイン

Streamyfin 用 Jellyfin プラグインは、Jellyfin にインストールするプラグインで、クライアント Streamyfin のすべての設定を保持します。これにより、すべてのユーザー間で設定を同期できます。例えば：

- ユーザー入力不要の自動 Seerr ログイン
- 好みのデフォルト言語の設定
- ダウンロード方法や検索プロバイダーの構成
- ホーム画面のパーソナライズ
- その他多数

[Streamyfin プラグイン](https://github.com/streamyfin/jellyfin-plugin-streamyfin)

### 📡 Chromecast

Chromecast サポートは現在開発中です。ビデオキャストはすでに利用可能で、字幕サポートや追加機能の実装に積極的に取り組んでいます。

### 🔍 Jellysearch

[Jellysearch](https://gitlab.com/DomiStyle/jellysearch) は Streamyfin と連携します

> Jellyfin 用の高速全文検索プロキシ。ほとんどの Jellyfin クライアントとシームレスに統合されます。

## 🛣️ ロードマップ

私たちが次に取り組んでいる内容は[ロードマップ](https://github.com/users/fredrikburmester/projects/5)をチェックしてください。常にフィードバックや提案を歓迎しています。アイデアや機能リクエストがあればぜひお知らせください。

## 📥 Streamyfin をダウンロード

<div style="display: flex; gap: 5px;">
  <a href="https://apps.apple.com/app/streamyfin/id6593660679?l=en-GB"><img height=50 alt="App Store で Streamyfin を入手" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_the_App_Store_Badge.png"/></a>
  <a href="https://play.google.com/store/apps/details?id=com.fredrikburmester.streamyfin"><img height=50 alt="Google Play ストアで Streamyfin を入手" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Google_Play_Store_badge_EN.svg"/></a>
  <a href="https://github.com/streamyfin/streamyfin/releases/latest"><img height=50 alt="Github で Streamyfin を入手" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_Github_.png"/></a>
</div>

### 🧪 ベータテスト

Streamyfin ベータにアクセスするには、[Patreon](https://www.patreon.com/streamyfin) のメンバー階層（またはそれ以上）に登録する必要があります。これにより Discord の ⁠🧪-beta-releases チャンネルに即時アクセスでき、登録済みであることがわかります。ここで APK と IPA を共有しています。TestFlight の自動アクセスは提供されないため、Apple 用のメールアドレスを私（Cagemaster）に DM で送って手動で追加してください。

**注意**：Streamyfin のソースコードに積極的に貢献している方は、ベータリリースに自動的にアクセスできます。

## 🚀 はじめに

### ⚙️ 前提条件

- デバイスがJellyfinサーバーと同じネットワークに接続されていること（ローカル接続の場合）  
- Jellyfinサーバーが稼働中で、ローカルネットワーク外から接続する場合はリモートアクセスが有効になっていること  
- サーバーのバージョンが最新であること（古いバージョンは互換性の問題を引き起こす可能性があります）  
- 閲覧したいメディアライブラリにアクセスできる有効なJellyfinユーザーアカウントを持っていること  
- **ダウンロード**や**Seerr統合**などの機能を使用する場合は、必要なプラグインがJellyfinサーバーにインストールされ設定されていることを確認してください

## 🙌 コントリビューション

Streamyfinの改善に貢献していただける方を歓迎します。まずリポジトリをフォークし、プルリクエストを提出してください。大きな変更や新機能の場合は、事前にイシューを開いてアイデアを共有し、プロジェクトとの整合性を確認してください。

## 🌍 翻訳

[![Crowdin Translation Status](https://badges.crowdin.net/streamyfin/localized.svg)](https://crowdin.com/project/streamyfin)

Streamyfinは複数の言語に対応しており、世界中のユーザーが利用できるよう翻訳にご協力いただける方を常に募集しています。  
翻訳は直接[当社のCrowdinプロジェクトページ](https://crowdin.com/project/streamyfin)から貢献可能です。

### 👨‍💻 開発情報

1. node `>20` を使用してください  
2. 依存関係をインストール `bun i && bun run submodule-reload`  
3. xcodeおよび/またはandroid studioがインストールされていることを確認してください。（expoのガイドに従う：https://docs.expo.dev/workflow/android-studio-emulator/）  
4. VSCode/使用しているIDEにBiomeJS拡張機能をインストールしてください（https://biomejs.dev/）  
4. `npm run prebuild` を実行してください  
5. `npm run ios` または `npm run android` を実行してexpoの開発ビルドを作成します。これによりコンピューター上でシミュレーターが開き、アプリが実行されます

TV版の場合はnpmコマンドに `:tv` を付けて実行してください。

`npm run prebuild:tv`  
`npm run ios:tv` または `npm run android:tv`

## 👋 お問い合わせ

サポートが必要、または質問がありますか？

- **Discord:** [サーバーに参加する](https://discord.gg/BuGG9ZNhaE)
- **GitHub Issues:** [バグ報告や機能リクエストはこちら](https://github.com/streamyfin/streamyfin/issues)  
- **メール:** [developer@streamyfin.app](https://raw.githubusercontent.com/streamyfin/streamyfin/develop/mailto:developer@streamyfin.app)  


## ❓ FAQ

1. Q: なぜStreamyfinでライブラリが見えないのですか？  
   A: サーバーが最新バージョンのいずれかを実行していることと、オーディオのみでないライブラリが少なくとも1つあることを確認してください
2. Q: なぜ音楽ライブラリが見えないのですか？  
   A: 現在音楽はサポートしておらず、近い将来にサポートする可能性は低いです

## 📝 クレジット

Streamyfinは[Fredrik Burmester](https://github.com/fredrikburmester)によって開発されており、Jellyfinとは関係ありません。アプリはExpo、React Native、およびその他のオープンソースライブラリを使用して構築されています。

## 🎖️ コア開発者

以下の貢献者の皆様に多大な貢献を感謝します：

<div align="left">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Alexk2309">
        <img src="https://github.com/Alexk2309.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Alexk2309</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/herrrta">
        <img src="https://github.com/herrrta.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@herrrta</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lostb1t">
        <img src="https://github.com/lostb1t.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lostb1t</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Simon-Eklundh">
        <img src="https://github.com/Simon-Eklundh.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Simon-Eklundh</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/topiga">
        <img src="https://github.com/topiga.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@topiga</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lancechant">
        <img src="https://github.com/lancechant.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lancechant</b></sub>
      </a>
    </td>
  </tr>
  <tr>
    <td align="center">
      <a href="https://github.com/simoncaron">
        <img src="https://github.com/simoncaron.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@simoncaron</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/jakequade">
        <img src="https://github.com/jakequade.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@jakequade</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ryan0204">
        <img src="https://github.com/Ryan0204.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Ryan0204</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/retardgerman">
        <img src="https://github.com/retardgerman.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@retardgerman</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/whoopsi-daisy">
        <img src="https://github.com/whoopsi-daisy.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@whoopsi-daisy</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Gauvino">
        <img src="https://github.com/Gauvino.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Gauvino</b></sub>
      </a>
    </td>
  </tr>
</table>
</div>

## ✨ Acknowledgements

We would like to thank the Jellyfin team for their excellent software and support on Discord.

Special thanks to the official Jellyfin clients, which have served as an inspiration for Streamyfin.

We also thank all other developers who have contributed to Streamyfin, your efforts are greatly appreciated.

A special mention to the following people and projects for their contributions:

- [Reiverr](https://github.com/aleksilassila/reiverr) for invaluable help with understanding the Jellyfin API
- [Jellyfin TS SDK](https://github.com/jellyfin/jellyfin-sdk-typescript) for providing the TypeScript SDK
- [Seerr](https://github.com/seerr-team/seerr) for enabling API integration with their project


## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=streamyfin/streamyfin&type=Date)](https://star-history.com/#streamyfin/streamyfin&Date)

## 📄 License

StreamyfinはMozilla Public License 2.0（MPL-2.0）でライセンスされています。  
これは、このソフトウェアを自由に使用、改変、配布できることを意味します。MPL-2.0は、プロプライエタリコードと組み合わせる際により柔軟性を持たせたコピーレフトライセンスです。  
MPL-2.0の主なポイント：  

- ソフトウェアをあらゆる目的で使用可能  
- ソフトウェアを改変し、改変版を配布可能  
- 元の著作権およびライセンス表示を含める必要がある  
- 対象ファイルの改変に対してソースコードを開示する必要がある  
- 大きな作品ではMPLコードを他のライセンスのコードと組み合わせ可能  
- MPLライセンスのコンポーネントはMPLのままでなければならないが、大きな作品は別のライセンスでもよい  
- ライセンス全文はこのリポジトリのLICENSEファイルをご覧ください  

## ⚠️ 免責事項  
Streamyfinはいかなる形の海賊行為も推奨、支持、容認しません。  
このアプリは、個人的に所有・管理しているメディアのストリーミングのみを目的としています。メディアコンテンツを提供または含みません。  
海賊行為に関する議論、サポート依頼、言及、および海賊行為に関連するツール、ソフトウェア、ウェブサイトはすべてのチャネルで厳禁です。  

## 🤝 スポンサーシップ  
VPSホスティングは[Hexabyte](https://hexabyte.se/en/vps/?currency=eur)および[SweHosting](https://swehosting.se/en/#tj%C3%A4nster)のご厚意により提供されています  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---