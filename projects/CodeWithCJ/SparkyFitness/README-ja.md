<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

自己ホスト型・プライバシー重視のMyFitnessPal代替アプリ。栄養・運動・身体指標・健康データを記録し、データの完全なコントロールを維持できます。

![スクリーンショット](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitnessは以下で構成される自己ホスト型フィットネストラッキングプラットフォームです：

- バックエンドサーバー（API＋データストレージ）
- ウェブベースのフロントエンド
- iOSとAndroid向けのネイティブモバイルアプリ

インフラストラクチャを自分で管理し、サードパーティサービスに依存せずに健康データを保存・管理します。

## コア機能

- 栄養、運動、水分補給、睡眠、断食、気分、体測定のトラッキング
- 目標設定と日々のチェックイン
- インタラクティブなチャートと長期レポート
- 複数ユーザープロファイルと家族アクセス
- ライト・ダークテーマ
- OIDC、TOTP、Passkey、MFAなど

## 健康＆デバイス連携

SparkyFitnessは複数の健康・フィットネスプラットフォームからデータ同期が可能です：

- **Apple Health**（iOS）
- **Google Health Connect**（Android）
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow**（部分的にテスト済み）
- **Hevy**（未テスト）
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava**（部分的にテスト済み）

連携機能により、歩数、ワークアウト、睡眠などのアクティビティデータや、体重や体測定値などの健康指標が自動的にSparkyFitnessサーバーに同期されます。

## オプションAI機能（ベータ版）

SparkyAIはデータ記録と進捗確認のための会話型インターフェースを提供します。

- チャットで食事、運動、身体統計、歩数を記録
- 食事画像をアップロードして自動的に食事記録
- フォローアップのために会話履歴を保持

注：AI 機能は現在ベータ版です。

## クイックスタート（サーバー）

Docker Compose を使って数分で SparkyFitness サーバーを起動できます。

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```
## 🎥 ビデオチュートリアル

[![ビデオを見る](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

SparkyFitness（セルフホスト型フィットネストラッカー）のインストール方法を2分で簡単に解説したチュートリアルです。

## ドキュメント

インストールガイド、設定オプション、開発用ドキュメントの詳細は[ドキュメントサイト](https://codewithcj.github.io/SparkyFitness/)をご覧ください。

### クイックリンク

- **[インストールガイド](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - デプロイと設定方法
- **[機能概要](https://codewithcj.github.io/SparkyFitness/features)** - 全機能の詳細ドキュメント
- **[開発ワークフロー](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 開発者向けガイドとコントリビューション手順
- **[iOSアプリ情報](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** および **[Androidアプリ情報](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### サポートが必要ですか？

- Githubのイシュー／ディスカッションに投稿してください。
- より早い回答や他のコミュニティメンバーからのサポートを得るには **[Discordに参加](https://discord.gg/vcnMT5cPEA)** してください。

## スター履歴

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="スター履歴チャート" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 翻訳

**[Weblate 翻訳](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">



<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="翻訳状況" />
</a>

## リポジトリアクティビティ

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats分析画像")

## コントリビューター

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ 既知の問題 / ベータ機能 ⚠️

SparkyFitnessは積極的に開発中です。
リリース間で重大な変更が発生する可能性があります。

- コンテナの自動アップデートは推奨されません
- アップグレード前に必ずリリースノートを確認してください

以下の機能は現在ベータ版であり、十分なテストが行われていない場合があります。バグや機能の不完全さが予想されます：

- AIチャットボット
- ファミリー＆フレンズアクセス
- APIドキュメント


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---