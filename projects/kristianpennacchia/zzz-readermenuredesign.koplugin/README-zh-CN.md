# zzz-readermenuredesign.koplugin

KOReader 中各种阅读器菜单的重新设计，包括词典快速查找弹出窗口和阅读器高亮菜单。

<p align="left">
  <img src="https://github.com/user-attachments/assets/2d82282a-96c9-43b7-aaea-fb27a74d2f52" width=45%>
</p>

包括一个选项，可在阅读器高亮菜单中显示“未知”按钮（此插件未更改的按钮）：

<p align="left">
  <img src="https://github.com/user-attachments/assets/162b8b8c-c6b5-4149-a8d9-b5e9bbeb64dd" width=45%>
  <img src="https://github.com/user-attachments/assets/9dbfec8c-88e0-4b91-9f13-7eb50f1f881c" width=45%>
</p>

该插件还为其他插件提供自定义 UI，例如 [WordReference 插件](https://github.com/kristianpennacchia/wordreference.koplugin) 和 [AI 助手插件](https://github.com/omer-faruq/assistant.koplugin)。

<p align="left">
  <img src="https://github.com/user-attachments/assets/2a99493d-d86d-44f0-813f-4ee4ef1cd606" width=30%>
  <img src="https://github.com/user-attachments/assets/6c5650b4-6718-4b9b-8a0e-2cd8a6ed4f47" width=30%>
</p>

## 安装

- 下载[最新版本](https://github.com/kristianpennacchia/zzz-readermenuredesign.koplugin/releases/latest)。
- 解压 `zzz-readermenuredesign.koplugin.zip`。
- 将 `zzz-readermenuredesign.koplugin` 文件夹复制到设备上 KOReader 的 `plugins` 目录。
- 重启 KOReader。

#### 故障排除

- **所有图标都是警告（⚠️）符号。**
    - 从 v1.0.5 版本开始，图标应自动安装，但如果仍遇到此问题，请尝试手动将图标从 `zzz-readermenuredesign.koplugin` 文件夹复制到 KOReader 图标文件夹 `/koreader/resources/icons`。

- **图标根本不显示。**
    - 这可能发生在某些设备使用旧版本插件时。尝试删除 `/koreader/resources/icons/mdlight` 中此插件的 SVG 图标，并用[最新版本](https://github.com/kristianpennacchia/zzz-readermenuredesign.koplugin/releases/latest)中的 PNG 图标替换，然后**重启 KOReader**。

## 设置

- 阅读器高亮菜单：
    - 打开菜单 → 工具 🛠️ → 更多工具 → 阅读器菜单重新设计 → 在阅读器高亮菜单中显示未知按钮。
    - 这将切换显示/隐藏“未知”按钮（本插件中未特殊处理的按钮）在阅读器高亮菜单中。
- 词典快速查询：
    - 打开菜单 → 工具 🛠️ → 更多工具 → 阅读器菜单重新设计 → 在词典快速查询中显示导航按钮。
    - 这将切换显示/隐藏词典快速查询中的“导航”按钮，用于在词典、维基百科条目等之间导航。
    - 另外：你也可以简单地左右滑动来导航，但这些按钮对PC/Mac更为实用。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---