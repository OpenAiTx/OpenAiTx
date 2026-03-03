<div align="right">
  <details>
<summary>🌐 言語</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*特定の場所と時代のデータのみから**ゼロから**学習された言語モデル。現代的なバイアスを抑え、その時代の声、語彙、世界観を再現します。*

AIモデルが単に歴史的なふりをするだけでなく、実際にそうであったとしたらどうでしょう。

v0とv0.5は [Andrej Karpathy氏のnanoGPT](https://github.com/karpathy/nanoGPT) をベースに構築。コアの学習スクリプトとモデルアーキテクチャは彼の作品です。

v1は [MicrosoftのPhi 1.5](https://huggingface.co/microsoft/phi-1_5) をベースに構築。

v2は llamaforcausallmをベースに構築。

[Hugging Face リンク](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## 研究状況
本プロジェクトは独立して開始・開発されました。

現在は学術的指導の下、Muhlenberg Collegeとの共同研究として実施されています。

## 引用

このデータセットやモデルを学術研究等で利用する場合は、以下を引用してください。


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## モデルの挙動と制限

### **v0**

初期プロンプトでは、1800年代の言語と振る舞いでモデルが応答しています。
例：プロンプト：「Who art Henry?」に対し「I know that man, I have did not a black, the storm.」と返答。

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代的な概念には言及しない  
- 主に時代に即した語彙  
- 文はほとんど一貫性がない（約187MBの学習データでは想定内）

### **v0.5**

v0に比べて大きな進歩。
- ビクトリア朝風の文体、適切な句読点、ほぼ文法的な文章  
- 依然として事実の幻覚率は高い  
- OCRノイズ（「Digitized by Google」）が出力に残っている

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

初めて実際の歴史的出来事をデータセットの実在人物と結び付けて想起したモデル。

例：プロンプト：「It was the year of our Lord 1834」

出力：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」

最初は偶然同じ年に抗議活動があったのかと思いましたが、次をご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2の90GBデータセットから15GBサンプルを用いて学習。
モデルは10Kステップのみ学習。

トークナイゼーションの問題により出力がこのようになりました:

チャールズ・ディケンズとは誰ですか？



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
修正版：

「チャールズ・ディケンズとは誰ですか？彼の優れた感動的な作品は、彼の戯曲やグレート・カンパニーの農場で、さらに多く見られますか？私がまだ引用していないジャック・ピケットについてはどうでしょう？彼らが一種の疾走、または胸を切り裂くような行為をしていたこと、あるいはジャクソンが窓を見つめていた頃に何が行われていたかをご存じありませんか？イギリス人の成功とは何であり、彼の息子が私に発見させていない事柄は、どのようにしてそのような重責を成し遂げるのか？あなたは古い街道を通り抜けたことがありますか、あるいは私たちの船の下にあるアンカー・ブリーズに行ったことがありますか、そこから私たちを離れなければなりません。実際のところ、土曜の夜や正午、あるいは北風が吹き上がるかどうかにかかわらず、私たちは現在と同じ効果をもたらす手強い障壁を記述せざるを得ません。この状況下では、少なくとも私たちがその部屋を離れたと言っても過言ではありません。『ファイブ・ハンドレッドフォールド』には3部の写しがあると私は信じています。これは参照用であり、私たちの読者で希望される最初の番号です…」

### **v2mini-eval2**

同じ15GBのサンプルデータでeval1のトレーニングに使用。
モデルは再び1万ステップのみでトレーニング。

プロンプト：チャールズ・ダーウィン

チャールズ・ダーウィンECCEMACY.　拝啓、—次の事例は私にとって興味深いものです：—私はロンドンに2週間滞在し、リウマチの発作に非常に悩まされました。最初のリウマチ発作はあなたに会う1週間前で、2度目はあなたに会った時、3度目は同時期でした。しかし、2度目の痛風発作には発熱症状は伴わず、尿量の増加とより多量の尿の排出が見られました。3度目の発作はあなたに会って1時間後に起こり、痛風の発作が再発し、より速やかに痛風が戻りました。4度目の発作も発熱を伴いましたが、常に発熱症状があるわけではありませんでした。3度目の痛風発作はあなたが病気になった2週間後で、4度目は痛風の発作を伴いました。4度目の発作はあなたが発症した2週間後で、感覚を伴っていました

### **v2**

90GB（112GBトークナイズ）のデータセットで学習
182Kステップまでトレーニング

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  データセット

### **v2**

- 90GB（生データ）1800-1875年ロンドン文書
- 136,344文書
- 完全なトークナイズ済みデータセットはこちら：https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### バイアス統計
  ![代名詞バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理的バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![時系列バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

より詳しくは [v2 バイアスレポート](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) を参照してください。



## 使用方法

このプロジェクトは主に歴史的データの収集、トレーニング用の準備、トークナイザーの構築に焦点を当てています。完全なLLMのトレーニングプロセスについては扱いませんので、Andrej KarpathyのnanoGPTを参照してください。

### ステップ1: 歴史的テキストの収集と準備

- 選択した時代のパブリックドメインの書籍や文書などの.txtファイルを集めます（例：ロンドン 1800-1850）
- 選択した時代や場所の範囲内に収めてください
- スクリプトでテキストファイルをクリーンアップするか、手動でProject Gutenbergのヘッダー/フッターや現代の注釈、OCRエラーなどを削除します。

### ステップ2: カスタムトークナイザーの構築

- クリーンアップしたデータでtrain_tokenizer.pyまたはtrain_tokenizer_hf.pyを実行します。
- vocab.jsonとmerges.txtが生成されます
- これらのファイルがモデルの語彙とマージルールを定義します

### ステップ3: モデルのトレーニング

- トレーニングプロセスや選択したアーキテクチャのドキュメントについては[Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT)を参照してください。

# FAQ

## Selective Temporal Trainingとは？

Selective Temporal Training（STT）は、すべてのトレーニングデータが特定の歴史的時代に収まるように厳選される機械学習手法です。その時代の言語や知識を現代の概念の影響を受けずにモデル化するために行われます。たとえば、現在のモデル（v0.5）は1800～1875年のデータのみでトレーニングされており、ファインチューニングではなくスクラッチからトレーニングされているため、その時代の言語的スタイルや歴史的文脈が反映されます。

## なぜファインチューニングやLoRAを使わないのですか？

このプロジェクトでは、現代のバイアスから解放された言語モデルを作りたいと考えています。GPT-2のようなモデルをファインチューニングしても、すでに事前学習されている情報は消えません。スクラッチからトレーニングすれば、言語モデルは古いフリをするのではなく、本当にその時代のものになります。今の目標は、1800～1875年にロンドンで出版された書籍の知識だけで推論できるものを作ることです。

## トレーニングに使ったデータはどんなものですか？

1800～1875年のロンドンの書籍、法的文書、新聞、その他の著作を使用しています。リンクしたリスト（v0用）には約200件ありますが、最初のトレーニングでは約50ファイル（約187MB）を使用しました。文書のリストはこちらで閲覧できます：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

データセットサイズ:
- v0: 約187MB
- v0.5: 約435MB
- v1: 約6.25GB
- v2mini-eval1: 15GB（v2の90GBからのサンプル）
- v2: 90GB

## モデルのサイズはどれくらいですか？

v0: 1,600万パラメータ

v0.5: 1億2,300万パラメータ

v1: 7億パラメータ

v2mini-eval1: 3億パラメータ

v2mini-eval2: 2億パラメータ

v2: 12億パラメータ

## トレーニング仕様は？

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
RAM: 16GB DDR5

### v1
GPU: A100 SXM（レンタル）

### v2mini-eval1/eval2
GPU: A100 SXM（レンタル）

### v2
GPU: H100 SXM（レンタル）

## 謝辞

[Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) に、学術的指導、研究の構成と評価の助言、v2リリースのためのトークナイザートレーニングとデータセット準備へのご協力に感謝いたします。彼のフィードバックと経験は、本研究の発表を洗練する上で非常に重要でした。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---