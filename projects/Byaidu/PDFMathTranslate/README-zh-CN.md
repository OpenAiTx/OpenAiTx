<div align="center">

English | [简体中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-TW.md) | [日本語](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ja-JP.md) | [한국어](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ko-KR.md)

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/banner.png" width="320px"  alt="PDF2ZH"/>

<h2 id="title">PDFMathTranslate</h2>

<p>
  <!-- PyPI -->
  <a href="https://pypi.org/project/pdf2zh/">
    <img src="https://img.shields.io/pypi/v/pdf2zh"></a>
  <a href="https://pepy.tech/projects/pdf2zh">
    <img src="https://static.pepy.tech/badge/pdf2zh"></a>
  <a href="https://hub.docker.com/r/byaidu/pdf2zh">
    <img src="https://img.shields.io/docker/pulls/byaidu/pdf2zh"></a>
  <a href="https://hellogithub.com/repository/8ec2cfd3ef744762bf531232fa32bc47" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=8ec2cfd3ef744762bf531232fa32bc47&claim_uid=JQ0yfeBNjaTuqDU&theme=small" alt="Featured｜HelloGitHub" /></a>
  <a href="https://gitcode.com/Byaidu/PDFMathTranslate/overview">
    <img src="https://gitcode.com/Byaidu/PDFMathTranslate/star/badge.svg"></a>
  <a href="https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker">
    <img src="https://img.shields.io/badge/%F0%9F%A4%97-Online%20Demo-FF9E0D"></a>
  <a href="https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate">
    <img src="https://img.shields.io/badge/ModelScope-Demo-blue"></a>
  <a href="https://github.com/Byaidu/PDFMathTranslate/pulls">
    <img src="https://img.shields.io/badge/contributions-welcome-green"></a>
  <a href="https://t.me/+Z9_SgnxmsmA5NzBl">
    <img src="https://img.shields.io/badge/Telegram-2CA5E0?style=flat-squeare&logo=telegram&logoColor=white"></a>
  <!-- License -->
  <a href="./LICENSE">
    <img src="https://img.shields.io/github/license/Byaidu/PDFMathTranslate"></a>
</p>

<a href="https://trendshift.io/repositories/12424" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12424" alt="Byaidu%2FPDFMathTranslate | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

</div>

PDF 科学论文翻译与双语对比。

- 📊 保留公式、图表、目录和注释 _([预览](#preview))_。
- 🌐 支持[多语言](#language)及多样的[翻译服务](#services)。
- 🤖 提供 [命令行工具](#usage)、[交互式用户界面](#gui) 和 [Docker](#docker)

欢迎在 [GitHub Issues](https://github.com/Byaidu/PDFMathTranslate/issues) 或 [Telegram 群组](https://t.me/+Z9_SgnxmsmA5NzBl) 提供反馈。

有关如何贡献的详细信息，请查阅 [贡献指南](https://github.com/Byaidu/PDFMathTranslate/wiki/Contribution-Guide---%E8%B4%A1%E7%8C%AE%E6%8C%87%E5%8D%97)。

<h2 id="updates">更新日志</h2>

- [2025年5月9日] pdf2zh 2.0 预览版本 [#586](https://github.com/Byaidu/PDFMathTranslate/issues/586)：Windows ZIP 文件和 Docker 镜像现已提供。

> [!注意]
>
> 2.0 版本已迁移至组织下的新仓库：[PDFMathTranslate/PDFMathTranslate-next](https://github.com/PDFMathTranslate/PDFMathTranslate-next)
> 
> 2.0 正式版本已发布。

- [2025年3月3日] 新后端 [BabelDOC](https://github.com/funstory-ai/BabelDOC) WebUI 作为实验选项添加支持（由 [@awwaawwa](https://github.com/awwaawwa) 提供）
- [2025年2月22日] 更好的发布 CI 和完善打包的 windows-amd64 可执行文件（由 [@awwaawwa](https://github.com/awwaawwa) 提供）
- [2024年12月24日] 译者现支持基于 [Xinference](https://github.com/xorbitsai/inference) 的本地模型 _(由 [@imClumsyPanda](https://github.com/imClumsyPanda) 提供)_
- [2024年12月19日] 现在支持非 PDF/A 文档，使用 `-cp` 参数 _(由 [@reycn](https://github.com/reycn) 提供)_
- [2024年12月13日] 新增后端支持 _(由 [@YadominJinta](https://github.com/YadominJinta) 提供)_
- [2024年12月10日] 译者现支持 Azure 上的 OpenAI 模型 _(由 [@yidasanqian](https://github.com/yidasanqian) 提供)_

<h2 id="preview">预览</h2>

<div align="center">
<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/preview.gif" width="80%"/>
</div>

<h2 id="demo">在线服务 🌟</h2>

您可以通过以下任一演示体验我们的应用：

- [公共免费服务](https://pdf2zh.com/) 在线使用，无需安装 _(推荐)_。
- [沉浸式翻译 - BabelDOC](https://app.immersivetranslate.com/babel-doc/) 每月提供 1000 页免费额度。 _(推荐)_
- [HuggingFace 托管演示](https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker)
- [ModelScope 托管演示](https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate) 无需安装。

请注意，演示的计算资源有限，请勿滥用。

<h2 id="install">安装和使用</h2>

### 方法

针对不同的使用场景，我们提供了不同的方法来使用我们的程序：

<details open>
  <summary>1. UV 安装</summary>

1. 已安装 Python（3.10 <= 版本 <= 3.12）

2. 安装我们的包：

   ```bash
   pip install uv
   uv tool install --python 3.12 pdf2zh
   ```

3. 执行翻译，文件生成于[当前工作目录](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)：

   ```bash
   pdf2zh document.pdf
   ```

</details>

<details>
  <summary>2. Windows exe</summary>

1. 从[发布页面](https://github.com/Byaidu/PDFMathTranslate/releases)下载 pdf2zh-version-win64.zip

2. 解压后双击 `pdf2zh.exe` 运行。

</details>

<details>
  <summary>3. 图形用户界面</summary>

1. 已安装 Python（版本 3.10 <= 版本 <= 3.12）

2. 安装我们的包：

```bash
pip install pdf2zh
```

3. 开始在浏览器中使用：

   ```bash
   pdf2zh -i
   ```
4. 如果您的浏览器未自动启动，请转到


   ```bash
   http://localhost:7860/
   ```

   <img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/gui.gif" width="500"/>

详见[GUI文档](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/README_GUI.md)。

</details>

<details>
  <summary>4. Docker</summary>

1. 拉取并运行：

   ```bash
   docker pull byaidu/pdf2zh
   docker run -d -p 7860:7860 byaidu/pdf2zh
   ```
2. 在浏览器中打开：


   ```
   http://localhost:7860/
   ```
云服务上的 Docker 部署：

<div>
<a href="https://www.heroku.com/deploy?template=https://github.com/Byaidu/PDFMathTranslate">
  <img src="https://www.herokucdn.com/deploy/button.svg" alt="Deploy" height="26"></a>
<a href="https://render.com/deploy">
  <img src="https://render.com/images/deploy-to-render-button.svg" alt="Deploy to Koyeb" height="26"></a>
<a href="https://zeabur.com/templates/5FQIGX?referralCode=reycn">
  <img src="https://zeabur.com/button.svg" alt="Deploy on Zeabur" height="26"></a>
<a href="https://template.sealos.io/deploy?templateName=pdf2zh">
  <img src="https://sealos.io/Deploy-on-Sealos.svg" alt="Deploy on Sealos" height="26"></a>
<a href="https://app.koyeb.com/deploy?type=git&builder=buildpack&repository=github.com/Byaidu/PDFMathTranslate&branch=main&name=pdf-math-translate">
  <img src="https://www.koyeb.com/static/images/deploy/button.svg" alt="Deploy to Koyeb" height="26"></a>
</div>

</details>

<details>
  <summary>5. Zotero 插件</summary>


详情请见 [Zotero PDF2zh](https://github.com/guaguastandup/zotero-pdf2zh)。

</details>

<details>
  <summary>6. 命令行</summary>

1. 已安装 Python（版本 3.10 <= 版本 <= 3.12）
2. 安装我们的包：


   ```bash
   pip install pdf2zh
   ```
3. 执行翻译，文件生成于[当前工作目录](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)：


   ```bash
   pdf2zh document.pdf
   ```

</details>

> [!TIP]
>
> - 如果您使用的是 Windows，下载后无法打开文件，请安装 [vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe) 并重试。
>
> - 如果您无法访问 Docker Hub，请尝试使用 [GitHub 容器注册表](https://github.com/Byaidu/PDFMathTranslate/pkgs/container/pdfmathtranslate) 上的镜像。
> ```bash
> docker pull ghcr.io/byaidu/pdfmathtranslate
> docker run -d -p 7860:7860 ghcr.io/byaidu/pdfmathtranslate
> ```

### 无法安装？

本程序在运行前需要一个 AI 模型（`wybxc/DocLayout-YOLO-DocStructBench-onnx`），部分用户因网络问题无法下载该模型。如果您在下载此模型时遇到问题，我们提供了以下环境变量的解决方案：

```shell
set HF_ENDPOINT=https://hf-mirror.com
```
对于 PowerShell 用户：


```shell
$env:HF_ENDPOINT = https://hf-mirror.com
```
如果该解决方案对您无效 / 您遇到其他问题，请参阅[常见问题](https://github.com/Byaidu/PDFMathTranslate/wiki#-faq--%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)。

<h2 id="usage">高级选项</h2>

在命令行执行翻译命令，将在当前工作目录生成翻译后的文档 `example-mono.pdf` 和双语文档 `example-dual.pdf`。默认使用 Google 作为翻译服务。更多支持的翻译服务请见[此处](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)。

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/cmd.explained.png" width="580px"  alt="cmd"/>

下面表格列出了所有高级选项供参考：

| 选项                  | 功能                                                                                                         | 示例                                           |
| --------------------- | ------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| files                 | 本地文件                                                                                                     | `pdf2zh ~/local.pdf`                           |
| links                 | 在线文件                                                                                                     | `pdf2zh http://arxiv.org/paper.pdf`            |
| `-i`                  | [进入图形界面](#gui)                                                                                          | `pdf2zh -i`                                    |
| `-p`                  | [部分文档翻译](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#partial)                   | `pdf2zh example.pdf -p 1`                      |
| `-li`                 | [源语言](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                      | `pdf2zh example.pdf -li en`                    |
| `-lo`                 | [目标语言](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                    | `pdf2zh example.pdf -lo zh`                    |
| `-s`                  | [翻译服务](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)                     | `pdf2zh example.pdf -s deepl`                  |
| `-t`                  | [多线程](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#threads)                        | `pdf2zh example.pdf -t 1`                      |
| `-o`                  | 输出目录                                                                                                     | `pdf2zh example.pdf -o output`                 |
| `-f`, `-c`            | [异常处理](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#exceptions)                   | `pdf2zh example.pdf -f "(MS.*)"`               |
| `-cp`                 | 兼容模式                                                                                                     | `pdf2zh example.pdf --compatible`              |
| `--skip-subset-fonts` | [跳过字体子集](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#font-subset)              | `pdf2zh example.pdf --skip-subset-fonts`       |
| `--ignore-cache`      | [忽略翻译缓存](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cache)                    | `pdf2zh example.pdf --ignore-cache`            |
| `--share`             | 公开链接                                                                                                     | `pdf2zh -i --share`                            |
| `--authorized`        | [授权](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#auth)                            | `pdf2zh -i --authorized users.txt [auth.html]` |
| `--prompt`            | [自定义提示词](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#prompt)                   | `pdf2zh --prompt [prompt.txt]`                 |
| `--onnx`              | [使用自定义 DocLayout-YOLO ONNX 模型]                                                                         | `pdf2zh --onnx [onnx/model/path]`              |
| `--serverport`        | [使用自定义 WebUI 端口]                                                                                       | `pdf2zh --serverport 7860`                     |
| `--dir`               | [批量翻译]                                                                                                    | `pdf2zh --dir /path/to/translate/`             |
| `--config`            | [配置文件](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cofig)                        | `pdf2zh --config /path/to/config/config.json`  |
| `--serverport`        | [自定义 gradio 服务器端口]                                                                                     | `pdf2zh --serverport 7860`                     |
| `--babeldoc`          | 使用实验性后端 [BabelDOC](https://funstory-ai.github.io/BabelDOC/) 进行翻译                                    | `pdf2zh --babeldoc` -s openai example.pdf      |
| `--mcp`               | 启用 MCP STDIO 模式                                                                                           | `pdf2zh --mcp`                                 |
| `--sse`               | 启用 MCP SSE 模式                                                                                             | `pdf2zh --mcp --sse`                           |

详细说明请参阅我们的[高级用法](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/ADVANCED.md)文档，了解各选项完整列表。


<h2 id="downstream">二次开发（API）</h2>

对于下游应用，请参考我们的文档[API 详情](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md)以获取更多信息：

- [Python API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-python)，如何在其他 Python 程序中使用本程序
- [HTTP API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-http)，如何与安装了本程序的服务器通信

<h2 id="todo">待办事项</h2>

- [ ] 使用基于 DocLayNet 的模型解析布局，[PaddleX](https://github.com/PaddlePaddle/PaddleX/blob/17cc27ac3842e7880ca4aad92358d3ef8555429a/paddlex/repo_apis/PaddleDetection_api/object_det/official_categories.py#L81)，[PaperMage](https://github.com/allenai/papermage/blob/9cd4bb48cbedab45d0f7a455711438f1632abebe/README.md?plain=1#L102)，[SAM2](https://github.com/facebookresearch/sam2)

- [ ] 修复页面旋转、目录、列表格式

- [ ] 修复旧论文中的像素公式

- [ ] 异步重试，除 KeyboardInterrupt 外

- [ ] 西方语言的 Knuth–Plass 算法

- [ ] 支持非 PDF/A 文件

- [ ] [Zotero](https://github.com/zotero/zotero) 和 [Obsidian](https://github.com/obsidianmd/obsidian-releases) 插件

<h2 id="acknowledgement">致谢</h2>

- [Immersive Translation](https://immersivetranslate.com) 为本项目活跃贡献者每月赞助 Pro 会员兑换码，详情见：[CONTRIBUTOR_REWARD.md](https://github.com/funstory-ai/BabelDOC/blob/main/docs/CONTRIBUTOR_REWARD.md)

- 新后端：[BabelDOC](https://github.com/funstory-ai/BabelDOC)

- 文档合并：[PyMuPDF](https://github.com/pymupdf/PyMuPDF)

- 文档解析：[Pdfminer.six](https://github.com/pdfminer/pdfminer.six)

- 文档提取：[MinerU](https://github.com/opendatalab/MinerU)

- 文档预览：[Gradio PDF](https://github.com/freddyaboulton/gradio-pdf)

- 多线程翻译：[MathTranslate](https://github.com/SUSYUSTC/MathTranslate)

- 布局解析：[DocLayout-YOLO](https://github.com/opendatalab/DocLayout-YOLO)

- 文档标准: [PDF Explained](https://zxyle.github.io/PDF-Explained/), [PDF Cheat Sheets](https://pdfa.org/resource/pdf-cheat-sheets/)

- 多语言字体: [Go Noto Universal](https://github.com/satbyy/go-noto-universal)

<h2 id="contrib">贡献者</h2>

<a href="https://github.com/Byaidu/PDFMathTranslate/graphs/contributors">
  <img src="https://opencollective.com/PDFMathTranslate/contributors.svg?width=890&button=false" />
</a>

![Alt](https://repobeats.axiom.co/api/embed/dfa7583da5332a11468d686fbd29b92320a6a869.svg "Repobeats analytics image")

<h2 id="star_hist">Star 历史</h2>

<a href="https://star-history.com/#Byaidu/PDFMathTranslate&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date"/>
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-13

---