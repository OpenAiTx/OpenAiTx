# Stable Diffusion 웹 UI
Stable Diffusion을 위한 웹 인터페이스로, Gradio 라이브러리를 사용하여 구현되었습니다.

![](https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/screenshot.png)

## 기능
[이미지와 함께 자세한 기능 소개](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- 원래의 txt2img 및 img2img 모드
- 원클릭 설치 및 실행 스크립트 (하지만 여전히 python과 git은 설치해야 합니다)
- 아웃페인팅
- 인페인팅
- 컬러 스케치
- 프롬프트 매트릭스
- Stable Diffusion 업스케일
- 어텐션, 모델이 더 주목해야 할 텍스트 부분 지정
    - a man in a `((tuxedo))` - tuxedo에 더 주목함
    - a man in a `(tuxedo:1.21)` - 대체 문법
    - 텍스트 선택 후 `Ctrl+Up` 또는 `Ctrl+Down` (MacOS에서는 `Command+Up` 또는 `Command+Down`)을 눌러 선택한 텍스트의 어텐션을 자동 조절 (익명 사용자가 기여한 코드)
- 루프백, img2img 처리를 여러 번 실행
- X/Y/Z 플롯, 다양한 매개변수로 이미지를 3차원 플롯으로 그리는 방법
- 텍스추얼 인버전
    - 원하는 만큼 임베딩을 보유하고 자유롭게 이름 지정 가능
    - 토큰당 벡터 수가 다른 여러 임베딩 사용 가능
    - 반정밀도 부동소수점 숫자 사용 가능
    - 8GB에서 임베딩 훈련 가능 (6GB에서도 가능하다는 보고 있음)
- Extras 탭에:
    - GFPGAN, 얼굴을 복원하는 신경망
    - CodeFormer, GFPGAN 대체 얼굴 복원 도구
    - RealESRGAN, 신경망 업스케일러
    - ESRGAN, 다양한 서드파티 모델을 지원하는 신경망 업스케일러
    - SwinIR 및 Swin2SR ([여기 참조](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), 신경망 업스케일러
    - LDSR, 잠재 확산 초해상도 업스케일링
- 종횡비 조절 옵션
- 샘플링 방법 선택
    - 샘플러 eta 값(노이즈 배수) 조절
    - 더 고급 노이즈 설정 옵션
- 언제든지 처리 중단 가능
- 4GB 비디오 카드 지원 (2GB에서도 작동 보고 있음)
- 배치별 올바른 시드 지원
- 실시간 프롬프트 토큰 길이 검증
- 생성 매개변수
     - 이미지 생성에 사용된 매개변수가 해당 이미지와 함께 저장됨
     - PNG 파일의 PNG 청크에, JPEG는 EXIF에 저장
     - 이미지를 PNG 정보 탭으로 드래그하면 생성 매개변수를 복원하고 UI에 자동 복사
     - 설정에서 비활성화 가능
     - 이미지/텍스트 매개변수를 프롬프트 박스로 드래그 앤 드롭 가능
- 생성 매개변수 읽기 버튼, 프롬프트 박스에 매개변수를 로드하여 UI에 반영
- 설정 페이지
- UI에서 임의의 파이썬 코드 실행 (활성화하려면 `--allow-code` 옵션 필요)
- 대부분 UI 요소에 마우스오버 힌트 제공
- 텍스트 구성으로 UI 요소의 기본값/최대값/최소값/단계값 변경 가능
- 타일링 지원, 텍스처처럼 타일링 가능한 이미지 생성용 체크박스
- 진행 바와 실시간 이미지 생성 미리보기
    - 거의 VRAM이나 연산 요구 없이 별도의 신경망으로 미리보기 생성 가능
- 네거티브 프롬프트, 생성 이미지에 포함하지 않을 내용을 나열할 수 있는 추가 텍스트 필드
- 스타일, 프롬프트 일부를 저장하고 드롭다운으로 쉽게 적용 가능
- 변형, 거의 동일하지만 약간 다른 이미지를 생성하는 방법
- 시드 크기 조절, 약간 다른 해상도로 동일한 이미지 생성 방법
- CLIP 인터로게이터, 이미지에서 프롬프트를 추측하는 버튼
- 프롬프트 편집, 생성 중간에 프롬프트 변경 가능 (예: 수박을 만들다 중간에 애니메이션 소녀로 변경)
- 배치 처리, img2img를 사용하여 여러 파일 일괄 처리
- Img2img 대체, 역 오일러 방식의 교차 어텐션 제어
- 고해상도 수정, 일반 왜곡 없이 원클릭으로 고해상도 이미지 생성 편의 옵션
- 체크포인트를 실시간으로 다시 로드
- 체크포인트 병합기, 최대 3개의 체크포인트를 하나로 병합하는 탭
- [커스텀 스크립트](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts), 커뮤니티에서 제공하는 다양한 확장 기능
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), 여러 프롬프트를 동시에 사용하는 방법
     - 대문자 `AND`로 프롬프트 구분
     - 프롬프트 가중치도 지원: `a cat :1.2 AND a dog AND a penguin :2.2`
- 프롬프트 토큰 제한 없음 (원래 stable diffusion은 최대 75토큰 사용 가능)
- DeepDanbooru 통합, 애니메이션 프롬프트에 대해 단보루 스타일 태그 생성
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), 일부 그래픽 카드에서 속도 대폭 향상: (명령줄 인자에 `--xformers` 추가)
- 확장 기능으로: [히스토리 탭](https://github.com/yfszzx/stable-diffusion-webui-images-browser), UI 내에서 이미지 보기, 직접 접근 및 삭제 가능
- 무한 생성 옵션
- 훈련 탭
     - 하이퍼네트워크 및 임베딩 옵션
     - 이미지 전처리: 자르기, 미러링, BLIP 또는 deepdanbooru(애니용)를 이용한 자동 태깅
- 클립 스킵
- 하이퍼네트워크
- 로라(Loras) (하이퍼네트워크와 같지만 더 예쁘게)
- 임베딩, 하이퍼네트워크 또는 로라를 미리보기와 함께 선택할 수 있는 별도 UI
- 설정 화면에서 다른 VAE 로드 선택 가능
- 진행 바에 예상 완료 시간 표시
- API
- RunwayML의 전용 [인페인팅 모델](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) 지원
- 확장 기능으로: [미적 그라디언트](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), 클립 이미지 임베드를 사용해 특정 미학의 이미지 생성 방법 ([https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients) 구현)
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) 지원 - [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)에서 사용법 참고
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) 지원 - [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)에서 사용법 참고
- 이제 나쁜 글자 없음!
- safetensors 형식의 체크포인트 로드
- 해상도 제한 완화: 생성 이미지 크기는 64가 아닌 8의 배수여야 함
- 이제 라이선스 포함!
- 설정 화면에서 UI 요소 순서 변경 가능
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) 지원

## 설치 및 실행
필요한 [종속성](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)이 충족되는지 확인하고 다음 지침을 따르세요:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (권장)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU
- [Intel CPU, Intel GPU (통합 및 별도)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (외부 wiki 페이지)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (외부 위키 페이지)

또는, 온라인 서비스(예: Google Colab)를 사용하세요:

- [온라인 서비스 목록](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### NVidia-GPU를 사용하는 Windows 10/11에서 릴리스 패키지 설치
1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre)에서 `sd.webui.zip`을 다운로드하고 내용을 압축 해제합니다.
2. `update.bat`을 실행합니다.
3. `run.bat`을 실행합니다.
> 자세한 내용은 [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)를 참조하세요.

### Windows에서 자동 설치
1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/)을 설치합니다 (더 최신 버전의 Python은 torch를 지원하지 않습니다), "Add Python to PATH"를 체크하세요.
2. [git](https://git-scm.com/download/win)을 설치합니다.
3. stable-diffusion-webui 저장소를 다운로드합니다. 예를 들어 `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git` 명령어를 실행합니다.
4. Windows 탐색기에서 일반 사용자 권한(관리자 아님)으로 `webui-user.bat`을 실행합니다.

### Linux에서 자동 설치
1. 의존성 패키지를 설치합니다:
```bash
# Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-based:
sudo pacman -S wget git python3
```
시스템이 매우 최신인 경우, python3.11 또는 python3.10을 설치해야 합니다:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # do not confuse with python3.11 package

# Only for 3.11
# Then set up env variable in launch script
export python_cmd="python3.11"
# or in webui-user.sh
python_cmd="python3.11"
```
2. 웹 UI를 설치할 디렉터리로 이동한 후 다음 명령어를 실행하세요:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
또는 원하는 곳에 저장소를 복제하세요:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```
3. `webui.sh`를 실행하세요.  
4. 옵션은 `webui-user.sh`를 확인하세요.  
### Apple Silicon 설치  

설치 방법은 [여기](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)에서 찾으실 수 있습니다.  

## 기여하기  
이 저장소에 코드를 추가하는 방법은 다음과 같습니다: [기여하기](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)  

## 문서  

문서는 이 README에서 프로젝트의 [위키](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)로 옮겨졌습니다.  

Google 및 기타 검색 엔진이 위키를 크롤링하도록 하기 위한 목적으로, (사람용이 아닌) [크롤링 가능한 위키](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) 링크를 제공합니다.  

## 크레딧  
차용한 코드의 라이선스는 `Settings -> Licenses` 화면과 `html/licenses.html` 파일에서 확인할 수 있습니다.  

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
- Cross Attention 레이어 최적화 - Doggettx - https://github.com/Doggettx/stable-diffusion, 프롬프트 편집의 원래 아이디어.  
- Cross Attention 레이어 최적화 - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (원래는 http://github.com/lstein/stable-diffusion)  
- Sub-quadratic Cross Attention 레이어 최적화 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)  
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (코드는 사용하지 않지만 아이디어는 사용 중).  
- SD 업스케일 아이디어 - https://github.com/jquesnelle/txt2imghd  
- 아웃페인팅 mk2용 노이즈 생성 - https://github.com/parlance-zz/g-diffuser-bot  
- CLIP 인터로게이터 아이디어 및 일부 코드 차용 - https://github.com/pharmapsychotic/clip-interrogator  
- Composable Diffusion 아이디어 - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch  
- xformers - https://github.com/facebookresearch/xformers  
- DeepDanbooru - 애니메이션 디퓨저용 인터로게이터 https://github.com/KichangKim/DeepDanbooru  
- float16 UNet에서 float32 정밀도로 샘플링 - 아이디어는 marunine, Diffusers 구현 예시는 Birch-san (https://github.com/Birch-san/diffusers-play/tree/92feee6)  
- Instruct pix2pix - Tim Brooks (별), Aleksander Holynski (별), Alexei A. Efros (별 없음) - https://github.com/timothybrooks/instruct-pix2pix  
- 보안 조언 - RyotaK  
- UniPC 샘플러 - Wenliang Zhao - https://github.com/wl-zhao/UniPC  
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd  
- LyCORIS - KohakuBlueleaf  
- 재시작 샘플링 - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling  
- Hypertile - tfernd - https://github.com/tfernd/HyperTile  
- 초기 Gradio 스크립트 - 4chan의 익명 사용자 게시. 익명 사용자에게 감사드립니다.  
- (당신)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---