# Xenity 엔진

Xenity 엔진은 PlayStation Portable, PsVita, PS3 및 Windows용 GameObjects와 Components 기반의 크로스플랫폼 게임 엔진입니다.

[Xenity 스크립팅 문서](https://fewnity.github.io/Xenity-Engine/script_api_reference/scripting_api_reference.html)

저는 이 엔진의 대부분의 큰 문제를 해결하기 위해 새로운 엔진 작업을 계획 중입니다.<br>
그래서 아마 이 엔진에 새로운 기능을 추가하지 않을 것입니다.<br>
하지만 풀 리퀘스트는 여전히 환영합니다. 새로운 기능, 리팩터, 버그 수정, 최적화 또는 문서 개선, 무엇이든 환영합니다!
엔진을 개선하고 싶다면, 여기에 [TODO 리스트](https://github.com/Fewnity/Xenity-Engine/blob/crossplatform/TODO.md)가 있습니다.

![image](https://github.com/Fewnity/Xenity-Engine/assets/39272935/df59e12e-b989-4b0d-93b1-4f95fac7c91f)

![gif](https://github.com/user-attachments/assets/7568e868-e41c-4495-bde7-56bb7b6bc54d)

[게임 샘플](https://fewnity.github.io/Xenity-Engine/game_project_samples/game_project_samples.html)을 다운로드할 수 있습니다!

### 지원 플랫폼:<br>
✔️ 지원됨<br>
🚧 작업 중<br>

| 상태 | 플랫폼 |
|-|-|
✔️ | Windows
✔️ | PlayStation Portable
✔️ | PlayStation Vita
✔️ | PlayStation 3
🚧 | Linux (UI가 약간 글리치가 있고, 오디오 및 빌드 시스템이 누락됨)

기능:

- [X] 기본 2D
- [X] 기본 3D
- [X] 2D 오디오
- [ ] 3D 오디오
- [X] 스카이박스
- [X] 씬
- [ ] 애니메이션
- [X] 3D 물리
- [ ] 2D 물리
- [X] C++ 핫 리로딩

> [!경고]
> 엔진은 완벽하지 않습니다. 따라서 게임 개발 중 다음과 같은 문제가 발생할 수 있습니다:
> - 메타 파일을 삭제하면 프로젝트에 영향이 있습니다. 해당 파일을 참조하는 변수들이 비워집니다.
> - 메타 파일을 복제하면 문제가 발생합니다. 각 메타 파일에는 고유한 파일 ID가 포함되어 있습니다.
> - 오디오는 44100Hz에서 "정상적으로" 작동하지만 PS3에서는 48000Hz 오디오를 사용해야 합니다.

> [!참고]
> 에디터에서 게임을 컴파일하려면 `Engine Settings` 메뉴(Window->Engine Settings)에서 `Compiler path`를 설정해야 합니다.<br>
> `Compiler path`의 기본값은 `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build`이며, Visual Studio 설치 위치나 버전이 다르면 변경하세요.<br>
> PSP 빌드를 위한 Build And Run에 `PPSSPP location`을 설정할 수 있습니다.

## 에디터 사용 방법
### 에디터에서 게임 플레이 방법
- "Game->Compile Game"에서 게임을 컴파일합니다.
- 재생 버튼을 클릭합니다.
### 게임 빌드 방법
- "File->Build Settings"에서 빌드 설정 메뉴를 엽니다.
- 플랫폼을 선택합니다.
- 빌드를 클릭합니다.
(PSP, PS3, PsVita의 경우 Docker Desktop이 설치되고 구성되어 있어야 합니다).

## Docker 설정
PSP, PS3, PsVita 게임을 컴파일하려면 Docker Desktop이 필요합니다.<br>
Docker Desktop 다운로드: https://www.docker.com/products/docker-desktop/

그런 다음 Xenity에서 Docker 설치를 완료하세요. "Window->Docker Configuration"으로 이동합니다. 컴퓨터 성능이나 인터넷 속도가 느리면 이 과정이 몇 분 걸릴 수 있습니다. (에디터가 멈춘 것처럼 보일 수 있습니다).

## 호환 파일
이미지: `.png .jpg .bmp, .tga`

오디오: `.wav .mp3` (PS3를 제외하고 44100Hz 오디오를 사용하세요. PS3는 48000Hz 오디오를 사용해야 합니다)

메시: `.obj .fbx`

폰트: `.ttf`

## Visual Studio에서 엔진 컴파일 방법
- 프로젝트 `Xenity_Engine_Executable`을 시작 프로젝트로 설정하세요.
- `Engine` 구성을 컴파일한 후 `Editor`를 컴파일하여 모든 dll 파일을 생성합니다.

## 엔진 내부 동작 방식

프로젝트/게임이 로드되면, 엔진은 존재하는 모든 파일의 목록을 만듭니다. 각 파일은 고유한 Id를 가집니다.
`Texture`, `Audio Clip`, `Mesh Data` 등과 같이 원래 파일인 클래스들은 `File Reference`를 상속받아 해당 파일을 가리키는 포인터를 가집니다.

`Component`, `GameObject`, `Vector3` 등과 같은 일부 클래스는 `Reflective`를 상속받습니다. 이는 기본 클래스를 알지 못해도 변수에 접근할 수 있게 합니다. 이 기능은 Inspector에서 데이터를 보고 수정하는 데 사용되며, 데이터를 파일에 저장하거나 파일에서 불러오는 데 사용됩니다.

## 연락처
도움이 필요하면 이슈를 열거나 저에게 연락하세요.

이메일: `fewnity@gmail.com`<br>
디스코드: `fewnity`

## 라이선스

이 저장소의 코드는 MIT 라이선스 하에 있습니다.

## 게임 콘솔 SDK

https://github.com/Fewnity/Xenity-Engine-SDK

## 사용된 라이브러리
Stb (사용: stb_image 2.23 (이후 버전은 PSP에서 작동하지 않음), stb_image_resize 0.97, stb_image_write 1.16): https://github.com/nothings/stb

drmp3 v0.6.40 & drwav v0.13.17: https://github.com/mackron/dr_libs

JSON for Modern C++ v3.11.3: https://github.com/nlohmann/json

GLM (PS2용으로 약간 수정됨): https://github.com/g-truc/glm

Bullet 2.82 (컴파일 오류 수정용 약간의 수정): https://code.google.com/archive/p/bullet/downloads

### Windows 전용:
Assimp (79d451b): https://github.com/assimp/assimp/
<br>`cmake CMakeLists.txt -DASSIMP_BUILD_ZLIB=ON -DASSIMP_NO_EXPORT=ON -DASSIMP_BUILD_ALL_EXPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_TESTS=OFF -DASSIMP_BUILD_ASSIMP_VIEW=OFF -DASSIMP_INJECT_DEBUG_POSTFIX=OFF -DASSIMP_INSTALL=OFF -DASSIMP_BUILD_ALL_IMPORTERS_BY_DEFAULT=OFF -DASSIMP_BUILD_OBJ_IMPORTER=ON -DASSIMP_BUILD_FBX_IMPORTER=ON -DCMAKE_BUILD_TYPE=Release`
`cmake --build . --config Release`

FreeType (v2.13.2): https://github.com/ubawurinna/freetype-windows-binaries/
ImGui 도킹 브랜치 (1.91.8 WIP): https://github.com/ocornut/imgui

SDL (3.2): https://github.com/libsdl-org/SDL

Glad v2.0.8 (gl 4.6 호환 모드): https://gen.glad.sh/

### PsVita 전용: 
VitaGL (029ddbe): (HAVE_GLSL_SUPPORT=1 플래그 활성화, NO_DEBUG=1 릴리즈용, HAVE_SHARK_LOG=1 LOG_ERRORS=2 디버그용으로 컴파일됨) https://github.com/Rinnegatamante/vitaGL



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-03

---