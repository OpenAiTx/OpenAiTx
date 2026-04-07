# Payload OAuth2 插件

<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-brightgreen.svg" alt="软件许可" />
</a>
<a href="https://github.com/wilsonle/payload-oauth2/issues">
  <img src="https://img.shields.io/github/issues/wilsonle/payload-oauth2.svg" alt="问题" />
</a>
<a href="https://npmjs.org/package/payload-oauth2">
  <img src="https://img.shields.io/npm/v/payload-oauth2.svg?style=flat-squar" alt="NPM" />
</a>

# 功能

- ✅ 兼容 Payload v3
- 🔐 配置任意提供商的 OAuth2
- ✨ 零依赖
- ⚙ 高度可定制

# 集成

从技术上讲，该插件应适用于所有通用的 OAuth2 提供商。以下是已测试的提供商列表：

| 提供商   | 状态                                                                                                                                                                                                        | 示例                             |
| -------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| Google   | [![测试 Google OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml)      | [配置](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/google.ts)  |
| Zitadel  | [![测试 Zitadel OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml)   | [配置](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/zitadel.ts) |
| Apple    | 测试未实现                                                                                                                                                                                                  | [配置](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/apple.ts)   |

# 安装

```
npm install payload-oauth2
yarn install payload-oauth2
pnpm install payload-oauth2
```
如果你喜欢冒险并想自己管理插件，可以将 `src` 目录复制到你的 payload 项目中。

# 贡献

欢迎贡献和反馈。

运行步骤：

1. 克隆项目。
2. `pnpm install`
3. `pnpm dev`

# 许可证

MIT 许可证 (MIT)。更多信息请参见 [许可证文件](LICENSE)。

# 致谢

此包的灵感来自 [Payload Plugin OAuth](https://github.com/thgh/payload-plugin-oauth)。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---