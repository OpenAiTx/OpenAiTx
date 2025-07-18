<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E: AI時代のあなたのデジタル脳

<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>ドキュメント</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine（文脈観察・想起エンジン）**

C.O.R.Eは、あなたのLLMとのやり取りや個人データから構築されるポータブルなメモリーグラフで、すべての文脈やワークフロー履歴を、まるでデジタル脳のように、どんなAIツールからでも利用可能にします。これにより、繰り返し文脈を共有する必要がなくなります。目指すのは以下の通りです：

- **統合されたポータブルメモリー**：シームレスに文脈を追加・想起し、Claude、Cursor、Windsurfなどのアプリ間でメモリーを接続できます。
- **関係性を持つ、単なる平坦な事実以上**：COREは知識を整理し、事実だけでなく関係性も保存することで、本物の脳のようにより深く豊かな記憶を実現します。
- **ユーザー所有**：保存・更新・削除する内容を自分で決め、好きなツール間でメモリーを共有でき、ベンダーロックインから解放されます。

## 🎥 デモ動画

[COREデモを見る](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  主な特徴

- **メモリーグラフ**：事実や好みがどのようにつながっているかを可視化
- **メモリーと会話**：記憶について質問して即座に洞察や理解を得る
- **プラグアンドプレイ**：CursorやClaudeなどのアプリですぐにCOREメモリーを利用可能

## ☁️ C.O.R.E クラウドセットアップ

1. [Core Cloud](https://core.heysol.ai)にサインアップし、メモリーグラフの構築を始めます。
2. メモリーに保存したいテキストを追加します。`+ Add`ボタンをクリックすると、メモリーグラフが生成されます。
3. [Core Memory MCPをCursorと接続](#connecting-core-mcp-with-cursor)

## 💻 C.O.R.E ローカルセットアップ

#### 前提条件

1. Docker
2. OpenAI APIキー


> **注意:** Llamaモデルのサポート強化に積極的に取り組んでいます。現時点では、C.O.R.EはLlamaベースのモデルで最適な結果を提供できませんが、近い将来より良い互換性と出力を実現するために進歩を続けています。
> 
#### C.O.R.Eをローカルで実行する

1. **環境変数をコピー**

   サンプルの環境ファイルを `.env` にコピーします:


   ```bash
   cp .env.example .env
   ```
2. **アプリケーションの起動**

   必要なすべてのサービスを起動するには、Docker Composeを使用します:


   ```bash
   docker-compose up
   ```
3. **アプリにアクセスする**

   コンテナが起動したら、ブラウザを開き [http://localhost:3000](http://localhost:3000) にアクセスしてください。

4. **マジックリンクでアカウントを作成する**

   - アカウントを作成するには、`Continue with email` ボタンをクリックします

     <img width="865" height="490" alt="Create account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - メールアドレスを入力し、`Send a Magic Link` ボタンをクリックします

     <img width="824" height="429" alt="Enter email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `ターミナルのログからマジックリンクをコピー`し、ブラウザで開きます

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **プライベートスペースを作成しデータを追加する**

   - ダッシュボードの右上セクションへ移動し、メッセージを入力します。例：`I love playing badminton`、そして `+Add` をクリックします。
   - メモリは処理待ちキューに入り、そのステータスは `Logs` セクションで確認できます。
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - 処理が完了すると、ノードがプライベートナレッジグラフに追加され、ダッシュボードに表示されます。
   - 後でこのメモリを他のツールと連携するか、非公開のままにすることができます。

6. **メモリを検索する**

   - ダッシュボードの検索機能を使い、プライベートスペース内の取り込んだデータをクエリできます。


## CORE MCPとCursorの接続

1. COREダッシュボードを開き、APIセクションに移動して新しいAPIトークンを生成します。
2. Cursorでは、設定 → ツールと統合 → 新規MCPサーバーに移動します。
3. 以下の構成フォーマットを使用してCORE MCPサーバーを追加します。ステップ1で生成したAPIトークンをAPI_TOKEN値に必ず置き換えてください。

   Cursorに追加するMCP構成


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. 設定 -> ユーザー規則 -> 新規規則 -> に移動し、以下の規則を追加して、すべてのチャットのやり取りがCOREメモリに保存されるようにします。


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## ドキュメンテーション

COREを最大限に活用するためにドキュメントを参照してください
- [基本概念](https://docs.heysol.ai/core/overview)
- [APIリファレンス](https://docs.heysol.ai/core/local-setup)
- [Core Memory MCPとCursorの接続](#connecting-core-mcp-with-cursor)


## 🧑‍💻 サポート
質問やフィードバックがありますか？私たちがサポートします：
- Discord: [core-supportチャンネルに参加](https://discord.gg/YGUZcvDjUa)
- ドキュメンテーション: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- メール: manik@poozle.dev

## 利用ガイドライン

**保存するもの：**

- 会話履歴
- ユーザーの好み
- タスクのコンテキスト
- 参考資料

**保存しないもの：**

- 機微なデータ（個人識別情報）
- 認証情報
- システムログ
- 一時データ

## 👥 コントリビューター

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---