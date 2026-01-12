# GOT-OCR-2-GUI

## [英語版はこちら](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/README-en.md)

🛑サポート停止、今後は気ままに更新

![img.png](https://raw.githubusercontent.com/XJF2332/GOT-OCR-2-GUI/main/img.png)

## このプロジェクトについて

モデル重み：[ミラーサイト](https://hf-mirror.com/stepfun-ai/GOT-OCR2_0)、[公式サイト](https://huggingface.co/stepfun-ai/GOT-OCR2_0)  
元GitHub：[GOT-OCR2.0](https://github.com/Ucas-HaoranWei/GOT-OCR2.0/)   
このプロジェクトはWindows上で開発されています。私はLinuxを使ったことがなく、Linux上で正常に動作するか保証できません。  
もしLinuxでのデプロイをする場合は、この[issue](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/3)を参考にしてください。  
一部のコードは以下からのものです：[GLM4](https://chatglm.cn/main/alltoolsdetail?lang=zh)、[Deepseek](https://www.deepseek.com/)

スターを押してください

## ToDo

- [x] ログ内容のローカライズ
- [ ] 新モデル stepfun-ai/GOT-OCR-2.0-hf のサポート
- [ ] PDF関連のエラー処理ロジックの最適化
- [x] GGUFモデルのサポート、推論の高速化を期待（[issue #19](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/19) の協力に感謝）
- [ ] GGUFモデルのサポートの充実
- [x] 新レンダリングモード：性能最適化、より多くのフォーマット出力対応
- [ ] 旧レンダラーの削除/非表示

## 使い方

ここにあるフォルダがなければ、**新規作成してください**

### ブランチを選択

#### Alpha

最も更新が早いブランチで、最新の変更はすべてここにコミットされます。  
コードは時々未テストの場合があります。  
非常に不安定で、時には使用できないこともあります。

#### main

比較的に安定したブランチですが、いくつかの新機能が欠けていることがあります。

### 依存関係

この環境は**python 3.11.9**でテストされ、正常に動作することが確認されています。

#### torch

[torch公式サイト](https://pytorch.org/get-started/locally/)から自分に合った**GPUバージョン**のtorchをインストールしてください。  
以前はStable 2.4.1 + cu124を使用していました。  
現在はStable 2.0.1 + cu118を使用しており、`1 Torch is not compiled with Flash Attention`の問題を解決できており、他の問題は見つかっていません。

#### PyMuPDF

実際に`requirements.txt`から直接インストールすると`ModuleNotFoundError: No module named 'frontend'`が発生します。  
しかし、個別にインストールするとこの問題は発生しません。具体的な原因は不明です。  
また、もし依然として`ModuleNotFoundError`が発生する場合は、まず`fitz`と`PyMuPDF`をアンインストールし、再度インストールすると解決する可能性があります。実際には`pip install -U PyMuPDF`だけでは効果がありません。


```commandline
pip install fitz
pip install PyMuPDF
```
#### 使用`pip`でのインストール


```commandline
pip install -r requirements.txt
```
また、`requirements.txt`を使って依存関係をインストールした際に競合問題が発生したという報告がありましたが、私の環境では問題は見つかりませんでしたし、`pipdeptree`でも競合は表示されませんでした。  
`requirements.txt`は私の仮想環境で`pip freeze`したものをそのまま使っているので、基本的には問題ないはずです。  
しかし、実際に問題が起きている方もいるため、バージョン番号なしの`requirements-noversion.txt`を用意しましたので、試してみてください：  
詳細はこの [issue #4](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/4) をご覧ください。


```commandline
pip install -r requirements-noversion.txt
```
#### その他

- [Edge WebDriver](https://developer.microsoft.com/zh-cn/microsoft-edge/tools/webdriver/?form=MA13LH#downloads)  
  圧縮ファイルをダウンロードし、`edge_driver`フォルダに入れる

> みんなのパソコンにはedgeが入ってるはずだよね？多分？これってプリインストールされてるはず……  
> ファイル構成は以下のような感じのはず：
> ```
> GOT-OCR-2-GUI
> └─edge_driver
>    ├─msedgedriver.exe
>    └─...
> ```

### モデルファイルのダウンロード

以下のモデルのうちどれか1つあればOCRは実行できるが、自動ロード機能を使うには`Safetensors`モデルが必要  
GGUFモデルのサポートはまだ十分ではなく、現在はGGUFタブで個別に試すことができる

#### Safetensors

1. `models`フォルダにダウンロードする  
2. ファイルのダウンロード漏れに注意  
3. 新しい`GOT-OCR-2-HF`モデルの場合（現在は未対応）、`models-hf`フォルダにダウンロードする（ただし現時点では対応していない）

- ファイル構成は以下のような感じのはず：


```
GOT-OCR-2-GUI
└─models
   ├─config.json
   ├─generation_config.json
   ├─got_vision_b.py
   ├─model.safetensors
   ├─modeling_GOT.py
   ├─qwen.tiktoken
   ├─render_tools.py
   ├─special_tokens_map.json
   ├─tokenization_qwen.py
   └─tokenizer_config.json
```
#### GGUF

GGUF モデルは `got.cpp` によってサポートされています  
モデルをダウンロードするには `MosRat/got.cpp` リポジトリへ行き、`Encode.onnx` を `gguf\Encoder.onnx` に置き、残りの Decoder GGUF モデルは `gguf\decoders` に入れてください

### 使用開始

1. コマンドラインを使いたい場合は `CLI.py` を使用してください  
2. グラフィカルインターフェースを使いたい場合は `GUI.py` を使用してください  
3. 設定を変更したい場合は `Config Manager.py` を使用してください  
4. 自動レンダリング処理を実行したい場合は `Renderer.py` を使用してください。`imgs` フォルダ内のすべての `.jpg` と `.png` 画像を自動でレンダリングします

> GUI を使う場合は気にしなくて構いませんが、CLI を使う方は OCR したい画像を `imgs` フォルダに入れてください（CLI は現在 `.jpg` と `.png` の画像のみを検出します）

## ローカライズサポート

- `Locales` フォルダ内に各言語の `.json` ファイルがあり、CLI と GUI の言語ファイルは別々に保存されています  
- `gui` サブフォルダ内には言語 `.json` ファイルの他に `instructions` フォルダがあり、GUI の組み込みチュートリアルが `言語.md` という名前であります  
- 言語サポートを変更したい場合は、`config.json` の `'language'` の値を変更してください。使用可能な選択肢は言語 `.json` ファイルの拡張子を除いたファイル名です  
- 新しい言語サポートを追加する場合、CLI では新しい言語 `.json` を追加するだけで（既存のファイルを基にすることを強く推奨します）、GUI では対応する `言語.md` ファイルも必要です  
- 言語やその他の設定ファイルは `Config Manager.py` で管理できます

## 注意事項

- スクリプトがクラッシュする場合は、`cmd` で `python +ファイル名` を実行してみてください。私自身テスト時にクラッシュすることがあり、原因は不明です  
- `result` フォルダ内の `markdown-it.js` を削除しないでください。削除すると PDF 出力がエラーになります！

> もし誤って削除してしまった場合は、`scripts` フォルダ内にバックアップがありますので、コピーして戻してください

- インストールしている `torch` は GPU バージョンであることを確認してください。スクリプト内で `device_map='cuda'` を使用しています

## よくある質問

- Q：CLI.py: error: the following arguments are required: --path/-P  
- A：PowerShell を使ってください。CMD ではなぜかこのバグが出るようで、原因はまだ見つかっていません  
---  
- Q：「HTML本地文件」とは何ですか？ローカルに保存されていないHTMLファイルがあるのですか？  
- A：モデルが出力するHTMLファイルはローカルに保存されていますが、外部スクリプトを使用しているため、ファイルがローカルにあってもネットワーク接続が必要です。そのため外部スクリプトをダウンロードしてきて、先に述べた通りにしています


  `mardown-it.js`。これは主にネットワークの問題によるPDFエクスポートの失敗を防ぐためです。
---
- Q：なぜ私のモデルの読み込みに失敗したのですか？
- A：ファイルが不足していないか確認してください。百度クラウドからダウンロードしたモデルファイルはファイルが不足しているようです。前述のHuggingfaceからダウンロードすることをお勧めします。
---
- Q：このプロジェクトのデプロイに関するアドバイスはありますか？
- A：こちらの[issue #5](https://github.com/XJF2332/GOT-OCR-2-GUI/issues/5)をご覧ください。
---
- Q：どこでヘルプドキュメントを見られますか？
- A：GUIユーザーの場合は`説明`タブを探してください。CLIユーザーの場合は、`.\CLI.py --help`でargparseが自動生成するヘルプドキュメントを確認できますし、`.\CLI.py --detailed-help`でより詳細なヘルプドキュメントを見ることもできます。

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=XJF2332/GOT-OCR-2-GUI&type=Date)](https://star-history.com/#XJF2332/GOT-OCR-2-GUI&Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-12

---