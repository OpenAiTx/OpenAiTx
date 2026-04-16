# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

A powerful browser extension focused on prompt management and quick input. It helps users create, manage, and organize a prompt library, and quickly insert preset prompt content into any webpage input box, improving work efficiency.

> Since browser extensions can only be used on the web, an open-source [Raycast plugin](https://github.com/wenyuanw/quick-prompt-raycast) with the same functionality is also available, compatible with the browser extension data format and supporting seamless migration via the same JSON data.

## ✨ Features

- 📚 **Prompt Management**: Easily create, edit, and manage your prompt library
- 🚀 **Quick Input**: Instantly trigger the prompt selector in any web page input box with `/p`
- ⌨️ Supports configuring hotkeys to open the prompt selector & save selected text as a prompt
- 📑 Supports right-click menu to directly save selected text as a prompt
- 🎯 Supports custom prompts, including categories, titles, content, tags, and variables
- 🧑‍💻 **Variable Support**: Use variables in the format `{{variableName}}` in prompts, and fill in specific values when using
- 💾 **Data Backup**: Supports exporting and importing the prompt library for easy migration and backup across devices
- 🔗 **Cloud Sync**: Supports syncing prompt library with Notion database or Gitee/GitHub Gist
- 🔍 Supports prompt search and filter functions
- 🌙 Automatically adapts to system light/dark theme

## 🚀 How to Use

1. **Quick Trigger**: Enter `/p` in any text input box on a webpage to trigger the prompt selector
2. **Hotkey to Open Selector**: Use `Ctrl+Shift+P` (Windows/Linux) or `Command+Shift+P` (macOS) to open the prompt selector
3. **Select Prompt**: Click the desired prompt from the pop-up selector and it will automatically insert into the current input box
4. **Quickly Save Prompt**: After selecting any text, use `Ctrl+Shift+S` (Windows/Linux) or `Command+Shift+S` (macOS) to quickly save as a prompt
5. **Right-click Menu Save**: After selecting any text, right-click and choose "Save this prompt" to save the selected content as a prompt
6. **Export Prompt Library**: Click the "Export" button in the management page to export all prompts as a JSON file to your local device
7. **Import Prompt Library**: Click the "Import" button in the management page to import prompts from a local JSON file (supports merging or overwriting existing prompts)

## 📸 Interface Preview

Quick Prompt provides an intuitive and user-friendly interface for easy prompt management and usage.

### Prompt Selector

![Prompt Selector](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt Selector](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Use the `/p` quick command or hotkey in any input box to quickly bring up the prompt selector, allowing you to easily pick and insert the prompts you need.

### Prompt Management Page

![Prompt Management](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

On the management page, you can create new prompts, edit existing prompts, add tags, and manage categories. The interface is clean and straightforward, making operations easy.

### Right-Click Menu Save

![Right-Click Menu Save](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Simply select any text on the webpage, right-click, and you can quickly save it as a prompt, improving your work efficiency.

### Prompt Variable Input

![Prompt Variable Popup](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts support variable configuration; after selection, a popup will appear for you to input the corresponding variable values.

## ⚙️ Custom Configuration

1. Click the extension icon, then click the "Manage Prompts" button
2. On the management page, you can:
   - Add new prompts
   - Edit existing prompts
   - Delete unnecessary prompts
   - Add tags to categorize prompts
   - Export the prompt library for backup
   - Import a previously backed-up prompt library

## 📦 Installation Guide

### Install from Extension Store

Now available on the Chrome Web Store! [Click here to download and install](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Get from GitHub Releases

1. Visit the [GitHub Releases page](https://github.com/wenyuanw/quick-prompt/releases)
2. Download the latest version of the built extension package
3. Extract the downloaded file
4. Follow the instructions below to install the built extension

### Build from Source

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---