# ExKeyMo
안드로이드 4.1부터 앱은 [키 캐릭터 맵](https://source.android.com/docs/core/input/key-character-map-files) 파일을 통해 추가 키보드 레이아웃을 제공할 수 있습니다.
그 이후로, 필요한 레이아웃을 포함한 앱을 설치하여 루트 권한 없이 키보드 레이아웃을 커스터마이즈하는 것이 가능해졌습니다.
ExKeyMo는 안드로이드 개발에 대해 아무것도 몰라도 이러한 앱을 만들 수 있도록 도와줍니다.

ExKeyMo는 [Heroku](https://exkeymo.herokuapp.com/)에서 호스팅되었으나, Heroku가 무료 프로젝트 호스팅을 중단하고 이 프로젝트를 Heroku 오픈 소스 소프트웨어 크레딧 프로그램에 승인하지 않아 더 이상 사용 불가능합니다. 사용자 맞춤 레이아웃으로 APK를 만들려면 로컬에서 ExKeyMo를 실행하거나 아래에 나열된 미리 빌드된 APK를 사용해야 합니다.

두 개 이상의 레이아웃이 필요하신가요? [Custom Keyboard Layout](https://github.com/ris58h/custom-keyboard-layout) 프로젝트를 기반으로 APK를 빌드할 수 있습니다.

지원하고 싶으신가요? [커피 한 잔 사주세요](https://www.buymeacoffee.com/ris58h).

## 미리 빌드된 APK
- CapsLock을 Ctrl로 [ExKeyMo-caps2ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775514/ExKeyMo-caps2ctrl.zip)
- CapsLock과 Ctrl 상호 변환 [ExKeyMo-swap-caps-and-ctrl.zip](https://github.com/ris58h/exkeymo-server/files/12775516/ExKeyMo-swap-caps-and-ctrl.zip)
- CapsLock을 Esc로 [ExKeyMo-caps2esc.zip](https://github.com/ris58h/exkeymo-server/files/12775515/ExKeyMo-caps2esc.zip)
- CapsLock과 Esc 상호 변환 [ExKeyMo-swap-caps-and-esc.zip](https://github.com/ris58h/exkeymo-server/files/12775517/ExKeyMo-swap-caps-and-esc.zip)

## 앱 설치 및 설정

1. 앱을 설치하세요. 이 앱은 자체 서명되어 있어 안드로이드에서 신뢰할 수 없는 출처 경고가 나타날 수 있습니다. 참고: 앱 설치 시 오류가 발생하면 이전 버전을 먼저 제거해 보세요.
2. `설정 -> 언어 및 입력 -> 물리적 키보드` (경로는 기기에 따라 다를 수 있음)로 이동하여 커스터마이즈할 키보드를 선택하고 `ExKeyMo Layout`을 선택하세요.

## 프로젝트 로컬 실행

### 요구 사항
- 자바 (17 이상).

### 소스 코드 받기
Git을 통해 소스 코드를 클론하세요:
```
git clone git@github.com:ris58h/exkeymo-server.git
```
또는 [다운로드](https://github.com/ris58h/exkeymo-server/archive/refs/heads/master.zip)하여 zip 파일로 받으세요.

### 빌드
```
./mvnw clean install
```

### Run
```
java -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
특정 포트에서 실행하려면 `server.port` 시스템 속성을 사용하세요:
```
java -Dserver.port=PORT_NUMBER -jar target/exkeymo-server-*-jar-with-dependencies.jar
```
### 사용법
[http://localhost/](http://localhost/)를 방문하고 __RTFM__ ([http://localhost/docs.html](http://localhost/docs.html))을 잊지 마세요.

### Docker로 실행하기
Docker를 사용하여 애플리케이션을 실행할 수 있습니다. 두 가지 방법이 있습니다: Docker Compose를 사용하거나 단순히 Docker를 사용하는 방법입니다.

#### Docker 사용하기
Docker 이미지를 빌드하세요:

```bash
docker build -t exkeymo-server .
```

도커 컨테이너를 실행합니다:
```bash
docker run -p 80:80 exkeymo-server
```
이 명령은 컨테이너를 시작하고 애플리케이션을 포트 80에 노출합니다.

#### Docker Compose 사용하기

Docker와 Docker Compose가 설치되어 있는지 확인하세요. 그런 다음, `docker-compose.yml` 파일이 있는 디렉터리에서 다음 명령어를 실행합니다:
```bash
docker-compose up
```
이 명령은 Docker 이미지를 빌드하고 컨테이너를 시작하며, 애플리케이션을 포트 80에서 노출합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-16

---