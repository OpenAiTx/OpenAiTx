# 메트릭 깊이 비디오 툴박스 (MDVToolbox)

메트릭 3D 깊이 비디오 생성 및 작업용 도구입니다.

![gif_banner](https://github.com/user-attachments/assets/4d737bb3-6fb6-4135-b01e-b35528371d22)

_3d_view_depthfile.py로 제작된 배너_

## 데모

**쇼케이스 비디오:** https://youtu.be/nEiUloZ591Q

**무비 → 3D 변환 데모**: https://www.youtube.com/watch?v=PLFjoNgkZDY

**샘플 스테레오 클립:**
https://github.com/calledit/metric_depth_video_toolbox/releases/tag/Showcase


## 기능

### 메트릭 깊이 비디오 생성

여러 최신 모델을 사용하여 RGB 비디오를 메트릭 깊이 비디오로 변환:

- Depth-Anything 시리즈 (`video_metric_convert.py`) 및 (`videoanythingmetric_video.py`)
- MoGe (`moge_video.py`)
- UniDepth (`unidepth_video.py`)
- UniK3D (`unik3d_video.py`)
- DepthPro (`depthpro_video.py`)
- DepthCrafter (`depthcrafter_video.py`)
- MVSAnywhere (`video_mvsa.py`)

### 스테레오 / 3D 변환

- 2D 영화 → 3D (`movie_2_3D.py`)
- 깊이 및 RGB 비디오로부터 스테레오 렌더링 (`stereo_rerender.py`)
- 시차 보정 및 확산 기반 스테레오 인페인팅 (`stereo_crafter_infill.py`)

### 시각화

- 메트릭 깊이 비디오용 실시간 3D 뷰어 (`3d_view_depthfile.py`)
- 깊이 비디오로부터의 새로운 시점 렌더링 (`3d_view_depthfile.py`)

### 카메라 추적 및 3D 재구성

- 깊이 기반 카메라 추적 (`sam_track_video.py`) 및 (`align_3d_points.py`)
- 장기 점 추적 (CoTracker3) (`track_points_in_video.py`)
- 자세 추출 및 정렬 도구

### 내보내기 도구

메트릭 깊이 비디오를 다른 도구에서 사용하기 위한 표준 형식으로 내보내기: (`convert_metric_depth_video_to_other_format.py`)

- `.ply` 점군
- `.obj` 메시
- Blender `.blend` 및 Alembic `.abc` 카메라 트랙
- 8비트 / 16비트 깊이 맵
- 삼각측량 기반 깊이 재조정

### 마스킹 및 정리

- 자동 주 피사체 마스킹 (`generate_video_mask.py`)
- 자막/로고 인페인팅 (`apply_inpainting.sh`)


## 문서

| 주제 | 링크 |
|---|---|
초보자 가이드 | [`HOWTO.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO.md)  
영화 → 3D 가이드 | [`HOWTO_movie2_3d.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/HOWTO_movie2_3d.md)  
전체 도구 참조 | [`USAGE.md`](https://raw.githubusercontent.com/calledit/metric_depth_video_toolbox/main/docs/USAGE.md)  
GUI 튜토리얼 비디오 | https://youtu.be/BE_aJCI7DHI  


## 깊이 비디오 형식

MDVT는 **RGB 인코딩 16비트 메트릭 깊이**를 사용합니다:

- **빨강 + 초록** = 상위 8비트 (가시성 위해 중복)
- **파란색** = 하위 8비트  
- 기본 범위: **100미터**
- 해상도: **~1.5mm 깊이 정밀도**

향후 더 높은 정밀도 업그레이드는 **24비트 깊이** 또는 장거리 정확도를 위한 **로그 인코딩 깊이**로 진행될 예정입니다.

---

## 설치

### 윈도우
1. git 설치 https://git-scm.com/downloads/win
2. miniconda 설치 https://docs.conda.io/en/latest/
3. 시작 메뉴에서 Anaconda 프롬프트(miniconda) 실행
4. 실행
```batch
git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox
windows_installer.bat
```
5. `conda activate mdvt`를 사용하여 conda를 활성화하고 도구를 사용합니다. 일부 ML 모델은 윈도우에서 지원되지 않지만 Sterecrafter와 depth anything 같은 가장 필수적인 모델은 지원됩니다.

### Ubuntu/Debian 및 OSX

```bash


git clone https://github.com/calledit/metric_depth_video_toolbox
cd metric_depth_video_toolbox

# on linux
sudo apt-get install -y libgl1
./install_mdvtoolbox.sh

#Optional (only required for some tools)
./install_mdvtoolbox.sh -megasam
./install_mdvtoolbox.sh -geometrycrafter
./install_mdvtoolbox.sh -unik3d
./install_mdvtoolbox.sh -depthpro
./install_mdvtoolbox.sh -stereocrafter
./install_mdvtoolbox.sh -madpose
./install_mdvtoolbox.sh -unidepth
./install_mdvtoolbox.sh -moge
./install_mdvtoolbox.sh -promptda

# if using headless linux you need to start a virtual x11 server
apt-get install xvfb
Xvfb :2 &
export DISPLAY=:2

# OSX (OSX only supports post processing of depth videos not generation of them. As the ML models need CUDA)
# (open3d requires python3.11 on OSX (as of 2025)))
pip3.11 install open3d numpy opencv-python

```
### 요구 사항
ML 모델을 필요로 하는 도구들은 Cuda 12.4와 Torch 2.5.1을 지원하는 nvidia 3090 카드가 장착된 머신에서 [vast.ai](https://cloud.vast.ai/?ref_id=148636)에서 "template PyTorch (cuDNN Devel)"를 사용하여 테스트되었습니다.

### 다음 단계
- 현재 새로운 안정적이고 정확한 깊이 모델을 기다리고 있습니다.

### 기여
감사히 받습니다. 맞춤법과 같은 간단한 것도 좋습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---