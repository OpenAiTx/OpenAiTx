<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">친근한 동네 게임 사이트.</p>
<br>

MonkeyGG2에 오신 것을 환영합니다! 150개 이상의 다양한 게임을 제공하며, 독특하고 맞춤 설정이 가능한 게임 경험을 선사하는 풍부한 기능의 게임 사이트입니다. 게이머, 개발자, 혹은 일반 사용자 누구든 MonkeyGG2에서 원활하고 즐거운 게임 환경을 경험할 수 있습니다.

> 저희에게 스타를 남겨주세요! 특히 이 저장소를 포크했거나, 이 저장소로 다른 용도를 찾으셨다면 더욱 환영합니다.

## 특징

-   150개 이상의 게임
-   사용이 간편함
-   배포가 쉬움
-   맞춤 설정 가능
-   프록시 지원
-   그리고 더 많은 기능...

## 맞춤 설정

### 설정

#### 클로킹(Cloaking)

클로킹이란 페이지를 `about:blank` 탭에서 여는 것을 의미합니다. 이 동작은 기본적으로 강제 적용되며, 비활성화할 수도 있습니다. 리디렉션 링크에 대한 프리셋이 제공되지만, 수동으로도 설정이 가능합니다.

#### 마스킹(Masking)

마스킹이란 about:blank 탭의 아이콘과 탭 제목을 변경하는 것을 의미합니다. 아이콘과 탭 제목에 대한 프리셋이 제공되며, 역시 수동 설정이 가능합니다.

#### 단축키(Shortcuts)

사용자 지정 키보드 단축키를 생성하여 다양한 작업을 수행할 수 있습니다. 예를 들어, 게임 종료, 탭 마스킹, 사용자 지정 자바스크립트 실행 등이 지원됩니다.
> 참고: 사용자 지정 자바스크립트를 실행하려면, 무엇을 하는지 알고 있어야 합니다. 문제가 발생하면 페이지를 새로고침하면 됩니다.

#### 테마(Theme)

현재 지원되는 테마 맞춤 설정은 다음과 같습니다:
- 배경 애니메이션 전환 (게임 중 성능이 걱정된다면, 게임을 플레이할 때 자동으로 비활성화되니 걱정하지 마세요)
- 배경 색상
- 블록 색상
- 버튼 색상
- 게임 색상
- 호버 색상
- 스크롤바 색상
- 스크롤 트랙 색상
- 폰트 색상

> 참고: 실수로 색상을 변경해 사이트 사용이 불가능해졌다면, 쿠키와 로컬 스토리지를 삭제해야 합니다.

### 고급 맞춤 설정

> 면책 조항: 아래 맞춤 설정은 저장소의 소유자 또는 포크한 저장소의 소유자만 사용할 수 있습니다.

`config.jsonc` 파일은 사이트 전체의 구성을 포함하도록 포맷되어 있습니다. 현재 지원되는 항목은 다음과 같습니다:
- 게임
- 테마(곧 지원 예정)
- 프록시 구성

#### 게임

각 게임 항목은 게임의 표시 이름을 키로 하며, 값은 세 가지 키-값 쌍이 포함된 객체여야 합니다:
- `"path"`: `./games` 디렉터리에서 게임으로의 경로
- `"aliases"`: 검색 향상을 위한 게임의 대체 이름 목록
- `"categories"`: 게임이 속하는 카테고리 목록 (아이콘 추가 지원은 곧 제공 예정)

항목을 수동으로 추가할 수도 있지만, 특히 알파벳/숫자순으로 정렬하려면 번거롭습니다(정렬하지 않아도 구성에는 문제없음).
이런 이유로 `add-game-entry.js` 스크립트가 만들어졌으며, 파일을 직접 편집하지 않고도 쉽게 새 게임을 구성에 추가할 수 있습니다.

```bash
# node.js, bun, deno 등 어떤 js 런타임도 사용할 수 있습니다.
# 이 예시에서는 bun을 사용합니다. bun은 의존성을 자동으로 설치합니다.
bun add-game-script.js
# 이어지는 프롬프트에 답하면 구성이 업데이트됩니다.
```

#### 테마

테마 표준은 아직 구현되지 않았습니다(TODO).

#### 프록시

프록시 구성 옵션은 **"config"** 키 아래에 있습니다.
`"proxy"` 키의 값은 프록시 기능을 활성화/비활성화하는 불리언 값입니다. `"proxy"`가 false로 설정되어 있으면, 사용자가 프록시에 접근하려고 할 때 오류 다이얼로그가 표시됩니다.
`"proxyPath"` 키의 값은 프록시 경로입니다. 절대 경로나 상대 경로 모두 가능하지만, 프록시 페이지는 사이트에서 iframe으로 표시되기 때문에 **CORS**를 지원해야 합니다.

## 배포

### 프록시 없이 배포

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

또는 [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) 또는 [Codeberg](https://codeberg.org/MonkeyGG2/pages)에서 저장소를 포크해 각각 GitHub Pages 또는 Codeberg Pages로 배포할 수 있습니다.

### 프록시와 함께 배포

MonkeyGG2를 프록시와 함께 호스팅하는 방법은 [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) 페이지를 참고하세요.

### 로컬에서 실행

```bash
# 경고: "monkeygg2"라는 폴더가 이미 있다면, 이 명령은 해당 폴더 안의 모든 파일을 삭제합니다.
# 아래 두 명령에서 디렉터리 이름을 반드시 변경하세요.
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# 여기서부터는 정적 서버를 실행할 수 있는 어떤 도구도 사용 가능합니다. 여기선 npm의 "live-server"를 사용합니다.
npm install -g live-server # 이미 설치되어 있지 않은 경우에만 실행
npx live-server
```

## 라이선스

WTFPL 라이선스로 배포됩니다. 자세한 내용은 [여기](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE)를 참고하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---