
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Hãy thử mô hình sinh [tại đây](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), hoặc MaiMod [tại đây](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Xem video trình diễn [tại đây](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator là một framework đa mô hình sử dụng đầu vào spectrogram để tạo ra beatmap osu! hoàn chỉnh cho tất cả chế độ chơi và [hỗ trợ modding beatmap](#maimod-the-ai-driven-modding-tool).
Mục tiêu của dự án này là tự động tạo ra các beatmap osu! đạt chất lượng xếp hạng từ bất kỳ bài hát nào với mức độ tùy biến cao.

Dự án này được xây dựng dựa trên [osuT5](https://github.com/gyataro/osuT5) và [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Khi phát triển dự án này, tôi đã sử dụng khoảng 2500 giờ tính toán GPU trên 142 lượt chạy bằng 4060 Ti của tôi và thuê các máy 4090 trên vast.ai.

#### Sử dụng công cụ này một cách có trách nhiệm. Luôn thông báo việc sử dụng AI trong các beatmap của bạn.

## Cài đặt

Hướng dẫn dưới đây cho phép bạn tạo beatmap trên máy tính cá nhân, ngoài ra bạn cũng có thể chạy nó trên đám mây với [colab notebook](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Sao chép kho lưu trữ

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Tùy chọn) Tạo môi trường ảo

Sử dụng Python 3.10, các phiên bản sau có thể không tương thích với các thư viện phụ thuộc.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Cài đặt các phụ thuộc

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Dành cho GPU NVIDIA) hoặc [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Dành cho GPU AMD trên linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Đảm bảo làm theo hướng dẫn Bắt đầu để cài đặt `torch` và `torchaudio` với hỗ trợ GPU. Hãy chọn đúng phiên bản Compute Platform mà bạn đã cài đặt ở bước trước.

- và các phụ thuộc Python còn lại:

```sh
pip install -r requirements.txt
```

## Giao diện Web (Khuyến nghị)

Để có trải nghiệm thân thiện với người dùng hơn, hãy cân nhắc sử dụng Giao diện Web. Nó cung cấp giao diện đồ họa để cấu hình các tham số sinh, khởi động quá trình và giám sát kết quả.

### Khởi động GUI

Di chuyển đến thư mục `Mapperatorinator` đã được nhân bản trong terminal của bạn và chạy:

```sh
python web-ui.py
```
Điều này sẽ khởi động một máy chủ web cục bộ và tự động mở giao diện người dùng trong một cửa sổ mới.

### Sử dụng Giao Diện Đồ Họa (GUI)

- **Cấu hình:** Đặt đường dẫn đầu vào/đầu ra bằng các trường biểu mẫu và nút "Duyệt". Điều chỉnh các tham số tạo như chế độ chơi, độ khó, phong cách (năm, ID mapper, mô tả), thời gian, các tính năng cụ thể (hitsounds, super timing), và nhiều hơn nữa, phản ánh các tùy chọn dòng lệnh. (Lưu ý: Nếu bạn cung cấp một `beatmap_path`, giao diện sẽ tự động xác định `audio_path` và `output_path` từ đó, vì vậy bạn có thể để trống các trường này)
- **Bắt đầu:** Nhấn nút "Bắt đầu suy luận" để khởi động quá trình tạo beatmap.
- **Hủy:** Bạn có thể dừng quá trình đang chạy bằng nút "Hủy suy luận".
- **Mở đầu ra:** Khi hoàn tất, sử dụng nút "Mở thư mục đầu ra" để truy cập nhanh các tệp đã tạo.

Giao diện Web UI hoạt động như một lớp bao tiện lợi quanh script `inference.py`. Để sử dụng các tùy chọn nâng cao hoặc xử lý sự cố, hãy tham khảo hướng dẫn dòng lệnh.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Suy luận bằng dòng lệnh

Dành cho người dùng thích sử dụng dòng lệnh hoặc cần truy cập vào các cấu hình nâng cao, hãy làm theo các bước dưới đây. **Lưu ý:** Để giao diện đồ họa đơn giản hơn, vui lòng xem phần [Web UI (Khuyến nghị)](#web-ui-recommended) ở trên.

Chạy `inference.py` và truyền vào một số đối số để tạo beatmap. Đối với trường hợp này, sử dụng [cú pháp ghi đè Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Xem `configs/inference_v29.yaml` để biết tất cả các tham số có sẵn.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Ví dụ:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI Tương Tác
Đối với những người thích làm việc trên terminal nhưng muốn được hướng dẫn thiết lập, script CLI tương tác là một lựa chọn tuyệt vời thay thế cho giao diện Web.

### Khởi động CLI
Di chuyển đến thư mục đã được nhân bản. Bạn có thể cần phải cấp quyền thực thi cho script trước.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Sử dụng CLI
Script sẽ hướng dẫn bạn qua một loạt các câu hỏi để cấu hình tất cả các tham số sinh, giống như giao diện Web.

Nó sử dụng giao diện mã màu để dễ nhận biết.
Nó cung cấp menu chọn nhiều nâng cao để chọn các mô tả phong cách bằng phím mũi tên và phím cách.
Sau khi bạn trả lời tất cả các câu hỏi, nó sẽ hiển thị lệnh cuối cùng để bạn xem lại.
Bạn có thể xác nhận để thực thi trực tiếp hoặc hủy và sao chép lệnh để sử dụng thủ công.

## Mẹo Sinh Dữ Liệu

- Bạn có thể chỉnh sửa `configs/inference_v29.yaml` và thêm các tham số của mình ở đó thay vì nhập chúng vào terminal mỗi lần.
- Tất cả các mô tả có sẵn có thể được tìm thấy [ở đây](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Luôn cung cấp tham số năm trong khoảng từ 2007 đến 2023. Nếu bạn để trống, mô hình có thể sinh ra kiểu không nhất quán.
- Luôn cung cấp tham số độ khó. Nếu bạn để trống, mô hình có thể sinh ra độ khó không nhất quán.
- Tăng tham số `cfg_scale` để tăng hiệu quả của các tham số `mapper_id` và `descriptors`.
- Bạn có thể sử dụng tham số `negative_descriptors` để hướng mô hình tránh một số phong cách nhất định. Điều này chỉ hiệu quả khi `cfg_scale > 1`. Đảm bảo số lượng mô tả tiêu cực bằng với số lượng mô tả.
- Nếu phong cách bài hát và phong cách beatmap mong muốn không phù hợp, mô hình có thể không theo đúng hướng dẫn của bạn. Ví dụ, rất khó để sinh beatmap SR cao, SV cao cho một bài hát nhẹ nhàng.
- Nếu bạn đã có timing và kiai times cho bài hát, bạn có thể cung cấp cho mô hình để tăng tốc độ và độ chính xác suy luận: Sử dụng các tham số `beatmap_path` và `in_context=[TIMING,KIAI]`.
- Để remap chỉ một phần của beatmap, sử dụng các tham số `beatmap_path`, `start_time`, `end_time`, và `add_to_beatmap=true`.
- Để sinh độ khó guest cho beatmap, sử dụng các tham số `beatmap_path` và `in_context=[GD,TIMING,KIAI]`.
- Để sinh hitsounds cho beatmap, sử dụng các tham số `beatmap_path` và `in_context=[NO_HS,TIMING,KIAI]`.
- Để chỉ sinh timing cho bài hát, sử dụng các tham số `super_timing=true` và `output_type=[TIMING]`.

## MaiMod: Công cụ Modding AI-driven

MaiMod là công cụ modding cho beatmap osu! sử dụng dự đoán của Mapperatorinator để tìm các lỗi và sự không nhất quán tiềm ẩn mà các công cụ modding tự động khác như [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier) không thể phát hiện.
Nó có thể phát hiện các vấn đề như:
- Snap hoặc mẫu nhịp điệu sai
- Điểm thời gian không chính xác
- Vị trí hit object hoặc đặt new combo không nhất quán
- Hình dạng slider lạ
- Hitsounds hoặc âm lượng không nhất quán

Bạn có thể thử MaiMod [tại đây](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), hoặc chạy nó tại máy:
Để chạy MaiMod tại máy, bạn cần cài Mapperatorinator. Sau đó, chạy script `mai_mod.py`, chỉ định đường dẫn beatmap bằng tham số `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Điều này sẽ in các đề xuất modding lên bảng điều khiển, sau đó bạn có thể áp dụng chúng vào beatmap của mình một cách thủ công.
Các đề xuất được sắp xếp theo thứ tự thời gian và được nhóm thành các danh mục.
Giá trị đầu tiên trong vòng tròn chỉ ra 'surprisal', là thước đo mức độ bất ngờ mà mô hình nhận thấy vấn đề, vì vậy bạn có thể ưu tiên những vấn đề quan trọng nhất.

Mô hình có thể mắc lỗi, đặc biệt là với các vấn đề có surprisal thấp, vì vậy hãy luôn kiểm tra kỹ các đề xuất trước khi áp dụng chúng vào beatmap của bạn.
Mục tiêu chính là giúp bạn thu hẹp phạm vi tìm kiếm các vấn đề tiềm ẩn, để bạn không phải kiểm tra thủ công từng đối tượng hit trong beatmap của mình.

### MaiMod GUI
Để chạy MaiMod Web UI, bạn cần cài đặt Mapperatorinator.
Sau đó, chạy script `mai_mod_ui.py`. Điều này sẽ khởi động một máy chủ web cục bộ và tự động mở giao diện người dùng trong một cửa sổ mới:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Tổng quan

### Tokenization

Mapperatorinator chuyển đổi beatmap của osu! thành một dạng trung gian của sự kiện, có thể chuyển đổi trực tiếp sang và từ các token.
Nó bao gồm các hit object, hitsound, vận tốc slider, combo mới, điểm thời gian, thời gian kiai, và tốc độ cuộn của taiko/mania.

Dưới đây là một ví dụ nhỏ về quá trình tokenization:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Để tiết kiệm kích thước từ vựng, các sự kiện thời gian được lượng tử hóa theo khoảng 10ms và tọa độ vị trí được lượng tử hóa theo lưới điểm 32 pixel.

### Kiến trúc mô hình
Mô hình cơ bản là một lớp bao quanh [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), với embedding đầu vào và hàm loss tùy chỉnh.
Kích thước mô hình là 219 triệu tham số.
Mô hình này được tìm thấy nhanh hơn và chính xác hơn T5 cho tác vụ này.

Tổng quan ở cấp cao về input-output của mô hình như sau:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Mô hình sử dụng các khung phổ Mel làm đầu vào encoder, với một khung cho mỗi vị trí đầu vào. Đầu ra decoder tại mỗi bước là một phân phối softmax trên một tập hợp từ vựng rời rạc, được xác định trước của các sự kiện. Đầu ra là thưa, chỉ cần sự kiện khi có hit-object, thay vì chú thích từng khung âm thanh.

### Định dạng huấn luyện đa tác vụ

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Trước token SOS là các token bổ sung để hỗ trợ sinh có điều kiện. Những token này bao gồm chế độ chơi, độ khó, ID mapper, năm và các metadata khác.
Trong quá trình huấn luyện, các token này không có nhãn đi kèm nên chúng không bao giờ được mô hình xuất ra.
Ngoài ra trong huấn luyện, có xác suất ngẫu nhiên một token metadata sẽ bị thay thế bởi một token 'unknown', nên trong suy luận chúng ta có thể dùng các token 'unknown' này để giảm lượng metadata cần cung cấp cho mô hình.

### Sinh liên tục mượt mà

Độ dài ngữ cảnh của mô hình là 8.192 giây. Rõ ràng là không đủ để tạo ra toàn bộ beatmap, do đó chúng ta phải chia bài hát thành nhiều cửa sổ và sinh beatmap thành từng phần nhỏ.
Để đảm bảo beatmap sinh ra không bị lộ ranh giới giữa các cửa sổ, chúng tôi sử dụng độ chồng lấn 90% và sinh các cửa sổ tuần tự.
Mỗi cửa sổ sinh (trừ cửa sổ đầu tiên) sẽ bắt đầu với decoder được điền trước đến 50% cửa sổ sinh bằng token từ các cửa sổ trước.
Chúng tôi sử dụng một bộ xử lý logit để đảm bảo rằng mô hình không thể sinh ra các token thời gian nằm trong 50% đầu tiên của cửa sổ sinh.
Ngoài ra, 40% cuối của cửa sổ sinh được dành cho cửa sổ tiếp theo. Bất kỳ token thời gian nào được sinh ra trong phạm vi đó sẽ được coi là token EOS.
Điều này đảm bảo rằng mỗi token được sinh ra đều được điều kiện hóa bởi ít nhất 4 giây token trước đó và 3,3 giây âm thanh tương lai để dự đoán.

Để ngăn trôi lệch offset trong quá trình sinh dài, các offset ngẫu nhiên đã được thêm vào các sự kiện thời gian trong decoder trong quá trình huấn luyện.
Điều này buộc nó phải sửa lỗi thời gian bằng cách lắng nghe các onset trong âm thanh thay vào đó, và kết quả là offset chính xác một cách nhất quán.

### Tọa độ tinh chỉnh với diffusion

Tọa độ vị trí được sinh ra bởi decoder được lượng tử hóa thành các điểm lưới 32 pixel, vì vậy sau đó chúng tôi sử dụng diffusion để loại bỏ nhiễu tọa độ đến các vị trí cuối cùng.
Để làm điều này, chúng tôi đã huấn luyện một phiên bản sửa đổi của [osu-diffusion](https://github.com/OliBomby/osu-diffusion) chuyên biệt chỉ cho 10% cuối của lịch trình nhiễu, và nhận các token metadata nâng cao hơn mà Mapperatorinator sử dụng cho sinh có điều kiện.

Vì mô hình Mapperatorinator xuất ra SV của sliders, chiều dài cần thiết của slider là cố định bất kể hình dạng đường đi của control point.
Do đó, chúng tôi cố gắng hướng quá trình diffusion để tạo ra các tọa độ phù hợp với chiều dài slider yêu cầu.
Chúng tôi thực hiện điều này bằng cách tính lại vị trí kết thúc slider sau mỗi bước của quá trình diffusion dựa trên chiều dài yêu cầu và đường đi control point hiện tại.
Điều này có nghĩa là quá trình diffusion không kiểm soát trực tiếp vị trí kết thúc slider, nhưng vẫn có thể ảnh hưởng đến chúng bằng cách thay đổi đường đi control point.

### Xử lý hậu kỳ

Mapperatorinator thực hiện một số bước xử lý hậu kỳ bổ sung để nâng cao chất lượng beatmap được sinh ra:

- Tinh chỉnh tọa độ vị trí với diffusion.
- Gắn lại các sự kiện thời gian vào tick gần nhất bằng cách sử dụng snap divisors do mô hình sinh ra.
- Gắn kết các vị trí gần như trùng khớp.
- Chuyển đổi các sự kiện cột mania thành tọa độ X.
- Sinh đường slider cho taiko drumrolls.
- Sửa các khác biệt lớn giữa chiều dài slider yêu cầu và chiều dài đường đi control point.

### Bộ sinh timing siêu cấp

Bộ sinh timing siêu cấp là một thuật toán cải thiện độ chính xác của timing được sinh ra bằng cách suy ra timing cho cả bài hát 20 lần và lấy trung bình kết quả.
Điều này hữu ích cho các bài hát có BPM thay đổi, hoặc các bài hát có thay đổi BPM. Kết quả gần như hoàn hảo, chỉ đôi khi có một đoạn cần chỉnh sửa thủ công.

## Huấn luyện

Hướng dẫn bên dưới sẽ tạo môi trường huấn luyện trên máy cục bộ của bạn.

### 1. Sao chép repository

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Tạo bộ dữ liệu

Tạo bộ dữ liệu của riêng bạn bằng ứng dụng [Mapperator console app](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Ứng dụng này yêu cầu một [osu! OAuth client token](https://osu.ppy.sh/home/account/edit) để xác minh beatmaps và lấy thêm metadata. Đặt bộ dữ liệu vào thư mục `datasets` cạnh thư mục `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Tùy chọn) Thiết lập Weight & Biases để ghi log
Tạo một tài khoản trên [Weight & Biases](https://wandb.ai/site) và lấy khóa API từ phần cài đặt tài khoản của bạn.
Sau đó thiết lập biến môi trường `WANDB_API_KEY`, để quá trình huấn luyện biết ghi log vào khóa này.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Tạo container docker
Bạn cũng có thể huấn luyện trong venv của mình, nhưng chúng tôi khuyến nghị sử dụng Docker trên WSL để có hiệu suất tốt hơn.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Cấu hình tham số và bắt đầu huấn luyện

Tất cả các cấu hình nằm trong `./configs/train/default.yaml`.
Hãy đảm bảo thiết lập đúng `train_dataset_path` và `test_dataset_path` trỏ đến tập dữ liệu của bạn, cũng như chỉ số mapset bắt đầu và kết thúc cho phân chia huấn luyện/kiểm thử.
Đường dẫn là cục bộ trong container docker, vì vậy nếu bạn đặt tập dữ liệu tên là `cool_dataset` vào thư mục `datasets`, thì nó nên là `/workspace/datasets/cool_dataset`.

Tôi khuyên bạn nên tạo một file cấu hình tùy chỉnh ghi đè file cấu hình mặc định, để bạn có thể lưu lại cấu hình huấn luyện nhằm đảm bảo khả năng tái lập kết quả.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Tinh chỉnh LoRA

Bạn cũng có thể tinh chỉnh một mô hình đã huấn luyện trước bằng [LoRA](https://arxiv.org/abs/2106.09685) để thích ứng với một phong cách hoặc chế độ chơi cụ thể.
Để làm điều này, hãy điều chỉnh `configs/train/lora.yaml` theo nhu cầu của bạn và chạy cấu hình huấn luyện `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Các tham số LoRA quan trọng cần lưu ý:
- `pretrained_path`: Đường dẫn hoặc repo HF của mô hình gốc cần tinh chỉnh.
- `r`: Hạng của các ma trận LoRA. Giá trị cao hơn tăng khả năng mô hình nhưng cũng tăng sử dụng bộ nhớ.
- `lora_alpha`: Hệ số tỉ lệ cho các cập nhật LoRA.
- `total_steps`: Tổng số bước huấn luyện. Cân đối theo kích thước tập dữ liệu của bạn.
- `enable_lora`: Có sử dụng LoRA hay tinh chỉnh toàn bộ mô hình.

Trong quá trình suy luận, bạn có thể chỉ định trọng số LoRA sử dụng với tham số `lora_path`.
Tham số này có thể là một đường dẫn cục bộ hoặc repo trên Hugging Face.

## Xem thêm
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Ghi nhận

Đặc biệt cảm ơn:
1. Các tác giả của [osuT5](https://github.com/gyataro/osuT5) với mã huấn luyện của họ.
2. Nhóm Hugging Face với [các công cụ](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) và [Richard Nagyfi](https://github.com/sedthh) vì những ý tưởng đóng góp.
4. [Marvin](https://github.com/minetoblend) vì đã quyên góp tín dụng huấn luyện.
5. Cộng đồng osu! vì các beatmap.

## Các công trình liên quan

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) của Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) của kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) của OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) của gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) của sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) của jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---