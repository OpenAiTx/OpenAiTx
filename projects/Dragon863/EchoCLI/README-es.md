> [!IMPORTANTE]
> Si estás buscando rootear tu echo, este proyecto ahora está obsoleto; por favor usa la solución documentada [aquí](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/) en su lugar. Muchas gracias a todos los que hicieron esto posible, ¡ha sido muy divertido trabajar en este proyecto! :)

# EchoCLI
Una solución de root tethered para tu echo dot de 2ª generación.
Para comenzar, ejecuta `main.py`
<br>

[<kbd> <br> ¿Cómo funciona esto? <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)

## Aviso
- Debido a que las actualizaciones de software se envían constantemente, no puedo garantizar que esto funcione para tu echo. Si encuentras algún problema, no dudes en contactarme, y si encuentras un error, las solicitudes de extracción son bienvenidas.
- Se recomienda **fuertemente** ejecutar esto en una máquina Linux, ya que no puedo probarlo en Windows y no hay garantía de que no existan errores específicos de Windows.

> **Advertencia**
> 
> **Esta es una solución de root TETHERED** Se _recomienda_ bloquear los servidores OTA de Amazon (https://d1s31zyz7dcc2d.cloudfront.net y https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net) para evitar que las actualizaciones corrompan o eliminen el root en tu dispositivo. No me hago responsable de ningún daño a tu dispositivo.

## Características
- Shell ADB con root vía USB o Wi-Fi
- Graba audio desde el dispositivo
- Usa tu Echo como indicador para Home Assistant sin internet
- Restaura tu dispositivo a la configuración de fábrica

## Instalación
- Este proyecto requiere python 3.
- Recomiendo usar Linux para ejecutar este programa. Por favor asegúrate de haber deshabilitado ModemManager si lo tienes instalado.
Instala los requisitos usando `pip`:
```sh
pip install -r requirements.txt
```
- También necesitarás fastboot y ADB, hay una buena guía sobre cómo instalar estos [aquí](https://wiki.lineageos.org/adb_fastboot_guide). Después de descargarlos, puedes configurar la ruta ejecutable en el archivo config.json.  
- Por favor, asegúrate de que el cable micro USB que uses para conectar tu echo dot sea un cable de datos y no una variante solo de energía.  

## Documentación  
Puedes encontrar cómo funciona esta herramienta en [mi sitio web](https://dragon863.github.io/blog/echoroot.html).  

Una vez que hayas rooteado el dispositivo, se generará un archivo llamado `preloader_no_hdr.bin`. Para arrancar el dispositivo, necesitarás instalar [mtkclient](https://github.com/bkerler/mtkclient), copiar el archivo en su directorio y ejecutar `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin`. Reemplaza `python` por `python3` según la versión de python que tengas instalada.  

## Indicador de Home Assistant  
Al usar la función de indicador de home assistant, recomendaría usar una raspberry pi zero w u otra SBC pequeña para ejecutar el servidor python flask y arrancar el dispositivo. Puedes usar crontab para que esto ocurra automáticamente al iniciar usando mtkclient.  

## ¿Has brickeado tu echo?  
Sigue la guía [aquí](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md) para usar mtkclient y desbrickear un echo rooteado o parcialmente rooteado.  

## Agradecimientos  

Este proyecto no habría sido posible sin:  
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - Por ayudarme inicialmente a rootear mi dispositivo, rediseñar el sistema de parcheo y mostrarme cómo usar fos_flags en combinación y en general orientarme en la dirección correcta al buscar recursos  
- [xyzz's Amonet](https://github.com/xyzz/amonet) - Este es el exploit que he adaptado para este dispositivo, incluyendo el exploit del bootrom  
- [chaosmaster](https://github.com/chaosmaster) - Escribió mucho código útil de amonet del cual usé varios fragmentos, incluyendo para arreglar mi GPT  

## Contáctame  
- Puedes enviarme un correo a dragon863.dev@gmail.com  
- Puedes iniciar una conversación en [XDA](https://forum.xda-developers.com/m/lemon86.12487447/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---