<div align="right">
  <details>
<summary>🌐 言語</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*特定の場所や時代のデータのみを用いて**ゼロから**訓練された言語モデル。現代的なバイアスを減らし、当時の声・語彙・世界観を再現します。*

AIモデルがただ歴史的なふりをするのではなく、実際にその時代のものであったらどうなるかを想像してみてください。

v0およびv0.5は[Andrej Karpathy氏のnanoGPT](https://github.com/karpathy/nanoGPT)上に構築されています。コアの訓練スクリプトとモデル構造は彼の貢献です。

v1は[MicrosoftのPhi 1.5](https://huggingface.co/microsoft/phi-1_5)上に構築されています。

v2はllamaforcausallm上に構築されています。

[Hugging Faceリンク](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## 研究状況
本プロジェクトは独立して開始・開発されました。

現在は学術的監督の下、Muhlenberg CollegeおよびGeorgia State Universityとの提携研究として実施されています。

## 引用

本データセットやモデルを学術研究で利用する場合は、以下のように引用してください：


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Vintage LLM Discordに参加しよう

**歴史的言語モデル**、**時代特定データセット**、あるいは **TimeCapsuleLLM**、**Violet-1.4B**、**Mr. Chatterbox** のようなプロジェクトの未来に興味がある方は、ぜひコミュニティにご参加ください。

このサーバーではアイデアの議論、進捗の共有、この分野で活動する他の方々との交流を行っています。

[Discordに参加する](https://discord.gg/JeWkk4z5)

## スポンサー

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

DolOfferのご支援に感謝します！

DolOfferはデジタルプロダクトの推薦と割引共有に特化したプラットフォームで、ユーザーが価値あるツールやサービス、期間限定のお得な情報を素早く発見できるようサポートしています。YouTube Premium、Claude、ChatGPT Plus、Spotify、Apple Musicなど人気のサブスクリプションサービスを、正規価格の30％以下で提供することもあります。

この限定リンク [doloffer](https://doloffer.com/en/) から今すぐ登録し、チャージ時にプロモコード AI8888 を入力すると、さらに10％割引が受けられます。

## モデルの挙動と制限事項

### **v0**  

初期のプロンプトでは、1800年代の言語と挙動で応答します。  
例：プロンプト「Who art Henry?」に対し、「I know that man, I have did not a black, the storm.」と返答しました。

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 現代的な概念には言及しない  
- ほぼ時代に忠実な語彙  
- 文はほとんどが一貫性に欠ける（約187MBの訓練データでは想定内）

### **v0.5-london** 

v0と比較して大幅な改善。  
- ヴィクトリア朝風の文体、正しい句読点、ほぼ文法的な文章
- 依然として事実誤認（ハルシネーション）率が高い  
- OCRノイズ（「Digitized by Google」）が出力に依然として現れる

![TimeCapsuleLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

データセットの実在人物と実際の歴史的出来事を初めて関連付けて想起したモデル。

例：プロンプト：「It was the year of our Lord 1834」 

出力：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」 

最初は、偶然にも同じ年に抗議活動があったのかと思いましたが、こちらをご覧ください: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

v2の90GBデータセットから15GBサンプルを用いて学習。
モデルは1万ステップのみ学習。

トークナイゼーションに問題があり、出力が次のようになります：

プロンプト：
チャールズ・ディケンズとは誰ですか？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
修正版：

「チャールズ・ディケンズとは誰ですか？彼の優れた感動的な作品が、彼の戯曲や、グレート・カンパニーの農場でより多く表れているのでしょうか？私がまだ引用していないジャック・ピケットについてはどうでしょう？あなたは彼らが一種の疾走、あるいは胸を打つ行為であったこと、あるいはジャクソンが窓を見ていた時期に何が行われていたのかをご存じではありませんか？イギリス人の成功とは何か、そしてその息子が私に発見させてくれなかったものは、どうやってそのような重荷を達成するのでしょうか？あなたは古い道路に通じる道、あるいは私たちの船の足元にあるアンカーブリーズに入ったことがありますか、それは私たちを離れなければならないものですか？事実としては、風が土曜日の夜や正午、あるいは北から吹き上がるかどうかに関わらず、私たちは現在と同じ効果を伴う手ごわい障壁を描写せざるを得なくなるでしょう。この状況では、少なくとも私たちがその部屋を離れたと言っても過言ではありません。「ファイブ・ハンドレッドフォールド」には3部の写本があると信じていますが、それは私たちの読者の最初の何人かが参照するためのものです...」

### **v2mini-eval2-london**

eval1の訓練に使われた同じ15GBサンプルを使用して訓練。
モデルも同様に1万ステップのみ訓練。

プロンプト:チャールズ・ダーウィン

チャールズ・ダーウィンECCEMACY. 拝啓、— 次のケースは私にとって興味深いものです：— 私はロンドンに2週間滞在し、リウマチの発作に大きく苦しみました。最初のリウマチの発作はあなたに会う1週間前で、2度目はあなたに会った時、3度目は同じ時に起こりました。しかし、2度目の痛風の発作は発熱症状を伴わず、尿量の増加とより多量の排尿を伴いました。3度目の発作はあなたに会った1時間後に起こり、その後再び痛風の発作が戻り、より急速に再発しました。4度目の発作も発熱を伴いましたが、必ずしも発熱症状があったわけではありません。3度目の痛風の発作は、あなたが病気になって2週間後に発生し、4度目は痛風の発作を伴いました。4度目の発作は、あなたが発症してから2週間後で、感覚を伴いました

### **v2-london**

90GB（トークン化後112GB）のデータセットを使用して訓練
182,000ステップまで訓練

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **今後の展望**

- TimeCapsuleLLM v3の開発開始
- データセットの規模と地理的範囲を拡大
- ロンドン以外の都市へも拡張

本研究はミューhlenberg大学およびジョージア州立大学の研究者と共同で進められています。


##  データセット

### **v2**

- 1800-1875年ロンドンのテキスト90GB（生データ）
- 136,344件の文書
- 完全なトークン化済みデータセットはこちらで公開中：https://huggingface.co/datasets/postgrammar/london-llm-1800


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

GPU: A100 SXM レンタル

### v2
GPU: H100 SXM レンタル

## 関連研究

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  Q&A付きで1930年以前のテキスト260Bトークンで訓練された13BパラメータLLM。 [ベース](https://huggingface.co/talkie-lm/talkie-1930-13b-base) バージョンもあります。
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  Q&A付きで1800-1899年のテキストで訓練された1.4BパラメータLLM。 [160M](https://huggingface.co/zakarth/violet-160m-chat) バージョンもあります。
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  Q&A付きで1837-1899年の28,000以上のテキストで訓練された340MパラメータLLM。

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Qwen3アーキテクチャに基づき、1913、1929、1933、1939、1946の知識カットオフまでの歴史データ80Bトークンからゼロから訓練された4BパラメータLLMファミリー。
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - 英語の1913年以前のテキストのみを事前学習した7.24B歴史言語モデル（LM）。ウォータールー大学、アデレード大学、オックスフォード大学、ユニバーシティ・カレッジ・ロンドンの研究者によって作成。 [論文リンク](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPTは、EEBOとGallicaの主に英語、フランス語、ラテン語の11,000の初期近代テキストでMistral-Hermes 2をファインチューニングしたモデル。

## 謝辞

v2リリースのための学術的指導、研究の枠組みと評価へのガイダンス、トークナイザー訓練とデータセット準備の支援について、[Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) に感謝します。彼のフィードバックと経験は本研究の内容を洗練する上で非常に重要でした。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---