# SQLite 在线版

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="SQLite 在线版标志"
      width="128"
    />
  </a>
</div>

一个基于 React、TypeScript、Vite 和 `sql.js` 构建的客户端 SQLite 编辑器。  
它运行在浏览器中，默认初始化一个演示数据库，并且可以打开本地 SQLite 文件，无需后端支持。

## 概述

- **打开本地 `.db`、`.sqlite` 和 `.sqlite3` 文件**
- **使用 SQL 创建和修改表、视图和索引**
- **浏览、筛选、排序、分页、添加、编辑和删除行**
- **运行自定义 SQL 并导出结果为 CSV**

大部分数据库操作在浏览器中通过 WebAssembly 和 web worker 本地运行。  
可选功能如 URL 加载、CORS 代理回退、Google 字体和 Gemini 驱动的查询生成使用网络请求。

## 功能

- **本地优先的数据库编辑：**从磁盘打开文件，将数据库拖放到页面中，并下载当前数据库为  
  `database.sqlite`。
- **模式和数据工作流：**查看模式、浏览表数据、编辑行、插入新行、删除行以及执行自定义 SQL 语句。
- **CSV 导出路径：**导出整张表、当前表页或当前自定义查询结果集为 CSV。
- **附加用户体验功能：**暗黑模式、高对比度模式、键盘快捷键、跳过链接和无障碍的实时区域。
- **可选集成：**从 `?url=` 查询参数加载数据库，配置 Gemini API 密钥后通过 `/ai ...` 提示生成 SQL。








## 开发

```bash
npm install
npm run dev
```
有用的项目命令：

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## 键盘快捷键（热键）

使用这些内置热键简化您的工作流程：

| 快捷键               | 操作                        |
| -------------------- | --------------------------- |
| **Ctrl + s**         | 下载数据库                  |
| **Ctrl + ArrowRight**| 转到下一页                  |
| **Ctrl + ArrowUp**   | 跳转到第一页                |
| **Ctrl + ArrowDown** | 跳转到最后一页              |
| **Ctrl + ArrowLeft** | 转到上一页                  |
| **Ctrl + \`**        | 关闭编辑面板                |
| **Ctrl + i**         | 插入模式 / 提交插入         |
| **Ctrl + u**         | 提交更新编辑                |
| **Ctrl + d**         | 提交删除编辑                |
| **Ctrl + q**         | 执行 SQL 查询               |

## 许可协议

SQLite Online 采用 [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE) 许可发布。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---