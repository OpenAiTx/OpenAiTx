[toc]

## 개요

이 저장소는 *Optical Wireless Communications System and Channel Modelling with MATLAB*와 관련된 소스 코드를 포함하고 있습니다.

**일부 원본 코드에 문제가 있어 수정이 필요했습니다. 실용성과 기능성을 향상시키기 위해 필요한 조정을 진행하였습니다.**



## MATLAB 버전

MATLAB R2024a

## 디렉토리 구조

- `util/` - 유틸리티 스크립트 및 함수.

## 일부 코드 설명

아래는 이 저장소에 포함된 MATLAB 스크립트의 목록입니다(전체는 아님):

| 이름                       | 설명                                                                                                        |
| ------------------------ | --------------------------------------------------------------------------------------------------------- |
| `CORRECT_plot_Fig3p31.m` | 감마-감마 확률 밀도 함수(PDF)                                                                              |
| `CORRECT_plot_Fig3p28.m` | 로그 정규 분포의 PDF                                                                                      |
| `CORRECT_program_4p4.m`  | 프로그램 4.4: On-Off Keying Non-Return-to-Zero (OOK-NRZ)의 비트 오류율(BER) 시뮬레이션 MATLAB 코드           |
| `CORRECT_program_4p5.m`  | 프로그램 4.5: 매치드 필터 기반 수신기를 사용한 OOK-NRZ의 BER 시뮬레이션 MATLAB 코드                        |
| `CORRECT_plot_Fig4p13.m` | 프로그램 4.10: 이산 펄스 간격 변조(DPIM)의 전력 스펙트럼 밀도(PSD)를 계산하는 MATLAB 코드 (0 가드 슬롯)    |

## 사용 방법

이 스크립트를 사용하려면 `util/` 디렉토리가 MATLAB 경로에 포함되어야 합니다. MATLAB 시작 스크립트에 아래 줄을 추가하거나 MATLAB 명령 창에 직접 실행하면 됩니다:

```matlab
addpath('path/to/util');
```

`'path/to/util'`을 `util/` 디렉토리의 실제 경로로 바꿔주세요.

## 기여 안내

이 저장소에 자유롭게 포크하고 풀 리퀘스트를 제출해 기여하실 수 있습니다. 개선 사항, 버그 수정, 추가 기능 모두 환영합니다.

## 감사의 말씀

이 프로젝트는 *Optical Wireless Communications System and Channel Modelling with MATLAB*을 기반으로 하고 있습니다. 원본 코드의 저자와 기여자 여러분께 특별히 감사드립니다.

---



### &#8627; Stargazers
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; Forkers
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---