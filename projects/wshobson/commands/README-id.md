
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code Slash Commands

Perintah slash siap produksi untuk [Claude Code](https://docs.anthropic.com/en/docs/claude-code) yang mempercepat pengembangan melalui otomatisasi cerdas.

**52 perintah** yang diorganisasikan sebagai:
- **🤖 Alur Kerja**: Orkestrasi multi-subagen untuk tugas kompleks
- **🔧 Alat**: Utilitas tujuan tunggal untuk operasi spesifik

### 🤝 Memerlukan Claude Code Subagents

Perintah-perintah ini bekerja dengan [Claude Code Subagents](https://github.com/wshobson/agents) untuk kemampuan orkestrasi.

## Instalasi

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Perintah yang Tersedia

- **🤖 Alur Kerja** - Mengorkestrasi beberapa subagen untuk tugas kompleks
- **🔧 Alat** - Perintah tujuan tunggal untuk operasi tertentu

## Penggunaan

Perintah diatur dalam direktori `tools/` dan `workflows/`. Gunakan dengan awalan direktori:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Catatan:** Jika Anda lebih suka menggunakan perintah tanpa prefiks, Anda dapat meratakan direktori:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code secara otomatis menyarankan perintah yang relevan berdasarkan konteks.

## 🤖 Alur Kerja

Orkestrasi multi-subagen untuk tugas kompleks:

### Pengembangan Fitur
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagen backend, frontend, pengujian, dan deployment membangun fitur lengkap
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Beberapa subagen review memberikan analisis kode yang komprehensif
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Menganalisis masalah dan mendelegasikan ke subagen spesialis yang sesuai

### Proses Pengembangan
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Menerapkan alur kerja Git yang efektif dengan strategi branching dan template PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Meningkatkan performa subagen melalui optimasi prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Memodernisasi basis kode lama dengan subagen khusus
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Membuat pipeline ML dengan subagen data dan rekayasa ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Membangun aplikasi lintas platform dengan koordinasi subagen
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Mengotomatiskan CI/CD, monitoring, dan alur kerja deployment

### Alur Kerja Orkestrasi Subagen
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Fitur multi-platform dengan subagen backend, frontend, dan mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementasi berfokus keamanan dengan subagen khusus
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Fitur bertenaga ML dengan subagen ilmu data
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimasi menyeluruh dengan subagen performa
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Resolusi insiden produksi dengan subagen ops

## 🔧 Tools (Perintah Satu Tujuan)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Bangun asisten AI dan chatbot siap produksi
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Review khusus untuk basis kode AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Membuat agen LangChain/LangGraph dengan pola modern
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Membuat pipeline ML menyeluruh dengan MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimalkan prompt AI untuk performa dan kualitas

### Arsitektur & Kualitas Kode
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Hasilkan penjelasan detail dari kode kompleks
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migrasi kode antar bahasa, framework, atau versi
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refaktor kode untuk kemudahan pemeliharaan dan performa

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analisis dan prioritaskan utang teknis

### Data & Database
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Rancang arsitektur pipeline data yang skalabel
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Terapkan sistem validasi data yang komprehensif
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Strategi migrasi database tingkat lanjut

### DevOps & Infrastruktur
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Hasilkan konfigurasi dan daftar periksa deployment
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Strategi optimasi container tingkat lanjut
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Deployment Kubernetes kelas produksi
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Siapkan sistem monitoring dan observabilitas menyeluruh
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementasikan Service Level Objectives (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Otomatiskan workflow pengembangan dan operasional

### Pengembangan & Pengujian
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Buat mock API realistis untuk pengembangan dan pengujian
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Hasilkan endpoint API siap produksi dengan tumpukan implementasi lengkap
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Buat suite pengujian komprehensif dengan deteksi framework

### Keamanan & Kepatuhan
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Pengujian aksesibilitas menyeluruh dan perbaikan
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Pastikan kepatuhan regulasi (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Pemindaian keamanan menyeluruh dengan remediasi otomatis

### Debugging & Analisis
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Strategi debugging dan tracing tingkat lanjut
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analisis pola error mendalam dan strategi resolusi
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Lacak dan diagnosis error produksi
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Buat issue GitHub/GitLab yang terstruktur dengan baik

### Dependensi & Konfigurasi
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Validasi dan kelola konfigurasi aplikasi
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audit dependensi untuk keamanan dan lisensi
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Upgrade dependensi proyek secara aman

### Dokumentasi & Kolaborasi
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Hasilkan dokumentasi yang komprehensif
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementasikan workflow Git yang efektif
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Tingkatkan pull request dengan pemeriksaan kualitas

### Optimasi Biaya
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimalkan biaya cloud dan infrastruktur

### Onboarding & Pengaturan
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Siapkan lingkungan pengembangan untuk anggota tim baru

### Alat Subagen
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Review kode multi-perspektif dengan subagen khusus
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Debugging mendalam dengan subagen debugger dan performa
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimasi full-stack dengan banyak subagen
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Simpan konteks proyek menggunakan subagen pengelola konteks
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Pulihkan konteks yang disimpan untuk kontinuitas

## Fitur

- Implementasi siap produksi
- Deteksi otomatis framework
- Praktik terbaik keamanan
- Monitoring dan pengujian bawaan
- Perintah bekerja bersama secara mulus

## Jumlah Perintah

**Total: 52 perintah slash siap produksi** yang diorganisir dalam:

### 🤖 Alur Kerja (14 perintah)

- Pengembangan Fitur & Review (3 perintah) 
- Otomasi Proses Pengembangan (6 perintah)
- Alur Kerja Orkestrasi Subagen (5 perintah)

### 🔧 Alat (38 perintah)

- AI & Machine Learning (5 perintah)
- Arsitektur & Kualitas Kode (4 perintah)
- Data & Basis Data (3 perintah)
- DevOps & Infrastruktur (6 perintah)
- Pengembangan & Pengujian (3 perintah)
- Keamanan & Kepatuhan (3 perintah)
- Debugging & Analisis (4 perintah)
- Ketergantungan & Konfigurasi (3 perintah)
- Dokumentasi & Kolaborasi (1 perintah)
- Orientasi & Penyiapan (1 perintah)
- Alat Khusus Subagen (5 perintah)

## Contoh Penggunaan

### 🤖 Contoh Alur Kerja

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 Contoh Alat (Perintah Satu Tujuan)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## Perintah yang Ditingkatkan

### Keamanan & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Pemindaian keamanan komprehensif dengan remediasi otomatis.

- **Pemindaian Multi-Alat**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Perbaikan Otomatis**: Kerentanan umum diperbaiki otomatis
- **Integrasi CI/CD**: Gerbang keamanan untuk GitHub Actions/GitLab CI
- **Pemindaian Kontainer**: Analisis kerentanan gambar
- **Deteksi Rahasia**: Integrasi GitLeaks dan TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Strategi optimasi kontainer tingkat lanjut.

- **Optimasi Cerdas**: Menganalisis dan menyarankan peningkatan
- **Build Multi-Tahap**: Dockerfile optimal khusus framework
- **Alat Modern**: BuildKit, Bun, UV untuk build lebih cepat
- **Penguatan Keamanan**: Gambar distroless, pengguna non-root
- **Integrasi Lintas Perintah**: Bekerja dengan keluaran /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Penerapan Kubernetes tingkat produksi.

- **Pola Lanjutan**: Standar Keamanan Pod, Kebijakan Jaringan, OPA
- **Siap GitOps**: Konfigurasi FluxCD dan ArgoCD
- **Observabilitas**: Prometheus ServiceMonitors, OpenTelemetry
- **Otomatisasi Skala**: Konfigurasi HPA, VPA, dan cluster autoscaler
- **Service Mesh**: Integrasi Istio/Linkerd

### Frontend & Data

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Strategi migrasi database tingkat lanjut.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Blue-green deployments, rolling migrations
- **Event Sourcing**: Integrasi Kafka/Kinesis untuk CDC
- **Cross-Platform**: Menangani persistensi poliglot
- **Monitoring**: Pemeriksaan kesehatan migrasi dan rollback

## Menggabungkan Alur Kerja dan Alat

Kekuatan sesungguhnya muncul dari menggabungkan alur kerja dan alat untuk siklus pengembangan yang lengkap:

### Contoh: Membangun Fitur Baru

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### Contoh: Memodernisasi Kode Lama

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## Pola Orkestrasi Perintah

Perintah dapat digunakan secara individual atau digabungkan dalam pola yang kuat:

### Eksekusi Berurutan
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Analisis Paralel
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Penyempurnaan Iteratif
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integrasi Lintas Domain
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Kapan Menggunakan Workflow vs Tools

### 🔀 Workflow & Tools Subagen
- **Pemecahan masalah**: Menganalisis dan memperbaiki masalah secara adaptif
- **Beragam perspektif**: Mengkoordinasikan subagen spesialis
- **Tugas kompleks**: Proses multi-langkah lintas domain
- **Solusi tidak diketahui**: Biarkan subagen menentukan pendekatan

### 🛠️ Tools Spesialisasi
- **Pengaturan infrastruktur**: Konfigurasikan lingkungan
- **Pembuatan kode**: Membuat implementasi spesifik
- **Analisis**: Menghasilkan laporan tanpa perbaikan
- **Tugas domain**: Operasi yang sangat spesifik

**Contoh:**
- "Implementasi sistem autentikasi pengguna" → `/workflows:feature-development`
- "Memperbaiki masalah performa di seluruh stack" → `/workflows:smart-fix`
- "Modernisasi monolit warisan" → `/workflows:legacy-modernize`

### 🔧 Gunakan Tools Ketika:
- **Dibutuhkan keahlian spesifik** - Tugas jelas dan terfokus dalam satu domain
- **Kontrol presisi diinginkan** - Ingin mengarahkan detail implementasi tertentu
- **Bagian dari workflow manual** - Mengintegrasikan ke proses yang ada
- **Spesialisasi mendalam diperlukan** - Butuh implementasi tingkat ahli
- **Membangun dari pekerjaan yang ada** - Menambah atau menyempurnakan output sebelumnya

**Contoh:**
- "Buat manifest Kubernetes" → `/tools:k8s-manifest`
- "Scan kerentanan keamanan" → `/tools:security-scan`
- "Hasilkan dokumentasi API" → `/tools:doc-generate`

## Format Perintah

Perintah slash adalah file markdown sederhana di mana:
- Nama file menjadi nama perintah (mis. `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Konten file adalah prompt/instruksi yang dijalankan saat dipanggil
- Gunakan placeholder `$ARGUMENTS` untuk input pengguna

## Praktik Terbaik

### Pemilihan Perintah
- **Biarkan Claude Code menyarankan secara otomatis** - Menganalisis konteks dan memilih perintah optimal
- **Gunakan alur kerja untuk tugas kompleks** - Subagen mengkoordinasikan implementasi multi-domain
- **Gunakan alat untuk tugas terfokus** - Terapkan perintah khusus untuk peningkatan yang ditargetkan

### Penggunaan Efektif
- **Berikan konteks yang komprehensif** - Sertakan tumpukan teknologi, batasan, dan persyaratan
- **Rangkai perintah secara strategis** - Alur Kerja → Alat → Penyempurnaan
- **Bangun dari keluaran sebelumnya** - Perintah dirancang untuk saling bekerja sama

## Kontribusi

1. Buat file `.md` di `workflows/` atau `tools/`
2. Gunakan nama dengan huruf kecil dan tanda hubung
3. Sertakan `$ARGUMENTS` untuk masukan pengguna

## Pemecahan Masalah

**Perintah tidak ditemukan**: 
- Periksa file ada di `~/.claude/commands/tools/` atau `~/.claude/commands/workflows/`
- Gunakan awalan yang benar: `/tools:nama-perintah` atau `/workflows:nama-perintah`
- Atau ratakan direktori jika Anda lebih suka tanpa awalan: `cp tools/*.md . && cp workflows/*.md .`

**Alur kerja lambat**: Normal - mereka mengkoordinasikan banyak subagen

**Keluaran umum**: Tambahkan konteks lebih spesifik tentang tumpukan teknologi Anda

**Masalah integrasi**: Verifikasi jalur file dan urutan perintah

## Tips Kinerja

**Pemilihan Perintah:**
- **Alur Kerja**: Koordinasi multi-subagen untuk fitur kompleks
- **Alat**: Operasi tujuan tunggal untuk tugas tertentu
- **Edit sederhana**: Tetap gunakan agen utama

**Optimasi:**
- Mulai dengan alat untuk masalah yang sudah diketahui
- Berikan persyaratan detail di awal
- Bangun di atas output perintah sebelumnya
- Biarkan alur kerja selesai sebelum melakukan modifikasi

### Menambahkan Alur Kerja Baru:
- Fokus pada logika orkestrasi dan delegasi subagen
- Tentukan subagen khusus mana yang digunakan dan urutannya
- Definisikan pola koordinasi antara subagen

### Menambahkan Alat Baru:
- Sertakan implementasi lengkap yang siap produksi
- Strukturkan konten dengan bagian yang jelas dan keluaran yang dapat ditindaklanjuti
- Sertakan contoh, praktik terbaik, dan titik integrasi

## Pelajari Lebih Lanjut

- [Dokumentasi Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Dokumentasi Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Dokumentasi Subagen](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Koleksi Subagen Claude Code](https://github.com/wshobson/agents) - Subagen khusus yang digunakan oleh perintah-perintah ini


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---