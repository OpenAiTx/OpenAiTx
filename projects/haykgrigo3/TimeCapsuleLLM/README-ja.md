# TimeCapsule LLM
特定の時代のデータのみで訓練されたLLMで、現代のバイアスを軽減します。

AIモデルが単に歴史的なふりをするだけでなく、実際にそうであったと想像してみてください。

[Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT)を基に構築。コアのトレーニングスクリプトとモデルアーキテクチャは彼の作品です。

# プロジェクトの目標

TimeCapsule LLMは、特定の時代に書かれたテキストのみで訓練される実験的プロジェクトです。目的は特定の歴史的時代の世界観と言語をシミュレートすることです。

# なぜファインチューニングだけでは不十分か

既に訓練されたモデルをファインチューニングするだけでは、LLMは現代の概念を依然として知っています。もちろん、現代のバイアスをゼロにするのは難しいですが、できるだけ近づけたいです。現代のバイアスを完全になくすには、モデルをスクラッチから訓練する必要があります。

# 期待される成果

完成すれば、このモデルは現代の概念を知らず、訓練された範囲を超えて推論できないはずです。現代の概念や語彙を認識せず、現代の知識を幻覚しないことを望んでいます。

# 進捗報告

## 2025年7月9日

期間は1800年から1850年、地域はロンドンに設定しました。

テキスト、書籍、文書のリストを収集しました。

現在50ファイルをテキスト形式で取得し、間もなくNanoGPTの訓練を開始します。

進捗があれば更新します。

## 2025年7月13日

187MBの歴史的テキストデータでnanoGPTを訓練しました。

## 2025年7月15日

2回目の訓練用にテキストをダウンロードし始めました。すべてInternet Archiveから取得し、期間を1800年から1875年に拡大しました。多様なテキストを得るために、Internet Archiveの出版場所、期間、主題の検索フィルターを使うことができます。

![Search Filters](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

Internet Archiveから約500のテキストファイルをダウンロードし、空白やGutenbergのヘッダーなどを削除してクリーンアップした後、約500MBのデータが得られました。非常に小さなデータセットですが、前回は187MBで訓練したため、2回目のモデル訓練後には何らかの違いが出るはずです。少なくともより一貫性のある意味の通った文章を生成できることを期待しています。もちろん保証はできませんが、前回よりは多いデータ量です。

これは自分のハードウェアで可能で、GPUをレンタルする前に改善が見られるか確認できるのは良いことです。GPUレンタルは予定していますが、その前にデータセットをできるだけきれいにキュレーションしたいです。問題の一つはクリーンアップで、多くのテキストファイルに意味不明な文字列が混じっています。使用したスクリプトは機能しますが、完全ではありません。

このデータセットで今日訓練を開始し、4～5時間かかる予定です。完了しテストしたら更新します。プロジェクトを見てくれている皆さん、OCRリソースのリンクを提供してくれた方もいてありがとうございます！もっと多くの人が独自のデータセットで試して実験してほしいです。

### 訓練状況報告

435MB（1億800万トークン）のコーパスで訓練を開始し、順調に進んでいます。2800イテレーションでトレインロスは10.9から4.9に下がりました。完了まで8～9時間かかる見込みです。完了後に再度報告します。

## 2025年7月17日 午前2:13

2回目のモデルの訓練が完了しました。4060で約8時間40分（3,900イテレーション/時間）、合計33,000イテレーション（5エポック）かかりました。最終トレインロスは3.73でした。出力は驚くほど良く、19世紀風のまとまった文章を生成します。

# V0モデルの挙動と制限

初期のプロンプトでは、モデルは1800年代の言語と振る舞いで応答します。例えば「Who art Henry?」と聞くと「I know that man, I have did not a black, the storm.」と返します。この文章は意味不明ですが、LLMが人について尋ねられていると認識していることがわかります。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

現代の概念は一切出てこず、出力は主に1800年代の単語や表現で構成されています。

まだ多くの改善が必要で、187MBのデータ量では複雑な推論を行うテキスト生成はできません。

現状では文法的に不完全で意味をなさない文章が多いですが、これは訓練データ量が少ないため通常のことです。

# V0.5モデルの挙動と制限

前モデルからの大きな改善です。文体と言葉遣いはヴィクトリア朝風で、ほぼすべての文が文法的に正しく、適切な句読点が使われています。スクラッチで訓練しているため1800年代の話題に忠実です。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

多くの事実的な幻覚があります。日付、出来事、歴史上の人物などの詳細はほぼ100%作り話です。また文同士のつながりが乏しく、2文程度が関連することはありますがそれ以上はありません。さらに時折「Digitized by Google」のフッターが混入することがあり、次回の訓練ではテキストのクリーンアップを徹底する必要があります。全体的には満足しています。まだLLMとは言えませんが、確実に文生成器です。

多くを学んでおり、今後数週間で改善点を模索していきます。ファイルも近日アップロード予定です！

# 今後の計画

バージョン1の作業を開始します。50冊の本で訓練する代わりに、理想的には500～600冊で訓練します。現在は1800～1850年のロンドンの本でnanoGPTを訓練中です。課題としては、見つけた本が改訂されていないことや現代の解釈が入っていないこと、選んだ期間内に出版された未加工の本であることを確認する点があります。

# このプロジェクトの使い方

このプロジェクトは主に歴史的データの収集、訓練用準備、トークナイザーの構築に焦点を当てています。完全なLLM訓練プロセスはカバーしません。詳しくはAndrej KarpathyのnanoGPTを参照してください。

# ステップ1: 歴史的テキストの収集と準備

選んだ時代（例：ロンドン1800-1850年）のパブリックドメインの書籍や文書の.txtファイルを集めます。

必要であればdownload_texts_improved.pyを使って書籍をダウンロードできます。

Project Gutenbergのヘッダーやフッター、現代の注釈、OCRエラーなどをスクリプトや手動で除去してテキストファイルをクリーンアップします。

prepare_dataset.pyが正常に動作します。

# ステップ2: カスタムトークナイザーの構築

クリーンアップ済みデータに対してtrain_tokenizer.pyまたはtrain_tokenizer_hf.pyを実行します。
This will give you vocab.json and merges.txt

Thes files define vocab and merge rules for your model

# Step 3: Train Your Model (nanoGPT) 

Refer to [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) for the training process.

You can train a different LLM if you want, but I used nanoGPT 

# FAQ

## Why not just use fine-tuning or LoRA?

For this project I'm trying to create a language model that is unclouded from modern bias. If I fine-tune something like GPT-2, it's already pre-trained and that information won't go away. If I train from scratch the language model won't pretend to be old, it just will be. The Goal for this project right now is to create something can reason exclusively using knowledge from London books published between 1800 and 1850.

## What kind of data did you use for training?

I'm using books, legal documents, newspapers, and other writings from 1800–1850 London. The list I linked has like 200 but for the first training I just used 50 files about ~187 MB. You can view a list of the documents:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## How large is the Version 0 model ?

This model is very small right now, I'm just doing this for fun and following a strict training rule of no modern sources. It has almost 16 million parameters but I'm gonna start gathering more old texts to begin another model training. Will give updates as I go.

## Training Specs ? 

GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---