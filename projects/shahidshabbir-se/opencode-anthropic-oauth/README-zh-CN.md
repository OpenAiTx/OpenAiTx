# opencode-anthropic-oauth

Anthropic Claude Pro/Max OAuth 登录的 OpenCode 插件 — 无需 Claude Code。

## 功能介绍

让您通过浏览器 OAuth 直接在 OpenCode 中使用 Claude Pro/Max 订阅进行身份验证。无需安装 Claude Code 或管理凭证文件。

## 安装

```bash
npm install -g opencode-anthropic-oauth
```

然后添加到你的 `opencode.json` 中：

```json
{
  "plugin": ["opencode-anthropic-oauth"]
}
```

## 使用方法

1. 在 OpenCode 中运行 `/connect`（或在命令行运行 `oc auth login`）
2. 选择 **Anthropic** > **Claude Pro/Max**
3. 在浏览器中打开链接并授权
4. 将代码粘贴回 OpenCode
5. 完成 — 现在所有 Anthropic 模型均可使用

## 工作原理

- 直接针对 Anthropic 的认证端点实现 OAuth PKCE 流程
- 打开浏览器进行身份验证 — 使用 Claude 账户登录
- 用授权码交换访问令牌和刷新令牌
- **令牌过期时自动刷新** — 无需手动重新授权
- 在 Anthropic 请求上设置必需的 API 头部
- **保留提示缓存**，实现高效令牌使用

## 更新日志

### 0.4.1
- **修复高令牌消耗问题** — 移除禁用提示缓存的 `cache_control` 剥离
- 添加 `x-anthropic-billing-header` 以实现准确的令牌追踪
- 使测试版标志与官方 Claude CLI 插件保持一致

### 0.4.0
- 添加用于 OAuth 兼容性的 `?beta=true` URL 参数
- 为 claude-code 测试版注入系统身份前缀
- 剥离 `cache_control`（现已在 0.4.1 中移除）

### 0.3.0
- 通过加载器钩子添加自动令牌刷新功能
- 后台主动刷新计时器（每 5 分钟触发）

## 环境变量覆盖

所有 OAuth 参数都可以通过环境变量覆盖。如果 Anthropic 在我们发布更新前做了更改，设置环境变量即可继续工作：

| 变量 | 描述 |
|---|---|
| `ANTHROPIC_CLIENT_ID` | OAuth 客户端 ID |
| `ANTHROPIC_CLI_VERSION` | Claude CLI 版本，用于 User-Agent |
| `ANTHROPIC_USER_AGENT` | 完整的 User-Agent 字符串（覆盖版本） |
| `ANTHROPIC_AUTHORIZE_URL` | OAuth 授权端点 |
| `ANTHROPIC_TOKEN_URL` | OAuth 令牌端点 |
| `ANTHROPIC_REDIRECT_URI` | OAuth 重定向 URI |
| `ANTHROPIC_SCOPES` | OAuth 作用域 |
| `ANTHROPIC_BETA_FLAGS` | Anthropic 测试功能标志 |

示例：

```bash
export ANTHROPIC_CLI_VERSION=2.2.0
```

## 免责声明

此插件使用Anthropic的公共OAuth客户端ID进行身份验证。Anthropic的服务条款（2026年2月）规定，Claude Pro/Max订阅令牌应仅与官方Anthropic客户端一起使用。此插件作为社区解决方案存在，如果Anthropic更改其OAuth基础设施，可能会停止工作。请自行斟酌使用。

## 许可协议

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-20

---