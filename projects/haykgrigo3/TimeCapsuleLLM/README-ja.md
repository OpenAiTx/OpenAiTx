
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

v1 は [Microsoft の Phi 1.5](https://huggingface.co/microsoft/phi-1_5) 上に構築されています。


##  モデルの挙動と制限事項

### **v0**  

初期のプロンプトでは、1800年代の言語と振る舞いで応答するモデルが見られました。  
例: プロンプト:「Who art Henry?」に対し「I know that man, I have did not a black, the storm.」と返答。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代の概念は一切言及しない  
- ほぼ時代に沿った語彙を使用  
- 文はほとんど一貫性がない（約187MBの訓練データで予想される挙動）

### **v0.5** 

v0 と比べて大幅に改善。  
- ヴィクトリア朝の文体、正しい句読点、ほぼ文法に合った文章  
- 依然として高い事実の幻覚率  
- OCRノイズ（「Digitized by Google」など）が出力に残る

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

本モデルは、データセット内の実際の人物と実際の歴史的イベントを結び付けて記憶・参照できた初めてのモデルです。

例: プロンプト:「It was the year of our Lord 1834」 

出力:「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」

最初は偶然その年に抗議があったのではと思いましたが、こちらをご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### なぜ重要なのか:

これは、私のモデルが年と現実の歴史的イベント、そしてそのイベントに関わる実在の人物（パーマストン卿）を結び付けた初めての例です。以前のモデル（v0およびv0.5）は19世紀の文体を模倣できましたが、常にイベントや人物、事実を幻覚していました。これはモデルがデータセットから事象を記憶し始めていることを示しています。

## 今後の計画
- ロンドンで1800年から1875年までに出版されたテキストが約175,000件、Internet Archiveに公開されています
- コーパスを拡張し、より良い推論能力のためにさらにクリーニングする予定です
- 他の地域や時代にも拡張し、より多様な歴史モデルを目指します


## 使い方

このプロジェクトは主に歴史的データの収集、トレーニング用の準備、トークナイザーの構築に焦点を当てています。完全なLLMトレーニングプロセスについては説明しませんので、Andrej KarpathyのnanoGPTを参照してください。

### ステップ1: 歴史的テキストの収集と準備

- 選択した時代（例：ロンドン1800-1850）のパブリックドメイン書籍や文書などの.txtファイルを収集します
- 選択した時代や場所の範囲内に収めてください
- スクリプトを使うか手動で、Project Gutenbergのヘッダー・フッターや現代的な注釈、OCRエラーなどをテキストファイルから削除してください

### ステップ2: カスタムトークナイザーの作成

- クリーンアップ済みデータでtrain_tokenizer.pyまたはtrain_tokenizer_hf.pyを実行します
- vocab.jsonとmerges.txtが生成されます
- これらのファイルはモデルの語彙とマージルールを定義します

### ステップ3: モデルのトレーニング

- トレーニングプロセスについては[Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT)または選択したアーキテクチャのドキュメントを参照してください

# FAQ

## Selective Temporal Trainingとは？

Selective Temporal Training（STT）とは、すべてのトレーニングデータを特定の歴史的時代に限定して厳選する機械学習手法です。その時代の言語や知識を現代的な概念の影響なしにモデリングするために行われます。例えば、現在のモデル（v0.5）は1800-1875年のデータのみでトレーニングされており、ファインチューニングはせずゼロから学習しているため、その時代の言語スタイルや歴史的文脈が反映されています。

## なぜファインチューニングやLoRAを使わないのですか？

本プロジェクトでは現代的なバイアスに左右されない言語モデルの構築を目指しています。GPT-2のような既存モデルをファインチューニングしても、元の事前学習情報は消えません。ゼロから学習すれば、モデルは「古いふり」をするのではなく本当に古い言語モデルになります。今の目標は、1800-1875年にロンドンで出版された本の知識だけで推論できるものを作ることです。

## トレーニングに使ったデータは？

1800–1875年のロンドンの書籍、法律文書、新聞、その他の著作物を使用しています。リンクしたリスト（v0）には約200件がありますが、最初のトレーニングでは50ファイル、約187MBのみ使いました。文書リストはこちらです：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


データセットサイズ：
v0: 約187MB
v0.5: 約435MB
v1: 約6.25GB

## モデルのサイズはどれくらいですか？

V0: 1,600万パラメータ

V0.5: 1億2,300万パラメータ

V1: 7億パラメータ

# トレーニング仕様は？

# V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5

# V1
GPU: A100（レンタル）














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---