
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

[![สถานะ CRAN](https://www.r-pkg.org/badges/version/missForest)](https://CRAN.R-project.org/package=missForest)
[![จำนวนดาวน์โหลดจากกระจก RStudio CRAN เดือนล่าสุด](https://cranlogs.r-pkg.org/badges/last-month/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![จำนวนดาวน์โหลดจากกระจก RStudio CRAN รวมทั้งหมด](https://cranlogs.r-pkg.org/badges/grand-total/missForest?color=blue)](https://r-pkg.org/pkg/missForest)
[![R-CMD-check](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/R-CMD-check.yaml)
[![test-coverage](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml/badge.svg)](https://github.com/stekhoven/missForest/actions/workflows/test-coverage.yaml)
[![License: GPL (≥ 2)](https://img.shields.io/badge/license-GPL%20(%E2%89%A5%202)-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

<!-- badges: end -->

**missForest** เป็นวิธีการแทนค่าข้อมูลที่ขาดหายแบบไม่พึ่งสมมติฐานสำหรับข้อมูลตารางแบบ **ผสมประเภท** ใน R โดยรองรับตัวแปรทั้ง **เชิงตัวเลขและเชิงหมวดหมู่** พร้อมกันด้วยการฝึก random forest แบบวนซ้ำเพื่อทำนายค่าที่ขาดหายจากค่าที่สังเกตได้ ไม่ต้องตั้งสมมติฐานแบบชัดเจน ไม่ต้องทำ matrix factorization—แค่ใช้ baseline ทำนายที่แข็งแกร่งซึ่งใช้งานได้ดีทันที

* ใช้งานได้กับ **คอลัมน์ตัวเลขและแฟคเตอร์ทุกประเภท**
* จับ **ความไม่เชิงเส้น** และ **ปฏิสัมพันธ์**
* รายงาน **ข้อผิดพลาดการแทนค่าข้อมูล OOB** (NRMSE/PFC)
* รองรับ **การประมวลผลแบบขนาน** (ต่อคอลัมน์หรือต่อป่า)
* มี backend ป่าสองตัว: **[`ranger`](https://cran.r-project.org/package=ranger)** (ค่าเริ่มต้น) และ **[`randomForest`](https://cran.r-project.org/package=randomForest)** (รุ่นเก่า/สำหรับความเข้ากันได้)

แพคเกจนี้ยังมีเครื่องมือสำหรับวัดข้อผิดพลาดการแทนค่าข้อมูล สร้างข้อมูลขาดหายสำหรับการทดลอง และตรวจสอบประเภทตัวแปร

---

## การติดตั้ง

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

### การเลือกแบ็คเอนด์

```r
# Legacy behavior using randomForest
imp_rf <- missForest(iris_mis, backend = "randomForest")

# Explicitly use ranger with limited threads
imp_rg <- missForest(iris_mis, backend = "ranger", num.threads = 2)
```

### การประมวลผลแบบขนาน

มีโหมดให้เลือกใช้สองแบบผ่าน `parallelize`:

* `"variables"`: สร้างฟอเรสต์สำหรับตัวแปรแต่ละตัวแบบขนาน (ต้องลงทะเบียน backend ของ foreach)
* `"forests"`: ประมวลผลแบบขนานภายในฟอเรสต์ของตัวแปรเดียว (ใช้เธรดของ ranger หรือใช้ foreach สำหรับ sub-forests ของ randomForest)

```r
# Not run:
# library(doParallel)
# registerDoParallel(2)
# imp_vars <- missForest(iris_mis, parallelize = "variables", verbose = TRUE)
# imp_fors <- missForest(iris_mis, parallelize = "forests",  verbose = TRUE, num.threads = 2)
```
---

## ภาพรวมของ API

### `missForest(xmis, ...)`

ฟังก์ชันหลักสำหรับการเติมค่าที่ขาดหายไป

อาร์กิวเมนต์สำคัญ:

* `xmis` — data frame/matrix ที่มีค่าขาดหาย (คอลัมน์ต้องเป็น `numeric` หรือ `factor`)
* `maxiter` — จำนวนรอบสูงสุด (ค่าเริ่มต้น `10`)
* `ntree` — จำนวนต้นไม้ต่อป่า (ค่าเริ่มต้น `100`)
* `mtry` — ตัวแปรที่สุ่มเลือกในแต่ละการแบ่ง (ค่าเริ่มต้น `sqrt(p)`)
* `nodesize` — **เวกเตอร์ตัวเลขขนาด 2**: ขนาดโหนดขั้นต่ำสำหรับ **c(numeric, factor)** ค่าเริ่มต้น `c(5, 1)`
* `variablewise` — คืนค่า OOB error รายตัวแปรหาก `TRUE`
* `parallelize` — `"no"`, `"variables"` หรือ `"forests"`
* `num.threads` — จำนวนเธรดสำหรับ `ranger` (ถูกละเว้นโดย `randomForest`)
* `backend` — `"ranger"` (ค่าเริ่มต้น) หรือ `"randomForest"`
* `xtrue` — ข้อมูลสมบูรณ์สำหรับ **การวัดประสิทธิภาพ** (เพิ่ม `$error`)

การแมปอาร์กิวเมนต์บางส่วนสำหรับ `backend = "ranger"`:

* `ntree → num.trees`
* `nodesize → min.bucket` (แยกสำหรับ regression/classification; ค่าเริ่มต้น `c(5,1)`)
* `sampsize` (จำนวน) → `sample.fraction` (สัดส่วน; ทั้งหมดหรือแยกตามคลาส)
* `classwt → class.weights`
* `cutoff` ถูกจัดการด้วยการสร้าง **probability forests** และการกำหนด threshold ภายหลัง

### ยูทิลิตี้

* `mixError(ximp, xmis, xtrue)` — คำนวณ **NRMSE** (ตัวเลข) และ **PFC** (factor) เฉพาะค่าที่ขาดจริง
* `nrmse(ximp, xmis, xtrue)` — NRMSE สำหรับข้อมูลเชิงต่อเนื่องเท่านั้น
* `prodNA(x, noNA = 0.1)` — สร้างค่าขาดหายแบบ MCAR ลงใน data frame
* `varClass(x)` — คืนค่า `"numeric"`/`"factor"` รายคอลัมน์

---

## เคล็ดลับ & แนวปฏิบัติที่ดีที่สุด


* แปลงคอลัมน์ตัวอักษรเป็นแฟคเตอร์ก่อนเรียกใช้ `missForest`
* สำหรับข้อมูลที่กว้าง ให้พิจารณาใช้ `parallelize = "variables"` สำหรับต้นไม้ที่ลึก/ใช้ทรัพยากรสูง ให้พิจารณาใช้ `parallelize = "forests"`
* ตั้งค่า seed เพื่อผลลัพธ์ที่สามารถทำซ้ำได้ในระดับหนึ่ง:

  ```r
  set.seed(123); imp <- missForest(x)
  ```
* คุณสามารถลดค่า `ntree` ในระหว่างการสร้างต้นแบบเพื่อเร่งความเร็วในการทำซ้ำ

---

## การอ้างอิง

หากคุณใช้ **missForest** กรุณาอ้างอิงดังนี้:

* Stekhoven, D. J. & Bühlmann, P. (2012). *MissForest—nonparametric missing value imputation for mixed-type data.* **Bioinformatics**, 28(1), 112–118. [https://doi.org/10.1093/bioinformatics/btr597](https://doi.org/10.1093/bioinformatics/btr597)

คุณยังสามารถอ้างอิงแพ็คเกจนี้ได้เช่นกัน:

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