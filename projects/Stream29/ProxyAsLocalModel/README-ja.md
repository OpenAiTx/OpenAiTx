# ProxyAsLocalModel

リモートLLM APIをローカルモデルとしてプロキシします。特にJetBrains AI AssistantでカスタムLLMを利用する際に有効です。

Ktorとkotlinx.serializationによって実現されています。これらのリフレクション非依存の特徴に感謝します。

## このプロジェクトの経緯

現在、JetBrains AI Assistantは非常に制限された無料プランを提供しています。試してみたところ、すぐに上限に達してしまいました。

私はすでにGeminiやQwenなど他のLLM APIトークンを購入済みでした。そのため、これらをAI Assistantで利用できないかと考え始めました。しかし、LM StudioとOllamaのローカルモデルのみがサポートされていました。そこで、サードパーティ製LLM APIをLM StudioやOllama APIとしてプロキシするこのアプリケーションの開発に着手しました。これにより、JetBrains IDE上でこれらを利用できるようになります。

これはシンプルなタスクだったため、公式SDKをクライアントとして利用し、LM StudioやOllamaのエンドポイントを提供するシンプルなKtorサーバーを書き始めました。しかし、GraalVMネイティブイメージとして配布しようとした際に問題が発生しました。公式のJava SDKは動的機能を多用しており、トレースエージェントを用いてもネイティブイメージへのコンパイルが困難でした。そこで、Ktorとkotlinx.serialization（どちらもリフレクション非依存、関数型、DSLスタイル）を使って、ストリーミングチャット補完APIのシンプルなクライアントを自作することにしました。

ご覧の通り、このアプリケーションはファットランナブルjarおよびGraalVMネイティブイメージとして配布されており、クロスプラットフォームかつ高速起動を実現しています。

このアプリケーションの開発により、Kotlin/Ktor/kotlinx.serializationへの信頼が深まりました。Kotlinの世界はより関数型でリフレクションが少ないため、GraalVMネイティブイメージにより適しており、高速な起動と低メモリ使用を実現します。

## 現在サポートしているもの

プロキシ元: OpenAI, Claude, DashScope(Alibaba Qwen), Gemini, Deepseek, Mistral, SiliconFlow.

プロキシ先: LM Studio, Ollama.

ストリーミングチャット補完APIのみ対応。
## 使い方

このアプリケーションはプロキシサーバーであり、ファット実行可能JARとGraalVMネイティブイメージ（Windows x64）として配布されています。

アプリケーションを実行すると、ヘルプメッセージが表示されます。

```
2025-05-02 10:43:53 INFO  Help - 初めてこのプログラムを起動したようです。
2025-05-02 10:43:53 INFO  Help - デフォルトの設定ファイルが your_path\config.yml にスキーマ注釈付きで作成されました。
2025-05-02 10:43:53 INFO  Config - 設定ファイルウォッチャーが your_path\config.yml で開始されました
2025-05-02 10:43:53 INFO  LM Studio Server - LM Studio Server が 1234 で開始されました
2025-05-02 10:43:53 INFO  Ollama Server - Ollama Server が 11434 で開始されました
2025-05-02 10:43:53 INFO  Model List - モデルリストが読み込まれました: []
```

その後、設定ファイルを編集してプロキシサーバーをセットアップできます。

## 設定ファイル

この設定ファイルは、変更時に自動的にホットリロードされます。影響を受けるサーバー部分のみが更新されます。

初めて設定ファイルを生成する際、スキーマ注釈付きで作成されます。これにより、エディタで補完やチェックが利用できます。
## サンプル設定ファイル

```yaml
# $schema: https://github.com/Stream29/ProxyAsLocalModel/raw/master/config_v3.schema.json
lmStudio:
  port: 1234 # これはデフォルト値です
  enabled: true # これはデフォルト値です
  host: 0.0.0.0 # これはデフォルト値です
  path: /your/path # 元のエンドポイントの前に追加されます。デフォルト値は空です
ollama:
  port: 11434 # これはデフォルト値です
  enabled: true # これはデフォルト値です
  host: 0.0.0.0 # これはデフォルト値です
  path: /your/path # 元のエンドポイントの前に追加されます。デフォルト値は空です
client:
  socketTimeout: 1919810 # デフォルト値は Long.MAX_VALUE、ミリ秒単位
  connectionTimeout: 1919810 # デフォルト値は Long.MAX_VALUE、ミリ秒単位
  requestTimeout: 1919810 # デフォルト値は Long.MAX_VALUE、ミリ秒単位
  retry: 3 # これはデフォルト値です
  delayBeforeRetry: 1000 # これはデフォルト値です、ミリ秒単位

apiProviders:
  OpenAI:
    type: OpenAi
    baseUrl: https://api.openai.com/v1
    apiKey: <your_api_key>
    modelList:
      - gpt-4o
  Claude:
    type: Claude
    apiKey: <your_api_key>
    modelList:
      - claude-3-7-sonnet
  Qwen:
    type: DashScope
    apiKey: <your_api_key>
    modelList: # これはデフォルト値です
      - qwen-max
      - qwen-plus
      - qwen-turbo
      - qwen-long
  DeepSeek:
    type: DeepSeek
    apiKey: <your_api_key>
    modelList: # これはデフォルト値です
      - deepseek-chat
      - deepseek-reasoner
  Mistral:
    type: Mistral
    apiKey: <your_api_key>
    modelList: # これはデフォルト値です
      - codestral-latest
      - mistral-large
  SiliconFlow:
    type: SiliconFlow
    apiKey: <your_api_key>
    modelList:
      - Qwen/Qwen3-235B-A22B
      - Pro/deepseek-ai/DeepSeek-V3
      - THUDM/GLM-4-32B-0414
  OpenRouter:
    type: OpenRouter
    apiKey: <your_api_key>
    modelList:
      - openai/gpt-4o
  Gemini:
    type: Gemini
    apiKey: <your_api_key>
    modelList:
      - gemini-2.5-flash-preview-04-17
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---