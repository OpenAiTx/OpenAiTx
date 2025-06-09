# StyTr^2 : Chuyển Đổi Phong Cách Ảnh Bằng Transformers（CVPR2022）
*Tác giả: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

Bài báo này đề xuất một phương pháp chuyển đổi phong cách ảnh không thiên vị dựa trên mô hình transformer. Chúng tôi có thể cải thiện hiệu ứng phong cách hóa so với các phương pháp tiên tiến nhất hiện nay.
Kho lưu trữ này là bản cài đặt chính thức của [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576).

## Trình bày kết quả
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
So với một số thuật toán tiên tiến hiện nay, phương pháp của chúng tôi có khả năng mạnh mẽ trong việc tránh rò rỉ nội dung và có khả năng biểu diễn đặc trưng tốt hơn.  <br>

## Khung mô hình
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
Quy trình tổng thể của khung StyTr^2 của chúng tôi. Chúng tôi chia hình ảnh nội dung và phong cách thành các mảng nhỏ, và sử dụng phép chiếu tuyến tính để thu được chuỗi ảnh. Sau đó, các chuỗi nội dung được cộng thêm CAPE sẽ được đưa vào bộ mã hóa transformer nội dung, trong khi các chuỗi phong cách sẽ được đưa vào bộ mã hóa transformer phong cách. Sau hai bộ mã hóa transformer này, một bộ giải mã transformer nhiều lớp được sử dụng để phong cách hóa chuỗi nội dung theo chuỗi phong cách. Cuối cùng, chúng tôi sử dụng bộ giải mã tăng cường dần để thu được các hình ảnh phong cách hóa với độ phân giải cao.

## Thí nghiệm
### Yêu cầu
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### Kiểm thử
Các mô hình đã huấn luyện trước: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
Vui lòng tải các mô hình này và đặt vào thư mục ./experiments/  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### Huấn luyện
Bộ dữ liệu phong cách là WikiArt thu thập từ [WIKIART](https://www.wikiart.org/)  <br>  
Bộ dữ liệu nội dung là COCO2014  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### Tham khảo
Nếu bạn thấy công trình của chúng tôi hữu ích cho nghiên cứu của mình, vui lòng trích dẫn bài báo của chúng tôi bằng mục BibTeX sau ~ Xin cảm ơn ^ . ^. Link bài báo [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---