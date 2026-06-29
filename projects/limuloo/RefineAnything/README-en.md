# RefineAnything

**Multimodal Region-Specific Refinement for Perfect Local Details**

<a href="https://limuloo.github.io/RefineAnything/"><img src="https://img.shields.io/badge/Project-Page-blue" /></a>
<a href="https://arxiv.org/abs/2604.06870"><img src="https://img.shields.io/badge/arXiv-2604.06870-b31b1b" /></a>
<a href="https://github.com/limuloo/RefineAnything"><img src="https://img.shields.io/badge/GitHub-Code-black?logo=github" /></a>
<a href="https://huggingface.co/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Checkpoint-yellow?logo=huggingface" /></a>
<a href="https://huggingface.co/spaces/limuloo1999/RefineAnything"><img src="https://img.shields.io/badge/HuggingFace-Space-orange?logo=huggingface" /></a>
<a href="https://github.com/smthemex/ComfyUI_RefineAnything"><img src="https://img.shields.io/badge/ComfyUI-Plugin-green?logo=github" /></a>

RefineAnything targets **region-specific image refinement**: given an input image and a user-specified region (e.g., scribble mask or bounding box), it restores fine-grained details—text, logos, thin structures—while keeping **all non-edited pixels unchanged**. It supports both **reference-based** and **reference-free** refinement.

![Teaser](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/teaser.png)
---

## News
- **2026-04-21** — **Environment pinning update.** For best results (and to avoid color shifts), please use **exactly** the versions pinned in `requirement.txt`: `diffusers==0.36.0`, `transformers==4.55.0`, `safetensors==0.5.3`, `peft==0.17.0`. See [Environment Notice](#environment-notice) below for a visual comparison.
- **2026-04-21** — **Hugging Face Space environment fixed.** The online demo now runs on the correct dependency versions, so refinement results are noticeably better: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-14** — Community ComfyUI integration by [@smthemex](https://github.com/smthemex): [ComfyUI_RefineAnything](https://github.com/smthemex/ComfyUI_RefineAnything). Thanks for the great work!
- **2026-04-14** — Local Gradio demo (`app.py`) is available for interactive testing.
- **2026-04-12** — Hugging Face Space demo is live: <https://huggingface.co/spaces/limuloo1999/RefineAnything>.
- **2026-04-09** — Checkpoint released on Hugging Face: <https://huggingface.co/limuloo1999/RefineAnything>.
- **2026-04-09** — Release inference scripts.
- **2026-04-08** — Documentation skeleton added; **code release coming this month** (inference scripts, environment, and checkpoints will be linked here).
- **TBD** — Checkpoints and training/evaluation resources will be announced once finalized.

---

## Highlights

- **Region-accurate refinement** — Explicit region cues (scribbles or boxes) steer edits to the target area.
- **Reference-based and reference-free** — Optional reference image for guided local detail recovery.
- **Strict background preservation** — Edits stay inside the target region; training emphasizes seamless boundaries.

---

## Comparisons

![Reference-free qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_free.png)

![Reference-based qualitative comparisons](https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/qualitative_reference.png)

---

## Installation

```bash
pip install -r requirement.txt
```

> **Important — pin these versions exactly.** RefineAnything is sensitive to small numerical differences in the underlying libraries. Please install **exactly** the versions below; using newer or older releases can cause visible artifacts such as color shifts in the refined region.
>
> ```
> diffusers==0.36.0
> transformers==4.55.0
> safetensors==0.5.3
> peft==0.17.0
> ```

---

## Environment Notice

We have observed that mismatched versions of `diffusers` / `transformers` / `safetensors` / `peft` can introduce **color shifts** in the refined region, even when everything else is identical. The example below uses the prompt *"remove the hand"*:

<table>
<tr>
<td align="center"><b>Input (masked region = hand)</b></td>
<td align="center"><b>Correct environment</b></td>
<td align="center"><b>Wrong environment (color shift)</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/env_check_input.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/correct_env_result.png" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/wrong_env_result.png" width="100%"></td>
</tr>
</table>

If your output shows a mild color/tone mismatch inside the mask while the rest of the image looks fine, the first thing to check is your package versions.

---

## Quick Start

Only **three** things are required to run RefineAnything:

| Argument | Description |
|----------|-------------|
| `--input` | Source image |
| `--mask` | Binary mask (white = region to refine) |
| `--prompt` | What to refine |
| `--ref` | *(optional)* Reference image for guided refinement |

---

### Demo 1 — Reference-based Logo Refinement

Refine a blurry logo on a pillow using a reference image.

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
<td align="center"><b>Input</b></td>
<td align="center"><b>Reference</b></td>
<td align="center"><b>Prompt</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_input_zoom.jpg" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/src/ref1.png" width="100%"></td>
<td><i>"Refine the LOGO."</i></td>
</tr>
<tr>
<td align="center" colspan="3"><b>Output</b></td>
</tr>
<tr>
<td colspan="3"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo1_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

### Demo 2 — Reference-free Text Refinement

Refine blurry Chinese text on a building sign — no reference image needed.


```bash
python scripts/fast_inference.py \
    --input  src/input2.png \
    --mask   src/mask2.png \
    --prompt "refine the text '鼎好商城'" \
    --output output/demo2.png
```
<table>
<tr>
<td align="center"><b>Input</b></td>
<td align="center"><b>Prompt</b></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_input_zoom.jpg" width="100%"></td>
<td><i>"refine the text '鼎好商城'"</i></td>
</tr>
<tr>
<td align="center" colspan="2"><b>Output</b></td>
</tr>
<tr>
<td colspan="2"><img src="https://raw.githubusercontent.com/limuloo/RefineAnything/main/docs/static/demo2_output_zoom.jpg" width="100%"></td>
</tr>
</table>

---

## Local Gradio Demo

We also provide a Gradio-based web UI for interactive testing. You can brush regions, upload reference images, and adjust all inference parameters in the browser.


```bash
python app.py
```

Then open `http://localhost:7860` in your browser. The app will automatically download the base model (`Qwen/Qwen-Image-Edit-2511`) and the RefineAnything LoRA from Hugging Face on first launch.

You can specify a custom base model path via the `MODEL_DIR` environment variable:

```bash
MODEL_DIR=/path/to/local/Qwen-Image-Edit-2511 python app.py
```

**Features of the Gradio demo:**
- **Brush-to-select**: paint directly on the source image to define the refinement region.
- **Optional reference image**: upload a second image and optionally brush to crop a specific reference area.
- **Focus crop**: automatically crops and zooms into the edit region for higher detail fidelity, then composites back seamlessly.
- **Lightning LoRA**: one-click toggle for faster inference with fewer steps.
- **Before / After slider**: instantly compare input and output.

---

## Citation

If you use this repository, please cite:

```bibtex
@article{zhou2026refineanything,
  title={RefineAnything: Multimodal Region-Specific Refinement for Perfect Local Details},
  author={Zhou, Dewei and Li, You and Yang, Zongxin and Yang, Yi},
  journal={arXiv preprint arXiv:2604.06870},
  year={2026}
}
```

---

## Acknowledgements and License

RefineAnything builds on ideas and components from the broader diffusion and multimodal ecosystem (including **Qwen2.5-VL**, **Qwen-Image**, and latent diffusion with **VAE** + **MMDiT**). Base model weights and API terms are subject to their respective licenses—**verify compliance before redistributing checkpoints or derived weights**.

Repository **code license**: *TBD* (e.g., Apache-2.0 or MIT)—set `LICENSE` when you open-source the implementation.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-29

---