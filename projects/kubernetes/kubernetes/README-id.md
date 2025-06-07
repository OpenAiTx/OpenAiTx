# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes, juga dikenal sebagai K8s, adalah sistem open source untuk mengelola [aplikasi terkontainerisasi]
di berbagai host. Sistem ini menyediakan mekanisme dasar untuk deployment, pemeliharaan,
dan penskalaan aplikasi.

Kubernetes dibangun berdasarkan pengalaman selama satu setengah dekade di Google menjalankan
beban kerja produksi dalam skala besar menggunakan sistem yang disebut [Borg],
dikombinasikan dengan ide dan praktik terbaik dari komunitas.

Kubernetes dihosting oleh Cloud Native Computing Foundation ([CNCF]).
Jika perusahaan Anda ingin membantu membentuk evolusi
teknologi yang dikemas dalam kontainer, dijadwalkan secara dinamis,
dan berorientasi pada microservices, pertimbangkan untuk bergabung dengan CNCF.
Untuk detail tentang siapa saja yang terlibat dan bagaimana peran Kubernetes,
baca [pengumuman] CNCF.

----

## Untuk mulai menggunakan K8s

Lihat dokumentasi kami di [kubernetes.io].

Ikuti kursus gratis tentang [Microservices Skala Besar dengan Kubernetes].

Untuk menggunakan kode Kubernetes sebagai library di aplikasi lain, lihat [daftar komponen yang telah dipublikasikan](https://git.k8s.io/kubernetes/staging/README.md).
Penggunaan modul `k8s.io/kubernetes` atau paket `k8s.io/kubernetes/...` sebagai library tidak didukung.

## Untuk mulai mengembangkan K8s

[Repositori komunitas] menyimpan semua informasi tentang
membangun Kubernetes dari sumber, cara berkontribusi kode
dan dokumentasi, kontak terkait apa, dan lain-lain.

Jika Anda ingin langsung membangun Kubernetes, ada dua opsi:

##### Anda memiliki [Lingkungan Go] yang berfungsi.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### Anda memiliki [Lingkungan Docker] yang berfungsi.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

Untuk penjelasan lengkap, kunjungi [dokumentasi pengembang].

## Dukungan

Jika Anda membutuhkan dukungan, mulailah dengan [panduan pemecahan masalah],
dan ikuti proses yang telah kami jelaskan.

Namun demikian, jika Anda memiliki pertanyaan, hubungi kami
[dengan berbagai cara][komunikasi].

[pengumuman]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[komunikasi]: https://git.k8s.io/community/communication
[repositori komunitas]: https://git.k8s.io/community
[aplikasi terkontainerisasi]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[dokumentasi pengembang]: https://git.k8s.io/community/contributors/devel#readme
[Lingkungan Docker]: https://docs.docker.com/engine
[Lingkungan Go]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Microservices Skala Besar dengan Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[panduan pemecahan masalah]: https://kubernetes.io/docs/tasks/debug/

## Pertemuan Komunitas

[Kalender](https://www.kubernetes.dev/resources/calendar/) memiliki daftar semua pertemuan dalam komunitas Kubernetes di satu lokasi.

## Adopter

Situs web [Studi Kasus Pengguna](https://kubernetes.io/case-studies/) berisi studi kasus nyata dari organisasi di berbagai industri yang melakukan deployment/migrasi ke Kubernetes.

## Tata Kelola

Proyek Kubernetes diatur oleh kerangka prinsip, nilai, kebijakan, dan proses untuk membantu komunitas dan konstituen kami menuju tujuan bersama.

[Komunitas Kubernetes](https://github.com/kubernetes/community/blob/master/governance.md) adalah titik awal untuk mempelajari bagaimana kami mengorganisasi diri.

[Repositori Steering Kubernetes](https://github.com/kubernetes/steering) digunakan oleh Komite Steering Kubernetes, yang mengawasi tata kelola proyek Kubernetes.

## Roadmap

Repositori [Kubernetes Enhancements](https://github.com/kubernetes/enhancements) menyediakan informasi tentang rilis Kubernetes, serta pelacakan fitur dan backlog.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---