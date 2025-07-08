<samp>
  
<h1>محرر الفيديو مفتوح المصدر</h1>
<p>ليست مجرد تطبيق عادي لتحرير الفيديو باستخدام React، Remotion وTypeScript.</p>
<br />

> [!ملاحظة]  
> التطبيق قيد التطوير النشط. هذه نسخة MVP أولية. يرجى الانضمام إلى [خادم الديسكورد](https://discord.gg/GSknuxubZK) إذا كنت تنوي تشغيله.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="لقطة شاشة لمحرر الفيديو React">
</p>
<p align="center">بديل مفتوح المصدر لـ Capcut و Canva وRVE.</p>
</samp>

## ✨الميزات

- 🎬تحرير فيديو غير خطي
- 🔀دعم المسارات المتعددة
- 👀معاينة مباشرة
- 📤تصدير الفيديو
- 📜مرخص بموجب MIT

## 🐋النشر

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻التطوير

```
pnpm i
pnpm run dev (الواجهة الأمامية)
pnpm dlx tsx app/videorender/videorender.ts (الخلفية)
uv run backend/main.py
غيّر `isProduction` إلى `false` في `/app/utils/api.ts`

ستحتاج أيضاً إلى GEMINI_API_KEY إذا كنت ترغب في استخدام الذكاء الاصطناعي.
```

## 📃المهام القادمة

لدينا الكثير من العمل! كبداية، نخطط لدمج جميع واجهات Remotion البرمجية. سأضيف خارطة طريق مناسبة قريباً. انضم إلى [خادم الديسكورد](https://discord.com/invite/GSknuxubZK) للحصول على التحديثات والدعم.

## ❤️المساهمة

نرحب بمساهماتك! ❤️ تحقق من [دليل المساهمة](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md).

## 📜الترخيص

هذا المشروع مرخص بموجب رخصة MIT. كما تنطبق [رخصة Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) على الأجزاء ذات الصلة من المشروع.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---