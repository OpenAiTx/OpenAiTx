# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

Aplicación de apilamiento de enfoque de código abierto para Windows, macOS y Linux.

## Características

- **4 algoritmos de apilamiento:** Pirámide Laplaciana, Promedio Ponderado, Mapa de Profundidad, Fusión de Exposición (HDR)
- **Alineación automática:** Solo traslación o corrección de Rotación + Escala (respiración de enfoque)
- **Pipeline de 16 bits:** Preservación completa de la profundidad de bits desde RAW hasta la salida
- **Recorte automático:** Elimina bordes negros por desplazamientos de alineación
- **Autoajuste:** Parámetros detectados automáticamente según la resolución de la imagen
- **GUI + CLI:** Interfaz gráfica completa y herramienta de línea de comandos sin interfaz
- **Multiplataforma:** Compilaciones nativas para Windows, macOS, Linux
- **Pausar/reanudar/cancelar:** Control de apilamientos de larga duración
- **Comparación antes/después:** Visor con control deslizante para comparar entrada vs salida
- **Arrastrar y soltar:** Suelta archivos o carpetas de imágenes directamente en la aplicación

## Descarga

Paquetes precompilados disponibles en la página de [Releases](https://github.com/noah-peeters/ChimpStackr/releases):

| Plataforma | Descargar | Notas |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | Extraer y ejecutar `chimpstackr.exe` |
| **macOS** | `ChimpStackr-macOS.dmg` | Abrir DMG, arrastrar a Aplicaciones |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | `chmod +x` y ejecutar |

## Uso CLI

La CLI permite apilamiento de enfoque sin interfaz gráfica:

```bash
# Basic stack
chimpstackr-cli --input images/*.jpg --output result.tif

# Align + stack with auto parameters
chimpstackr-cli -i images/*.jpg -o result.tif --align --auto --auto-crop

# Full options
chimpstackr-cli -i images/*.jpg -o result.png \
  --align \
  --method laplacian \
  --rotation-scale \
  --kernel-size 6 \
  --pyramid-levels 8 \
  --auto-crop \
  --quality-report
```

**Métodos disponibles:** `laplacian` (predeterminado), `weighted_average`, `depth_map`

## Algoritmos de apilamiento

| Método | Mejor para | Cómo funciona |
|---|---|---|
| **Pirámide** | Detalles finos (cabellos, cerdas, bordes) | Descomposición en pirámide laplaciana, selección de máximo contraste por banda de frecuencia, mapeo de tono local |
| **Ponderado** | Sujetos suaves, buen color | Ponderación de contraste por píxel con acumulación adecuada |
| **Mapa de profundidad** | Superficies opacas, mejor fidelidad de color | Nitidez multiescala con suavizado bilateral consciente de bordes |
| **HDR** | Exposición/iluminación variable | Fusión de exposición Mertens (no para apilamiento de enfoque) |

## Construir desde la fuente

Requiere Python 3.9-3.13.

```bash
git clone https://github.com/noah-peeters/ChimpStackr.git
cd ChimpStackr
python -m venv .venv
source .venv/bin/activate  # or .venv\Scripts\activate on Windows
pip install -r requirements.txt

# Run GUI
python src/run.py

# Run CLI
python -m src.cli --help

# Run tests
pip install pytest
pytest tests/ -v
```

## Empaquetado

Las compilaciones usan PyInstaller con postprocesamiento específico de la plataforma. Solo puedes compilar para tu plataforma actual.

```bash
# Install build tools
pip install pyinstaller

# Build (creates dist/chimpstackr/ and dist/ChimpStackr.app on macOS)
pyinstaller chimpstackr.spec --noconfirm

# Or use the platform scripts:
./scripts/build_macos.sh        # macOS → .dmg
./scripts/build_linux.sh        # Linux → .AppImage
.\scripts\build_windows.ps1     # Windows → .zip or installer
```

CI/CD construye automáticamente todas las plataformas en lanzamientos etiquetados mediante GitHub Actions.

## Galería

Las siguientes pilas se tomaron a ~4x de aumento en un equipo ligeramente inestable (~150 imágenes cada una), apiladas con ChimpStackr y postprocesadas en [darktable](https://www.darktable.org/).

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## Fuentes

- Algoritmo de apilamiento de enfoque basado en: Wang, W., & Chang, F. (2011). A Multi-focus Image Fusion Method Based on Laplacian Pyramid. *Journal of Computers*, 6(12).
- Alineación de imágenes DFT adaptada de: [imreg_dft](https://github.com/matejak/imreg_dft)
- Fusión de exposición de Mertens: Mertens, T., Kautz, J., & Van Reeth, F. (2007). Exposure Fusion.
- Medida de enfoque Sum Modified Laplacian: Nayar, S.K., & Nakagawa, Y. (1994).

## Licencia

GPL-3.0 - ver [LICENSE](LICENSE) para detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---