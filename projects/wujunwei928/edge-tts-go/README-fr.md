# edge-tts-go

* [中文](https://github.com/wujunwei928/edge-tts-go/blob/main/README.md)
* [English](https://github.com/wujunwei928/edge-tts-go/blob/main/README_en-US.md)

`edge-tts-go` est un module golang qui vous permet d'utiliser le service de synthèse vocale en ligne de Microsoft Edge à partir de code golang ou via la commande `edge-tts-go` fournie.

## Installation

### go install
    $ go install github.com/wujunwei928/edge-tts-go

### Télécharger la version précompilée
    https://github.com/wujunwei928/edge-tts-go/releases

## Utilisation

### Utilisation de base

Si vous souhaitez utiliser la commande `edge-tts-go`, il suffit de l'exécuter avec la commande suivante :

    $ edge-tts-go --text "Hello, world" --write-media hello.mp3

### Changer la voix

Si vous souhaitez changer la voix utilisée pour la conversion du texte.

Vous devez utiliser l'option `--list-voices` pour vérifier les voix disponibles :

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

Utiliser l'option `--voice` pour spécifier la voix à utiliser

    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" --write-media hello_in_chinese.mp3

    Si ffplay est installé sur votre ordinateur, vous pouvez utiliser la commande suivante pour lire directement le fichier audio :
    $ edge-tts-go --voice zh-CN-XiaoxiaoNeural --text "纵使浮云蔽天日，我亦拔剑破长空" | ffplay -i -

### Modifier la vitesse, le volume et la hauteur

    $ edge-tts-go --rate=-50% --text "Hello, world" --write-media hello_with_rate_halved.mp3
    $ edge-tts-go --volume=-50% --text "Hello, world" --write-media hello_with_volume_halved.mp3
    $ edge-tts-go --pitch=-50Hz --text "Hello, world" --write-media hello_with_pitch_halved.mp3

## Module go

Vous pouvez utiliser directement le module `edge-tts-go` dans le code go, consultez le fichier ci-dessous pour voir comment l'appeler :

* https://github.com/wujunwei928/edge-tts-go/blob/main/internal/cmd/root.go

## Remerciements

* https://github.com/rany2/edge-tts


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-05

---