# TapMePlus1 자동 클리어 스크립트

TapMePlus1 게임의 클리어 과정을 자동화하는 강력한 Greasemonkey 사용자 스크립트입니다.

## 주요 기능

- 🎮 **완전 자동 게임**: 최적의 클릭 전략을 자동으로 판단
- ⚡ **지능적 의사결정**: 가치 함수에 따라 각 클릭의 잠재적 이득 평가
- 🔁 **체인 반응 처리**: 체인 제거 효과를 완벽히 시뮬레이션
- 🚀 **효율적인 알고리즘**: 다중 클릭 연속 작동 전략 지원
- 🛠 **돌파 모드**: 불리한 상황에서 최적의 돌파구 지점 탐색
- 📊 **실시간 모니터링**: 백그라운드에서 게임 상태 모니터링 및 자동 재시작
- 🖥 **컨트롤 패널**: 스크립트 작동을 직관적으로 제어하는 GUI 인터페이스

## 설치 안내

1. [violentmonkey](https://violentmonkey.github.io/) 브라우저 확장 프로그램 설치
2. [TapmePlus1 스크립트](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) 클릭하여 설치
3. [TapMePlus1](https://tapmeplus1.com/) 방문 후 게임 시작

## 설정 옵션

스크립트는 다음과 같은 조정 가능한 파라미터를 포함합니다(코드 내에서 수정):

```javascript
// ====== 기본 파라미터 ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== 동적 가중치 함수 ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== 단계별 전략 ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '기본', strategy: 'default' };
    };
```

## 라이선스

GPL-3.0 라이선스.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---