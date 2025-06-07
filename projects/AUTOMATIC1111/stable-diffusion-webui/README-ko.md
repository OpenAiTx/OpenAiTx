# Stable Diffusion web UI
Gradio 라이브러리를 사용하여 구현된 Stable Diffusion용 웹 인터페이스입니다.

![](screenshot.png)

## 기능
[이미지와 함께 상세한 기능 소개](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- 원본 txt2img 및 img2img 모드
- 원클릭 설치 및 실행 스크립트(단, python과 git은 직접 설치해야 함)
- 아웃페인팅(Outpainting)
- 인페인팅(Inpainting)
- 컬러 스케치
- 프롬프트 매트릭스
- Stable Diffusion 업스케일
- 어텐션, 모델이 텍스트의 특정 부분에 더 집중하도록 지정
    - a man in a `((tuxedo))` - tuxedo에 더 집중
    - a man in a `(tuxedo:1.21)` - 대체 구문
    - 텍스트 선택 후 `Ctrl+Up` 또는 `Ctrl+Down`(MacOS는 `Command+Up` 또는 `Command+Down`)으로 선택한 텍스트의 어텐션 자동 조정(익명 사용자 기여 코드)
- 루프백, img2img 처리를 여러 번 반복 실행
- X/Y/Z 플롯, 다양한 파라미터로 3차원 이미지 플롯 생성
- 텍스추얼 인버전(Textual Inversion)
    - 원하는 만큼 임베딩 추가 및 자유로운 이름 사용 가능
    - 토큰당 벡터 수가 다른 다중 임베딩 사용 가능
    - 반정밀도 부동소수점 지원
    - 8GB에서 임베딩 학습 가능(6GB에서도 동작 보고 있음)
- Extras 탭:
    - GFPGAN, 얼굴 복원 신경망
    - CodeFormer, GFPGAN 대체 얼굴 복원 도구
    - RealESRGAN, 신경망 업스케일러
    - ESRGAN, 다양한 서드파티 모델을 지원하는 신경망 업스케일러
    - SwinIR 및 Swin2SR([여기 참고](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), 신경망 업스케일러
    - LDSR, 잠재적 확산 초고해상도 업스케일링
- 크기 비율 조정 옵션
- 샘플링 방식 선택
    - 샘플러 eta 값(노이즈 배수) 조정
    - 더 고급 노이즈 설정 옵션
- 언제든지 처리 중단 가능
- 4GB 비디오 카드 지원(2GB에서도 동작 보고 있음)
- 배치에 대한 올바른 시드
- 실시간 프롬프트 토큰 길이 검증
- 생성 파라미터
    - 이미지 생성에 사용한 파라미터가 이미지와 함께 저장됨
    - PNG는 PNG 청크, JPEG는 EXIF에 저장
    - 이미지를 PNG info 탭에 드래그하여 생성 파라미터 복원 및 UI에 자동 복사
    - 설정에서 비활성화 가능
    - 이미지/텍스트-파라미터를 프롬프트 박스로 드래그 앤 드롭
- 생성 파라미터 읽기 버튼, 프롬프트 박스의 파라미터를 UI로 불러오기
- 설정 페이지
- UI에서 임의의 파이썬 코드 실행(`--allow-code` 옵션 필요)
- 대부분의 UI 요소에 마우스오버 힌트
- 텍스트 설정으로 UI 요소의 기본/최대/최소/스텝 값 변경 가능
- 타일링 지원, 텍스처처럼 타일링 가능한 이미지 생성 체크박스
- 진행률 바 및 실시간 이미지 생성 미리보기
    - 별도의 신경망으로 VRAM이나 연산 없이 미리보기 생성 가능
- 네거티브 프롬프트, 생성 이미지에서 보고 싶지 않은 항목을 나열하는 추가 텍스트 필드
- 스타일, 프롬프트의 일부를 저장하고 드롭다운으로 쉽게 적용
- 변형, 거의 동일하지만 약간 다른 이미지 생성
- 시드 리사이징, 거의 동일한 이미지를 약간 다른 해상도로 생성
- CLIP 인터로게이터, 이미지에서 프롬프트 추정 버튼
- 프롬프트 편집, 생성 도중 프롬프트 변경(예: 수박에서 시작해 중간에 애니메 소녀로 전환)
- 배치 처리, img2img로 파일 그룹 처리
- img2img 대안, 역 오일러 방식의 크로스 어텐션 컨트롤
- 고해상도 Fix, 일반적인 왜곡 없이 원클릭으로 고해상도 이미지 생성
- 체크포인트 실시간 재로딩
- 체크포인트 병합, 최대 3개 체크포인트를 하나로 합치는 탭
- [커스텀 스크립트](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts), 커뮤니티 확장 지원
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), 여러 프롬프트를 동시에 사용
     - 대문자 `AND`로 프롬프트 구분
     - 프롬프트 가중치 지원: `a cat :1.2 AND a dog AND a penguin :2.2`
- 프롬프트 토큰 제한 없음(원본 stable diffusion은 최대 75개 토큰)
- DeepDanbooru 연동, 애니메 프롬프트용 danbooru 태그 생성
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), 일부 카드에서 속도 대폭 향상(`--xformers` 명령줄 옵션 추가)
- 확장 기능: [히스토리 탭](https://github.com/yfszzx/stable-diffusion-webui-images-browser), UI에서 이미지 조회, 직접 이동 및 삭제 지원
- 무한 생성 옵션
- 트레이닝 탭
     - 하이퍼네트워크 및 임베딩 옵션
     - 이미지 전처리: 자르기, 미러링, BLIP 또는 deepdanbooru(애니메용)로 자동 태깅
- Clip skip
- 하이퍼네트워크(Hypernetworks)
- Loras(하이퍼네트워크와 유사하지만 더 직관적)
- 임베딩, 하이퍼네트워크, Lora를 미리보기와 함께 선택하여 프롬프트에 추가할 수 있는 별도 UI
- 설정 화면에서 다른 VAE 선택 가능
- 진행률 바에 예상 완료 시간 표시
- API
- RunwayML의 [전용 인페인팅 모델](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) 지원
- 확장 기능: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), clip 이미지 임베드를 사용하여 특정 미학의 이미지 생성([구현 참고](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) 지원 - 사용법은 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) 참고
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) 지원 - 사용법은 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) 참고
- 이제 나쁜 문자가 없습니다!
- safetensors 형식의 체크포인트 로드 지원
- 해상도 제한 완화: 생성 이미지의 크기는 64의 배수가 아닌 8의 배수면 가능
- 라이선스 추가!
- 설정 화면에서 UI 요소 순서 변경 가능
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) 지원

## 설치 및 실행
필요한 [종속성](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)을 충족하고, 아래 안내에 따라 진행하세요:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (권장)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU
- [Intel CPU, Intel GPU(내장/외장 모두)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (외부 위키)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (외부 위키)

또는 온라인 서비스(예: Google Colab) 사용:

- [온라인 서비스 목록](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### NVidia GPU용 Windows 10/11 릴리즈 패키지 설치
1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre)에서 `sd.webui.zip`을 다운로드 후 압축 해제
2. `update.bat` 실행
3. `run.bat` 실행
> 자세한 내용은 [NVidia-GPU 설치/실행 안내](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) 참고

### Windows 자동 설치
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) 설치(최신 Python은 torch 미지원), "Add Python to PATH" 체크
2. [git](https://git-scm.com/download/win) 설치
3. stable-diffusion-webui 저장소 다운로드, 예시: `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`
4. Windows 탐색기에서 일반 사용자(관리자 X)로 `webui-user.bat` 실행

### Linux 자동 설치
1. 종속성 설치:
```bash
# Debian 계열:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat 계열:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE 계열:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch 계열:
sudo pacman -S wget git python3
```
시스템이 최신이면 python3.11 또는 python3.10 설치 필요:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # python3.11 패키지와 혼동 주의

# 3.11 전용
# 런치 스크립트에 환경변수 설정
export python_cmd="python3.11"
# 또는 webui-user.sh에
python_cmd="python3.11"
```
2. 웹UI를 설치할 디렉토리로 이동해 아래 명령 실행:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
혹은 원하는 곳에 저장소 클론:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. `webui.sh` 실행
4. 옵션은 `webui-user.sh` 참고
### Apple Silicon 설치

[여기](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)에서 안내 확인

## 기여하기
이 저장소에 코드를 추가하는 방법: [기여 안내](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## 문서

문서는 이 README에서 프로젝트의 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)로 이동되었습니다.

Google 및 기타 검색 엔진의 위키 크롤링을 위해, (사람용이 아님) [크롤링 가능한 위키](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) 링크를 제공합니다.

## 크레딧
차용된 코드의 라이선스는 `설정 -> 라이선스` 화면 또는 `html/licenses.html` 파일에서 확인할 수 있습니다.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel 구현
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- 최적화 아이디어 - https://github.com/basujindal/stable-diffusion
- Cross Attention layer 최적화 - Doggettx - https://github.com/Doggettx/stable-diffusion, 프롬프트 편집 원본 아이디어
- Cross Attention layer 최적화 - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (원본 http://github.com/lstein/stable-diffusion)
- Sub-quadratic Cross Attention layer 최적화 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- 텍스추얼 인버전 - Rinon Gal - https://github.com/rinongal/textual_inversion (코드를 사용하지는 않지만 아이디어 참조)
- SD 업스케일 아이디어 - https://github.com/jquesnelle/txt2imghd
- Outpainting mk2의 노이즈 생성 - https://github.com/parlance-zz/g-diffuser-bot
- CLIP interrogator 아이디어 및 일부 코드 차용 - https://github.com/pharmapsychotic/clip-interrogator
- Composable Diffusion 아이디어 - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - 애니메 디퓨저용 interrogator https://github.com/KichangKim/DeepDanbooru
- float16 UNet에서 float32 정밀도로 샘플링 - 아이디어: marunine, Diffusers 예제 구현: Birch-san(https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks(별), Aleksander Holynski(별), Alexei A. Efros(별X) - https://github.com/timothybrooks/instruct-pix2pix
- 보안 자문 - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- 초기 Gradio 스크립트 - 4chan의 익명 사용자 작성. 익명 사용자에게 감사드립니다.
- (You)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---