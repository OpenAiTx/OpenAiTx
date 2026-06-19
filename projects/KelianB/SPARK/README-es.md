<p align="center">
    <h1 align="center">SPARK: Captura Monocular de Rostro Personalizada en Tiempo Real y Auto-supervisada</h1>
    <p align="center">
        <a href="mailto://kelian.baert@gmail.com"><strong>Kelian Baert</strong></a>
        ·
        <a href="https://sbharadwajj.github.io/"><strong>Shrisha Bharadwaj</strong></a>
        ·
        <a href="https://www.linkedin.com/in/fabien-castan/"><strong>Fabien Castan</strong></a>
        ·
        <a href="https://www.linkedin.com/in/benoitmaujean/"><strong>Benoit Maujean</strong></a>
        ·
        <a href="https://people.irisa.fr/Marc.Christie/"><strong>Marc Christie</strong></a>
        ·
        <a href="https://vabrevaya.github.io/"><strong>Victoria Fernandez Abrevaya</strong></a>
        ·
        <a href="https://boukhayma.github.io/"><strong>Adnane Boukhayma</strong></a>
    </p>
    <p align="center">
        <a href="https://technicolor.com">Technicolor</a> | <a href="https://is.mpg.de/">Instituto Max Planck</a> | <a href="https://www.inria.fr/en/inria-centre-rennes-university">INRIA Rennes</a>
        <br>
        <strong>Artículos de la Conferencia SIGGRAPH Asia 2024</strong>
    </p>
    <p align="center">
        <a href="https://kelianb.github.io/SPARK/" style="padding-left: 0.5rem;">
            <img src="https://img.shields.io/badge/Project-Page-blue?style=flat&logo=Google%20chrome&logoColor=blue" alt="Página del Proyecto">
        </a>
        <a href="https://dl.acm.org/doi/10.1145/3680528">
            <img src="https://img.shields.io/badge/Paper-red" alt="PDF">
        </a>
        <a href="https://arxiv.org/abs/2409.07984">
            <img src="https://img.shields.io/badge/Arxiv-red" alt="PDF arxiv">
        </a>
    </p>
    <p align="center">
        <img src="https://raw.githubusercontent.com/KelianB/SPARK/main/assets/teaser.webp" width="98%" />
    </p>
</p>

## Cita

Si encuentra útil nuestro código o artículo, por favor cite como:

```bibtex
@inproceedings{baert2024spark,
  title = {{SPARK}: Self-supervised Personalized Real-time Monocular Face Capture},
  author = {Baert, Kelian and Bharadwaj, Shrisha and Castan, Fabien and Maujean, Benoit and Christie, Marc and Abrevaya, Victoria and Boukhayma, Adnane},
  year = {2024},
  month = dec,
  booktitle = {SIGGRAPH Asia 2024 Conference Proceedings},
  articleno = {113},
  doi = {10.1145/3680528.3687704},
  isbn = {979-8-4007-1131-2/24/12},
  publisher = {Association for Computing Machinery},
  address = {New York, NY, USA},
  numpages = {12},
  url = {https://kelianb.github.io/SPARK/},
}
```

## Instalación

<details>
    <summary>Detalles</summary>

- Crea el entorno usando [setup.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./setup.sh).
- Ejecuta [TrackerAdaptation/setup_submodules.sh](https://raw.githubusercontent.com/KelianB/SPARK/main/./TrackerAdaptation/setup_submodules.sh). Esto puede tomar algunos minutos.
- Enlaza FLAME desde MultiFLARE a EMOCA: `ln TrackerAdaptation/submodules/EMOCA/assets/FLAME/geometry/generic_model.pkl MultiFLARE/assets/flame/flame2020.pkl`
    - Esto es equivalente a descargar [FLAME](https://flame.is.tue.mpg.de/download.php) (versión 2020), descomprimirlo y copiar `generic_model.pkl` en `./MultiFLARE/assets/flame/flame2020.pkl`.
- Obtén el espacio de textura del Basel Face Model adaptado a FLAME. Desafortunadamente, no podemos distribuir el espacio de textura ya que la licencia no lo permite. Por lo tanto, utiliza la herramienta de este [repositorio](https://github.com/TimoBolkart/BFM_to_FLAME) para convertir el espacio de textura a FLAME. Coloca el archivo resultante del modelo de textura en `TrackerAdaptation/submodules/EMOCA/assets/FLAME/texture/FLAME_albedo_from_BFM.npz`.

SPARK ha sido probado con GPUs NVIDIA RTX A5000 (24GB) o RTX A4000 (16GB). Es posible entrenar en GPUs con menos memoria reduciendo el tamaño del lote.

</details>

## Conjunto de datos

Consulta el repositorio [MonoFaceCompute](https://github.com/KelianB/MonoFaceCompute) para preprocesar tus propios datos.

## Uso

SPARK es un enfoque de dos etapas. Primero, ejecuta [MultiFLARE](./MultiFLARE/) para reconstruir un Avatar Facial 3D a partir de múltiples vídeos. Luego, usa [TrackerAdaptation](./TrackerAdaptation/) para adaptar un rastreador facial 3D existente a tu avatar para seguimiento en tiempo real mediante aprendizaje por transferencia.

<details>
    <summary>Detalles</summary>

### 1. MultiFLARE

```bash
cd MultiFLARE
python train.py --config configs/example.txt

# Export neutral mesh
python export_mesh.py --config configs/example.txt --resume 3000 --out_dir /tmp/example_mesh --tex_type albedo
```

Recomendamos comenzar con el archivo de configuración de ejemplo proporcionado y modificar `input_dir`, `train_dir` y `output_dir`. Para una lista de todos los parámetros, por favor consulte [arguments.py](https://raw.githubusercontent.com/KelianB/SPARK/main/./MultiFLARE/arguments.py) o la salida de `python train.py --help`. Los parámetros se pueden pasar ya sea en el archivo de configuración o como argumentos de línea de comandos.

### 2. Adaptación del Rastreador

```bash
cd TrackerAdaptation
# DECA encoder + MultiFLARE decoder
python train.py --config configs/example_deca.txt
# EMOCA encoder + MultiFLARE decoder
python train.py --config configs/example_emoca.txt
# SMIRK encoder + MultiFLARE decoder (recommended!)
python train.py --config configs/example_smirk.txt
# EMOCA encoder + EMOCA decoder (baseline)
python train.py --config configs/example_emoca_baseline.txt

# Quantitative eval
python evaluate.py --config configs/example_smirk.txt --tracker_resume 3000 --frame_interval 5 --num_frames 64

# Visualization videos
python make_comparison_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 5 6 --n_frames 1000 --smooth_crops --framerate 24
python make_overlay_video.py --config configs/example_smirk.txt --tracker_resume 3000 --test_dirs 2 --out test_beard --texture /path/to/texture.png --n_frames 1000 --smooth_crops --framerate 24
```

</details>

## Información de la Licencia

El código en este repositorio está sujeto a múltiples licencias.

1. **Código Original** (Technicolor Group & INRIA Rennes)
   - Todo el código en este repositorio, excepto donde se especifique lo contrario, está licenciado bajo la [Licencia CC BY-NC-SA](./LICENSE).

2. **Código de Terceros** (Instituto Max Planck para Sistemas Inteligentes)
   - Ubicación: `./MultiFLARE/flame`, `./MultiFLARE/flare`, `./TrackerAdaptation/submodules`
   - Estos directorios contienen código del Instituto Max Planck, con algunas modificaciones. Por favor, lea cuidadosamente la [Licencia MPI](./LICENSE_MPI) y tenga en cuenta que esto está disponible solo para **fines de investigación científica no comercial**.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-19

---