# notify

[![go.dev reference](https://img.shields.io/badge/go.dev-reference-007d9c?logo=go&logoColor=white&style=flat-square)](https://pkg.go.dev/github.com/esiqveland/notify?tab=doc)
[![Go Report Card](https://goreportcard.com/badge/github.com/esiqveland/notify)](https://goreportcard.com/report/github.com/esiqveland/notify)
![Build](https://github.com/esiqveland/notify/actions/workflows/go.yml/badge.svg?branch=master)

Notify는 freedesktop.org에서 정의한 dbus 알림 서비스와 상호작용하기 위한 Go 라이브러리입니다:
https://specifications.freedesktop.org/notification/latest/

`notify`는 libnotify가 하는 것처럼 dbus를 통해 데스크탑 알림을 전달할 수 있습니다.

`notify`는 아직 개발 중이며 1.0이 출시되기 전까지 API가 확정되지 않았음을 참고하세요.

더 많은 테스터를 환영합니다 =)

의존성:
 - [godbus](https://github.com/godbus/dbus).

## 변경 로그
- v0.11.2: ExpireTimeoutSetByNotificationServer, ExpireTimeoutNever 헬퍼 도입
- v0.11.1: Close() 중 경합 상태 수정 #11
- v0.11.0: BSD 라이선스 하에 재출시
- v0.10.0: 더 엄격한 타입: [일부 호환성 깨지는 변경사항](https://github.com/esiqveland/notify/releases/tag/v0.10.0)
- v0.9.0: [일부 호환성 깨지는 변경사항](https://github.com/esiqveland/notify/releases/tag/v0.9.0)
- v0.2.1: dbus: gomod: dbus v5로 고정
- v0.2.0: `Notifier.Close()`가 더 이상 기본 `dbus.Conn`의 `.Close()`를 호출하지 않음

## 빠른 소개
예제 보기: [main.go](https://github.com/esiqveland/notify/blob/master/example/main.go).

저장소를 클론하고 examples 폴더로 이동하세요:

``` go run main.go ```


## TODO

- [x] 콜백 지원, 즉 dbus 신호 추가.
- [ ] 테스트. (유용한) 테스트 작성에 관한 아이디어에 매우 관심이 있습니다.

## 참고

Gnome 알림 사양 https://developer.gnome.org/notification-spec/.


## 기여자
신호 수신에 대한 훌륭한 아이디어를 제공한 사용자 [emersion](https://github.com/emersion)에게 감사드립니다.

Close() 중 발생하는 경쟁 상태를 수정해 준 [Merovius](https://github.com/Merovius)에게 감사드립니다.

## 라이선스

BSD 3-Clause



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---