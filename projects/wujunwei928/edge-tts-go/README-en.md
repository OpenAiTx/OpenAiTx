# edge-tts-go

* [中文](https://github.com/wujunwei928/edge-tts-go/blob/main/README.md)
* [English](https://github.com/wujunwei928/edge-tts-go/blob/main/README_en-US.md)

`edge-tts-go` is a golang module that allows you to use Microsoft's Edge online text-to-speech service from golang code or by using the provided `edge-tts-go` command.

## Installation

### go install
    $ go install github.com/wujunwei928/edge-tts-go

### Download precompiled versions
    https://github.com/wujunwei928/edge-tts-go/releases

## Usage

### Basic usage

If you want to use the `edge-tts-go` command, just run it with the following command:

    $ edge-tts-go --text "Hello, world" --write-media hello.mp3

### Changing the voice

If you want to change the voice used when converting text.

You need to check available voices using the `--list-voices` option:

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
    Locale: zh-CN
    ContentCategories: Cartoon,Novel
    VoicePersonalities: Lively

    ...

Use the `--voice` option to specify the voice for conversion

    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" --write-media hello_in_chinese.mp3

    If ffplay is installed on your computer, you can use the following command to play the audio file directly:
    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" | ffplay -i -

### Change rate, volume, and pitch

    $ edge-tts-go --rate=-50% --text "Hello, world" --write-media hello_with_rate_halved.mp3
    $ edge-tts-go --volume=-50% --text "Hello, world" --write-media hello_with_volume_halved.mp3
    $ edge-tts-go --pitch=-50Hz --text "Hello, world" --write-media hello_with_pitch_halved.mp3

## Go module

You can directly use the `edge-tts-go` module in Go code; see the calling method in the following file:

* https://github.com/wujunwei928/edge-tts-go/blob/main/internal/cmd/root.go

## Acknowledgements

* https://github.com/rany2/edge-tts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---