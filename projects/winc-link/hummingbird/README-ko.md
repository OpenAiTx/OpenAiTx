<p align="center">
	<img src="https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/logo.png" width="100">
<br>

</p>

# 제품 소개

허밍버드(HummingBird)는 Golang 언어로 구현된 초경량 IoT 개발 플랫폼으로, 핵심 서비스는 전적으로 팀에서 자체 개발하였습니다. 이 플랫폼 설계 초기부터 경량화와 우수한 성능을 개발 원칙으로 삼았습니다. 따라서 모든 서비스는 Golang 언어로 작성되어 메모리 점유율이 매우 낮습니다. 데이터 저장에서는 SQLite와 LevelDB를 혁신적으로 사용하여 저장 데이터베이스로 활용하였으며, SQLite의 경량성과 LevelDB의 데이터 고처리량 및 고압축 특성 덕분에 실제 테스트에서 1C/1G 100G 스토리지 물리 서버에서 수천 대의 장치 연결과 8000만 건의 메시지 저장을 실현할 수 있었습니다.

물론, 데이터의 신뢰성이나 대용량 저장 요구가 있을 경우, SQLite와 LevelDB를 MySQL 및 TDengine으로 교체할 수 있습니다. 허밍버드 IoT 플랫폼은 다양한 데이터베이스 연결을 지원하여 사용자가 자신의 비즈니스 필요에 맞는 데이터베이스를 선택할 수 있습니다.

“참새(허밍버드)는 작지만, 오장육부가 완비되어 있다” 허밍버드는 초경량 IoT 플랫폼임에도 불구하고 핵심 기능이 줄어들지 않습니다. 장치 접속, 제품 관리, 사물 모델, 경보 센터, 규칙 엔진... 이러한 모든 IoT 플랫폼의 기본 기능을 본 플랫폼에서 찾을 수 있습니다.



![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/architecture.png)



# 일부 화면 전시

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/2.png)  |
|:--------------------------|:---------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/4.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/5.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/6.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/9.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/10.png) |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/7.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/8.png)  |

# 미니 프로그램 화면 전시

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge2.png) |
|:---------------------------------------|:---------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge4.png) |

# 공식 문서 주소
https://doc.hummingbird.winc-link.com/

# 빠른 시작

git clone https://gitee.com/winc-link/hummingbird.git

cd hummingbird/manifest/docker 

docker-compose up -d

# 주요 기능

- 제품 관리
- 장치 관리
- 이미지 관리
- 드라이버 관리
- 드라이버 마켓
- 시스템 모니터링
- 경보 센터
- 자원 관리
- 규칙 엔진
- 시나리오 연동
- 플러그인 마켓
- 데이터 대시보드

# 제품 장점

- **무료 오픈소스**: 모든 소스 코드를 공개하여 개인 학습에 적합합니다.
- **우수한 성능**: 실제 테스트에서 2C4G 서버에서 6만 대 장치 연결을 지원합니다. 4천 대 장치를 모사하여 1000ms 간격으로 16kb 길이의 속성 데이터를 서버에 전송할 때 CPU 사용률은 안정적으로 60%, 메모리 사용률은 16%로 유지됩니다.
- **다중 데이터 지원**: 플랫폼은 SQLite, LevelDB, MySQL, TDengine 데이터베이스를 지원하며, 사용자가 프로젝트 요구에 따라 적합한 데이터베이스를 선택할 수 있습니다.
- **시각화 대시보드 지원**: 사용자는 간단한 드래그 앤 드롭만으로 코드 작성 없이 시각화 대시보드를 개발 및 설계할 수 있습니다.
- **내장 제품 템플릿 라이브러리**: 플랫폼 내부에 390개의 제품 템플릿이 사전 탑재되어 있어 사용자가 원클릭으로 제품을 생성할 수 있습니다.
- **명확한 문서**: 플랫폼 문서는 명확하고 완성도 높으며, 다수의 사용 사례와 비디오 튜토리얼을 포함해 사용자가 제품을 빠르게 이해하고 사용할 수 있도록 돕습니다.
- **간편한 배포**: 모든 서비스가 도커(Docker) 형태로 실행되며, docker-compose 명령어로 원클릭 시작을 지원합니다.
- **비용 우위**: 중소형 IoT 프로젝트(장치 수 <= 5000)에서는 2C4G 서버만으로도 충분하며, 로컬 배포도 지원합니다.

# 연락처

우리는 허밍버드 사용자 그룹을 개설하였으며, 제품 사용 중 문제가 있을 경우 그룹에 참여하여 소통할 수 있습니다.


| 위챗 그룹                (먼저 친구 추가 후 그룹 참가 요청)                                                     | QQ 그룹                                                                       |
|:------------------------------------------------------------------------|:--------------------------------------------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qweixin.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qq.png) |

# 오픈소스 기여

-   `master` 브랜치에서 새 브랜치를 `checkout` 합니다 (**주의**: 반드시 `master` 코드가 최신인지 확인하세요)
-   새 브랜치 명명 규칙: `feature/사용자명/설명` 예: `feature/pick/mqtt_driver`
-   새 브랜치에서 문서, 코드 편집 후 커밋합니다
-   `PR`을 제출하여 `develop` 브랜치에 병합 요청하고, 작성자가 병합할 때까지 기다립니다

# 오픈소스 라이선스

`Hummingbird` 오픈 플랫폼은 [Apache 2.0 라이선스](https://www.apache.org/licenses/LICENSE-2.0.html)를 따릅니다. 허밍버드 IoT 플랫폼을 상업적으로 사용하려면 사전에 저자에게 허가를 받으시기 바랍니다!



## 시간에 따른 스타 수

[![Stargazers over time](https://starchart.cc/winc-link/hummingbird.svg)](https://starchart.cc/winc-link/hummingbird)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---