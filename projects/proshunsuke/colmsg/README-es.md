> [!WARNING]
> Actualmente hay un problema que impide obtener el `refresh_token` en iOS. Este no es un problema de `colmsg`, sino un efecto debido a una actualización en la aplicación de mensajes. Por el momento no existe una solución completa para este problema. En el caso de Android, por favor continúe consultando [aquí](https://github.com/proshunsuke/colmsg/blob/main/doc/how_to_get_refresh_token.md#android%E3%82%A2%E3%83%97%E3%83%AA%E3%81%AE%E5%A0%B4%E5%90%88).

<div align="center">
  <h1><strong>colmsg</strong></h1>
  <img src="https://user-images.githubusercontent.com/3148511/158018437-09822a33-8767-4e03-ba90-e0f69594c493.jpeg" width="32px" alt="Logo de Sakura46 Mensajes"><img src="https://user-images.githubusercontent.com/3148511/158018441-dd7cb9eb-bf31-4938-830d-1ef293a2afba.jpg" width="32px" alt="Logo de Hinatazaka46 Mensajes"><img src="https://user-images.githubusercontent.com/3148511/158018442-ae54e926-760d-4b47-b0a0-7255485e1f28.jpg" width="32px" alt="Logo de Nogizaka46 Mensajes">

  Guarda los mensajes de las aplicaciones “Sakura46 Mensajes”, “Hinatazaka46 Mensajes”, “Nogizaka46 Mensajes”, “Asuka Saito Mensajes”, “Mai Shiraishi Mensajes” y “yodel” en tu PC.

  ![demo](https://user-images.githubusercontent.com/3148511/158026220-90735546-2401-40ca-a9e6-89d2176ad3b4.gif)
</div>

## Resumen

Para la instalación de `colmsg` consulta [aquí](#インストール).

**Primero** obtén el refresh_token. El método para obtenerlo está en [aquí](https://raw.githubusercontent.com/proshunsuke/colmsg/main/doc/how_to_get_refresh_token.md).

Una vez obtenido, ejecuta lo siguiente.  
En `<s_refresh_token>`, `<h_refresh_token>`, `<n_refresh_token>`, `<a_refresh_token>`, `<m_refresh_token>`, `<y_refresh_token>`, coloca el refresh_token obtenido para “Sakura46 Mensajes”, “Hinatazaka46 Mensajes”, “Nogizaka46 Mensajes”, “Asuka Saito Mensajes”, “Mai Shiraishi Mensajes” y “yodel”, respectivamente.  
※ Solo es necesario especificar las aplicaciones a las que estés suscrito.

Se guardarán todos los mensajes de todos los miembros suscritos, para todo el período.  

```shell script
colmsg --s_refresh_token <s_refresh_token> --h_refresh_token <h_refresh_token> --n_refresh_token <n_refresh_token> --a_refresh_token <a_refresh_token> --m_refresh_token <m_refresh_token> --y_refresh_token <y_refresh_token>
```
En el caso de Windows, reemplace el nombre del archivo ejecutable por `colmsg.exe`.

## Características

* ✅ No es necesario rootear el dispositivo
* ✅ Compatible con aplicaciones Android e iOS
* ✅ Se puede ejecutar en Windows, macOS y Linux
* ✅ Se pueden elegir varios métodos de almacenamiento
* ✅ Compatible con las siguientes versiones de aplicaciones
  * "Sakurazaka46 Message": versión 1.12.01.169
  * "Hinatazaka46 Message": versión 2.13.01.169
  * "Nogizaka46 Message": versión 1.8.01.169
  * "Asuka Saito Message": versión 1.1.01.169
  * "Mai Shiraishi Message": versión 3.4.3.426
  * "yodel": versión 4.1.1.455

## Cómo usar

Se explicó el uso básico en el resumen.  
Sin embargo, como el refresh_token es información sensible, no es recomendable introducirlo directamente en la terminal.  
Por ello, se recomienda configurar las opciones predeterminadas en un archivo config.  
Para más información sobre el archivo config, consulte [aquí](#configファイル).  
A partir de ahora, se asume que el refresh_token está configurado en el archivo config.

`colmsg` tiene varias opciones y permite elegir diversos métodos de almacenamiento.

Si desea guardar mensajes de un miembro específico


```shell script
colmsg -n 菅井友香 -n 佐々木久美
```

Si desea guardar mensajes de un grupo específico

```shell script
colmsg -g sakurazaka
```

Si desea guardar un tipo específico de mensaje

```shell script
colmsg -k picture -k video
```

Si desea guardar mensajes posteriores a una fecha y hora específicas

```shell script
colmsg -F '2020/01/01 00:00:00'
```
Las opciones se pueden usar en combinación. Para una explicación más detallada, ejecute lo siguiente para verificar.


```shell script
colmsg --help
```

## Especificaciones detalladas

* Si ya hay algunos mensajes guardados, al ejecutar el comando se obtendrán y guardarán los mensajes posteriores al último mensaje guardado.  
* Los mensajes guardados se almacenan en la siguiente estructura de directorios
  * ```shell script
    colmsg/
    ├── Hinatazaka46 Primera generación
    │   └── Sasaki Kumi
    │       └── 1_0_20191231235959.txt
    ├── Nogizaka46
    │   └── Akimoto Manatsu
    │       └── 2_1_20200101000000.jpg
    └── Sakurazaka46 Primera generación
        └── Sugai Yūka
            ├── 3_2_20200101000001.mp4
            └── 4_3_20200101000002.mp4
    ```
* ファイル名の形式は `<シーケンス番号>_<種類>_<日付>.<拡張子>` となっています
  * シーケンス番号はメッセージの時系列を表す番号になっています。若い数字程昔のメッセージです。ファイルブラウザで辞書順に並べると保存したメッセージが時系列通りに並びます
  * 種類の数字は以下のように対応しています
    * 0: テキストメッセージ
    * 1: 画像
    * 2: 動画
    * 3: ボイス
    * 4: リンク
* 各環境毎のデフォルトの保存先は以下を実行することで確認することが出来ます
  * ```shell script
    colmsg --download-dir
    ```
* Los mensajes ya guardados no se sobrescribirán

## archivo de configuración

`colmsg` permite especificar opciones previamente en un archivo de configuración.  
La ruta predeterminada se puede verificar ejecutando lo siguiente.

```shell script
colmsg --config-dir
```
Además, también puede especificar la ubicación del archivo de configuración en la variable de entorno `COLMSG_CONFIG_PATH`.

```shell script
export COLMSG_CONFIG_PATH="/path/to/colmsg.conf"
```

### Formato

Este archivo de configuración es una lista simple de argumentos de línea de comandos. Usando `colmsg --help` puede ver las opciones disponibles y sus valores. Además, puede agregar comentarios usando `#`.

Ejemplo de archivo de configuración:

```bash
# s_refresh_tokenを指定
--s_refresh_token s_refresh_token

# h_refresh_tokenを指定
--h_refresh_token h_refresh_token

# n_refresh_tokenを指定
--n_refresh_token n_refresh_token

# a_refresh_tokenを指定
--a_refresh_token a_refresh_token

# m_refresh_tokenを指定
--m_refresh_token m_refresh_token

# y_refresh_tokenを指定
--y_refresh_token y_refresh_token

# メディアファイルだけ保存するように設定
-k picture -k video -k voice
```

## Instalación

### Windows

Los archivos ejecutables compilados para Windows están comprimidos en zip y se encuentran en la [página de lanzamientos](https://github.com/proshunsuke/colmsg/releases).  
Descárguelos y descomprímalos con un software como [7-Zip](https://sevenzip.osdn.jp/).  
Después de descomprimir, obtendrá el archivo ejecutable `colmsg.exe`.  
Ejecute el archivo en [PowerShell](https://docs.microsoft.com/ja-jp/powershell/) u otro entorno similar.

### macOS

Se puede instalar mediante Homebrew.

```shell script
brew tap proshunsuke/colmsg
brew install colmsg
```

### Arch Linux

Se puede instalar desde [AUR](https://aur.archlinux.org/packages/colmsg/).

```bash
yay -S colmsg
```

### Binario

Se han colocado archivos ejecutables compilados para diferentes arquitecturas en la [página de lanzamientos](https://github.com/proshunsuke/colmsg/releases).

## Desarrollo

`colmsg` llama a una API externa. Durante el desarrollo, es posible levantar un servidor mock utilizando OpenApi.

```shell
make server/kh
make server/n46
```

Puede realizar solicitudes al servidor simulado especificando las variables de entorno `S_BASE_URL`, `H_BASE_URL` y `N_BASE_URL`.

```shell script
S_BASE_URL=http://localhost:8003 H_BASE_URL=http://localhost:8003 N_BASE_URL=http://localhost:8006 cargo run -- -d ~/Downloads/temp/ --help
```
## TODO

* [ ] Pruebas automáticas mediante CI  
* [ ] Preparar ejemplos  
* [ ] Paralelización del proceso de almacenamiento de mensajes  
* [ ] Convertir el cliente API en crate  

## Licencia

`colmsg` se distribuye bajo los términos de la licencia MIT.

Para más detalles sobre la licencia, consulte el archivo [LICENSE](https://raw.githubusercontent.com/proshunsuke/colmsg/main/LICENSE.txt).

## Avisos

Por favor, tenga en cuenta que el Artículo 8 (Prohibiciones) de los términos de uso de la aplicación incluye los siguientes puntos.

* (16) Acceder o intentar acceder al servicio por medios distintos a los métodos de acceso especificados por la empresa  
* (17) Acceder o intentar acceder al servicio mediante medios automatizados (incluidos rastreadores y tecnologías similares)  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---