Bitcoin Core 集成/暂存树
=======================

https://bitcoincore.org

如需立即可用的 Bitcoin Core 软件二进制版本，请参见  
https://bitcoincore.org/en/download/。

什么是 Bitcoin Core？
---------------------

Bitcoin Core 连接到比特币点对点网络，以下载并完全验证区块和交易。它还包含一个钱包和图形用户界面，可根据需要选择性构建。

有关 Bitcoin Core 的更多信息，请参见 [doc 文件夹](/doc)。

许可证
-------

Bitcoin Core 根据 MIT 许可证条款发布。详情请参见 [COPYING](COPYING) 或访问 https://opensource.org/license/MIT。

开发流程
--------

`master` 分支会定期构建（构建说明请参见 `doc/build-*.md`），并进行测试，但不能保证完全稳定。[标签](https://github.com/bitcoin/bitcoin/tags) 会定期从发布分支创建，用以标示 Bitcoin Core 的新官方稳定版本。

https://github.com/bitcoin-core/gui 仓库专用于 GUI 的开发。其 master 分支在所有单树仓库中都是一致的。不存在发布分支和标签，因此请不要分叉该仓库，除非是出于开发目的。

贡献工作流程详见 [CONTRIBUTING.md](CONTRIBUTING.md)，开发者可在 [doc/developer-notes.md](doc/developer-notes.md) 中找到有用的提示。

测试
----

测试和代码审查是开发的瓶颈；我们收到的拉取请求比我们能在短时间内审查和测试的要多。请耐心等待，并通过测试他人的拉取请求来提供帮助，同时记住这是一个安全关键项目，任何错误都可能导致他人损失大量资金。

### 自动化测试

强烈建议开发者为新代码编写[单元测试](src/test/README.md)，并为旧代码提交新的单元测试。单元测试可编译并运行（假设在生成构建系统时未禁用），命令为：`ctest`。有关运行和扩展单元测试的更多细节，请参见 [/src/test/README.md](/src/test/README.md)。

此外还有[回归和集成测试](/test)，使用 Python 编写。  
如已安装[测试依赖项](/test)，可通过以下命令运行这些测试：`build/test/functional/test_runner.py`  
（假设 `build` 是你的构建目录）。

CI（持续集成）系统确保每个拉取请求都能为 Windows、Linux 和 macOS 构建，并自动运行单元/健全性测试。

### 手动质量保证（QA）测试

更改应由编写代码的开发者以外的人员进行测试。对于大型或高风险更改，这一点尤为重要。如果更改的测试不是很直观，建议在拉取请求描述中添加测试计划。

翻译
----

翻译的更改以及新翻译可提交至  
[Bitcoin Core 的 Transifex 页面](https://www.transifex.com/bitcoin/bitcoin/)。

翻译会定期从 Transifex 拉取并合并到 git 仓库中。有关详细流程，请参见 [translation process](doc/translation_process.md)。

**重要提示**：我们不接受以 GitHub 拉取请求方式提交的翻译更改，因为下次从 Transifex 拉取时会自动覆盖这些更改。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---