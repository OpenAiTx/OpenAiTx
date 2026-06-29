# RefineAnything

**Refinamiento multimodal específico por región para detalles locales perfectos**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnything se enfoca en el **refinamiento de imágenes específico por región**: dada una imagen de entrada y una región especificada por el usuario (por ejemplo, máscara de garabato o caja delimitadora), restaura detalles finos—texto, logotipos, estructuras delgadas—manteniendo **todos los píxeles no editados sin cambios**. Soporta refinamiento tanto **con referencia** como **sin referencia**.

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## Noticias
- **2026-04-21** — **Actualización de fijación de entorno.** Para mejores resultados (y evitar cambios de color), por favor use **exactamente** las versiones fijadas en `requirement.txt`: `diffusers==0.36.0`, `transformers==4.55.0`, `safetensors==0.5.3`, `peft==0.17.0`. Vea el [Aviso de Entorno](#environment-notice) abajo para una comparación visual.
- **2026-04-21** — **Entorno de Hugging Face Space corregido.** La demo en línea ahora funciona con las versiones correctas de las dependencias, por lo que los resultados de refinamiento son notablemente mejores: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-14** — Integración comunitaria de ComfyUI por [@smthemex](https://github.com/smthemex): [ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything). ¡Gracias por el gran trabajo!
- **2026-04-14** — Demo local de Gradio (`app.py`) disponible para pruebas interactivas.
- **2026-04-12** — Demo en Hugging Face Space en línea: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-09** — Checkpoint lanzado en Hugging Face: <https://huggingface.co/limuloo1999/RefineAnything>.
- **2026-04-09** — Scripts de inferencia lanzados.
- **2026-04-08** — Esqueleto de documentación añadido; **lanzamiento del código este mes** (scripts de inferencia, entorno y checkpoints estarán enlazados aquí).
- **Por definir** — Los checkpoints y recursos de entrenamiento/evaluación serán anunciados una vez finalizados.

---

## Destacados

- **Refinamiento preciso por región** — Señales explícitas de región (garabatos o cajas) guían las ediciones hacia el área objetivo.
- **Con y sin referencia** — Imagen de referencia opcional para recuperación guiada de detalles locales.
- **Preservación estricta del fondo** — Las ediciones se mantienen dentro de la región objetivo; el entrenamiento enfatiza bordes sin costuras.

---

## Comparaciones

![Comparaciones cualitativas sin referencia](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```

> **Importante — fije estas versiones exactamente.** RefineAnything es sensible a pequeñas diferencias numéricas en las bibliotecas subyacentes. Por favor, instale **exactamente** las versiones indicadas a continuación; usar versiones más nuevas o más antiguas puede causar artefactos visibles como cambios de color en la región refinada.
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## Aviso sobre el entorno

Hemos observado que versiones incompatibles de `diffusers` / `transformers` / `safetensors` / `peft` pueden introducir **cambios de color** en la región refinada, incluso cuando todo lo demás es idéntico. El ejemplo a continuación usa el prompt *"remove the hand"*:

<table>
<tr>
<td align="center"><b>Entrada (región enmascarada = mano)</b></td>
<td align="center"><b>Entorno correcto</b></td>
<td align="center"><b>Entorno incorrecto (cambio de color)</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

Si su resultado muestra una leve discordancia de color/tono dentro de la máscara mientras el resto de la imagen se ve bien, lo primero que debe revisar son las versiones de sus paquetes.

---

## Inicio rápido

Solo se requieren **tres** cosas para ejecutar RefineAnything:

| Argumento | Descripción |
|----------|-------------|
| `--input` | Imagen fuente |
| `--mask` | Máscara binaria (blanco = región a refinar) |
| `--prompt` | Qué refinar |
| `--ref` | *(opcional)* Imagen de referencia para refinamiento guiado |

---

### Demostración 1 — Refinamiento de logotipo basado en referencia

Refina un logotipo borroso en una almohada usando una imagen de referencia.

```bash
python scripts/fast_inference.py \
    --input  src/input1.png \
    --mask   src/mask1.png \
    --prompt "Refine the LOGO." \
    --ref    src/ref1.png \
    --output output/demo1.png
```

<table>
<tr>
<td align="center"><b>Entrada</b></td>
<td align="center"><b>Referencia</b></td>
<td align="center"><b>Indicador</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>"Refinar el LOGO."</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>Salida</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### Demostración 2 — Refinamiento de Texto sin Referencia

Refina texto chino borroso en un letrero de edificio — no se necesita imagen de referencia.

```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```
<table>
<tr>
<td align="center"><b>Entrada</b></td>
<td align="center"><b>Indicación</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>"refinar el texto '鼎好商城'"</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>Salida</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## Demostración Local en Gradio

También ofrecemos una interfaz web basada en Gradio para pruebas interactivas. Puedes pintar regiones, subir imágenes de referencia y ajustar todos los parámetros de inferencia en el navegador.


```bash
python app.py
```

Luego abre `http://localhost:7860` en tu navegador. La aplicación descargará automáticamente el modelo base (`Qwen/Qwen-Image-Edit-2511`) y el LoRA RefineAnything desde Hugging Face en el primer inicio.

Puedes especificar una ruta personalizada para el modelo base mediante la variable de entorno `MODEL_DIR`:

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Características de la demostración de Gradio:**
- **Pincel para seleccionar**: pinta directamente sobre la imagen fuente para definir la región de refinamiento.
- **Imagen de referencia opcional**: sube una segunda imagen y opcionalmente pinta para recortar un área de referencia específica.
- **Recorte de enfoque**: recorta y acerca automáticamente la región de edición para mayor fidelidad de detalles, luego la recompone sin problemas.
- **Lightning LoRA**: conmutador de un clic para una inferencia más rápida con menos pasos.
- **Control deslizante Antes / Después**: compara instantáneamente la entrada y la salida.

---

## Citación

Si usas este repositorio, por favor cita:

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## Agradecimientos y Licencia

RefineAnything se basa en ideas y componentes del ecosistema más amplio de difusión y multimodal (incluyendo **Qwen2.5-VL**, **Qwen-Image**, y difusión latente con **VAE** + **MMDiT**). Los pesos del modelo base y los términos de la API están sujetos a sus respectivas licencias—**verifique el cumplimiento antes de redistribuir puntos de control o pesos derivados**.

Licencia del **código del repositorio**: *Por determinar* (p. ej., Apache-2.0 o MIT)—establezca `LICENSE` cuando haga público el código fuente.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---