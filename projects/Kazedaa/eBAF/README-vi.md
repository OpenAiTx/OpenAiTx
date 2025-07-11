# eBAF - Tường lửa Quảng cáo dựa trên eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Bạn sẽ không tải xuống một quảng cáo"
### Nhưng bạn sẽ chặn nó!

Spotify đã xây dựng một đế chế dựa trên một công thức đơn giản: kiếm tiền từ sự chú ý của bạn, trả công thấp cho các nghệ sĩ, và bán lại chính thời gian của bạn như một tính năng cao cấp.
Trong thế giới của họ, trải nghiệm nghe nhạc của bạn không phải là của bạn. Đó là một thị trường được sắp đặt kỹ lưỡng — đôi tai của bạn là sản phẩm, sự kiên nhẫn của bạn là đơn vị thanh toán.

Họ thích gọi đó là tầng "miễn phí".
Nhưng hãy thành thật: nó không miễn phí nếu bạn phải trả giá bằng thời gian của mình.

Trong khi đó, các nghệ sĩ mà bạn yêu thích — những người đã tạo ra giá trị cho nền tảng — thường chỉ kiếm được một phần rất nhỏ của một xu cho mỗi lượt phát. Spotify thì thu lợi nhuận lớn, các nhà quảng cáo thì có được sự chú ý, còn người sáng tạo? Họ chỉ nhận được phần thừa.

Đây không chỉ là chuyện bỏ qua một vài quảng cáo phiền toái.
Đây là việc từ chối tham gia vào một hệ thống kiếm lời từ sự bóc lột, xao nhãng, và biến sự chú ý của bạn thành hàng hóa.

#### Đây là gì?
Một hành động nhỏ thanh lịch của sự phản kháng kỹ thuật số: một trình chặn quảng cáo sạch, mã nguồn mở cho Spotify giúp loại bỏ tiếng ồn — theo nghĩa đen.

Không mod lậu, không phần mềm bẻ khóa, không phần mềm độc hại giả dạng tự do. Chỉ một mục tiêu: để âm nhạc vang lên mà không bị quảng cáo kìm hãm.

Spotify không miễn phí — bạn trả giá bằng sự kiên nhẫn của mình.

Họ dội bom bạn với những quảng cáo khó chịu lặp đi lặp lại, cho đến khi bạn bỏ cuộc và đăng ký. Không phải vì bạn yêu thích Premium. Mà bởi vì bạn đã bị bào mòn. Đó không phải là freemium — đó là chiến tranh tâm lý với một danh sách phát.

Còn các nghệ sĩ thì sao? Vẫn bị trả lương thấp.
Quảng cáo? To hơn. Dày đặc hơn. Đôi khi còn thực sự to hơn.
Bạn? Chỉ đang cố thưởng thức âm nhạc.

Họ kiếm lời từ sự kiên nhẫn của bạn và việc trả lương thấp cho người sáng tạo, trong khi lại giả vờ đó là cách duy nhất bền vững. Tiết lộ: không phải vậy. Họ có sự lựa chọn — nhưng họ đã chọn lợi nhuận thay vì con người.

Spotify muốn bạn tin rằng đây là cái giá để được tiếp cận.
Chúng tôi tin đó là một lời nói dối.

Chúng tôi không phải là cướp biển. Chúng tôi không phải tội phạm. Chúng tôi chỉ là những người nghĩ rằng việc vạch ra một ranh giới là điều đúng đắn.

Dự án này không chỉ là bỏ qua vài quảng cáo. Đó là sự từ chối một hệ thống cho rằng sự im lặng của bạn có thể bị bán, trải nghiệm của bạn có thể bị gián đoạn, và giá trị của bạn chỉ bắt đầu khi bạn mở ví.

Chặn quảng cáo không phải là ăn cắp.<br>
Ăn cắp thời gian của bạn mới là ăn cắp.<br>
Chúng tôi không ở đây để vi phạm bản quyền. Chúng tôi ở đây để từ chối tham gia.<br>
<br>
**Bạn sẽ không tải về một quảng cáo. Nhưng bạn chắc chắn sẽ chặn nó.**
## eBAF hoạt động như thế nào?

eBAF (eBPF Ad Firewall) tận dụng sức mạnh của eBPF (Extended Berkeley Packet Filter) để chặn các quảng cáo không mong muốn ngay ở cấp độ nhân hệ điều hành. Dưới đây là tổng quan ở mức cao về chức năng của nó:

## eBAF hoạt động như thế nào?

eBAF (eBPF Ad Firewall) sử dụng eBPF (Extended Berkeley Packet Filter) để chặn quảng cáo ở cấp độ nhân hệ điều hành một cách hiệu quả. Dưới đây là tổng quan đơn giản:

1. **Lọc gói tin**:
   - Kiểm tra các gói tin mạng đến và chặn những gói phù hợp với danh sách đen các địa chỉ IP bằng XDP (eXpress Data Path).

2. **Cập nhật động**:
   - Giải quyết tên miền thành địa chỉ IP và cập nhật danh sách đen một cách linh hoạt để luôn hiệu quả trước các máy chủ quảng cáo thay đổi liên tục.

3. **Bảng điều khiển web**:
   - Cung cấp thống kê trực tiếp và giám sát thông qua giao diện thân thiện với người dùng.

4. **Hiệu suất cao**:
   - Hoạt động trực tiếp ở cấp độ giao diện mạng, bỏ qua ngăn xếp mạng của nhân hệ điều hành để xử lý nhanh hơn và sử dụng tài nguyên tối thiểu.

eBAF kết hợp hiệu quả, minh bạch và dễ sử dụng để mang lại một giải pháp chặn quảng cáo mạnh mẽ.
## Cài đặt đơn giản (Khuyến nghị)
Đảm bảo đã cài đặt git và curl
```bash
git --version
curl --version
```
### Cài đặt
#### Bật tích hợp Spotify (Khuyến nghị)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Tắt rõ ràng
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Gỡ cài đặt
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Cài đặt Dev
Chạy các lệnh sau để cài đặt các phụ thuộc cần thiết:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Sửa lỗi asm/types.h khi chạy mã eBPF
Kiểm tra liên kết hiện tại
`ls -l /usr/include/asm`
Tìm liên kết đúng
`find /usr/include -name "types.h" | grep asm`
Sửa liên kết tượng trưng 
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Biên dịch Dự án

Để biên dịch eBPF Adblocker, hãy thực hiện các bước sau:

1. Sao chép kho lưu trữ:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Xây dựng dự án:
   ```bash
   make
   ```

3. (Tùy chọn) Cài đặt trên toàn hệ thống:
   ```bash
   sudo make install
   ```

4. Các tùy chọn cài đặt khác (trợ giúp)
    ```bash
    make help
    ````
5. Gỡ cài đặt
    ```bash
    make uninstall
    ````

## Sử dụng

### Chạy Trình chặn quảng cáo
    Sử dụng spotify-stable.txt làm Danh sách đen mặc định.
    Cách dùng: ebaf [TÙY CHỌN] [GIAO DIỆN...]
    TÙY CHỌN:
    -a, --all               Chạy trên tất cả các giao diện đang hoạt động
    -d, --default           Chỉ chạy trên giao diện mặc định (có kết nối internet)
    -i, --interface IFACE   Chỉ định giao diện để sử dụng
    -D, --dash              Khởi động bảng điều khiển web (http://localhost:8080)
    -q, --quiet             Ẩn đầu ra (chế độ yên lặng)
    -h, --help              Hiển thị tin nhắn trợ giúp này


### Cấu hình Danh sách đen
Chỉnh sửa các danh sách để thêm hoặc xóa các tên miền. Mỗi tên miền nên nằm trên một dòng riêng biệt. Dòng chú thích bắt đầu với `#`.

## Lời cảm ơn

Đặc biệt cảm ơn ❤️ <br>
1. [Danh sách Spotify-AdsList của Isaaker](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [spotify-adblock của AnanthVivekanand](https://github.com/AnanthVivekanand/spotify-adblock)

đã cung cấp danh sách chặn spotify
## ⭐️ Hỗ trợ Dự án

Nếu bạn thấy eBAF hữu ích, hãy cân nhắc đánh dấu sao cho kho lưu trữ trên GitHub! Sự ủng hộ của bạn giúp tăng khả năng hiển thị và khuyến khích phát triển thêm.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---