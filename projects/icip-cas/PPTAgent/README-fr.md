
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/pptagent-logo.jpg" width="240px" alt="https://github.com/icip-cas/PPTAgent">
</div>

<table>
  <tr>
    <td width="50%">
      <video controls width="100%" src="https://github.com/user-attachments/assets/314bed6a-185e-4c81-9de5-35728e83e22a">
      </video>
    </td>
    <td width="50%">
      <video controls width="100%" src="https://github.com/user-attachments/assets/96eee616-5f79-4ea1-bd7f-bcaa466eda9e">
      </video>
    </td>
  </tr>
</table>

## Contact 📫
> Le principal contributeur de ce dépôt est un étudiant en Master diplômant en 2026, n'hésitez pas à le contacter pour toute collaboration ou opportunité.
>
> 本仓库的主要贡献者是一名 2026 届硕士毕业生，欢迎联系合作或交流机会。

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/wechat.jpg" width="140px">
</div>

## Actualités 📅
- [2026/03] : Nous prenons désormais en charge le CLI et avons publié nos modèles affinés sur [Hugging Face 🤗](https://huggingface.co/collections/ICIP/deeppresenter) !
- [2026/01] : Nous prenons en charge la génération libre et par modèle, l’export PPTX, et le mode hors-ligne ! La gestion de contexte a été ajoutée pour éviter le débordement.
- [2025/12] : 🔥 Sortie de la V2 avec des améliorations majeures - Intégration approfondie de la recherche, conception visuelle libre, création autonome d'actifs, génération texte-vers-image, et environnement agent avec sandbox & plus de 20 outils.
- [2025/09] : 🛠️ Support du serveur MCP ajouté - voir [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-) pour les détails de configuration
- [2025/09] : 🚀 Sortie de la v2 avec des améliorations majeures - voir [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.2.0) pour plus d’informations
- [2025/08] : 🎉 Article accepté à **EMNLP 2025** !
- [2025/05] : ✨ Sortie de la v1 avec les fonctionnalités de base et 🌟 avancée majeure : atteint 1 000 étoiles sur GitHub ! - voir [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.1.0) pour plus d’informations
- [2025/01] : 🔓 Code source ouvert, avec le code expérimental archivé à [experiment release](https://github.com/icip-cas/PPTAgent/releases/tag/experiment)

## Utilisation 📖

> [!IMPORTANT]
> Windows n’est pas supporté. Si vous êtes sous Windows, veuillez utiliser WSL.
>
> Nous recommandons vivement de commencer par le CLI et la tâche minimale pour vérifier que les dépendances et l’environnement sont correctement configurés.

### Configuration

Si vous utilisez le CLI, `pptagent onboard` peut vous aider à créer et mettre à jour ces configurations de façon interactive. Si vous utilisez Docker Compose ou construisez depuis la source, vous devez les préparer manuellement :

```bash
cp deeppresenter/config.yaml.example deeppresenter/config.yaml
cp deeppresenter/mcp.json.example deeppresenter/mcp.json
```

#### Services optionnels pour améliorer la qualité

Les services suivants peuvent améliorer de manière significative la qualité de génération, en particulier pour la profondeur de recherche, l’analyse de PDF et la création d’éléments visuels :

- **Tavily** : améliore la qualité des recherches web. Demandez une clé API sur [tavily.com](https://www.tavily.com/), puis définissez `TAVILY_API_KEY` dans [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json).
- **MinerU** : améliore la qualité du traitement des PDF. Vous pouvez soit demander une clé API sur [mineru.net](https://mineru.net/apiManage/docs) et configurer `MINERU_API_KEY` dans [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json), soit déployer MinerU localement et définir `MINERU_API_URL` à la place.
- **Modèle texte-vers-image** : améliore la qualité de génération des images. Configurez `t2i_model` dans [`deeppresenter/config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/config.yaml).


Si vous souhaitez une configuration entièrement hors ligne, déployez MinerU localement et définissez `offline_mode: true` dans `deeppresenter/config.yaml` pour éviter le chargement d’outils dépendants du réseau comme la recherche web.

D’autres variables configurables sont disponibles dans [constants.py](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/utils/constants.py).

### 1. Utilisation personnelle / Intégration OpenClaw : CLI

> [!NOTE]
> Sur macOS, la CLI peut installer automatiquement plusieurs dépendances locales, notamment Homebrew, Node.js, Docker, poppler, Playwright et llama.cpp.
>
> Sur Linux, vous devez préparer l’environnement vous-même.

Utilisez ce mode si vous souhaitez la configuration locale la plus rapide ou connecter DeepPresenter à OpenClaw via la CLI.

```bash
# Install uv
curl -LsSf https://astral.sh/uv/install.sh | sh

# First-time interactive setup
uvx pptagent onboard

# Generate a presentation
uvx pptagent generate "Single Page with Title: Hello World" -o hello.pptx

# Generate with attachments
uvx pptagent generate "Q4 Report" \
  -f data.xlsx \
  -f charts.pdf \
  -p "10-12" \
  -o report.pptx
```

| Commande               | Description                                         |
| ---------------------- | --------------------------------------------------- |
| `pptagent onboard`     | Assistant de configuration interactif               |
| `pptagent generate`    | Générer des présentations                           |
| `pptagent config`      | Afficher la configuration actuelle                  |
| `pptagent reset`       | Réinitialiser la configuration                      |
| `pptagent serve`       | Démarrer le service d'inférence local utilisé par le CLI |

### 2. Configuration minimale / Développement : Compilation depuis la source

Utilisez ce mode si vous souhaitez la couche d'abstraction la plus légère et un contrôle total sur les dépendances durant le développement.

```bash
uv pip install -e .
playwright install-deps
playwright install chromium
npm install --prefix deeppresenter/html2pptx

docker pull forceless/deeppresenter-sandbox:0.1.0
docker tag forceless/deeppresenter-sandbox:0.1.0 deeppresenter-sandbox:0.1.0

# or build from dockerfile
docker build -t deeppresenter-sandbox:0.1.0 -f deeppresenter/docker/SandBox.Dockerfile .
```

Démarrez l'application :

```bash
python webui.py
```

### 3. Déploiement du serveur : Docker Compose

Utilisez ce mode pour un environnement serveur stable avec des dépendances explicites.

```bash
# Pull the public images to avoid build from source
docker pull forceless/deeppresenter-sandbox:0.1.0
docker tag forceless/deeppresenter-sandbox:0.1.0 deeppresenter-sandbox:0.1.0

# Or build from source
docker build -t deeppresenter-sandbox:0.1.0 -f deeppresenter/docker/SandBox.Dockerfile .

# Start the host service
docker compose up -d deeppresenter-host
```

The service exposes the web UI on `http://localhost:7861`.

## Case Study 💡

- #### Prompt: Please present the given document to me.

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0008.jpg" alt="图片8" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0009.jpg" alt="图片9" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0010.jpg" alt="图片10" width="200"/>

</div>

- #### Prompt: 请介绍小米 SU7 的外观和价格

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0006.jpg" alt="图片6" width="200"/>

</div>

- #### Prompt: 请制作一份高中课堂展示课件，主题为“解码立法过程：理解其对国际关系的影响”

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0008.jpg" alt="图片8" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0009.jpg" alt="图片9" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0010.jpg" alt="图片10" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0011.jpg" alt="图片11" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0012.jpg" alt="图片12" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0013.jpg" alt="图片13" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0014.jpg" alt="图片14" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0015.jpg" alt="图片15" width="200"/>

</div>

---

## Contributeurs 🌟

<table>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Force1ess>
            <img src=https://avatars.githubusercontent.com/u/72636351?v=4 width="80;"  alt=Force1ess/>
            <br />
            <sub style="font-size:14px"><b>Force1ess</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Puellaquae>
            <img src=https://avatars.githubusercontent.com/u/22560343?v=4 width="80;"  alt=Puelloc/>
            <br />
            <sub style="font-size:14px"><b>Puelloc</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/hysyyds>
            <img src=https://avatars.githubusercontent.com/u/80150669?v=4 width="80;"  alt=hongyan/>
            <br />
            <sub style="font-size:14px"><b>hongyan</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Dnoob>
            <img src=https://avatars.githubusercontent.com/u/92987618?v=4 width="80;"  alt=Dnoob/>
            <br />
            <sub style="font-size:14px"><b>Dnoob</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Sadahlu>
            <img src=https://avatars.githubusercontent.com/u/126563707?v=4 width="80;"  alt=Sadahlu/>
            <br />
            <sub style="font-size:14px"><b>Sadahlu</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/KurisuMakiseSame>
            <img src=https://avatars.githubusercontent.com/u/168447425?v=4 width="80;"  alt=KurisuMakiseSame/>
            <br />
            <sub style="font-size:14px"><b>KurisuMakiseSame</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/kylooh>
            <img src=https://avatars.githubusercontent.com/u/26456650?v=4 width="80;"  alt=Eliot White/>
            <br />
            <sub style="font-size:14px"><b>Eliot White</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/EvolvedGhost>
            <img src=https://avatars.githubusercontent.com/u/92856393?v=4 width="80;"  alt=EvolvedGhost/>
            <br />
            <sub style="font-size:14px"><b>EvolvedGhost</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/ISCAS-zwl>
            <img src=https://avatars.githubusercontent.com/u/179820048?v=4 width="80;"  alt=ISCAS-zwl/>
            <br />
            <sub style="font-size:14px"><b>ISCAS-zwl</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/James4Ever0>
            <img src=https://avatars.githubusercontent.com/u/103997068?v=4 width="80;"  alt=James Brown/>
            <br />
            <sub style="font-size:14px"><b>James Brown</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/LasRuinasCirculares>
            <img src=https://avatars.githubusercontent.com/u/119716645?v=4 width="80;"  alt=JunZhang/>
            <br />
            <sub style="font-size:14px"><b>JunZhang</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/openaitx-system>
            <img src=https://avatars.githubusercontent.com/u/215529505?v=4 width="80;"  alt=Open AI Tx/>
            <br />
            <sub style="font-size:14px"><b>Open AI Tx</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/haosenwang1018>
            <img src=https://avatars.githubusercontent.com/u/167664334?v=4 width="80;"  alt=Sense_wang/>
            <br />
            <sub style="font-size:14px"><b>Sense_wang</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/DeJeune>
            <img src=https://avatars.githubusercontent.com/u/67425183?v=4 width="80;"  alt=SuYao/>
            <br />
            <sub style="font-size:14px"><b>SuYao</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Dormiveglia-elf>
            <img src=https://avatars.githubusercontent.com/u/81767213?v=4 width="80;"  alt=Zhenyu/>
            <br />
            <sub style="font-size:14px"><b>Zhenyu</b></sub>
        </a>
    </td>
</tr>
</table>

[![Graphique de l'historique des étoiles](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)

## Citation 🙏

Si vous trouvez ce projet utile, veuillez utiliser ce qui suit pour le citer :
```bibtex
@inproceedings{zheng-etal-2025-pptagent,
    title = "{PPTA}gent: Generating and Evaluating Presentations Beyond Text-to-Slides",
    author = "Zheng, Hao  and
      Guan, Xinyan  and
      Kong, Hao  and
      Zhang, Wenkai  and
      Zheng, Jia  and
      Zhou, Weixiang  and
      Lin, Hongyu  and
      Lu, Yaojie  and
      Han, Xianpei  and
      Sun, Le",
    editor = "Christodoulopoulos, Christos  and
      Chakraborty, Tanmoy  and
      Rose, Carolyn  and
      Peng, Violet",
    booktitle = "Proceedings of the 2025 Conference on Empirical Methods in Natural Language Processing",
    month = nov,
    year = "2025",
    address = "Suzhou, China",
    publisher = "Association for Computational Linguistics",
    url = "https://aclanthology.org/2025.emnlp-main.728/",
    doi = "10.18653/v1/2025.emnlp-main.728",
    pages = "14413--14429",
    ISBN = "979-8-89176-332-6",
    abstract = "Automatically generating presentations from documents is a challenging task that requires accommodating content quality, visual appeal, and structural coherence. Existing methods primarily focus on improving and evaluating the content quality in isolation, overlooking visual appeal and structural coherence, which limits their practical applicability. To address these limitations, we propose PPTAgent, which comprehensively improves presentation generation through a two-stage, edit-based approach inspired by human workflows. PPTAgent first analyzes reference presentations to extract slide-level functional types and content schemas, then drafts an outline and iteratively generates editing actions based on selected reference slides to create new slides. To comprehensively evaluate the quality of generated presentations, we further introduce PPTEval, an evaluation framework that assesses presentations across three dimensions: Content, Design, and Coherence. Results demonstrate that PPTAgent significantly outperforms existing automatic presentation generation methods across all three dimensions."
}

@misc{zheng2026deeppresenterenvironmentgroundedreflectionagentic,
      title={DeepPresenter: Environment-Grounded Reflection for Agentic Presentation Generation},
      author={Hao Zheng and Guozhao Mo and Xinru Yan and Qianhao Yuan and Wenkai Zhang and Xuanang Chen and Yaojie Lu and Hongyu Lin and Xianpei Han and Le Sun},
      year={2026},
      eprint={2602.22839},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2602.22839},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---