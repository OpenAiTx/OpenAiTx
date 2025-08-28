<div align="center">

<!-- TITLE -->
# **拡散言語モデルは超データ学習者である**

[![Static Badge](https://img.shields.io/badge/Blog-2025--08--09-darkcyan)](https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/cloudposse.svg?style=social&label=tweet)](https://x.com/NiJinjie/status/1954177095435014533)
</div>

# ハイライト
- 私たちはDLMとARモデルをゼロから最大**8Bパラメータ**かつ**480Bトークン**まで事前学習しました。DLMは自己回帰（AR）モデルと比較して> **3倍**以上のデータ活用能力を示します。特に、1Bパラメータのマスク拡散モデルは、特別な工夫なしに標準的な事前学習データを繰り返すだけで、HellaSwagで> **56%**、MMLUで> **33%**の精度をわずか**1B**トークンで達成しました。繰り返し回数を増やせばさらに性能が向上する可能性があり、**収益逓減の兆候は見られません**でした。
- DLMは密なARモデルよりも多くのFLOPsを消費する超高密度モデルです。DLMをデータ活用で最大限に活かすには通常、少なくとも**2桁以上**多いFLOPsが必要です。推論時には、16から4096トークンの生成でARベースラインと比較して**16倍〜4700倍**のFLOPs増加が発生します。さらに、拡散目的によって実現されるより表現力豊かな双方向注意機構により、**完全に因果的でない言語データの双方向モデリング**が可能となり、その価値を最大限に引き出します。
- 私たちの並行研究「Diffusion Beats Autoregressive in Data-Constrained Settings」には、**問題のある拡散損失の定式化、比較に無効な指標、ARモデルに不公平な設定、問題のあるスケーリング則の定式化**など、問題となりうる方法論上の課題が含まれており、これらは疑わしい結果や結論を導く可能性があります。

<br>

# クロスオーバー
<p align="center" width="100%">
<img src="https://raw.githubusercontent.com/JinjieNi/dlms-are-super-data-learners/main/resources/imgs/1.jpg"  width="80%" height="100%">
</p>

*ブログの図A：限られたデータの一部を繰り返し使用した際の自己回帰（AR）モデルとマスク拡散モデル（Diffusion）の性能比較。全モデルは計96Bトークン（繰り返しを含む）で訓練され、ユニークトークン数を0.5Bから96Bまで変化させています。拡散モデルは限られたユニークデータに対して繰り返しを増やすことでデータをより有効に活用します。ユニークトークン数が多い場合、クロスオーバーを見るにはより多くの繰り返しが必要であり、高いユニークトークン数の実験はクロスオーバーが96Bトークンの観察範囲を超えて遅延します。*

<br>

# 引用
```
@misc{ni2025difflm,
title={Diffusion Language Models are Super Data Learners},
author={Jinjie Ni and the team},
year={2025},
howpublished={\url{https://jinjieni.notion.site/Diffusion-Language-Models-are-Super-Data-Learners-239d8f03a866800ab196e49928c019ac}},
note={Notion Blog},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---