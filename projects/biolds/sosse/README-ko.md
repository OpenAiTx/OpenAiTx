<p>
  <img src="https://raw.githubusercontent.com/biolds/sosse/main/se/static/se/logo.svg" width="64" align="right">
  <a href="https://gitlab.com/biolds1/sosse/" alt="Gitlab code coverage" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-coverage/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/pipelines" alt="Gitlab pipeline status" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-status/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://sosse.readthedocs.io/en/stable/" alt="Documentation" style="text-decoration: none">
    <img src="https://img.shields.io/readthedocs/sosse?style=flat-square">
  </a>
  <a href="https://discord.gg/Vt9cMf7BGK" alt="Discord" style="text-decoration: none">
    <img src="https://img.shields.io/discord/1102142186423844944?style=flat-square&color=%235865f2">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/blob/main/LICENSE" alt="License" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/license/biolds1/sosse?style=flat-square">
  </a>
</p>

# Sosse 🦦

**Sosse를 발견하세요** — 강력한 웹 아카이빙, 크롤링 및 검색을 위해 구축된 Selenium 오픈 소스 검색 엔진입니다.  
[공식 웹사이트](https://sosse.io)에서 모든 기능과 역량을 탐색해 보세요.

개발자, 연구원 또는 데이터 애호가 여부에 상관없이 Sosse는 여러분의 프로젝트를 지원할 준비가 되어 있습니다.  
기능 요청 제출, 버그 신고, 코드 기여 또는 [토론 시작](https://github.com/biolds/sosse/discussions)을 위해  
[GitHub](https://github.com/biolds/sosse) 또는 [GitLab](https://gitlab.com/biolds1/sosse) 커뮤니티에 참여하세요.

## 주요 기능

- 🌍 **웹 페이지 검색**: 동적으로 렌더링된 페이지를 포함하여 고급 쿼리로 웹 페이지 콘텐츠를 검색합니다.  
  ([문서](https://sosse.readthedocs.io/en/stable/guides/search.html))

- 🕑 **반복 크롤링**: 일정한 간격으로 페이지를 크롤링하거나 콘텐츠 변경에 따라 크롤링 속도를 조절합니다.  
  ([문서](https://sosse.readthedocs.io/en/stable/crawl/policies.html))

- 🔖 **웹 페이지 아카이빙**: HTML 콘텐츠를 아카이빙하고, 로컬 사용을 위해 링크를 조정하며, 필요한 자산을 다운로드하고,  
  동적 콘텐츠를 지원합니다. ([문서](https://sosse.readthedocs.io/en/stable/guides/archive.html))

- 🏷️ **태그**: 크롤링하거나 아카이빙한 페이지를 태그로 조직하고 필터링하여 더 나은 검색 및 관리를 지원합니다.  
  ([문서](https://sosse.readthedocs.io/en/stable/tags.html))
- 📂 **파일 다운로드**: 웹 페이지에서 이진 파일을 일괄 다운로드합니다.
  ([문서](https://sosse.readthedocs.io/en/stable/guides/download.html))

- 📡 **웹훅**: 매우 유연한 웹훅을 사용하여 외부 서비스와 통합합니다. 독점 AI 플랫폼
  ([문서](https://sosse.readthedocs.io/en/stable/guides/ai_api_processing.html)) 또는 로컬 호스팅 솔루션
  ([문서](https://sosse.readthedocs.io/en/stable/guides/local_ai.html))에 연결하여 고급 데이터 추출,
  요약, 자동 태깅, 알림 등을 활성화합니다.

- 🔔 **Atom 피드**: 피드가 없는 웹사이트에 콘텐츠 피드를 생성하거나 키워드를 포함한 새 페이지가
  게시될 때 업데이트를 받습니다.
  ([문서](https://sosse.readthedocs.io/en/stable/guides/feed_website_monitor.html))

- 🔒 **인증**: 크롤러가 인증하여 비공개 페이지에 접근하고 콘텐츠를 가져올 수 있습니다.
  ([문서](https://sosse.readthedocs.io/en/stable/guides/authentication.html))

- 👥 **권한**: 관리자는 크롤러를 구성하고 통계를 볼 수 있으며, 인증된 사용자는 검색하거나 익명으로
  사용할 수 있습니다.
  ([문서](https://sosse.readthedocs.io/en/stable/permissions.html))

- 👤 **검색 기능**: 개인 검색 기록 ([문서](https://sosse.readthedocs.io/en/stable/user/history.html)),
  외부 검색 엔진 바로가기 ([문서](https://sosse.readthedocs.io/en/stable/user/shortcuts.html)) 등을 포함합니다.

📚 [문서](https://sosse.readthedocs.io/en/stable/index.html)를 탐색하고 몇 가지
📷 [스크린샷](https://sosse.readthedocs.io/en/stable/screenshots.html)을 확인해 보세요.

Sosse는 Python으로 작성되었으며 [GNU AGPLv3 라이선스](https://www.gnu.org/licenses/agpl-3.0.en.html) 하에 배포됩니다. JavaScript에 의존하는 페이지를 인덱싱하기 위해 [Mozilla Firefox](https://www.mozilla.org/firefox/) 또는
[Google Chromium](https://www.chromium.org/Home)과 함께 [Selenium](https://www.selenium.dev/)을 사용한 브라우저 기반 크롤링을 사용합니다. 더 빠른 크롤링을 위해 [Requests](https://docs.python-requests.org/en/latest/index.html)도 사용할 수 있습니다. Sosse는
데이터 저장에 [PostgreSQL](https://www.postgresql.org/)을 사용합니다.

## 직접 사용해보기

최신 버전을 Docker로 빠르게 사용하려면:

```
docker run -p 8005:80 biolds/sosse:stable
```

그런 다음 [http://127.0.0.1:8005/](http://127.0.0.1:8005/)를 열고 사용자 이름 `admin`과 비밀번호 `admin`으로 로그인하세요.

Docker 데이터의 영속성 또는 다른 설치 방법에 대해서는 [설치 가이드](https://sosse.readthedocs.io/en/stable/install.html)를 참고하세요.

## 계속 소통하기

도움이 필요하거나 아이디어를 공유하거나 Sosse에 대해 토론하려면 [Discord 서버](https://discord.gg/Vt9cMf7BGK)에 참여하세요!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---