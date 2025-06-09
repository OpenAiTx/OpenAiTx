<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">OpenAIのWhisperモデルによるシームレスな音声入力</p>
</p>

<p align="center">
  <!-- 最新バージョンバッジ -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- ライセンスバッジ -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- 技術バッジ -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- プラットフォームサポートバッジ -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## 概要

Whisperingは、グローバルな音声認識（音声→テキスト）機能を提供するオープンソースの文字起こしアプリケーションです。キーボードショートカットや自動コピー＆ペーストなど、音声入力をできるだけシームレスにするためのオプションを搭載しています。

内部ではOpenAIのWhisperモデルを利用しており、標準搭載の音声入力よりも大幅に高精度です。

> **重要な注意**: Whisperingは主に文字起こしツールとして設計されています。録音ツールではありません。信頼性が重要な長時間の録音には、スマートフォンやデバイスで専用の録音アプリ（ネイティブ録音APIを利用）を使用することを推奨します。これにより、最適な音質と録音の安定性が確保されます。

## デモ

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## 主な特徴

1. **グローバル文字起こし**: グローバルキーボードショートカットまたは2クリックで、どこでもWhisperの音声→テキスト機能にアクセス可能。
2. **クロスプラットフォーム体験**:
   - デスクトップアプリ: すべてのアプリケーションでグローバル文字起こしが可能。
   - ブラウザ拡張機能: Webアプリと連携し、ブラウザ内でグローバル文字起こしを提供。
3. **チャット統合**: ブラウザ拡張はChatGPTやClaudeのウェブサイトに録音ボタンを追加し、チャット画面から直接音声入力・文字起こしが可能。
4. **文字起こし管理**: Whisperingアプリ内で文字起こし内容の確認・編集ができ、正確性と明瞭性を確保。
5. **自動クリップボード連携**: 文字起こし完了後、テキストが自動的にクリップボードにコピーされます。自動ペーストのオプションも利用可能。

## データの保存方法

Whisperingは、録音データや文字起こしテキストを含め、可能な限り多くのデータをローカル（端末内）に保存します。このアプローチにより、最大限のプライバシーとデータセキュリティが確保されます。データの取り扱いについての概要は以下の通りです。

1. **ローカル保存**: 音声録音や文字起こしデータはIndexedDBに保存されます。これはBLOBストレージとして、テキストや文字起こしなど全データの保存場所として利用されます。

2. **文字起こしサービス**: 外部に送信されるデータは、（選択した場合のみ）文字起こし用の録音データのみです。以下のオプションがあります。
   - OpenAIやGroqなどの外部サービス
   - `faster-whisper-server`など、すべてデバイス内で完結するローカル文字起こしサービス

3. **設定変更可能**: 設定画面で文字起こしサービスを切り替え、最大限ローカルでの動作を保証できます。


## インストール

### Webアプリ

[whispering.bradenwong.com](https://whispering.bradenwong.com/) にアクセスしてください。ここには最新の `apps/app` フォルダがVercelでホスティングされています。

### Chrome拡張

ChromeウェブストアからChrome拡張機能を[こちら](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo)からインストールしてください。

### デスクトップアプリ

Whisperingデスクトップアプリをダウンロード・インストールするには、ご利用のOSごとの手順に従ってください。

#### Windows

1. [最新リリースページ](https://github.com/braden-w/whispering/releases)から`.msi`で終わるインストーラーパッケージをダウンロードします。
2. ダウンロードした`.msi`ファイルを開いてインストーラーを実行します。
3. 「安全ではない」と表示された場合は、`詳細情報` → `実行` をクリックしてインストールを続行します。
4. 画面の指示に従ってインストールを完了してください。

#### macOS

macOSの場合、以下の手順でWhisperingをインストールしてください。

1. **インストールパッケージのダウンロード**:
   - [最新リリースページ](https://github.com/braden-w/whispering/releases)にアクセス。
   - 該当するパッケージを選択:
     - Apple Silicon用: `Whispering_x.x.x_aarch64.dmg`
     - Intel用: `Whispering_x.x.x_x64.dmg`

2. **アプリケーションのインストール**:
   - ダウンロードした`.dmg`ファイルを開きます。
   - WhisperingアプリをApplicationsフォルダにドラッグします。

3. **Whisperingの起動**:
   - ApplicationsフォルダからWhisperingを開きます。
   - 開発元未確認の警告が表示された場合:
     - `キャンセル`をクリック
     - Finderでアプリを右クリックし、`開く`を選択

4. **トラブルシューティング**（Apple Siliconのみ）:
   `"Whispering"は壊れているため開けません`というエラーが出た場合:
   - ターミナルを開きます
   - 以下のコマンドを実行:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - 再度アプリを開いてみてください

これらの手順を完了すると、WhisperingがmacOSで利用できるようになります。

#### Linux

Linuxの場合、複数のインストール方法があります。ご利用環境に合った方法を選択してください。

1. **AppImage**:

   - [最新リリースページ](https://github.com/braden-w/whispering/releases)から`.AppImage`ファイルをダウンロードします。
   - ファイルを実行可能にします:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - AppImageを実行します:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEBパッケージ（Debian/Ubuntu）**:
   - [最新リリースページ](https://github.com/braden-w/whispering/releases)から`.deb`ファイルをダウンロードします。
   - `dpkg`を使ってパッケージをインストールします:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - 依存関係の問題を解決:
     ```bash
     sudo apt-get install -f
     ```

インストール後、アプリが使用可能になります。

## 使い方

### Chrome拡張

Chrome拡張をインストール後、Chromeの拡張バーにWhisperingアイコンが表示されます。このアイコンをクリックして拡張機能を開き、マイクボタンをクリックして録音を開始、四角ボタンをクリックして録音を終了します。文字起こし結果は下のテキストボックスに表示されます。

ChatGPTまたはClaudeの機能を利用するには、ChatGPTまたはClaudeのウェブページに移動してください。チャット画面に新しい録音ボタンが表示されます。このボタンをクリックして録音の開始・停止を行い、文字起こしテキストが自動的にチャット入力欄に挿入されます。

ショートカット機能を利用するには、<kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> または <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd>（後でChrome拡張ショートカットで設定可）を押して、任意のウェブサイトから録音を開始します。文字起こし結果は自動的にクリップボードにコピーされ、現在の入力欄にペーストされます。

Chrome拡張は [whispering.bradenwong.com](https://whispering.bradenwong.com) と通信し、バックグラウンドにタブが存在しない場合は自動で作成を試みます。多くのバグはこの通信が失敗した場合（タブがスリープ状態になるなど）に発生します。

### Webアプリ

Webアプリは [whispering.bradenwong.com](https://whispering.bradenwong.com) で利用できます。マイクボタンをクリックして録音を開始し、四角ボタンで終了します。文字起こし結果がテキストボックスに表示されます。

### デスクトップアプリ

Whisperingデスクトップアプリをインストール後、<kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd>（設定で変更可能）を押すことで、デスクトップ上のどこからでも録音を開始できます。文字起こし結果は自動的にクリップボードにコピーされペーストされますが、これらの機能は設定で切り替え可能です。

## 使用技術

#### Webおよびデスクトップ

Whisperingアプリは以下の技術とライブラリで構築されています:

- [Svelte 5](https://svelte.dev): 選択されたUIリアクティビティライブラリ。
- [SvelteKit](https://kit.svelte.dev/docs): ルーティングと静的サイト生成のため。ウェブサイトおよびTauriアプリ用の静的フロントエンドに使用。
- [Tauri](https://tauri.studio/en/docs/intro/): デスクトップアプリフレームワーク。
- [Effect-TS](https://github.com/Effect-TS/effect): 関数型プログラミングを取り入れ、エラーを関数シグネチャの戻り値型に含めて非常に型安全な関数を記述。
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Svelteアプリ用のシンプルかつカスタマイズ可能なトーストライブラリ。`renderAsToast`関数でEffect-TSからバブルアップしたエラー表示に使用。
- [TanStack Table](https://tanstack.com/table): すべてのデータテーブルを支えるライブラリ。
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): ブラウザ内で大量の構造化データを保存するための低レベルAPI。Tanstack Tableと同期。
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): 選択されたUIコンポーネントライブラリ。
- [TailwindCSS](https://tailwindcss.com/docs): カスタムUIを迅速に構築するためのユーティリティファーストCSSフレームワーク。
- [Turborepo](https://turborepo.org/): モノレポ管理用。`apps/app`と`apps/extension`が同じコードベースを共有し、コードの重複を大幅に削減、単一のソースオブトゥルースを維持。
- [Rust](https://www.rust-lang.org): デスクトップアプリの機能拡張用。自動ペースト処理で`enigo`クレートなどを利用。
- [Vercel](https://vercel.com/): ホビープロジェクト向けのホスティング。Turborepoとの統合も良好。
- [Zapsplat.com](https://www.zapsplat.com/): ロイヤリティフリーの効果音ライブラリ。

#### 拡張機能

Whispering Chrome拡張は以下を利用して構築されています:

- [Plasmo](https://docs.plasmo.com/): Chrome拡張を構築するためのフレームワーク。[relay flow](https://docs.plasmo.com/framework/messaging#relay-flow)を使いWhisperingウェブサイトと通信。
- [Effect-TS](https://github.com/Effect-TS/effect): 関数型プログラミングを取り入れ、エラーを関数シグネチャの戻り値型に含めて非常に型安全な関数を記述。
- [React](https://reactjs.org): Chrome拡張のUIリアクティビティライブラリ。PlasmoはSvelte 5をサポートしていないため。
- [ShadCN](https://github.com/shadcn): Chrome拡張用のUIコンポーネントライブラリ。
- [TailwindCSS](https://tailwindcss.com/docs): カスタムユーザーインターフェースを迅速に構築するためのユーティリティファーストなCSSフレームワークです。
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): Chrome拡張機能のAPIです。
- [Zapsplat.com](https://www.zapsplat.com/): ロイヤリティフリーの効果音ライブラリです。

## ローカル開発モードでWhisperingを実行する

ローカルマシンでプロジェクトをセットアップするには、以下の手順に従ってください。

1. リポジトリをクローンします: `git clone https://github.com/braden-w/whispering.git`
2. プロジェクトディレクトリに移動します: `cd whispering`
3. 必要な依存関係をインストールします: `pnpm i`

Whisperingデスクトップアプリおよびウェブサイトを開発モードで実行するには:

4. アプリディレクトリに移動します: `cd apps/app`
5. 開発サーバーを起動します: `pnpm tauri dev`

デスクトップアプリはローカル開発のために自動的に起動するはずです。ウェブアプリを開発する場合は、ブラウザで `http://localhost:5173` にアクセスしてください。

Whispering Chrome拡張機能を開発モードで実行するには:

4. 拡張機能ディレクトリに移動します: `cd apps/extension`
5. 開発サーバーを起動します: `pnpm dev --target=chrome-mv3`

Chrome拡張機能を開発するには、Chromeの `chrome://extensions` にアクセスし、デベロッパーモードを有効にして、`apps/extension/build/{platform}-{manifest-version}-dev` フォルダをパッケージ化されていない拡張機能として読み込んでください。

## 実行ファイルを自分でビルドする

インストーラーの信頼性に不安がある場合や、より詳細な制御を希望する場合は、いつでも実行ファイルをご自身でビルドできます。これには追加のセットアップが必要ですが、期待通りのコードを実行できることが保証されます。これこそがオープンソースソフトウェアの醍醐味です！

### Chrome

1. 拡張機能ディレクトリに移動します: `cd apps/extension`
2. 必要な依存関係をインストールします: `pnpm i`
3. Plasmoビルドを実行します: `pnpm plasmo build --target=chrome-mv3`
4. 出力は `apps/extension/build/chrome-mv3-prod` に生成されます。このフォルダをパッケージ化されていない拡張機能としてChromeに読み込むことができます。
5. あるいは、Chromeウェブストア用にビルドするには: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. 拡張機能ディレクトリに移動します: `cd apps/extension`
2. 必要な依存関係をインストールします: `pnpm i`
3. Plasmoビルドを実行します: `pnpm plasmo build --target=firefox-mv3`
4. 出力は `apps/extension/build/firefox-mv3-prod` に生成されます。このフォルダをパッケージ化されていない拡張機能としてChromeに読み込むことができます。
5. あるいは、Chromeウェブストア用にビルドするには: `pnpm plasmo build --target=firefox-mv3 --release`

### デスクトップ

1. アプリディレクトリに移動します: `cd apps/app`
2. 必要な依存関係をインストールします: `pnpm i`
3. Tauriビルドを実行します: `pnpm tauri build`
4. 実行ファイルは `apps/app/target/release` ディレクトリにあります。

## コントリビューション

コミュニティからのコントリビューションを歓迎します！Whisperingに貢献したい場合は、以下の手順に従ってください。

1. リポジトリをフォークしてください。
2. 新しい機能やバグ修正用にブランチを作成します: `git checkout -b feature/your-feature-name` または `git checkout -b fix/your-bugfix-name`
3. 変更を加えて、説明的なメッセージでコミットしてください。
4. フォークしたリポジトリにブランチをプッシュします: `git push origin your-branch-name`
5. フォークしたリポジトリからオリジナルリポジトリへプルリクエストを作成してください。

コードは既存の規約に従い、十分にドキュメント化されていることを確認してください。

## ライセンス

Whisperingは [MITライセンス](https://opensource.org/licenses/MIT) のもとで公開されています。

## スポンサー

このプロジェクトは、以下の素晴らしい方々や組織によって支えられています。

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## サポートとフィードバック

問題が発生した場合や改善案がある場合は、[GitHubのissuesタブ](https://github.com/braden-w/whispering/issues)でissueを作成するか、[whispering@bradenwong.com](mailto:whispering@bradenwong.com) までご連絡ください。皆様からのフィードバックを心よりお待ちしております！

Whisperingをご利用いただき、ありがとうございます。楽しい執筆をお祈りします！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---