# @343dev/optimizt

<img align="right" width="176" height="176"
     alt="Optimizt 标志：OK 手势，中指和拇指之间夹着蒙娜丽莎图像"
     src="https://raw.githubusercontent.com/343dev/optimizt/main/./docs/logo.png">

[![npm](https://img.shields.io/npm/v/@343dev/optimizt.svg)](https://www.npmjs.com/package/@343dev/optimizt)
[![Docker](https://img.shields.io/docker/v/343dev/optimizt?label=Docker)](https://hub.docker.com/r/343dev/optimizt)

**Optimizt** 是一个命令行工具，帮助为网页准备图片。

它可以有损或无损压缩 PNG、JPEG、GIF 和 SVG，并为光栅图像创建 AVIF 和 WebP 版本。

## 理由

作为前端开发者，我们必须关注图片：压缩 PNG 和 JPEG，去除无用的 SVG 部分，为现代浏览器创建 AVIF 和 WebP，等等。有一天，我们厌倦了使用一堆应用程序来完成这些工作，于是创建了一个满足我们所有需求的工具。

## 使用方法

安装：

```sh
npm install -g @343dev/optimizt
```
优化！


```sh
optimizt path/to/picture.jpg
```

## 命令行参数

- `--avif` — 创建图片的 AVIF 版本。
- `--webp` — 创建图片的 WebP 版本。
- `-f, --force` — 即使 AVIF 和 WebP 版本已存在，也重新创建。
- `-l, --lossless` — 无损优化，而非有损优化。
- `-v, --verbose` — 显示详细输出（例如跳过的文件）。
- `-c, --config` — 使用自定义配置文件代替默认配置。
- `-o, --output` — 将结果写入指定目录。
- `-p, --prefix` — 为优化后的文件名添加前缀。
- `-s, --suffix` — 为优化后的文件名添加后缀。
- `-V, --version` — 显示工具版本。
- `-h, --help` — 显示帮助信息。

## 使用示例

```bash
# optimize a single image
optimizt path/to/picture.jpg

# optimize multiple images losslessly
optimizt --lossless path/to/picture.jpg path/to/another/picture.png

# recursively create AVIF and WebP versions for all images in a directory
optimizt --avif --webp path/to/directory

# recursively optimize JPEG files in the current directory
find . -iname \*.jpg -exec optimizt {} +
```
## 有损与无损的区别

### 有损（默认）

在文件大小减小与视觉质量损失最小之间提供最佳平衡。

### 无损（`--lossless` 标志）

- **AVIF/WebP**：使用无损压缩。
- **PNG/JPEG/GIF**：在牺牲文件大小的情况下最大化图像质量。
- **SVG**：两种模式下设置相同。

## 配置

图像处理利用：

- [sharp](https://github.com/lovell/sharp) 处理 [JPEG](https://sharp.pixelplumbing.com/api-output#jpeg)、[PNG](https://sharp.pixelplumbing.com/api-output#png)、[WebP](https://sharp.pixelplumbing.com/api-output#webp) 和 [AVIF](https://sharp.pixelplumbing.com/api-output#avif)。
- [svgo](https://github.com/svg/svgo) 处理 SVG。
- [gifsicle](https://github.com/kohler/gifsicle) 处理 GIF。

> [!注意]
> JPEG 的无损模式使用 [Guetzli](https://github.com/google/guetzli)。重复优化可能会降低视觉质量。

默认设置定义在 [.optimiztrc.cjs](./.optimiztrc.cjs) 中，包含所有支持的参数。可通过将参数设置为 `false` 来禁用。

使用 `--config path/to/.optimiztrc.cjs` 时，将使用指定的配置文件。若未提供 `--config`，Optimizt 会从当前目录向上递归查找 `.optimiztrc.cjs`。若未找到，则应用默认设置。

## 故障排除

### 出现 “spawn guetzli ENOENT” 错误。

确保禁用了 [ignore-scripts](https://docs.npmjs.com/cli/v6/using-npm/config#ignore-scripts) npm 选项。
详情见：[funbox/optimizt/issues/9](https://github.com/funbox/optimizt/issues/9)。

## Docker

### 预构建镜像


```bash
# pull latest
docker pull 343dev/optimizt

# pull specific version
docker pull 343dev/optimizt:9.0.2
```

### 手动构建

```bash
# clone repository
git clone https://github.com/343dev/optimizt.git
cd optimizt

# build image
docker build --tag 343dev/optimizt .
```

或者：

```bash
# build directly from GitHub
# ignores .dockerignore (see: https://github.com/docker/cli/issues/2827)
docker build --tag 343dev/optimizt https://github.com/343dev/optimizt.git
```

### 运行容器

```bash
# mount current directory to /src in the container
docker run --rm --volume $(pwd):/src 343dev/optimizt --webp ./image.png
```

## 集成

Optimizt 无缝支持：

- [JetBrains IDEs](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/jetbrains.md)
- [Visual Studio Code](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/vscode.md)
- [Sublime Text 3](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/sublime-text.md)
- [GitHub Actions 工作流](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/github.md)

## 文章

- [anuwong.com](https://anuwong.com/blog/2023-08-21-save-tons-of-gbs-with-optimizt/) — 上传前压缩文件，节省大量 GB。 🇹🇭
- [Linux Format，第 277 期（2021 年 7 月）](https://www.linuxformat.com/archives?issue=277#:~:text=Kitchen%20Tales%2C%20zFRAG%2C-,Optimizt,-and%20SingleFileZ.) — Optimizt 是减少图像磁盘占用且无质量损失的理想选择。

## 致谢

项目的可爱图片由 [Igor Garybaldi](http://pandabanda.com/) 制作。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---