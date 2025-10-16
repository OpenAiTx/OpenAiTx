<a name="readme-top"></a>
<div align="center">
  
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![Netlify Status](https://api.netlify.com/api/v1/badges/3d9506ce-9212-47ae-b686-fb932a24f940/deploy-status)](https://app.netlify.com/sites/astro-theme-cody/deploys)  

<a href='https://ko-fi.com/F1F2J3RV9' target='_blank'><img height='36' style='border:0px;height:36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=6' border='0' alt='Buy Me a Coffee at ko-fi.com' /></a>


  <p align="center">
    <h1>Astro 主题 Cody</h1>
  <p>
    一个使用 Astro 构建的极简博客主题。为任何想要快速轻松搭建个人博客的人提供的快速入门构建。
  </p>
    <a href="https://astro-theme-cody.netlify.app">查看演示</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">报告错误</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">请求功能</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## 目录
- [动机](#motivation)
- [主要特性](#key-features)
- [演示](#demo)
- [快速开始](#quick-start)
- [命令](#commands)
- [配置您的网站](#configuring-your-website)
  - [网站配置、社交媒体链接和导航栏链接](#site-config-social-media-links-and-navbar-links)
  - [添加文章和项目](#adding-posts-and-projects)
  - [多语言支持](#multi-language-support)
- [部署](#deploy)
- [额外功能](#extra-funtionality)
- [致谢](#credit)

## 动机
虽然已经有很多博客主题，但我想要一个能散发
终端/开发氛围且具有其他主题没有的一些功能的主题。

## 主要功能：
- Astro v4 快速 🚀
- TailwindCSS 工具类
- 可访问的语义化 HTML 标记
- 响应式 & SEO 友好
- 多语言支持
- 深色 / 浅色模式，使用 Tailwind 和 CSS 变量
- 置顶文章和项目
- [Astro 资源集成](https://docs.astro.build/en/guides/assets/) 用于优化图片
- MD & [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features) 文章
- 分页功能
- 通过 [PageFind](https://pagefind.app/) 搜索文章
- [自动 RSS 订阅源](https://docs.astro.build/en/guides/rss)
- 自动生成的 [网站地图](https://docs.astro.build/en/guides/integrations-guide/sitemap/)
- [Astro 图标](https://github.com/natemoo-re/astro-icon) svg 图标组件
- 回到顶部按钮

## 演示
点击[这里](https://astro-theme-cody.netlify.app)查看演示。

## 快速开始
从此模板[创建一个新仓库](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo)。

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```
<p align="right">(<a href="#readme-top">返回顶部</a>)</p>


## 命令

所有命令均在项目根目录的终端中运行：

| 命令                      | 操作                                              |
| :------------------------ | :------------------------------------------------ |
| `pnpm install`             | 安装依赖                                          |
| `pnpm run dev`             | 启动本地开发服务器，地址为 `localhost:4321`       |
| `pnpm run build`           | 构建生产站点至 `./dist/`                           |
| `pnpm run preview`         | 在部署前本地预览构建结果                            |
| `pnpm run astro ...`       | 运行 CLI 命令，如 `astro add`，`astro check`       |
| `pnpm run astro -- --help` | 获取 Astro CLI 使用帮助                            |

<p align="right">(<a href="#readme-top">返回顶部</a>)</p>

## 配置您的网站

### 站点配置、社交媒体链接和导航栏链接
您的站点配置、社交媒体链接和导航栏链接均位于 [`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts) 中。
您可以在此配置站点默认标题、描述、语言、个人资料、社交媒体链接及可见导航栏链接。

### 添加文章和项目
此主题使用 [内容集合](https://docs.astro.build/en/guides/content-collections/) 
来组织 Markdown 和/或 MDX 文件，并通过模式进行前置数据的类型检查 -> `src/content/config.ts`。

您可以在 `src/content/blog` 中找到博客文章示例，在 `src/content/project` 中找到项目示例。

#### 博客文章前置数据
| 属性（* 表示必填）        | 描述                                                  |
|:-------------------------| :---------------------------------------------------- |
| title *                  | 文章标题。最长不超过150个字符                         |
| description *            | 文章简短描述，也用于 SEO。最长不超过250个字符         |
| pubDate *                | 发表日期                                              |
| updateDate               | 可选，表示文章更新日期。若提供，将用此日期替代发表日期进行文章排序。|
| heroImage                | 可选，文章封面图片。需包含 `src` 和 `alt` 属性。示例请查看 `src/content/blog/first-post.md`。|


| ogImage | 用于SEO的可选图片。 |
| tags | 使用可选标签将您的帖子组织到类别或主题中。所有标签将显示在 `yourdomain.com/tags`。 |
| series | 使用可选系列将您的帖子组织成一系列帖子。所有系列将显示在 `yourdomain.com/series`。 |
| draft | 可选布尔值。移除帖子发布。|
| order | 可选数字值，范围1 - 5，用于将某些帖子置顶。最多只能置顶5个帖子。|
| hide  | 可选布尔值。在 `/blog` 页面隐藏帖子。仍会在 `/archive` 中显示。|

#### 项目 frontmatter

| 属性（* = 必填） | 描述 |
|:-----------------------| :----------|
| title * | 项目标题。最多150个字符 |
| description * | 项目简短描述，也用于SEO。|
| pubDate * | 发布时间 |
| heroImage | 项目封面图片的可选项。需包含 `src` 和 `alt` 属性。示例见 `src/pages/projects/project-1.md`。|
| ogImage | 用于SEO的可选图片。 |
| stack * | 项目所用技术列表，将以图标形式呈现。此主题使用SVG Logos库，您可以访问 [icones.js.org](https://icones.js.org/collection/vscode-icons) 查找所需图标。|
| platform | 网站或演示链接 |
| website | 网站或演示链接 |
| github | 您的GitHub仓库链接 |
| draft | 可选布尔值。移除项目发布。|
| order | 可选数字值，范围1 - 5，用于将某些项目置顶。最多只能置顶5个帖子。|

<p align="right">(<a href="#readme-top">回到顶部</a>)</p>

### 多语言支持
请参阅[wiki](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support)以设置您的博客多语言支持。

## 部署
Astro 提供了丰富的文档，指导您在各种平台上部署 Astro 网站。
您可以在[这里](https://docs.astro.build/en/guides/deploy/)找到相关内容。

## 额外功能
查看 [Astro Recipes](https://docs.astro.build/en/recipes/) 来添加其他功能，如 RSS 订阅源。

## 致谢

本主题基于主题 [Astro Cactus](https://astro-theme-cactus.netlify.app) 和 [Hugo Risotto](https://risotto.joeroe.io)。


<p align="right">(<a href="#readme-top">返回顶部</a>)</p>

[contributors-shield]: https://img.shields.io/github/contributors/kirontoo/astro-theme-cody.svg?style=for-the-badge
[contributors-url]: https://github.com/kirontoo/astro-theme-cody/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/kirontoo/astro-theme-cody.svg?style=for-the-badge
[forks-url]: https://github.com/kirontoo/astro-theme-cody/network/members
[stars-shield]: https://img.shields.io/github/stars/kirontoo/astro-theme-cody.svg?style=for-the-badge
[stars-url]: https://github.com/kirontoo/astro-theme-cody/stargazers
[issues-shield]: https://img.shields.io/github/issues/kirontoo/astro-theme-cody.svg?style=for-the-badge
[issues-url]: https://github.com/kirontoo/astro-theme-cody/issues
[license-shield]: https://img.shields.io/github/license/kirontoo/astro-theme-cody.svg?style=for-the-badge
[license-url]: https://github.com/kirontoo/astro-theme-cody/blob/master/LICENSE.txt


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---