[![Lisensi](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Cakupan](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler adalah [penjadwal Kubernetes](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/) yang tangguh, efisien, dan skalabel yang mengoptimalkan alokasi sumber daya GPU untuk beban kerja AI dan machine learning.

Dirancang untuk mengelola klaster GPU skala besar, termasuk ribuan node, dan throughput beban kerja yang tinggi, membuat KAI Scheduler ideal untuk lingkungan yang luas dan menuntut.
KAI Scheduler memungkinkan administrator klaster Kubernetes untuk mengalokasikan sumber daya GPU secara dinamis ke beban kerja.

KAI Scheduler mendukung seluruh siklus hidup AI, dari pekerjaan kecil dan interaktif yang membutuhkan sumber daya minimal hingga pelatihan dan inferensi besar, semuanya dalam satu klaster yang sama.
Ini memastikan alokasi sumber daya yang optimal sekaligus menjaga keadilan sumber daya di antara berbagai konsumen.
Dapat berjalan bersamaan dengan penjadwal lain yang terpasang di klaster.

## Fitur Utama
* [Batch Scheduling](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): Memastikan semua pod dalam satu grup dijadwalkan secara bersamaan atau tidak sama sekali.
* Bin Packing & Spread Scheduling: Optimalkan penggunaan node baik dengan meminimalkan fragmentasi (bin-packing) atau meningkatkan resiliensi dan load balancing (spread scheduling).
* [Workload Priority](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): Memprioritaskan beban kerja secara efektif di dalam antrean.
* [Hierarchical Queues](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): Mengelola beban kerja dengan hierarki antrean dua tingkat untuk kontrol organisasi yang fleksibel.
* [Resource distribution](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): Kustomisasi kuota, bobot over-quota, batas, dan prioritas per antrean.
* [Fairness Policies](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Memastikan distribusi sumber daya yang adil menggunakan Dominant Resource Fairness (DRF) dan reclamation sumber daya di seluruh antrean.
* Workload Consolidation: Mengalokasikan ulang beban kerja yang sedang berjalan secara cerdas untuk mengurangi fragmentasi dan meningkatkan utilisasi klaster.
* [Elastic Workloads](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): Menskalakan beban kerja secara dinamis dalam jumlah pod minimum dan maksimum yang telah ditentukan.
* Dynamic Resource Allocation (DRA): Mendukung sumber daya perangkat keras vendor tertentu melalui Kubernetes ResourceClaims (misal, GPU dari NVIDIA atau AMD).
* [GPU Sharing](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): Memungkinkan beberapa beban kerja untuk berbagi satu atau beberapa GPU secara efisien, memaksimalkan pemanfaatan sumber daya.
* Dukungan Cloud & On-premise: Sepenuhnya kompatibel dengan infrastruktur cloud dinamis (termasuk auto-scalers seperti Karpenter) maupun deployment on-premise statis.

## Prasyarat
Sebelum menginstal KAI Scheduler, pastikan Anda memiliki:

- Klaster Kubernetes yang berjalan
- [Helm](https://helm.sh/docs/intro/install) CLI terpasang
- [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) terpasang untuk menjadwalkan beban kerja yang membutuhkan sumber daya GPU

## Instalasi
KAI Scheduler akan diinstal di namespace `kai-scheduler`. Saat mengirimkan beban kerja, pastikan untuk menggunakan namespace khusus.

### Metode Instalasi
KAI Scheduler dapat diinstal:

- **Dari Produksi (Direkomendasikan)**
- **Dari Sumber (Build Sendiri)**

#### Instal dari Produksi
Temukan versi rilis terbaru di halaman [releases](https://github.com/NVIDIA/KAI-Scheduler/releases).
Jalankan perintah berikut setelah mengganti `<VERSION>` dengan versi rilis yang diinginkan:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Build dari Sumber
Ikuti instruksi [di sini](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)

## Quick Start
Untuk mulai menjadwalkan beban kerja dengan KAI Scheduler, silakan lanjutkan ke [Contoh Quick Start](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)

## Roadmap

### Gambaran umum prioritas utama untuk 2025
* Refaktor basis kode untuk meningkatkan netralitas vendor
* Dukungan Scheduling Gates https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Riset integrasi dengan Kueue https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Tambahkan dukungan Topology Aware Scheduling untuk pod-group https://github.com/NVIDIA/KAI-Scheduler/issues/66
* Dukungan Min Run Time per beban kerja
* Dukungan Max Run Time per beban kerja (dengan delayed requeue)
* Tambahkan lebih banyak PriorityClasses sebagai bagian dari instalasi default KAI
* Dukungan JobSet
* Dukungan LWS (LeaderWorkerSet)
* Tambahkan metrik untuk preemption pod dan pod-group
* Pisahkan Priority dan Preemption

### Tujuan jangka panjang
* Dukungan time decay per antrean
* Peningkatan hyper scale
* Dukungan konsolidasi beban kerja inferensi untuk defragmentasi klaster
* Dukungan n-level hierarki antrean
* Rollout beban kerja inferensi secara bertahap (pembaruan revisi baru menggunakan antrean sementara over-quota)

## Komunitas, Diskusi, dan Dukungan

Kami ingin mendengar dari Anda! Berikut cara terbaik untuk terhubung:

### Slack
Bergabunglah dengan [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf) terlebih dahulu dan kunjungi channel [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler).

### Panggilan Komunitas Dua Mingguan  
**Kapan:** Setiap hari Senin bergantian pukul 17:00 CEST  
[Konversikan ke zona waktu Anda](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Tambahkan ke kalender Anda](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Catatan & agenda rapat](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### Mailing List  
Bergabunglah dengan [milis kai-scheduler](https://groups.google.com/g/kai-scheduler) untuk menerima pembaruan tentang pertemuan dua mingguan.

### Masalah Teknis & Permintaan Fitur  
Silakan buka [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) untuk bug, saran fitur, atau bantuan teknis. Ini membantu kami melacak permintaan dan merespons secara efektif.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---