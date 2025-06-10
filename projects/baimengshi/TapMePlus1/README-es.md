# TapMePlus1 Script de Auto-Limpieza

Un potente userscript de Greasemonkey para automatizar el proceso de limpieza en el juego TapMePlus1.

## Características

- 🎮 **Juego totalmente automático**: Determina automáticamente la estrategia de clic óptima
- ⚡ **Decisión inteligente**: Evalúa los beneficios potenciales de cada clic basado en la función de valor
- 🔁 **Procesamiento de reacción en cadena**: Simula completamente el efecto de eliminación en cadena
- 🚀 **Algoritmo eficiente**: Soporta estrategia de operación continua con múltiples clics
- 🛠 **Modo de avance**: Encuentra el mejor punto de avance en una situación desfavorable
- 📊 **Monitoreo en tiempo real**: Monitorea el estado del juego en segundo plano y reinicia automáticamente el juego
- 🖥 **Panel de control**: Interfaz gráfica intuitiva para controlar la operación del script

## Instrucciones de instalación

1. Instala la extensión de navegador [violentmonkey](https://violentmonkey.github.io/)
2. Haz clic para instalar el [script TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Visita [TapMePlus1](https://tapmeplus1.com/) e inicia el juego

## Opciones de configuración

El script contiene los siguientes parámetros ajustables (modificar en el código):

```javascript
// ====== Parámetros básicos ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Función de peso dinámico ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Estrategia por fases ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## Licencia

La Licencia GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---