# Fava 投资者

Fava 投资者旨在为[Beancount](https://beancount.github.io/)和
[Fava](https://github.com/beancount/fava)（用于
[纯文本复式记账](https://plaintextaccounting.org/)的软件）提供一套全面的投资报告、分析和工具。它作为一组模块开发，每个模块提供一个*Fava 插件、一个 Beancount 库和一个命令行工具*。

### 当前模块：
- [按类别的可视化树状资产配置](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/assetalloc_class#readme)
- 按账户的资产配置
- [税损收割工具](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/tlh#readme)
- [现金拖累分析](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/cashdrag#readme)
- [摘要器](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/summarizer#readme)
- [收益最小化器](https://github.com/redstreet/fava_investor/blob/main/fava_investor/modules/minimizegains#readme)

### 演示
***在 [pythonanywhere](http://favainvestor.pythonanywhere.com/example-beancount-file/extension/Investor/) 上体验实时演示。***


#### 截图（日期）：
![截图：税损收割](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot.png)
![截图：资产配置](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot-assetalloc.png)

### 工具集

Fava 投资者附带 `ticker-util`，这是一组用于：
- 从雅虎下载商品（代码）信息，并为您的商品声明添加元数据注释
- 发现 Beancount 文件中代码之间的关系，如等价和实质相同代码，以及税损收割合作组，基于最小且不完整的规范
- 为您的导入器提供 ISIN 及其他代码识别信息

更多内容，请通过 pip 安装 fava_investor，然后查看：







```
ticker-util --help
ticker-util relate --help
```


## 安装
```bash
pip3 install fava-investor
```

或者从 git 安装最新的开发版本：
```bash
pip3 install git+https://github.com/redstreet/fava_investor
```
请参见 [#55](https://github.com/redstreet/fava_investor/issues/55) 了解 MacOS 安装。

请注意，最新版本的 Fava Investor 兼容 Beancount v2 和 v3。

## 运行 Fava Investor
### 在 Fava 中运行：
将此添加到您的 beancount 源文件中，然后像往常一样启动 fava：
```
2000-01-01 custom "fava-extension" "fava_investor" "{}"
```
你现在应该能在 fava 的侧边栏中看到一个“Investor”链接。有关如何配置该扩展的更多信息，请参阅附带的 `huge-example.beancount`。

### 命令行运行：
命令行界面（CLI）通过 `investor` 命令访问，该命令为每个模块提供子命令。例如：




```
investor assetalloc-class
investor tlh
investor --help
```

Both the CLI and the utility (`ticker-util`) use [click](https://click.palletsprojects.com/en/8.1.x/).
[参见这里](https://click.palletsprojects.com/en/8.1.x/shell-completion/#enabling-completion)
以启用 zsh、bash 或 fish 的 shell 补全，强烈推荐使用。

## 遇到问题？
- 监视运行 fava 的终端，查看 fava_investor 的错误输出
- 在提交错误报告或寻求帮助时，请包含上述错误信息

## 贡献指南

欢迎功能、修复和改进。请记住：
- 欢迎提交拉取请求。请包含单元测试
- 对于较大改动或可能需要讨论的更改，请先联系讨论以节省时间（打开 issue）
- 请合理合并您的提交
- 提交信息请使用 [conventional commits](https://www.conventionalcommits.org/en/v1.0.0/)

感谢您的贡献！

## 相关项目
- [Fava Dashboards](https://github.com/andreasgerstmayr/fava-dashboards)
- [Fava Portfolio Returns](https://github.com/andreasgerstmayr/fava-portfolio-returns)
- [Beangrow](https://github.com/beancount/beangrow)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---