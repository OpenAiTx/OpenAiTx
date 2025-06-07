**Este repositório do GitHub (<https://github.com/Genymobile/scrcpy>) é a única fonte oficial do projeto. Não baixe versões de sites aleatórios, mesmo que o nome deles contenha `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_pronunciado "**scr**een **c**o**py**"_

Este aplicativo espelha dispositivos Android (vídeo e áudio) conectados via USB ou
[TCP/IP](doc/connection.md#tcpip-wireless) e permite o controle usando o teclado e o mouse do computador. Não requer acesso _root_ nem um aplicativo instalado no dispositivo. Funciona em _Linux_, _Windows_ e _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Foca em:

 - **leveza**: nativo, exibe apenas a tela do dispositivo
 - **desempenho**: 30~120fps, dependendo do dispositivo
 - **qualidade**: 1920×1080 ou superior
 - **baixa latência**: [35~70ms][lowlatency]
 - **baixo tempo de inicialização**: ~1 segundo para exibir a primeira imagem
 - **não intrusivo**: nada é instalado no dispositivo Android
 - **benefícios ao usuário**: sem conta, sem anúncios, sem necessidade de internet
 - **liberdade**: software livre e de código aberto

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Suas funcionalidades incluem:
 - [encaminhamento de áudio](doc/audio.md) (Android 11+)
 - [gravação](doc/recording.md)
 - [display virtual](doc/virtual_display.md)
 - espelhamento com [a tela do dispositivo Android desligada](doc/device.md#turn-screen-off)
 - [copiar e colar](doc/control.md#copy-paste) em ambas as direções
 - [qualidade configurável](doc/video.md)
 - [espelhamento da câmera](doc/camera.md) (Android 12+)
 - [espelhamento como webcam (V4L2)](doc/v4l2.md) (apenas Linux)
 - simulação física de [teclado][hid-keyboard] e [mouse][hid-mouse] (HID)
 - suporte a [gamepad](doc/gamepad.md)
 - [modo OTG](doc/otg.md)
 - e muito mais…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Pré-requisitos

O dispositivo Android requer pelo menos API 21 (Android 5.0).

[Encaminhamento de áudio](doc/audio.md) é suportado para API >= 30 (Android 11+).

Certifique-se de ter [ativado a depuração USB][enable-adb] no(s) seu(s) dispositivo(s).

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Em alguns dispositivos (especialmente Xiaomi), você pode receber o seguinte erro:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

Nesse caso, é necessário habilitar [uma opção adicional][control] `Depuração USB
(Configurações de segurança)` (este é um item diferente de `Depuração USB`) para controlar
usando teclado e mouse. Reiniciar o dispositivo é necessário após definir essa opção.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Note que a depuração USB não é necessária para executar o scrcpy em [modo OTG](doc/otg.md).


## Baixe o aplicativo

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (leia [como executar](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Dicas essenciais

 - [Reduzir a resolução](doc/video.md#size) pode melhorar muito o desempenho
   (`scrcpy -m1024`)
 - [_Clique direito_](doc/mouse.md#mouse-bindings) aciona `BACK`
 - [_Clique do meio_](doc/mouse.md#mouse-bindings) aciona `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> alterna [tela cheia](doc/window.md#fullscreen)
 - Existem muitos outros [atalhos](doc/shortcuts.md)


## Exemplos de uso

Há muitas opções, [documentadas](#user-documentation) em páginas separadas.
Aqui estão apenas alguns exemplos comuns.

 - Capture a tela em H.265 (melhor qualidade), limite o tamanho para 1920, limite
   a taxa de quadros para 60fps, desative o áudio e controle o dispositivo simulando
   um teclado físico:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # versão curta
    ```

 - Inicie o VLC em um novo display virtual (separado do display do dispositivo):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Grave a câmera do dispositivo em H.265 a 1920x1080 (e microfone) para um arquivo MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Capture a câmera frontal do dispositivo e exponha-a como uma webcam no computador (em
   Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Controle o dispositivo sem espelhamento simulando um teclado e mouse físicos (não requer depuração USB):

    ```bash
    scrcpy --otg
    ```

 - Controle o dispositivo usando gamepads conectados ao computador:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # versão curta
    ```

## Documentação do usuário

O aplicativo oferece muitos recursos e opções de configuração. Eles estão
documentados nas seguintes páginas:

 - [Conexão](doc/connection.md)
 - [Vídeo](doc/video.md)
 - [Áudio](doc/audio.md)
 - [Controle](doc/control.md)
 - [Teclado](doc/keyboard.md)
 - [Mouse](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Dispositivo](doc/device.md)
 - [Janela](doc/window.md)
 - [Gravação](doc/recording.md)
 - [Display virtual](doc/virtual_display.md)
 - [Túneis](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Câmera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Atalhos](doc/shortcuts.md)


## Recursos

 - [FAQ](FAQ.md)
 - [Traduções][wiki] (não necessariamente atualizadas)
 - [Instruções de compilação](doc/build.md)
 - [Desenvolvedores](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artigos

- [Apresentando o scrcpy][article-intro]
- [Scrcpy agora funciona sem fio][article-tcpip]
- [Scrcpy 2.0, com áudio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Contato

Você pode abrir uma [issue] para relatar bugs, sugerir recursos ou enviar dúvidas em geral.

Para relatos de bugs, por favor, leia primeiro o [FAQ](FAQ.md), você pode encontrar uma solução para o seu problema imediatamente.

[issue]: https://github.com/Genymobile/scrcpy/issues

Você também pode usar:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Doação

Eu sou [@rom1v](https://github.com/rom1v), autor e mantenedor do _scrcpy_.

Se você aprecia este aplicativo, pode [apoiar meu trabalho open source][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Licença

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Licenciado sob a Licença Apache, Versão 2.0 (a "Licença");
    você não pode usar este arquivo exceto em conformidade com a Licença.
    Você pode obter uma cópia da Licença em

        http://www.apache.org/licenses/LICENSE-2.0

    A menos que exigido pela legislação aplicável ou acordado por escrito, o software
    distribuído sob a Licença é distribuído "COMO ESTÁ",
    SEM GARANTIAS OU CONDIÇÕES DE QUALQUER TIPO, expressas ou implícitas.
    Veja a Licença para o idioma específico que rege as permissões e limitações da Licença.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---