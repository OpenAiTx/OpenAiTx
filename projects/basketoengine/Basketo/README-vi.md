<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo Basketo Game Engine" width="200"/>
</p>

<h2 align="center">Tạo ra, Chơi, Truyền cảm hứng. Những trò chơi được thổi sức sống. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Thay your_discord_server_id bằng ID máy chủ thực tế của bạn -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Chào mừng bạn đến với Basketo Engine - một dự án đam mê nơi chúng tôi đang nỗ lực hết mình để tạo ra một engine tuyệt vời và hiệu năng cao, với kế hoạch thú vị là biến nó thành một engine game AI-Native. Tích hợp giao diện trình chỉnh sửa giống Unity, kết nối Gemini AI, hệ thống hiệu ứng âm thanh đa kênh tiên tiến và kiến trúc ECS mạnh mẽ. Dù bạn ở đây để đóng góp, đề xuất ý tưởng hay chỉ đơn giản là theo dõi sự phát triển của dự án, bạn cũng là một phần của hành trình này! 🚀
</p>
## 🚀 Tình Trạng Hiện Tại của Engine
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Current State of Basketo Engine" width="700"/>
</p>

<p align="center">
  <em>Khám phá những phát triển mới nhất và các tính năng đang hoạt động!</em> 🎮
</p>

## ✨ Các Tính Năng Chính

### 🎮 **Giao Diện Trình Soạn Thảo Giống Unity**
- **Thiết lập hai cửa sổ**: Trình chỉnh sửa cảnh và chế độ xem game song song
- **Chỉnh sửa trực tiếp**: Thay đổi cảnh khi trò chơi đang chạy
- **Bảng kiểm tra**: Chỉnh sửa thành phần trực quan với thao tác kéo-thả
- **Chế độ xem phân cấp**: Tổ chức và quản lý thực thể
- **Trình duyệt tài nguyên**: Quản lý texture và âm thanh dễ dàng

### 🤖 **Phát Triển Gốc AI**
- **Tích hợp Gemini AI**: Lệnh ngôn ngữ tự nhiên cho phát triển game
- **Tạo script thông minh**: Tạo script Lua bằng AI
- **Chỉnh sửa thực thể**: Mô tả thay đổi bằng tiếng Anh đơn giản
- **Cài đặt API dễ dàng**: Cấu hình sẵn khóa API Gemini
### 🔊 **Hệ Thống Âm Thanh Nâng Cao**
- **Hiệu ứng âm thanh đa dạng**: Nhiều âm thanh được đặt tên cho mỗi thực thể (đi bộ, nhảy, tấn công, v.v.)
- **Âm thanh truyền thống**: Nhạc nền và âm thanh môi trường
- **Tích hợp Lua**: Kích hoạt âm thanh từ script với `PlaySound(entity, "action")`
- **Trình chỉnh sửa trực quan**: Quản lý hiệu ứng âm thanh qua thanh công cụ kiểm tra

### 🎯 **Entity-Component-System (ECS)**
- **Hiệu suất cao**: Tối ưu hóa cho số lượng lớn thực thể
- **Thiết kế mô-đun**: Kết hợp các thành phần linh hoạt theo nhu cầu
- **Tích hợp script**: Lập trình Lua với quyền truy cập đầy đủ vào ECS
- **Cập nhật thời gian thực**: Chỉnh sửa thành phần trực tiếp

### 🎨 **Đồ Họa & Hoạt Hình**
- **Kết xuất sprite**: Quy trình đồ họa 2D hiệu quả
- **Hệ thống hoạt hình**: Hoạt hình theo khung hình với lặp lại
- **Hệ thống biến đổi**: Vị trí, xoay và tỷ lệ
- **Hệ thống camera**: Hỗ trợ nhiều camera

### ⚡ **Vật Lý & Va Chạm**
- **Phát hiện va chạm**: Va chạm AABB với tối ưu hóa không gian
- **Vật lý rigidbody**: Trọng lực, vận tốc và lực tác động
- **Phản hồi va chạm**: Sự kiện va chạm có thể truy cập bằng script
- **Phân vùng không gian**: Tối ưu hóa hiệu suất bằng quadtree
## 🎬 Nhấn vào hình bên dưới để xem video minh họa:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## 🛠️ Hướng Dẫn Khởi Động Nhanh

### 1. **Lấy Khóa API Gemini** (Tùy chọn nhưng được khuyến nghị)
- Truy cập [Google AI Studio](https://aistudio.google.com/app/apikey)
- Đăng nhập và tạo một khóa API miễn phí
- Điều này cho phép sử dụng các tính năng dựa trên AI như lệnh ngôn ngữ tự nhiên

### 2. **Biên dịch và Chạy**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Cấu hình Tính năng AI**
- Trong engine, vào bảng AI Prompt (dưới cùng)
- Tìm "🤖 Cấu hình Gemini AI"
- Nhập khóa API của bạn và nhấn "Lưu"

### 4. **Bắt đầu Tạo nội dung**
- Thử các lệnh AI: `"create a player at 100 200"`
- Thêm hiệu ứng âm thanh cho các thực thể trong inspector
- Viết script Lua hoặc để AI tự sinh ra
- Sử dụng trình chỉnh sửa hai cửa sổ để phát triển trực tiếp

## 🛠️ Biên dịch Engine (Linux) 🐧

### Yêu cầu trước
- Cần CMake 3.26.0 hoặc cao hơn.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (cho các tính năng AI)
- nlohmann/json (đã bao gồm dưới dạng submodule)
- ImGui (đã bao gồm dưới dạng submodule)
### Các Bước Biên Dịch
```bash
# Sao chép kho lưu trữ
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Chạy
```bash
./BasketoGameEngine

```
Nếu bạn muốn chạy bài kiểm tra vật lý:
```bash
./PhysicsTest

```

## 🛠️ Xây dựng Engine (Windows) 💻

### Yêu cầu trước

1. **Visual Studio 2022 (Phiên bản Community hoặc cao hơn)**  
   Cài đặt với các workload sau:
   - Desktop development with C++
   - C++ CMake tools for Windows
   - Windows 10 hoặc 11 SDK

2. **CMake** (được tích hợp trong Visual Studio hoặc tải về từ https://cmake.org/download/)

3. **vcpkg** (dùng để cài đặt các thư viện phụ thuộc)


---
### Cài đặt các Phụ thuộc

```bash
# Mở Developer Command Prompt cho VS 2022 hoặc PowerShell

# Nhân bản vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Cài đặt các thư viện cần thiết
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Các Bước Biên dịch
```bash
# Sao chép kho lưu trữ Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Cấu hình với CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/path/to/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Thay thế "C:/path/to/vcpkg" bằng đường dẫn đầy đủ tới thư mục vcpkg của bạn

# Biên dịch engine
cmake --build . --config Release
```

---

### Chạy

```bash
# Từ thư mục build/Release
```
./BasketoGameEngine.exe

# Để chạy kiểm tra vật lý
./PhysicsTest.exe
```

## 📚 Tài liệu

### Tính năng cốt lõi
- **[Hệ thống Hiệu ứng Âm thanh](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Hướng dẫn đầy đủ về hiệu ứng âm thanh đa dạng
- **[Cài đặt Gemini API](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Hướng dẫn cấu hình AI từng bước
- **[Lập trình Lua](assets/Scripts/)**: Ví dụ script và tài liệu tham khảo API

### Ví dụ sử dụng

#### Phát triển tích hợp AI
```bash
# Lệnh ngôn ngữ tự nhiên
"tạo một nhân vật người chơi tại vị trí 100 200"
"thêm hành vi nhảy cho người chơi"
"làm cho kẻ địch di chuyển nhanh hơn"

# Tạo script
gemini_script tạo một controller platformer với nhảy đôi
```

#### Hiệu Ứng Âm Thanh Đa Dạng
```lua
-- Trong các script Lua của bạn
PlaySound(entity, "jump")    -- Phát âm thanh nhảy
PlaySound(entity, "walk")    -- Phát âm thanh đi bộ
PlaySound(entity, "attack")  -- Phát âm thanh tấn công

-- Kiểm tra nếu âm thanh tồn tại
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### Hệ Thống Thành Phần
- **Transform**: Vị trí, xoay, tỉ lệ
- **Sprite**: Kết xuất kết cấu
- **Animation**: Hoạt ảnh theo khung hình
- **Script**: Script hành vi Lua
- **Collider**: Va chạm vật lý
- **Rigidbody**: Mô phỏng vật lý
- **Audio**: Nhạc nền
- **SoundEffects**: Nhiều hiệu ứng âm thanh theo tên
- **Camera**: Quản lý góc nhìn
## 🤝 Tham Gia Đóng Góp

Chúng tôi rất hoan nghênh các đóng góp từ cộng đồng ❤️. Để biết chi tiết về cách đóng góp hoặc chạy dự án cho mục đích phát triển, hãy xem [Hướng Dẫn Đóng Góp](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Giả sử bạn đã có tệp này -->

- 🐛 Phát hiện lỗi? Hãy mở một issue!
- ✨ Có ý tưởng tính năng hay? Hãy chia sẻ với chúng tôi!
- 💻 Muốn đóng góp? Fork, viết mã, và tạo pull request!

Hãy cùng nhau xây dựng engine này và làm cho việc phát triển game trở nên vui vẻ, dễ dàng cho tất cả mọi người. 🌍

## 👥 Cộng Đồng
Chào mừng với một cái ôm lớn 🤗. Chúng tôi vô cùng phấn khích trước mọi đóng góp từ cộng đồng - dù là cải tiến mã nguồn 📝, cập nhật tài liệu 📚, báo cáo lỗi 🐞, yêu cầu tính năng 💡, hay thảo luận trên Discord của chúng tôi 🗣️.

Tham gia cộng đồng tại đây:

- 👋 [Tham gia cộng đồng Discord của chúng tôi](https://discord.gg/F3DswRMW)
- ⭐ [Gắn sao cho chúng tôi trên GitHub](https://github.com/basketoengine/Basketo)

## 🙏 Ủng hộ chúng tôi:
Chúng tôi không ngừng cải tiến và sẽ sớm ra mắt nhiều tính năng, ví dụ mới 🌟. Nếu bạn yêu thích dự án này, hãy tặng chúng tôi một ngôi sao ⭐ tại kho GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo) để luôn cập nhật và giúp chúng tôi phát triển. 🌱

---

Chúc bạn lập trình và làm game vui vẻ! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---