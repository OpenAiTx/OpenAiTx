# 言語モデルは本当に時系列予測に役立つのか？

**（NeurIPS 2024 スポットライト）** 🌟 [論文リンク](https://arxiv.org/pdf/2406.16964)

本研究では、時系列予測（TSF）におけるLLMの最近の人気にもかかわらず、性能を大きく向上させることはほとんどないことを示しました。簡単なベースラインである「PAttn」を提案し、ほとんどのLLMベースのTSFモデルよりも優れた性能を示しました。

著者：[Mingtian Tan](https://x.com/MTTan1203)、[Mike A. Merrill](https://mikemerrill.io/)、[Vinayak Gupta](https://gvinayak.github.io/)、[Tim Althoff](https://homes.cs.washington.edu/~althoff/)、[Thomas Hartvigsen](https://www.tomhartvigsen.com/)

### 自己回帰型LLMは将来の時系列を推論（予測）するための文脈活用に大きな可能性を持つが、本論文で言及した時系列予測モデルはそうではない。

テキストを通じた時系列の推論（予測）については、こちらの[時系列推論（予測）研究](https://github.com/behavioral-data/TSandLanguage/tree/main/text_aid_forecast)を参照してください。

## 概要 💁🏼
最近の時系列解析の研究は、事前学習済み大規模言語モデル（LLM）を**予測（TSF）**、分類、異常検知に適用することに注目しています。これらの研究は、テキストにおける連続的依存関係を対象とした言語モデルが時系列データに一般化できる可能性を示唆しています。このアイデアは機械学習における言語モデルの人気と合致しますが、言語モデリングとTSFの直接的な関連はまだ不明瞭です。**従来のTSFタスクに対して言語モデルはどれほど有効なのでしょうか？**

３つの最近の**LLMベースTSF**手法に対するアブレーション研究を通じて、**LLM成分を除去または単純な注意層に置き換えても結果が悪化せず、多くの場合改善すら見られました。**さらに、PAttnを導入し、パッチ処理と注意機構が最先端のLLMベース予測器と同等の性能を発揮することを示しました。

![Ablations/PAttn](https://raw.githubusercontent.com/BennyTMT/LLMsForTimeSeries/main/pic/ablations.png)

## データセット 📖
[Google Drive](https://drive.google.com/file/d/1NF7VEefXCmXuWNbnNe858WvQAkJ_7wuP/view)から適切に前処理されたデータセットを入手し、ダウンロードした内容を./datasets配下に配置してください。

## セットアップ 🔧
３つの人気LLMベースTSF手法をアブレーションに含めました。対応するリポジトリ、[OneFitsAll](https://github.com/DAMO-DI-ML/NeurIPS2023-One-Fits-All)、[Time-LLM](https://github.com/KimMeen/Time-LLM)、[CALF](https://github.com/Hank0626/CALF)を参照し、環境構築を行ってください。**「PAttn」**手法については、上記いずれかのリポジトリの環境で互換性があります。

## PAttn 🤔
**PAttn**と[PatchTST](https://github.com/yuqinie98/PatchTST)の主な違いは、Transformerモジュールの重要でない部分や位置埋め込みを段階的に除去した点です。詳細は[こちらの回答](https://github.com/BennyTMT/LLMsForTimeSeries/issues/7)を参照してください。

**動機**：多くの新手法により[DLinear](https://github.com/cure-lab/LTSF-Linear)が超えられたため、簡単かつ効果的なパッチベースの手法として単純なベースラインを提供することを目指しました。

     cd ./PAttn 

     bash ./scripts/ETTh.sh (ETTh1 & ETTh2用)
     bash ./scripts/ETTm.sh (ETTm1 & ETTm2用)
     bash ./scripts/weather.sh (Weather用)
     
#### その他のデータセットの場合は、上記コマンド内のスクリプト名を変更してください。

## アブレーション
     
#### CALF (ETT) でアブレーションを実行：
     
    cd ./CALF
    sh scripts/long_term_forecasting/ETTh_GPT2.sh
    sh scripts/long_term_forecasting/ETTm_GPT2.sh
    
    sh scripts/long_term_forecasting/traffic.sh 
    （trafficなど他のデータセット用）

#### OneFitsAll (ETT) でアブレーションを実行：
     cd ./OFA
     bash ./script/ETTh_GPT2.sh   
     bash ./script/ETTm_GPT2.sh

     bash ./script/illness.sh 
     （illnessなど他のデータセット用）

#### Time-LLM (ETT) でアブレーションを実行：
     cd ./Time-LLM-exp
     bash ./scripts/train_script/TimeLLM_ETTh1.sh
     bash ./scripts/train_script/TimeLLM_ETTm1.sh 

     bash ./scripts/train_script/TimeLLM_Weather.sh
     （Weatherなど他のデータセット用）

#### （他のデータセットでアブレーションを行う場合は、上記の例のようにデータセット名を変更してください。）

## 謝辞

本コードベースは[Time-Series-Library](https://github.com/thuml/Time-Series-Library)を基に構築されています。ありがとうございます！

## 引用
本研究が役立った場合は、以下のようにご引用ください。


```bibtex
@inproceedings{tan2024language,
    title={言語モデルは実際に時系列予測に役立つのか？},
    author={Tan, Mingtian and Merrill, Mike A and Gupta, Vinayak and Althoff, Tim and Hartvigsen, Thomas},
    booktitle={Neural Information Processing Systems (NeurIPS)},
    year={2024}
}

```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---