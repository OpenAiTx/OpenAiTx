# momoisay
*C로 작성된 CLI 프로그램으로 Blue Archive의 토킹 사이바 모모이를 특징으로 합니다!!!*

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Version](https://img.shields.io/badge/version-1.2.0-green)]()

---

## 미리보기

애니메이션 사용 예시

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## 기능
- 모모이의 토킹 ASCII 아트
- 모모이의 애니메이션 ASCII 아트
- 모모이의 자유로운 애니메이션 변경

## 설치

#### 면책 조항
때때로 사전 컴파일된 바이너리가 릴리스된 최신 버전이 아닐 수 있습니다. 최신 버전을 확실히 얻고 싶다면 소스에서 직접 빌드할 수 있습니다. 컴파일된 바이너리의 버전은 `/bin` 폴더에서 확인할 수 있습니다.

### 리눅스
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/linux.sh
```
### MacOS
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/mac.sh
```
### 소스에서 빌드하기 (최신 버전)
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## 사용법
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```

## 파일 구조
```
repo/
├── bin/ 
│    ├── linux/
│    │   ├── version.txt
│    │   └── momoisay
│    └── mac/
│        ├── version.txt 
│        └── momoisay
├── install/
│    ├── mac.sh
│    └── linux.sh
├── src/
│    ├── art/
│    │   ├── art.c
│    │   └── art.h
│    ├── extern/
│    │   ├── cString.c
│    │   └── cString.h
│    ├── momoisay.c
│    ├── render.c
│    ├── render.h
│    ├── speech.c
│    └── speech.h
├── Makefile
├── LICENSE
├── preview.gif
└── README.md
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---