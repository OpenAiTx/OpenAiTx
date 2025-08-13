<div align="center">

English | [简体中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_zh-TW.md) | [日本語](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ja-JP.md) | [한국어](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/docs/README_ko-KR.md)

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/banner.png" width="320px"  alt="PDF2ZH"/>

<h2 id="title">PDFMathTranslate</h2>

<p>
  <!-- PyPI -->
  <a href="https://pypi.org/project/pdf2zh/">
    <img src="https://img.shields.io/pypi/v/pdf2zh"></a>
  <a href="https://pepy.tech/projects/pdf2zh">
    <img src="https://static.pepy.tech/badge/pdf2zh"></a>
  <a href="https://hub.docker.com/r/byaidu/pdf2zh">
    <img src="https://img.shields.io/docker/pulls/byaidu/pdf2zh"></a>
  <a href="https://hellogithub.com/repository/8ec2cfd3ef744762bf531232fa32bc47" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=8ec2cfd3ef744762bf531232fa32bc47&claim_uid=JQ0yfeBNjaTuqDU&theme=small" alt="Featured｜HelloGitHub" /></a>
  <a href="https://gitcode.com/Byaidu/PDFMathTranslate/overview">
    <img src="https://gitcode.com/Byaidu/PDFMathTranslate/star/badge.svg"></a>
  <a href="https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker">
    <img src="https://img.shields.io/badge/%F0%9F%A4%97-Online%20Demo-FF9E0D"></a>
  <a href="https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate">
    <img src="https://img.shields.io/badge/ModelScope-Demo-blue"></a>
  <a href="https://github.com/Byaidu/PDFMathTranslate/pulls">
    <img src="https://img.shields.io/badge/contributions-welcome-green"></a>
  <a href="https://t.me/+Z9_SgnxmsmA5NzBl">
    <img src="https://img.shields.io/badge/Telegram-2CA5E0?style=flat-squeare&logo=telegram&logoColor=white"></a>
  <!-- License -->
  <a href="./LICENSE">
    <img src="https://img.shields.io/github/license/Byaidu/PDFMathTranslate"></a>
</p>

<a href="https://trendshift.io/repositories/12424" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12424" alt="Byaidu%2FPDFMathTranslate | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

</div>

Traduction d’articles scientifiques au format PDF et comparaison bilingue.

- 📊 Préservation des formules, graphiques, table des matières et annotations _([aperçu](#preview))_.
- 🌐 Support de [plusieurs langues](#language) et de divers [services de traduction](#services).
- 🤖 Fournit un [outil en ligne de commande](#usage), une [interface utilisateur interactive](#gui) et un [Docker](#docker)

N’hésitez pas à donner votre avis dans les [Issues GitHub](https://github.com/Byaidu/PDFMathTranslate/issues) ou le [Groupe Telegram](https://t.me/+Z9_SgnxmsmA5NzBl).

Pour les détails sur la contribution, veuillez consulter le [Guide de Contribution](https://github.com/Byaidu/PDFMathTranslate/wiki/Contribution-Guide---%E8%B4%A1%E7%8C%AE%E6%8C%87%E5%8D%97).

<h2 id="updates">Mises à jour</h2>

- [9 mai 2025] Version Preview pdf2zh 2.0 [#586](https://github.com/Byaidu/PDFMathTranslate/issues/586) : Le fichier ZIP Windows et l’image Docker sont désormais disponibles.

> [!NOTE]
>
> 2.0 Migré vers un nouveau dépôt sous l’organisation : [PDFMathTranslate/PDFMathTranslate-next](https://github.com/PDFMathTranslate/PDFMathTranslate-next)
> 
> La version officielle 2.0 a été publiée.

- [3 mars 2025] Support expérimental pour le nouveau backend [BabelDOC](https://github.com/funstory-ai/BabelDOC) WebUI ajouté en option expérimentale (par [@awwaawwa](https://github.com/awwaawwa))
- [22 févr. 2025] Meilleur CI de release et exécutable windows-amd64 bien packagé (par [@awwaawwa](https://github.com/awwaawwa))
- [24 déc. 2024] Le traducteur supporte désormais les modèles locaux sur [Xinference](https://github.com/xorbitsai/inference) _(par [@imClumsyPanda](https://github.com/imClumsyPanda))_
- [19 déc. 2024] Les documents non PDF/A sont désormais supportés via `-cp` _(par [@reycn](https://github.com/reycn))_
- [13 déc. 2024] Support additionnel pour backend _(par [@YadominJinta](https://github.com/YadominJinta))_
- [10 déc. 2024] Le traducteur supporte désormais les modèles OpenAI sur Azure _(par [@yidasanqian](https://github.com/yidasanqian))_

<h2 id="preview">Aperçu</h2>

<div align="center">
<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/preview.gif" width="80%"/>
</div>

<h2 id="demo">Service en ligne 🌟</h2>

Vous pouvez essayer notre application en utilisant l’une des démos suivantes :

- [Service public gratuit](https://pdf2zh.com/) en ligne sans installation _(recommandé)_.
- [Immersive Translate - BabelDOC](https://app.immersivetranslate.com/babel-doc/) 1000 pages gratuites par mois. _(recommandé)_
- [Démo hébergée sur HuggingFace](https://huggingface.co/spaces/reycn/PDFMathTranslate-Docker)
- [Démo hébergée sur ModelScope](https://www.modelscope.cn/studios/AI-ModelScope/PDFMathTranslate) sans installation.

Notez que les ressources de calcul de la démo sont limitées, merci d’éviter toute utilisation abusive.

<h2 id="install">Installation et Utilisation</h2>

### Méthodes

Pour différents cas d'utilisation, nous proposons des méthodes distinctes pour utiliser notre programme :

<details open>
  <summary>1. Installation UV</summary>

1. Python installé (3.10 <= version <= 3.12)

2. Installer notre paquet :

   ```bash
   pip install uv
   uv tool install --python 3.12 pdf2zh
   ```

3. Exécuter la traduction, fichiers générés dans [répertoire de travail actuel](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444) :

   ```bash
   pdf2zh document.pdf
   ```

</details>

<details>
  <summary>2. Exécutable Windows</summary>

1. Téléchargez pdf2zh-version-win64.zip depuis la [page des releases](https://github.com/Byaidu/PDFMathTranslate/releases)

2. Décompressez et double-cliquez sur `pdf2zh.exe` pour lancer.

</details>

<details>
  <summary>3. Interface graphique utilisateur</summary>

1. Python installé (3.10 <= version <= 3.12)

2. Installez notre package :

```bash
pip install pdf2zh
```
3. Commencez à utiliser dans le navigateur :


   ```bash
   pdf2zh -i
   ```
4. Si votre navigateur ne s'est pas lancé automatiquement, allez à  


   ```bash
   http://localhost:7860/
   ```

   <img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/gui.gif" width="500"/>

Voir la [documentation pour l'interface graphique (GUI)](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/README_GUI.md) pour plus de détails.

</details>

<details>
  <summary>4. Docker</summary>

1. Télécharger et exécuter :

   ```bash
   docker pull byaidu/pdf2zh
   docker run -d -p 7860:7860 byaidu/pdf2zh
   ```

2. Ouvrir dans le navigateur :

   ```
   http://localhost:7860/
   ```

Pour le déploiement Docker sur un service cloud :

<div>
<a href="https://www.heroku.com/deploy?template=https://github.com/Byaidu/PDFMathTranslate">
  <img src="https://www.herokucdn.com/deploy/button.svg" alt="Déployer" height="26"></a>
<a href="https://render.com/deploy">
  <img src="https://render.com/images/deploy-to-render-button.svg" alt="Déployer sur Koyeb" height="26"></a>
<a href="https://zeabur.com/templates/5FQIGX?referralCode=reycn">
  <img src="https://zeabur.com/button.svg" alt="Déployer sur Zeabur" height="26"></a>
<a href="https://template.sealos.io/deploy?templateName=pdf2zh">
  <img src="https://sealos.io/Deploy-on-Sealos.svg" alt="Déployer sur Sealos" height="26"></a>
<a href="https://app.koyeb.com/deploy?type=git&builder=buildpack&repository=github.com/Byaidu/PDFMathTranslate&branch=main&name=pdf-math-translate">
  <img src="https://www.koyeb.com/static/images/deploy/button.svg" alt="Déployer sur Koyeb" height="26"></a>
</div>

</details>

<details>
  <summary>5. Plugin Zotero</summary>


Voir [Zotero PDF2zh](https://github.com/guaguastandup/zotero-pdf2zh) pour plus de détails.

</details>

<details>
  <summary>6. Ligne de commande</summary>

1. Python installé (3.10 <= version <= 3.12)
2. Installer notre paquet :

   ```bash
   pip install pdf2zh
   ```

3. Exécuter la traduction, fichiers générés dans [répertoire de travail actuel](https://chatgpt.com/share/6745ed36-9acc-800e-8a90-59204bd13444) :

   ```bash
   pdf2zh document.pdf
   ```

</details>

> [!ASTUCE]
>
> - Si vous utilisez Windows et ne pouvez pas ouvrir le fichier après l'avoir téléchargé, veuillez installer [vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe) et réessayez.
>
> - Si vous ne pouvez pas accéder à Docker Hub, veuillez essayer l'image sur [GitHub Container Registry](https://github.com/Byaidu/PDFMathTranslate/pkgs/container/pdfmathtranslate).
> ```bash
> docker pull ghcr.io/byaidu/pdfmathtranslate
> docker run -d -p 7860:7860 ghcr.io/byaidu/pdfmathtranslate
> ```

### Impossible d'installer ?

Le programme actuel nécessite un modèle d'IA (`wybxc/DocLayout-YOLO-DocStructBench-onnx`) avant de fonctionner et certains utilisateurs ne peuvent pas le télécharger à cause de problèmes réseau. Si vous avez un problème pour télécharger ce modèle, nous proposons une solution de contournement en utilisant la variable d'environnement suivante :

```shell
set HF_ENDPOINT=https://hf-mirror.com
```
Pour l'utilisateur PowerShell :


```shell
$env:HF_ENDPOINT = https://hf-mirror.com
```
Si la solution ne fonctionne pas pour vous / vous rencontrez d'autres problèmes, veuillez consulter la [FAQ](https://github.com/Byaidu/PDFMathTranslate/wiki#-faq--%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98).

<h2 id="usage">Options Avancées</h2>

Exécutez la commande de traduction dans la ligne de commande pour générer le document traduit `example-mono.pdf` et le document bilingue `example-dual.pdf` dans le répertoire de travail actuel. Utilisez Google comme service de traduction par défaut. Plus de services de traduction supportés sont disponibles [ICI](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services).

<img src="https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/images/cmd.explained.png" width="580px"  alt="cmd"/>

Dans le tableau suivant, nous listons toutes les options avancées à titre de référence :

| Option                | Fonction                                                                                                      | Exemple                                        |
| --------------------- | ------------------------------------------------------------------------------------------------------------- | ---------------------------------------------- |
| files                 | Fichiers locaux                                                                                                | `pdf2zh ~/local.pdf`                           |
| links                 | Fichiers en ligne                                                                                              | `pdf2zh http://arxiv.org/paper.pdf`            |
| `-i`                  | [Entrer dans l'interface graphique](#gui)                                                                     | `pdf2zh -i`                                    |
| `-p`                  | [Traduction partielle du document](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#partial) | `pdf2zh example.pdf -p 1`                      |
| `-li`                 | [Langue source](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                | `pdf2zh example.pdf -li en`                    |
| `-lo`                 | [Langue cible](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#languages)                 | `pdf2zh example.pdf -lo zh`                    |
| `-s`                  | [Service de traduction](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#services)         | `pdf2zh example.pdf -s deepl`                  |
| `-t`                  | [Multi-threads](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#threads)                  | `pdf2zh example.pdf -t 1`                      |
| `-o`                  | Répertoire de sortie                                                                                            | `pdf2zh example.pdf -o output`                 |
| `-f`, `-c`            | [Exceptions](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#exceptions)                  | `pdf2zh example.pdf -f "(MS.*)"`               |
| `-cp`                 | Mode compatibilité                                                                                              | `pdf2zh example.pdf --compatible`              |
| `--skip-subset-fonts` | [Ignorer le sous-ensemble de polices](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#font-subset) | `pdf2zh example.pdf --skip-subset-fonts`       |
| `--ignore-cache`      | [Ignorer le cache de traduction](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cache)   | `pdf2zh example.pdf --ignore-cache`            |
| `--share`             | Lien public                                                                                                     | `pdf2zh -i --share`                            |
| `--authorized`        | [Autorisation](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#auth)                       | `pdf2zh -i --authorized users.txt [auth.html]` |
| `--prompt`            | [Invite personnalisée](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#prompt)             | `pdf2zh --prompt [prompt.txt]`                 |
| `--onnx`              | [Utiliser un modèle DocLayout-YOLO ONNX personnalisé]                                                          | `pdf2zh --onnx [onnx/model/path]`              |
| `--serverport`        | [Utiliser un port WebUI personnalisé]                                                                           | `pdf2zh --serverport 7860`                     |
| `--dir`               | [Traduction par lot]                                                                                            | `pdf2zh --dir /path/to/translate/`             |
| `--config`            | [Fichier de configuration](https://github.com/Byaidu/PDFMathTranslate/blob/main/docs/ADVANCED.md#cofig)          | `pdf2zh --config /path/to/config/config.json`  |
| `--serverport`        | [Port serveur gradio personnalisé]                                                                              | `pdf2zh --serverport 7860`                     |
| `--babeldoc`          | Utiliser le backend expérimental [BabelDOC](https://funstory-ai.github.io/BabelDOC/) pour traduire               | `pdf2zh --babeldoc` -s openai example.pdf      |
| `--mcp`               | Activer le mode MCP STDIO                                                                                        | `pdf2zh --mcp`                                 |
| `--sse`               | Activer le mode MCP SSE                                                                                          | `pdf2zh --mcp --sse`                           |

Pour des explications détaillées, veuillez vous référer à notre document sur [l'utilisation avancée](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/ADVANCED.md) pour la liste complète de chaque option.


<h2 id="downstream">Développement Secondaire (APIs)</h2>

Pour les applications en aval, veuillez vous référer à notre document sur les [Détails de l’API](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md) pour plus d’informations sur :

- [API Python](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-python), comment utiliser le programme dans d’autres programmes Python  
- [API HTTP](https://raw.githubusercontent.com/Byaidu/PDFMathTranslate/main/./docs/APIS.md#api-http), comment communiquer avec un serveur ayant le programme installé

<h2 id="todo">À FAIRE</h2>

- [ ] Analyser la mise en page avec des modèles basés sur DocLayNet, [PaddleX](https://github.com/PaddlePaddle/PaddleX/blob/17cc27ac3842e7880ca4aad92358d3ef8555429a/paddlex/repo_apis/PaddleDetection_api/object_det/official_categories.py#L81), [PaperMage](https://github.com/allenai/papermage/blob/9cd4bb48cbedab45d0f7a455711438f1632abebe/README.md?plain=1#L102), [SAM2](https://github.com/facebookresearch/sam2)

- [ ] Corriger la rotation des pages, la table des matières, le format des listes

- [ ] Corriger les formules pixellisées dans les anciens articles

- [ ] Reprise asynchrone sauf KeyboardInterrupt

- [ ] Algorithme Knuth–Plass pour les langues occidentales

- [ ] Support des fichiers non PDF/A

- [ ] Plugins pour [Zotero](https://github.com/zotero/zotero) et [Obsidian](https://github.com/obsidianmd/obsidian-releases)

<h2 id="acknowledgement">Remerciements</h2>

- [Immersive Translation](https://immersivetranslate.com) sponsorise des codes d’échange d’abonnement Pro mensuels pour les contributeurs actifs de ce projet, voir détails sur : [CONTRIBUTOR_REWARD.md](https://github.com/funstory-ai/BabelDOC/blob/main/docs/CONTRIBUTOR_REWARD.md)

- Nouveau backend : [BabelDOC](https://github.com/funstory-ai/BabelDOC)

- Fusion de documents : [PyMuPDF](https://github.com/pymupdf/PyMuPDF)

- Analyse de documents : [Pdfminer.six](https://github.com/pdfminer/pdfminer.six)

- Extraction de documents : [MinerU](https://github.com/opendatalab/MinerU)

- Aperçu de documents : [Gradio PDF](https://github.com/freddyaboulton/gradio-pdf)

- Traduction multithread : [MathTranslate](https://github.com/SUSYUSTC/MathTranslate)

- Analyse de mise en page : [DocLayout-YOLO](https://github.com/opendatalab/DocLayout-YOLO)

- Norme du document : [PDF Explained](https://zxyle.github.io/PDF-Explained/), [PDF Cheat Sheets](https://pdfa.org/resource/pdf-cheat-sheets/)

- Police multilingue : [Go Noto Universal](https://github.com/satbyy/go-noto-universal)

<h2 id="contrib">Contributeurs</h2>

<a href="https://github.com/Byaidu/PDFMathTranslate/graphs/contributors">
  <img src="https://opencollective.com/PDFMathTranslate/contributors.svg?width=890&button=false" />
</a>

![Alt](https://repobeats.axiom.co/api/embed/dfa7583da5332a11468d686fbd29b92320a6a869.svg "Image analytique Repobeats")

<h2 id="star_hist">Historique des étoiles</h2>

<a href="https://star-history.com/#Byaidu/PDFMathTranslate&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date" />
   <img alt="Graphique de l'historique des étoiles" src="https://api.star-history.com/svg?repos=Byaidu/PDFMathTranslate&type=Date"/>
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-13

---