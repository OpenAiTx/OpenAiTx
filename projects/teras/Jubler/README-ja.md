## Jubler - 字幕エディタ

![GitHub release (latest by date)](https://img.shields.io/github/v/release/teras/Jubler)
![GitHub all releases](https://img.shields.io/github/downloads/teras/Jubler/total)
![GitHub](https://img.shields.io/github/license/teras/Jubler?v=2)
![Java](https://img.shields.io/badge/Java-8+-orange)
![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS%20%7C%20Windows-blue)
![GitHub Release Date](https://img.shields.io/github/release-date/teras/Jubler)

Jublerは、テキストベースの字幕の作成、編集、変換のための無料かつオープンソースの字幕エディタです。クロスプラットフォーム互換性のためにJavaで書かれており、新しい字幕の作成や既存字幕の改善をビデオプレビュー、品質検証、豊富なフォーマット対応で提供します。

(C) 2005-2025 Panayotis Katsaloulis
panayotis@panayotis.com

GNU Affero General Public License v3 (AGPL-3.0) の下でライセンスされています

---

## 機能

### 字幕フォーマット
- **20以上のフォーマットに対応**しており、SubRip (SRT)、Advanced SubStation Alpha (ASS/SSA)、WebVTT、MicroDVD、SubViewer、MPL2、Spruce DVD Maestro、TTML、ITT、DFXP、YouTube字幕などを含みます
- **ユニバーサルエンコーディング対応**（UTF-8、UTF-16、およびすべてのJavaプラットフォームのエンコーディング）
- **文字および段落レベルのスタイリング**が可能なフォーマットに対応（ASS/SSA、SRT）
- **すべての対応フォーマット間での変換**が可能

### ビデオ統合
- **FFmpeg統合**によりフレームプレビューとオーディオ波形の視覚化を実現
- **MPlayerサポート**による動画再生
- **動画視聴中のリアルタイム字幕編集**
- **ドラッグ可能な字幕ブロックを備えたインタラクティブなタイムライン**
- **タイミング調整のための二点同期機能**
- **Shift/Altキー対応の強化プレビューコントロールおよびスナップ機能**

### 編集ツール
- **時間操作** - シフト、フレームレート変換、タイミングの丸め
- **コンテンツ操作** - エントリの分割/結合、ファイルの分割/結合
- **テキスト処理** - スペルチェッカー、正規表現対応の検索＆置換
- **重複検出と解決を備えたスマートタイムフィクサー**
- **字幕の並列翻訳のための翻訳モード**
- **元に戻す/やり直し** 機能（履歴全保持）
- **自動保存と復元**

### 品質管理
- **字幕検証**（設定可能な品質ルール対応）
- **CPS（1秒あたりの文字数）メトリクス** を字幕テーブルに表示
- **TEDガイドライン準拠** チェック
- **問題箇所を強調表示する色分け検証**
- **統計および分析** ツール

### ユーザーインターフェース
- **HiDPI対応**（スケーリング調整可能）
- **ダークテーマ** 利用可能
- **カスタマイズ可能なキーボードショートカット**
- **多言語インターフェース**（i18n対応）
- **字幕グループ整理用の色分け**

### 自動化
- **バッチ処理用コマンドラインツール**
- **拡張可能なプラグインシステム**
- **外部ツール連携**
- **自動翻訳用Azure Translator対応**

---

## はじめに

### 動作環境
- Java 8以上（配布版に同梱されていることが多い）
- 任意：動画プレビュー用MPlayer
- 任意：スペルチェック用ASpell

### インストール

[リリースページ](https://github.com/teras/Jubler/releases)からバイナリをダウンロード：
- Windows、macOS、Linux用インストーラー
- Linux用AppImage
- 汎用クロスプラットフォームパッケージ

またはソースからビルド（[BUILD_AND_RUN.md](https://raw.githubusercontent.com/teras/Jubler/master/BUILD_AND_RUN.md)参照）

### 実行

アプリケーションメニューまたはデスクトップのショートカットから起動します。手動で実行することもできます：
```bash
java -jar Jubler.jar
```

---

## Contributing

Jubler is an open source project that welcomes contributions. Whether you're fixing bugs, adding features, improving documentation, or translating the interface, your help is appreciated.

---

## Credits

Free code signing on Windows provided by [SignPath.io](https://signpath.io/), certificate by [SignPath Foundation](https://signpath.org/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---