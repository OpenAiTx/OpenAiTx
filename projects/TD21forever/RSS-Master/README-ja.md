# RSS-Master

RSSフィードのカスタムフィルタリング、絞り込み、AIによる要約、概括、スコアリングなどを行います。パフォーマンス最適化版で、非同期処理と並列AI要約に対応しています。

### はじめに

9月初旬に、Inoreader + RSSHubを使って興味のあるRSSを集約・購読し、Reederで読むことで、毎日の情報源を完全にコントロールしようとしました。1ヶ月経つと増え続けるRSSフィードと未読情報が読書の不安を増大させ、何かカスタムフィルタルールを設定でき、できればAIを活用して読書負担を軽減する方法がないか考えました。

Inoreaderにはフィルター機能がありますが、それだけのために課金するのは割に合わないと感じました。NewsBlurには「Intelligence Trainer」というスマート分類機能がありますが、試した限りでは効果があまり感じられませんでした。FeedlyはフィルタリングとAI機能を備えていてニーズに合いそうでしたが、InoreaderからFeedlyの有料ユーザーに移行しようか迷っていた時に、以下の2つのプロジェクトに出会いました。

- [ChatGPTでHacker Newsを要約する](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT使用ガイド](http://yinan.me/rss-gpt-manual-zh.html)

これらのプロジェクトの基本的な考え方は、GitActionを使ってスクリプトを実行し、情報を取得後OpenAIのAPIで翻訳・要約し、テンプレートにレンダリングしてGitHub Pageにデプロイするものです。RSS-GPTの方式は私のニーズにより合っており、定期実行でRSSのxmlファイルを直接取得し処理後にGitHub Pageへデプロイし、そのxmlファイルのアクセスリンクを取得、最後にリーダーがこのリンクを直接購読する形です。

私はInoreaderのマルチデバイス同期を強く求めており、config設定ファイルに新規追加されたRSSフィードをInoreaderに即時通知して同期させる必要がありました。そこで[RSS-GPT](https://github.com/yinan-c/)の考え方を拡張し、「RSS-Master」と名付けました。

### 機能特徴

- **並列処理対応**：非同期とスレッドプールを使い、RSSフィードとAI要約の並列処理を実現し処理速度を大幅に向上
- **強化されたキャッシュ機構**：より安定したキャッシュシステムでデータ損失防止と重複アクセス性能向上
- **優れたエラーハンドリング**：全操作に完全なエラーハンドリングとログ記録を実装し安定性を向上
- **HTML内容の最適抽出**：記事内容をスマートに抽出し、無関係な情報を無視してAI要約品質を向上
- **最新のOpenAI API対応**：最新バージョンのOpenAI APIに完全対応
- **詳細な統計情報**：処理完了後に実行時間、成功率、コスト統計を提供
- **opmlファイル生成対応**：config.ymlとの相互変換をサポート：`script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **カスタムフィルタルール対応**：include、excludeの2種タイプとtitle、articleの2種スコープをサポート
- **AIモデルのカスタマイズ可能**：環境変数で異なるOpenAIモデルの設定が可能
- **基本URLのカスタマイズ可能**：RSSファイルのベースアクセスURLを設定でき、異なる環境でのデプロイを容易化
- **インタラクティブテストノートブック**：Jupyterノートブックで各機能のテストが可能

### 環境変数設定

プロジェクトは`.env`ファイルで以下パラメータの設定をサポートしています：

```
# 必須パラメータ
OPENAI_API_KEY=your_openai_api_key_here

# 任意パラメータ
RSS_BASE_URL=https://example.com/rss-feeds/  # RSSベースURL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAIモデル
LOG_LEVEL=INFO                               # ログレベル
PARALLEL_WORKERS=5                           # 並列処理数
```

`.env.example`をコピーして`.env`にリネームし、パラメータ値を編集してください。

### パフォーマンス改善

本バージョンは元バージョンに比べ以下の性能改善を実現しています：

1. **RSSフィードの並列処理**：`asyncio`を使い複数のRSSフィードを同時処理
2. **AI要約の並列化**：スレッドプールを活用し複数記事のAI要約を並行処理
3. **テキスト処理の最適化**：HTML内容抽出アルゴリズムを改良し記事の重要内容をよりスマートに抽出
4. **安全なファイル処理**：安全なファイル書き込み機構を採用し、プログラムクラッシュによるデータ損失を防止
5. **メモリ使用の最適化**：データ構造と処理フローを改善しメモリ使用量を削減

### 使い方

1. プロジェクトをローカルにクローン
2. 依存関係をインストール：`pip install -r requirements.txt`
3. `.env`ファイルを作成しOpenAI APIキーを設定：`OPENAI_API_KEY=あなたのキー`
4. `resource/config.yml`を編集してRSSフィードを設定
5. `python main.py`を実行して処理開始

### テストとデバッグ

プロジェクトはインタラクティブなテストノートブック`test.ipynb`を提供し、以下の機能テストが可能です：

1. RSSフィード取得と解析
2. フィルタ機能
3. AI要約機能
4. キャッシュ機構
5. カスタム基本URL
6. パフォーマンステスト

使用方法：

```bash
# Jupyterのインストール
pip install jupyter

# ノートブック起動
jupyter notebook test.ipynb
```

### カスタムフィルタルール例

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          'コーラ',
          'スプライト',
          'ファンタ',
          'レモン',
          'お茶',
          'ティッシュ',
          'アルコール',
          'ウェットティッシュ',
          'ナプキン',
        ]
```

### 使用スクリーンショット

- AIによる概括・要約機能

<div style="display: flex;">
    <img src="https://qiniu.dcts.top/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://qiniu.dcts.top/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- カスタムフィルタ：『什么值得买』のお得情報チャンネルから、最近まとめ買いしたい商品（例：炭酸飲料）のみを推薦

<img src="https://qiniu.dcts.top/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400; height: 400;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---