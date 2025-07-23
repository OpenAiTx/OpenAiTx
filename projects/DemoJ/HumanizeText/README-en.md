
# Human Language Translator

## Project Introduction

Human Language Translator is a Chrome browser extension designed to help users quickly translate text content on webpages. It provides a beautiful, draggable popup interface, supporting real-time translation and copy functions.  

It is currently available on major browser extension stores. Search for "Human Language Translator" or click the links below to download and use it.  
Chrome Browser: [Chrome Web Store](https://chromewebstore.google.com/detail/genddacnaonloeecodkncflhpcdbcmdh)  
Edge Browser: [Edge Add-ons Store](https://microsoftedge.microsoft.com/addons/detail/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/nfcgnclfgdeocdakoconadlbonnjaglj)  
Firefox Browser: [Firefox Add-ons Store](https://addons.mozilla.org/zh-CN/firefox/addon/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/)  

## Main Features

- **Text Selection Translation**: Trigger translation after selecting text on a webpage  
- **Real-time Translation Display**: Translation results show in the popup in real time  
- **Thought Chain Display**: Can show the translation's thought process  
- **Draggable Interface**: Popup supports dragging for easy repositioning  
- **Copy Function**: One-click copy of translation results  
- **Markdown Support**: Translation results support Markdown format rendering  

## Usage Instructions

1. Install the extension in the Chrome browser  
2. Click the extension icon - Settings, enter API information on the settings page  
3. Select the text you want to translate on any webpage  
4. Trigger translation (via right-click menu or shortcut keys)  
5. View the results in the popup window  
6. Move the popup by dragging the title bar  
7. Click the "Copy Translation" button to copy the translation results  
8. Click the "✕" button in the upper right corner to close the popup  

## Technical Implementation

### Frontend Interface

- Popup interface built with pure JavaScript  
- CSS styles are visually appealing, supporting scrolling, dragging, and other interactions  
- Custom Markdown parser used for text formatting  

### Communication Mechanism

- Uses Chrome extension message passing (`chrome.runtime.onMessage`)  
- Supports the following message types:  
  - `showTranslationPopup`: Show the translation popup  
  - `translate`: Send translation request  
  - `updateTranslation`: Update translation results  
  - `cleanup`: Clean up resources  

### Special Design

- **Prevent Style Conflicts**: All CSS class names are prefixed with `translator-`  
- **Smart Scrolling**: Auto-scroll to bottom only when the user has not scrolled manually  
- **Error Handling**: Comprehensive error handling with user-friendly error messages  
- **Singleton Pattern**: Ensures only one translation popup exists at a time  

## Project Structure


```
├── content/
│   └── content.js    # 内容脚本，负责弹窗创建和交互
├── background/
│   └── background.js # 后台脚本，处理翻译请求和API调用
├── popup/
│   ├── popup.html    # 扩展弹出窗口HTML
│   ├── popup.js      # 扩展弹出窗口脚本
│   └── popup.css     # 扩展弹出窗口样式
├── options/
│   ├── options.html  # 选项页面HTML
│   ├── options.js    # 选项页面脚本
│   └── options.css   # 选项页面样式
├── assets/
│   ├── icon.png      # 扩展图标目录
├── manifest.json     # 扩展配置文件
└── README.md         # 项目说明文档
```
## Development Notes

- The extension uses the Chrome extension API and requires correct permission configuration in manifest.json
- The translation feature depends on a backend API, so ensure the API key is configured correctly
- The styling is designed to be isolated from the original webpage styles to avoid conflicts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---