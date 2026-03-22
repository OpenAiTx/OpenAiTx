# PhotonInfer

<div align="center">

**Un motor de inferencia LLM de alto rendimiento con agrupamiento continuo al estilo vLLM**

[English](https://raw.githubusercontent.com/lumia431/photon_infer/master/README.md) | [中文](https://raw.githubusercontent.com/lumia431/photon_infer/master/README_ZH.md) | [Demostración en vivo](https://photoninfer.xyz/)

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CUDA](https://img.shields.io/badge/CUDA-12.0+-green.svg)](https://developer.nvidia.com/cuda-toolkit)
[![C++20](https://img.shields.io/badge/C++-20-orange.svg)](https://en.cppreference.com/w/cpp/20)

</div>

---

## 🚀 Aspectos Destacados de Rendimiento

PhotonInfer ofrece **rendimiento de inferencia de calidad para producción** para LLMs con capacidades avanzadas de agrupamiento. **Soporta modelos Llama-3.2 y Qwen3**.

### Inferencia de Solicitud Única

| Modelo | PhotonInfer | llama.cpp | Aceleración |
|--------|-------------|-----------|-------------|
| Llama 3.2 1B | 185 tok/s | 252 tok/s | 0.73× (llama.cpp más rápido) |

**TTFT (Tiempo Hasta el Primer Token)**: 387ms con prompt de 100 tokens (cuantización INT8)

### Rendimiento de Inferencia en Lote

| Tamaño del Lote | PhotonInfer | llama.cpp | Aceleración |
|-----------------|-------------|-----------|-------------|
| 4               | 410 tok/s   | 252 tok/s | **1.63×**   |
| 8               | 720 tok/s   | 255 tok/s | **2.82×**   |
| 16              | 787 tok/s   | 253 tok/s | **3.07×**   |

**Probado en**: NVIDIA A100, Llama 3.2 1B, cuantización Q8/INT8

## ✨ Características Clave

### 🎯 **Batching Continuo Estilo vLLM**
- **Programación dinámica a nivel de token**: Agrega nuevas solicitudes durante la generación sin esperar a que termine el lote
- **Planificador en dos fases**: Continúa ejecutando solicitudes mientras admite nuevas de forma fluida
- **Seguimiento del estado de la solicitud**: Gestión precisa de `num_computed_tokens` para una reanudación eficiente
- **Perfecto para producción**: Servicios de inferencia de alta concurrencia con capacidad de respuesta en tiempo real

### ⚡ **Kernels Optimizados para GPU**
- **Atención Paginada en Lote**: Gestión de caché KV a nivel de bloque con uso eficiente de memoria
- **Acceso a Memoria Vectorizado**: Cargas `float4` para eficiencia de ancho de banda 2-4×
- **Operaciones Fusionadas**: Muestreo en GPU sin copias, RoPE en lote, y normalización fusionada
- **Cuantización INT8**: Cuantización por grupos con soporte cuBLASLt INT8 GEMM
- **Softmax Optimizado**: CUB BlockReduce para cálculo numéricamente estable de atención

### 🏗️ **Arquitectura Moderna C++20**
- **Manejo de Errores Seguro por Tipo**: Tipo `Result<T, E>` inspirado en Rust para propagación explícita de errores
- **Diseño Sin Copias**: Uso extensivo de `std::span` y semántica de movimiento
- **Independiente del Dispositivo**: Interfaz unificada para backends CPU y CUDA
- **Conceptos y Rangos**: Restricciones en tiempo de compilación y seguridad de tipos expresiva

## 🚀 Inicio Rápido

### Requisitos Previos

- **Compilador**: GCC 12+ (se requiere soporte C++20)
- **CMake**: 3.20+
- **CUDA Toolkit**: 12.0+ (probado en 12.5)
- **GPU**: GPU NVIDIA con Capacidad de Cómputo 7.0+

### Descargar Modelo

Descarga un modelo pre-cuantiﬁcado para comenzar rápidamente:

https://huggingface.co/Lummy666/llama-3.2-1B-Instruct

### Compilar

#### Opción 1: Compilar desde el Código Fuente

```bash
# Clone repository
cd photon_infer

# Configure with CUDA
mkdir build && cd build
cmake -DCMAKE_BUILD_TYPE=Release -DPHOTON_BUILD_CUDA=ON ..

# Build
cmake --build . -j$(nproc)

# Install (optional)
sudo cmake --install .
```

Después de la instalación, puede ejecutar el servidor web directamente desde cualquier lugar:

```bash
photon_web_server \
    --port 5728 \
    --model /path/to/llama-3.2-1B-Instruct \
    --tokenizer /path/to/llama-3.2-1B-Instruct/tokenizer.json
```

La instalación colocará:
- `photon_web_server` → `/usr/local/bin/`
- Archivos web estáticos → `/photon_infer/web/static/`
- Biblioteca principal → `/usr/local/lib/`

Para desinstalar:
```bash
cd build
sudo cmake --build . --target uninstall
```
#### Opción 2: Usar Docker (Recomendado)


```bash
# Pull the pre-built Docker image
docker pull lumia431/photon_infer:latest

# Run the container with GPU support
docker run --rm --gpus all -p 5728:5728 -e PORT=5728 lumia431/photon_infer:latest
```

La interfaz web estará disponible en `http://localhost:5728`

## 🔬 Detalles Técnicos

### Cuantificación INT8
- **Cuantificación por grupos**: Tamaño de grupo configurable (32, 64, 128)
- **Integración cuBLASLt**: GEMM INT8 acelerado por hardware
- **Pérdida mínima de precisión**: < 1% de degradación en perplexidad en modelos Llama

### Atención Paginada
- **Cache KV a nivel de bloque**: Asignación eficiente de memoria sin fragmentación
- **Gestión dinámica de secuencias**: Desplazamientos de caché por secuencia para programación flexible
- **Operaciones en caché por lotes**: Kernel único para escrituras K/V de múltiples secuencias

### Planificador de Batching Continuo
- **Programación en dos fases**:
  1. **Fase 1**: Continuar todas las solicitudes EN EJECUCIÓN (sin interrupción)
  2. **Fase 2**: Admitir solicitudes EN ESPERA para llenar la capacidad restante
- **Estados de solicitud**: ESPERANDO → EN EJECUCIÓN → FINALIZADO (con soporte PREEMPTADO)
- **Granularidad a nivel de token**: Seguimiento de `num_computed_tokens` para reanudación precisa

## 🛣️ Hoja de Ruta

- [x] **Infraestructura central**: Tensores, operadores, gestión de memoria
- [x] **Modelo LLaMA**: Implementación completa del transformador con kernels CPU/GPU
- [x] **Cuantificación INT8**: Cuantificación por grupos con cuBLASLt
- [x] **Atención paginada**: Gestión de caché KV a nivel de bloque
- [x] **Batching continuo**: Programación dinámica de solicitudes estilo vLLM
- [ ] **Flash Attention 2**: Atención consciente de IO para secuencias largas
- [ ] **Soporte Multi-GPU**: Paralelismo tensorial para modelos grandes
- [ ] **Precisión mixta FP16/BF16**: Mayor rendimiento en GPUs modernas
- [ ] **Decodificación especulativa**: Generación multi-token con modelo borrador

## 📖 Documentación

- [Diseño de Batching Continuo](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/continuous_batching.md)
- [Guía de Optimización de Rendimiento](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/performance.md)
- [Referencia API](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/api.md)

## 🤝 Contribuyendo

¡Contribuciones bienvenidas! Por favor, consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/contributing.md) para las pautas.

## 📝 Licencia

Licencia MIT - vea [LICENSE](LICENSE) para detalles.

## 🙏 Agradecimientos

- Arquitectura inspirada en [vLLM](https://github.com/vllm-project/vllm)
- Referencia de optimizaciones de kernel [llama.cpp](https://github.com/ggerganov/llama.cpp)
- Diseño de manejo de errores basado en `Result<T, E>` de Rust

---

**Construido con ❤️ para inferencia de LLM de alto rendimiento**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---