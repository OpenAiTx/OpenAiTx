# RaySplats: 광선 추적 기반 가우시안 스플래팅
Krzysztof Byrski, Marcin Mazur, Jacek Tabor, Tadeusz Dziarmaga, Marcin Kądziołka, Dawid Baran, Przemysław Spurek <br>

| arXiv |
| :---- |
| RaySplats: 광선 추적 기반 가우시안 스플래팅 [https://arxiv.org/pdf/2501.19196.pdf](http://arxiv.org/abs/2501.19196)|

<img src=assets/gif1.gif height="300" class="center"> 
<br>

<table align="center" cellspacing="0" cellpadding="0">
  <tr class="center">
    <td><img src=assets/screenshot1.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot92.png height="200" width="300" class="center"></td>
    <td><img src=assets/screenshot10.png height="200" width="300" class="center"> </td>
  </tr>
  </tr class="center">
  <tr class="center">
    <td><img src=assets/screenshot7.png height="200" width="300" ></td>
    <td><img src=assets/screenshot82.png height="200" width="300" ></td>
    <td><img src=assets/screenshot4.png height="200" width="300" class="center"> </td>
  </tr>
</table>

# 특징
- 구면 조화 함수는 차수 **4**까지 지원합니다.
- 학습된 모델 상태를 실시간으로 미리 볼 수 있는 대화형 Windows 뷰어 / 최적화기 애플리케이션.
- **PLY** 형식의 학습된 모델 출력 지원.
- 매우 효율적인 순수 가우시안 렌더러 (임베딩된 기본 메시 근사 없음).
- 편리한 텍스트 구성 파일 기반의 고도로 구성 가능한 최적화기.
- **Blender**와 **COLMAP** 데이터 세트 모두 지원 (3DGS를 통한 사전 처리 후).
- 모델 평가 및 시각화를 구성 가능한 빈도로 *.bmp 파일로 내장 지원.

# 대화형 Windows 뷰어 / 최적화기 애플리케이션의 컨트롤

<img src="https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/app_main_window.png">

- **더블 왼쪽 클릭**: **고정 카메라**와 **자유 이동** 모드 간 전환.
- **마우스 이동**: **자유 이동** 모드에서 카메라 회전.
- **W / S**: 앞으로 / 뒤로 이동.
- **A / D**: 왼쪽 / 오른쪽으로 이동합니다.  
- **Spacebar / C**: 위 / 아래로 이동합니다.  
- **[ / ]**: 카메라를 이전 / 다음 훈련 자세로 전환합니다.  
- **Print Screen**: 스크린샷을 찍고 24비트 *.bmp 파일로 저장합니다.  

# 필수 조건:  

- Visual Studio 2019 Enterprise;  
- CUDA Toolkit 12.4.1;  
- NVIDIA OptiX SDK 8.0.0;  

# 대화형 Windows 뷰어 / 최적화기 애플리케이션 빌드  

- 새 Windows 데스크톱 애플리케이션 프로젝트를 생성하고 이름을 "RaySplats"로 지정합니다;  
- 코드 템플릿이 포함된 새로 생성된 RaySplats.cpp 파일을 제거합니다;  
- **Build Dependencies** -> **Build Customizations...**에서 설치된 CUDA 버전에 맞는 체크박스를 선택합니다. 테스트 시스템에서는 다음 체크박스를 선택해야 했습니다:  

  **CUDA 12.4(.targets, .props)**  
  
- "RaySplats" 디렉터리의 모든 파일을 프로젝트에 추가합니다;  
- 프로젝트 속성에서 **Configuration**을 **"Release"**로, **Platform**을 **"x64"**로 설정합니다;  
- **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common** -> **Generate Relocatable Device Code**에서 **Yes (-rdc=true)**를 선택합니다;  
- "shaders.cuh" 파일에 대해 **Properties** -> **Configuration Properties** -> **General** -> **Item Type**에서 **"CUDA C/C++"**를 선택합니다;  
- 다음 파일들: "shaders.cuh", "shaders_SH0.cu", "shaders_SH1.cu", "shaders_SH2.cu", "shaders_SH3.cu" 및 "shaders_SH4.cu"에 대해 **Properties** -> **Configuration Properties** -> **CUDA C/C++** -> **Common**에서:  
  - **Compiler Output (obj/cubin)**의 접미사를 **".obj"**에서 **".ptx"**로 변경합니다;  
  - **Generate Relocatable Device Code**에서 **No**를 선택합니다;  
  - **NVCC Compilation Type**에서 **Generate device-only .ptx file (-ptx)**를 선택합니다;  
- **Properties** -> **Configuration Properties** -> **VC++ Directories** -> **Include Directories**에서 OptiX "include" 디렉터리 경로를 추가합니다. 테스트 시스템에서는 다음 경로를 추가해야 했습니다:
  ```plaintext
  "C:\ProgramData\NVIDIA Corporation\OptiX SDK 8.0.0\include"
  ```
- **속성** -> **구성 속성** -> **CUDA C/C++** -> **장치** -> **코드 생성**에서 GPU의 컴퓨팅 능력과 마이크로아키텍처 버전을 입력합니다. RTX 4070 GPU가 장착된 테스트 시스템에서는 다음과 같이 입력했습니다:
  ```plaintext
  "compute_89,sm_89"
  ```
- **속성** -> **구성 속성** -> **링커** -> **입력** -> **추가 종속성**에 세 개의 새 줄을 다음과 같이 추가합니다:
  ```plaintext
  "cuda.lib"
  ```
  ```plaintext
  "cudart.lib"
  ```
  ```plaintext
  "cufft.lib"
  ```
- InitializeOptiXRenderer.cu 파일의 서로 다른 두 코드 블록 각각에서:
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rb");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rb");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rb");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rb");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rb");
  ```
  and
  ```plaintext
  if      constexpr (SH_degree == 0) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH0.cu.ptx", "rt");
  else if constexpr (SH_degree == 1) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH1.cu.ptx", "rt");
  else if constexpr (SH_degree == 2) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH2.cu.ptx", "rt");
  else if constexpr (SH_degree == 3) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH3.cu.ptx", "rt");
  else if constexpr (SH_degree == 4) f = fopen("C:/Users/pc/source/repos/RaySplats/RaySplats/x64/Release/shaders_SH4.cu.ptx", "rt");
  ```
  제공된 경로를 하드디스크에 있는 *.ptx 컴파일된 셰이더 파일 경로로 교체하십시오.

# 첫 번째 모델 훈련하기 (Blender 데이터셋):

- 3DGS로 Blender 데이터셋(예: "NeRF synthetic" 세트의 "lego")에서 소량의 반복(예: 100회)으로 모델을 훈련합니다;
- 데이터셋 메인 디렉터리에 있는 하위 디렉터리 "train"과 "test"에 있는 모든 파일을 이름을 변경하지 않고 24비트 *.bmp 파일 포맷으로 변환합니다;
- 구성 파일 "config.txt"를 프로젝트 메인 디렉터리에 복사합니다. 테스트 시스템에서는 다음 디렉터리에 복사했습니다:
  ```plaintext
  "C:\Users\<Windows username>\source\repos\RaySplats\RaySplats"
  ```
- 구성 파일의 4, 5번째 줄에 데이터셋 메인 디렉터리 위치와 짧은 모델 사전학습 후 얻은 출력 3DGS *.ply 파일 위치를 지정합니다 (**중요!** 사전학습에 사용된 구면 조화 차수와 구성 파일 7번째 줄에 지정된 목표 차수는 일치하지 않아도 됩니다);
- 구성 파일의 13-15번째 줄에 다음 공식을 사용하여 사전학습에 사용된 배경색과 일치하는 배경색을 지정합니다:
  
  R' = (R + 0.5) / 256<br>
  G' = (G + 0.5) / 256<br>
  B' = (B + 0.5) / 256<br>

  여기서 R, G, B는 0-255 범위의 정수 비음수 배경색 좌표입니다.
- Visual Studio IDE에서 "RaySplats" 프로젝트를 실행합니다;

# RaySplatting 뷰어
![image](https://github.com/user-attachments/assets/9a9d61cb-f54a-4301-8a52-4c2d0ce2cc72)
![](https://raw.githubusercontent.com/KByrski/RaySplatting/master/assets/tutorial.mp4)

이 뷰어는 **RaySplatting**을 시각화하고 레이 트레이싱을 지원하는 추가 사용자 로드 객체를 보여주는 경량의 사용자 친화적 뷰어입니다. 이 뷰어는 **OBJ** 및 **PLY (ASCII 형식)** 파일을 장면에 원활하게 통합할 수 있습니다.  

현재 재질 시스템은 **반사성** 또는 **유리와 같은** 모델에 최적화되어 있어 사실적인 빛 상호작용으로 고품질 시각화를 렌더링하는 데 이상적입니다.  

## 시스템 요구 사항  

이 뷰어를 사용하려면 시스템이 다음 요구 사항을 충족하는지 확인하세요:  

- **운영 체제**: Windows  
- **GPU**: NVIDIA RTX 20xx 시리즈 이상 (**RTX 30xx+ 권장**)  
- **CUDA 버전**: 12.4 이상  
- **필수 DLL**: 다음 파일을 디렉터리에 배치하세요:  
  ```plaintext
  C:\Program Files\NVIDIA GPU Computing Toolkit\CUDA\v12.4\bin
  ```
  - `cudart64_12.dll`  
  - `cufft64_11.dll`  

## 설치 및 사용법  

1. 제공된 **ZIP 파일**을 다운로드하세요.  [ZIP 다운로드](https://drive.google.com/file/d/1XPivZb6-dVtuwQ3T9UrxOF2gTTnerGhp/view?usp=sharing)
2. 압축을 풉니다.  
3. **exe 파일**을 실행하세요—추가 설정이 필요 없습니다!  
4. **mesh_config.txt**에서 메쉬 속성을 수정하세요.  
5. `config.txt`에서 **PLY 파일 경로**를 편집하여 기본 씬을 변경하세요.  

## 컨트롤  

- 인터랙티브 Windows 뷰어 / 최적화 애플리케이션과 동일합니다.

## 향후 기능  

다음과 같은 새로운 기능을 적극 개발 중입니다:  
- **향상된 메쉬 변환** (mesh_config.txt 외에 스케일, 회전, 위치 편집)  
- 렌더링된 씬의 **스크린샷 캡처**  
- 다양한 시점을 원활하게 전환할 수 있는 **뷰 프리셋**  
- **그리고 더 많은 기능!**  

업데이트와 개선 사항을 기대해 주세요!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---