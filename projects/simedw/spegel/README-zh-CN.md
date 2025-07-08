# Spegel – 通过 AI 反映网页

自动将网站重写为适合在终端查看的 Markdown 格式。
阅读介绍博客文章 [这里](https://simedw.com/2025/06/23/introducing-spegel/)

这是一个概念验证项目，可能存在一些 bug，欢迎提出 issue 或 pull request。

## 截图
有时候你并不想读完某人的人生故事，只是想直接看到菜谱
![菜谱示例](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)

## 安装

需要 Python 3.11 及以上版本

```
pip install spegel
```
或者克隆仓库并以可编辑模式安装

```bash
# 克隆并进入目录
$ git clone <repo-url>
$ cd spegel

# 安装依赖和 CLI
$ pip install -e .
```

## API 密钥
Spegel 目前仅支持 Gemini 2.5 Flash，要使用它需要在环境变量中提供你的 API 密钥

```
GEMINI_API_KEY=...
```

## 使用方法

### 启动浏览器

```bash
spegel                # 启动欢迎界面
spegel bbc.com        # 直接打开一个 URL
```

或者，同等方式：

```bash
python -m spegel      # 启动欢迎界面
python -m spegel bbc.com
```

### 基本操作
- `/`         – 打开 URL 输入
- `Tab`/`Shift+Tab` – 循环切换链接
- `Enter`     – 打开选中的链接
- `e`         – 编辑当前视图的 LLM 提示词
- `b`         – 返回
- `q`         – 退出

## 编辑设置

Spegel 从 TOML 配置文件加载设置。你可以自定义视图、提示词和界面选项。

**配置文件查找顺序：**
1. `./.spegel.toml`（当前目录）
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

要编辑设置：
1. 复制示例配置：
   ```bash
   cp example_config.toml .spegel.toml
   # 或创建 ~/.spegel.toml
   ```
2. 用你喜欢的编辑器编辑 `.spegel.toml`。

示例片段：
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

更多信息请参阅源码或提交 issue！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---