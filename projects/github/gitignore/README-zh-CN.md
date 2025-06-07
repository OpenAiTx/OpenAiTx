# `.gitignore` 模板集合

这是 GitHub 的 [`.gitignore`][man] 文件模板集合。我们使用此列表来填充 GitHub.com 界面在创建新仓库和文件时可用的 `.gitignore` 模板选择器。

关于 `.gitignore` 文件的工作原理及使用方法，以下资源是很好的入门参考：

- [Pro Git][progit] 书籍中的 [忽略文件章节][chapter]。
- GitHub 帮助网站上的 [忽略文件文章][help]。
- [gitignore(5)][man] 手册页。

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## 文件夹结构

我们支持一系列模板，组织方式如下：

- 根目录包含常用的模板，帮助用户快速开始流行的编程语言和技术。这些模板定义了一组有意义的规则，帮助你起步，并确保不会将不重要的文件提交到仓库中。
- [`Global`](./Global) 目录包含可用于不同场景的各种编辑器、工具和操作系统的模板。建议你 [将这些模板添加到全局模板](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)，或将这些规则合并到你的项目专用模板中（如果你希望永久使用它们）。
- [`community`](./community) 目录包含其他流行语言、工具和项目的专用模板，这些模板目前不属于主流模板。当你决定采用某个框架或工具时，应将这些模板添加到你的项目专用模板中。

## 优秀模板的标准

一个模板应包含一组规则，帮助 Git 仓库与特定的编程语言、框架、工具或环境协同工作。

如果无法为该场景整理出一小组有用的规则，那么该模板就不适合收录到本集合中。

如果一个模板主要是某个软件特定版本安装的文件列表（如某个 PHP 框架），它可以放在 `community` 目录下。详见 [有版本区分的模板](#versioned-templates)。

如果你有一组较小的规则，或者想支持一种尚未广泛使用的技术，且认为这会对他人有帮助，请阅读 [专用模板](#specialized-templates) 部分了解详细信息。

如果你的模板很重要且具有可见性，请在提交 Pull Request 时注明细节。我们可能不会立即接受，但可以根据需求将其提升到根目录。

同时请理解，我们无法收录所有曾经存在过的工具。我们的目标是精选_最常用且最有帮助_的模板，而不是覆盖所有可能的项目。如果我们未收录你的语言、工具或项目，并不是因为它不好。

## 贡献指南

我们非常欢迎你帮助我们改进本项目。为保持此集合的高质量，建议贡献遵循以下准则。

- **提供应用或项目主页的链接**。除非它极为流行，否则维护者可能不了解或未使用你的更改涉及的语言、框架、编辑器、应用或项目。

- **提供支持你更改的文档链接**。以当前、权威的文档中提及被忽略的文件为最佳。如果没有相关文档，请尽量解释被忽略文件的用途。

- **解释你更改的原因**。即使理由很明显，也请用一句或两句话说明为什么应进行此更改或添加。特别建议说明该更改为何适用于_所有_使用该技术的开发者，而不仅仅是你或你的团队。

- **请考虑更改的适用范围**。如果你的更改只针对某种语言或框架，请确保只修改该语言或框架的模板，而不是编辑器、工具或操作系统的模板。

- **每次 Pull Request 只修改_一个模板_**。这样有助于聚焦于某个特定项目或技术的改动和反馈。

总之，你提供的信息越详细，我们越能快速理解并采纳你的贡献。

## 有版本区分的模板

有些模板在不同版本间变化较大，如果你想为本仓库贡献相关模板，请遵循如下流程：

- 根目录下的模板应为当前支持的版本
- 根目录下的模板文件名不应包含版本号（即为“常青版”）
- 旧版本模板应放在 `community/` 目录下
- 旧版本模板文件名应包含版本号，便于阅读

这样可以确保用户总是能获得最新版本（因为他们会使用根目录的模板），同时维护者还能支持仍在使用的旧版本。

## 专用模板

如果你有一个想要贡献但不够主流的模板，请考虑将其添加到 `community` 目录下最合适的子目录。

你的专用模板中的规则应针对特定的框架或工具，任何额外的模板都应在模板头部的注释中提及。

例如，此模板可放在 `community/DotNet/InforCRM.gitignore`：

```
# InforCRM（原 SalesLogix）的 gitignore 模板
# 网站：https://www.infor.com/product-summary/cx/infor-crm/
#
# 推荐：VisualStudio.gitignore

# 忽略自动生成的模型文件
ModelIndex.xml
ExportedFiles.xml

# 忽略部署文件
[Mm]odel/[Dd]eployment

# 强制包含门户 SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## 贡献流程

推荐你按照如下方式为本项目提出更改：

1. [Fork 本项目][fork]到你的账户。
2. [为你要进行的更改创建分支][branch]。
3. 在 Fork 的分支上进行更改。
4. 从你的分支 [发起 Pull Request][pr] 到我们的 `main` 分支。

使用网页界面进行更改也是可以的，这会自动 Fork 项目并提示你发起 Pull Request。

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## 许可证

[CC0-1.0](./LICENSE)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---