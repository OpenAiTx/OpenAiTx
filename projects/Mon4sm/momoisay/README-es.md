# momoisay
*Un programa CLI escrito en C que presenta a Saiba Momoi hablando de Blue Archive!!!*

[![Licencia](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Versión](https://img.shields.io/badge/version-1.2.0-green)]()

---

## Vista previa

Ejemplo de uso animado

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## Características
- Arte ASCII parlante de Momoi
- Arte ASCII animado de Momoi
- Animación de Momoi con cambios libres

## Instalación

#### descargo de responsabilidad
A veces los binarios precompilados no son la versión más reciente como la del lanzamiento. Si quieres asegurarte de tener la última versión, puedes compilarlo desde el código fuente. Puedes verificar las versiones de los binarios compilados en las carpetas `/bin`.

### Linux
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/linux.sh
```
### MacOS
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/mac.sh
```
### Construir desde el código fuente (Última versión)
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## Uso
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```
## Estructura de Archivos

```
repo/
├── bin/ 
│    ├── linux/
│    │   ├── version.txt
│    │   └── momoisay
│    └── mac/
│        ├── version.txt 
│        └── momoisay
├── install/
│    ├── mac.sh
│    └── linux.sh
├── src/
│    ├── art/
│    │   ├── art.c
│    │   └── art.h
│    ├── extern/
│    │   ├── cString.c
│    │   └── cString.h
│    ├── momoisay.c
│    ├── render.c
│    ├── render.h
│    ├── speech.c
│    └── speech.h
├── Makefile
├── LICENSE
├── preview.gif
└── README.md
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---