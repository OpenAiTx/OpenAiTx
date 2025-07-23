
# DeckTap（局域网MVP）

<a href="https://youtu.be/pNgNUWSf7C4" title="链接标题"><img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/hero.png" alt="替代文本" width="600"/></a>

📡 DeckTap 是一个轻量级的局域网远程控制工具，用于控制演示文稿。  
使用手机无线控制 PowerPoint、Keynote、PDF 幻灯片——无需安装应用。

---

## ✨ 功能

- 📱 通过手机浏览器控制幻灯片
- 🌐 支持局域网 Wi-Fi/热点网络
- 🖥 模拟键盘方向键来切换幻灯片
- 🚀 极简设置：运行本地 Node.js 服务器并扫描二维码
- 🔒 不需要互联网，**安全**且**私密**

---

## 📦 项目结构

```yaml
decktap/
├── client/            # Computer side agent
│    ├── lan.js        # LAN control
│    ├── cloud.js      # Connect cloud relay server in the future
│    └── config.js
│
├── controller/        # Mobile phone controller web page
│    └── index.html
│
├── server-cloud/      # Cloud server for remote control in the future
│    └── server.js
│
├── README.md
├── LICENSE
├── package.json
└── .gitignore
```
---

## 🔧 前提条件

### macOS 权限
DeckTap 使用 `@nut-tree/nut-js` 来模拟键盘事件。在 macOS 上，您需要授予终端辅助功能权限：

1. 打开 **系统设置** > **隐私与安全性** > **辅助功能**
2. 点击锁形图标 🔒 以进行更改
3. 点击 **+** 按钮
4. 选择 `Terminal.app`（或 iTerm、VS Code 等，取决于您使用的终端）
5. 勾选终端应用程序旁的复选框

> **注意**：如果没有这些权限，DeckTap 将无法控制您的演示文稿。

---

## 🚀 快速开始（局域网模式）
1. 安装依赖：
   ```bash
   cd decktap-web && npm install && npm run build
   cd .. && npm install
   ```
2. 授予辅助功能权限（仅限 macOS）：
   - 按照 [macOS 权限](#macos-permissions) 中的步骤操作
   - 授予权限后重启终端

3. 启动服务器：


   ```bash
   npm start
   ```
4. 连接您的手机：
   - 将手机连接到与电脑相同的WiFi网络（仅支持无vlan的私有WiFi，不支持校园网）
   - 在手机浏览器中打开显示的URL或扫描二维码
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/computer-client.png" width="600">
   - 开始控制您的演示（使用👉切换左右手模式）
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/phone-controller.png" width="300" >
  

---

## ~🖱️ 独立版快速上手~（尚不可用，未来将开发Electron客户端）

如果您收到了DeckTap的**独立可执行版本**（例如`decktap-macos`、`decktap-win.exe`或`decktap-linux`），可以直接运行，无需安装Node.js或任何依赖。

### 步骤
1. **macOS / Linux 用户：**
   - 第一次运行前，赋予执行权限（只需一次）：

     ```bash
     chmod +x decktap-macos
     ```
   - Run:
     ```bash
     ./decktap-macos
     ```
2. **Windows 用户：**  
   - 在命令提示符下运行：
     ```bat
     decktap-win.exe
     ```
3. **首次在 macOS 上运行：** 请按照终端提示授予辅助功能权限（参见上文 [macOS 权限](#macos-permissions)）。

4. **扫描二维码或在手机上打开显示的 URL，开始控制您的演示文稿！**

---

> 如果遇到无法运行、权限不足或无法访问页面等问题，请将终端错误信息发送给开发者寻求帮助。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---