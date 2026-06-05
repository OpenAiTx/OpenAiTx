# edge-tts-go

* [中文](https://github.com/wujunwei928/edge-tts-go/blob/main/README.md)
* [English](https://github.com/wujunwei928/edge-tts-go/blob/main/README_en-US.md)

`edge-tts-go` es un módulo de golang que le permite usar el servicio en línea de texto a voz de Microsoft Edge desde código golang o mediante el comando `edge-tts-go` proporcionado.

## Instalación

### go install
    $ go install github.com/wujunwei928/edge-tts-go

### Descargar versiones precompiladas
    https://github.com/wujunwei928/edge-tts-go/releases

## Uso

### Uso básico

Si desea usar el comando `edge-tts-go`, simplemente ejecútelo con el siguiente comando:

    $ edge-tts-go --text "Hello, world" --write-media hello.mp3

### Cambiar la voz

Si desea cambiar la voz usada para convertir el texto.

Necesita usar la opción `--list-voices` para verificar las voces disponibles:

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

Usar la opción `--voice` para especificar la voz en la conversión

    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" --write-media hello_in_chinese.mp3

    Si tienes ffplay instalado en tu computadora, puedes reproducir el archivo de audio directamente con el siguiente comando:
    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" | ffplay -i -

### Cambiar velocidad, volumen y tono

    $ edge-tts-go --rate=-50% --text "Hello, world" --write-media hello_with_rate_halved.mp3
    $ edge-tts-go --volume=-50% --text "Hello, world" --write-media hello_with_volume_halved.mp3
    $ edge-tts-go --pitch=-50Hz --text "Hello, world" --write-media hello_with_pitch_halved.mp3

## Módulo go

Puedes usar directamente el módulo `edge-tts-go` en código go, consulta el siguiente archivo para ver cómo llamarlo:

* https://github.com/wujunwei928/edge-tts-go/blob/main/internal/cmd/root.go

## Agradecimientos

* https://github.com/rany2/edge-tts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---