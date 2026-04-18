

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/extension/icon128.png" width="72" alt="TerminalStart 图标">
</p>

<h1 align="center">TerminalStart</h1>

<p align="center">
  复古风格，模块化的新标签页仪表盘，专为专注和速度而设计。
</p>

<p align="center">
  <a href="https://thecsir.github.io/TerminalStart/">在线演示</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/mainPage.png" width="900" alt="TerminalStart 预览">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/settingsPage.png" width="900" alt="TerminalStart 设置">
</p>

---


## 在 Edge / Chrome 中安装

1. 打开 `edge://extensions`（或 `chrome://extensions`）
2. 启用 **开发者模式**
3. 点击 **加载已解压的扩展程序**
4. 选择 `extension` 文件夹


## Todoist 集成

使用个人 API 令牌同步您的待办小部件与 Todoist。

1. 进入 **设置 > 高级 > 待办小部件**
2. 启用 **与 Todoist 同步**  
3. 粘贴您的 API 令牌（设置 > 集成 > 开发者，访问 [todoist.com](https://todoist.com)）  
4. 提示时授予主机权限  

**截止日期** &mdash; 创建任务时添加自然语言日期：  

| 输入 | 任务 | 截止时间 |  
|---|---|---|  
| `meet john tomorrow at 2pm` | meet john | 明天下午2点 |  
| `buy groceries next monday` | buy groceries | 下周一 |  
| `call mom every friday` | call mom | 每周五 |  
| `submit report jan 15` | submit report | 1月15日 |  

Todoist 的自然语言处理负责解析。离线模式仍支持仅时间语法（例如 `standup 9am`）。  

## 构建  

### 要求  

* Node.js v16+  
* Python 3  

### 步骤  

1. 安装依赖项：

```
npm install
```

2. 构建：

```
npm run build
```

构建脚本会自动将资源同步到 `extension/` 文件夹。

3. 打包：

```
python scripts/package_addon.py
```
输出：`terminal-start-v1.0.0.zip`

### 测试


```
npx playwright test
```

使用 Chromium 运行针对扩展的端到端测试。

## 说明

- 将鼠标悬停在右上角区域以设置。
- API 令牌存储在您的浏览器本地，除 Todoist API 外，绝不发送到任何其他地方。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---