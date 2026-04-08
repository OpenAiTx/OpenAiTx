<div align="center">

<img src="https://media.giphy.com/media/Pt2yOXUALOhpB5dpiM/giphy.gif" alt="Meteor Devtool Evolved Gif" />

<p style="font-size: 30px">
Meteor Devtools 확장 프로그램
</p>
Meteor DevTools의 진화를 보십시오.</p>

Meteor Devtools Evolved는 현재 Google Chrome과 Mozilla Firefox에서 사용할 수 있습니다.

</div>

<p align="center" >
    <a href="https://chrome.google.com/webstore/detail/meteor-devtools-evolved/ibniinmoafhgbifjojidlagmggecmpgf">
    <img width="120" src="https://img.shields.io/badge/%20-Chrome-orange?logo=google-chrome&logoColor=white" alt="Chrome용 다운로드" />
    </a>
    <a href="https://addons.mozilla.org/en-US/firefox/addon/meteor-devtools-evolved/">
    <img width="110" src="https://img.shields.io/badge/%20-Firefox-red?logo=mozilla&logoColor=white" alt="Firefox용 다운로드" />
    </a>
</p>

[Harder, Better, Faster, Stronger](https://www.youtube.com/watch?v=gAjR4_CbPpQ) :rocket:

Meteor를 처음 시작하십니까? "무슨 일이 일어나고 있는지" 파악하거나 Meteor 앱을 최적화하고 싶으신가요? 이 도구가 바로 당신을 위한 것입니다.

:point_right: [변경 로그](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CHANGELOG.md)

### 분산 데이터 프로토콜 (DDP)

Meteor 애플리케이션 내부에서 무슨 일이 일어나고 있는지 추적하고 이해하는 데 필요한 모든 것을 제공합니다. 이 확장 프로그램은 수천, 수만 개의 DDP 메시지를 문제 없이 필터링하고 검색할 수 있게 해줍니다.

### 북마크

DDP 검사는 일시적이지만 원하는 만큼 많은 DDP 메시지를 나중에 검색하고 조회할 수 있도록 저장할 수 있습니다, 어느 호스트에서든 가능합니다. 단, IndexedDB에 저장된다는 점에 주의하세요.

### 미니몽고

어떤 데이터가 어디에 속하는지 모르시겠나요? 미니몽고 데이터에서 어떤 것이든 빠르게 검색할 수 있으며, 우리의 초고속 맞춤형 Object Treerinator로 문서들을 쉽게 시각화할 수 있습니다.

---

## 개발

> 면책 조항: 이 작업은 부분적으로 The Bakery의 [Meteor DevTools](https://github.com/bakery/meteor-devtools) 확장 기능을 기반으로 합니다. 안타깝게도 더 이상 유지 관리되지 않고 있습니다. 반드시 포크는 아니지만, 유용한 지식과 아키텍처 결정 일부를 사용했으며, 몇 가지는 자연스럽게 가장 실용적인 해결책으로 수렴되었습니다. 그래서 "진화된" 것입니다.

이 확장 기능은 거의 전부 TypeScript로 작성되었으며, 실용적인 이유로 일부 Chrome 특정 코드는 제외되어 있습니다. 상태 관리를 위해 MobX를 사용하고 스타일은 SASS를 사용합니다. 또한 Palantir의 [Blueprint](https://github.com/palantir/blueprint) 라이브러리 컴포넌트를 사용합니다. 모든 것은 Webpack으로 연결되어 있습니다.

> 누구나 기여할 수 있으며, 자세한 정보는 [여기](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CONTRIBUTING.md)를 참조하세요.

## 파이어폭스

이 확장 기능의 파이어폭스 포트는 [@nilooy](https://github.com/nilooy)의 기여로 만들어졌습니다. 감사합니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---