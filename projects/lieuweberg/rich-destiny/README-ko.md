![GitHub all releases](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/lieuweberg/rich-destiny/latest/total) ![Time spent coding (15 minute timeout)](https://wakatime.com/badge/user/a637a12a-da87-4487-8b1e-660151dc3e7b/project/94fa2fc6-7e9b-4c74-b6eb-4ce6a09b4cdf.svg)

# rich-destiny
| <img src="https://richdestiny.app/favicon.ico" width="100"> | 현재 Destiny 2 활동을 Discord 상태에 표시하는 플러그 앤 플레이 백그라운드 프로그램입니다. 현대적이고, 불안정한 스크린샷이 없으며 크기가 작습니다. |
| :---: | :---: |

## 기여 ✨

기여하고 싶다면 환영합니다! 새로운 기능에 대해서는 먼저 Discord 서버에서 문의하거나 만들고자 하는 내용을 이슈로 작성해 주세요. 버그를 수정하고 싶다면 그냥 PR을 생성하면 됩니다. 그래도 “버그가 아니라 기능입니다”일 수도 있으니 문의하는 것이 권장됩니다.

## 개발 🛠
필수 조건:
 - (클라이언트) 최신 Go 1.x 버전을 설치하세요.
 - (클라이언트) 윈도우의 경우: git bash가 필요합니다. 빌드 스크립트의 명령어를 수동으로 실행할 수도 있지만 저는 bash 스크립트를 사용합니다 :)
 - (웹) 최신 버전의 Node.js와 npm이 필요합니다.

빌드:
 - 저장소를 클론하세요.
  
 - 클라이언트:
   - `cd client`
   - `config.go.example` 파일을 `config.go`로 복사하고 값을 입력하세요. 리디렉트 URI는 `https://richdestiny.app/login`을 사용할 수 있으며 Bungie.net 개발자 포털에도 등록되어 있습니다. 이는 로컬호스트 리디렉트로 연결됩니다.
   - `go get`
   - `./build dev`
     - 유효한 semver 버전 번호와 함께 `./build vX.Y.Z`를 사용할 수도 있지만 개발 용도에는 dev를 사용하세요. 자동으로 업데이트를 비활성화하고 앞으로 다른 기능도 비활성화할 수 있습니다.

 - 웹사이트:
   - `cd web`
   - `npm install`
   - 로컬 개발 서버를 위해 `npm run start` 또는 프로덕션 빌드를 위해 `npm run build`를 실행하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---