# Stable Diffusion web UI
Gradioライブラリを使用して実装されたStable Diffusion用のWebインターフェース。

![](screenshot.png)

## 機能
[画像付き詳細機能紹介](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- オリジナルのtxt2imgおよびimg2imgモード
- ワンクリックでインストール＆実行スクリプト（ただしPythonとgitのインストールは必要）
- アウトペインティング
- インペインティング
- カラースケッチ
- プロンプトマトリクス
- Stable Diffusionアップスケール
- Attention、モデルに特定のテキスト部分へより注意を向けるよう指定
    - a man in a `((tuxedo))` - tuxedoにより注意を向ける
    - a man in a `(tuxedo:1.21)` - 別の構文
    - テキストを選択して`Ctrl+Up`または`Ctrl+Down`（Macの場合は`Command+Up`または`Command+Down`）を押すと選択テキストのAttentionを自動調整（匿名ユーザーによるコード提供）
- ループバック、img2img処理を複数回実行
- X/Y/Zプロット、異なるパラメータで画像の3次元プロットを描画
- テキストインバージョン
    - 好きな数だけ埋め込みを持ち、好きな名前を付けて使用可能
    - トークンごとに異なるベクトル数を持つ複数の埋め込みを利用可能
    - 半精度浮動小数点で動作
    - 8GB（6GBでも動作報告あり）で埋め込み学習
- Extrasタブ:
    - GFPGAN、顔修復ニューラルネットワーク
    - CodeFormer、GFPGANの代替となる顔修復ツール
    - RealESRGAN、ニューラルネットワークアップスケーラー
    - ESRGAN、サードパーティモデル多数対応のアップスケーラー
    - SwinIRおよびSwin2SR（[詳細はこちら](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)）、ニューラルネットワークアップスケーラー
    - LDSR、潜在拡散型超解像アップスケーリング
- リサイズアスペクト比オプション
- サンプリング手法選択
    - サンプラーeta値（ノイズ倍率）の調整
    - より高度なノイズ設定オプション
- いつでも処理を中断可能
- 4GBビデオカード対応（2GBでも動作報告あり）
- バッチに対する正しいシード
- リアルタイムのプロンプトトークン長バリデーション
- 生成パラメータ
     - 画像生成時のパラメータを画像に保存
     - PNGではPNGチャンク、JPEGではEXIFに格納
     - 画像をPNG infoタブにドラッグで生成パラメータを復元し自動的にUIへコピー
     - 設定で無効化可能
     - 画像/テキストパラメータをプロンプトボックスにドラッグ＆ドロップ
- 生成パラメータ読込ボタン、プロンプトボックスのパラメータをUIに読込
- 設定ページ
- UIから任意のPythonコード実行（`--allow-code`で有効化）
- 多くのUI要素にマウスオーバーヒント
- テキスト設定でUI要素のデフォルト/最小/最大/ステップ値変更可能
- タイリング対応、テクスチャのようにタイル化可能な画像を作成するチェックボックス
- プログレスバーとリアルタイム画像生成プレビュー
    - ほぼVRAMや計算リソースを必要としない別のニューラルネットワークでプレビュー生成可能
- ネガティブプロンプト、生成画像に含めたくない要素を指定する追加テキスト欄
- スタイル、プロンプトの一部を保存し後からドロップダウンで簡単に適用
- バリエーション、同じ画像を微細な違いで生成
- シードリサイズ、やや異なる解像度で同じ画像を生成
- CLIPインタロゲーター、画像からプロンプトを推測するボタン
- プロンプト編集、生成中にプロンプトを変更（途中でスイカからアニメ少女に切り替えるなど）
- バッチ処理、img2imgを使ってファイル群を処理
- Img2img代替、逆Euler法によるクロスアテンション制御
- 高解像度修正、ワンクリックで通常の歪みなく高解像度画像を生成する便利オプション
- チェックポイントのオンザフライリロード
- チェックポイントマージャー、最大3つのチェックポイントを1つに統合するタブ
- [カスタムスクリプト](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts)、コミュニティによる多くの拡張
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)、複数プロンプト同時使用
     - プロンプトは大文字の`AND`で区切る
     - プロンプトごとの重み指定も対応: `a cat :1.2 AND a dog AND a penguin :2.2`
- プロンプトのトークン数制限なし（オリジナルStable Diffusionは75トークンまで）
- DeepDanbooru統合、アニメプロンプト用danbooruスタイルタグ生成
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)、一部カードで大幅な高速化（コマンドライン引数に`--xformers`を追加）
- 拡張機能: [履歴タブ](https://github.com/yfszzx/stable-diffusion-webui-images-browser)、UI内で画像の閲覧・直接操作・削除が可能
- 永続生成オプション
- トレーニングタブ
     - ハイパーネットワーク・埋め込みオプション
     - 画像の前処理：クロップ、ミラー、BLIPまたはdeepdanbooru（アニメ用）による自動タグ付け
- Clip skip
- ハイパーネットワーク
- Lora（ハイパーネットワークと同様だがより美しい）
- プレビュー付きでプロンプトに追加する埋め込み・ハイパーネットワーク・Loraを選択できる独立UI
- 設定画面から異なるVAEのロードを選択可能
- プログレスバーに予想完了時間表示
- API
- RunwayMLによる専用[インペインティングモデル](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion)対応
- 拡張機能: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)、clip画像埋め込みを用いて特定の美的スタイル画像を生成（[https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients)の実装）
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion)対応 - 手順は[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)参照
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679)対応 - 手順は[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)参照
- 不適切な文字なし！
- safetensors形式のチェックポイント読み込み
- 解像度制限緩和：生成画像の各辺は64の倍数→8の倍数に
- ライセンス付き！
- 設定画面からUI要素の並び順変更
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)対応

## インストールと実行
必要な[依存関係](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)を満たし、以下の手順に従ってください：
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)（推奨）
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU
- [Intel CPU、Intel GPU（統合・ディスクリート）](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon)（外部wiki）
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs)（外部wiki）

またはオンラインサービス（Google Colab等）を利用：

- [オンラインサービス一覧](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### NVidia-GPU搭載Windows 10/11でリリースパッケージを使ったインストール
1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre)から`sd.webui.zip`をダウンロードし、内容を展開
2. `update.bat`を実行
3. `run.bat`を実行
> 詳細は[Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)参照

### Windowsでの自動インストール
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/)をインストール（torchは新しいバージョン非対応）、「Add Python to PATH」にチェック
2. [git](https://git-scm.com/download/win)をインストール
3. stable-diffusion-webuiリポジトリをダウンロード（例：`git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`を実行）
4. Windows Explorerから`webui-user.bat`を通常ユーザーで実行

### Linuxでの自動インストール
1. 依存関係をインストール：
```bash
# Debian系:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat系:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE系:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch系:
sudo pacman -S wget git python3
```
システムが新しい場合、python3.11またはpython3.10をインストール：
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # python3.11パッケージと混同注意

# 3.11のみ
# 起動スクリプトで環境変数を設定
export python_cmd="python3.11"
# またはwebui-user.shで
python_cmd="python3.11"
```
2. インストールしたいディレクトリに移動し、以下を実行：
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
またはリポジトリを好きな場所にクローン：
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. `webui.sh`を実行
4. オプションは`webui-user.sh`を確認
### Apple Siliconへのインストール

[こちら](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)を参照。

## 貢献方法
このリポジトリにコードを追加する方法：[Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## ドキュメント

ドキュメントはこのREADMEからプロジェクトの[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)に移動しました。

Googleなど検索エンジンのクロール用（人間向けではありません）として、[クロール用wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki)へのリンクを掲載します。

## クレジット
借用コードのライセンスは`設定 -> ライセンス`画面、または`html/licenses.html`ファイルに記載。

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
- 最適化アイデア - https://github.com/basujindal/stable-diffusion
- クロスアテンション層の最適化 - Doggettx - https://github.com/Doggettx/stable-diffusion, プロンプト編集の元アイデア
- クロスアテンション層の最適化 - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (元: http://github.com/lstein/stable-diffusion)
- 準二次クロスアテンション層の最適化 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- テキストインバージョン - Rinon Gal - https://github.com/rinongal/textual_inversion（コードは未使用、アイデアのみ利用）
- SDアップスケールのアイデア - https://github.com/jquesnelle/txt2imghd
- アウトペインティングmk2のノイズ生成 - https://github.com/parlance-zz/g-diffuser-bot
- CLIPインタロゲーターのアイデアと一部コード - https://github.com/pharmapsychotic/clip-interrogator
- Composable Diffusionのアイデア - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - アニメディフューザー向けインタロゲーター https://github.com/KichangKim/DeepDanbooru
- float16 UNetからのfloat32精度サンプリング - marunineのアイデア、Birch-sanによるDiffusers実装例 (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- セキュリティアドバイス - RyotaK
- UniPCサンプラー - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- リスタートサンプリング - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- 初期Gradioスクリプト - Anonymousユーザーによって4chanに投稿。ありがとうAnonymousユーザー。
- (あなた)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---