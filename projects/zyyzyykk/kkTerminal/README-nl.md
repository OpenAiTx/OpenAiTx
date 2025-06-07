# kkTerminal

> kkTerminal, een terminal voor Web SSH-verbinding
>
> Auteur: [zyyzyykk](https://github.com/zyyzyykk/)
>
> Broncode: https://github.com/zyyzyykk/kkTerminal
>
> Docker Hub-adres: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> Voorbeeld: https://ssh.kkbpro.com/
>
> Update tijd: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ Snelle integratie

Gebruik de `iframe` tag in HTML-webpagina's voor snelle integratie:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 Deployen met Docker

1. Afbeelding ophalen:

```bash
docker pull zyyzyykk/kkterminal
```

2. Maak en start een container voor poortkoppeling: `-p poort:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. Aangepast art-woord: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. Toegang via browser: `http://server-ip:3000/`

### 🛸 Voorbeeld

Bezoek de volgende website: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**Meer modulevoorbeelden**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 Functiebeschrijving

1. kkTerminal is een terminal voor Web SSH-verbinding. Klik op het terminalpictogram linksboven en selecteer de verbindingsinstellingen om een SSH-verbinding tot stand te brengen

2. Ondersteunt het gebruik van `iframe` tags in webpagina's voor snelle integratie in externe websites

3. Ondersteunt het aanpassen van de terminalconfiguratie via [URL Parameters](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. Ondersteunt internationalisatie en taalschakeling tussen Chinees en Engels

5. Ondersteunt lokale PC-installatie, opent automatisch een browservenster bij het opstarten

6. Ondersteunt adaptieve venstergrootte en Chinese invoer

7. Ondersteunt aangepaste voorkeuren, waarmee gebruikers achtergrond/voorgrondkleur, lettergrootte, cursorstijl, TCode activeren voor de terminal, enz. kunnen kiezen

8. Ondersteunt herstarten: Na het wijzigen van SSH-verbinding of voorkeuren wordt automatisch herstart, of kan handmatig worden herstart na verbreken SSH-verbinding

9. Ondersteunt kopiëren en plakken:

   - Kopiëren: Net als in de `Git` terminal, tekst selecteren kopieert het automatisch

   - Plakken: Net als in de `Cmd` terminal, rechtsklik om te plakken (browsertoestemming vereist)


9. Ondersteunt bestandsbeheer, open het bestandsbeheermodule om bestanden/mappen te bekijken, uit te pakken, uploaden en downloaden

10. Ondersteunt sneltoetsen zoals meerdere/alle bestanden selecteren, kopiëren en plakken, knippen, selectie wisselen, openen, enz.

11. Ondersteunt bestandsweergave en -bewerking, wijzig het bestand en sla op naar de externe server met `ctrl+s`

12. Ondersteunt [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md), waarmee geautomatiseerde workflows vergelijkbaar met Shell-scripts kunnen worden bereikt via aangepaste TCode

13. Ondersteunt bewerkingsopname en cloud-synchronisatie

14. Ondersteunt Cooperate-, Monitor- en Docker-functies

### 👨‍💻 Update-geschiedenis

##### zyyzyykk/kkterminal:3.6.0: latest

- Geavanceerde Cooperate-functie toegevoegd
- Geavanceerde Monitor-functie toegevoegd
- Geavanceerde Docker-functie toegevoegd
- Geoptimaliseerd pakketvolume en webpaginaweergave

##### zyyzyykk/kkterminal:3.5.6: 

- Ondersteunt meer URL-parameters
- Editor tekst- & afbeeldingsgrootte-percentage toegevoegd
- Webpaginaweergave geoptimaliseerd

##### zyyzyykk/kkterminal:3.5.3: 

- URL-parameter toegevoegd voor aangepaste terminalconfiguratie
- Bug opgelost met herstarten van meerdere vensters
- Bewerking-opname en cloud-synchronisatie toegevoegd
- Gedeeltelijke codelogica herzien

[**Historisch update-overzicht**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 Architectuur

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ Over dit project

Beste gebruikers,

Tot mijn spijt moet ik aankondigen dat ik wegens beperkte tijd en energie `kkTerminal` in de toekomst niet meer kan onderhouden.

Als je geïnteresseerd bent in `kkTerminal` of het wilt blijven onderhouden, neem gerust contact met me op of open een issue.

Als je bugs ontdekt of nieuwe functies wilt ontwikkelen, open dan ook gerust een issue.

Tot slot, bedankt voor je steun aan `kkTerminal` en ik hoop oprecht dat `kkTerminal` echt nuttig voor je kan zijn.

Met vriendelijke groet,

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 Sterren

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---