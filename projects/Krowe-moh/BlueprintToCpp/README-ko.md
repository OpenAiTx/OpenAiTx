# Blueprint To C++

언리얼 엔진 블루프린트를 C++ 코드로 변환하는 도구입니다.

[CUE4Parse](https://github.com/FabianFG/CUE4Parse) 기반으로 제작되었습니다.

## 설치

1. 저장소를 클론하세요:
    ```bash
    git clone https://github.com/Krowe-moh/BlueprintToCpp.git --recursive
    ```
2. IDE에서 솔루션 파일을 열고 프로젝트를 빌드합니다.

## 사용법

1. 실행 파일을 실행하여 자동으로 `config.json` 파일을 생성합니다.

2. `config.json`에서 옵션을 구성합니다:

    예시:

    ```js
    {
      "PakFolderPath": "C:/Program Files/Epic Games/Fortnite/FortniteGame/Content/Paks",
      "BlueprintPath": "FortniteGame/Content/Athena/Cosmetics/Sprays/BP_SprayDecal.uasset",
      "OodlePath": "C:/Users/krowe/BlueprintToCpp/oo2core_5_win64.dll",
      "ZlibPath ": "", // leave blank if no zlib compression
      "UsmapPath": "C:/Users/krowe/BlueprintToCpp/++Fortnite+Release-33.20-CL-39082670-Windows_oo.usmap",
      "Version": "GAME_UE5_LATEST"
    }
    ```
3. 변환을 시작하려면 `Main.exe`를 실행하세요.

## AES

AES를 설정하려면 프로그램을 한 번 실행하세요(설정이 적용된 상태에서), 그런 다음 생성된 `aes.json` 파일을 수정하세요.

## 출력

디컴파일된 블루프린트는 `Output.cpp`로 출력됩니다(현재 폴더 계층 구조로 출력되도록 변경되었으며, 곧 비활성화 옵션이 제공될 예정입니다).

참고: 현재 이 도구는 모든 표현식을 지원하지 않으며, C++ 출력이 100% 정확하지 않을 수 있습니다.

## 문제점

문제가 발생하면 [여기](https://github.com/Krowe-moh/BlueprintToCpp/issues)에서 제출해 주세요.

## 기여

문제 제출, 저장소 포크, 개선 사항에 대한 풀 리퀘스트 생성은 언제든지 환영합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---