<h1 align="center">Welcome to&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20to%201.0.0-blue.svg" />
</p>

> Cursor Auto Continue Tool, Cursor Auto Retry, Cursor Auto Confirm, Cursor Usage Statistics, Cursor Enhancement Tool, Cursor Assistant Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Homepage](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper is an automation enhancement tool specifically designed for Cursor IDE. It can display usage in real time, automatically handle the 25-dialogue limit, network connection failures, confirmation prompts, and other scenarios, making your development experience smoother.

**Video Demo:** [Cursor Auto Helper Demo Video](https://www.bilibili.com/video/BV1cajKzCEzv/)

With high-quality prompts and well-planned project requirements, this program enables Cursor to automatically complete a project without manual intervention.

> 🔒 **Version Compatibility:** Currently developed and tested on Cursor 0.49.6 and Cursor 1.0.0; theoretically compatible with Cursor 0.48.x - 1.0.0 versions.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖Changelog

- 2025-06-01 Released v2.3: Added Cursor theme settings, optimized code injection stability, corrected usage display to match official format
- 2025-05-21 Released v2.1: Refactored architecture, added multi-platform support, added real-time usage display, etc.
- 2025-04-25 Released v1.0: Automatically handles 25-dialogue limit, network failures, confirmation prompts, and other scenarios
- 2025-04-20 Project started

## 🌟 Cursor Auto Helper Best Practices

Note: The following documentation can be generated with the help of AI tools such as Cursor, and should be manually verified and adjusted.

**STEP 1:** Detailed project system requirements design (the clearer the requirements, the higher the project quality), write high-quality project development prompts in **SYSTEM.md**

**STEP 2:** Based on **SYSTEM.md**, output a high-quality system development design document **DESIGN.md**

**STEP 3:** Based on **SYSTEM.md** and **DESIGN.md**, output a high-quality development plan document **TODOLIST.md**

**STEP 4:** Use **Cursor Auto Helper**, specify **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, and use auto-continue feedback prompts to keep Cursor automatically completing the project according to the development plan, until completion

**Cursor Auto Helper Auto Continue Feedback Prompt:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Please strictly follow the TODOLIST development plan for subsequent feature development, and update the TODOLIST development plan in real time. After each task is completed, ask me "Continue?", until the project is completed and return "Project completed"
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Usage Instructions

Star this project to support us. If you have any questions, please submit them via [Issues](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Configuration File Instructions

The configuration file `config.ini` **is used to customize automation behaviors** (set and test as needed) and supports the following options:

#### Basic Configuration
```ini
[common]
log_enable = true     # Whether to enable logging; set to false if you don't want to log

[cursor]
path = C:\Path\To\Cursor.exe  # Cursor IDE installation path. The program will automatically locate Cursor; if not found, you'll be prompted. Modify this entry if necessary.
```

#### Automated Action Configuration
Each automated action is prefixed with `action name.`, and supports the following fields:

- `type`: Action type
  - `click`: Click a button
  - `input_and_submit`: Input and submit

- `text` / `text_list`: Matched text content
  - `text`: A single string
  - `text_list`: Multiple strings separated by |; the action is triggered if any item is present on the page

- `button_selector`: CSS selector for the button to click (`click` type only)
- `button_text`: Button text content (optional, for further restriction)
- `input_box_selector`: CSS selector for the input box (`input_and_submit` type required)
- `input_content`: Content to be automatically entered
- `submit_btn_selector`: CSS selector for the submit button
- `delay`: Delay before action execution (milliseconds), can be used to wait for page rendering

##### Configuration Example
```ini
[auto_actions]
# Automatically retry on connection failure
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# after 25 tool calls
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "Please continue"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
```
action_continue.delay = 1000

# Auto-confirm Continue
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "Do you need|Do you want to continue|Do you need me|Please tell me"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "Please continue with the subsequent development and record the development progress in real time"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Note:**
> 1. The name of each action (such as `action_retry`, `action_continue`) can be customized, but the prefix of all fields in the same action must be consistent.
> 2. It is recommended to use the browser developer tools to locate the CSS selectors to ensure accuracy.
> 3. After modifying the configuration file, you need to restart the program for the changes to take effect.

## 🎯 Application Scenarios

### 💼 Long Conversation Development
- Automatically handles the 25-turn conversation limit, supports continuous long conversation development, automatically continues the conversation flow, and improves development efficiency.

### 👥 Unstable Network
- Automatically detects network anomalies, intelligently retries connections, and automatically recovers conversations to ensure development continuity.

### 🏢 Confirmation Scenarios
- Intelligently identifies confirmation prompt scenarios, automatically handles confirmation prompts, and reduces manual intervention.

### 📚 Usage Monitoring
- Real-time statistics on conversation count, monitors Cursor usage, records usage data, and optimizes usage efficiency.

Terminal usage display:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Cursor IDE usage display:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Feature Description

### 🤖Automatically Continue Long Conversations
- Automatically handles Cursor's 25-turn conversation limit, supports multi-turn continuous conversations.

### 🎨 Automatic Retry Connection
- Automatically detects network connection failures, intelligently retries, and monitors connection status in real time.

### 📱 Automatic Confirmation Prompts
- Intelligently identifies various confirmation prompt scenarios, and automatically handles confirmation pop-ups.
- Supports custom confirmation content and responses to reduce manual intervention.
- Flexible rule configuration, adaptable to diverse development processes.

### 🛍️ Usage Statistics
- Real-time statistics on conversation count and usage, automatically records data.
- Visualized display of usage data for easier analysis and optimization.
- Supports terminal color log display and IDE usage panel to enhance usability.

### 💡 Logging System
- Multi-level logs (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), terminal color output.
- Log files are automatically generated by date, supports file recording and drag-and-drop display panels.
- Real-time panel makes it easy for developers to monitor and trace.

### 🔒 Version Compatibility and Performance Optimization
- Developed based on Cursor 0.49.6, core features fully tested.
- Optimized for specific versions, continuously following up with Cursor version updates.
- Highly stable and compatible, suitable for production environments.

## 🔮Effect Showcase

### 🤖 Automatic Continue Conversation

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Cursor Auto-completion Program Demo

From project requirements to complete implementation, the whole process requires no manual intervention:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Author

👤 **pen9un**

* Website: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Support

If you find this project useful, please give a free ⭐️⭐️

## ✨Star History

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Visitor Statistics

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---