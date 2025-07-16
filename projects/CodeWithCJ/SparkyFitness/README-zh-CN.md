<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness - MyFitnessPal 的自托管替代方案

SparkyFitness 是一款全面的健身追踪与管理应用，旨在帮助用户监控营养、锻炼和身体数据。它为日常进度追踪、目标设定和洞察报告提供多种工具，助力健康生活方式。


## ✨ 功能特色

### 🍎 营养追踪

* **记录每日饮食**
* **创建和管理自定义食物及分类**
* **通过交互式图表查看汇总和分析趋势**

### 💪 运动记录

* **记录锻炼内容**
* **浏览并搜索全面的运动数据库**
* **追踪健身进展变化**

### 💧 饮水量监测

* **追踪每日饮水目标**
* **快速简便的饮水记录**

### 📏 身体数据

* **记录身体指标**（如体重、腰围、手臂等）
* **添加自定义测量类型**
* **通过图表可视化进度**

### 🎯 目标设定

* **设定和管理健身与营养目标**
* **随时间追踪目标进展**

### 🗓️ 每日签到

* **监控每日活动**
* **通过习惯追踪保持持续性**

### 🤖 AI 营养教练（SparkyAI）

* **通过聊天记录饮食、锻炼、身体数据和步数**
* **上传食物图片自动记录餐食**
* **包含聊天历史和个性化指导**

### 🔒 用户认证与个人资料

* **安全的登录系统**
* **在不同用户资料间切换**
* **支持家庭访问与管理**

### 📊 全面报告

* **生成营养和身体数据汇总**
* **按周或月追踪长期趋势**

### 🎨 可自定义主题

* **切换明亮和深色模式**
* **设计简约、无干扰界面**

### 需要帮助？
* **加入 Discord 社区**
  https://discord.gg/vcnMT5cPEA
* **参与讨论区发帖**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## 🚀 快速开始

要在本地机器上运行 SparkyFitness 应用程序，请按照以下步骤操作：

### 前提条件

### 安装

1.  **配置环境变量：**

    在根目录下创建一个 `.env` 文件。从示例 `.env` 文件中复制模板，并用你的设置进行更新。你可以参考 WIKI 了解我使用的现有配置。尽量不要更改端口，因为在项目稳定之前，初始版本可能无法正常工作。

    *   **管理面板 URL：** 要启用管理面板并配置 OIDC 设置，请确保 `SPARKY_FITNESS_ADMIN_EMAIL` 环境变量设置为你的管理面板对应的 URL。
    

2.  **使用 Docker Compose 运行：**
    拉取 Docker 镜像并启动服务。如果你对 `.env` 文件做了更改，请重新构建镜像，以确保新的环境变量被正确加载。


    ```sh
    docker-compose pull # Pull the latest Docker images
    docker-compose up -d # Start the services in detached mode
    ```
    请参考示例设置
    https://github.com/CodeWithCJ/SparkyFitness/wiki/Sample-Setup

3.  **访问应用程序：**
    当服务启动并运行后，在网页浏览器中通过为前端配置的URL访问SparkyFitness（例如，`http://localhost:3004` 或 `http://your_frontend_ip_or_domain:3004`）。

4.  **AI 聊天机器人 - 可选配置：**
    若需启用AI聊天机器人的全部功能，请在登录后于应用设置中配置所需的API密钥。
  
5.  **初始应用设置：**
    登录应用后，进入设置菜单以：
    *   添加您偏好的食物供应商（例如，OpenFoodFacts是一个免费的选项）。
    *   调整您的偏好和个人资料设置。

### ⚠️ 已知问题 / 测试版功能 ⚠️

以下功能目前处于测试阶段，尚未经过全面测试。预计可能存在Bug或功能不完整的情况：

*   AI聊天机器人
*   多用户支持
*   家庭与朋友访问
*   Apple Health数据集成

该应用程序正在积极开发中。由于Supabase到PostgreSQL的迁移，一些功能可能无法如预期运行。在应用稳定前，可能会引入重大变更。
对于新版本，您可能需要更改Docker/环境变量。因此，不建议使用Watchtower或类似工具自动升级。请阅读发行说明以了解任何重大变更。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---