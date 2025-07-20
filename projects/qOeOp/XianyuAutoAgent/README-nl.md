<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">Engels</a>
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

# 🚀 Xianyu AutoAgent - Slimme Xianyu Klantenservice Robot Systeem

[![Java Versie](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Een AI-bewakingsoplossing speciaal voor het Xianyu-platform, realiseert 7×24 uur geautomatiseerde bewaking, ondersteunt samenwerking tussen meerdere experts, slimme prijsonderhandeling en contextbewuste gesprekken.

## 🎮 Playground - Snel Uitproberen (Zonder Configuratie)

Geen lokale omgeving of Secrets nodig! **Voer direct parameters in via de GitHub Actions webinterface** en start de Xianyu-bot met één klik.

### Hoe te gebruiken
1. **Fork deze repository** → Klik op de `Fork` knop rechtsboven
2. **Start een Action**:
   - Ga naar het tabblad `Actions` van jouw repository
   - Kies de **`🚀 Run Service`** workflow
   - Klik op de **`Run workflow`** knop en vul de parameters in:
      - `API Key`: Plak je grote model API Key (zoals Alibaba Cloud DashScope)
      - `Cookies`: Plak de volledige Cookie-string van Xianyu webinterface
3. **Bekijk de runtime logs**:
   - De bot luistert automatisch op Xianyu-berichten na het starten
   - Zoek in de Action logs naar `🤖 Reply:` om het gesprekslogboek te bekijken

### Opmerkingen
⚠️ Let op tijdelijke runtime beperkingen:
- Standaard runtime is **30 minuten** (GitHub gratis account limiet)
- Gevoelige informatie (zoals Cookies) **wordt niet opgeslagen**, alleen geldig voor deze sessie

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Kernfuncties

### Slimme Gespreksengine
| Functiemodule   | Technische Implementatie   | Belangrijkste Kenmerken                                        |
| --------------- | ------------------------- | ------------------------------------------------------------- |
| Contextbewust   | Opslag van gespreksgeschiedenis | Lichtgewicht gespreksgeheugenbeheer, volledige gespreksgeschiedenis als LLM-contextinput |
| Expert routering| LLM prompt+regelroutering | Intentieherkenning op basis van prompt engineering → Dynamische toewijzing aan expertagent, ondersteunt prijsonderhandeling/techniek/klantenservice scenario's |

### Zakelijke Functiematrix
| Module    | Gerealiseerd                        | In Planning                   |
| --------- | ----------------------------------- | ----------------------------- |
| Kernengine| ✅ LLM automatische antwoorden<br>✅ Contextbeheer | 🔄 Verbeterde sentimentanalyse        |
| Onderhandelingssysteem | ✅ Stapsgewijze prijsverlaging       | 🔄 Marktvergelijkingsfunctie           |
| Technische ondersteuning | ✅ Integratie met websearch         | 🔄 RAG-kennisbank uitbreiding         |

## 🚴 Snel Aan de Slag

### Vereisten voor de omgeving
- JDK 21+
- Maven 3.9.10+

### Installatiestappen

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
## 🤝 Bijdragen

Je bent welkom om suggesties in te dienen via Issues of code bij te dragen via PR's. Volg hierbij de [bijdragegids](https://contributing.md/).



## 🛡 Opmerkingen

⚠️ Let op: **Dit project is uitsluitend bedoeld voor studie en uitwisseling. Neem contact op met de auteur voor verwijdering bij inbreuk.**

Gezien de bijzondere aard van het project kan het ontwikkelteam op elk moment besluiten om **te stoppen met updaten** of het **project te verwijderen**.


## 🧸 Speciale dank

Dit project is herbouwd op basis van de volgende open source projecten:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Intelligent Xianyu klantenservice robotsysteem, ontwikkeld door [@shaxiu](https://github.com/shaxiu) en [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---