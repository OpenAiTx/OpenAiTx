

# MMAR：音声、オーディオ、音楽、およびそれらの混合における深層推論のための挑戦的ベンチマーク
[**📖 arXiv**](https://arxiv.org/abs/2505.13032) | [**🎬 MMAR デモ動画**](https://www.youtube.com/watch?v=Dab13opIGqU) | [**🛠️ GitHub コード**](https://github.com/ddlBoJack/MMAR) | [**🔊 MMAR オーディオダウンロード（HuggingFace）**](https://huggingface.co/datasets/BoJack/MMAR)
                                          
<p align="center"><img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/logo.png" alt="MMAR Benchmark Logo" width="300"/></p>

## MMARの概要
私たちはMMARを紹介します。これは、大規模な多分野タスクにわたるオーディオ言語モデル（ALM）の深層推論能力を評価するために設計された新しいベンチマークです。  
MMARは、実際のインターネット動画から収集され、反復的な誤り修正と品質チェックを通じて高品質を保証された、厳選された1,000のオーディオ・質問・回答トリプレットで構成されています。  
ベンチマークの各項目は、表面的理解を超えた多段階の深層推論を要求します。さらに、一部の質問は大学院レベルの知覚および専門分野知識を必要とし、ベンチマークの難易度と深さを高めています。  
例としては以下があります：

![Example](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/example.png)

MMARのメタデータは[こちらのファイル](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json)で利用可能です。従来のベンチマークと異なり、MMARは音声、オーディオ、音楽などの従来のモダリティに加え、それらの混合も含み、野外動画から収集されています。これらのモダリティにおけるデータの分布は左図に示されています。さらに、各質問には指定されたカテゴリおよびサブカテゴリが注釈されており、右図に示されています。

各質問について、元の動画のURLと対応するタイムスタンプ、そしてクリップ内の話されている言語（存在する場合）も提供しています。推論モデルのトレーニングへの潜在的なデータリークを防ぐため、推論手掛かりおよび思考連鎖注釈は適切な時期にリリースされるまで withheld しています。

<p float="left">
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/modality_pie.png" width="49%" />
  <img src="https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/category_sunburst.png" width="49%" />
</p>

## ベンチマーク結果
MMAR上で、以下の5つのモデルカテゴリにわたりモデルのベンチマークを行いました：  
1. 大規模オーディオ言語モデル（LALMs）  
2. 大規模オーディオ推論モデル（LARMs）  
3. オムニ言語モデル（OLMs）  
4. オーディオキャプションを入力とする大規模言語モデル（LLMs）  
5. オーディオキャプションを入力とする大規模推論モデル（LRMs）  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/benchmark.png)

## データセット作成
MMARベンチマークは包括的なパイプラインで構築されました。プロセスは以下を含みます：  
1. 難問のブレインストーミング  
2. 人間とLLMの協働による分類体系の構築  
3. ヒューリスティックに基づくデータ収集と注釈  
4. オーディオデータのクロールと複数スロットにわたる内容の充実化  
5. 反復的な修正と品質検査を行い高いデータ忠実度を保証  

![Pipeline](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/assets/pipeline.png)

## モデルをテストしよう！

既存の評価パイプラインへのスムーズな統合を確保するため、[MMAU](https://github.com/Sakshi113/MMAU)から修正を加えた評価手法を採用し、[evaluation.py](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/code/evaluation.py)に実装しています。評価スクリプトへの入力は、[MMAR-meta.json](https://raw.githubusercontent.com/ddlBoJack/MMAR/main/MMAR-meta.json)と同じ形式で、各質問に対するモデル予測を格納する `model_prediction` という追加キーを含みます。  
  
スクリプトを実行するには：

```bash
python evaluation.py  --input INPUT_JSON_PATH
```
## 謝辞
私たちは、評価コードが[MMAU](https://github.com/Sakshi113/MMAU)の公式実装を改変したものであることに深く感謝します。

## 引用文献

```
@article{ma2025mmar,
  title={MMAR: A Challenging Benchmark for Deep Reasoning in Speech, Audio, Music, and Their Mix},
  author={Ma, Ziyang and Ma, Yinghao and Zhu, Yanqiao and Yang, Chen and Chao, Yi-Wen and Xu, Ruiyang and others},
  journal={arXiv preprint arXiv:2505.13032},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---