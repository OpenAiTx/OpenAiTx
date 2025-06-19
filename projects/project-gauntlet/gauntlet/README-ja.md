# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

ReactベースのプラグインによるWebファーストなクロスプラットフォームアプリケーションランチャー

> [!WARNING]
> ランチャーは開発者1人が余暇時間で開発しています。
> 進捗は遅いかもしれませんが、着実に進みます。
>
> 破壊的変更が発生する可能性がありますが、[changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md)に記載されます。

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## デモ

やや古いデモ

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## 特徴

- プラグインファースト
  - プラグインはTypeScriptで記述
  - 豊富なプラグインAPI
      - UIビューの作成
      - ワンショットコマンド
      - ワンショットコマンドのリストを動的に提供
      - メイン検索バーの値に応じて、その直下にクイックな「インライン」コンテンツを表示
      - クリップボードからの取得および追加
  - プラグインはGitリポジトリの別ブランチとして配布されるため、配布に中央サーバーは不要
  - プラグインIDはGitリポジトリのURL
  - [React](https://github.com/facebook/react)ベースのUI
    - カスタムReact Reconcilerで実装（Electronは不使用）
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - DenoによってJavaScriptプラグインコードをサンドボックス化し、セキュリティ向上
    - プラグインは必要な権限を明示的に指定する必要あり
    - Node.jsはプラグインツール用に使用されますが、プラグイン開発者はDeno上で動作するコードのみ記述
- 最初からクロスプラットフォーム対応を意識して設計
- コマンドやビューはカスタムグローバルショートカットで実行/起動可能
- コマンドまたはビューにカスタム検索エイリアスを割り当て可能
- カスタムテーマ対応
- 標準機能はバンドルされたプラグインで提供
  - Applications: システムにインストールされているアプリケーションを検索結果に表示
    - プラグインはウィンドウと、そのウィンドウが属するアプリケーションも追跡。既に開いているアプリを再度開くと、デフォルトで既存ウィンドウをアクティブに
      - 現時点で全システム対応ではありません。[機能サポート](https://gauntlet.sh/docs/feature-support)参照
  - Calculator: メイン検索バー直下に数式の計算結果を表示
    - 為替レートを使った通貨換算も可能
    - [Numbat](https://github.com/sharkdp/numbat)を利用
- Frecency（頻度＋新しさ）ベースの検索結果順
   - Frecencyはfrequency（利用頻度）とrecency（最近さ）の組み合わせ
   - よく使われる項目は上位表示されるが、過去に多く使われ、最近使われていない項目は最近よく使われる項目より下位
   - 結果は単語ごとに部分一致でマッチ

##### OSサポート

##### 公式サポート
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### ベストエフォート
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Waylandは未対応、[#40](https://github.com/project-gauntlet/gauntlet/issues/40)参照
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## はじめに

### Gauntletのインストール

[インストール方法](https://gauntlet.sh/docs/installation)を参照

### グローバルショートカット

メインウィンドウはグローバルショートカットまたはCLIコマンドで開けます:
- グローバルショートカット（設定で変更可能）
  - Windows: <kbd>ALT</kbd> + <kbd>Space</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Space</kbd>
  - Linux Wayland
    - グローバルショートカットは未対応の場合あり。[機能サポート](https://gauntlet.sh/docs/feature-support)参照
    - 代わりにCLIコマンドを使い、ウィンドウマネージャ固有の方法で呼び出してください
  - macOS: <kbd>CMD</kbd> + <kbd>Space</kbd>
- CLIコマンド
  - `gauntlet open`

### プラグインのインストール

プラグインは設定UIからインストールします。プラグインのGitリポジトリURLを利用してください。例：`https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### 独自プラグインの作成

[プラグイン開発入門](https://gauntlet.sh/docs/plugin-development/getting-started)を参照

## テーマ

[テーマ](https://gauntlet.sh/docs/theming)を参照

## Gauntletのビルド

必要なもの:
- NodeJS
- Rust
- Protobuf Compiler
- CMake（プロジェクト自体は未使用ですが依存関係で必要）
- Linuxの場合: `libxkbcommon-dev`（※ディストリビューションによって名称が異なる場合あり）

### 開発用

開発ビルドは以下を実行:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
開発モード（"release"機能なし）では、アプリケーションは状態やキャッシュをプロジェクトディレクトリ内だけに保存し、グローバルインストールを汚しません

### パッケージ化前ビルド

パッケージ化されていないリリースバイナリのビルドは以下を実行:
```bash
npm ci
npm run build
cargo build --release --features release
```

### パッケージ化ビルド
OSごとのパッケージビルドは以下のいずれかを実行:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

新バージョンのリリースはGitHub Actions経由で行う必要があります

## コントリビューション

Gauntlet開発への参加は、コードの貢献だけでなく、他にもさまざまな方法があります:
- バグやUI/UXの問題報告
- プラグインの作成

単純な問題であれば、IssueやPRを気軽に作成し、ご自身で解決していただいて構いません。
大きな変更の場合は、まずDiscord（README上部の招待リンク）で開発者にご連絡のうえご相談ください。

あらゆる貢献を歓迎します。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---