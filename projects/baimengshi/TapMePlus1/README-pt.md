# TapMePlus1 Script de Auto-Limpeza

Um poderoso userscript Greasemonkey para automatizar o processo de limpeza do jogo TapMePlus1.

## Funcionalidades

- 🎮 **Jogo totalmente automático**: Determina automaticamente a estratégia de clique ideal
- ⚡ **Decisão inteligente**: Avalia os benefícios potenciais de cada clique com base na função de valor
- 🔁 **Processamento de reação em cadeia**: Simula completamente o efeito de eliminação em cadeia
- 🚀 **Algoritmo eficiente**: Suporta estratégia de operação contínua com múltiplos cliques
- 🛠 **Modo de avanço**: Encontra o melhor ponto de avanço em situações desfavoráveis
- 📊 **Monitoramento em tempo real**: Monitora o status do jogo em segundo plano e reinicia automaticamente o jogo
- 🖥 **Painel de controle**: Interface gráfica intuitiva para controlar a operação do script

## Instruções de instalação

1. Instale a extensão de navegador [violentmonkey](https://violentmonkey.github.io/)
2. Clique para instalar o [script TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Acesse [TapMePlus1](https://tapmeplus1.com/) e inicie o jogo

## Opções de configuração

O script contém os seguintes parâmetros ajustáveis (modifique no código):

```javascript
// ====== Parâmetros básicos ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Função de peso dinâmica ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Estratégia de fases ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Básico', strategy: 'default' };
    };
```

## Licença

Licença GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---