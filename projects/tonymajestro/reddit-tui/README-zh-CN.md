# Reddittui
一个轻量级的终端应用程序，用于从命令行浏览 Reddit。由 [bubbletea](https://github.com/charmbracelet/bubbletea) 提供支持

## 功能
- **子版块浏览:** 浏览你喜欢的子版块。
- **帖子查看:** 阅读文本帖子和评论。
- **键盘导航:** 使用 vim/标准键盘快捷键滚动和选择帖子。
- **可配置:** 通过配置文件自定义缓存行为和定义子版块过滤器

## 演示
https://github.com/user-attachments/assets/40d61ef3-3a95-4a26-8c49-bec616f6ae1c

## 安装

### Git
#### 前提条件
- **Git**
- **Go:** 版本 1.16 或更高
- **终端:** 类 Unix 终端（Linux、macOS 或类似系统）。
- **POSIX 工具:** 安装过程中使用了 `install` 命令，该命令在 Linux 和 macOS 上均可用。

克隆仓库并运行安装脚本： 

```bash
git clone https://github.com/tonymajestro/reddit-tui.git reddittui
cd reddittui
./install.sh
```
要移除 reddittui，请运行卸载脚本：


```bash
./uninstall.sh
```

### Arch
Arch 用户可以使用 yay 或其他 AUR 助手从 AUR 安装 reddittui。

提供了[预编译包](https://aur.archlinux.org/packages/reddit-tui-bin)和[源码包](https://aur.archlinux.org/packages/reddit-tui)。

```bash
yay -S reddit-tui-bin
```

```bash
yay -S reddit-tui
```

### Nix
Nix 用户可以在 shell 中尝试，或像这样将其添加到系统配置中。
```bash
nix-shell -p reddit-tui
```
```nix
  environment.systemPackages = [
      pkgs.reddit-tui
    ];
```

## 使用方法
从您喜欢的终端运行已安装的二进制文件：

```bash
# Open reddittui, navigating to the home page
reddittui

# Open reddittui, navigating to a specific subreddit
reddittui --subreddit dogs

# Open reddittui, navigating to a specific post by its ID
reddittui --post 1iyuce4
```
## 快捷键绑定
- 导航
  - **h, j, k, l:** Vim 风格移动
  - **left, right, up, down:** 普通移动
  - **g**: 跳转到页面顶部
  - **G**: 跳转到页面底部
  - **s**: 切换子版块
- 帖子页面
  - **L**: 加载更多帖子
- 评论页面
  - **o**: 在浏览器中打开帖子链接
  - **c**: 折叠评论
- 其他
  - **H:** 返回首页
  - **backspace**: 返回上一页
  - **q, esc**: 退出 reddittui

## 配置文件
运行 reddittui 可执行文件后，会初始化以下文件：
- 配置文件：
  - `~/.config/reddittui/reddittui.toml`
- 日志文件：
  - `~/.local/state/reddittui.log`
- 缓存
  - `~/.cache/reddittui/`

示例配置：

```toml
# Core configuration
[core]
bypassCache = false
logLevel = "Warn"

# Filter out posts containing keywords or belonging to certain subreddits
[filter]
subreddits = ["news", "politics"]
keywords = ["pizza", "pineapple"]

# Configure client timeout and cache TTL. By default, subreddit posts and comments are cached for 1 hour.
[client]
timeoutSeconds = 10
cacheTtlSeconds = 3600

# Configure which reddit server to use. Default is old.reddit.com but redlib servers are also supported
[server]
domain = "old.reddit.com"
type = "old"
```

## Redlib
为了增强隐私，支持私有的 [Redlib 后端](https://github.com/redlib-org/redlib)。Redlib 服务器列表可在 [这里](https://github.com/redlib-org/redlib-instances/blob/main/instances.json) 找到。使用以下配置以使用 Redlib 服务器代替 old.reddit.com：

```toml
[server]
domain = "safereddit.com"
type = "redlib"
```

## 致谢
Reddittui 基于 [bubbletea](https://github.com/charmbracelet/bubbletea) 框架。它还借鉴了黑客新闻终端浏览器 [circumflex](https://github.com/bensadeh/circumflex) 的灵感。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---