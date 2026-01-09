<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*特定の場所と時代のデータのみで**ゼロから**訓練された言語モデルであり、現代のバイアスを抑制し、その時代の声、語彙、世界観を再現します。*

もしAIモデルが単に歴史的なふりをするだけでなく、本当に歴史的だったらどうでしょうか。

v0およびv0.5は[Andrej Karpathy氏のnanoGPT](https://github.com/karpathy/nanoGPT)の上に構築されています。コアのトレーニングスクリプトとモデルアーキテクチャは彼の作品です。

v1は[MicrosoftのPhi 1.5](https://huggingface.co/microsoft/phi-1_5)上で構築されています。

[Hugging Faceリンク](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  モデルの挙動と制限

### **v0**  

初期のプロンプトでは、モデルが1800年代の言語と挙動で応答することが示されました。  
例：プロンプト「Who art Henry?」に対し、「I know that man, I have did not a black, the storm.」と返答しました。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代の概念には触れていない  
- ほぼ時代に即した語彙  
- 文はほとんど一貫性がない（~187MBの訓練データでは予想通り）

### **v0.5** 

v0より大幅に改善されています。  
- ビクトリア朝の文体、適切な句読点、ほぼ文法的な文  
- 依然として高い事実誤認率  
- OCRノイズ（「Digitized by Google」）が出力に残存

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

初めてモデルが実際の歴史的出来事をデータセットの実在人物と関連付けて想起。

例：プロンプト「It was the year of our Lord 1834」

出力：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」

最初は抗議活動が偶然同じ年に起きたのかと思いましたが、こちらをご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2の90GBデータセットから15GBサンプルで訓練。

モデルは1万ステップのみで学習されています。

トークナイゼーションに問題があり、出力が次のようになります：

プロンプト：
チャールズ・ディケンズとは誰ですか？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
修正済み：

「チャールズ・ディケンズとは誰か？彼の素晴らしい感動的な作品は、彼の戯曲や、グレート・カンパニーの農場で、より多く見られるのか？私がまだ引用していないジャック・ピケットからの言葉は何か？彼らが胸を駆け巡ったり、切り刻んだりする一種の行為であったこと、またはジャクソンが窓を見ていた頃に何がなされるべきだったのか、知らないのか？イギリス人の成功とは何か、そしてその息子が私に発見していないことは何か、それによってそのような重荷を成し遂げる方法は？昔の道に通じる通路を作ったことがあるか、または私たちのボートの足元でアンカーブリーズを経験したことがあるか、そこから私たちを去らねばならないのか？実際のところ、土曜の夜や正午、あるいは北風が吹くかどうかに関係なく、我々は現在と同じ効果を伴う、手強い障壁を描写せざるを得ないだろう。この状況下では、少なくとも私たちがその部屋を離れたと言い過ぎではないと思う。『ファイブ・ハンドレッドフォールド』には三つの写しがあると信じている。これは、読者の最初の番号に参照されるべきものである……」

### **v2mini-eval2**

eval1のトレーニングに使用した15GBサンプルと同じものを使用してトレーニング。
モデルも10Kステップのみで再びトレーニング。

プロンプト：チャールズ・ダーウィン

チャールズ・ダーウィンECCEMACY。先生、— 次の事例は私にとって興味深いものです：— 私はロンドンに2週間おり、リウマチの発作に非常に悩まされました。最初のリウマチの発作はあなたに会う1週間前で、2度目はあなたに会った時、3度目も同じ時期でした。ただし、2度目の痛風の発作は、熱性症状を伴わず、尿量の増加とより多量の排尿を伴いました。3度目の発作はあなたに会って1時間後で、痛風の発作の再発と、より急速な痛風の戻りが続きました。4度目の発作も発熱を伴いましたが、必ずしも熱性症状があるとは限りませんでした。3度目の痛風の発作はあなたが病気になってから2週間後、4度目は痛風の発作が続きました。4度目の発作はあなたが発症してから2週間後で、感覚を伴っていました。


## データセット

### **v2**

- 1800〜1875年ロンドンのテキスト 90GB
- 136,344 ドキュメント
- 90GB全体はまだトークナイズされていないため未公開ですが、15GBのサンプルはこちらにあります：https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### バイアス統計 
  ![代名詞バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理的バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![時間的バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

詳細は [v2 バイアスレポート](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) を参照してください。


## 使用方法

このプロジェクトは主に歴史的データの収集、トレーニング用の準備、トークナイザーの構築に焦点を当てています。完全なLLMトレーニングプロセスについてはAndrej KarpathyによるnanoGPTを参照してください。

### ステップ1：歴史的テキストの収集と準備

- 選択した時代（例：ロンドン1800-1850）のパブリックドメインの書籍や文書等の.txtファイルを収集する

- 選択した時間/場所の範囲内にデータを収めてください  
- テキストファイルはスクリプトまたは手動で、Project Gutenbergのヘッダー/フッター、現代的な注釈、OCRエラーなどを除去してクリーンアップしてください。

### ステップ2: カスタムトークナイザーの構築

- クリーンアップしたデータに対して train_tokenizer.py または train_tokenizer_hf.py を実行します。
- これにより vocab.json および merges.txt が生成されます。
- これらのファイルがモデルの語彙とマージルールを定義します。

### ステップ3: モデルの学習

- 学習手順については [Andrej Karpathy の nanoGPT](https://github.com/karpathy/nanoGPT) または選択したアーキテクチャのドキュメントを参照してください。

# FAQ

## Selective Temporal Training とは何ですか？

Selective Temporal Training（STT）は、すべての訓練データが特定の歴史的期間に収まるよう厳選された機械学習手法です。その時代の言語や知識を現代の概念に影響されずにモデル化するために行われます。たとえば、現在私が持っているモデル（v0.5）は1800-1875年のデータのみで学習されており、ファインチューニングは行わずゼロから訓練することで、その時代の言語スタイルや歴史的背景を反映した出力が得られます。

## なぜファインチューニングやLoRAを使わないのですか？

このプロジェクトでは現代のバイアスを排除した言語モデルを作りたいと考えています。たとえばGPT-2のようなモデルをファインチューニングしても、すでに事前学習済みの情報は消せません。ゼロから学習させることで、モデルは「古風なふり」をするのではなく、本当にその時代のものになります。現在の目標は1800年から1875年にロンドンで出版された書籍のみの知識で論理的推論ができるモデルを作ることです。

## 学習にはどのようなデータを使いましたか？

1800年～1875年ロンドンの書籍、法的文書、新聞、その他の著作物を使用しています。リンクしたリスト（v0用）には約200件あり、最初の学習には約50ファイル（約187MB）を使いました。文書リストは以下で見られます：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

データセットサイズ：
- v0: 約187MB
- v0.5: 約435MB 
- v1: 約6.25GB 
- v2mini-eval1: 15GB

## モデルのサイズはどれくらいですか？

v0: 1,600万パラメータ

v0.5: 1億2,300万パラメータ

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---