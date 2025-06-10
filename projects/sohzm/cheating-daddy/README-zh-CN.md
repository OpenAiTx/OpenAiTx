# Cheating Daddy

> [!NOTE]  
> 请使用最新的 MacOS 和 Windows 版本，旧版本仅有限支持

> [!NOTE]  
> 测试期间，如果你直接提问它不会回答，你需要模拟面试官提问，它才会回答

一个实时 AI 助手，通过屏幕捕捉和音频分析，在视频通话、面试、演讲和会议过程中提供上下文帮助。

## 功能

- **实时 AI 协助**：由 Google Gemini 2.0 Flash Live 提供实时帮助
- **屏幕和音频捕捉**：分析你所看到和听到的内容，提供上下文响应
- **多种配置文件**：面试、销售通话、商务会议、演讲、谈判
- **透明悬浮窗**：始终置顶窗口，可随意移动
- **穿透点击模式**：需要时窗口可对点击事件透明
- **跨平台支持**：可在 macOS、Windows 及 Linux（仅测试，不建议使用）运行

## 设置

1. **获取 Gemini API 密钥**：访问 [Google AI Studio](https://aistudio.google.com/apikey)
2. **安装依赖**：`npm install`
3. **运行应用**：`npm start`

## 使用方法

1. 在主窗口输入你的 Gemini API 密钥
2. 在设置中选择你的配置文件和语言
3. 点击“开始会话”以启动
4. 使用快捷键调整窗口位置
5. AI 会根据你的屏幕内容和面试官提问实时提供帮助

## 快捷键

- **窗口移动**：`Ctrl/Cmd + 方向键` - 移动窗口
- **穿透点击**：`Ctrl/Cmd + M` - 切换鼠标事件
- **关闭/返回**：`Ctrl/Cmd + \` - 关闭窗口或返回
- **发送消息**：`Enter` - 向 AI 发送文本

## 音频捕捉

- **macOS**：[SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) 用于系统音频 
- **Windows**：回环音频捕捉
- **Linux**：麦克风输入

## 系统要求

- 支持 Electron 的操作系统（macOS、Windows、Linux）
- Gemini API 密钥
- 屏幕录制权限
- 麦克风/音频权限

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---