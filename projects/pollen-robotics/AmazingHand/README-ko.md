Project는 [Apache 2.0](https://www.apache.org/licenses/LICENSE-2.0) 라이선스하에 있습니다.


기계 설계는 다음 라이선스를 따릅니다 :
[Creative Commons Attribution 4.0 International License][cc-by].
[![CC BY 4.0][cc-by-image]][cc-by]
[![CC BY 4.0][cc-by-shield]][cc-by]

[cc-by]: http://creativecommons.org/licenses/by/4.0/
[cc-by-image]: https://licensebuttons.net/l/by/4.0/88x31.png
[cc-by-shield]: https://img.shields.io/badge/License-CC%20BY-lightgrey.svg



# Amazing Hand 프로젝트

![패턴](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Patterns_Overview.jpg)

로봇 핸드는 종종 매우 비싸고 표현력이 부족합니다. 더 정교한 동작은 종종 케이블과 팔뚝에 분리된 액추에이터가 필요합니다.

이 프로젝트의 목표는 실제 로봇에서 휴머노이드 손의 가능성을 탐색하는 것입니다 (Reachy2가 완벽한 후보입니다!) 적당한 비용으로.
=> 손목 인터페이스는 Reachy2의 손목(Orbita 3D)에 맞게 설계되었지만, 다른 로봇 손목에도 쉽게 적응할 수 있습니다...

![Reachy](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Reachy.jpg)

Amazing Hand는 :
- 4개의 손가락을 가진 8 자유도 휴머노이드 손
- 각 손가락은 2개의 마디가 연결되어 있음
- 거의 모든 곳에 유연한 셸 적용
- 모든 액추에이터가 손 내부에 위치, 케이블 없음
- 3D 프린트 가능
- 무게 400g
- 저비용(<200€)
- 오픈소스

[AmazingHand_개요](/docs/AmazingHand_Overview.pdf)

![손 개요](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Hand_Overview.jpg)
각 손가락은 병렬 메커니즘으로 구동됩니다.
즉, 각 손가락을 굽힘/신전 및 벌림/모음 동작을 위해 2개의 작은 Feetech SCS0009 서보가 사용됩니다.

![손가락 개요](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Finger_Overview.jpg)


2가지 제어 방식이 제공됩니다 :
- 직렬 버스 드라이버(예: waveshare) + 파이썬 스크립트 사용
- 아두이노 + feetech TTL Linker 사용

두 방식에 대한 자세한 설명과 기본 데모 소프트웨어도 제공됩니다.
선택은 여러분의 몫입니다!


## 목차

- [빌드 리소스](#build-resources)
    - [BOM (자재 명세서)](#bom-bill-of-materials)
    - [CAD 파일 및 Onshape 문서](#CAD-files-and-onshape-document)
    - [조립 가이드](#assembly-guide)
    - [기본 데모 실행](#Run-basic-Demo)
- [면책 조항](#disclaimer)
- [AmazingHand_트래킹 데모](#AmazingHand_tracking_Demo) 
- [프로젝트 업데이트 & 커뮤니티](#project-updates--community)
    - [업데이트 이력](#updates-history)
    - [프로젝트 게시물](#project-posts)
    - [할 일 목록](#to-do-list)
    - [자주 묻는 질문(FAQ)](#faq)
    - [연락처](#contact)
    - [감사 인사](#thank-you)


# 빌드 리소스
## BOM (자재 명세서)
필요한 모든 부품 목록은 여기에서 확인할 수 있습니다:  
[AmazingHand BOM](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342)  
![BOM](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/BOM.jpg)

그리고 제어 방식 선택 비용도 추가하는 것을 잊지 마세요 (앞서 설명한 2가지 옵션)


맞춤형 3D 프린트 부품에 대한 자세한 내용은 다음과 같습니다 : 
[3D 프린트 부품](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=2050623549#gid=2050623549)

![3D 부품](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/3Dparts.jpg)

필요한 모든 맞춤 부품을 출력하는 방법을 설명하는 가이드입니다 :
[=> 3D 프린팅 가이드](/docs/AmazingHand_3DprintingTips.pdf)
![3D프린팅_예시](/assets/3DPrint.jpg) 



## CAD 파일 및 Onshape 문서
STL 및 Steps 파일은 [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/cad)에서 찾을 수 있습니다. 

왼손을 만들고자 할 경우 손가락은 동일하지만 일부 부품은 대칭입니다. 오른손 전용 부품은 "R"로 시작하며, 왼손 부품은 "L"로 시작합니다.

![하트](/assets/Heart.jpg)

누구나 Onshape 문서에 접근할 수 있습니다 :   
[Onshape 링크](https://cad.onshape.com/documents/430ff184cf3dd9557aaff2be/w/e3658b7152c139971d22c688/e/bd399bf1860732c6c6a2ee45?renderMode=0&uiState=6867fd3ef773466d059edf0c)  

사전 정의된 위치는 "named position" 도구에서 사용 가능하며, 해당하는 서보 각도와 함께 제공됩니다.

![Onshape&Named_Pos](/assets/Named_Pos.jpg)  

## 조립 안내

BOM의 표준 부품과 함께 Amazing Hand 조립 안내는 여기에서 확인할 수 있습니다:  
[=> 조립 안내](/docs/AmazingHand_Assembly.pdf)  
![Assembly_example](/assets/Assembly.jpg)  

각 손가락을 보정하기 위한 간단한 프로그램/스크립트가 필요하며, 다음에서 이용 가능합니다:
- Python & Waveshare 시리얼 버스 드라이버 사용 : [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)
- Arduino & TTLinker 사용 : [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)


이 조립 안내는 독립형 오른손용임을 참고하세요.

독립형 왼손을 제작해야 하는 경우, 서보 위치에 동일한 ID를 유지하고 소프트웨어에서 오른손 또는 왼손을 선택할 수 있습니다.

하지만, 로봇에 오른손과 왼손을 모두 연결해야 하는 경우, 오른손과 왼손에 서로 다른 ID를 부여해야 합니다. 동일한 시리얼 버스에서 서로 다른 서보에 같은 ID를 사용할 수 없습니다...

## 기본 데모 실행

기본 데모는 Python과 Arduino 모두에서 사용할 수 있습니다.

손 내부의 8개 액추에이터에 전원을 공급하기 위해 외부 전원 공급 장치가 필요합니다.

이미 가지고 있지 않다면, 간단한 외부 전원 공급 장치는 DC/DC 220V -> 5V / 2A 어댑터와 잭 커넥터일 수 있습니다.
BOM 목록을 확인하세요:
[AmazingHand BOM](https://docs.google.com/spreadsheets/d/1QH2ePseqXjAhkWdS9oBYAcHPrxaxkSRCgM_kOK0m52E/edit?gid=1269903342#gid=1269903342) 

- Python 스크립트 : "AmazingHand_Demo.py" [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/ArduinoExample)
  
- Arduino 프로그램 : "AmazingHand_Demo.ino" [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/PythonExample)


https://github.com/user-attachments/assets/485fc1f4-cc57-4e59-90b5-e84518b9fed0


# 면책 조항

Flexion / Extension, Abduction / Adduction 이론 각도와 실제 프로토타입 각도 간에 차이가 있음을 확인했습니다. 이는 여러 변동 원인(3D 프린팅 부품의 불완전성, 볼조인트 로드의 수동 조정, 서보 혼 리워크, 플라스틱 부품의 유연성 등) 때문일 가능성이 큽니다.

이 설계는 아직 장시간 및 복잡한 파지 작업에 대해 테스트되지 않았습니다. 안전하게 물체를 잡기(서보나 기계 부품 손상 없이)를 위해서는 스마트 소프트웨어가 구축되어야 합니다.
SCS0009 서보는 다음과 같은 스마트 기능을 갖추고 있습니다:
- 토크 활성화 / 비활성화
- 토크 피드백
- 현재 위치 센서
- 열 온도 피드백
- ...


# AmazingHand 고급 데모
[![트래킹 데모](https://img.youtube.com/vi/U0TfeG3ZUto/maxresdefault.jpg)](https://www.youtube.com/watch?v=U0TfeG3ZUto)

역기구학/순기구학을 사용하는 고급 활용을 위해 [Demo](Demo) 디렉토리에 여러 예제와 모터 테스트/구성에 유용한 도구들이 포함되어 있습니다.


# 프로젝트 업데이트 및 커뮤니티
## 커뮤니티 업데이트

Amazing Hand용 Amazing Base : 
![Base](https://raw.githubusercontent.com/pollen-robotics/AmazingHand/main/assets/Base.jpg)
STL 또는 Step 파일은 [여기](https://github.com/pollen-robotics/AmazingHand/tree/main/cad)에서 찾을 수 있습니다. 

특정 중국용 BOM은 여기에서 확인하세요:
[Chinese BOM](https://docs.google.com/spreadsheets/d/1fHZiTky79vyZwICj5UGP2c_RiuLLm89K8HrB3vpb2h4/edit?gid=837395814#gid=837395814)

감사합니다, Jianliang Shen님!

## 할 일 목록
- 시리얼 허브 및 전원 공급 기능이 포함된 작은 맞춤형 PCB 설계, 모든 부품을 손 안에 맞추기 위해
- 파지 작업 테스트  
      => 사용 가능한 모터 피드백 기반으로 손 닫기 동작을 더 스마트하게 추가
- 4가지 다른 손가락 길이 가능성 연구, 또는 5번째 손가락 추가
- SCS0009 대신 STS3032 피티드치 모터 사용 가능성 연구  
      => 거의 동일한 부피에 더 강력하지만, 서보 혼이 다름
- 강체 링크를 스프링으로 대체하여 컴플라이언시 추가 가능성 연구
- 스마트 제어를 한 단계 높이기 위한 손끝 센서 추가


## FAQ
작업 진행 중

## 연락처

공개 Discord 채널에 접속할 수 있습니다:  
[Discord AmazingHand](https://discord.com/channels/519098054377340948/1395021147346698300)

또는  
[나 또는 Pollen Robotics에 연락하기](/docs/contact.md)

## 감사 인사
지금까지 이 프로젝트에 기여해 주신 분들께 큰 감사를 드립니다:
- [Steve N'Guyen](https://github.com/SteveNguyen) : 베타 테스트, Rustypot 내 Feetech 모터 통합, Mujoco/Mink 및 핸드 트래킹 데모
- [Pierre Rouanet](https://github.com/pierre-rouanet) : pypot 내 Feetech 모터 통합  
- [Augustin Crampette](https://fr.linkedin.com/in/augustin-crampette) & [Matthieu Lapeyre](https://www.linkedin.com/in/matthieulapeyre/) : 열린 토론 및 기계적 조언


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---