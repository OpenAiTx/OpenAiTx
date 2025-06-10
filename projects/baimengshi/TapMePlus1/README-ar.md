# TapMePlus1 برنامج المسح التلقائي

سكريبت Greasemonkey قوي لأتمتة عملية مسح لعبة TapMePlus1.

## الميزات

- 🎮 **لعبة تلقائية بالكامل**: تحديد استراتيجية النقر المثلى تلقائيًا
- ⚡ **قرار ذكي**: تقييم الفوائد المحتملة لكل نقرة بناءً على دالة القيمة
- 🔁 **معالجة التفاعل التسلسلي**: محاكاة كاملة لتأثير الإزالة التسلسلية
- 🚀 **خوارزمية فعّالة**: دعم استراتيجية التشغيل المستمر بعدة نقرات
- 🛠 **وضع الاختراق**: إيجاد أفضل نقطة اختراق في المواقف غير المواتية
- 📊 **مراقبة في الوقت الحقيقي**: مراقبة حالة اللعبة في الخلفية وإعادة تشغيل اللعبة تلقائيًا
- 🖥 **لوحة تحكم**: واجهة مستخدم رسومية بديهية للتحكم في تشغيل السكريبت

## تعليمات التثبيت

1. قم بتثبيت إضافة المتصفح [violentmonkey](https://violentmonkey.github.io/)
2. انقر لتثبيت [سكريبت TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. قم بزيارة [TapMePlus1](https://tapmeplus1.com/) وابدأ اللعبة

## خيارات التكوين

يحتوي السكريبت على المعلمات التالية القابلة للتعديل (قم بتعديلها داخل الكود):

```javascript
// ====== المعلمات الأساسية ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== دالة الوزن الديناميكي ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== إستراتيجية المراحل ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: 'أساسي', strategy: 'default' };
    };
```

## الرخصة

رخصة GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---