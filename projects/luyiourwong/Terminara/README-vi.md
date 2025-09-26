
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=luyiourwong&project=Terminara&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

# Terminara

[![Hỏi DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/luyiourwong/Terminara)
![Hỗ trợ Python](https://img.shields.io/badge/Python-3.10%20%7C%203.11%20%7C%203.12%20%7C%203.13-blue)

Một trò chơi mô phỏng trí tuệ nhân tạo dựa trên giao diện dòng lệnh.

## Cách sử dụng

Bạn có thể tải xuống ứng dụng thực thi từ [phát hành mới nhất](https://github.com/luyiourwong/Terminara/releases/latest).

Tệp nén đầy đủ bao gồm tệp thực thi và tệp thiết lập thế giới mặc định. Bạn chỉ cần tải tệp thực thi nếu đang cập nhật trò chơi lên phiên bản mới nhất.

| Hệ điều hành | Phiên bản                                         |
|-------------|---------------------------------------------------|
| Windows     | Windows 10, Windows 11                            |
| Linux       | (GLIBC 2.35+) Ubuntu 22.04 LTS, Ubuntu 24.04 LTS  |
| MacOS       | macOS 13, macOS 14, macOS 15, macOS 26            |

<details>
<summary><strong>Chạy thủ công</strong></summary>

### Cài đặt

1.  **Sao chép kho lưu trữ:**
    ```bash
    git clone https://github.com/luyiourwong/Terminara
    cd Terminara
    ```

2.  **Tạo môi trường ảo:**
    ```bash
    python -m venv .venv
    source .venv/bin/activate
    ```
    Trên Windows, sử dụng `.venv\Scripts\activate`

3.  **Cài đặt các phụ thuộc:**
    ```bash
    pip install -e .
    ```

### Bắt đầu Phương pháp 1: Sử dụng lệnh đã cài đặt (Khuyến nghị)
Sau khi cài đặt, chạy trò chơi với:
```bash
terminara
```

### Bắt đầu Phương pháp 2: Thực thi trực tiếp
Cách đa nền tảng
```bash
python -m terminara.main
```
or
```bash
python terminara/main.py
```
Trên Windows, sử dụng `terminara\main.py`

để biết thêm thông tin, xem [Hướng dẫn Đóng góp & Phát triển](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md).
</details>

## Cài đặt AI

Sau khi khởi động ứng dụng, bạn cần cấu hình các thiết lập AI từ menu chính.

![Cài đặt AI](https://raw.githubusercontent.com/luyiourwong/Terminara/main/docs/assets/ai_settings.png)

Bạn cần điền vào các trường sau: (API tương thích OpenAI)
- **Host**: Điểm cuối API. Để trống để sử dụng điểm cuối OpenAI mặc định.
- **API Key**: Khóa API của bạn cho dịch vụ AI.
- **Model**: Mô hình bạn muốn sử dụng.

Nhấn "Áp dụng" để lưu các thiết lập.

### Ví dụ

#### 1. [OpenAI](https://platform.openai.com/) (Mặc định)
- **Host**: (để trống)
- **API Key**: `YOUR_OPENAI_API_KEY`
- **Model**: `gpt-4o-mini-2024-07-18`

#### 2. [Google AI Studio](http://aistudio.google.com/)
- **Host**: `https://generativelanguage.googleapis.com/v1beta/openai/`
- **API Key**: `YOUR_GEMINI_API_KEY`
- **Model**: `gemini-2.0-flash`

## Cài đặt Thế giới

### Lưu trữ Cấu hình
Các thiết lập thế giới được lưu trong thư mục `terminara/data/worlds`. (ở bản phát hành đầy đủ)
```
.
|-- terminara/
|   `-- data/
|       |-- schema/           # Json schema files for world settings
|       `-- worlds/           # Directory for world setting files
`-- terminara_platform_version        # Executable file
```

### Tạo một thế giới mới
Có một ví dụ về thế giới [aethelgard.json](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/worlds/aethelgard.json). Bạn có thể làm theo [schema](https://raw.githubusercontent.com/luyiourwong/Terminara/main/terminara/data/schema/world_schema.json) để tạo một thế giới mới.

## Liên kết

- [GitHub Pages](https://luyiourwong.github.io/Terminara)
- [Kho lưu trữ GitHub](https://github.com/luyiourwong/Terminara)
- [Hướng dẫn đóng góp & phát triển](https://raw.githubusercontent.com/luyiourwong/Terminara/main/CONTRIBUTING.md)

## Giấy phép

Dự án này được cấp phép theo [Giấy phép MIT](LICENSE).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-26

---