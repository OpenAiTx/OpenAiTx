การแยกข้อมูลการคาดการณ์เศรษฐกิจแบบ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) ที่เผยแพร่ออนไลน์โดย [Federal Open Market Committee](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [แหล่งที่มา](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [ข้อมูลล่าสุดที่เก็บมาได้](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## วิธีใช้งาน

โคลน repository

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

เข้าสู่ไดเรกทอรี

```bash
cd fed-dot-plot-scraper
```

ติดตั้ง dependencies

```bash
pipenv install --dev
```

รันตัว scraper

```bash
pipenv run python -m src.scrape
```

คำสั่งข้างต้นจะส่งออกไฟล์ CSV ไปยัง shell คุณสามารถบันทึกเป็นไฟล์ได้ดังนี้:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---