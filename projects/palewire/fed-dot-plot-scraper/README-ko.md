["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) 경제 전망을 [연방공개시장위원회(Federal Open Market Committee)](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)가 온라인에 게시한 자료에서 추출합니다.

* [출처](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [최신 스크래핑 데이터](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## 사용법

저장소를 클론합니다.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

디렉터리로 이동합니다.

```bash
cd fed-dot-plot-scraper
```

의존성을 설치합니다.

```bash
pipenv install --dev
```

스크래퍼를 실행합니다.

```bash
pipenv run python -m src.scrape
```

위 명령은 셸에 CSV를 출력합니다. 다음과 같이 파일로 저장할 수 있습니다:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---