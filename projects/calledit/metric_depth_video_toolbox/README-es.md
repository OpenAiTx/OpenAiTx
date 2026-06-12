# Caja de herramientas de video de profundidad métrica (MDVToolbox)

Herramientas para generar y trabajar con videos de profundidad 3D métricos.

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_Banner creado con 3d_view_depthfile.py_

## Demostraciones

**Video de muestra:** https://youtu.be/nEiUloZ591Q

**Demo de conversión de película → 3D**: https://www.youtube.com/watch?v=PLFjoNgkZDY

**Clips estéreo de ejemplo:**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## Características

### Generación de video de profundidad métrica

Convierte videos rgb en videos de profundidad métricos usando múltiples modelos SOTA:

- Serie Depth-Anything (`video_metric_convert.py`) y (`videoanythingmetric_video.py`)
- MoGe  (`moge_video.py`)
- UniDepth  (`unidepth_video.py`)
- UniK3D  (`unik3d_video.py`)
- DepthPro  (`depthpro_video.py`)
- DepthCrafter  (`depthcrafter_video.py`)
- MVSAnywhere  (`video_mvsa.py`)

### Conversión estéreo / 3D

- Películas 2D → 3D (`movie_2_3D.py`)
- Renderizado estéreo desde video de profundidad y rgb (`stereo_rerender.py`)
- Relleno de paralaje e inpainting estéreo basado en difusión (`stereo_crafter_infill.py`)

### Visualización

- Visor 3D en tiempo real para videos de profundidad métrica (`3d_view_depthfile.py`)
- Renderizado de vista novedosa desde video de profundidad (`3d_view_depthfile.py`)

### Seguimiento de Cámara y Reconstrucción 3D

- Seguimiento de cámara asistido por profundidad (`sam_track_video.py`) y (`align_3d_points.py`)
- Seguimiento de puntos a largo plazo (CoTracker3) (`track_points_in_video.py`)
- Herramientas de extracción y alineación de pose

### Herramientas de Exportación

Exportar video de profundidad métrica a formatos estándar para uso en otras herramientas: (`convert_metric_depth_video_to_other_format.py`)

- Nubes de puntos `.ply`
- Mallas `.obj`
- Seguimientos de cámara Blender `.blend` y Alembic `.abc`
- Mapas de profundidad de 8 bits / 16 bits
- Reescalado de profundidad basado en triangulación

### Enmascaramiento y Limpieza

- Enmascaramiento automático del sujeto principal (`generate_video_mask.py`)
- Retoque de subtítulos/logos (`apply_inpainting.sh`)


## Documentación

| Tema | Enlace |
|---|---|
Guía para principiantes | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
Guía Película → 3D | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
Referencia completa de la herramienta | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
Video tutorial GUI | https://youtu.be/BE_aJCI7DHI  


## Formato de Video de Profundidad

MDVT usa **profundidad métrica codificada en RGB de 16 bits**:

- **Rojo + Verde** = 8 bits superiores (duplicados para visibilidad)  
- **Azul** = 8 bits inferiores  
- Rango predeterminado: **100 metros**
- Resolución: **~1.5 mm de precisión en profundidad**

La mejora futura para mayor precisión se realizará con: **profundidad de 24 bits** o **profundidad codificada en logaritmo** para precisión a largo alcance.

---

## Instalación

### Windows
1. instalar git https://git-scm.com/downloads/win
2. Instalar miniconda https://docs.conda.io/en/latest/
3. Abrir el símbolo de Anaconda (miniconda) desde el menú inicio
4. ejecutar
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. use `conda activate mdvt` para activar conda y usar las herramientas. Algunos modelos de ML no son compatibles con Windows pero los más esenciales sí, como Sterecrafter y depth anything.

### Ubuntu/Debian y OSX

```bash


git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox

# on linux
sudo apt-get install -y libgl1
./install_mdvtoolbox.sh

#Optional (only required for some tools)
./install_mdvtoolbox.sh -megasam
./install_mdvtoolbox.sh -geometrycrafter
./install_mdvtoolbox.sh -unik3d
./install_mdvtoolbox.sh -depthpro
./install_mdvtoolbox.sh -stereocrafter
./install_mdvtoolbox.sh -madpose
./install_mdvtoolbox.sh -unidepth
./install_mdvtoolbox.sh -moge
./install_mdvtoolbox.sh -promptda

# if using headless linux you need to start a virtual x11 server
apt-get install xvfb
Xvfb :2 &
export DISPLAY=:2

# OSX (OSX only supports post processing of depth videos not generation of them. As the ML models need CUDA)
# (open3d requires python3.11 on OSX (as of 2025)))
pip3.11 install open3d numpy opencv-python

```

### Requisitos
Las herramientas que requieren modelos de ML han sido probadas en máquinas con tarjetas nvidia 3090 que soportan Cuda 12.4 y Torch 2.5.1 en [vast.ai](https://cloud.vast.ai/?ref_id=148636) usando "template PyTorch (cuDNN Devel)"

### Próximos pasos
- Actualmente esperando nuevos modelos de profundidad estables y precisos.

### Contribuciones
Se agradecen. Incluso por cosas simples como la ortografía.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---