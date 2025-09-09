
<div align="right">
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

# 魔法AIイラスト

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Next.js をベースに開発された AI 描画アプリで、以下の主な機能を備えています：
- 🎨 複数の AI モデル（Sora、DALL-E、GPT、GEMINI など）およびカスタムモデルの追加に対応
- 🖼️ テキストから画像生成・画像から画像生成機能、複数画像参照やエリア編集をサポート
- 🔐 全データとAPIキーをローカル保存し、プライバシーと安全性を確保
- 💻 ウェブ版およびデスクトップアプリのパッケージングに対応、クロスプラットフォーム利用可能

## オンライン体験

アクセス先：[https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### アプリのスクリーンショット

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="アプリスクリーンショット4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="アプリスクリーンショット4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="アプリスクリーンショット1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="アプリスクリーンショット2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="アプリスクリーンショット3" width="800" style="margin-bottom: 20px"/>
</div>

## 機能特徴

- 🎨 複数の AI モデル対応
  - GPT Sora_Image モデル
  - GPT 4o_Image モデル
  - GPT Image 1 モデル
  - DALL-E 3 モデル
  - GEMINI モデル
  - 🆕 カスタムモデル（プライベートモデル追加対応）
- 🔄 複数モデルの切り替え
  - 異なるモデル間での高速切り替えに対応
  - 各モデルごとに独立した設定オプション
- ✍️ テキストから画像生成機能
  - カスタムプロンプト対応
  - 画像比率の選択が可能
  - 複数画像サイズに対応
- 🖼️ 画像から画像生成機能
  - 画像編集をサポート
  - エリアマスク編集対応
  - 画像品質調整に対応
  - 複数画像の参照をサポート（複数枚同時アップロード可能）
- 🔒 データセキュリティ
  - 生成された画像や履歴はすべてローカルブラウザのみに保存
  - カスタムAPIプロキシアドレスの設定に対応
  - API Keyの設定に対応
- 📱 UIデザイン
  - モダンなユーザーインターフェース
  - 滑らかなインタラクション体験
  - Markdown形式で表示
  - コードのハイライト対応
- 🖥️ クロスプラットフォーム対応
  - デスクトップアプリ（Windows、macOS、Linux）としてパッケージ化可能
  - オフライン利用に対応（API設定が必要）

## 技術スタック

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri（デスクトップアプリパッケージ化）

## ローカル開発

1. プロジェクトをクローン
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
     注意：URL の特殊文字は URL エンコードする必要があります

2. 生成モードの選択
   - テキストから画像生成：テキスト説明で画像を生成
   - 画像から画像生成：画像をアップロードして編集

3. 生成パラメータの設定
   - AIモデルの選択（内蔵モデルまたはカスタムモデル）
   - 画像の比率設定
   - 画像品質の調整（画像生成モード）

4. カスタムモデル管理
   - モデル選択欄の横にある設定アイコンをクリック
   - 新しいモデル追加：モデル名、モデル値、モデルタイプを入力
   - モデル編集：既存モデルの編集ボタンをクリック
   - モデル削除：既存モデルの削除ボタンをクリック
   - モデル選択：モデルのプラスボタンをクリックして即時選択

5. モデルタイプ説明
   - DALL-E形式：画像生成API（/v1/images/generations）を使用
   - OpenAI形式：チャットAPI（/v1/chat/completions）を使用

6. 画像生成
   - プロンプトを入力
   - 「画像生成」ボタンをクリック
   - 生成完了まで待機

7. 画像管理
   - 履歴の閲覧
   - 生成画像のダウンロード
   - 既存画像の編集

## 注意事項

- 生成されたすべての画像と履歴はローカルのブラウザにのみ保存されます
- プライベートモード利用やデバイス変更でデータが失われます
- 重要な画像は早めにダウンロード・バックアップしてください
- API設定は安全にブラウザ内に保存され、サーバーにはアップロードされません
- HTTPSサイトでHTTPリソースを読み込む場合、ブラウザによりブロックされます。アプリは自動でHTTP APIをHTTPSに変換します

## 貢献ガイド

Issue や Pull Request を提出して、プロジェクトの改善にご協力ください。

## ライセンス

本プロジェクトは [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) ライセンスを採用しています。

ライセンスに従い、以下が可能です：
- ✅ 商用利用：ソフトウェアを商用利用できます
- ✅ 改変：ソフトウェアのソースコードを改変できます
- ✅ 再配布：ソフトウェアを再配布できます
- ✅ 個人利用：ソフトウェアを個人利用できます
- ✅ 特許許諾：本ライセンスは特許の許諾も提供します

ただし、以下の条件を守る必要があります：
- 📝 ライセンスと著作権表示：元のライセンスと著作権表示を含める必要があります
- 📝 変更の明示：元のコードに重大な変更を加えた場合、変更内容を明示する必要があります
- 📝 商標について：コントリビューターの商標を使用してはいけません

---

## コーヒーをご馳走してください

このプロジェクトが役立った場合、ぜひコーヒーをご馳走してください ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat 支払いコード" width="300" />
  <p>コーヒーをご馳走してください</p>
</div>

## 連絡先

ご質問やご提案がありましたら、WeChat でご連絡ください：

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat 連絡先" width="300" />
  <p>QRコードをスキャンして WeChat に追加してください</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---