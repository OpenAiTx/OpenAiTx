# EX-4D: Síntesis de Video 4D de Puntos de Vista Extremos mediante Malla Estanca de Profundidad

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Artículo](https://arxiv.org/abs/2506.05554)  |  [🎥 Página principal](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Código](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Destacados

- **🎯 Síntesis de Puntos de Vista Extremos**: Genera videos 4D de alta calidad con movimientos de cámara desde -90° hasta 90°
- **🔧 Malla Estanca de Profundidad**: Nueva representación geométrica que modela tanto regiones visibles como ocultas
- **⚡ Arquitectura Liviana**: Solo el 1% de los parámetros entrenables (140M) de la columna vertebral de difusión de video de 14B
- **🎭 Sin Entrenamiento Multi-vista**: Estrategia innovadora de enmascaramiento que elimina la necesidad de costosos conjuntos de datos multi-vista
- **🏆 Rendimiento de Última Generación**: Supera a los métodos existentes, especialmente en ángulos extremos de cámara

## 🎬 Resultados de Demostración

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D transforma videos monoculares en experiencias 4D controlables por cámara con resultados físicamente consistentes bajo puntos de vista extremos.*

## 🏗️ Descripción General del Framework

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Nuestro framework consta de tres componentes clave:

1. **🔺 Construcción de Malla Estanca de Profundidad**: Crea un robusto priorde geométrico que modela explícitamente regiones visibles y ocultas
2. **🎭 Estrategia de Enmascaramiento Simulado**: Genera datos de entrenamiento efectivos a partir de videos monoculares sin conjuntos de datos multi-vista
3. **⚙️ Adaptador LoRA Liviano**: Integra eficientemente la información geométrica con modelos de difusión de video preentrenados

## 🚀 Inicio Rápido

### Instalación

```bash
# Clona el repositorio
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Crea el entorno conda
conda create -n ex4d python=3.10
conda activate ex4d
# Instala PyTorch (se recomienda 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Instala Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Instala dependencias y diffsynth
pip install -e .
# Instala depthcrafter para la estimación de profundidad. (Sigue las instrucciones de instalación de DepthCrafter para la preparación de los checkpoints.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Descargar el Modelo Preentrenado
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Ejemplo de Uso
#### 1. Reconstrucción DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Generación EX-4D (se requieren 48GB de VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Video de Entrada</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Video de Salida</b>
</td>
</tr> 
</table>

<!-- ## 📊 Rendimiento

### Resultados Cuantitativos
| Método | FID (Extremo) ↓ | FVD (Extremo) ↓ | Puntuación VBench ↑ |
|--------|-----------------|-----------------|---------------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Nuestro)** | **55.42** | **823.61** | **0.450** | -->

### Resultados del Estudio de Usuario

- **70.7%** de los participantes prefirieron EX-4D sobre los métodos base
- Rendimiento superior en consistencia física y calidad en puntos de vista extremos
- Mejora significativa a medida que los ángulos de la cámara se vuelven más extremos


## 🎯 Aplicaciones

- **🎮 Videojuegos**: Crear cinemáticas de juegos 3D inmersivas a partir de grabaciones 2D
- **🎬 Producción Cinematográfica**: Generar ángulos de cámara novedosos para postproducción
- **🥽 VR/AR**: Crear experiencias de video con puntos de vista libres
- **📱 Redes Sociales**: Generar movimientos dinámicos de cámara para creación de contenido
- **🏢 Arquitectura**: Visualizar espacios desde múltiples puntos de vista

<!-- ## 📈 Benchmarks -->

<!-- ### Evaluación del Rango de Puntos de Vista

| Rango | Pequeño (0°→30°) | Grande (0°→60°) | Extremo (0°→90°) | Completo (-90°→90°) |
|-------|-------------------|------------------|-------------------|---------------------|
| Puntuación FID | 44.19 | 50.30 | 55.42 | - |
| Diferencia de Rendimiento | +9.1% mejor | +8.9% mejor | +11.3% mejor | +15.5% mejor | -->

<!-- *Diferencia de rendimiento en comparación con el segundo mejor método en cada categoría.* -->

## ⚠️ Limitaciones

- **Dependencia de Profundidad**: El rendimiento depende de la calidad de la estimación de profundidad monocular
- **Costo Computacional**: Requiere cómputo significativo para videos de alta resolución
- **Superficies Reflectantes**: Desafíos con materiales reflectantes o transparentes

## 🔮 Trabajo Futuro
- [ ] Optimización de inferencia en tiempo real (3DGS / 4DGS)
- [ ] Soporte para resoluciones más altas (1K, 2K)
- [ ] Técnicas de refinamiento de malla neuronal

## 🙏 Agradecimientos

Queremos agradecer al proyecto [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) por proveer el marco de difusión fundamental.

## 📚 Citación

Si encuentra útil nuestro trabajo, por favor considere citarlo:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu y Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---