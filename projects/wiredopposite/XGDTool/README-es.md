# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDTool es una utilidad para discos de OG Xbox y Xbox 360, capaz de convertir discos hacia y desde cualquier formato popular. Está disponible como una aplicación GUI o CLI.

Este programa aún está en pruebas iniciales. Si experimentas algún problema, por favor repórtalo en la pestaña de Issues y ayuda a mejorar este programa.

## Características
- Soporta conversión entre los siguientes formatos:
    - ISO / XISO
    - Archivos extraídos (Xex / Xbe / HDD Ready)
    - GoD / Juegos bajo demanda
    - CCI
    - CSO
    - ZAR
- Conversión sin interrupciones, por ejemplo, puedes extraer directamente una imagen GoD, convertir un ISO a archivo ZAR, o un directorio extraído a archivo CCI, sin escribir archivos temporales. El único formato que requiere archivos temporales es ZAR cuando se proporciona como entrada.
- Limpieza de imagen ("Partial Scrub"), elimina relleno aleatorio y recorta el archivo de salida a la longitud más corta posible.
- Reautoría de imagen ("Full Scrub"), reescribe completamente la estructura del disco para obtener el archivo de salida más pequeño posible.
- Autoría de imagen, toma tus archivos extraídos y crea una nueva imagen con ellos.
- Compresión multihilo para formatos CCI y CSO.
- Procesamiento por lotes, una carpeta llena de diferentes formatos de juegos puede ser convertida por lotes a un solo formato.
- Encuentra automáticamente archivos divididos cuando solo se proporciona una parte como ruta de entrada, asumiendo que están nombrados en este formato: ```nombre.1.extensión``` ```nombre.2.extensión```.
- Opción para seleccionar tu aplicación/máquina objetivo (Xemu, Xenia, OG Xbox, Xbox 360) y dejar que XGDTool decida qué configuraciones usar.
- Generación adjunta de XBE para OG Xbox.
- Consulta en base de datos en línea para nombrado exacto de archivos (puede deshabilitarse).

## Uso CLI
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```
  
Las banderas de configuración y el directorio de salida son opcionales.

### Argumentos de formato de salida (mutuamente excluyentes)
- ```--extract```   Extrae todos los archivos a un directorio
- ```--xiso```      Crea una imagen Xiso
- ```--god```       Crea una imagen/estructura de directorio Games on Demand
- ```--cci```       Crea un archivo CCI (se divide automáticamente si es demasiado grande para Xbox)
- ```--cso```       Crea un archivo CSO (se divide automáticamente si es demasiado grande para Xbox)
- ```--zar```       Crea un archivo ZAR
- ```--xbe```       Genera un archivo attach XBE, no convierte el archivo de entrada
- ```--ogxbox```    Elige automáticamente formato y configuraciones para uso con OG Xbox
- ```--xbox360```   Elige automáticamente formato y configuraciones para uso con Xbox 360
- ```--xemu```      Elige automáticamente formato y configuraciones para uso con Xemu
- ```--xenia```     Elige automáticamente formato y configuraciones para uso con Xenia

Información:
- ```--list```      Lista el contenido del archivo de entrada
- ```--version```   Imprime información de la versión
- ```--help```      Imprime información de uso

### Banderas de configuración
Estos argumentos pueden apilarse, aunque no todos los formatos de salida los usarán, en ese caso la opción se ignora. Si se proporcionan configuraciones conflictivas (por ejemplo, limpieza completa/parcial), se usará la última. 
- ```--partial-scrub```  Limpia y recorta la imagen de salida, se elimina el relleno aleatorio.
- ```--full-scrub```     Reautoriza completamente la imagen resultante, esto producirá el archivo más pequeño posible.
- ```--split```          Divide el archivo XISO resultante si es demasiado grande para OG Xbox.
- ```--rename```         Parchea el campo de título de los archivos XBE resultantes con uno encontrado en la base de datos.
- ```--attach-xbe```     Genera un archivo attach XBE junto con el archivo de salida.
- ```--am-patch```       Parchea el campo "Allowed Media" en los archivos XBE resultantes.
- ```--offline```        Desactiva la funcionalidad en línea.
- ```--debug```          Habilita el registro de depuración.
- ```--quiet```          Desactiva todo registro excepto advertencias y errores.

## Compilación
Por defecto se compila como GUI, configure Cmake con ```-DENABLE_GUI=OFF``` para compilar para CLI. Para compilar para x86 sería necesario hacer varios cambios en los archivos CmakeLists.txt y cmake/setup_vcpkg.cmake para tenerlo en cuenta.

### Windows
Si tienes Cmake y MSVC instalados, debería ser bastante sencillo. El proyecto está configurado para Windows de modo que descargue y compile automáticamente todas las dependencias con vcpkg dentro del directorio del proyecto configurando con Cmake. Esto puede tardar un tiempo dependiendo de tu velocidad de internet y especificaciones del PC, pero solo debe hacerse una vez.

Clona este repositorio y crea un directorio de compilación

```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```

Configurar como GUI: 
```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
o como CLI: 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```
Construir

```
cmake --build . --config Release
```

### Linux
Esta aplicación aún no ha sido probada exhaustivamente en Linux, Linux también tiene algunas peculiaridades con wxWidgets, por lo que la interfaz gráfica no se ve exactamente como debería. Se ha probado con Clang, además de Clang, Make y Cmake, necesitarás instalar algunas otras dependencias:
```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
Clona este repositorio y crea un directorio de compilación
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
Configurar como GUI: 
```
cmake ..
``` 
o como CLI: 
```
cmake -DENABLE_GUI=OFF ..
```
Construir

```
make
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---