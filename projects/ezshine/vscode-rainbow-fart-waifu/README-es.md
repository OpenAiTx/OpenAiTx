# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

Sitio web：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

Idiomas: [简体中文](./README.zh.md) | English

## Resumen

----

La idea de esta extensión proviene de [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart), se reescribió todo el código. Compatible con todos los paquetes de voz y se añadieron algunas funciones nuevas.

## Agradecimientos Especiales

---

1. La extensión incluye el paquete de voz en chino de [@justkowalski](https://github.com/JustKowalski). Puedes [obtener más paquetes de voz en github](https://github.com/topics/rainbow-fart) 
2. La extensión incluye cmdmp3win.exe, de [@James K. Lawless](http://jiml.us)
3. El modelo waifu predeterminado es de [@二夏](https://erxia207.lofter.com), si deseas diseñar una waifu original solo para ti, contacta con ella.
4. La extensión incluye otro modelo waifu llamado keysoban, open source por [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632).

[Obtener más modelos de Waifu](https://github.com/ezshine/live2d-model-collections)

## Plataforma Soportada

---

~~~~
Solo compatible con MacOS y Windows10
~~~~

## Preguntas y Respuestas

---

#### _¿La Waifu no se muestra?_
> R: Necesitas [descargar](https://github.com/ezshine/live2d-model-collections) el contenedor waifu. Después de descomprimir todo el archivo zip, ejecuta liv2dplayer.exe, muestra la lista de comandos en vscode e intenta cambiar el modelo waifu.

## Manual, Comandos

---

🌈 Mostrar Comandos de Rainbow Fart Waifu

- "Cambiar Paquetes de Voz"
- "Cambiar Modelos de Waifu"
- "Abrir Directorio de Recursos"

> Si descargas un paquete de voz o un paquete de modelo, debes usar este comando para abrir el directorio de recursos y mover esos paquetes bajo la ruta

- "Descargar Contenedor de Waifu y Más Recursos"

## Características

---

1. Se eliminó la WebUI, se reproduce el archivo de audio usando 'afplay' en MacOS y 'cmdmp3win' en Windows10.
2. Interactúa con WaifuContainer, pon una esposa virtual en tu escritorio para acompañar tu programación.

## Aviso de Paquete de Voz

---

~~~~
algunas advertencias para personalizar paquetes de voz o usar paquetes de voz descargados de internet
~~~~

1. Usa 'contributes.json' en lugar de 'manifest.json'.
2. Añade textos en 'contributes.json' para hacer coincidir el contenido de voz.

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
            "¡Guau, tu función callback está genial!",
            "¿Qué tal si nombras esta función con mi nombre?",
            "¡Ninguna función, por increíble que sea, puede ejecutar mi amor por ti!"
        ]
    }
]
~~~~

## Apóyame

---

Si esta extensión hace tu programación más feliz, ¿me invitas a una coca?

![](./resources/donate.jpg)

**¡Disfruta!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---