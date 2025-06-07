# mimotion
![ 걸음 수 조작](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# 샤오미 운동 자동 걸음 수 조작

> 샤오미 운동 자동 걸음 수 조작

## Github Actions 배포 가이드

### 1. 이 저장소를 Fork하기

### 2. 계정과 비밀번호 설정
# 20230224추가
**CONFIG**라는 이름의 변수를 추가: Settings-->Secrets-->New secret, 아래 json 템플릿을 사용하여 다중 계정 구성, 이메일, 휴대폰번호 지원
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, 없으면 비워두세요",
  "TG_USER_ID": "telegram TG_USER_ID, 없으면 비워두세요",
  "SKEY": "쿨푸시 skey, 없으면 비워두세요",
  "SCKEY": "server酱 sckey, 없으면 비워두세요",
  "POSITION": "기업 위챗 푸시 사용 여부, 없으면 비워두세요",
  "CORPID": "기업 ID, 기업 위챗 로그인 후 내 기업-->기업 정보에서 확인, 없으면 비워두세요",
  "CORPSECRET": "기업 위챗 자체 앱의 secret, 각 앱마다 별도의 secret, 없으면 비워두세요",
  "AGENTID": "기업 위챗 자체 앱 ID, 따옴표 없이 정수값, AgentId, 없으면 비워두세요",
  "TOUSER": "메시지 수신 회원 지정, 회원 ID 리스트(여러 명은 ”&#166;”로 구분, 최대 1000명). 특수: ”@all”이면 전체 회원에게 발송, 없으면 비워두세요",
  "TOPARTY": "메시지 수신 부서 지정, 부서 ID 리스트, 여러 명은 ”&#166;”로 구분, 최대 100명. touser가 ”@all”이면 ”@all”로 작성, 없으면 비워두세요",
  "TOTAG": "메시지 수신 태그 지정, 태그 ID 리스트, 여러 명은 ”&#166;”로 구분, 최대 100명. touser가 ”@all”이면 ”@all”로 작성, 없으면 비워두세요",
  "OPEN_GET_WEATHER": "지역 날씨에 따라 걸음 수 감소 여부, 없으면 비워두세요",
  "AREA": "날씨 정보를 받을 지역 설정(위 항목 활성화 시 필수), 예: 베이징, 없으면 비워두세요",
  "QWEATHER": "여기에 HeWeather Private KEY 입력, 신청 주소 https://console.qweather.com/#/apps, 없으면 비워두세요",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "다중 계정 최대 걸음 수, 위 참고",
      "min_step": "다중 계정 최소 걸음 수, 위 참고",
      "password": "다중 계정 비밀번호, 위 참고",
      "user": "다중 계정 휴대폰번호, 위 참고"
    }
  ]
}
```
> **PAT**라는 이름의 변수를 추가: Settings-->Secrets-->New secret

| Secrets |  형식  |
| -------- | ----- |
| PAT |   **PAT**은 별도 신청 필요, github token 값, 튜토리얼: https://www.jianshu.com/p/bb82b3ad1d11 , repo와 workflow 권한 필수, 필수 입력, git push 권한 오류 방지용. |

**CONFIG** 예시
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "다중 계정 최대 걸음 수, 위 참고",
      "min_step": "다중 계정 최소 걸음 수, 위 참고",
      "password": "다중 계정 비밀번호, 위 참고",
      "user": "다중 계정 휴대폰번호, 위 참고"
    }
  ]
}
```

### 3. 실행 시간 커스터마이즈

**random_cron.sh**를 편집  
내부 **if** 조건문의 시간은 UTC 기준(즉, **베이징 시간-8**), 예를 들어 베이징 8시는 UTC 0시, 실행 시간-8이 UTC 시간



## 주의사항

1. 매일 7회 실행, random_cron.sh에서 제어, 분 단위는 랜덤 값

2. 다중 계정 수와 비밀번호가 반드시 일치해야 사용 가능!!!

3. 실행 시간은 UTC 시간이어야 함!

4. server酱 가입 주소 [여기 클릭](https://sct.ftqq.com/)

5. 알리페이 걸음 수가 업데이트 안 되면, 샤오미 운동->설정->계정->로그아웃->데이터 초기화 후 재로그인, 제3자 서비스 재연결

6. 샤오미 운동 자체는 걸음 수를 업데이트하지 않으며, 연동된 서비스만 동기화됨!!!!!!

7. 사용 시 반드시 [메인 브랜치](https://github.com/xunichanghuan/mimotion-run/)를 Fork 하세요. 불필요한 버그 방지.

8. 계정은 [샤오미 계정]이 아니라 [샤오미 운동]의 계정임을 유의하세요.

## 누적 Star 수

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---