<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E：AI时代您的数字大脑

<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>文档</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**上下文观察与回忆引擎**

C.O.R.E 是一个由您的LLM交互和个人数据构建的可移植记忆图谱，使您的所有上下文和工作流历史可被任何AI工具访问，就像一个数字大脑。这消除了反复共享上下文的需求。目标是提供：

- **统一、可移植的记忆**：无缝添加和回忆上下文，并将您的记忆跨Claude、Cursor、Windsurf等应用连接。
- **关系型，不只是平面事实**：CORE 组织您的知识，既存储事实也保存关联，打造如大脑般丰富深入的记忆。
- **用户拥有**：您决定保留、更新或删除哪些内容，并可在所需工具间共享记忆，摆脱厂商锁定。

## 🎥 演示视频

[查看C.O.R.E演示](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  主要特性

- **记忆图谱**：可视化您的事实与偏好如何相互关联
- **与记忆对话**：就记忆内容提问，获得即时见解和理解
- **即插即用**：可在Cursor、Claude等应用中立即使用CORE记忆

## ☁️ C.O.R.E 云端部署

1. 注册 [Core Cloud](https://core.heysol.ai) 并开始构建您的记忆图谱。
2. 添加您想保存到记忆中的文本。点击 `+ Add` 按钮后，您的记忆图谱将被生成。
3. [将Core Memory MCP与Cursor连接](#connecting-core-mcp-with-cursor)

## 💻 C.O.R.E 本地部署

#### 前置条件

1. Docker
2. OpenAI API密钥


> **注意:** 我们正在积极改进对Llama模型的支持。目前，C.O.R.E与基于Llama的模型兼容性和效果还不理想，但我们正在努力提升其兼容性和输出质量。
> 
#### 本地运行C.O.R.E

1. **复制环境变量**

   将示例环境文件复制为 `.env`：


   ```bash
   cp .env.example .env
   ```
2. **启动应用程序**

   使用 Docker Compose 启动所有所需的服务：


   ```bash
   docker-compose up
   ```
3. **访问应用程序**

   容器启动后，打开浏览器并访问 [http://localhost:3000](http://localhost:3000)。

4. **使用魔法链接创建账户**

   - 要创建账户，点击 `Continue with email` 按钮

     <img width="865" height="490" alt="Create account" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - 输入你的邮箱并点击 `Send a Magic Link` 按钮

     <img width="824" height="429" alt="Enter email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `从终端日志中复制魔法链接` 并在浏览器中打开

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **创建你的私人空间并添加数据**

   - 在仪表盘右上角，输入消息，例如 `I love playing badminton`，然后点击 `+Add`。
   - 你的记忆已排队处理中；你可以在 `Logs` 部分监控其状态。
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - 处理完成后，节点将被添加到你的私人知识图谱中，并在仪表盘中可见。
   - 你以后可以选择将此记忆连接到其他工具或保持私密。

6. **搜索你的记忆**

   - 使用仪表盘的搜索功能，在你的私人空间内查询已导入的数据。


## 将 CORE MCP 与 Cursor 连接

1. 打开 CORE 仪表盘，导航到 API 部分生成新的 API 令牌。
2. 在 Cursor 中，进入：设置 → 工具与集成 → 新建 MCP 服务器。
3. 使用以下格式添加 CORE MCP 服务器配置。确保将 API_TOKEN 替换为你在步骤 1 中生成的令牌。

   要在 Cursor 中添加的 MCP 配置


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. 进入设置-> 用户规则 -> 新建规则 -> 并添加以下规则以确保您的所有聊天交互均被存储在CORE内存中


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## 文档

探索我们的文档，充分利用 CORE  
- [基本概念](https://docs.heysol.ai/core/overview)  
- [API 参考](https://docs.heysol.ai/core/local-setup)  
- [连接 Core Memory MCP 与 Cursor](#connecting-core-mcp-with-cursor)  


## 🧑‍💻 支持  
有问题或反馈？我们随时为您提供帮助：  
- Discord：[加入 core-support 频道](https://discord.gg/YGUZcvDjUa)  
- 文档：[docs.heysol.ai/core](https://docs.heysol.ai/core/overview)  
- 邮箱：manik@poozle.dev  

## 使用指南  

**存储内容：**  

- 对话历史  
- 用户偏好  
- 任务上下文  
- 参考资料  

**不存储内容：**  

- 敏感数据（个人身份信息）  
- 凭证信息  
- 系统日志  
- 临时数据  

## 👥 贡献者  

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">  
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />  
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---