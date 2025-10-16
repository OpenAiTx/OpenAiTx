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
    <h1>Astro Theme Cody</h1>
  <p>
    A minimalist blog theme built with Astro. A quick and easy starter build for anyone who wants to start their own blog.
  </p>
    <a href="https://astro-theme-cody.netlify.app">View Demo</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Report Bug</a>
    ·
    <a href="https://github.com/kirontoo/astro-theme-cody/issues">Request Feature</a>
  </p>
  </p>
</div>

![demo-preview](https://github.com/kirontoo/astro-theme-cody/assets/28286622/d585dcb2-6d5f-4a68-871c-b6028cfcc27f)


## Table of Contents
- [Motivation](#motivation)
- [Key Features](#key-features)
- [Demo](#demo)
- [Quick Start](#quick-start)
- [Commands](#commands)
- [Configuring Your Website](#configuring-your-website)
  - [Site Config, Social Media Links and Navbar Links](#site-config-social-media-links-and-navbar-links)
  - [Adding Posts and Projects](#adding-posts-and-projects)
  - [Multi-Language Support](#multi-language-support)
- [Deploy](#deploy)
- [Extra Functionality](#extra-funtionality)
- [Credit](#credit)

## Motivation
Although there are already so many blog themes out there, I wanted one that would give off
that terminal/dev vibe and a few features that other themes did not have.

## Key Features:
- Astro v4 Fast 🚀
- TailwindCSS Utility classes
- Accessible, semantic HTML markup
- Responsive & SEO-friendly
- Multi-language support
- Dark / Light mode, using Tailwind and CSS variables
- Pinned posts and projects
- [Astro Assets Integration](https://docs.astro.build/en/guides/assets/) for optimised images
- MD & [MDX](https://docs.astro.build/en/guides/markdown-content/#mdx-only-features) posts
- Pagination
- Search through posts with [PageFind](https://pagefind.app/)
- [Automatic RSS feed](https://docs.astro.build/en/guides/rss)
- Auto-generated [sitemap](https://docs.astro.build/en/guides/integrations-guide/sitemap/)
- [Astro Icon](https://github.com/natemoo-re/astro-icon) svg icon component
- Back To Top button

## Demo
Check out the demo [here](https://astro-theme-cody.netlify.app).

## Quick Start
[Create a new repo](https://github.com/new?template_name=astro-theme-cody&template_owner=kirontoo) from this template.

```
# npm 7+
npm create astro@latest -- --template kirontoo/astro-theme-cody

# pnpm
pnpm dlx create-astro --template kirontoo/astro-theme-cody
```

<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Commands

All commands are run from the root of the project, from a terminal:

| Command                   | Action                                           |
| :------------------------ | :----------------------------------------------- |
| `pnpm install`             | Installs dependencies                            |
| `pnpm run dev`             | Starts local dev server at `localhost:4321`      |
| `pnpm run build`           | Build your production site to `./dist/`          |
| `pnpm run preview`         | Preview your build locally, before deploying     |
| `pnpm run astro ...`       | Run CLI commands like `astro add`, `astro check` |
| `pnpm run astro -- --help` | Get help using the Astro CLI                     |

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Configuring Your Website

### Site Config, Social Media Links and Navbar Links
Your site config, social media links and Navbar links are all placed within [`src/consts.ts`](https://github.com/kirontoo/astro-theme-cody/blob/main/src/consts.ts).
There you can configure your site default title, description, language, profile, social media links and visible nav bar links.

### Adding Posts and Projects
This theme utilises [ Content Collections ](https://docs.astro.build/en/guides/content-collections/) 
to organise Markdown and/or MDX files, as well as type-checking frontmatter 
with a schema -> `src/content/config.ts`.

You can find examples of blog posts in `src/content/blog` and examples of projects in `src/content/project`.

#### Blog post frontmatter
| Property (* = required) | Description |
|:-----------------------| :---------- |
| title * | Title of your post. Limited to a maximum of 150 characters  |
| description * | Short description of your post, which will also be used for SEO. Has a max length of 250 characters. |
| pubDate * | Published date |
| updateDate | Optional date representing when the post has been updated. Note that this date will be used instead of the published date to order posts when available.|
| heroImage | Optional cover image for you post. Include both a `src` and a `alt` property. Check `src/content/blog/first-post.md` for an example.|
| ogImage | Optional image used for SEO. |
| tags | Use optional tags to organize your posts into categories or topics. All tags will be shown in `yourdomain.com/tags`. |
| series | Use optional series to organize your posts into a series of posts. All series will be shown in `yourdomain.com/series`. |
| draft | Optional boolean. Removes posts from being published.|
| order | Optional number value from 1 - 5 to pin certain posts to the top. Limited to only 5 pinned posts|
| hide  | Optional boolean. Hide a post on `/blog` page. Will still show up in `/archive`|

#### Project frontmatter

| Property (* = required) | Description |
|:-----------------------| :----------|
| title * | Title of your project. Limited to a maximum of 150 characters  |
| description * | Short description of your project, which will also be used for SEO.|
| pubDate * | Published date |
| heroImage | Optional cover image for you project. Include both a `src` and a `alt` property. Check `src/pages/projects/project-1.md` for an example.|
| ogImage | Optional image used for SEO. |
| stack * | A list of technologies your project used which will be rendered as icons. This theme uses the SVG Logos librar, you can use [icones.js.org](https://icones.js.org/collection/vscode-icons) to find the icons you need.|
| platform | Link to website or demo |
| website | Link to website or demo |
| github | Your github repo link |
| draft | Optional boolean. Removes projects from being published.|
| order | Optional number value from 1 - 5 to pin certain projects to the top. Limited to only 5 pinned posts|

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Multi-Language Support
See the [wiki](https://github.com/kirontoo/astro-theme-cody/wiki/Set-up-multi%E2%80%90language-support) to set up multi-language support for your blog.

## Deploy
Astro provides great documentation for deploying your Astro websites on various platforms.
You can find it [here](https://docs.astro.build/en/guides/deploy/).

## Extra Funtionality
Check out [Astro Recipes](https://docs.astro.build/en/recipes/) to add other functionality like a RSS feed.


## Credit

This theme is based off of the theme [Astro Cactus](https://astro-theme-cactus.netlify.app) and [Hugo Risotto](https://risotto.joeroe.io).

<p align="right">(<a href="#readme-top">back to top</a>)</p>

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
