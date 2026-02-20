# Warpinator para Windows (no oficial)

Esta es una reimplementación no oficial de la herramienta de intercambio de archivos de Linux Mint [Warpinator](https://github.com/linuxmint/warpinator) para Windows 7 y versiones posteriores.

Transfiere archivos entre dispositivos Linux, Windows y Android

## ⚠️ Advertencia: Sitio web falso/malicioso

`http://warpinator.com` es un sitio web falso, ¡potencialmente malicioso!

¡NO** descargues ni ejecutes ningún software de allí!

No sabemos quién lo mantiene. Ver [aviso del equipo de Linux Mint](https://github.com/linuxmint/warpinator?tab=readme-ov-file#%EF%B8%8F-warning-fakemalicious-website).

## Descargar
Ahora disponible en la página de [Releases](https://github.com/slowscript/warpinator-windows/releases)

Alternativamente puede instalarse vía winget:  
`winget install slowscript.Warpinator`

## Compilación
Requiere .NET SDK 4.7.2

Compilar con Visual Studio

### Captura de pantalla
![screenshot](https://raw.githubusercontent.com/slowscript/warpinator-windows/master/screenshot.png)

## Traducción
Necesitarás una versión reciente de Visual Studio  
1) Crea un nuevo archivo de recursos en la carpeta Resources llamado Strings.xx.resx donde xx es el código del idioma al que estás traduciendo  
2) Copia toda la tabla de Strings.resx y traduce los valores. Los comentarios son solo para contexto  
3) Abre Controls\TransferPanel, Form1, SettingsForm y TransferFrom en el diseñador y repite los pasos 4-6 en cada uno  
4) Selecciona el elemento de nivel superior (ventana completa) y en Propiedades cambia el idioma a tu idioma  
5) Selecciona los controles con texto (botones, etiquetas, menús) y traduce su propiedad "Text". No necesitas traducir los marcadores de posición obvios que se reemplazarán en tiempo de ejecución. Esto se puede verificar simplemente ejecutando la aplicación (flecha verde de reproducción en la barra de herramientas). Además, dos botones en TransferPanel están ocultos debajo de los otros dos.  
6) También puedes mover y cambiar el tamaño de los controles para ajustarlos a las nuevas cadenas y esto solo afectará el idioma seleccionado actualmente


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-20

---