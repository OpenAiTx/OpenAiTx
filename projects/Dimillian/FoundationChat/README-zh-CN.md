<translate-content># FoundationChat

一个基于 SwiftUI 的聊天应用，使用苹果的 Foundation Models 框架构建，展示了设备端 AI 能力和持久化对话存储。

![预览](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/Images/image.png)

## 要求

- **iOS 26.0+** / iPadOS 26.0+ / macOS 26.0+ / visionOS 26.0+
- **Xcode 26.0+**（包含 iOS 26 SDK）
- 支持 Apple Intelligence 的设备
- 设备设置中需启用 Apple Intelligence

## 功能

- ✅ **多会话支持**：创建和管理多个聊天会话
- ✅ **持久化存储**：集成 SwiftData 以保存会话历史
- ✅ **实时流式**：带结构化输出的实时响应流
- ✅ **智能摘要**：自动对话内容总结
- ✅ **工具集成**：网页分析及元数据提取
- ✅ **丰富信息展示**：支持带缩略图和描述的附件显示
- ✅ **可用性检测**：合理处理 Foundation Models 的可用性
- ✅ **现代 SwiftUI**：简洁界面，导航堆栈及滑动操作
- ✅ **设备端 AI**：无需互联网，完全隐私保护
- ✅ **错误处理**：UI 中优雅显示错误信息

## 架构

### 核心组件

- **`ChatEngine`**：管理 Foundation Models 会话及流式响应
- **`Conversation`** & **`Message`**：用于持久化存储的 SwiftData 模型
- **`MessageGenerable`**：带网页元数据的 @Generable 结构体，用于结构化 AI 响应
- **`ConversationsListView`**：管理会话的主界面
- **`ConversationDetailView`**：支持消息流的聊天界面
- **`WebAnalyserTool`**：用于从网页提取结构化数据的工具

### 数据流程

1. **会话列表**：按最新消息时间排序显示所有会话
2. **聊天界面**：实时流式响应并持久化存储
3. **消息流**：使用 `@Generable` 实现结构化 AI 响应
4. **自动摘要**：每次交互后更新会话摘要

## 快速开始

1. 在 Xcode 中打开 `FoundationChat.xcodeproj`
2. 确保开发设备已启用 Apple Intelligence
3. 在支持的设备上构建并运行（不建议使用模拟器以保证性能）
4. 点击“+”按钮创建新会话
5. 开始与设备端 AI 聊天

## 关键实现细节

### Foundation Models 集成
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
### 结构化流响应

```swift
func respondTo() async -> LanguageModelSession.ResponseStream<MessageGenerable>? {
    session.streamResponse(generating: MessageGenerable.self) {
        // Conversation context with full history
    }
}
```
<translate-content>
### 工具集成</translate-content>
```swift
struct WebAnalyserTool: Tool {
    let name = "WebAnalyser"
    let description = "Analyse a website and return structured content"
    
    func call(arguments: Arguments) async throws -> ToolOutput {
        // Extracts title, thumbnail, and description
    }
}
```
### SwiftData 持久化

```swift
@Model
class Conversation {
    @Relationship(deleteRule: .cascade)
    var messages: [Message]
    var summary: String?
}
```
<translate-content>
## 文档

- **[CLAUDE.md](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/CLAUDE.md)** - 开发指南和框架概述
- **[Examples](EXAMPLES/)** - 全面实现示例：
  - 基本用法
  - 结构化输出
  - 流式响应
  - 工具调用
  - 性能与安全
  - 完整聊天应用

## 项目结构
</translate-content>
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
## 贡献

这是一个展示苹果Foundation Models框架的演示项目。欢迎您：
- 分叉并尝试不同的AI提示
- 扩展更多Foundation Models功能
- 添加新的UI组件和交互
- 贡献改进和错误修复

## 许可证

MIT许可证 - 详情请参见LICENSE文件


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---