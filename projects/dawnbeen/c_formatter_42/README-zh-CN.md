<p align="center">
  <a style="text-decoration:none" href="https://badge.fury.io/py/c-formatter-42"><img src="https://badge.fury.io/py/c-formatter-42.svg" alt="PyPI version" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-package.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-publish.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://pypi.org/project/c-formatter-42/"><img src="https://img.shields.io/pypi/pyversions/c-formatter-42" height="20"></a>
</p>

<br />

<p align="center">
  <img width="65%" align="center" src="https://raw.githubusercontent.com/dawnbeen/c_formatter_42/master/./img/final_back.png">
</p>

# c_formatter_42

符合42规范v3的C语言代码美化工具。
我知道你已经是个优秀的人类规范执行者。
这只是为了方便。

## 安装

需要Python3.8+（3.9、3.10、3.11、3.12）

### 从PyPI安装

```sh
pip3 install c-formatter-42
pip3 install --user c-formatter-42  # If you don't have root privileges
```
如果你使用的是 Ubuntu 22.04 或更新版本（或任何启用了 PEP 668 的基于 Debian 的系统），你可能会看到类似的错误：

`error: externally-managed-environment`

要解决此问题，请添加 `--break-system-packages` 标志：


```sh
pip3 install --break-system-packages c-formatter-42
```
### 来自源头


```sh
git clone https://github.com/cacharle/c_formatter_42
cd c_formatter_42
pip3 install -e .
```


## 使用方法

### 命令行


```sh
c_formatter_42 < file.c
python3 -m c_formatter_42 < file.c  # If you get 'command not found' with the previous one

c_formatter_42 --help
usage: c_formatter_42 [-h] [-c] [FILE [FILE ...]]

Format C source according to the norm

positional arguments:
  FILE           File to format inplace, if no file is provided read STDIN

optional arguments:
  -h, --help     show this help message and exit
  -c, --confirm  Ask confirmation before overwriting any file
```
## 插件 / 扩展

### Vim

查看 [`c_formatter_42.vim`](https://github.com/cacharle/c_formatter_42.vim) 插件。该插件使用 pip 自动安装 `c_formatter_42` 包。

### Visual Studio Code

1. 安装 `c_formatter_42`
1. 安装 [`keyhr.42-c-format`](https://marketplace.visualstudio.com/items?itemName=keyhr.42-c-format) 扩展
1. 在 `.vscode/settings.json` 中将 `keyhr.42-c-format` 设置为 C 文件的默认格式化工具


```json
{
  "[c]": {
    "editor.defaultFormatter": "keyhr.42-c-format"
  }
}
```
## 贡献

欢迎随时报告问题或贡献代码。:)

### 运行测试


```sh
pip3 install tox
tox
tox -e py311  # for a specific python version
```
### 部署新版本


```sh
pip3 install bumpversion
bumpversion [major|minor|patch]
git push
git push --tags
```


访问：<https://github.com/dawnbeen/c_formatter_42/tags> 并点击你刚创建的标签。  
然后点击 `Create release from tag`，流水线将为你构建并部署该版本。  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---