[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Dự đoán Khả năng Tổng hợp Hợp chất Dựa trên Học sâu

Với sự phát triển không ngừng của công nghệ trí tuệ nhân tạo, ngày càng nhiều mô hình sinh sâu được sử dụng để sinh phân tử. Tuy nhiên, hầu hết các phân tử mới được sinh ra bởi các mô hình này thường gặp phải thách thức lớn về khả năng tổng hợp.

DeepSA được đề xuất nhằm dự đoán khả năng tổng hợp của các hợp chất, và có tỷ lệ làm giàu sớm cao hơn nhiều trong việc phân biệt các phân tử khó tổng hợp. Điều này giúp người dùng lựa chọn các phân tử ít tốn kém hơn để tổng hợp, từ đó giảm thời gian phát hiện và phát triển thuốc. Bạn có thể sử dụng DeepSA trên máy chủ web tại https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Yêu cầu
Các thư viện phụ thuộc có thể được cài đặt bằng lệnh sau:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# cho phiên bản gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Tin tức 🔔

* 2024-12, do [AutoGluon đã ngừng hỗ trợ Python phiên bản 3.8](https://github.com/autogluon/autogluon/pull/4512) kể từ tháng 10 năm 2024. Do đó, chúng tôi đã cập nhật DeepSA để sử dụng Python phiên bản 3.12 và cập nhật các script huấn luyện và suy luận để thích ứng với phiên bản mới nhất của AutoGluon, cảm ơn bạn đã quan tâm đến DeepSA!

* 2023-7, DeepSA_v1.0 đã được phát hành, hoan nghênh đóng góp ý kiến tại issue!

## Dữ liệu
Bộ dữ liệu huấn luyện mở rộng và kiểm tra có thể được tải xuống dễ dàng tại https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing

## Hướng dẫn sử dụng cho nhà nghiên cứu
Nếu bạn muốn huấn luyện mô hình của riêng mình, bạn có thể chạy lệnh sau từ dòng lệnh,

chạy:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Nếu bạn muốn sử dụng mô hình mà chúng tôi đề xuất,

chạy:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Máy chủ trực tuyến

Chúng tôi đã triển khai một mô hình đã huấn luyện sẵn trên máy chủ chuyên dụng, công khai tại https://bailab.siais.shanghaitech.edu.cn/deepsa, giúp các nhà nghiên cứu y sinh dễ dàng sử dụng DeepSA trong hoạt động nghiên cứu của mình.

Người dùng có thể tải lên SMILES hoặc file csv của họ lên máy chủ, sau đó nhanh chóng nhận được kết quả dự đoán.

## <span id="citelink">Trích dẫn</span>
Nếu bạn thấy kho lưu trữ này hữu ích cho nghiên cứu của mình, vui lòng trích dẫn bài báo của chúng tôi:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Liên hệ
Nếu bạn có bất kỳ câu hỏi nào, vui lòng liên hệ với Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) hoặc Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Rất hoan nghênh các pull request!

## Lời cảm ơn
Chúng tôi xin cảm ơn sự hỗ trợ từ Nền tảng HPC của Đại học Khoa học và Công nghệ Thượng Hải.<br/>
Xin cảm ơn tất cả các bạn đã quan tâm đến công trình này.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---