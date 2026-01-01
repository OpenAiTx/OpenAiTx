
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

SparkyFitness 是一款全面的健身跟踪与管理应用，旨在帮助用户监控营养、锻炼和身体数据。它提供每日进展跟踪、目标设定和有洞察力的报告工具，支持健康生活方式。

文档：https://codewithcj.github.io/SparkyFitness

## ✨ 功能亮点

### 🍎 营养追踪
* **记录您的每日饮食**
* **创建和管理自定义食物与类别**
* **通过交互式图表查看摘要并分析趋势**

### 💪 运动记录

* **记录您的锻炼**
* **浏览和搜索全面的运动数据库**
* **跟踪健身进展**

### 💧 饮水摄入监控

* **跟踪每日饮水目标**
* **简单快捷地记录饮水**

### 📏 身体测量

* **记录身体指标**（如体重、腰围、臂围）
* **添加自定义测量类型**
* **通过图表可视化进展**

### 🎯 目标设定

* **设定和管理健身与营养目标**
* **跟踪进展情况**

### 🗓️ 每日签到

* **监控每日活动**
* **通过习惯追踪保持一致性**

### 🤖 AI营养教练（SparkyAI）

* **通过聊天记录食物、锻炼、身体数据和步数**
* **上传食物图片自动记录餐饮**
* **包括聊天历史和个性化指导**

### 🔒 用户认证与个人资料


* **安全登录系统**
* **在用户资料之间切换**
* **支持家庭访问和管理**

### 📊 综合报告

* **生成营养和身体指标摘要**
* **跟踪数周或数月的长期趋势**

### 🎨 可自定义主题

* **切换浅色和深色模式**
* **采用极简、无干扰界面设计**

### 需要帮助？
* **加入 Discord**
  https://discord.gg/vcnMT5cPEA
* **在讨论区发帖**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)

## � 快速开始

几分钟内让 SparkyFitness 运行起来：

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -o docker-compose.yml https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/docker-compose.prod.yml
curl -o .env https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docker/.env.example

# 3. (Optional) Edit .env to customize your setup
# e.g., update database credentials, ports, etc.
# if you require Gamrin integration, uncomment Garmin section from compose file.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 📖 文档

如需完整的安装指南、开发环境搭建和使用说明，请访问我们的综合文档：

**👉 [SparkyFitness 文档站点](https://codewithcj.github.io/SparkyFitness)**

### 快速链接

- **[🚀 快速开始](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 开发与生产环境完整搭建指南
- **[🐳 Docker 指南](https://codewithcj.github.io/SparkyFitness/developer/docker)** - Docker 部署与配置说明
- **[🔧 开发工作流](https://codewithcj.github.io/SparkyFitness/developer/workflow)** - 开发者指南及贡献流程  
- **[📊 功能概览](https://codewithcj.github.io/SparkyFitness/features/)** - 完整功能文档
- **[🏗️ 架构](https://codewithcj.github.io/SparkyFitness/app-overview)** - 技术架构与设计说明
- 参考 Wiki 获取示例环境配置及移动端应用设置。


## Star 历史

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Star 历史图表" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 翻译

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="翻译状态" />
</a>

## 仓库活动

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats 分析图片")


## 贡献者

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

### ⚠️ 已知问题 / 测试版功能 ⚠️

以下功能目前处于测试阶段，可能尚未经过充分测试。请预期可能存在的漏洞或功能不完整：

*   AI 聊天机器人
*   多用户支持
*   家庭和朋友访问
*   Apple Health 数据集成

该应用正在密集开发中。由于 Supabase 到 PostgreSQL 的迁移，某些功能可能无法如预期工作。在应用程序稳定之前，可能会引入重大变更（BREAKING CHANGES）。
您可能需要在新版本中更改 Docker/环境变量。因此，不建议使用 Watchtower 或类似应用进行自动升级。请阅读发布说明以了解任何重大变更（BREAKING CHANGES）。




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---