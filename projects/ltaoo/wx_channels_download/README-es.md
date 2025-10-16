# Descargador de Video de WeChat

Pequeño tamaño, fácil de usar, compatible con sistemas macOS y Windows.

## Actualización 250913

1. Se añadió botón de descarga en la página principal de Video de WeChat
<br/>
2. Se agregó el comando `uninstall` para desinstalar el certificado raíz instalado por esta herramienta
<br/>
3. Se corrigió el problema de página en blanco al abrir videos largos

<details><summary>Haz clic para ver más actualizaciones</summary>

## Actualización 250808

1. Se corrigió el problema de ausencia del botón de descarga en la nueva versión de WeChat


## Actualización 250621

1. Optimización en la visualización del "progreso" durante la descarga
<br/>
2. Se añadió el comando `download` para descargar y descifrar videos desde la terminal. Para videos mayores a 1G se recomienda usar este método
<br/>

```bash
# 使用方式
./wx_video_download_xx download --url "视频地址" --key 解密key --filename "文件名"
# 视频地址、文件名参数需要双引号包裹。解密key不用双引号
# 将会下载视频到 `Downloads` 目录，然后解密
```
3、En el menú "Más" del canal de video, se agregó el botón "Imprimir comando de descarga"
<br/>
4, Se corrigió el problema de que algunos mensajes de error al instalar certificados no estaban en chino


## Actualización 250514

1, Se corrigió el problema de no poder descargar imágenes y videos

## Actualización 25042501

1, Se corrigió el problema de que los videos descargados no se podían reproducir

## Actualización 250425

1, Se corrigió el problema de no poder descargar videos

## Actualización 250424

1, Se corrigió el problema de inconsistencia en el estilo del botón de descarga
<br/>
2, Se corrigió el problema de que al hacer clic en el botón Más no se mostraba el menú Más
<br/>
3, Se agregó una alerta para que Windows pregunte si se desea ejecutar como administrador al fallar el inicio

## Actualización 250215

1, Muestra el progreso de descarga en la consola, y cuando no se puede obtener el progreso muestra los bytes descargados
<br/>
2, Se agregó la descarga de la imagen de portada en el menú "Más"
<br/>
3, Detección automática del dispositivo de red actual y proxy
<br/>
4, Soporte para parámetros de línea de comandos para especificar el dispositivo de red a usar en proxy y el puerto usado por el programa


```bash
./wx_video_download_xxx --dev=Wi-Fi --port=1080
```
> En general, no es necesario especificar manualmente el dispositivo y el número de puerto, simplemente ejecutar ./wx_video_download_xxx

## Actualización 241216

1. Soporte para descargar repeticiones de transmisiones en vivo
<br/>
2. Soporte para sistemas macOS
<br/>
Probado y funcionando en WeChat Versión 3.8.9 (28564)

Instrucciones de uso en macOS


```bash
chmod +x ./wx_video_download_darwin_xxx
sudo ./wx_video_download_darwin_xxx
```
En este momento se mostrará un aviso indicando que el archivo no se puede abrir, es necesario ir a la configuración del sistema para permitirlo, y luego ejecutar nuevamente `sudo ./wx_video_download_darwin_xxx`.  
<br/>

Durante el proceso de instalación del certificado se solicitarán permisos, solo acepte. Posteriormente, para abrir no será necesario usar `sudo`, solo hay que hacer doble clic para ejecutar.  
<br/>

Al cerrar la terminal de `macOS` por favor utilice la combinación `Command + c`, de lo contrario puede que no se cancele el proxy del sistema, lo que causaría problemas de acceso a la red.  
<br/>

> Cuando haya problemas de acceso a la red, por favor revise el proxy del sistema y cancele manualmente.  

<br/>

## Actualización 241106

1. Se corrigió el problema donde los videos que no eran la primera vez que se abrían, descargados no podían reproducirse.  

Ahora al hacer clic en los videos de "Más recomendaciones" en la página, los videos descargados se pueden abrir y reproducir normalmente.  
<br>
Cuando aparezca el mensaje "Error de descifrado, deteniendo descarga", cierre todas las páginas y ventanas de video. Ábralas de nuevo y podrá descargar.  

## Actualización 241104

1. Soporte para descargar videos en diferentes calidades.  
<br>
2. Se corrigió el problema que impedía arrastrar la barra de progreso en los videos descargados.  
<br>
3. Se corrigió el problema de descargar videos largos antes de que se cargara el progreso, lo que causaba que el video no se reprodujera o estuviera incompleto.  
<br>
4. Se corrigió el problema donde algunos videos se confundían con imágenes y no podían descargarse.  
<br>
5. Se corrigió el problema de carga infinita en las salas de transmisión en vivo.  

![Botón de descarga 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)  

Para más detalles sobre los videos de diferentes calidades, consulte las instrucciones de uso más abajo.  

## Actualización 241102  


Añadir el botón "Descargar video" en el menú desplegable "Más", compatible con diferentes diseños de página de detalles que no muestran el botón de descarga.

![Botón de descarga2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

## Actualización 241101

Ahora no es necesario descargar ni instalar manualmente el certificado.
<br>
Se corrigió el problema de que al descargar indicaba que no se encontraba `lib/jszip.min.js`.

## Actualización 241031

Se volvió a encontrar el problema de que no se podía descargar desde la página, esta vez se cambió a descargar un paquete comprimido, con el video dentro del paquete.
Actualmente funciona, pero no se puede garantizar que siga funcionando en el futuro.

Se recomienda usar [WechatVideoSniffer2.0](https://github.com/kanadeblisst00/WechatVideoSniffer2.0) que es más estable.

## Actualización 241030

Cuando el contenido del canal de video son múltiples imágenes, también aparecerá el botón de descarga. Al hacer clic, se descargará un paquete comprimido que contiene todas las imágenes.

## Actualización 241022

Cuando un video es eliminado, no mostraba correctamente "Eliminado" sino que quedaba siempre en estado de carga.
El botón de descarga se modificó para tener el mismo estilo que los otros botones de acción.

## Actualización 241016

La versión anterior no pudo descargar de nuevo, al cambiar a descarga directa en la página volvió a funcionar, ¿será por la versión del cliente de WeChat? No lo sé bien.
Si la versión 241016 no funciona, pueden probar otras versiones.
Actualmente mi versión de cliente de WeChat es `Weixin 3.9.12.17`, y descarga normalmente.

## Actualización 241011

Parece que el canal de video cambió de nuevo, ya no se puede descargar directamente en la página. Se cambió a que al hacer clic en el botón de descarga se copie el enlace del video al portapapeles, y luego abrirlo en Google u otro navegador para descargar.
Además, probé muchos videos que se pueden descargar directamente, ya no están cifrados. Por lo tanto, si hay videos cifrados, la nueva versión puede que falle en la descarga.

> Descargar directamente en la página, en teoría sigue siendo posible, pero la implementación es mucho más complicada, se estudiará más adelante.

</details>
## Instrucciones de uso

Descargue el [archivo binario](https://github.com/ltaoo/wx_channels_download/releases), **ejecútelo como administrador**, la primera vez que se abra instalará automáticamente el certificado y luego iniciará el servicio.

Cuando el terminal muestre "Servicio iniciado correctamente" significa que ya puede usarse.

![Uso normal](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot8.png)

> Si el certificado está instalado, se omitirá el paso de instalación del certificado.

Abra la versión PC de WeChat, haga clic en el video que desea descargar, en la barra de botones debajo del video aparecerá un botón de descarga, como se muestra a continuación

![Botón de descarga de video](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot1.png)

> Si no aparece, revise en "Más" si está el botón "Descargar video".<br> > ![Botón de descarga 2](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot10.png)

Espere a que el video comience a reproducirse, luego pause el video y haga clic en el botón de descarga para descargar el video. Después de una descarga exitosa, se mostrará el archivo descargado arriba, el nombre del archivo descargado tendrá al final una indicación de la calidad del video.

![Descarga de video exitosa](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot2.png)

Por defecto se descargará el video de la primera calidad en el menú desplegable. Al desplegar "Más", puede descargar videos de otras calidades, incluyendo el video original.

![Descargar videos de diferentes calidades](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot13.png)
<br>

Las opciones mostradas para diferentes videos varían, no se encontró una explicación específica para xWT111, como qué resolución o tamaño tiene, etc.
<br>
Tras pruebas, si el video original tiene 104MB, el de mayor tamaño aquí es xWT111 con 17MB, y el más pequeño es xWT98 con 7MB.

![Estadísticas de tamaños de videos de diferentes calidades](https://raw.githubusercontent.com/ltaoo/wx_channels_download/main/assets/screenshot14.png)

Solo para referencia.

## Preguntas frecuentes

1. El servicio está iniciado, pero al abrir el detalle del video se queda cargando y no hay información de logs en el terminal.
<br>
Intente presionar `Ctrl+C` en el terminal, solo una vez.


2, fallo en la descifrado, detener la descarga
<br>
Cerrar todas las páginas y ventanas de video. Vuelva a abrir y podrá descargar.

## Instrucciones de desarrollo

Primero inicie el terminal como administrador, luego `go run main.go`.

## Empaquetado

# windows

```bash
go build -o wx_video_download.exe main.go
```

Después de empaquetar, se puede usar `upx` para comprimir, reduciendo el tamaño de 17MB a 5MB.

# macOS

```bash
CGO_ENABLED=1 GOOS=darwin SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

```bash
CGO_ENABLED=1 GOOS=darwin GOARCH=amd64 SDKROOT=$(xcrun --sdk macosx --show-sdk-path) go build -trimpath -ldflags="-s -w" -o wx_video_download
```

## 其他

此程序大部分参考自以下项目代码
<br>
https://github.com/kanadeblisst00/WechatVideoSniffer2.0

此程序的核心实现依赖以下库
<br>
https://github.com/qtgolang/SunnyNet

## 我的赞赏码

如果我的项目对你有所帮助，可以请我喝杯咖啡 ☕️

[![Sponsors](https://sponsorkit-iota.vercel.app/api/sponsors)](https://sponsorkit-iota.vercel.app/api/sponsors)

```text
                 本项目为开源项目
            仅用于技术交流学习和研究的目的
          请遵守法律法规,请勿用作任何非法用途
               否则造成一切后果自负
           若您下载并使用即视为您知晓并同意
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---