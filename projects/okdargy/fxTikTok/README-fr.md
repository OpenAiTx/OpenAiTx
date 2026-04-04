# fxTikTok

Intégrez des vidéos et diaporamas TikTok sur Discord avec simplement `s/i/n`

> [!NOTE]  
> Vous souhaitez une fonctionnalité dans fxTikTok ou signaler un bug ? Créez une issue ! J’aimerais beaucoup avoir votre retour.

## 📸 Captures d’écran

<details>
  <summary>Cliquez ici pour voir un aperçu de fxTikTok en action</summary>

| <img src="/.github/readme/compare.png" alt="Aperçu vidéo" height="400px" /> |
| :-------------------------------------------------------------------------: |
|            Comparaison des intégrations `tiktok.com` vs. `tnktok.com` sur Discord            |

| <img src="/.github/readme/slideshow.png" alt="Aperçu diaporama" /> |
| :---------------------------------------------------------------: |
|                            Intégrations de diaporamas                            |

| <img src="/.github/readme/direct.png" alt="Aperçu direct" height="400px" /> |
| :-------------------------------------------------------------------------: |
|                          Support direct des images/vidéos                          |

</details>

## 📖 Utilisation

Utiliser fxTikTok est facile sur Discord. Corrigez les intégrations moches et non réactives en envoyant votre lien TikTok puis en tapant `s/i/n`

<details>
  <summary>👁️ Apprenant visuel ? Cliquez ici pour voir un tutoriel GIF</summary>

  <img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/introduction.gif" alt="GIF d’introduction" height="500px" style="border-radius:2%" />
</details>

### Comment cela fonctionne-t-il ?

Lorsque vous envoyez `s/i/n` sur Discord, cela modifie votre message le plus récent en utilisant le format [sed](https://www.gnu.org/software/sed/manual/sed.html). Plus précisément, cela remplace la première occurrence du second paramètre (`i`) dans le message par le troisième paramètre (`n`).

|     Avant      |     Après      |
| :------------: | :------------: |
| t**i**ktok.com | t**n**ktok.com |

> [!CONSEIL]
> Si vous gérez un serveur Discord, je vous recommande vivement d’ajouter [FixTweetBot](https://github.com/Kyrela/FixTweetBot) à votre serveur. Il modifie automatiquement les liens pour utiliser des correcteurs d’intégration comme fxTikTok, et il est très personnalisable.

### Utilisation des Intégrations Directes

Vous ne voulez pas tout ce désordre statistique sur votre intégration et souhaitez uniquement la vidéo ou l’image ? Changez simplement votre URL en `d.tnktok.com`

|         Avant         |        Après         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **d**.t**n**ktok.com |

> Vous pouvez aussi définir `isDirect` à true via la requête URL en ajoutant `?isDirect=true` à la fin de votre URL

### « Je ne vois pas la légende de la vidéo ! »

Par défaut, nous plaçons la description dans la balise `og:description`, mais Discord la supprime de l’intégration s’il y a une vidéo à l’intérieur. Nous avons décidé de ne pas la mettre en haut comme le fait [tfxktok.com](https://tfxktok.com) pour éviter que l’intégration ne soit trop encombrée de hashtags.

Cependant, nous voulons donner aux utilisateurs la possibilité de l’ajouter au cas où cela apporterait un contexte supplémentaire à la vidéo. Vous pouvez changer votre URL en `a.tnktok.com` pour ajouter la description en haut.

|         Avant         |        Après         |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **a**.t**n**ktok.com |

> Vous pouvez aussi définir `addDesc` à true via la requête URL en ajoutant `?addDesc=true` à la fin de votre URL

### Passage en Haute Qualité

TikTok prend en charge H.265/HEVC (High Efficiency Video Coding) qui offre une qualité nettement meilleure à taille de fichier égale comparé à H.264, au prix d’une compatibilité réduite. Par défaut, nous utilisons la qualité H.264 car [de nombreux utilisateurs signalent des problèmes avec les intégrations H.265](https://github.com/okdargy/fxTikTok/issues/14), mais le support de H.265 est activable.

Pour activer la lecture haute qualité H.265, ajoutez `?hq=true` ou utilisez `hq.tnktok.com` :
| Avant | Après |
| :--------------------: | :------------------: |
| **www**.t**i**ktok.com | **hq**.t**n**ktok.com |

### Combinaison des Modes

Vous pouvez combiner différents modes en utilisant des noms d'hôtes spécifiques ou des paramètres de requête URL. Par exemple, si vous souhaitez activer le H.265 et voir également la légende, vous pouvez utiliser `hq.a.tnktok.com` ou ajouter `?hq=true&addDesc=true` à l’URL.

> Vous ne pouvez pas utiliser simultanément le mode Direct et le mode Légende car ils se contredisent.

### Pourquoi utiliser tnktok.com ?

Nous remplissons tous les critères pour être l’un des meilleurs services d’intégration TikTok avec de nombreuses fonctionnalités que les autres n’ont pas. Voici un tableau comparant notre service, tnktok.com, avec les autres services d’intégration TikTok ainsi que les intégrations par défaut de TikTok.

|                                        | [fxTikTok](https://www.tnktok.com) | TikTok par défaut | [kkScript](https://kktiktok.com/) | [tfxktok.com](https://tfxktok.com) | [EmbedEZ](https://tiktokez.com) |
| -------------------------------------- | ---------------------------------- | ----------------- | --------------------------------- | ---------------------------------- | ------------------------------- |
| Intégrer des vidéos lisibles           | ☑️                                 | ☑️                | ☑️                                | ☑️                                 | ☑️                              |
| Intégrer des diaporamas multi-images   | ☑️                                 | ❌                | ❌                                | ☑️                                 | ☑️                              |
| Open source                           | ☑️                                 | ❌                | ❔                                | ❌                                 | ❌                              |
| Supporte les intégrations directes    | ☑️                                 | ❌                | ❔                                | ❌                                 | ❌                              |
| Affiche likes, partages, commentaires | ☑️                                 | ☑️                | ❌                                | ☑️                                 | ☑️                              |
| Supprime le tracking pour les redirections | ☑️                             | ❌                | ❌                                | ☑️                                 | ☑️                              |
| Supporte les URLs courtes multi-continent | ☑️                             | ☑️                | ❌                                | ❌                                 | ☑️                              |
| Supporte h265/haute qualité            | ☑️                                 | ❌                | ❌                                | ❌                                 | ❌                              |
| Dernier commit                       | [![][tnk]][tnkc]                   | N/A               | [![][kkt]][kktc]                  | N/A                                | N/A                             |

[tnk]: https://img.shields.io/github/last-commit/okdargy/fxTikTok?label  
[tnkc]: https://github.com/okdargy/fxTikTok/commits  
[kkt]: https://img.shields.io/github/last-commit/kkscript/kk?label  
[kktc]: https://github.com/kkscript/kk/commits  

Les services d’intégration suivants ne sont pas listés car ils ne sont plus maintenus ou ne fonctionnent tout simplement pas :

- [tiktxk.com](https://tiktxk.com)  
- [vxtiktok.com](https://vxtiktok.com) (redirige vers kkScript)  

## 💻 Auto-hébergement

Par défaut, lors de la configuration d’une nouvelle instance fxTikTok, le serveur de déchargement par défaut est `offload.tnktok.com`.  
Pour configurer le vôtre, compilez et lancez simplement [`offload.ts`](/src/offload.ts) qui démarrera sur le port **8787**.

```bash
# Install all necessary dependencies
pnpm install
# Start your server
bun run src/offload.ts
```
> Je recommande de configurer cela sur votre propre domaine avec un reverse proxy comme [nginx](https://nginx.org) et par-dessus Cloudflare avec une protection activée.

Ensuite, déployez votre Worker avec le bouton ci-dessous et suivez les instructions.

[![Déployer sur Cloudflare Workers](https://deploy.workers.cloudflare.com/button)](https://deploy.workers.cloudflare.com/?url=https://github.com/okdargy/fxtiktok)

Une fois terminé, allez dans "Paramètres" et changez votre serveur de déchargement sous "Variables et Secrets" :

<img src="https://raw.githubusercontent.com/okdargy/fxTikTok/hono-rewrite/.github/readme/settings.png" alt="Page des Paramètres, montrant où cliquer pour changer votre serveur de déchargement" height="300px" style="border-radius:2%" />

#### 🎉 Voilà ! Vous avez maintenant votre propre instance fxTikTok à utiliser quand vous voulez, où vous voulez.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---