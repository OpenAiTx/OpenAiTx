## 프로젝트를 위한 문서 라이브러리를 쉽게 만드는 방법

데모: [https://easydocs.codeandmedia.com/](https://easydocs.codeandmedia.com/)

이 테마는 [Zola](https://getzola.org) (정적 사이트 엔진)용으로, 프로젝트 문서를 쉽고 빠르게 구축하고 배포할 수 있도록 도와줍니다. Zola는 단일 바이너리로, Markdown으로 작성된 문서를 빌드한 후 HTML 페이지와 추가 정적 자산을 출력합니다. 따라서 이 테마, md 파일, Zola를 사용하면 유연하고 간단한 문서 웹사이트를 만들 수 있습니다.

### 단계별 안내

들어보셨겠지만 Zola는 꽤 유연합니다 :) 아래 시나리오는 수백 가지 가능한 방법 중 하나이니, 최적의 방법을 자유롭게 찾아보세요. 또한 Zola는 자체 테마 설치 및 사용 메커니즘을 제공합니다. 자세한 내용은 [문서](https://www.getzola.org/documentation/themes/installing-and-using-themes/)를 참고하세요.

1. 리포지토리를 포크하고 content 폴더 내의 데모 콘텐츠를 자신의 것으로 교체하세요. 다만 _index.md 파일을 확인하세요. `title`이 포함되어 있고 헤더 오른쪽에 앵커를 추가하려면 각 인덱스에 `insert_anchor_links = "right"`를 추가하세요. `theme.toml`, 스크린샷, readme는 삭제해도 됩니다.
2. `config.toml`에서 URL과 제목을 자신에 맞게 변경하세요. extra 섹션에서 네비게이션 로고 아래 버전을 위한 GitHub API 경로, 파비콘, 로고 자체를 지정할 수 있습니다. 필요 없으면 해당 줄을 삭제하세요. 또한 Zola 관련 추가 설정을 구성하거나 활성화할 수 있습니다. [설명서](https://www.getzola.org/documentation/getting-started/configuration/)를 참고하세요.
3. sass/_variables.scss에서 글꼴, 색상 또는 배경을 원하는 대로 변경할 수 있습니다.
4. 거의 완료되었습니다. 이제 웹사이트를 어떻게 빌드하고 어디에 호스팅할지 결정하세요. 로컬에서 빌드 후 업로드하거나 GitHub Actions에서 빌드하여 GitHub Pages / Netlify / CloudFlare Pages / AnyS3CloudStorage 등에 호스팅할 수 있습니다. [GitHub Pages 사용법](https://www.getzola.org/documentation/deployment/github-pages/). [내 GitHub 워크플로 예제](https://github.com/o365hq/o365hq.com/blob/main/.github/workflows/main.yml) (2단계 빌드: 첫 단계는 링크 및 맞춤법 검증, 두 번째는 Azure 업로드). [Dockerfile](https://github.com/codeandmedia/zola_docsascode_theme/blob/master/Dockerfile)로 Docker 이미지 생성 가능.

## 제공되는 설정 옵션

이 옵션들은 [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml)의 `extra` 섹션에서 설정할 수 있습니다. 설정이 없으면 스타터 [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml)에 나와 있는 기본 동작과 동일합니다.

- **easydocs_logo_always_clickable**는 로고가 항상 클릭 가능한지 제어합니다. 기본적으로 로고는 홈 페이지가 아닐 때만 클릭 가능합니다. 이 옵션을 활성화하면 홈 페이지에서도 로고가 클릭 가능해져, 홈 페이지에서는 페이지를 새로 고침하는 효과가 납니다.
- **easydocs_uglyurls**는 웹서버를 사용하지 않는 오프라인 사이트를 지원합니다. true로 설정하면 네비게이션 내 링크가 `index.html`을 포함한 전체 경로로 생성됩니다. 이 기능은 [Abridge 테마](https://www.getzola.org/themes/abridge/)에서 영감을 받았습니다. 작동하려면 base URL을 사이트가 저장될 로컬 폴더로 설정해야 합니다(ex. `base_url = file:///home/user/mysite/public/`). 따라서 이 설정은 이동성이 없으며 특정 로컬 폴더에서만 동작하지만, 웹서버 없이 사이트 탐색이 가능합니다.
- **easydocs_heading_threshold**는 왼쪽 네비게이션에 헤딩이 표시되기 위한 페이지 내 최소 헤딩 수를 제어합니다. 기본값은 5입니다. 예를 들어 항상 각 페이지에 헤딩을 표시하려면 1로 설정할 수 있습니다.

문서를 즐겨보세요!

* _아이콘: [Office UI Fabric Icons](https://uifabricicons.azurewebsites.net/)_
* _코드 복사 버튼: [Aaron Luna](https://aaronluna.dev/blog/add-copy-button-to-code-blocks-hugo-chroma/)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---