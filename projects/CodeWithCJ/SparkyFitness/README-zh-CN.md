# SparkyFitness - MyFitnessPal 的自托管替代方案

SparkyFitness 是一款全面的健身追踪与管理应用，旨在帮助用户监控营养、锻炼和身体数据。它提供每日进度追踪、目标设定和洞察报告等工具，助力健康生活方式。


## ✨ 功能特色

### 🍎 营养追踪

* **记录每日餐食**
* **创建和管理自定义食物与类别**
* **通过交互式图表查看汇总并分析趋势**

### 💪 运动记录

* **记录锻炼内容**
* **浏览和搜索全面的运动数据库**
* **追踪健身进展**

### 💧 饮水监控

* **追踪每日饮水目标**
* **快速简单的饮水记录**

### 📏 身体数据测量

* **记录身体指标**（如体重、腰围、手臂等）
* **添加自定义测量类型**
* **通过图表可视化进展**

### 🎯 目标设定

* **设定和管理健身及营养目标**
* **随时间追踪进展**

### 🗓️ 每日签到

* **监测每日活动**
* **保持习惯追踪的一致性**

### 🤖 AI 营养教练（SparkyAI）

* **通过聊天记录食物、运动、身体数据和步数**
* **上传食物图片自动记录餐食**
* **包含聊天记录和个性化指导**

### 🔒 用户认证与个人资料

* **安全的登录系统**
* **切换用户档案**
* **支持家庭访问与管理**

### 📊 综合报告

* **生成营养和身体数据的汇总**
* **按周或月追踪长期趋势**

### 🎨 可自定义主题

* **切换浅色/深色模式**
* **采用极简、无干扰界面设计**

### 需要帮助？
* **加入 Discord**
  https://discord.gg/vcnMT5cPEA
* **在讨论区发帖**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 快速开始

要在本地运行 SparkyFitness 应用，请按以下步骤操作：

### 前置条件

*   **Supabase 项目**：你需要设置一个 Supabase 项目。
    *   **在 Supabase 上创建新项目**：访问 [Supabase](https://app.supabase.com/) 并创建新项目。（如需，也可以尝试搭建本地 Supabase 项目。）
    *   从项目设置（API 部分）获取你的 Supabase 项目 URL 和 Anon Key。
    *   **Supabase 认证的重要说明：** 请在 Supabase 认证设置中更新你的 URL 配置以匹配你的域名。这对于你的域名正常工作和接收注册邮件邀请至关重要。Supabase 提供丰富的安全功能和第三方 SSO 选项，请根据项目需求配置。
    *   如果你使用的是 Supabase 免费版，自动 DB 部署到 Supabase 不支持 IPV4。因此你需要将网络配置为使用 IPV6 连接，否则数据库迁移将失败，需要手动部署。       


    

### 安装

1.  **配置环境变量：**
    在 private 文件夹下创建 `.env` 文件。如果你使用 Portainer，可直接在其中创建。
    添加你的 Supabase 凭据：
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **使用 Docker Compose 运行：**
    拉取 Docker 镜像并启动服务：
    ```sh
```
docker compose pull
docker compose up -d
```

3.  **访问应用程序：**  
    一旦服务启动并运行，在您的网页浏览器中访问 SparkyFitness，地址为：  
    ```
    http://localhost:3000
    ```

4.  **AI 聊天机器人 - 可选配置：**  
    如需启用 AI 聊天机器人的全部功能，包括安全的 API 密钥存储和数据库访问，请按照以下步骤操作：

    *   **配置 `AI_API_ENCRYPTION_KEY`：** 在 “Supabase -> Edge Functions” -> “Environment Variables” 中生成一个密钥。此密钥用于在 Supabase 内部存储您的 AI 密钥时进行加密。

    *   **生成 `SUPABASE_ACCESS_TOKEN`：**
        1.  进入您的 Docker 控制台。
        2.  运行 `supabase login` 并使用提供的 URL 进行身份验证。
        3.  通过运行 `cat ~/.supabase/access-token` 获取访问令牌。
        4.  在 `docker-compose.yml` 或 Portainer 配置中更新此令牌并重新部署。
        5.  重新部署后，登录 SparkyFitness 并在 AI 服务配置中选择您的首选提供商。
     

### 手动部署数据库和函数到 Supabase

**方法一：**  
**如果您没有启用 IPV6 网络连接，数据库迁移将会失败，因为 Supabase 免费版不支持 IPV4 直连。**

   1. 下载最新版本并解压到您的电脑。
   2. 进入项目文件夹。需要确保 Docker 已启动并运行。
   3. 运行以下命令。（functions deploy 仅在需要 AI 配置时执行。如果不需要 ChatBOT，可以跳过此步骤）
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
重新运行 Docker compose。前端应用将开始运行。

**方法二：**  
   1. 下载最新版本并解压到您的电脑。  
   2. 进入项目文件夹。  
   3. 打开 supabase/migrations。复制 SQL 语句，并在 Supabase-->Project-->SQL Editor 中按升序逐条执行。  
   4. 【可选】如需 AI ChatBOT，同样操作 supabase/functions/chat。复制 index.js 并在 Supabase-->Project-->Edge Function-->Deploy new function 中运行。  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---