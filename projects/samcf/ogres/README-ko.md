![Ogres 앱 스크린샷](https://raw.githubusercontent.com/samcf/ogres/main/site/web/media/ogres-media-collection.webp)

## 기능

[ogres.app](https://ogres.app)은 브라우저에서 실행할 수 있고 친구들과 함께 플레이할 수 있는 무료 오픈 소스 가상 테이블탑입니다. 오늘날 사용 가능한 일부 종합 도구들에 비해 매우 가벼운 대안을 목표로 합니다. 제한된 핵심 기능 세트는 던전 마스터가 가장 중요한 필수 요소만으로 신속하게 전투와 모험을 준비할 수 있도록 설계되었습니다.

- 회원 가입이나 광고 없이 즉시 게임 준비 시작
- 친구들과 온라인 협업 세션 시작
- 여러 장면을 동시에 준비 및 관리
- 간소화된 전투를 위한 내장 이니셔티브 추적기
- 휴대폰 및 태블릿에 최적화된 반응형 디자인
- 다른 게임 시스템에도 쉽게 사용 가능
- ... 그리고 더 많은 기능이 계획 중!

## 기여하기

버그 수정이나 기능 확장에 관심이 있으신가요? **초보자 친화적**으로 표시된 이슈를 찾아 작업하고 싶다고 댓글을 달아주세요. 다음은 로컬 개발 환경을 시작하는 방법에 대한 안내입니다 (개발자 전용).

> [!중요]
> `node`, `npm`, 그리고 `clojure`가 설치되어 있어야 합니다.

```sh
#!/bin/sh

# copy the repository
git clone git@github.com:samcf/ogres.git

# install dependencies and start the local web server
# by default opens at http://localhost:8080
npm install
npm start

# run the process that bundles CSS files
npm run style

# optionally, start the application server necessary
# for hosting online sessions
clojure -M -m ogres.server.core 5000
```
## 자체 서버 실행하기

Docker를 사용하여 이 애플리케이션의 자체 인스턴스를 실행할 수 있습니다. 자세한 내용은 [위키 문서](https://github.com/samcf/ogres/wiki/Docker-Usage)를 참조하세요. 다음 명령어는 애플리케이션을 설치하고 실행합니다.


```sh
#!/bin/sh
docker compose up -d
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---