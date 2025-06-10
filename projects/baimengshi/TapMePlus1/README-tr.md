# TapMePlus1 Otomatik Temizleme Scripti

TapMePlus1 oyununu otomatik olarak temizleme sürecini otomatikleştiren güçlü bir Greasemonkey kullanıcı betiği.

## Özellikler

- 🎮 **Tam otomatik oyun**: En uygun tıklama stratejisini otomatik olarak belirler
- ⚡ **Akıllı karar verme**: Her tıklamanın potansiyel faydasını değer fonksiyonuna göre değerlendirir
- 🔁 **Zincirleme reaksiyon işleme**: Zincirleme eleme etkisini tamamen simüle eder
- 🚀 **Verimli algoritma**: Çoklu tıklama ve sürekli işlem stratejisini destekler
- 🛠 **Atılım modu**: Elverişsiz bir durumda en iyi atılım noktasını bulur
- 📊 **Gerçek zamanlı izleme**: Oyun durumunu arka planda izler ve oyunu otomatik olarak yeniden başlatır
- 🖥 **Kontrol paneli**: Betik çalışmasını kontrol etmek için sezgisel GUI arayüzü

## Kurulum talimatları

1. [violentmonkey](https://violentmonkey.github.io/) tarayıcı uzantısını kurun
2. [TapmePlus1 scriptini](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) tıklayarak kurun
3. [TapMePlus1](https://tapmeplus1.com/) adresini ziyaret edin ve oyuna başlayın

## Yapılandırma seçenekleri

Betik aşağıdaki ayarlanabilir parametreleri içerir (kodda değiştirin):

```javascript
// ====== Temel parametreler ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Dinamik ağırlık fonksiyonu ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Faz stratejisi ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Temel', strategy: 'default' };
    };
```

## Lisans

GPL-3.0 Lisansı.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---