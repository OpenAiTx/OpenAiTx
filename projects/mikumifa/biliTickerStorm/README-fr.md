# 🎫 BiliTickerStorm

## ⚙️ Description du service

| Nom du service        | Description                  | Remarques      |
| --------------------- | --------------------------- | -------------- |
| `ticket-master`       | Service principal, responsable de l’ordonnancement des tâches | Déploiement instance unique |
| `ticket-worker`       | Worker de réservation de billets, extensible horizontalement | Supporte plusieurs instances |
| `gt-python`           | Service de gestion des captchas graphiques | Déploiement instance unique |

---

## 🚀 Étapes de déploiement rapide

> Pour la configuration du cluster, veuillez consulter le [Guide de configuration du cluster](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Installation depuis le dépôt distant (recommandé)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Installer le Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` est le répertoire du fichier de configuration pour la billetterie, monté dans le conteneur `ticket-master`. Le fichier de configuration de la billetterie est généré à l’aide de https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` est la configuration de notification pushplus. Après configuration, vous pouvez recevoir des notifications sur le résultat de la billetterie.
> - `ticketWorker.ticketInterval` est l’intervalle de tentative de billetterie en secondes, par défaut 300 millisecondes.
> - `ticketWorker.ticketTimeStart` est l’heure de démarrage programmée, au format `2025-05-20T13:14`. Si non renseigné, le conteneur commence la billetterie dès son lancement.

### 3. Mettre à jour le Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
---
</details> 
<details> <summary><strong>📦 Installation du Chart local</strong></summary>


### 1. Installer le Chart

```bash
# Cloner le dépôt
git clone https://github.com/mikumifa/biliTickerStorm
# Utiliser le Chart local
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Mettre à niveau le Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Commandes Générales</strong></summary>

### ⏹ Désinstallation
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Clause de non-responsabilité

Ce projet est sous licence MIT License, destiné uniquement à l'apprentissage et à la recherche personnels. Il est interdit d'utiliser ce projet à des fins commerciales lucratives, ainsi que pour toute forme de revente automatique, d'activités illégales ou de violation des règles des plateformes concernées. Toute conséquence résultant de ces usages sera entièrement à la charge de l'utilisateur, sans aucune responsabilité pour l'auteur.

Si vous forkez ou utilisez ce projet, vous devez impérativement respecter les lois et réglementations en vigueur ainsi que les règles de la plateforme cible.

## 💡 À propos de la fréquence d'accès et du contrôle de la concurrence
Ce projet a été conçu selon le principe strict de « non-intrusion » afin d'éviter toute perturbation des serveurs cibles (tels que Bilibili).

Tous les intervalles de requêtes réseau sont configurables par l'utilisateur, avec des valeurs par défaut simulant la vitesse d'opération manuelle d'un utilisateur normal. Le programme fonctionne par défaut en mode mono-thread, sans tâches concurrentes. En cas d'échec d'une requête, le programme effectue un nombre limité de tentatives, en insérant des délais appropriés entre chaque essai pour éviter les accès à haute fréquence. Le projet s'appuie entièrement sur les interfaces publiques de la plateforme et sur la structure des pages web, sans recourir à des techniques destructrices telles que le contournement des contrôles de sécurité ou le détournement d'API.
## 🛡️ Déclaration de respect de la plateforme

Ce programme a été conçu pour contrôler autant que possible la fréquence des requêtes, afin d’éviter toute charge ou impact notable sur les serveurs de Bilibili. Ce projet est uniquement destiné à des fins d’apprentissage, ne possède pas la capacité de fonctionner à grande échelle ou à haute concurrence, et n’a aucune intention malveillante ni de perturber les services.

Si ce projet contient des éléments portant atteinte aux droits légitimes de la société Bilibili, veuillez me contacter par e-mail à [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Je retirerai immédiatement le contenu concerné et supprimerai ce dépôt. Je m’excuse sincèrement pour tout désagrément causé et vous remercie de votre compréhension et de votre tolérance.

## 📄 Licence

[Licence MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---