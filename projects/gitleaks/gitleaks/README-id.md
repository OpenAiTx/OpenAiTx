# Gitleaks

```
┌─○───┐
│ │╲  │
│ │ ○ │
│ ○ ░ │
└─░───┘
```

[license]: https://raw.githubusercontent.com/gitleaks/gitleaks/master/LICENSE
[badge-license]: https://img.shields.io/github/license/gitleaks/gitleaks.svg
[go-docs-badge]: https://pkg.go.dev/badge/github.com/gitleaks/gitleaks/v8?status
[go-docs]: https://pkg.go.dev/github.com/zricethezav/gitleaks/v8
[badge-build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml/badge.svg
[build]: https://github.com/gitleaks/gitleaks/actions/workflows/test.yml
[go-report-card-badge]: https://goreportcard.com/badge/github.com/gitleaks/gitleaks/v8
[go-report-card]: https://goreportcard.com/report/github.com/gitleaks/gitleaks/v8
[dockerhub]: https://hub.docker.com/r/zricethezav/gitleaks
[dockerhub-badge]: https://img.shields.io/docker/pulls/zricethezav/gitleaks.svg
[gitleaks-action]: https://github.com/gitleaks/gitleaks-action
[gitleaks-badge]: https://img.shields.io/badge/protected%20by-gitleaks-blue
[gitleaks-playground-badge]: https://img.shields.io/badge/gitleaks%20-playground-blue
[gitleaks-playground]: https://gitleaks.io/playground


[![GitHub Action Test][badge-build]][build]
[![Docker Hub][dockerhub-badge]][dockerhub]
[![Gitleaks Playground][gitleaks-playground-badge]][gitleaks-playground]
[![Gitleaks Action][gitleaks-badge]][gitleaks-action]
[![GoDoc][go-docs-badge]][go-docs]
[![GoReportCard][go-report-card-badge]][go-report-card]
[![License][badge-license]][license]


### Bergabung dengan Discord kami! [![Discord](https://img.shields.io/discord/1102689410522284044.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/8Hzbrnkr7E)

Gitleaks adalah alat untuk **mendeteksi** secret seperti password, API key, dan token di repo git, file, dan apa pun yang ingin Anda periksa melalui `stdin`. Jika Anda ingin mengetahui lebih lanjut tentang cara kerja mesin deteksi, cek blog ini: [Regex is (almost) all you need](https://lookingatcomputer.substack.com/p/regex-is-almost-all-you-need).


```
➜  ~/code(master) gitleaks git -v

    ○
    │╲
    │ ○
    ○ ░
    ░    gitleaks


Finding:     "export BUNDLE_ENTERPRISE__CONTRIBSYS__COM=cafebabe:deadbeef",
Secret:      cafebabe:deadbeef
RuleID:      sidekiq-secret
Entropy:     2.609850
File:        cmd/generate/config/rules/sidekiq.go
Line:        23
Commit:      cd5226711335c68be1e720b318b7bc3135a30eb2
Author:      John
Email:       john@users.noreply.github.com
Date:        2022-08-03T12:31:40Z
Fingerprint: cd5226711335c68be1e720b318b7bc3135a30eb2:cmd/generate/config/rules/sidekiq.go:sidekiq-secret:23
```

## Memulai

Gitleaks dapat diinstal menggunakan Homebrew, Docker, atau Go. Gitleaks juga tersedia dalam bentuk binary untuk banyak platform dan jenis OS populer pada [halaman rilis](https://github.com/gitleaks/gitleaks/releases). Selain itu, Gitleaks dapat diimplementasikan sebagai pre-commit hook langsung di repo Anda atau sebagai GitHub action menggunakan [Gitleaks-Action](https://github.com/gitleaks/gitleaks-action).

### Instalasi

```bash
# MacOS
brew install gitleaks

# Docker (DockerHub)
docker pull zricethezav/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path zricethezav/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Docker (ghcr.io)
docker pull ghcr.io/gitleaks/gitleaks:latest
docker run -v ${path_to_host_folder_to_scan}:/path ghcr.io/gitleaks/gitleaks:latest [COMMAND] [OPTIONS] [SOURCE_PATH]

# Dari Source (pastikan `go` sudah terinstal)
git clone https://github.com/gitleaks/gitleaks.git
cd gitleaks
make build
```

### GitHub Action

Cek [Gitleaks GitHub Action](https://github.com/gitleaks/gitleaks-action) resmi

```
name: gitleaks
on: [pull_request, push, workflow_dispatch]
jobs:
  scan:
    name: gitleaks
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v3
        with:
          fetch-depth: 0
      - uses: gitleaks/gitleaks-action@v2
        env:
          GITHUB_TOKEN: ${{ secrets.GITHUB_TOKEN }}
          GITLEAKS_LICENSE: ${{ secrets.GITLEAKS_LICENSE}} # Hanya dibutuhkan untuk Organisasi, bukan akun personal.
```

### Pre-Commit

1. Instal pre-commit dari https://pre-commit.com/#install
2. Buat file `.pre-commit-config.yaml` di root repository Anda dengan konten berikut:

   ```
   repos:
     - repo: https://github.com/gitleaks/gitleaks
       rev: v8.24.2
       hooks:
         - id: gitleaks
   ```

   untuk [eksekusi native gitleaks](https://github.com/gitleaks/gitleaks/releases) atau gunakan [`gitleaks-docker` pre-commit ID](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.pre-commit-hooks.yaml) untuk menjalankan gitleaks menggunakan [gambar Docker resmi](#docker)

3. Auto-update konfigurasi ke versi repo terbaru dengan menjalankan `pre-commit autoupdate`
4. Instal dengan `pre-commit install`
5. Sekarang Anda sudah siap!

```
➜ git commit -m "this commit contains a secret"
Detect hardcoded secrets.................................................Failed
```

Catatan: untuk menonaktifkan gitleaks pre-commit hook Anda dapat menambahkan `SKIP=gitleaks` sebelum perintah commit
dan gitleaks tidak akan dijalankan

```
➜ SKIP=gitleaks git commit -m "skip gitleaks check"
Detect hardcoded secrets................................................Skipped
```

## Penggunaan

```
Usage:
  gitleaks [command]

Available Commands:
  dir         scan directories or files for secrets
  git         scan git repositories for secrets
  help        Help about any command
  stdin       detect secrets from stdin
  version     display gitleaks version

Flags:
  -b, --baseline-path string          path to baseline with issues that can be ignored
  -c, --config string                 config file path
                                      order of precedence:
                                      1. --config/-c
                                      2. env var GITLEAKS_CONFIG
                                      3. env var GITLEAKS_CONFIG_TOML with the file content
                                      4. (target path)/.gitleaks.toml
                                      If none of the four options are used, then gitleaks will use the default config
      --diagnostics string            enable diagnostics (comma-separated list: cpu,mem,trace). cpu=CPU profiling, mem=memory profiling, trace=execution tracing
      --diagnostics-dir string        directory to store diagnostics output files (defaults to current directory)
      --enable-rule strings           only enable specific rules by id
      --exit-code int                 exit code when leaks have been encountered (default 1)
  -i, --gitleaks-ignore-path string   path to .gitleaksignore file or folder containing one (default ".")
  -h, --help                          help for gitleaks
      --ignore-gitleaks-allow         ignore gitleaks:allow comments
  -l, --log-level string              log level (trace, debug, info, warn, error, fatal) (default "info")
      --max-decode-depth int          allow recursive decoding up to this depth (default "0", no decoding is done)
      --max-archive-depth int         allow scanning into nested archives up to this depth (default "0", no archive traversal is done)
      --max-target-megabytes int      files larger than this will be skipped
      --no-banner                     suppress banner
      --no-color                      turn off color for verbose output
      --redact uint[=100]             redact secrets from logs and stdout. To redact only parts of the secret just apply a percent value from 0..100. For example --redact=20 (default 100%)
  -f, --report-format string          output format (json, csv, junit, sarif, template)
  -r, --report-path string            report file
      --report-template string        template file used to generate the report (implies --report-format=template)
  -v, --verbose                       show verbose output from scan
      --version                       version for gitleaks

Use "gitleaks [command] --help" for more information about a command.
```

### Perintah

⚠️ v8.19.0 memperkenalkan perubahan yang menghapus `detect` dan `protect`. Perintah tersebut masih tersedia tetapi
disembunyikan dalam menu `--help`. Lihat [gist ini](https://gist.github.com/zricethezav/b325bb93ebf41b9c0b0507acf12810d2) untuk konversi perintah dengan mudah.
Jika Anda menemukan v8.19.0 menyebabkan perintah lama (`detect`/`protect`) rusak, silakan buat issue.

Ada tiga mode pemindaian: `git`, `dir`, dan `stdin`.

#### Git

Perintah `git` memungkinkan Anda memindai repo git lokal. Di balik layar, gitleaks menggunakan perintah `git log -p` untuk memindai patch.
Anda dapat mengonfigurasi perilaku `git log -p` dengan opsi `log-opts`.
Sebagai contoh, jika Anda ingin menjalankan gitleaks pada rentang commit, Anda dapat menggunakan
perintah: `gitleaks git -v --log-opts="--all commitA..commitB" path_to_repo`. Lihat dokumentasi [git log](https://git-scm.com/docs/git-log) untuk info lebih lanjut.
Jika tidak ada target yang ditentukan sebagai argumen posisi, maka gitleaks akan mencoba memindai direktori kerja saat ini sebagai repo git.
#### Dir

Perintah `dir` (alias termasuk `files`, `directory`) memungkinkan Anda memindai direktori dan file. Contoh: `gitleaks dir -v path_to_directory_or_file`.
Jika tidak ada target yang ditentukan sebagai argumen posisi, maka gitleaks akan memindai direktori kerja saat ini.

#### Stdin

Anda juga dapat melakukan streaming data ke gitleaks dengan perintah `stdin`. Contoh: `cat some_file | gitleaks -v stdin`

### Membuat baseline

Saat memindai repositori besar atau repositori dengan riwayat panjang, akan lebih mudah menggunakan baseline. Saat menggunakan baseline,
gitleaks akan mengabaikan temuan lama apa pun yang ada di baseline. Baseline dapat berupa laporan gitleaks apa saja. Untuk membuat laporan gitleaks, jalankan gitleaks dengan parameter `--report-path`.

```
gitleaks git --report-path gitleaks-report.json # Ini akan menyimpan laporan dalam file bernama gitleaks-report.json
```

Setelah baseline dibuat, baseline tersebut dapat diterapkan saat menjalankan perintah detect kembali:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Setelah menjalankan perintah detect dengan parameter --baseline-path, output laporan (findings.json) hanya akan berisi isu baru.

## Pre-Commit hook

Anda dapat menjalankan Gitleaks sebagai pre-commit hook dengan menyalin skrip contoh `pre-commit.py` ke dalam
direktori `.git/hooks/` Anda.

## Memuat Konfigurasi

Urutan prioritas adalah:

1. Opsi `--config/-c`:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Variabel lingkungan `GITLEAKS_CONFIG` dengan path file:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Variabel lingkungan `GITLEAKS_CONFIG_TOML` dengan isi file:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. File `.gitleaks.toml` di dalam path target:
      ```bash
      gitleaks git .
      ```

Jika tidak ada satu pun dari empat opsi yang digunakan, maka gitleaks akan menggunakan konfigurasi default.

## Konfigurasi

Gitleaks menawarkan format konfigurasi yang dapat Anda ikuti untuk menulis aturan deteksi secret Anda sendiri:

```toml
# Judul untuk file konfigurasi gitleaks.
title = "Konfigurasi Gitleaks Kustom"

# Pada dasarnya Anda memiliki dua opsi untuk konfigurasi kustom Anda:
#
# 1. mendefinisikan konfigurasi sendiri, aturan default tidak berlaku
#
#    gunakan misalnya, konfigurasi default sebagai titik awal:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. memperluas konfigurasi, aturan akan ditimpa atau diperluas
#
#    Saat Anda memperluas konfigurasi, aturan yang diperluas akan memiliki prioritas dibanding aturan
#    default. Artinya, jika ada aturan duplikat di konfigurasi yang diperluas
#    dan konfigurasi default, aturan yang diperluas atau atributnya akan menimpa aturan default.
#    Hal lain yang perlu diketahui dalam memperluas konfigurasi adalah Anda dapat merangkai
#    beberapa file konfigurasi hingga kedalaman 2. Array Allowlist akan digabungkan dan dapat berisi duplikat.

# useDefault dan path TIDAK DAPAT digunakan secara bersamaan. Pilih salah satu.
[extend]
# useDefault akan memperluas konfigurasi gitleaks default yang tertanam di binary
# versi terbaru dapat ditemukan di:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# atau Anda dapat menyediakan path ke konfigurasi yang ingin diperluas.
# Path bersifat relatif terhadap lokasi gitleaks dijalankan,
# bukan lokasi base config.
# path = "common_config.toml"
# Jika ada aturan yang tidak ingin Anda warisi, bisa ditentukan di sini.
disabledRules = [ "generic-api-key"]

# Array dari tabel yang berisi informasi yang mendefinisikan instruksi
# cara mendeteksi secret
[[rules]]
# Pengenal unik untuk aturan ini
id = "awesome-rule-1"

# Deskripsi singkat yang mudah dibaca manusia untuk aturan ini.
description = "awesome rule 1"

# Ekspresi regular Golang yang digunakan untuk mendeteksi secret. Perhatikan bahwa engine regex Golang
# tidak mendukung lookaheads.
regex = '''one-go-style-regex-for-this-rule'''

# Int yang digunakan untuk mengekstrak secret dari hasil regex dan digunakan sebagai grup yang akan
# dicek entropinya jika `entropy` diatur.
secretGroup = 3

# Float yang merepresentasikan minimum entropi shannon yang harus dimiliki grup regex agar dianggap sebagai secret.
entropy = 3.5

# Ekspresi regular Golang yang digunakan untuk mencocokkan path. Ini dapat digunakan sebagai aturan mandiri atau dapat digunakan
# bersamaan dengan entri `regex` yang valid.
path = '''a-file-path-regex'''

# Keyword digunakan untuk filtering pemeriksaan pra-regex. Aturan yang berisi
# keyword akan melakukan pemeriksaan perbandingan string cepat untuk memastikan
# keyword ada dalam konten yang dipindai. Idealnya nilai-nilai ini sebaiknya
# menjadi bagian dari identifier atau string unik spesifik untuk regex aturan
# (diperkenalkan di v8.6.0)
keywords = [
  "auth",
  "password",
  "token",
]

# Array string yang digunakan untuk tujuan metadata dan pelaporan.
tags = ["tag","another tag"]

    # ⚠️ Pada v8.21.0 `[rules.allowlist]` digantikan dengan `[[rules.allowlists]]`.
    # Perubahan ini bersifat backward-compatible: penggunaan `[rules.allowlist]` masih tetap berfungsi.
    #
    # Anda dapat mendefinisikan beberapa allowlists untuk sebuah aturan guna mengurangi false positive.
    # Temuan akan diabaikan jika _ADA_ `[[rules.allowlists]]` yang cocok.
    [[rules.allowlists]]
    description = "abaikan commit A"
    # Jika beberapa kriteria didefinisikan, kondisi default adalah "OR".
    # contoh, ini dapat mencocokkan pada |commits| ATAU |paths| ATAU |stopwords|.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # catatan: stopwords menargetkan secret yang diekstrak, bukan seluruh hasil regex
    # seperti yang dilakukan 'regexes'. (stopwords diperkenalkan di 8.8.0)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # Kondisi "AND" dapat digunakan untuk memastikan semua kriteria cocok.
    # contoh, ini cocok jika |regexes| DAN |paths| terpenuhi.
    condition = "AND"
    # catatan: |regexes| secara default akan memeriksa _Secret_ pada temuan.
    # Nilai yang dapat diterima untuk |regexTarget| adalah "secret" (default), "match", dan "line".
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Anda dapat memperluas aturan tertentu dari konfigurasi default. contoh, gitlab-pat
# jika Anda telah mendefinisikan prefix token kustom pada instance GitLab Anda
[[rules]]
id = "gitlab-pat"
# semua atribut lain dari aturan default diwarisi

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ Pada v8.25.0 `[allowlist]` digantikan dengan `[[allowlists]]`.
#
# Global allowlists memiliki urutan prioritas lebih tinggi daripada allowlists khusus aturan.
# Jika sebuah commit yang terdaftar di field `commits` di bawah ini ditemukan maka commit tersebut akan dilewati dan tidak
# ada secret yang akan dideteksi untuk commit tersebut. Logika yang sama berlaku untuk regexes dan paths.
[[allowlists]]
description = "daftar allow global"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# catatan: (global) regexTarget secara default akan memeriksa _Secret_ pada temuan.
# Nilai yang dapat diterima untuk regexTarget adalah "match" dan "line"
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# catatan: stopwords menargetkan secret yang diekstrak, bukan seluruh hasil regex
# seperti yang dilakukan 'regexes'. (stopwords diperkenalkan di 8.8.0)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ Pada v8.25.0, `[[allowlists]]` memiliki field baru bernama |targetRules|.
#
# Common allowlists dapat didefinisikan sekali dan ditugaskan ke beberapa aturan menggunakan |targetRules|.
# Ini hanya akan dijalankan pada aturan yang ditentukan, tidak secara global.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Aset uji kami memicu false-positive pada beberapa aturan."
paths = ['''tests/expected/._\.json$''']
```

Lihat [konfigurasi default gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) untuk contoh atau ikuti [panduan kontribusi](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) jika Anda ingin berkontribusi pada konfigurasi default. Selain itu, Anda dapat membaca [posting blog gitleaks ini](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) yang membahas pengaturan konfigurasi tingkat lanjut.

### Konfigurasi Tambahan

#### gitleaks:allow

Jika Anda dengan sengaja melakukan commit secret pengujian yang akan terdeteksi oleh gitleaks, Anda dapat menambahkan komentar `gitleaks:allow` pada baris tersebut yang akan menginstruksikan gitleaks untuk mengabaikan secret itu. Contoh:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Anda dapat mengabaikan temuan tertentu dengan membuat file `.gitleaksignore` di root repositori Anda. Pada rilis v8.10.0 Gitleaks menambahkan nilai `Fingerprint` pada laporan Gitleaks. Setiap kebocoran, atau temuan, memiliki Fingerprint yang mengidentifikasi secret secara unik. Tambahkan fingerprint ini ke file `.gitleaksignore` untuk mengabaikan secret spesifik tersebut. Lihat [.gitleaksignore Gitleaks](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) untuk contoh. Catatan: fitur ini masih eksperimental dan dapat berubah di masa depan.

#### Decoding

Kadang-kadang secret dienkode dengan cara yang membuatnya sulit ditemukan hanya dengan regex. Sekarang Anda dapat menginstruksikan gitleaks untuk secara otomatis menemukan dan mendekode teks yang dienkode. Flag `--max-decode-depth` mengaktifkan fitur ini (nilai default "0" berarti fitur ini dinonaktifkan secara default).

Decoding rekursif didukung karena teks yang telah didekode juga dapat berisi teks yang masih dienkode. Flag `--max-decode-depth` mengatur batas rekursi. Rekursi akan berhenti ketika tidak ada segmen baru dari teks yang dienkode untuk didekode, jadi menetapkan nilai kedalaman maksimum yang sangat tinggi tidak berarti akan melakukan sebanyak itu, hanya akan sebanyak yang dibutuhkan untuk mendekode teks. Secara keseluruhan, decoding hanya sedikit meningkatkan waktu pemindaian.

Temuan untuk teks yang dienkode berbeda dari temuan normal dalam hal berikut:

- Lokasi menunjukkan batas dari teks yang dienkode
  - Jika aturan cocok di luar teks yang dienkode, batas akan disesuaikan untuk mencakupnya juga
- Match dan secret berisi nilai yang telah didekode
- Dua tag ditambahkan `decoded:<encoding>` dan `decode-depth:<depth>`

Encoding yang saat ini didukung:

- **percent** - Nilai ASCII printable yang di-encode dengan persen
- **hex** - Nilai ASCII printable yang di-encode hex ≥ 32 karakter
- **base64** - Nilai ASCII printable yang di-encode base64 ≥ 16 karakter

#### Pemindaian Arsip

Terkadang secret dikemas dalam file arsip seperti file zip atau tarball, sehingga sulit ditemukan. Sekarang Anda dapat menginstruksikan gitleaks untuk secara otomatis mengekstrak dan memindai isi arsip. Flag `--max-archive-depth` mengaktifkan fitur ini untuk tipe pemindaian `dir` maupun `git`. Nilai default "0" berarti fitur ini dinonaktifkan secara default.

Pemindaian rekursif didukung karena arsip dapat berisi arsip lain di dalamnya. Flag `--max-archive-depth` mengatur batas rekursi. Rekursi berhenti ketika tidak ada arsip baru yang diekstrak, jadi menetapkan nilai kedalaman maksimum yang sangat tinggi hanya menetapkan potensi untuk sedalam itu. Akan tetapi, pemindaian hanya akan sedalam yang dibutuhkan.

Temuan untuk secret yang ditemukan di dalam arsip akan menyertakan path ke file di dalam arsip. Path dalam ditandai dengan `!`.

Contoh temuan (dipendekkan):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Ini berarti ada secret terdeteksi pada baris 4 di `files/.env.prod.` yang berada di dalam `archives/files.tar` yang berada di dalam `testdata/archives/nested.tar.gz`.

Format yang saat ini didukung:

[Format kompresi](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) dan [format arsip](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats) yang didukung oleh [paket archives mholt](https://github.com/mholt/archives) didukung.

#### Pelaporan

Gitleaks memiliki dukungan bawaan untuk beberapa format laporan: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml), dan [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Jika tidak ada format ini yang sesuai kebutuhan Anda, Anda dapat membuat format laporan sendiri dengan [file Go `text/template` .tmpl](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) dan flag `--report-template`. Template dapat menggunakan [fitur tambahan dari pustaka template `Masterminds/sprig`](https://masterminds.github.io/sprig/).

Sebagai contoh, template berikut menghasilkan output JSON kustom:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Penggunaan:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsor

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorship" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Kode Exit

Anda selalu dapat mengatur kode keluar ketika kebocoran terdeteksi menggunakan flag --exit-code. Kode keluar default di bawah ini:

```
0 - tidak ada kebocoran
1 - ditemukan kebocoran atau error
126 - flag tidak dikenal
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---