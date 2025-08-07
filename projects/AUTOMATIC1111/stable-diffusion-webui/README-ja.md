# Stable Diffusion web UI
Stable Diffusionのためのウェブインターフェースで、Gradioライブラリを使用して実装されています。

![](https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/screenshot.png)

## Features
[画像付き詳細機能紹介](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- オリジナルのtxt2imgおよびimg2imgモード
- ワンクリックでインストールと実行スクリプト（ただしPythonとgitは別途インストールが必要）
- アウトペインティング
- インペインティング
- カラースケッチ
- プロンプトマトリックス
- Stable Diffusion アップスケール
- アテンション、モデルがより注意を払うべきテキスト部分を指定
    - a man in a `((tuxedo))` - tuxedoにより注意を払う
    - a man in a `(tuxedo:1.21)` - 代替構文
    - テキストを選択し、`Ctrl+Up`または`Ctrl+Down`（MacOSの場合は`Command+Up`または`Command+Down`）を押すと選択テキストのアテンションを自動調整（匿名ユーザーのコード提供）
- ループバック、img2img処理を複数回実行
- X/Y/Zプロット、異なるパラメータで画像の3次元プロットを描画する方法
- テキスチュアルインバージョン
    - 好きなだけ埋め込みを持て、好きな名前を使える
    - トークンごとに異なるベクトル数の複数埋め込みを使用可能
    - 半精度浮動小数点数で動作
    - 8GBで埋め込みを訓練可能（6GBで動作報告もあり）
- Extrasタブに以下を含む：
    - GFPGAN、顔を修正するニューラルネットワーク
    - CodeFormer、GFPGANの代替顔修復ツール
    - RealESRGAN、ニューラルネットワークアップスケーラー
    - ESRGAN、多数のサードパーティモデルを持つニューラルネットワークアップスケーラー
    - SwinIRおよびSwin2SR（[こちら参照](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)）、ニューラルネットワークアップスケーラー
    - LDSR、潜在拡散スーパーレゾリューションアップスケーリング
- アスペクト比リサイズオプション
- サンプリング手法選択
    - サンプラーのeta値（ノイズ乗数）調整
    - より高度なノイズ設定オプション
- いつでも処理を中断可能
- 4GBビデオカードサポート（2GBで動作報告もあり）
- バッチごとに正しいシード生成
- プロンプトトークン長のリアルタイム検証
- 生成パラメータ
     - 画像を生成するために使用したパラメータが画像と一緒に保存される
     - PNGの場合はPNGチャンクに、JPEGの場合はEXIFに保存
     - 画像をPNG情報タブにドラッグすると生成パラメータを復元しUIに自動コピー
     - 設定で無効化可能
     - 画像／テキストパラメータをプロンプトボックスにドラッグ＆ドロップ可能
- 生成パラメータ読み込みボタン、プロンプトボックスにパラメータをロード
- 設定ページ
- UIから任意のPythonコードを実行可能（`--allow-code`オプションで有効化）
- ほとんどのUI要素にマウスオーバーヒント
- UI要素のデフォルト／最小／最大／ステップ値をテキスト設定で変更可能
- タイリング対応、テクスチャのようにタイル可能な画像を作成するチェックボックス
- 進捗バーとリアルタイム画像生成プレビュー
    - VRAMや計算資源をほぼ使わずにプレビューを生成する別ニューラルネットワークを使用可能
- ネガティブプロンプト、生成画像に含めたくない要素を列挙する追加テキスト欄
- スタイル、プロンプトの一部を保存し、後でドロップダウンから簡単に適用可能
- バリエーション、ほぼ同じ画像を僅かな違いで生成する方法
- シードリサイズ、ほぼ同じ画像をわずかに異なる解像度で生成
- CLIPインターロゲーター、画像からプロンプトを推測するボタン
- プロンプト編集、生成中にプロンプトを変更可能。例：スイカから途中でアニメ少女に切り替え
- バッチ処理、複数ファイルをimg2imgで処理
- Img2img代替、逆オイラー法によるクロスアテンション制御
- 高解像度修正、ワンクリックで通常の歪みなしに高解像度画像を生成する便利オプション
- チェックポイントを即時再読み込み可能
- チェックポイントマージャー、最大3つのチェックポイントを1つにマージ可能なタブ
- [カスタムスクリプト](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts)、コミュニティによる多くの拡張
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)、複数プロンプトを同時使用可能
     - プロンプトを大文字の`AND`で区切る
     - 重み付けも対応：`a cat :1.2 AND a dog AND a penguin :2.2`
- プロンプトにトークン制限なし（元のStable Diffusionは最大75トークン）
- DeepDanbooru統合、アニメプロンプト用のdanbooruスタイルタグ生成
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)、特定GPUで大幅な高速化（コマンドライン引数に`--xformers`を追加）
- 拡張機能経由：[履歴タブ](https://github.com/yfszzx/stable-diffusion-webui-images-browser)、UI内で画像の閲覧、直接操作、削除が便利に
- 永続生成オプション
- トレーニングタブ
     - ハイパーネットワークと埋め込みオプション
     - 画像の前処理：クロッピング、ミラーリング、BLIPやdeepdanbooruによる自動タグ付け（アニメ用）
- Clip skip
- ハイパーネットワーク
- Lora（ハイパーネットワークと同様だがより見た目が良い）
- 埋め込み、ハイパーネットワーク、Loraを選択しプレビュー付きでプロンプトに追加できる別UI
- 設定画面から異なるVAEの読み込み選択可能
- 進捗バーに推定完了時間表示
- API
- RunwayML提供の[専用インペインティングモデル](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion)対応
- 拡張機能経由：[Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)、クリップ画像埋め込みを使って特定の美的感覚で画像生成（[実装元](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients)）
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion)対応 - 詳細は[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679)対応 - 詳細は[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- 悪い文字なしで今ここに！
- safetensorsフォーマットのチェックポイント読み込み対応
- 解像度制限緩和：生成画像の寸法は64の倍数ではなく8の倍数でよくなった
- ライセンス付きになりました！
- 設定画面からUI要素の並び順変更可能
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)対応

## インストールと実行
必要な[依存関係](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)を満たしていることを確認し、以下の手順に従ってください：
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)（推奨）
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU
- [Intel CPU、Intel GPU（内蔵およびディスクリート）](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon)（外部wikiページ）
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs)（外部Wikiページ）

または、オンラインサービス（Google Colabなど）を利用してください：

- [オンラインサービス一覧](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### NVidia GPU搭載Windows 10/11でのリリースパッケージによるインストール
1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre)から `sd.webui.zip` をダウンロードし、展開します。
2. `update.bat` を実行します。
3. `run.bat` を実行します。
> 詳細は [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) を参照してください。

### Windowsでの自動インストール
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) をインストールします（新しいPythonバージョンはtorchをサポートしていません）。「Add Python to PATH」にチェックを入れてください。
2. [git](https://git-scm.com/download/win) をインストールします。
3. stable-diffusion-webuiリポジトリをダウンロードします。例： `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git` を実行。
4. Windowsエクスプローラーから `webui-user.bat` を通常ユーザー（管理者ではなく）で実行します。

### Linuxでの自動インストール
1. 依存関係をインストールします：
```bash
# Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-based:
sudo pacman -S wget git python3
```
システムが非常に新しい場合は、python3.11 または python3.10 をインストールする必要があります:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # do not confuse with python3.11 package

# Only for 3.11
# Then set up env variable in launch script
export python_cmd="python3.11"
# or in webui-user.sh
python_cmd="python3.11"
```
2. WebUIをインストールしたいディレクトリに移動し、次のコマンドを実行します:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
または、リポジトリを好きな場所にクローンしてください:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```
3. `webui.sh`を実行します。  
4. オプションについては`webui-user.sh`を確認してください。  
### Apple Siliconでのインストール  

インストール手順は[こちら](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)を参照してください。  

## 貢献方法  
このリポジトリにコードを追加する方法はこちらです: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)  

## ドキュメント  

ドキュメントはこのREADMEからプロジェクトの[ウィキ](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)に移動しました。  

Googleや他の検索エンジンにウィキをクロールさせるために、（人間向けではない）[クロール可能なウィキ](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki)へのリンクを用意しています。  

## クレジット  
借用したコードのライセンスは`Settings -> Licenses`画面および`html/licenses.html`ファイルに記載されています。  

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref  
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git  
- Spandrel - https://github.com/chaiNNer-org/spandrel 実装  
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git  
  - CodeFormer - https://github.com/sczhou/CodeFormer  
  - ESRGAN - https://github.com/xinntao/ESRGAN  
  - SwinIR - https://github.com/JingyunLiang/SwinIR  
  - Swin2SR - https://github.com/mv-lab/swin2sr  
- LDSR - https://github.com/Hafiidz/latent-diffusion  
- MiDaS - https://github.com/isl-org/MiDaS  
- 最適化のアイデア - https://github.com/basujindal/stable-diffusion  
- クロスアテンション層の最適化 - Doggettx - https://github.com/Doggettx/stable-diffusion、プロンプト編集のオリジナルアイデア。  
- クロスアテンション層の最適化 - InvokeAI、lstein - https://github.com/invoke-ai/InvokeAI （元は http://github.com/lstein/stable-diffusion）  
- サブ二次的クロスアテンション層の最適化 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)  
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion （コードは使っていませんがアイデアを利用しています）。  
- SDアップスケールのアイデア - https://github.com/jquesnelle/txt2imghd  
- アウトペインティングmk2用ノイズ生成 - https://github.com/parlance-zz/g-diffuser-bot  
- CLIPインタロゲーターのアイデアと一部コード借用 - https://github.com/pharmapsychotic/clip-interrogator  
- Composable Diffusionのアイデア - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch  
- xformers - https://github.com/facebookresearch/xformers  
- DeepDanbooru - アニメディフューザー用インタロゲーター https://github.com/KichangKim/DeepDanbooru  
- float16 UNetからfloat32精度でのサンプリング - marunineのアイデア、Birch-sanのDiffusers実装例 (https://github.com/Birch-san/diffusers-play/tree/92feee6)  
- Instruct pix2pix - Tim Brooks (スター), Aleksander Holynski (スター), Alexei A. Efros (スターなし) - https://github.com/timothybrooks/instruct-pix2pix  
- セキュリティアドバイス - RyotaK  
- UniPCサンプラー - Wenliang Zhao - https://github.com/wl-zhao/UniPC  
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd  
- LyCORIS - KohakuBlueleaf  
- サンプリングの再開 - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling  
- Hypertile - tfernd - https://github.com/tfernd/HyperTile  
- 最初のGradioスクリプト - 4chanの匿名ユーザーによる投稿。匿名ユーザーに感謝します。  
- （あなた）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---