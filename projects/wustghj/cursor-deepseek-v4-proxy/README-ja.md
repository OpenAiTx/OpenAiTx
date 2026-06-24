# 🧠 Cursor DeepSeek V4 プロキシ

> **Cursor で DeepSeek V4 を使用する際の `reasoning_content` エラーをワンクリックで修正し、`Rate limit exceeded` を解消して AI エージェントモードを安定稼働させます。**

[![GitHub stars](https://img.shields.io/github/stars/你的用户名/cursor-deepseek-v4-proxy?style=social)](https://github.com/你的用户名/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 このプロジェクトで解決できること

Cursor で DeepSeek V4（Pro / Flash）を呼び出す際に、以下のいずれかのエラーが頻繁に発生する場合：

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded`（残りクォータが十分なのにエラーが出る）
* `AI Model Not Found: deepseek-v4-pro`（バックグラウンドタスクでモデル名が無効と報告される）
* チャットの1回目は正常だが、2回目以降にエラーや中断が発生する

**もう悩む必要はありません。このガイドに沿って5分で完全に解決できます。**

> ⚠️  **2026-05-14 修正**：プレーンテキストモデルで画像を自動フィルタリングするようになり、502エラーを解消しました。詳細は [更新ログ](#changelog) をご覧ください。

---

## ✨ 主な機能

* ✅ **自動キャッシュ＆思考チェーンの再送信**：`reasoning_content` の欠落によるエラーを防ぎます。
* ✅ **スマートレートリミット**：トークンバケット内蔵で突発的な同時リクエストによる無料枠の枯渇を防止。
* ✅ **ストリーミング出力対応**：Cursor のタイプライター描画に影響を与えません。
* ✅ **ワンクリックスクリプト起動**：Windows / macOS / Linux 共通でダブルクリックで実行可能。
* ✅ **透明なログ出力**：端末にリアルタイムでリクエスト状況を表示し、トラブルシューティングに便利。
* ✅ **ゼロインベイジョン**：Cursor のプログラムファイルを変更せず、Base URL のみ変更。

---

## 🖥️ 対応環境

| OS | サポート状況 |
| :--- | :--- |
| **Windows 10 / 11** | ✅ 対応 |
| **macOS** | ✅ 対応 |
| **Linux** | ✅ 対応 |

> **唯一の要件**：**Python 3.8** 以上をインストールしてください（インストール時に必ず `Add Python to PATH` をチェックしてください）。

---

## 🚀 超詳細な3ステップで始める（初心者向け）

### ステップ1：プロジェクトをダウンロードし依存関係をインストール

1.  本プロジェクトのリポジトリのZIPファイルをダウンロードし、ローカルに解凍します（**パスに日本語を含めないでください**）。
2.  解凍したフォルダに入り、フォルダのアドレスバーに `cmd` と入力してEnterを押し、コマンドプロンプトを開きます。
3.  以下のコマンドを実行して依存関係をインストールします：
    ```bash
    pip install -r requirements.txt
    ```
    *若提示 `pip不是内部命令`，请重新安装 Python 并勾选 `Add to PATH`。*

### 第二步：起動ローカルプロキシ + トンネル

パブリックアドレスを生成するためのトンネルが必要です（Cursorはlocalhostへのアクセスを制限しています）。

#### 🪟 Windows ユーザー
1.  フォルダ内に `cloudflared-windows-amd64.exe` があることを確認してください（ない場合は [Cloudflare公式サイト](https://github.com/cloudflare/cloudflared/releases) からダウンロードしてください）。
2.  **`start_proxy.bat`** をダブルクリックして実行します。
3.  2つのウィンドウが開きます。**トンネルウィンドウ**で、`https://xxx.trycloudflare.com` の形式のURLを見つけて**コピー**してください。

#### 🍎 macOS / Linux ユーザー
1.  ターミナルでプロジェクトディレクトリに移動し、次のコマンドを実行します：
    ```bash
    bash start_proxy.sh
    ```
2.  少し待って、ターミナル出力の `https://xxx.trycloudflare.com` アドレスをコピーします。

> ⚠️ **注意**：ウィンドウを閉じないでください。トンネルのアドレスは再起動ごとに変わりますが、ウィンドウを閉じなければ常に有効です。

### 第三歩：Cursorの設定

1.  Cursorの設定を開く：`Ctrl+Shift+P` を押して → `Cursor Settings` と入力。
2.  **Models** タブに移動。
3.  **"Override OpenAI Base URL"** に先ほどコピーしたアドレスを貼り付け、**末尾に `/v1` を追加**：
    * 例：`https://xxxxxx.trycloudflare.com/v1`
4.  APIキー欄にあなたの **DeepSeek API Key** を入力。
5.  **Cursorを完全に終了し、再起動します**。

---

## 🛡️ "Model name not valid" エラーの修正

Applyやバックグラウンドタスクでエラーが発生した場合、以下の手順を実行してください：

1.  `Ctrl+Shift+P` を押し、`Preferences: Open User Settings (JSON)` と入力してEnter。
2.  JSONの中括弧 `{}` の内側に次の設定を追加：
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  保存して Cursor を再起動します。

---

## ❓ よくある質問 (FAQ)

<details>
<summary>🔁 トンネルアドレスが変わったらどうする？</summary>
スクリプトを再起動するたびに新しいアドレスが生成されます。Cursor の Base URL を再取得して更新してください。
</details>

<details>
<summary>💸 それでも Rate limit exceeded が出る？</summary>
DeepSeek の無料プランは頻度が非常に低いです。`proxy.py` を編集し、`TokenBucket(rate=5/60.0, capacity=5)` の `5` を（例えば `3` に）小さくしてリクエスト頻度を強制的に下げられます。
</details>

<details>
<summary>🚫 トンネルは必須？localhost に接続できない？</summary>
Cursor はセキュリティ上の理由で直接 `localhost` への接続を禁止しています。Cloudflare Tunnel は現在最も簡単で無料、登録不要のトンネルソリューションです。
</details>

<details>
<summary>🧪 代理はモデルの知能に影響する？</summary>
99% のケースで無感知です。代理はモデルが思考の連鎖を「忘れた」時に自動補完を行い、対話の途切れを防ぎます。
</details>

<details>
<summary>🧪 なぜ 200k コンテキストで、1M ではないの？</summary>
これは Cursor のデフォルト制限であり、代理の問題ではありません。

Cursor はデフォルトで 200k のコンテキストウィンドウを使用します。
モデルのサポートする 1M コンテキストを有効にするには、Cursor Chat で `Max Mode` をオンにしてください。
パス：
Chat -> Model Selector -> Max Mode
</details>

---

## ⚙️ 高度なカスタマイズ

* **上流の変更**：`proxy.py` の `UPSTREAM_URL` を修正します。
* **固定ドメイン**：独自ドメインをお持ちの場合は、Cloudflare ネームトンネル（Persistent Tunnel）を設定できます。

<a name="changelog"></a>
## 🆕 更新履歴

### 2026-05-14：プレーンテキストモデルの画像対応修正

**修正内容**
Cursor などのクライアントが `deepseek-v4-pro`（プレーンテキストモデル）に画像を含むメッセージを送信した際、プロキシ層は現在 `image_url` の内容ブロックを自動でフィルタリングし、テキスト部分のみを保持します。メッセージが全て画像（テキストなし）の場合は、モデルが空メッセージを受け取らないように代替のテキストに置き換えます。
本修正は DeepSeek API が `"unknown variant image_url, expected text"` を返し 502 エラーとなる問題を解決しました。

**追加改善**

- 上流のエラー返却フォーマットを統一し、クライアントが構造化された JSON エラーを受け取れるように（元のエラーや空白ページではなく）。
- 画像対応ロジックは推論キャッシュ（`reasoning_content`）に影響せず、履歴メッセージの処理は正常に保たれています。

------

### 謝辞

Issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4) にてレート制限問題を報告いただいた [@BG-ah](https://github.com/BG-ah) と、議論に参加いただいた [@CH-nolyn](https://github.com/CH-nolyn) に感謝します。皆様のフィードバックが今回の互換性修正を促進し、プレーンテキストモデルでの安定した動作に寄与しました。

------

> 💡 **ヒント**：モデルに画像内容を正しく理解させたい場合は、リクエストの `model` フィールドをマルチモーダル対応の `deepseek-chat` に変更し、DeepSeek アカウントで対応権限が有効になっていることを確認してください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-24

---