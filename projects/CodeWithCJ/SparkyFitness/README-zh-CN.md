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
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
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

# SparkyFitness

一个自托管、隐私优先的 MyFitnessPal 替代方案。在完全控制自己数据的前提下，跟踪营养、锻炼、身体指标和健康数据。

![截图](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness 是一个由以下部分组成的自托管健身追踪平台：

- 后端服务器（API + 数据存储）
- 基于 Web 的前端
- 适用于 iOS 和 Android 的原生移动应用

它在您可控的基础设施上存储和管理健康数据，无需依赖第三方服务。

## 核心功能

- 营养、锻炼、饮水、睡眠、禁食、情绪和身体测量跟踪
- 目标设定与每日签到
- 交互式图表和长期报告
- 多用户档案和家庭访问
- 浅色和深色主题
- OIDC、TOTP、Passkey、多因素认证等

## 健康与设备集成

SparkyFitness 可从多个健康与健身平台同步数据：

- **Apple Health**（iOS）
- **Google Health Connect**（Android）
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow**（部分测试）
- **Hevy**（未测试）
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava**（部分测试）

集成会自动将步数、锻炼和睡眠等活动数据，以及体重和身体测量等健康指标，同步到您的 SparkyFitness 服务器。

## 可选 AI 功能（测试版）

SparkyAI 提供用于记录数据和回顾进展的对话界面。

- 通过聊天记录饮食、锻炼、身体数据和步数
- 上传食物图片，实现自动膳食记录
- 保留对话历史以便后续跟进

注意：AI 功能目前处于测试阶段。

## 快速开始（服务器）

使用 Docker Compose 可在几分钟内部署 SparkyFitness 服务器。

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 视频教程

[![观看视频](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

快速 2 分钟教程，演示如何安装 SparkyFitness（自托管健身追踪器）。


## 文档

如需完整的安装指南、配置选项和开发文档，请访问我们的[文档网站](https://codewithcj.github.io/SparkyFitness/)。

### 快捷链接

- **[安装指南](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - 部署与配置
- **[功能概览](https://codewithcj.github.io/SparkyFitness/features)** - 完整功能文档
- **[开发流程](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 开发者指南与贡献流程
- **[iOS 应用信息](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** 与 **[Android 应用信息](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### 需要帮助？

- 在 Github issues/discussion 发帖。
- 想要更快获得响应并与社区成员互动，**[加入我们的 Discord](https://discord.gg/vcnMT5cPEA)**

## Star 历史

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Star 历史图表" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 翻译

**[Weblate 翻译](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="翻译状态" />
</a>

## 代码仓库活动

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats 分析图像")

## 贡献者

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ 已知问题 / Beta 功能 ⚠️

SparkyFitness 正在积极开发中。
版本间可能会有重大更改。

- 不推荐自动更新容器
- 升级前请务必查看发布说明

以下功能目前处于测试版，可能尚未经过充分测试。请预期可能存在缺陷或功能不完整：

- AI 聊天机器人
- 家庭和朋友访问
- API 文档


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---