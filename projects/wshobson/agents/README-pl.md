<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Kolekcja Subagentów Claude Code

Kompleksowa kolekcja wyspecjalizowanych subagentów AI dla [Claude Code](https://docs.anthropic.com/en/docs/claude-code), zaprojektowana w celu usprawnienia procesów programistycznych dzięki ekspertyzie domenowej.

## Przegląd

To repozytorium zawiera 76 wyspecjalizowanych subagentów rozszerzających możliwości Claude Code. Każdy subagent jest ekspertem w określonej dziedzinie, wywoływany automatycznie na podstawie kontekstu lub ręcznie, gdy zachodzi taka potrzeba. Wszyscy agenci są skonfigurowani z określonymi modelami Claude w zależności od złożoności zadania, zapewniając optymalną wydajność i efektywność kosztową.

## Dostępne Subagenty

### Rozwój i Architektura
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - Projektowanie RESTful API, granic mikroserwisów oraz schematów baz danych
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Tworzenie komponentów React, wdrażanie responsywnych układów i zarządzanie stanem po stronie klienta
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - Tworzenie projektów interfejsów, makiet oraz systemów projektowych
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - Weryfikacja czy modyfikacje UI osiągnęły zamierzone cele poprzez dokładną analizę zrzutów ekranu
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - Tworzenie aplikacji React Native lub Flutter z natywnymi integracjami
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - Projektowanie schematów GraphQL, resolverów i federacji
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - Recenzowanie zmian w kodzie pod kątem spójności architektonicznej i wzorców

### Specjaliści językowi
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - Pisanie idiomatycznego kodu w Pythonie z zaawansowanymi funkcjami i optymalizacjami
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - Pisanie idiomatycznego kodu Ruby z metaprogramowaniem, wzorcami Rails, rozwojem gemów i frameworkami testowymi
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - Pisanie idiomatycznego kodu Go z goroutines, kanałami i interfejsami
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - Pisanie idiomatycznego kodu Rust z wzorcami własności, czasem życia i implementacjami cech
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - Pisanie wydajnego kodu C z prawidłowym zarządzaniem pamięcią i wywołaniami systemowymi
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - Pisanie idiomatycznego kodu C++ z nowoczesnymi funkcjami, RAII, inteligentnymi wskaźnikami i algorytmami STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - Opanowanie nowoczesnego JavaScript z ES6+, wzorcami asynchronicznymi i API Node.js
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - Opanowanie TypeScript z zaawansowanymi typami, generykami i ścisłym bezpieczeństwem typów
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - Pisanie idiomatycznego kodu PHP z nowoczesnymi funkcjami i optymalizacjami wydajności
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - Opanowanie nowoczesnej Javy ze strumieniami, współbieżnością i optymalizacją JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - Pisanie idiomatycznego kodu Elixir z wzorcami OTP, programowaniem funkcyjnym i frameworkami Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - Pisanie nowoczesnego kodu C# z zaawansowanymi funkcjami i optymalizacją .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - Opanowanie rozwoju Scala klasy enterprise z programowaniem funkcyjnym, systemami rozproszonymi i przetwarzaniem big data
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Opanowanie tworzenia aplikacji Flutter z Dartem, widgetami i integracjami z platformami
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - Tworzenie gier w Unity z zoptymalizowanymi skryptami i strojenie wydajności
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Opanowanie tworzenia pluginów serwerowych Minecraft z API Bukkit, Spigot i Paper
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Tworzenie natywnych aplikacji iOS w Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - Pisanie złożonych zapytań SQL, optymalizacja planów wykonania i projektowanie znormalizowanych schematów

### Infrastruktura i Operacje
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - Rozwiązywanie problemów produkcyjnych, analiza logów i naprawa błędów wdrożeniowych
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - Konfiguracja pipeline'ów CI/CD, kontenerów Docker i wdrożeń w chmurze
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - Projektowanie infrastruktury AWS/Azure/GCP i optymalizacja kosztów chmury
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - Projektowanie infrastruktury hybrydowej w AWS/Azure/GCP i środowiskach on-premises OpenStack
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - Projektowanie infrastruktury cloud-native opartej na Kubernetes i zasadach GitOps w AWS/Azure/GCP oraz środowiskach hybrydowych.
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - Optymalizacja zapytań SQL, projektowanie wydajnych indeksów i obsługa migracji baz danych
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - Zarządzanie operacjami bazodanowymi, backupami, replikacją i monitoringiem
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - Pisanie zaawansowanych modułów Terraform, zarządzanie plikami stanu oraz wdrażanie najlepszych praktyk IaC
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - Obsługa incydentów produkcyjnych z pilnością i precyzją
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - Debugowanie łączności sieciowej, konfiguracja load balancerów i analiza wzorców ruchu
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - Specjalista od doświadczenia dewelopera, usprawniający narzędzia, konfigurację i przepływy pracy

### Jakość i bezpieczeństwo
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - Ekspert od przeglądu kodu ze szczególnym naciskiem na bezpieczeństwo konfiguracji i niezawodność produkcji
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - Przegląd kodu pod kątem podatności i zapewnienie zgodności z OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - Tworzenie kompleksowych pakietów testów: jednostkowych, integracyjnych i e2e
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - Profilowanie aplikacji, optymalizacja wąskich gardeł i wdrażanie strategii cache'owania
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - Specjalista ds. debugowania błędów, nieudanych testów i nieoczekiwanych zachowań
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - Wyszukiwanie wzorców błędów, stack trace'ów i anomalii w logach i bazach kodu
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - Ekspert w badaniach internetowych, stosujący zaawansowane techniki wyszukiwania i syntezy

### Dane i AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - Ekspert analizy danych: zapytania SQL, operacje BigQuery, wnioski z danych
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - Budowa pipeline'ów ETL, hurtowni danych i architektur streamingu
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - Tworzenie aplikacji LLM, systemów RAG i pipeline'ów promptów
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - Implementacja pipeline'ów ML, serwowanie modeli i inżynieria cech
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - Budowa pipeline'ów ML, śledzenie eksperymentów i rejestry modeli
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - Optymalizacja promptów dla LLM i systemów AI

### Domeny specjalistyczne
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - Tworzenie specyfikacji OpenAPI/Swagger oraz dokumentacji dla deweloperów
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Integracja Stripe, PayPal i procesorów płatności
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - Tworzenie modeli finansowych, backtest strategii tradingowych, analiza danych rynkowych
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - Monitorowanie ryzyka portfela, wskaźników R-multiple i limitów pozycji
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - Refaktoryzacja starych baz kodu i wdrażanie stopniowej modernizacji
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - Zarządza kontekstem pomiędzy wieloma agentami i zadaniami długoterminowymi

### Dokumentacja
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - Tworzy kompleksową dokumentację techniczną na podstawie istniejących baz kodu
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - Tworzenie diagramów Mermaid: flowchartów, sekwencji, ERD i architektur
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - Tworzy wyczerpujące referencje techniczne oraz dokumentację API
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - Tworzy instrukcje krok po kroku i materiały edukacyjne na podstawie kodu

### Biznes i marketing
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - Analiza metryk, tworzenie raportów i śledzenie KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - Pisanie postów na bloga, treści do mediów społecznościowych i newsletterów e-mailowych
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** - Partner do rekrutacji, wdrożeń/zwolnień, urlopów, ocen wydajności, zgodnych polityk i relacji pracowniczych.
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - Tworzenie szablonów maili cold, follow-upów i ofert
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - Obsługa zgłoszeń, odpowiedzi FAQ i wiadomości od klientów
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - Tworzenie polityk prywatności, regulaminów, zrzeczeń i powiadomień prawnych

### SEO i optymalizacja treści
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - Analizuje dostarczoną treść pod kątem jakości, sygnałów E-E-A-T i najlepszych praktyk SEO
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - Tworzy zoptymalizowane meta tytuły, opisy i sugestie adresów URL
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - Analizuje użycie słów kluczowych, oblicza ich gęstość, sugeruje warianty semantyczne
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - Optymalizuje strukturę treści, hierarchię nagłówków i oznaczenia schematów
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - Formatuje treści pod kątem wyróżnionych fragmentów i funkcji SERP
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - Identyfikuje nieaktualne elementy i sugeruje aktualizacje treści
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - Analizuje wiele stron pod kątem nakładania się słów kluczowych i konfliktów
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - Analizuje treść pod kątem sygnałów E-E-A-T i wskaźników zaufania
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - Pisze treści zoptymalizowane pod SEO na podstawie słów kluczowych i wytycznych
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - Tworzy konspekty treści, klastry tematyczne i kalendarze publikacji

## Przypisania modeli

Wszystkie 76 subagentów skonfigurowano z określonymi modelami Claude w zależności od złożoności zadania:

### 🚀 Haiku (szybki i ekonomiczny) - 15 agentów
**Model:** `haiku`
- `data-scientist` - Zapytania SQL i analiza danych
- `api-documenter` - Dokumentacja OpenAPI/Swagger
- `reference-builder` - Wyjątkowo szczegółowe referencje techniczne i dokumentacja API
- `business-analyst` - Śledzenie metryk i KPI
- `content-marketer` - Posty na blogu i w mediach społecznościowych
- `customer-support` - Zgłoszenia wsparcia i FAQ
- `sales-automator` - Maile ofertowe i propozycje sprzedażowe
- `search-specialist` - Badania internetowe i gromadzenie informacji
- `legal-advisor` - Polityki prywatności i dokumenty zgodności
- `seo-meta-optimizer` - Optymalizacja meta tytułów i opisów
- `seo-keyword-strategist` - Analiza gęstości słów kluczowych i semantyki
- `seo-structure-architect` - Struktura treści i oznaczenia schematów
- `seo-snippet-hunter` - Formatowanie pod wyróżnione fragmenty
- `seo-content-refresher` - Aktualizacje świeżości treści
- `seo-cannibalization-detector` - Wykrywanie nakładania się słów kluczowych
- `seo-content-planner` - Kalendarze publikacji i konspekty treści

### ⚡ Sonnet (zrównoważona wydajność) - 45 agentów
**Model:** `sonnet`

**Rozwój i Języki:**
- `python-pro` - Programowanie w Pythonie z zaawansowanymi funkcjami
- `ruby-pro` - Programowanie w Ruby z metaprogramowaniem, wzorcami Rails i tworzeniem gemów
- `javascript-pro` - Nowoczesny JavaScript i Node.js
- `typescript-pro` - Zaawansowany TypeScript z systemami typów
- `golang-pro` - Programowanie współbieżne w Go i wzorce idiomatyczne
- `rust-pro` - Bezpieczeństwo pamięci w Rust i programowanie systemowe
- `c-pro` - Programowanie w C i systemy wbudowane
- `cpp-pro` - Nowoczesny C++ ze STL i szablonami
- `php-pro` - Nowoczesny PHP z zaawansowanymi funkcjami
- `java-pro` - Nowoczesna Java ze strumieniami i współbieżnością
- `elixir-pro` - Elixir z wzorcami OTP i Phoenix
- `csharp-pro` - Nowoczesny C# z .NET i wzorcami projektowymi
- `scala-pro` - Enterprise Scala z Apache Pekko, Akka, Spark oraz ZIO/Cats Effect
- `flutter-expert` - Programowanie w Flutter z zarządzaniem stanem i animacjami
- `unity-developer` - Tworzenie i optymalizacja gier w Unity
- `minecraft-bukkit-pro` - Tworzenie pluginów do Minecraft z Bukkit/Spigot/Paper
- `ios-developer` - Natywne aplikacje iOS ze Swift/SwiftUI
- `frontend-developer` - Komponenty React i interfejsy użytkownika
- `ui-ux-designer` - Projektowanie interfejsów i makiet
- `ui-visual-validator` - Rygorystyczna walidacja UI przez analizę zrzutów ekranu
- `backend-architect` - Projektowanie API i mikroserwisów
- `mobile-developer` - Aplikacje React Native/Flutter
- `sql-pro` - Zaawansowana optymalizacja zapytań SQL
- `graphql-architect` - Schematy i resolver’y GraphQL

**Infrastruktura i Operacje:**
- `devops-troubleshooter` - Debugowanie produkcyjne
- `deployment-engineer` - Pipeline’y CI/CD
- `database-optimizer` - Optymalizacja zapytań
- `database-admin` - Operacje bazodanowe
- `terraform-specialist` - Infrastruktura jako kod
- `network-engineer` - Konfiguracja sieci
- `dx-optimizer` - Optymalizacja doświadczeń programisty
- `data-engineer` - Pipeline’y ETL

**Jakość i Wsparcie:**
- `test-automator` - Tworzenie zestawów testów
- `code-reviewer` - Analiza jakości kodu
- `debugger` - Badanie błędów
- `error-detective` - Analiza logów
- `ml-engineer` - Wdrażanie modeli ML
- `legacy-modernizer` - Migracje frameworków
- `payment-integration` - Przetwarzanie płatności
- `mermaid-expert` - Diagramy Mermaid i dokumentacja wizualna
- `flutter-expert` - Programowanie w Flutterze
- `seo-content-auditor` - Audyt jakości treści i analiza E-E-A-T
- `seo-authority-builder` - Optymalizacja sygnałów autorytetu
- `seo-content-writer` - Tworzenie treści zoptymalizowanych pod SEO

### 🧠 Opus (Maksymalna Wydajność) - 15 agentów
**Model:** `opus`
- `ai-engineer` - Aplikacje LLM i systemy RAG
- `security-auditor` - Analiza podatności
- `performance-engineer` - Optymalizacja aplikacji
- `incident-responder` - Obsługa incydentów produkcyjnych
- `mlops-engineer` - Infrastruktura ML
- `architect-reviewer` - Spójność architektoniczna
- `cloud-architect` - Projektowanie infrastruktury chmurowej
- `prompt-engineer` - Optymalizacja promptów LLM
- `context-manager` - Koordynacja wielu agentów
- `quant-analyst` - Modelowanie finansowe
- `risk-manager` - Zarządzanie ryzykiem portfela
- `docs-architect` - Kompleksowa dokumentacja techniczna na podstawie kodu
- `tutorial-engineer` - Samouczki krok po kroku i treści edukacyjne

## Instalacja

Te subagenty są automatycznie dostępne po umieszczeniu ich w katalogu `~/.claude/agents/`.

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## Użycie

### Automatyczne wywołanie
Claude Code automatycznie deleguje zadania do odpowiedniego subagenta na podstawie kontekstu zadania oraz opisu subagenta.

### Jawne wywołanie
Wspomnij nazwę subagenta w swojej prośbie:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## Przykłady użycia

### Zadania pojedynczego agenta
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```

### Wieloagentowe przepływy pracy

Te subagentki współpracują ze sobą bezproblemowo, a do bardziej złożonych orkiestracji możesz użyć kolekcji **[Claude Code Commands](https://github.com/wshobson/commands)**, która zawiera 52 gotowe komendy ukośnikowe wykorzystujące te subagentki w zaawansowanych przepływach pracy.

```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### Zaawansowane przepływy pracy z poleceniami Slash

Do bardziej zaawansowanej orkiestracji z wieloma subagentami użyj towarzyszącego repozytorium [Commands](https://github.com/wshobson/commands):

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## Formatka subagenta

Każdy subagent stosuje następującą strukturę:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### Konfiguracja Modelu

Od wersji Claude Code v1.0.64, subagenci mogą określić, którego modelu Claude powinni używać. Umożliwia to delegowanie zadań w sposób opłacalny w zależności od złożoności:

- **Niska złożoność (Haiku)**: Proste zadania, takie jak podstawowa analiza danych, generowanie dokumentacji i standardowe odpowiedzi
- **Średnia złożoność (Sonnet)**: Zadania deweloperskie, przegląd kodu, testowanie i standardowa praca inżynierska  
- **Wysoka złożoność (Opus)**: Krytyczne zadania, takie jak audyty bezpieczeństwa, przegląd architektury, reakcja na incydenty oraz inżynieria AI/ML

Dostępne modele (z uproszczonymi nazwami od Claude Code v1.0.64):
- `haiku` - Szybki i ekonomiczny do prostych zadań
- `sonnet` - Zrównoważona wydajność dla większości prac deweloperskich
- `opus` - Najbardziej zaawansowany do złożonej analizy i krytycznych zadań

Jeśli model nie zostanie określony, subagent użyje domyślnego modelu systemowego.

## Wzorce Orkiestracji Agentów

Claude Code automatycznie koordynuje agentów, wykorzystując te popularne wzorce:

### Przepływy pracy sekwencyjnej
```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### Warunkowe rozgałęzianie
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### Przegląd i walidacja
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```

## Kiedy używać którego agenta

### 🏗️ Planowanie i Architektura
- **backend-architect**: Projektowanie API, schematy baz danych, architektura systemu
- **frontend-developer**: Planowanie UI/UX, architektura komponentów
- **ui-ux-designer**: Projektowanie interfejsu, wireframe'y, systemy projektowe, badania użytkowników
- **cloud-architect**: Projektowanie infrastruktury, planowanie skalowalności

### 🔧 Implementacja i Rozwój  
- **python-pro**: Zadania programistyczne w Pythonie
- **ruby-pro**: Metaprogramowanie w Ruby, aplikacje Rails, rozwój gemów, testowanie RSpec/Minitest
- **golang-pro**: Zadania programistyczne w Go
- **rust-pro**: Rozwój w Rust, bezpieczeństwo pamięci, programowanie systemowe
- **c-pro**: Programowanie w C, systemy wbudowane, kod o wysokiej wydajności
- **javascript-pro**: Nowoczesny JavaScript, wzorce asynchroniczne, kod Node.js/przeglądarkowy
- **typescript-pro**: Zaawansowany TypeScript, generyki, inferencja typów, wzorce korporacyjne
- **java-pro**: Nowoczesny rozwój w Javie, strumienie, współbieżność, Spring Boot
- **elixir-pro**: Programowanie w Elixir, wzorce OTP, frameworki Phoenix, programowanie funkcyjne
- **csharp-pro**: Nowoczesny rozwój w C#, frameworki .NET, wzorce korporacyjne
- **scala-pro**: Scala korporacyjna z programowaniem funkcyjnym, aktorzy Apache Pekko/Akka, Apache Spark, ZIO/Cats Effect, architektury reaktywne
- **flutter-expert**: Rozwój w Flutter, Dart, zarządzanie stanem, animacje, wdrożenia wieloplatformowe
- **unity-developer**: Tworzenie gier w Unity, skrypty C#, optymalizacja wydajności
- **minecraft-bukkit-pro**: Tworzenie pluginów Minecraft, systemy zdarzeń, funkcje po stronie serwera
- **ios-developer**: Natywne aplikacje iOS w Swift/SwiftUI
- **sql-pro**: Zapytania do baz danych, projektowanie schematów, optymalizacja zapytań
- **mobile-developer**: Programowanie w React Native/Flutter

### 🛠️ Operacje i Utrzymanie
- **devops-troubleshooter**: Problemy produkcyjne, trudności z wdrożeniem
- **incident-responder**: Krytyczne awarie wymagające natychmiastowej reakcji
- **database-optimizer**: Optymalizacja zapytań, strategie indeksowania
- **database-admin**: Strategie backupu, replikacja, zarządzanie użytkownikami, odzyskiwanie po awarii
- **terraform-specialist**: Infrastructure as Code, moduły Terraform, zarządzanie stanem
- **network-engineer**: Łączność sieciowa, load balancery, SSL/TLS, debugowanie DNS

### 📊 Analiza i Optymalizacja
- **performance-engineer**: Wąskie gardła aplikacji, optymalizacja
- **security-auditor**: Skanowanie podatności, kontrole zgodności
- **data-scientist**: Analiza danych, wnioski, raportowanie
- **mlops-inżynier**: Infrastruktura ML, śledzenie eksperymentów, rejestry modeli, automatyzacja pipeline'ów

### 🧪 Zapewnienie Jakości
- **recenzent-kodu**: Jakość kodu, bezpieczeństwo konfiguracji, niezawodność produkcji
- **automat-tester**: Strategia testowania, tworzenie zestawów testowych
- **debugger**: Analiza błędów, rozwiązywanie problemów
- **detektyw-błędów**: Analiza logów, rozpoznawanie wzorców błędów, analiza przyczyn źródłowych
- **specjalista-wyszukiwania**: Głębokie badania internetowe, analiza konkurencji, weryfikacja faktów

### 📚 Dokumentacja
- **dokumentator-api**: Specyfikacje OpenAPI/Swagger, dokumentacja API
- **architekt-dokumentacji**: Kompleksowa dokumentacja techniczna, przewodniki architektury, podręczniki systemowe
- **twórca-referencji**: Wyjątkowo szczegółowe referencje API, przewodniki konfiguracyjne, dokumentacja parametrów
- **inżynier-tutoriali**: Samouczki krok po kroku, ścieżki nauki, treści edukacyjne

### 💼 Biznes i Strategia
- **analityk-biznesowy**: KPI, modele przychodów, prognozy wzrostu, metryki inwestorskie
- **menedżer-ryzyka**: Ryzyko portfela, strategie zabezpieczające, R-multiple, rozmiar pozycji
- **specjalista-marketingu-treści**: Treści SEO, wpisy na bloga, media społecznościowe, kampanie e-mailowe
- **automat-sprzedaży**: Cold maile, follow-upy, propozycje, pielęgnowanie leadów
- **wsparcie-klienta**: Zgłoszenia, FAQ, dokumentacja pomocy, rozwiązywanie problemów
- **doradca-prawny** - Sporządzanie polityki prywatności, regulaminów, zastrzeżeń i powiadomień prawnych

## Najlepsze Praktyki

### 🎯 Delegowanie Zadań
1. **Pozwól Claude Code delegować automatycznie** – Główny agent analizuje kontekst i wybiera optymalnych agentów
2. **Bądź precyzyjny w wymaganiach** – Uwzględnij ograniczenia, stos technologiczny i wymagania jakościowe
3. **Zaufaj ekspertom agentów** – Każdy agent jest zoptymalizowany dla swojej dziedziny

### 🔄 Przepływy pracy wielu agentów
4. **Zaczynaj od ogólnych żądań** – Pozwól agentom koordynować złożone zadania wieloetapowe
5. **Przekazuj kontekst między agentami** – Upewnij się, że agenci mają niezbędne informacje
6. **Przeglądaj punkty integracji** – Sprawdź, jak wyniki różnych agentów współpracują ze sobą

### 🎛️ Jawna Kontrola
7. **Używaj wywołań jawnych do specjalnych potrzeb** – Gdy chcesz uzyskać opinię konkretnego eksperta
8. **Łącz wielu agentów strategicznie** – Różni specjaliści mogą nawzajem weryfikować swoją pracę
9. **Zamawiaj konkretne wzorce recenzji** – „Poproś audytora bezpieczeństwa o przegląd projektu API architekta backendu”

### 📈 Optymalizacja
10. **Monitoruj skuteczność agentów** - Dowiedz się, którzy agenci najlepiej sprawdzają się w Twoich przypadkach użycia
11. **Iteruj na złożonych zadaniach** - Wykorzystaj informacje zwrotne od agenta do dopracowania wymagań
12. **Wykorzystaj mocne strony agentów** - Dopasuj złożoność zadania do możliwości agenta

## Współtworzenie

Aby dodać nowego subagenta:
1. Utwórz nowy plik `.md` zgodnie z powyższym formatem
2. Używaj nazw pisanych małymi literami, oddzielonych myślnikami
3. Napisz jasne opisy, kiedy należy użyć subagenta
4. Dołącz szczegółowe instrukcje w systemowym komunikacie

## Rozwiązywanie problemów

### Typowe problemy

**Agent nie jest wywoływany automatycznie:**
- Upewnij się, że Twoje zgłoszenie jasno wskazuje domenę (np. "problem z wydajnością" → performance-engineer)
- Bądź precyzyjny w określaniu rodzaju zadania (np. "przegląd kodu" → code-reviewer)

**Nieoczekiwany wybór agenta:**
- Podaj więcej informacji o swojej technologii i wymaganiach
- Skorzystaj z jawnego wywołania, jeśli potrzebujesz konkretnego agenta

**Wielu agentów udziela sprzecznych porad:**
- To normalne - różni specjaliści mogą mieć różne priorytety
- Poproś o wyjaśnienie: "Pogódź zalecenia od security-auditor i performance-engineer"

**Agent wydaje się nie mieć kontekstu:**
- Podaj informacje wprowadzające w swoim zgłoszeniu
- Odnieś się do wcześniejszych rozmów lub ustalonych wzorców

### Uzyskiwanie pomocy

Jeśli agenci nie działają zgodnie z oczekiwaniami:
1. Sprawdź opisy agentów w ich indywidualnych plikach
2. Spróbuj użyć bardziej precyzyjnego języka w swoich zgłoszeniach
3. Skorzystaj z jawnego wywołania, aby przetestować konkretnego agenta
4. Podaj więcej informacji o swoim projekcie i celach

## Licencja

Ten projekt jest objęty licencją MIT - szczegóły znajdują się w pliku [LICENSE](LICENSE).

## Dowiedz się więcej

- [Dokumentacja Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Dokumentacja Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---