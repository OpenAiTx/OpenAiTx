<samp>
  
<h1>ویرایشگر ویدئویی متن‌باز</h1>
<p>این فقط یک برنامه ویرایش ویدئو معمولی نیست؛ با استفاده از React، Remotion و TypeScript ساخته شده است.</p>
<br />

> [!NOTE]  
> این برنامه در حال توسعه فعال است. این یک نسخه اولیه MVP است. لطفاً اگر قصد اجرا دارید، به [سرور دیسکورد](https://discord.gg/GSknuxubZK) بپیوندید.

<br />

<p align="center">
  <img src="https://raw.githubusercontent.com/robinroy03/videoeditor/main/public/screenshot-app.png" alt="تصویر برنامه ویرایشگر ویدئو React">
</p>
<p align="center">یک جایگزین متن‌باز برای Capcut، Canva و RVE.</p>
</samp>

## ✨ویژگی‌ها

- 🎬 ویرایش ویدئویی غیرخطی
- 🔀 پشتیبانی از چند ترک
- 👀 پیش‌نمایش زنده
- 📤 خروجی گرفتن ویدئو
- 📜 دارای مجوز MIT

## 🐋استقرار

```
git clone https://github.com/robinroy03/videoeditor.git
cd videoeditor
docker compose up
```

## 🧑‍💻توسعه

```
pnpm i
pnpm run dev (سمت فرانت‌اند)
pnpm dlx tsx app/videorender/videorender.ts (سمت بک‌اند)
uv run backend/main.py
گزینه `isProduction` را در فایل `/app/utils/api.ts` به `false` تغییر دهید

در صورت تمایل به استفاده از هوش مصنوعی، به GEMINI_API_KEY نیز نیاز خواهید داشت.
```

## 📃کارهای باقی‌مانده (TODO)

کارهای زیادی داریم! در ابتدا قصد داریم تمام APIهای Remotion را یکپارچه کنیم. به‌زودی یک نقشه راه مناسب اضافه خواهم کرد. برای دریافت به‌روزرسانی و پشتیبانی به [سرور دیسکورد](https://discord.com/invite/GSknuxubZK) بپیوندید.

## ❤️مشارکت

از مشارکت‌های شما استقبال می‌کنیم! ❤️ راهنمای [مشارکت](https://raw.githubusercontent.com/robinroy03/videoeditor/main/CONTRIBUTING.md) را بررسی کنید.

## 📜مجوز

این پروژه تحت مجوز MIT منتشر شده است. [مجوز Remotion](https://github.com/remotion-dev/remotion/blob/main/LICENSE.md) نیز برای بخش‌های مرتبط پروژه اعمال می‌شود.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---