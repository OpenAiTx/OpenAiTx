# [Historic Borders](https://historicborders.app/)

異なる歴史時代（紀元前2000年～1994年）の国境を視覚化

[r/dataisbeautiful](https://www.reddit.com/r/dataisbeautiful/comments/l52krh/an_app_i_made_for_visualizing_country_borders/)で紹介されました。

## スクリーンショット

<img width="1023" alt="screen-shot-of-app" src="https://user-images.githubusercontent.com/10817537/175097196-e746778d-241a-4bee-b406-aac294849597.png">

## 機能

### 情報ソース

アプリは2つの情報ソースから国情報を提供します：

1. **Wikipedia**（デフォルト） - Wikipediaからリアルタイム情報を取得
2. **AI搭載** - Google Gemini AIを使い、歴史的文脈を含む国情報を生成

フッターのトグルボタンでこれらのソースを切り替え可能です。

### AIレスポンスのキャッシュ

アプリは**Redis**を使ってAIレスポンスをキャッシュし、パフォーマンスを向上させています：

- ⚡ 以前にリクエストされた国や年に対して**即時応答**
- 💰 **APIコスト削減** - Google Geminiへの呼び出し回数を削減
- 🔧 **スマートな有効期限** - 1時間のキャッシュTTLで内容を新鮮に保つ
- 📊 **分析追跡** - Google Analyticsでキャッシュヒット/ミス率を追跡

詳細なセットアップ手順は[REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md)を参照してください。

### AI機能の分析

アプリはAI機能のユーザーエンゲージメントとパフォーマンスを把握するため、Google Analyticsによる包括的な追跡を行っています：

#### 追跡イベント

**プロバイダー利用状況：**
- `toggle_provider` - ユーザーがWikipediaとAIを切り替えたとき
- `enable_ai` / `disable_ai` - AI機能の有効化／無効化
- `provider_restored` - localStorageから設定が読み込まれたとき
- `session_provider_active` - セッションごとのアクティブプロバイダー

**AIリクエスト:**
- `request_initiated` - AIリクエスト開始
- `response_success` - AIリクエスト成功
- `response_time_success` - 成功したリクエストの応答時間
- `response_length` - AI応答の文字数
- `response_word_count` - AI応答の単語数
- `request_failed` - AIリクエスト失敗
- `api_error` - ステータスコード付きのAPI固有エラー
- `api_key_missing` - APIキーがないイベント

**キャッシュパフォーマンス:**
- `cache_hit` - Redisキャッシュからの応答（高速）
- `cache_miss` - キャッシュなし、API呼び出し実行
- `cache_error` - Redis利用不可（APIにフォールバック）
- `cache_write_success` - 応答のキャッシュ成功
- `cache_write_error` - 応答のキャッシュ失敗

**コンテンツ表示:**
- `popup_displayed` - AIとWikipediaコンテンツのポップアップ表示時
- `content_displayed` - コンテンツ表示成功
- `content_error_displayed` - ユーザーにエラーコンテンツ表示
- `content_empty_displayed` - 空またはコンテンツなしのシナリオ
- `popup_closed` - ユーザーが情報ポップアップを閉じた時

**パフォーマンス指標:**
- 応答時間（成功／失敗）
- コンテンツ品質指標（単語数、文字数）
- エラー率と種類
- ユーザーエンゲージメントパターン

#### 分析カテゴリ

すべてのAI関連イベントは、Googleアナリティクスで簡単にフィルタリングできるようにカテゴリ `"AI Feature"` を使用します。

#### データプライバシー

アナリティクストラッキングは匿名化されており、個人情報ではなく機能の使用パターンに焦点を当てています。APIキーや機密データは追跡されません。

## セットアップ

### 前提条件

- Node.js 18+ と yarn
- Google Gemini APIキー（無料プランあり）
- Google Analytics 4 プロパティ（任意、分析用）

### インストール

```bash
git clone https://github.com/nrgapple/historic-country-borders-app.git
cd historic-country-borders-app
yarn install
```

### 環境変数

`.env.local` ファイルを作成します:

```bash
# Optional for analytics
NEXT_PUBLIC_GA_FOUR=your_google_analytics_id

# Optional for map features
NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token

# Redis for AI response caching (required for caching)
REDIS_URL=your_redis_connection_string

# Required for AI features (server-side only)
GEMINI_API_KEY=your_gemini_api_key_here
```
### APIキーの取得

#### Google Gemini API（無料）

1. [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key) にアクセス
2. Googleアカウントでサインイン
3. **「Create API Key」** をクリック
4. 生成されたキーを `.env.local` ファイルにコピー

**利点:**
- ✅ 1分あたり60リクエスト（寛大な無料枠）
- ✅ クレジットカード不要
- ✅ 高品質なAI応答
- ✅ 優れた歴史知識

#### キャッシュ用Vercel Redis（任意だが推奨）

1. Vercelまたは任意のRedisプロバイダーでRedisをセットアップ
2. プロジェクトに `REDIS_URL` 環境変数を追加
3. 詳細は [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) を参照

**利点:**
- ⚡ キャッシュされたコンテンツの即時応答
- 💰 API使用量とコストの削減
- 🔧 自動で1時間のキャッシュ期限
- 📊 キャッシュパフォーマンス分析

#### Google Analytics 4（任意）

1. [Google Analytics](https://analytics.google.com/) にアクセス
2. 新しいGA4プロパティを作成
3. 計測IDを取得（形式：G-XXXXXXXXXX）
4. `.env.local` ファイルに追加

### 開発


```bash
yarn dev
```

アプリを見るには [http://localhost:3000](http://localhost:3000) を開いてください。

### テスト

```bash
# Run all tests
yarn test

# Run tests in watch mode
yarn test:watch

# Run specific test files
yarn test hooks/__tests__/useAI.test.tsx
```
## AI機能トラブルシューティング

### よくある問題

**「AI情報にはGemini APIキーの設定が必要です」**
- Gemini APIキーを`.env.local`に追加してください
- 開発サーバーを再起動してください
- 詳細な設定は[GEMINI_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./GEMINI_SETUP.md)を参照してください

**AI応答が遅い**
- 通常の応答時間：1～3秒
- インターネット接続を確認してください
- Gemini APIにはレート制限があります（60リクエスト/分）

**空の応答またはエラー応答**
- 一時的にWikipediaに切り替えてみてください
- ブラウザのコンソールで詳細なエラーメッセージを確認してください
- APIキーが有効かどうかを確認してください

### アナリティクスダッシュボード

Google AnalyticsでAI機能の分析を見るには：

1. **Events** → **All Events**に移動
2. **Event Category** = "AI Feature"でフィルター
3. 監視すべき主要な指標：
   - `toggle_provider` - 機能の採用状況
   - `response_success` 対 `request_failed` - 成功率
   - `response_time_success` - パフォーマンス
   - `content_displayed` - ユーザーエンゲージメント

### パフォーマンス監視

アプリは複数のパフォーマンス指標を追跡しています：

- **応答時間**：AI応答時間の平均とWikipediaの比較
- **成功率**：AIリクエストの成功/失敗比率
- **コンテンツの質**：AI応答の単語数と長さ
- **ユーザーエンゲージメント**：AIとWikipediaコンテンツのユーザーの関わり方

## 貢献方法

1. リポジトリをフォークする
2. 機能ブランチを作成する
3. 変更を加える
4. 新機能のためのテストを追加する
5. すべてのテストが通ることを確認する
6. プルリクエストを提出する

## ライセンス

MITライセンス - 詳細は[LICENSE](LICENSE)を参照してください。

## 謝辞

- 歴史的国境データ提供：[World Historical Gazetteer](https://whgazetteer.org/)
- AI技術提供：[Google Gemini](https://ai.google.dev/)
- 地図提供：[Mapbox](https://www.mapbox.com/)
- アナリティクス提供：[Google Analytics 4](https://analytics.google.com/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---