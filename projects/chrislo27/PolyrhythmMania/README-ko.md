# 폴리리듬 매니아  
리듬 천국(リズム天国)의 *폴리리듬* 미니게임을 충실히 재현한 게임으로,  
내장된 레벨 에디터와 사이드 모드를 제공합니다.  

![폴리리듬 매니아 썸네일](https://user-images.githubusercontent.com/6299069/144956042-654ff2b3-aeba-4486-810e-f26aa1b33bff.png)  
![폴리리듬: 어셈블 사이드 모드 썸네일](https://user-images.githubusercontent.com/6299069/140859874-0552bb9a-c6dc-460b-a4a2-e35f99648ea9.png)  

[![다운로드 수](https://img.shields.io/github/downloads/chrislo27/PolyrhythmMania/total.svg)](https://github.com/chrislo27/PolyrhythmMania/releases/latest)  
[![GitHub 라이선스](https://img.shields.io/github/license/chrislo27/PolyrhythmMania.svg)](https://github.com/chrislo27/PolyrhythmMania/blob/dev/LICENSE.txt)  
[![프로젝트 메인테이너에게 기부하기](https://img.shields.io/badge/Donate-PayPal-blue.svg?logo=paypal)](https://www.paypal.com/donate?hosted_button_id=9JLGHKZNWLLQ8)  

[GENERIC이 제공하는 유튜브 오리지널 사운드트랙](https://www.youtube.com/playlist?list=PLt_3dgnFrUPwcA6SdTfi0RapEBdQV64v_)  

## 특징  
* 리듬 천국의 폴리리듬 미니게임을 완벽 재현, *그리고 그 이상!*  
* 40개 이상의 레벨이 포함된 완전한 *스토리 모드*  
* 라이브러리 기능을 통해 커스텀 레벨 정렬 및 관리 가능  
* 내장된 직관적인 레벨 에디터로 커스텀 레벨 제작 가능  
* 색상 팔레트 변경, 텍스트 박스 추가, 스킬 스타 배치 등 레벨 효과 지원  
* 클래식 GBA, 최신 HD, 아케이드 텍스처 간 전환 및 사용자 지정 텍스처 팩 추가 가능  
* 원작 GBA 게임 레벨로 폴리리듬 실력을 향상시키는 연습 모드  
* 끝없이 이어지는 절차 생성 패턴으로 긴장감을 유지하는 무한 모드  
* 일반 무한 모드에서 볼 수 없는 패턴 시리즈가 포함된 데일리 챌린지 모드와 온라인 리더보드  
* _폴리리듬: 덩크_, _폴리리듬: 어셈블_, _빌트 투 스케일: 솔리테어_와 같은 추가 사이드 모드로 폴리리듬 재미 확장  

[v1.2 업데이트 트레일러를 유튜브에서 확인하세요!](https://www.youtube.com/watch?v=I4BXu7sNj-M)  
[공식 발표 트레일러를 유튜브에서 확인하세요!](https://www.youtube.com/watch?v=A3ZUBIy_MAQ)  
[2021년 8월 기능 트레일러를 확인하세요!](https://www.youtube.com/watch?v=k9PtPI1-tDo)  

## 플레이를 위한 시스템 요구사항  
**공식 지원 운영체제:** Windows 10 이상, Linux (x86-64 및 ARM).  

> macOS는 공식적으로 지원되지 않습니다(즉, macOS에서 버그 리포트는 받지 않음).  
> 하지만 [이슈 #29](https://github.com/chrislo27/PolyrhythmMania/issues/29)를 참고하여 실행 시도는 가능합니다.  

**시스템 사양:** [*Minecraft: Java Edition*과 유사한 요구사항](https://help.minecraft.net/hc/en-us/articles/4409225939853-Minecraft-Java-Edition-Installation-Issues-FAQ#h_01FFJMSQWJH31CH16H63GX4YKE)이 적용되며,  
동일한 그래픽 라이브러리(GLFW와 OpenGL 4.4)를 사용하기 때문입니다.  

### 최소 요구사항  
* CPU: Intel Core i3-3210 3.2 GHz / AMD A8-7600 APU 3.1 GHz 또는 이에 준하는 사양  
* RAM: 4GB 
* GPU (통합): Intel HD Graphics 4000 (Ivy Bridge) 또는 AMD Radeon R5 시리즈 (Kaveri 라인) OpenGL 4.4 지원
* GPU (독립형): NVIDIA GeForce 400 시리즈 또는 AMD Radeon HD 7000 시리즈 OpenGL 4.4 지원 
* HDD: 게임 및 레벨용 최소 1GB 
* OS: Windows 10 이상, 2018년 이후 배포된 64비트 Linux 배포판
* 디스플레이: 1280x720 해상도

### 권장 사양
* CPU: Intel Core i5-4690 3.5GHz / AMD A10-7800 APU 3.5 GHz 또는 동급 
* RAM: 8GB 
* GPU: NVIDIA GeForce 700 시리즈 또는 AMD Radeon Rx 200 시리즈 (통합 칩셋 제외) OpenGL 4.5 지원 
* HDD: 2GB (SSD 권장) 
* OS: Windows 10 이상 (64비트), 2020년 이후 배포된 64비트 Linux 배포판 (예: Ubuntu 20.04) 
* 디스플레이: 1920x1080 해상도

## 설치 지침
처음 게임을 다운로드하거나 새 버전으로 업그레이드할 때 동일한 지침입니다.
위 시스템 요구 사항을 충족하는지 확인하십시오.

__Windows (64비트 전용, Java 설치 불필요):__
1. 새 탭 또는 창에서 [최신 릴리스 페이지](https://github.com/chrislo27/PolyrhythmMania/releases/latest)로 이동합니다.
2. Assets 섹션에서 `PolyrhythmMania_VERSION_win64.zip` 파일을 다운로드합니다. 여기서 VERSION은 릴리스 버전 이름입니다. **파일명에 "win64"가 포함된 것을 확인하세요.** "Source code"는 다운로드하지 마십시오.
3. 파일 탐색기에서 다운로드한 zip 파일을 찾습니다. zip 파일을 추출하려면, 다운로드한 zip 파일을 마우스 오른쪽 버튼으로 클릭하고 "모두 추출..."을 선택하여 폴더에 내용을 추출합니다.
4. 새로 추출된 폴더를 열고 `PolyrhythmMania_win64` 폴더로 이동합니다.
5. `LaunchPolyrhythmMania.exe` 실행 파일을 더블 클릭하여 게임을 시작합니다! (Java Runtime Environment가 설치되어 있지 않아도 됩니다. 게임에 포함되어 있습니다.)
6. Windows Defender에서 "Windows Defender SmartScreen이 인식되지 않은 앱의 시작을 차단했습니다"라는 메시지가 표시되면, "자세히"를 클릭한 후 "그래도 실행"을 클릭하여 무시할 수 있습니다.

__기타 플랫폼 (또는 이미 Java가 설치된 고급 사용자용)__
1. **(필수)** Java Runtime Environment (JRE 17 권장, JRE 11 최소)가 설치되어 있으며 `java` 명령어로 경로에서 접근 가능한지 확인합니다.
2. 새 탭 또는 창에서 [최신 릴리스 페이지](https://github.com/chrislo27/PolyrhythmMania/releases/latest)로 이동합니다.
3. Assets 섹션에서 `PolyrhythmMania_VERSION.zip` 파일을 다운로드합니다. 여기서 VERSION은 릴리스 버전 이름입니다. "Source code"는 다운로드하지 마십시오.
4. zip 파일을 알기 쉬운 위치에 추출합니다.
5. 새로 추출된 디렉토리를 열고 `PolyrhythmMania_platform_agnostic` 디렉토리로 이동합니다.
6. 적절한 실행 스크립트를 실행합니다: Windows에서는 `play_windows.bat`를 더블 클릭, Linux에서는 `play_linux.sh`를 실행합니다 (먼저 `chmod +x play_linux.sh` 명령어로 실행 권한을 부여해야 할 수 있습니다).
7. 실행 스크립트를 사용하지 않으려면, 선호하는 설정과 함께 `java -jar bin/PolyrhythmMania.jar` 명령으로 실행할 수 있습니다.

## 컴파일 지침
이 지침은 게임 소스 코드를 수정하려는 분들을 위한 것입니다.

1. JDK 17 이상이 설치되어 있는지 확인하십시오.
2. `chmod +x gradlew`
3. `./gradlew :desktop:run`

## 기타 정보
리듬 천국은 닌텐도의 지적 재산입니다.
이 프로그램은 닌텐도에 의해 어떠한 방식으로도 승인되거나 후원되지 않았습니다.
이 소프트웨어에 사용된 닌텐도의 모든 자산(이름, 오디오, 그래픽 등)은 상표권을 악의적으로 침해할 의도가 없습니다.
모든 다른 상표 및 자산은 각 소유자의 재산입니다.
이 프로젝트는 커뮤니티 프로젝트이며, [GPL-3.0 라이선스](LICENSE)에 따라
무료로 다른 사람들이 사용할 수 있도록 제공됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-31

---