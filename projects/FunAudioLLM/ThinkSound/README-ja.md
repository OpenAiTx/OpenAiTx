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
  このプロジェクトが役に立った場合、<br>
  GitHubでスター ⭐ を付けていただけると大変嬉しいです！
</p>

---

**ThinkSound** は、Chain-of-Thought（CoT）推論によるフローマッチングを用いた統一型Any2Audio生成フレームワークです。

PyTorchによるマルチモーダル音声生成・編集の実装：動画・テキスト・音声からの生成や編集を、マルチモーダル大規模言語モデル（MLLM）による逐次推論で実現します。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 ニュース
- **2025.07.15** &nbsp; 📦 インストールと使いやすさを簡素化：依存関係をPyPIに集約しクロスプラットフォーム対応を実現；Windows用`.bat`スクリプトで環境構築やスクリプト実行を自動化。
- **2025.07.08** &nbsp;  🔧 主要アップデート：モデルの軽量化・メモリおよびGPU使用量の最適化、大規模な高スループット音声生成に対応！
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) および [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) でのオンラインデモを公開、インタラクティブ体験が可能！
- **2025.07.01** &nbsp; 🔥推論用スクリプトとWebインターフェースをリリース； 
- **2025.06** &nbsp; 🔥[ThinkSound 論文](https://arxiv.org/pdf/2506.21448) がarXivで公開！
- **2025.06** &nbsp; 🔥[オンラインデモ](http://thinksound-project.github.io/) が公開中 - ぜひお試しください！

---


## 🚀 特徴

- **Any2Audio**：動画・テキスト・音声やその組み合わせなど、任意のモダリティから音声を生成。
- **Video-to-Audio SOTA**：複数のV2Aベンチマークで最先端の成果を達成。
- **CoT駆動推論**：MLLMによるChain-of-Thought推論で、構成的かつ制御可能な音声生成を実現。
- **インタラクティブなオブジェクト中心編集**：視覚オブジェクトのクリックやテキスト指示で、特定の音イベントを洗練・編集。
- **統一フレームワーク**：生成・編集・インタラクティブワークフローを一つの基盤モデルでサポート。

---

## ✨ メソッド概要

ThinkSoundは音声生成・編集を、MLLMベースのChain-of-Thought（CoT）推論でガイドされる3つのインタラクティブな段階に分解します：

1. **フォリー生成：** 動画から意味的・時間的に整合した基礎的なサウンドスケープを生成。
2. **オブジェクト中心リファインメント：** 動画内のクリックや領域指定でユーザー指定オブジェクトの音を洗練・追加。
3. **ターゲット音声編集：** 高レベルな自然言語指示で生成音声を修正。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模CoTアノテーション済みデータセット（**AudioCoT**）を用いて推論モジュールと統一音声基盤モデルを学習。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

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
---

## 📝 TODO & 今後の計画
* - [ ] ThinkSoundモデルのトレーニングスクリプトを公開（2025年7月20日以前を予定）
* - [ ] AudioCoTデータセットおよび自動化パイプラインのオープンソース化（2025年7月23日以前を予定）
* - [ ] すぐに使用可能な環境イメージの提供（2025年7月23日以前を予定）
* - [ ] 複数のドメインをカバーする、より強力な基盤モデルの公開。より魅力的で没入感のあるフォーリー作成を提供（2025年8月末までを予定）
* - [ ] 追加のモダリティとダウンストリームタスクへの対応追加（2025年7月末までを予定）
* - [ ] 異なるスケールのモデル公開（2025年7月末までを予定）
* - [x] 初心者向けWindowsクイックスタートREADME
---


## 📄 ライセンス

本プロジェクトはApache 2.0ライセンスの下で公開されています。

> **注意:**
> コード、モデル、データセットは**研究および教育目的のみに使用可能**です。
> **商用利用は禁止されています。**
> 商用ライセンスについては著者までご連絡ください。

**📦 サードパーティコンポーネント**

* **Stable Audio Open VAE**（Stability AI提供）:
  このリポジトリには [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) からファインチューニングされたVAEが含まれており、[Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) の下でライセンスされています。
  **商用利用および再配布にはStability AIの事前許可が必要です。**

* 📘 **その他すべてのコードおよびモデル**はApache License 2.0の下で公開されています。

---

## 謝辞

以下の方々に深く感謝いたします：

* **stable-audio-tools**（Stability AI提供）:
オーディオ生成のための使いやすいフレームワーク、およびVAEモジュールと重みを提供していただきました。
* **MMAudio**:
  オーディオ領域におけるMM-DiTバックボーンの実装を提供していただきました。

---

## 📖 引用

ThinkSoundがあなたの研究や仕事に役立った場合は、ぜひ本論文を引用してください：


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

## 📬 お問い合わせ

✨ ご質問やご提案がございましたら、[Issueをオープン](https://github.com/liuhuadai/ThinkSound/issues)するか、メール（[liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)）でお気軽にご連絡ください！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---