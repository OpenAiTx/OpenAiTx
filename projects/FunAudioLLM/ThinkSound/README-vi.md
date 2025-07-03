# 🎶 ThinkSound

<p align="center">
  Nếu bạn thấy dự án này hữu ích, một ngôi sao ⭐ trên GitHub sẽ được đánh giá rất cao!
</p>

<p align="center">
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

---

**ThinkSound** là một framework hợp nhất cho Any2Audio với phương pháp flow matching được dẫn dắt bởi lý luận Chuỗi Suy Nghĩ (Chain-of-Thought - CoT).

Hiện thực PyTorch cho việc tạo và chỉnh sửa âm thanh đa phương tiện: tạo hoặc chỉnh sửa âm thanh từ video, văn bản, và âm thanh, được hỗ trợ bởi quá trình suy luận từng bước từ Mô hình Ngôn ngữ Lớn Đa phương tiện (MLLMs).

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 Tin tức
- **2025.07** &nbsp; 🔥Demo trực tuyến trên [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) và [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) cho trải nghiệm tương tác!
- **2025.07** &nbsp; 🔥Phát hành mã suy luận và giao diện web;
- **2025.06** &nbsp; 🔥[Bài báo ThinkSound](https://arxiv.org/pdf/2506.21448) được phát hành trên arXiv!
- **2025.06** &nbsp; 🔥[Demo trực tuyến](http://thinksound-project.github.io/) đã hoạt động - hãy thử ngay!

---

## 🚀 Tính năng

- **Any2Audio**: Tạo âm thanh từ bất kỳ loại dữ liệu nào — video, văn bản, âm thanh, hoặc kết hợp của chúng.
- **Video-to-Audio SOTA**: Đạt kết quả tốt nhất trên nhiều bộ chuẩn V2A.
- **Lý luận dựa trên CoT**: Lý luận Chuỗi Suy Nghĩ cho việc tạo âm thanh có tính thành phần và kiểm soát được thông qua MLLMs.
- **Chỉnh sửa tập trung vào đối tượng tương tác**: Tinh chỉnh hoặc chỉnh sửa sự kiện âm thanh cụ thể bằng cách nhấp vào đối tượng hình ảnh hoặc sử dụng hướng dẫn văn bản.
- **Khung hợp nhất**: Một mô hình nền tảng hỗ trợ tạo, chỉnh sửa và quy trình làm việc tương tác.

---

## ✨ Tổng quan phương pháp

ThinkSound phân tách quá trình tạo và chỉnh sửa âm thanh thành ba giai đoạn tương tác, tất cả đều được dẫn dắt bởi lý luận Chuỗi Suy Nghĩ (CoT) dựa trên MLLM:

1. **Tạo Foley:** Tạo nền âm thanh cơ bản, phù hợp về ngữ nghĩa và thời gian từ video.
2. **Tinh chỉnh tập trung vào đối tượng:** Tinh chỉnh hoặc thêm âm thanh cho các đối tượng do người dùng chỉ định thông qua click hoặc vùng chọn trong video.
3. **Chỉnh sửa âm thanh mục tiêu:** Chỉnh sửa âm thanh đã tạo bằng hướng dẫn ngôn ngữ tự nhiên ở cấp độ cao.

![Tổng quan ThinkSound](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- Một bộ dữ liệu quy mô lớn được chú thích theo CoT (**AudioCoT**) được sử dụng để huấn luyện cả module lý luận và mô hình nền tảng âm thanh hợp nhất.
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ Bắt đầu nhanh

**Chuẩn bị môi trường:**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# Tải trọng số đã huấn luyện sẵn https://huggingface.co/liuhuadai/ThinkSound về thư mục ckpts/
# Trọng số mô hình cũng có thể tải từ https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**Cấp quyền thực thi**
```bash
chmod +x scripts/demo.sh
```

**Chạy script**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### Sử dụng giao diện web

Để có trải nghiệm tương tác, hãy khởi động giao diện web Gradio:

```bash
python app.py
```

---
## 📝 VIỆC CẦN LÀM

- ☐ Phát hành các script huấn luyện cho các mô hình ThinkSound
- ☐ Mã nguồn mở bộ dữ liệu AudioCoT và quy trình tự động hóa
- ☐ Cung cấp tài liệu chi tiết và tham khảo API
- ☐ Thêm hỗ trợ cho các kiểu dữ liệu và tác vụ hậu kỳ khác

---

## 📄 Giấy phép

Dự án này được phát hành theo [Giấy phép Apache 2.0](LICENSE).

> **Lưu ý:**  
> Mã nguồn, mô hình và bộ dữ liệu **chỉ dành cho mục đích nghiên cứu và giáo dục**.  
> **KHÔNG được phép sử dụng cho mục đích thương mại.**
>
> Để xin giấy phép thương mại, vui lòng liên hệ tác giả.

---

## 📖 Trích dẫn

Nếu bạn thấy ThinkSound hữu ích trong nghiên cứu hoặc công việc của mình, vui lòng trích dẫn bài báo của chúng tôi:

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
```

---

## 📬 Liên hệ

✨ Hãy [tạo issue mới](https://github.com/liuhuadai/ThinkSound/issues) hoặc liên hệ với chúng tôi qua email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) nếu bạn có bất kỳ câu hỏi hoặc góp ý nào!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---