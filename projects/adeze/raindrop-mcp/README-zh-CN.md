# Raindrop.io MCP 服务器

[![smithery 徽章](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm 版本](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude 桌面 MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

使用简单的 MCP 服务器将 Raindrop.io 连接到您的 AI 助手。通过自然语言组织、搜索和管理书签。

## 它能做什么

- 创建、更新和删除集合及书签
- 按标签、域名、类型、日期等搜索书签
- 管理标签（列出、重命名、合并、删除）
- 阅读书签中的高亮内容
- 批量编辑集合中的书签
- 审计断链和重复项，管理回收站

## 工具

- **diagnostics** - 服务器诊断信息和库健康指标
- **collection_list** - 以扁平列表形式列出所有集合
- **get_collection_tree** - 以层级视图显示集合及完整面包屑路径
- **collection_manage** - 创建、更新或删除集合
- **bookmark_search** - 支持筛选、标签和分页的高级搜索
- **bookmark_manage** - 创建、更新或删除书签
- **get_raindrop** - 通过 ID 获取单个书签
- **list_raindrops** - 分页列出某集合的书签
- **get_suggestions** - 针对 URL 或书签的 AI 驱动组织建议（标签/集合）
- **suggest_tags** - 通过 AI 辅助分析从书签元数据建议相关标签
- **bulk_edit_raindrops** - 批量更新、移动或移除指定集合中的书签
- **tag_manage** - 重命名、合并或删除标签
- **highlight_manage** - 创建、更新或删除高亮
- **library_audit** - 扫描库中的断链、重复和无标签项
- **empty_trash** - 永久清空回收站（需确认）
- **cleanup_collections** - 删除空集合（需确认）
- **remove_duplicates** - 查找并删除重复书签，带安全确认流程

## 安装

### 快速开始（一行命令）
| 工具               | 一行命令                                                         |
| :----------------- | :---------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp`  |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`             |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp` |
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                                |

> **注意**：对于通过 `npx` 添加 MCP 服务器的工具，您必须在 shell 或工具的环境配置中设置 `RAINDROP_ACCESS_TOKEN` 环境变量。

### Vercel Skills (npx skills)

该项目兼容 [Vercel Skills](https://github.com/vercel/skills) 系统。所有必要的清单文件均已包含：

- `manifest.json`：用于服务器定义的标准 MCP 清单。
- `SKILL.md`：用于代理发现的标准化技能描述。
- `mcp.json`：MCP 客户端和注册表的根配置。

要将此服务器添加到您的本地技能目录：


```bash
npx skills add adeze/raindrop-mcp --global
```
要将此贡献到 [Vercel Skills Registry](https://github.com/vercel/skills/tree/main/registry)，请提交一个 Pull Request，将此仓库 URL 添加到注册表中。

### Claude Desktop (MCPB)

从 GitHub Release 下载最新的 raindrop-mcp.mcpb，并将其添加到 Claude Desktop：

- Releases: https://github.com/adeze/raindrop-mcp/releases

在 Claude Desktop 中，添加该包并设置此环境变量：

- RAINDROP_ACCESS_TOKEN（来自您的 Raindrop.io 集成设置）

### NPX (CLI)

将您的 API 令牌设置为环境变量，然后运行：


```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### 手动 MCP 配置 (mcp.json)

将此添加到您的 MCP 客户端配置中：

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```

## 需求

- 一个 Raindrop.io 账户
- 一个 Raindrop.io API 访问令牌：https://app.raindrop.io/settings/integrations

## 支持

- 问题反馈：https://github.com/adeze/raindrop-mcp/issues

## 发布

本仓库使用 `semantic-release` 作为唯一支持的发布流程。

### 发布流程说明

- 发布由推送到 `master` 分支触发，通过 `.github/workflows/ci.yml` 执行。
- `semantic-release` 解析 Conventional Commit 消息，计算下一个版本，更新 `CHANGELOG.md`，在 GitHub 上打标签/发布，并发布到 npm。
- 在发布准备阶段，`.releaserc.json` 同步 `manifest.json`、`mcp.json` 和 `gemini-extension.json`，然后构建 `raindrop-mcp.mcpb`，使 GitHub Release 包含该包。

### 预发布干运行

- 在切公共发布前，运行 `.github/workflows/release-dry-run.yml` 的 **Run workflow**。
- 这会验证语义版本计算、注册表认证和发布流程行为，但不进行实际发布。

### 必需的密钥

- `GITHUB_TOKEN` 由 GitHub Actions 提供，用于发布自动化。

### npm 受信任的发布

- npm 发布通过 GitHub Actions 的 OIDC 受信任发布配置。
- 标准 CI 发布路径不需要 `NPM_TOKEN`。

### 合并前本地验证

```bash
bun run lint
bun run type-check
bun run test
bun run build
```
### 提交信息示例

- `fix: 处理空标签合并负载`
- `feat: 添加收藏路径过滤器`
- `feat!: 移除已弃用的搜索参数`

正常发布时请勿手动升级版本、推送发布标签或运行手动 npm 发布命令。

## 📋 最近增强功能 (v2.4.x)

### 智能组织与层级结构

- **AI 建议**：新增 `get_suggestions` 工具，使用 Raindrop 的 API 和 MCP 采样提供组织建议。
- **收藏树**：`get_collection_tree` 工具提供带完整面包屑路径的层级视图。
- **批量移动**：向 `bulk_edit_raindrops` 添加了 `move` 操作，实现高效的库组织。
- **分页支持**：标准化 `list_raindrops` 和 `bookmark_search`，支持大型库的分页。

### 安全与质量

- **确认逻辑**：破坏性工具（`empty_trash`、`cleanup_collections`）现在需要明确确认。
- **命名规范**：所有工具现均采用统一的蛇形命名规范。
- **CI/CD 流水线**：增强 GitHub Actions，自动执行代码检查、类型检查及跨传输测试。
- **代码质量**：建立 ESLint 和 Prettier 配置，保证开发可维护性。

## 📋 之前的增强功能 (v2.3.3)

### 高级清理与库审计

## 📋 之前的增强功能 (v2.3.2)

### MCP 资源链接实现

- 现代化的 `resource` 内容，遵循当前 MCP SDK 最佳实践
- 高效数据访问：工具返回轻量级链接而非完整负载
- 性能提升：客户端仅在需要时获取完整书签/收藏数据
- 与动态资源系统无缝集成（`mcp://raindrop/{id}`）

### SDK 与 API 更新


- 更新至本仓库支持的最新 MCP SDK  
- 采用现代化工具注册，描述更详尽  
- 修正 API 端点和路径参数  
- 所有核心工具均可正常使用  

### 工具优化  

- 书签/收藏列表响应更节省资源  
- 通过 `mcp://collection/{id}` 和 `mcp://raindrop/{id}` 实现动态资源访问  
- 客户端体验提升，列表负载更轻  
- 完全符合 MCP 官方 SDK 规范  

### 服务层改进  

- 通过提取公共辅助函数减少代码量  
- 错误处理和响应处理更一致  
- 使用泛型处理器增强类型安全  
- 端点构建集中管理  

### 测试改进  

- MCP 工具执行端到端覆盖更全面  
- 扩展了针对真实客户端流程的集成测试  

### MCP 2.0 准备（批量操作）  

- 为 MCP 2.0 批量操作工作流和工具奠定基础  

### OAuth（即将推出）  

- 基于 OAuth 的认证流程，简化设置，无需手动令牌  

### 说明  

对最近几次构建受影响的用户表示歉意，感谢您的耐心和反馈。  

## 许可  

本项目采用 MIT 许可协议 - 详情请参阅 [LICENSE](LICENSE) 文件。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---