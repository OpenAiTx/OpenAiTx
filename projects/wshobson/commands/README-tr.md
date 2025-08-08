
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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

# Claude Code Slash Komutları

Gelişimi akıllı otomasyon ile hızlandıran, üretime hazır [Claude Code](https://docs.anthropic.com/en/docs/claude-code) için slash komutları.

**52 komut** şu şekilde organize edilmiştir:
- **🤖 İş Akışları**: Karmaşık görevler için çoklu alt ajan orkestrasyonu
- **🔧 Araçlar**: Belirli işlemler için tek amaçlı yardımcılar

### 🤝 Claude Code Alt Ajanları Gerekir

Bu komutlar, orkestrasyon yetenekleri için [Claude Code Alt Ajanları](https://github.com/wshobson/agents) ile birlikte çalışır.

## Kurulum

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Mevcut Komutlar

- **🤖 İş Akışları** - Karmaşık görevler için birden fazla alt ajanı yönetin
- **🔧 Araçlar** - Belirli işlemler için tek amaçlı komutlar

## Kullanım

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```

Claude Code, bağlama göre otomatik olarak ilgili komutları önerir.

## 🤖 İş Akışları

Karmaşık görevler için çoklu alt ajan orkestrasyonu:

### Özellik Geliştirme
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Backend, frontend, test ve dağıtım alt ajanlarıyla tam özellikler geliştirilir
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Birden fazla inceleme alt ajanı ile kapsamlı kod analizi sunar
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Sorunları analiz eder ve uygun uzman alt ajanlara yönlendirir

### Yazılım Geliştirme Süreçleri
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Dallama stratejileri ve PR şablonları ile etkili Git iş akışları uygular
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Alt ajan performansını istem optimizasyonu ile artırır
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Eski kod tabanlarını özel alt ajanlarla modernleştirir
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Veri ve ML mühendisliği alt ajanlarıyla ML boru hatları oluşturur
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Koordine alt ajanlarla çoklu platform uygulamaları geliştirir
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, izleme ve dağıtım iş akışlarını otomatikleştirir

### Alt Ajan Orkestrasyonlu İş Akışları
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Backend, frontend ve mobil alt ajanlarla çoklu platform özellikleri
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Özel alt ajanlarla güvenlik odaklı uygulama
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Veri bilimi alt ajanları ile ML destekli özellikler
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Performans alt ajanlarıyla uçtan uca optimizasyon
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Operasyon alt ajanlarıyla üretim olaylarının çözümü

## 🔧 Araçlar (Tek Amaçlı Komutlar)

### AI & Makine Öğrenimi
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Üretime hazır AI asistanları ve sohbet botları oluşturun
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML kod tabanları için özel inceleme
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Modern desenlerle LangChain/LangGraph ajanları oluşturun
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps ile uçtan uca ML boru hatları oluşturun
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - AI istemlerini performans ve kalite için optimize edin

### Mimari & Kod Kalitesi
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Karmaşık kodun ayrıntılı açıklamalarını üretin
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Kodları diller, çerçeveler veya sürümler arasında taşıyın
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Kodun sürdürülebilirliği ve performansı için yeniden düzenleyin
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Teknik borcu analiz edin ve önceliklendirin

### Veri & Veritabanı
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Ölçeklenebilir veri boru hattı mimarileri tasarlayın
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Kapsamlı veri doğrulama sistemleri uygulayın
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Gelişmiş veritabanı geçiş stratejileri

### DevOps & Altyapı
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Dağıtım yapılandırmaları ve kontrol listeleri oluşturun
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Gelişmiş konteyner optimizasyon stratejileri
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Üretim düzeyinde Kubernetes dağıtımları
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Kapsamlı izleme ve gözlemlenebilirlik kurun
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Hizmet Düzeyi Hedefleri (SLO) uygulayın
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Geliştirme ve operasyonel iş akışlarını otomatikleştirin

### Geliştirme & Test
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Geliştirme ve test için gerçekçi API taklitleri oluşturun
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Tam uygulama yığını ile üretime hazır API uç noktaları oluşturun
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Çerçeve algılama ile kapsamlı test paketleri oluşturun

### Güvenlik & Uyumluluk
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kapsamlı erişilebilirlik testi ve düzeltmeleri
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Yasal uyumluluğu sağlayın (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Otomatik düzeltmeli kapsamlı güvenlik taraması

### Hata Ayıklama & Analiz
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Gelişmiş hata ayıklama ve izleme stratejileri
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Derin hata deseni analizi ve çözüm stratejileri
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Üretim hatalarını izleyin ve teşhis edin
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - İyi yapılandırılmış GitHub/GitLab sorunları oluşturun

### Bağımlılıklar & Yapılandırma
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Uygulama yapılandırmasını doğrulayın ve yönetin
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Güvenlik ve lisans için bağımlılıkları denetleyin
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Proje bağımlılıklarını güvenli bir şekilde yükseltin

### Dokümantasyon & İşbirliği
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Kapsamlı dokümantasyon üretin
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Etkili Git iş akışları uygulayın
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Kalite kontrolleriyle pull request'leri geliştirin

### Maliyet Optimizasyonu
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Bulut ve altyapı maliyetlerini optimize edin

### Onboarding & Kurulum
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Yeni ekip üyeleri için geliştirme ortamı kurun

### Alt Ajan Araçları
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Uzmanlaşmış alt ajanlarla çoklu bakış açılı kod incelemesi
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Hata ayıklayıcı ve performans alt ajanlarıyla derin hata ayıklama
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Birden fazla alt ajanla tam yığın optimizasyon
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Context-manager alt ajanı ile proje bağlamını kaydedin
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Süreklilik için kaydedilmiş bağlamı geri yükleyin

## Özellikler

- Üretime hazır uygulamalar
- Çerçeve otomatik algılama
- Güvenlik en iyi uygulamaları
- Dahili izleme ve test
- Komutlar sorunsuz bir şekilde birlikte çalışır

## Komut Sayısı

**Toplam: 52 üretime hazır slash komutu** aşağıdaki gibi organize edilmiştir:

### 🤖 İş Akışları (14 komut)

- Özellik Geliştirme ve İnceleme (3 komut)
- Geliştirme Süreci Otomasyonu (6 komut)
- Alt ajan Orkestrasyonlu İş Akışları (5 komut)

### 🔧 Araçlar (38 komut)

- Yapay Zeka & Makine Öğrenimi (5 komut)
- Mimari & Kod Kalitesi (4 komut)
- Veri & Veritabanı (3 komut)
- DevOps & Altyapı (6 komut)
- Geliştirme & Test (3 komut)
- Güvenlik & Uyumluluk (3 komut)
- Hata Ayıklama & Analiz (4 komut)
- Bağımlılıklar & Yapılandırma (3 komut)
- Dokümantasyon & İş Birliği (1 komut)
- Onboarding & Kurulum (1 komut)
- Alt ajanlara Özel Araçlar (5 komut)

## Kullanım Örnekleri

### 🤖 İş Akışı Örnekleri

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

### 🔧 Araç Örnekleri (Tek Amaçlı Komutlar)

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

## Gelişmiş Komutlar

### Güvenlik & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Otomatik iyileştirme ile kapsamlı güvenlik taraması.

- **Çoklu Araç Taraması**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Otomatik Düzeltmeler**: Yaygın açıklar otomatik olarak giderilir
- **CI/CD Entegrasyonu**: GitHub Actions/GitLab CI için güvenlik geçişleri
- **Konteyner Taraması**: İmaj zafiyet analizi
- **Gizli Bilgi Tespiti**: GitLeaks ve TruffleHog entegrasyonu

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Gelişmiş konteyner optimizasyon stratejileri.

- **Akıllı Optimizasyon**: Analiz eder ve iyileştirmeler önerir
- **Çok Aşamalı Yapılar**: Framework'e özel optimize Dockerfile'lar
- **Modern Araçlar**: Daha hızlı yapılar için BuildKit, Bun, UV
- **Güvenlik Sağlamlaştırma**: Distroless imajlar, root olmayan kullanıcılar
- **Çapraz Komut Entegrasyonu**: /api-scaffold çıktılarıyla çalışır

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Üretim seviyesinde Kubernetes dağıtımları.

- **Gelişmiş Kalıplar**: Pod Güvenlik Standartları, Ağ Politikaları, OPA
- **GitOps Hazır**: FluxCD ve ArgoCD yapılandırmaları
- **Gözlemlenebilirlik**: Prometheus ServiceMonitors, OpenTelemetry
- **Otomatik Ölçeklendirme**: HPA, VPA ve küme otomatik ölçekleyici yapılandırmaları
- **Servis Ağı**: Istio/Linkerd entegrasyonu

### Frontend & Veri

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Gelişmiş veritabanı geçiş stratejileri.

- **Çoklu Veritabanı**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Sıfır Kesinti**: Mavi-yeşil dağıtımlar, adım adım geçişler
- **Olay Kaynağı**: CDC için Kafka/Kinesis entegrasyonu
- **Çapraz Platform**: Çoklu veri yapısını yönetir
- **İzleme**: Geçiş sağlık kontrolü ve geri alma

## İş Akışlarını ve Araçları Birleştirme

Gerçek güç, tüm geliştirme döngüleri için iş akışlarının ve araçların birleştirilmesinden gelir:

### Örnek: Yeni Bir Özellik Geliştirme

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

### Örnek: Eski Kodun Modernizasyonu

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

## Komut Orkestrasyon Kalıpları

Komutlar tek başına kullanılabileceği gibi güçlü kalıplar halinde de birleştirilebilir:

### Sıralı Yürütme
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Paralel Analiz
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Yinelemeli İyileştirme
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Alanlar Arası Entegrasyon
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Ne Zaman İş Akışları, Ne Zaman Araçlar Kullanılmalı

### 🔀 İş Akışları & Alt-Ajan Araçları
- **Sorun çözme**: Uyarlanabilir bir şekilde analiz etme ve düzeltme
- **Çoklu bakış açıları**: Uzman alt ajanları koordine etme
- **Karmaşık görevler**: Alanlar arası çok adımlı süreçler
- **Bilinmeyen çözümler**: Alt ajanların yaklaşımı belirlemesine izin ver

### 🛠️ Uzmanlaşmış Araçlar
- **Altyapı kurulumu**: Ortamları yapılandırma
- **Kod üretimi**: Spesifik uygulamalar oluşturma
- **Analiz**: Düzeltme olmadan rapor oluşturma
- **Alan görevleri**: Yüksek derecede uzmanlaşmış işlemler

**Örnekler:**
- "Kullanıcı kimlik doğrulama sistemi uygula" → `/feature-development`
- "Yığın genelinde performans sorunlarını düzelt" → `/smart-fix`
- "Eski monolit sistemi modernize et" → `/legacy-modernize`

### 🔧 Araçları Şu Durumlarda Kullanın:
- **Spesifik uzmanlık gerekliyse** - Tek bir alanda net, odaklı görev
- **Kesin kontrol isteniyorsa** - Belirli uygulama detaylarını yönlendirmek istiyorsanız
- **Manuel iş akışının parçasıysa** - Mevcut süreçlere entegre ediliyor
- **Derin uzmanlık gerekiyorsa** - Uzman düzeyinde uygulama ihtiyacı varsa
- **Mevcut çalışmaya ek yapılıyorsa** - Önceki çıktıları geliştirme veya iyileştirme

**Örnekler:**
- "Kubernetes manifestleri oluştur" → `/k8s-manifest`
- "Güvenlik açıklarını tara" → `/security-scan`
- "API dokümantasyonu oluştur" → `/doc-generate`

## Komut Formatı

Slash komutları basit Markdown dosyalarıdır:
- Dosya adı komut adı olur (örn. `api-scaffold.md` → `/api-scaffold`)
- Dosya içeriği, komut çağrıldığında yürütülen talimatlardır
- Kullanıcı girdisi için `$ARGUMENTS` yer tutucusu kullanılır

## En İyi Uygulamalar

### Komut Seçimi
- **Claude Code’un otomatik önermesine izin verin** - Bağlamı analiz eder ve en iyi komutları seçer
- **Karmaşık görevlerde iş akışlarını kullanın** - Alt ajanlar çoklu alan uygulamalarını koordine eder
- **Odaklı görevler için araçları kullanın** - Belirli iyileştirmeler için özel komutlar uygulayın

### Etkili Kullanım
- **Kapsamlı bağlam sağlayın** - Teknoloji yığını, kısıtlamalar ve gereksinimleri ekleyin
- **Komutları stratejik olarak zincirleyin** - İş Akışları → Araçlar → İyileştirmeler
- **Önceki çıktılar üzerine inşa edin** - Komutlar birlikte çalışacak şekilde tasarlanmıştır

## Katkıda Bulunma

1. `workflows/` veya `tools/` dizininde `.md` dosyası oluşturun
2. Küçük harf-tireli isimler kullanın
3. Kullanıcı girdisi için `$ARGUMENTS` ekleyin

## Sorun Giderme

**Komut bulunamadı**: Dosyaların `~/.claude/commands/` dizininde olduğundan emin olun

**İş akışları yavaş**: Normal - birden fazla alt ajanı koordine ediyorlar

**Genel çıktı**: Teknoloji yığını hakkında daha spesifik bağlam ekleyin

**Entegrasyon sorunları**: Dosya yollarını ve komut sırasını doğrulayın

## Performans İpuçları

**Komut Seçimi:**
- **İş Akışları**: Karmaşık özellikler için çoklu alt ajan koordinasyonu
- **Araçlar**: Spesifik görevler için tek amaçlı işlemler
- **Basit düzenlemeler**: Ana ajan ile devam edin

**Optimizasyon:**
- Bilinen sorunlarda araçlarla başlayın
- Ayrıntılı gereksinimleri baştan belirtin
- Önceki komut çıktıları üzerine inşa edin
- Değişiklikten önce iş akışlarının tamamlanmasını bekleyin

### Yeni Bir İş Akışı Ekleme:
- Alt ajan orkestrasyonu ve delege mantığına odaklanın
- Hangi uzman alt ajanların kullanılacağını ve sırasını belirtin
- Alt ajanlar arasındaki koordinasyon düzenlerini tanımlayın

### Yeni Bir Araç Ekleme:
- Tam, üretime hazır uygulamaları dahil edin
- İçeriği net bölümler ve uygulanabilir çıktılar ile yapılandırın
- Örnekler, en iyi uygulamalar ve entegrasyon noktalarını ekleyin

## Daha Fazla Bilgi Edinin

- [Claude Code Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Komutları Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Alt Ajanlar Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Alt Ajanlar Koleksiyonu](https://github.com/wshobson/agents) - Bu komutlarda kullanılan uzman alt ajanlar


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---