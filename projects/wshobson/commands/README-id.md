
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

**52 perintah** diorganisir sebagai:
- **🤖 Alur Kerja**: Orkestrasi multi-subagen untuk tugas kompleks
- **🔧 Alat**: Utilitas satu tujuan untuk operasi spesifik

### 🤝 Membutuhkan Subagen Claude Code

Perintah-perintah ini bekerja dengan [Subagen Claude Code](https://github.com/wshobson/agents) untuk kemampuan orkestrasi.

## Instalasi

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Perintah yang Tersedia

- **🤖 Alur Kerja** - Mengorkestrasi beberapa subagen untuk tugas yang kompleks
- **🔧 Alat** - Perintah satu tujuan untuk operasi tertentu

## Penggunaan

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code secara otomatis menyarankan perintah yang relevan berdasarkan konteks.

## 🤖 Alur Kerja

Orkestrasi multi-subagen untuk tugas kompleks:

### Pengembangan Fitur
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagen backend, frontend, pengujian, dan deployment membangun fitur lengkap
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Beberapa subagen review menyediakan analisis kode yang komprehensif
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Menganalisis masalah dan mendelegasikan ke subagen spesialis yang sesuai

### Proses Pengembangan
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Menerapkan alur kerja Git yang efektif dengan strategi branching dan template PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Meningkatkan performa subagen melalui optimasi prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernisasi basis kode lama menggunakan subagen khusus
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Membuat pipeline ML dengan subagen data dan rekayasa ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Membangun aplikasi lintas platform dengan subagen terkoordinasi
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Mengotomatisasi alur kerja CI/CD, monitoring, dan deployment

### Alur Kerja Terorkestrasi Subagen
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Fitur multi-platform dengan subagen backend, frontend, dan mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementasi berorientasi keamanan dengan subagen khusus
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Fitur berbasis ML dengan subagen data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optimasi end-to-end dengan subagen performa
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Penyelesaian insiden produksi dengan subagen ops

## 🔧 Tools (Perintah Khusus)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Membangun asisten AI dan chatbot siap produksi
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Review khusus untuk basis kode AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Membuat agen LangChain/LangGraph dengan pola modern
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Membuat pipeline ML end-to-end dengan MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimasi prompt AI untuk performa dan kualitas

### Arsitektur & Kualitas Kode
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Menghasilkan penjelasan detail dari kode kompleks
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migrasi kode antar bahasa, framework, atau versi
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refaktor kode untuk pemeliharaan dan performa
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analisis dan prioritasi technical debt

### Data & Database
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Merancang arsitektur pipeline data yang skalabel
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementasi sistem validasi data menyeluruh
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Strategi migrasi database tingkat lanjut

### DevOps & Infrastruktur
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Menghasilkan konfigurasi dan checklist deployment
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Strategi optimasi kontainer tingkat lanjut
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Deployment Kubernetes kelas produksi
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Menyiapkan monitoring dan observasi menyeluruh
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementasi Service Level Objectives (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Otomatisasi alur kerja pengembangan dan operasional

### Pengembangan & Pengujian
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Membuat mock API realistis untuk pengembangan dan pengujian
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Menghasilkan endpoint API siap produksi dengan stack implementasi lengkap
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Membuat suite pengujian lengkap dengan deteksi framework

### Keamanan & Kepatuhan
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Pengujian dan perbaikan aksesibilitas menyeluruh
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Memastikan kepatuhan regulasi (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Pemindaian keamanan menyeluruh dengan remediasi otomatis

### Debugging & Analisis
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Strategi debugging dan tracing tingkat lanjut
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analisis pola error mendalam dan strategi resolusi
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Melacak dan mendiagnosis error produksi
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Membuat issue GitHub/GitLab yang terstruktur baik

### Dependensi & Konfigurasi
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Validasi dan manajemen konfigurasi aplikasi
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audit dependensi untuk keamanan dan lisensi
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Upgrade dependensi proyek secara aman

### Dokumentasi & Kolaborasi
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Menghasilkan dokumentasi menyeluruh
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Menerapkan alur kerja Git yang efektif
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Meningkatkan pull request dengan pengecekan kualitas

### Optimasi Biaya
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimasi biaya cloud dan infrastruktur

### Onboarding & Setup
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Menyiapkan lingkungan pengembangan bagi anggota tim baru

### Tools Subagen
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Review kode multi-perspektif dengan subagen khusus
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Debugging mendalam dengan subagen debugger dan performa
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optimasi full-stack dengan beberapa subagen
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Menyimpan konteks proyek menggunakan subagen context-manager
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Mengembalikan konteks yang tersimpan untuk kontinuitas

## Fitur

- Implementasi siap produksi
- Deteksi framework otomatis
- Praktik terbaik keamanan
- Monitoring dan pengujian bawaan

- Perintah bekerja bersama secara mulus

## Jumlah Perintah

**Total: 52 perintah slash siap produksi** yang diorganisasikan ke dalam:

### 🤖 Alur Kerja (14 perintah)

- Pengembangan & Review Fitur (3 perintah) 
- Otomatisasi Proses Pengembangan (6 perintah)
- Alur Kerja yang Diorkestrasi Subagen (5 perintah)

### 🔧 Alat (38 perintah)

- AI & Pembelajaran Mesin (5 perintah)
- Arsitektur & Kualitas Kode (4 perintah)
- Data & Basis Data (3 perintah)
- DevOps & Infrastruktur (6 perintah)
- Pengembangan & Pengujian (3 perintah)
- Keamanan & Kepatuhan (3 perintah)
- Debugging & Analisis (4 perintah)
- Ketergantungan & Konfigurasi (3 perintah)
- Dokumentasi & Kolaborasi (1 perintah)
- Onboarding & Penyiapan (1 perintah)
- Alat Khusus Subagen (5 perintah)

## Contoh Penggunaan

### 🤖 Contoh Alur Kerja

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 Contoh Alat (Perintah Satu Tujuan)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## Perintah yang Ditingkatkan

### Keamanan & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Pemindaian keamanan komprehensif dengan remediasi otomatis.

- **Pemindaian Multi-Alat**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Perbaikan Otomatis**: Kerentanan umum diperbaiki otomatis
- **Integrasi CI/CD**: Gerbang keamanan untuk GitHub Actions/GitLab CI
- **Pemindaian Kontainer**: Analisis kerentanan image
- **Deteksi Secret**: Integrasi GitLeaks dan TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Strategi optimasi kontainer tingkat lanjut.

- **Optimasi Cerdas**: Menganalisis dan menyarankan perbaikan
- **Multi-Stage Builds**: Dockerfile yang dioptimalkan khusus framework
- **Alat Modern**: BuildKit, Bun, UV untuk build yang lebih cepat
- **Penguatan Keamanan**: Image distroless, pengguna non-root
- **Integrasi Lintas Perintah**: Bekerja dengan output /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Deploy Kubernetes siap produksi.

- **Pola Lanjutan**: Standar Keamanan Pod, Network Policies, OPA
- **Siap GitOps**: Konfigurasi FluxCD dan ArgoCD
- **Observabilitas**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: Konfigurasi HPA, VPA, dan cluster autoscaler
- **Service Mesh**: Integrasi Istio/Linkerd

### Frontend & Data

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Strategi migrasi database tingkat lanjut.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Deploy biru-hijau, migrasi rolling
- **Event Sourcing**: Integrasi Kafka/Kinesis untuk CDC
- **Lintas Platform**: Menangani persistensi poliglot
- **Monitoring**: Pemeriksaan kesehatan migrasi dan rollback

## Menggabungkan Alur Kerja dan Alat

Kekuatan sesungguhnya berasal dari menggabungkan alur kerja dan alat untuk siklus pengembangan lengkap:

### Contoh: Membangun Fitur Baru

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### Contoh: Memodernisasi Kode Lama

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## Pola Orkestrasi Perintah

Perintah dapat digunakan secara individual atau digabungkan dalam pola yang kuat:

### Eksekusi Berurutan
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Analisis Paralel
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Penyempurnaan Iteratif
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Integrasi Lintas Domain
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Kapan Menggunakan Workflow vs Tools

### 🔀 Workflow & Tools Subagen
- **Pemecahan masalah**: Analisis dan perbaiki isu secara adaptif
- **Berbagai perspektif**: Koordinasikan subagen spesialis
- **Tugas kompleks**: Proses multi-langkah lintas domain
- **Solusi tidak diketahui**: Biarkan subagen menentukan pendekatan

### 🛠️ Tools Khusus
- **Pengaturan infrastruktur**: Konfigurasi lingkungan
- **Pembuatan kode**: Buat implementasi spesifik
- **Analisis**: Buat laporan tanpa perbaikan
- **Tugas domain**: Operasi yang sangat spesialis

**Contoh:**
- "Implementasikan sistem autentikasi pengguna" → `/feature-development`
- "Perbaiki masalah performa di seluruh stack" → `/smart-fix`
- "Modernisasi monolitik lama" → `/legacy-modernize`

### 🔧 Gunakan Tools Jika:
- **Keahlian khusus dibutuhkan** - Tugas jelas dan fokus pada satu domain
- **Kontrol presisi diinginkan** - Ingin mengarahkan detail implementasi spesifik
- **Bagian dari workflow manual** - Integrasi ke dalam proses yang sudah ada
- **Spesialisasi mendalam diperlukan** - Butuh implementasi tingkat ahli
- **Membangun di atas hasil sebelumnya** - Memperbaiki atau menyempurnakan output sebelumnya

**Contoh:**
- "Buat manifest Kubernetes" → `/k8s-manifest`
- "Pindai kerentanan keamanan" → `/security-scan`
- "Hasilkan dokumentasi API" → `/doc-generate`

## Format Perintah

Perintah slash adalah file markdown sederhana di mana:
- Nama file menjadi nama perintah (mis. `api-scaffold.md` → `/api-scaffold`)
- Isi file adalah prompt/instruksi yang dijalankan saat dipanggil
- Gunakan placeholder `$ARGUMENTS` untuk input pengguna

## Praktik Terbaik

### Pemilihan Perintah
- **Biarkan Claude Code menyarankan otomatis** - Menganalisis konteks dan memilih perintah optimal
- **Gunakan workflow untuk tugas kompleks** - Subagen mengoordinasikan implementasi multi-domain
- **Gunakan tools untuk tugas fokus** - Terapkan perintah spesifik untuk peningkatan terarah

### Penggunaan Efektif
- **Berikan konteks komprehensif** - Sertakan stack teknologi, batasan, dan kebutuhan
- **Rantai perintah secara strategis** - Workflow → Tools → Penyempurnaan
- **Bangun di atas output sebelumnya** - Perintah dirancang untuk bekerja bersama

## Kontribusi

1. Buat file `.md` di `workflows/` atau `tools/`
2. Gunakan nama dengan huruf kecil dan tanda hubung
3. Sertakan `$ARGUMENTS` untuk input pengguna

## Pemecahan Masalah

**Perintah tidak ditemukan**: Periksa file berada di `~/.claude/commands/`

**Workflow lambat**: Normal - mereka mengoordinasikan beberapa subagen

**Output umum**: Tambahkan konteks lebih spesifik tentang stack teknologi Anda

**Masalah integrasi**: Verifikasi jalur file dan urutan perintah

## Tips Performa

**Pemilihan Perintah:**
- **Workflow**: Koordinasi multi-subagen untuk fitur kompleks
- **Tools**: Operasi satu tujuan untuk tugas spesifik
- **Edit sederhana**: Tetap dengan agen utama

**Optimasi:**
- Mulai dengan tools untuk masalah yang sudah diketahui
- Berikan kebutuhan terperinci di awal
- Bangun dari output perintah sebelumnya
- Biarkan workflow selesai sebelum modifikasi

### Menambah Workflow Baru:
- Fokus pada orkestrasi dan logika delegasi subagen
- Spesifikasikan subagen spesialis mana yang digunakan dan urutannya
- Definisikan pola koordinasi antar subagen

### Menambah Tool Baru:
- Sertakan implementasi lengkap siap produksi
- Susun konten dengan bagian jelas dan output yang dapat ditindaklanjuti
- Sertakan contoh, praktik terbaik, dan titik integrasi

## Pelajari Lebih Lanjut

- [Dokumentasi Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Dokumentasi Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Dokumentasi Subagen](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Koleksi Subagen Claude Code](https://github.com/wshobson/agents) - Subagen spesialis yang digunakan oleh perintah ini


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---