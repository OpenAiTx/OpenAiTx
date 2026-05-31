<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou-dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg">
  <img alt="Piou logo"
    src="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg"
    width="250"/>
</picture>

# Piou

[![Python versions](https://img.shields.io/pypi/pyversions/piou)](https://pypi.python.org/pypi/piou)
[![Latest PyPI version](https://img.shields.io/pypi/v/piou?logo=pypi)](https://pypi.python.org/pypi/piou)
[![CI](https://github.com/Andarius/piou/actions/workflows/ci.yml/badge.svg)](https://github.com/Andarius/piou/actions/workflows/ci.yml)
[![Latest conda-forge version](https://img.shields.io/conda/vn/conda-forge/piou?logo=conda-forge)](https://anaconda.org/conda-forge/piou)

一个用于构建带有类型验证的美观命令行界面的CLI工具。

## 快速示例

```python
from piou import Cli, Option

cli = Cli(description='A CLI tool')


@cli.command(cmd='foo', help='Run foo command')
def foo_main(
        bar: int = Option(help='Bar positional argument (required)'),
        baz: str = Option('-b', '--baz', help='Baz keyword argument (required)'),
        foo: str | None = Option(None, '--foo', help='Foo keyword argument'),
):
    """
    A longer description on what the function is doing.
    """
    pass


if __name__ == '__main__':
    cli.run()
```

![example](https://github.com/Andarius/piou/raw/master/docs/static/simple-output.svg)

## Installation

```bash
pip install piou
```
或者使用 [uv](https://docs.astral.sh/uv/):


```bash
uv add piou
```

或者使用 [conda](https://docs.conda.io/):

```bash
conda install piou -c conda-forge
```

### 原始格式化器

默认情况下，Piou 使用 [Rich](https://github.com/Textualize/rich) 来实现美观的终端输出。 如果您更喜欢纯文本输出，可以使用原始格式化器：

```bash
# Force raw output via environment variable
PIOU_FORMATTER=raw python your_cli.py --help
```

## 文档

完整文档可在 **[andarius.github.io/piou](https://andarius.github.io/piou)** 获取。

### 功能

- 类似 FastAPI 的开发者体验，支持类型提示
- 自定义格式化器（默认基于 Rich）
- 嵌套命令组 / 子命令
- 派生选项用于可复用参数模式
- 支持异步命令
- 类型验证与转换
- **交互式 TUI 模式**，带命令建议和历史记录
- **结构化 JSON 帮助**（`--help-json`），便于工具和程序化 CLI 发现

## 为什么选择 Piou？

我找不到一个库能提供：

- 与 [FastAPI](https://fastapi.tiangolo.com/) 相同的开发者体验
- 界面自定义（构建类似 [Poetry](https://python-poetry.org/) 的 CLI）
- 类型验证 / 转换

[Typer](https://github.com/tiangolo/typer) 是最接近的替代品，但缺乏使用外部库（如 [Rich](https://github.com/Textualize/rich)）自定义输出格式的能力。

**Piou** 提供了所有这些功能，并允许你定义自己的格式化器。

## 异步命令

命令可以是 `async` 函数 — piou 会自动检测协程并运行，无需手动调用 `asyncio.run()`：

```python
from piou import Cli, Option

cli = Cli(description='Async example')

@cli.command(cmd='fetch', help='Fetch data')
async def fetch(url: str = Option(help='URL to fetch')):
    import niquests
    async with niquests.AsyncSession() as client:
        r = await client.get(url)
        print(r.status_code)

if __name__ == '__main__':
    cli.run()
```
这对于命令组内的命令同样适用。

## 交互式 TUI 模式

Piou 包含一个可选的交互式 TUI（文本用户界面）模式，由 [Textual](https://textual.textualize.io/) 提供支持。  
这提供了丰富的终端体验，包括命令建议、历史记录和内联补全。

### 安装


```bash
pip install piou[tui]

# With auto-reload support for development
pip install piou[tui-reload]
```

### 使用方法

通过在创建命令行界面时设置 `tui=True` 来启用 TUI 模式：

```python
from piou import Cli, Option

cli = Cli(description='My Interactive CLI', tui=True)

@cli.command(cmd='hello', help='Say hello')
def hello(name: str = Option(..., help='Name to greet')):
    print(f'Hello, {name}!')

if __name__ == '__main__':
    cli.run()
```

或者通过 `--tui` 标志：

```bash
python my_cli.py --tui
```
或者通过设置环境变量 `PIOU_TUI=1`：


```bash
PIOU_TUI=1 python my_cli.py
```

### TUI 功能

- **命令建议**：输入 `/` 查看可用命令及其描述
- **子命令导航**：使用 `:` 导航子命令（例如 `/stats:uploads`）
- **内联补全**：输入时显示参数占位符
- **命令历史**：使用上下箭头浏览历史命令（跨会话保存）
- **丰富输出**：输出中保留 ANSI 颜色和格式
- **键盘快捷键**：
  - `Tab` - 确认选中的建议
  - `上/下` - 浏览建议或历史
  - `Ctrl+C` - 清除输入（按两次退出）
  - `Esc` - 退出
- **开发模式**：源文件更改时自动重载命令（见下文）

<img alt="TUI Demo" src="https://github.com/Andarius/piou/raw/master/docs/static/tui-demo.gif" width="600"/>

### 带自动重载的开发模式

为加快开发迭代，启用开发模式以在源文件更改时自动重载命令：

```bash
pip install piou[tui-reload]
```

然后使用 `--tui-reload` 标志：

```bash
python my_cli.py --tui-reload
```
或通过环境变量：


```bash
PIOU_TUI_DEV=1 python my_cli.py --tui
```
启用后，Piou 会监视您的命令源文件并在保存时热重载它们。您还可以通过 `/tui-reload` 命令在运行时切换重载模式。

要在每次重载后运行自定义代码（例如，刷新缓存数据），请使用 `@cli.tui_on_reload` 装饰器：


```python
@cli.tui_on_reload
def on_reload():
    print('Code reloaded!')
```

### 高级示例：HTTP 基准测试

TUI 模式支持挂载自定义 Textual 小部件以实现丰富的交互式显示。此示例使用实时进度网格对 HTTP 库进行基准测试：

<img alt="HTTP Benchmark TUI" src="https://github.com/Andarius/piou/raw/master/docs/static/bench_1000.gif" width="700"/>

完整实现请参见 [examples/http_bench_tui.py](https://raw.githubusercontent.com/Andarius/piou/master/examples/http_bench_tui.py)，使用了 `TuiContext` 和自定义小部件。

## 开发

### 运行测试

```bash
uv run pytest
```

### 生成文档

```bash
# Build docs
uv run --group docs mkdocs build

# Serve locally
uv run --group docs mkdocs serve
```

### 生成截图和 GIF

终端录制使用 [VHS](https://github.com/charmbracelet/vhs) 创建。请先安装它：

```bash
# Ubuntu/Debian
sudo apt install vhs ttyd

# macOS
brew install vhs

# Or via Go
go install github.com/charmbracelet/vhs@latest
```

然后从磁带文件生成录音：

```bash
vhs docs/static/tui-demo.tape
```

磁带文件位于 `docs/static/` 中，定义了生成 GIF 的脚本化终端会话。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---