<div align="center">

<img alt="LOGO" src="https://raw.githubusercontent.com/fishaudio/Bert-VITS2/master/avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

多言語BERTを用いたVITS2バックボーン

クイックガイドについては、`webui_preprocess.py`を参照してください。

简易教程请参见 `webui_preprocess.py`。

## 【プロジェクト紹介】
# FishAudioによる新しい自己回帰型TTS [Fish-Speech](https://github.com/fishaudio/fish-speech)が利用可能になりました。現時点でのオープンソースSOTA水準の性能を持ち、継続的にメンテナンスされています。BV2/GSVの代替として本プロジェクトの使用を推奨します。本プロジェクトは短期間でのメンテナンスを終了します。
## デモ動画: https://www.bilibili.com/video/BV18E421371Q
## 技術スライド動画: https://www.bilibili.com/video/BV1zJ4m1K7cj
## ご注意：本プロジェクトの核心的アイデアは[anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)という非常に優れたTTSプロジェクトに由来します。
## MassTTSのデモは[ai版峰哥锐评峰哥本人,并找回了在金三角失落的腰子](https://www.bilibili.com/video/BV1w24y1c7z9)です。

[//]: # (## 本项目与[PlayVoice/vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41; 没有任何关系)

[//]: # ()
[//]: # (本仓库来源于之前朋友分享了ai峰哥的视频，本人被其中的效果惊艳，在自己尝试MassTTS以后发现fs在音质方面与vits有一定差距，并且training的pipeline比vits更复杂，因此按照其思路将bert)

## 熟練者、開拓者、艦長、博士、先生、ハンター、ニャーニャール、Vの方はコードを参照して自身で学習方法を確認してください。

### 本プロジェクトを中華人民共和国憲法、中華人民共和国刑法、中華人民共和国治安管理処罰法、中華人民共和国民法典に違反する目的での使用を厳禁します。
### 政治関連の目的での使用を厳禁します。
#### 動画:https://www.bilibili.com/video/BV1hp4y1K78E
#### デモ:https://www.bilibili.com/video/BV1TF411k78w
## 参考文献
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## すべての貢献者の努力に感謝します
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# 本项目所有代码引用均已写明，bert部分代码思路来源于[AI峰哥]&#40;https://www.bilibili.com/video/BV1w24y1c7z9&#41;，与[vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41;无任何关系。欢迎各位查阅代码。同时，我们也对该开发者的[碰瓷，乃至开盒开发者的行为]&#40;https://www.bilibili.com/read/cv27101514/&#41;表示强烈谴责。)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---