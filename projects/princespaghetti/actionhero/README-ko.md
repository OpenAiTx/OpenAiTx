# 액션 히어로

## 액션 히어로란?

액션 히어로는 AWS용 최소 권한 IAM 정책을 생성하는 데 도움을 주는 사이드카 스타일 유틸리티입니다.

## 왜 필요한가?

일반적으로 개발자는 신속한 반복을 위해 관리자 권한이 있는 더 넓은 권한의 역할로 인프라를 코드로 작성하기 시작합니다. 그러나 더 세밀하게 범위가 지정된 권한 집합을 만들려고 하면 고통스럽고 시간이 많이 소요될 수 있습니다.

액션 히어로는 더 넓은 권한 반복 중에 필요한 모든 권한을 캡처할 수 있는 수단을 제공하여 필요한 권한만 가진 IAM 역할을 쉽게 만들 수 있도록 합니다.

## 어떻게 작동하는가?

액션 히어로는 AWS SDK의 클라이언트 사이드 모니터링 기능을 사용합니다. 이 기능은 AWS API 호출을 로컬 UDP 포트(기본값 31000)로 전송합니다.

서밋 루트는 이 기능에 대해 이 [포스트](https://summitroute.com/blog/2020/05/25/client_side_monitoring/)에서 설명합니다(이 도구의 영감이 된 글입니다).

## 사전 조건

위 포스트에서 논의된 것처럼 ``export AWS_CSM_ENABLED=true``를 셸에서 실행하거나 SDK를 사용하는 도구가 실행되는 프로파일에 설정해야 합니다. 예를 들어 테라폼을 사용하는 경우 계획/적용을 실행하는 셸에서 이 값을 내보내야 합니다.

환경 변수 ``AWS_CSM_PORT``는 CSM 액션이 전송되는 포트와 액션 히어로가 수신하는 포트를 재정의하는 데 사용할 수 있습니다. 사용 시 두 셸 모두에서 내보내야 합니다.

## 설치

바이너리는 [릴리스](https://github.com/princespaghetti/actionhero/releases) 페이지에서 사용할 수 있습니다.

도커 이미지는 [도커 허브](https://hub.docker.com/r/princespaghetti/actionhero)에서도 이용 가능합니다.

## 액션 히어로 실행

SDK를 사용하는 터미널과는 별도의 터미널에서 바이너리를 실행하세요.

``./actionhero``

또는 도커 실행 명령어를 사용할 수 있습니다.

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C는 프로세스를 안전하게 종료하는 데 사용할 수 있습니다

## 안내

도구의 샘플 사용법은 이 [블로그 게시물](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2)을 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---