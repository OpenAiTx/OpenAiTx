# PhotonInfer

<div align="center">

**vLLM 스타일의 연속 배칭을 지원하는 고성능 LLM 추론 엔진**

[English](https://raw.githubusercontent.com/lumia431/photon_infer/master/README.md) | [中文](https://raw.githubusercontent.com/lumia431/photon_infer/master/README_ZH.md) | [Live Demo](https://photoninfer.xyz/)

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)
[![CUDA](https://img.shields.io/badge/CUDA-12.0+-green.svg)](https://developer.nvidia.com/cuda-toolkit)
[![C++20](https://img.shields.io/badge/C++-20-orange.svg)](https://en.cppreference.com/w/cpp/20)

</div>

---

## 🚀 성능 하이라이트

PhotonInfer는 고급 배칭 기능을 갖춘 **생산 수준의 LLM 추론 성능**을 제공합니다. **Llama-3.2 및 Qwen3 모델을 지원**합니다.

### 단일 요청 추론

| 모델 | PhotonInfer | llama.cpp | 속도 향상 |
|-------|-------------|-----------|---------|
| Llama 3.2 1B | 185 토큰/초 | 252 토큰/초 | 0.73× (llama.cpp가 더 빠름) |

**TTFT (첫 토큰까지 시간)**: 387ms @ 100토큰 프롬프트 (INT8 양자화)

### 배치 추론 처리량

| 배치 크기 | PhotonInfer | llama.cpp | 속도 향상 |
|------------|-------------|-----------|---------|
| 4          | 410 토큰/초 | 252 토큰/초 | **1.63×** |
| 8          | 720 토큰/초 | 255 토큰/초 | **2.82×** |
| 16         | 787 토큰/초 | 253 토큰/초 | **3.07×** |

**테스트 환경**: NVIDIA A100, Llama 3.2 1B, Q8/INT8 양자화

## ✨ 주요 기능

### 🎯 **vLLM 스타일 연속 배치 처리**
- **토큰 단위 동적 스케줄링**: 배치 완료를 기다리지 않고 생성 중간에 새 요청 추가
- **2단계 스케줄러**: 새 요청 수락과 동시에 실행 중인 요청 원활하게 계속 처리
- **요청 상태 추적**: 효율적인 재개를 위한 정확한 `num_computed_tokens` 관리
- **실서비스에 최적**: 실시간 반응성을 갖춘 고동시성 추론 서비스

### ⚡ **GPU 최적화 커널**
- **배치 처리된 페이징 어텐션**: 효율적인 메모리 활용을 위한 블록 단위 KV 캐시 관리
- **벡터화된 메모리 접근**: 2-4배 대역폭 효율의 `float4` 로드
- **퓨즈드 연산**: 제로 카피 GPU 샘플링, 배치 RoPE, 퓨즈드 정규화
- **INT8 양자화**: cuBLASLt INT8 GEMM 지원 그룹 단위 양자화
- **최적화된 소프트맥스**: 수치 안정적 어텐션 계산을 위한 CUB BlockReduce

### 🏗️ **모던 C++20 아키텍처**
- **타입 안전 오류 처리**: 명시적 오류 전파를 위한 Rust 영감 `Result<T, E>` 타입
- **제로 카피 설계**: `std::span`과 이동 시맨틱 광범위 사용
- **디바이스 무관**: CPU와 CUDA 백엔드 통합 인터페이스
- **컨셉트 & 레인지**: 컴파일 타임 제약과 표현력 높은 타입 안전성

## 🚀 빠른 시작

### 전제 조건

- **컴파일러**: GCC 12 이상 (C++20 지원 필수)
- **CMake**: 3.20 이상
- **CUDA 툴킷**: 12.0 이상 (12.5에서 테스트됨)
- **GPU**: Compute Capability 7.0 이상 NVIDIA GPU

### 모델 다운로드

빠른 시작을 위해 사전 양자화된 모델 다운로드:

https://huggingface.co/Lummy666/llama-3.2-1B-Instruct

### 빌드

#### 옵션 1: 소스에서 빌드하기

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
설치 후에는 어디에서나 웹 서버를 직접 실행할 수 있습니다:


```bash
photon_web_server \
    --port 5728 \
    --model /path/to/llama-3.2-1B-Instruct \
    --tokenizer /path/to/llama-3.2-1B-Instruct/tokenizer.json
```
설치는 다음 위치에 파일을 배치합니다:
- `photon_web_server` → `/usr/local/bin/`
- 정적 웹 파일 → `/photon_infer/web/static/`
- 핵심 라이브러리 → `/usr/local/lib/`

제거하려면:

```bash
cd build
sudo cmake --build . --target uninstall
```
#### 옵션 2: 도커 사용 (권장)


```bash
# Pull the pre-built Docker image
docker pull lumia431/photon_infer:latest

# Run the container with GPU support
docker run --rm --gpus all -p 5728:5728 -e PORT=5728 lumia431/photon_infer:latest
```
웹 인터페이스는 `http://localhost:5728` 에서 이용 가능합니다.

## 🔬 기술 세부사항

### INT8 양자화
- **그룹별 양자화**: 구성 가능한 그룹 크기 (32, 64, 128)
- **cuBLASLt 통합**: 하드웨어 가속 INT8 GEMM
- **최소 정확도 손실**: Llama 모델에서 < 1% 혼란도 저하

### 페이징된 어텐션
- **블록 단위 KV 캐시**: 단편화 없는 효율적인 메모리 할당
- **동적 시퀀스 관리**: 유연한 스케줄링을 위한 시퀀스별 캐시 오프셋
- **배치된 캐시 작업**: 다중 시퀀스 K/V 쓰기를 위한 단일 커널

### 연속 배치 스케줄러
- **2단계 스케줄링**:
  1. **1단계**: 모든 RUNNING 요청 계속 수행 (중단 없음)
  2. **2단계**: 남은 용량을 채우기 위해 WAITING 요청 승인
- **요청 상태**: WAITING → RUNNING → FINISHED (PREEMPTED 지원 포함)
- **토큰 단위 세분화**: 정확한 재개를 위한 `num_computed_tokens` 추적

## 🛣️ 로드맵

- [x] **핵심 인프라**: 텐서, 연산자, 메모리 관리
- [x] **LLaMA 모델**: CPU/GPU 커널을 포함한 완전한 트랜스포머 구현
- [x] **INT8 양자화**: cuBLASLt를 이용한 그룹별 양자화
- [x] **페이징된 어텐션**: 블록 단위 KV 캐시 관리
- [x] **연속 배치**: vLLM 스타일 동적 요청 스케줄링
- [ ] **Flash Attention 2**: 긴 시퀀스를 위한 IO 인식 어텐션
- [ ] **멀티 GPU 지원**: 대형 모델을 위한 텐서 병렬처리
- [ ] **FP16/BF16 혼합 정밀도**: 최신 GPU에서 처리량 향상
- [ ] **추측적 디코딩**: 초안 모델을 이용한 다중 토큰 생성

## 📖 문서

- [연속 배치 설계](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/continuous_batching.md)
- [성능 최적화 가이드](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/performance.md)
- [API 참조](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/api.md)


## 🤝 기여

기여를 환영합니다! 가이드라인은 [CONTRIBUTING.md](https://raw.githubusercontent.com/lumia431/photon_infer/master/docs/contributing.md)에서 확인하세요.

## 📝 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.

## 🙏 감사의 말

- 아키텍처는 [vLLM](https://github.com/vllm-project/vllm)에서 영감을 받았습니다.
- 커널 최적화는 [llama.cpp](https://github.com/ggerganov/llama.cpp)를 참고했습니다.
- 에러 처리 설계는 Rust의 `Result<T, E>`에서 차용했습니다.

---

**고성능 LLM 추론을 위해 ❤️와 함께 제작되었습니다**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-22

---