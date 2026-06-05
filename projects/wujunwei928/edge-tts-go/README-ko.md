# edge-tts-go

* [中文](https://github.com/wujunwei928/edge-tts-go/blob/main/README.md)
* [English](https://github.com/wujunwei928/edge-tts-go/blob/main/README_en-US.md)

`edge-tts-go` 는 golang 모듈로, golang 코드 내에서 또는 제공된 `edge-tts-go` 명령어를 사용하여 Microsoft Edge의 온라인 텍스트 음성 변환 서비스를 사용할 수 있습니다.

## 설치

### go install
    $ go install github.com/wujunwei928/edge-tts-go

### 미리 컴파일된 버전 다운로드
    https://github.com/wujunwei928/edge-tts-go/releases

## 사용법

### 기본 사용법

`edge-tts-go` 명령어를 사용하고 싶다면, 다음 명령어로 실행하면 됩니다:

    $ edge-tts-go --text "Hello, world" --write-media hello.mp3

### 음성 변경하기

텍스트 변환 시 사용할 음성을 변경하고 싶다면,

`--list-voices` 옵션을 사용하여 사용 가능한 음성을 확인해야 합니다:

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

`--voice` 옵션을 사용하여 음성을 지정하여 변환

    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" --write-media hello_in_chinese.mp3

    컴퓨터에 ffplay가 설치되어 있으면 다음 명령어로 오디오 파일을 직접 재생할 수 있습니다:
    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" | ffplay -i -

### 속도, 볼륨 및 음조 변경

    $ edge-tts-go --rate=-50% --text "Hello, world" --write-media hello_with_rate_halved.mp3
    $ edge-tts-go --volume=-50% --text "Hello, world" --write-media hello_with_volume_halved.mp3
    $ edge-tts-go --pitch=-50Hz --text "Hello, world" --write-media hello_with_pitch_halved.mp3

## go 모듈

go 코드 내에서 직접 `edge-tts-go` 모듈을 사용할 수 있으며, 호출 방법은 다음 파일에서 확인할 수 있습니다:

* https://github.com/wujunwei928/edge-tts-go/blob/main/internal/cmd/root.go

## 감사의 글

* https://github.com/rany2/edge-tts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---