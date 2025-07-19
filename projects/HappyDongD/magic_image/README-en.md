<translate-content># Magic AI Drawing

<div align="right">Chinese | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

An AI drawing application developed based on Next.js, featuring the following main functions:
- 🎨 Supports multiple AI models (Sora, DALL-E, GPT, etc.) and custom model additions
- 🖼️ Provides text-to-image and image-to-image functions, supporting multi-image references and regional editing
- 🔐 All data and API keys are stored locally to ensure privacy and security
- 💻 Supports both web version and desktop application packaging for cross-platform use

## Online Experience

Access URL: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Application Screenshots

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="App Screenshot 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="App Screenshot 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="App Screenshot 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="App Screenshot 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="App Screenshot 3" width="800" style="margin-bottom: 20px"/>
</div>

## Features

- 🎨 Supports multiple AI models
  - GPT Sora_Image model
  - GPT 4o_Image model
  - GPT Image 1 model
  - DALL-E 3 model
  - 🆕 Custom models (support adding private models)
- ✍️ Text-to-Image function
  - Supports custom prompts
  - Supports selectable image aspect ratios
  - Supports multiple image sizes
- 🖼️ Image-to-Image function
  - Supports image editing
  - Supports regional mask editing
  - Supports image quality adjustment
  - Supports multi-image references (upload multiple images simultaneously)
- 🔒 Data Security
  - All generated images and history are saved only in the local browser
  - Supports custom API proxy address
  - Supports API Key configuration
- 📱 UI Design
  - Modern user interface
  - Smooth interaction experience
  - Markdown format display
  - Code syntax highlighting support
- 🖥️ Cross-platform support
  - Supports packaging as desktop applications (Windows, macOS, Linux)
  - Supports offline use (API interface configuration required)

## Technology Stack

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (desktop application packaging)

## Local Development

1. Clone the project</translate-content>
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
     Note: Special characters in URLs need to be URL encoded

2. Select Generation Mode
   - Text-to-Image: Generate images from text descriptions
   - Image-to-Image: Upload images for editing

3. Set Generation Parameters
   - Choose AI model (built-in or custom models)
   - Set image aspect ratio
   - Adjust image quality (Image-to-Image mode)

4. Custom Model Management
   - Click the settings icon next to the model selection box
   - Add new model: enter model name, model value, and select model type
   - Edit model: click the edit button on an existing model
   - Delete model: click the delete button on an existing model
   - Select model: click the plus button on a model to immediately select it for use

5. Model Type Description
   - DALL-E format: uses the image generation endpoint (/v1/images/generations)
   - OpenAI format: uses the chat completion endpoint (/v1/chat/completions)

6. Generate Images
   - Enter prompt
   - Click the "Generate Image" button
   - Wait for generation to complete

7. Image Management
   - View history
   - Download generated images
   - Edit existing images

## Notes

- All generated images and history are saved only locally in your browser
- Using private mode or switching devices will cause data loss
- Please download and back up important images in time
- API configurations are securely stored in your browser and will not be uploaded to servers
- HTTPS websites block loading HTTP resources; the app will automatically convert HTTP endpoints to HTTPS

## Contribution Guide

Contributions via Issues and Pull Requests to improve the project are welcome.

## License

This project is licensed under the [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

According to the license, you may:
- ✅ Commercial use: use the software for commercial purposes
- ✅ Modification: modify the source code
- ✅ Distribution: distribute the software
- ✅ Private use: use the software privately
- ✅ Patent grant: the license also provides a patent grant

But you must comply with the following conditions:
- 📝 License and copyright notice: you must include the original license and copyright notice
- 📝 Statement of changes: you must state significant changes made to the original code
- 📝 Trademark statement: you may not use contributors' trademarks

---

## Buy Me a Coffee

If this project helps you, feel free to buy me a coffee ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat Pay QR Code" width="300" />
  <p>Buy me a coffee</p>
</div>

## Contact

If you have any questions or suggestions, feel free to contact me via WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat Contact" width="300" />
  <p>Scan QR code to add on WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---