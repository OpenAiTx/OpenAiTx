# TapMePlus1 Auto-Clearing Script

Sebuah userscript Greasemonkey yang kuat untuk mengotomatisasi proses penyelesaian game TapMePlus1.

## Fitur

- 🎮 **Permainan sepenuhnya otomatis**: Menentukan strategi klik optimal secara otomatis
- ⚡ **Keputusan cerdas**: Mengevaluasi manfaat potensial dari setiap klik berdasarkan fungsi nilai
- 🔁 **Pemrosesan reaksi berantai**: Mensimulasikan sepenuhnya efek eliminasi berantai
- 🚀 **Algoritma efisien**: Mendukung strategi operasi klik berkelanjutan multi-kali
- 🛠 **Mode terobosan**: Menemukan titik terobosan terbaik dalam situasi yang tidak menguntungkan
- 📊 **Pemantauan real-time**: Memantau status permainan di latar belakang dan secara otomatis mengulang permainan
- 🖥 **Panel kontrol**: Antarmuka GUI yang intuitif untuk mengontrol operasi skrip

## Instruksi instalasi

1. Instal ekstensi browser [violentmonkey](https://violentmonkey.github.io/)
2. Klik untuk menginstal [skrip TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. Kunjungi [TapMePlus1](https://tapmeplus1.com/) Mulai permainan

## Opsi konfigurasi

Skrip ini berisi parameter-parameter yang dapat disesuaikan berikut ini (ubah di dalam kode):

```javascript
// ====== Parameter dasar ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== Fungsi bobot dinamis ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== Strategi fase ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'Dasar', strategy: 'default' };
    };
```

## Lisensi

Lisensi GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---