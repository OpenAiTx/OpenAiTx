<div align="center">
  <img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/logo.svg" alt="Claude Code UI" width="64" height="64">
  <h1>Claude Code UI</h1>
</div>


一个适用于桌面和移动端的 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 用户界面，Anthropic 官方的 AI 辅助编码命令行工具。您可以本地或远程使用它来查看您在 Claude Code 中的活动项目和会话，并以与 Claude Code CLI 相同的方式进行更改。这样您就拥有了一个真正适用于所有平台的界面。

## 截图

<div align="center">
  
<table>
<tr>
<td align="center">
<h3>桌面视图</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/desktop-main.png" alt="Desktop Interface" width="400">
<br>
<em>主界面，显示项目概览和聊天</em>
</td>
<td align="center">
<h3>移动体验</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/mobile-chat.png" alt="Mobile Interface" width="250">
<br>
<em>响应式移动设计，支持触控导航</em>
</td>
</tr>
</table>



</div>

## 功能特点

- **响应式设计** - 无缝支持桌面、平板和移动设备，您也可以从手机使用 Claude Code
- **交互式聊天界面** - 内置聊天界面，实现与 Claude Code 的无缝通信
- **集成终端** - 通过内置 shell 功能直接访问 Claude Code CLI
- **文件浏览器** - 交互式文件树，支持语法高亮和实时编辑
- **Git 浏览器** - 查看、暂存和提交更改，还可以切换分支
- **会话管理** - 恢复对话，管理多个会话，并跟踪历史记录


## 快速开始

### 前提条件

- [Node.js](https://nodejs.org/) v20 或更高版本
- 已安装并配置好 [Claude Code CLI](https://docs.anthropic.com/en/docs/claude-code)

### 安装

1. **克隆仓库：**
```bash
git clone https://github.com/siteboon/claudecodeui.git
cd claudecodeui
```
<translate-content>
2. **安装依赖项：**</translate-content>
```bash
npm install
```
3. **配置环境：**

```bash
cp .env.example .env
# Edit .env with your preferred settings
```
<translate-content>
4. **启动应用程序：**</translate-content>
```bash
# Development mode (with hot reload)
npm run dev

```
应用程序将从您在 .env 中指定的端口启动

5. **打开浏览器：**
   - 开发环境：`http://localhost:3001`

## 安全性与工具配置

**🔒 重要提示**：所有 Claude Code 工具默认**禁用**。这防止了潜在的有害操作自动运行。

### 启用工具

要使用 Claude Code 的全部功能，您需要手动启用工具：

1. **打开工具设置** - 点击侧边栏的齿轮图标
3. **选择性启用** - 仅开启您需要的工具
4. **应用设置** - 您的偏好设置会被本地保存

<div align="center">

![工具设置模态框](https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/tools-modal.png)
*工具设置界面 - 仅启用您需要的工具*

</div>

**推荐做法**：从启用基础工具开始，按需添加更多。您可以随时调整这些设置。

## 使用指南

### 核心功能

#### 项目管理
界面自动从 `~/.claude/projects/` 发现 Claude Code 项目，并提供：
- **可视化项目浏览器** - 所有可用项目及其元数据和会话计数
- **项目操作** - 重命名、删除和组织项目
- **智能导航** - 快速访问最近的项目和会话

#### 聊天界面
- **使用响应式聊天或 Claude Code CLI** - 您可以使用适配的聊天界面，或通过 shell 按钮连接到 Claude Code CLI。
- **实时通信** - 通过 WebSocket 连接流式传输 Claude 响应
- **会话管理** - 恢复之前的对话或开启新会话
- **消息历史** - 完整的对话历史，含时间戳和元数据
- **多格式支持** - 文本、代码块和文件引用

#### 文件浏览器与编辑器
- **交互式文件树** - 浏览项目结构，支持展开/折叠导航
- **实时文件编辑** - 直接在界面中读取、修改和保存文件
- **语法高亮** - 支持多种编程语言
- **文件操作** - 创建、重命名、删除文件和目录

#### Git 浏览器


#### 会话管理
- **会话持久化** - 所有对话自动保存
- **会话组织** - 按项目和时间戳分组会话
- **会话操作** - 重命名、删除和导出对话历史
- **跨设备同步** - 可从任何设备访问会话

### 移动应用
- **响应式设计** - 适配所有屏幕尺寸
- **触控友好界面** - 支持滑动手势和触控导航
- **移动导航** - 底部标签栏便于拇指操作
- **自适应布局** - 可折叠侧边栏和智能内容优先级
- **添加快捷方式到主屏幕** - 添加快捷方式后，应用将表现如 PWA

## 架构

### 系统概览

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   Frontend      │    │   Backend       │    │  Claude CLI     │
│   (React/Vite)  │◄──►│ (Express/WS)    │◄──►│  Integration    │
└─────────────────┘    └─────────────────┘    └─────────────────┘
```
### 后端 (Node.js + Express)
- **Express 服务器** - RESTful API 及静态文件服务
- **WebSocket 服务器** - 用于聊天和项目刷新通信
- **Claude CLI 集成** - 进程生成与管理
- **会话管理** - JSONL 解析与对话持久化
- **文件系统 API** - 暴露项目文件浏览器

### 前端 (React + Vite)
- **React 18** - 现代组件架构与钩子
- **CodeMirror** - 高级代码编辑器，支持语法高亮





### 贡献指南

欢迎贡献！请遵循以下准则：

#### 入门指南
1. **Fork** 本仓库
2. **克隆** 你的 Fork：`git clone <your-fork-url>`
3. **安装** 依赖：`npm install`
4. **创建** 功能分支：`git checkout -b feature/amazing-feature`

#### 开发流程
1. **按现有代码风格** 进行修改
2. **全面测试** - 确保所有功能正常
3. **运行质量检查**：`npm run lint && npm run format`
4. **提交** 带有描述性信息的代码，遵循 [Conventional Commits](https://conventionalcommits.org/)
5. **推送** 到你的分支：`git push origin feature/amazing-feature`
6. **提交** Pull Request，包含：
   - 明确的变更描述
   - UI 变更截图
   - 如适用，测试结果

#### 可贡献内容
- **漏洞修复** - 帮助提升稳定性
- **新功能** - 增强功能（先在 issues 讨论）
- **文档** - 改进指南和 API 文档
- **UI/UX 改进** - 优化用户体验
- **性能优化** - 提升速度

## 故障排除

### 常见问题及解决方案

#### “未找到 Claude 项目”
**问题**：界面未显示项目或项目列表为空  
**解决方案**：
- 确保已正确安装 [Claude CLI](https://docs.anthropic.com/en/docs/claude-code)
- 在至少一个项目目录中运行 `claude` 命令以初始化
- 验证 `~/.claude/projects/` 目录存在且权限正确  
d

#### 文件浏览器问题
**问题**：文件无法加载、权限错误、目录为空  
**解决方案**：
- 检查项目目录权限（终端执行 `ls -la`）
- 确认项目路径存在且可访问
- 查看服务器控制台日志获取详细错误信息
- 确保未尝试访问项目范围外的系统目录


## 许可证

GNU 通用公共许可证 v3.0 - 详情见 [LICENSE](LICENSE) 文件。

本项目开源，遵循 GPL v3 许可证，免费使用、修改和分发。

## 致谢

### 构建工具
- **[Claude Code](https://docs.anthropic.com/en/docs/claude-code)** - Anthropic 官方 CLI
- **[React](https://react.dev/)** - 用户界面库
- **[Vite](https://vitejs.dev/)** - 快速构建工具及开发服务器
- **[Tailwind CSS](https://tailwindcss.com/)** - 实用优先的 CSS 框架
- **[CodeMirror](https://codemirror.net/)** - 高级代码编辑器


## 支持与社区

### 保持更新
- **Star** 本仓库以示支持
- **Watch** 以获取更新和新版本通知
- **关注** 项目公告

### 赞助商
- [Siteboon - AI 驱动的网站构建器](https://siteboon.ai)
---

<div align="center">
  <strong>为 Claude Code 社区精心制作。</strong>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---