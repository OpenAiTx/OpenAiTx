# parakeet.cpp

Reconocimiento de voz rápido con los modelos [Parakeet](https://huggingface.co/collections/nvidia/parakeet) de NVIDIA en C++ puro.

Construido sobre [axiom](https://github.com/frikallo/axiom) — una biblioteca ligera de tensores con aceleración automática Metal GPU. Sin runtime ONNX, sin runtime Python, sin dependencias pesadas. Solo C++ y una biblioteca de tensores que supera a PyTorch MPS.

**~27ms de inferencia del codificador en GPU Apple Silicon** para audio de 10s (modelo 110M) — 96 veces más rápido que CPU. Soporte FP16 para ~2x reducción de memoria.

## Modelos Soportados

| Modelo | Clase | Tamaño | Tipo | Descripción |
|--------|-------|--------|------|-------------|
| `tdt-ctc-110m` | `ParakeetTDTCTC` | 110M | Offline | Inglés, decodificadores duales CTC/TDT |
| `tdt-600m` | `ParakeetTDT` | 600M | Offline | Multilingüe, decodificador TDT |
| `eou-120m` | `ParakeetEOU` | 120M | Streaming | Inglés, RNNT con detección de fin de enunciado |
| `nemotron-600m` | `ParakeetNemotron` | 600M | Streaming | Multilingüe, latencia configurable (80ms–1120ms) |
| `sortformer` | `Sortformer` | 117M | Streaming | Diarización de hablantes (hasta 4) |
| `diarized` | `DiarizedTranscriber` | 110M+117M | Offline | ASR + diarización → palabras con atribución a hablantes |

Todos los modelos ASR comparten la misma pipeline de audio: WAV mono 16kHz → espectrograma Mel de 80 bins → codificador FastConformer.

## Inicio Rápido

```cpp
#include <parakeet/parakeet.hpp>

parakeet::Transcriber t("model.safetensors", "vocab.txt");
t.to_gpu();   // optional — Metal acceleration
t.to_half();  // optional — FP16 inference (~2x memory reduction)

auto result = t.transcribe("audio.wav");
std::cout << result.text << std::endl;
```

## Características

- **Múltiples decodificadores** — Decodificador CTC greedy, TDT greedy, búsqueda en haz CTC, búsqueda en haz TDT (cambio en el punto de llamada)
- **Tiempos de palabras** — Tiempos de inicio/fin y puntuaciones de confianza por palabra en todos los decodificadores
- **Búsqueda en haz + LM** — Búsqueda en haz CTC y TDT con fusión opcional de modelo de lenguaje n-grama ARPA
- **Impulso de frases** — Sesgo de contexto mediante trie a nivel de token para vocabulario específico del dominio
- **Transcripción por lotes** — Múltiples archivos en una sola pasada hacia adelante del codificador por lotes
- **Preprocesamiento VAD** — Silero VAD elimina el silencio antes del ASR; los tiempos se reasignan automáticamente
- **Aceleración GPU** — Metal mediante el compilador MPSGraph de axiom (aceleración de 96x en Apple Silicon)
- **Inferencia FP16** — Pesos y cálculos en media precisión (~2x reducción de memoria)
- **Streaming** — Modelos EOU y Nemotron con entrada de audio en fragmentos
- **Diarización de hablantes** — Sortformer (hasta 4 hablantes), combinable con ASR para palabras atribuidas a hablantes
- **API C** — FFI plano `extern "C"` para Python, Swift, Go, Rust y otros lenguajes
- **Audio multi-formato** — WAV, FLAC, MP3, OGG con remuestreo automático

Vea [examples/](examples/) para código que demuestra cada característica.

## Instalación

Los binarios precompilados están adjuntos a cada [lanzamiento de GitHub](https://github.com/Frikallo/parakeet.cpp/releases) para macOS arm64, macOS x86_64 y Linux x86_64. Descargue el archivo tarball para su plataforma y extraiga:

```bash
tar -xzf parakeet-v0.1.0-macos-arm64.tar.gz
cd parakeet-v0.1.0-macos-arm64
# On macOS, clear the Gatekeeper quarantine attribute first:
xattr -dr com.apple.quarantine .
./bin/parakeet --help
```

El archivo incluye un `bin/parakeet` autónomo (y `bin/example-server`) más `lib/libaxiom` con `@rpath`/`$ORIGIN` configurados para que los binarios resuelvan sus dependencias relativas al directorio de instalación — se puede colocar el directorio en cualquier lugar. Los encabezados de la API en C bajo `include/parakeet/` están incluidos para integradores.

## Construir desde el código fuente

```bash
git clone --recursive https://github.com/frikallo/parakeet.cpp
cd parakeet.cpp
make build
make test
```

Requisitos: C++20 (Clang 14+ o GCC 12+), CMake 3.20+, macOS 13+ para GPU Metal.

> **macOS:** la compilación requiere la instalación **completa de Xcode** (no solo las Herramientas de Línea de Comandos), porque axiom compila sus shaders Metal con `xcrun metal` y `xcrun metallib` — estos solo se incluyen con Xcode. Si solo quieres ejecutar parakeet, usa el tarball precompilado arriba; el `.metallib` está incrustado en el `libaxiom.dylib` distribuido y se ejecuta sin necesidad de instalar Xcode/CLT en el lado del usuario.

## Convertir Pesos

```bash
# Download from HuggingFace
huggingface-cli download nvidia/parakeet-tdt_ctc-110m --include "*.nemo" --local-dir .

# Convert to safetensors
pip install safetensors torch
python scripts/convert_nemo.py parakeet-tdt_ctc-110m.nemo -o model.safetensors
```

El convertidor admite todos los tipos de modelos: `110m-tdt-ctc` (predeterminado), `600m-tdt`, `eou-120m`, `nemotron-600m`, `sortformer`.

```bash
python scripts/convert_nemo.py checkpoint.nemo -o model.safetensors --model 600m-tdt
```
Pesos de Silero VAD:

```bash
python scripts/convert_silero_vad.py -o silero_vad_v5.safetensors
```

## Ejemplos

| Ejemplo | Descripción |
|---------|-------------|
| [basic](examples/basic/) | Transcripción más simple (~20 líneas) |
| [timestamps](examples/timestamps/) | Marcas de tiempo de palabras/tokens con confianza |
| [beam-search](examples/beam-search/) | Búsqueda beam CTC/TDT con LM ARPA opcional |
| [phrase-boost](examples/phrase-boost/) | Sesgo contextual para vocabulario de dominio |
| [batch](examples/batch/) | Transcripción por lotes de múltiples archivos |
| [vad](examples/vad/) | VAD independiente y preprocesamiento ASR+VAD |
| [gpu](examples/gpu/) | GPU Metal + FP16 con comparación de tiempos |
| [stream](examples/stream/) | Transcripción en streaming EOU |
| [nemotron](examples/nemotron/) | Streaming Nemotron con modos de latencia |
| [diarize](examples/diarize/) | Diarización de hablantes Sortformer |
| [diarized-transcription](examples/diarized-transcription/) | ASR + diarización combinados |
| [c-api](examples/c-api/) | Uso FFI puro C99 |
| [cli](examples/cli/) | CLI completo con todas las opciones |

## Uso como Biblioteca

### CMake `find_package`

Después de la instalación (`make install` o `cmake --install build`):

```cmake
find_package(Parakeet REQUIRED)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### CMake `add_subdirectory`

```cmake
add_subdirectory(third_party/parakeet.cpp)
target_link_libraries(myapp PRIVATE Parakeet::parakeet)
```

### pkg-config

```bash
g++ -std=c++20 myapp.cpp $(pkg-config --cflags --libs parakeet) -o myapp
```

## Arquitectura

### Modelos Offline

Construidos sobre un codificador FastConformer compartido (Conv2d con submuestreo 8x → N bloques Conformer con atención posicional relativa):

| Modelo | Clase | Decodificador | Caso de uso |
|--------|-------|---------------|-------------|
| CTC | `ParakeetCTC` | Argmax voraz o búsqueda con haz (+LM) | Rápido, solo inglés |
| RNNT | `ParakeetRNNT` | LSTM autorregresivo | Capaz de transmisión |
| TDT | `ParakeetTDT` | LSTM + predicción de duración, voraz o búsqueda con haz (+LM) | Mejor precisión que RNNT |
| TDT-CTC | `ParakeetTDTCTC` | Cabezas TDT y CTC | Cambiar decodificador en inferencia |

### Modelos de Streaming

Construidos sobre un codificador FastConformer de streaming con caché, convoluciones causales y atención con contexto limitado:

| Modelo | Clase | Decodificador | Caso de uso |
|--------|-------|---------------|-------------|
| EOU | `ParakeetEOU` | RNNT en streaming | Detección de fin de enunciado |
| Nemotron | `ParakeetNemotron` | TDT en streaming | Streaming con latencia configurable |

### Diarización

| Modelo | Clase | Arquitectura | Caso de uso |
|--------|-------|--------------|-------------|
| Sortformer | `Sortformer` | Codificador NEST → Transformer → sigmoide | Diarización de hablantes (hasta 4 hablantes) |

## Benchmarks

Medido en Apple M3 16GB con entrada de audio simulada (`Tensor::randn`). Los tiempos son por paso de avance del codificador (Sortformer: paso completo).

**Rendimiento del codificador — audio de 10s:**

| Modelo | Parámetros | CPU (ms) | GPU (ms) | Aceleración GPU |
|--------|------------|----------|----------|-----------------|
| 110m (TDT-CTC) | 110M | 2,581 | 27 | **96x** |
| tdt-600m | 600M | 10,779 | 520 | **21x** |
| rnnt-600m | 600M | 10,648 | 1,468 | **7x** |
| sortformer | 117M | 3,195 | 479 | **7x** |

**Escalado de GPU de 110m a través de duraciones de audio:**

| Audio | CPU (ms) | GPU (ms) | RTF | Rendimiento |
|-------|----------|----------|-----|-------------|
| 1s | 262 | 24 | 0.024 | 41x |
| 5s | 1,222 | 26 | 0.005 | 190x |
| 10s | 2,581 | 27 | 0.003 | 370x |
| 30s | 10,061 | 32 | 0.001 | 935x |
| 60s | 26,559 | 72 | 0.001 | 833x |

Aceleración GPU impulsada por el compilador de gráficos Metal de axiom, que fusiona el codificador completo en operaciones MPSGraph optimizadas.

```bash
make bench ARGS="--110m=models/model.safetensors --tdt-600m=models/tdt.safetensors"
```
## Hoja de ruta

### Nivel 1 — Alto Impacto

- [x] **Puntuaciones de confianza** — Confianza por token y por palabra a partir de log-probs de tokens  
- [x] **Impulso de frases** — Sesgo de contexto en trie a nivel de token durante la decodificación  
- [x] **Búsqueda en haz** — Búsqueda en haz de prefijo CTC y búsqueda en haz síncrona en tiempo TDT  
- [x] **Fusión de LM N-gram** — Modelos de lenguaje ARPA evaluados en límites de palabra  

### Audio & E/S

- [x] **Audio multi-formato** — WAV, FLAC, MP3, OGG vía dr_libs + stb_vorbis  
- [x] **Remuestreo automático** — Interpolación sinc con ventana (Kaiser, 16-taps)  
- [x] **Carga desde memoria** — `read_audio(bytes, len)`, buffers float/int16  
- [ ] **Consulta duración audio** — Duración solo cabecera sin decodificación completa  
- [ ] **Callbacks de progreso** — Reporte de etapas para archivos largos  
- [ ] **Streaming desde PCM bruto** — Alimentación directa de buffer de micrófono  

### Nivel 2 — Preparación para Producción

- [x] **Transcripción diarizada** — ASR + Sortformer → palabras atribuidas a oradores  
- [x] **VAD** — Silero VAD v5, independiente + preprocesamiento ASR  
- [x] **Inferencia por lotes** — Paso hacia adelante codificador multi-archivo con padding  
- [ ] **Segmentación para audio largo** — Ventanas solapadas para audio >30s  
- [ ] **Reevaluación con LM neuronal** — Reordenamiento N-mejores con LM Transformer  

### Nivel 3 — Ecosistema

- [x] **API C** — Interfaz C plana para FFI desde cualquier lenguaje  
- [x] **Inferencia FP16** — Pesos y cómputo en media precisión  
- [ ] **Cuantización de modelo** — INT8/INT4 para despliegue móvil  
- [ ] **Detección de palabras clave** — Detección de frase disparadora  
- [ ] **Embeddings de orador** — Verificación de orador desde Sortformer/TitaNet  

## Notas

- Audio: 16kHz mono (WAV, FLAC, MP3, OGG — auto-detectados y remuestreados)  
- Modelos offline tienen límites de longitud de audio de ~4-5 minutos; usar modelos streaming para audio más largo  
- Aceleración GPU requiere Apple Silicon con soporte Metal


## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---