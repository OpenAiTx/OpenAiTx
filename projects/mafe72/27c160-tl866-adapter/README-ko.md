# 27C322/160/800/400 EPROM 프로그래밍 어댑터 시리즈

![GitHub issues](https://img.shields.io/github/issues-raw/mafe72/27c160-tl866-adapter?logo=Github&style=for-the-badge)

## 소개

이 어댑터는 아래에 나열된 부품들의 핀 배열(동시대 DIP 패키지 마스크 ROM과 유사)을 TL866 시리즈 USB 프로그래머가 지원하는 27C4096 핀 배열로 변환합니다.

지원하는 EPROM 부품은 다음과 같습니다:
- **27C400:** 40핀, 4Mbit (256k x 16비트, 512k x 8비트)
- **27C800:** 42핀, 8Mbit (512k x 16비트, 1M x 8비트)
- **27C160:** 42핀, 16Mbit (1M x 16비트, 2M x 8비트)
- **27C322:** 42핀, 32Mbit (2M x 16비트, 8비트 접근 모드 없음)

## 설계

이 어댑터는 KiCad 5.0을 사용하여 설계되었으며, 프로젝트 파일은 kicad-project 폴더에서 찾을 수 있습니다.

상단면:

![top](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/front_th.png)

하단면:

![bottom](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/back_th.png)

## 사용법

소켓 핸들이 서로 인접하도록 어댑터를 TL866에 삽입합니다. EPROM은 어댑터의 가장 낮은 위치에 삽입하며, 핀 1이 핸들에 가장 가까이 오도록 합니다.

![Adapter when in use](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/adapter_in_use.jpg)

만약 27C322 EPROM을 프로그래밍한다면 스위치를 **Position 27c322**로 이동시키고, 27C160, 27C400, 27C800 EPROM의 경우 스위치는 **Position other**에 있어야 합니다.

![Adapter mode](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/addapter_mode.jpg)

## 소프트웨어

다음 지침은 27c160 EPROM을 쓰는 방법을 설명합니다.

소스 EPROM을 512K바이트 단위로 분할합니다. 이 경우 HJSplit을 사용하지만 다른 프로그램도 사용할 수 있습니다.

![HJSplit](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/hjsplit_512k.jpg)

출력 경로를 지정하면, 이 예제에서는 ".001" - ".004" 확장자를 가진 512K바이트 크기의 네 개 파일이 생성됩니다.

MiniPro 소프트웨어를 실행하고 `AMD 27C4096 DIP40` 장치를 선택하며, `Check ID` 선택을 해제하고 `Pulse Delay`를 `50us`로 설정합니다. EPROM 데이터시트와 프로그래밍 성공 여부에 따라 `VPP Voltage`를 `12.50V`로 줄이는 것도 선택 사항입니다.

![MiniPro Software Configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/minipro.jpg)

EPROM은 이제 DIP 스위치에 의해 구성된 대로 27C4096 장치처럼 512kB씩 접근할 수 있습니다:

- **27C400:** 한 번에 512kB 전체를 프로그래밍.
- **27C800:** 2회에 걸쳐 512kB씩 프로그래밍.
- **27C160:** 4회에 걸쳐 512kB씩 프로그래밍.
- **27C322:** 8회에 걸쳐 512kB씩 프로그래밍.

DIP 스위치 구성은 다음 표를 참고하세요:

![DIP Switch configuration](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/dip_config.png)

## 문제 해결

프로그래밍 중 쓰기 또는 검증 오류가 발생하면 다음 단계를 시도하세요:

1. 프로그래밍 전에 EPROM이 완전히 비어 있는지 확인하세요 (`Device -> Blank Check`). 오늘날 사용 가능한 모든 EPROM은 중고 '리드'이며, 판매자가 재판매 전에 지우는 데 항상 신경 쓰지 않습니다.

2. 어댑터의 ZIF 레버를 몇 번 열고 닫으며 EPROM을 소켓에 정확히 다시 위치시키세요.

3. `VPP Voltage`를 `12.50V`에서 `13.50V` 사이로 조정해 보세요. 주관적으로, 더 높은 전압에서 성공률이 더 높았으며, 이는 어댑터의 로직을 통해 VPP를 전달하는 동안 전압 손실에 여유를 줍니다.

4. 프로그래밍 오류는 가끔 발생하며, 장치가 클수록 확률이 높아집니다. UV 이레이저에 투자하는 것이 합리적입니다. 이들은 이베이에서 약 15~20달러에 저렴하게 구할 수 있습니다. 대부분의 장치는 UV 조명 아래 10~20분 후에 지워집니다.

5. [Maillouski](https://github.com/Maillouski/)는 Xgpro v12.38이 AT27C4096의 기본 VDD Write 값을 6.60V로 설정한다고 보고했습니다. 프로그래밍 문제를 피하려면 이 값을 3.30V로 변경하세요.

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/vdd_3v30.png)

6. [Tim aka BeepFixer](https://x.com/@beepfixer)는 AliExpress에서 구한 **27C160** 변종의 프로그래밍 값을 공유합니다.

   주요 차이점은 UV 윈도우 패드 구성입니다. 이를 타입 A, B, C라고 부릅니다.
    - **유형 A**: 사용 가능한 창 공간의 중앙만 사용하는 2x2 패드 
    - **유형 B**: 사용 가능한 창 공간 대부분을 사용하는 2x2 패드 
    - **유형 C**: 2x4 패드

![IC Config Information VDD Write](https://raw.githubusercontent.com/mafe72/27c160-tl866-adapter/master/images/m27c160_variants.jpg)

**테스트 결과**

  **유형 A**: 10개 중 2개 칩은 약간의 조정이 필요했습니다- 권장 설정 외에 약간의 조정(50us에서 100us 변경)으로 프로그래밍 및 검증이 가능해졌습니다. 확실히 하기 위해 사용된 전체 설정은 다음과 같습니다: VPP 전압: 13.50V / VCC 검증: 5.00V / VDD 쓰기: 5.00V / 펄스 지연: 100us. 펄스 지연이 100us이고 50us가 아니면 다른 전압에서도 성공했습니다.

  **유형 B**: 10개 중 7개 칩은 완벽하게 작동했습니다- 첫 시도에 Eladio 권장 설정(50us)으로

  **유형 C**: 10개 중 1개 칩은 크게 실패했습니다. 읽기와 지우기는 잘 되고 단어 하나를 쓸 수는 있지만, 한 단어를 쓴 후에는 더 이상 쓰기를 거부합니다. 아마도 오래된, 더 엄격한 변종일 것입니다; 고장이 아니라 실리콘 까다로운 칩입니다. 여러 설정으로 여러 번 시도했지만 전체 배치를 쓰는 데 성공하지 못했습니다.

**실용 팁**

   - 프로그래밍 후 항상 검증하세요. 
   - 어댑터 GitHub에 언급된 전압 차이도 시도해 보세요.
   - 그리고 파일 쓰기 순서를 주의하세요; 어댑터를 사용해 이미지를 4섹션으로 나누어 쓸 때, 잘못된 파일을 잘못된 뱅크에 쓰기 쉽습니다 (실제로 저도 한 번 파일 3을 뱅크 3과 4에 쓴 적이 있습니다). 그러니 대상 장치의 EPROM을 꼭 검증하세요!

## 하드웨어 변경 기록

R_20231123

* EDG-03 DIP 스위치의 올바른 극성 수정.
* 리비전 번호를 R_20231123으로 업데이트
* 버전 번호를 1.1로 업데이트

V_20180919

* 초기 릴리스.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---