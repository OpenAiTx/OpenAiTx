# CreamLinux

CreamLinuxは、SteamゲームのDLC ID管理を簡素化するLinux向けGUIアプリケーションです。ネイティブLinuxゲーム向けのCreamAPIおよびProton経由で動作するWindowsゲーム向けのSmokeAPIのインストールと設定を、ユーザーフレンドリーなインターフェースで提供します。

## デモを見る：

[![デモを見る](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/./src/assets/screenshot1.png)](https://www.youtube.com/watch?v=neUDotrqnDM)

## ベータステータス

⚠️ **重要**: CreamLinuxは現在ベータ版です。これは以下を意味します：

- 一部の機能は未完成または変更される可能性があります
- バグや予期しない動作に遭遇する可能性があります
- アプリケーションは積極的に開発中です
- フィードバックやバグ報告は非常に重要です

コア機能は動作していますが、これは初期リリースであることにご注意ください。安定性の向上、機能追加、ユーザー体験の改善に継続的に取り組んでいます。問題があれば[GitHub Issuesページ](https://github.com/Novattz/creamlinux-installer/issues)にて報告してください。

## 特徴

- **自動検出**: システムにインストールされたSteamゲームを自動的に検出
- **ネイティブサポート**: ネイティブLinuxゲーム向けにCreamLinuxをインストール
- **Protonサポート**: Proton経由で動作するWindowsゲーム向けにSmokeAPIをインストール
- **DLC管理**: 有効にするDLCを簡単に選択可能
- **モダンUI**: 使いやすいクリーンでレスポンシブなインターフェース

## インストール

### AppImage（推奨）

1. 最新の `creamlinux.AppImage` を[リリース](https://github.com/Novattz/creamlinux-installer/releases)ページからダウンロード
2. 実行可能にする：
   ```bash
   chmod +x creamlinux.AppImage
   ```
3. 実行してください：

   ```bash
   ./creamlinux.AppImage
   ```

   Nvidiaユーザーはこのコマンドを使用してください:

   ```
   WEBKIT_DISABLE_DMABUF_RENDERER=1 ./creamlinux.AppImage
   ```

### ソースからのビルド

#### 前提条件

- Rust 1.77.2以降
- Node.js 18以降
- webkit2gtk-4.1（Debianではlibwebkit2gtk-4.1）
- npmまたはyarn

#### 手順

1. リポジトリをクローンする：

   ```bash
   git clone https://github.com/Novattz/creamlinux-installer.git
   cd creamlinux-installer
   ```

2. 依存関係をインストールします:

   ```bash
   npm install # or yarn
   ```

3. アプリケーションをビルドする:

   ```bash
   NO_STRIP=true npm run tauri build
   ```

4. コンパイルされたバイナリは `src-tauri/target/release/creamlinux` にあります。

### デスクトップ統合

AppImageバージョンを使用している場合、デスクトップ環境に統合できます：

1. デスクトップエントリファイルを作成します：

   ```bash
   mkdir -p ~/.local/share/applications
   ```

2. `~/.local/share/applications/creamlinux.desktop` を以下の内容で作成します（AppImageのパスは適宜調整してください）：

   ```
   [Desktop Entry]
   Name=Creamlinux
   Exec=/absolute/path/to/CreamLinux.AppImage
   Icon=/absolute/path/to/creamlinux-icon.png
   Type=Application
   Categories=Game;Utility;
   Comment=DLC Manager for Steam games on Linux
   ```

3. デスクトップデータベースを更新して、creamlinux がアプリランチャーに表示されるようにします:

```bash
update-desktop-database ~/.local/share/applications
```
## トラブルシューティング

### よくある問題

- **ゲームが起動しない**: Steamの起動オプションが正しく設定されているか確認してください
- **DLCが表示されない**: ゲームリストを更新し、再インストールを試みてください
- **Steamが見つからない**: Steamがインストールされており、一度は起動していることを確認してください

### デバッグログ

ログは次の場所に保存されています: `~/.cache/creamlinux/creamlinux.log`

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています - 詳細は[LICENSE](https://raw.githubusercontent.com/Novattz/creamlinux-installer/main/LICENSE.md)ファイルをご覧ください。

## クレジット

- [Creamlinux](https://github.com/anticitizn/creamlinux) - ネイティブサポート
- [SmokeAPI](https://github.com/acidicoala/SmokeAPI) - Protonサポート
- [Tauri](https://tauri.app/) - デスクトップアプリケーション構築のためのフレームワーク
- [React](https://reactjs.org/) - UIライブラリ



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-17

---