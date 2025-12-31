
# 블루 아카이브 API

## *이 API는 블루 아카이브의 글로벌 및 일본 버전 데이터를 제공합니다.*

- [블루 아카이브 EN](https://bluearchive.nexon.com/home): 공식 EN 웹사이트
- [블루 아카이브 JP](https://bluearchive.jp/): 공식 JP 웹사이트

블루 아카이브 게임의 다양한 데이터를 제공하는 API입니다. 이 프로젝트에 기여하고 싶다면 자유롭게 풀 리퀘스트나 이슈를 열어주세요. 저를 지원하고 싶다면 [Ko-Fi](https://ko-fi.com/torikushiii)로 후원할 수 있습니다.

**호스팅된 API 주소: https://api.ennead.cc/buruaka**

## 사전 요구사항

- [Go](https://go.dev/dl/): 1.24 이상
- API가 접근 가능한 MongoDB 인스턴스 (기본 URI는 `mongodb://localhost:27017`)

## 설정

런타임 옵션은 YAML 파일에서 로드됩니다. 기본적으로 서버는 프로젝트 루트의 `config.yaml`을 읽습니다. 필요시 `CONFIG_PATH` 환경 변수를 설정하여 다른 설정 파일을 지정할 수 있습니다.

로컬 기본값과 일치하는 예제는 `config.yaml`을 참조하세요.

## API 실행

Go를 사용하여 의존성을 빌드하고 서버를 시작합니다:

```bash
go run ./cmd/server
```
리스너 주소는 구성(기본값 `0.0.0.0:9999`)을 통해 제어됩니다. 모든 REST 엔드포인트는 `/buruaka` 기본 경로(예: `/buruaka/character`) 아래에서 제공되며, 서버는 구성된 URI를 사용하여 MongoDB에 연결하여 캐릭터, 공격대, 배너 데이터를 제공합니다.

독립 실행형 바이너리를 생성하려면:


```bash
go build -o server ./cmd/server
```

다음 명령어로 테스트를 실행하세요:

```bash
go test ./...
```

## REST API 문서

엔드포인트 세부 정보는 [docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs) 폴더에 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-31

---