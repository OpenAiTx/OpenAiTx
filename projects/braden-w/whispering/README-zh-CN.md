<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">由 OpenAI Whisper 模型驱动的无缝语音输入</p>
</p>

<p align="center">
  <!-- 最新版本徽章 -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- 许可证徽章 -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- 技术徽章 -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- 平台支持徽章 -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## 关于

Whispering 是一个开源转录应用，提供全球语音转文字功能，并支持快捷键和自动复制粘贴等选项，使语音输入尽可能无缝。

其底层由 OpenAI 的 Whisper 模型驱动，相比内置语音输入更加精准。

> **重要提示**：Whispering 主要设计为转录工具，而非录音工具。对于需要高可靠性的重要长时间录音，建议使用手机或其他设备的专用录音应用，并利用原生录音 API，以确保最佳音质和录音稳定性。

## 演示

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## 主要特性

1. **全局转录**：通过全局快捷键或两次点击即可随时访问 Whisper 的语音转文字功能。
2. **跨平台体验**：
   - 桌面应用：支持在所有应用中全局转录。
   - 浏览器扩展：通过与网页应用通信，在浏览器内实现全局转录。
3. **聊天集成**：浏览器扩展会在 ChatGPT 和 Claude 网站添加录音按钮，允许直接在聊天界面进行语音输入并转录。
4. **转录管理**：在 Whispering 应用中审阅和编辑转录文本，确保准确和清晰。
5. **自动剪贴板集成**：转录完成后，文本会自动复制到剪贴板，也可选择自动粘贴。

## 我的数据如何存储？

Whispering 会尽可能将数据本地化存储在你的设备上，包括录音和文字转录内容。这种方式可确保最大程度的隐私和数据安全。以下是数据处理的概览：

1. **本地存储**：语音录音和转录文本存储在 IndexedDB 中，它作为二进制数据存储和所有文本、转录数据的存储位置。

2. **转录服务**：只有在你选择外部转录服务时，录音才会被发送到外部服务。你有以下选项：
   - 外部服务，如 OpenAI 或 Groq
   - 本地转录服务，例如 `faster-whisper-server`，所有数据均保留在本地设备

3. **可配置设置**：你可以在设置中更改转录服务，以确保最大本地化功能。


## 安装

### 网页应用

访问 [whispering.bradenwong.com](https://whispering.bradenwong.com/)，该页面托管了最新版本的 `apps/app` 文件夹（由 Vercel 托管）。

### Chrome 扩展

从 Chrome 网上应用店 [此处](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo) 安装 Chrome 扩展。

### 桌面应用

如需下载安装 Whispering 桌面应用，请按你的操作系统步骤操作：

#### Windows

1. 从 [最新发布页面](https://github.com/braden-w/whispering/releases) 下载以 `.msi` 结尾的安装包。
2. 打开下载的 `.msi` 文件运行安装程序。
3. 如果提示不安全，请点击 `更多信息` -> `仍然运行` 以继续安装。
4. 按照屏幕上的说明完成安装。

#### macOS

对于 macOS，请按以下步骤安装 Whispering：

1. **下载安装包**：
   - 访问 [最新发布页面](https://github.com/braden-w/whispering/releases)。
   - 选择合适的安装包：
     - Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Intel: `Whispering_x.x.x_x64.dmg`

2. **安装应用**：
   - 打开下载的 `.dmg` 文件。
   - 将 Whispering 应用拖动到“应用程序”文件夹。

3. **启动 Whispering**：
   - 在“应用程序”文件夹中打开 Whispering。
   - 如果看到关于未验证开发者的警告：
     - 点击 `取消`
     - 在 Finder 中右键应用并选择 `打开`

4. **故障排查**（仅限 Apple Silicon）：
   如果遇到 “Whispering 已损坏，无法打开” 的错误提示：
   - 打开终端
   - 运行以下命令：
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - 再次尝试打开应用

完成上述步骤后，Whispering 应可在你的 macOS 系统上正常使用。

#### Linux

对于 Linux，有多种安装方式可选，请选择适合你的环境的方式：

1. **AppImage**：

   - 从 [最新发布页面](https://github.com/braden-w/whispering/releases) 下载 `.AppImage` 文件。
   - 使文件具有可执行权限：
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - 运行 AppImage：
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB 包（Debian/Ubuntu）**：
   - 从 [最新发布页面](https://github.com/braden-w/whispering/releases) 下载 `.deb` 文件。
   - 使用 `dpkg` 安装包：
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - 解决依赖问题：
     ```bash
     sudo apt-get install -f
     ```

安装完成后，应用即可使用。

## 使用方法

### Chrome 扩展

安装 Chrome 扩展后，你会在 Chrome 扩展栏看到 Whispering 图标。点击该图标打开扩展。点击麦克风按钮开始录音，录制完成后点击方形按钮。转录文本会显示在下方文本框中。

如需使用 ChatGPT 或 Claude 功能，进入 ChatGPT 或 Claude 网页。在聊天界面会看到新增的录音按钮。点击该按钮开始和结束录音，转录文本会自动插入聊天输入框。

如需使用快捷键功能，按下 <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> 或 <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd>（后续可在 Chrome 扩展快捷键中配置）即可在任意网站开始录音。转录文本会自动复制到剪贴板并粘贴到当前输入框中。

Chrome 扩展会与 [whispering.bradenwong.com](https://whispering.bradenwong.com) 通信，如未检测到网页，将自动在后台创建标签页。大多数 bug 都与此通信失败有关，比如极少数情况下标签页休眠。

### 网页应用

可通过 [whispering.bradenwong.com](https://whispering.bradenwong.com) 访问网页应用。点击麦克风按钮开始录音，录制完成后点击方形按钮。转录文本会显示在文本框中。

### 桌面应用

安装 Whispering 桌面应用后，按下 <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd>（可在设置中配置）即可随时在桌面任意位置开始录音。转录文本会自动复制到剪贴板并粘贴，相关功能可在设置中开关。

## 技术栈

#### 网页端与桌面端

Whispering 应用基于以下技术和库构建：

- [Svelte 5](https://svelte.dev)：首选的 UI 响应式库。
- [SvelteKit](https://kit.svelte.dev/docs)：用于路由和静态站点生成，支持网站与 Tauri 应用前端的静态页面。
- [Tauri](https://tauri.studio/en/docs/intro/)：桌面应用开发框架。
- [Effect-TS](https://github.com/Effect-TS/effect)：为代码增添函数式编程风格，编写极其类型安全的函数，错误类型包含在函数签名的返回值中。
- [Svelte Sonner](https://svelte-sonner.vercel.app/)：Svelte 应用的简单可定制化 toast 库。用于通过 `renderAsToast` 函数捕获并展示 Effect-TS 抛出的错误。
- [TanStack Table](https://tanstack.com/table)：数据表格的核心动力。
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API)：浏览器端用于存储大量结构化数据的低级 API，并与 Tanstack Table 同步。
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte)：首选的 UI 组件库。
- [TailwindCSS](https://tailwindcss.com/docs)：快速构建自定义用户界面的原子 CSS 框架。
- [Turborepo](https://turborepo.org/)：单体仓库管理工具，让 `apps/app` 和 `apps/extension` 共享代码库，大幅减少代码重复，更重要的是保持单一数据源。
- [Rust](https://www.rust-lang.org)：扩展桌面应用特性，如使用 `enigo` crate 实现自动粘贴功能。
- [Vercel](https://vercel.com/)：适合业余项目的托管服务，具备优秀的 Turborepo 集成。
- [Zapsplat.com](https://www.zapsplat.com/)：免版权音效库。

#### 扩展端

Whispering Chrome 扩展基于以下技术构建：

- [Plasmo](https://docs.plasmo.com/)：Chrome 扩展开发框架。我们使用 [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) 与 Whispering 网站通信。
- [Effect-TS](https://github.com/Effect-TS/effect)：为代码增添函数式编程风格，编写极其类型安全的函数，错误类型包含在函数签名的返回值中。
- [React](https://reactjs.org)：Chrome 扩展的 UI 响应式库，因 Plasmo 暂不支持 Svelte 5。
- [ShadCN](https://github.com/shadcn)：Chrome 扩展的 UI 组件库。
- [TailwindCSS](https://tailwindcss.com/docs)：一个以实用为先的 CSS 框架，可用于快速构建自定义用户界面。
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/)：Chrome 扩展 API。
- [Zapsplat.com](https://www.zapsplat.com/)：免版权音效库。

## 在本地开发模式运行 Whispering

要在本地计算机上设置该项目，请按照以下步骤操作：

1. 克隆仓库：`git clone https://github.com/braden-w/whispering.git`
2. 进入项目目录：`cd whispering`
3. 安装必要依赖：`pnpm i`

要在开发模式下运行 Whispering 桌面应用和网站：

4. 进入 app 目录：`cd apps/app`
5. 运行开发服务器：`pnpm tauri dev`

桌面应用应会自动打开进行本地开发。要开发 Web 应用，请在浏览器中访问 `http://localhost:5173`。

要在开发模式下运行 Whispering Chrome 扩展：

4. 进入 extension 目录：`cd apps/extension`
5. 运行开发服务器：`pnpm dev --target=chrome-mv3`

要开发 Chrome 扩展，请在 Chrome 中打开 `chrome://extensions`，启用开发者模式，并将 `apps/extension/build/{platform}-{manifest-version}-dev` 文件夹作为未打包扩展加载。

## 自行构建可执行文件

如果您对安装程序的可信度有疑虑或希望获得更多控制权，您始终可以自行构建可执行文件。这需要更多的设置，但可以确保您运行的是您期望的代码。这就是开源软件的魅力！

### Chrome

1. 进入 extension 目录：`cd apps/extension`
2. 安装必要依赖：`pnpm i`
3. 运行 Plasmo 构建：`pnpm plasmo build --target=chrome-mv3`
4. 输出文件应位于 `apps/extension/build/chrome-mv3-prod`，可作为未打包扩展加载到 Chrome 中。
5. 或者，您也可以为 Chrome Web Store 构建扩展：`pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. 进入 extension 目录：`cd apps/extension`
2. 安装必要依赖：`pnpm i`
3. 运行 Plasmo 构建：`pnpm plasmo build --target=firefox-mv3`
4. 输出文件应位于 `apps/extension/build/firefox-mv3-prod`，可作为未打包扩展加载到 Chrome 中。
5. 或者，您也可以为 Chrome Web Store 构建扩展：`pnpm plasmo build --target=firefox-mv3 --release`

### 桌面端

1. 进入 app 目录：`cd apps/app`
2. 安装必要依赖：`pnpm i`
3. 运行 Tauri 构建：`pnpm tauri build`
4. 您可以在 `apps/app/target/release` 目录下找到可执行文件。

## 贡献

我们欢迎社区的贡献！如果您想为 Whispering 做出贡献，请按照以下步骤操作：

1. Fork 此仓库。
2. 为您的新功能或修复创建新分支：`git checkout -b feature/your-feature-name` 或 `git checkout -b fix/your-bugfix-name`
3. 进行更改并以描述性信息提交。
4. 将您的分支推送到 Fork 的仓库：`git push origin your-branch-name`
5. 从您的 Fork 仓库向原始仓库创建 pull request。

请确保您的代码遵循既定规范并有良好文档说明。

## 许可协议

Whispering 遵循 [MIT License](https://opensource.org/licenses/MIT) 开源协议发布。

## 赞助商

本项目由以下出色的个人和组织支持：

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## 支持与反馈

如果您遇到任何问题或有改进建议，请在 [GitHub issues 标签页](https://github.com/braden-w/whispering/issues) 提交 issue，或通过 [whispering@bradenwong.com](mailto:whispering@bradenwong.com) 联系我。非常感谢您的反馈！

感谢您使用 Whispering，祝您写作愉快！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---