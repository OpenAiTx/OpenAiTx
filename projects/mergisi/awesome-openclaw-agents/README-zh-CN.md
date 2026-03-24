# 🦞 超棒的 OpenClaw 代理

[![Awesome](https://awesome.re/badge.svg)](https://awesome.re)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)
[![Stars](https://img.shields.io/github/stars/mergisi/awesome-openclaw-agents?style=social)](https://github.com/mergisi/awesome-openclaw-agents)
[![Agents](https://img.shields.io/badge/agents-187-blueviolet)](agents/)

> 一个精选的 **187 个可用于生产的 AI 代理模板** 集合，适用于 OpenClaw 生态系统。每个模板都是一个可直接复制粘贴的 `SOUL.md` 文件。

<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=waving&color=0:4F46E5,100:7C3AED&height=180&section=header&text=%F0%9F%A6%9E%20187%20OpenClaw%20Agent%20Templates&fontSize=36&fontColor=ffffff&fontAlignY=35" width="100%"/>
</p>

<div align="center">

### 跳过设置，60秒部署。

**[浏览全部187个模板 →](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=browse)** · **[60秒快速部署 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=deploy)**

选择模板。自定义配置。获取完整部署包。无需终端。

</div>

<div align="center">

📬 **每周获取代理模板和技巧** — 每周二发布新模板、部署指南和社区精选。

**[订阅新闻通讯 →](https://docs.google.com/forms/d/e/1FAIpQLSeIqBjV1LXnR2qQqGSGa-48rAveAmpSKVqlzLqDK2d4D4aVWg/viewform)**

</div>

---

## 目录

- [代理模板](#agent-templates)（187个代理，涵盖24个类别）
  - [生产力](#productivity) · [开发](#development) · [市场营销](#marketing--content) · [商业](#business) · [个人](#personal)
  - [运维](#devops) · [金融](#finance) · [教育](#education) · [医疗](#healthcare) · [法律](#legal) · [人力资源](#hr) · [创意](#creative) · [安全](#security)
  - [电子商务](#e-commerce) · [数据](#data) · [SaaS](#saas) · [房地产](#real-estate) · [自由职业](#freelance) · [Moltbook](#-moltbook-new)
  - [供应链](#supply-chain) · [合规](#compliance) · [语音](#voice) · [客户成功](#customer-success) · [自动化](#automation)
- [用例](#use-cases)（132个真实案例）
- [快速开始](#quickstart)
- [为什么选择OpenClaw？](#why-openclaw)（对比框架，轻量级，企业级）
- [使用CrewClaw快速部署](#quick-deploy-with-crewclaw)
- [MCP服务器](#mcp-servers)
- [集成](#integrations)
- [工具](#tools)
- [安全](#security)
- [教程与指南](#tutorials--guides)
- [提交您的代理](#submit-your-agent)
- [社区](#community)

---

## 代理模板

即用型SOUL.md代理模板。复制SOUL.md，使用`openclaw agents add`注册，开始网关。

```bash
# Quick start with any template
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
npm install && cp ../agents/productivity/orion/SOUL.md ./SOUL.md
node bot.js
```
> 所有100个代理也可作为机器可读的JSON获取：[`agents.json`](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json)

> **跳过设置？** [CrewClaw](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=skip_setup) 可为任何角色生成完整部署包（Dockerfile + docker-compose + 机器人 + README）。

### 📋 生产力

用更少的努力完成更多工作。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🎯 Orion](agents/productivity/orion/) | 任务协调，项目管理 | 需要每日优先级、截止日期跟踪和团队对齐时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/orion/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=project-manager) |
| [📊 Pulse](agents/productivity/metrics/) | 分析仪表盘（Mixpanel、Stripe、GA4） | 需要自动化的日/周指标报告时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/metrics/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧍 Standup](agents/productivity/daily-standup/) | 每日站会收集，团队总结 | 团队需要异步站会无会议时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/daily-standup/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=project-manager) |
| [📧 Inbox](agents/productivity/inbox-zero/) | 邮件分流，回复草稿，每日摘要 | 收件箱过载且需要优先级划分时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/inbox-zero/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 Minutes](agents/productivity/meeting-notes/) | 会议总结，行动项跟踪 | 需要自动化会议记录和跟进时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/meeting-notes/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🍅 Focus Timer](agents/productivity/focus-timer/) | 番茄钟，深度工作管理 | 需要结构化专注时间和责任制时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/focus-timer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ Habit Tracker](agents/productivity/habit-tracker/) | 每日习惯，连胜，责任追踪 | 需要每日签到和连胜追踪时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/productivity/habit-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 💻 开发

构建未来，一次提交一个代码。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🔎 Lens](agents/development/code-reviewer/) | PR审核，安全扫描，代码质量 | 需要合并前自动代码审查时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/code-reviewer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=code-reviewer) |
| [📖 Scribe](agents/development/docs-writer/) | README，API文档，代码文档 | 文档落后于代码库时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/docs-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=technical-writer) |
| [🐛 Trace](agents/development/bug-hunter/) | 错误分析，根因调查 | 需要更快调试和事件响应时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/bug-hunter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Probe](agents/development/api-tester/) | API测试，健康检查，性能 | 需要持续API监控和报警时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/api-tester/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 Log](agents/development/changelog/) | 自动变更日志，从git生成发布说明 | 需要从提交生成发布说明时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/changelog/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔗 Dependency Scanner](agents/development/dependency-scanner/) | CVE扫描，许可证检查，供应链 | 需要自动依赖安全审计时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/dependency-scanner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔀 PR Merger](agents/development/pr-merger/) | 自动合并，冲突检测 | 需要检查通过后自动合并PR时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/pr-merger/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗄️ Migration Helper](agents/development/migration-helper/) | 数据库迁移，模式差异，回滚 | 计划数据库变更且需要安全保障时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/migration-helper/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🧪 Test Writer](agents/development/test-writer/) | 单元测试生成，覆盖率分析 | 测试覆盖率低且需要赶上时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/test-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🗂️ Schema Designer](agents/development/schema-designer/) | 从自然语言生成数据库模式，ERD输出 | 需要根据需求设计数据库模式时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/development/schema-designer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |

> **想要60秒内运行的软件工程师代理？** [用CrewClaw部署 →](https://crewclaw.com/create-agent?role=software-engineer)

### 📣 营销与内容


自动化增长您的受众。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [✍️ Echo](agents/marketing/echo/) | 博客文章、社交文案、电子邮件 | 需要跨渠道持续内容输出时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/echo/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Buzz](agents/marketing/social-media/) | 推特、领英、帖子管理 | 需要定时社交发布并跟踪互动时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/social-media/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [🔍 Rank](agents/marketing/seo-writer/) | SEO内容，基于GSC的关键词研究 | 需要基于真实搜索数据的SEO优化内容时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/seo-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=seo-specialist) |
| [📬 Digest](agents/marketing/newsletter/) | 新闻简报策划、邮件撰写 | 需要每周新闻简报且无需手动操作时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/newsletter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🔭 Scout](agents/marketing/competitor-watch/) | 竞争对手监控、价格情报 | 需要每天跟踪竞争对手动态时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/competitor-watch/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔎 Reddit Scout](agents/marketing/reddit-scout/) | 子版块监控、回复机会 | 需要发现并参与相关Reddit主题时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/reddit-scout/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎵 TikTok Repurposer](agents/marketing/tiktok-repurposer/) | 博客转视频脚本转换 | 想将长内容转为短视频时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/tiktok-repurposer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📨 Cold Outreach](agents/marketing/cold-outreach/) | 潜在客户调研、个性化冷邮件 | 需要可扩展且不显机械的外联时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/cold-outreach/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [📊 A/B Test Analyzer](agents/marketing/ab-test-analyzer/) | 实验分析、统计显著性 | 运行实验并需要清晰结果时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ab-test-analyzer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Influencer Finder](agents/marketing/influencer-finder/) | 网红调研、外联、活动 | 想寻找并联系相关网红时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/influencer-finder/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=social-media-manager) |
| [👁️ Brand Monitor](agents/marketing/brand-monitor/) | 品牌提及监控、情感警报 | 需要实时知道品牌被提及时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/brand-monitor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📧 Email Sequence](agents/marketing/email-sequence/) | 多阶段滴灌营销、主题行 | 需要自动化邮件养成序列时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/email-sequence/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [♻️ Content Repurposer](agents/marketing/content-repurposer/) | 博客转推文、帖子、短视频脚本 | 想让一篇内容覆盖所有平台时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/content-repurposer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📖 Book Writer](agents/marketing/book-writer/) | 全书制作流程，6个阶段 | 想从大纲到手稿写书时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/book-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📰 News Curator](agents/marketing/news-curator/) | 来源扫描、AI策划、发布 | 需要自动化汇总50+新闻来源时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/news-curator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎥 UGC Video](agents/marketing/ugc-video/) | AI网红风格视频内容 | 需要UGC风格视频脚本与制作计划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/ugc-video/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📱 Multi-Account Social](agents/marketing/multi-account-social/) | 10+账号管理、排程 | 管理多个品牌账号时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/marketing/multi-account-social/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=social-media-manager) |

> **需要内容写手或SEO代理吗？** [用CrewClaw部署 →](https://crewclaw.com/create-agent?role=content-writer)

### 💼 业务

无额外负担地运营。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📊 Radar](agents/business/radar/) | 数据分析、洞察生成 | 需要每日业务指标及趋势分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/radar/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎧 Compass](agents/business/customer-support/) | 工单分类、回复草稿、升级处理 | 支持量增长快于团队时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/customer-support/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |
| [💼 Pipeline](agents/business/sales-assistant/) | 潜在客户评分、外联、销售报告 | 需要自动化潜客资格审核与跟进时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sales-assistant/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [💰 Ledger](agents/business/invoice-tracker/) | 付款监控、发票追踪、经常性收入 | 需要实时收入和付款跟踪时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/invoice-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔮 Sentinel](agents/business/churn-predictor/) | 流失风险评分、留存措施 | 想在客户流失前及时预警时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/churn-predictor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🤝 Personal CRM](agents/business/personal-crm/) | 联系人跟踪、跟进提醒 | 关系和跟进失控时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/personal-crm/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💬 WhatsApp Business](agents/business/whatsapp-business/) | 多渠道支持、潜客资格审核 | 客户通过WhatsApp联系且需快速回复时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/whatsapp-business/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📅 Meeting Scheduler](agents/business/meeting-scheduler/) | 智能排程、时区处理 | 跨时区安排会议耗时时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/meeting-scheduler/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💲 Competitor Pricing](agents/business/competitor-pricing/) | 价格跟踪、变动提醒 | 需要每日监控竞争对手价格变动时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/competitor-pricing/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📞 SDR Outbound](agents/business/sdr-outbound/) | 潜客调研、个性化外联 | 需要自动化外呼销售开发时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/sdr-outbound/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎯 交易预测员](agents/business/deal-forecaster/) | 管道信号，成交概率 | 当您需要数据驱动的交易成交预测时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/deal-forecaster/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🗣️ 异议处理器](agents/business/objection-handler/) | 实时反驳，话术跟踪 | 当销售代表需要即时异议回应时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/business/objection-handler/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |

### 🧘 个人

您的日常生活AI助手。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📅 阿特拉斯](agents/personal/daily-planner/) | 日程优化，早晚复盘 | 当您想要有结构化的日常安排并保持责任感时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/daily-planner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📚 滚动](agents/personal/reading-digest/) | 文章摘要，周度阅读摘要 | 当您有阅读积压且需要精选摘要时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/reading-digest/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💪 铁人](agents/personal/fitness-coach/) | 锻炼，营养，进度报告 | 当您想要一个追踪一切的私人教练时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/fitness-coach/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏠 家庭自动化](agents/personal/home-automation/) | 通过Telegram控制智能家居 | 当您想通过聊天控制智能家居时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/home-automation/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [👨‍👩‍👧‍👦 家庭协调员](agents/personal/family-coordinator/) | 共享日历，膳食，家务轮换 | 当您的家庭需要共享组织者和计划者时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/family-coordinator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ 旅行规划师](agents/personal/travel-planner/) | 行程，航班，酒店，预算 | 当您需要带有智能推荐的旅行计划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/travel-planner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📓 日志提示器](agents/personal/journal-prompter/) | 每日提示，心情追踪，目标 | 当您想要引导式的每日日志以便反思时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/personal/journal-prompter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🚀 运维

保持基础设施全天候运行。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🚨 事故响应者](agents/devops/incident-responder/) | 警报分流，事故协调 | 当您需要自动化事故响应和升级时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/incident-responder/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🚀 部署守护者](agents/devops/deploy-guardian/) | CI/CD监控，部署状态 | 当您想要部署通知和回滚警报时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/deploy-guardian/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🖥️ 基础设施监控](agents/devops/infra-monitor/) | 服务器健康，磁盘，CPU，内存 | 当您需要主动服务器监控和警报时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/infra-monitor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📜 日志分析器](agents/devops/log-analyzer/) | 日志解析，模式检测，异常 | 当您被日志淹没且需要自动分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/log-analyzer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💸 成本优化器](agents/devops/cost-optimizer/) | 云支出监控，节省建议 | 当您的云费用增长且需要可视化时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/cost-optimizer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔧 自愈服务器](agents/devops/self-healing-server/) | 自动重启容器，磁盘清理 | 当您希望服务器在凌晨3点自动修复时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/self-healing-server/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🍓 树莓派代理](agents/devops/raspberry-pi/) | 轻量级边缘代理，低内存优化 | 当您在树莓派或边缘设备上部署代理时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/raspberry-pi/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📋 操作手册编写者](agents/devops/runbook-writer/) | 从系统架构生成操作手册 | 当您需要事故响应的文档化流程时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/runbook-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📊 SLA监控](agents/devops/sla-monitor/) | SLA合规追踪，降级警报 | 当您需要追踪各服务的正常运行承诺时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/sla-monitor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📐 容量规划师](agents/devops/capacity-planner/) | 基础设施容量预测 | 当您需要提前规划基础设施扩展时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/devops/capacity-planner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |

### 💰 财务

解读数字的意义。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🧾 费用跟踪器](agents/finance/expense-tracker/) | 费用分类，预算提醒 | 需要自动化费用跟踪和预算监控时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/expense-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧮 发票管理器](agents/finance/invoice-manager/) | 发票创建，跟踪，催款 | 发票丢失且付款延迟时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/invoice-manager/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 收入分析师](agents/finance/revenue-analyst/) | MRR分析，客户流失，收入预测 | 需要自动化收入报告和预测时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/revenue-analyst/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🏦 税务准备员](agents/finance/tax-preparer/) | 收据整理，扣除计算 | 税季临近需要整理时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/tax-preparer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📉 交易机器人](agents/finance/trading-bot/) | 投资组合跟踪，情绪，价格提醒 | 需要自动化市场监控和价格提醒时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/trading-bot/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🔍 欺诈检测器](agents/finance/fraud-detector/) | 交易异常检测，欺诈提醒 | 需要实时交易欺诈监控时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/fraud-detector/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 财务预测器](agents/finance/financial-forecaster/) | 基于历史数据的收入/费用预测 | 需要数据驱动的财务预测时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/financial-forecaster/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⚖️ 投资组合再平衡器](agents/finance/portfolio-rebalancer/) | 配置漂移分析，再平衡交易 | 投资组合需要定期再平衡时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/portfolio-rebalancer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💳 应付账款](agents/finance/accounts-payable/) | 发票匹配，审批流程，付款 | AP工作流程需自动化和加快处理时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/accounts-payable/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 跟单交易员](agents/finance/copy-trader/) | 跟单顶级交易者，风险控制 | 需要自动复制预测市场交易时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/finance/copy-trader/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🎓 教育

更聪明地学习，而非更辛苦。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🎓 家教](agents/education/tutor/) | 概念讲解，练习题 | 需要全天候耐心家教时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/tutor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [❓ 测验制作](agents/education/quiz-maker/) | 测验生成，成绩跟踪 | 需要自动化测验生成时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/quiz-maker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📖 学习计划员](agents/education/study-planner/) | 学习日程，提醒 | 需要结构化学习计划和每日提醒时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/study-planner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 研究助理](agents/education/research-assistant/) | 论文搜索，摘要，引用 | 研究时需要帮助查找论文时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/research-assistant/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌍 语言家教](agents/education/language-tutor/) | 语言学习，会话练习 | 需要手机每日语言练习时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/language-tutor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📐 课程设计师](agents/education/curriculum-designer/) | 课程大纲，学习目标 | 需要结构化课程设计和评估标准时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/curriculum-designer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📝 论文评分员](agents/education/essay-grader/) | 论文反馈，基于评分标准 | 需要大规模一致的论文评估时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/essay-grader/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🃏 闪卡生成器](agents/education/flashcard-generator/) | 基于笔记的间隔重复卡片 | 需要自动化闪卡以高效学习时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/education/flashcard-generator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🏥 医疗保健

关爱最重要的事。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🧘 健康教练](agents/healthcare/wellness-coach/) | 每日签到，心理健康，习惯 | 需要每日健康提醒和情绪追踪时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/wellness-coach/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🥗 餐饮计划师](agents/healthcare/meal-planner/) | 餐饮计划，营养追踪 | 需要基于目标的每周餐饮计划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/meal-planner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🏋️ 锻炼追踪器](agents/healthcare/workout-tracker/) | 锻炼计划，进度追踪 | 需要适应进度的锻炼计划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/workout-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [🩺 症状分诊](agents/healthcare/symptom-triage/) | 结构化症状评估，紧急程度 | 患者需要初步症状评估和指导时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/symptom-triage/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📋 临床记录](agents/healthcare/clinical-notes/) | SOAP格式临床文档 | 临床会诊需结构化笔录时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/clinical-notes/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [💊 用药检查器](agents/healthcare/medication-checker/) | 药物相互作用，剂量提醒 | 需要核实用药安全和相互作用时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/medication-checker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |
| [📝 患者接收](agents/healthcare/patient-intake/) | 接收表格，保险验证 | 患者登记需自动化和加速时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/healthcare/patient-intake/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=fitness-coach) |

### ⚖️ 法律

导航细则。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📜 合同审查员](agents/legal/contract-reviewer/) | 合同审查，风险条款检测 | 当您正在审查合同并需要第二双眼睛时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/contract-reviewer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✅ 合规检查员](agents/legal/compliance-checker/) | 合规监控，截止日期跟踪 | 当您需要紧跟监管要求时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/compliance-checker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 政策撰写员](agents/legal/policy-writer/) | 内部政策，服务条款 | 当您需要起草或更新公司政策时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/policy-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔬 专利分析师](agents/legal/patent-analyzer/) | 专利权利要求，现有技术，侵权风险 | 当您需要专利格局分析和风险评估时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/patent-analyzer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 法律简报撰写员](agents/legal/legal-brief-writer/) | 简报，动议，备忘录起草 | 当您需要根据案件事实起草法律文件时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/legal-brief-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🔒 保密协议生成器](agents/legal/nda-generator/) | 定制保密协议，保密条款 | 当您需要快速定制保密协议时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/legal/nda-generator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 👥 人力资源

打造高效团队。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🤝 招聘专员](agents/hr/recruiter/) | 简历筛选，面试安排 | 当您招聘时需要更快筛选候选人 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/recruiter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎒 入职引导](agents/hr/onboarding/) | 新员工设置，入职指南 | 当新员工需要引导式入职体验时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/onboarding/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📊 绩效评审员](agents/hr/performance-reviewer/) | 反馈收集，评审总结 | 当进入评审季且需要结构化反馈时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/performance-reviewer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 简历筛选员](agents/hr/resume-screener/) | 简历评分，候选人排名 | 当您需要筛选大量申请人时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/resume-screener/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🚪 离职面谈员](agents/hr/exit-interview/) | 结构化离职面谈，留任洞察 | 当您需要了解员工离职原因时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/exit-interview/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎁 福利顾问](agents/hr/benefits-advisor/) | 福利问答，政策指导 | 当员工对福利和政策有疑问时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/benefits-advisor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [💰 薪酬对标员](agents/hr/compensation-benchmarker/) | 薪资数据，市场行情分析 | 当您需要数据驱动的薪酬建议时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/hr/compensation-benchmarker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎨 创意

让它美观且引人入胜。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🎨 品牌设计师](agents/creative/brand-designer/) | 品牌指南，色彩搭配 | 当您正在构建或刷新品牌形象时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/brand-designer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 视频脚本师](agents/creative/video-scripter/) | 视频脚本，大纲，镜头列表 | 当您需要视频内容但不喜欢写脚本时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/video-scripter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎙️ 播客制作人](agents/creative/podcast-producer/) | 节目策划，节目笔记 | 当您运营播客需要规划帮助时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/podcast-producer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🧑‍💻 用户体验研究员](agents/creative/ux-researcher/) | 用户调查，反馈分析 | 当您需要用户洞察但不想雇研究员时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ux-researcher/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [✏️ 文案撰写员](agents/creative/copywriter/) | 广告文案，登陆页，邮件序列 | 当您需要快速获得转化导向文案时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/copywriter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🖼️ 缩略图设计师](agents/creative/thumbnail-designer/) | YouTube/社交媒体缩略图创意 | 当您需要引人注目的缩略图创意时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/thumbnail-designer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [📢 广告文案师](agents/creative/ad-copywriter/) | Google、Meta、LinkedIn广告变体 | 当您需要跨平台A/B测试广告文案时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/ad-copywriter/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🎬 分镜编写器](agents/creative/storyboard-writer/) | 视觉分镜，镜头列表 | 当你需要为视频内容进行前期制作规划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/creative/storyboard-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |

### 🔒 安全

保护你所构建的内容。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🛡️ 漏洞扫描器](agents/security/vuln-scanner/) | 漏洞扫描，修复优先级排序 | 当你需要对你的技术栈进行持续安全扫描时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/vuln-scanner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔐 访问审计员](agents/security/access-auditor/) | 权限审查，过度访问标记 | 当你需要审计谁拥有何种访问权限时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/access-auditor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [👁️ 威胁监控](agents/security/threat-monitor/) | 威胁信息监控，相关警报 | 当你希望对针对你的技术栈的威胁进行预警时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/threat-monitor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [📓 事件记录器](agents/security/incident-logger/) | 安全事件文档记录 | 当你需要结构化的事件跟踪和事后分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/incident-logger/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🔒 安全加固器](agents/security/security-hardener/) | SOUL.md 审核，网关加固 | 当你想加固代理和网关配置时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/security-hardener/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [🎣 钓鱼邮件检测器](agents/security/phishing-detector/) | 邮件钓鱼分析，URL 扫描 | 当你的团队需要自动化钓鱼检测时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/security/phishing-detector/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |

### 🛒 电子商务

更多销售，更少管理。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🏷️ 产品上架员](agents/ecommerce/product-lister/) | 列表优化，SEO 标题 | 当你需要在各大市场优化产品列表时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/product-lister/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [⭐ 评论回复员](agents/ecommerce/review-responder/) | 自动回复客户评论 | 当客户评论需要快速且一致的回应时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/review-responder/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📦 库存追踪器](agents/ecommerce/inventory-tracker/) | 库存监控，补货提醒 | 当你需要防止缺货和库存过剩时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/inventory-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [💲 价格优化器](agents/ecommerce/pricing-optimizer/) | 动态定价，竞争跟踪 | 当你希望价格能根据市场状况调整时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/pricing-optimizer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🛒 放弃购物车](agents/ecommerce/abandoned-cart/) | 购物车恢复，挽回流程 | 当你因放弃购物车而失去销售时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/abandoned-cart/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🔍 代发货研究员](agents/ecommerce/dropshipping-researcher/) | 24/7 产品研究，供应商分析 | 当你需要持续发现代发货产品时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/ecommerce/dropshipping-researcher/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |

> **经营 Shopify 或亚马逊店铺？** [部署电子商务代理 →](https://crewclaw.com/create-agent?role=customer-support)

### 📊 数据

将原始数据转化为决策。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🔄 ETL 管道](agents/data/etl-pipeline/) | 管道监控，失败警报，重试 | 当你的数据管道需要自动监控时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/etl-pipeline/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🧹 数据清理器](agents/data/data-cleaner/) | 质量检查，去重，规范化 | 当你的数据混乱，需要自动清理时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/data-cleaner/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 报告生成器](agents/data/report-generator/) | 多来源自动报告 | 当利益相关者需要定期报告且无需人工时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/report-generator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🗃️ SQL 助手](agents/data/sql-assistant/) | SQL 帮助，查询优化，架构探索 | 当你需要复杂查询的 SQL 助手时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/sql-assistant/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 仪表盘构建器](agents/data/dashboard-builder/) | 指标仪表盘，维护 | 当你需要自动创建和更新仪表盘时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/dashboard-builder/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🚨 异常检测器](agents/data/anomaly-detector/) | 指标异常检测，统计警报 | 当你需要对异常数据模式进行自动报警时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/anomaly-detector/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📋 调查分析器](agents/data/survey-analyzer/) | 情绪，主题，NPS细分 | 当你有调查数据需要结构化分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/data/survey-analyzer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |

> **需要数据分析师代理吗？** [使用 CrewClaw 部署 →](https://crewclaw.com/create-agent?role=data-analyst)

### ☁️ SaaS

发展你的产品，留住用户。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🚀 入职流程](agents/saas/onboarding-flow/) | 用户入职，激活跟踪 | 当新用户未达到他们的“aha”时刻时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/onboarding-flow/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=project-manager) |
| [💡 功能请求](agents/saas/feature-request/) | 请求收集，优先级排序，投票 | 当功能请求分散在多个渠道时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/feature-request/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=project-manager) |
| [🔮 流失预防](agents/saas/churn-prevention/) | 主动流失预防，健康评分 | 当用户流失且你不知道原因时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/churn-prevention/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 使用分析](agents/saas/usage-analytics/) | 产品使用，功能采用跟踪 | 当你需要了解用户如何使用你的产品时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/usage-analytics/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📝 发布说明](agents/saas/release-notes/) | 从git和PR自动生成发布说明 | 当写发布说明成了没人愿意做的苦差事时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/saas/release-notes/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=technical-writer) |

### 🏡 房地产

寻找交易，更快成交。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🏡 房源侦查](agents/real-estate/listing-scout/) | 房产监控，降价提醒 | 当你想即时获得新房源和降价提醒时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/listing-scout/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📊 市场分析器](agents/real-estate/market-analyzer/) | 市场分析，可比报告 | 当你需要自动市场对比和趋势分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/market-analyzer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [🎯 潜在客户评分](agents/real-estate/lead-qualifier/) | 潜在客户评分，跟进序列 | 当潜在客户涌入速度超过你评估能力时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/lead-qualifier/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=sales-representative) |
| [🎬 房产视频](agents/real-estate/property-video/) | 房源视频，虚拟导览，布置 | 当你需要大规模房产视频内容时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/property-video/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [🏢 商业地产](agents/real-estate/commercial-re/) | 商业地产分析，资本化率，交易跟踪 | 当你需要商业地产投资分析时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/real-estate/commercial-re/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |

### 🧑‍💻 自由职业

更聪明地工作，赚更多钱。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📝 提案撰写](agents/freelance/proposal-writer/) | 提案生成，费率计算 | 当你花太多时间写提案时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/proposal-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=content-writer) |
| [⏱️ 时间追踪](agents/freelance/time-tracker/) | 时间追踪，开票，利用率 | 当你因时间追踪不佳而流失计费时间时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/time-tracker/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤝 客户管理](agents/freelance/client-manager/) | 客户关系管理，合同跟踪 | 当你需要同时管理多个客户和截止日期时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/freelance/client-manager/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=project-manager) |

> **自由职业者？** [部署个人助理代理 →](https://crewclaw.com/create-agent?role=personal-assistant)

### 🤖 Moltbook `新`

AI 代理社交网络 —— 您的代理在代理对代理社交层的存在感。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🤖 社区经理](agents/moltbook/community-manager/) | 发布更新，互动，建立声望 | 当您希望您的代理在 Moltbook 上保持社交存在时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/community-manager/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [🔭 侦察员](agents/moltbook/scout/) | 信息流扫描，关键词监控，摘要 | 当您想监控 Moltbook 上的相关讨论和机会时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/scout/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?integrations=moltbook) |
| [📈 增长代理](agents/moltbook/growth-agent/) | 关注者增长，子 Molt 管理，策略 | 当您想在 Moltbook 上提升代理的影响力和关注者数量时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/moltbook/growth-agent/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?integrations=moltbook) |

> **新功能：Moltbook 集成！** 您的代理现在可以在 AI 代理社交网络上发布、互动和成长。 [使用 Moltbook 部署 →](https://crewclaw.com/create-agent?integrations=moltbook)

### 📦 供应链 `新`

优化物流和供应商运营。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🚚 路线优化器](agents/supply-chain/route-optimizer/) | 送货路线，交通，容量 | 当您需要优化配送规划时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/route-optimizer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [📈 库存预测器](agents/supply-chain/inventory-forecaster/) | 需求预测，补货点 | 当您需要通过智能预测防止缺货时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/inventory-forecaster/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |
| [⭐ 供应商评估师](agents/supply-chain/vendor-evaluator/) | 供应商评分，质量跟踪 | 当您需要基于数据进行供应商选择和排名时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/supply-chain/vendor-evaluator/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=data-analyst) |

### ✅ 合规 `新`

领先法规合规。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🔒 GDPR 审核员](agents/compliance/gdpr-auditor/) | GDPR 差距分析，整改方案 | 当您需要审核系统的数据隐私合规性时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/gdpr-auditor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📋 SOC2 准备员](agents/compliance/soc2-preparer/) | 证据收集，审核准备 | 当您准备 SOC 2 认证时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/soc2-preparer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🤖 AI 政策撰写员](agents/compliance/ai-policy-writer/) | AI 治理，欧盟 AI 法案对齐 | 当您需要组织的 AI 使用政策时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/ai-policy-writer/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [⚠️ 风险评估师](agents/compliance/risk-assessor/) | 风险评估，缓解规划 | 当您需要结构化的业务风险评估时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/compliance/risk-assessor/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🎙️ 语音 `新`

AI 驱动的语音和电话代理。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📞 电话接待员](agents/voice/phone-receptionist/) | 来电处理，路由，预约 | 当你需要全天候电话接听而无需员工时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/phone-receptionist/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |
| [📝 语音信箱转录员](agents/voice/voicemail-transcriber/) | 转录，行动项提取 | 当语音信箱需要快速处理和路由时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/voicemail-transcriber/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🎤 面试机器人](agents/voice/interview-bot/) | 筛选面试，评分标准 | 当你需要大规模结构化候选人筛选时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/voice/interview-bot/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

### 🤝 客户成功 `NEW`

保持客户满意并实现增长。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [📊 NPS 跟进](agents/customer-success/nps-followup/) | 恶评恢复，个性化外展 | 当 NPS 恶评者需要立即关注时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/nps-followup/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |
| [🎯 入职指南](agents/customer-success/onboarding-guide/) | 产品设置，情境提示 | 当新用户需要引导产品入门时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/customer-success/onboarding-guide/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=customer-support) |

### 🔄 自动化 `NEW`

设定后忘记它。代理在你睡觉时工作。

| 代理 | 专长 | 何时使用 | SOUL.md | 部署 |
|-------|-----------|-------------|---------|--------|
| [🤝 谈判代理](agents/automation/negotiation-agent/) | 账单谈判，交易达成 | 当你希望 AI 谈判账单和合同时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/negotiation-agent/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [📄 求职申请](agents/automation/job-applicant/) | 大规模申请，简历定制 | 当你想在睡觉时申请 500+ 个职位时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/job-applicant/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [☀️ 早间简报](agents/automation/morning-briefing/) | 邮件、日历、新闻每日汇总 | 当你希望每天早上7点收到个性化简报时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/morning-briefing/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [✈️ 航班抓取器](agents/automation/flight-scraper/) | 航班优惠，价格下降提醒 | 当你想自动找到最便宜的航班时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/flight-scraper/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |
| [🌙 夜间程序员](agents/automation/overnight-coder/) | 自主编码，早晨提交 PR | 当你希望代码在你睡觉时被写好时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/overnight-coder/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=software-engineer) |
| [💬 Discord 商务](agents/automation/discord-business/) | 通过 Discord 完整业务运营 | 当你通过 Discord 运营你的业务时 | [查看](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents/automation/discord-business/SOUL.md) | [部署 →](https://crewclaw.com/create-agent?role=personal-assistant) |

---

## 使用案例

**132 个经过验证的真实世界使用案例** — 人们实际使用 OpenClaw 代理构建的项目。

从开发者工作流和 DevOps 自动化，到智能家居控制、加密货币交易、机器人，以及能自我修改代码的代理。

**[浏览全部 132 个使用案例 →](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/USE-CASES.md)**

热门类别：个人生产力 (14) · 业务运营 (11) · 开发者工作流 (10) · 内容创作 (10) · 生态系统工具 (10)

---

## 快速开始

在不到5分钟内运行一个工作代理，无需任何配置：

```bash
git clone https://github.com/mergisi/awesome-openclaw-agents.git
cd awesome-openclaw-agents/quickstart
cp .env.example .env          # add your API key + Telegram token
cp ../agents/marketing/echo/SOUL.md ./SOUL.md
npm install && node bot.js    # your agent is live on Telegram
```

查看完整的带有 Docker 支持的[快速入门指南](quickstart/)。

或者跳过设置：**[使用 CrewClaw 部署 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=quickstart)** — 获取任何角色的完整部署包（Dockerfile + docker-compose + 机器人 + README）。

---

## 为什么选择 OpenClaw？

OpenClaw 与其他 AI 代理框架的比较：

### 与 AI 代理框架对比

| 特性 | OpenClaw | AutoGPT | CrewAI | LangChain | MetaGPT |
|---------|----------|---------|--------|-----------|---------|
| 配置优先 (SOUL.md) | ✅ | ❌ | ❌ | ❌ | ❌ |
| 无需编码 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 内置 Telegram/Slack/Discord | ✅ | ❌ | ❌ | ❌ | ❌ |
| 多代理编排 | ✅ | ❌ | ✅ | ✅ | ✅ |
| MCP（模型上下文协议） | ✅ | ❌ | ❌ | ❌ | ❌ |
| 自托管 / 本地部署 | ✅ | ✅ | ✅ | ✅ | ✅ |
| 心跳监测 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 支持 Ollama（免费） | ✅ | ✅ | ✅ | ✅ | ❌ |
| 生产就绪模板数量 | **187** | 0 | 5 | 0 | 3 |
| 一键部署 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 代理间通信 | ✅ | ❌ | ✅ | ✅ | ✅ |
| 设置时间 | ~5 分钟 | ~30 分钟 | ~20 分钟 | ~45 分钟 | ~30 分钟 |

### 与轻量级替代方案对比

| 特性 | OpenClaw | ZeroClaw | PicoClaw | NanoClaw | memU |
|---------|----------|----------|----------|----------|------|
| 语言 | Node.js | Rust | Go | Python | Python |
| 二进制大小 | ~150MB | ~5MB | ~8MB | ~4K 行代码 | ~50MB |
| 最小内存 | 512MB | 32MB | 64MB | 128MB | 256MB |
| 多代理 | ✅ AGENTS.md | ❌ | ❌ | ❌ | ❌ |
| 技能/插件 | ✅ 13K+ | ❌ | ❌ | ❌ | ❌ |
| 消息渠道 | ✅ 25+ | 3 | 2 | 1 | 5 |
| 长期记忆 | 基础 | ❌ | ❌ | ❌ | ✅ 知识图谱 |
| MCP 支持 | ✅ | ❌ | ❌ | ❌ | ❌ |
| 生产模板 | **187** | 0 | 0 | 0 | 0 |
| 最适合 | 完整代理团队 | 边缘/物联网 | 单用途机器人 | 极简设置 | 个人助理 |

### 与托管/企业解决方案对比

| 特性 | OpenClaw | Claude Code Channels | NemoClaw (NVIDIA) | OpenFang |
|---------|----------|---------------------|-------------------|----------|
| 开源 | ✅ MIT | ❌ 专有 | ✅ Apache 2.0 | ✅ MIT |
| 自托管 | ✅ | ❌ 仅云端 | ✅ | ✅ |
| 安装 | 配置文件 | API 密钥 | Docker + 配置 | Rust 二进制 |
| 多代理 | ✅ | ❌ | ✅ 通过 OpenClaw | ✅ 7 个“手” |
| 安全模型 | 用户管理 | Anthropic 管理 | 内核沙箱 | 进程隔离 |
| 通讯 | ✅ 25+ 渠道 | Telegram，Discord | 通过 OpenClaw | 3 个渠道 |
| 费用 | 免费 + API 费用 | Claude 订阅 | 免费 + API 费用 | 免费 + API 费用 |
| 最适合 | 完全控制 | 非技术用户 | 企业安全 | 代理操作系统高级用户 |

**简而言之：** OpenClaw 以配置为先。编写 SOUL.md，运行命令，代理即刻上线。无需 Python，无需链，无需图。轻量级替代方案以功能换取更小体积。企业解决方案增加安全层。

---

## 使用 CrewClaw 快速部署

选择模板，自定义，通过 [CrewClaw](https://crewclaw.com/create-agent) 获取完整部署包：

```
Your CrewClaw package includes:
├── agents/your-agent/SOUL.md    # Agent configuration
├── Dockerfile                    # Container setup
├── docker-compose.yml            # One-command deploy
├── bot.js                        # Telegram bot (grammy)
├── .env.example                  # API keys template
├── package.json                  # Dependencies
└── README.md                     # Setup instructions
```

任选上述187个模板中的任何一个，或从头创建自定义代理。

**[创建您的代理 →](https://crewclaw.com/create-agent?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta)**

---

## MCP 服务器

模型上下文协议服务器，用于扩展代理功能。

### 官方

| 服务器 | 描述 | 安装 |
|--------|-------------|---------|
| [@anthropic/mcp-server-fetch](https://github.com/anthropics/mcp-server-fetch) | 网络抓取和浏览 | `npx -y @anthropic/mcp-server-fetch` |
| [@anthropic/mcp-server-filesystem](https://github.com/anthropics/mcp-server-filesystem) | 文件系统访问 | `npx -y @anthropic/mcp-server-filesystem` |

### 社区

| 服务器 | 描述 |
|--------|-------------|
| mcp-notion | Notion 集成 |
| mcp-google-calendar | Google 日历访问 |
| mcp-github | GitHub 操作 |
| mcp-slack | Slack 消息 |
| mcp-postgres | PostgreSQL 查询 |
| mcp-stripe | Stripe 支付 |
| mcp-shopify | Shopify 商店管理 |
| mcp-twitter | Twitter/X 发布 |
| mcp-discord | Discord 机器人集成 |
| mcp-linear | Linear 问题跟踪 |

---

## 集成

将您的代理连接到外部服务。

### 消息传递
- **Telegram** - 通过 Telegram 与代理聊天（内置于 OpenClaw）
- **Slack** - Slack 工作区连接（内置于 OpenClaw）
- **Discord** - Discord 服务器机器人（内置于 OpenClaw）
- **Email** - 电子邮件通道（内置于 OpenClaw）

### 自动化

- **n8n** - n8n 集成节点
- **GitHub Actions** - CI/CD 集成
- **Cron / pm2 / systemd** - 持续运行的代理调度

---

## 工具

用于操作 OpenClaw 的实用程序和辅助工具。

| 工具 | 描述 |
|------|-------------|
| [openclaw CLI](https://crewclaw.com/blog/openclaw-cli-commands-reference) | 官方 CLI - 完整命令参考 |
| [agents.json](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/agents.json) | 所有 187 个代理模板的机器可读索引 |
| agent-validator | 验证 SOUL.md 语法 |
| mcp-tester | 测试 MCP 服务器连接 |

---

## 安全

OpenClaw 代理运行在您的硬件上，可访问您的文件和服务。请遵循以下最佳实践：

| 风险 | 缓解措施 |
|------|------------|
| 网关暴露 | 仅绑定到 `localhost`。使用 SSH 隧道进行远程访问。切勿将端口 18789 暴露于互联网。 |
| API 密钥泄露 | 将密钥存储在 `.env` 文件中。将 `.env` 添加到 `.gitignore`。定期轮换密钥。 |
| 恶意技能 | 仅安装来自 ClawHub 验证发布者的技能。安装前请审查 SKILL.md。 |
| 提示注入 | 在 SOUL.md 中设置严格的 `## Rules`。限制文件系统访问。对不可信输入禁用 shell 命令。 |
| 无人值守代理 | 使用 HEARTBEAT.md 限制范围。设置预算上限。启用所有操作的日志记录。 |

**最新安全资源：**

- [OpenClaw 安全指南](https://crewclaw.com/blog/openclaw-security-guide) - 加固您的设置
- [OpenClaw 2026 安全风险](https://crewclaw.com/blog/openclaw-security-risks-2026) - 已知漏洞及修复
- [NemoClaw（NVIDIA GTC 2026）](https://crewclaw.com/blog/nvidia-gtc-2026-openclaw-nemoclaw) - 企业安全封装
- [官方安全文档](https://docs.openclaw.ai/gateway/security) - 网关安全配置

---

## 教程与指南

学习如何构建和部署代理。

### 入门指南

- [如何使用 OpenClaw：初学者指南](https://crewclaw.com/blog/how-to-use-openclaw-guide) - 5 分钟内安装并运行第一个代理
- [什么是 OpenClaw？](https://crewclaw.com/blog/what-is-openclaw-ai-agent-framework) - 框架完整指南
- [创建您的第一个代理](https://crewclaw.com/blog/how-to-create-ai-agent-openclaw) - 无需编码
- [OpenClaw 2026 设置指南](https://crewclaw.com/blog/openclaw-setup-guide-2026) - 安装、配置、运行
- [系统需求](https://crewclaw.com/blog/openclaw-system-requirements-2026) - 硬件、GPU、VPS、Docker 规格
- [OpenClaw 最佳模型](https://crewclaw.com/blog/best-models-for-openclaw-2026) - 10 个大型语言模型在成本、速度、工具调用上的对比
- [SOUL.md 模板](https://crewclaw.com/blog/soul-md-examples-templates) - 10 个可直接使用的示例

### 多代理与编排

- [多代理设置指南](https://crewclaw.com/blog/openclaw-multi-agent-setup-guide) - 同时运行多个代理
- [代理间通信](https://crewclaw.com/blog/openclaw-agent-to-agent-communication) - 代理如何协作
- [构建 AI 团队](https://crewclaw.com/blog/build-ai-team-workflows) - 自动运行的工作流程

### 使用案例

- [OpenClaw 能做什么？](https://crewclaw.com/blog/what-can-openclaw-do) - 12 个带配置的真实使用案例
- [OpenClaw 商业应用](https://crewclaw.com/blog/openclaw-for-business-use-cases) - 8 个类别中的 25 个使用案例
- [内容创作指南](https://crewclaw.com/blog/openclaw-content-creation-guide) - 博客、社交媒体、视频自动化
- [潜在客户生成指南](https://crewclaw.com/blog/openclaw-lead-generation-guide) - Reddit、Twitter、销售管道
- [邮件自动化](https://crewclaw.com/blog/openclaw-email-automation-guide) - 邮箱分类、自动回复、跟进
- [家庭助手集成](https://crewclaw.com/blog/openclaw-home-assistant-integration) - 智能家居控制

### 集成与自动化

- [Slack & Telegram 集成](https://crewclaw.com/blog/openclaw-slack-telegram-integration) - 连接消息渠道

- [使用 Ollama 运行](https://crewclaw.com/blog/openclaw-ollama-local-agents) - 免费本地 AI 代理  
- [自动化指南](https://crewclaw.com/blog/openclaw-automation-guide) - 构建全天候工作流  
- [CLI 命令参考](https://crewclaw.com/blog/openclaw-cli-commands-reference) - 完整速查表  
- [Google Workspace 集成](https://crewclaw.com/blog/openclaw-google-workspace-integration) - Gmail、文档、驱动器、日历  

### 比较  

- [OpenClaw 与 CrewAI](https://crewclaw.com/blog/openclaw-vs-crewai) - 哪个更好？  
- [OpenClaw 与 AutoGen](https://crewclaw.com/blog/openclaw-vs-autogen) - 微软的多代理框架  
- [OpenClaw 与 LangChain](https://crewclaw.com/blog/openclaw-vs-langchain) - 框架对比  
- [OpenClaw 与 AutoGPT](https://crewclaw.com/blog/openclaw-vs-autogpt) - 关键差异  
- [OpenClaw 与 ZeroClaw](https://crewclaw.com/blog/openclaw-vs-zeroclaw) - Rust 轻量级替代方案  
- [OpenClaw 与 OpenFang](https://crewclaw.com/blog/openclaw-vs-openfang) - 具有七只手的代理操作系统  
- [OpenClaw 与 memU](https://crewclaw.com/blog/openclaw-vs-memu) - 长期记忆 AI  
- [PicoClaw 与 OpenClaw](https://crewclaw.com/blog/picoclaw-vs-openclaw) - 超简约替代方案  
- [OpenClaw GitHub 仓库指南](https://crewclaw.com/blog/openclaw-ai-agent-github-guide) - 25 万星仓库解析  

---

## 提交您的代理  

构建了自定义代理？将其列在这里及 [crewclaw.com/agents](https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=submit) 上。  

每个代理都是完整的操作系统，而不仅仅是一个提示：

```
agents/[category]/[your-agent]/
├── SOUL.md          ← Identity & personality (required)
├── README.md        ← Description & use cases (required)
├── AGENTS.md        ← Operating rules (optional)
├── HEARTBEAT.md     ← Wake-up checklist (optional)
└── WORKING.md       ← Starting task (optional)
```
**通过 PR（推荐）：**

1. Fork 此仓库  
2. 添加包含 SOUL.md + README.md（至少）的代理文件夹  
3. 在 `agents.json` 中添加条目  
4. 提交 Pull Request  

**通过 Issue（无需设置）：**

[提交你的代理 →](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md) — 粘贴你的文件，我们会帮你添加。  

完整指南：[CONTRIBUTING.md](https://raw.githubusercontent.com/mergisi/awesome-openclaw-agents/main/CONTRIBUTING.md)  

---  

## 社区  

想要请求代理？请使用 [代理请求](https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-request.md) 模板。  

---  

## 相关项目  

- [🦞 CrewClaw](https://crewclaw.com) - 零配置部署 AI 代理。无需 Docker，无需终端。  
- [OpenClaw](https://github.com/openclaw) - 官方 OpenClaw 仓库  
- [Anthropic MCP](https://github.com/anthropics/mcp) - 模型上下文协议  

---  

## Star 历史  

[![Star History Chart](https://api.star-history.com/svg?repos=mergisi/awesome-openclaw-agents&type=Date)](https://star-history.com/#mergisi/awesome-openclaw-agents&Date)  

---  

## 许可证  

[![CC0](https://licensebuttons.net/p/zero/1.0/88x31.png)](https://creativecommons.org/publicdomain/zero/1.0/)


在法律允许的范围内，贡献者已放弃对本作品的所有版权及相关权利。

---

<p align="center">
  由 OpenClaw 社区用 🦞 制作
  <br/>
  <a href="https://crewclaw.com/agents?utm_source=github&utm_medium=readme&utm_campaign=bottom_cta">使用 CrewClaw 部署您的代理 →</a> · <a href="https://github.com/mergisi/awesome-openclaw-agents/issues/new?template=agent-submission.md">提交您的代理 →</a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-24

---