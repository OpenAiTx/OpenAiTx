# Node HL7 Client

> Un client HL7 pur TypeScript pour Node.js permettant une communication transparente avec les serveurs HL7.

`node-hl7-client` est une bibliothèque légère, sans dépendance externe, conçue pour une communication haute performance avec les courtiers/serveurs HL7. Elle prend en charge l'envoi de messages HL7 correctement formatés, la gestion des réponses, et le traitement des formats de messages HL7 uniques ou groupés (MSH, BHS et FHS).

## ✨ Fonctionnalités

* ⚡ **Aucune Dépendance Externe** – Performances ultra-rapides sans surcharge.
* 🔁 **Reconnexion et Réessai Automatiques** – Gère automatiquement les interruptions de connexion.
* 🧠 **TypeScript + Définitions Typées** – Entièrement typé pour les environnements de développement modernes.
* 🤝 **Package Compagnon Disponible** – À utiliser avec [`node-hl7-server`](https://www.npmjs.com/package/node-hl7-server) pour une solution HL7 complète.
* 💻 **Compatibilité Multi-plateforme** – Fonctionne sur Windows, macOS et Linux.
* 🧭 **Basé sur les Standards** – Les builders typés garantissent que les segments MSH, BHS et FHS sont conformes aux spécifications HL7.org.

## 📦 Installation

```bash
npm install node-hl7-client
```

## 📚 Contenu Inclus

* **Client HL7** – Se connecte à un serveur HL7 distant, envoie des messages et traite les réponses.
* **Parseur HL7** – Analyse les chaînes de messages HL7 brutes en segments accessibles.
* **Builder HL7** – Génère des messages HL7 valides, des lots, ou des fichiers de lots HL7 complets.

## 🧾 Table des Matières

1. [Définitions des mots-clés](#définitions-des-mots-clés)
2. [Documentation](#documentation)
3. [Remerciements](#remerciements)
4. [Licence](#licence)

## Définitions des mots-clés

Ce package NPM est conçu pour prendre en charge des applications médicales susceptibles d’avoir un impact sur les soins et le diagnostic des patients. Cette documentation, ainsi que son package compagnon [node-hl7-server](https://www.npmjs.com/package/node-hl7-server), utilise les définitions standardisées suivantes pour plus de clarté et d’interopérabilité :

Des mots-clés comme **« DOIT »**, **« NE DOIT PAS »**, **« REQUIS »**, **« DEVRA »**, **« NE DEVRA PAS »**, **« DEVRAIT »**, **« NE DEVRAIT PAS »**, **« RECOMMANDÉ »**, **« PEUT »**, et **« OPTIONNEL »** sont utilisés de façon cohérente dans toute la documentation. Ces termes conservent leur signification même lorsqu'ils ne sont pas en majuscules.

* **DOIT** – Ce mot, ou les termes **« REQUIS »** ou **« DEVRA »**, indique une exigence absolue de la spécification.
* **NE DOIT PAS** – Cette expression, ou l’expression **« NE DEVRA PAS »**, indique une interdiction absolue de la spécification.
* **DEVRAIT** – Ce mot, ou l’adjectif **« RECOMMANDÉ »**, signifie qu’il peut exister des raisons valables dans certaines circonstances d’ignorer un élément particulier, mais les implications complètes doivent être comprises et soigneusement évaluées avant de le faire.
* **NE DEVRAIT PAS** – Cette expression, ou l’expression **« NON RECOMMANDÉ »**, signifie qu’il peut exister des raisons valables dans certaines circonstances où le comportement est acceptable ou même utile. Les implications complètes doivent être comprises et le cas soigneusement évalué avant la mise en œuvre.
* **PEUT** – Ce mot, ou l’adjectif **« OPTIONNEL »**, signifie que l’élément est réellement optionnel. Les implémentations qui n’incluent pas une option particulière DOIVENT néanmoins interopérer avec celles qui l’incluent, bien qu’avec une fonctionnalité réduite. De même, les implémentations qui incluent une option DOIVENT interopérer avec celles qui ne l’incluent pas (sauf, bien sûr, pour la fonctionnalité spécifique apportée par l’option).

## 📖 Documentation

La documentation complète de l’API, des exemples d’utilisation et des configurations avancées sont disponibles sur le site du projet :
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 Remerciements

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – Source d’inspiration pour la logique de connexion.
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – Référence de conception pour le parseur et le builder.
* Ma femme et ma petite fille – pour leur amour, leur patience et leur inspiration.

## 📄 Licence

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---