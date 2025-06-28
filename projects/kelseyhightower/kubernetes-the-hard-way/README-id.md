# Kubernetes The Hard Way

Tutorial ini membimbing Anda dalam menyiapkan Kubernetes dengan cara yang sulit. Panduan ini bukan untuk mereka yang mencari alat otomatisasi penuh untuk membangun klaster Kubernetes. Kubernetes The Hard Way dioptimalkan untuk pembelajaran, yang berarti mengambil jalur panjang untuk memastikan Anda memahami setiap tugas yang diperlukan untuk melakukan bootstrap klaster Kubernetes.

> Hasil dari tutorial ini sebaiknya tidak dianggap siap untuk produksi, dan mungkin hanya mendapat dukungan terbatas dari komunitas, tetapi jangan biarkan hal itu menghentikan Anda untuk belajar!

## Hak Cipta

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Lisensi Creative Commons" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />Karya ini dilisensikan di bawah <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Lisensi Creative Commons Atribusi-NonKomersial-BerbagiSerupa 4.0 Internasional</a>.


## Target Pembaca

Target pembaca untuk tutorial ini adalah seseorang yang ingin memahami dasar-dasar Kubernetes dan bagaimana komponen inti saling terhubung.

## Detail Klaster

Kubernetes The Hard Way membimbing Anda melalui proses bootstrap klaster Kubernetes dasar dengan semua komponen control plane berjalan pada satu node, dan dua node worker, yang cukup untuk mempelajari konsep-konsep inti.

Versi komponen:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Lab

Tutorial ini memerlukan empat (4) mesin virtual atau fisik berbasis ARM64 atau AMD64 yang terhubung ke jaringan yang sama.

* [Prasyarat](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Menyiapkan Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Penyediaan Sumber Daya Komputasi](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Penyediaan CA dan Pembuatan Sertifikat TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Pembuatan File Konfigurasi Kubernetes untuk Autentikasi](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Pembuatan Konfigurasi dan Kunci Enkripsi Data](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Bootstrap Klaster etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Bootstrap Control Plane Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Bootstrap Node Worker Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Konfigurasi kubectl untuk Akses Jarak Jauh](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Penyediaan Rute Jaringan Pod](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Smoke Test](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Pembersihan](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---