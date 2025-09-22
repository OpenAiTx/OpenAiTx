# GhidraNes

NES ROM의 디스어셈블리 및 분석을 지원하는 Ghidra 확장 기능입니다.

![Ghidra disassembly showing a decompiled function from a file named "game.nes"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## 기능

- iNES 포맷의 NES ROM을 가져옵니다. 다음 매퍼가 지원됩니다:
    - 16K/32K 고정 PRG ROM
        - [NROM](https://www.nesdev.org/wiki/NROM) (매퍼 0)
        - [CNROM](https://www.nesdev.org/wiki/CNROM) (매퍼 3, 185)
        - [CPROM](https://www.nesdev.org/wiki/CPROM) (매퍼 13)
    - 16K 뱅커블 PRG ROM
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1) (매퍼 1, 매퍼 16 포함)
        - [UxROM](https://www.nesdev.org/wiki/UxROM) (매퍼 2)
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4) (매퍼 10)
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512) (매퍼 30)
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068) (매퍼 67, 68)
        - 기타 매퍼 [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - 32K 뱅커블 PRG ROM
        - [AxROM](https://www.nesdev.org/wiki/AxROM) (매퍼 7)
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034) (매퍼 34)
        - [GxROM](https://www.nesdev.org/wiki/GxROM) (매퍼 66)
        - 기타 매퍼 [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - 8K 뱅커블 PRG ROM
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119) (매퍼 4, 118, 119)
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019) (매퍼 19)
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4) (매퍼 21, 22, 23, 25)
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1) (매퍼 64, 158)
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7) (매퍼 69)
        - [DxROM](https://www.nesdev.org/wiki/DxROM) (매퍼 [206](https://www.nesdev.org/wiki/INES_Mapper_206))
        - 기타 매퍼 [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- 디스어셈블리 내에 라벨과 메모리 블록을 추가하여, 디스어셈블된 ROM 내에서 쉽게 이동할 수 있습니다!

## 설치

1. 호환 가능한 Java 및 Ghidra 버전을 설치하세요 (Java 21 이상).
2. 최신 [GhidraNes 릴리스](https://github.com/kylewlacy/GhidraNes/releases)를 다운로드하세요. 다운로드하는 릴리스가 사용하는 Ghidra 버전과 일치하는지 확인하세요!
3. "파일" > "확장 기능 설치..."로 이동합니다. 오른쪽 상단의 "+"를 클릭하고 GhidraNes Zip을 선택합니다. "확인"을 클릭하여 확장 기능을 설치합니다.
4. Ghidra를 재시작합니다.

## 사용법

1. Ghidra에서 "파일" > "새 프로젝트..." 아래의 마법사를 따라 새 프로젝트를 만듭니다.
2. iNES `.nes` ROM 파일을 프로젝트로 드래그 앤 드롭합니다. 형식을 "NES ROM"으로 설정하고 "확인"을 클릭합니다.
3. 프로젝트에서 ROM을 더블 클릭하여 Ghidra의 CodeBrowser를 엽니다.
4. 프롬프트가 뜨면 파일을 분석하거나 ("분석" > "자동 분석...") 기본 설정으로 두고 "분석"을 클릭합니다.
5. 완료되면 게임이 디스어셈블됩니다! 왼쪽의 "심볼 트리" > "함수" 아래에서 `reset`을 열어 리셋 벡터(실행 시작 지점)로 이동하거나 `vblank`를 열어 NMI 벡터(VBlank 중 실행 지점)로 이동할 수 있습니다.

## 참고사항

### 뱅크 스위칭

GhidraNes는 ROM의 각 뱅크를 자체 메모리 블록에 매핑하지만 뱅크 스위칭을 자동으로 처리하는 제어 흐름 분석은 구현되어 있지 않습니다. 대신, 디스어셈블리에서 뱅크 스위칭을 수동으로 처리해야 합니다. 예를 들어 다음 함수는:

![Ghidra disassembly showing a "reset" function consisting of "LDA #0x0", "STA DAT_8000", and "JMP (0xfffc)=>reset". The gutter shows this function as an infinite loop](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)

이 디스어셈블된 함수는 뱅크 스위치를 수행합니다: `DAT_8000`에 쓰는 작업이 이 경우 PRG ROM을 뱅크 0으로 전환합니다. 이런 경우는 다음 단계로 Ghidra에서 수정할 수 있습니다:

1. `JMP` 명령어를 우클릭합니다.
2. "참조 > 추가/편집 (R)"을 클릭합니다.
3. 목적지 오퍼랜드를 더블 클릭합니다.
4. "주소로" 필드에서 왼쪽 드롭다운을 "RAM:"에서 적절한 메모리 뱅크("이 예에서는 PRG0::")로 변경합니다.
5. "업데이트"를 클릭합니다.

디스어셈블리에서 이제 올바른 뱅크로 점프하는 것이 표시됩니다:

![Ghidra disassembly showing the same "reset" function, but the "JMP" instruction now goes to "(0xfffc)=>LAB_PRG0__ffaf"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)

> 참고: 매퍼 레지스터에 대한 모든 쓰기 명령어(예: `STA`/`STX`/`STY`, `INC`/`DEC`)는 현재 실행 중인 코드가 포함된 뱅크가 교체되면 제어 흐름이 변경됩니다. 이를 수정하려면:
>
> 1. 쓰기 명령어를 우클릭합니다.
> 2. `Fallthrough`>`설정...`을 선택합니다.
> 3. 주소 오프셋 상자의 값을 기억합니다.
> 4. `사용자`를 선택하고 드롭다운에서 새 뱅크를 선택합니다.
> 5. 주소 오프셋 상자에 3단계에서 기억한 값을 설정합니다(PC가 새 뱅크에서 "다음" 명령어가 되기 때문입니다).
>
>이 방법은 분석과 디컴파일이 뱅크 스위치를 "따라가도록" 도와줍니다.
기본적으로, 32K 미만의 PRG 블록 크기를 가진 ROM은 마지막 뱅크를 제외하고 기본 주소가 `0x8000`으로 생성됩니다. (8K 블록은 `0xe000`, 16K는 `0xc000`의 "가장 높은" 주소에 위치합니다.) 각 뱅크가 어디에 있어야 하는지 미리 알고 있다면 로드 시 `Options...` 대화상자를 사용하여 각 뱅크의 주소를 설정할 수 있습니다. 나중에 추측이 틀렸다고 판단되어 ROM을 다시 가져오고 싶지 않다면, 메모리 맵 창을 사용해 뱅크의 기준 주소를 다시 설정할 수 있습니다:

1. 이미 열려있지 않다면 메뉴에서 `Window`>`Memory Map`을 선택합니다.
2. 변경하려는 뱅크가 있는 행을 선택합니다.
3. 메모리 맵 창 제목 표시줄에서 파란색 십자 아이콘("블록을 다른 주소로 이동")을 선택합니다.
4. "New Start Address"를 올바른 기준 주소로 변경합니다. "New End Address"는 블록 크기에 따라 자동으로 업데이트됩니다.
5. "OK"를 선택하면 뱅크가 업데이트됩니다.

## 개발

### Eclipse를 이용한 개발

1. Java와 Ghidra를 설치합니다.
2. Eclipse를 설치합니다.
3. GhidraDev Eclipse 플러그인을 설치합니다. 설치 지침은 Ghidra 설치 디렉터리 내 `Extensions/Eclipse/GhidraDev/GhidraDev_README.html`에서 확인할 수 있습니다.
4. Eclipse에서 "File" > "Open Projects from File System..."을 선택해 GhidraNes 저장소를 엽니다. "Directory"를 클릭하고 이 저장소(이 `README.md` 파일과 `GhidraNes` 하위 디렉터리가 포함된 최상위 폴더)를 선택합니다. 마지막으로 "Finish"를 클릭합니다.
5. "GhidraDev" > "Link Ghidra..."를 열어 Ghidra 설치를 추가하고 "Next >"를 클릭한 후 Java 프로젝트로 "GhidraNes"를 선택합니다. "Finish"를 클릭합니다.
6. "Run" > "Run As" > "Ghidra"를 선택하여 GhidraNes 확장과 함께 Ghidra를 실행합니다.

### Eclipse에서 릴리스 빌드하기

**참고:** GhidraNes Eclipse 프로젝트가 타겟팅할 _최초_ Java 버전으로 설정되어 있는지 확인하세요. 이후 버전의 Java를 사용하면 호환성 문제가 발생할 수 있습니다!

1. Gradle을 설치합니다 ([SDKMAN](https://sdkman.io/)을 사용하면 `sdk install gradle` 명령으로 설치 가능).
2. Eclipse에서 "GhidraDev" > "Export" > "Ghidra Module Extension..."을 엽니다. 프로젝트로 "GhidraNes"를 선택하고 "Next >"를 클릭한 뒤 "Local installation directory:"를 선택하고 Gradle 설치 디렉터리를 지정합니다 (SDKMAN을 사용하면 `~/.sdkman/candidates/gradle/$GRADLE_VERSION`에 위치). "Finish"를 클릭합니다.
3. 빌드된 zip 파일은 `GhidraNes/dist/` 디렉터리에 저장됩니다. 설치 방법은 "Installation" 섹션을 참조하세요.

### 다른 편집기(예: VS Code)로 개발하기

1. Java와 Ghidra를 설치합니다.
2. 편집기에서 JDK 설정을 구성합니다.
    - VSCode의 경우 공식 ["Getting Started with Java in VS Code"](https://code.visualstudio.com/docs/java/java-tutorial) 가이드를 따르세요.
3. `GhidraNes/gradle.properties.example` 파일을 `GhidraNes/gradle.properties`로 복사하고 Ghidra 설치 디렉터리를 필요에 따라 설정합니다.
4. GhidraNes 저장소를 Java 프로젝트로 가져옵니다 (`README.md` 파일과 `GhidraNes` 하위 폴더가 포함된 최상위 폴더).

### Gradle로 릴리스 빌드하기

1. 내부 `GhidraNes` 하위 디렉터리로 이동: `cd GhidraNes/GhidraNes`
2. `gradle buildExtension` 명령을 실행합니다.

    - `gradle.properties` 파일이 설정되지 않은 경우, 속성을 Gradle에 직접 전달할 수 있습니다. 예: `gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. 빌드된 zip 파일은 `GhidraNes/dist/` 디렉터리에 저장됩니다. 빌드된 zip 파일 설치에 대한 자세한 내용은 "설치" 섹션을 참조하세요.

## 릴리스 게시

1. `CHANGELOG.md`를 새 커밋으로 업데이트합니다.
2. 새 릴리스에 대한 태그를 만듭니다. 태그와 릴리스 이름은 현재 날짜 [UTC 기준](https://www.utctime.net/)에 따라 `vYYYYMMDD` 형식이어야 합니다 (예: `v20250520`)
3. 태그를 푸시합니다. 그러면 ["Release" GH Actions 워크플로](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml)가 트리거되어 몇 분 후 릴리스 노트와 빌드 자산이 포함된 새 [초안 릴리스](https://github.com/kylewlacy/GhidraNes/releases)를 생성합니다.
4. 빌드 자산이 제대로 생성되었는지 다시 확인하고, 필요하면 릴리스 노트를 조정하거나 추가한 후 게시하세요!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---