# lsfg-vk
Dự án này mang [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) đến Linux!
>[!NOTE]
> Đây là một dự án đang phát triển. Dù frame generation đã hoạt động trên một số trò chơi, vẫn còn nhiều việc phải làm. Vui lòng xem lại wiki để được hỗ trợ (wiki hiện chưa được viết)

## Biên dịch, Cài đặt và Chạy

>[!CAUTION]
> Hướng dẫn biên dịch đã thay đổi gần đây. Vui lòng xem lại chúng.

Để biên dịch LSFG, hãy đảm bảo bạn đã cài đặt các thành phần sau trên hệ thống của mình:
- Công cụ biên dịch truyền thống (+ sed, git)
- Trình biên dịch Clang (dự án này KHÔNG dễ dàng biên dịch với GCC)
- Tệp tiêu đề Vulkan
- Hệ thống xây dựng CMake
- Hệ thống xây dựng Meson (cho DXVK)
- Hệ thống xây dựng Ninja (backend cho CMake)

Biên dịch lsfg-vk khá đơn giản, vì mọi thứ đã được tích hợp gọn gàng vào CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Lệnh này sẽ cài đặt lsfg-vk vào ~/.local/lib và ~/.local/share/vulkan.

Tiếp theo, bạn cần tải Lossless Scaling từ Steam. Chuyển sang nhánh `legacy_2.13` hoặc tải depot tương ứng.
Sao chép hoặc lưu lại đường dẫn của "Lossless.dll" từ thư mục trò chơi.

Cuối cùng, hãy khởi động một chương trình với frame generation được bật. Trong ví dụ này, tôi sẽ dùng `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Hãy chắc chắn rằng bạn đã điều chỉnh các đường dẫn. Chúng ta hãy xem xét từng biến:
- `LVK_INSTANCE_LAYERS`: Chỉ định `VK_LAYER_LS_frame_generation` tại đây. Điều này buộc bất kỳ ứng dụng Vulkan nào cũng sẽ tải layer lsfg-vk.
- `LSFG_DLL_PATH`: Tại đây bạn chỉ định tệp Lossless.dll đã tải về từ Steam. lsfg-vk sẽ giải nén và chuyển đổi các shader từ đây.
- `LSFG_MULTIPLIER`: Đây là hệ số nhân mà bạn nên quen thuộc. Chỉ định `2` để tăng gấp đôi tốc độ khung hình, v.v.
- `VK_LAYER_PATH`: Nếu bạn không cài đặt vào `~/.local` hoặc `/usr`, bạn phải chỉ định thư mục `explicit_layer.d` tại đây.

>[!WARNING]
> Không giống như trên Windows, LSFG_MULTIPLIER hiện bị giới hạn khá nhiều ở đây! Nếu phần cứng của bạn có thể tạo 8 hình ảnh swapchain, thì việc đặt LSFG_MULTIPLIER là 4 sẽ chiếm 4 hình ảnh, chỉ còn lại 4 cho trò chơi. Nếu trò chơi yêu cầu 5 hoặc nhiều hơn, nó sẽ bị crash.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---