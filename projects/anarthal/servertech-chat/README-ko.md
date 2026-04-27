# BoostServerTech 채팅

이 저장소는 C++로 작성된 채팅 애플리케이션의 코드를 보관합니다.

전체 문서는 [여기](https://anarthal.github.io/servertech-chat/)에서 읽을 수 있습니다.

| 빌드                                                                                              | 문서                                                                                                                                            | 라이브 서버                     |
| -------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| ![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/build.yml/badge.svg) | [![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/doc.yml/badge.svg)](https://anarthal.github.io/servertech-chat/) | [사용해보기!](http://16.171.43.27/) |

## BoostServerTech 프로젝트

이것은 [BoostServerTech 프로젝트들](https://docs.google.com/document/d/1ZQrod1crs8EaNLLqSYIRMacwR3Rv0hC5l-gfL-jOp2M)의 첫 번째 프로젝트로,
C++과 Boost가 서버 측 코드에 어떻게 사용될 수 있는지 보여주는 프로젝트 모음입니다.

## 아키텍처

서버는 Boost.Beast 기반이며, 비동기식(C++20 코루틴)이고 단일 스레드로 작동합니다.
빌드에는 C++20이 필요합니다. 영속성(persistence)을 위해 Redis와 MySQL을 사용합니다.

클라이언트는 웹 기반이며 Next.js를 사용합니다. 서버와는 웹소켓을 통해 통신합니다.

아키텍처에 대해 더 자세히 알고 싶다면
[문서의 이 섹션](https://anarthal.github.io/servertech-chat/01-architecture.html)을 참고하세요.

## 로컬 개발

Docker Compose를 사용하여 로컬호스트에서 채팅 애플리케이션을 빠르게 실행할 수 있습니다.
저장소 루트에서 터미널에 다음 명령을 입력하세요:



```
docker compose up --build
```
또는 전통적인 개발 환경 설정 방법에 대해  
[여기](https://anarthal.github.io/servertech-chat/02-local-dev.html)에서 배울 수 있습니다.  

## 몇 분 만에 라이브로 전환하기  

이 프로젝트는 코드를 몇 분 만에 서버에 배포할 수 있는 CI/CD 파이프라인을 제공합니다.  
필요한 것은 SSH가 활성화된 Linux 서버나 AWS 계정을 통해 서버를 생성하는 것뿐입니다.  
자세한 내용은 [여기](https://anarthal.github.io/servertech-chat/03-fork-modify-deploy.html)에서 확인할 수 있습니다.  

## 기여하고 싶으신가요?  

[cpplang Slack](https://cpplang.slack.com/archives/C06BRML5EFK)에서 메시지를 남겨주세요!  
기여자는 언제나 환영합니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---