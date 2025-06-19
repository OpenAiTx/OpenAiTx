# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Apa itu .NET Aspire?

.NET Aspire adalah stack siap cloud dengan opini khusus untuk membangun aplikasi terdistribusi yang dapat diamati dan siap produksi. .NET Aspire disediakan melalui kumpulan paket NuGet yang menangani perhatian khusus cloud-native. Aplikasi cloud-native sering terdiri dari bagian-bagian kecil yang saling terhubung atau mikroservis, bukan satu basis kode monolitik. Aplikasi cloud-native umumnya menggunakan banyak layanan, seperti basis data, pesan, dan cache.

.NET Aspire membantu dengan:

[Orkestrasi](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire menyediakan fitur untuk menjalankan dan menghubungkan aplikasi multi-proyek beserta dependensinya.

[Integrasi](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Integrasi .NET Aspire adalah paket NuGet untuk layanan yang sering digunakan, seperti Redis atau Postgres, dengan antarmuka standar yang memastikan dapat terhubung secara konsisten dan mulus dengan aplikasi Anda.

[Alat Bantu](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire hadir dengan template proyek dan pengalaman alat bantu untuk Visual Studio serta dotnet CLI yang membantu Anda membuat dan berinteraksi dengan aplikasi .NET Aspire.

Untuk mempelajari lebih lanjut, baca [tinjauan dan dokumentasi lengkap .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Contoh tersedia di [repositori contoh .NET Aspire](https://github.com/dotnet/aspire-samples). Anda dapat menemukan [contoh eShop di sini](https://github.com/dotnet/eshop) dan [versi Azure di sini](https://github.com/Azure-Samples/eShopOnAzure).

## Apa yang ada di repo ini?

.NET Aspire application host, dashboard, infrastruktur penemuan layanan, dan semua integrasi .NET Aspire. Repo ini juga berisi template proyek.

## Menggunakan build harian terbaru

Ikuti petunjuk di [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) untuk mulai menggunakan .NET Aspire dengan build harian terbaru.

## Bagaimana saya dapat berkontribusi?

Kami menyambut kontribusi! Banyak orang di seluruh dunia telah membantu membuat .NET menjadi lebih baik.

Ikuti petunjuk di [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) untuk bekerja dengan kode di repositori ini.

## Melaporkan masalah keamanan dan bug keamanan

Masalah dan bug keamanan harus dilaporkan secara pribadi, melalui email, ke Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Anda akan menerima respons dalam waktu 24 jam. Jika karena suatu alasan Anda tidak menerima respons, mohon lakukan tindak lanjut melalui email untuk memastikan kami menerima pesan awal Anda. Informasi lebih lanjut, termasuk kunci PGP MSRC, dapat ditemukan di [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Anda juga dapat menemukan petunjuk ini di [dokumen Keamanan](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) repo ini.

Lihat juga info tentang [Microsoft .NET Core dan ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Catatan tentang container yang digunakan oleh integrasi resource dan klien .NET Aspire

Tim .NET tidak dapat mengevaluasi container pihak ketiga yang mendasari dan yang kami dukung API-nya, untuk memastikan kecocokan dengan kebutuhan spesifik pelanggan.

Anda harus mengevaluasi container apapun yang Anda pilih untuk dikomposisi dan diotomasi dengan Aspire untuk memastikan mereka memenuhi kebutuhan Anda, perusahaan atau pemerintah Anda terkait keamanan, keselamatan, regulasi kriptografi, dan standar regulasi atau korporasi lain yang mungkin berlaku untuk penggunaan container tersebut.

## .NET Foundation

.NET Aspire adalah proyek [.NET Foundation](https://www.dotnetfoundation.org/projects).

Ada banyak proyek terkait .NET di GitHub.

* [Repositori utama .NET](https://github.com/Microsoft/dotnet) - tautan ke ratusan proyek .NET, dari Microsoft dan komunitas.
* [Beranda ASP.NET Core](https://docs.microsoft.com/aspnet/core) - tempat terbaik untuk mulai belajar tentang ASP.NET Core.

Proyek ini telah mengadopsi kode etik yang didefinisikan oleh [Contributor Covenant](https://contributor-covenant.org) untuk memperjelas perilaku yang diharapkan dalam komunitas kami. Untuk informasi lebih lanjut, lihat [Kode Etik .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Lisensi

Kode dalam repo ini dilisensikan di bawah lisensi [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---