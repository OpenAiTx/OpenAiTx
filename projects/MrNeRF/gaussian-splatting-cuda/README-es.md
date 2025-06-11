# Gaussian Splatting 3D para Renderizado en Tiempo Real de Campos de Radiancia - Implementación en C++ y CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Una implementación de alto rendimiento en C++ y CUDA de Gaussian Splatting 3D, construida sobre el backend de rasterización [gsplat](https://github.com/nerfstudio-project/gsplat).

## Noticias
- **[2025-06-10]**: Se corrigieron algunos problemas. Estamos cerrando la brecha con las métricas de gsplat. Sin embargo, aún hay una pequeña discrepancia.
- **[2025-06-04]**: Añadida la estrategia MCMC con la opción de línea de comando `--max-cap` para controlar el conteo máximo de gaussianas.
- **[2025-06-03]**: Cambiado al backend Gsplat y actualizada la licencia.
- **[2024-05-27]**: Actualizado a LibTorch 2.7.0 para mejor compatibilidad y rendimiento. Se abordaron cambios disruptivos en la gestión del estado del optimizador.
- **[2024-05-26]**: El objetivo actual de este repositorio es avanzar hacia una licencia permisiva. Se ha realizado un trabajo importante para reemplazar el rasterizador por la implementación de gsplat.

## Métricas
Actualmente la implementación no logra resultados equivalentes a gsplat-mcmc, pero está en progreso.  
Es solo cuestión de tiempo para corregir el error. ¡Se agradece la ayuda! :) Las métricas para la estrategia mcmc son las siguientes:

| Escena   | Iteración | PSNR          | SSIM         | LPIPS        | Tiempo por Imagen | Nº de Gaussianas |
| -------- | --------- | ------------- | ------------ | ------------ | ----------------- | ---------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765          | 1000000          |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618          | 1000000          |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536          | 1000000          |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188          | 1000000          |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259          | 1000000          |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078          | 1000000          |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519          | 1000000          |
| **media**| **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**      | **1000000**      |

## Comunidad y Soporte

Únete a nuestra creciente comunidad para discusiones, soporte y actualizaciones:  
- 💬 **[Comunidad Discord](https://discord.gg/TbxJST2BbC)** - Obtén ayuda, comparte resultados y discute el desarrollo  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Visita nuestro sitio web para más recursos  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Lista completa de papers y recursos  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Sigue para las últimas actualizaciones

## Instrucciones de Construcción y Ejecución

### Requisitos de Software
1. **Linux** (probado en Ubuntu 22.04) - Actualmente no se soporta Windows  
2. **CMake** 3.24 o superior  
3. **CUDA** 11.8 o superior (puede funcionar con versiones inferiores mediante configuración manual)  
4. **Python** con headers de desarrollo  
5. **LibTorch 2.7.0** - Instrucciones de instalación abajo  
6. Otras dependencias se manejan automáticamente con CMake

### Requisitos de Hardware
1. **GPU NVIDIA** con soporte CUDA  
    - Probado con éxito: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Problema conocido con RTX 3080Ti en datasets grandes (ver #21)  
2. Capacidad mínima de cómputo: 8.0

> Si logras ejecutar con otro hardware, ¡comparte tu experiencia en la sección de Discussions!

### Instrucciones para Construir

```bash
# Clonar el repositorio con submódulos
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Descargar y configurar LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Compilar el proyecto
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Este proyecto utiliza **LibTorch 2.7.0** para un rendimiento y compatibilidad óptimos:

- **Rendimiento Mejorado**: Optimización y manejo de memoria mejorados  
- **Estabilidad API**: Última API estable de PyTorch en C++  
- **Compatibilidad CUDA**: Mejor integración con CUDA 11.8+  
- **Corrección de Errores**: Problemas de gestión del estado del optimizador resueltos

### Actualización desde Versiones Anteriores
1. Descarga la nueva versión de LibTorch siguiendo las instrucciones de compilación  
2. Limpia tu directorio de compilación: `rm -rf build/`  
3. Reconstruye el proyecto

## Dataset

Descarga el dataset del repositorio original:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)  

Extráelo en la carpeta `data` en la raíz del proyecto.

## Opciones de Línea de Comandos

### Opciones Principales

- **`-h, --help`**  
  Muestra el menú de ayuda

- **`-d, --data-path [RUTA]`**  
  Ruta a los datos de entrenamiento (obligatorio)

- **`-o, --output-path [RUTA]`**  
  Ruta para guardar el modelo entrenado (por defecto: `./output`)

- **`-i, --iter [NÚM]`**  
  Número de iteraciones de entrenamiento (por defecto: 30000)  
    - El paper sugiere 30k, pero 6k-7k suele dar buenos resultados preliminares  
    - Los resultados se guardan cada 7k iteraciones y al finalizar

- **`-f, --force`**  
  Fuerza sobrescribir la carpeta de salida si existe

- **`-r, --resolution [NÚM]`**  
  Define la resolución para las imágenes de entrenamiento

### Opciones Específicas para MCMC

- **`--max-cap [NÚM]`**  
  Número máximo de Gaussianas para la estrategia MCMC (por defecto: 1000000)  
    - Controla el límite superior de gaussian splats durante el entrenamiento  
    - Útil para entornos con limitación de memoria

### Ejemplos de Uso

Entrenamiento básico:
```bash
./build/gaussian_splatting_cuda -d /ruta/a/datos -o /ruta/a/salida -i 10000
```

Entrenamiento MCMC con gaussianas limitadas:
```bash
./build/gaussian_splatting_cuda -d /ruta/a/datos -o /ruta/a/salida -i 10000 --max-cap 500000
```

## Guía para Contribuciones

¡Damos la bienvenida a contribuciones! Así puedes empezar:

1. **Primeros pasos**:  
    - Revisa issues etiquetados como **good first issues** para tareas amigables para principiantes  
    - Para nuevas ideas, abre una discusión o únete a nuestro [Discord](https://discord.gg/TbxJST2BbC)

2. **Antes de enviar un PR**:  
    - Aplica `clang-format` para mantener un estilo de código consistente  
    - Usa el hook pre-commit: `cp tools/pre-commit .git/hooks/`  
    - Discute nuevas dependencias en un issue antes - buscamos minimizar dependencias

## Agradecimientos

Esta implementación se basa en varios proyectos clave:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Usamos el backend de rasterización CUDA altamente optimizado de gsplat, que ofrece mejoras significativas en rendimiento y eficiencia de memoria.

- **Gaussian Splatting 3D original**: Basado en el trabajo innovador de Kerbl et al.

## Cita

Si usas este software en tu investigación, por favor cita el trabajo original:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Licencia

Consulta el archivo LICENSE para más detalles.

---

**Conéctate con nosotros:**  
- 🌐 Sitio web: [mrnerf.com](https://mrnerf.com)  
- 📚 Papers: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Únete a nuestra comunidad](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Sigue a [@janusch_patas](https://twitter.com/janusch_patas) para actualizaciones del desarrollo

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---