[![freeCodeCamp Social Banner](https://cdn.freecodecamp.org/platform/universal/fcc_banner_new.png)](https://www.freecodecamp.org/)

[![Pull Requests Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat)](https://makeapullrequest.com)
[![first-timers-only Friendly](https://img.shields.io/badge/first--timers--only-friendly-blue.svg)](https://www.firsttimersonly.com/)
[![Open Source Helpers](https://www.codetriage.com/freecodecamp/freecodecamp/badges/users.svg)](https://www.codetriage.com/freecodecamp/freecodecamp)
[![Setup Automated](https://img.shields.io/badge/setup-automated-blue?logo=gitpod)](https://gitpod.io/from-referrer/)
[![Discord](https://img.shields.io/discord/692816967895220344?logo=discord&label=Discord&color=5865F2)](https://discord.gg/PRyKn3Vbay)

## freeCodeCamp.org의 오픈소스 코드베이스 및 커리큘럼

[freeCodeCamp.org](https://www.freecodecamp.org)는 무료로 코딩을 배울 수 있는 친근한 커뮤니티입니다. 이는 수백만 명의 바쁜 성인들이 기술 분야로 전환할 수 있도록 돕는 [기부 후원 501(c)(3) 자선단체](https://www.freecodecamp.org/donate)에 의해 운영됩니다. 우리 커뮤니티는 이미 40,000명 이상의 사람들이 첫 개발자 직업을 얻도록 도왔습니다.

우리의 풀스택 웹 개발 및 머신러닝 커리큘럼은 완전히 무료이고 자기 주도 학습이 가능합니다. 수천 개의 인터랙티브 코딩 챌린지를 통해 여러분의 기술을 확장할 수 있습니다.

## 목차

- [인증 과정](#certifications)
- [학습 플랫폼](#the-learning-platform)
- [버그 및 이슈 신고](#reporting-bugs-and-issues)
- [보안 이슈 및 책임 있는 공개](#reporting-security-issues-and-responsible-disclosure)
- [기여 방법](#contributing)
- [플랫폼, 빌드 및 배포 상태](#platform-build-and-deployment-status)
- [라이선스](#license)

### 인증 과정

freeCodeCamp.org는 여러 무료 개발자 인증 과정을 제공합니다. 각 인증 과정은 5개의 필수 웹 앱 프로젝트와, 해당 프로젝트 준비를 돕기 위한 수백 개의 선택적 코딩 챌린지로 구성되어 있습니다. 각 인증 과정은 초보 프로그래머가 약 300시간 정도 소요될 것으로 예상합니다.

freeCodeCamp.org 커리큘럼의 50개 프로젝트 각각은 자체 애자일 유저 스토리와 자동화된 테스트를 포함합니다. 이는 여러분이 프로젝트를 점진적으로 구축하고, 제출 전에 모든 유저 스토리를 충족했는지 확인하는 데 도움이 됩니다.

이 테스트 슈트들은 [freeCodeCamp의 CDN](https://cdn.freecodecamp.org/testable-projects-fcc/v1/bundle.js)을 통해 불러올 수 있습니다. 즉, CodePen, Replit 같은 웹사이트나, 여러분의 로컬 개발 환경에서도 이 프로젝트들을 만들 수 있습니다.

인증을 획득하면, 영원히 소유하게 됩니다. 언제든지 LinkedIn이나 이력서에 링크할 수 있습니다. 그리고 잠재적인 고용주나 프리랜스 클라이언트가 해당 링크를 클릭하면, 여러분에게만 해당하는 검증된 인증서를 확인할 수 있습니다.

단 한 가지 예외는 [학업 정직성 정책](https://www.freecodecamp.org/news/academic-honesty-policy/) 위반이 발견된 경우입니다. 타인의 코드나 프로젝트를 인용 없이 제출하는 명백한 표절이 발견되면, 모든 엄격한 교육 기관과 마찬가지로 인증을 취소하고 해당 사용자를 영구 차단합니다.

다음은 12개의 핵심 인증 과정입니다:

#### 1. [반응형 웹 디자인 인증](https://www.freecodecamp.org/learn/2022/responsive-web-design/)

- [고양이 사진 앱 만들기로 HTML 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-html-by-building-a-cat-photo-app)
- [카페 메뉴 만들기로 기본 CSS 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-basic-css-by-building-a-cafe-menu)
- [색상 마커 만들기로 CSS 색상 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-colors-by-building-a-set-of-colored-markers)
- [회원가입 폼 만들기로 HTML 폼 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-html-forms-by-building-a-registration-form)
- [로스코 그림 만들기로 CSS 박스 모델 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-the-css-box-model-by-building-a-rothko-painting)
- [사진 갤러리 만들기로 CSS Flexbox 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-flexbox-by-building-a-photo-gallery)
- [영양 성분표 만들기로 타이포그래피 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-typography-by-building-a-nutrition-label)
- [퀴즈 만들기로 접근성 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-accessibility-by-building-a-quiz)
- [밸런스 시트 만들기로 CSS 의사 선택자 더 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-more-about-css-pseudo-selectors-by-building-a-balance-sheet)
- [고양이 그림 만들기로 중급 CSS 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-intermediate-css-by-building-a-cat-painting)
- [피아노 만들기로 반응형 웹 디자인 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-responsive-web-design-by-building-a-piano)
- [도시 스카이라인 만들기로 CSS 변수 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-variables-by-building-a-city-skyline)
- [매거진 만들기로 CSS 그리드 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-grid-by-building-a-magazine)
- [펭귄 만들기로 CSS 변환 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-transforms-by-building-a-penguin)
- [관람차 만들기로 CSS 애니메이션 배우기](https://www.freecodecamp.org/learn/2022/responsive-web-design/#learn-css-animation-by-building-a-ferris-wheel)
  <br />
  <br />
  **프로젝트**: [설문조사 폼](https://www.freecodecamp.org/learn/2022/responsive-web-design/build-a-survey-form-project/build-a-survey-form), [트리뷰트 페이지](https://www.freecodecamp.org/learn/2022/responsive-web-design/build-a-tribute-page-project/build-a-tribute-page), [기술 문서 페이지](https://www.freecodecamp.org/learn/2022/responsive-web-design/build-a-technical-documentation-page-project/build-a-technical-documentation-page), [제품 랜딩 페이지](https://www.freecodecamp.org/learn/2022/responsive-web-design/build-a-product-landing-page-project/build-a-product-landing-page), [개인 포트폴리오 웹페이지](https://www.freecodecamp.org/learn/2022/responsive-web-design/build-a-personal-portfolio-webpage-project/build-a-personal-portfolio-webpage)

#### 2. [자바스크립트 알고리즘 및 자료구조 인증](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/)

- [피라미드 생성기 만들기로 입문 자바스크립트 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-introductory-javascript-by-building-a-pyramid-generator)
- [롤플레잉 게임 만들기로 기본 자바스크립트 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-basic-javascript-by-building-a-role-playing-game)
- [칼로리 계산기 만들기로 폼 검증 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-form-validation-by-building-a-calorie-counter)
- [뮤직 플레이어 만들기로 문자열 및 배열 메서드 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-basic-string-and-array-methods-by-building-a-music-player)
- [날짜 포매터 만들기로 Date 객체 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-the-date-object-by-building-a-date-formatter)
- [축구팀 카드 만들기로 최신 자바스크립트 메서드 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-modern-javascript-methods-by-building-football-team-cards)
- [할 일 앱 만들기로 localStorage 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-localstorage-by-building-a-todo-app)
- [십진수-2진수 변환기 만들기로 재귀 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-recursion-by-building-a-decimal-to-binary-converter)
- [숫자 정렬기 만들기로 기본 알고리즘 사고 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-basic-algorithmic-thinking-by-building-a-number-sorter)
- [통계 계산기 만들기로 고급 배열 메서드 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-advanced-array-methods-by-building-a-statistics-calculator)
- [스프레드시트 만들기로 함수형 프로그래밍 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-functional-programming-by-building-a-spreadsheet)
- [스팸 필터 만들기로 정규표현식 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-regular-expressions-by-building-a-spam-filter)
- [쇼핑 카트 만들기로 기본 OOP 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-basic-oop-by-building-a-shopping-cart)
- [플랫폼 게임 만들기로 중급 OOP 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-intermediate-oop-by-building-a-platformer-game)
- [주사위 게임 만들기로 중급 알고리즘 사고 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#review-algorithmic-thinking-by-building-a-dice-game)
- [fCC 저자 페이지 만들기로 Fetch 및 프로미스 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-fetch-and-promises-by-building-an-fcc-authors-page)
- [fCC 포럼 리더보드 만들기로 비동기 프로그래밍 배우기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/#learn-asynchronous-programming-by-building-an-fcc-forum-leaderboard)
  <br />
  <br />
  **프로젝트**: [팰린드롬 체커](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/build-a-palindrome-checker-project/build-a-palindrome-checker), [로마 숫자 변환기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/build-a-roman-numeral-converter-project/build-a-roman-numeral-converter), [전화번호 검증기](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/build-a-telephone-number-validator-project/build-a-telephone-number-validator), [캐시 레지스터](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/build-a-cash-register-project/build-a-cash-register), [RPG 크리쳐 검색 앱](https://www.freecodecamp.org/learn/javascript-algorithms-and-data-structures-v8/build-an-rpg-creature-search-app-project/build-an-rpg-creature-search-app)

#### 3. [프론트엔드 라이브러리 인증](https://www.freecodecamp.org/learn/front-end-development-libraries/)

- [Bootstrap](https://www.freecodecamp.org/learn/front-end-development-libraries/#bootstrap)
- [jQuery](https://www.freecodecamp.org/learn/front-end-development-libraries/#jquery)
- [Sass](https://www.freecodecamp.org/learn/front-end-development-libraries/#sass)
- [React](https://www.freecodecamp.org/learn/front-end-development-libraries/#react)
- [Redux](https://www.freecodecamp.org/learn/front-end-development-libraries/#redux)
- [React와 Redux](https://www.freecodecamp.org/learn/front-end-development-libraries/#react-and-redux)
  <br />
  <br />
  **프로젝트**: [무작위 명언 생성기](https://www.freecodecamp.org/learn/front-end-development-libraries/front-end-development-libraries-projects/build-a-random-quote-machine), [Markdown 미리보기기](https://www.freecodecamp.org/learn/front-end-development-libraries/front-end-development-libraries-projects/build-a-markdown-previewer), [드럼 머신](https://www.freecodecamp.org/learn/front-end-development-libraries/front-end-development-libraries-projects/build-a-drum-machine), [자바스크립트 계산기](https://www.freecodecamp.org/learn/front-end-development-libraries/front-end-development-libraries-projects/build-a-javascript-calculator), [25+5 시계](https://www.freecodecamp.org/learn/front-end-development-libraries/front-end-development-libraries-projects/build-a-25--5-clock)

#### 4. [데이터 시각화 인증](https://www.freecodecamp.org/learn/data-visualization/)

- [D3로 데이터 시각화](https://www.freecodecamp.org/learn/data-visualization/#data-visualization-with-d3)
- [JSON API와 Ajax](https://www.freecodecamp.org/learn/data-visualization/#json-apis-and-ajax)
  <br />
  <br />
  **프로젝트**: [막대 차트](https://www.freecodecamp.org/learn/data-visualization/data-visualization-projects/visualize-data-with-a-bar-chart), [산점도 그래프](https://www.freecodecamp.org/learn/data-visualization/data-visualization-projects/visualize-data-with-a-scatterplot-graph), [히트맵](https://www.freecodecamp.org/learn/data-visualization/data-visualization-projects/visualize-data-with-a-heat-map), [연도별 지도(Choropleth Map)](https://www.freecodecamp.org/learn/data-visualization/data-visualization-projects/visualize-data-with-a-choropleth-map), [트리맵 다이어그램](https://www.freecodecamp.org/learn/data-visualization/data-visualization-projects/visualize-data-with-a-treemap-diagram)

#### 5. [관계형 데이터베이스](https://www.freecodecamp.org/learn/relational-database/)

- [보일러플레이트 만들기로 Bash 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-bash-by-building-a-boilerplate)
- [비디오 게임 캐릭터 데이터베이스 만들기로 관계형 데이터베이스 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-relational-databases-by-building-a-database-of-video-game-characters)
- [5개 프로그램 만들기로 Bash 스크립트 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-bash-scripting-by-building-five-programs)
- [학생 데이터베이스 만들기로 SQL 배우기: 1부](https://www.freecodecamp.org/learn/relational-database/#learn-sql-by-building-a-student-database-part-1)
- [학생 데이터베이스 만들기로 SQL 배우기: 2부](https://www.freecodecamp.org/learn/relational-database/#learn-sql-by-building-a-student-database-part-2)
- [고급 Bash로 키티 입숨 번역기 만들기](https://www.freecodecamp.org/learn/relational-database/#learn-advanced-bash-by-building-a-kitty-ipsum-translator)
- [자전거 대여점 만들기로 Bash와 SQL 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-bash-and-sql-by-building-a-bike-rental-shop)
- [캐슬 만들기로 Nano 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-nano-by-building-a-castle)
- [SQL 참조 객체 만들기로 Git 배우기](https://www.freecodecamp.org/learn/relational-database/#learn-git-by-building-an-sql-reference-object)
  <br />
  <br />
  **프로젝트**: [미용실 예약 스케줄러](https://www.freecodecamp.org/learn/relational-database/#build-a-salon-appointment-scheduler-project), [천체 데이터베이스](https://www.freecodecamp.org/learn/relational-database/#build-a-celestial-bodies-database-project), [주기율표 데이터베이스](https://www.freecodecamp.org/learn/relational-database/#build-a-periodic-table-database-project), [숫자 맞추기 게임](https://www.freecodecamp.org/learn/relational-database/#build-a-number-guessing-game-project), [월드컵 데이터베이스](https://www.freecodecamp.org/learn/relational-database/#build-a-world-cup-database-project)

#### 6. [백엔드 개발 및 API 인증](https://www.freecodecamp.org/learn/back-end-development-and-apis/)

- [Npm으로 패키지 관리하기](https://www.freecodecamp.org/learn/back-end-development-and-apis/#managing-packages-with-npm)
- [기본 Node와 Express](https://www.freecodecamp.org/learn/back-end-development-and-apis/#basic-node-and-express)
- [MongoDB와 Mongoose](https://www.freecodecamp.org/learn/back-end-development-and-apis/#mongodb-and-mongoose)
  <br />
  <br />
  **프로젝트**: [타임스탬프 마이크로서비스](https://www.freecodecamp.org/learn/back-end-development-and-apis/back-end-development-and-apis-projects/timestamp-microservice), [요청 헤더 파서](https://www.freecodecamp.org/learn/back-end-development-and-apis/back-end-development-and-apis-projects/request-header-parser-microservice), [URL 단축기](https://www.freecodecamp.org/learn/back-end-development-and-apis/back-end-development-and-apis-projects/url-shortener-microservice), [운동 추적기](https://www.freecodecamp.org/learn/back-end-development-and-apis/back-end-development-and-apis-projects/exercise-tracker), [파일 메타데이터 마이크로서비스](https://www.freecodecamp.org/learn/back-end-development-and-apis/back-end-development-and-apis-projects/file-metadata-microservice)

#### 7. [품질 보증 인증](https://www.freecodecamp.org/learn/quality-assurance/)

- [Chai로 품질 보증 및 테스트](https://www.freecodecamp.org/learn/quality-assurance/#quality-assurance-and-testing-with-chai)
- [고급 Node와 Express](https://www.freecodecamp.org/learn/quality-assurance/#advanced-node-and-express)
  <br />
  <br />
  **프로젝트**: [미터-야드 변환기](https://www.freecodecamp.org/learn/quality-assurance/quality-assurance-projects/metric-imperial-converter), [이슈 트래커](https://www.freecodecamp.org/learn/quality-assurance/quality-assurance-projects/issue-tracker), [개인 도서관](https://www.freecodecamp.org/learn/quality-assurance/quality-assurance-projects/personal-library), [스도쿠 솔버](https://www.freecodecamp.org/learn/quality-assurance/quality-assurance-projects/sudoku-solver), [미국-영국 번역기](https://www.freecodecamp.org/learn/quality-assurance/quality-assurance-projects/american-british-translator)

#### 8. [파이썬 과학 컴퓨팅 인증](https://www.freecodecamp.org/learn/scientific-computing-with-python/)

- [암호기 만들기로 문자열 조작 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-string-manipulation-by-building-a-cipher)
- [Luhn 알고리즘 구현으로 숫자와 문자열 다루기 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-how-to-work-with-numbers-and-strings-by-implementing-the-luhn-algorithm)
- [비용 추적기 만들기로 람다 함수 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-lambda-functions-by-building-an-expense-tracker)
- [대소문자 변환기 만들기로 리스트 컴프리헨션 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-list-comprehension-by-building-a-case-converter-program)
- [제곱근 찾기로 이분법 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-the-bisection-method-by-finding-the-square-root-of-a-number)
- [비밀번호 생성기 만들기로 정규표현식 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-regular-expressions-by-building-a-password-generator)
- [최단 경로 알고리즘 만들기로 알고리즘 설계 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-algorithm-design-by-building-a-shortest-path-algorithm)
- [하노이의 탑 퍼즐 풀기로 재귀 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-recursion-by-solving-the-tower-of-hanoi-puzzle)
- [병합 정렬 알고리즘 만들기로 자료구조 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-data-structures-by-building-the-merge-sort-algorithm)
- [스도쿠 솔버 만들기로 클래스와 객체 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-classes-and-objects-by-building-a-sudoku-solver)
- [이진 탐색 트리 만들기로 트리 순회 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-tree-traversal-by-building-a-binary-search-tree)
- [벡터 공간 만들기로 특수 메서드 배우기](https://www.freecodecamp.org/learn/scientific-computing-with-python/#learn-special-methods-by-building-a-vector-space)
  <br />
  <br />
  **프로젝트**: [산술 서식 지정기](https://www.freecodecamp.org/learn/scientific-computing-with-python/build-an-arithmetic-formatter-project/build-an-arithmetic-formatter-project), [시간 계산기](https://www.freecodecamp.org/learn/scientific-computing-with-python/build-a-time-calculator-project/build-a-time-calculator-project), [예산 앱](https://www.freecodecamp.org/learn/scientific-computing-with-python/build-a-budget-app-project/build-a-budget-app-project), [다각형 면적 계산기](https://www.freecodecamp.org/learn/scientific-computing-with-python/build-a-polygon-area-calculator-project/build-a-polygon-area-calculator-project), [확률 계산기](https://www.freecodecamp.org/learn/scientific-computing-with-python/build-a-probability-calculator-project/build-a-probability-calculator-project)

#### 9. [파이썬 데이터 분석 인증](https://www.freecodecamp.org/learn/data-analysis-with-python/)

- [파이썬 데이터 분석 과정](https://www.freecodecamp.org/learn/data-analysis-with-python/#data-analysis-with-python-course)
- [NumPy](https://www.freecodecamp.org/learn/data-analysis-with-python/#numpy)
  <br />
  <br />
  **프로젝트**: [평균-분산-표준편차 계산기](https://www.freecodecamp.org/learn/data-analysis-with-python/data-analysis-with-python-projects/mean-variance-standard-deviation-calculator), [인구통계 데이터 분석기](https://www.freecodecamp.org/learn/data-analysis-with-python/data-analysis-with-python-projects/demographic-data-analyzer), [의료 데이터 시각화 도구](https://www.freecodecamp.org/learn/data-analysis-with-python/data-analysis-with-python-projects/medical-data-visualizer), [페이지 뷰 시계열 시각화](https://www.freecodecamp.org/learn/data-analysis-with-python/data-analysis-with-python-projects/page-view-time-series-visualizer), [해수면 예측기](https://www.freecodecamp.org/learn/data-analysis-with-python/data-analysis-with-python-projects/sea-level-predictor)

#### 10. [정보 보안 인증](https://www.freecodecamp.org/learn/information-security/)

- [HelmetJS로 정보 보안](https://www.freecodecamp.org/learn/information-security/#information-security-with-helmetjs)
- [침투 테스트용 파이썬](https://www.freecodecamp.org/learn/information-security/#python-for-penetration-testing)
  <br />
  <br />
  **프로젝트**: [주가 확인기](https://www.freecodecamp.org/learn/information-security/information-security-projects/stock-price-checker), [익명 메시지 게시판](https://www.freecodecamp.org/learn/information-security/information-security-projects/anonymous-message-board), [포트 스캐너](https://www.freecodecamp.org/learn/information-security/information-security-projects/port-scanner), [SHA-1 비밀번호 크래커](https://www.freecodecamp.org/learn/information-security/information-security-projects/sha-1-password-cracker), [실시간 멀티플레이어 게임 보안](https://www.freecodecamp.org/learn/information-security/information-security-projects/secure-real-time-multiplayer-game)

#### 11. [파이썬 머신러닝 인증](https://www.freecodecamp.org/learn/machine-learning-with-python/)

- [TensorFlow](https://www.freecodecamp.org/learn/machine-learning-with-python/#tensorflow)
- [신경망의 작동 원리](https://www.freecodecamp.org/learn/machine-learning-with-python/#how-neural-networks-work)
  <br />
  <br />
  **프로젝트**: [가위바위보](https://www.freecodecamp.org/learn/machine-learning-with-python/machine-learning-with-python-projects/rock-paper-scissors), [고양이와 강아지 이미지 분류기](https://www.freecodecamp.org/learn/machine-learning-with-python/machine-learning-with-python-projects/cat-and-dog-image-classifier), [KNN 기반 도서 추천 엔진](https://www.freecodecamp.org/learn/machine-learning-with-python/machine-learning-with-python-projects/book-recommendation-engine-using-knn), [선형 회귀 건강 비용 계산기](https://www.freecodecamp.org/learn/machine-learning-with-python/machine-learning-with-python-projects/linear-regression-health-costs-calculator), [신경망 SMS 텍스트 분류기](https://www.freecodecamp.org/learn/machine-learning-with-python/machine-learning-with-python-projects/neural-network-sms-text-classifier)

#### 12. [파이썬으로 배우는 대학 대수학](https://www.freecodecamp.org/learn/college-algebra-with-python/)

- [비율과 비례 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-ratios-and-proportions)
- [X 구하기 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-how-to-solve-for-x)
- [분수와 소수 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-fractions-and-decimals)
- [함수와 그래프 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-functions-and-graphing)
- [선형 함수 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-linear-functions)
- [공약수와 제곱근 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-common-factors-and-square-roots)
- [방정식의 그래프 그리기 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-how-to-graph-systems-of-equations)
- [연립방정식 풀이 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-how-to-solve-systems-of-equations)
- [선형 시스템의 응용 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-applications-of-linear-systems)
- [이차방정식 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-quadratic-equations)
- [부모 그래프와 다항식 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-parent-graphs-and-polynomials)
- [대수학의 비즈니스 응용 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-business-applications-of-college-algebra)
- [단리와 복리 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-simple-and-compound-interest)
- [지수와 로그 배우기](https://www.freecodecamp.org/learn/college-algebra-with-python/#learn-exponents-and-logarithms)
- [파이썬으로 배우는 대학 대수학: 결론](https://www.freecodecamp.org/learn/college-algebra-with-python/#college-algebra-with-python-conclusion)
  <br />
  <br />
  **프로젝트**: [다기능 계산기](https://www.freecodecamp.org/learn/college-algebra-with-python/#build-a-multi-function-calculator-project), [그래프 계산기](https://www.freecodecamp.org/learn/college-algebra-with-python/#build-a-graphing-calculator-project), [수학 게임 3가지](https://www.freecodecamp.org/learn/college-algebra-with-python/#build-three-math-games-project), [금융 계산기](https://www.freecodecamp.org/learn/college-algebra-with-python/#build-a-financial-calculator-project), [데이터 그래프 탐색기](https://www.freecodecamp.org/learn/college-algebra-with-python/#build-a-data-graph-explorer-project)

#### 레거시 풀스택 개발 인증

반응형 웹 디자인, 알고리즘 및 자료구조, 프론트엔드 개발 라이브러리, 데이터 시각화, 백엔드 개발 및 API, 레거시 정보 보안 및 품질 보증 인증을 모두 획득하면 freeCodeCamp.org 풀스택 개발 인증을 받을 수 있습니다. 이 인증은 여러분이 약 1,800시간의 코딩과 다양한 웹 개발 도구 활용을 완료했음을 의미합니다.

#### 레거시 인증

2015년 커리큘럼부터 이어진 4개의 레거시 인증도 여전히 제공됩니다. 이 레거시 인증에 필요한 모든 프로젝트는 freeCodeCamp.org에서 계속 이용 가능합니다.

- 레거시 프론트엔드 개발 인증
- 레거시 데이터 시각화 인증
- 레거시 백엔드 개발 인증
- 레거시 정보 보안 및 품질 보증 인증

### 무료 전문 인증

#### [(신규) Microsoft와 함께하는 기초 C# 인증](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/)

- [C#으로 첫 코드 작성하기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#write-your-first-code-using-c-sharp)
- [간단한 C# 콘솔 앱 생성 및 실행하기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#create-and-run-simple-c-sharp-console-applications)
- [C# 콘솔 앱에 로직 추가하기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#add-logic-to-c-sharp-console-applications)
- [C# 콘솔 앱에서 변수 데이터 다루기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#work-with-variable-data-in-c-sharp-console-applications)
- [C# 콘솔 앱에서 메서드 만들기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#create-methods-in-c-sharp-console-applications)
- [C# 콘솔 앱 디버깅하기](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/#debug-c-sharp-console-applications)
  <br />
  <br />
  **시험**: [Microsoft와 함께하는 기초 C# 인증 시험](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/foundational-c-sharp-with-microsoft-certification-exam/foundational-c-sharp-with-microsoft-certification-exam)

### 학습 플랫폼

이 코드는 [freeCodeCamp.org](https://www.freecodecamp.org)에서 실시간으로 실행되고 있습니다.

우리 커뮤니티는 다음과 같은 서비스를 제공합니다:

- [포럼](https://forum.freecodecamp.org): 보통 몇 시간 이내에 프로그래밍 도움이나 프로젝트 피드백을 받을 수 있습니다.
- [YouTube 채널](https://youtube.com/freecodecamp): Python, SQL, Android 및 다양한 기술의 무료 강좌가 있습니다.
- [기술 출판물](https://www.freecodecamp.org/news): 수천 개의 프로그래밍 튜토리얼과 수학, 컴퓨터 과학 관련 기사 제공.
- [Discord 서버](https://discord.gg/Z7Fm39aNtZ): 개발자나 코딩을 배우는 사람들과 소통할 수 있습니다.

> #### [여기에서 커뮤니티에 가입하세요](https://www.freecodecamp.org/signin).

### 버그 및 이슈 신고

버그를 발견했다고 생각된다면, 먼저 [버그 신고 방법](https://forum.freecodecamp.org/t/how-to-report-a-bug/19543) 글을 읽고 안내를 따라 주세요.

새로운 버그임을 확신하고 다른 사람도 동일한 문제를 겪고 있다면, 새 GitHub 이슈를 생성하세요. 버그를 재현할 수 있도록 최대한 많은 정보를 포함해 주세요.

### 보안 이슈 및 책임 있는 공개

플랫폼과 사용자 보호에 영향을 줄 수 있는 취약점의 책임 있는 공개에 감사드립니다.

> #### [보안 정책을 읽고, 취약점 신고 절차를 따라주세요](https://contribute.freecodecamp.org/#/security).

### 기여 방법

freeCodeCamp.org 커뮤니티는 여러분과 같은 수천 명의 친절한 자원봉사자 덕분에 가능했습니다. 모든 커뮤니티 기여를 환영하며, 여러분의 참여를 기대합니다.

> #### [기여 방법을 따라주세요](https://contribute.freecodecamp.org).

최근 기여 현황:

![Alt](https://repobeats.axiom.co/api/embed/89be0a1a1c8f641c54f9234a7423e7755352c746.svg 'Repobeats analytics image')

### 라이선스

Copyright © 2025 freeCodeCamp.org

이 저장소의 내용은 아래 라이선스가 적용됩니다:

- 컴퓨터 소프트웨어는 [BSD-3-Clause](LICENSE.md) 라이선스에 따라 제공됩니다.
- [`/curriculum`](/curriculum) 디렉토리 및 그 하위 디렉토리의 학습 자료는 Copyright © 2025 freeCodeCamp.org

---

[Powered By DeepAiTx](https://github.com/DeepAiTx)

---