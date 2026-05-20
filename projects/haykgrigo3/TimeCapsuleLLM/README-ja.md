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
## ヴィンテージLLM Discordに参加しよう

**歴史的な言語モデル**や**時代特有のデータセット**、そして**TimeCapsuleLLM**、**Violet-1.4B**、**Mr. Chatterbox**のようなプロジェクトの将来に興味がある方は、ぜひコミュニティにご参加ください。

このサーバーでは、アイデアの議論、進捗の共有、同じ分野で活動する人々との交流を行っています。

[Discordに参加する](https://discord.gg/JeWkk4z5)

## モデルの挙動と制限

### **v0**  

初期のプロンプトでは、1800年代の言語や挙動で応答するモデルが見られました。  
例：プロンプト「Who art Henry?」への応答：「I know that man, I have did not a black, the storm.」

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代的な概念は一切言及しない  
- 主にその時代に合った語彙を使用  
- 文がほとんど一貫性がない（約187MBの学習データとしては想定通り）

### **v0.5-london** 

v0から大幅な改善が見られました。  
- ヴィクトリア朝の文体、正しい句読点、ほぼ文法的に正しい文  
- 依然として高い事実誤認（ハルシネーション）率  
- 出力にOCRノイズ（「Digitized by Google」など）が残存

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

初めて実際のデータセットから本物の歴史的出来事と実在人物を結びつけて想起・言及するモデル。

例：プロンプト「It was the year of our Lord 1834」

出力：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」

最初は偶然同じ年に抗議活動があったのかと思いましたが、こちらをご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

v2の90GBデータセットから15GBをサンプリングして学習しました。
モデルは10Kステップのみで学習されました。

トークナイゼーションに問題があり、出力が次のようになります：

プロンプト：
チャールズ・ディケンズとは誰ですか？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
修正済み：

「チャールズ・ディケンズとは誰ですか？彼の素晴らしい感動的な作品は、彼の劇や、グレート・カンパニーの農場でより多く働いているのですか？私がまだジャック・ピケットから引用していないものは何ですか？彼らが一種のギャロッピングや、胸を切り裂くような動作をしていたこと、あるいはジャクソンが窓を見ていた時に何が起こったかについて、あなたは知らないのですか？イギリス人の成功とは何であり、その息子が私にまだ見出していないものは何であり、それによってそのような重荷を達成することができるのでしょうか？あなたはかつて古い道を通り抜けたり、私たちの船の足元でアンカーブリーズに到達したりしたことがありますか、それを私たちから離れなければならないのですか？事実は、風が土曜の夜や正午に平原から吹き上がるか、北へ向かうか、その他の場合でも、私たちは現在と同じ効果を持つ強大な障壁を記述しなければならない、ということです。この状況では、少なくとも私たちがその部屋を離れたと言っても過言ではありません。私は「ファイブ・ハンドレッドフォールド」に三部あると信じており、参照されるべきです。これは、私たちの読者の最初の番号です。彼らが望む...」

### **v2mini-eval2-london**

eval1のトレーニングで使用された15GBサンプルと同じデータを使用して訓練。
モデルは再び10Kステップのみで訓練されています。

プロンプト：チャールズ・ダーウィン

チャールズ・ダーウィンECCEMACY。先生、— 次の症例は私にとって興味深いものです：—私はロンドンに二週間滞在し、リウマチの発作に大きく影響されました。リウマチの最初の発作はあなたに会う一週間前に起こり、二度目はあなたに会った時、三度目もあなたに会った時、そして三度目は同じ時期でした。しかし、二度目の痛風の発作には発熱症状は伴わず、尿の流れが増加し、尿の排出がより多量でした。三度目の発作はあなたに会った一時間後に起こり、痛風の発作が再発し、痛風のより急速な再発が続きました。四度目の発作も熱を伴いましたが、必ずしも発熱症状を伴うとは限りませんでした。三度目の痛風の発作はあなたが病気になってから二週間後に起こり、四度目は痛風の発作が続きました。四度目の発作はあなたが発症してから二週間後に起こり、伴っていました。

### **v2-london**

90GB（トークナイズ後112GB）のデータセットで訓練
182Kステップまで訓練

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **次は何？**

- TimeCapsuleLLM v3の開発が始まりました
- データセットのサイズと地理的範囲を拡大
- ロンドン以外の都市にも拡張

この作業はユニバーシティ・カレッジ・ロンドン（UCL）の研究者と協力して進められており、追加の機関の関与も議論されています。


## データセット

### **v2**

- 1800-1875年ロンドンのテキスト90GB（生データ）
- 136,344ドキュメント
- 完全なトークナイズ済みデータセットはこちらで公開：https://huggingface.co/datasets/postgrammar/london-llm-1800


### バイアス統計
![代名詞バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![地理的バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![時間的バイアス](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

詳細については [v2 バイアスレポート](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) を参照してください。


-


## 使用方法

このプロジェクトは主に歴史的データの収集、トレーニングの準備、トークナイザーの構築に焦点を当てています。完全なLLMトレーニングプロセスについては説明しませんので、Andrej KarpathyによるnanoGPTを参照してください。

### ステップ1：歴史的テキストの収集と準備

- 公的ドメインの本や文書などの.txtファイルを、選択した時代（例：ロンドン1800-1875）から収集します
- 選択した時代や場所の範囲内に収めてください
- スクリプトを使うか手動で、Project Gutenbergのヘッダーやフッター、現代の注釈やOCRエラーなどを削除してテキストファイルをクリーンアップします

### ステップ2：カスタムトークナイザーの構築

- クリーンアップしたデータで train_tokenizer.py または train_tokenizer_hf.py を実行します。
- これにより vocab.json と merges.txt が生成されます
- これらのファイルはモデルの語彙とマージルールを定義します

### ステップ3：モデルのトレーニング

- トレーニングプロセスについては [Andrej KarpathyによるnanoGPT](https://github.com/karpathy/nanoGPT) や、選択したアーキテクチャのドキュメントを参照してください。

# FAQ

## 選択的時間的トレーニングとは？

選択的時間的トレーニング（STT）は、すべてのトレーニングデータを特定の歴史的時代に限定して選別する機械学習手法です。その時代の言語や知識を現代の概念から影響を受けずにモデル化するために行われます。たとえば、現行モデル（v0.5）は1800-1875年のデータのみでトレーニングされており、ファインチューニングではなくスクラッチから学習しているため、その時代の言語スタイルや歴史的文脈を反映した出力になります。

## なぜファインチューニングやLoRAを使わないのですか？
このプロジェクトでは、現代のバイアスから解放された言語モデルを作成しようとしています。GPT-2のようなモデルをファインチューニングすると、すでに事前学習されている情報が消えることはありません。ゼロから学習すれば、言語モデルが「古風なふり」をするのではなく、実際に古い知識のみを持つことになります。本プロジェクトの現在の目標は、1800年から1875年までのロンドンで出版された書籍の知識のみを用いて推論できるものを作ることです。

## トレーニングにはどのようなデータを使いましたか？

1800～1875年のロンドンの書籍、法的文書、新聞、その他の著作物を使用しています。リンクしたリスト（v0）は約200件ありますが、最初の学習では約50ファイル、約187MBを使用しました。ドキュメントの一覧はこちらで確認できます：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

データセットサイズ：
- v0: 約187MB
- v0.5: 約435MB
- v1: 約6.25GB
- v2mini-eval1: 15GB（v2の90GBからサンプル）
- v2: 90GB

## モデルの大きさはどれくらいですか？

v0: 1,600万パラメータ

v0.5: 1億2,300万パラメータ

v1: 7億パラメータ

v2mini-eval1: 3億パラメータ

v2mini-eval2: 2億パラメータ

v2: 12億パラメータ

## トレーニングスペックは？

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
RAM: 16GB DDR5.

### v1
GPU: A100 SXM（レンタル）

### v2mini-eval1/eval2

GPU：A100 SXM レンタル

### v2
GPU：H100 SXM レンタル

## 関連研究

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13BパラメータのLLMで、1930年以前の260BトークンのテキストとQ&Aで訓練。 [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base)バージョンもあり。
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4BパラメータのLLMで、1800-1899年のテキストとQ&Aで訓練。 [160M](https://huggingface.co/zakarth/violet-160m-chat)バージョンもあり。
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340MパラメータのLLMで、1837-1899年の28,000以上のテキストとQ&Aで訓練。

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Qwen3アーキテクチャに基づく4BパラメータのLLMファミリーで、1913、1929、1933、1939、1946年までの知識カットオフの歴史データ80Bトークンでゼロから訓練。

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPTはMistral-Hermes 2をベースに、主にEEBOとGallicaに由来する英語・フランス語・ラテン語の初期近代テキスト11,000件でファインチューニング。

## 謝辞

[Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)氏には、学術的監督、研究フレーミングと評価の指導、v2リリースのトークナイザー訓練やデータセット準備へのご協力をいただき、心より感謝申し上げます。彼のフィードバックと経験は、本研究のプレゼンテーションの洗練に極めて重要でした。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---