<translate-content># Quick Prompt

[English](https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./README_en.md) | 中文

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

A powerful browser extension focused on prompt management and quick input. Helps users create, manage, and organize prompt libraries, and quickly insert preset prompt content into any webpage input box to improve work efficiency.

> Since browser extensions can only be used on web pages, an open-source [Raycast plugin](https://github.com/wenyuanw/quick-prompt-raycast) with the same features has been released, compatible with the browser extension data format, supporting seamless migration via the same JSON data.

## ✨ Features

- 📚 **Prompt Management**: Conveniently create, edit, and manage your prompt library
- 🚀 **Quick Input**: Quickly trigger the prompt selector in any webpage input box by typing `/p`
- ⌨️ Supports configuring hotkeys to open the prompt selector & save selected text as a prompt
- 📑 Supports saving selected text as a prompt directly from the right-click menu
- 🎯 Supports custom prompts, including categories, titles, content, tags, and variables
- 🧑‍💻 **Variable Support**: Variables in prompts can use the `{{variable_name}}` format, with values filled in at use time
- 💾 **Data Backup**: Supports exporting and importing prompt libraries for easy cross-device migration and backup
- 🔗 **Notion Sync**: Supports syncing prompt libraries with Notion databases
- 🔍 Supports search and filter functionality for prompts
- 🌙 Automatically adapts to system light/dark themes

## ⚠️ Known Issues

- On the Doubao (doubao.com) website, after triggering the prompt selector with `/p`, some input boxes may not clear the `/p`. But don’t worry, my old partner Cursor and I are working day and night to find a solution and fix it as soon as possible!

## 🚀 How to Use

1. **Quick Trigger**: Type `/p` in any webpage text input box to trigger the prompt selector
2. **Hotkey to Open Selector**: Use `Ctrl+Shift+P` (Windows/Linux) or `Command+Shift+P` (macOS) to open the prompt selector
3. **Select Prompt**: Click the desired prompt from the popup selector, it will automatically insert into the current input box
4. **Quick Save Prompt**: Select any text, then use `Ctrl+Shift+S` (Windows/Linux) or `Command+Shift+S` (macOS) to quickly save as a prompt
5. **Right-click Menu Save**: Select any text, right-click and choose "Save this prompt" to save the selection as a prompt
6. **Export Prompt Library**: On the management page, click the "Export" button to save all prompts as a JSON file locally
7. **Import Prompt Library**: On the management page, click the "Import" button to import prompts from a local JSON file (supports merging or overwriting existing prompts)

## 📸 Interface Preview

Quick Prompt provides an intuitive and friendly user interface to easily manage and use prompts.

### Prompt Selector

![Prompt Selector](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt Selector](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Use the `/p` quick command or hotkey to quickly bring up the prompt selector in any input box, allowing you to conveniently pick and insert the needed prompt.

### Prompt Management Page

![Prompt Management](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

On the management page, you can create new prompts, edit existing prompts, add tags, and manage categories. The interface is clear and operation is easy.

### Right-click Menu Save

![Right-click Menu Save](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Simply select any text on a webpage, right-click to quickly save it as a prompt, improving work efficiency.

### Prompt Variable Input

![Prompt Variable Popup](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts support configuring variables; after selection, a popup prompts you to enter the corresponding variable values.

## ⚙️ Custom Configuration

1. Click the extension icon, then click the "Manage Prompts" button
2. On the management page, you can:
   - Add new prompts
   - Edit existing prompts
   - Delete unwanted prompts
   - Add tags to prompts for categorization
   - Export prompt library for backup
   - Import previously backed-up prompt libraries

## 📦 Installation Guide

### Install from App Store

Now available on the Chrome Web Store! [Click here to download and install](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Get from GitHub Releases

1. Visit the [GitHub Releases page](https://github.com/wenyuanw/quick-prompt/releases)
2. Download the latest built extension package
3. Extract the downloaded files
4. Follow the instructions below to install the built extension

### Build from Source

1. Clone the repository</translate-content>
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---