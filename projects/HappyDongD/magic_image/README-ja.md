﻿<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 魔法AI絵画

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Next.jsを基盤としたAI絵画アプリで、主な機能は以下の通りです：
- 🎨 複数のAIモデル（Sora、DALL-E、GPTなど）およびカスタムモデルの追加に対応
- 🖼️ テキストから画像生成と画像から画像生成機能を提供し、複数画像参照・領域編集に対応
- 🔐 すべてのデータとAPIキーはローカルに保存し、プライバシーを保護
- 💻 Web版およびデスクトップアプリ化に対応し、クロスプラットフォームで利用可能

## オンライン体験

アクセス先：[https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### アプリ画面

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="应用截图1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="应用截图2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="应用截图3" width="800" style="margin-bottom: 20px"/>
</div>

## 機能の特徴

- 🎨 複数のAIモデルに対応
  - GPT Sora_Imageモデル
  - GPT 4o_Imageモデル
  - GPT Image 1モデル
  - DALL-E 3モデル
  - 🆕 カスタムモデル（プライベートモデルの追加対応）
- ✍️ テキストから画像生成機能
  - カスタムプロンプト対応
  - 画像比率の選択可能
  - 複数の画像サイズに対応
- 🖼️ 画像から画像生成機能
  - 画像編集対応
  - 領域マスク編集対応
  - 画質調整対応
  - 複数画像参照（複数画像同時アップロード）
- 🔒 データセキュリティ
  - 生成した画像と履歴はすべてローカルブラウザのみに保存
  - カスタムAPIプロキシアドレス設定可能
  - API Key設定対応
- 📱 UIデザイン
  - モダンなユーザーインターフェース
  - スムーズな操作体験
  - Markdown形式表示
  - コードハイライト対応
- 🖥️ クロスプラットフォーム対応
  - デスクトップアプリ（Windows、macOS、Linux）としてパッケージ化可能
  - オフライン利用対応（API設定が必要）

## 技術スタック

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri（デスクトップアプリパッケージ化）

## ローカル開発

1. プロジェクトをクローンする

```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. 依存関係のインストール

```bash
npm install
# 或
yarn install
# 或
pnpm install
```


3. 開発サーバーの起動

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4.  [http://localhost:3000](http://localhost:3000) にアクセスする

## デスクトップアプリのパッケージ化

本プロジェクトでは Tauri を使用してデスクトップアプリのパッケージ化を行い、Windows、macOS、Linux の各システムをサポートしています。

### 環境準備

デスクトップアプリのパッケージ化前に、以下の依存関係をインストールする必要があります：

1. **Rust のインストール**：
   - [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install) にアクセスする
   - 指示に従い Rust と Cargo をインストールする

2. **システム依存関係**：
   - **Windows**: [Visual Studio C++ ビルドツール](https://visualstudio.microsoft.com/visual-cpp-build-tools/) をインストールする
   - **macOS**: Xcode コマンドラインツールをインストールする (`xcode-select --install`)
   - **Linux**: 関連する依存関係をインストールする。詳細は [Tauri ドキュメント](https://tauri.app/v1/guides/getting-started/prerequisites) を参照

### 開発モード


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### デスクトップアプリの構築


```bash
# 构建桌面应用安装包
npm run desktop
```
ビルド完了後、`src-tauri/target/release/bundle` ディレクトリで対応するシステムのインストーラーを見つけることができます。

## Vercel デプロイ

1. 本プロジェクトをあなたの GitHub アカウントにフォークします

2. [Vercel](https://vercel.com) で新しいプロジェクトを作成します

3. あなたの GitHub リポジトリをインポートします

4. デプロイをクリックします

## 使用方法

1. 初回使用時に API キーを設定する必要があります
   - 右上の「キー設定」をクリックします
   - API キーとベースアドレスを入力します
   - 保存をクリックします
   - URL パラメータでのクイック設定も可能です：


     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     注意：URL 中の特殊文字は URL エンコードが必要です

2. 生成モードの選択
   - 文章から画像へ：テキストの説明で画像を生成
   - 画像から画像へ：画像をアップロードして編集

3. 生成パラメータの設定
   - AIモデルの選択（内蔵モデルまたはカスタムモデル）
   - 画像比率の設定
   - 画像品質の調整（画像から画像モード）

4. カスタムモデル管理
   - モデル選択ボックス横の設定アイコンをクリック
   - 新しいモデルを追加：モデル名、モデル値、モデルタイプを入力
   - モデルを編集：既存モデルの編集ボタンをクリック
   - モデルを削除：既存モデルの削除ボタンをクリック
   - モデルを選択：モデルのプラスボタンをクリックで即選択

5. モデルタイプの説明
   - DALL-E形式：画像生成インターフェースを使用（/v1/images/generations）
   - OpenAI形式：チャットインターフェースを使用（/v1/chat/completions）

6. 画像生成
   - プロンプトを入力
   - 「画像生成」ボタンをクリック
   - 生成完了を待つ

7. 画像管理
   - 履歴を見る
   - 生成画像をダウンロード
   - 既存画像を編集

## 注意事項

- 生成されたすべての画像と履歴はローカルブラウザにのみ保存されます
- プライバシーモードの使用やデバイスの変更でデータが失われる可能性があります
- 重要な画像は速やかにダウンロードしてバックアップしてください
- API設定は安全にブラウザ内に保存され、サーバーにアップロードされません
- HTTPSサイトでHTTPリソースを読み込むとブラウザによりブロックされます。アプリは自動的にHTTPインターフェースをHTTPSに変換します

## 貢献ガイド

IssueやPull Requestの提出を歓迎し、プロジェクト改善にご協力ください。

## ライセンス

本プロジェクトは [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) ライセンスを採用しています。

ライセンスに基づき、以下が可能です：
- ✅ 商用利用：ソフトウェアを商用利用可能
- ✅ 改変：ソースコードの改変可能
- ✅ 配布：ソフトウェアの配布可能
- ✅ 私的利用：個人での利用可能
- ✅ 特許許諾：本ライセンスは特許許諾も提供

ただし以下の条件を守る必要があります：
- 📝 ライセンスと著作権表示：元のライセンスと著作権表示を含めること
- 📝 変更の明示：元のコードに重大な変更を加えた場合、それを明示すること
- 📝 商標の使用禁止：貢献者の商標を使用してはならない

---

## コーヒーを一杯ご馳走してください

このプロジェクトが役に立ったら、コーヒーをご馳走していただけると嬉しいです ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat支払いコード" width="300" />
  <p>コーヒーを一杯ご馳走してください</p>
</div>

## 連絡先

ご質問やご提案があれば、WeChatでお気軽にご連絡ください：

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat連絡先" width="300" />
  <p>QRコードをスキャンしてWeChatを追加</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---