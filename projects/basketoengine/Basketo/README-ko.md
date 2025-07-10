<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Basketo Game Engine Logo" width="200"/>
</p>

<h2 align="center">창조하고, 플레이하고, 영감을 주다. 생명을 불어넣는 게임. ✨</h2>

<h1 align="center">Basketo 게임 엔진</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Replace your_discord_server_id with your actual server ID -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Basketo 엔진에 오신 것을 환영합니다 - 우리는 열정적으로 멋지고 성능이 뛰어난 엔진을 만들기 위해 최선을 다하고 있으며, AI-네이티브 게임 엔진으로 발전시킬 흥미로운 계획을 가지고 있습니다. Unity와 유사한 에디터 인터페이스, Gemini AI 통합, 고급 멀티 사운드 이펙트 시스템, 강력한 ECS 아키텍처를 제공합니다. 기여하거나, 아이디어를 제안하거나, 단순히 성장하는 모습을 지켜보는 등 어떤 방식으로든 여러분은 이 여정의 일부입니다! 🚀
</p>

## 🚀 엔진의 현재 상태
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>최신 개발 상황과 기능을 직접 확인해 보세요!</em> 🎮
</p>

## ✨ 주요 기능

### 🎮 **Unity와 유사한 에디터 인터페이스**
- **이중 창 구성**: 씬 에디터와 게임 뷰를 나란히 배치
- **실시간 편집**: 게임 실행 중에도 씬 수정 가능
- **인스펙터 패널**: 드래그 앤 드롭으로 시각적 컴포넌트 편집
- **계층 구조 보기**: 엔티티를 체계적으로 관리 및 구성
- **에셋 브라우저**: 텍스처와 오디오를 쉽게 관리

### 🤖 **AI-네이티브 개발**
- **Gemini AI 통합**: 자연어 명령으로 게임 개발
- **스마트 스크립트 생성**: AI 기반 Lua 스크립트 생성
- **엔티티 수정**: 변경 사항을 영어로 설명
- **간편한 API 설정**: 내장 Gemini API 키 구성
### 🔊 **고급 오디오 시스템**
- **다중 사운드 효과**: 엔터티별로 여러 개의 명명된 사운드(걷기, 점프, 공격 등)
- **전통적 오디오**: 배경 음악 및 환경음
- **Lua 연동**: 스크립트에서 `PlaySound(entity, "action")`으로 사운드 트리거
- **비주얼 에디터**: 인스펙터에서 사운드 효과 관리

### 🎯 **엔터티-컴포넌트-시스템(ECS)**
- **고성능**: 대량의 엔터티에 최적화
- **모듈형 디자인**: 필요에 따라 컴포넌트 혼합 및 매칭
- **스크립트 연동**: ECS 전체 접근이 가능한 Lua 스크립팅
- **실시간 업데이트**: 라이브 컴포넌트 편집

### 🎨 **그래픽 & 애니메이션**
- **스프라이트 렌더링**: 효율적인 2D 그래픽 파이프라인
- **애니메이션 시스템**: 루프가 가능한 프레임 기반 애니메이션
- **트랜스폼 시스템**: 위치, 회전, 크기 조절
- **카메라 시스템**: 다중 카메라 지원

### ⚡ **물리 & 충돌**
- **충돌 감지**: 공간 최적화된 AABB 충돌
- **리지드바디 물리**: 중력, 속도, 힘
- **충돌 콜백**: 스크립트에서 접근 가능한 충돌 이벤트
- **공간 분할**: 성능을 위한 쿼드트리 최적화
## 🎬 아래 이미지를 클릭하여 비디오 시연을 확인하세요:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � 빠른 시작 가이드

### 1. **Gemini API 키 받기** (선택 사항이지만 권장)
- [Google AI Studio](https://aistudio.google.com/app/apikey)에 방문하세요
- 로그인하고 무료 API 키를 생성하세요
- 자연어 명령과 같은 AI 기반 기능이 활성화됩니다

### 2. **빌드 및 실행**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **AI 기능 구성하기**
- 엔진에서 AI 프롬프트 패널(하단)로 이동합니다
- "🤖 Gemini AI Configuration"을 찾습니다
- API 키를 입력하고 "저장"을 클릭합니다

### 4. **창작 시작하기**
- AI 명령어를 시도해보세요: `"create a player at 100 200"`
- 인스펙터에서 엔티티에 사운드 효과를 추가하세요
- Lua 스크립트를 직접 작성하거나 AI가 생성하도록 하세요
- 듀얼 윈도우 에디터를 사용하여 실시간 개발을 하세요

## �🛠️ 엔진 빌드하기 (Linux) 🐧

### 필수 조건
- CMake 3.26.0 이상이 필요합니다.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (AI 기능용)
- nlohmann/json (서브모듈로 포함됨)
- ImGui (서브모듈로 포함됨)
### 빌드 단계
```bash
# 저장소를 클론합니다
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### 실행
```bash
./BasketoGameEngine

```
물리 테스트를 실행하려면:
```bash
./PhysicsTest

```

## 🛠️ 엔진 빌드하기 (Windows) 💻

### 필수 조건

1. **Visual Studio 2022 (Community Edition 이상)**  
   다음 워크로드와 함께 설치하세요:
   - C++를 사용한 데스크톱 개발
   - Windows용 C++ CMake 도구
   - Windows 10 또는 11 SDK

2. **CMake** (Visual Studio에 포함되어 있거나 https://cmake.org/download/ 에서 다운로드)

3. **vcpkg** (의존성 설치에 사용됨)


---
### 의존성 설치

```bash
# VS 2022용 개발자 명령 프롬프트 또는 PowerShell을 엽니다.

# vcpkg 클론

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# 필요한 라이브러리 설치
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### 빌드 단계
```bash
# Basketo 저장소를 클론합니다
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# CMake로 구성합니다
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# "C:/path/to/vcpkg"를 vcpkg 디렉토리의 전체 경로로 교체하세요

# 엔진을 빌드합니다
cmake --build . --config Release
```

---

### 실행

```bash
# build/Release 디렉토리에서
```
./BasketoGameEngine.exe

# 물리 테스트 실행 방법
./PhysicsTest.exe
```

## 📚 문서

### 주요 기능
- **[사운드 효과 시스템](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: 다중 사운드 효과에 대한 완벽한 가이드
- **[Gemini API 설정](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: 단계별 AI 구성 방법
- **[Lua 스크립팅](assets/Scripts/)**: 예제 스크립트 및 API 참고 자료

### 사용 예시

#### AI 기반 개발
```bash
# 자연어 명령어
"플레이어 캐릭터를 위치 100 200에 생성해줘"
"플레이어에게 점프 동작을 추가해줘"
"적을 더 빠르게 이동하게 해줘"

# 스크립트 생성
gemini_script 플랫폼 게임 컨트롤러를 더블 점프로 생성하기
```

#### 다중 사운드 효과
```lua
-- Lua 스크립트에서
PlaySound(entity, "jump")    -- 점프 사운드 재생
PlaySound(entity, "walk")    -- 걷기 사운드 재생
PlaySound(entity, "attack")  -- 공격 사운드 재생

-- 사운드가 존재하는지 확인
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### 컴포넌트 시스템
- **Transform**: 위치, 회전, 크기
- **Sprite**: 텍스처 렌더링
- **Animation**: 프레임 기반 애니메이션
- **Script**: Lua 동작 스크립트
- **Collider**: 물리 충돌
- **Rigidbody**: 물리 시뮬레이션
- **Audio**: 배경 음악
- **SoundEffects**: 다중 명명 사운드
- **Camera**: 뷰 관리
## 🤝 참여하기

우리는 커뮤니티의 기여를 환영합니다 ❤️. 기여 방법이나 개발을 위한 프로젝트 실행에 대한 자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md)을 참고하세요. <!-- 이 파일이 있다고 가정합니다 -->

- 🐛 버그를 발견하셨나요? 이슈를 등록해 주세요!
- ✨ 멋진 기능 아이디어가 있으신가요? 들려주세요!
- 💻 기여하고 싶으신가요? Fork하고, 코딩한 후, Pull Request를 생성해 주세요!

함께 이 엔진을 만들어가며, 모두에게 게임 개발을 쉽고 재미있게 만들어 봅시다. 🌍

## 👥 커뮤니티
따뜻하게 환영합니다 🤗. 코드 개선 📝, 문서 업데이트 📚, 이슈 제보 🐞, 기능 요청 💡, 그리고 Discord에서의 토론 🗣️ 등 모든 종류의 커뮤니티 기여를 진심으로 환영합니다.

커뮤니티에 참여하세요:

- 👋 [Discord 커뮤니티에 참여하기](https://discord.gg/F3DswRMW)
- ⭐ [GitHub에서 Star 누르기](https://github.com/basketoengine/Basketo)

## 🙏 후원하기:
우리는 지속적으로 개선하고 있으며, 더 많은 기능과 예제가 곧 제공될 예정입니다 🌟. 이 프로젝트가 마음에 드신다면, GitHub 저장소에 Star ⭐를 눌러 주세요 [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) 최신 소식을 받고 저희의 성장을 도와주세요. 🌱

---

행복한 코딩과 게임 제작 되세요! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---