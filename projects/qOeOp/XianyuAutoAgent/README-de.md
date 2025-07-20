<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Intelligentes Kundendienst-Robotersystem für Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Speziell entwickelte KI-Lösung für die Xianyu-Plattform zur 7×24h-Automatisierung, unterstützt kollaborative Entscheidungsfindung durch mehrere Experten, intelligentes Verhandeln und kontextbewusste Dialoge.

## 🎮 Playground - Schnelltest (Konfigurationsfreie Version)

Keine lokale Umgebung oder Secrets notwendig! **Einfach Parameter über GitHub Actions Weboberfläche eingeben**, um den Xianyu-Bot mit einem Klick zu starten.

### So geht's
1. **Forke dieses Repository** → Klicke oben rechts auf den `Fork`-Button
2. **Action auslösen**:
   - Gehe in deinem Repository auf den Tab `Actions`
   - Wähle den Workflow **`🚀 Run Service`**
   - Klicke auf den Button **`Run workflow`** und gib die Parameter ein:
      - `API Key`: Füge deinen LLM API Key ein (z.B. Aliyun DashScope)
      - `Cookies`: Füge den vollständigen Cookie-String der Xianyu-Webseite ein
3. **Protokolle prüfen**:
   - Nach dem Start lauscht der Bot automatisch auf Xianyu-Nachrichten
   - Suche im Action-Protokoll nach `🤖 Reply:`, um die Dialoghistorie zu sehen

### Hinweise
⚠️ Temporäre Laufzeitbeschränkung beachten:
- Standardmäßig läuft der Bot **30 Minuten** (GitHub Free Account Limit)
- Sensible Daten (z.B. Cookie) werden **nicht gespeichert**, gelten nur für diesen Durchlauf

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Hauptfunktionen

### Intelligente Dialog-Engine
| Funktionsmodul | Technische Umsetzung    | Schlüsselmerkmale                                              |
| -------------- | ---------------------- | -------------------------------------------------------------- |
| Kontextbewusst | Speicherung Verlauf     | Leichtgewichtiges Dialog-Gedächtnis, gesamte Historie als LLM-Kontext |
| Expertenrouting| LLM-Prompt+Regelrouter | Intentionserkennung durch Prompt Engineering → dynamische Zuweisung an Experten-Agenten, unterstützt Wechsel zwischen Verhandlung/Technik/Support |

### Feature-Matrix
| Modul      | Bereits umgesetzt                   | In Planung                      |
| ---------- | ----------------------------------- | ------------------------------- |
| Kernengine | ✅ Automatische LLM-Antwort<br>✅ Kontextverwaltung | 🔄 Erweiterte Sentiment-Analyse         |
| Verhandeln | ✅ Stufenweises Preisnachlass-System | 🔄 Marktpreis-Vergleich                  |
| Support    | ✅ Integration Websuche              | 🔄 Wissensdatenbank (RAG)                |

## 🚴 Schnellstart

### Systemvoraussetzungen
- JDK 21+
- Maven 3.9.10+

### Installationsschritte

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Beteiligung und Beiträge

Vorschläge können gerne über Issues eingereicht oder Code per PR beigesteuert werden. Bitte befolge die [Beitragsrichtlinien](https://contributing.md/).



## 🛡 Hinweise

⚠️ Hinweis: **Dieses Projekt dient ausschließlich zu Lern- und Austauschzwecken. Bei Urheberrechtsverletzungen kontaktieren Sie bitte den Autor zur Löschung.**

Aufgrund der besonderen Natur des Projekts kann das Entwicklungsteam jederzeit die **Aktualisierung einstellen** oder das **Projekt löschen**.


## 🧸 Besonderer Dank

Dieses Projekt wurde auf Basis der folgenden Open-Source-Projekte neu entwickelt:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) – Intelligentes Xianyu-Kundendienstrobotersystem, entwickelt von [@shaxiu](https://github.com/shaxiu) und [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---