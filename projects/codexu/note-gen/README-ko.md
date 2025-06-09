![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## 안내서

NoteGen은 AI를 활용하여 기록과 작성을 연결하고, 파편화된 지식을 읽기 쉬운 노트로 정리하는 크로스 플랫폼 `Markdown` 노트 필기 애플리케이션입니다.

🖥️ 공식 문서: [https://notegen.top](https://notegen.top)

💬 [WeChat/QQ 그룹 참여](https://github.com/codexu/note-gen/discussions/110)

## NoteGen을 선택하는 이유?

- 경량: [설치 패키지](https://github.com/codexu/note-gen/releases)가 **단 20MB**, 무료이며 광고나 번들 소프트웨어가 없습니다.
- 크로스 플랫폼: Mac, Windows, Linux를 지원하며, `Tauri2`의 크로스 플랫폼 기능 덕분에 향후 iOS 및 Android도 지원할 예정입니다.
- `스크린샷`, `텍스트`, `삽화`, `파일`, `링크` 등 다양한 기록 방식을 지원하여 여러 상황에서 파편화된 기록을 충족합니다.
- 네이티브 `Markdown(.md)`을 저장 포맷으로 사용하여 변형 없이 손쉽게 이관 가능합니다.
- 네이티브 오프라인 사용, `GitHub, Gitee 프라이빗 저장소` 및 WebDAV 동기화와 함께 실시간 동기화 및 히스토리 롤백을 지원합니다.
- AI 강화: ChatGPT, Gemini, Ollama, LM Studio, Grok 등 다양한 모델 설정 가능, 커스텀 써드파티 모델 설정 지원.
- RAG: 당신의 노트가 곧 지식 베이스입니다. 임베딩 모델 및 리랭킹 모델을 지원합니다.

## 스크린샷

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

기록:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

작성:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

테마:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## 기록에서 작성으로

일반적인 노트 필기 애플리케이션은 대체로 기록 기능을 제공하지 않으며, 사용자가 내용을 직접 복사·붙여넣기 해야 하므로 효율이 크게 떨어집니다. 파편화된 기록을 정리하려면 많은 노력이 필요합니다.

NoteGen은 `기록`과 `작성` 페이지로 나뉘며, 두 페이지는 다음과 같은 관계를 가집니다.

- 기록을 노트로 정리하여 작성 페이지로 이동시켜 심층적으로 작성할 수 있습니다.
- 작성 중 언제든 기록을 삽입할 수 있습니다.

### 기록

기록 기능은 **AI 챗봇**과 유사하지만, 대화 중 이전에 기록한 내용을 연관시킬 수 있어, 대화 모드에서 정리 모드로 전환하여 기록을 읽기 쉬운 노트로 정렬할 수 있습니다.

효과적인 기록을 돕기 위한 보조 기능:

- **태그**로 다양한 기록 상황 구분
- **페르소나**: 커스텀 프롬프트 지원으로 AI 어시스턴트를 정밀하게 제어
- **클립보드 어시스턴트**: 클립보드의 텍스트나 이미지를 자동 인식하여 리스트에 기록

### 작성

작성은 **파일 관리자**와 **Markdown 에디터**로 나뉩니다.

**파일 관리자**

- 로컬 마크다운 파일과 GitHub 동기화 파일 관리 지원
- 무제한 디렉터리 계층 지원
- 다양한 정렬 방식 지원

**Markdown 에디터**

- WYSIWYG, 인스턴트 렌더링, 분할 화면 프리뷰 지원
- 버전 관리 및 히스토리 롤백 지원
- AI 어시스턴트를 통한 대화, 이어쓰기, 다듬기, 번역 기능 지원
- 이미지 호스팅, 이미지 업로드 및 Markdown 이미지 링크 변환 지원
- HTML을 Markdown으로 변환, 브라우저에서 복사한 내용을 자동으로 Markdown 포맷으로 변환
- 아웃라인, 수식, 마인드맵, 차트, 플로우차트, 간트차트, 시퀀스 다이어그램, 악보, 멀티미디어, 음성 읽기, 제목 앵커, 코드 하이라이팅 및 복사, graphviz 렌더링, plantuml UML 다이어그램 지원
- 실시간 로컬 저장, 지연(10초 미편집 시) 자동 동기화, 히스토리 롤백 지원

## 기타 기능

- 특정 내용을 빠르게 검색하고 이동할 수 있는 글로벌 검색
- 이미지 저장소 내용을 편리하게 관리할 수 있는 이미지 호스팅 관리
- 다크 테마 및 Markdown, 코드 등 외관 설정을 지원하는 테마 및 외관
- 국제화 지원, 현재 중국어와 영어 제공

## 사용 방법?

### 다운로드

현재 Mac, Windows, Linux를 지원합니다. Tauri2의 크로스 플랫폼 기능으로 향후 iOS와 Android도 지원 예정입니다.

[NoteGen 다운로드 (alpha)](https://github.com/codexu/note-gen/releases)

### 고급 기능

노트 필기 애플리케이션은 별도 설정 없이 바로 사용할 수 있습니다. 더 나은 경험을 원하신다면 설정 페이지에서 AI 및 동기화를 구성해 주세요.

## 기여하기

- [기여 가이드 읽기](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [업데이트 계획](https://github.com/codexu/note-gen/issues/46)
- [버그 또는 개선 제안 제출](https://github.com/codexu/note-gen/issues)
- [디스커션](https://github.com/codexu/note-gen/discussions)

## 기여자

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Star 히스토리

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---