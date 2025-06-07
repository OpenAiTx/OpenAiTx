[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Prediktor Aksesibilitas Sintesis Senyawa Berbasis Deep-learning

Dengan perkembangan teknologi kecerdasan buatan yang berkelanjutan, semakin banyak model generatif berbasis deep-learning digunakan untuk pembuatan molekul. Namun, sebagian besar molekul baru yang dihasilkan oleh model generatif sering kali menghadapi tantangan besar dalam hal aksesibilitas sintesis.

DeepSA diusulkan untuk memprediksi aksesibilitas sintesis senyawa, dan memiliki tingkat enrichment awal yang jauh lebih tinggi dalam membedakan molekul yang sulit disintesis. Hal ini membantu pengguna memilih molekul yang lebih murah untuk disintesis, sehingga mengurangi waktu penemuan dan pengembangan obat. Anda dapat menggunakan DeepSA melalui webserver di https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Persyaratan
Dependensi dapat diinstal menggunakan perintah berikut:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# untuk versi gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Berita 🔔

* 2024-12, karena [AutoGluon berhenti mendukung python versi 3.8](https://github.com/autogluon/autogluon/pull/4512) mulai Oktober 2024. Oleh karena itu, kami telah memperbarui DeepSA untuk menggunakan Python versi 3.12 dan memperbarui skrip pelatihan serta inferensi agar sesuai dengan versi terbaru AutoGluon, terima kasih atas minat Anda pada DeepSA!

* 2023-7, DeepSA_v1.0 telah dirilis, silakan berikan masukan melalui issue!

## Data
Dataset pelatihan dan tes yang diperluas dapat diunduh dengan mudah di https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing

## Penggunaan untuk Peneliti
Jika Anda ingin melatih model Anda sendiri, Anda dapat menjalankannya dari command line,

jalankan:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Jika Anda ingin menggunakan model yang kami sediakan,

jalankan:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Server Online

Kami telah melakukan deploy model yang sudah dilatih pada server khusus, yang tersedia secara publik di https://bailab.siais.shanghaitech.edu.cn/deepsa, agar peneliti biomedis dapat dengan mudah menggunakan DeepSA dalam aktivitas penelitian mereka.

Pengguna dapat mengunggah file SMILES atau csv mereka ke server, dan kemudian dapat dengan cepat memperoleh hasil prediksi.

## <span id="citelink">Sitasi</span>
Jika Anda merasa repository ini berguna dalam penelitian Anda, mohon pertimbangkan untuk mengutip paper kami:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Kontak
Jika Anda memiliki pertanyaan, silakan hubungi Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) atau Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Pull request sangat kami hargai!

## Ucapan Terima Kasih
Kami berterima kasih atas dukungan dari HPC Platform ShanghaiTech University.<br/>
Terima kasih atas perhatian Anda terhadap karya ini.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---