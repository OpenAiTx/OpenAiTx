
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Đây là cấu hình docker-compose tự lưu trữ cho [SimpleLogin](https://simplelogin.io).

## Yêu cầu tiên quyết

- một máy chủ Linux (có thể là máy ảo hoặc máy chủ vật lý). Tài liệu này hướng dẫn cài đặt trên Ubuntu 18.04 LTS nhưng các bước có thể điều chỉnh cho các bản phân phối Linux phổ biến khác. Vì hầu hết các thành phần chạy dưới dạng container Docker và Docker có thể khá nặng, nên khuyến nghị có ít nhất 2 GB RAM. Máy chủ cần mở các cổng 25 (email), 80, 443 (cho webapp), 22 (để bạn có thể ssh vào).

- một tên miền mà bạn có thể cấu hình DNS. Nó có thể là một tên miền phụ. Trong phần còn lại của tài liệu, giả sử đó là `mydomain.com` cho email và `app.mydomain.com` cho ứng dụng web SimpleLogin. Vui lòng đảm bảo thay thế các giá trị này bằng tên miền và tên miền phụ của bạn bất cứ khi nào chúng xuất hiện trong tài liệu. Một mẹo mà chúng tôi sử dụng là tải xuống tệp README này về máy tính của bạn và thay thế tất cả các trường hợp `mydomain.com` và `app.mydomain.com` bằng tên miền của bạn.

Ngoại trừ việc thiết lập DNS thường được thực hiện trên giao diện quản lý tên miền của bạn, tất cả các bước dưới đây đều được thực hiện trên máy chủ của bạn. Các lệnh được chạy với `bash` (hoặc bất kỳ shell tương thích bash nào như `zsh`) là shell. Nếu bạn sử dụng các shell khác như `fish`, vui lòng đảm bảo điều chỉnh các lệnh cho phù hợp.

- Một số gói tiện ích được sử dụng để kiểm tra cấu hình. Cài đặt chúng bằng cách:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## Cấu hình DNS

_Xem [tài liệu tham khảo](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) để biết thêm chi tiết_

> **Lưu ý** rằng các thay đổi DNS có thể mất đến 24 giờ để lan truyền. Tuy nhiên, trên thực tế, quá trình này thường nhanh hơn nhiều (~1 phút trong thử nghiệm của chúng tôi). Khi cấu hình DNS, chúng ta thường sử dụng tên miền có dấu chấm (`.`) ở cuối để bắt buộc sử dụng tên miền tuyệt đối.

Bạn sẽ cần thiết lập các bản ghi DNS sau:

- **A**: Ánh xạ tên miền của bạn đến địa chỉ IPv4 của máy chủ.
- **AAAA**: Ánh xạ tên miền của bạn đến địa chỉ IPv6 của máy chủ.
- **MX**: Định tuyến email đến máy chủ thư của bạn (bao gồm cả các ký tự đại diện `*`).
- **PTR**: Ánh xạ địa chỉ IP của máy chủ về tên miền của bạn.

Thiết lập các chính sách bảo mật bắt buộc:

- **DKIM**: Ký điện tử email gửi đi để xác thực tính xác thực.
- **DMARC**: Xác định cách các máy chủ nhận xử lý email không vượt qua xác thực.
- **SPF**: Ủy quyền cho các máy chủ thư cụ thể gửi email từ tên miền của bạn.

Các bước bổ sung:

- **CAA**: Quy định các tổ chức phát hành chứng chỉ được phép cấp chứng chỉ SSL cho tên miền của bạn.
- **MTA-STS**: Bắt buộc kết nối an toàn, mã hóa giữa các máy chủ thư.
- **TLS-RPT**: Báo cáo lỗi kết nối TLS để nâng cao bảo mật gửi nhận email.

**Cảnh báo**: thiết lập bản ghi CAA sẽ giới hạn tổ chức phát hành chứng chỉ có thể cấp chứng chỉ SSL cho tên miền của bạn.
Điều này sẽ ngăn việc phát hành chứng chỉ từ máy chủ staging của Let’s Encrypt. Bạn có thể muốn trì hoãn bản ghi DNS này cho đến khi chứng chỉ SSL được cấp thành công cho tên miền của bạn.

## Docker

Nếu bạn chưa cài đặt Docker trên máy chủ, vui lòng làm theo các bước trong [Docker CE cho Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) để cài đặt Docker.

Bạn cũng có thể cài đặt Docker bằng cách sử dụng script [docker-install](https://github.com/docker/docker-install) là

```bash
curl -fsSL https://get.docker.com | sh
```

Kích hoạt IPv6 cho [mạng cầu nối mặc định](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
Quy trình này sẽ hướng dẫn bạn cách chạy toàn bộ stack bằng cách sử dụng các container Docker.
Bao gồm:

- traefik
- Các container [SimpleLogin app](https://github.com/simple-login/app)
- postfix

Chạy SimpleLogin từ các container Docker:

1. Sao chép kho lưu trữ này vào `/opt/simplelogin`
1. Sao chép `.env.example` thành `.env` và thiết lập các giá trị thích hợp.

    - đặt biến `DOMAIN` thành tên miền của bạn.
    - đặt biến `SUBDOMAIN` thành tên miền phụ của bạn. Giá trị mặc định là `app`.
    - đặt biến `POSTGRES_USER` khớp với thông tin đăng nhập postgres (nếu bắt đầu từ đầu, sử dụng `simplelogin`).
    - đặt biến `POSTGRES_PASSWORD` khớp với thông tin đăng nhập postgres (nếu bắt đầu từ đầu, hãy đặt thành một khóa ngẫu nhiên).
    - đặt `FLASK_SECRET` thành một khóa bí mật tùy ý.

### Postgres SQL

Kho lưu trữ này chạy một postgres SQL trong một container Docker.

**Cảnh báo**: các phiên bản trước của kho lưu trữ này sử dụng phiên bản `12.1`.
Vui lòng tham khảo [tài liệu tham khảo](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) để biết thêm chi tiết và
hướng dẫn nâng cấp.

### Chạy ứng dụng

Chạy ứng dụng bằng các lệnh sau:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Bạn có thể muốn thiết lập [Ủy quyền Cơ quan Chứng chỉ (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) tại bước này.

## Các bước tiếp theo

Nếu tất cả các bước trên đều thành công, hãy mở <https://app.mydomain.com/> và tạo tài khoản đầu tiên của bạn!

Theo mặc định, các tài khoản mới không phải là tài khoản cao cấp nên không có số lượng bí danh không giới hạn. Để nâng cấp tài khoản của bạn lên cao cấp,
vui lòng vào cơ sở dữ liệu, bảng "users" và đặt cột "lifetime" thành "1" hoặc "TRUE":

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

Sau khi bạn đã tạo tất cả các tài khoản đăng nhập mong muốn, hãy thêm các dòng này vào `.env` để vô hiệu hóa việc đăng ký thêm:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
Sau đó, để khởi động lại ứng dụng web, hãy áp dụng: `docker compose restart app`

## Khác

### Cấu hình Postfix - Spamhaus

Dự án Spamhaus duy trì một danh sách đáng tin cậy các địa chỉ IP được biết là nguồn phát tán SPAM.
Bạn có thể kiểm tra xem một địa chỉ IP cụ thể có trong danh sách đó không bằng cách gửi truy vấn tới hạ tầng DNS.

Vì Spamhaus chặn các truy vấn đến từ các DNS-Resolver công khai (mở) (xem: <https://check.spamhaus.org/returnc/pub>) và container postfix của bạn có thể sử dụng
một resolver công khai theo mặc định, nên khuyến nghị đăng ký dịch vụ
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
miễn phí và lấy một khóa Spamhaus DQS.

Dán khóa này dưới dạng `SPAMHAUS_DQS_KEY` vào file `.env` của bạn

Nếu không cung cấp khóa DQS, container postfix của bạn sẽ kiểm tra xem các mirror công khai của Spamhaus có chấp nhận truy vấn của nó không và sử dụng chúng thay thế.
Nếu Spamhaus từ chối các truy vấn từ container postfix của bạn tới mirror công khai, nó sẽ bị vô hiệu hóa hoàn toàn.

### Cấu hình Postfix - Virtual aliases

Cấu hình postfix hỗ trợ virtual aliases sử dụng các file `postfix/conf.d/virtual` và `postfix/conf.d/virtual-regexp`.
Những file này được tự động tạo khi khởi động dựa trên các file mẫu tương ứng [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
và [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl).

Cấu hình mặc định như sau:

#### virtual.tpl

File `virtual` hỗ trợ cài đặt `virtual_alias_maps` của postfix.
Nó bao gồm một quy tắc ánh xạ `unknown@mydomain.com` sang `contact@mydomain.com` để minh họa việc nhận
và email từ một địa chỉ cụ thể không tương ứng với một alias hiện có, sang một địa chỉ khác có tồn tại.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

Tệp `virtual-regexp` hỗ trợ các thiết lập `virtual_alias_maps` của postfix.
Nó bao gồm một quy tắc để viết lại các email được gửi đến một tên miền con bất kỳ, mà không tương ứng với một bí danh hiện có,
thành một bí danh mới thuộc về một thư mục có tên được lấy từ tên miền con đó.
Bí danh đó có thể được tạo ngay lập tức nếu nó chưa tồn tại.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Ví dụ, các email gửi đến `someone@directory.mydomain.com` sẽ được postfix chuyển hướng đến `directory/someone@mydomain.com`.

## Cách nâng cấp từ 3.4.0

_Phần này đã được chuyển sang [tài liệu tham khảo](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## Cách nâng cấp từ thiết lập NGinx trước đó

_Phần này đã được chuyển sang [tài liệu tham khảo](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---