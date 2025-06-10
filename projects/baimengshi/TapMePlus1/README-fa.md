# اسکریپت پاک‌سازی خودکار TapMePlus1

یک اسکریپت قدرتمند Greasemonkey برای خودکارسازی فرآیند پاک‌سازی بازی TapMePlus1.

## قابلیت‌ها

- 🎮 **بازی کاملاً خودکار**: به طور خودکار بهترین استراتژی کلیک را تعیین می‌کند
- ⚡ **تصمیم‌گیری هوشمند**: ارزیابی مزایای بالقوه هر کلیک بر اساس تابع ارزش
- 🔁 **پردازش واکنش زنجیره‌ای**: شبیه‌سازی کامل اثر حذف زنجیره‌ای
- 🚀 **الگوریتم کارآمد**: پشتیبانی از استراتژی عملیات پیوسته چند کلیک
- 🛠 **حالت شکست بن‌بست**: یافتن بهترین نقطه شکست در شرایط نامطلوب
- 📊 **پایش لحظه‌ای**: پایش وضعیت بازی در پس‌زمینه و راه‌اندازی مجدد خودکار بازی
- 🖥 **پنل کنترل**: رابط کاربری گرافیکی شهودی برای کنترل اجرای اسکریپت

## دستورالعمل نصب

1. افزونه مرورگر [violentmonkey](https://violentmonkey.github.io/) را نصب کنید
2. برای نصب [اسکریپت TapmePlus1](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js) کلیک کنید
3. به [TapMePlus1](https://tapmeplus1.com/) بروید و بازی را شروع کنید

## گزینه‌های پیکربندی

اسکریپت شامل پارامترهای قابل تنظیم زیر است (در کد تغییر دهید):

```javascript
// ====== پارامترهای پایه ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== تابع وزن‌دهی پویا ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== استراتژی فاز ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## مجوز

مجوز GPL-3.0.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---