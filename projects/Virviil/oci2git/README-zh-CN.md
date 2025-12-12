
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![文档](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![许可证](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![下载量](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock for future test.yaml)
[//]: # ([![测试状态]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

一个将容器镜像（如 Docker 等）转换为 Git 仓库的 Rust 应用程序。每个容器层都表示为一个 Git 提交，保留了原始镜像的历史和结构。

![OCI2Git 转换 nginx 镜像的演示](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 功能特性

- 分析 Docker 镜像并提取层信息
- 创建一个每个镜像层都作为提交的 Git 仓库
- 支持空层（ENV、WORKDIR 等）作为空提交
- 完整元数据提取并转为 Markdown 格式
- 可扩展架构以支持不同的容器引擎

## 应用场景

### 层间差异分析
在容器故障排查时，可以利用 Git 强大的差异分析功能，精确识别任意两层之间发生了什么变化。通过在提交间运行 `git diff`，工程师可以清楚看到哪些文件被添加、修改或删除，从而更容易理解每条 Dockerfile 指令的影响并定位有问题的变更。
![层差异示例](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### 源头追踪
使用 `git blame`，开发者可以快速确定是哪个层引入了特定文件或代码行。这在诊断配置文件或依赖项问题时尤其有价值。无需手动检查每个层，您可以立即追溯任意文件的来源层及其对应的 Dockerfile 指令。

### 文件生命周期追踪
OCI2Git 让您能够跟踪特定文件在容器镜像历史中的演变过程。可以观察文件最初创建时间、在各层中的修改情况，以及最终是否被删除。这种全面视角有助于理解文件的演化，无需手动在可能多达数十层间逐步检查变更。

要追踪容器镜像中特定文件的历史——包括首次出现、变更和删除时间——在转换后可以使用以下 Git 命令：

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
这些命令使得追踪任意文件在容器层之间的完整历史变得简单，无需手动提取和比较层的 tar 包的复杂操作。

### 多层分析
有时，最有洞察力的比较来自于检查多个非连续层之间的变化。使用 OCI2Git，您可以利用 Git 的比较工具分析组件在多个构建阶段的演变，识别仅通过观察相邻层无法发现的模式。

### 层探索
通过使用 `git checkout` 切换到任意特定提交，您可以检查容器文件系统在该层的确切状态。这样开发者就能在镜像创建过程中的任意时点检查文件和目录的精确状态，在调试或分析容器行为时提供宝贵的上下文。
![切换到先前提交](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### 多镜像分析

在处理具有共同祖先的多个容器镜像时，OCI2Git 仅在镜像实际分叉时智能创建分支。这样，您可以在单一仓库中分析多个相关镜像，同时保留它们的共同历史。


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git 会自动检测镜像之间共享的层，并创建一个反映它们共同基础的分支结构。Git 历史将显示：
- 包含所有共享层的公共主干
- 仅在镜像实际不同的时候分叉的独立分支
- 清晰地展示镜像共享共同祖先的位置以及何处变得独特
- 智能重复处理：如果完全相同的镜像被处理两次，算法会在最终元数据提交之前检测到这一点并跳过创建重复分支

这种方法尤其适用于：
- **镜像家族分析**：理解不同变体镜像（不同版本、架构或配置）之间的关系
- **基础镜像影响**：准确查看基础镜像的更改如何影响多个派生镜像
- **优化机会**：识别可以在镜像变体之间更好利用的共享组件

![多镜像仓库结构，显示共享基础和分叉分支](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### 其他使用场景

- **安全审计**：准确识别易受攻击的软件包或配置何时引入，并追溯到具体的构建指令。
- **镜像优化**：分析层结构，发现冗余操作或可合并的大文件，帮助减小镜像体积。
- **依赖管理**：监控依赖何时被添加、升级或移除，贯穿整个镜像历史。
- **构建过程改进**：检查层组成，优化 Dockerfile 指令以实现更好的缓存和更小的镜像大小。
- **跨镜像对比**：将多个相关镜像转换为 Git 仓库，利用 Git 的对比工具分析它们的差异和共性。

## 安装

### 从源码安装


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### 来自 Crates.io

```bash
cargo install oci2git
```

## 用法

```bash
oci2git [OPTIONS] <IMAGE>
```

Arguments:
  `<IMAGE>`  要转换的镜像名称（例如，'ubuntu:latest'）或使用 tar 引擎时的 tar 包路径

Options:
  `-o, --output <o>`  Git 仓库输出目录 [默认值: ./container_repo]
  `-e, --engine <ENGINE>`  使用的容器引擎（docker、nerdctl、tar）[默认值: docker]
  `-h, --help`            打印帮助信息
  `-V, --version`         打印版本信息

Environment Variables:
  `TMPDIR`  设置此环境变量以更改用于中间数据处理的默认位置。此位置依赖于平台（例如，Unix/macOS 上的 `TMPDIR`，Windows 上的 `TEMP` 或 `TMP`）。

## Examples

使用 Docker 引擎（默认）：
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

使用已下载的镜像 tar 包：
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

tar 引擎期望一个有效的 OCI 格式 tar 包，通常使用 `docker save` 创建：
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```
这将在 `./ubuntu-repo` 中创建一个 Git 仓库，包含：
- `Image.md` - 以 Markdown 格式完整描述镜像的元数据
- `rootfs/` - 来自容器的文件系统内容

Git 历史反映了容器的层历史：
- 第一次提交仅包含带有完整元数据的 `Image.md` 文件
- 之后的每次提交代表原始镜像的一个层
- 提交包含 Dockerfile 命令作为提交信息

## 仓库结构


```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## 要求

- Rust 2021 版本
- Docker CLI（用于 Docker 引擎支持）
- Git

## 许可证

MIT

[文档]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-12

---