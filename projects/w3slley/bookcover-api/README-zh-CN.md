# 一个用于从互联网检索书籍封面的API。

这是一个简单的API，从Goodreads获取书籍封面图片。您可以使用书名和作者，或使用ISBN编号搜索封面。它返回一个封面图片的直接URL，您可以在应用程序中使用。

## 文档

### GET /bookcover

使用书名和作者名搜索书籍封面。

**必需参数：**
- `book_title` (字符串)：书名
- `author_name` (字符串)：书籍作者名

**示例请求：**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover?book_title=The+Pale+Blue+Dot&author_name=Carl+Sagan"
```
**示例响应：**

```json
{
  "url": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388620656i/55030.jpg"
}
```

### GET /bookcover/:isbn

使用ISBN-13号搜索书籍封面。

**示例请求：**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover/978-0345376596"
```
**示例响应：**

```json
{
  "url": "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1500191671i/61663.jpg"
}
```

## 工作原理

该 API 使用两种不同的方法从 Goodreads 获取图书封面图片：

1. **按书名和作者搜索**
   - 以书名和作者名作为输入
   - 在 Goodreads 中搜索并找到匹配的图书
   - 提取高质量封面图片的 URL
   - 缓存结果以加快未来请求速度

2. **按 ISBN-13 搜索**
   - 接受 13 位 ISBN 编号
   - 在 Goodreads 上直接查询
   - 返回图书封面 URL
   - 同时缓存成功的结果


该 API 以 JSON 格式提供清晰的错误信息：
- 400 错误请求：缺少参数或 ISBN 无效
- 404 未找到：未找到匹配的图书封面
- 所有响应均包含适当的 CORS 头信息


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---