# 🌈 レインボーファート・ワイフ
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

ウェブサイト：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

言語: [简体中文](./README.zh.md) | English

## 概要

----

この拡張機能のアイデアは[@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart)から得ており、全てのコードをリライトしました。全てのボイスパッケージに互換性があり、新機能も追加しています。

## 特別感謝

---

1. この拡張機能には[@justkowalski](https://github.com/JustKowalski)の中国語ボイスパッケージが含まれています。[GitHubでさらに多くのボイスパッケージを入手できます](https://github.com/topics/rainbow-fart)。
2. この拡張機能には[@James K. Lawless](http://jiml.us)によるcmdmp3win.exeが含まれています。
3. デフォルトのワイフモデルは[@二夏](https://erxia207.lofter.com)によるものです。あなただけのオリジナルワイフをデザインしたい場合は、彼女にご連絡ください。
4. 拡張機能にはもう一つのワイフモデル「keysoban」が含まれており、[@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632)によってオープンソース化されています。

[さらに多くのワイフモデルを入手](https://github.com/ezshine/live2d-model-collections)

## サポートされているプラットフォーム

---

~~~~
MacOSおよびWindows10のみサポート
~~~~

## Q&A

---

#### _ワイフが表示されませんか？_
> A: [こちらから](https://github.com/ezshine/live2d-model-collections)ワイフコンテナをダウンロードする必要があります。zipファイルをすべて解凍した後、liv2dplayer.exeを実行し、VSCodeでコマンドリストを呼び出してワイフモデルの切り替えを試してください。

## マニュアル・コマンド

---

🌈 レインボーファート・ワイフ コマンド一覧

- 「ボイスパッケージを切り替える」
- 「ワイフモデルを切り替える」
- 「リソースディレクトリを開く」

> ボイスパッケージやモデルパッケージをダウンロードした場合、このコマンドを使ってリソースディレクトリを開き、パッケージをそのパス下に移動してください。

- 「ワイフコンテナやその他リソースをダウンロード」

## 機能

---

1. WebUIを削除し、MacOSでは'afplay'、Windows10では'cmdmp3win'を使って音声ファイルを再生します。
2. WaifuContainerと連携し、仮想のワイフがデスクトップでプログラミングの伴侶となります。

## ボイスパッケージに関する注意

---

~~~~
カスタマイズしたボイスパッケージやインターネットからダウンロードしたボイスパッケージを使用する際の注意点
~~~~

1. 'manifest.json'ではなく'contributes.json'を使用してください。
2. ボイス内容に合うテキストを'contributes.json'に追加してください。

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "わあ、あなたのコールバック関数とても素晴らしいですね！",
            "この関数の名前、私の名前にしてみませんか？",
            "どんなにすごい関数でも、あなたへの想いは実行できません！"
        ]
    }
]
~~~~

## サポートのお願い

---

この拡張機能があなたのプログラミングを楽しくしたなら、コーラを一杯ごちそうしてもらえますか？

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)
**お楽しみください！**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---