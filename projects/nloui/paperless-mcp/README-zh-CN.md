[![MseeP.ai 安全评估徽章](https://mseep.net/pr/nloui-paperless-mcp-badge.png)](https://mseep.ai/app/nloui-paperless-mcp)

# Paperless-NGX MCP 服务器

[![smithery 徽章](https://smithery.ai/badge/@nloui/paperless-mcp)](https://smithery.ai/server/@nloui/paperless-mcp)

一个用于与 Paperless-NGX API 服务器交互的 MCP（模型上下文协议）服务器。该服务器提供了管理 Paperless-NGX 实例中的文档、标签、往来人和文档类型的工具。

## 快速开始

### 通过 Smithery 安装

通过 [Smithery](https://smithery.ai/server/@nloui/paperless-mcp) 自动为 Claude Desktop 安装 Paperless NGX MCP 服务器：

```bash
npx -y @smithery/cli install @nloui/paperless-mcp --client claude
```

### 手动安装
1. 安装 MCP 服务器：
```bash
npm install -g paperless-mcp
```

2. 将其添加到您的 Claude MCP 配置中：

对于 VSCode 扩展，编辑 `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`：
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```

对于Claude桌面应用，编辑 `~/Library/Application Support/Claude/claude_desktop_config.json` ：
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```
3. 获取您的 API 令牌：  
   1. 登录您的 Paperless-NGX 实例  
   2. 点击右上角的用户名  
   3. 选择“我的资料”  
   4. 点击圆形箭头按钮生成新令牌  

4. 替换 MCP 配置中的占位符：  
   - 将 `http://your-paperless-instance:8000` 替换为您的 Paperless-NGX URL  
   - 将 `your-api-token` 替换为您刚刚生成的令牌  

就是这样！现在您可以让 Claude 帮助您管理 Paperless-NGX 文档。  

## 示例用法  

以下是您可以让 Claude 执行的一些操作：  

- “显示所有标记为‘发票’的文档”  
- “搜索包含‘报税’的文档”  
- “创建一个名为‘收据’、颜色为 #FF0000 的新标签”  
- “下载文档 #123”  
- “列出所有通信联系人”  
- “创建一个名为‘银行对账单’的新文档类型”  

## 可用工具  

### 文档操作  

#### list_documents  
获取所有文档的分页列表。  

参数：  
- page（可选）：页码  
- page_size（可选）：每页文档数量  


```typescript
list_documents({
  page: 1,
  page_size: 25
})
```

#### get_document
通过ID获取特定文档。

参数：
- id：文档ID

```typescript
get_document({
  id: 123
})
```

#### search_documents
跨文档全文搜索。

参数：
- query: 搜索查询字符串

```typescript
search_documents({
  query: "invoice 2024"
})
```

#### download_document
通过ID下载文档文件。

参数：
- id：文档ID
- original（可选）：如果为true，下载原始文件而非归档版本

```typescript
download_document({
  id: 123,
  original: false
})
```

#### bulk_edit_documents
对多个文档执行批量操作。

参数：
- documents：文档ID数组
- method：以下之一：
  - set_correspondent：设置文档的往来单位
  - set_document_type：设置文档类型
  - set_storage_path：设置文档存储路径
  - add_tag：为文档添加标签
  - remove_tag：从文档中移除标签
  - modify_tags：添加和/或移除多个标签
  - delete：删除文档
  - reprocess：重新处理文档
  - set_permissions：设置文档权限
  - merge：合并多个文档
  - split：将文档拆分为多个文档
  - rotate：旋转文档页面
  - delete_pages：删除文档中的特定页面
- 基于方法的附加参数：
  - correspondent：set_correspondent对应的ID
  - document_type：set_document_type对应的ID
  - storage_path：set_storage_path对应的ID
  - tag：add_tag/remove_tag对应的ID
  - add_tags：modify_tags对应的标签ID数组
  - remove_tags：modify_tags对应的标签ID数组
  - permissions：set_permissions对应的对象，包含所有者、权限、合并标志
  - metadata_document_id：merge时指定元数据来源的ID
  - delete_originals：merge/split时的布尔值
  - pages：split格式为"[1,2-3,4,5-7]"，delete_pages格式为"[2,3,4]"的字符串
  - degrees：rotate的角度数（90、180或270）

示例：
```typescript
// Add a tag to multiple documents
bulk_edit_documents({
  documents: [1, 2, 3],
  method: "add_tag",
  tag: 5
})

// Set correspondent and document type
bulk_edit_documents({
  documents: [4, 5],
  method: "set_correspondent",
  correspondent: 2
})

// Merge documents
bulk_edit_documents({
  documents: [6, 7, 8],
  method: "merge",
  metadata_document_id: 6,
  delete_originals: true
})

// Split document into parts
bulk_edit_documents({
  documents: [9],
  method: "split",
  pages: "[1-2,3-4,5]"
})

// Modify multiple tags at once
bulk_edit_documents({
  documents: [10, 11],
  method: "modify_tags",
  add_tags: [1, 2],
  remove_tags: [3, 4]
})
```

#### post_document
向 Paperless-NGX 上传新文档。

参数：
- file：Base64 编码的文件内容
- filename：文件名
- title（可选）：文档标题
- created（可选）：文档创建日期时间（例如 "2024-01-19" 或 "2024-01-19 06:15:00+02:00"）
- correspondent（可选）：通讯录 ID
- document_type（可选）：文档类型 ID
- storage_path（可选）：存储路径 ID
- tags（可选）：标签 ID 数组
- archive_serial_number（可选）：档案序列号
- custom_fields（可选）：自定义字段 ID 数组

```typescript
post_document({
  file: "base64_encoded_content",
  filename: "invoice.pdf",
  title: "January Invoice",
  created: "2024-01-19",
  correspondent: 1,
  document_type: 2,
  tags: [1, 3],
  archive_serial_number: "2024-001"
})
```

### 标签操作

#### list_tags
获取所有标签。

```typescript
list_tags()
```
#### create_tag
创建一个新标签。

参数：
- name：标签名称
- color（可选）：十六进制颜色代码（例如 "#ff0000"）
- match（可选）：匹配的文本模式
- matching_algorithm（可选）：以下之一 "any"、"all"、"exact"、"regular expression"、"fuzzy"


```typescript
create_tag({
  name: "Invoice",
  color: "#ff0000",
  match: "invoice",
  matching_algorithm: "fuzzy"
})
```

### 通讯员操作

#### list_correspondents
获取所有通讯员。

```typescript
list_correspondents()
```

#### create_correspondent
创建一个新的通讯员。

参数：
- name：通讯员名称
- match（可选）：匹配的文本模式
- matching_algorithm（可选）：以下之一 "any"、"all"、"exact"、"regular expression"、"fuzzy"

```typescript
create_correspondent({
  name: "ACME Corp",
  match: "ACME",
  matching_algorithm: "fuzzy"
})
```

### 文档类型操作

#### list_document_types
获取所有文档类型。

```typescript
list_document_types()
```

#### create_document_type
创建一个新的文档类型。

参数：
- name：文档类型名称
- match（可选）：匹配的文本模式
- matching_algorithm（可选）："any"、"all"、"exact"、"regular expression"、"fuzzy" 中的一个

```typescript
create_document_type({
  name: "Invoice",
  match: "invoice total amount due",
  matching_algorithm: "any"
})
```

## 错误处理

如果出现以下情况，服务器将显示明确的错误信息：
- Paperless-NGX 的 URL 或 API 令牌不正确
- 无法连接到 Paperless-NGX 服务器
- 请求的操作失败
- 提供的参数无效

## 开发

想要贡献代码或修改服务器？以下是你需要了解的：

1. 克隆仓库
2. 安装依赖：
```bash
npm install
```

3. 对 server.js 进行更改  
4. 本地测试：
```bash
node server.js http://localhost:8000 your-test-token
```
服务器构建于：
- [litemcp](https://github.com/wong2/litemcp)：一个用于构建MCP服务器的TypeScript框架
- [zod](https://github.com/colinhacks/zod)：以TypeScript为先的模式验证工具

## API 文档

此MCP服务器实现了Paperless-NGX REST API的端点。有关底层API的更多详细信息，请参阅[官方文档](https://docs.paperless-ngx.com/api/)。

## 运行MCP服务器

MCP服务器可以以两种模式运行：

### 1. stdio（默认）

这是默认模式。服务器通过stdio进行通信，适用于CLI和直接集成。


```
npm run start -- <baseUrl> <token>
```

### 2. HTTP（可流式传输的 HTTP）

要以 HTTP 服务运行服务器，请使用 `--http` 标志。您还可以使用 `--port` 指定端口（默认：3000）。此模式需要安装 [Express](https://expressjs.com/)（它作为依赖包含在内）。

```
npm run start -- <baseUrl> <token> --http --port 3000
```

- MCP API 将在指定端口通过 `POST /mcp` 提供。
- 每个请求无状态处理，遵循 [StreamableHTTPServerTransport](https://github.com/modelcontextprotocol/typescript-sdk) 模式。
- 对 `/mcp` 的 GET 和 DELETE 请求将返回 405 方法不允许。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---