# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## 설치

```
yarn install
```

### 실행

```
yarn run serve
```

### 설명

```
vue 기반으로 개발된 간트 차트로, 팀 협업, 작업 분할 등 애자일 환경에서 사용할 수 있습니다.

그룹화 지원
드래그 앤 드롭 지원
늘리기(길이 조정) 지원
진행률(%) 지원
시간 범위 지원: 일, 주, 월
현재는 1단계 그룹화만 작성되어 있으며, 향후 2단계 또는 다단계 그룹화 요구에 대비하여 지난 커밋에서 일부 코드를 리팩토링하여 다단계 그룹화도 지원하지만, 현재 버전에서는 개발되지 않았습니다.

장점: 드래그, 늘리기, 진행률 수정 등 작업 시 데이터가 실시간으로 업데이트되지 않고, 작업 후에 업데이트되어 성능 소모를 줄였습니다.
      편집, 삭제, 추가 시에도 전체 인스턴스를 재귀적으로 수정하지 않고, 수정된 부분만 증감/변경 처리합니다.

컴포넌트화 준비를 위해 구조를 재정비 중이며, 현재 프로젝트에서 사용하려면 해당 프로젝트의 `gant.vue`만 불러오면 됩니다.
대량 데이터의 import/export 방법도 이미 작성되어 있어, 복사해서 바로 사용할 수 있습니다!~
```

### 업데이트 안내

- 편집 지원
- 삭제 지원
- 수직 스크롤이 불가능한 버그 수정(양방향 동시 스크롤 추가) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- elementUI로 인한 버그 수정
- 시간 범위 관련 문제 [#5](https://github.com/GGBeng1/Gantt/issues/5)
- 현재는 범위 설정 변경만으로 시간 단위(예: 시간 추가 등)와 같은 다른 범위를 구현할 수 없습니다. 초기화 시 일부 설정이 고정되어 있어 추후 api로 제공할 예정입니다.

### 예제 보기

See [demo](https://ggbeng1.github.io/Gantt/#/)

### 예시 이미지

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---