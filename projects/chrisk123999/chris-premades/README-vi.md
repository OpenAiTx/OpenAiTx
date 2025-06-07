# Readme

Một bộ sưu tập các mục tự động hóa bao gồm phép thuật, tính năng lớp nhân vật, tính năng quái vật, v.v..., các cơ chế để thực hiện điều đó, và các tiện ích mở rộng hỗ trợ nâng cao trải nghiệm cho môi trường D&D5e dựa trên Midi-QOL với mức tự động hóa cao. Các bộ tổng hợp (compendium) trong module này không bao gồm mô tả của mục. Mặc dù module này có một số phụ thuộc module từ các tác giả khác nhau, vui lòng không làm phiền tposney, Wasp, hoặc bất kỳ tác giả module nào khác với các lỗi hoặc sự cố liên quan đến module này. Báo cáo lỗi và yêu cầu triển khai module lớn có thể được thực hiện trên GitHub. Hỗ trợ nhanh hơn và yêu cầu tính năng có thể truy cập tại [Discord server](https://discord.gg/BumxBcQDrT).

![CauldronofPlentifulResourcesMedium](https://github.com/user-attachments/assets/58c729ba-c499-45a3-a62c-c6982ad1f725) 
  
### Tác giả:
[Chris](https://github.com/chrisk123999) <br> 
[Autumn](https://github.com/Autumn225) <br>
[Michael](https://github.com/roth-michael) <br>
[SagaTympana](https://github.com/SagaTympana)

### Hỗ trợ:
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/chris-kofi.svg" width=237px />](https://ko-fi.com/O5O5G582S) <br>
[<img src="https://raw.githubusercontent.com/chrisk123999/chris-premades/master/images/michael-kofi.svg" width=253px />](https://ko-fi.com/T6T8XKCII)
  
# Các Module Bắt Buộc  
| Module | Phiên Bản Tối Thiểu |  
| --- | --- | 
| D&D 5e System | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.systems%5B%3A1%5D.compatibility.minimum&label=%20&color=orange) | 
| Midi-Qol | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B0%5D.compatibility.minimum&label=%20&color=green) |  
| Dynamic Active Effects | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B3%5D.compatibility.minimum&label=%20&color=green) |
| Jules & Ben's Animated Assets | ![Static Badge](https://img.shields.io/badge/0.6.0-blue) |  
| Sequencer | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B1%5D.compatibility.minimum&label=%20&color=green) |  
| Socket Lib | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B2%5D.compatibility.minimum&label=%20&color=green) |  
| Time's Up | ![Dynamic JSON Badge](https://img.shields.io/badge/dynamic/json?url=https%3A%2F%2Fgithub.com%2Fchrisk123999%2Fchris-premades%2Freleases%2Flatest%2Fdownload%2Fmodule.json&query=%24.relationships.requires%5B4%5D.compatibility.minimum&label=%20&color=green) |
  
# Các Module Hỗ Trợ Tùy Chọn:  
- Gambit's Premades
- Midi Item Showcase Community
- Universal Animations
- [Animated Spell Effects: Cartoon](https://github.com/chrisk123999/animated-spell-effects-cartoon/releases/download/0.4.6/module.json)
- Visual Active Effects
- D&D Beyond Importer
- Tidy5e Sheet
- Token Magic FX
  
# Tính Năng Chính:
- Bộ tổng hợp các phép thuật, vật phẩm, tính năng lớp nhân vật, và nhiều hơn nữa đã được tự động hóa.
- Nút trên thanh tiêu đề cung cấp giao diện để áp dụng và cấu hình các tự động hóa đi kèm.
- Hiệu ứng hoạt hình đẹp mắt được tạo bởi ***Eskiemoh*** cho một số tự động hóa, sử dụng *Patreon JB2A* và *Animated Spell Effects: Cartoon*.
- Bộ giải quyết lăn xúc xắc tùy chỉnh cho các lượt lăn thủ công, được thiết kế cho các trò chơi trực tiếp.
- API tùy chỉnh mở rộng từ quy trình làm việc của Midi-QOL, cho phép xác định chính xác thời gian sự kiện và tự động hóa các hiệu ứng phép chồng lấn.
- API công khai để chạy macro tùy chỉnh.
- Nhiều tiện ích mở rộng giao diện người dùng tùy chọn nhằm tăng trải nghiệm người dùng.
- Thay đổi hiệu ứng bao gồm mô tả tự động, thay đổi biểu tượng hiệu ứng trạng thái, và áp dụng các cờ Midi-QOL liên quan đến hiệu ứng trạng thái.
- Giao diện hiệu ứng tùy chỉnh để lưu trữ và áp dụng các hiệu ứng tùy chỉnh.
- Cơ chế tùy chọn và Homebrew bao gồm DMG Cleave, Exploding Heals, và BG3 Weapon Actions.
- Tự động sao lưu nhân vật.

# Liên Kết Cộng Đồng:
[Cauldron of Plentiful Resources Discord](https://discord.gg/BumxBcQDrT)<br>
[Foundry VTT Discord](https://discord.gg/foundryvtt)<br>
[Posney's Foundry Automation Discord](https://discord.gg/Xd4NEvw5d7)<br>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---