# Mamba: Trình Quản Lý Gói Nhanh, Đa Nền Tảng

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">một phần của mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Trình Quản Lý Gói <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Máy Chủ Gói <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` là một hiện thực lại của trình quản lý gói conda bằng C++.

- tải song song dữ liệu kho và tệp gói bằng đa luồng
- sử dụng libsolv để giải quyết phụ thuộc nhanh hơn nhiều, đây là thư viện hiện đại được sử dụng trong trình quản lý gói RPM của Red Hat, Fedora và OpenSUSE
- phần lõi của `mamba` được hiện thực bằng C++ để đạt hiệu suất tối đa

Đồng thời, `mamba` sử dụng cùng trình phân tích cú pháp dòng lệnh, mã cài đặt và gỡ cài đặt gói và các quy trình xác minh giao dịch như `conda` để đảm bảo khả năng tương thích tối đa.

`mamba` là một phần của hệ sinh thái [conda-forge](https://conda-forge.org/), trong đó còn có `quetz`, một máy chủ gói `conda` mã nguồn mở.

Bạn có thể đọc [bài thông báo trên blog của chúng tôi](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` là phiên bản liên kết tĩnh của `mamba`.

Nó có thể được cài đặt như một tập tin thực thi độc lập mà không cần bất kỳ phụ thuộc nào, rất phù hợp cho các pipeline CI/CD và môi trường container hóa.

Xem [tài liệu về `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) để biết chi tiết.

## `mamba` v.s. `micromamba`

Nên ưu tiên sử dụng `mamba` khi:

- `libmambapy` hoặc `libmamba` được sử dụng bởi phần mềm khác trong cùng môi trường.
- Các trường hợp cần cập nhật thư viện thường xuyên (đặc biệt về bảo mật).
- Các môi trường chú trọng giảm dung lượng sử dụng của các phụ thuộc.

Nên ưu tiên sử dụng `micromamba` khi:

- Yêu cầu sử dụng một tập tin thực thi độc lập duy nhất.
- Không có phân phối miniforge.
- Yêu cầu thời gian chạy tối thiểu.

## Cài đặt

Vui lòng tham khảo hướng dẫn cài đặt [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
và [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) trong tài liệu.

## Các tính năng bổ sung trong Mamba và Micromamba

`mamba` và `micromamba` có các tính năng bổ sung ngoài `conda` gốc.

### `repoquery`

Để truy vấn kho và phụ thuộc gói một cách hiệu quả, bạn có thể sử dụng `mamba repoquery` hoặc `micromamba repoquery`.

Xem [tài liệu repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) để biết chi tiết.

### Cài đặt tệp lock

`micromamba` có thể được sử dụng để cài đặt các tệp lock được tạo bởi [conda-lock](https://conda.github.io/conda-lock/) mà không cần cài đặt `conda-lock`.

Chỉ cần gọi `micromamba create` với tùy chọn `-f`, cung cấp tệp lock của môi trường có tên kết thúc bằng
`-lock.yml` hoặc `-lock.yaml`; ví dụ:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (thay thế setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) là một thay thế cho [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) sử dụng `micromamba`.

Nó có thể giảm đáng kể thời gian thiết lập CI của bạn bằng cách:

- Sử dụng `micromamba`, chỉ mất khoảng 1 giây để cài đặt.
- Cache các tệp tải về của gói.
- Cache toàn bộ môi trường `conda`.

## Khác biệt với `conda`

Dù `mamba` và `micromamba` nhìn chung có thể thay thế trực tiếp cho `conda`, vẫn có một số khác biệt:

- `mamba` và `micromamba` không hỗ trợ revisions (thảo luận tại <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` và `micromamba` chuẩn hóa chuỗi `MatchSpec` về dạng đơn giản nhất, trong khi `conda` sử dụng dạng chi tiết hơn
  Điều này có thể dẫn đến sự khác biệt nhỏ trong kết quả của `conda env export` và `mamba env export`.

## Cài đặt phát triển

Vui lòng tham khảo hướng dẫn trong [tài liệu chính thức](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Ổn định API và ABI

Dự án Mamba sử dụng [semantic versioning](https://semver.org/) theo dạng `MAJOR.MINOR.PATCH`.
Trong khi chúng tôi cố gắng giữ ổn định cho người dùng, đôi khi cần phải thay đổi lớn để cải tiến
Mamba và giảm nợ kỹ thuật.
Các phiên bản tương lai của Mamba có thể cung cấp các đảm bảo mạnh mẽ hơn.

### `libmamba` (C++)

Chúng tôi chưa biết có phần mềm nào sử dụng API C++ này, nên chúng tôi cho phép mình cải tiến thêm.
Với `libmamba`, thuật ngữ _tương thích ngược_ được hiểu như sau:

- _Tương thích ngược ABI_ nghĩa là bạn có thể thay thế tập tin thư viện nhị phân mà không cần biên dịch lại
  mã của bạn với header cập nhật.
  Hành vi quan sát được sẽ giống nhau, trừ các lỗi (hy vọng là đã biến mất) và hiệu năng.
- _Tương thích ngược API_ nghĩa là bạn cần biên dịch lại mã của mình với mã thư viện mới,
  nhưng không cần thay đổi mã nguồn, chỉ cần build lại.
  Điều này áp dụng miễn là bạn không dùng bất kỳ khai báo nào được hiểu là private, ví dụ
  trong các sub-namespace `detail`.
  Hành vi quan sát được sẽ giống nhau, trừ các lỗi (hy vọng là đã biến mất) và hiệu năng.
  Khi các khai báo bị deprecated nhưng chưa bị loại bỏ và vẫn còn hoạt động, chúng tôi cũng coi là
  tương thích ngược, vì chỉ thay đổi hành vi khi biên dịch.

Với các tiêu chí trên, `libmamba` cung cấp các đảm bảo sau:

- Bản phát hành `PATCH` tương thích ngược API và ABI;
- Bản phát hành `MINOR` tương thích ngược API cho các khai báo trong `mamba/api`,
  Có thể phá vỡ API ở nơi khác và ABI ở bất kỳ đâu;
- Bản phát hành `MAJOR` không có đảm bảo nào.

### `libmambapy` (Python)

Với `libmambapy`, thuật ngữ _tương thích ngược API_ nghĩa là mã Python của bạn sẽ hoạt động
tương tự với phiên bản mới hơn của `libmambapy` miễn là bạn không sử dụng bất kỳ khai báo nào được hiểu là
private, ví dụ tên bắt đầu bằng `_`.
Hành vi quan sát được sẽ giống nhau, trừ các lỗi (hy vọng là đã biến mất) và hiệu năng.
Khi các khai báo bị deprecated nhưng chưa bị loại bỏ và vẫn còn hoạt động, chúng tôi cũng coi là
tương thích ngược, vì chỉ có thể thấy hành vi khi kích hoạt Python
`DeprecationWarning`, thường chỉ bật khi phát triển.

Với các tiêu chí trên, `libmambapy` cung cấp các đảm bảo sau:

- Bản phát hành `PATCH` tương thích ngược API;
- Bản phát hành `MINOR` tương thích ngược API;
- Bản phát hành `MAJOR` không có đảm bảo nào.

### `mamba` và `micromamba` (tập tin thực thi)

Với các tập tin thực thi, thuật ngữ _tương thích ngược_ áp dụng cho đầu vào và đầu ra có thể lập trình được, nghĩa là
mã của bạn (bao gồm các shell script) sẽ hoạt động với phiên bản mới hơn của tập tin thực thi mà không cần
sửa đổi.
Các đầu vào/đầu ra có thể lập trình gồm tên file thực thi, tham số dòng lệnh, tệp cấu hình,
biến môi trường, đầu ra dòng lệnh JSON, và các tệp được tạo ra.
Nó _không bao gồm_ đầu ra và thông báo lỗi dành cho con người đọc, do đó cảnh báo deprecated ghi
trong đầu ra cho con người đọc cũng không tính.

Với các tiêu chí trên, `mamba` và `micromamba` cung cấp các đảm bảo sau:

- Bản phát hành `PATCH` tương thích ngược;
- Bản phát hành `MINOR` tương thích ngược;
- Bản phát hành `MAJOR` không có đảm bảo nào.

## Hỗ trợ chúng tôi

Chỉ `mamba` và `micromamba` 2.0 trở lên được hỗ trợ và phát triển tích cực.

Nhánh `1.x` chỉ được duy trì để xử lý các vấn đề bảo mật như CVE.

Nếu có câu hỏi, bạn cũng có thể tham gia [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
hoặc kênh [Conda](https://gitter.im/conda/conda) (lưu ý dự án này không liên kết chính thức với `conda` hoặc Anaconda Inc.).

## Giấy phép

Chúng tôi sử dụng mô hình bản quyền chia sẻ, cho phép tất cả cộng tác viên giữ bản quyền cho phần đóng góp của mình.

Phần mềm này được cấp phép theo giấy phép BSD-3-Clause. Xem tệp [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) để biết chi tiết.

---

### Họp Phát Triển Định Kỳ Hai Tuần

Chúng tôi có các cuộc họp video hai tuần một lần để thảo luận về công việc đã làm và nhận phản hồi từ nhau.

Bất kỳ ai cũng được chào đón tham dự, dù muốn thảo luận một chủ đề hay chỉ muốn nghe.

- Khi nào: Thứ Ba [4:00 PM CET (Châu Âu)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Ở đâu: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Nội dung: [Ghi chú cuộc họp](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---