# RSS-Master

RSS 소스에 대한 맞춤 필터링, 선별, AI 요약, 개요, 점수 매기기 등을 지원합니다. 성능 최적화 버전으로 비동기 처리 및 병렬 AI 요약을 지원합니다.

### 서문

9월 초순, 저는 Inoreader + RSSHub를 사용해 관심 있는 RSS를 집계, 구독하며 Reeder로 읽기 시작했습니다. 매일 입력되는 정보 원천을 완전히 통제하려 했습니다. 한 달이 지나면서 점점 늘어나는 RSS 소스와 증가하는 미독 정보가 저에게 많은 읽기 불안을 가져왔습니다. 그래서 맞춤 필터링 규칙을 만들 수 있고, AI를 활용해 읽기를 보조하여 부담을 줄일 수 있는 방법이 있을지 고민했습니다.

Inoreader에는 필터 기능이 있지만, 이 기능만을 위해 비용을 지불하기는 아까웠습니다; NewsBlur에는 ‘Intelligence Trainer’라는 지능형 분류 기능이 있지만, 간단히 시도해보니 피드백이 뚜렷하지 않고 단기간에 지능이 체감되지 않았습니다; Feedly는 필터링과 AI 기능 모두 갖추고 있어 제 요구에 부합하는 듯했지만, Inoreader에서 Feedly 유료 사용자로 갈아탈까 고민하던 중 다음 두 프로젝트를 발견했습니다.

- [ChatGPT로 Hacker News 요약하기](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT 사용 가이드](http://yinan.me/rss-gpt-manual-zh.html)

이 두 프로젝트의 전반적인 아이디어는 GitAction을 통해 스크립트를 실행하고, 정보를 받아 OpenAI API로 번역, 요약한 뒤 템플릿으로 렌더링해 GitHub Page에 배포하는 방식입니다. RSS-GPT 방식이 제 요구에 더 맞았는데, 스케줄러로 스크립트를 실행해 RSS xml 파일을 직접 가져와 처리 후 GitHub Page에 배포해 이 xml 파일의 접근 URL을 얻고, 리더기가 이 URL을 직접 구독하도록 하는 방식입니다.

저는 Inoreader의 다중 기기 동기화가 매우 필요하며, config 설정 파일에 새 RSS 소스가 추가되면 즉시 Inoreader에 동기화를 알릴 필요가 있었습니다. 그래서 [RSS-GPT](https://github.com/yinan-c/)의 아이디어를 확장해 RSS-Master라는 프로젝트를 만들었습니다.

### 기능 특징

- **병렬 처리 지원**: 비동기 및 스레드 풀을 사용해 RSS 소스와 AI 요약을 병렬 처리하여 처리 속도 대폭 향상
- **강화된 캐시 메커니즘**: 더욱 안정적인 캐시 시스템으로 데이터 손실 방지 및 반복 접근 성능 향상
- **향상된 오류 처리**: 모든 작업에 완전한 오류 처리와 로그 기록을 제공하여 안정성 강화
- **HTML 콘텐츠 최적 추출**: 관련 없는 정보를 무시하고 글 내용을 지능적으로 추출하여 AI 요약 품질 향상
- **최신 OpenAI API 지원**: 최신 버전 OpenAI API 완전 호환
- **상세 통계 정보 제공**: 처리 완료 후 실행 시간, 성공률, 비용 통계 제공
- **opml 파일 생성 지원**: `script/convert_opml_to_yaml.sh`, `script/convert_yaml_to_opml.sh`를 통한 opml 파일과 config.yml 간 상호 변환 지원
- **맞춤 필터링 규칙 지원**: include, exclude 두 가지 유형과 title, article 두 가지 적용 범위 지원
- **커스텀 AI 모델 설정 가능**: 환경 변수로 다양한 OpenAI 모델 사용 설정 가능
- **기본 URL 커스터마이징**: 다양한 환경에서 배포할 수 있도록 RSS 파일 기본 접근 URL 설정 가능
- **인터랙티브 테스트 노트북 제공**: Jupyter 노트북으로 각 기능 테스트 가능

### 환경 변수 설정

프로젝트는 `.env` 파일로 다음 파라미터를 설정할 수 있습니다:

```
# 필수 파라미터
OPENAI_API_KEY=your_openai_api_key_here

# 선택 파라미터
RSS_BASE_URL=https://example.com/rss-feeds/  # RSS 기본 URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI 모델
LOG_LEVEL=INFO                               # 로그 레벨
PARALLEL_WORKERS=5                           # 병렬 처리 수
```

`.env.example` 파일을 복사해 `.env`로 이름 변경 후 적절히 수정하세요.

### 성능 개선

이번 버전은 원본 대비 다음과 같은 성능 개선을 포함합니다:

1. **RSS 소스 병렬 처리**: `asyncio`를 사용해 여러 RSS 소스를 동시에 처리
2. **AI 요약 병렬화**: 스레드 풀로 여러 기사 AI 요약 동시 처리
3. **텍스트 처리 최적화**: HTML 콘텐츠 추출 알고리즘 개선으로 핵심 내용 지능적 추출
4. **안전한 파일 처리**: 안전한 파일 쓰기 메커니즘 적용, 프로그램 충돌 시 데이터 손실 방지
5. **메모리 사용 최적화**: 데이터 구조 및 처리 프로세스 최적화로 메모리 사용량 감소

### 사용법

1. 프로젝트를 로컬에 클론
2. 의존성 설치: `pip install -r requirements.txt`
3. `.env` 파일 생성 후 OpenAI API 키 설정: `OPENAI_API_KEY=당신의_키`
4. `resource/config.yml` 파일에서 RSS 소스 설정
5. `python main.py` 실행하여 처리 시작

### 테스트 및 디버깅

프로젝트는 기능 테스트용 인터랙티브 노트북 `test.ipynb`를 제공합니다. 다음 기능을 테스트할 수 있습니다:

1. RSS 소스 수집 및 파싱
2. 필터 기능
3. AI 요약 기능
4. 캐시 메커니즘
5. 맞춤 기본 URL 설정
6. 성능 테스트

사용 방법:

```bash
# Jupyter 설치
pip install jupyter

# 노트북 실행
jupyter notebook test.ipynb
```

### 맞춤 필터링 규칙 예시

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '콜라',
          '스프라이트',
          '판타',
          '레몬',
          '차잎',
          '화장지',
          '알코올',
          '물티슈',
          '냅킨',
        ]
```

### 사용 화면 캡처

- AI 요약 및 개요 기능

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- 맞춤 필터링: ‘什么值得买’의 좋은 가격 채널 필터링, 최근에 쟁이고 싶은 상품만 추천 (예: 탄산음료)

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/什么值得买-汽水.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---