<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
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

# 🚀 Xianyu AutoAgent - Système intelligent de robot de service client Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Une solution de surveillance par IA conçue spécialement pour la plateforme Xianyu, permettant une surveillance automatisée 24h/24 et 7j/7, avec prise en charge de la prise de décision collaborative multi-experts, négociation intelligente et dialogue contextuel.

## 🎮 Playground - Expérience rapide (version sans configuration)

Aucun environnement local ou configuration de Secrets nécessaire ! **Passez simplement les paramètres via l'interface web GitHub Actions**, et lancez le robot Xianyu en un clic.

### Comment utiliser
1. **Forkez ce dépôt** → Cliquez sur le bouton `Fork` en haut à droite
2. **Déclenchez l'Action** :
   - Accédez à l’onglet `Actions` de votre dépôt
   - Sélectionnez le workflow **`🚀 Run Service`**
   - Cliquez sur le bouton **`Run workflow`**, puis renseignez les paramètres :
      - `API Key` : Collez votre clé API de grand modèle (par ex. Aliyun DashScope)
      - `Cookies` : Collez la chaîne complète de cookies du site web Xianyu
3. **Consultez les logs d’exécution** :
   - Le robot écoutera automatiquement les messages Xianyu après le démarrage
   - Recherchez `🤖 Reply:` dans les logs d’Action pour voir l’historique des conversations

### Remarques importantes
⚠️ Attention aux limitations d’exécution temporaire :
- Exécution par défaut de **30 minutes** (limite pour les comptes gratuits GitHub)
- Les informations sensibles (comme les cookies) **ne sont pas stockées**, valables uniquement pour la session en cours

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Fonctionnalités principales

### Moteur de dialogue intelligent
| Module        | Implémentation technique  | Fonctionnalités clés                                         |
| ------------- | ------------------------ | ------------------------------------------------------------ |
| Contexte      | Stockage historique      | Gestion légère de la mémoire de conversation, tout l’historique utilisé comme contexte LLM |
| Routage expert| Prompt LLM + routage     | Reconnaissance d’intention basée sur l’ingénierie de prompt → distribution dynamique vers l’Agent expert, prise en charge de la négociation/technique/SAV |

### Matrice des fonctionnalités métiers
| Module     | Déjà implémenté                    | À venir                   |
| ---------- | ---------------------------------- | ------------------------ |
| Moteur     | ✅ Réponse automatique LLM<br>✅ Gestion du contexte | 🔄 Renforcement de l’analyse des sentiments     |
| Négociation| ✅ Stratégie de baisse de prix      | 🔄 Fonction de comparaison de marché            |
| Support tech| ✅ Intégration recherche web        | 🔄 Renforcement de la base de connaissances RAG |

## 🚴 Démarrage rapide

### Prérequis
- JDK 21+
- Maven 3.9.10+

### Étapes d'installation

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
## 🤝 Participation et contribution

Vous êtes invité à soumettre des suggestions via Issue ou à contribuer au code par PR, veuillez suivre le [Guide de contribution](https://contributing.md/)



## 🛡 Remarques importantes

⚠️ Attention : **Ce projet est uniquement destiné à l'apprentissage et à l'échange. En cas d'infraction, veuillez contacter l'auteur pour suppression.**

Compte tenu de la spécificité du projet, l'équipe de développement peut à tout moment **arrêter la mise à jour** ou **supprimer le projet**.


## 🧸 Remerciements spéciaux

Ce projet a été reconstruit sur la base des projets open source suivants :
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Système intelligent de robot service client Xianyu, développé par [@shaxiu](https://github.com/shaxiu) et [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---