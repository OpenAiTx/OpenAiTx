
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=henryhu55&project=tts-web-vue&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# TTS-Vue Web Version

🎤 Microsoft Speech Synthesis Tool, Web version, built with `Vue` + `ElementPlus` + `Vite`.

## Website Example

https://web.tts88.top
### New Version Interface
![image](https://github.com/user-attachments/assets/177c8c0d-33d1-48e7-81e3-778f36d8fedd)

### Old Version Interface
![image](https://github.com/user-attachments/assets/67cafd2c-7b0f-4b0d-b14b-bf402aaff0cd)

## Features

- 🌐 Completely web-based, no need to install desktop applications
- 🔊 Supports various Microsoft voice syntheses
- 🚀 Supports TTS88 API integration
- 🆓 Supports free TTS calls, daily free quota
- 🧠 Supports OpenAI text generation
- 🌍 Supports multiple languages: Chinese, English, Spanish
- 🔐 Browser fingerprint recognition for a more secure user experience

## Latest Updates

### UI Refactoring & Feature Enhancement (v2.2.0)

- 📱 **UI Refactoring**: Fixed top navigation, sticky text box, optimized for mobile adaptation
- 🔤 **SSML Enhancement**: Added SSML formatting, automatically updates SSML based on settings changes
- 🎵 **Player Optimization**: Integrated player into main interface, improved audio playback and download experience
- 🎞️ **Subtitle Feature**: Added online subtitle generation to boost content creation efficiency
- 🌓 **Theme Optimization**: Improved dark mode interface, added global theme switching
- 🛠️ **Advanced Settings**: Optimized free TTS service interface, added speech rate and pitch configuration
- 💡 **Interaction Experience**: Added tooltip function to enhance user guidance
- 🔄 **Dependency Upgrades**: Vue updated to 3.5.11, ElementPlus updated to 2.9.9
- 🌐 **Link Update**: Updated GitHub repository address

### Free TTS Service Integration (v2.1.0)

- 🆕 **Free TTS Feature**: No API key required, daily free quota
- 👤 **Browser Fingerprint Recognition**: Ensures fair usage of free quota for each user
- 🔄 **Quota Status Display**: Real-time display of remaining free characters and reset time
- 🌐 **Server Status Detection**: Automatically detects free TTS server connection status
- 🛡️ **Enhanced Error Handling**: More user-friendly error messages and status feedback
- 🎛️ **Free TTS Settings Panel**: Convenient for users to configure and view quota information

### UI and User Experience Optimization (v2.0.0)

- ✨ **Settings Area Optimization**: The settings panel now supports collapsing; click the "Voice Settings" title to expand/collapse.
- 🔘 **Smart Button Placement**: The "Start Conversion" button is moved to the top, so you can click it without scrolling.
- 💬 **Enhanced Status Prompts**: Intuitive conversion status prompt text has been added.
- 🎨 **Visual Improvements**: Button now features lighting animations for a better user experience.
- 📱 **Responsive Layout Optimization**: Improved display effects across different screen sizes.

These improvements greatly enhance usability, especially addressing the issue in traditional designs where users had to scroll to the bottom to click the "Start Conversion" button. Now, users can easily initiate the conversion process from anywhere on the page.

## Development Plan

> **📢 Important Notice: Desktop version under development!**
> We are developing a cross-platform desktop app version, which will support more features and provide a better user experience.
> Stay tuned for further updates, and follow the project for the latest information.

## Quick Start

### Development Environment

```bash
# 克隆仓库
git clone https://github.com/henryhu55/tts-web-vue.git

# 安装依赖
yarn install

# 启动开发服务器
yarn dev
```

### Production Build

```bash
# 构建生产版本
yarn build

# 预览生产版本
yarn preview
```

## Deployment

After building, deploy the contents of the `dist` directory to any static web server.

## API Configuration

This web version currently supports free TTS service, TTS88 API, and OpenAI API:

### Free TTS Service Configuration

1. Find the "Free TTS Service" option on the settings page  
2. The system defaults to a configured free TTS server address  
3. You can check the remaining free quota and reset time for the day  
4. Each browser client has an independent free quota  

### TTS88 API Configuration

1. Find the "Third-Party API URL" setting option on the settings page  
2. Enter your TTS88 API address  
3. If you have an API key, enter it in the "TTS88 API Key" field  

### OpenAI API Configuration

1. Find the OpenAI settings option on the settings page  
2. Enter your OpenAI API key  
3. Select the model to use (default is gpt-3.5-turbo)  
4. If using self-hosting or proxy, you can set a custom API Base URL  

## Notes

- Data is only stored in the browser's local storage; refreshing or clearing the cache does not affect other users  
- Converted audio files can be played directly in the browser or downloaded locally  
- The free TTS service has a daily usage quota limit; exceeding it requires waiting for the next day’s reset  

## Technology Stack

- Vue 3.2  
- Pinia  
- ElementPlus
- Vite

## License

MIT License

## Getting Started

- [Project Introduction](https://docs.tts88.top//guide/intro.html)
- [Installation and Running](https://docs.tts88.top//guide/install.html)
- [Feature Introduction](https://docs.tts88.top/guide/features.html)
- [FAQ](https://docs.tts88.top//guide/qa.html)
- [Changelog](https://docs.tts88.top//guide/update.html)

## Notice

This software and code are for personal learning and testing purposes only. Please delete it within 24 hours after downloading and do not use it for commercial purposes; otherwise, the consequences are at your own risk. I am not responsible for any legal consequences caused by illegal use. This software will never charge any fees. If you paid any extra fees before using this software, or paid for the source code or finished software, then you have definitely been scammed!

**Please indicate the source when redistributing. It is forbidden to induce others to obtain the software repository, download address, and installation package via joining groups, private messages, etc.**

### Feedback and version release QQ group:

`【tts-web-vue Feedback Group 1】279895662`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---