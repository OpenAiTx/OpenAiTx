
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

Geliştirmeyi akıllı otomasyon ile hızlandıran [Claude Code](https://docs.anthropic.com/en/docs/claude-code) için üretime hazır slash komutları.

**52 komut** şu şekilde organize edilmiştir:
- **🤖 İş Akışları**: Karmaşık görevler için çoklu alt ajan düzenlemesi
- **🔧 Araçlar**: Belirli işlemler için tek amaçlı yardımcılar

### 🤝 Claude Kod Alt Ajanları Gerektirir

Bu komutlar, orkestrasyon yetenekleri için [Claude Kod Alt Ajanları](https://github.com/wshobson/agents) ile çalışır.

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

Komutlar `tools/` ve `workflows/` dizinlerinde organize edilmiştir. Bunları dizin önekiyle kullanın:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Not:** Eğer önekler olmadan komutları kullanmayı tercih ediyorsanız, dizinleri düzleştirebilirsiniz:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code, bağlama göre otomatik olarak ilgili komutları önerir.

## 🤖 İş Akışları

Karmaşık görevler için çoklu alt ajan orkestrasyonu:

### Özellik Geliştirme
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Backend, frontend, test ve dağıtım alt ajanları ile tam özellikler oluşturur
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Birden fazla inceleme alt ajanı ile kapsamlı kod analizi sağlar
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Sorunları analiz eder ve uygun uzman alt ajanlara yönlendirir

### Geliştirme Süreçleri
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Dallama stratejileri ve PR şablonlarıyla etkili Git iş akışları uygular
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Alt ajan performansını komut optimizasyonu ile iyileştirir
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Eski kod tabanlarını uzman alt ajanlarla modernleştirir
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Veri ve ML mühendisliği alt ajanlarıyla ML boru hatları oluşturur
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Koordine alt ajanlarla çapraz platform uygulamaları geliştirir
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - CI/CD, izleme ve dağıtım iş akışlarını otomatikleştirir

### Alt Ajan Orkestrasyonlu İş Akışları
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Backend, frontend ve mobil alt ajanlarla çoklu platform özellikleri
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Güvenlik odaklı uygulama, uzman alt ajanlarla
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Veri bilimi alt ajanlarıyla ML destekli özellikler
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Performans alt ajanları ile uçtan uca optimizasyon
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Operasyon alt ajanları ile üretim olayı çözümü

## 🔧 Araçlar (Tek Amaçlı Komutlar)

### AI & Makine Öğrenimi
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Üretime hazır AI asistanları ve sohbet botları oluşturun
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML kod tabanları için özel inceleme
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Modern desenlerle LangChain/LangGraph ajanları oluşturun
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - MLOps ile uçtan uca ML boru hatları oluşturun
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Performans ve kalite için AI komutlarını optimize edin

### Mimari & Kod Kalitesi
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Karmaşık kodun ayrıntılı açıklamalarını oluşturur
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Kodunuzu diller, çerçeveler veya sürümler arasında taşıyın
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Kodun sürdürülebilirliği ve performansı için yeniden düzenler

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
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Hizmet Seviyesi Hedefleri (SLO) uygulayın
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Geliştirme ve operasyonel iş akışlarını otomatikleştirin

### Geliştirme & Test
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Geliştirme ve test için gerçekçi API maketleri oluşturun
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Tam uygulama yığını ile üretime hazır API uç noktaları oluşturun
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Çerçeve algılama ile kapsamlı test paketleri oluşturun

### Güvenlik & Uyumluluk
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kapsamlı erişilebilirlik testleri ve düzeltmeleri
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Yasal uyumluluğu sağlayın (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Otomatik düzeltmeli kapsamlı güvenlik taraması

### Hata Ayıklama & Analiz
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Gelişmiş hata ayıklama ve izleme stratejileri
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Derin hata deseni analizi ve çözüm stratejileri
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Üretim hatalarını izleyin ve teşhis edin
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - İyi yapılandırılmış GitHub/GitLab sorunları oluşturun

### Bağımlılıklar & Yapılandırma
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Uygulama yapılandırmasını doğrulayın ve yönetin
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Bağımlılıkları güvenlik ve lisans açısından denetleyin
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Proje bağımlılıklarını güvenli şekilde yükseltin

### Dokümantasyon & İşbirliği
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Kapsamlı dokümantasyon oluşturun
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Etkili Git iş akışları uygulayın
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Kalite kontrolleri ile çekme taleplerini geliştirin

### Maliyet Optimizasyonu
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Bulut ve altyapı maliyetlerini optimize edin

### İşe Alım & Kurulum
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Yeni ekip üyeleri için geliştirme ortamlarını kurun

### Alt Ajan Araçları
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Uzman alt ajanlarla çok yönlü kod inceleme
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Hata ayıklama ve performans alt ajanları ile derin hata ayıklama
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Birden fazla alt ajan ile tam yığın optimizasyon
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Proje bağlamını context-manager alt ajanı ile kaydedin
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Devamlılık için kayıtlı bağlamı geri yükleyin

## Özellikler

- Üretime hazır uygulamalar
- Otomatik framework algılama
- Güvenlik en iyi uygulamaları
- Dahili izleme ve test
- Komutlar sorunsuz bir şekilde birlikte çalışır

## Komut Sayısı

**Toplam: 52 üretime hazır slash komutu** şu şekilde organize edilmiştir:

### 🤖 İş Akışları (14 komut)

- Özellik Geliştirme & İnceleme (3 komut)
- Geliştirme Süreci Otomasyonu (6 komut)
- Alt ajanlarla Orkestre Edilmiş İş Akışları (5 komut)

### 🔧 Araçlar (38 komut)

- Yapay Zeka & Makine Öğrenimi (5 komut)
- Mimari & Kod Kalitesi (4 komut)
- Veri & Veritabanı (3 komut)
- DevOps & Altyapı (6 komut)
- Geliştirme & Test (3 komut)
- Güvenlik & Uyumluluk (3 komut)
- Hata Ayıklama & Analiz (4 komut)
- Bağımlılıklar & Yapılandırma (3 komut)
- Dokümantasyon & İşbirliği (1 komut)
- Başlangıç & Kurulum (1 komut)
- Alt ajanlara Özel Araçlar (5 komut)

## Kullanım Örnekleri

### 🤖 İş Akışı Örnekleri

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

### 🔧 Araç Örnekleri (Tek Amaçlı Komutlar)

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

## Gelişmiş Komutlar

### Güvenlik & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Otomatik iyileştirme ile kapsamlı güvenlik taraması.

- **Çoklu Araç Taraması**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Otomatik Düzeltmeler**: Yaygın açıklar otomatik olarak giderilir
- **CI/CD Entegrasyonu**: GitHub Actions/GitLab CI için güvenlik kapıları
- **Konteyner Taraması**: Görüntü zafiyet analizi
- **Gizli Bilgi Tespiti**: GitLeaks ve TruffleHog entegrasyonu

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Gelişmiş konteyner optimizasyon stratejileri.

- **Akıllı Optimizasyon**: Analiz eder ve iyileştirme önerir
- **Çok Aşamalı Yapılar**: Framework'e özel optimize edilmiş Dockerfile'lar
- **Modern Araçlar**: Daha hızlı yapı için BuildKit, Bun, UV
- **Güvenlik Sertleştirme**: Distroless imajlar, root olmayan kullanıcılar
- **Çapraz Komut Entegrasyonu**: /api-scaffold çıktılarıyla çalışır

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Üretim düzeyinde Kubernetes dağıtımları.

- **Gelişmiş Desenler**: Pod Güvenlik Standartları, Ağ Politikaları, OPA
- **GitOps Uyumlu**: FluxCD ve ArgoCD yapılandırmaları
- **Gözlemlenebilirlik**: Prometheus ServiceMonitor'ları, OpenTelemetry
- **Otomatik Ölçekleme**: HPA, VPA ve küme otomatik ölçekleyici ayarları
- **Servis Mesh**: Istio/Linkerd entegrasyonu

### Frontend & Veri

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Gelişmiş veritabanı geçiş stratejileri.

- **Çoklu Veritabanı**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Sıfır Kesinti**: Mavi-yeşil dağıtımlar, yuvarlanan geçişler
- **Olay Kaynağı**: CDC için Kafka/Kinesis entegrasyonu
- **Çapraz Platform**: Çoklu dilde kalıcılığı yönetir
- **İzleme**: Geçiş sağlık kontrolleri ve geri alma

## İş Akışları ve Araçların Birleştirilmesi

Gerçek güç, tam geliştirme döngüleri için iş akışlarının ve araçların birleştirilmesinden gelir:

### Örnek: Yeni Bir Özellik Oluşturmak

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

### Örnek: Eski Kodun Modernizasyonu

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

## Komut Orkestrasyon Kalıpları

Komutlar tek başına kullanılabileceği gibi güçlü kalıplar halinde de birleştirilebilir:

### Sıralı Yürütme
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Paralel Analiz
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Yinelemeli İyileştirme
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Alanlar Arası Entegrasyon
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## İş Akışları mı Araçlar mı Ne Zaman Kullanılır

### 🔀 İş Akışları & Alt Ajans Araçları
- **Sorun çözme**: Uyarlanabilir şekilde analiz edip düzeltmek
- **Çoklu bakış açıları**: Uzman alt ajansları koordine etmek
- **Karmaşık görevler**: Alanlar arası çok adımlı süreçler
- **Bilinmeyen çözümler**: Alt ajansların yaklaşımı belirlemesine izin vermek

### 🛠️ Uzmanlaşmış Araçlar
- **Altyapı kurulumu**: Ortamları yapılandırmak
- **Kod üretimi**: Belirli uygulamaları oluşturmak
- **Analiz**: Sadece rapor üretmek, düzeltme olmadan
- **Alan görevleri**: Yüksek derecede uzmanlaşmış işlemler

**Örnekler:**
- "Kullanıcı kimlik doğrulama sistemi uygula" → `/workflows:feature-development`
- "Stack genelinde performans sorunlarını düzelt" → `/workflows:smart-fix`
- "Eski monolit sistemi modernize et" → `/workflows:legacy-modernize`

### 🔧 Araçları Şu Durumlarda Kullanın:
- **Belirli uzmanlık gerektiğinde** - Tek bir alanda net, odaklanmış görev
- **Kesin kontrol isteniyorsa** - Belirli uygulama detaylarını yönlendirmek
- **Manuel iş akışının parçasıysa** - Mevcut süreçlere entegre etmek
- **Derin uzmanlık gerekliyse** - Uzman seviyesinde uygulama lazım
- **Mevcut iş üzerine inşa edilirken** - Önceki çıktıları geliştirmek veya iyileştirmek

**Örnekler:**
- "Kubernetes manifest dosyaları oluştur" → `/tools:k8s-manifest`
- "Güvenlik açıklarını tara" → `/tools:security-scan`
- "API dokümantasyonu oluştur" → `/tools:doc-generate`

## Komut Formatı

Slash komutları, basit markdown dosyalarıdır ve:
- Dosya adı komut adı olur (ör: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Dosya içeriği, çağrıldığında yürütülen istem/talimatlardır
- Kullanıcı girişi için `$ARGUMENTS` yer tutucusunu kullanın

## En İyi Uygulamalar

### Komut Seçimi
- **Claude Code'un otomatik önermesine izin verin** - Bağlamı analiz eder ve en uygun komutları seçer
- **Karmaşık görevler için iş akışlarını kullanın** - Alt ajanlar çok alanlı uygulamaları koordine eder
- **Odaklanmış görevler için araçları kullanın** - Hedeflenen iyileştirmeler için belirli komutları uygulayın

### Etkili Kullanım
- **Kapsamlı bağlam sağlayın** - Teknoloji yığını, kısıtlamalar ve gereksinimleri dahil edin
- **Komutları stratejik olarak zincirleyin** - İş Akışları → Araçlar → İyileştirmeler
- **Önceki çıktılar üzerine inşa edin** - Komutlar birlikte çalışacak şekilde tasarlanmıştır

## Katkıda Bulunma

1. `workflows/` veya `tools/` klasöründe `.md` dosyası oluşturun
2. Küçük harf-tireli isimler kullanın
3. Kullanıcı girişi için `$ARGUMENTS` dahil edin

## Sorun Giderme

**Komut bulunamadı**: 
- Dosyaların `~/.claude/commands/tools/` veya `~/.claude/commands/workflows/` içinde olduğundan emin olun
- Doğru öneki kullanın: `/tools:komut-ismi` veya `/workflows:komut-ismi`
- Ya da önek olmadan dizinleri düzleştirin: `cp tools/*.md . && cp workflows/*.md .`

**İş akışları yavaş**: Normal - birden fazla alt ajanı koordine ederler

**Genel çıktı**: Teknoloji yığını hakkında daha spesifik bağlam ekleyin

**Entegrasyon sorunları**: Dosya yollarını ve komut sırasını doğrulayın

## Performans İpuçları

**Komut Seçimi:**
- **İş Akışları**: Karmaşık özellikler için çoklu alt ajan koordinasyonu
- **Araçlar**: Belirli görevler için tek amaçlı işlemler
- **Basit düzenlemeler**: Ana ajan ile devam edin

**Optimizasyon:**
- Bilinen sorunlar için araçlarla başlayın
- Detaylı gereksinimleri en başta sağlayın
- Önceki komut çıktıları üzerine inşa edin
- Değişikliklerden önce iş akışlarının tamamlanmasına izin verin

### Yeni Bir İş Akışı Ekleme:
- Alt ajan orkestrasyonu ve delege etme mantığına odaklanın
- Hangi uzmanlaşmış alt ajanların hangi sırayla kullanılacağını belirtin
- Alt ajanlar arasındaki koordinasyon desenlerini tanımlayın

### Yeni Bir Araç Ekleme:
- Tam, üretime hazır uygulamalar dahil edin
- İçeriği net bölümler ve uygulanabilir çıktılar ile yapılandırın
- Örnekler, en iyi uygulamalar ve entegrasyon noktaları ekleyin

## Daha Fazla Bilgi Edinin

- [Claude Kod Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Komutları Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Alt Ajanlar Dokümantasyonu](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Kod GitHub](https://github.com/anthropics/claude-code)
- [Claude Kod Alt Ajanlar Koleksiyonu](https://github.com/wshobson/agents) - Bu komutlarda kullanılan uzmanlaşmış alt ajanlar


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---