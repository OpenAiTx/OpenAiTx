![Banner image](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n – Sichere Workflow-Automatisierung für technische Teams

n8n ist eine Workflow-Automatisierungsplattform, die technischen Teams die Flexibilität von Code mit der Geschwindigkeit von No-Code bietet. Mit über 400 Integrationen, nativen KI-Funktionen und einer Fair-Code-Lizenz ermöglicht n8n die Erstellung leistungsstarker Automatisierungen – bei voller Kontrolle über Ihre Daten und Deployments.

![n8n.io - Screenshot](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Zentrale Funktionen

- **Code nach Bedarf**: Schreiben Sie JavaScript/Python, fügen Sie npm-Pakete hinzu oder nutzen Sie die visuelle Oberfläche
- **KI-native Plattform**: Erstellen Sie KI-Agenten-Workflows auf Basis von LangChain mit eigenen Daten und Modellen
- **Volle Kontrolle**: Self-Hosting mit unserer Fair-Code-Lizenz oder Nutzung unseres [Cloud-Angebots](https://app.n8n.cloud/login)
- **Enterprise-tauglich**: Erweiterte Berechtigungen, SSO und Air-Gap-Deployments
- **Aktive Community**: Über 400 Integrationen und 900+ sofort nutzbare [Vorlagen](https://n8n.io/workflows)

## Schnellstart

Testen Sie n8n sofort mit [npx](https://docs.n8n.io/hosting/installation/npm/) (benötigt [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Oder Deployment mit [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Greifen Sie auf den Editor unter http://localhost:5678 zu

## Ressourcen

- 📚 [Dokumentation](https://docs.n8n.io)
- 🔧 [400+ Integrationen](https://n8n.io/integrations)
- 💡 [Beispiel-Workflows](https://n8n.io/workflows)
- 🤖 [KI- & LangChain-Leitfaden](https://docs.n8n.io/langchain/)
- 👥 [Community-Forum](https://community.n8n.io)
- 📖 [Community-Tutorials](https://community.n8n.io/c/tutorials/28)

## Support

Sie benötigen Hilfe? Unser Community-Forum ist der richtige Ort, um Unterstützung zu erhalten und sich mit anderen Nutzern auszutauschen:
[community.n8n.io](https://community.n8n.io)

## Lizenz

n8n ist [fair-code](https://faircode.io) und wird unter der [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) sowie der [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md) bereitgestellt.

- **Source Available**: Quellcode immer einsehbar
- **Self-Hostbar**: Überall einsetzbar
- **Erweiterbar**: Eigene Nodes und Funktionen hinzufügen

[Enterprise-Lizenzen](mailto:license@n8n.io) sind für zusätzliche Funktionen und Support verfügbar.

Weitere Informationen zum Lizenzmodell finden Sie in den [Dokumentationen](https://docs.n8n.io/reference/license/).

## Beitrag leisten

Einen Fehler gefunden 🐛 oder eine Feature-Idee ✨? Lesen Sie unseren [Beitragsleitfaden](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md), um loszulegen.

## Werde Teil des Teams

Sie möchten die Zukunft der Automatisierung mitgestalten? Schauen Sie sich unsere [Stellenangebote](https://n8n.io/careers) an und werden Sie Teil unseres Teams!

## Was bedeutet n8n?

**Kurze Antwort:** Es steht für „nodemation“ und wird „n-eight-n“ ausgesprochen.

**Lange Antwort:** „Ich bekomme diese Frage ziemlich oft gestellt (häufiger als erwartet), daher ist es wahrscheinlich am besten, sie hier zu beantworten. Als ich nach einem passenden Namen für das Projekt mit freier Domain suchte, habe ich schnell festgestellt, dass alle guten Namen bereits vergeben waren. Am Ende habe ich mich für nodemation entschieden. ‚node-‘ im Sinne von Node-View und der Verwendung von Node.js und ‚-mation‘ für ‚automation‘, was das Projekt ermöglichen soll. Allerdings gefiel mir die Länge des Namens nicht und ich konnte mir nicht vorstellen, so einen langen Begriff jedes Mal im CLI einzugeben. So entstand schließlich ‚n8n‘.“ – **Jan Oberhauser, Gründer und CEO, n8n.io**


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---