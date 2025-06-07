## FanImeTsf

이것은 [FanImeServer](https://github.com/fanlumaster/FanImeServer)의 TSF 엔드입니다.

알림: 현재 64비트 앱만 지원합니다.

## 빌드 방법

### 필수 조건

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

vcpkg와 gsudo가 **Scoop**으로 설치되어 있는지 확인하십시오.

## 빌드 단계

### 빌드

먼저, 저장소를 클론합니다.

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

그 다음, 환경을 준비합니다.

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

그리고, 빌드합니다.

```powershell
.\scripts\lcompile.ps1
```

### 설치

파워셸을 관리자 권한으로 실행하고, 시스템의 `Enable sudo` 옵션이 활성화되어 있는지 확인하십시오.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

그런 다음, `C:\Program Files\`에 `FanImeTsf`라는 폴더를 만들고, `FanImeTsf.dll` 파일을 복사합니다.

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

그런 다음, 설치합니다.

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### 제거

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## 스크린샷

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## 로드맵

현재 샤오허 쌍병만 지원합니다.

### 중국어

- 샤오허 쌍병
- 전음(Quanpin)
- 한자 부수 사용 시 도움 코드
- 사용자 정의 가능한 사전
- 사용자 정의 IME 엔진
- 사용자 정의 스킨
- 간체/번체 전환
- 영어 자동 완성
- 오픈소스 클라우드 IME API
- 후보창 UI를 세로/가로 모드로 전환
- 기능 스위치: 대부분의 기능은 사용자가 자유롭게 전환하거나 사용자 정의할 수 있어야 합니다.

### 일본어 지원

아마도 별도의 프로젝트로 진행될 수 있습니다.

그리고 다른 언어 지원도 추가될 수 있습니다.

### 참고 자료

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---