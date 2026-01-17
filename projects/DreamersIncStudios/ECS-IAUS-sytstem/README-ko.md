# ECS-IAUS-시스템
Unity용 무한 축 유틸리티 시스템  
이 유틸리티 시스템은 AI가 사용할 수 있는 옵션을 식별하고 상황에 따라 각 옵션에 점수를 매겨 가장 좋은 옵션을 선택하는 방식으로 작동합니다. 이는 여러 가지 이유로 매우 효과적인 방법임이 입증되었습니다.

설계가 간단함 - 유틸리티 AI는 자연어로 설계할 수 있어 AI 프로그래머가 게임 디자이너와 쉽게 소통할 수 있습니다. 조건, 상태, 시퀀스, 데코레이터와 같은 난해한 개념에 대해 이야기할 필요가 없습니다. 대신 “AI가 공격받고 있을 때는 은폐처 찾기를 우선시한다”와 같은 용어로 의도한 AI 동작을 설명할 수 있습니다. “우선시한다”와 같은 모호한 용어도 사용할 수 있는데, 이는 인간 대화에 자연스러운 방식입니다.

확장 용이 - 규칙, 즉 스코어러라고도 하는 요소들은 기존 AI 위에 쉽게 추가할 수 있습니다. 예를 들어 유한 상태 기계와 달리 중요한 관계를 깨뜨릴 필요가 없습니다. 대신 스코어러를 기존 스코어러 위에 덧붙이기만 하면 되어 AI 기능과 정밀도를 쉽게 확장할 수 있습니다.

더 나은 품질 - 설계의 단순성과 AI 확장의 용이성은 버그를 크게 줄이고 생산성을 비약적으로 향상시킵니다. 이는 주어진 예산과 일정 내에서 더 복잡하고 잘 작동하는 AI 개발에 더 많은 여유를 남겨 전체적으로 AI 품질을 향상시킵니다.

이 프로젝트는 Dave Mark의 무한 축 유틸리티 시스템을 Unity3d에서 DOTS를 사용해 구현하려는 시도입니다.

무한 축 유틸리티 시스템이란 무엇인가?

간단히 말해 가장 높은 값을 가진 동작(Action)을 반환하는 시스템입니다. 기본적으로 동작 리스트가 있고 각 동작은 여러 “축(Axis)”을 가집니다. Dave Mark가 몇 년 전 GDC에서 이 주제로 강연을 했는데 그때 처음 알게 되었습니다. 실제로 그 강연에서 고양이와 레이저 포인터 게임도 언급했는데, 이것이 Lol Cats I Can Has Lazer의 초기 아이디어였으나 우리 게임은 독자적인 디자인 방향으로 진행되었습니다.

강연 링크는 다음과 같습니다:

http://intrinsicalgorithm.com/IAonAI/2013/02/both-my-gdc-lectures-on-utility-theory-free-on-gdc-vault/

https://www.gdcvault.com/play/1018040/Architecture-Tricks-Managing-Behaviors-in 강연은 33분부터 시작

이 저장소는 주로 DOTS와 유틸리티 AI에 관한 학습 및 기록을 목적으로 합니다. 현재 상태에서 바로 사용할 수 있는 에셋을 찾고 있다면 아래 링크를 확인하세요.
https://gitlab.com/lclemens/lightweightdotsutilityai

Unity 6 Beta 지원 업데이트  
상태를 위한 GOAP 계획 추가


Copyright 2019 - 2024 Dreamers Inc Studios Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software. THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-17

---