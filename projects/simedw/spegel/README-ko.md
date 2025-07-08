# Spegel – AI를 통한 웹 반영

웹사이트를 자동으로 마크다운으로 변환하여 터미널에서 최적화된 형태로 보여줍니다.  
소개 블로그 글은 [여기](https://simedw.com/2025/06/23/introducing-spegel/)에서 읽어보세요.

이 프로젝트는 개념 증명(proof-of-concept) 단계이며, 버그가 있을 수 있습니다. 이슈나 풀 리퀘스트는 언제든 환영합니다.

##  스크린샷
때로는 누군가의 인생 이야기를 읽지 않고도 레시피에 바로 접근하고 싶을 때가 있습니다  
![Recipe Example](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)

## 설치

Python 3.11 이상이 필요합니다.

```
pip install spegel
```
또는 저장소를 클론하여 editable 모드로 설치할 수 있습니다.

```bash
# 저장소를 클론하고 디렉토리로 이동
$ git clone <repo-url>
$ cd spegel

# 의존성과 CLI 설치
$ pip install -e .
```

## API 키
Spegel은 현재 Gemini 2.5 Flash만 지원합니다. 사용하려면 환경 변수에 API 키를 제공해야 합니다.

```
GEMINI_API_KEY=...
```

## 사용법

### 브라우저 실행

```bash
spegel                # 시작 화면으로 실행
spegel bbc.com        # 즉시 URL 열기
```

또는, 다음과 같이 사용할 수도 있습니다:

```bash
python -m spegel      # 시작 화면으로 실행
python -m spegel bbc.com
```

### 기본 컨트롤
- `/`         – URL 입력창 열기
- `Tab`/`Shift+Tab` – 링크 순환
- `Enter`     – 선택한 링크 열기
- `e`         – 현재 보기의 LLM 프롬프트 편집
- `b`         – 뒤로 가기
- `q`         – 종료

## 설정 편집

Spegel은 TOML 구성 파일에서 설정을 불러옵니다. 뷰, 프롬프트, UI 옵션을 커스터마이즈할 수 있습니다.

**설정 파일 검색 순서:**  
1. `./.spegel.toml` (현재 디렉토리)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

설정을 편집하려면:  
1. 예시 구성 파일 복사:
   ```bash
   cp example_config.toml .spegel.toml
   # 또는 ~/.spegel.toml 생성
   ```
2. 선호하는 편집기로 `.spegel.toml` 파일을 편집하세요.

예시 스니펫:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Transform this webpage into the perfect terminal browsing experience! ..."
```

---

자세한 내용은 코드 참고 또는 이슈를 남겨주세요!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---