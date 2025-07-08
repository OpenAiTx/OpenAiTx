<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

Repositori ini berisi kode dan data untuk SynLogic, sebuah kerangka kerja sintesis data penalaran logis yang komprehensif, yang menghasilkan data penalaran yang beragam dan dapat diverifikasi dalam skala besar. Karya kami menjawab kesenjangan penting dalam data pelatihan penalaran logis berkualitas tinggi untuk mengembangkan kemampuan penalaran umum pada Large Language Models (LLM).

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## Berita
- **[2025/07/07]** :fire: Kami menyediakan panduan penggunaan data SynLogic untuk pelatihan RL dengan kerangka kerja Verl. Lihat [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) untuk detailnya. 

- **[2025/06/03]** :fire: Model Terlatih Dirilis di Hugging Face:  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: Kami dengan bangga merilis sumber daya untuk makalah "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond"

## 📋 Ikhtisar

**SynLogic** adalah kerangka sintesis data dan dataset komprehensif yang:
- 📊 **Mencakup 35 tugas penalaran logis yang beragam** termasuk Sudoku, Game of 24, Cipher, Arrow Maze, dan lainnya
- 🎯 **Memungkinkan sintesis tingkat kesulitan yang dapat dikontrol** dengan parameter yang dapat disesuaikan untuk setiap tugas
- ✅ **Menyediakan reward yang dapat diverifikasi** melalui verifikasi berbasis aturan untuk pelatihan RL
- 🚀 **Mencapai performa SOTA** di antara dataset open-source, melampaui DeepSeek-R1-Distill-Qwen-32B sebanyak 6 poin pada BBEH

### Fitur Utama
- **Generasi Data Skala Besar**: Sintesis tak terbatas dengan tingkat kesulitan yang dapat dikontrol
- **Cakupan Tugas Komprehensif**: 35 tugas penalaran logis berbeda dengan generator dan verifier khusus
- **Siap untuk RL**: Semua contoh dapat diverifikasi dengan aturan sederhana, sangat ideal untuk reinforcement learning
- **Transfer Lintas Domain**: Generalisasi kuat ke domain matematika dan pemrograman

## 🚀 Mulai Cepat

### Instalasi
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### Menghasilkan Data Contoh (Contoh Arrow Maze)
```bash
# Contoh cepat dengan Arrow Maze
bash games/tasks/arrow_maze/run.sh

# Atau dengan parameter khusus
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### Untuk Pelatihan RL

Kami menyediakan panduan komprehensif untuk menggunakan data SynLogic dalam pelatihan reinforcement learning. Lihat [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) untuk instruksi detail tentang integrasi SynLogic dengan kerangka kerja Verl.

## :rocket: Sumber Daya

### Dataset
| Nama Dataset | Deskripsi | Tautan |
|:------------:|:------------|:----:|
| **SynLogic** | Dataset | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### Model


| Nama Model | Deskripsi | Tautan |
|:-----------|:------------|:----:|
| **SynLogic-7B** | Model 7B yang dilatih pada SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | Model 32B yang dilatih pada SynLogic | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | Model 32B yang dilatih pada campuran data SynLogic, Matematika, dan Pemrograman | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 Pembaruan Mendatang
Kami sedang aktif bekerja untuk memperluas SynLogic dengan lebih banyak tugas penalaran logis.

Ikuti repositori kami untuk pembaruan dan rilis terbaru!

## Sitasi
Mohon sitasi makalah kami jika Anda merasa pekerjaan kami bermanfaat:

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan dan Zhuo Jiang dan Han Ding dan Yongyi Hu dan Chi Zhang dan Yiqi Shi dan Shitong Weng dan Aili Chen dan Shiqi Chen dan Yunan Huang dan Mozhi Zhang dan Pengyu Zhao dan Junjie Yan dan Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---