# Godot-Easy-Vehicle-Physics
Godot 4.2 이상용 레이캐스트 기반 강체 차량 시스템

## 설명
키보드로 플레이하기 적합하고 설정하기 쉬운 물리 기반 차량 컨트롤러입니다. 모든 매개변수는 하나의 스크립트(vehicle.gd)에 포함되어 있으며, 모두에 대해 툴팁이 제공됩니다.

## 기능
이 컨트롤러는 다음과 같은 유능한 차량 제작을 돕는 다양한 시스템을 특징으로 합니다:
- 조향 보조
- 반대 조향 보조
- 트랙션 컨트롤
- 안티록 브레이크
- 안정성 보조
- 공중 보조
- 자동 변속기
- 차동 잠금 장치
- 타이어 그립 보조
- 계산된 서스펜션 매개변수; 적절한 서스펜션 매개변수 설정은 어려울 수 있으므로, 이 컨트롤러는 비율과 무게 분포를 기반으로 스프링 강도와 감쇠율을 계산합니다.

## 예제
4가지 예제 차량이 포함되어 있습니다:
- demo_arcade.tscn: 아케이드 스타일 레이싱카처럼 다루기 쉽고 많은 그립과 보조 기능을 갖춤.
- demo_simcade.tscn: 실제 자동차와 유사한 조작감에 차량 제어를 돕는 보조 기능 포함.
- demo_monster_truck.tscn: 몬스터 트럭처럼 다루며 보조 기능은 매우 적음.
- demo_drift.tscn: 쉬운 드리프트를 위한 설정.

## 조작법
- 조향: 왼쪽: ← 또는 a 오른쪽: → 또는 d
- 가속: ↑ 또는 w
- 브레이크: ↓ 또는 s
- 핸드브레이크: 스페이스
- 클러치: C
- 변속기 토글 (자동/수동): T
- 변속 상승: F 또는 +
- 변속 하강: R 또는 -
- 디버그 정보: ~
- 디버그 화면 전환: < 또는 >

## 물리 엔진
이 컨트롤러는 Godot 및 Jolt 물리 엔진 모두에서 잘 작동합니다. 최소 120의 물리 틱 레이트를 권장하며 더 높은 값도 사용 가능하지만, 틱 레이트 변경 시 차량 동작이 달라질 수 있습니다.

## 감사의 글
Dechode와 Wolfe가 Godot 커뮤니티에 프로젝트를 공유해 주신 것에 대해 크게 감사드립니다. 이 프로젝트 공유는 그에 대한 보답의 의미입니다. 이 코드의 일부는 [Dechode의 Godot Advanced Vehicle](https://github.com/Dechode/Godot-Advanced-Vehicle) 및 [SERIES: Driving Simulator Workshop](https://lupine-vidya.itch.io/gdsim/devlog/677572/series-driving-simulator-workshop-mirror)을 기반으로 하며, 해당 소스 파일에 적절히 출처가 명시되어 있습니다.
데모로 제공된 자동차 모델은 [Kenney.nl Car Kit](https://www.kenney.nl/assets/car-kit)에서 가져왔습니다.

## Godot Easy Vehicle Physics를 사용하는 프로젝트
이 애드온을 사용하는 프로젝트를 진행 중이며 여기에 목록을 추가하고 싶다면, 이슈를 열어 알려 주세요.
- [Jack of all Cars](https://dashoe1.itch.io/jack-of-all-cars)
- [Another Lap](https://store.steampowered.com/app/3550210/Another_Lap/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---