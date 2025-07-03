# 🎶 ThinkSound

<p align="center">
  このプロジェクトが役に立った場合は、GitHubでスター ⭐ を付けていただけると嬉しいです！
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

---

**ThinkSound**はChain-of-Thought（CoT）推論によるフローマッチングに基づく統一型Any2Audio生成フレームワークです。

マルチモーダル大規模言語モデル（MLLM）の段階的推論により、ビデオ・テキスト・オーディオから音声を生成・編集するためのPyTorch実装です。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 News
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound)および[ModelScope](https://modelscope.cn/studios/iic/ThinkSound)上でオンラインデモが公開され、インタラクティブ体験が可能に！
- **2025.07** &nbsp; 🔥推論用スクリプトとWebインターフェースをリリース；
- **2025.06** &nbsp; 🔥[ThinkSound 論文](https://arxiv.org/pdf/2506.21448)がarXivに公開！
- **2025.06** &nbsp; 🔥[オンラインデモ](http://thinksound-project.github.io/)が公開中 - 今すぐお試しください！

---

## 🚀 特徴

- **Any2Audio**: ビデオ、テキスト、オーディオ、またはそれらの組み合わせなど任意のモダリティから音声を生成。
- **ビデオから音声へのSOTA**: 複数のV2Aベンチマークで最先端の結果を達成。
- **CoT駆動の推論**: MLLMによるChain-of-Thought推論で、構成的かつ制御可能な音声生成を実現。
- **インタラクティブなオブジェクト中心編集**: ビジュアルオブジェクトをクリックしたりテキスト指示で、特定のサウンドイベントを微調整・編集可能。
- **統一フレームワーク**: 1つの基盤モデルで生成・編集・インタラクティブなワークフローをサポート。

---

## ✨ メソッド概要

ThinkSoundは音声生成と編集を、すべてMLLMベースのChain-of-Thought（CoT）推論によって導かれる3つのインタラクティブなステージに分解します：

1. **フォーリー生成:** ビデオから意味的・時間的に整合した基礎的なサウンドスケープを生成。
2. **オブジェクト中心のリファインメント:** ビデオ内のクリックや領域指定により、ユーザーが指定したオブジェクト用の音を微調整または追加。
3. **ターゲット音声編集:** 高レベルな自然言語指示で生成された音声を編集。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模なCoTアノテーション付きデータセット（**AudioCoT**）を用いて、推論モジュールと統一音声基盤モデルを学習しています。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ クイックスタート

**環境準備:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# 事前学習済み重みを https://huggingface.co/liuhuadai/ThinkSound よりダウンロードし、ckpts/ ディレクトリに配置
# モデルの重みは https://www.modelscope.cn/models/iic/ThinkSound からもダウンロード可能
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**実行権限の付与**
```bash
chmod +x scripts/demo.sh
```

**スクリプトの実行**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Webインターフェースの利用

インタラクティブな体験には、GradioのWebインターフェースを起動してください：

```bash
python app.py
```

---
## 📝 TODO

- ☐ ThinkSoundモデルのトレーニングスクリプトを公開
- ☐ AudioCoTデータセットおよび自動化パイプラインをオープンソース化
- ☐ 詳細なドキュメントとAPIリファレンスを提供
- ☐ 追加のモダリティおよび下流タスクへの対応を追加

---

## 📄 ライセンス

本プロジェクトは [Apache 2.0 License](LICENSE) のもとで公開されています。

> **注意:**  
> コード、モデル、およびデータセットは**研究および教育目的に限り使用可能**です。  
> **商用利用は禁止されています。**
>
> 商用ライセンスについては、著者までご連絡ください。

---

## 📖 引用

ThinkSoundがあなたの研究や業務に役立った場合は、以下の論文を引用してください:

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

✨ ご質問やご提案がありましたら、[issueをオープン](https://github.com/liuhuadai/ThinkSound/issues)いただくか、メール（[liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)）でお気軽にご連絡ください！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---