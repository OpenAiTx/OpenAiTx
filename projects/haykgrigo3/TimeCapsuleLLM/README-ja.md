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
特定の時代のデータのみで訓練されたLLM。現代的なバイアスを減らすためのものです。

AIモデルが歴史的なふりをするだけでなく、本当にそうであったらどうなるでしょう。

[Andrej KarpathyによるnanoGPT](https://github.com/karpathy/nanoGPT)をベースに構築。コアのトレーニングスクリプトとモデルアーキテクチャは彼の仕事です。

# プロジェクトの目的

TimeCapsule LLMは特定の時代に書かれたテキストのみで訓練される実験的プロジェクトです。目標は、特定の歴史時代の世界観と言語をシミュレートすることです。

# 微調整だけでは不十分な理由

事前学習モデルを微調整しただけでは、LLMはやはり現代的な概念を知っています。完全な現代バイアスゼロは困難ですが、できるだけこれに近づきたいと考えています。現代バイアスゼロを目指すなら、モデルをゼロから訓練する必要があります。

# 期待される成果

完成した際、このモデルは現代的な概念を知らず、訓練された内容を超えて推論できないはずです。現代的な語彙や概念を認識せず、現代知識を幻覚しないことを期待しています。

# 進捗状況

## 2025年7月9日

1800～1850年を時代設定、地域はロンドンに決定しました。

テキスト・書籍・文書のリストを集めました。

これまでにtxtファイルとして50件集めたので、間もなくNanoGPTの訓練を始めます。

進捗があればここに追記していきます。

## 2025年7月13日

nanoGPTを187MBの歴史的テキストデータで訓練しました。

## 2025年7月15日

第2回目の訓練のためにテキストのダウンロードを開始しました。Internet Archiveから全て取得しており、時代範囲も1800～1875年に拡大しました。多様なテキストを得るため、Internet Archiveの出版地・時代・主題でフィルタ検索を利用できます。

![検索フィルタ](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

Internet Archiveから約500件のtxtファイルをダウンロードし、ホワイトスペースやグーテンベルクのヘッダー等を削除してクリーンアップ後、約500MBのデータとなりました。データセットは小さいですが、前回は187MBで訓練したので、今回は出力に何らかの違いが現れるはずです。このモデルがより一貫した意味のある文を生成できることを期待しています。もちろん、まだ非常に小さいデータセットなので保証はできませんが、前回よりは増えています。

自分のハードウェアでも処理できそうで、それも良い点です。大規模データセットへ進む前に改善を体感できるかもしれません。GPUをレンタルする予定ですが、その前にデータセットをできるだけ精選・クリーンにしたいです。問題の一つはクリーンアップで、txtファイルには無意味な文字列も多いです。クリーニング用スクリプトは役立ちますが、100％効果的ではありません。

本日このデータセットで訓練します。所要時間は4～5時間の見込みです。完了後にテスト・報告します。プロジェクトを見てくださる皆様、OCRリソースを教えてくれた方々、本当にありがとうございます！ぜひ、他の方も自分のデータセットで試してみてください。

### 訓練状況アップデート

435MB（1億800万トークン）のコーパスで訓練を開始し、今のところ順調です。最初の2800イテレーションでトレインロスが10.9から4.9に下がりました。完了まで8～9時間程度かかると予想されます。完了したらまた報告します。

## 2025年7月17日 2:13AM

第2モデルの訓練が完了しました。4060 GPUで8時間40分（3,900イテレーション／時）かかり、33,000イテレーション（5エポック）を回しました。最終トレインロスは3.73でした。出力も驚くほどよく、19世紀スタイルの一貫した文が生成されています。

## 2025年7月28日

v0.5をHugging Faceにアップロードしました。[こちらからご覧ください](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。リポジトリをダウンロードしローカルで実行可能です。残念ながらnanoGPTはHuggingFaceにネイティブ対応していないので、モデルをローカルでダウンロードして実行する必要があります。

また、次回訓練用データのキュレーションも始めます。推論能力を得るにはデータ量が5～10倍必要だと考えています。

# V0モデルの挙動と制限

初期プロンプトでは、モデルが1800年代の言葉と挙動で応答します。たとえば「Who art Henry?」と聞いたところ「I know that man, I have did not a black, the storm.」と返し、文章としては意味不明ですが、人について尋ねていることは認識しています。




![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

現代的な概念には一切言及されておらず、出力内容もほとんどが1800年代の単語や言い回しで構成されています。

まだ多くの改善が必要です。187MBのデータで学習しても、複雑な推論を伴うテキストを生成するモデルにはなりません。

現在のところ、文は完全な構造を持たず、全体的に意味が通らないものになっていますが、これは学習データ量の規模からすると普通のことです。

# V0.5 モデルの挙動と制限

前回のモデルと比べると大きく改善されています。文章のスタイルや語彙はヴィクトリア朝風で、ほぼすべての文が文法的に正しく、句読点も適切です。そして、これはゼロから学習しているので、1800年代の話題にしっかりと限定されています。

![TimeLockLLM サンプル出力](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

事実誤認が多く見られます。詳細（日時、出来事、歴史的人物）についてはほぼ100%が創作です。また、文同士の繋がりもあまりなく、2文ほど関連することはありますが、それ以上は繋がりません。さらに、時折「Digitized by Google」というフッターが混入するため、次回はテキストのクリーニングを徹底する必要があります。全体的には結果に満足しています。まだLLMには程遠いですが、確かに文生成器にはなっています。

多くのことを学びつつあり、今後数週間で改善すべき点を見極めていきます。ファイルも近々アップロード予定です！

# 今後の計画

（完了）バージョン0.5の作業を開始します。50冊ではなく、理想的には500〜600冊を使って学習します。現在は1800〜1850年のロンドンに限定し、nanoGPTで学習しています。見つけた本が改訂や現代的解釈を含まないようにすること、選択した時代のままの出版物であることが課題です。

新しいモデル（v1）を、v0.5の5〜10倍の大きさのコーパスで学習させたいと考えています。Selective Temporal Trainingだけで推論能力が現れるかを目指していますが、これはより困難な課題であり、歴史的データの制約もあるため可能かどうかも分かりません。今後数週間で5〜10GB分のデータをキュレートする予定です。高品質なデータとGPUが手配できれば、進展があると信じています。

# 本プロジェクトの使い方

このプロジェクトは主に歴史的データのキュレーション、学習用の準備、トークナイザーの構築に焦点を当てています。LLM全体の学習プロセスは対象外ですので、詳細はAndrej KarpathyのnanoGPTを参照してください。

# ステップ1: 歴史的テキストを収集・準備する

選択した時代のパブリックドメイン書籍や文書の.txtファイルを集めます（例: 1800〜1850年ロンドン）

必要ならdownload_texts_improved.pyを使って書籍をダウンロードできます。

テキストファイルはスクリプトまたは手動で、プロジェクトグーテンベルクのヘッダー/フッターや現代的注釈、OCRエラーなどを除去してクリーンアップします。

prepare_dataset.pyで十分動作します。

# ステップ2: カスタムトークナイザーを構築する

クリーンなデータでtrain_tokenizer.pyまたはtrain_tokenizer_hf.pyを実行します。
これによりvocab.jsonとmerges.txtが得られます。

これらのファイルがモデルの語彙とマージルールを定義します。

# ステップ3: モデルを学習する（nanoGPT）

学習プロセスは[Andrej KarpathyのnanoGPT](https://github.com/karpathy/nanoGPT)を参照してください。

他のLLMで学習しても構いませんが、私はnanoGPTを使用しました。

# FAQ

## Selective Temporal Trainingとは？

Selective Temporal Training（STT）は、すべての学習データを特定の歴史的時代に限定して厳選する機械学習手法です。現代的な概念の影響を受けずに、その時代の言語と知識をモデル化するために行います。たとえば、現在のモデル（v0.5）は1800〜1875年のデータのみでゼロから学習されているため、その時代の言語スタイルや歴史的文脈が出力に反映されます。

## なぜファインチューニングやLoRAを使わないのですか？

本プロジェクトでは現代のバイアスがない言語モデルを作りたいと考えています。GPT-2のような既存モデルをファインチューンしても、事前学習された情報は消えません。ゼロから学習すれば、モデルは「古いふり」をするのではなく、実際に古いものになります。今の目的は、1800〜1850年のロンドン書籍だけの知識で推論できるモデルの作成です。

## 学習に使ったデータは？

1800〜1850年ロンドンの書籍、法文書、新聞、その他の文献を使っています。リンク先には約200点ありますが、最初の学習では約50ファイル（約187MB）だけを使用しました。ドキュメント一覧はこちら：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## バージョン0モデルの規模は？

今のモデルはとても小さく、趣味的に、現代的な情報を排除する厳格なルールで作っています。パラメータ数は約1600万ですが、さらに古いテキストを集めて次の学習に使う予定です。進捗があれば随時報告します。

## 学習スペックは？

GPU: Geforce rtx 4060
CPU: i5-13400F 
メモリ: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---