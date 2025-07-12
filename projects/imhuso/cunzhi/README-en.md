# Cunzhi 🛑

> **The "Premature End" Terminator for AI Conversations—Keep Your Dialogue Going**

Still frustrated that your AI assistant always ends conversations too early? There’s so much more you want to discuss, but it just says, "Is there anything else I can help with?" **Cunzhi** is here to fix that!

When your AI tries to "wrap things up too soon," Cunzhi will instantly pop up a dialog, allowing you to keep the conversation going until your issue is truly resolved.

## 🌟 Core Features

- 🛑 **Intelligent Interception**: Automatically pops up continuation options when the AI tries to end the conversation
- 🧠 **Memory Management**: Stores development standards and preferences by project
- 🎨 **Elegant Interaction**: Markdown support and multiple input methods
- ⚡ **Ready to Use**: 3-second installation, cross-platform support

## 📸 See It in Action

### 🛑 Intelligent Interception Pop-up
![Cunzhi Popup Demo](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*When the AI tries to end the conversation, Cunzhi’s smart popup appears in time, offering predefined options for quick selection and allowing the conversation to continue deeply*
### ⚙️ Settings Management Interface
![Cunzhi Settings Interface](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Elegant settings interface, supports memory management, feature toggles, theme switching, and intelligent prompt generation*

## 🚀 Getting Started

### Method 1: Quick Install (Recommended)

**macOS Users:**
```bash
# 3-second installation, no need to wait for compilation
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Troubleshooting**: If you encounter a 404 download error, please follow these steps:
>
> ```bash
> # Clear old tap cache
> brew untap imhuso/cunzhi
> # Reinstall
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Common Error Example:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> This is usually caused by a version mismatch due to previous version caching issues. Clearing the tap and reinstalling will resolve the problem.

**Windows/Linux Users:**
It is recommended to use Method 2 for manual download, which is simple and fast!
### Method 2: Manual Download

1. Visit the [Releases page](https://github.com/imhuso/cunzhi/releases)
2. Download the version suitable for your system:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. After extracting, add `寸止` and `等一下` to your system PATH

## ⚡ Quick Start

### Step 1: Configure MCP Client

Add the following to the configuration file of your MCP client (such as Claude Desktop):

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### Step 2: Open the Settings Interface

```bash
# Run the settings command
Wait a moment
```

### Step 3: Configure Prompt Words

In the "Reference Prompts" tab of the settings interface:
1. View the automatically generated prompts
2. Click the copy button
3. Add the prompts to your AI assistant

### Step 4: Start Using

Now your AI assistant is equipped with intelligent interception, memory management, and popup interaction features!

> 💡 **Tip**: You can personalize and modify the generated prompts to create your own exclusive AI interaction experience.
## 🤝 Contributing

Cunzhi is an open-source project, and we welcome all forms of contribution!

### 🐛 Found a problem?
- [Submit an Issue](https://github.com/imhuso/cunzhi/issues) to describe the problem
- Provide reproduction steps and environment information

### 💡 Have a great idea?
- [Start a discussion](https://github.com/imhuso/cunzhi/discussions) to share your thoughts
- Submit a Pull Request to implement new features

### 🛠️ Local Development
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Contact Us

- 🐛 **Report Issues**: [GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Feature Discussions**: [GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Like the Project**: Give us a Star to support!

## 📄 Open Source License

MIT License - Free to use, contributions welcome!

---

<div align="center">

**Say Goodbye to AI Conversation "Premature Termination" | Make Every Interaction Last Until the End**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Report Bug](https://github.com/imhuso/cunzhi/issues) · [💡 Request Feature](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---