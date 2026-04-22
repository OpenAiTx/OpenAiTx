Edición: Este repositorio ha sido archivado ya que no he podido generar resultados buenos (suficientemente) con el modelo, por ahora me quedaré con LTX2.3.  
Siéntete libre de seguir trabajando en él.

Edición: ¡OJO! Esto aún está en progreso, no esperes que funcione.  
Me voy de vacaciones de Pascua y no tendré tiempo de revisarlo hasta que regrese.  
Siéntete libre de hacer un fork y continuar el trabajo, o espera a que Kijai lance su versión.

El código (por ahora, se cambiará más adelante) descargará automáticamente el codificador de texto y el wan vae necesarios desde huggingface,  
espera que tome un tiempo en la primera ejecución.

# ComfyUI-DaVinci-MagiHuman

Nodos personalizados de ComfyUI para [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman), un transformador de flujo único de 15 mil millones de parámetros para generación rápida de audio y video. Optimizado para GPUs de consumo (RTX 5090 32GB).

## Características

- **Intercambio CPU/GPU a nivel de bloque** — solo 8 de 40 capas del transformador en GPU a la vez (~6GB vs ~30GB)  
- **Prefetching CUDA asíncrono** — transferencia del siguiente bloque mientras se calcula el bloque actual  
- **Modo Distill** — generación en 8 pasos sin CFG (el más rápido)  
- **Super-resolución 1080p** — escalado en espacio latente desde base 256p  
- **Decodificador TurboVAE** — decodificación con ventana deslizante y descarga de salida para 1080p  
- **Audio + video** — generación conjunta de flujo único

## Nodos

| Nodo | Descripción |
|------|-------------|
| **Cargador de Modelo DaVinci** | Carga modelo distill/base/SR con `blocks_on_gpu` configurable |
| **Cargador DaVinci TurboVAE** | Carga el VAE rápido solo para decodificación |
| **Codificador de Texto DaVinci** | Texto a embeddings (acepta codificador T5 externo) |
| **Sampler DaVinci** | Bucle de denoising (8 pasos distill / 32 pasos base) |
| **Super Resolución DaVinci** | Escala latente 256p a 1080p con modelo SR |
| **Decodificador DaVinci** | TurboVAE latente a video con descarga de salida |
| **Salida de Video DaVinci** | Guardar en mp4/webm vía FFmpeg |

## Flujo de trabajo

```
Model Loader (distill, 8 blocks on GPU)
  → Text Encode
    → Sampler (256p, 8 steps)
      → [optional] SR Model Loader (1080p_sr) → Super Resolution
        → TurboVAE Loader → Decode → Video Output
```

## Requisitos

- **GPU**: RTX 5090 (32GB) o superior. 8 bloques en GPU funcionan con 32GB de VRAM.
- **RAM**: Se recomienda 64GB+ (la descarga en CPU almacena ~24GB de pesos del modelo en la RAM del sistema)
- **CUDA**: GPU compatible con CUDA con soporte bf16
- **FFmpeg**: Requerido para salida de video
- **Paquetes de Python**: `safetensors`, `torch`, `numpy`

## Configuración del modelo

Descargue los pesos del modelo desde [HuggingFace](https://huggingface.co/GAIR/daVinci-MagiHuman):

```bash
cd ComfyUI/models

# Clone without large files
GIT_LFS_SKIP_SMUDGE=1 git clone https://huggingface.co/GAIR/daVinci-MagiHuman

cd daVinci-MagiHuman

# Pull only what you need (skip 540p_sr if you only want 1080p)
git lfs pull --include="distill/*,turbo_vae/*"        # ~61GB - base generation
git lfs pull --include="1080p_sr/*"                    # ~61GB - 1080p upscaling
```

Estructura de directorios esperada:
```
ComfyUI/models/daVinci-MagiHuman/
├── distill/          # 8-step distilled model (~61GB)
├── 1080p_sr/         # Super-resolution model (~61GB)
├── turbo_vae/        # Fast decoder (small)
├── base/             # Full 32-step model (optional, ~30GB)
└── 540p_sr/          # 540p SR (optional, ~61GB)
```

## Guía de VRAM

| `blocks_on_gpu` | Uso de VRAM | Velocidad | Recomendado Para |
|-----------------|-------------|-----------|------------------|
| 4 | ~3GB + overhead | Más lento | GPUs de 16GB |
| 8 | ~6GB + overhead | Bueno | GPUs de 24-32GB |
| 16 | ~12GB + overhead | Rápido | GPUs de 48GB |
| 40 | ~30GB | Más rápido | GPUs de 80GB+ |

## Codificador de Texto

daVinci-MagiHuman usa T5Gemma-9B como su codificador de texto. El nodo **DaVinci Text Encode** actualmente proporciona:

- **Embeddings de marcador de posición** para pruebas de pipeline (ruido aleatorio — no producirá salida significativa)
- **Entrada T5 externa** — conecta embeddings T5 precomputados (3584 dim) desde otro nodo codificador

Para uso en producción, conecta un nodo codificador T5-XXL o T5Gemma a la entrada `t5_embeds`.

## Arquitectura

El modelo es un transformador de flujo único que genera video y audio conjuntamente:

- **15B parámetros**, 40 capas de transformador
- **Tamaño oculto**: 5120, **GQA**: 40 cabezas de consulta / 8 KV, **Dimensión de cabeza**: 128
- **Capas sandwich**: 0-3 y 36-39 tienen normas por modalidad (video/audio/texto)
- **Capas compartidas**: 4-35 usan procesamiento unificado
- **Sin paso de tiempo explícito**: No hay embedding explícito de paso de tiempo — infiere estado de denoising desde la entrada
- **Compuertas por cabeza**: Compuertas sigmoides aprendidas en cada cabeza de atención

## Créditos

- [daVinci-MagiHuman](https://huggingface.co/GAIR/daVinci-MagiHuman) por SII-GAIR & Sand.ai
- [MagiCompiler](https://github.com/SandAI-org/MagiCompiler) para fusión de operadores
- Construido sobre Wan2.2 y TurboVAED

## Licencia

Apache 2.0


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-22

---