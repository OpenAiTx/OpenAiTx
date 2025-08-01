![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**Tests:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## ioBroker용 vw-connect 어댑터

VW We Connect, We Connect ID, We Charge, myAudi, Skoda Connect, Seat Connect 및 We Connect Go용 어댑터입니다.

Node 10에서 시스템을 업데이트하십시오.
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## 사용법

원격 제어 상태를 사용하여 차량을 원격으로 제어하세요.
일반 새로 고침은 VAG 클라우드에서 데이터를 수신하기 위한 폴링 간격입니다.
강제 새로 고침은 비전기차용으로 새로 고침을 강제로 수행하는 기능이며, 차량이 다시 켜질 때까지 VAG에서 이 횟수를 제한합니다.
주행 데이터는 비전기차에만 제공됩니다.

다음 위치에서 실내 온도 설정을 할 수 있습니다.
.climater.settings.targetTemperature.content

## 토론 및 질문

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## 상태 필드 설명

### 항목 목록

```

```
## 변경 로그

### 0.7.12 (2025-05-05)

- 스코다 리프레시 토큰 수정
- 환기 활성화 수정
- 새로 지원하지 않는 엔드포인트 추가

### 0.7.9 (2025-03-20)

- ID 월 차저 수정

### 0.7.7 (2025-03-02)

- 스코다 보조 난방 및 지속 시간 수정
- 스코다 잠금/잠금 해제 수정

### 0.7.6 (2025-02-28)

- 시작 시에만 충전 상태 업데이트 수정
- 스코다 이동 중 상태 수정

### 0.7.3 (2025-02-26)

- 설정 온도 설정 수정
- 스코다 잠금 해제 및 잠금 수정

### 0.7.0 (2025-02-25)

- 스코다 및 시트 수정
- 상태 구조 완전히 변경됨. 기존 상태는 객체에서 삭제하세요.

### 0.6.1 (2024-10-01)

- 스코다 로그인 수정

### 0.6.0 (2024-04-11)

- 추가 컵라 상태 추가

### 0.5.4 (2024-03-17)

- 도어 윈도우 상태 수정

### 0.4.1

- VW 상태 업데이트 수정

### 0.0.65

- 컵라 로그인 수정

### 0.0.63

- VW/스코다 이트론 로그인 수정

### 0.0.62

- 아우디 이트론 로그인 수정

### 0.0.61

- ID 로그인 수정

### 0.0.60

- 소소한 개선. WeCharge 최소 간격이 이제 15분입니다.

### 0.0.55

- ID 상태 업데이트 수정

### 0.0.51

- 아우디 이트론 로그인 수정

### 0.0.48

- 로그인 수정, 아우디 업데이트 수정, 월박스 제한 추가

### 0.0.43

- 리프레시 토큰 타임아웃 증가

### 0.0.42

- 스코다 로그인 수정

### 0.0.40

- 최신 차량용 기후 v3 추가. 파워패스 및 시트 엘리 추가

### 0.0.39

- ID 로그인 수정

### 0.0.36

- 스코다 에냐크 지원 추가

### 0.0.35

- nodeJS v10 호환성 추가

### 0.0.34

- 새로운 개인정보 동의 자동 수락 추가

### 0.0.32

- 최근 여행 마지막 선택 수정

### 0.0.31

- 여행 유형 다중 선택 활성화

### 0.0.30

- 다중 차량 문제 수정, 현재 VW와 VWv2 간 차이 없음, VWv2 모드 추가

### 0.0.29

- skoda 리프레시 토큰 수정, 소규모 개선

### 0.0.26

- 버그 수정

### 0.0.25

- we charge 추가

### 0.0.24

- 원격 상태 업데이트 추가

### 0.0.23

- Seat 및 새로운 climatisation v2 추가

### 0.0.22

- Skoda와 Audi에 대해서도 외부 온도를 °C로 계산

### 0.0.21

- id용 원격 추가

### 0.0.20

- audi 로그인 수정, ID 로그인 추가

### 0.0.19

- 상태 객체를 연속 번호 대신 id로 상태에 저장

### 0.0.18

- 2020 모델 배터리 상태 수정

### 0.0.17

- 2020 모델 지원 추가

### 0.0.16

- js.controller 3 문제 수정

### 0.0.11

- 다중 차량 관련 audi 버그 수정
- 기능이 없을 경우 상태 업데이트 오류 숨김

## 라이선스

MIT 라이선스

저작권 (c) 2019-2030 ta2k <tombox2020@gmail.com>

이 소프트웨어 및 관련 문서 파일(이하 "소프트웨어")의 사본을 획득한 모든 사람에게 무료로 사용, 복사, 수정, 병합, 출판, 배포, 서브라이선스 및 판매할 권한을 무제한으로 허가하며, 소프트웨어가 제공된 사람에게도 이와 같은 권한을 부여합니다. 단, 다음 조건을 준수해야 합니다:

위 저작권 표시와 이 허가 표시를 소프트웨어의 모든 복사본 또는 주요 부분에 포함해야 합니다.

소프트웨어는 명시적이거나 묵시적인 보증 없이 "있는 그대로" 제공되며, 상품성, 특정 목적 적합성 및 비침해에 대한 보증을 포함하되 이에 국한되지 않습니다. 저자나 저작권자는 계약 행위, 불법 행위 또는 기타 행위에 의한 손해나 기타 책임에 대해 어떠한 책임도 지지 않습니다. 소프트웨어 사용 또는 기타 거래와 관련하여 발생하는 모든 청구, 손해 또는 기타 책임에 대해 책임을 지지 않습니다.















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---