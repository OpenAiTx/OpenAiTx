# Luz 엔진

[![라이선스: MIT](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![윈도우](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Windows.yml)
[![우분투](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml/badge.svg)](https://github.com/hadryansalles/Luz/actions/workflows/Ubuntu.yml)

AAA 게임에서 사용하는 최신 렌더링 기법을 연구하고 구현하기 위해 개발 중인 Vulkan 엔진입니다.
- [유튜브 동영상](https://www.youtube.com/user/HadryanSalles/videos)
- [특징](#features)
- [빌드 및 실행 방법](#build)
- [참고 문헌 및 크레딧](#references)

<a name="features"/>

## 특징
- 완전한 Vulkan 래퍼 (BLAS 및 TLAS 생성 포함)
- 볼류메트릭 라이트를 위한 3가지 접근법: Froxels, 폴리곤 메시, 스크린 스페이스
- 시간적 안티앨리어싱
- 섀도우 맵
- 대기 산란
- 씬 직렬화 (JSON)
- 디퍼드 렌더링
- 실시간 레이트레이스 섀도우 및 앰비언트 오클루전
- 금속성, 거칠기, 노멀, 앰비언트 오클루전 및 발광을 포함한 PBR 셰이딩
- Vulkan 바인드리스 리소스
- 원근 및 직교 투영, 플라이 및 오빗 컨트롤을 지원하는 뷰포트 카메라
- ImGui 도킹 UI

## 갤러리
- Froxel 기반 볼류메트릭 라이트
![froxel](https://github.com/user-attachments/assets/28efe343-f5be-45db-a3ac-246aee47faa4)

- 폴리곤 메시 볼류메트릭 라이트
![polygonal](https://github.com/user-attachments/assets/c2113f1b-9081-4a1d-8b8a-516c6d81281f)

- 스크린 스페이스 볼류메트릭 라이트
![ssvl](https://github.com/user-attachments/assets/fcbd3fd5-881f-4640-a887-565d7190da23)

- 디퍼드 렌더링 (라이트, 알베도, 노멀, 재질, 발광 및 깊이)
![deferred](https://user-images.githubusercontent.com/37905502/154867586-7dfa15d1-faf7-4eab-8337-c578831c9044.gif)
- 레이 트레이스 그림자 및 앰비언트 오클루전  
![raytraced](https://user-images.githubusercontent.com/37905502/144621461-52f1ab97-ff6b-4f6f-a83a-cc6f67f5ead6.gif)

- PBR 셰이딩 및 glTF 모델  
![pbr](https://user-images.githubusercontent.com/37905502/144612584-1d752a16-c978-4f43-93d6-2e2362b2804b.gif)

- 텍스처 드래그 앤 드롭  
![dragndrop](https://user-images.githubusercontent.com/37905502/144619247-737d37c1-ba67-4f9a-abf4-63e4d2f965d6.gif)

<a name="build"/>

## 요구 사항  
- VK_KHR_ray_query 확장을 지원하는 GPU ([지원 GPU 목록](https://vulkan.gpuinfo.org/listdevicescoverage.php?extension=VK_KHR_ray_query&platform=all))  
- C++17 컴파일러. ``Visual Studio 2019``, ``Clang``, ``GCC``에서 테스트됨  
- [CMake 3.7](https://cmake.org/download/) 이상  
- [Vulkan SDK](https://vulkan.lunarg.com/sdk/home)  

### 리눅스용  

이 프로젝트는 GLFW 라이브러리를 사용하며, 기본 Ubuntu 20.04와 같은 X11 환경에서 컴파일하려면 다음이 필요합니다:


```sh
sudo apt-get install xorg-dev
```

다른 윈도우 관리자(예: Wayland)를 사용 중인 경우, 의존성을 [여기](https://www.glfw.org/docs/latest/compile.html#compile_deps)에서 확인할 수 있습니다.

## 빌드 및 실행
```sh
git clone --recursive https://github.com/hadryansalles/Luz
cd Luz
mkdir build
cmake . -Bbuild
cmake --build build --parallel 4
./bin/Luz
```
- Visual Studio: ``build/Luz.sln``을 열고 프로젝트 ``Luz``를 컴파일/실행합니다.

<a name="references"/>

## 참고 문헌 및 크레딧

- [GLFW](https://github.com/glfw/glfw) 애플리케이션 창을 여는 데 사용
- [glm](https://github.com/g-truc/glm) 수학 라이브러리로 사용
- [ImGui](https://github.com/ocornut/imgui) 사용자 인터페이스 제작에 사용
- [ImGuizmo](https://github.com/CedricGuillemet/ImGuizmo) 3D 기즈모 생성에 사용
- [spdlog](https://github.com/gabime/spdlog) 로깅 라이브러리로 사용
- [stb_image](https://github.com/nothings/stb) 이미지 파일 로드에 사용
- [tiny_obj_loader](https://github.com/tinyobjloader/tinyobjloader) wavefront .obj 파일 로드에 사용
- [optick](https://github.com/bombomby/optick) 엔진 프로파일링에 사용
- [pbr-sky](https://www.shadertoy.com/view/slyBDG) 대기 하늘 모델 참고용으로 사용



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---