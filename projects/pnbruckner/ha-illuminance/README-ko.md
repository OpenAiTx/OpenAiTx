# <img src="https://brands.home-assistant.io/illuminance/icon.png" alt="Sun2 Sensor" width="50" height="50"/> 조도 센서
태양 고도 또는 시간대에 기반하여 야외 조도를 추정하는 `sensor` 엔티티를 생성합니다.  
두 경우 모두, 값은 다른 기존 엔티티에서 얻은 현재 기상 조건 또는 구름 덮개를 기준으로 추가 조정할 수 있습니다.


## 작동 모드
세 가지 모드가 제공됩니다: 일반, 복사조도 및 단순 모드.

### 일반/복사조도 모드 - 태양 고도
이 모드는 미국 해군 천문대[^1]의 알고리즘을 사용하여 태양의 고도(고도각)에 따른 태양 조도 또는 복사조도를 추정합니다. 최대 조도 값은 약 150,000 lx이며, 최대 복사조도 값은 약 1,250 와트/㎡입니다.  
아래는 3일간 조도 변화 예시입니다.

<p align="center">
  <img src=images/normal.png>
</p>

[^1]: Janiczek, P. M., and DeYoung, J. A. _Computer Programs for Sun and Moon Illuminance With Contingent Tables and Diagrams_. Circular No. 171. Washington, D. C.: United States Naval Observatory, 1987 [Google Scholar](https://scholar.google.com/scholar_lookup?title=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams&author=P.%20M.%20Janiczek&author=J.%20A.%20Deyoung&publication_year=1987&book=Computer%20programs%20for%20sun%20and%20moon%20illuminance%20with%20contingent%20tables%20and%20diagrams)

### 단순 모드 - 시간대
야간에는 값이 10 lx입니다. 해뜨기 전후 조금 전부터 현재 조건에 따라 값이 점차 상승합니다. 해질 무렵에도 마찬가지로 값이 점차 하락합니다.  
역사적 이유로 최대 값은 10,000 lx입니다. 아래는 3일간 변화 예시입니다.

<p align="center">
  <img src=images/simple.png>
</p>

## 지원하는 기상 소스
[표준 조건 목록](https://www.home-assistant.io/integrations/weather/#condition-mapping)을 사용하는 모든 기상 엔티티 또는 구름 덮개 백분율을 제공하는 엔티티는 이 통합과 작동해야 합니다.  
다음은 지원되는 것으로 알려진 기상 데이터 소스입니다:

통합 | 비고
-|-
[AccuWeather](https://www.home-assistant.io/integrations/accuweather/) | `weather`
[Buienradar](https://www.home-assistant.io/integrations/buienradar/) | `weather`
[ecobee](https://www.home-assistant.io/integrations/ecobee/) |
[Meteorologisk institutt (Met.no)](https://www.home-assistant.io/integrations/met/) | `weather`
[OpenWeatherMap](https://www.home-assistant.io/integrations/openweathermap/) | `weather`; cloud_coverage 및 condition `sensor`

## 설치

이 통합 소프트웨어는 먼저 커스텀 컴포넌트로 설치되어야 합니다.
HACS를 사용하여 설치를 관리하고 업데이트 알림을 받을 수 있습니다.
또는 소프트웨어를 수동으로 설치할 수 있습니다.

<details>
<summary>HACS 사용 시</summary>

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg)](https://hacs.xyz/)

1. 이 저장소를 [커스텀 저장소](https://hacs.xyz/docs/faq/custom_repositories/)로 추가하세요:
   그러면 새로운 통합으로 나타납니다. 클릭하세요. 필요하면 "illuminance"를 검색하세요.
   ```text
   https://github.com/pnbruckner/ha-illuminance
   ```
   또는 이 버튼을 사용하세요:
  
   [![Home Assistant 인스턴스를 열고 Home Assistant Community Store 내의 저장소를 엽니다.](https://my.home-assistant.io/badges/hacs_repository.svg)](https://my.home-assistant.io/redirect/hacs_repository/?owner=pnbruckner&repository=ha-illuminance&category=integration)

1. 적절한 버튼을 사용하여 통합을 다운로드합니다.

</details>

<details>
<summary>수동 설치</summary>

[`custom_components/illuminance`](custom_components/illuminance) 폴더의 파일 복사본을
`<config>/custom_components/illuminance`에 배치하세요,
여기서 `<config>`는 Home Assistant 구성 디렉터리입니다.

>__참고__: 다운로드 시 각 파일 페이지에서 `Raw` 버튼을 사용해야 합니다.

</details>

### 설치 후

다운로드가 완료되면 Home Assistant를 재시작해야 합니다.

### 버전

이 커스텀 통합은 HomeAssistant 버전 2024.8.3 이상을 지원합니다.

## 서비스

### `illuminance.reload`

YAML 구성에서 Illuminance를 다시 로드합니다. 또한 개발자 도구 -> YAML 페이지에 `ILLUMINANCE`를 추가합니다.

## 구성 변수

하나 이상의 센서에 대한 구성 옵션 목록입니다. 각 센서는 다음 옵션으로 정의됩니다.

> 참고: 이는 YAML을 통한 구성을 정의합니다. 그러나 동일한 센서들을 UI에서 추가할 수도 있습니다.

키 | 선택사항 | 설명
-|-|-
`unique_id` | 아니오 | 센서의 고유 식별자입니다. 이를 통해 나머지 옵션을 변경해도 새로운 센서로 인식되지 않습니다. (YAML 기반 구성에만 필요합니다.)
`entity_id` | 예 | 현재 날씨 상태 또는 구름 덮임 비율을 나타내는 다른 엔티티의 엔티티 ID입니다.
`fallback` | 예 | 날씨 데이터가 없을 때 사용할 조도 나누기 값입니다. 1(맑음)부터 10(어두움) 범위 내여야 합니다. `entity_id`가 사용되면 기본값은 10이고, 그렇지 않으면 1입니다.
`mode` | 예 | 작동 모드입니다. 선택지는 태양 고도를 사용하는 기본값 `normal`, 시간대를 사용하는 `simple`, 그리고 값이 와트/제곱미터로 표현되는 `irradiance`(기본 `normal`과 동일)입니다.
`name` | 예 | 센서 이름입니다. 기본값은 `Illuminance`입니다.
`scan_interval` | 예 | 업데이트 간격입니다. 최소 30초이며 기본값은 5분입니다.

## 2.1.0 이전 릴리스
자세한 내용은 https://github.com/pnbruckner/homeassistant-config/blob/master/docs/illuminance.md 를 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---