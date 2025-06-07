استخراج پیش‌بینی‌های اقتصادی ["نمودار نقطه‌ای"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) که به صورت آنلاین توسط [کمیته بازار آزاد فدرال](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee) منتشر شده‌اند

* [منبع](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [جدیدترین داده‌های استخراج‌شده](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## نحوه استفاده

مخزن را کلون کنید.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

وارد دایرکتوری شوید.

```bash
cd fed-dot-plot-scraper
```

وابستگی‌ها را نصب کنید.

```bash
pipenv install --dev
```

اسکریپر را اجرا کنید.

```bash
pipenv run python -m src.scrape
```

این کار یک فایل CSV را در شل خروجی می‌دهد. می‌توانید آن را به این صورت در یک فایل ذخیره کنید:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---