# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Site：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Idiomas: [简体中文](./README.zh.md) | English

## Resumo

----

A ideia desta extensão veio de [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), todo o código foi reescrito. Compatível com todos os pacotes de voz, e adiciona alguns novos recursos.

## Agradecimentos Especiais

---

1. A extensão inclui o pacote de voz chinês de [@justkowalski](https://github.com/JustKowalski). Você pode [obter mais pacotes de voz no github](https://github.com/topics/rainbow-fart).
2. A extensão inclui o cmdmp3win.exe, de [@James K. Lawless](http://jiml.us).
3. O modelo waifu padrão é de [@二夏](https://erxia207.lofter.com), se você quiser criar uma waifu original só sua, entre em contato com ela.
4. A extensão inclui outro modelo waifu chamado keysoban, open source por [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Obtenha Mais Modelos de Waifu](https://github.com/ezshine/live2d-model-collections)

## Plataforma Suportada

---

~~~~
Suporta apenas MacOS e Windows10
~~~~

## Perguntas e Respostas

---

#### _Waifu não aparece?_
> R: Você precisa [baixar](https://github.com/ezshine/live2d-model-collections) o container waifu. Após extrair tudo do arquivo zip, execute liv2dplayer.exe, chame a lista de comandos no vscode e tente trocar o modelo waifu.

## Manual, Comandos

---

🌈 Mostrar Comandos do Rainbow Fart Waifu

- "Trocar Pacotes de Voz"
- "Trocar Modelos Waifu"
- "Abrir Diretório de Recursos"

> Se você baixar um pacote de voz ou pacote de modelo, use este comando para abrir o diretório de recursos e mova esses pacotes para o caminho indicado.

- "Baixar Container Waifu e Mais Recursos"

## Funcionalidades

---

1. WebUI removida, o áudio é reproduzido usando 'afplay' no MacOS e 'cmdmp3win' no Windows10.
2. Interaja com o WaifuContainer, coloque uma esposa virtual na sua área de trabalho para acompanhar sua programação.

## Aviso Sobre o Pacote de Voz

---

~~~~
Algumas observações para personalizar pacotes de voz ou usar pacotes de voz baixados da internet
~~~~

1. Use 'contributes.json' e não 'manifest.json'.
2. Adicione textos em 'contributes.json' para combinar com o conteúdo de voz.

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
            "Uau, sua função de callback está incrível!",
            "Que tal usar meu nome para nomear esta função?",
            "Nem a função mais poderosa pode expressar o quanto gosto de você!"
        ]
    }
]
~~~~

## Apoie-me

---

Se esta extensão deixou sua programação mais feliz, posso ganhar uma coca-cola?

![](https://raw.githubusercontent.com/ezshine/vscode-rainbow-fart-waifu/master/resources/donate.jpg)

**Aproveite!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---