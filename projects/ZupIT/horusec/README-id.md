<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Daftar Isi**
### 1. [**Tentang**](#about)
### 2. [**Mulai Cepat**](#getting-started)
>#### 2.1.   [**Persyaratan**](#requirements)
>#### 2.2.  [**Instalasi**](#installing-horusec)
### 3. [**Penggunaan**](#usage)
>#### 3.1. [**Penggunaan CLI**](#cli-usage)
>#### 3.2. [**Menggunakan Docker**](#using-docker)
>#### 3.3. [**Versi Lama**](#older-versions)
>#### 3.4. [**Menggunakan Aplikasi Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Menggunakan Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Menggunakan Pipeline**](#using-the-pipeline)
### 4. [**Dokumentasi**](#documentation)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Kontribusi**](#contributing)
### 7. [**Kode Etik**](#code-of-conduct)
### 8. [**Lisensi**](#license)
### 9. [**Komunitas**](#community)



<br>
<br>
<br>

# **Tentang**
Horusec adalah alat open source yang melakukan analisis kode statis untuk mengidentifikasi kelemahan keamanan selama proses pengembangan. Saat ini, bahasa yang didukung untuk analisis adalah C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx. 
Alat ini memiliki opsi untuk mencari kebocoran kunci dan kelemahan keamanan di semua file proyek Anda, serta di riwayat Git. Horusec dapat digunakan oleh pengembang melalui CLI dan oleh tim DevSecOps pada matriks CI/CD. 

Lihat [**Dokumentasi**](https://docs.horusec.io/docs/overview/) kami, di sana Anda akan menemukan daftar lengkap alat dan bahasa yang dianalisis oleh Horusec.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Contoh Output:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Mulai Cepat**

## **Persyaratan**

- Docker

Anda memerlukan Docker terinstal di mesin Anda untuk menjalankan Horusec dengan semua alat yang kami gunakan.
Jika Anda belum memiliki Docker, kami menyediakan [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` untuk menonaktifkan ketergantungan ini, namun Anda juga akan kehilangan sebagian besar kekuatan analisis. 
Kami merekomendasikan penggunaan dengan Docker.

Jika Anda mengaktifkan author commit `-G true`, maka ada juga ketergantungan pada `git`.

## **Instalasi Horusec**
### **Mac atau Linux**
```
make install
```

atau

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Cek Instalasi**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Cek Instalasi**
```bash
./horusec.exe version
```

### **Dan Lainnya**

- Anda dapat menemukan semua binary beserta versinya di [**halaman rilis**](https://github.com/ZupIT/horusec/releases) kami.

- Untuk detail lebih lanjut tentang cara instalasi, silakan lihat [**dokumentasi**](https://docs.horusec.io/docs/cli/installation) 


## **Penggunaan**
### **Penggunaan CLI**
Untuk menggunakan horusec-cli dan memeriksa kerentanan aplikasi, gunakan perintah berikut:
```bash
horusec start -p .
```
> Ketika horusec memulai analisis, ia akan membuat folder bernama **`.horusec`**. Folder ini berfungsi agar kode Anda tidak berubah. Kami merekomendasikan untuk menambahkan baris **`.horusec`** ke file **`.gitignore`** Anda agar folder ini tidak perlu dikirim ke server git Anda.

### **Menggunakan Docker**
Anda dapat menggunakan Horusec melalui image docker **`horuszup/horusec-cli:latest`**.

Jalankan perintah berikut untuk melakukannya:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Kami membuat volume yang berisi proyek `-v $(pwd):/src`.

Dengan image docker, proyek dapat ditemukan di dua path yang berbeda.

Flag `-p` akan merepresentasikan path proyek di dalam container, pada contoh ini `/src`.
Flag `-P` akan merepresentasikan path proyek di luar container, dalam contoh ini adalah `$(pwd)`,
dan juga diperlukan untuk melewatkan path proyek saat mount volume `-v $(pwd):/src`.

### **Versi Lama**

Horusec versi v1 masih tersedia.

**PERINGATAN:** Endpoint dengan v1 akan dihentikan, silakan upgrade CLI Anda ke v2. Lihat detail lebih lanjut di [**dokumentasi**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac atau Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Binary lama dapat ditemukan di endpoint ini, termasuk versi v1 terbaru **`v1.10.3`**. 
- Mulai v2, binary tidak lagi didistribusikan melalui endpoint ini, Anda dapat menemukannya di [**halaman rilis**](https://github.com/ZupIT/horusec/releases).

### **Menggunakan Aplikasi Horusec-Web**
Kelola kerentanan Anda melalui antarmuka web kami. Anda dapat memiliki dashboard metrik terkait kerentanan Anda, kontrol false positive, token otorisasi, update kerentanan, dan banyak lagi.
Lihat bagian [**aplikasi web**](https://github.com/ZupIT/horusec-platform) untuk membaca selengkapnya.

Lihat contoh di bawah ini, ini mengirimkan analisis ke layanan web Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Lihat [**tutorial cara membuat token otorisasi melalui Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**PERINGATAN:** Layanan web kami telah dipindahkan ke [**repo baru**](https://github.com/ZupIT/horusec-platform). Anda harus upgrade ke v2, lihat [**cara migrasi dari v1 ke v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Menggunakan Visual Studio Code**
Anda dapat menganalisis proyek Anda menggunakan ekstensi Visual Studio Code dari Horusec.
Untuk informasi lebih lanjut, [**lihat dokumentasi**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Menggunakan Pipeline**
Anda dapat melakukan analisis pada proyek Anda sebelum melakukan deployment di lingkungan Anda untuk memastikan keamanan maksimal di organisasi Anda.
Untuk informasi lebih lanjut, [**lihat dokumentasi**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Fitur**
Lihat di bawah ini: 
- Menganalisis secara simultan 18 bahasa dengan 20 alat keamanan berbeda untuk meningkatkan akurasi;
- Mencari riwayat git Anda untuk secrets dan konten lain yang terekspos;
- Analisis Anda dapat dikonfigurasi sepenuhnya, [**lihat semua resource CLI yang tersedia**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Dokumentasi**
Anda dapat menemukan dokumentasi Horusec di [**website**](https://docs.horusec.io/docs/overview/) kami.

## **Roadmap**
Kami memiliki [**roadmap proyek**](https://raw.githubusercontent.com/ZupIT/horusec/main/ROADMAP.md), Anda dapat berkontribusi bersama kami!

Horusec memiliki repositori lain, silakan cek:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Kontribusi**

Jangan ragu untuk menggunakan, merekomendasikan perbaikan, atau berkontribusi pada implementasi baru.

Lihat [**panduan kontribusi**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) kami untuk mempelajari tentang proses pengembangan kami, cara mengusulkan perbaikan bug dan peningkatan.

### **Developer Certificate of Origin - DCO**

Ini adalah lapisan keamanan untuk proyek dan para pengembang. Ini bersifat wajib.

Ikuti salah satu dari dua metode berikut untuk menambahkan DCO ke commit Anda:

**1. Command line**  
Ikuti langkah-langkah berikut:  
**Langkah 1:** Konfigurasikan lingkungan git lokal Anda dengan menambahkan nama dan email yang sama seperti yang dikonfigurasi di akun GitHub Anda. Ini membantu untuk menandatangani commit secara manual selama review dan saran.

```
git config --global user.name “Nama”
git config --global user.email “email@domain.com.br”
```
**Langkah 2:** Tambahkan baris Signed-off-by dengan flag `'-s'` pada perintah git commit:

```
$ git commit -s -m "Ini adalah pesan commit saya"
```
**2. Situs web GitHub**

Anda juga dapat menandatangani commit Anda secara manual selama review dan saran di GitHub, ikuti langkah-langkah di bawah ini:

**Langkah 1:** Saat kotak commit changes terbuka, ketik atau tempel tanda tangan Anda secara manual di kotak komentar, lihat contohnya:

```
Signed-off-by: Nama < alamat e-mail >
```

Untuk metode ini, nama dan email Anda harus sama seperti yang terdaftar di akun GitHub Anda.

## **Kode Etik**
Silakan ikuti [**Kode Etik**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) dalam setiap interaksi Anda dengan proyek kami.

## **Lisensi**
[**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Komunitas**

Jangan ragu untuk menghubungi kami di:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Jika Anda memiliki pertanyaan atau ide, mari berdiskusi di [**Forum Open Source Zup**](https://forum.zup.com.br).


Proyek ini ada berkat semua kontributor. Kalian luar biasa! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---