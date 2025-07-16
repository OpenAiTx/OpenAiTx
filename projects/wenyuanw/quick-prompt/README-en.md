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

A powerful browser extension focused on prompt management and quick input. It helps users create, manage, and organize prompt libraries and quickly insert preset Prompt content into any web input box, improving work efficiency.

> Since browser extensions can only be used on the web, an open-source [Raycast plugin](https://github.com/wenyuanw/quick-prompt-raycast) with the same functionality is available. It is compatible with the browser extension's data format and supports seamless migration using the same JSON data.

## ✨ Features

- 📚 **Prompt Management**: Easily create, edit, and manage your prompt library
- 🚀 **Quick Input**: Quickly trigger the prompt selector in any web input box via `/p`
- ⌨️ Supports configuring shortcuts to open the prompt selector & save selected text as a prompt
- 📑 Supports saving selected text as a prompt directly via the right-click menu
- 🎯 Supports custom prompts, including categories, titles, content, tags, and variables
- 🧑‍💻 **Variable Support**: Variables in prompts can use the `{{variable_name}}` format, and specific values can be filled in when using
- 💾 **Data Backup**: Supports exporting and importing the prompt library, making it convenient for cross-device migration and backup
- 🔗 **Notion Sync**: Supports syncing the prompt library with Notion databases
- 🔍 Supports search and filter functions for prompts
- 🌙 Automatically adapts to system light and dark themes

## ⚠️ Known Issues

- On the Doubao (doubao.com) website, after triggering the prompt selector with `/p`, some input boxes may not clear the `/p`. But don’t worry, my old partner Cursor and I are working day and night to find a solution, aiming to fix it as soon as possible!

## 🚀 How to Use

1. **Quick Trigger**: Enter `/p` in any web text input box to trigger the prompt selector
2. **Shortcut to Open Selector**: Use `Ctrl+Shift+P` (Windows/Linux) or `Command+Shift+P` (macOS) to open the prompt selector
3. **Select Prompt**: Click the desired prompt from the pop-up selector, and it will automatically be inserted into the current input box
4. **Quickly Save Prompt**: After selecting any text, use `Ctrl+Shift+S` (Windows/Linux) or `Command+Shift+S` (macOS) to quickly save as a prompt
5. **Right-click Menu Save**: After selecting any text, right-click and choose "Save this prompt" to save the selected content as a prompt
6. **Export Prompt Library**: Click the "Export" button on the management page to export all prompts as a JSON file saved locally
7. **Import Prompt Library**: Click the "Import" button on the management page to import prompts from a local JSON file (supports merging or overwriting existing prompts)

## 📸 Interface Preview

Quick Prompt provides an intuitive and user-friendly interface to easily manage and use prompts.

### Prompt Selector

![Prompt Selector](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt Selector](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Use the `/p` quick command or shortcut to quickly bring up the prompt selector in any input box, making it easy to pick and insert the prompts you need.

### Prompt Management Page

![Prompt Management](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

On the management page, you can create new prompts, edit existing prompts, add tags, and manage categories. The interface is simple and clear, and the operation is convenient.

### Right-click Menu Save

![Right-click Menu Save](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Just select any text on a web page and right-click to quickly save it as a prompt, improving work efficiency.

### Prompt Variable Input

![Prompt Variable Popup](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts support configuring variables. After selection, a popup will appear to input the corresponding variable values.

## ⚙️ Custom Configuration

1. Click the extension icon, then click the "Manage Prompts" button
2. On the management page, you can:
   - Add new prompts
   - Edit existing prompts
   - Delete unnecessary prompts
   - Add tags to prompts for classification
   - Export the prompt library for backup
   - Import previously backed up prompt libraries

## 📦 Installation Guide

### Install from Chrome Web Store

Now available on the Chrome Web Store! [Click here to download and install](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Get from GitHub Releases

1. Visit the [GitHub Releases page](https://github.com/wenyuanw/quick-prompt/releases)
2. Download the latest version of the built plugin package
3. Unzip the downloaded file
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
4. Select the project's `.output/chrome-mv3/` directory

#### Firefox
1. Open `about:debugging`
2. Click "This Firefox"
3. Click "Load Temporary Add-on"
4. Select the `manifest.json` file in the project's `.output/firefox-mv2/` directory

## 📄 License

MIT

## 🤝 Contribution Guide

Pull Requests and Issues are welcome!

1. Fork this repository
2. Create your feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 👏 Contributors

Thanks to all developers who contributed to the project!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---