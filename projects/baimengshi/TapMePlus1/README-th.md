# TapMePlus1 สคริปต์ล้างกระดานอัตโนมัติ

สคริปต์ผู้ใช้ Greasemonkey อันทรงพลังสำหรับการทำกระบวนการล้างเกม TapMePlus1 แบบอัตโนมัติ

## คุณสมบัติ

- 🎮 **เล่นเกมอัตโนมัติเต็มรูปแบบ**: กำหนดกลยุทธ์การคลิกที่เหมาะสมโดยอัตโนมัติ
- ⚡ **ตัดสินใจอย่างชาญฉลาด**: ประเมินประโยชน์ที่เป็นไปได้ของแต่ละการคลิกตามฟังก์ชันมูลค่า
- 🔁 **ประมวลผลปฏิกิริยาลูกโซ่**: จำลองเอฟเฟกต์การกำจัดแบบลูกโซ่ได้อย่างสมบูรณ์
- 🚀 **อัลกอริธึมประสิทธิภาพสูง**: รองรับกลยุทธ์การดำเนินการแบบต่อเนื่องหลายคลิก
- 🛠 **โหมดฝ่าวงล้อม**: ค้นหาจุดฝ่าวงล้อมที่ดีที่สุดในสถานการณ์ที่ไม่เอื้ออำนวย
- 📊 **การตรวจสอบแบบเรียลไทม์**: ตรวจสอบสถานะเกมในพื้นหลังและรีสตาร์ทเกมอัตโนมัติ
- 🖥 **แผงควบคุม**: อินเทอร์เฟซ GUI ที่ใช้งานง่ายสำหรับควบคุมการทำงานของสคริปต์

## คำแนะนำในการติดตั้ง

1. ติดตั้ง [violentmonkey](https://violentmonkey.github.io/) ส่วนขยายเบราว์เซอร์
2. คลิกเพื่อติดตั้ง [TapmePlus1 script](https://github.com/baimengshi/tapmeplus1/raw/main/TapMePlus1_auto-clear.user.js)
3. เยี่ยมชม [TapMePlus1](https://tapmeplus1.com/) เพื่อเริ่มเกม

## ตัวเลือกการกำหนดค่า

สคริปต์นี้มีพารามิเตอร์ที่ปรับเปลี่ยนได้ดังต่อไปนี้ (แก้ไขในโค้ด):

```javascript
// ====== พารามิเตอร์พื้นฐาน ======
    const BOARD_SIZE = 5;
    const MAX_CLICKS = 5;
    const BEAM_WIDTH = 8;
    const SEARCH_DEPTH = 4;
    const MIN_CLICK_DELAY = 60;
    const BASE_CLICK_DELAY = 100;
    const MAX_CACHE_SIZE = 500;
    const evaluationCache = new Map();

// ====== ฟังก์ชันน้ำหนักแบบไดนามิก ======
    const getScoreWeight = score => {
        if (score < 800) return { score: 100, layout: 1 };
        if (score < 1500) return { score: 85, layout: 0.8 };
        if (score < 2000) return { score: 70, layout: 0.6 };
        return { score: 60, layout: 0.4 };
    };

// ====== กลยุทธ์ตามช่วงคะแนน ======
    const getCurrentPhase = score => {
        if (score >= 4000) return { maxClicks: 1, riskFactor: 0.2, label: '4000+', strategy: 'focusLargeGroups' };
        if (score >= 3000) return { maxClicks: 2, riskFactor: 0.3, label: '3000+', strategy: 'balanceEdgeAndCenter' };
        if (score >= 2000) return { maxClicks: 2, riskFactor: 0.4, label: '2000+', strategy: 'maximizeChainPotential' };
        if (score >= 1000) return { maxClicks: 2, riskFactor: 0.7, label: '1000+', strategy: 'conservativeGrowth' };
        return { maxClicks: 2, riskFactor: 1.0, label: '基础', strategy: 'default' };
    };
```

## ใบอนุญาต

สัญญาอนุญาต GPL-3.0

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---