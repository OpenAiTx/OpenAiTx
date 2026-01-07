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
  <img src="https://img.shields.io/badge/NeurIPS 2025-Main Conference-blue.svg" alt="NeurIPS 2025"/>
<p align="center">
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
  このプロジェクトが役立つと感じた場合、<br>
  GitHubでスター ⭐ をいただけると嬉しいです！
</p>

---

**ThinkSound** は、Chain-of-Thought（CoT）推論によるフロー・マッチングを活用した統合型Any2Audio生成フレームワークです。
PyTorchによるマルチモーダル音声生成および編集の実装：動画、テキスト、音声から音声を生成・編集可能。マルチモーダル大規模言語モデル（MLLM）の段階的な推論によって強化されています。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ニュース
- **2025.11.25** &nbsp; 🔥[オンラインPrismAudioデモ](http://prismaudio-project.github.io/)公開 - 今すぐお試しください！
- **2025.11.25** &nbsp; 🔥[PrismAudio論文](https://arxiv.org/pdf/2511.18833)がarXivに公開、初の多次元CoT-RLフレームワークによるVideo-to-Audio生成！
- **2025.09.19** &nbsp; 🎉 ThinkSoundが**NeurIPS 2025本会議**に採択されました！
- **2025.09.01** &nbsp; AudioCoTデータセットがオープンソース化され、[Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT)で入手可能になりました！
- **2025.07.17** &nbsp; 🧠 ファインチューニング対応：トレーニングおよびファインチューニングコードを公開、独自データでThinkSoundをカスタマイズ・拡張するための明確な使用方法も提供。
- **2025.07.15** &nbsp; 📦 インストール・利用が簡単に：PyPI依存関係でクロスプラットフォーム環境構築が容易に。Windows用`.bat`スクリプトで環境作成・スクリプト実行を自動化。
- **2025.07.08** &nbsp;  🔧 大幅アップデート：モデルの軽量化、メモリ・GPU使用最適化により、大規模な高スループット音声生成を実現！
- **2025.07.01** &nbsp; [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound)および[ModelScope](https://modelscope.cn/studios/iic/ThinkSound)でオンラインデモ公開、インタラクティブ体験が可能！
- **2025.07.01** &nbsp; 推論スクリプトとWebインターフェース公開； 
- **2025.06** &nbsp; [ThinkSound論文](https://arxiv.org/pdf/2506.21448)がarXivに公開！
- **2025.06** &nbsp; [オンラインデモ](http://thinksound-project.github.io/)公開 - 今すぐお試しください！

---


## 🚀 特徴

- **Any2Audio**: 任意のモダリティ（動画、テキスト、音声または組み合わせ）から音声を生成。
- **Video-to-Audio SOTA**: 複数のV2Aベンチマークで最先端の結果を達成。
- **CoT駆動推論**: MLLMを利用したChain-of-Thought推論による構成的かつ制御可能な音声生成。
- **インタラクティブなオブジェクト中心編集**: 視覚オブジェクトのクリックやテキスト指示で特定の音イベントを編集・改良。
- **統一フレームワーク**: ひとつの基盤モデルで生成、編集、インタラクティブなワークフローをサポート。

---

## ✨ 手法概要

ThinkSoundは音声生成と編集を、MLLMベースのChain-of-Thought（CoT）推論で導かれる3つのインタラクティブな段階に分解します：

1. **フォーリー生成:** 動画から意味的・時間的に整合した基礎的なサウンドスケープを生成。
2. **オブジェクト中心の改良:** 動画内のクリックや領域指定で、ユーザー指定オブジェクトの音を追加・改良。
3. **ターゲット音声編集:** 高レベルな自然言語指示で生成済み音声を修正。


![ThinkSound 概要](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模なCoTアノテーション済みデータセット（**AudioCoT**）を使用して、推論モジュールと統合音声基盤モデルの両方を訓練します。
![AudioCoT パイプライン](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ クイックスタート

**環境準備：**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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

[`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md) を参照してください


---

## 📝 TODO & 今後の計画
* - [ ] より強力な基礎モデルを公開し、複数のドメインをカバーしてより魅力的で没入感のあるフォーリー作成を提供
* - [ ] 追加のモダリティおよび下流タスクへの対応を追加
* - [ ] 異なるスケールのモデルを公開
* - [x] AudioCoTデータセットおよび自動化パイプラインのオープンソース化
* - [x] ThinkSoundモデル用のトレーニングスクリプト公開
* - [x] 初心者向けWindowsクイックスタートREADME
---


## 📄 ライセンス

このプロジェクトはApache 2.0ライセンスの下で公開されています。

> **注意:**
> コード、モデル、データセットは **研究および教育目的のみ** で利用可能です。
> **商用利用は許可されていません。**
> 商用ライセンスについては著者にお問い合わせください。

**📦 サードパーティコンポーネント**

* **Stable Audio Open VAE**（Stability AIによる）:
  このリポジトリには [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) からファインチューニングされたVAEが含まれており、[Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)の下でライセンスされています。
  **商用利用および再配布にはStability AIの事前許可が必要です。**

* 📘 **その他のコードおよびモデル** はApache License 2.0の下で公開されています。

---

## 謝辞

感謝：

* **stable-audio-tools**（Stability AI 提供）：
音声生成のための使いやすいフレームワーク、ならびにVAEモジュールと重みをご提供いただきました。
* **MMAudio**：
  オーディオ領域におけるMM-DiTバックボーンの実装に感謝します。

---

## 📖 引用

もしThinkSoundが研究や業務で役立った場合は、ぜひ私たちの論文を引用してください：

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
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-07

---