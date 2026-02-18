# [arXiv] On-device Sora: Habilitando la Generación de Video a partir de Texto Basada en Difusión para Dispositivos Móviles

* El código se basa en la implementación de [Open-Sora](https://github.com/hpcaitech/Open-Sora)

**Artículo**: https://arxiv.org/abs/2502.04363

Implementación del código de [arXiv] On-device Sora: Habilitando la Generación de Video a partir de Texto Basada en Difusión para Dispositivos Móviles.
Código base referido ->
Open-Sora : Democratizando la Producción Eficiente de Video para Todos

## Introducción

Este repositorio proporciona código para *On-device Sora*, que es una implementación de código abierto del artículo llamado *On-device Sora: Habilitando la Generación de Video a partir de Texto Basada en Difusión para Dispositivos Móviles*.

### On-Device Sora
*On-device Sora* aplica Linear Proportional Leap (LPL), Temporal Dimension Token Merging (TDTM) y Concurrent Inference with Dynamic Loading (CI-DL) para permitir la generación eficiente de video en el iPhone 15 Pro.

![On-Device_Sora](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/overview.jpg)

### Open-Sora

[Open-Sora](https://github.com/hpcaitech/Open-Sora) es un modelo base de On-Device Sora, un proyecto de código abierto para generación de video, y un modelo de difusión T2V que puede producir videos basados en entrada de texto.

## Cómo convertir cada modelo a MLPackage para On-device Sora

## Dependencias del Paquete

### Dependencias

```
cd Device_conversion

conda create -n convert python=3.10

conda activate convert

pip install -r requirements/requirements-convert.txt

pip install -v .
```

## Conversión

### Conversión T5
```
cd t5
python3 export-t5.py
```

### Cubierta STDiT
```
cd stdit3
python3 export-stdit3.py
```

### Conversión de VAE
Cuando ejecutes `export-vae-spatial.py`, puede aparecer un error que dice `Fatal Python error: PyEval_SaveThread`.
Para solucionar este error, debes ejecutar solo un bloque de código para cada parte del VAE. Comenta el resto.

```
cd vae

# for vae's temporal part
python3 export-vae-temporal.py

# for vae's spatial part
python3 export-vae-spatial.py
```

## Cómo usar

### Requisitos
* Dispositivo Mac para xcode
* Cuenta Apple para compilar y lanzar la app
* iPhone: iPhone 15 pro o superior
* Versión iOS: 18 o superior
* Todos los MLPackage (T5, STDiT, VAE)

### Descargar MLPackage convertido (si no quieres convertir cada modelo a MLPackage)

Puedes descargar y usar los modelos convertidos desde el siguiente enlace. [[Descargar](https://drive.google.com/drive/folders/1L6pVi3KmyLygR_pvKofRL-21adKsEb4p?usp=sharing)]

### Ejecutar la app
* Implementa el proyecto xcode haciendo clic en On-device/On-device-Sora.xcodeproj
* Cambia el Equipo (Ninguno -> Tu cuenta Apple) en TARGETS/Signing&Capabilities
* Lanza la app
### Ejemplo de artefactos
![On-device-Sora-Example1](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/On-device-Sora-Example1.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---