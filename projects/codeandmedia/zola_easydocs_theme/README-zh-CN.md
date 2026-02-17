## 为您的项目创建文档库的简便方法

演示：[https://easydocs.codeandmedia.com/](https://easydocs.codeandmedia.com/)

此主题适用于 [Zola](https://getzola.org)（静态网站引擎），帮助您轻松快速地构建和发布项目文档。Zola 是一个二进制文件，构建您用 Markdown 编写的文档后输出 html 页面和额外的静态资源。因此，您可以使用该主题、您的 md 文件和 Zola，获得一个灵活且简单的文档网站。

### 逐步指南

如您所知，Zola 非常灵活 :) 下面的方案只是众多实现方式中的一种，欢迎自由探索最佳方案。此外，Zola 提供了自己的主题安装和使用机制，详见[文档](https://www.getzola.org/documentation/themes/installing-and-using-themes/)。

1. Fork 仓库并用您的内容替换 content 文件夹内的 demo-content。但请查看 _index.md 文件。它包含 `title`，如果您想让标题右侧出现锚点，请在每个 index 中添加 `insert_anchor_links = "right"`。`theme.toml`、截图和 readme 文件也可以删除。
2. 在 `config.toml` 中修改 URL 和标题。在 extra 部分您可以指定 GitHub API 路径，用于导航栏 logo 下方的版本信息、favicon 和 logo 本身。或者如果不需要，可以删除这些行。同时，您也可以配置或启用与 Zola 相关的其他设置。[规格说明见此处](https://www.getzola.org/documentation/getting-started/configuration/)。
3. 在 sass/_variables.scss 中，您可以根据需要更改字体、颜色或背景。
4. 几乎完成。现在，您需要决定如何构建以及网站将托管在哪里。您可以本地构建后上传到某处，或者使用 GitHub Actions 构建并托管在 GitHub Pages / Netlify / CloudFlare Pages / 任意 S3 云存储中。[GitHub Pages 使用指南](https://www.getzola.org/documentation/deployment/github-pages/)。[我的示例](https://github.com/o365hq/o365hq.com/blob/main/.github/workflows/main.yml)是一个 GitHub 工作流，包含两步构建（第一步检查链接和拼写错误，第二步上传至 Azure）。[Dockerfile](https://github.com/codeandmedia/zola_docsascode_theme/blob/master/Dockerfile) 用于制作 Docker 镜像。

## 提供的配置选项

这些选项可在 [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml) 的 `extra` 部分进行配置。  
如果未设置，则行为与起始 [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml) 中的默认值相同。

- **easydocs_logo_always_clickable** 控制 logo 是否始终可点击。默认情况下，只有不在首页时 logo 才可点击。如果启用此项，首页的 logo 也将可点击，点击时实际上是刷新当前页面，因为会跳转到同一页面。
- **easydocs_uglyurls** 支持不使用 Web 服务器的离线站点。如果设置为 true，导航中的链接将生成包含完整路径和 `index.html` 的链接。此功能灵感来自 [Abridge 主题](https://www.getzola.org/themes/abridge/)。注意，此功能要求 base URL 设置为站点存储的本地文件夹路径，例如 `base_url = file:///home/user/mysite/public/`。因此该配置不可移植，只能在特定本地文件夹使用，但无需 Web 服务器即可浏览站点。
- **easydocs_heading_threshold** 控制页面中显示导航栏左侧标题的最小标题数量。默认为 5。例如，将此值设为 1 可始终在每个页面显示标题。

祝您使用文档愉快！

* _图标：[Office UI Fabric Icons](https://uifabricicons.azurewebsites.net/)_
* _复制代码按钮：[Aaron Luna](https://aaronluna.dev/blog/add-copy-button-to-code-blocks-hugo-chroma/)_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---