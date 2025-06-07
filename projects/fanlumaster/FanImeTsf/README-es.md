## FanImeTsf

Este es el extremo TSF de [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Aviso: actualmente solo se admiten aplicaciones de 64 bits.

## Cómo compilar

### Requisitos previos

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Asegúrese de que vcpkg y gsudo estén instalados mediante **Scoop**.

## Pasos de compilación

### Compilar

Primero, clone el repositorio,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Luego, prepare el entorno,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Luego, compile,

```powershell
.\scripts\lcompile.ps1
```

### Instalar

Inicie PowerShell como administrador, asegúrese de que haya activado la opción del sistema `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Luego, cree una carpeta en `C:\Program Files\` llamada `FanImeTsf` y copie en ella el archivo `FanImeTsf.dll`,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Luego, instálelo,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Desinstalar

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Capturas de pantalla

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Hoja de ruta

Actualmente solo es compatible Xiaohe Shuangpin.

### Chino

- Xiaohe Shuangpin
- Quanpin
- Códigos de ayuda en el uso de componentes Hanzi
- Diccionario personalizable
- Motor IME personalizado
- Apariencias personalizadas
- Alternar entre chino simplificado y chino tradicional
- Autocompletado en inglés
- API de IME en la nube de código abierto
- Alternar la interfaz de la ventana de candidatos entre modo vertical y horizontal
- Interruptores de funciones: la mayoría de las funciones deberían poder alternarse o personalizarse libremente por los usuarios

### Soporte para japonés

Quizás en otro proyecto.

Y tal vez soporte para otros idiomas.

### Referencias

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---