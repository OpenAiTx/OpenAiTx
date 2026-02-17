## Un moyen simple de créer une bibliothèque de documents pour votre projet

Démo : [https://easydocs.codeandmedia.com/](https://easydocs.codeandmedia.com/)

Ce thème pour [Zola](https://getzola.org) (moteur de site statique) vous aide à construire et publier facilement et rapidement la documentation de votre projet. Zola est un seul binaire qui génère des pages html et des ressources statiques additionnelles après avoir compilé vos docs écrits en Markdown. Ainsi, vous pouvez prendre le thème, vos fichiers md, Zola et obtenir un site web flexible et simple pour la documentation.

### Étape par étape

Comme vous l’avez peut-être entendu, Zola est assez flexible :) Donc, le scénario ci-dessous est l’une des centaines de manières possibles de faire les choses, n’hésitez pas à trouver la vôtre. Aussi, Zola propose son propre mécanisme pour installer et utiliser des thèmes, voir [la documentation](https://www.getzola.org/documentation/themes/installing-and-using-themes/).

1. Forkez le dépôt et remplacez le contenu de démonstration dans le dossier content par le vôtre. Mais regardez les fichiers _index.md. Ils contiennent `title` et si vous souhaitez avoir une ancre à droite de vos en-têtes, ajoutez `insert_anchor_links = "right"` à chaque index. `theme.toml`, la capture d’écran et le readme peuvent aussi être supprimés.
2. Dans `config.toml` changez l’URL et le titre par les vôtres. Dans la section extra, vous pouvez spécifier le chemin vers votre API GitHub pour la version sous le logo dans la navigation, le favicon et le logo lui-même. Ou simplement supprimez ces lignes si vous n’en avez pas besoin. Vous pouvez aussi configurer ou activer certains réglages supplémentaires liés à Zola. [La spécification est ici](https://www.getzola.org/documentation/getting-started/configuration/).
3. Dans sass/_variables.scss vous pouvez changer la police, la couleur ou le fond si vous le souhaitez.
4. Presque fini. Maintenant, vous devez décider comment construire et où héberger votre site web. Vous pouvez le construire localement et le télécharger quelque part. Ou construire dans GitHub Actions et héberger sur GitHub Pages / Netlify / CloudFlare Pages / AnyS3CloudStorage. [Comment faire pour GitHub Pages](https://www.getzola.org/documentation/deployment/github-pages/). [Mon exemple](https://github.com/o365hq/o365hq.com/blob/main/.github/workflows/main.yml) de workflow GitHub avec construction en 2 étapes (la première vérifie les liens et les fautes d’orthographe, la deuxième télécharge sur Azure). [Dockerfile](https://github.com/codeandmedia/zola_docsascode_theme/blob/master/Dockerfile) pour créer une image Docker.

## Options de configuration fournies

Ces options peuvent être configurées dans la section `extra` du [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml).  
Si elles ne sont pas présentes, le comportement par défaut est celui montré dans le [config.toml](https://raw.githubusercontent.com/codeandmedia/zola_easydocs_theme/master/config.toml) de démarrage.

- **easydocs_logo_always_clickable** contrôle si le logo est toujours cliquable. Par défaut, le logo est cliquable uniquement si vous n’êtes pas sur la page d’accueil. Si activé, cela rendra le logo cliquable même sur la page d’accueil. Ainsi, sur la page d’accueil, cela rafraîchira simplement la page car elle vous ramènera à la même page.
- **easydocs_uglyurls** fournit un support pour les sites hors ligne qui n’utilisent pas de serveur web. Si réglé à true, les liens dans la navigation sont générés avec le chemin complet incluant `index.html`. Cette fonctionnalité est inspirée par le [thème Abridge](https://www.getzola.org/themes/abridge/). Notez que pour que cela fonctionne, il faut aussi que l’URL de base soit définie sur le dossier local où le site sera stocké, par exemple `base_url = file:///home/user/mysite/public/`. Par conséquent, ce n’est pas portable et ne fonctionne qu’avec un dossier local spécifique, mais ne nécessite pas de serveur web pour naviguer sur le site.
- **easydocs_heading_threshold** contrôle le nombre minimum de titres nécessaires sur une page avant que les titres apparaissent dans la navigation à gauche. Par défaut à 5. Peut être utilisé, par exemple, pour toujours afficher les titres sur chaque page en le réglant à 1.

Profitez de votre documentation !

* _Icônes : [Office UI Fabric Icons](https://uifabricicons.azurewebsites.net/)_
* _Bouton copier-coller : [Aaron Luna](https://aaronluna.dev/blog/add-copy-button-to-code-blocks-hugo-chroma/)_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-17

---