
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=stekhoven&project=missForest&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# missForest

<!-- badges: start -->

[![CRAN status](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![CRAN RStudio mirror downloads](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** là một phương pháp nội suy phi tham số dành cho dữ liệu dạng bảng **hỗn hợp kiểu** trong R. Nó xử lý đồng thời các biến **số và phân loại** bằng cách huấn luyện rừng ngẫu nhiên lặp lại để dự đoán các giá trị thiếu từ các giá trị quan sát được. Không giả định mô hình rõ ràng, không phân tích ma trận—chỉ sử dụng các mô hình dự đoán mạnh mẽ có hiệu quả ngay khi sử dụng.

* Làm việc với **bất kỳ sự kết hợp nào của cột số và cột phân loại**
* Bắt được các **phi tuyến tính** và **tương tác**
* Báo cáo lỗi nội suy **out-of-bag (OOB)** (NRMSE/PFC)
* Hỗ trợ **thực thi song song** (theo biến hoặc theo rừng)
* Hai backend rừng: **[`ranger`](https://cran.r-project.org/package=ranger)** (mặc định) và **[`randomForest`](https://cran.r-project.org/package=randomForest)** (cũ/tương thích)

Gói này cũng bao gồm các tiện ích để đo lường lỗi nội suy, tạo giá trị thiếu cho các thí nghiệm và kiểm tra kiểu biến.

---

## Cài đặt

```r
# CRAN (recommended)
install.packages("missForest")

# Development version (from GitHub)
# install.packages("remotes")
remotes::install_github("stekhoven/missForest")
```

---

## Quick start

```r
library(missForest)

# Example data
data(iris)

# Introduce ~20% MCAR missingness
set.seed(81)
iris_mis <- prodNA(iris, noNA = 0.20)

# Impute with default backend (ranger)
imp <- missForest(iris_mis, xtrue = iris, verbose = TRUE)

# Imputed data
head(imp$ximp)

# Estimated OOB errors (NRMSE for numeric, PFC for factors)
imp$OOBerror

# True error if xtrue was provided (for benchmarking only)
imp$error
```

### Lựa chọn backend

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### Song song hóa

Hai chế độ có sẵn thông qua `parallelize`:

* `"variables"`: xây dựng rừng cho các biến khác nhau song song (đăng ký một backend foreach).
* `"forests"`: song song hóa trong một rừng của biến đơn lẻ (các luồng ranger; hoặc sub-forest foreach cho randomForest).

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## Tổng quan API

### `missForest(xmis, ...)`

Hàm nội suy chính.

Các tham số chính:

* `xmis` — data frame/matrix chứa giá trị thiếu (các cột phải là `numeric` hoặc `factor`).
* `maxiter` — số vòng lặp tối đa (mặc định `10`).
* `ntree` — số cây mỗi rừng (mặc định `100`).
* `mtry` — số biến thử nghiệm tại mỗi lần chia (mặc định `sqrt(p)`).
* `nodesize` — **mảng số độ dài-2**: kích thước nút tối thiểu cho **c(numeric, factor)**. Mặc định `c(5, 1)`.
* `variablewise` — trả về lỗi OOB theo biến nếu `TRUE`.
* `parallelize` — `"no"`, `"variables"`, hoặc `"forests"`.
* `num.threads` — số luồng cho `ranger` (bỏ qua với `randomForest`).
* `backend` — `"ranger"` (mặc định) hoặc `"randomForest"`.
* `xtrue` — dữ liệu đầy đủ tùy chọn để **benchmark** (thêm `$error`).

Một số ánh xạ tham số cho `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (riêng cho hồi quy/phân loại; mặc định `c(5,1)`)
* `sampsize` (số lượng) → `sample.fraction` (tỷ lệ; toàn bộ hoặc theo lớp)
* `classwt → class.weights`
* `cutoff` xử lý bằng cách fit **probability forests** và hậu kiểm ngưỡng

### Tiện ích

* `mixError(ximp, xmis, xtrue)` — tính **NRMSE** (numeric) và **PFC** (factor) trên các giá trị thiếu thực tế.
* `nrmse(ximp, xmis, xtrue)` — NRMSE cho dữ liệu chỉ liên tục.
* `prodNA(x, noNA = 0.1)` — tạo thiếu dữ liệu MCAR vào một data frame.
* `varClass(x)` — trả về `"numeric"`/`"factor"` theo từng cột.

---

## Mẹo & thực tiễn tốt nhất


* Chuyển đổi các cột ký tự thành factor trước khi gọi `missForest`.
* Đối với dữ liệu rộng, hãy cân nhắc sử dụng `parallelize = "variables"`. Đối với cây sâu/tốn kém, hãy cân nhắc `parallelize = "forests"`.
* Đặt seed để có kết quả gần như tái lập:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* Bạn có thể giảm `ntree` trong quá trình thử nghiệm để tăng tốc độ lặp.

---

## Trích dẫn

Nếu bạn sử dụng **missForest**, vui lòng trích dẫn:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

Bạn cũng có thể trích dẫn gói phần mềm này:

```r
citation("missForest")
```

---

## Contributing

Issues and pull requests are welcome. Please include a minimal reproducible example when reporting bugs. For performance discussions, share small benchmarks and session info.

---

## License

GPL (≥ 2)

---

## Contact

Daniel J. Stekhoven — [stekhoven@nexus.ethz.ch](https://raw.githubusercontent.com/stekhoven/missForest/master/mailto:stekhoven@nexus.ethz.ch)

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-17

---