# 通用工具调用协议（UTCP）规范

本仓库包含通用工具调用协议（UTCP）的官方规范文档。UTCP 是一种现代、灵活且可扩展的标准，用于跨多种通信协议定义和交互工具。

## 什么是 UTCP？

UTCP 为 AI 系统和其他客户端提供了一种标准化方式，可从不同提供者发现和调用工具，无论底层协议是 HTTP、WebSocket、CLI 等。本规范定义了：

- 工具发现机制
- 工具调用格式
- 提供者配置
- 认证方法
- 响应处理

## 参与规范贡献

我们欢迎对 UTCP 规范的贡献！您可以按以下方式参与：

1. **Fork 本仓库**：创建规范仓库的个人副本
2. **进行修改**：根据需要更新或添加文档
3. **提交 Pull Request**：提交 PR 以便审阅您的更改
4. **参与讨论**：加入对提案修改的讨论

参与贡献时，请遵循以下准则：

- 保证您的更改符合 UTCP 的整体愿景和目标
- 遵循既定的文档结构和格式
- 添加新特性或概念时请附上示例
- 更新相关部分以确保文档的一致性

## 本地构建文档

### 前置条件

要在本地构建和预览文档站点，您需要：

- Ruby 2.5.0 或更高版本
- RubyGems
- Bundler

### 安装步骤

1. 克隆本仓库：
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. 安装依赖项：

   ```bash
   bundle install
   ```
### 运行文档网站

要在本地构建并运行该网站：


```bash
bundle exec jekyll serve
```
这将启动一个本地 Web 服务器，地址为 `http://localhost:4000`，您可以在此预览文档。

## 文档结构

UTCP 文档组织如下：

- `index.md`：UTCP 首页和简介
- `docs/`
  - `introduction.md`：详细介绍和核心概念
  - `for-tool-providers.md`：工具提供者实现指南
  - `for-tool-callers.md`：工具调用者实现指南
  - `providers/`：各提供者类型文档
    - `http.md`：HTTP 提供者
    - `websocket.md`：WebSocket 提供者
    - `cli.md`：CLI 提供者
    - `sse.md`：服务器发送事件提供者
    - 等等
  - `implementation.md`：实现指南和最佳实践

## 规范使用

### 修改文档

文档采用带有 Jekyll front matter 的 Markdown 格式编写。修改时：

1. 确保 Markdown 符合既定风格
2. 提交 PR 前本地预览更改
3. 保持示例与最新规范同步
4. 添加新页面时更新 `_config.yml` 中的导航项

### 文件组织

添加新文档时：

- 将特定提供者文档放入 `docs/providers/`
- 使用一致的 front matter 并设置合适的导航顺序
- 包含标签以提升 GitHub Pages 上的搜索性

## 版本控制

UTCP 规范遵循语义化版本控制：

- 大版本（1.0，2.0）：协议破坏性更改
- 小版本（1.1，1.2）：向后兼容的新特性
- 补丁版本（1.0.1，1.0.2）：向后兼容的错误修复和说明

## 许可证

本规范采用 Mozilla 公共许可证 2.0（MPL-2.0）发布。

## 附加资源

- [UTCP GitHub 组织](https://github.com/universal-tool-calling-protocol)
- [UTCP 官网](https://utcp.io)
- [参考实现](https://github.com/universal-tool-calling-protocol/python-utcp)
- [社区讨论](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---