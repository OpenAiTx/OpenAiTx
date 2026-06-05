# edge-tts-go

* [中文](https://github.com/wujunwei928/edge-tts-go/blob/main/README.md)
* [English](https://github.com/wujunwei928/edge-tts-go/blob/main/README_en-US.md)

`edge-tts-go` は golang モジュールであり、golang のコードから、または提供されている `edge-tts-go` コマンドを使って Microsoft Edge のオンラインテキスト読み上げサービスを利用できます。

## インストール

### go install
    $ go install github.com/wujunwei928/edge-tts-go

### 事前コンパイル済みバージョンのダウンロード
    https://github.com/wujunwei928/edge-tts-go/releases

## 使い方

### 基本的な使い方

`edge-tts-go` コマンドを使用したい場合は、以下のコマンドで実行してください：

    $ edge-tts-go --text "Hello, world" --write-media hello.mp3

### 音声の変更

テキスト変換時に使用する音声を変更したい場合。

使用可能な音声を確認するには `--list-voices` オプションを使います：

    $ edge-tts-go --list-voices
    Name: Microsoft Server Speech Text to Speech Voice (zh-CN, XiaoxiaoNeural)
    ShortName: zh-CN-XiaoxiaoNeural
    Gender: Female
    Locale: zh-CN
    ContentCategories: News,Novel
    VoicePersonalities: Warm
    
    Name: Microsoft Server Speech Text to Speech Voice (zh-CN, XiaoyiNeural)
    ShortName: zh-CN-XiaoyiNeural
    Gender: Female
    ロケール: zh-CN
    コンテンツカテゴリ: カートゥーン、小説
    ボイスパーソナリティ: 活発

    ...

`--voice` オプションで音声を指定して変換

    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" --write-media hello_in_chinese.mp3

    もしffplayをPCにインストールしている場合は、以下のコマンドで直接音声ファイルを再生可能です:
    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" | ffplay -i -

### 速度、音量、ピッチの変更

    $ edge-tts-go --rate=-50% --text "Hello, world" --write-media hello_with_rate_halved.mp3
    $ edge-tts-go --volume=-50% --text "Hello, world" --write-media hello_with_volume_halved.mp3
    $ edge-tts-go --pitch=-50Hz --text "Hello, world" --write-media hello_with_pitch_halved.mp3

## go モジュール

`edge-tts-go` モジュールはgoコード内で直接使用可能で、呼び出し方法は以下のファイルを参照してください:

* https://github.com/wujunwei928/edge-tts-go/blob/main/internal/cmd/root.go

## 謝辞

* https://github.com/rany2/edge-tts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---