<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/banner.svg" alt="Quick Prompt" width="100%">
</p>

<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Indonesian</a>
      </div>
    </div>
  </details>
</div>

<h1 align="center">Quick Prompt</h1>

A powerful browser extension focused on prompt management and fast input. Helps users create, manage, and organize a prompt library, and quickly insert preset Prompt content in any webpage input box to improve work efficiency.

## ✨ Features

- 📚 **Prompt Management**: Easily create, edit, and manage your prompt library
- 🚀 **Quick Input**: Instantly trigger the prompt selector in any web input field with `/p`
- ⌨️ Supports configuring hotkeys to open the prompt selector & save selected text as a prompt
- 📑 Supports saving selected text as a prompt directly via the right-click menu
- 🎯 Supports custom prompts, including categories, titles, content, attachments, tags, and variables
- 🧑‍💻 **Variable Support**: Prompts can use variables in the `{{variable_name}}` format, which can be filled in with specific values as needed
- 💾 **Data Backup**: Supports export and import of the prompt library for easy device migration and backup
- 🔗 **Cloud Sync**: Prompt library supports WebDAV sync, Notion database, and Gitee/GitHub Gist synchronization
- 🔍 Supports searching and filtering of prompts
- 🌙 Automatically adapts to the system's light or dark theme

## 🚀 How to Use

1. **Quick Trigger**: Type `/p` in any text input field on any webpage to trigger the prompt selector
2. **Open Selector with Hotkey**: Use `Ctrl+Shift+P` (Windows/Linux) or `Command+Shift+P` (macOS) to open the prompt selector
3. **Select a Prompt**: Click your desired prompt from the pop-up selector to automatically insert it into the current input field
4. **Quickly Save Prompt**: After selecting any text, use `Ctrl+Shift+S` (Windows/Linux) or `Command+Shift+S` (macOS) to quickly save it as a prompt
5. **Save via Right-Click Menu**: After selecting any text, right-click and choose "Save this Prompt" to save the selected content as a prompt
6. **Export Prompt Library**: Click the "Export" button on the management page to export all prompts as a JSON file to your local device
7. **Import Prompt Library**: Click the "Import" button on the management page to import prompts from a local JSON file (supports merging or overwriting existing prompts)

## 📸 Interface Preview

Quick Prompt offers an intuitive and user-friendly interface, making prompt management and usage easy.

### Prompt Selector

![Prompt Selector](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt Selector](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Use the `/p` command or hotkey to quickly bring up the prompt selector in any input field, allowing you to easily pick and insert the prompt you need.

### Prompt Management Page

![Prompt Management](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

On the management page, you can create new prompts, edit existing prompts, add tags, and manage categories. The interface is clear and straightforward, making operations convenient.

### Save via Right-Click Menu

![Right-click menu save](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Simply select any text on the webpage and right-click to quickly save it as a prompt, boosting your work efficiency.

### Prompt variable input

![Prompt variable popup](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts support variable configuration, and after selection, a popup will appear for inputting the corresponding variable values.

## ⚙️ Custom configuration

1. Click the extension icon, then click the "Manage Prompts" button
2. On the management page, you can:
   - Add new prompts
   - Edit existing prompts
   - Delete unnecessary prompts
   - Add tags to prompts for classification
   - Export the prompt library for backup
   - Import previously backed up prompt libraries

## 📦 Installation Guide

### Install from App Stores

<p>
  <a href="https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd">
    <img src="https://img.shields.io/badge/Chrome-App%20Store-4285F4?style=for-the-badge&logo=googlechrome&logoColor=white" alt="Chrome App Store">
  </a>
  <a href="https://addons.mozilla.org/firefox/addon/quick-prompt/">
    <img src="https://img.shields.io/badge/Firefox-Add-ons%20Store-FF7139?style=for-the-badge&logo=firefoxbrowser&logoColor=white" alt="Firefox Add-ons Store">
  </a>
</p>

### Get from GitHub Releases

1. Visit the [GitHub Releases page](https://github.com/wenyuanw/quick-prompt/releases)
2. Download the latest built plugin package
3. Extract the downloaded file
4. Install the built extension according to the instructions below

### Build from source

1. Clone the repository
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Install dependencies
   ```bash
   pnpm install
   ```
3. Development and Build

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```

### Installing the Built Extension

#### Chrome / Edge
1. Open the extensions management page (`chrome://extensions` or `edge://extensions`)
2. Enable "Developer mode"
3. Click "Load unpacked"
4. Select the `.output/chrome-mv3/` directory of the project

#### Firefox
1. Open `about:debugging`
2. Click "This Firefox"
3. Click "Load Temporary Add-on"
4. Select the `manifest.json` file in the `.output/firefox-mv2/` directory of the project

## 📄 License

MIT

## 🤝 Contribution Guide

Pull Requests and Issues are welcome!

1. Fork this repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 👏 Contributors List

Thanks to all the developers who contributed to the project!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-27

---