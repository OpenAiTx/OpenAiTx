<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Một chương trình liệt kê tệp hỗ trợ nhiều bộ lưu trữ, sử dụng Gin và Solidjs.</em></p>
<div>
  <a href="https://goreportcard.com/report/github.com/alist-org/alist/v3">
    <img src="https://goreportcard.com/badge/github.com/alist-org/alist/v3" alt="latest version" />
  </a>
  <a href="https://github.com/alist-org/alist/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Xhofe/alist" alt="License" />
  </a>
  <a href="https://github.com/alist-org/alist/actions?query=workflow%3ABuild">
    <img src="https://img.shields.io/github/actions/workflow/status/Xhofe/alist/build.yml?branch=main" alt="Build status" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/release/Xhofe/alist" alt="latest version" />
  </a>
  <a title="Crowdin" target="_blank" href="https://crwd.in/alist">
    <img src="https://badges.crowdin.net/alist/localized.svg">
  </a>
</div>
<div>
  <a href="https://github.com/alist-org/alist/discussions">
    <img src="https://img.shields.io/github/discussions/Xhofe/alist?color=%23ED8936" alt="discussions" />
  </a>
  <a href="https://discord.gg/F4ymsH4xv2">
    <img src="https://img.shields.io/discord/1018870125102895134?logo=discord" alt="discussions" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/downloads/Xhofe/alist/total?color=%239F7AEA&logo=github" alt="Downloads" />
  </a>
  <a href="https://hub.docker.com/r/xhofe/alist">
    <img src="https://img.shields.io/docker/pulls/xhofe/alist?color=%2348BB78&logo=docker&label=pulls" alt="Downloads" />
  </a>
  <a href="https://alist.nn.ci/guide/sponsor.html">
    <img src="https://img.shields.io/badge/%24-sponsor-F87171.svg" alt="sponsor" />
  </a>
</div>
</div>

---

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Contributing](./CONTRIBUTING.md) | [CODE_OF_CONDUCT](./CODE_OF_CONDUCT.md)

## Tính năng

- [x] Hỗ trợ nhiều bộ lưu trữ
    - [x] Lưu trữ cục bộ
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([toàn cầu](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Cá nhân, Gia đình)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav(Hỗ trợ OneDrive/SharePoint không cần API)
    - [x] Teambition([Trung Quốc](https://www.teambition.com/ ),[Quốc tế](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Cá nhân, Gia đình, Nhóm)
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [BaiduNetdisk](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC](https://drive.uc.cn)
    - [x] [Quark](https://pan.quark.cn)
    - [x] [Thunder](https://pan.xunlei.com)
    - [x] [Lanzou](https://www.lanzou.com/)
    - [x] [ILanzou](https://www.ilanzou.com/)
    - [x] [Aliyundrive share](https://www.alipan.com/)
    - [x] [Google photo](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [Baidu photo](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [FeijiPan](https://www.feijipan.com/)
    - [x] [dogecloud](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob Storage](https://azure.microsoft.com/products/storage/blobs)
- [x] Triển khai dễ dàng và sử dụng ngay lập tức
- [x] Xem trước tệp (PDF, markdown, code, văn bản thuần, ...)
- [x] Xem trước hình ảnh ở chế độ thư viện
- [x] Xem trước video và âm thanh, hỗ trợ lời bài hát và phụ đề
- [x] Xem trước tài liệu Office (docx, pptx, xlsx, ...)
- [x] Hiển thị xem trước `README.md`
- [x] Sao chép liên kết tĩnh và tải tệp trực tiếp
- [x] Chế độ tối
- [x] I18n
- [x] Bảo vệ đường dẫn (bảo vệ bằng mật khẩu và xác thực)
- [x] WebDav (xem https://alist.nn.ci/guide/webdav.html để biết chi tiết)
- [x] [Triển khai Docker](https://hub.docker.com/r/xhofe/alist)
- [x] Proxy qua Cloudflare Workers
- [x] Tải về gói tệp/thư mục
- [x] Tải lên qua web (có thể cho phép khách tải lên), xóa, tạo thư mục, đổi tên, di chuyển và sao chép
- [x] Tải về ngoại tuyến
- [x] Sao chép tệp giữa hai bộ lưu trữ
- [x] Tăng tốc tải xuống đa luồng cho tải xuống/phát trực tuyến đơn luồng

## Tài liệu

<https://alistgo.com/>

## Demo

<https://al.nn.ci>

## Thảo luận

Vui lòng truy cập [diễn đàn thảo luận](https://github.com/alist-org/alist/discussions) của chúng tôi cho các câu hỏi chung, **issues chỉ dành cho báo cáo lỗi và yêu cầu tính năng.**

## Nhà tài trợ

AList là phần mềm mã nguồn mở, nếu bạn yêu thích dự án này và muốn mình tiếp tục phát triển, hãy cân nhắc tài trợ hoặc quyên góp một lần! Cảm ơn tất cả tình cảm và sự ủng hộ:
https://alist.nn.ci/guide/sponsor.html

### Nhà tài trợ đặc biệt

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Ứng dụng phát video đám mây tinh tế trong hệ sinh thái Apple. Hỗ trợ iPhone, iPad, Mac và Apple TV.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - Máy chủ chống DDoS|Thuê máy chủ|Fuzhou chống DDoS|Guangdong Telecom|Máy chủ Hong Kong|Máy chủ Mỹ|Máy chủ quốc tế - Nhà cung cấp dịch vụ điện toán đám mây cấp doanh nghiệp uy tín tại Trung Quốc (tài trợ máy chủ API Trung Quốc)
- [找资源](http://zhaoziyuan2.cc/) - Công cụ tìm kiếm tài nguyên Aliyun Drive

## Người đóng góp

Xin cảm ơn những người tuyệt vời này:

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Giấy phép

`AList` là phần mềm mã nguồn mở được cấp phép theo giấy phép AGPL-3.0.

## Tuyên bố miễn trừ trách nhiệm
- Chương trình này là dự án miễn phí và mã nguồn mở. Được thiết kế để chia sẻ tệp trên ổ đĩa mạng, thuận tiện cho việc tải về và học Golang. Vui lòng tuân thủ pháp luật hiện hành khi sử dụng và không lạm dụng;
- Chương trình này triển khai bằng cách gọi sdk/giao diện chính thức, không phá hoại hành vi giao diện chính thức;
- Chương trình này chỉ thực hiện chuyển hướng 302/chuyển tiếp lưu lượng, không chặn, lưu trữ hoặc chỉnh sửa bất kỳ dữ liệu người dùng nào;
- Trước khi sử dụng chương trình này, bạn nên hiểu và tự chịu các rủi ro liên quan, bao gồm nhưng không giới hạn ở việc bị khóa tài khoản, giới hạn tốc độ tải, ... chương trình không chịu trách nhiệm;
- Nếu có vi phạm, vui lòng liên hệ [email](mailto:i@nn.ci), sẽ được xử lý kịp thời.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---