# Mapperatorinator

ジェネレーティブモデルを[こちら](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)で、またはMaiModを[こちら](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)で試せます。動画デモは[こちら](https://youtu.be/FEr7t1L2EoA)をご覧ください。

Mapperatorinatorはスペクトログラム入力を使用して、全ゲームモード向けの完全な機能を備えたosu!ビートマップを生成し、[アシストモッディングビートマップ](#maimod-the-ai-driven-modding-tool)を行うマルチモデルフレームワークです。  
このプロジェクトの目標は、任意の楽曲から高いカスタマイズ性を持つランク可能な品質のosu!ビートマップを自動生成することです。

このプロジェクトは[osuT5](https://github.com/gyataro/osuT5)と[osu-diffusion](https://github.com/OliBomby/osu-diffusion)をベースにしています。開発には、私の4060 Tiとvast.aiでレンタルした4090インスタンスを用いて、142回の実行で約2500時間のGPU計算を費やしました。

#### このツールは責任を持って使用してください。ビートマップにAIの使用を必ず明示してください。

## インストール

以下の手順でローカルマシンでビートマップを生成できます。代わりに[Colabノートブック](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)でクラウド上で実行することも可能です。

### 1. リポジトリをクローンする

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. （オプション）仮想環境の作成

Python 3.10を使用してください。以降のバージョンは依存関係と互換性がない可能性があります。

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. 依存関係のインストール

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone)（NVIDIA GPU用）または[ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html)（Linux上のAMD GPU用）
- [PyTorch](https://pytorch.org/get-started/locally/)：GPUサポート付きで`torch`と`torchaudio`をインストールするために、Get Startedガイドに従ってください。前のステップでインストールしたCompute Platformのバージョンを正しく選択してください。

- そして残りのPython依存関係：

```sh
pip install -r requirements.txt
```

## Web GUI（推奨）

よりユーザーフレンドリーな体験のために、Web UIの使用を検討してください。生成パラメータの設定、プロセスの開始、出力の監視を行うグラフィカルインターフェースを提供します。

### GUIの起動

ターミナルでクローンした `Mapperatorinator` ディレクトリに移動し、以下を実行します：

```sh
python web-ui.py
```

これはローカルのウェブサーバーを起動し、新しいウィンドウでUIを自動的に開きます。

### GUIの使用方法

- **設定:** 入力/出力パスをフォームフィールドと「参照」ボタンで設定します。コマンドラインオプションに対応したゲームモード、難易度、スタイル（年、マッパーID、記述子）、タイミング、特定機能（ヒットサウンド、スーパータイミング）など生成パラメータを調整します。（注：`beatmap_path`を指定すると、UIは自動的に`audio_path`と`output_path`を推測するため、これらのフィールドは空欄で構いません）
- **開始:** 「推論開始」ボタンをクリックしてビートマップ生成を開始します。
- **キャンセル:** 「推論キャンセル」ボタンで進行中の処理を停止できます。
- **出力を開く:** 完了後、「出力フォルダを開く」ボタンで生成ファイルにすばやくアクセスできます。

Web UIは`inference.py`スクリプトの便利なラッパーとして機能します。高度なオプションやトラブルシューティングにはコマンドラインの説明を参照してください。

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## コマンドライン推論

コマンドラインを好むユーザーや高度な設定が必要な場合は、以下の手順に従ってください。**注：より簡単なグラフィカルインターフェースについては、上記の[Web UI（推奨）](#web-ui-recommended)セクションを参照してください。**

`inference.py`を実行し、引数を渡してビートマップを生成します。この際[Hydraオーバーライド構文](https://hydra.cc/docs/advanced/override_grammar/basic/)を使用してください。利用可能なパラメータは`configs/inference_v29.yaml`をご覧ください。
```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```
例：

```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## インタラクティブCLI
ターミナルベースのワークフローを好みつつ、ガイド付きのセットアップを望む方には、インタラクティブCLIスクリプトがWeb UIの優れた代替手段です。

### CLIを起動する
クローンしたディレクトリに移動します。最初にスクリプトを実行可能にする必要があるかもしれません。

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### CLIの使用方法
スクリプトは、Web UIと同様にすべての生成パラメータを設定するための一連のプロンプトを案内します。

わかりやすさのために色分けされたインターフェースを使用します。
矢印キーとスペースバーを使ってスタイル記述子を選択する高度なマルチセレクトメニューを提供します。
すべての質問に答えると、最終的なコマンドを表示して確認できます。
その後、直接実行を確認するか、キャンセルして手動で使用するためにコマンドをコピーできます。

## 生成のヒント

- `configs/inference_v29.yaml`を編集して、毎回ターミナルで入力する代わりに引数を追加できます。
- 利用可能なすべての記述子は[こちら](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags)で確認できます。
- 2007年から2023年までの年引数を必ず指定してください。不明のままだとモデルが一貫しないスタイルで生成する可能性があります。
- 難易度引数も必ず指定してください。不明のままだとモデルが一貫しない難易度で生成する可能性があります。
- `cfg_scale`パラメータを上げると、`mapper_id`や`descriptors`引数の効果が高まります。
- `negative_descriptors`引数を使うと、特定のスタイルからモデルを遠ざけることができます。これは`cfg_scale > 1`の場合のみ有効です。ネガティブ記述子の数は記述子の数と同じにしてください。
- 曲のスタイルと希望するビートマップのスタイルが合わない場合、モデルが指示に従わないことがあります。例えば、落ち着いた曲で高SRかつ高SVのビートマップを生成するのは難しいです。
- 曲のタイミングと気合い時間が既にできている場合、モデルの推論速度と精度を大幅に向上させるためにこれをモデルに渡せます：`beatmap_path`と`in_context=[TIMING,KIAI]`引数を使用してください。
- ビートマップの一部だけをリマップするには、`beatmap_path`、`start_time`、`end_time`、および`add_to_beatmap=true`引数を使用してください。
- ゲスト難易度を生成するには、`beatmap_path`と`in_context=[GD,TIMING,KIAI]`引数を使用してください。
- ヒットサウンドを生成するには、`beatmap_path`と`in_context=[NO_HS,TIMING,KIAI]`引数を使用してください。
- 曲のタイミングのみを生成するには、`super_timing=true`と`output_type=[TIMING]`引数を使用してください。

## MaiMod：AI駆動のモッディングツール

MaiModは、Mapperatorinatorの予測を使用して、[Mapset Verifier](https://github.com/Naxesss/MapsetVerifier)のような他の自動モッディングツールでは検出できない潜在的な欠陥や不整合を見つけるosu!ビートマップ用のモッディングツールです。
検出可能な問題例：
- 不適切なスナップやリズムパターン
- 不正確なタイミングポイント
- 不整合なヒットオブジェクトの位置や新しいコンボ配置
- 奇妙なスライダー形状
- 不整合なヒットサウンドや音量

MaiModは[こちら](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)で試すことができ、ローカルで実行することも可能です：
ローカルでMaiModを実行するには、Mapperatorinatorをインストールしてください。その後、`mai_mod.py`スクリプトを実行し、`beatmap_path`引数でビートマップのパスを指定します。
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
これはモッディングの提案をコンソールに出力し、その後手動でビートマップに適用できるようにします。  
提案は時系列で並べられ、カテゴリごとにグループ化されています。  
円の最初の値は「サプライズ度」を示しており、これはモデルが問題をどれだけ予想外と判断したかの指標で、重要な問題を優先的に処理できます。  

モデルは特にサプライズ度が低い問題については誤りを犯すことがあるため、ビートマップに適用する前に必ず提案を再確認してください。  
主な目的は、潜在的な問題の探索範囲を絞り込む手助けをすることで、ビートマップ内のすべてのヒットオブジェクトを手動で確認する必要を減らすことにあります。  

### MaiMod GUI  
MaiMod Web UIを実行するには、Mapperatorinatorをインストールする必要があります。  
次に、`mai_mod_ui.py`スクリプトを実行します。これによりローカルのウェブサーバーが起動し、新しいウィンドウでUIが自動的に開きます：

```sh
python mai_mod_ui.py
```
<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## 概要

### トークン化

Mapperatorinatorはosu!のビートマップを、中間のイベント表現に変換します。これにより、直接トークンに変換したり、トークンから復元したりできます。
この表現にはヒットオブジェクト、ヒットサウンド、スライダー速度、新しいコンボ、タイミングポイント、キアイタイム、太鼓/マニアのスクロール速度が含まれます。

トークン化プロセスの簡単な例を示します：

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

語彙サイズを節約するために、時間イベントは10ms間隔に量子化され、位置座標は32ピクセルのグリッドポイントに量子化されます。

### モデルアーキテクチャ
このモデルは基本的に[HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration)モデルのラッパーであり、カスタムの入力埋め込みと損失関数を備えています。
モデルのサイズは2億1900万パラメータに相当します。
このモデルはこのタスクにおいて、T5よりも高速かつ高精度であることが判明しました。

モデルの入出力の大まかな概要は次のとおりです：

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

モデルはエンコーダの入力としてメルスペクトログラムのフレームを使用し、1フレームが1入力位置に対応します。デコーダの出力は各ステップで事前定義された離散的なイベント語彙に対するソフトマックス分布です。出力は疎で、ヒットオブジェクトが発生したときのみイベントが必要であり、全てのオーディオフレームに注釈を付ける必要はありません。

### マルチタスク学習フォーマット

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

SOSトークンの前には条件付き生成を促進する追加トークンがあります。これらのトークンにはゲームモード、難易度、マッパーID、年、その他のメタデータが含まれます。
学習時にはこれらのトークンには対応するラベルがないため、モデルはこれらを出力しません。
また、学習中にはランダムにメタデータトークンが「不明」トークンに置き換えられることがあり、推論時にはこの「不明」トークンを使ってモデルに与えるメタデータの量を減らせます。

### シームレスな長時間生成

モデルのコンテキスト長は8.192秒です。これは完全なビートマップを生成するには明らかに不十分なので、曲を複数のウィンドウに分割し、小さな部分ごとにビートマップを生成します。
生成されたビートマップがウィンドウ間で目立つ継ぎ目を持たないように、90%の重複を使い、ウィンドウを順次生成します。
最初のウィンドウを除き、各生成ウィンドウは前のウィンドウからのトークンで生成ウィンドウの最大50%までデコーダが事前に埋められた状態で始まります。

生成ウィンドウの最初の50%にある時間トークンをモデルが生成できないようにするために、ロジットプロセッサを使用しています。  
さらに、生成ウィンドウの最後の40%は次のウィンドウのために予約されています。その範囲内で生成された時間トークンはEOSトークンとして扱われます。  
これにより、各生成トークンは少なくとも4秒の前のトークンと3.3秒の将来のオーディオを条件として生成されることが保証されます。  

長時間の生成中のオフセットのずれを防ぐために、トレーニング中のデコーダの時間イベントにランダムなオフセットが追加されています。  
これにより、タイミングエラーをオーディオのオンセットを聞くことで修正するよう強制され、一貫して正確なオフセットが得られます。  

### 拡散による座標の洗練  

デコーダによって生成された位置座標は32ピクセルのグリッドポイントに量子化されるため、その後に拡散を用いて座標を最終位置にデノイズします。  
これには、ノイズスケジュールの最後の10%のみに特化し、Mapperatorinatorが条件付き生成のために使用するより高度なメタデータトークンを受け入れる改良版の[osu-diffusion](https://github.com/OliBomby/osu-diffusion)をトレーニングしました。  

MapperatorinatorモデルはスライダーのSVを出力するため、コントロールポイント経路の形状に関係なく必要なスライダーの長さは固定されます。  
したがって、拡散プロセスをガイドして必要なスライダー長に合う座標を作成するようにしています。  
これは拡散プロセスの各ステップ後に、必要な長さと現在のコントロールポイント経路に基づいてスライダーの終端位置を再計算することで実現しています。  
つまり、拡散プロセスはスライダーの終端位置を直接制御できませんが、コントロールポイント経路を変更することで影響を与えることができます。  

### ポストプロセッシング  

Mapperatorinatorは生成されたビートマップの品質を向上させるためにいくつかの追加のポストプロセッシングを行います：  

- 拡散による位置座標の洗練。  
- モデルが生成したスナップ除数を使用して時間イベントを最も近いティックにリスナップ。  
- ほぼ完璧な位置の重なりをスナップ。  
- maniaのカラムイベントをX座標に変換。  
- 太鼓の連打用スライダーパスの生成。  
- 必要なスライダー長とコントロールポイント経路長の大きな不一致の修正。  

### スーパータイミングジェネレーター  

スーパータイミングジェネレーターは、曲全体のタイミングを20回推論し結果を平均化することで、生成されたタイミングの精度と正確さを向上させるアルゴリズムです。  
これは可変BPMの曲やBPM変更のある曲に有効で、結果はほぼ完璧で、時折手動調整が必要なセクションがある程度です。  

## トレーニング  

以下の手順はローカルマシン上にトレーニング環境を作成します。  

### 1. リポジトリをクローンする  

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. データセットの作成

[Mapperatorコンソールアプリ](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset)を使って独自のデータセットを作成してください。ビートマップの検証と追加メタデータの取得には、[osu! OAuthクライアントトークン](https://osu.ppy.sh/home/account/edit)が必要です。データセットは`Mapperatorinator`ディレクトリの隣にある`datasets`ディレクトリに配置してください。

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. （オプション）Weight & Biases のセットアップとログ記録
[Weight & Biases](https://wandb.ai/site) にアカウントを作成し、アカウント設定からAPIキーを取得します。
次に、`WANDB_API_KEY` 環境変数を設定して、トレーニングプロセスがこのキーにログを記録するようにします。

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Dockerコンテナの作成
venv内でのトレーニングも可能ですが、パフォーマンス向上のためにWSL上のDocker使用を推奨します。
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. パラメータの設定とトレーニング開始

すべての設定は `./configs/train/default.yaml` にあります。  
`train_dataset_path` と `test_dataset_path` をデータセットに合わせて正しく設定し、トレイン/テスト分割の開始および終了のマップセットインデックスも設定してください。  
パスはDockerコンテナ内のローカルパスなので、例えば `cool_dataset` というデータセットを `datasets` ディレクトリに置いた場合、パスは `/workspace/datasets/cool_dataset` となります。  

再現性のために、デフォルト設定を上書きするカスタム設定ファイルを作成することをお勧めします。

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRAファインチューニング

事前学習済みモデルを[LoRA](https://arxiv.org/abs/2106.09685)でファインチューニングし、特定のスタイルやゲームモードに適応させることもできます。  
これを行うには、`configs/train/lora.yaml`をニーズに合わせて調整し、`lora`トレーニング設定を実行してください：  

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```
重要なLoRAパラメータ:
- `pretrained_path`: ファインチューニングするベースモデルのパスまたはHFリポジトリ。
- `r`: LoRA行列のランク。値が大きいほどモデルの容量は増えるが、メモリ使用量も増加。
- `lora_alpha`: LoRAアップデートのスケーリングファクター。
- `total_steps`: トレーニングの総ステップ数。データセットのサイズに応じて調整。
- `enable_lora`: LoRAを使用するか、フルモデルのファインチューニングを行うか。

推論時には、`lora_path`引数で使用するLoRA重みを指定可能。
これはローカルパスかHugging Faceリポジトリのいずれか。

## 関連資料
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## クレジット

特別な感謝:
1. [osuT5](https://github.com/gyataro/osuT5) の作者のトレーニングコード。
2. Hugging Faceチームの[ツール](https://huggingface.co/docs/transformers/index)。
3. アイデア交換に協力してくれた[Jason Won](https://github.com/jaswon)と[Richard Nagyfi](https://github.com/sedthh)。
4. トレーニングクレジットを寄付してくれた[Marvin](https://github.com/minetoblend)。
5. ビートマップを提供してくれたosu!コミュニティ。

## 関連作品

1. Syps (Nick Sypteras)による[osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator)
2. kotritrona, jyvden, Yoyolick (Ryan Zmuda)による[osumapper](https://github.com/kotritrona/osumapper)
3. OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)による[osu-diffusion](https://github.com/OliBomby/osu-diffusion)
4. gyataro (Xiwen Teoh)による[osuT5](https://github.com/gyataro/osuT5)
5. sedthh (Richard Nagyfi)による[Beat Learning](https://github.com/sedthh/BeatLearning)
6. jaswon (Jason Won)による[osu!dreamer](https://github.com/jaswon/osu-dreamer)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---