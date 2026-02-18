# [arXiv] 온-디바이스 소라: 모바일 기기를 위한 확산 기반 텍스트-투-비디오 생성 구현

* 코드는 [Open-Sora](https://github.com/hpcaitech/Open-Sora) 구현을 기반으로 합니다.

**논문**: https://arxiv.org/abs/2502.04363

[arXiv] 온-디바이스 소라: 모바일 기기를 위한 확산 기반 텍스트-투-비디오 생성 구현의 코드 구현입니다.
참고한 기본 코드 ->
Open-Sora : 모두를 위한 효율적인 비디오 제작 민주화

## 소개

이 저장소는 *On-device Sora*의 코드를 제공합니다. 이는 *On-device Sora: Enabling Diffusion-Based Text-to-Video Generation for Mobile Devices* 라는 논문의 오픈 소스 구현체입니다.

### 온-디바이스 소라
*On-device Sora*는 Linear Proportional Leap (LPL), Temporal Dimension Token Merging (TDTM), 그리고 Concurrent Inference with Dynamic Loading (CI-DL)을 적용하여 iPhone 15 Pro에서 효율적인 비디오 생성을 가능하게 합니다.

![On-Device_Sora](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/overview.jpg)

### 오픈-소라

[Open-Sora](https://github.com/hpcaitech/Open-Sora)는 온-디바이스 소라의 베이스라인 모델로, 비디오 생성을 위한 오픈 소스 프로젝트이며 텍스트 입력을 기반으로 영상을 생성할 수 있는 T2V 확산 모델입니다.

## 온-디바이스 소라를 위한 각 모델의 MLPackage 변환 방법

## 패키지 의존성

### 의존성

```
cd Device_conversion

conda create -n convert python=3.10

conda activate convert

pip install -r requirements/requirements-convert.txt

pip install -v .
```

## 변환

### T5 변환
```
cd t5
python3 export-t5.py
```

### STDiT 커버링
```
cd stdit3
python3 export-stdit3.py
```
### VAE 변환
`export-vae-spatial.py`를 실행할 때 `Fatal Python error: PyEval_SaveThread`라는 오류가 발생할 수 있습니다.
이 오류를 해결하려면 각 VAE 부분에 대해 한 개의 코드 블록만 실행해야 합니다. 나머지는 주석 처리하세요.


```
cd vae

# for vae's temporal part
python3 export-vae-temporal.py

# for vae's spatial part
python3 export-vae-spatial.py
```

## 사용 방법

### 필수 사항
* xcode용 Mac 기기
* 앱 빌드 및 실행을 위한 Apple 계정
* iPhone: iPhone 15 pro 이상
* iOS 버전: 18 이상
* 모든 MLPackage (T5, STDiT, VAE)

### 변환된 MLPackage 다운로드 (각 모델을 MLPackage로 변환하고 싶지 않은 경우)

아래 링크에서 변환된 모델을 다운로드하여 사용할 수 있습니다. [[다운로드](https://drive.google.com/drive/folders/1L6pVi3KmyLygR_pvKofRL-21adKsEb4p?usp=sharing)]

### 앱 실행
* On-device/On-device-Sora.xcodeproj를 클릭하여 xcode 프로젝트 구현
* TARGETS/Signing&Capabilities에서 팀 변경 (None -> 본인 Apple 계정)
* 앱 실행
### 예제 아티팩트
![On-device-Sora-Example1](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/On-device-Sora-Example1.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---