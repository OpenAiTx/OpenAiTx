# TapMePlus1 Скрипт для автоматического прохождения

Мощный userscript для Greasemonkey, автоматизирующий процесс прохождения игры TapMePlus1.

## Возможности

- 🎮 **Полностью автоматическая игра**: Автоматически определяет оптимальную стратегию клика
- ⚡ **Интеллектуальное принятие решений**: Оценивает потенциальную выгоду каждого клика на основе функции ценности
- 🔁 **Обработка цепной реакции**: Полностью симулирует эффект цепного устранения
- 🚀 **Эффективный алгоритм**: Поддерживает стратегию многократных непрерывных кликов
- 🛠 **Режим прорыва**: Находит наилучшую точку прорыва в неблагоприятной ситуации
- 📊 **Мониторинг в реальном времени**: Следит за состоянием игры в фоновом режиме и автоматически перезапускает игру
- 🖥 **Панель управления**: Интуитивно понятный графический интерфейс для управления работой скрипта

## Инструкция по установке

1. Установите расширение браузера [violentmonkey](https://violentmonkey.github.io/)
2. Кликните для установки [TapmePlus1 script](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Перейдите на сайт [TapMePlus1](https://tapmeplus1.com/) и начните игру

## Параметры конфигурации

Скрипт содержит следующие настраиваемые параметры (изменять в коде):

```javascript
// ====== Базовые параметры ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Функция динамического веса ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Стратегия по фазам ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Базовый', strategy: 'default' };
    };
```

## Лицензия

Лицензия GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---