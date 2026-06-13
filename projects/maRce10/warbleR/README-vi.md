warbleR: Đơn Giản Hóa Phân Tích Âm Sinh Học
================

🌐 **Ngôn ngữ:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md được tạo ra từ README.Rmd. Vui lòng chỉnh sửa tệp đó -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active The project has reached a stable, usable state
and is being actively
developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) nhằm mục đích hỗ trợ
phân tích cấu trúc tín hiệu âm thanh động vật trong
R. Người dùng có thể thu thập các bản ghi chim truy cập mở hoặc nhập dữ liệu của riêng mình
vào một quy trình làm việc giúp trực quan hóa phổ âm và
đo lường các tham số âm học.
[warbleR](https://cran.r-project.org/package=warbleR) sử dụng các
công cụ phân tích âm thanh cơ bản của gói seewave, và cung cấp các
công cụ mới để phân tích cấu trúc âm học. Các công cụ này có thể được sử dụng
để phân tích hàng loạt tín hiệu âm học.

Các tính năng chính của gói bao gồm:

- Nhiều công cụ để đo cấu trúc âm học
- Sử dụng vòng lặp để áp dụng các tác vụ qua các tín hiệu âm học được tham chiếu trong
  bảng lựa chọn
- Tạo hình ảnh trong thư mục làm việc với phổ âm để
  giúp người dùng tổ chức dữ liệu và xác minh các phân tích âm học

Gói cung cấp các hàm để:

- Khám phá và tải về các bản ghi [Xeno‐Canto](https://xeno-canto.org/)
- Khám phá, tổ chức và xử lý nhiều tệp âm thanh
- Phát hiện tín hiệu tự động (theo tần số và thời gian) (nhưng xem thêm gói R
  [ohun](https://docs.ropensci.org/ohun/) để có triển khai đầy đủ và thân thiện hơn)
- Tạo phổ âm của toàn bộ bản ghi hoặc các tín hiệu riêng lẻ
- Chạy các phép đo khác nhau về cấu trúc tín hiệu âm học
- Đánh giá hiệu suất các phương pháp đo
- Phân loại tín hiệu
- Đặc trưng các mức cấu trúc khác nhau trong tín hiệu âm học
- Phân tích thống kê sự phối hợp song ca
- Hợp nhất cơ sở dữ liệu và bảng chú thích

Hầu hết các hàm cho phép song song hóa các tác vụ, giúp
phân phối các tác vụ lên nhiều bộ xử lý để cải thiện hiệu suất tính toán

hiệu quả. Các công cụ để đánh giá hiệu suất của phân tích ở mỗi
bước cũng có sẵn.

## Cài đặt

Cài đặt/tải gói từ CRAN như sau:

``` r
install.packages("warbleR")

# load package
library(warbleR)
```

Để cài đặt phiên bản phát triển mới nhất từ
[github](https://github.com/) bạn sẽ cần gói R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## Sử dụng

Gói này bao gồm một số tài liệu hướng dẫn giải thích các tính năng chính của nó. [Giới thiệu về warbleR](https://marce10.github.io/warbleR/articles/warbleR.html) cung cấp cái nhìn tổng quan về các chức năng của gói. Tài liệu hướng dẫn [Định dạng dữ liệu chú thích](https://marce10.github.io/warbleR/articles/annotation_data_format.html) đưa ra mô tả chi tiết về định dạng yêu cầu cho dữ liệu chú thích đầu vào. Ngoài ra còn có ba [tài liệu hướng dẫn bổ sung](https://marce10.github.io/warbleR/articles/) với các ví dụ về cách tổ chức các hàm trong quy trình phân tích âm thanh.

Mô tả đầy đủ về gói (mặc dù hơi lỗi thời) có thể được tìm thấy trong [bài báo khoa học này](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## Các gói khác

Các gói [seewave](https://cran.r-project.org/package=seewave) và [tuneR](https://cran.r-project.org/package=seewave) cung cấp rất nhiều hàm cho phân tích và xử lý âm thanh. Chúng chủ yếu hoạt động trên các đối tượng sóng đã được nhập vào môi trường R. Gói [baRulho](https://cran.r-project.org/package=baRulho) tập trung vào việc định lượng sự suy giảm tín hiệu âm thanh do môi trường sống gây ra với đầu vào và đầu ra dữ liệu tương tự như [warbleR](https://cran.r-project.org/package=warbleR). Gói [Rraven](https://cran.r-project.org/package=Rraven) giúp trao đổi dữ liệu giữa R và [phần mềm phân tích âm thanh Raven](https://www.ravensoundsoftware.com/) ([Cornell Lab of Ornithology](https://www.birds.cornell.edu/home)) và có thể rất hữu ích để tích hợp Raven như một công cụ chú thích vào quy trình phân tích âm thanh trên R. Gói [ohun](https://docs.ropensci.org/ohun/) hoạt động trên việc phát hiện tự động các sự kiện âm thanh, cung cấp các hàm để chẩn đoán và tối ưu hóa quy trình phát hiện. [dynaSpec](https://cran.r-project.org/package=seewave) cho phép tạo ra các phổ động (ví dụ: video phổ âm).

## Trích dẫn





























Vui lòng trích dẫn [warbleR](https://cran.r-project.org/package=warbleR) như sau:

Araya-Salas, M. và Smith-Vidaurre, G. (2017), *warbleR: một gói r để
đơn giản hóa phân tích tín hiệu âm thanh động vật*. Methods Ecol Evol. 8,
184-191.

LƯU Ý: vui lòng trích dẫn cả các gói
[tuneR](https://cran.r-project.org/package=tuneR) và
[seewave](https://cran.r-project.org/package=seewave) nếu bạn
sử dụng bất kỳ chức năng tạo phổ âm hoặc đo lường âm thanh nào



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---