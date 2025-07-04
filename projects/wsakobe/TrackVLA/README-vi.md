<p align="center">
<h1 align="center"><strong>TrackVLA: Theo dõi Thị giác Nhúng trong Môi trường Tự nhiên</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    Đại học Bắc Kinh&emsp; 
    Galbot&emsp; <br>
    Đại học Hàng không Bắc Kinh&emsp;
    Đại học Sư phạm Bắc Kinh&emsp;
    Viện Trí tuệ Nhân tạo Bắc Kinh&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Giới thiệu
<strong><em>TrackVLA</em></strong> là một mô hình thị giác-ngôn ngữ-hành động có khả năng nhận diện đối tượng và theo dõi thị giác đồng thời, được huấn luyện trên bộ dữ liệu gồm 1,7 triệu mẫu. Mô hình này thể hiện khả năng theo dõi mạnh mẽ, theo dõi lâu dài và tổng quát hóa giữa các miền trong nhiều môi trường đa dạng đầy thách thức.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Tin tức

* [25/07/02]: EVT-Bench hiện đã có sẵn.

## 💡 Cài đặt
1. **Chuẩn bị môi trường conda**

   Đầu tiên, bạn cần cài đặt [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Sau khi cài đặt conda, hãy tạo một môi trường mới:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Cài đặt habitat-sim bằng Conda**
   
   Bạn cần cài đặt habitat-sim phiên bản 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Cài đặt habitat-lab từ mã nguồn**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Chuẩn bị bộ dữ liệu**

    Tải bộ dữ liệu Habitat Matterport 3D (HM3D) từ [đây](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) và Matterport3D (MP3D) từ [đây](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Sau đó di chuyển bộ dữ liệu vào `data/scene_datasets`. Cấu trúc thư mục của bộ dữ liệu như sau:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    Tiếp theo, chạy đoạn mã sau để lấy dữ liệu cho avatar hình người:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Đánh giá
  Chạy script với:

    bash eval.sh

  Kết quả sẽ được lưu trong đường dẫn SAVE_PATH đã chỉ định, bao gồm một thư mục log và một thư mục video. Để theo dõi kết quả trong quá trình đánh giá, hãy chạy:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Để dừng quá trình đánh giá, sử dụng:

    bash kill_eval.sh


## 📝 Danh sách TODO
- [x] Phát hành bài báo arXiv vào tháng 5, 2025.
- [x] Phát hành EVT-Bench (Bộ tiêu chuẩn đánh giá Theo dõi Thị giác Hóa thân).
- [ ] Phát hành bộ dữ liệu theo dõi thị giác hóa thân quy mô lớn.
- [ ] Phát hành checkpoint và mã nguồn của TrackVLA.

## ✉️ Liên hệ
Nếu có bất kỳ câu hỏi nào, vui lòng gửi email tới wangshaoan@stu.pku.edu.cn. Chúng tôi sẽ phản hồi sớm nhất có thể.


## 🔗 Trích dẫn
Nếu bạn thấy công trình của chúng tôi hữu ích, vui lòng trích dẫn như sau:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Giấy phép
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Công trình này tuân theo <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Giấy phép Creative Commons Ghi công-Phi thương mại-Chia sẻ tương tự 4.0 Quốc tế</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---