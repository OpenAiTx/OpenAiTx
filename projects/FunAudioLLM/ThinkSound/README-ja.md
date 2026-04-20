<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  このプロジェクトが役に立ったと感じたら、<br>
  GitHubでスター ⭐ を付けていただけると嬉しいです！
</p>

---

## リポジトリ構成
この **ThinkSound** GitHubリポジトリは、2つの関連プロジェクトを別々のブランチでホストしています：

| ブランチ | プロジェクト | ドキュメント |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — CoTガイド付きフローマッチングによる統一型Any2Audio生成 | 本ファイル：**`README.md`** |
| **`prismaudio`** | **PrismAudio** — マルチディメンショナルCoT-RLによるビデオから音声への後続研究（ICLR 2026） | [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio)ブランチの**`README.md`** |

**ThinkSound**の場合は、**`master`**ブランチ（このREADME）を使用してください。**PrismAudio**の場合は、**`prismaudio`**をチェックアウトし、そちらの**`README.md`**に従ってください。

---

**ThinkSound**はChain-of-Thought（CoT）推論によりガイドされたフローマッチングを特徴とする統一Any2Audio生成フレームワークです。

PyTorch実装によるマルチモーダル音声生成および編集：ビデオ・テキスト・音声からの生成/編集に対応し、マルチモーダル大規模言語モデル（MLLM）によるステップバイステップ推論を活用します。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ニュース
- **2026.03.24** &nbsp; 🔥 **PrismAudio**が同リポジトリの[`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio)ブランチで公開 — セットアップとモデルは**`README.md`**を参照。
- **2026.01.26** &nbsp; 🎉 PrismAudioが**ICLR 2026 メインカンファレンス**に採択（`prismaudio`でコード/ドキュメント公開）。
- **2025.11.25** &nbsp; 🔥 [オンラインPrismAudioデモ](http://prismaudio-project.github.io/)が公開。
- **2025.11.25** &nbsp; 🔥 [PrismAudio論文](https://arxiv.org/pdf/2511.18833)がarXivに公開 — ビデオから音声へのマルチディメンショナルCoT-RL。
- **2025.09.19** &nbsp; 🎉 **ThinkSound**が**NeurIPS 2025 メインカンファレンス**に採択！
- **2025.09.01** &nbsp; 当社のAudioCoTデータセットが[Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)でオープンソース化されました！
- **2025.07.17** &nbsp; 🧠 ファインチューニング対応：トレーニングとファインチューニング用コードが一般公開され、独自データでThinkSoundをカスタマイズ・拡張するための明確な使い方ガイドも付属。
- **2025.07.15** &nbsp; 📦 インストールと使いやすさを簡素化：PyPI依存関係によるクロスプラットフォームセットアップ対応、Windows用.batスクリプトで環境構築やスクリプト実行を自動化。
- **2025.07.08** &nbsp;  🔧 大幅アップデート：モデルの軽量化とメモリ・GPU使用量を最適化、大規模な高スループット音声生成に対応！
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound)および[ModelScope](https://modelscope.cn/studios/iic/ThinkSound)でオンラインデモ公開、インタラクティブ体験可能！
- **2025.07.01** &nbsp; 推論スクリプトとWebインターフェースを公開； 
- **2025.06** &nbsp; [ThinkSound論文](https://arxiv.org/pdf/2506.21448)をarXivで公開！
- **2025.06** &nbsp; [オンラインデモ](http://thinksound-project.github.io/)が公開中 - ぜひお試しください！

---


<div align="center">

### フォローアップ：PrismAudio（同リポジトリ、`prismaudio`ブランチ）


**PrismAudio** は ThinkSound (ICLR 2026) の後継であり、新しい名称で開発されましたが、このリポジトリの **`prismaudio`** ブランチ上で管理されています。インストール、チェックポイント、引用については **[`そのブランチのREADME.md`](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)** を参照してください。

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) またはGitHub上でブランチを開いてください。

</div>

---


## 🚀 特徴

- **Any2Audio**: 任意のモダリティ（動画、テキスト、音声、またはその組み合わせ）から音声を生成。
- **Video-to-Audio SOTA**: 複数のV2Aベンチマークで最先端の結果を達成。
- **CoT駆動推論**: MLLMによる連鎖的思考(Chain-of-Thought)推論で構成的かつ制御可能な音声生成を実現。
- **インタラクティブなオブジェクト中心編集**: 視覚的なオブジェクトをクリック、またはテキスト指示で特定の音声イベントを修正・編集可能。
- **統一フレームワーク**: 1つの基盤モデルが生成・編集・インタラクティブなワークフローをサポート。

---

## ✨ メソッド概要

ThinkSoundは、音声生成と編集をMLLMベースの連鎖的思考推論により、3つのインタラクティブな段階に分解します：

1. **フォリー生成:** 動画から意味的・時間的に整合した基礎的なサウンドスケープを生成。
2. **オブジェクト中心のリファインメント:** ユーザー指定オブジェクトに対してクリックや領域指定で音を追加・精緻化。
3. **ターゲット音声編集:** 高レベルの自然言語指示で生成音声を編集。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模なCoTアノテーション付きデータセット(**AudioCoT**)を用いて推論モジュールと統一音声基盤モデルの両方を学習。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ クイックスタート

**環境準備:**
```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windowsのヒント：**  
> Windowsユーザーは、`setup_windows.bat` を実行（またはダブルクリック）するだけで、自動的にconda環境が作成され、すべての依存関係（FFmpegを含む）がインストールされ、学習済みモデルがダウンロードされます — 手動でのセットアップは不要です。  
> スクリプトを実行する前に、`conda` および `git` がインストールされており、システムPATHに追加されていることを確認してください。


### ▶️ デモの実行

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

代わりに、用意された `.bat` スクリプトを使用できます。


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**注意:**

* `<path-to-your-demo-video>`: 単一ビデオへのパス
* `[use-half]`（オプション）: 最後にuse-halfを追加して半精度特徴抽出を有効にします。

---

### 📦 バッチ推論

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

同等の `.bat` スクリプトを使用してください:


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**注意:**

* `<video_path>`: 処理するすべての.mp4動画を含むルートディレクトリへのパス（すべての動画は同じ長さである必要があります）。
* `<csv_path>`: 各動画に対応するテキストプロンプトが記載されたCSVファイル（形式は`demo_test.csv`を参照）。
* `<save_path>`（オプション）: 生成された音声の保存先。デフォルトは`results/features`。
* `[use-half]`（オプション）: 最後にuse-halfを追加すると半精度特徴量抽出を有効化します。

---


### Webインターフェースの利用

インタラクティブな操作を行うには、GradioのWebインターフェースを起動してください。


```bash
python app.py
```
## 🏋️ モデルのトレーニング

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) を参照してください。


---


## 📄 ライセンス

本プロジェクトはApache 2.0ライセンスの下で公開されています。

> **注意:**
> コード、モデル、データセットは**研究および教育目的に限り**使用できます。
> **商用利用は禁止されています。**
> 商用ライセンスについては、著者にお問い合わせください。

**📦 サードパーティーコンポーネント**

* **Stable Audio Open VAE**（Stability AI提供）:
  本リポジトリには [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) からファインチューニングされたVAEが含まれており、[Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) のもとでライセンスされています。
  **商用利用および再配布にはStability AIの事前許可が必要です。**

* 📘 **その他のすべてのコードおよびモデル**はApache License 2.0のもとで公開されています。

---

## 謝辞

多大なる感謝を:

* **stable-audio-tools**（Stability AI提供）:
  オーディオ生成のための使いやすいフレームワークおよびVAEモジュールと重みの提供に感謝します。
* **MMAudio**:
  オーディオ領域におけるMM-DiTバックボーンの実装に感謝します。

---



## 📖 引用

本プロジェクトがあなたの研究や業務に役立った場合は、ぜひ私たちの論文を引用してください。

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---