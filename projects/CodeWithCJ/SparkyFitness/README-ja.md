# SparkyFitness - MyFitnessPalのセルフホスト型代替

SparkyFitnessは、ユーザーが栄養、運動、体の測定値を監視するのに役立つ、包括的なフィットネストラッキングおよび管理アプリケーションです。日々の進捗管理、目標設定、洞察に満ちたレポートなど、健康的なライフスタイルをサポートするためのツールを提供します。


## ✨ 機能

### 🍎 栄養トラッキング

* **毎日の食事を記録**
* **カスタム食品やカテゴリを作成・管理**
* **インタラクティブなグラフで要約・傾向分析**

### 💪 運動記録

* **ワークアウトを記録**
* **包括的なエクササイズデータベースを検索・閲覧**
* **フィットネスの進捗を時間をかけてトラッキング**

### 💧 水分摂取量モニタリング

* **毎日の水分補給目標を管理**
* **シンプルで素早い水分記録**

### 📏 体の測定値

* **体のメトリクスを記録**（例：体重、ウエスト、腕など）
* **カスタム測定項目を追加**
* **グラフで進捗を可視化**

### 🎯 目標設定

* **フィットネスや栄養の目標を設定・管理**
* **進捗を時間をかけてトラッキング**

### 🗓️ 毎日のチェックイン

* **毎日のアクティビティをモニター**
* **習慣トラッキングで一貫性を維持**

### 🤖 AI栄養コーチ（SparkyAI）

* **チャットで食品、運動、体の統計、歩数を記録**
* **食品画像をアップロードして自動で食事記録**
* **チャット履歴とパーソナライズされたガイダンス付き**

### 🔒 ユーザー認証 & プロフィール

* **セキュアなログインシステム**
* **ユーザープロフィールの切り替え**
* **家族アクセスと管理のサポート**

### 📊 包括的レポート

* **栄養や体のメトリクスの要約を生成**
* **週・月単位での長期傾向をトラッキング**

### 🎨 カスタマイズ可能なテーマ

* **ライトモード・ダークモードの切り替え**
* **ミニマルで気が散らないインターフェース設計**

### お困りですか？
* **Discordに参加**
  https://discord.gg/vcnMT5cPEA
* **ディスカッションに投稿**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 はじめに

SparkyFitnessアプリケーションをローカルマシンで動作させるには、以下の手順に従ってください。

### 必要条件

*   **Supabaseプロジェクト**: Supabaseプロジェクトの設定が必要です。
    *   **Supabaseで新しいプロジェクトを作成**: [Supabase](https://app.supabase.com/)にアクセスし、新しいプロジェクトを作成します。（希望の場合はローカルSupabaseプロジェクトの設定も可能です）
    *   プロジェクトの設定（APIセクション）からSupabaseプロジェクトURLとAnon Keyを取得します。
    *   **Supabase認証に関する重要な注意:** Supabase認証設定のURL構成を、あなたのドメインに合わせて更新してください。これは、ドメインでの動作やサインアップ用の招待メール受信に必須です。Supabaseは豊富なセキュリティ機能やサードパーティSSOオプションを提供しているので、プロジェクトのニーズに合わせて構成してください。
    *   Supabaseの無料版を利用している場合、IPV4では自動DBデプロイメントが機能しません。そのため、ネットワークをIPV6接続に構成する必要があります。そうしないとDBマイグレーションに失敗し、手動でデプロイする必要があります。       


    

### インストール

1.  **環境変数の設定:**
    privateフォルダの下に `.env` ファイルを作成します。Portainerを使用している場合は、直接そちらで作成してください。
    Supabaseの認証情報を追加します:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Docker Composeで実行:**
    Dockerイメージをプルしてサービスを起動します:
    ```sh
```
docker compose pull
docker compose up -d
```

3.  **アプリケーションへのアクセス:**
    サービスが起動したら、ウェブブラウザでSparkyFitnessにアクセスします:
    ```
    http://localhost:3000
    ```

4.  **AIチャットボット - オプション設定:**
    AIチャットボットの全機能（安全なAPIキー保存やデータベースアクセスを含む）を有効にするには、以下の手順を実行してください:

    *   **`AI_API_ENCRYPTION_KEY`の設定:** 「Supabase -> Edge Functions」->「Environment Variables」でシークレットを生成します。このキーはSupabase内にAIキーを保存する際の暗号化に使用されます。

    *   **`SUPABASE_ACCESS_TOKEN`の生成:**
        1.  Dockerコンソールにアクセスします。
        2.  `supabase login`を実行し、表示されたURLで認証します。
        3.  `cat ~/.supabase/access-token`を実行してアクセストークンを取得します。
        4.  このトークンで`docker-compose.yml`またはPortainerの設定を更新し、再デプロイします。
        5.  再デプロイ後、SparkyFitnessにログインし、お好みのプロバイダーでAIサービスを構成します。
     

### SupabaseへのDBおよび関数の手動デプロイ
**方法1:  
**IPV6ネットワーク接続が有効になっていない場合、DBマイグレーションは失敗します（Supabaseの無料版はIPV4直接接続をサポートしていません）。

   1. 最新リリースをダウンロードし、PCで解凍します。
   2. プロジェクトフォルダに移動します。Dockerが起動している必要があります。
   3. 以下のコマンドを実行します。（functions deployはAI設定時のみ必要。ChatBOTが不要な場合はスキップ可）
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Docker composeを再実行してください。フロントエンドアプリが動作を開始します。

**方法2:  
   1. 最新リリースをダウンロードし、PCで解凍します。  
   2. プロジェクトフォルダに移動します。  
   3. supabase/migrationsに移動し、SQL文をコピーしてSupabase→Project→SQL Editorで順番（ASC）に1つずつ実行します。  
   4. 【オプション】AI ChatBOTが必要な場合はsupabase/functions/chatも同様に実行します。index.jsをコピーし、Supabase→Project→Edge Function→Deploy new functionで実行します。  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---