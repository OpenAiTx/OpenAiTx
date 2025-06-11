# 실시간 방사장 렌더링을 위한 3D 가우시안 스플래팅 - C++ 및 CUDA 구현

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

[gsplat](https://github.com/nerfstudio-project/gsplat) 래스터라이제이션 백엔드를 기반으로 한 고성능 C++ 및 CUDA 3D 가우시안 스플래팅 구현입니다.

## 뉴스
- **[2025-06-10]**: 일부 문제 수정. gsplat 메트릭과의 격차를 줄이고 있습니다. 다만 아직 약간의 불일치가 존재합니다.
- **[2025-06-04]**: 최대 가우시안 개수 제어를 위한 `--max-cap` 명령줄 옵션과 함께 MCMC 전략 추가.
- **[2025-06-03]**: Gsplat 백엔드로 전환 및 라이선스 업데이트.
- **[2024-05-27]**: 향상된 호환성과 성능을 위해 LibTorch 2.7.0으로 업데이트. 옵티마이저 상태 관리 관련 파괴적 변경사항 해결.
- **[2024-05-26]**: 현재 이 저장소의 목표는 관대 라이선스로 전환하는 것입니다. 래스터라이저를 gsplat 구현으로 대체하는 주요 작업이 완료되었습니다.

## 메트릭
현재 구현은 gsplat-mcmc와 동등한 결과를 내지 못하지만, 진행 중인 작업입니다.  
버그 수정은 시간 문제이며, 도움을 환영합니다 :) mcmc 전략 메트릭은 다음과 같습니다:

| 장면      | 반복      | PSNR          | SSIM         | LPIPS        | 이미지당 시간 | 가우시안 수  |
| --------- | --------- | ------------- | ------------ | ------------ | ------------- | ------------ |
| garden    | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765      | 1000000      |
| bicycle   | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618      | 1000000      |
| stump     | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536      | 1000000      |
| bonsai    | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188      | 1000000      |
| counter   | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259      | 1000000      |
| kitchen   | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078      | 1000000      |
| room      | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519      | 1000000      |
| **평균**  | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**  | **1000000**  |

## 커뮤니티 및 지원

커뮤니티에 참여하여 토론, 지원, 업데이트를 받아보세요:  
- 💬 **[Discord 커뮤니티](https://discord.gg/TbxJST2BbC)** - 도움받기, 결과 공유, 개발 토론  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - 추가 자료 확인  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - 종합 논문 리스트 및 자료  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - 최신 업데이트 팔로우

## 빌드 및 실행 안내

### 소프트웨어 요구사항
1. **Linux** (Ubuntu 22.04에서 테스트됨) - 현재 Windows는 지원하지 않음  
2. **CMake** 3.24 이상  
3. **CUDA** 11.8 이상 (낮은 버전도 수동 구성 시 작동 가능)  
4. **Python** 개발 헤더 포함  
5. **LibTorch 2.7.0** - 설치 방법 아래 참조  
6. 기타 의존성은 CMake가 자동 처리

### 하드웨어 요구사항
1. **CUDA 지원 NVIDIA GPU**  
    - 성공적으로 테스트된 GPU: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - RTX 3080Ti는 큰 데이터셋에서 알려진 문제 있음 (#21 참고)  
2. 최소 컴퓨트 능력: 8.0

> 다른 하드웨어에서 성공적으로 실행한 경우, 토론 섹션에 경험을 공유해 주세요!

### 빌드 방법

```bash
# 하위 모듈 포함 저장소 클론
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# LibTorch 다운로드 및 설정
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# 프로젝트 빌드
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

이 프로젝트는 최적의 성능과 호환성을 위해 **LibTorch 2.7.0**을 사용합니다:

- **성능 향상**: 최적화 및 메모리 관리 개선  
- **API 안정성**: 최신 안정화된 PyTorch C++ API  
- **CUDA 호환성**: CUDA 11.8 이상과의 더 나은 통합  
- **버그 수정**: 옵티마이저 상태 관리 문제 해결

### 이전 버전에서 업그레이드 방법
1. 빌드 지침에 따라 새 LibTorch 버전 다운로드  
2. 빌드 디렉토리 정리: `rm -rf build/`  
3. 프로젝트 재빌드

## 데이터셋

원본 저장소에서 데이터셋 다운로드:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

프로젝트 루트의 `data` 폴더에 압축 해제하세요.

## 명령줄 옵션

### 기본 옵션

- **`-h, --help`**  
  도움말 메뉴 표시

- **`-d, --data-path [경로]`**  
  학습 데이터 경로 (필수)

- **`-o, --output-path [경로]`**  
  학습된 모델 저장 경로 (기본값: `./output`)

- **`-i, --iter [숫자]`**  
  학습 반복 횟수 (기본값: 30000)  
    - 논문은 30k 권장, 6k-7k도 좋은 예비 결과 제공  
    - 출력은 7k마다 및 완료 시 저장

- **`-f, --force`**  
  기존 출력 폴더 덮어쓰기 강제

- **`-r, --resolution [숫자]`**  
  학습 이미지 해상도 설정

### MCMC 전용 옵션

- **`--max-cap [숫자]`**  
  MCMC 전략의 최대 가우시안 수 (기본값: 1000000)  
    - 학습 중 최대 가우시안 스플랫 수 제한  
    - 메모리 제한 환경에 유용

### 사용 예시

기본 학습:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

MCMC 가우시안 수 제한 학습:
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## 기여 가이드라인

기여를 환영합니다! 시작 방법은 다음과 같습니다:

1. **시작하기**:  
    - 초보자 친화적 작업은 **good first issues** 레이블이 붙은 이슈 확인  
    - 새로운 아이디어는 토론을 열거나 [Discord](https://discord.gg/TbxJST2BbC)에 참여

2. **PR 제출 전**:  
    - 일관된 코드 스타일을 위해 `clang-format` 적용  
    - pre-commit 훅 사용: `cp tools/pre-commit .git/hooks/`  
    - 새 의존성은 먼저 이슈로 논의 - 의존성 최소화 목표

## 감사의 말

이 구현은 여러 핵심 프로젝트를 기반으로 합니다:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: 고도로 최적화된 CUDA 래스터라이제이션 백엔드를 사용하여 성능 및 메모리 효율성 대폭 개선  
- **원본 3D 가우시안 스플래팅**: Kerbl 등 연구진의 혁신적인 작업 기반

## 인용

본 소프트웨어를 연구에 사용하셨다면 아래 논문을 인용해 주세요:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## 라이선스

자세한 내용은 LICENSE 파일을 참조하세요.

---

**연결하기:**  
- 🌐 웹사이트: [mrnerf.com](https://mrnerf.com)  
- 📚 논문: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [커뮤니티 참여](https://discord.gg/TbxJST2BbC)  
- 🐦 트위터: 개발 업데이트 팔로우 [@janusch_patas](https://twitter.com/janusch_patas)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---