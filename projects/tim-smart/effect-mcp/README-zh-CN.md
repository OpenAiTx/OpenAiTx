<translate-content># effect mcp 服务器

[![安装 MCP 服务器](https://cursor.com/deeplink/mcp-install-dark.svg)](https://cursor.com/install-mcp?name=effect%20docs&config=eyJjb21tYW5kIjoibnB4IC15IGVmZmVjdC1tY3AifQ%3D%3D)

该 MCP 服务器添加了用于访问 Effect 文档的工具和资源。

## 使用方法

您可以使用以下命令通过 docker 运行：
</translate-content>
```bash
docker run --rm -i timsmart/effect-mcp
```
或者使用 npx：


```bash
npx -y effect-mcp
```
## Claude 代码集成

要将此 MCP 服务器与 Claude 代码一起使用，请运行以下命令：


```bash
claude mcp add-json effect-docs '{
  "command": "npx",
  "args": [
    "-y",
    "effect-mcp"
  ],
  "env": {}
}' -s user
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---