# 打印

打印插件为您的 Obsidian 工作区添加打印工具。您可以通过命令面板、打印机工具栏或右键菜单打印当前笔记、选中文本或文件夹中的所有笔记。如果您喜欢或觉得它有用，请考虑在 GitHub 上给它一个[星标 ![GitHub Repo stars](https://img.shields.io/github/stars/marijnbent/obsidian-print?style=social)](https://github.com/marijnbent/obsidian-print)。

https://github.com/user-attachments/assets/5882f08c-19e6-46da-b808-608b95376979

*插件使用的屏幕录制。*

## 功能

- **打印当前笔记**：可通过命令面板、打印机工具栏或右键单击笔记触发打印。
- **打印选区**：仅打印活动编辑器中选中的文本。
- **打印文件夹中的所有笔记**：右键点击文件夹或使用命令面板打印该文件夹中的所有 Markdown 笔记。

您还可以为打印操作添加快捷键，快速访问。

| | |
|:------:|:-------------------------:|
|![image](https://github.com/user-attachments/assets/8ba2959c-20a2-4cab-8ae7-c2f5f2475217)|![image](https://github.com/user-attachments/assets/ddb54bd0-4b58-410f-9d69-0f6a58b2ddfd)

## 支持

如果您喜欢这个插件，请通过在 [https://www.buymeacoffee.com/marijnbent](https://www.buymeacoffee.com/marijnbent) 买杯咖啡支持我的工作和热情。

<a href="https://www.buymeacoffee.com/marijnbent"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=marijnbent&button_colour=6495ED&font_colour=ffffff&font_family=Lato&outline_colour=000000&coffee_colour=FFDD00"></a>

## 快速开始

### 从社区插件商店安装

1. 打开 Obsidian，进入 **设置** > **社区插件**。
2. 点击 **浏览** 并搜索 **Print**。
3. 点击 **安装**，将插件添加到您的 Obsidian 设置中。
4. 安装完成后，启用插件，并可选地进入设置页面。

如果您经常打印，建议为一个或多个打印命令添加快捷键。进入 **设置** > **快捷键**，搜索 `print`，绑定您喜欢的快捷键。

## 设置


- **打印笔记标题**：在打印输出中包含笔记标题。  
- **打印属性**：在打印笔记顶部包含笔记属性/前置内容。  
- **字体大小和标题大小**：启用**规范化样式**时调整正文文本和标题大小。  
- **合并文件夹笔记**：打印文件夹中的所有笔记时，去除笔记之间的分页符。  
- **将横线视为分页符**：将 `---` 分隔符解释为打印分页符。  
- **调试模式**：打开一个包含生成的 HTML 和 CSS 的独立检查窗口，以便排查样式问题。  
- **继承笔记 `cssclasses`**：将 Obsidian 笔记的 `cssclasses` 应用到打印输出，使笔记特定的打印 CSS 得以传递。  
- **规范化样式**：使用中性内置打印样式，替代继承当前 Obsidian 主题样式。  
- **自定义 CSS**：在高级设置中，启用来自 Obsidian CSS 片段文件夹的 `print.css` 代码段（如果存在）。  

![image](https://github.com/user-attachments/assets/2ffed185-cc8f-43d9-8444-7cb9657d61f7)  

## 自定义 CSS  

在设置中，你可以选择隐藏标题，启用**规范化样式**时，也可以调整正文文本和标题的字体大小。  

要进一步自定义打印笔记的外观，你可以在 `.obsidian/snippets` 中创建一个 `print.css` 代码段，并在 Obsidian 识别后从插件设置中启用它。打印文档的主体包含 `obsidian-print` 类。请确保将你的 CSS 包裹在 `@media print` 中，或者在打印专用 CSS 选择器前加上 `.obsidian-print` 前缀，以保证样式仅应用于打印内容。如果启用**继承笔记 `cssclasses`**，笔记级别的 Obsidian 类也会出现在打印输出中。代码块和 MathJax 的主题样式在需要时也会带入打印文档，除非你启用**规范化样式**，使用插件的中性备用样式。你可以查看默认样式[此文件](/styles.css)。每个独立笔记包含 `obsidian-print-note` 类。  

如果样式出现问题，可启用调试模式，打开生成打印文档的检查窗口。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---