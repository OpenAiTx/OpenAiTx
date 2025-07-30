<h1 align="center">
  <a href="https://github.com/tbruno25/can-explorer">
    <!-- 请在此处提供您的徽标路径 -->
    <img src="https://github.com/Tbruno25/can-explorer/raw/main/docs/images/logo.png" alt="Logo" width="200" height="200">
  </a>
</h1>

<div align="center">
  can-explorer
  <br />
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=bug&template=01_BUG_REPORT.md&title=bug%3A+">报告错误</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=enhancement&template=02_FEATURE_REQUEST.md&title=feature%3A+">请求功能</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+">提问</a>
</div>

<div align="center">
<br/>


[![PyPI version](https://img.shields.io/pypi/v/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Python Versions](https://img.shields.io/pypi/pyversions/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Stars](https://img.shields.io/github/stars/tbruno25/can-explorer?color=mediumseagreen)](https://github.com/Tbruno25/can-explorer/stargazers)
</div>

---

## 关于

`can-explorer` 是一款用于 CAN 总线可视化的工具，旨在辅助逆向工程。

![演示](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/demo.gif)

### 这对我有什么帮助？
通过持续绘制每个 CAN ID 的所有负载，识别与特定动作对应的趋势将变得显著更容易。

请参考我之前写的这篇[文章](https://tbruno25.medium.com/car-hacking-faster-reverse-engineering-using-canopy-be1955843d57)，其中有一个如何使用该方法找到包含速度表数据的 ID 的实际示例。

### 构建工具


[![DearPyGui](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/dearpygui-logo.png)](https://github.com/hoffstadt/DearPyGui)
[![PythonCan](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/pythoncan-logo.png)](https://github.com/hardbyte/python-can)

## 入门

### 安装

推荐使用 [pipx](https://pypa.github.io/pipx/)，但任何支持 `pyproject.toml` 文件的包管理器都可以使用。


```sh
pipx install can-explorer
``` 

## 使用方法

可以通过在终端运行以下任一命令来启动图形界面。
```sh 
can-explorer
``` 

```sh 
python3 -m can_explorer
``` 
在启动查看器之前，您***必须***导航到设置标签并输入您的接口适配器配置以创建总线实例。有关支持的各种接口的更多信息，请参阅[python-can 文档](https://python-can.readthedocs.io/en/stable/index.html)。

该图形界面还可以通过演示标志启动，该标志将自动选择虚拟接口选项并在后台进程中开始流式传输模拟的 CAN 数据。


```sh 
can-explorer --demo
``` 
## 支持

请通过以下途径联系维护者：
- [GitHub 问题](https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+)
- 在[此 GitHub 个人资料](https://github.com/tbruno25)中列出的联系方式

如果您想说声**谢谢**和/或支持 can-explorer 的积极开发，请考虑为该项目添加一个[GitHub Star](https://github.com/tbruno25/can-explorer)。


## 贡献

请阅读[我们的贡献指南](https://raw.githubusercontent.com/Tbruno25/can-explorer/main/docs/CONTRIBUTING.md)

有关所有作者和贡献者的完整列表，请参见[贡献者页面](https://github.com/tbruno25/can-explorer/contributors)。

## 许可证

本项目采用**GNU 通用公共许可证 v3**授权。

详见[LICENSE](LICENSE)获取更多信息。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---