Trích xuất các dự báo kinh tế ["dot plot"](https://en.wikipedia.org/wiki/Fedspeak#Other_usage) được đăng trực tuyến bởi [Ủy ban Thị trường Mở Liên bang](https://en.wikipedia.org/wiki/Federal_Open_Market_Committee)

* [Nguồn](https://www.federalreserve.gov/monetarypolicy/fomccalendars.htm)
* [Dữ liệu mới nhất đã thu thập](https://github.com/palewire/fed-dot-plot-scraper/blob/main/data/dotplot.csv)

## Sử dụng

Sao chép kho lưu trữ.

```bash
gh repo clone palewire/fed-dot-plot-scraper
```

Di chuyển vào thư mục.

```bash
cd fed-dot-plot-scraper
```

Cài đặt các phụ thuộc.

```bash
pipenv install --dev
```

Chạy trình thu thập dữ liệu.

```bash
pipenv run python -m src.scrape
```

Lệnh này sẽ xuất ra một tệp CSV ra shell. Bạn có thể ghi nó vào một tệp như sau:

```bash
pipenv run python -m src.scrape > output.csv
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---