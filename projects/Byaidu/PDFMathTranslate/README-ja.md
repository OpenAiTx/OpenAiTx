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

PDFの科学論文の翻訳と二言語比較。

- 📊 数式、グラフ、目次、注釈を保持 _([プレビュー](#preview))_。
- 🌐 [多言語](#language)および多様な[翻訳サービス](#services)をサポート。
- 🤖 [コマンドラインツール](#usage)、[インタラクティブユーザーインターフェース](#gui)、および[Docker](#docker)を提供します。

フィードバックは[GitHub Issues](https://github.com/Byaidu/PDFMathTranslate/issues)または[Telegramグループ](https://t.me/+Z9_SgnxmsmA5NzBl)でお気軽にどうぞ。

貢献方法の詳細については、[貢献ガイド](https://github.com/Byaidu/PDFMathTranslate/wiki/Contribution-Guide---%E8%B4%A1%E7%8C%AE%E6%8C%87%E5%8D%97)をご参照ください。

<h2 id="updates">更新情報</h2>

- [2025年5月9日] pdf2zh 2.0プレビューバージョン [#586](https://github.com/Byaidu/PDFMathTranslate/issues/586): Windows用ZIPファイルとDockerイメージが利用可能になりました。

> [!NOTE]
>
> 2.0は組織下の新しいリポジトリに移行しました: [PDFMathTranslate/PDFMathTranslate-next](https://github.com/PDFMathTranslate/PDFMathTranslate-next)
> 
> バージョン2.0の正式リリースが公開されました。

- [2025年3月3日] 新しいバックエンド[BabelDOC](https://github.com/funstory-ai/BabelDOC)のWebUIを実験的オプションとして追加（[@awwaawwa](https://github.com/awwaawwa)による）
- [2025年2月22日] リリースCIが改善され、Windows-amd64のexeが適切にパッケージ化されました（[@awwaawwa](https://github.com/awwaawwa)による）
- [2024年12月24日] 翻訳ツールが[Xinference](https://github.com/xorbitsai/inference)のローカルモデルをサポートするようになりました（[@imClumsyPanda](https://github.com/imClumsyPanda)による）
- [2024年12月19日] 非PDF/Aドキュメントが`-cp`オプションでサポートされるようになりました（[@reycn](https://github.com/reycn)による）
- [2024年12月13日] バックエンドの追加サポートが行われました（[@YadominJinta](https://github.com/YadominJinta)による）
- [2024年12月10日] 翻訳ツールがAzure上のOpenAIモデルをサポートするようになりました（[@yidasanqian](https://github.com/yidasanqian)による）

<h2 id="preview">プレビュー</h2>

<div align="center">
<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/preview.gif" width="80%"/>
</div>

<h2 id="demo">オンラインサービス 🌟</h2>

以下のデモのいずれかを利用してアプリケーションを試すことができます：

- [パブリック無料サービス](https://pdf2zh.com/) インストール不要でオンライン利用可能 _(推奨)_。
- [Immersive Translate - BabelDOC](https://app.immersivetranslate.com/babel-doc/) 月間1000ページ無料。 _(推奨)_
- [HuggingFaceでホストされているデモ](https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker)
- [ModelScopeでホストされているデモ](https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate) インストール不要。

デモの計算リソースは限られているため、乱用はご遠慮ください。

<h2 id="install">インストールと使用方法</h2>

### 方法

異なるユースケースに対応して、当プログラムの使用方法をいくつか提供しています：

<details open>
  <summary>1. UV インストール</summary>

1. Python がインストールされていること（3.10 <= バージョン <= 3.12）

2. 当パッケージをインストールする：

   ```bash
   pip install uv
   uv tool install --python 3.12 pdf2zh
   ```
3. 翻訳を実行し、ファイルは[current working directory](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)に生成されます:


   ```bash
   pdf2zh document.pdf
   ```

</details>

<details>
  <summary>2. Windows exe</summary>

1. [リリースページ](https://github.com/Byaidu/PDFMathTranslate/releases) から pdf2zh-version-win64.zip をダウンロードします

2. 解凍して `pdf2zh.exe` をダブルクリックして実行します。

</details>

<details>
  <summary>3. グラフィカルユーザーインターフェース</summary>

1. Pythonがインストールされていること（バージョン3.10 <= version <= 3.12）

2. 当パッケージをインストールします：

```bash
pip install pdf2zh
```

3. ブラウザでの使用を開始する:

   ```bash
   pdf2zh -i
   ```

4. ブラウザが自動的に起動しない場合は、次の場所に移動してください。

   ```bash
   http://localhost:7860/
   ```

   <img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/gui.gif" width="500"/>

詳細については、[GUIのドキュメント](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/README_GUI.md)を参照してください。

</details>

<details>
  <summary>4. Docker</summary>

1. プルして実行します:

   ```bash
   docker pull byaidu/pdf2zh
   docker run -d -p 7860:7860 byaidu/pdf2zh
   ```

2. ブラウザで開く:

   ```
   http://localhost:7860/
   ```
クラウドサービスでのDockerデプロイ用:

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
  <summary>5. Zotero プラグイン</summary>


詳細は[Zotero PDF2zh](https://github.com/guaguastandup/zotero-pdf2zh)をご覧ください。

</details>

<details>
  <summary>6. コマンドライン</summary>

1. Pythonがインストールされていること (3.10 <= バージョン <= 3.12)
2. 当パッケージをインストールしてください:


   ```bash
   pip install pdf2zh
   ```
3. 翻訳を実行し、ファイルは[current working directory](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444)に生成されます:


   ```bash
   pdf2zh document.pdf
   ```

</details>

> [!TIP]
>
> - Windowsを使用していてダウンロード後にファイルが開けない場合は、[vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe)をインストールしてから再試行してください。
>
> - Docker Hubにアクセスできない場合は、[GitHub Container Registry](https://github.com/Byaidu/PDFMathTranslate/pkgs/container/pdfmathtranslate)のイメージを試してください。
> ```bash
> docker pull ghcr.io/byaidu/pdfmathtranslate
> docker run -d -p 7860:7860 ghcr.io/byaidu/pdfmathtranslate
> ```

### インストールできない場合？

本プログラムは動作前にAIモデル(`wybxc/DocLayout-YOLO-DocStructBench-onnx`)を必要とし、一部のユーザーはネットワークの問題でダウンロードできない場合があります。このモデルのダウンロードに問題がある場合、以下の環境変数を使用した回避策を提供しています：

```shell
set HF_ENDPOINT=https://hf-mirror.com
```
PowerShell ユーザー向け:


```shell
$env:HF_ENDPOINT = https://hf-mirror.com
```
もしこの解決策がうまくいかない場合や、他の問題が発生した場合は、[よくある質問](https://github.com/Byaidu/PDFMathTranslate/wiki#-faq--%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98)をご参照ください。

<h2 id="usage">高度なオプション</h2>

コマンドラインで翻訳コマンドを実行すると、現在の作業ディレクトリに翻訳済みドキュメント `example-mono.pdf` と二言語ドキュメント `example-dual.pdf` が生成されます。デフォルトの翻訳サービスとしてGoogleを使用します。対応可能な翻訳サービスの詳細は[こちら](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)をご覧ください。

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/cmd.explained.png" width="580px"  alt="cmd"/>

以下の表に、すべての高度なオプションを参考用に一覧にしています:

| オプション             | 機能                                                                                                         | 例                                             |
| --------------------- | ------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| files                 | ローカルファイル                                                                                               | `pdf2zh ~/local.pdf`                           |
| links                 | オンラインファイル                                                                                             | `pdf2zh http://arxiv.org/paper.pdf`            |
| `-i`                  | [GUIを起動](#gui)                                                                                              | `pdf2zh -i`                                    |
| `-p`                  | [部分的ドキュメント翻訳](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#partial)          | `pdf2zh example.pdf -p 1`                      |
| `-li`                 | [ソース言語](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                     | `pdf2zh example.pdf -li en`                    |
| `-lo`                 | [ターゲット言語](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                 | `pdf2zh example.pdf -lo zh`                    |
| `-s`                  | [翻訳サービス](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)                    | `pdf2zh example.pdf -s deepl`                  |
| `-t`                  | [マルチスレッド](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#threads)                   | `pdf2zh example.pdf -t 1`                      |
| `-o`                  | 出力ディレクトリ                                                                                               | `pdf2zh example.pdf -o output`                 |
| `-f`, `-c`            | [例外処理](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#exceptions)                      | `pdf2zh example.pdf -f "(MS.*)"`               |
| `-cp`                 | 互換モード                                                                                                     | `pdf2zh example.pdf --compatible`              |
| `--skip-subset-fonts` | [フォントサブセットをスキップ](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#font-subset)  | `pdf2zh example.pdf --skip-subset-fonts`       |
| `--ignore-cache`      | [翻訳キャッシュを無視](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cache)               | `pdf2zh example.pdf --ignore-cache`            |
| `--share`             | 公開リンク                                                                                                    | `pdf2zh -i --share`                            |
| `--authorized`        | [認証](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#auth)                               | `pdf2zh -i --authorized users.txt [auth.html]` |
| `--prompt`            | [カスタムプロンプト](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#prompt)                | `pdf2zh --prompt [prompt.txt]`                 |
| `--onnx`              | [カスタムDocLayout-YOLO ONNXモデルを使用]                                                                       | `pdf2zh --onnx [onnx/model/path]`              |
| `--serverport`        | [カスタムWebUIポートを使用]                                                                                     | `pdf2zh --serverport 7860`                     |
| `--dir`               | [バッチ翻訳]                                                                                                  | `pdf2zh --dir /path/to/translate/`             |
| `--config`            | [設定ファイル](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cofig)                      | `pdf2zh --config /path/to/config/config.json`  |
| `--serverport`        | [カスタムgradioサーバーポート]                                                                                   | `pdf2zh --serverport 7860`                     |
| `--babeldoc`          | 実験的バックエンド[BabelDOC](https://funstory-ai.github.io/BabelDOC/)を使用して翻訳                                | `pdf2zh --babeldoc` -s openai example.pdf      |
| `--mcp`               | MCP STDIOモードを有効化                                                                                        | `pdf2zh --mcp`                                 |
| `--sse`               | MCP SSEモードを有効化                                                                                          | `pdf2zh --mcp --sse`                           |

詳細な説明については、各オプションの完全なリストを含む[高度な使用法](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/ADVANCED.md)のドキュメントをご参照ください。


<h2 id="downstream">二次開発（API）</h2>

ダウンストリームアプリケーションについては、詳細は当社のドキュメント[API詳細](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md)をご参照ください：

- [Python API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-python)、他のPythonプログラムでの使用方法
- [HTTP API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-http)、プログラムがインストールされたサーバーとの通信方法

<h2 id="todo">TODOリスト</h2>

- [ ] DocLayNetベースモデルによるレイアウト解析、[PaddleX](https://github.com/PaddlePaddle/PaddleX/blob/17cc27ac3842e7880ca4aad92358d3ef8555429a/paddlex/repo_apis/PaddleDetection_api/object_det/official_categories.py#L81)、[PaperMage](https://github.com/allenai/papermage/blob/9cd4bb48cbedab45d0f7a455711438f1632abebe/README.md?plain=1#L102)、[SAM2](https://github.com/facebookresearch/sam2)

- [ ] ページ回転、目次、リストのフォーマットを修正

- [ ] 古い論文のピクセル数式を修正

- [ ] KeyboardInterruptを除く非同期リトライ

- [ ] 西洋言語向けKnuth–Plassアルゴリズム

- [ ] PDF/A以外のファイルをサポート

- [ ] [Zotero](https://github.com/zotero/zotero)および[Obsidian](https://github.com/obsidianmd/obsidian-releases)のプラグイン

<h2 id="acknowledgement">謝辞</h2>

- [Immersive Translation](https://immersivetranslate.com)は、本プロジェクトのアクティブな貢献者に毎月Proメンバーシップの引換コードを提供しています。詳細は[CONTRIBUTOR_REWARD.md](https://github.com/funstory-ai/BabelDOC/blob/main/docs/CONTRIBUTOR_REWARD.md)をご覧ください。

- 新バックエンド：[BabelDOC](https://github.com/funstory-ai/BabelDOC)

- ドキュメント結合：[PyMuPDF](https://github.com/pymupdf/PyMuPDF)

- ドキュメント解析：[Pdfminer.six](https://github.com/pdfminer/pdfminer.six)

- ドキュメント抽出：[MinerU](https://github.com/opendatalab/MinerU)

- ドキュメントプレビュー：[Gradio PDF](https://github.com/freddyaboulton/gradio-pdf)

- マルチスレッド翻訳：[MathTranslate](https://github.com/SUSYUSTC/MathTranslate)

- レイアウト解析：[DocLayout-YOLO](https://github.com/opendatalab/DocLayout-YOLO)

- ドキュメント標準: [PDF Explained](https://zxyle.github.io/PDF-Explained/), [PDF Cheat Sheets](https://pdfa.org/resource/pdf-cheat-sheets/)

- 多言語フォント: [Go Noto Universal](https://github.com/satbyy/go-noto-universal)

<h2 id="contrib">貢献者</h2>

<a href="https://github.com/Byaidu/PDFMathTranslate/graphs/contributors">
  <img src="https://opencollective.com/PDFMathTranslate/contributors.svg?width=890&button=false" />
</a>

![Alt](https://repobeats.axiom.co/api/embed/dfa7583da5332a11468d686fbd29b92320a6a869.svg "Repobeats analytics image")

<h2 id="star_hist">スター履歴</h2>

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