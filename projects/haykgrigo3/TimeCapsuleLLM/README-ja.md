
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (近日公開)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (近日公開)</a> |
        | <a href="#" title="Coming soon">ไทย (近日公開)</a> |
        | <a href="#" title="Coming soon">Français (近日公開)</a>
        | <a href="#" title="Coming soon">Deutsch (近日公開)</a>
        | <a href="#" title="Coming soon">Español (近日公開)</a>
        | <a href="#" title="Coming soon">Italiano (近日公開)</a>
        | <a href="#" title="Coming soon">Русский (近日公開)</a>
        | <a href="#" title="Coming soon">Português (近日公開)</a>
        | <a href="#" title="Coming soon">Nederlands (近日公開)</a>
        | <a href="#" title="Coming soon">Polski (近日公開)</a>
        | <a href="#" title="Coming soon">العربية (近日公開)</a>
        | <a href="#" title="Coming soon">فارسی (近日公開)</a>
        | <a href="#" title="Coming soon">Türkçe (近日公開)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (近日公開)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (近日公開)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*特定の場所や時代のデータのみを用いて**ゼロから**訓練された言語モデル。現代的なバイアスを減らし、その時代の声・語彙・世界観を再現します。*

もしAIモデルが、歴史的なふりをするだけでなく、本当にそのものだったらどうなるでしょう。

v0 および v0.5 は [Andrej Karpathy による nanoGPT](https://github.com/karpathy/nanoGPT) 上で構築されています。コアの訓練スクリプトとモデルアーキテクチャは彼の作品です。

v1は[MicrosoftのPhi 1.5](https://huggingface.co/microsoft/phi-1_5)上で構築されました

[Hugging Face リンク](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  モデルの挙動と制限

### **v0**  

初期のプロンプトでは、モデルが1800年代の言語や振る舞いで応答する様子が見られました。
例：プロンプト: "Who art Henry?" に対し "I know that man, I have did not a black, the storm." と返答。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代的な概念の言及なし  
- 主に時代に即した語彙  
- ほとんどの文が意味不明（~187MBの訓練データでは予想通り）

### **v0.5** 

v0から大きく改善されています。  
- ヴィクトリア朝の文体、適切な句読点、ほぼ文法的な文  
- 事実誤認（ハルシネーション）率は依然高い  
- OCRノイズ（「Digitized by Google」）が出力に残存

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

初めて、実際の歴史的出来事とデータセット内の実在人物を関連付けて記憶し接続できたモデル。

例：プロンプト: "It was the year of our Lord 1834" 

出力: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

最初は、抗議活動が偶然同じ年に発生したのかと考えましたが、こちらをご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### 重要性について:

これは、私のモデルが年を実際の歴史的出来事とその出来事に関わる実在人物（Lord Palmerston）両方と関連付けることができた最初の例です。初期モデル（v0, v0.5）は19世紀の文体を模倣できても、出来事や人物、事実を常にハルシネートしていました。この出力は、モデルがデータセットから情報を記憶し始めていることを示しています。


## 今後の計画

- インターネットアーカイブには1800〜1875年にロンドンで出版されたテキストが約175,000件あります
- コーパスを拡張し、推論能力向上のためにさらにクリーンアップする予定です
- より多様な地域と時代に拡張し、より多くの歴史モデルを作成します

## 使い方

このプロジェクトは主に歴史的データのキュレーション、学習用準備、トークナイザーの構築に焦点を当てています。LLMの完全な学習プロセスについては触れませんので、Andrej Karpathy氏のnanoGPTを参照してください。

### ステップ1: 歴史的テキストの収集と準備

- 選択した時代のパブリックドメイン書籍や文書などの.txtファイルを収集します（例：ロンドン1800〜1850）
- 選択した時期や場所の範囲内で管理してください
- スクリプトや手動で、Project Gutenbergのヘッダー/フッター、現代の注釈、OCRエラーなどをテキストファイルから削除してクリーンアップします。

### ステップ2: カスタムトークナイザーの構築

- クリーンアップ済みデータに対してtrain_tokenizer.pyまたはtrain_tokenizer_hf.pyを実行します。
- vocab.jsonとmerges.txtが生成されます
- これらのファイルはモデル用の語彙とマージルールを定義します

### ステップ3: モデルの学習

- 学習プロセスについては [Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT) または選択したアーキテクチャのドキュメントを参照してください。

# FAQ

## Selective Temporal Trainingとは？

Selective Temporal Training (STT)は、すべての学習データが特定の歴史的時代に収まるよう厳選される機械学習手法です。その時代の言語と知識を、現代の概念の影響なくモデル化するために行います。例えば、現在のモデル（v0.5）は1800〜1875年のデータのみで学習されており、ファインチューニングはされていません。ゼロから学習しているので、その時代の言語スタイルと歴史的文脈が反映された出力になります。

## なぜファインチューニングやLoRAを使わないのですか？

このプロジェクトでは現代的なバイアスから解放された言語モデルを作りたいと考えています。GPT-2などをファインチューニングしても、既に事前学習されている情報は消えません。ゼロから学習すれば、モデルは「古いふり」をするのではなく、実際にそうなります。現在の目標は、1800年から1875年にロンドンで出版された書籍の知識だけで推論できるものを作ることです。

## 学習に使ったデータはどんなものですか？


私は1800年から1875年のロンドンの本、法的文書、新聞、その他の著作物を使用しています。リンクしたリスト（v0用）には約200件ありますが、最初のトレーニングでは約50ファイル（約187MB）だけを使いました。ドキュメントのリストはこちらで確認できます：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

データセットサイズ：
v0： 約187MB
v0.5： 約435MB 
v1： 約6.25GB 

## モデルのサイズは？

V0： 1,600万パラメータ

V0.5： 1億2,300万パラメータ

V1： 7億パラメータ

# トレーニング仕様は？

# V0/V0.5
GPU： Geforce rtx 4060
CPU： i5-13400F 
メモリ： 16GB DDR5.

# V1
GPU： A100（レンタル）















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---