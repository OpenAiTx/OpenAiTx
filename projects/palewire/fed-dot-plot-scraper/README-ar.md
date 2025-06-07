استخراج توقعات "مخطط النقاط" ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) الاقتصادية المنشورة عبر الإنترنت من قبل [لجنة السوق المفتوحة الفيدرالية](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [المصدر](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [أحدث البيانات المستخرجة](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## الاستخدام

قم باستنساخ المستودع.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

انتقل إلى الدليل.

```bash
cd fed-dot-plot-scraper
```

قم بتثبيت الاعتماديات.

```bash
pipenv install --dev
```

شغّل أداة الاستخراج.

```bash
pipenv run python -m src.scrape
```

سيتم إخراج ملف CSV إلى الطرفية. يمكنك حفظه في ملف بهذه الطريقة:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---