# lsfg-vk
이 프로젝트는 [Lossless Scaling의 프레임 생성](https://store.steampowered.com/app/993090/Lossless_Scaling/)을 리눅스에 도입합니다!
>[!NOTE]
> 이 프로젝트는 아직 진행 중입니다. 프레임 생성이 일부 게임에서 동작하긴 했으나, 아직 갈 길이 멉니다. 지원 관련 내용은 위키를 참고해주세요 (위키는 아직 작성되지 않았습니다)

## 빌드, 설치 및 실행

>[!CAUTION]
> 빌드 방법이 최근에 변경되었습니다. 반드시 내용을 확인하세요.

LSFG를 컴파일하려면, 시스템에 다음 구성 요소가 설치되어 있어야 합니다:
- 전통적인 빌드 도구 (+ sed, git)
- Clang 컴파일러 (이 프로젝트는 GCC로는 쉽게 컴파일되지 않습니다)
- Vulkan 헤더 파일
- CMake 빌드 시스템
- Meson 빌드 시스템 (DXVK용)
- Ninja 빌드 시스템 (CMake의 백엔드)

lsfg-vk의 컴파일은 비교적 간단합니다. 모든 것이 CMake에 잘 통합되어 있습니다:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
이렇게 하면 lsfg-vk가 ~/.local/lib 및 ~/.local/share/vulkan에 설치됩니다.

다음으로, Steam에서 Lossless Scaling을 다운로드해야 합니다. `legacy_2.13` 브랜치로 전환하거나 해당 depot을 다운로드하세요.
게임 파일에서 "Lossless.dll"의 경로를 복사하거나 기억해 두세요.

마지막으로, 프레임 생성이 활성화된 상태로 프로그램을 시작해 봅시다. 이 예시에서는 `vkcube`를 사용하겠습니다:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
경로를 적절히 수정해야 합니다. 각 항목을 살펴봅시다:
- `LVK_INSTANCE_LAYERS`: 여기에는 `VK_LAYER_LS_frame_generation`을 지정합니다. 모든 Vulkan 앱이 lsfg-vk 레이어를 로드하도록 강제합니다.
- `LSFG_DLL_PATH`: 여기에는 Steam에서 다운로드한 Lossless.dll의 경로를 지정합니다. lsfg-vk는 여기에서 셰이더를 추출하고 변환합니다.
- `LSFG_MULTIPLIER`: 익숙할 만한 프레임 증가 배수입니다. 프레임레이트를 두 배로 늘리려면 `2`를 지정하세요.
- `VK_LAYER_PATH`: `~/.local` 또는 `/usr`에 설치하지 않았다면, 여기에서 `explicit_layer.d` 폴더 경로를 지정해야 합니다.

>[!WARNING]
> Windows와 달리, 여기서는 LSFG_MULTIPLIER가 상당히 제한적입니다 (현재 기준!). 하드웨어가 8개의 스왑체인 이미지를 생성할 수 있다면, LSFG_MULTIPLIER를 4로 설정하면 그 중 4개가 점유되어 게임에는 4개만 남습니다. 만약 게임이 5개 이상의 이미지를 요청하면, 크래시가 발생할 수 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---