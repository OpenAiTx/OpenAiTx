# parakeet.cpp

NVIDIA의 [Parakeet](https://huggingface.co/collections/nvidia/parakeet) 모델을 이용한 순수 C++ 기반의 빠른 음성 인식.

[axiom](https://github.com/frikallo/axiom) 위에 구축 — 자동 Metal GPU 가속을 지원하는 경량 텐서 라이브러리. ONNX 런타임 없음, Python 런타임 없음, 무거운 의존성 없음. 오직 C++와 PyTorch MPS보다 빠른 하나의 텐서 라이브러리만 사용.

**Apple Silicon GPU에서 10초 음성에 대해 약 27ms 인코더 추론** (110M 모델) — CPU보다 96배 빠름. FP16 지원으로 메모리 사용량 약 2배 절감.

## 지원 모델

| 모델 | 클래스 | 크기 | 유형 | 설명 |
|-------|-------|------|------|-------------|
| `tdt-ctc-110m` | `ParakeetTDTCTC` | 110M | 오프라인 | 영어, 이중 CTC/TDT 디코더 헤드 |
| `tdt-600m` | `ParakeetTDT` | 600M | 오프라인 | 다국어, TDT 디코더 |
| `eou-120m` | `ParakeetEOU` | 120M | 스트리밍 | 영어, 발화 종료 감지 기능이 있는 RNNT |
| `nemotron-600m` | `ParakeetNemotron` | 600M | 스트리밍 | 다국어, 조정 가능한 지연 시간 (80ms–1120ms) |
| `sortformer` | `Sortformer` | 117M | 스트리밍 | 화자 분리 (최대 4명) |
| `diarized` | `DiarizedTranscriber` | 110M+117M | 오프라인 | ASR + 분리 → 화자별 단어 |

모든 ASR 모델은 동일한 오디오 파이프라인을 공유: 16kHz 모노 WAV → 80-빈 멜 스펙트로그램 → FastConformer 인코더.

## 빠른 시작

```cpp
#include <parakeet/parakeet.hpp>

parakeet::Transcriber t("model.safetensors", "vocab.txt");
t.to_gpu();   // optional — Metal acceleration
t.to_half();  // optional — FP16 inference (~2x memory reduction)

auto result = t.transcribe("audio.wav");
std::cout << result.text << std::endl;
```
## 기능

- **다중 디코더** — CTC 그리디, TDT 그리디, CTC 빔 서치, TDT 빔 서치 (호출 지점에서 전환)
- **단어 타임스탬프** — 모든 디코더에서 단어별 시작/종료 시간 및 신뢰도 점수 제공
- **빔 서치 + 언어 모델** — 선택적 ARPA n-그램 언어 모델 융합을 지원하는 CTC 및 TDT 빔 서치
- **문구 부스팅** — 도메인별 어휘를 위한 토큰 레벨 트라이를 통한 컨텍스트 바이어싱
- **배치 전사** — 한 번의 배치 인코더 전방 패스로 다중 파일 처리
- **VAD 전처리** — Silero VAD가 ASR 전 음성 구간 무음 제거; 타임스탬프 자동 재매핑
- **GPU 가속** — axiom의 MPSGraph 컴파일러를 통한 Metal 지원 (Apple Silicon에서 96배 속도 향상)
- **FP16 추론** — 하프 정밀도 가중치 및 연산 (~2배 메모리 절감)
- **스트리밍** — 청크 오디오 입력을 지원하는 EOU 및 Nemotron 모델
- **화자 분리** — Sortformer (최대 4명 화자), ASR과 결합하여 화자 별 단어 제공 가능
- **C API** — Python, Swift, Go, Rust 등 다양한 언어를 위한 Flat `extern "C"` FFI
- **다중 포맷 오디오** — WAV, FLAC, MP3, OGG 자동 리샘플링 지원

각 기능을 보여주는 코드는 [examples/](examples/)를 참조하세요.

## 설치

사전 빌드된 바이너리는 macOS arm64, macOS x86_64, Linux x86_64용으로 각 [GitHub 릴리스](https://github.com/Frikallo/parakeet.cpp/releases)에 첨부되어 있습니다. 플랫폼에 맞는 tarball을 다운로드하여 압축을 해제하세요:


```bash
tar -xzf parakeet-v0.1.0-macos-arm64.tar.gz
cd parakeet-v0.1.0-macos-arm64
# On macOS, clear the Gatekeeper quarantine attribute first:
xattr -dr com.apple.quarantine .
./bin/parakeet --help
```
아카이브는 자체 포함된 `bin/parakeet` (및 `bin/example-server`)과 `lib/libaxiom`을 제공하며, `@rpath`/`$ORIGIN`이 설정되어 있어 이진 파일들이 설치 디렉토리를 기준으로 의존성을 해결합니다 — 디렉토리를 어디에나 놓을 수 있습니다. 임베더를 위해 `include/parakeet/` 아래에 C-API 헤더가 포함되어 있습니다.

## 소스에서 빌드하기


```bash
git clone --recursive https://github.com/frikallo/parakeet.cpp
cd parakeet.cpp
make build
make test
```
요구사항: C++20 (Clang 14+ 또는 GCC 12+), CMake 3.20+, Metal GPU용 macOS 13+.

> **macOS:** 빌드하려면 **전체 Xcode** 설치가 필요합니다 (Command Line Tools만으로는 안 됩니다). axiom은 Metal 셰이더를 `xcrun metal`과 `xcrun metallib`로 컴파일하는데, 이 도구들은 Xcode에만 포함되어 있습니다. parakeet만 실행하려면 위에 있는 미리 빌드된 tarball을 사용하세요; `.metallib`는 제공된 `libaxiom.dylib`에 포함되어 있어 사용자 측에서 Xcode/CLT 설치 없이 실행됩니다.

## 가중치 변환하기


```bash
# Download from HuggingFace
huggingface-cli download nvidia/parakeet-tdt_ctc-110m --include "*.nemo" --local-dir .

# Convert to safetensors
pip install safetensors torch
python scripts/convert_nemo.py parakeet-tdt_ctc-110m.nemo -o model.safetensors
```
컨버터는 모든 모델 유형을 지원합니다: `110m-tdt-ctc` (기본값), `600m-tdt`, `eou-120m`, `nemotron-600m`, `sortformer`.


```bash
python scripts/convert_nemo.py checkpoint.nemo -o model.safetensors --model 600m-tdt
```

실레로 VAD 가중치:
```bash
python scripts/convert_silero_vad.py -o silero_vad_v5.safetensors
```
## Examples

| Example | Description |
|---------|-------------|
| [basic](examples/basic/) | 가장 간단한 전사 (~20줄) |
| [timestamps](examples/timestamps/) | 단어/토큰 타임스탬프 및 신뢰도 |
| [beam-search](examples/beam-search/) | 선택적 ARPA LM과 함께하는 CTC/TDT 빔 서치 |
| [phrase-boost](examples/phrase-boost/) | 도메인 어휘를 위한 문구 편향 |
| [batch](examples/batch/) | 여러 파일 일괄 전사 |
| [vad](examples/vad/) | 독립형 VAD 및 ASR+VAD 전처리 |
| [gpu](examples/gpu/) | Metal GPU + FP16 및 시간 비교 |
| [stream](examples/stream/) | EOU 스트리밍 전사 |
| [nemotron](examples/nemotron/) | 지연 모드가 있는 Nemotron 스트리밍 |
| [diarize](examples/diarize/) | Sortformer 화자 분리 |
| [diarized-transcription](examples/diarized-transcription/) | ASR + 화자 분리 결합 |
| [c-api](examples/c-api/) | 순수 C99 FFI 사용법 |
| [cli](examples/cli/) | 모든 옵션 포함 전체 CLI |

## 라이브러리로 사용하기

### CMake `find_package`

설치 후 (`make install` 또는 `cmake --install build`):


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
## 아키텍처

### 오프라인 모델

공유 FastConformer 인코더(Conv2d 8배 다운샘플링 → 상대 위치 인식 주의가 적용된 N개의 Conformer 블록)를 기반으로 구축:

| 모델 | 클래스 | 디코더 | 사용 사례 |
|-------|-------|---------|----------|
| CTC | `ParakeetCTC` | 탐욕적 argmax 또는 빔 서치 (+LM) | 빠름, 영어 전용 |
| RNNT | `ParakeetRNNT` | 자동회귀 LSTM | 스트리밍 가능 |
| TDT | `ParakeetTDT` | LSTM + 지속 시간 예측, 탐욕적 또는 빔 서치 (+LM) | RNNT보다 높은 정확도 |
| TDT-CTC | `ParakeetTDTCTC` | TDT와 CTC 헤드 모두 | 추론 시 디코더 전환 |

### 스트리밍 모델

인과적 합성곱과 제한된 문맥 주의가 적용된 캐시 인식 스트리밍 FastConformer 인코더 기반:

| 모델 | 클래스 | 디코더 | 사용 사례 |
|-------|-------|---------|----------|
| EOU | `ParakeetEOU` | 스트리밍 RNNT | 발화 종료 감지 |
| Nemotron | `ParakeetNemotron` | 스트리밍 TDT | 구성 가능한 지연 시간 스트리밍 |

### 화자 분리

| 모델 | 클래스 | 아키텍처 | 사용 사례 |
|-------|-------|-------------|----------|
| Sortformer | `Sortformer` | NEST 인코더 → Transformer → 시그모이드 | 화자 분리 (최대 4명) |

## 벤치마크

Apple M3 16GB에서 시뮬레이션된 오디오 입력(`Tensor::randn`)을 사용하여 측정. 시간은 인코더 한 번 전방향 통과 기준(Sortformer: 전체 전방향 통과).

**인코더 처리량 — 10초 오디오:**

| 모델 | 파라미터 | CPU (ms) | GPU (ms) | GPU 가속비 |
|-------|--------|----------|----------|-------------|
| 110m (TDT-CTC) | 110M | 2,581 | 27 | **96배** |
| tdt-600m | 600M | 10,779 | 520 | **21배** |
| rnnt-600m | 600M | 10,648 | 1,468 | **7배** |

| sortformer | 117M | 3,195 | 479 | **7배** |

**오디오 길이에 따른 110m GPU 확장성:**

| 오디오 | CPU (ms) | GPU (ms) | RTF | 처리량 |
|-------|----------|----------|-----|--------|
| 1초 | 262 | 24 | 0.024 | 41배 |
| 5초 | 1,222 | 26 | 0.005 | 190배 |
| 10초 | 2,581 | 27 | 0.003 | 370배 |
| 30초 | 10,061 | 32 | 0.001 | 935배 |
| 60초 | 26,559 | 72 | 0.001 | 833배 |

GPU 가속은 전체 인코더를 최적화된 MPSGraph 연산으로 융합하는 axiom의 Metal 그래프 컴파일러에 의해 구현됩니다.

```bash
make bench ARGS="--110m=models/model.safetensors --tdt-600m=models/tdt.safetensors"
```
## 로드맵

### 1단계 — 높은 영향력

- [x] **신뢰도 점수** — 토큰 로그 확률에서 토큰별 및 단어별 신뢰도
- [x] **구문 부스팅** — 디코딩 중 토큰 수준 트라이 컨텍스트 바이어싱
- [x] **빔 서치** — CTC 접두사 빔 서치 및 TDT 시간 동기 빔 서치
- [x] **N-그램 LM 융합** — 단어 경계에서 점수화된 ARPA 언어 모델

### 오디오 및 입출력

- [x] **다중 포맷 오디오** — dr_libs + stb_vorbis를 통한 WAV, FLAC, MP3, OGG 지원
- [x] **자동 리샘플링** — 창 함수 싱크 보간법 (Kaiser, 16탭)
- [x] **메모리에서 로드** — `read_audio(bytes, len)`, float/int16 버퍼
- [ ] **오디오 길이 조회** — 전체 디코딩 없이 헤더만으로 길이 확인
- [ ] **진행 콜백** — 긴 파일에 대한 단계별 보고
- [ ] **원시 PCM 스트리밍** — 마이크 버퍼 직접 공급

### 2단계 — 생산 준비

- [x] **화자 분리 전사** — ASR + Sortformer → 화자 구분 단어
- [x] **VAD** — Silero VAD v5, 독립형 + ASR 전처리
- [x] **배치 추론** — 패딩된 다중 파일 인코더 순방향
- [ ] **장기 오디오 분할** — 30초 이상 오디오를 위한 겹치는 창
- [ ] **신경망 LM 재점수화** — Transformer LM을 이용한 N-베스트 재순위화

### 3단계 — 생태계

- [x] **C API** — 모든 언어에서 FFI를 위한 평면 C 인터페이스
- [x] **FP16 추론** — 반정밀도 가중치 및 연산
- [ ] **모델 양자화** — 모바일 배포를 위한 INT8/INT4
- [ ] **핫워드 감지** — 트리거 구문 감지
- [ ] **화자 임베딩** — Sortformer/TitaNet을 이용한 화자 검증

## 참고 사항

- 오디오: 16kHz 모노 (WAV, FLAC, MP3, OGG — 자동 감지 및 리샘플링)
- 오프라인 모델은 약 4-5분 길이 제한; 더 긴 오디오에는 스트리밍 모델 사용
- GPU 가속은 Metal 지원 Apple Silicon 필요


## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-20

---