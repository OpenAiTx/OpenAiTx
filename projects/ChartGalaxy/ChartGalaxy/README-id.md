![Logo ChartGalaxy](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/title.png)

## Dataset
> 📦 **[👉 Akses dataset ChartGalaxy lengkap di Hugging Face! 👈](https://huggingface.co/datasets/ChartGalaxy/ChartGalaxy)**

Karena keterbatasan penyimpanan, kami hanya menyertakan kumpulan contoh yang representatif. 
Repositori ini berisi kode terkait untuk makalah "ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation".

## 🔥 Berita
**2025.5**:  🎉🎉 Kami telah merilis versi pertama dari dataset kami, yang mencakup 1.151.087 grafik infografik sintetis dan 104.519 grafik infografik nyata, mencakup 75 jenis grafik dan 330 variasi.

-------------------

<img src="https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/teaser.png" style="border:none;box-shadow:none;">

![Gambar Contoh](https://raw.githubusercontent.com/ChartGalaxy/ChartGalaxy/refs/heads/main/examples.png)

<!-- ## 🔔 Berita -->

## Pendahuluan

### Tentang

ChartGalaxy adalah dataset berskala jutaan yang terdiri dari grafik infografik sintetis dan nyata beserta tabel data, mendukung aplikasi pemahaman grafik infografik, pembuatan kode, dan pembuatan grafik. Dataset ini mengatasi tantangan bahwa dataset yang ada sebagian besar terbatas pada grafik sederhana, gagal menangkap beragam gaya desain dan tata letak yang merupakan karakteristik utama grafik infografik.

### Statistik

- **Ukuran**: 1.255.606 grafik infografik (1.151.087 sintetis + 104.519 nyata)
- **Konten**: Setiap grafik infografik dipasangkan dengan data tabular yang digunakan untuk membuatnya
- **Jenis Grafik**: 75 jenis grafik dengan 330 variasi grafik
- **Template Tata Letak**: 68 template tata letak

### Pengumpulan dan Pembuatan Data

ChartGalaxy dibangun melalui:

1. **Pengumpulan Grafik Infografik Nyata**: Grafik dikumpulkan dari 19 situs web kaya grafik yang terkemuka, seperti Pinterest, Visual Capitalist, Statista, dan Information is Beautiful.

2. **Pembuatan Grafik Infografik Sintetis**: Mengikuti proses strukturasi induktif yang:
   - Mengidentifikasi 75 jenis grafik (misal: grafik batang) dan 330 variasi grafik yang mencerminkan berbagai gaya elemen visual
   - Mengekstrak 68 template tata letak yang mendefinisikan hubungan spasial antar elemen
   - Secara terprogram menghasilkan grafik sintetis berdasarkan pola ini

## 🎯 Aplikasi

Kegunaan ChartGalaxy didemonstrasikan melalui tiga aplikasi representatif:

### 1. 🧠 Pemahaman Grafik Infografik

Fine-tuning pada ChartGalaxy meningkatkan performa model dasar pada pemahaman grafik infografik. 

### 2. 💻 Pembuatan Kode Grafik Infografik

Benchmark untuk menilai pembuatan kode LVLM untuk grafik infografik. Benchmark ini mengevaluasi kemiripan antara grafik yang dirender oleh kode D3.js yang dihasilkan dan grafik ground-truth pada dua tingkat granularitas: tingkat tinggi (kemiripan visual keseluruhan) dan tingkat rendah (rata-rata kemiripan antar elemen SVG yang terperinci).

#### Ikhtisar

Benchmark ini menilai pembuatan kode grafik pada dua tingkat:
- **Tingkat rendah**: Kemiripan per elemen antara SVG yang dihasilkan dan referensi
- **Tingkat tinggi**: Penilaian kesetiaan visual dan fungsi secara keseluruhan

#### Instalasi

```bash
git clone https://github.com/ChartGalaxy/ChartGalaxy.git
cd ChartGalaxy/code_generation_benchmark
```

#### Penggunaan

1. Konfigurasikan pengaturan di `code_generation_benchmark/configs/default_config.yaml`:
   ```yaml
   prompts:
     high_level_eval_prompt_file: eval_high_level.txt
     chat_prompt_file: chat_direct_prompt.txt

   VLM:
     max_tokens: null
     thinking_budget: 1024
     temperature: 0.0
     top_p: 1.0

   models:
     # Hapus komentar pada model yang ingin dievaluasi
     # - gpt-4o-2024-11-20
     # - claude-3-7-sonnet-20250219
     # - gemini-2.5-pro-preview-05-06
     # - Qwen/Qwen2.5-VL-72B-Instruct

   dirs:
     output_dir: ./output
     log_dir: ./logs
     data_root_dir: ./data
     clip_cache_dir: ./model-ckpts

   eval_model: gpt-4o-2024-11-20
   n_workers: 10
   ```

2. Jalankan benchmark:
   ```bash
   python main.py
   ```

#### Struktur Data

Setiap folder grafik di `data_root_dir` harus berisi:
- `chart.svg`: Grafik asli dalam format SVG

Sistem akan menghasilkan:
- `convert_chart.html`: Rendering HTML dari grafik referensi
- `convert_chart.png`: Screenshot PNG dari grafik referensi
- `convert_chart.json`: Struktur elemen dari grafik referensi
- Output khusus model di subfolder

#### Hasil

Hasil disimpan dalam subfolder khusus model dengan:
- Rendering HTML/PNG yang dihasilkan
- Metrik evaluasi dalam format JSON
- Log detail di `log_dir`
  

### 3. 🖼️ Pembuatan Grafik Infografik Berbasis Contoh

Metode berbasis contoh yang mengubah data tabular yang diberikan pengguna menjadi grafik infografik, sesuai dengan tata letak dan gaya visual dari grafik contoh yang diberikan. Studi pengguna menunjukkan metode ini mengungguli GPT-Image-1 dalam hal kesetiaan, estetika, dan kreativitas.


## Kontak
- chartgalaxy@163.com

## Tautan Makalah

### 📌 Makalah Utama (Repositori Ini)

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

### Makalah Relevan

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 📚 Sitasi
Jika Anda menggunakan ChartGalaxy dalam penelitian Anda, mohon sitasi sebagai berikut:
```
@misc{li2025chartgalaxydatasetinfographicchart,
      title={ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation}, 
      author={Zhen Li and Yukai Guo and Duan Li and Xinyuan Guo and Bowen Li and Lanxi Xiao and Shenyu Qiao and Jiashu Chen and Zijian Wu and Hui Zhang and Xinhuan Shu and Shixia Liu},
      year={2025},
      eprint={2505.18668},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.18668}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---