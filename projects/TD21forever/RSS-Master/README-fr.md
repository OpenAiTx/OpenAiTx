# RSS-Master

Filtrage et tri personnalisés des flux RSS, utilisation de l'IA pour résumer, synthétiser, noter, etc. Version optimisée pour la performance, prise en charge du traitement asynchrone et du résumé IA en parallèle.

### Préface

Au début du mois de septembre, j'ai commencé à utiliser Inoreader + RSSHub pour agréger et m'abonner aux flux RSS qui m'intéressaient, en les lisant avec Reeder, dans le but de maîtriser entièrement la source des informations quotidiennes. Après un mois, le nombre croissant de flux RSS et d'informations non lues m'a causé pas mal d'anxiété de lecture. Je me suis donc demandé s'il existait un moyen de personnaliser certaines règles de filtrage, de préférence avec l'aide de l'IA pour m'assister dans la lecture et alléger ma charge.

Inoreader inclut un filtre, mais payer uniquement pour cette fonction ne me semblait pas rentable ; NewsBlur propose un « Intelligence Trainer » pour une classification intelligente, mais après un essai rapide, je n'ai pas constaté de résultats évidents à court terme ; Feedly offre à la fois du filtrage et des fonctions IA, ce qui semblait répondre à mes besoins. Juste au moment où j'hésitais à passer d'Inoreader à Feedly en tant qu'utilisateur payant, j'ai découvert ces deux projets :

- [Laisser ChatGPT résumer Hacker News](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [Guide d'utilisation de RSS-GPT](http://yinan.me/rss-gpt-manual-zh.html)

Le concept général de ces deux projets est d'exécuter un script via GitAction, d'obtenir les informations puis d'utiliser l'API Open AI pour traduire, résumer, puis rendre un modèle déployé sur GitHub Page. La méthode de RSS-GPT correspondait mieux à mes besoins : exécuter un script planifié pour récupérer directement le fichier XML RSS, le traiter, puis déployer le XML sur GitHub Page pour obtenir un lien d'accès, que le lecteur peut directement s'abonner.

J'ai un fort besoin de synchronisation multi-appareils avec Inoreader. Pour les nouveaux flux RSS ajoutés dans le fichier de configuration, il faut notifier Inoreader rapidement pour la synchronisation. J'ai donc étendu l'idée de [RSS-GPT](https://github.com/yinan-c/) en un projet appelé RSS-Master.

### Fonctionnalités principales

- **Prise en charge du traitement parallèle** : utilisation de l'asynchrone et d'un pool de threads pour traiter simultanément les flux RSS et les résumés IA, améliorant considérablement la vitesse
- **Mécanisme de cache amélioré** : système de cache plus stable pour éviter la perte de données et améliorer les performances des accès répétés
- **Meilleure gestion des erreurs** : toutes les opérations comportent une gestion complète des erreurs et un enregistrement des logs, augmentant la stabilité
- **Extraction optimisée du contenu HTML** : extraction intelligente du contenu des articles, en ignorant les informations non pertinentes, améliorant la qualité des résumés IA
- **Support de la dernière API OpenAI** : compatibilité totale avec la dernière version de l'API OpenAI
- **Statistiques détaillées** : fourniture du temps d'exécution, du taux de réussite et des statistiques de coûts après traitement
- **Support de génération de fichiers opml** : ainsi que la conversion mutuelle avec config.yml via `script/convert_opml_to_yaml.sh` et `script/convert_yaml_to_opml.sh`
- **Règles de filtrage personnalisées** : support des types include et exclude, avec les champs title et article
- **Modèle IA personnalisable** : configuration via variables d'environnement pour utiliser différents modèles OpenAI
- **URL de base personnalisable** : configuration de l'URL de base pour accéder aux fichiers RSS, facilitant le déploiement dans différents environnements
- **Notebook interactif de test** : fourniture d'un notebook Jupyter pour tester diverses fonctionnalités

### Configuration des variables d'environnement

Le projet supporte la configuration des paramètres suivants via un fichier `.env` :

```
# Paramètres obligatoires
OPENAI_API_KEY=your_openai_api_key_here

# Paramètres optionnels
RSS_BASE_URL=https://raw.githubusercontent.com/TD21forever/RSS-Master/main/rss-feeds/  # URL de base des RSS
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # Modèle OpenAI
LOG_LEVEL=INFO                               # Niveau des logs
PARALLEL_WORKERS=5                           # Nombre de traitements parallèles
```

Vous pouvez copier le fichier `.env.example` et le renommer en `.env`, puis modifier les valeurs des paramètres.

### Améliorations de performance

Cette version apporte les améliorations de performance suivantes par rapport à la version originale :

1. **Traitement parallèle des flux RSS** : utilisation de `asyncio` pour traiter plusieurs flux RSS simultanément
2. **Parallélisation des résumés IA** : utilisation d'un pool de threads pour traiter les résumés IA de plusieurs articles en parallèle
3. **Optimisation du traitement du texte** : amélioration de l'algorithme d'extraction du contenu HTML pour extraire plus intelligemment les informations clés
4. **Traitement sécurisé des fichiers** : mécanisme d'écriture sécurisé pour éviter la perte de données en cas de crash
5. **Optimisation de l'utilisation mémoire** : optimisation des structures de données et des flux de traitement pour réduire la consommation mémoire

### Instructions d'utilisation

1. Cloner le projet localement
2. Installer les dépendances : `pip install -r requirements.txt`
3. Créer un fichier `.env` et définir la clé API OpenAI : `OPENAI_API_KEY=votre_cle`
4. Modifier `resource/config.yml` pour configurer vos flux RSS
5. Lancer `python main.py` pour démarrer le traitement

### Tests et débogage

Le projet fournit un notebook interactif `test.ipynb` pour tester les fonctionnalités suivantes :

1. Récupération et analyse des flux RSS
2. Fonctionnalité du filtre
3. Résumé IA
4. Mécanisme de cache
5. URL de base personnalisée
6. Test de performance

Mode d'emploi :

```bash
# Installer Jupyter
pip install jupyter

# Lancer le notebook
jupyter notebook test.ipynb
```

### Exemple de règles de filtrage personnalisées

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Captures d'écran d'utilisation

- Fonctionnalité de synthèse et résumé IA

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Filtrage personnalisé : filtrer le canal des bonnes affaires de 「什么值得买」, ne recommandant que les produits que je souhaite stocker récemment, comme les sodas

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/typora/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---