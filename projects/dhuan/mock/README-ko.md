# mock

[![Go Reference](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Go Report Card](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock*은 API 유틸리티로, 다음을 할 수 있습니다:

- API 구성 파일이나
  명령줄 매개변수를 통해 API 경로를 쉽게 정의할 수 있습니다.
- 쉘 스크립트를 응답 핸들러로 사용할 수 있습니다. 또는 다른 종류의 프로그램도
  응답 핸들러 역할을 할 수 있습니다.
- API를 테스트할 수 있습니다 - 엔드포인트가 요청되었는지에 대한 단언을 할 수 있습니다.

[`mock`을 배우고 이해하는 가장 빠른 방법은 예제 페이지를 보는 것입니다.](https://dhuan.github.io/mock/latest/examples.html)

## 빠른 링크

- [사용자 가이드](https://dhuan.github.io/mock)
- [사용자 가이드 (메인 브랜치, 아직 출시되지 않음)](https://dhuan.github.io/mock/latest)
- [사용법 및 예제](https://dhuan.github.io/mock/latest/examples.html)

## 시작하기

```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```

테스트해 봅시다:

```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```
*mock*은 다른 API(또는 어떤 HTTP 서비스든)를 확장할 수도 있습니다.  
예를 들어, ``example.com``에서 실행 중인 기존 API에 새 경로를 추가하고 싶다고 가정해 보겠습니다:  
```  
example.com  
```
```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```
``--base example.com`` 옵션을 사용하면, 귀하의 API는 해당 다른 웹사이트의 프록시 역할을 하며, 추가 경로 `GET /some-new-route`를 확장합니다.  
자세한 내용은 문서에서 "Base APIs"를 참조하세요.  

*[*mock*을 사용하여 API를 더욱 맞춤화하는 다양한 방법이 있습니다. 가이드를 계속 읽어보세요.](https://dhuan.github.io/mock)*  

## 설치하기  

mock은 단일 파일 실행 파일로 배포됩니다. 릴리즈 페이지를 확인하고 최신 tarball을 다운로드하세요.  

## 라이선스  

**mock**은 MIT 라이선스를 따릅니다. 자세한 내용은 [LICENSE 파일](LICENSE)을 확인하세요.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-18

---