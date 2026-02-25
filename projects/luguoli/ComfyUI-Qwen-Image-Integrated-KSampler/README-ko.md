# 🐋 Qwen 이미지 통합 KSampler

[![GitHub](https://img.shields.io/badge/GitHub-luguoli-orange)](https://github.com/luguoli)
[![ComfyUI](https://img.shields.io/badge/ComfyUI-CustomNode-blue)](https://github.com/comfyanonymous/ComfyUI)

[English](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-en.md) | **[简体中文](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-zh.md)**

QwenImageIntegratedKSampler

이것은 ComfyUI Qwen-Image 이미지 생성 샘플러 노드의 통합 버전으로, Z-Image를 지원합니다. 공식 KSampler 사용과 비교하여 복잡한 배선을 없애고, 텍스트-이미지 및 이미지-이미지 생성을 모두 지원하며, 공식 노드의 오프셋 문제를 해결하고, 프롬프트 입력 상자 통합, 자동 이미지 크기 조정, 자동 메모리/VRAM 정리, 배치 생성, 자동 저장 등 포괄적인 최적화 기능을 통합하여 엄마가 내 복잡한 배선 걱정을 더 이상 하지 않도록 했습니다~~~~

#### 이 프로젝트가 도움이 되셨다면, ⭐Star를 눌러주세요 — 사용자가 있음을 알 수 있습니다!

## 🏆 기능

### 🎨 지원 생성 모드
- **Z-Image**: Z-Image 모델 지원
- **텍스트-이미지**: 텍스트 프롬프트로부터 이미지 생성
- **이미지-이미지**: 참조 이미지를 기반으로 생성, 이미지 편집, 최대 5장 이미지 지원

### ⚡ 고급 최적화
- **오프셋 문제 최적화**: 공식 노드의 오프셋 문제 해결, 명령어 준수 향상
- **통합 샘플링 알고리즘 (AuraFlow)**: 샘플링 알고리즘 (AuraFlow) 노드 통합, 추가 배선 불필요
- **CFGNorm 통합**: CFGNorm 노드 통합, 추가 배선 불필요

### 🖼️ 이미지 처리
- **통합 프롬프트 입력 상자**: 프롬프트 입력 상자 통합, 추가 배선 불필요
- **다중 참조 이미지**: 조건 생성용 최대 5장 참조 이미지 지원
- **자동 이미지 크기 조정**: 목표 치수에 맞춰 종횡비 유지하며 크기 조정

- **ControlNet 제어 지원**: 포즈, 깊이 등 제어를 위한 [🐋 Qwen ControlNet 통합 로더] 추가 연결 지원

### 🔧 생산성 향상
- **배치 생성**: 한 번에 여러 이미지 생성
- **자동 VRAM 정리**: GPU/VRAM 메모리 자동 정리 옵션
- **자동 RAM 정리**: RAM 메모리 자동 정리 옵션
- **자동 결과 저장**: 생성된 결과 이미지 자동 지정 폴더 저장
- **완료 음성 알림**: 생성 완료 후 음성 알림 재생

## 🍧 비교 표시
### 🔄 워크플로우 복잡도 비교
- **❌ [Qwen Image Integrated KSampler] 미사용 워크플로우 (복잡함, 노드 및 와이어 과다)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-1-en.png)
- **✅ [Qwen Image Integrated KSampler] 사용 워크플로우 (매우 간단, 단일 노드 완료, 거의 와이어 없음)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-2-en.png)

### 🖼️ 생성된 이미지 효과 비교
- **❌ [Qwen Image Integrated KSampler] 미사용 워크플로우 (명백한 오프셋, 스케일링)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-1.png)
- **✅ [Qwen Image Integrated KSampler] 사용 워크플로우 (완전한 무 오프셋, 스케일링)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-2.png)

## 📦 설치 방법

### 방법 1: ComfyUI 매니저를 통한 설치 (추천)
1. ComfyUI 인터페이스에서 ComfyUI 매니저를 엽니다
2. "ComfyUI-Qwen-Image-Integrated-KSampler"를 검색합니다
3. 설치를 클릭합니다

### 방법 2: 수동 설치
1. ComfyUI 사용자 정의 노드 디렉터리로 이동합니다:
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   ```
2. 저장소를 복제합니다:

   ```bash
   git clone https://github.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   or gitee repository:
   git clone https://gitee.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   ```

3. 종속성 설치:
   ```bash
   pip install -r requirements.txt
   ```
4. ComfyUI 재시작

## 🚀 사용 방법

### [워크플로우 예제](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/workflow_example.json)

### 기본 텍스트-투-이미지 생성

1. 워크플로우에 "🐋 Qwen Image Integrated KSampler" 노드 추가
2. `generation_mode`를 "text-to-image"로 설정
3. 필수 입력 연결:
   - 모델 (🤖 Model)
   - CLIP (🟡 Clip)
   - VAE (🎨 Vae)
4. 긍정 및 부정 프롬프트 입력
5. 너비 및 높이 설정 (텍스트-투-이미지에 필요)
6. 샘플링 매개변수 설정 (스텝, CFG, 샘플러, 스케줄러)
7. 워크플로우 실행

### 이미지-투-이미지 생성

1. 워크플로우에 노드 추가
2. `generation_mode`를 "image-to-image"로 설정
3. 최소 한 개의 참조 이미지 연결 (🖼️ Image1)
4. 선택적으로 최대 4개의 추가 참조 이미지 추가
5. 긍정/부정 프롬프트 및 지시사항 입력
6. 스케일링을 위한 목표 너비/높이 설정 (선택 사항)
7. 필요에 따라 기타 매개변수 설정
8. 워크플로우 실행

### ControlNet 제어

1. [🐋 Qwen ControlNet Integrated Loader] 노드 추가, [📦 ControlNet Data]에 연결

2. 포즈, 깊이 제어 이미지 연결

3. ControlNet 모델 선택, 제어 유형 및 강도 설정

4. 워크플로우 실행

![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/3-en.png)

### 고급 기능

- **메모리 관리**: GPU/CPU 정리 옵션을 활성화하여 자원 효율성 향상
- **배치 처리**: batch_size > 1 설정 시 다중 이미지 생성 가능
- **자동 저장**: 출력 폴더 지정 시 자동 저장 기능 활성화
- **AuraFlow 조정**: auraflow_shift 값을 조절하여 속도와 품질 균형 맞춤
- **CFG 향상**: CFG 안정화 기능 제공

## ⚠️ 주의사항

### 📝 사용 요구사항
- **텍스트-이미지 모드**: 너비(Width)와 높이(Height)를 반드시 설정해야 하며, 필수 매개변수임
- **이미지-이미지 모드**: 최소 1개의 참조 이미지(Image1)를 제공해야 하며, 최대 5개 참조 이미지(Image1-Image5) 지원

### 🎛️ 매개변수 설정 권장사항
- **배치 크기**: 1-10 사이 선택, GPU 메모리에 따라 조정, 테스트는 1부터 시작 권장
- **해상도(너비/높이)**: 8의 배수여야 하며, 범위는 0-16384, 낮은 해상도(예: 512x512)부터 테스트 권장
- **샘플링 단계**: Qwen 모델은 4-20단계 권장, 너무 높으면 계산 시간이 길어지지만 품질 향상과는 무관
- **CFG 값**: 0-100 범위, 기본값 1.0, 1.0-7.0 범위 권장
- **노이즈 제거 강도**: 0-1 범위, 기본값 1.0, 이미지-이미지 모드에서는 적절히 낮출 수 있음
- **AuraFlow Shift**: 0-100 범위, 기본값 3.0, 생성 속도와 품질 균형 조절용
- **CFG 정규화 강도**: 0-100 범위, 기본값 1.0, CFG 안정화용

### 🔧 이미지 처리
- **자동 스케일링**: 텍스트-이미지 모드에서는 너비와 높이 입력 필수, 이미지-이미지 모드는 참조 이미지 비율 유지하며 자동 스케일링, 너비 또는 높이를 0으로 설정하면 스케일링 비활성화
- **참조 이미지 순서**: 최대 5개 참조 이미지 지원, Image1-Image5 순서로 처리, Image1이 주 이미지
- **이미지 형식**: 표준 이미지 입력 형식 지원, 배치 차원 자동 처리

### 💾 메모리 관리
- **GPU 메모리 정리**: enable_clean_gpu_memory 옵션 활성화 시 생성 전후 VRAM 자동 정리
- **CPU 메모리 정리**: enable_clean_cpu_memory_after_finish 옵션 활성화 시 생성 완료 후 RAM 정리 (파일 캐시, 프로세스, 동적 라이브러리 포함)
- 대규모 연속 생성 시 메모리 오버플로우 방지를 위해 항상 메모리 정리 옵션 활성화 권장

### 💾 자동 저장
- **출력 폴더**: auto_save_output_folder 설정 시 자동 저장 기능 활성화, 비워두면 비활성, 절대경로 및 상대경로 지원
- **파일명 지정**: output_filename_prefix 사용자 지정 접두사, 기본값 "auto_save"
- 저장 형식은 PNG이며, 파일명에 시드와 배치 번호 포함 (예: auto_save_123456_00000.png)

### 🔊 알림 기능
- **사운드 알림**: 윈도우 시스템에서만 지원됨

## 📝 업데이트 기록
### v1.0.6:
- **로컬라이제이션 스크립트 추가:** ComfyUI v0.3.68부터 중국어 언어 파일이 무효화됨. 자동 로컬라이제이션 스크립트 추가, [自动汉化节点.bat]를 더블 클릭하고 ComfyUI를 재시작하세요, ComfyUI-DD-Translation 플러그인 설치 필요


## 📞 특수 맞춤 문의 📞
- 작성자: @luguoli（벽에 붙은 해바라기）
- 작성자 이메일: luguoli@vip.qq.com


---

**ComfyUI 커뮤니티를 위해 ❤️로 제작됨**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---