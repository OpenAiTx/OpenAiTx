Edit: This repo has been archived as i have not been able to generate good (enough) results with the model, i'll stick to LTX2.3 for now. 
Feel free to keep working on it.

Edit: OBS! This is still work in progress, do not expect it to work. 
Im going away on easter holiday and have no time to look at it before im back.
Feel free to fork it and continue the work, or wait for Kijai to release his version.

The code will (for now, will be changed later) automatically download the required text encoder and wan vae from huggingface, 
expect it to take some time on the first run.

# ComfyUI-DaVinci-MagiHuman

ComfyUI custom nodes for [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman), a 15B parameter single-stream transformer for fast audio-video generation. Optimized for consumer GPUs (RTX 5090 32GB).

## Features

- **Block-level CPU/GPU swapping** — only 8 of 40 transformer layers on GPU at once (~6GB vs ~30GB)
- **Async CUDA prefetching** — next block transfers while current block computes
- **Distill mode** — 8-step generation without CFG (fastest)
- **1080p super-resolution** — latent-space upscaling from 256p base
- **TurboVAE decoder** — sliding window decode with output offload for 1080p
- **Audio + video** — single-stream joint generation

## Nodes

| Node | Description |
|------|-------------|
| **DaVinci Model Loader** | Load distill/base/SR model with configurable `blocks_on_gpu` |
| **DaVinci TurboVAE Loader** | Load the fast decode-only VAE |
| **DaVinci Text Encode** | Text prompt to embeddings (accepts external T5 encoder) |
| **DaVinci Sampler** | Denoising loop (8 steps distill / 32 steps base) |
| **DaVinci Super Resolution** | Upscale 256p latent to 1080p with SR model |
| **DaVinci Decode** | TurboVAE latent-to-video with output offload |
| **DaVinci Video Output** | Save to mp4/webm via FFmpeg |

## Workflow

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```

## Requirements

- **GPU**: RTX 5090 (32GB) or better. 8 blocks on GPU works for 32GB VRAM.
- **RAM**: 64GB+ recommended (CPU offloading stores ~24GB of model weights in system RAM)
- **CUDA**: CUDA-capable GPU with bf16 support
- **FFmpeg**: Required for video output
- **Python packages**: `safetensors`, `torch`, `numpy`

## Model Setup

Download model weights from [HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman):

```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```

Expected directory structure:
```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```

## VRAM Guide

| `blocks_on_gpu` | VRAM Usage | Speed | Recommended For |
|-----------------|-----------|-------|-----------------|
| 4 | ~3GB + overhead | Slowest | 16GB GPUs |
| 8 | ~6GB + overhead | Good | 24-32GB GPUs |
| 16 | ~12GB + overhead | Fast | 48GB GPUs |
| 40 | ~30GB | Fastest | 80GB+ GPUs |

## Text Encoder

daVinci-MagiHuman uses T5Gemma-9B as its text encoder. The **DaVinci Text Encode** node currently provides:

- **Placeholder embeddings** for pipeline testing (random noise — won't produce meaningful output)
- **External T5 input** — connect pre-computed T5 embeddings (3584 dim) from another encoder node

For production use, connect a T5-XXL or T5Gemma encoder node to the `t5_embeds` input.

## Architecture

The model is a single-stream transformer that jointly generates video and audio:

- **15B parameters**, 40 transformer layers
- **Hidden size**: 5120, **GQA**: 40 query / 8 KV heads, **Head dim**: 128
- **Sandwich layers**: 0-3 and 36-39 have per-modality norms (video/audio/text)
- **Shared layers**: 4-35 use unified processing
- **Timestep-free**: No explicit timestep embedding — infers denoising state from input
- **Per-head gating**: Learned sigmoid gates on each attention head

## Credits

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) by SII-GAIR & Sand.ai
- [MagiCompiler](https://github.com/SandAI-org/MagiCompiler) for operator fusion
- Built upon Wan2.2 and TurboVAED

## License

Apache 2.0
