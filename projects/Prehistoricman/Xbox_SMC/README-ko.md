
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
오리지널 Xbox에서 추출한 PIC16/Xyclops 덤프와 IDA 데이터베이스, 그리고 일부 리버스 엔지니어링 결과입니다.

![오리지널 Xbox의 PIC16LC63A 이미지](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops 플래싱 (XycloMod)
[Xyclops 디렉터리와 README](/Xyclops)를 참고하세요.

# 덤프
각 PIC 덤프의 .bin 파일은 IDA에 올바르게 로딩되도록 바이트가 교환되어 있습니다. 따라서 PIC 메모리의 첫 번째 워드는 byte_0 + byte_1 << 8입니다.

.idb IDA 데이터베이스에는 변수 정보와 데이터베이스 노트패드에 대한 몇 가지 관찰 내용이 있습니다.

SMC 버전의 분류는 이 위키 페이지를 참조하세요: https://xboxdevwiki.net/Xboxen_Info

## B2A
DVT3 Xbox에서 덤프되었습니다. P01과 동일한 구성 워드를 가지고 있습니다. 또한 프로덕션 PIC과 달리 구성 영역에 0000 0000 000B 002A 디바이스 ID가 기록되어 있습니다.

부트 챌린지가 완전히 빠져 있습니다.

## D01
XDK BETA 2 Xbox에서 덤프되었습니다. 부트 챌린지가 빠진 점을 제외하면 P01과 동일합니다. 예상 부트 챌린지 응답을 계산하는 함수는 여전히 있지만, 호출되지 않습니다.

## DXF
XDK D2 디버그 키트에서 덤프되었습니다. D01과 매우 유사하지만 트레이 로직, 과열 로직, 부트 로직이 약간 다릅니다. 부트 챌린지는 D01과 동일하게 누락되어 있습니다.

## D2E
Tuscany (v1.6) 개발 키트에서 덤프되었습니다. Xyclops 칩은 X01202-001로 표기되어 있으며, 리테일 유닛에 있는 A-A02 또는 A-B01 라인이 빠져 있습니다.

FC00의 디버그 시리얼 코드는 리테일 P2L 덤프와 일치합니다. 0x4000에서 0xFBFF까지 이상한 데이터 패턴이 있습니다.

## P01
v1.0 Xbox에서 덤프되었습니다. 구성 워드는 0x86입니다:
- CP1:CP0 = 0 (전체 메모리에 코드 보호 활성화)
- BODEN = 0 (브라운아웃 리셋 비활성화)
- ~PWRTE = 0 (파워업 타이머 활성화)
- WDTE = 1 (워치독 타이머 활성화)
- FOSC1:FOSC0 = 2 (HS 오실레이터)

SMC 클론에서 코드 보호가 활성화되지 않도록 0x3FB6 구성 값이 적합합니다.

## P11
v1.3 Xbox에서 덤프되었습니다. 구성 워드는 P01과 동일합니다.

P11은 P01에 비해 몇 가지 작은 변경사항이 있으며, 여기에는 추가 SMBus 명령(0x22 쓰기), 다른 LED 우선순위, 더 느슨한 부트 타이밍 등이 포함됩니다.

v1.3의 스크램블 덤프와 v1.4를 비교해봤고 일치했습니다. 이는 두 기기가 동일한 프로그램을 가질 가능성이 매우 높다는 것을 의미합니다.

## P2L
v1.6 Xbox에서 덤프되었습니다. Xyclops 리비전 A-A02입니다. Intel 8051 코드가 포함되어 있지만 기능이 알려지지 않은 특수 기능 레지스터가 많이 있습니다.

디버그 시리얼은 FC00의 코드에 의해 구동됩니다. 실행을 일시 정지하고, 데이터를 덤프하며, 레지스터/RAM에 쓰기 기능이 있는 조잡한 디버거처럼 보입니다.

# Xyclops 덤프

Xyclops 칩에는 '디버그'용으로 3개의 핀이 있습니다: TXD(핀 64), RXD(핀 63), 그리고 DEBUG(핀 29). DEBUG 핀을 High로 설정하면 TX와 RX 핀에서 시리얼 포트가 활성화됩니다. 시리얼은 9600 baud로 동작합니다.

프로토콜은 일반적으로 `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>` 형식의 4바이트 명령을 기반으로 합니다.

명령 0x14는 한 번에 64바이트의 BIOS 데이터를 덤프하고, 0x15는 한 번에 64바이트의 SMC 프로그램 데이터를 덤프합니다. Xyclops에서 덤프한 P2L.bin 파일이 저장소에 포함되어 있습니다. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py)도 포함되어 있으니 직접 덤프할 수 있습니다.

# PIC 덤프 방법론
전체 설명은 https://wiki.recessim.com/view/PIC_Burnout

PIC은 코드 보호가 활성화되어 있어서 모든 데이터가 0000으로 읽힙니다. 대신 스크램블된 데이터를 출력시키는 트릭을 사용했고, 희생용 칩을 통해 스크램블 알고리즘을 발견한 다음, 일종의 익스플로잇을 통해 ROM 데이터를 일부 비트를 알려진 값으로 고정하여 수정했습니다. 그런 다음 여러 번의 스크램블 덤프에서 필요한 정보를 추출하여 원본 데이터를 복원할 수 있습니다.

# PICProgrammer
PICProgrammer는 RP2040용으로 제가 연구에 사용한 몇 가지 Arduino 프로젝트 중 하나입니다. PIC에서 ICSP(인서킷 시리얼 프로그래밍) 작업을 실행할 수 있는 간단한 명령행 인터페이스를 제공합니다. 제조사가 의도하지 않은 작업을 할 수 있고, 유연성이 높아 PICkit 같은 목적형 프로그래머보다 선호됩니다.

전자공학과 프로그래밍에 대한 충분한 이해가 필요하며, 명령을 실행하기 전에 반드시 명령이 무엇을 하는지 꼼꼼히 살펴보시기 바랍니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---