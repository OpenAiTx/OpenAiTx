# KVzip: Kompresi Cache KV Query-Agnostik dengan Rekonstruksi Konteks

[[Paper](https://arxiv.org/abs/2505.23416)] [[Blog](https://janghyun1230.github.io/kvzip/)] 

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/method.png" width="800">

## Apa yang Baru?
- KVzip mengompresi cache KV untuk mendukung **berbagai query masa depan**.
- [Bergantung konteks] Mencapai **pengurangan ukuran cache KV sebesar 3–4×** dan **penurunan latensi decoding sebesar 2×**, dengan degradasi performa minimal.
- [Tidak bergantung konteks] Meningkatkan kompresi KV tingkat head ala [DuoAttention](https://github.com/mit-han-lab/duo-attention), hanya dengan **beberapa forward pass dalam satu menit** untuk optimasi skor penting tingkat head (100x lebih cepat).
- Jalankan demo.py:
<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/demo.png" width="800">


### Benchmarking pada pengaturan query-agnostik
- Tugas: [SQuAD](https://huggingface.co/datasets/rajpurkar/squad), [NIAH](https://github.com/gkamradt/LLMTest_NeedleInAHaystack), [SCBench](https://github.com/microsoft/MInference/tree/main/scbench), [GSM8K](https://huggingface.co/datasets/openai/gsm8k/viewer/main/train?row=7294). 
- Model: [Qwen2.5-7B-Instruct-1M](https://huggingface.co/Qwen/Qwen2.5-7B-Instruct)

<img src="https://raw.githubusercontent.com/snu-mllab/KVzip/main/images/benchmark.png" width="800">


## Instalasi
Kami menggunakan CUDA 12.1 dan Python 3.10
```bash
cd KVzip
pip install -r requirements.txt
pip install flash-attn==2.7.4.post1 --no-build-isolation
make i
```
- Untuk menggunakan kuantisasi [QServe](https://github.com/mit-han-lab/omniserve), silakan ikuti [`./model/quant_model`](https://github.com/snu-mllab/KVzip/tree/main/model/quant_model).
### Dataset
- Silakan unduh dataset SCBench yang sudah diproses dari [Google Drive](https://drive.google.com/file/d/1cqoR6pxxFcjFqvPZkuAmF-fBSAlAbjbN/view?usp=share_link).
- Jika Anda mengunduh file yang sudah diekstrak, cukup pindahkan folder scbench.
```bash
mv scbench.zip kvzip/data/
cd kvzip/data
unzip scbench.zip  
```

## Mulai Cepat
```python
from model import ModelKVzip

model = ModelKVzip("Qwen/Qwen2.5-7B-Instruct-1M")
context = "This is my basic profile. My name is Kim living in Seoul. My major is computer science."
queries = ["What is my name?", "Do I live in Seoul?"]

kv = model.prefill(context, load_score=False)  # prefill cache KV + penilaian penting
kv.prune(ratio=0.3)  # rasio kompresi, keluarkan 70% KV

for q in queries:
    query_ids = model.apply_template(q)
    output = model.generate(query_ids, kv=kv, update_cache=False)  # inferensi efisien
    print(q, output)
```
- Model yang didukung tercantum di [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), termasuk **LLaMA3, Qwen2.5/3, Gemma3**.
- Atur `load_score=True` untuk menghilangkan overhead kompresi. Ini memungkinkan pengeluaran KV yang tidak bergantung konteks, dengan trade-off rasio kompresi `ratio=0.6`.
- Setelah generasi, pasangan KV yang terkait dengan query dan token yang dihasilkan secara selektif dikeluarkan dari cache untuk pemrosesan selanjutnya. Atur `update_cache=True` untuk mengaktifkan inferensi multi-giliran, mempertahankan seluruh riwayat interaksi selama inferensi.

## Profiling Memori dan Waktu Komputasi
### Pengeluaran bergantung konteks
```bash
python -B test.py -m [model_name] -d [data_name] --kv_type evict --ratio 0.3
```
- Kode di atas juga membandingkan output yang dihasilkan dengan cache KV penuh versus yang sudah dipruning.
- Untuk pengujian cepat, gunakan `-d squad`. Untuk pengujian konteks panjang, gunakan `-d scbench_kv`.
  - Nama data yang tersedia: [`data/load.py`](https://github.com/snu-mllab/KVzip/blob/main/data/load.py).
  - Nama model yang tersedia: [`model/load.py`](https://github.com/snu-mllab/KVzip/blob/main/model/load.py), misal llama3.1-8b, qwen2.5-7b (atau Qwen/Qwen2.5-7B-Instruct-1M).
- Kami mengadaptasi kernel CUDA dari [AdaKV](https://github.com/FFY0/AdaKV/tree/main), mendukung alokasi anggaran head yang tidak uniform.
  - Saat ini, kode kami belum memiliki kernel yang teroptimasi untuk Gemma3 yang menggunakan cache KV statis, sehingga kode tidak menghasilkan peningkatan efisiensi nyata. Namun, performa model masih bisa dievaluasi menggunakan perhatian yang dikurangi dengan subsampling KV (`--kv_type retain`).


### Pengeluaran tidak bergantung konteks (tanpa overhead kompresi runtime)
- Gunakan flag `--level head` dengan `--ratio 0.6` (direkomendasikan).
  - Kami menghapus semua pasangan KV konteks yang terkait dengan head tertentu sambil mempertahankan pasangan KV prompt sistem dan query.
  - Skor head yang sudah dihitung tersedia untuk LLaMA3.1-8B dan Qwen2.5-7/14B di `./utils/head_score`.
- Untuk menghitung skor head untuk model lain:
  ```bash
  python -B test.py -m [model_name] -d scbench_qa_eng --save_head_score
  ```
  - Hasil akan disimpan di `./utils/head_score`.
  - Jika menargetkan tugas pemrograman, kami sarankan juga menjalankan perintah dengan `-d scbench_repoqa`. Ini memungkinkan model menggunakan skor head maksimal dari bahasa alami dan bahasa pemrograman, yang meningkatkan performa.
- Skor ini dapat diintegrasikan secara mulus dengan mesin inferensi teroptimasi [DuoAttention](https://github.com/mit-han-lab/duo-attention) dengan mengganti data skor head mereka dengan skor kami.


## Evaluasi
- Untuk menghasilkan respons model dengan rasio kompresi KV dari 0.1 hingga 1.0:
    ```bash
    python -B eval.py -m [model_name] -d [data_name] --kv_type retain --num 100
    ``` 
  - Hasil akan disimpan di `./results/[data_name]`.
  - Dataset yang didukung tercantum di `data/load.py`.
- Untuk menghitung metrik evaluasi dari hasil yang dihasilkan:
  ```bash
  python -B -m results.parse -m [model_name] -d [data_name]
  ```

## Menerapkan ke Model Baru
Untuk mengintegrasikan KVzip ke model baru, Anda perlu memperbarui file-file berikut:
- `attention/attn.py`  
  Modifikasi logika forward pass attention sesuai kebutuhan. Dalam beberapa kasus, pembaruan pada kvcache.py dan score.py juga mungkin diperlukan.
- `model/monkeypatch.py`  
  Implementasi monkey patching spesifik model untuk integrasi.
- `model/template.py`   
  Definisikan prompt sistem dan template format chat model.


## Sitasi
```bibtex
@article{kim2025kvzip,
        title={KVzip: Query-Agnostic KV Cache Compression with Context Reconstruction},
        author={Kim, Jang-Hyun and Kim, Jinuk and Kwon, Sangwoo and Lee, Jae W and Yun, Sangdoo and Song, Hyun Oh},
        journal={arXiv preprint arXiv:2505.23416},
        year={2025}
}
```

## Lisensi
Lisensi MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---