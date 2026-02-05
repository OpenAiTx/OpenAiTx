## Blender용 쉐이프 키 도구
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Blender Artists 포럼 게시물 링크"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Blender Artists Forum Post" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="디스코드 참여하기"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Discord server button" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="유튜브 튜토리얼 보기"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Youtube Tutorial" /></a></span>

Blender 2.93용 쉐이프 키 전송

이 애드온을 사용하여 서로 다른 토폴로지의 메쉬 간에 쉐이프 키를 쉽게 전송할 수 있습니다.

두 메쉬를 원점에 배치하고 복사하려는 소스 메쉬의 쉐이프 키를 대상 메쉬가 복사할 위치에 겹치게 놓으세요.

이 애드온은 처음에는 ManuelBastioniLab 캐릭터에서 다른 메쉬로 쉐이프 키를 복사하기 위해 만들어졌지만, 어떤 상황에서도 사용할 수 있습니다.

이 애드온은 제가 만든 [StackoverFlow 게시물](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867)의 코드를 기반으로 합니다.

애드온은 도구 -> 쉐이프 키 도구 아래에 위치합니다.

쉐이프 키를 제외할 수도 있습니다.

증가 반경(Increment Radius)을 사용하여 대상 메쉬에 영향을 미치는 소스 메쉬의 정점 수를 늘릴 수 있습니다.

가장 가까운 정점 사용(Use Closest Vertex)이 꺼져 있으면 증가 반경 내 모든 인근 정점 위치의 평균을 냅니다.

#### 소스 메쉬의 정점 수가 적을수록 작업이 더 빠르게 진행됩니다.

##

### 기능:

- 서로 다른 토폴로지의 메쉬 간 쉐이프 키 전송

- 제외할 쉐이프 키를 추가하여 전송할 키 관리

- 메쉬의 모든 쉐이프 키 이름을 클립보드에 복사

### 사용 예시:

- 얼굴에서 콧수염 또는 눈썹 헤어 카드로 쉐이프 키 복사하기

- 기본 메시에서 LOD로 쉐이프 키 복사.

##

### 참고:
때때로 소스 메시를 복제하고 목적지 메시 영향에 필요 없을 것으로 생각되는 정점들을 제거하는 것이 좋습니다.

예를 들어 콧수염과 얼굴의 경우: 얼굴을 복제한 뒤 입 주변 정점만 남기고 나머지 정점들을 삭제합니다. 입 주변 정점들은 콧수염에 가장 영향을 줄 가능성이 높으므로, 이렇게 생성된 메시를 소스로 사용해 쉐이프 키를 목적지 콧수염 헤어 카드나 메시로 복사합니다.

필요 시 이 애드온에 더 많은 기능을 추가할 예정입니다. 이 도구로 메시 내 모든 쉐이프 키를 쉽게 삭제할 수도 있습니다.

##

### 라이선스:

Blender용 쉐이프 키 전송 애드온 - 저작권 (C) 2018 Ajit Christopher D'Monte

모든 파이썬 파일은 GNU 일반 공중 사용 허가서 3에 따라 배포됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---