# SinGAN

[Project](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [Supplementary materials](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [Talk (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### Cài đặt chính thức bằng pytorch của bài báo: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### Giải thưởng bài báo xuất sắc nhất ICCV 2019 (Marr prize)


## Các mẫu ngẫu nhiên từ *một* ảnh duy nhất
Với SinGAN, bạn có thể huấn luyện một mô hình sinh từ một ảnh tự nhiên duy nhất, và sau đó sinh ra các mẫu ngẫu nhiên từ ảnh đó, ví dụ:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## Ứng dụng của SinGAN
SinGAN cũng có thể được sử dụng cho một loạt các tác vụ chỉnh sửa ảnh, ví dụ:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
Việc này được thực hiện bằng cách đưa một ảnh vào mô hình đã được huấn luyện sẵn. Xem mục 4 trong [bài báo](https://arxiv.org/pdf/1905.01164.pdf) của chúng tôi để biết thêm chi tiết.


### Trích dẫn
Nếu bạn sử dụng mã nguồn này cho nghiên cứu của mình, vui lòng trích dẫn bài báo của chúng tôi:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## Mã nguồn

### Cài đặt các thư viện phụ thuộc

```
python -m pip install -r requirements.txt
```

Mã nguồn này đã được kiểm tra với python 3.6, torch 1.4

Lưu ý: mã nguồn hiện tại chỉ hỗ trợ torch 1.4 hoặc thấp hơn do sơ đồ tối ưu hóa.

Với các phiên bản torch mới hơn, bạn có thể thử kho này: https://github.com/kligvasser/SinGAN (kết quả có thể sẽ không giống hoàn toàn với bản cài đặt chính thức).


###  Huấn luyện
Để huấn luyện mô hình SinGAN trên ảnh của riêng bạn, hãy đặt ảnh huấn luyện mong muốn vào thư mục Input/Images, và chạy

```
python main_train.py --input_name <input_file_name>
```

Lệnh này cũng sẽ sử dụng mô hình đã huấn luyện để sinh các mẫu ngẫu nhiên bắt đầu từ cấp độ thô nhất (n=0).

Để chạy mã này trên máy chỉ có cpu, hãy thêm tùy chọn `--not_cuda` khi gọi `main_train.py`

###  Mẫu ngẫu nhiên
Để sinh các mẫu ngẫu nhiên từ bất kỳ cấp độ sinh nào, trước hết hãy huấn luyện mô hình SinGAN trên ảnh mong muốn (như hướng dẫn ở trên), sau đó chạy 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

lưu ý: để sử dụng toàn bộ mô hình, hãy đặt cấp độ bắt đầu sinh là 0; để bắt đầu sinh từ cấp độ thứ hai, hãy đặt là 1, v.v.

###  Mẫu ngẫu nhiên với kích thước tuỳ ý
Để sinh các mẫu ngẫu nhiên với kích thước tuỳ ý, trước hết hãy huấn luyện mô hình SinGAN trên ảnh mong muốn (như hướng dẫn ở trên), sau đó chạy

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  Tạo hoạt ảnh từ một ảnh duy nhất

Để sinh hoạt ảnh ngắn từ một ảnh duy nhất, chạy

```
python animation.py --input_name <input_file_name> 
```

Lệnh này sẽ tự động bắt đầu một pha huấn luyện mới với chế độ noise padding.

###  Hài hoà hoá

Để hài hoà một đối tượng dán vào trong ảnh (Xem ví dụ trong Hình 13 ở [bài báo của chúng tôi](https://arxiv.org/pdf/1905.01164.pdf)), trước hết hãy huấn luyện mô hình SinGAN trên ảnh nền mong muốn (như hướng dẫn ở trên), sau đó lưu ảnh tham chiếu được dán thô và mặt nạ nhị phân của nó vào thư mục "Input/Harmonization" (xem ảnh mẫu đã lưu). Chạy lệnh

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

Lưu ý rằng các cấp độ chèn khác nhau sẽ tạo ra hiệu ứng hài hoà khác nhau. Cấp độ chèn thô nhất là 1.

###  Chỉnh sửa

Để chỉnh sửa một ảnh, (Xem ví dụ trong Hình 12 ở [bài báo của chúng tôi](https://arxiv.org/pdf/1905.01164.pdf)), trước hết hãy huấn luyện mô hình SinGAN trên ảnh gốc chưa chỉnh sửa mong muốn (như hướng dẫn ở trên), sau đó lưu bản chỉnh sửa thô làm ảnh tham chiếu vào thư mục "Input/Editing" cùng với bản đồ nhị phân tương ứng (xem ảnh mẫu đã lưu). Chạy lệnh

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
cả đầu ra đã che và chưa che sẽ được lưu lại.
Tại đây, các tỷ lệ tiêm khác nhau cũng sẽ tạo ra các hiệu ứng chỉnh sửa khác nhau. Tỷ lệ tiêm thô nhất là 1.

###  Vẽ thành Ảnh

Để chuyển một bức vẽ thành ảnh thực tế (Xem ví dụ ở Hình 11 trong [bài báo của chúng tôi](https://arxiv.org/pdf/1905.01164.pdf)), trước tiên hãy huấn luyện mô hình SinGAN trên ảnh mong muốn (như mô tả ở trên), sau đó lưu bức vẽ của bạn vào thư mục "Input/Paint", và chạy lệnh

```
python paint2image.py --input_name <tên_file_ảnh_huấn_luyện> --ref_name <tên_file_ảnh_vẽ> --paint_start_scale <tỷ lệ tiêm>
```
Tại đây, các tỷ lệ tiêm khác nhau cũng sẽ tạo ra các hiệu ứng chỉnh sửa khác nhau. Tỷ lệ tiêm thô nhất là 1.

Tùy chọn nâng cao: Chỉ định quantization_flag là True, để huấn luyện lại *chỉ* mức tiêm của mô hình, nhằm tạo ra phiên bản lượng tử màu của ảnh sinh ra được nội suy từ tỷ lệ trước đó. Đối với một số ảnh, việc này có thể cho kết quả thực tế hơn.

### Nâng Cấp Độ Phân Giải (Super Resolution)
Để nâng cấp độ phân giải cho một ảnh, hãy chạy:
```
python SR.py --input_name <tên_file_ảnh_low_res>
```
Lệnh này sẽ tự động huấn luyện mô hình SinGAN tương ứng với hệ số phóng đại 4x (nếu chưa tồn tại).
Đối với các hệ số nâng cấp khác nhau, hãy chỉ định bằng tham số `--sr_factor` khi gọi hàm.
Kết quả của SinGAN trên bộ dữ liệu BSD100 có thể tải về từ thư mục 'Downloads'.

## Dữ Liệu và Chức Năng Bổ Sung

### Chỉ Số Khoảng Cách Fréchet Inception Ảnh Đơn (SIFID score)
Để tính SIFID giữa ảnh thực và các mẫu giả tương ứng, hãy chạy:
```
python SIFID/sifid_score.py --path2real <đường_dẫn_ảnh_thật> --path2fake <đường_dẫn_ảnh_giả> 
```  
Đảm bảo rằng tên file của mỗi ảnh giả phải giống hệt với ảnh thực tương ứng. Ảnh nên được lưu ở định dạng `.jpg`.

### Kết Quả Nâng Cấp Độ Phân Giải
Kết quả SR của SinGAN trên bộ dữ liệu BSD100 có thể tải về từ thư mục 'Downloads'.

### Nghiên Cứu Người Dùng
Dữ liệu sử dụng cho nghiên cứu người dùng có thể tìm thấy trong thư mục Downloads.

real folder: 50 ảnh thực, được chọn ngẫu nhiên từ [cơ sở dữ liệu places](http://places.csail.mit.edu/)

fake_high_variance folder: các mẫu ngẫu nhiên bắt đầu từ n=N cho mỗi ảnh thực

fake_mid_variance folder: các mẫu ngẫu nhiên bắt đầu từ n=N-1 cho mỗi ảnh thực

Để biết thêm chi tiết vui lòng xem mục 3.1 trong [bài báo của chúng tôi](https://arxiv.org/pdf/1905.01164.pdf)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---