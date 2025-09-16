# ECSCombat

유니티 ECS 프레임워크를 사용한 SF 전투 시뮬레이션입니다.

[![미리보기 이미지](https://img.youtube.com/vi/S2RJfbJly_A/0.jpg)](https://www.youtube.com/watch?v=S2RJfbJly_A)

무한 전투 영상은 [여기](https://www.youtube.com/watch?v=S2RJfbJly_A)에서 볼 수 있습니다.

## 살펴볼 만한 제안:

* 다양한 AI 행동은 `Battle/AI`에서 찾을 수 있습니다.
* 전투 시스템은 `Battle/Combat`에 있습니다. 여기에는 다양한 무기 유형(투사체/즉발), 사거리 기반 무기 효과, 방패로 공격 차단 등이 포함됩니다.
* 장비와 기어는 `Battle/Equipment`에 있습니다. 함선은 다양한 장비를 장착할 수 있으며, 이들은 함선의 속도나 회전 속도 변경 등의 효과를 가질 수 있습니다. 장비는 공격받으면 손상되어 비활성화될 수 있으며, 예를 들어 손상된 엔진은 함선을 무력화시킵니다.

## 기술 세부 사항:

* Unity 2020.1.0b7
* 유니버설 렌더 파이프라인 (함선 셰이더는 셰이더 그래프로 작성)

## 주의 사항!

이 프로젝트는 원래 Unity Entities 패키지가 아직 초기 단계였을 때 ECS(Entity-Component-System) 스타일 프로그래밍 연습용으로 시작되었습니다.
이후 Unity Entities API와 권장되는 모범 사례에 상당한 변화가 있었습니다.
가능한 한 최신 상태를 유지하려 노력했지만, 제 한정된 여가 시간으로 인해 개선이 필요한 부분이 분명히 있을 것입니다.
따라서 이 프로젝트에서 영감을 얻되, 더 나은 방법이 있을 수 있음을 염두에 두세요!

## 최종 감사 인사

몇몇 스프라이트는 제가 만들었으나, 멋진 것들은 [여기](https://opengameart.org/content/spaceships-1)에서 가져왔으며, 해당 저작권은 [Wuhu](https://opengameart.org/users/wuhu)에게 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---