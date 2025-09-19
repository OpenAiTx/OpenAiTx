# Shape up 下载器

## 它是做什么的？
这是一个简单的命令行应用程序，用于下载 [Basecamp 优秀的免费 Shape Up 书籍](https://basecamp.com/shapeup)
到一个单一的、自包含的 HTML 文件中。
* 使用 base64 图片
* 使用文档内部链接
* 仅使用最少的 CSS

## 为什么会有这个项目？
这本书目前提供 HTML 格式，每章是一个文档，还有一个将所有章节合并成一个自包含文件的 PDF 文档。在阅读这本书时，我渴望能在电子书阅读器上阅读，但在 Kindle 上阅读 PDF 体验很差，将 PDF 转换为 epub 或 mobi 充其量也很不稳定。生成该 PDF 的软件将某些字符组合（例如 “tf”）合并为带连字的单一 UTF-8 代码点。这却使大多数转换软件出现问题。

因此，这个项目诞生了，用于下载并合并所有网页文档为一个无样式的自包含文件。
你不打算直接在该 HTML 格式中阅读书籍——但它可以作为进一步转换步骤的基础。

要将文件转换为更实用的格式，我推荐使用 calibre 的 `ebook-convert` 工具：




```bash
$ ebook-convert shape-up.html shape-up.epub \
    --authors "Ryan Singer" \
    --title "Shape Up: Stop Running in Circles and Ship Work that Matters" \
    --book-producer "Basecamp" \
    --publisher "Basecamp" \
    --language "en"
```
## 我可以从哪里下载这个 HTML/EPUB/MOBI 单页版本？
我不太确定托管这些文件的法律影响——因此我没有这样做。
下载代码在这里，但你必须自己使用它。

## 使用方法
### 本地 PHP

1. [安装 PHP](https://www.php.net/manual/en/install.php)
2. [安装 Composer](https://getcomposer.org/download/)
3. 运行 `php composer.phar install`（或者如果 composer 全局安装了，运行 `composer install`）
4. 运行 `php cli.php download:single-html`

这将在你当前目录下创建一个 `shape-up.html` 文件。
就是这样。

### Docker 方式

有一种方法可以完全不用处理 php。只需要安装 docker 引擎即可。

使用方法

```
docker run -it --rm -v $(pwd)/output:/app/output thej6s/shape-up-downloader

```
这将在 ./output 目录中创建一个 `shape-up.html` 文件


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---