# 速查表

[![GitHub](https://img.shields.io/badge/github-michaelmagan/cheatsheet-blue?logo=github)](https://github.com/michaelmagan/cheatsheet)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](./LICENSE)
[![Next.js](https://img.shields.io/badge/Next.js-15-black?logo=next.js)](https://nextjs.org/)
[![Tambo AI](https://img.shields.io/badge/Tambo-AI-purple)](https://tambo.co)

一个由 [Tambo AI](https://tambo.co) 构建的 AI 驱动的开源 Google Sheets 竞争产品。

通过自然语言构建和操作交互式电子表格，以及图表和可视化。

## 演示
亲自试试：**[CheatSheet](https://cheatsheet.tambo.co)**

### 预览
https://github.com/user-attachments/assets/da72aa8b-6bc5-468e-8f42-0da685105d22

## 功能

- **AI 编辑**：使用自然语言与电子表格交互。
- **单元格选择**：选择单元格以让 AI 进行交互。
- **多模态**：附加图片和消息。
- **图表和曲线图**：从电子表格数据创建可视化图表。
- **模型上下文协议 (MCP)**：连接外部数据源和工具。

## 路线图

- **语音输入**：除键入外支持语音输入。
- **公式支持**：电子表格公式（SUM，AVERAGE，IF，VLOOKUP 等）。
- **更好的格式化**：表格更多视觉选项（颜色、边框、字体、对齐）。
- **导入/导出**：支持 CSV、XLSX 和 JSON。

## 快速开始

1. 克隆此仓库

2. 进入项目目录：

   ```bash
   cd spreadsheet-template
   ```
3. 安装依赖项：

   ```bash
   npm install
   ```

4. 设置您的环境变量：

   **选项 A：使用 Tambo CLI（推荐）**
   ```bash
   npx tambo init
   ```
   这将交互式地提示您输入 Tambo API 密钥，并自动创建 `.env.local`。

   **选项 B：手动设置**
   ```bash
   cp example.env.local .env.local
   ```
   然后编辑 `.env.local`，并添加您从 [tambo.co/dashboard](https://tambo.co/dashboard) 获取的 API 密钥。

5. 启动开发服务器：
   ```bash
   npm run dev
   ```

6. 在浏览器中打开 [http://localhost:3000](http://localhost:3000) 以使用该应用！

## 架构概述

此模板展示了 AI 如何通过三种方式读取和更新电子表格：

### AI 如何访问电子表格状态

**上下文助手**（只读数据）
- `spreadsheetContextHelper` - 提供当前标签页的数据，格式为 Markdown 表格
- `spreadsheetSelectionContextHelper` - 告诉 AI 当前选中的内容
- `tabContextHelper` - 列出所有标签页并高亮显示活动标签页
- 每当你发送消息时自动运行
- 参见：`src/lib/spreadsheet-context-helper.ts`，`src/lib/spreadsheet-selection-context.ts`，`src/lib/tab-context-helper.ts`

**工具**（进行更改）
- 电子表格和标签页工具，供 AI 改变状态或检查元数据
- 上下文助手是只读的；工具用来进行更改
- 参见：`src/tools/spreadsheet-tools.ts`，`src/tools/tab-tools.ts`

### 电子表格工具参考

| 工具 | 作用 |
|------|---------|
| `updateCell` | 更新单个单元格的值 |
| `updateRange` | 一次更新多个单元格 |
| `addColumn` | 添加新列 |
| `removeColumn` | 删除列 |
| `addRow` | 添加新行 |
| `removeRow` | 删除行 |
| `readCell` | 读取单个单元格的值 |
| `readRange` | 读取多个单元格 |
| `clearRange` | 清除范围内单元格的值 |
| `sortByColumn` | 按列值排序行 |

### 关键文件

**配置**
- `src/lib/tambo.ts` - 组件和工具注册
- `src/app/chat/page.tsx` - 主要聊天界面，使用 TamboProvider

**电子表格系统**
- `src/components/ui/spreadsheet-tabs.tsx` - FortuneSheet 工作簿包装器 + 标签 UI
- `src/lib/fortune-sheet-store.tsx` - 内存中的全局存储，连接工作簿状态
- `src/lib/fortune-sheet-utils.ts` - 以 FortuneSheet 为中心的辅助工具（范围、查找）

**状态管理**
- `src/lib/canvas-storage.ts` - 画布/标签状态管理
- 电子表格状态通过 FortuneSheet 提供者和工作簿 API 流动。

**依赖说明：** FortuneSheet（`@fortune-sheet/{core,react}`）驱动所有电子表格交互。

## 自定义

### 添加自定义组件

在 `src/lib/tambo.ts` 中注册 AI 可在聊天中内联渲染的组件。示例结构：

```tsx
import type { TamboComponent } from "@tambo-ai/react";

const components: TamboComponent[] = [
  {
    name: "MyComponent",
    description: "When to use this component",
    component: MyComponent,
    propsSchema: myComponentSchema, // Zod schema
  },
];
```

请查看 `src/components/tambo/` 以获取组件示例，详见 [Tambo 组件文档](https://docs.tambo.co/concepts/components)。

### 创建自定义工具

在 `src/tools/` 中添加工具，遵循以下模式：

```tsx
export const myTool = {
  name: "toolName",
  description: "What this tool does",
  tool: async (param: string) => {
    // Implementation
    return { success: true, message: "Result" };
  },
  toolSchema: z.function().args(
    z.string().describe("Parameter description")
  ).returns(z.object({
    success: z.boolean(),
    message: z.string().optional(),
  })),
};
```

在 `src/lib/tambo.ts` 的 tools 数组中注册。详情见 [Tambo 工具文档](https://docs.tambo.co/concepts/tools)。

### 模型上下文协议（MCP）

通过设置模态框配置 MCP 服务器以连接外部数据源。服务器信息存储在浏览器 localStorage 中，并在聊天界面中由 `TamboMcpProvider` 包装。

## 文档

了解更多关于 Tambo：
- [组件](https://docs.tambo.co/concepts/components)
- [可交互组件](https://docs.tambo.co/concepts/components/interactable-components)
- [工具](https://docs.tambo.co/concepts/tools)
- [附加上下文](https://docs.tambo.co/concepts/additional-context)

由 [Tambo AI](https://tambo.co) 构建 —— 一个用于构建 AI 驱动界面的框架。Tambo 是开源的：[tambo-ai/tambo](https://github.com/tambo-ai/tambo)。

![Tambo 模板演示](https://raw.githubusercontent.com/tambo-ai/tambo/main/assets/template.gif)

## 贡献

欢迎贡献！请参见 [CONTRIBUTING.md](https://raw.githubusercontent.com/michaelmagan/cheatsheet/main/./CONTRIBUTING.md) 了解指南。

## 许可证

MIT 许可证


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---