![Reactive Resume](https://i.imgur.com/FFc4nyZ.jpg)

![App Version](https://img.shields.io/github/package-json/version/AmruthPillai/Reactive-Resume?label=version)
[![Docker Pulls](https://img.shields.io/docker/pulls/amruthpillai/reactive-resume)](https://hub.docker.com/repository/docker/amruthpillai/reactive-resume)
[![GitHub Sponsors](https://img.shields.io/github/sponsors/AmruthPillai)](https://github.com/sponsors/AmruthPillai)
[![Crowdin](https://badges.crowdin.net/reactive-resume/localized.svg)](https://crowdin.com/project/reactive-resume)
[![Discord](https://img.shields.io/discord/1173518977851473940?label=discord&link=https%3A%2F%2Fdiscord.gg%2FhzwkZbyvUW)](https://discord.gg/hzwkZbyvUW)

# Reactive Resume

一个免费且开源的简历生成器，简化了创建、更新和分享简历的流程。

### [访问应用](https://rxresu.me/) | [文档](https://docs.rxresu.me/)

## 描述

Reactive Resume 是一个免费且开源的简历生成器，简化了创建、更新和分享简历的流程。无任何用户追踪或广告，隐私是我们的首要任务。该平台极其用户友好，如果您希望完全拥有自己的数据，可以在不到30秒内自行托管。

它支持多种语言，并集成了实时编辑、数十个模板、拖放自定义以及与 OpenAI 的整合来提升您的写作。

您可以将个性化的简历链接分享给潜在雇主，跟踪简历的浏览或下载情况，并通过拖放来定制页面布局。平台还支持多种字体选项，并提供数十种模板供选择。是的，还有暗黑模式，让阅读体验更加舒适。

今天就用 Reactive Resume 开始打造您的出色简历吧！

## 模板

| Azurill                                                      | Bronzor                                                     | Chikorita                                                   |
| ------------------------------------------------------------ | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/jKgo04C.jpeg" width="200px" /> | <img src="https://i.imgur.com/DFNQZP2.jpg" width="200px" /> | <img src="https://i.imgur.com/Dwv8Y7f.jpg" width="200px" /> |

| Ditto                                                       | Kakuna                                                      | Nosepass                                                    |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/6c5lASL.jpg" width="200px" /> | <img src="https://i.imgur.com/268ML3t.jpg" width="200px" /> | <img src="https://i.imgur.com/npRLsPS.jpg" width="200px" /> |

| Onyx                                                        | Pikachu                                                     | Rhyhorn                                                     |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/cxplXOW.jpg" width="200px" /> | <img src="https://i.imgur.com/Y9f7qsh.jpg" width="200px" /> | <img src="https://i.imgur.com/h4kQxy2.jpg" width="200px" /> |

## 功能

- **永久免费**且开源
- 无遥测、无用户追踪或广告
- 可以在不到30秒内自行托管应用
- **支持多语言** ([帮忙添加/完善您的语言](https://translate.rxresu.me/))
- 使用您的电子邮件地址（或一次性邮箱，均可）创建账号
- 也可用 GitHub 或 Google 账号登录，甚至可以设置双因素认证以增强安全性
- 一个账号下可创建任意多份简历，根据职位描述为每份简历优化以获得更高的 ATS 评分
- **使用您自己的 OpenAI API 密钥**，一键解锁改进写作、纠正拼写和语法、改变文本语气等功能
- 使用 ChatGPT 将简历翻译成任何语言，并导入回来方便编辑
- 轻松创建单页简历或多页简历
- 自定义颜色和布局，为简历添加个人风格
- 通过拖放自由定制页面布局
- 如果现有的分类不适用，可以创建行业专属的自定义章节
- 记下仅自己可见的简历专属个人笔记
- 锁定简历，防止进一步编辑（适用于主模板）
- **数十种模板**可选，涵盖专业和现代风格
- 使用标准化的 EuroPass 设计模板设计简历
- 支持 A4 或 Letter 纸张格式打印简历
- 使用 [Google Fonts](https://fonts.google.com/) 上的任意字体设计简历
- **分享个性化简历链接**给公司或招聘人员，实时获取最新更新
- 可追踪公开简历的浏览量和下载量
- 采用目前最先进且可靠的技术构建，经过开源社区在 GitHub 上的实战测试和同行评审
- **MIT 许可协议**，只要注明原作者，代码可随意使用
- 当然，还有暗黑模式 🌓

## 技术栈

- React (Vite)，前端框架
- NestJS，后端框架
- Postgres（主数据库）
- Prisma ORM，方便切换到其他关系数据库，只需少量代码更改
- Minio（对象存储：存储头像、简历 PDF 和预览）
- Browserless（无头浏览器，用于打印 PDF 和生成预览）
- SMTP 服务器（发送密码找回邮件）
- GitHub/Google OAuth（快速用户认证）
- LinguiJS 和 Crowdin（翻译管理和本地化）

## Star 历史

<a href="https://star-history.com/#AmruthPillai/Reactive-Resume&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date" />
  </picture>
</a>

## 许可协议

Reactive Resume 使用 [MIT 许可协议](/LICENSE.md) 打包和分发，允许商业使用、分发、修改和私人使用，前提是所有软件副本均包含相同的许可和版权声明。

_由社区，为社区而生。_  
一个由 [Amruth Pillai](https://www.amruthpillai.com/) 发起的热情项目

<p>
  <a href="https://www.digitalocean.com/?utm_medium=opensource&utm_source=Reactive-Resume">
    <img src="https://opensource.nyc3.cdn.digitaloceanspaces.com/attribution/assets/PoweredByDO/DO_Powered_by_Badge_blue.svg" width="200px">
  </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---