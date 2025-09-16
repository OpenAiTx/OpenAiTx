# **<img src="https://raw.githubusercontent.com/FozerG/WinYandexMusicRPC/main/./assets/YMRPC_ico.ico" alt="[DISCORD RPC]" width="30"/> &nbsp;WinSdk + Yandex Music Discord Rich Presence**
[![TotalDownloads](https://img.shields.io/github/downloads/FozerG/WinYandexMusicRPC/total)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![LastRelease](https://img.shields.io/github/v/release/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download") [![CodeOpen](https://img.shields.io/github/languages/top/FozerG/WinYandexMusicRPC)](https://github.com/FozerG/WinYandexMusicRPC/blob/main/main.py "Show code") [![OS - Windows](https://img.shields.io/badge/OS-Windows-blue?logo=windows&logoColor=white)](https://github.com/FozerG/WinYandexMusicRPC/releases "Download")

>A pesar de la decisión irracional de bloquear Discord en Rusia, continuaré manteniendo el script en funcionamiento, en la medida de lo posible 🕊️

>[Usaremos lo que nos gusta.](https://github.com/Flowseal/zapret-discord-youtube)

**Discord RPC para mostrar la música que estás escuchando actualmente en tu computadora. La descarga de las pistas y sus carátulas se realiza desde Yandex Music.**

<img src="https://github.com/user-attachments/assets/99d15c70-632f-41ec-a6cd-49de8a7d2a8f" alt="discord" width="340">

Existen RPC similares que muestran la pista actual usando la API de Yandex Music. Sin embargo, no pueden mostrar información sobre lo que está sonando en la radio (por ejemplo, `Моя Волна`).

Por eso creé un script que usa `Windows.Media.Control` para obtener información sobre la pista actual, realiza una búsqueda en Yandex Music y muestra la pista en Discord.

Ventajas en comparación con otros scripts:    
No se necesita token de Yandex Music ✅  
Muestra pistas de playlists y radio ✅  
No está limitado al uso de Yandex Music, puedes escuchar música incluso desde VKontakte ✅  
Funciona tanto con navegadores como con aplicaciones ✅   
Muestra estado de pausa ✅  
Muestra cuánto queda para que termine la pista ✅  
Estado "Escuchando" en lugar de "Jugando a un juego" ✅

## Requisitos
El funcionamiento ha sido probado solo en Windows 11 y Windows 10, no funcionará en otras versiones ni plataformas. **No se garantiza el funcionamiento en versiones Lite o Custom reducidas de Windows.**

Si no vas a usar el archivo exe entonces:  
1. Python <3.14, >=3.10

## ¿Cómo descargar y usar el exe?
1. Descarga la [última versión disponible](https://github.com/FozerG/WinYandexMusicRPC/releases)
  
2. Abre WinYandexMusicRPC

3. El script se ocultará automáticamente en la bandeja del sistema tras 3 segundos. Abre la consola desde la bandeja para asegurarte de que está funcionando.

## ¿Cómo usar main.py?

1. Abre la terminal y navega a la carpeta donde se encuentra el archivo `requirements.txt`.
2. Escriba `pip install -r requirements.txt` para instalar las dependencias.  
3. En la terminal escriba `python main.py`

>Para compilar el script usando [Pyinstaller](https://pypi.org/project/pyinstaller/), ejecute este comando:  
`pyinstaller --noconfirm main.spec`

------------  
En caso de que escuche música no solo de Yandex Music, recomiendo cambiar la línea `strong_find = True` por `strong_find = False`, o usar la bandeja del sistema. Así se mostrará un mejor resultado de búsqueda, aunque no siempre exacto.

## Errores  
Los errores siempre existen, pero primero hay que encontrarlos 🫡  
Si encuentra un error, no dude en reportarlo en [Issues](https://github.com/FozerG/WinYandexMusicRPC/issues)

------------  
Por favor, muestre su interés en este proyecto para que pueda actualizarlo según sea posible.

>El código no es perfecto, ya que Python no es mi lenguaje principal y el script fue escrito para uso personal. Sin embargo, puede servir como base para sus propios scripts.

>Se utiliza [Yandex Music API](https://github.com/MarshalX/yandex-music-api)  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---