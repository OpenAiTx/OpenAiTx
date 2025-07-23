
# 人话翻译器

## 项目简介

人话翻译器是一个 Chrome 浏览器扩展，旨在帮助用户快速翻译网页上的文本内容。它提供了一个美观、可拖动的弹窗界面，支持实时翻译和复制功能。  

目前已上架主流浏览器插件市场，搜索「人话翻译器」或点击以下链接前往，欢迎下载使用。  
Chrome浏览器：[chrome应用商店](https://chromewebstore.google.com/detail/genddacnaonloeecodkncflhpcdbcmdh)  
Edge浏览器：[Edge插件市场](https://microsoftedge.microsoft.com/addons/detail/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/nfcgnclfgdeocdakoconadlbonnjaglj)  
火狐浏览器：[火狐插件市场](https://addons.mozilla.org/zh-CN/firefox/addon/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/)  

## 主要功能

- **文本选择翻译**：选中网页上的文本后触发翻译
- **实时翻译显示**：翻译结果实时显示在弹窗中
- **思维链展示**：可显示翻译的思考过程
- **可拖动界面**：弹窗支持拖动，方便用户调整位置
- **复制功能**：一键复制翻译结果
- **Markdown 支持**：翻译结果支持 Markdown 格式的渲染

## 使用方法

1. 在 Chrome 浏览器中安装扩展
2. 点击扩展图标-设置，进入设置页面填写api信息
3. 在任意网页上选中需要翻译的文本
4. 触发翻译（通过右键菜单或快捷键）
5. 在弹出的翻译窗口中查看结果
6. 可以通过拖动标题栏移动弹窗位置
7. 点击"复制译文"按钮复制翻译结果
8. 点击右上角"✕"按钮关闭弹窗

## 技术实现

### 前端界面

- 使用纯 JavaScript 构建的弹窗界面
- CSS 样式设计美观，支持滚动、拖动等交互
- 自定义 Markdown 解析器用于格式化文本

### 通信机制

- 使用 Chrome 扩展的消息传递机制（`chrome.runtime.onMessage`）
- 支持以下消息类型：
  - `showTranslationPopup`：显示翻译弹窗
  - `translate`：发送翻译请求
  - `updateTranslation`：更新翻译结果
  - `cleanup`：清理资源

### 特色设计

- **防止样式冲突**：所有 CSS 类名都添加了 `translator-` 前缀
- **智能滚动**：只在用户未主动滚动时自动滚动到底部
- **错误处理**：完善的错误处理机制，提供友好的错误提示
- **单例模式**：确保同一时间只有一个翻译弹窗存在

## 项目结构


```
├── content/
│   └── content.js    # 内容脚本，负责弹窗创建和交互
├── background/
│   └── background.js # 后台脚本，处理翻译请求和API调用
├── popup/
│   ├── popup.html    # 扩展弹出窗口HTML
│   ├── popup.js      # 扩展弹出窗口脚本
│   └── popup.css     # 扩展弹出窗口样式
├── options/
│   ├── options.html  # 选项页面HTML
│   ├── options.js    # 选项页面脚本
│   └── options.css   # 选项页面样式
├── assets/
│   ├── icon.png      # 扩展图标目录
├── manifest.json     # 扩展配置文件
└── README.md         # 项目说明文档
```
## 开发注意事项

- 扩展使用了 Chrome 扩展 API，需要在 manifest.json 中正确配置权限
- 翻译功能依赖于后端 API，需要确保 API 密钥配置正确
- 样式设计考虑了与网页原有样式的隔离，避免冲突


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---