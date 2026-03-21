<div align="center">
<h1>現実的なUAVビジョン・言語ナビゲーションに向けて：プラットフォーム、ベンチマーク、および方法論</h1>

<image src="./header.png" width="70%">

<a href="https://arxiv.org/abs/2410.07087"><img src='https://img.shields.io/badge/arXiv-TRAVEL: UAV VLN Platform, Benchmark, and Methodology-red' alt='Paper PDF'></a>
<a href='https://prince687028.github.io/Travel/'><img src='https://img.shields.io/badge/Project_Page-TRAVEL-green' alt='Project Page'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV'><img src='https://img.shields.io/badge/Dataset-TRAVEL-blue'></a>
<a href='https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env'><img src='https://img.shields.io/badge/Env-TRAVEL-blue'></a>

</div>

## 目次

- [はじめに](#introduction)
- [依存関係](#dependencies)
- [準備](#prepare-the-data)
- [使い方](#usage)
- [引用](#paper)

## ニュース
- **2025-05-22:** 言語条件付きUAV模倣学習のための初の実世界ベンチマークであるUAV-Flowをリリースしました。（プロジェクトページ：https://prince687028.github.io/UAV-Flow）
- **2025-01-25:** 論文、プロジェクトページ、コード、データ、環境およびモデルがすべて公開されました。

# はじめに

本研究は、**_現実的なUAVビジョン・言語ナビゲーションに向けて：プラットフォーム、ベンチマーク、および方法論_**を提案します。UAVシミュレーションプラットフォーム、アシスタントガイドによる現実的なUAV VLNベンチマーク、ならびに現実的なUAVビジョン・言語ナビゲーションの課題に対処するMLLMベースの手法を紹介します。

# 依存関係

### `llamauav`環境の作成

```bash
conda create -n llamauav python=3.10 -y
conda activate llamauav
pip install torch==2.0.1 torchvision==0.15.2 torchaudio==2.0.2 --index-url https://download.pytorch.org/whl/cu118
```

## LLaMA-UAVモデルのインストール

[こちらのLLaMA-UAV](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#install)を参照してllmの依存関係をインストールできます。

### requirementsファイルに記載されているその他の依存関係をインストールする

```bash
pip install -r requirement.txt
```
さらに、AirSimのPython APIとの互換性を確保するために、[AirSim issue](https://github.com/microsoft/AirSim/issues/3333#issuecomment-827894198)で言及されている修正を適用してください。

# 準備

## データ

データセットを準備するには、[Dataset セクション](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md#dataset)に記載された指示に従ってデータセットを構築してください。

## モデル

### GroundingDINO

GroundingDINOモデルは、[groundingdino_swint_ogc.pth](https://huggingface.co/ShilongLiu/GroundingDINO/resolve/main/groundingdino_swint_ogc.pth)からダウンロードし、ファイルを `src/model_wrapper/utils/GroundingDINO/` ディレクトリに配置してください。

### LLaMA-UAV

モデルのセットアップについては、詳細な[Model Setup](https://raw.githubusercontent.com/prince687028/TravelUAV/main/./Model/LLaMA-UAV/README.md)を参照してください。

## シミュレータ環境

様々なマップ用のシミュレータ環境は[こちら](https://huggingface.co/datasets/wangxiangyu0814/TravelUAV_env)からダウンロードしてください。

環境のファイルディレクトリは以下の通りです：


```
├── carla_town_envs
│   ├── Town01
│   ├── Town02
│   ├── Town03
│   ├── ...
├── closeloop_envs
│   ├── Engine
│   ├── ModularEuropean
│   ├── ModularEuropean.sh
│   ├── ModularPark
│   ├── ModularPark.sh
│   ├── ...
├── extra_envs
│   ├── BrushifyUrban
│   ├── BrushifyCountryRoads
│   ├── ...
```

# 使用方法

1. シミュレータ環境サーバーの設定

シミュレーションを実行する前に、AirSim環境サーバーが適切に設定されていることを確認してください。

> `AirVLNSimulatorServerTool.py`内の`root_path`に対して相対的なenv実行ファイルのパス`env_exec_path_dict`を更新してください。

```bash
cd airsim_plugin
python AirVLNSimulatorServerTool.py --port 30000 --root_path /path/to/your/envs
```

2. クローズドループシミュレーションを実行する

シミュレータサーバーが起動している場合、daggerまたは評価スクリプトを実行できます。

```bash
# Dagger NYC
bash scripts/dagger_NYC.sh
# Eval
bash scripts/eval.sh
bash scripts/metrics.sh
```

# 論文

このプロジェクトが役立つと感じたら、次の論文を引用してください: [論文](https://arxiv.org/abs/2410.07087):

```
@misc{wang2024realisticuavvisionlanguagenavigation,
      title={Towards Realistic UAV Vision-Language Navigation: Platform, Benchmark, and Methodology},
      author={Xiangyu Wang and Donglin Yang and Ziqin Wang and Hohin Kwan and Jinyu Chen and Wenjun Wu and Hongsheng Li and Yue Liao and Si Liu},
      year={2024},
      eprint={2410.07087},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2410.07087},
}
```

# 謝辞

このリポジトリは一部、[AirVLN](https://github.com/AirVLN/AirVLN)および[LLama-VID](https://github.com/dvlab-research/LLaMA-VID)のリポジトリを基にしています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---