# OneTwoVLA: 適応的推論を備えた統一視覚・言語・行動モデル

[[プロジェクトページ]](https://one-two-vla.github.io/) [[論文]](https://arxiv.org/abs/2505.11917) [[処理済みデータセット]](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)

[Fanqi Lin](https://fanqi-lin.github.io/)<sup>1,2,3,5\*</sup>,
[Ruiqian Nai](https://richard-coder-nai.github.io/)<sup>1,2,3,5\*</sup>,
[Yingdong Hu](https://yingdong-hu.github.io/)<sup>1,2,3\*</sup>,
[Jiacheng You](https://scholar.google.com/citations?user=FiP-TVUAAAAJ)<sup>1,2,3</sup>,
Junming Zhao<sup>1,4</sup>,
[Yang Gao](https://yang-gao.weebly.com/)<sup>1,2,3,5</sup>

<sup>1</sup>清華大学,
<sup>2</sup>上海啓智研究所,
<sup>3</sup>上海AIラボ, 
<sup>4</sup>復旦大学,
<sup>5</sup>Spirit AI

<sup>\*</sup> は同等の貢献を示します


## 🛠️ インストール

Pythonの依存関係は[uv](https://docs.astral.sh/uv/)で管理しています。`uv`をまだインストールしていない場合は、[uvインストール手順](https://docs.astral.sh/uv/getting-started/installation/)に従ってセットアップしてください。

環境を設定するには、以下を実行してください：

```bash
GIT_LFS_SKIP_SMUDGE=1 uv sync
GIT_LFS_SKIP_SMUDGE=1 uv pip install -e .
```

> 注意: 依存関係としてLeRobotを取得するには `GIT_LFS_SKIP_SMUDGE=1` が必要です。

詳細については、元の[openpiリポジトリ](https://github.com/Physical-Intelligence/openpi.git)を参照してください。

## 🚀 OneTwoVLAのトレーニング
データセットをダウンロードし、`$LEROBOT_HOME/umi/`の下に配置してください。

OneTwoVLAモデルをトレーニングするには、次のコマンドを実行します:
```bash
bash train_scripts/train_<task_name>.sh
```
利用可能なタスクは次のとおりです:
```bash
train_scripts
|-- train_onetwovla_cocktail.sh
|-- train_onetwovla_visual_grounding.sh
|-- train_pi0_cocktail.sh
|-- train_pi0_visual_grounding.sh
```
## 🦾 実世界での展開
推論はポリシーサーバーとハードウェアクライアントを使用して実行します。ポリシーサーバーの実行手順は[examples/umi/README.md](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/README.md)に記載されており、UMIハードウェアクライアントコードはこの[リポジトリ](https://github.com/Fanqi-Lin/OneTwoVLA-UMI-Client)で提供しています。

## 📷 データ
以下のデータセットへのアクセスを提供しています：

- `ロボットデータセット`：`cocktail`および`open-world visual grounding`タスクのためのデータセット。
- `ビジョン・言語データセット`：`open-world visual grounding`タスクの合成画像と注釈付き推論を含むデータセット。

すべてのデータセットはHugging Faceでホストされています。こちらからご覧いただけます：[here](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)。

UMIデータ形式をLeRobotデータ形式に変換するコードは[こちら](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/convert_umi_data_to_lerobot.py)で提供しています。

### 合成画像の増強

合成画像が実際のロボット観測により近づくように、ランダムに複数の増強処理を適用しています。これにはランダムな魚眼歪みや、ロボットグリッパーの合成と適応的明るさ調整が含まれます。実装は[scripts/augment_vl_data/augment.py](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/scripts/augment_vl_data/augment.py)でご覧いただけます。

以下に例を示します。左から順に、元画像、魚眼歪み適用画像、ロボットグリッパー合成と適応的明るさ調整画像、両方を適用した画像です。

<img width="90%" src="https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/figures/fisheye-aug.png">

## 🙏 謝辞
コードをオープンソース化してくださった[openpi](https://github.com/Physical-Intelligence/openpi.git)の開発者の皆様に心より感謝申し上げます。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---