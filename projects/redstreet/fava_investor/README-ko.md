# Fava 투자자

Fava 투자자는 [Beancount](https://beancount.github.io/) 및
[Fava](https://github.com/beancount/fava) (소프트웨어로서
[평문, 복식부기](https://plaintextaccounting.org/))를 위한
투자에 관한 종합적인 보고서, 분석 및 도구 세트를 목표로 합니다. 각 모듈은 *Fava 플러그인, Beancount 라이브러리, 그리고
쉘 명령어*를 제공하는 모듈 모음으로 개발되었습니다.

### 현재 모듈:
- [클래스별 시각적 트리 구조 자산 배분](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/assetalloc_class#readme)
- 계좌별 자산 배분
- [세금 손실 수확기](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/tlh#readme)
- [현금 드래그 분석](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/cashdrag#readme)
- [요약기](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/summarizer#readme)
- [이익 최소화기](https://github.com/redstreet/fava_investor/blob/main/fava_investor/modules/minimizegains#readme)

### 데모
***[pythonanywhere](http://favainvestor.pythonanywhere.com/example-beancount-file/extension/Investor/)에서
라이브 데모를 체험해 보세요***.


#### 스크린샷 (날짜 포함):
![스크린샷: TLH](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot.png)
![스크린샷: 자산 배분](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot-assetalloc.png)

### 유틸리티

Fava 투자자는 `ticker-util`을 함께 제공하는데, 이는 다음을 위한 유틸리티 모음입니다:
- 야후에서 상품(티커)에 대한 정보를 다운로드하고,
  상품 선언에 메타데이터를 주석 처리
- 최소한의 불완전한 명세로부터 Beancount 파일 내 티커 간 관계 탐색, 예를 들어 동등하거나 실질적으로 동일한 티커, 세금 손실 수확 파트너 그룹 등
- 수입자를 위한 ISIN 및 기타 티커 식별 정보 제공

더 자세한 내용은 pip로 fava_investor를 설치한 후 다음을 참조하세요:



```
ticker-util --help
ticker-util relate --help
```


## 설치
```bash
pip3 install fava-investor
```

또는 git에서 최신 버전을 설치하려면:
```bash
pip3 install git+https://github.com/redstreet/fava_investor
```
MacOS 설치는 [#55](https://github.com/redstreet/fava_investor/issues/55)를 참조하세요.

최신 버전의 Fava Investor는 Beancount v2와 v3 모두와 호환됩니다.

## Fava Investor 실행하기
### Fava 내에서 실행하기:
이 내용을 beancount 소스에 추가한 후 평소처럼 fava를 시작하세요:
```
2000-01-01 custom "fava-extension" "fava_investor" "{}"
```
이제 fava의 사이드바에 'Investor' 링크가 표시되어야 합니다. 확장 기능 구성에 대한 자세한 내용은 포함된 `huge-example.beancount`를 참조하십시오.

### 명령줄에서 실행하기:
명령줄 인터페이스(CLI)는 `investor` 명령어를 사용하여 액세스하며, 각 모듈에 대한 하위 명령어가 있습니다. 예:




```
investor assetalloc-class
investor tlh
investor --help
```

Both the CLI and the utility (`ticker-util`) use [click](https://click.palletsprojects.com/en/8.1.x/).
[See here](https://click.palletsprojects.com/en/8.1.x/shell-completion/#enabling-completion)
to enable shell completion in zsh, bash, or fish, which is highly recommended.

## 문제가 있나요?
- fava를 실행하는 터미널을 모니터링하여 fava_investor의 오류 출력을 확인하세요
- 버그 보고서 작성 또는 도움 요청 시 위에서 본 오류 메시지를 포함하세요

## 기여하기

기능, 수정 및 개선 환영합니다. 다음을 기억하세요:
- 자유롭게 풀 리퀘스트를 보내세요. 단위 테스트를 포함해 주세요
- 더 큰 변경 사항이나 논의가 필요할 수 있는 변경 사항은 먼저 연락하여 논의해 시간을 절약하세요 (이슈 열기)
- 커밋은 적절히 스쿼시해 주세요
- 커밋 메시지에는 [컨벤셔널 커밋](https://www.conventionalcommits.org/en/v1.0.0/)을 사용하세요

기여해 주셔서 감사합니다!

## 관련 프로젝트
- [Fava Dashboards](https://github.com/andreasgerstmayr/fava-dashboards)
- [Fava Portfolio Returns](https://github.com/andreasgerstmayr/fava-portfolio-returns)
- [Beangrow](https://github.com/beancount/beangrow)




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---