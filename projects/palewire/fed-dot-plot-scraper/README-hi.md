["डॉट प्लॉट"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) आर्थिक अनुमानों को ऑनलाइन पोस्ट करने वाले [फेडरल ओपन मार्केट कमेटी](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee) से निकालना

* [स्रोत](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [नवीनतम स्क्रैप किया गया डेटा](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## उपयोग

रिपॉजिटरी को क्लोन करें।

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

डायरेक्टरी में जाएँ।

```bash
cd fed-dot-plot-scraper
```

डिपेंडेंसीज़ इंस्टॉल करें।

```bash
pipenv install --dev
```

स्क्रैपर चलाएँ।

```bash
pipenv run python -m src.scrape
```

यह कमांड शेल में एक CSV आउटपुट करेगा। आप इसे फाइल में इस तरह लिख सकते हैं:

```bash
pipenv run python -m src.scrape > output.csv
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---