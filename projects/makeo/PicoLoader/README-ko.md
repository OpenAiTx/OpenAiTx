# PicoLoader
이것은 닌텐도 게임큐브용 ODE 기반 모드칩으로 홈브류 부팅을 지원합니다.\
가격과 기능은 [PicoBoot](https://github.com/webhdx/PicoBoot)과 매우 유사하지만 여러 가지 장점이 있습니다.

지원받고 모드를 논의하려면 [디스코드 서버](https://discord.gg/YtA9aU3BKZ)에 참여하세요!

## 작동 원리
이 모드는 부팅 중에 디스크 드라이브를 에뮬레이트하여 홈브류 앱을 실행하고 이후 디스크 드라이브를 다시 활성화합니다.\
이것은 FlippyDrive와 유사한 플렉스 PCB를 사용하여 구현됩니다.
그러나 완전한 광 드라이브 에뮬레이터가 아니며 PicoBoot처럼 플래시에서 작은 홈브류 앱(예: [swiss](https://github.com/emukidid/swiss-gc))만 실행할 수 있습니다.
SD 카드의 파일에 접근하려면 별도로 구입 가능한 SDGecko, SD2SP2 또는 유사 어댑터가 필요합니다.

## 특징
- 오픈 소스
- 디스크 드라이브 유지 가능
- [온라인 변환기](https://makeo.github.io/PicoLoader/converter/)를 사용해 대부분 홈브류 앱을 간단히 부팅 가능
- 게임큐브에 영구적인 수정 불필요
- 디스크 드라이브 없이 설치 가능한 [3D 프린트 플러그](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl)
- 쉽게 제거 가능
- 클론 보드와의 호환성을 위해 200MHz로 Pico 실행

#### 납땜형 버전
- 저렴하고 구하기 쉬운 부품 (라즈베리 파이 Pico/Pico 2 + 플렉스 PCB + 다이오드)
- 쉽게 구할 수 있음
- 게임큐브에 직접 납땜 불필요
- 납땜이 간단함
- 대체 설치 옵션: [파나소닉 Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option), [로우 프로파일](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)

#### 무납땜형 버전
- 납땜 불필요
- 쉽게 교체 가능한 플렉스 PCB
- PicoLoader 펌웨어와 [Swiss](https://github.com/emukidid/swiss-gc)가 사전 프로그래밍됨
> [!TIP]
> 무납땜형과 일반형 버전은 [store.makstech.io](https://store.makstech.io/)에서 구매할 수 있습니다.

## 예정된 기능
*귀뚜라미 소리*

## 설치 및 문서
> [!IMPORTANT]
> 위키의 [설치 지침](https://makeo.github.io/PicoLoader/)을 반드시 따라주세요.\
> 지침을 따르지 않으면 설치 중 플렉스 PCB가 손상될 수 있습니다.

📖[위키](https://github.com/makeo/PicoLoader/wiki/1.-Home)를 먼저 확인하여 시작하세요!

## 갤러리

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## 특별 감사
- 플렉스 PCB와 마운트 제작에 특히 도움을 준 [silversteel](https://github.com/silverstee1)님께 감사드립니다
- 드라이브 신호를 가로채기 위해 플렉스 PCB를 사용한 놀라운 아이디어를 제공한 [TeamOffBroadway](https://github.com/OffBroadway)님께 감사드립니다
- Swiss 개발에 참여한 [Extrems](https://github.com/Extrems), [emukidid](https://github.com/emukidid) 및 모든 분들께 감사드립니다
- gekkoboot 제작에 도움을 준 [novenary (9ary)](https://github.com/9ary)님께 감사드립니다

## 감사의 글
[gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) 및 [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr)의 소스는 GPL-2.0 라이선스로 제공되며 [여기](https://github.com/makeo/cubeboot-tools)에서 확인할 수 있습니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---