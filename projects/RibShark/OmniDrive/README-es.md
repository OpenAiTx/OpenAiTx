# OmniDrive
Copyright © 2026 Rib

## Descripción
OmniDrive es una modificación de firmware para unidades de disco óptico basadas en MediaTek MT1959 fabricadas por Hitachi-LG Data Storage que habilita funciones que permiten una lectura mejor y más completa de los discos, incluidos discos de juegos propietarios.

## Características
* Lectura de lead-in/lead-out para CD/DVD/BD y derivados.
* Lectura de sectores en bruto para CD/DVD/BD y derivados (2352 bytes/sector para CD, 2064 bytes/sector para DVD, 2072 bytes/sector para BD).
* Comando personalizado READ DISC RAW para leer discos, con banderas para FUA (evitando caché), direccionamiento en bruto (MSF para CD, PSN para DVD/BD) y descrambleo (para DVD/BD).
* Capacidad para leer varios discos de juegos propietarios (ver tabla):

| Tipo de Disco | Soporte | Notas |
| ---: | :---: | --- |
| CD (ROM/R/RW) | ☑️ |
| DVD (ROM/RAM/±R/±RW) | ☑️ |
| BD (ROM/R/RE) | ☑️ |
| BD-XL (R/RE) | ☑️ |
| UHD-BD | ☑️ |
| PlayStation 3 BD-ROM | ☑️ | El contenido del disco está cifrado, la clave del disco no es recuperable
| PlayStation 4 BD-ROM | ☑️ | El contenido del disco está cifrado, la clave del disco no es recuperable
| PlayStation 5 BD-ROM | ☑️ | El contenido del disco está cifrado, la clave del disco no es recuperable
| Xbox (XGD1) | ✅ |
| Xbox 360 (XGD2/XGD3) | ✅ |
| Xbox One/Series (XGD4) | ✅ | El contenido del disco está cifrado, la clave del disco no es recuperable
| GameCube (NROM)/Wii (RVL-ROM) | ✅ |
| GameCube (NR)/Wii (RVT-R) | ❓ |
| Wii U (WUP-ROM?) | ⚠️ | Puede leerse en bruto, pero el algoritmo de scrambling es actualmente desconocido |
| Wii U (CAT-R) | ☑️ |
| Dreamcast (GD-ROM/GD-R) | ❎ | Solo se puede leer el área de baja densidad |

Clave:
* ☑️ - Soporte nativo (sin firmware parcheado)
* ✅ - Soportado con OmniDrive
* ⚠️ - Soporte parcial (ver notas)
* ❓ - Soporte desconocido (requiere pruebas)
* ❎ - Actualmente no soportado

## Compilación
### Dependencias
* CMake  
* ninja  
* cadena de herramientas arm-none-eabi-gcc  
* [armips](https://github.com/Kingcom/armips)  
* Python 3  
* pycryptodome  
### Instrucciones  
1. Coloque los archivos de firmware originales LG BU40N 1.00 y ASUS BW-16D1HT 3.02 en la carpeta `firmware`. Los archivos deben tener los siguientes nombres y las siguientes sumas de verificación:  

| Nombre de archivo | CRC32 | MD5 | SHA-1 |  
| --- | --- | --- | --- |  
| HL-DT-ST_BD-RE_BU40N_1.00.bin | `E3C1A315` | `EDB28FCD7A239281ACE26A468D382A9C` | `9C48677B155154D24A3B95A32B4A29CA02FF40B3` |  
| ASUS_BW-16D1HT_3.02.bin | `84000B21` | `97F0EEABD0B675B4363B2C4749226016` | `F8DF5B579F25DA8D4E5AA5EF79F3005DAC5EB8C7` |  
2. Cree una carpeta `build` y ejecute `cmake -G Ninja ..` desde la carpeta build.  
3. Ejecute `ninja`. Los archivos de firmware parcheados se generarán en la carpeta `patched_firmware`.  

## Flasheo  
Actualmente, el método recomendado para flashear las unidades es usar `sdftool`, que viene como parte de [MakeMKV](https://makemkv.com/). El firmware BU40N debería funcionar con todas las unidades slim y el firmware BW-16D1HT debería funcionar con todas las unidades de escritorio.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---