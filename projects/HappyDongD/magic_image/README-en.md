
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Indonesian</a>
      </div>
    </div>
  </details>
</div>

# Magic AI Drawing

<div align="right">Chinese | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

An AI drawing application developed based on Next.js with the following main features:
- 🎨 Supports multiple AI models (Sora, DALL-E, GPT, GEMINI, etc.) and custom model addition
- 🖼️ Provides text-to-image and image-to-image functions, supports multi-image reference and area editing
- 🔐 All data and API keys are stored locally to ensure privacy and security
- 💻 Supports web and desktop application packaging for cross-platform use

## Online Experience

Access address: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Application Screenshots

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="App Screenshot 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="App Screenshot 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="App Screenshot 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="App Screenshot 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="App Screenshot 3" width="800" style="margin-bottom: 20px"/>
</div>

## Feature Highlights

- 🎨 Supports multiple AI models
  - GPT Sora_Image model
  - GPT 4o_Image model
  - GPT Image 1 model
  - DALL-E 3 model
  - GEMINI model
  - 🆕 Custom models (supports adding private models)
- 🔄 Multi-model switching
  - Supports quick switching between different models
  - Each model has independent configuration options
- ✍️ Text-to-image function
  - Supports custom prompts
  - Allows selection of image aspect ratios
  - Supports various image sizes
- 🖼️ Image-to-image function
  - Supports image editing
  - Supports area mask editing
  - Supports image quality adjustment
  - Supports multiple image references (upload multiple images at the same time)
- 🔒 Data Security
  - All generated images and history are stored only in the local browser
  - Supports custom API proxy address
  - Supports API Key configuration
- 📱 UI Design
  - Modern user interface
  - Smooth interactive experience
  - Markdown format display
  - Code highlighting support
- 🖥️ Cross-platform support
  - Supports packaging as desktop applications (Windows, macOS, Linux)
  - Supports offline usage (API interface configuration required)

## Tech Stack

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (desktop app packaging)

## Local Development

1. Clone the project
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Install Dependencies

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Start the development server

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4.  Visit [http://localhost:3000](http://localhost:3000)

## Desktop Application Packaging

This project uses Tauri for desktop application packaging, supporting Windows, macOS, and Linux systems.

### Environment Preparation

Before packaging the desktop application, the following dependencies need to be installed:

1. **Install Rust**:
   - Visit [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Follow the instructions to install Rust and Cargo

2. **System Dependencies**:
   - **Windows**: Install [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Install Xcode Command Line Tools (`xcode-select --install`)
   - **Linux**: Install relevant dependencies, see [Tauri Documentation](https://tauri.app/v1/guides/getting-started/prerequisites)

### Development Mode


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Building Desktop Applications


```bash
# 构建桌面应用安装包
npm run desktop
```
After the build is complete, you can find the installation package for the corresponding system in the `src-tauri/target/release/bundle` directory.

## Vercel Deployment

1. Fork this project to your GitHub account

2. Create a new project on [Vercel](https://vercel.com)

3. Import your GitHub repository

4. Click deploy

## Usage Instructions

1. API key configuration is required for first use
   - Click "Key Settings" at the top right
   - Enter the API key and base URL
   - Click save
   - You can also quickly configure via URL parameters:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Note: Special characters in the URL need to be URL encoded

2. Select generation mode
   - Text-to-image: Generate images via text descriptions
   - Image-to-image: Upload images for editing

3. Set generation parameters
   - Choose AI model (built-in or custom model)
   - Set image ratio
   - Adjust image quality (image-to-image mode)

4. Custom model management
   - Click the settings icon next to the model selection box
   - Add new model: enter model name, model value, and select model type
   - Edit model: click the edit button of an existing model
   - Delete model: click the delete button of an existing model
   - Select model: click the plus button of a model to immediately choose and use it

5. Model type description
   - DALL-E format: uses the image generation API (/v1/images/generations)
   - OpenAI format: uses the chat API (/v1/chat/completions)

6. Generate images
   - Enter prompt
   - Click the "Generate Image" button
   - Wait for generation to complete

7. Image management
   - View history records
   - Download generated images
   - Edit existing images

## Notes

- All generated images and history records are saved only in the local browser
- Using privacy mode or changing devices will result in data loss
- Please download and back up important images in time
- API configuration will be securely stored in your browser and will not be uploaded to the server
- HTTPS sites loading HTTP resources will be blocked by browsers, and the application will automatically convert HTTP APIs to HTTPS

## Contribution Guide

You are welcome to submit Issues and Pull Requests to help improve the project.

## License

This project uses the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

According to the license, you may:
- ✅ Commercial use: You can use the software for commercial purposes
- ✅ Modification: You can modify the software source code
- ✅ Distribution: You can distribute the software
- ✅ Private use: You can use the software privately
- ✅ Patent grant: This license also provides a patent grant

But you must comply with the following conditions:
- 📝 License and copyright notice: You must include the original license and copyright notice
- 📝 Notice of changes: You must declare significant changes to the original code
- 📝 Trademark statement: You may not use the contributor's trademarks

---

## Buy Me a Coffee

If this project is helpful to you, feel free to buy me a coffee ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat payment code" width="300" />
  <p>Buy me a coffee</p>
</div>

## Contact Information

If you have any questions or suggestions, feel free to contact me via WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat contact info" width="300" />
  <p>Scan QR code to add WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---