<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/icon-transparent.png" alt="ImmiBridge" width="128">
</p>

<h1 align="center">ImmiBridge</h1>

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.apple.com/macos/"><img src="https://img.shields.io/badge/macOS-12.0+-blue.svg" alt="macOS"></a>
</p>

<p align="center">
  <a href="https://github.com/emerysilb/immibridge/releases/"><img src="https://img.shields.io/badge/Download-Latest%20Release-blue?style=for-the-badge" alt="Download latest release"></a>
</p>

Apple Photosライブラリを撮影日ごとに整理されたフォルダ、または直接[Immich](https://immich.app)サーバーにバックアップします。オリジナル（Live Photoのペア動画を含む）をエクスポートし、オプションで編集済みのレンダリングも行います。

<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/screenshot.png" alt="ImmiBridge Screenshot" width="700">
</p>

## 機能

- 日付ごとに整理されたローカルフォルダへ写真をエクスポート
- Immichフォトサーバーへ直接アップロード
- 増分、完全、またはミラーバックアップモード
- アルバム、メディアタイプ、または日付でフィルタリング
- バックアップの一時停止と再開
- スケジュールされた自動バックアップ
- メニューバー統合
- プログレス追跡付きのiCloud写真ダウンロード
- メタデータのみの同期（ファイルを再アップロードせずにメタデータを更新）
- Sparkleによる自動更新

## インストール

### ダウンロード（推奨）

1. [Releases](../../releases)ページから`ImmiBridge-x.x.x.dmg`をダウンロード
2. DMGを開き、ImmiBridgeをアプリケーションフォルダにドラッグしてください
3. アプリケーションからImmiBridgeを起動します  
4. プロンプトが表示されたら写真へのアクセスを許可してください  

### ソースからビルドする  

詳細なビルド手順については[CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md)を参照してください。  

**クイックスタート：**  

```bash
# Clone the repository
git clone https://github.com/emerysilb/immibridge.git
cd immibridge

# Open in Xcode
open ImmiBridge/ImmiBridge.xcodeproj
```
### サイン付きリリースのビルド

配布用の公証済みDMGをビルドするには、Apple Developer ID証明書（年額99ドル）が必要です。詳細は[CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md#creating-a-signed-release)を参照してください。

## 使い方

ImmiBridgeを起動し、設定します：

1. **ソース**：写真ライブラリおよび/またはカスタムフォルダを選択
2. **宛先**：ローカルフォルダおよび/またはImmichサーバー
3. **オプション**：バックアップモード、フィルター、スケジューリング

### バックアップモード

| モード | エクスポート | マニフェスト使用 | 宛先から削除 |
|--------|--------------|------------------|--------------|
| **スマートインクリメンタル** | 新規/変更ファイルのみ | はい | いいえ |
| **フル** | すべてのファイル毎回 | いいえ | いいえ |
| **ミラー** | 新規/変更ファイルのみ | はい | はい（孤立ファイル） |

### Immich統合

Immichサーバーに接続するには：

1. **宛先**タブに移動
2. ImmichサーバーのURLを入力（例: `http://192.168.1.100:2283`）
3. APIキーを入力（Immichのユーザー設定→APIキーで生成）
4. **接続テスト**をクリック

**機能:**
- SHA1チェックサムを使用し重複アップロードを防止
- ライブフォトは動画＋静止画のペアでアップロード
- Immichへのアルバム同期に対応

## 権限

初回起動時にmacOSは以下を求めます：

- **写真へのアクセス**：写真ライブラリを読み取るために必要

- **ローカルネットワークアクセス**: Immichサーバーがローカルネットワーク上にある場合に必要です

権限を拒否した場合は、**システム設定 → プライバシーとセキュリティ**で再度有効にしてください。

## 貢献

貢献を歓迎します！ ガイドラインは[CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md)をご覧ください。

## ライセンス

MITライセンス - 詳細は[LICENSE](LICENSE)をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---