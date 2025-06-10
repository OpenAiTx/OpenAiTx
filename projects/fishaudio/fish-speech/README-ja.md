<div align="center">
<h1>Fish Speech</h1>

**English** | [简体中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **ライセンスに関する注意**  
> このコードベースは**Apache License**の下でリリースされており、すべてのモデル重みは**CC-BY-NC-SA-4.0 License**の下でリリースされています。詳細は[LICENSE](LICENSE)をご参照ください。

> [!WARNING]
> **法的免責事項**  
> 本コードベースの不正利用について、当方は一切の責任を負いません。DMCAなど関連法規については、お住まいの地域の法律をご確認ください。

---

## 🎉 お知らせ

私たちは**OpenAudio**へとリブランディングし、Fish-Speechの基盤の上に構築された革新的な新シリーズの高度なテキスト読み上げモデルを発表できることを嬉しく思います。

本シリーズの最初のモデルとして、品質・性能・機能性において大幅な向上を実現した**OpenAudio-S1**をリリースいたします。

OpenAudio-S1には**OpenAudio-S1**と**OpenAudio-S1-mini**の2バージョンがあり、どちらも[Fish Audio Playground](https://fish.audio)（**OpenAudio-S1**）および[Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini)（**OpenAudio-S1-mini**）でご利用いただけます。

ブログや技術レポートは[OpenAudio公式サイト](https://openaudio.com/blogs/s1)をご覧ください。

## 主な特長 ✨

### **優れたTTS品質**

Seed TTS評価指標を用いてモデル性能を評価した結果、OpenAudio S1は英語テキストで**0.008 WER**および**0.004 CER**を達成し、従来モデルよりも大幅に高い精度を示しました。（英語、自動評価、OpenAI gpt-4o-transcribeベース、話者距離はRevai/pyannote-wespeaker-voxceleb-resnet34-LM利用）

| モデル | Word Error Rate (WER) | Character Error Rate (CER) | Speaker Distance |
|--------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **TTS-Arena2で最高評価** 🏆

OpenAudio S1は、テキスト読み上げベンチマーク[TTS-Arena2](https://arena.speechcolab.org/)で**第1位**を獲得しました。

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **音声コントロール**

OpenAudio S1は**多様な感情・トーン・特殊マーカー**をサポートし、音声合成の表現力を高めます。

- **基本感情**:
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **高度な感情**:
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **トーンマーカー**:
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **特殊音声効果**:
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

Ha,ha,haのような記述でもコントロール可能です。他にも様々な使い方がありますので、ぜひお試しください。

（現在、英語・中国語・日本語に対応。今後さらに多言語対応予定！）

### **2種類のモデル**

| モデル | サイズ | 提供状況 | 特徴 |
|--------|--------|----------|------|
| **S1** | 40億パラメータ | [fish.audio](fish.audio)で利用可能 | フル機能のフラッグシップモデル |
| **S1-mini** | 5億パラメータ | huggingfaceの[hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini)で利用可能 | コア機能を持つ蒸留版 |

S1およびS1-miniともに、オンラインでの人間フィードバックによる強化学習（RLHF）を導入しています。

## **機能一覧**

1. **ゼロショット＆フューショットTTS:** 10～30秒の音声サンプルを入力するだけで、高品質なTTS出力が可能。**詳細ガイドは[Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices)をご覧ください。**

2. **多言語・クロスリンガル対応:** マルチリンガルテキストをそのまま入力欄に貼り付けるだけでOK。言語指定は不要。現在、英語・日本語・韓国語・中国語・フランス語・ドイツ語・アラビア語・スペイン語に対応。

3. **音素非依存:** 本モデルは高い汎化能力を持ち、TTSに音素情報を必要としません。あらゆる言語スクリプトのテキストを扱えます。

4. **高精度:** Seed-TTS評価でCER（文字誤り率）約0.4%、WER（単語誤り率）約0.8%を実現。

5. **高速:** fish-techアクセラレーションにより、Nvidia RTX 4060ラップトップでリアルタイムファクター約1:5、Nvidia RTX 4090で約1:15。

6. **WebUI推論:** Gradioベースの直感的なWeb UIを搭載し、Chrome・Firefox・Edge等の各種ブラウザに対応。

7. **GUI推論:** PyQt6によるグラフィカルインターフェースも利用可能で、APIサーバーとシームレスに連携。Linux・Windows・macOS対応。[GUIを見る](https://github.com/AnyaCoder/fish-speech-gui)

8. **デプロイ容易:** Linux、Windows（MacOSは近日対応予定）でネイティブに推論サーバーを簡単セットアップ。速度低下を最小限に抑えます。

## **メディア・デモ**

<div align="center">

### **ソーシャルメディア**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **インタラクティブデモ**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **ビデオ紹介**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **音声サンプル**
<div style="margin: 20px 0;">
    <em> 近日中に高品質な音声サンプルを公開予定です。多言語・多感情TTSの性能をご確認いただけます。</em>
</div>

</div>

---

## ドキュメント

- [ビルド環境](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [推論方法](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## クレジット

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## 技術レポート (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
```
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---