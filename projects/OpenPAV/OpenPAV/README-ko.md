# Open-PAV

OpenPAV(Open Production Automated Vehicle)은 생산 자동화 차량(PAV)의 **데이터 수집, 행동 모델링 및 성능 평가**를 용이하게 하기 위해 설계된 오픈 플랫폼입니다. 다양한 데이터셋과 보정된 차량 모델을 통합하여 PAV 동역학 및 그 영향을 연구하려는 연구자와 개발자에게 필수적인 도구입니다. 이 프로젝트는 연구 커뮤니티의 기여를 장려하며 시뮬레이션 도구와 원활하게 통합할 수 있는 즉시 사용 가능한 모델 매개변수를 제공합니다. 자세한 내용은 [OpenPAV 웹사이트](https://openpav.github.io/OpenPAV)를 확인하세요.

![Framework](https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Framework.png)

## 데이터 출처 및 기여자

### 원본 데이터 출처:

현재 데이터셋은 7개의 제공자에서 14개의 오픈 소스 데이터셋을 검토했으며, 각 데이터셋은 다양한 주행 조건과 시나리오에서 AV 행동에 대한 독특한 통찰력을 제공합니다. 이들은 다음과 같습니다:

- **Argoverse 2 Motion Forecasting Dataset**. 텍사스 오스틴, 미시간 디트로이트, 플로리다 마이애미, 펜실베이니아 피츠버그, 캘리포니아 팔로 알토, 워싱턴 D.C.에서 Argo AI와 카네기 멜론 대학교 및 조지아 공과대학교 연구진이 수집했습니다. 이용 가능 - [Argoverse 2 Motion Forecasting Dataset](https://www.argoverse.org/av2.html).
- **CATS Open Datasets**. 플로리다 탬파와 위스콘신 매디슨에서 CATS 연구소가 수집한 세 개의 데이터셋. 이용 가능 - [CATS Lab](https://github.com/CATS-Lab).
- **Central Ohio ACC Datasets**. 오하이오에서 UCLA 모빌리티 연구소와 교통 연구 센터가 수집한 두 개의 데이터셋. 이용 가능 - [Advanced Driver Assistance System (ADAS)-Equipped Single-Vehicle Data for Central Ohio](https://catalog.data.gov/dataset/advanced-driver-assistance-system-adas-equipped-single-vehicle-data-for-central-ohio).
- **MircoSimACC Dataset**. 플로리다의 델레이 비치, 록사허치, 보카 레이턴, 파크랜드 등 네 도시에서 플로리다 애틀랜틱 대학교 연구 그룹이 수집. 이용 가능 - [microSIM-ACC](https://github.com/microSIM-ACC).
- **OpenACC Database**. 이탈리아, 스웨덴, 헝가리 전역에서 유럽 위원회 공동 연구 센터가 수집한 네 개의 데이터셋. 이용 가능 - [data.europa.eu](https://data.europa.eu/data/datasets/9702c950-c80f-4d2f-982f-44d06ea0009f?locale=en).
- **Vanderbilt ACC Dataset**. 테네시 내슈빌에서 밴더빌트 대학교 연구 그룹이 수집. 이용 가능 - [Adaptive Cruise Control Dataset](https://acc-dataset.github.io/).
- **Waymo Open Dataset**. 캘리포니아 샌프란시스코, 마운틴 뷰, 로스앤젤레스, 애리조나 피닉스, 미시간 디트로이트, 워싱턴 시애틀 등 6개 도시에서 Waymo가 수집한 두 개의 데이터셋. 이용 가능 - [Waymo Motion Dataset](https://waymo.com/open/data/motion/) 및 [Waymo Open Dataset에서 처리한 차량 궤적 데이터](https://data.mendeley.com/datasets/wfn2c3437n/2).

<img src="https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Dataset.png" alt="Major Components" width="600">

### 가공된 데이터 출처:

위 데이터셋의 데이터를 정리하여 모든 데이터가 표준화된 형식으로 표현된 통합 궤적 데이터셋 ULTra-AV를 처리했습니다. 이용 가능 - [자동화 차량을 위한 통합 종방향 궤적 데이터셋](https://www.nature.com/articles/s41597-024-03795-y) 및 [ULTra-AV](https://github.com/CATS-Lab/Filed-Experiment-Data-ULTra-AV).

## 최신 소식

- **2026년 3월:** 프로젝트가 새로운 인터페이스를 출시했습니다.
- **2024년 11월:** 설치 및 사용자 가이드와 함께 프로젝트가 초기 시작되었습니다.

## 주요 구성 요소

Open-PAV는 다음 구성 요소로 이루어져 있습니다:

- **데이터 처리:** 원시 AV 데이터(LiDAR, 이미지, 비디오, 궤적)를 입력으로 받아 동일 유형 데이터를 통합 형식으로 변환하고 초기 데이터 정리를 수행하는 모듈입니다.
- **행동 모델링:** 처리된 AV 데이터를 사용하여 자동화 차량의 차량 운동학 모델을 보정하고 시뮬레이션 용도로 내보냅니다. 사용자는 자체 AV 소프트웨어 스택을 직접 입력하여 이 모듈 내에서 개발한 AV 시스템을 테스트할 수도 있습니다.
- **가속 평가:** 주어진 AV 모델에 특화된 맞춤형 안전 위험 주행 시나리오를 생성하여 안전 성능을 평가하는 모듈입니다.


## 기여자

### 기여 그룹

[CATS Lab](https://catslab.engr.wisc.edu/) (책임연구자: [Xiaopeng Li](https://catslab.engr.wisc.edu/staff/xiaopengli/))

[CAT Lab](http://www.connectedandautonomoustransport.com/dr-zhengs-research.html) (책임연구자: [Zuduo Zheng](https://civil.uq.edu.au/profile/857/zuduo-zheng))

[SHINE Lab](https://sites.google.com/site/danjuechen/) (책임연구자: Danjue Chen)

NextGen-ITS Lab (책임연구자: David Kan)

### 기술 기여자:

- [Hang Zhou](https://catslab.engr.wisc.edu/staff/zhou-hang/), [Ke Ma](https://markmaaaaa.github.io/KeMa.github.io/), Keke Long , Chengyuan Ma.

### 관련 출판물:

- Zhou, H., Ma, K., Liang, S., Li, X., and Qu, X. (2024). *자동차 자동화를 위한 통합 종방향 궤적 데이터셋*. *Scientific Data*, 11, 1123.

### 감사의 글:

이 프로젝트는 국가과학재단(NSF)의 "[NSF CPS: Small: NSF-DST: 교차로에서 메타러닝을 이용한 자동화 차량의 ‘공유지의 비극(ToC)’을 ‘출현적 협력 행동(ECB)’으로 전환](https://www.nsf.gov/awardsearch/show-award?AWD_ID=2343167)" (No. 2343167) 지원을 일부 받았습니다. 또한 [IEEE 지능형 교통 시스템 학회(ITSS) 신흥 교통 기술 테스트(ET3) 기술 위원회](https://ieee-itss.org/chapters-committees/emerging-transportation-technology-testing)의 지원에 감사를 표합니다.

이 작업을 가능하게 한 모든 데이터셋 제공자와 기여자분들께 진심으로 감사드립니다.

## 라이선스

Open-PAV는 [MIT 라이선스](LICENSE) 하에 배포됩니다. 자세한 내용은 LICENSE 파일을 참조하십시오.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---