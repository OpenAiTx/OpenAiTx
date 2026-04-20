<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Một giải pháp thay thế MyFitnessPal tự lưu trữ, ưu tiên quyền riêng tư. Theo dõi dinh dưỡng, luyện tập, chỉ số cơ thể và dữ liệu sức khỏe với toàn quyền kiểm soát dữ liệu của bạn.

![Ảnh chụp màn hình](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness là nền tảng theo dõi thể hình tự lưu trữ gồm có:

- Một máy chủ backend (API + lưu trữ dữ liệu)
- Một giao diện web frontend
- Ứng dụng di động gốc cho iOS và Android

Lưu trữ và quản lý dữ liệu sức khỏe trên hạ tầng bạn kiểm soát, không phụ thuộc vào dịch vụ bên thứ ba.

## Tính Năng Cốt Lõi

- Theo dõi dinh dưỡng, tập luyện, nước uống, giấc ngủ, nhịn ăn, tâm trạng và các chỉ số cơ thể
- Thiết lập mục tiêu và kiểm tra hàng ngày
- Biểu đồ tương tác và báo cáo dài hạn
- Nhiều hồ sơ người dùng và truy cập gia đình
- Chủ đề sáng và tối
- OIDC, TOTP, Passkey, MFA, v.v.

## Tích Hợp Sức Khỏe & Thiết Bị

SparkyFitness có thể đồng bộ dữ liệu từ nhiều nền tảng sức khỏe và thể dục:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (đã kiểm thử một phần)
- **Hevy** (chưa kiểm thử)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (đã kiểm thử một phần)

Các tích hợp tự động đồng bộ dữ liệu hoạt động như số bước, bài tập, giấc ngủ, cùng các chỉ số sức khỏe như cân nặng và đo lường cơ thể lên máy chủ SparkyFitness của bạn.

## Tính Năng AI Tùy Chọn (Beta)

SparkyAI cung cấp giao diện hội thoại để ghi nhật ký dữ liệu và xem xét tiến trình.

- Ghi lại thức ăn, bài tập, chỉ số cơ thể, và số bước qua trò chuyện
- Tải ảnh món ăn để tự động ghi nhận bữa ăn
- Giữ lại lịch sử hội thoại để theo dõi

Lưu ý: Các tính năng AI hiện đang ở giai đoạn thử nghiệm beta.

## Bắt đầu nhanh (Máy chủ)

Khởi động máy chủ SparkyFitness trong vài phút bằng Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 Hướng Dẫn Video

[![Xem video](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Video hướng dẫn nhanh 2 phút chỉ cách cài đặt SparkyFitness (trình theo dõi thể hình tự lưu trữ).


## Tài Liệu Hướng Dẫn

Để có hướng dẫn cài đặt đầy đủ, tuỳ chọn cấu hình và tài liệu phát triển, vui lòng truy cập [Trang Tài Liệu](https://codewithcj.github.io/SparkyFitness/).

### Liên Kết Nhanh

- **[Hướng Dẫn Cài Đặt](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Triển khai và cấu hình
- **[Tổng Quan Tính Năng](https://codewithcj.github.io/SparkyFitness/features)** - Tài liệu tính năng đầy đủ
- **[Quy Trình Phát Triển](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Hướng dẫn lập trình viên và quy trình đóng góp
- **[Thông Tin Ứng Dụng iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** và **[Thông Tin Ứng Dụng Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Cần Hỗ Trợ?

- Đăng bài trong phần vấn đề/thảo luận trên Github.
- Để nhận phản hồi nhanh hơn và hỗ trợ từ cộng đồng **[Tham gia Discord của chúng tôi](https://discord.gg/vcnMT5cPEA)**

## Lịch Sử Gắn Sao

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Biểu Đồ Lịch Sử Gắn Sao" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Dịch Thuật

**[Dịch Thuật Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Trạng thái dịch" />
</a>

## Hoạt động kho lưu trữ

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Hình ảnh phân tích Repobeats")

## Những người đóng góp

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Vấn đề đã biết / Tính năng Beta ⚠️

SparkyFitness đang trong quá trình phát triển tích cực.
Có thể xảy ra thay đổi phá vỡ giữa các lần phát hành.

- Không khuyến nghị cập nhật container tự động
- Luôn xem lại ghi chú phát hành trước khi nâng cấp

Các tính năng sau hiện đang ở giai đoạn beta và có thể chưa được kiểm thử kỹ lưỡng. Có thể xuất hiện lỗi hoặc chức năng chưa hoàn thiện:

- Chatbot AI
- Truy cập Gia đình & Bạn bè
- Tài liệu API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---