
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
特定の時代のデータのみで訓練され、現代的なバイアスを減らしたLLM。

AIモデルが歴史を演じるだけでなく、実際にその時代のものだったらどうなるか想像してください。

[Andrej Karpathy氏のnanoGPT](https://github.com/karpathy/nanoGPT)を基盤としています。コアの訓練スクリプトとモデルアーキテクチャは彼の仕事です。

# プロジェクトの目的

TimeCapsule LLMは、特定の時代に書かれたテキストのみで訓練される実験的プロジェクトです。目的は、特定の歴史時代の世界観と言語をシミュレートすることです。

# ファインチューニングだけでは不十分な理由

事前学習済みモデルをファインチューニングするだけでは、あなたのLLMはやはり現代の概念を知っています。もちろん完全な現代的バイアスゼロは難しいですが、私はできるだけこれに近づきたいと考えています。現代的バイアスを排除するには、モデルをゼロから訓練する必要があります。

# 期待される成果

完成時には、このモデルは現代の概念を知らず、訓練された範囲を超えて推論することができないことを期待しています。現代的な概念や語彙を認識せず、現代知識を幻覚的に生成しないことを望みます。

# 進捗状況

## 2025年7月9日

1800-1850年、地域はロンドンに設定しました

テキスト・書籍・文書のリストを収集しました

今のところ50個のtxtファイルが集まり、まもなくNanoGPTでの訓練を始めます

進捗があれば随時更新します

## 2025年7月13日

nanoGPTを187MBの歴史的テキストデータで訓練しました。

## 2025年7月15日

2回目の訓練用にテキストのダウンロードを始めました。全てInternet Archiveから入手し、期間も1800-1875年に拡大しました。多様なテキストを得るため、Internet Archiveの検索フィルターで出版地や時代、主題を指定できます。

![検索フィルター](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

Internet Archiveから約500個のtxtファイルをダウンロードし（空白やGutenbergのヘッダー等を削除してクリーンアップ後）、約500MBのデータになりました。これはとても小さなデータセットですが、前回は187MBで訓練したので、2回目のモデル訓練後には出力に何らかの目立った違いが現れるはずです。今回のモデルは、少なくとももう少し意味の通る文章を生み出せることを期待しています。もちろんこれはまだ非常に小さなデータセットなので保証はできませんが、前回よりは多いです。

これは自分のハードウェアで十分に処理可能で、より大きなデータセットに飛び込む前に何らかの改善を確認できるのも良い点です。もちろん近々GPUを借りる予定ですが、その前にデータセットをできるだけ厳選・クリーンにしておきたいです。問題の一つはクリーンアップで、多くのtxtファイルに意味不明な文字列が混在しています。使っているクリーニングスクリプトはある程度機能しますが、完全ではありません。

本日このデータセットで訓練し、4〜5時間程度かかる見込みです。完了しテストしたらまた報告します。プロジェクトを見てくれている皆さん本当にありがとう。OCRリソースのリンクを送ってくれた方もいて感謝しています！より多くの人が自身のデータセットで試してくれることを願っています。

## 2025年7月28日

v0.5をHugging Faceにアップロードしました。[こちらからどうぞ](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。リポジトリをダウンロードしてローカルで実行できます。残念ながらnanoGPTはHuggingFaceとネイティブには動作しないため、モデルをダウンロードしてローカルで実行する必要があります。

また次回の訓練用データの選定も始めます。推論能力を得るにはデータ量が今の5～10倍は必要だと考えています。

### 訓練状況のアップデート

435MB（1億800万トークン）のコーパスで訓練を始め、今のところ順調です。最初の2800イテレーションで訓練損失が10.9から4.9に下がりました。完了までに8～9時間かかる見込みです。終わったらまた報告します。

## 2025年7月17日 2:13AM

2回目のモデル訓練が完了しました。4060で約8時間40分（3,900イテレーション/時）かかり、33,000イテレーション（5エポック）行いました。最終的な訓練損失は3.73でした。出力は驚くほど良く、本当に19世紀風の一貫性のある文章を生成できるようになりました。

# V0モデルの挙動と限界

初期のプロンプトでは、モデルが1800年代の言葉遣いや振る舞いで応答しています。例えば「Who art Henry?」と質問したところ、「I know that man, I have did not a black, the storm.」と返答し、意味は通じませんが、人について尋ねられたことは認識しています。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

現代的な概念への言及はなく、出力される内容はほとんどが1800年代の言葉や表現です。

まだ多くの改善が必要であり、187MBでトレーニングしても複雑な推論を行うモデルにはなりません。

現在は、完全な文構造がなく、全体的に意味をなさない文を生成しますが、これはトレーニングデータのサイズとしては普通のことです。

# V0.5 モデルの挙動と制限

前回のモデルと比べて大きな改善です。文体や語彙はヴィクトリア朝風で、ほぼすべての文が文法的に正しく、適切な句読点が使われています。そして今回もスクラッチからトレーニングしているので、1800年代のテーマに忠実です。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

事実に基づかない内容（ハルシネーション）が多く見られます。詳細（日時、出来事、歴史的人物など）はほぼ100%作り話です。また、文同士の関連性がなく、時々2文が関連することはあってもそれ以上はありません。さらに「Digitized by Google」のようなフッターが現れることがあるので、次回はより徹底的にテキストをクリーニングする必要があります。全体としては結果に満足しています。LLMには到底及びませんが、確かに文章生成器です。

多くを学んでいるので、今後数週間で改善策を模索していきます。ファイルも近日中にアップロード予定です！

# 今後の予定

（完了）バージョン0.5の作業を始めます。50冊の本でなく、理想的には500～600冊でトレーニングします。現在は1800～1850年のロンドンの本を使ってnanoGPTをトレーニング中です。見つけた本が改訂版や現代の解釈が加えられていない、当時そのままの本かどうか確認するなどの課題もあります。

新たなモデル（v1）を、v0.5の5～10倍の大きさのコーパスでトレーニングしたいと考えています。Selective Temporal Trainingだけで推論能力が出現するかを目指しますが、歴史データの制限もあり難しい課題です。今後数週間で5～10GBのコーパス用データをキュレーションします。高品質なデータとGPUをレンタルできれば、進展があるはずです。

# このプロジェクトの使い方

本プロジェクトは主に歴史データのキュレーション、トレーニング用の準備、トークナイザーの構築に焦点を当てています。LLM全体のトレーニングプロセスは扱いませんので、詳細はAndrej Karpathy氏のnanoGPTを参照してください。

# ステップ1: 歴史的テキストの収集と準備

選択した時代（例：ロンドン1800～1850年）のパブリックドメインの書籍や文書などの.txtファイルを集めます。

必要ならdownload_texts_improved.pyを使って書籍を自動ダウンロードできます。

スクリプトや手動で、Project Gutenbergのヘッダー・フッター、現代の注釈、OCRエラーなどを削除してクリーンアップします。

prepare_dataset.pyで問題なく処理できるはずです。

# ステップ2: カスタムトークナイザーの構築

クリーンデータに対してtrain_tokenizer.pyかtrain_tokenizer_hf.pyを実行します。
これでvocab.jsonとmerges.txtが得られます。

これらのファイルがモデル用の語彙やマージルールを定義します。

# ステップ3: モデルのトレーニング（nanoGPT）

トレーニングプロセスは [Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT) を参照してください。

他のLLMを使っても構いませんが、私はnanoGPTを使いました。

# よくある質問（FAQ）

## Selective Temporal Trainingとは？

Selective Temporal Training（STT）は、すべてのトレーニングデータが特定の歴史時代に限定されている機械学習手法です。その時代の言語や知識を現代的な概念の影響なしにモデル化するために行います。例えば、現行モデル（v0.5）は1800～1875年のデータのみでスクラッチからトレーニングしており、その時代の言語的スタイルや歴史的文脈が反映されたアウトプットになります。

## なぜファインチューニングやLoRAを使わないのですか？

このプロジェクトでは現代的なバイアスのない言語モデルを作りたいからです。GPT-2などをファインチューニングしても、既に現代的な事前学習がされており、その情報は消せません。スクラッチからトレーニングすれば、モデルは古いふりをするのではなく、実際に古いものになります。今の目標は1800～1850年にロンドンで出版された本の知識だけで推論できるものを作ることです。

## どのようなデータをトレーニングに使いましたか？

1800～1850年のロンドンの書籍、法的文書、新聞、その他の著作物を使用しています。リンク先リストには約200件ありますが、最初のトレーニングでは50ファイル（約187MB）だけ使いました。ドキュメントリストはこちら：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## バージョン0モデルの大きさは？

このモデルは非常に小さいです。趣味でやっているのと、現代の資料を一切使わないという厳格なルールでやっています。パラメータは約1600万ですが、今後さらに古いテキストを集めて新しいモデルのトレーニングを始めます。進捗があれば随時報告します。

## トレーニング環境は？

GPU: Geforce rtx 4060
CPU: i5-13400F
メモリ: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---