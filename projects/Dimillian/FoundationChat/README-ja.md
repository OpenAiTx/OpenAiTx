
# FoundationChat

AppleのFoundation Modelsフレームワークを用いて構築されたSwiftUIチャットアプリケーションで、オンデバイスAI機能と持続的な会話保存を実現しています。

![Preview](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/Images/image.png)

## 要件

- **iOS 26.0+** / iPadOS 26.0+ / macOS 26.0+ / visionOS 26.0+
- **Xcode 26.0+**（iOS 26 SDKを含む）
- Apple Intelligence対応デバイス
- 設定でApple Intelligenceが有効になっていること

## 機能

- ✅ **複数会話対応**：複数のチャット会話を作成・管理可能
- ✅ **持続的ストレージ**：SwiftData統合による会話履歴保存
- ✅ **リアルタイムストリーミング**：構造化された出力でのライブ応答
- ✅ **スマート要約**：自動的な会話要約生成
- ✅ **ツール統合**：メタデータ抽出を伴うウェブページ解析
- ✅ **リッチメッセージ表示**：サムネイルと説明付きの添付ファイル対応
- ✅ **利用可否確認**：Foundation Modelsの利用可能性を適切に処理
- ✅ **モダンなSwiftUI**：ナビゲーションスタックとスワイプ操作によるクリーンなUI
- ✅ **オンデバイスAI**：インターネット不要で完全なプライバシー保護
- ✅ **エラーハンドリング**：UI上での優雅なエラー表示

## アーキテクチャ

### コアコンポーネント

- **`ChatEngine`**：Foundation Modelsのセッション管理およびストリーミング応答処理
- **`Conversation`** & **`Message`**：持続的ストレージのためのSwiftDataモデル
- **`MessageGenerable`**：ウェブメタデータを含む構造化AI応答用の@Generable構造体
- **`ConversationsListView`**：会話管理のメインインターフェース
- **`ConversationDetailView`**：ストリーミングメッセージ対応のチャット画面
- **`WebAnalyserTool`**：ウェブページから構造化データを抽出するツール

### データフロー

1. **会話リスト**：最終メッセージのタイムスタンプ順にすべての会話を表示
2. **チャット画面**：リアルタイムストリーミングとSwiftDataによる永続化
3. **メッセージストリーミング**：構造化AI応答に`@Generable`を使用
4. **自動要約**：各やり取り後に会話の要約を更新

## はじめに

1. Xcodeで`FoundationChat.xcodeproj`を開く
2. 開発デバイスでApple Intelligenceが有効になっていることを確認
3. 対応デバイスでビルド・実行（パフォーマンスのためシミュレータは推奨されません）
4. 「＋」ボタンで新しい会話を作成
5. オンデバイスAIとチャットを開始

## 主要実装詳細

### Foundation Models統合

```swift
@Observable
class ChatEngine {
    private let model = SystemLanguageModel.default
    private let session: LanguageModelSession
    
    var isAvailable: Bool {
        switch model.availability {
        case .available: return true
        default: return false
        }
    }
}
```
### ストラクチャードストリーミングレスポンス

```swift
func respondTo() async -> LanguageModelSession.ResponseStream<MessageGenerable>? {
    session.streamResponse(generating: MessageGenerable.self) {
        // Conversation context with full history
    }
}
```
### ツール統合

```swift
struct WebAnalyserTool: Tool {
    let name = "WebAnalyser"
    let description = "Analyse a website and return structured content"
    
    func call(arguments: Arguments) async throws -> ToolOutput {
        // Extracts title, thumbnail, and description
    }
}
```
### SwiftData 永続化

```swift
@Model
class Conversation {
    @Relationship(deleteRule: .cascade)
    var messages: [Message]
    var summary: String?
}
```


## ドキュメンテーション

- **[CLAUDE.md](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/CLAUDE.md)** - 開発ガイドラインとフレームワークの概要
- **[Examples](EXAMPLES/)** - 包括的な実装例：
  - 基本的な使い方
  - 構造化された出力
  - ストリーミング応答
  - ツール呼び出し
  - パフォーマンスと安全性
  - 完全なチャットアプリ

## プロジェクト構成


```
FoundationChat/
├── Models/
│   ├── SwiftData/          # Data persistence models
│   └── Generable/          # Foundation Models structures
├── Views/
│   ├── ConversationsList/  # Main conversation list
│   └── ConversationDetail/ # Chat interface with message views
├── Tools/
│   └── WebAnalyserTool.swift # Web content extraction tool
├── Env/
│   └── ChatEngine.swift    # Foundation Models integration
└── FoundationChatApp.swift # App entry point
```
## 貢献について

これはAppleのFoundation Modelsフレームワークを紹介するデモプロジェクトです。自由に以下を行ってください：
- フォークして様々なAIプロンプトを試す
- Foundation Modelsの追加機能を拡張する
- 新しいUIコンポーネントやインタラクションを追加する
- 改善点やバグ修正に貢献する

## ライセンス

MITライセンス - 詳細はLICENSEファイルを参照してください


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---