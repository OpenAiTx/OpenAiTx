# 🚀 AndroBuster

<div align="center">
  <img width="2808" height="699" alt="bannerfinal" src="https://github.com/user-attachments/assets/7f74539f-0af6-40d9-bafb-9207afd80af8" />

</div> 

<div align="center">

**🔒 ペンテストを簡単に**  
*Flutterで構築された強力なディレクトリおよびサブドメイン列挙ツール*

[![Download APK](https://img.shields.io/badge/Download-APK-blue?style=for-the-badge&logo=android)](https://github.com/BlackHatDevX/androbuster/releases)
[![GitHub stars](https://img.shields.io/github/stars/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub forks](https://img.shields.io/github/forks/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)
[![GitHub issues](https://img.shields.io/github/issues/BlackHatDevX/androbuster?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster/issues)

</div>

---

## 📖 概要

AndroBusterは、GoBusterに触発された**オープンソースのセキュリティツール**であり、ディレクトリおよびサブドメインの列挙のためのモダンでクロスプラットフォームなインターフェースを提供します。Flutterで構築されており、プロフェッショナルなセキュリティツールに期待される強力さと柔軟性を維持しながら、クリーンで直感的なユーザー体験を提供します。

### 🎯 AndroBusterの特長は？
- 🚀 **クロスプラットフォーム**：Android、iOS、デスクトップで動作
- 🔒 **セキュリティ重視**：ペネトレーションテスター向けに設計
- 💻 **モダンUI**：美しいFlutterベースのインターフェース
- ⚡ **高性能**：効率的なスレッドおよびメモリ管理
- 📱 **モバイルファースト**：モバイルセキュリティテストに最適化

---

## 🖼️ スクリーンショット

<div align="center">

<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 24 AM" src="https://github.com/user-attachments/assets/e12ed93e-876f-408b-9e3d-4a849e8fe2a1" />
<img width="339" height="749" alt="Screenshot 2025-08-20 at 1 11 34 AM" src="https://github.com/user-attachments/assets/17850561-cef9-46e2-8203-8ba29c223fe7" />
</div>

---



## ✨ 機能

### 🗂️ ディレクトリ列挙モード
- **対象URL入力**：自動で末尾のスラッシュを除去するクリーンなURL処理
- **ネガティブステータスコード**：不要なHTTPステータスコードをフィルタリング（デフォルト：404）
- **ネガティブページサイズ**：コンテンツ長に基づくレスポンスの除外
- **ワードリスト対応**：大容量テキスト入力およびファイルインポート機能
- **スレッド制御**：最適なパフォーマンスのためのスレッド数設定可能
- **タイムアウト設定**：ミリ秒単位でカスタマイズ可能なリクエストタイムアウト

### 🌐 サブドメイン列挙モード
- **ドメイン入力**：http/https不要のクリーンなドメイン処理
- **サブドメインワードリスト**：サブドメイン発見用の専用ワードリスト管理
- **プロトコルテスト**：自動HTTPS/HTTPフォールバックテスト
- **サブドメイン検証**：RFC 1123準拠のサブドメイン名検証
- **専用フィルター**：サブドメイン用の別個のネガティブステータスコード・ページサイズ設定
- **スレッド＆タイムアウト**：ディレクトリモードと独立した設定が可能

### 📋 結果管理
- **統合結果タブ**：ディレクトリおよびサブドメインのスキャン結果を一元表示
- **結果フォーマット**：パス、ステータスコード、サイズ、URLを明確に表示
- **クリップボードへコピー**：外部解析用に結果をエクスポート
- **結果クリア**：スキャン間の簡単な結果リセット
- **結果数管理**：ディレクトリとサブドメイン別に結果数を追跡

### 📁 ファイル管理
- **ワードリストインポート**：最大50MBの.txtファイルに対応
- **スマートプレビュー**：ファイルサイズに応じた内容表示
- **大容量ファイル処理**：巨大ワードリストの効率的な処理
- **フォーマット対応**：コメント（#）や空行を自動処理

### 🚀 パフォーマンス＆信頼性
- **バックグラウンド実行**：スキャン中もアプリがバックグラウンドで継続動作

- **メモリ最適化**：大規模なワードリストの効率的な処理
- **エラーハンドリング**：優雅なフォールバックおよび回復メカニズム
- **クロスプラットフォーム**：AndroidおよびiOS向けにFlutterで構築



---

## 📱 インストール

### 📦 リリースビルド
現在、Android APKのリリース版のみ利用可能です。リリースページから最新のAPKをダウンロードしてください。

<div align="center">

[![Download Latest](https://img.shields.io/badge/📥%20Download%20Latest%20Release-blue?style=for-the-badge)](https://github.com/BlackHatDevX/androbuster/releases)

</div>

### 🔧 ソースからのビルド
ソースコードは現在公開されており、誰でも使用、改変、貢献が可能です。

---

## 📖 使用ガイド

### 🗂️ ディレクトリ列挙
1. 「Dir」タブに移動
2. 対象のURLを入力
3. ネガティブステータスコードとページサイズを設定
4. ワードリストを貼り付けまたはインポート
5. スレッド数とタイムアウトを設定
6. スキャンを開始し進行状況を監視

### 🌐 サブドメイン列挙
1. 「Subdomain」タブに移動
2. 対象ドメインを入力（http/httpsなし）
3. サブドメイン固有のフィルターを設定
4. サブドメイン用ワードリストをインポートまたは貼り付け
5. スレッド数とタイムアウト設定を調整
6. サブドメインの発見を開始

### 📋 結果管理
- 「結果」タブで全ての結果を表示
- 結果をクリップボードにコピーして外部分析に使用
- 異なるスキャン間で結果をクリア
- スキャンの進行状況と完了を監視

---

## ⚙️ 設定

### ⚡ スレッド数
- **推奨**: ほとんどのシナリオで10～20スレッド
- **高スレッド警告**: 20スレッドを超えると警告
- **考慮事項**: スレッド数が多いとレート制限が発生する可能性あり

### ⏱️ タイムアウト設定
- **デフォルト**: 5000ms（5秒）
- **調整**: ネットワークが遅い場合は増加、速い応答には減少
- **範囲**: 1000msから30000msまで対応

### 🚫 ネガティブフィルター
- **ステータスコード**: カンマ区切りリスト（例：404,403,500）
- **ページサイズ**: カンマ区切りリスト（例：0,1234,5678）
- **目的**: 不要な応答を結果から除外

---

## 🤝 貢献について

このプロジェクトは**オープンソース**であり、貢献を歓迎します！ソースコードは公開されており、誰でも利用可能です。

<div align="center">

[![Star Repository](https://img.shields.io/badge/⭐%20Star%20Repository-yellow?style=for-the-badge&logo=github)](https://github.com/BlackHatDevX/androbuster)

</div>

### 📋 貢献方法
1. **⭐ スター** を押してください（任意ですが感謝します！）
2. **🍴 フォーク** してください
3. **🌿 機能ブランチ** を作成してください
4. **📤 プルリクエスト** を提出してください

---

## 🙏 クレジット＆謝辞

- **🎯 インスパイア元**: [GoBuster](https://github.com/OJ/gobuster) - 元祖ディレクトリ列挙ツール
- **🛠️ 使用技術**: [Flutter](https://flutter.dev/) - GoogleのネイティブコンパイルアプリケーションUIツールキット
- **🔒 セキュリティ重視**: ペネトレーションテスターとセキュリティ研究者向けに設計
- **🌍 コミュニティ**: すべての貢献者と支援者に感謝

---

## 📄 ライセンス

本プロジェクトは**オープンソース**で、MITライセンスの下で利用可能です。

---

## ⚠️ 免責事項

本ツールは**許可されたセキュリティテスト**および**ペネトレーションテスト目的のみ**に設計されています。ユーザーはテスト対象のシステムに対して適切な許可を得ていることを確認する責任があります。開発者は本ツールの不正使用に対して責任を負いません。

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---