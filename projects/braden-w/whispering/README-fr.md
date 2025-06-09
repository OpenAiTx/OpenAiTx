<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Dictée sans couture propulsée par le modèle Whisper d'OpenAI</p>
</p>

<p align="center">
  <!-- Badge de dernière version -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- Badge de licence -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges pour les technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Badges de support de plateforme -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## À propos

Whispering est une application de transcription open-source qui offre une fonctionnalité de reconnaissance vocale globale, avec des options telles que des raccourcis clavier et le copier-coller automatique pour rendre la dictée aussi fluide que possible.

En coulisses, elle est propulsée par le modèle Whisper d'OpenAI, ce qui la rend nettement plus précise que la dictée intégrée.

> **Note importante** : Whispering est principalement conçue comme un outil de transcription, et non comme un outil d’enregistrement. Pour des enregistrements longs où la fiabilité est cruciale, il est recommandé d’utiliser une application dédiée sur votre téléphone ou appareil, qui utilise les API natives d’enregistrement. Cela garantit une qualité audio optimale et une stabilité d’enregistrement.

## Démos

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Fonctionnalités clés

1. **Transcription globale** : Accédez à la fonctionnalité de reconnaissance vocale de Whisper partout grâce à un raccourci clavier global ou en deux clics.
2. **Expérience multiplateforme** :
   - Application de bureau : permet la transcription globale dans toutes les applications.
   - Extension de navigateur : offre la transcription globale dans le navigateur en communiquant avec l’application web.
3. **Intégration au chat** : L’extension de navigateur ajoute un bouton d’enregistrement sur les sites ChatGPT et Claude, permettant une saisie vocale directe et la transcription dans l’interface de chat.
4. **Gestion des transcriptions** : Passez en revue et éditez les transcriptions dans l’application Whispering pour garantir précision et clarté.
5. **Intégration automatique du presse-papiers** : Une fois la transcription terminée, le texte est automatiquement copié dans votre presse-papiers. Une option de collage automatique est également disponible.

## Comment mes données sont-elles stockées ?

Whispering stocke autant de données que possible localement sur votre appareil, y compris les enregistrements et les transcriptions. Cette approche garantit une confidentialité maximale et une sécurité accrue des données. Voici un aperçu de la gestion des données :

1. **Stockage local** : Les enregistrements vocaux et les transcriptions sont stockés dans IndexedDB, utilisé comme stockage de blobs et pour conserver toutes vos données telles que texte et transcriptions.

2. **Service de transcription** : La seule donnée envoyée ailleurs est votre enregistrement vers un service de transcription externe—si vous en choisissez un. Vous avez les options suivantes :
   - Services externes comme OpenAI ou Groq
   - Un service de transcription local tel que `faster-whisper-server`, qui conserve tout sur l’appareil

3. **Paramètres configurables** : Vous pouvez changer le service de transcription dans les paramètres pour garantir une fonctionnalité locale maximale.


## Installation

### Application Web

Visitez [whispering.bradenwong.com](https://whispering.bradenwong.com/), qui héberge la dernière version du dossier `apps/app` sur Vercel.

### Extension Chrome

Installez l’extension Chrome depuis le Chrome Web Store [ici](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Application de bureau

Pour télécharger et installer l’application de bureau Whispering, suivez les étapes selon votre système d’exploitation :

#### Windows

1. Téléchargez le paquet d’installation se terminant par `.msi` depuis la [page des dernières versions](https://github.com/braden-w/whispering/releases).
2. Ouvrez le fichier `.msi` téléchargé pour lancer l’installateur.
3. Si un avertissement de sécurité apparaît, cliquez sur `Plus d’informations` -> `Exécuter quand même` pour poursuivre l’installation.
4. Suivez les instructions à l’écran pour terminer l’installation.

#### macOS

Pour macOS, suivez ces étapes pour installer Whispering :

1. **Téléchargez le paquet d’installation** :
   - Rendez-vous sur la [page des dernières versions](https://github.com/braden-w/whispering/releases).
   - Choisissez le paquet approprié :
     - Pour Apple Silicon : `Whispering_x.x.x_aarch64.dmg`
     - Pour Intel : `Whispering_x.x.x_x64.dmg`

2. **Installez l’application** :
   - Ouvrez le fichier `.dmg` téléchargé.
   - Glissez l’application Whispering vers le dossier Applications.

3. **Lancez Whispering** :
   - Ouvrez Whispering depuis le dossier Applications.
   - Si un avertissement concernant un développeur non vérifié apparaît :
     - Cliquez sur `Annuler`
     - Faites un clic droit sur l’application dans le Finder et sélectionnez `Ouvrir`

4. **Dépannage** (Apple Silicon uniquement) :
   Si vous rencontrez l’erreur `"Whispering" est endommagé et ne peut pas être ouvert` :
   - Ouvrez le Terminal
   - Exécutez la commande suivante :
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Essayez à nouveau d’ouvrir l’application

Après avoir terminé ces étapes, Whispering devrait être prêt à l’emploi sur votre système macOS.

#### Linux

Pour Linux, plusieurs options d’installation sont disponibles. Choisissez celle adaptée à votre environnement :

1. **AppImage** :

   - Téléchargez le fichier `.AppImage` depuis la [page des dernières versions](https://github.com/braden-w/whispering/releases).
   - Rendez le fichier exécutable :
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Lancez l’AppImage :
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Paquet DEB (Debian/Ubuntu)** :
   - Téléchargez le fichier `.deb` depuis la [page des dernières versions](https://github.com/braden-w/whispering/releases).
   - Installez le paquet avec `dpkg` :
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Résolvez les éventuels problèmes de dépendances :
     ```bash
     sudo apt-get install -f
     ```

Après l’installation, l’application sera prête à être utilisée.

## Utilisation

### Extension Chrome

Après avoir installé l’extension Chrome, vous trouverez une icône Whispering dans la barre des extensions de Chrome. Cliquez sur cette icône pour ouvrir l’extension. Cliquez sur le bouton microphone pour enregistrer votre voix, puis sur le bouton carré lorsque vous avez terminé. Votre transcription apparaîtra dans la zone de texte ci-dessous.

Pour accéder à la fonctionnalité ChatGPT ou Claude, rendez-vous sur la page web de ChatGPT ou Claude. Un nouveau bouton d’enregistrement apparaîtra dans l’interface de chat. Cliquez sur ce bouton pour démarrer et arrêter l’enregistrement, et le texte transcrit sera automatiquement inséré dans le champ de saisie du chat.

Pour accéder à la fonctionnalité de raccourci, appuyez sur <kbd>Contrôle</kbd> + <kbd>Maj</kbd> + <kbd>X</kbd> ou <kbd>Commande</kbd> + <kbd>Maj</kbd> + <kbd>X</kbd> (configurable ultérieurement via les raccourcis d’extension Chrome) pour démarrer l’enregistrement depuis n’importe quel site web. La transcription sera automatiquement copiée dans votre presse-papiers et collée dans le champ de saisie actuel.

L’extension Chrome communique avec [whispering.bradenwong.com](https://whispering.bradenwong.com), et tentera automatiquement de créer un onglet en arrière-plan si elle n’en trouve pas un. La plupart des bugs sont dus à l’échec de cette communication, comme de rares cas où l’onglet passe en veille.

### Application Web

L’application web est accessible via [whispering.bradenwong.com](https://whispering.bradenwong.com). Cliquez sur le bouton microphone pour enregistrer votre voix, puis sur le bouton carré lorsque vous avez terminé. Votre transcription apparaîtra dans la zone de texte.

### Application de bureau

Après avoir installé l’application de bureau Whispering, appuyez sur <kbd>Contrôle/Commande</kbd> + <kbd>Maj</kbd> + <kbd>;</kbd> (configurable dans les paramètres) pour démarrer l’enregistrement depuis n’importe où sur votre bureau. La transcription sera automatiquement copiée dans votre presse-papiers et collée, bien que les deux fonctionnalités puissent être activées ou désactivées dans les paramètres.

## Conçu avec

#### Web et bureau

L’application Whispering est construite avec les technologies et bibliothèques suivantes :

- [Svelte 5](https://svelte.dev) : la bibliothèque de réactivité UI choisie.
- [SvelteKit](https://kit.svelte.dev/docs) : pour le routage et la génération de site statique, utilisé à la fois pour le site web et le frontend statique de l’application Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/) : le framework d’application de bureau.
- [Effect-TS](https://github.com/Effect-TS/effect) : pour ajouter un peu de programmation fonctionnelle et écrire des fonctions extrêmement sûres, où les erreurs sont incluses dans le type de retour de la signature de la fonction.
- [Svelte Sonner](https://svelte-sonner.vercel.app/) : une bibliothèque toast simple et personnalisable pour les applications Svelte. Utilisée pour capturer et afficher les erreurs propagées via Effect-TS à l’aide de la fonction `renderAsToast`.
- [TanStack Table](https://tanstack.com/table) : pour alimenter tous les tableaux de données.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API) : une API bas niveau pour stocker de grandes quantités de données structurées dans le navigateur. Synchronisé avec Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte) : la bibliothèque de composants UI choisie.
- [TailwindCSS](https://tailwindcss.com/docs) : un framework CSS utilitaire pour construire rapidement des interfaces utilisateur personnalisées.
- [Turborepo](https://turborepo.org/) : pour la gestion de monorepo, permettant à `apps/app` et `apps/extension` de partager le même code, réduisant considérablement la duplication et, surtout, gardant une seule source de vérité.
- [Rust](https://www.rust-lang.org) : pour étendre les fonctionnalités de l’application de bureau, par exemple en utilisant la crate `enigo` pour la gestion du collage automatique.
- [Vercel](https://vercel.com/) : un hébergement adapté à un projet hobby et intégrant bien Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/) : une bibliothèque d’effets sonores libres de droits.

#### Extension

L’extension Chrome Whispering est construite avec :

- [Plasmo](https://docs.plasmo.com/) : un framework pour créer des extensions Chrome. Utilisation du [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) pour communiquer avec le site Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect) : pour ajouter un peu de programmation fonctionnelle et écrire des fonctions extrêmement sûres, où les erreurs sont incluses dans le type de retour de la signature de la fonction.
- [React](https://reactjs.org) : la bibliothèque de réactivité UI pour l’extension Chrome, Plasmo ne prenant malheureusement pas en charge Svelte 5.
- [ShadCN](https://github.com/shadcn) : la bibliothèque de composants UI pour l’extension Chrome.
- [TailwindCSS](https://tailwindcss.com/docs) : Un framework CSS utilitaire-first pour construire rapidement des interfaces utilisateur personnalisées.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/) : L’API d’extension de Chrome.
- [Zapsplat.com](https://www.zapsplat.com/) : Une bibliothèque d’effets sonores libres de droits.

## Exécuter Whispering en mode développement local

Pour configurer le projet sur votre machine locale, suivez ces étapes :

1. Clonez le dépôt : `git clone https://github.com/braden-w/whispering.git`
2. Accédez au dossier du projet : `cd whispering`
3. Installez les dépendances nécessaires : `pnpm i`

Pour lancer l’application de bureau Whispering et le site web en mode développement :

4. Accédez au dossier de l’application : `cd apps/app`
5. Lancez le serveur de développement : `pnpm tauri dev`

L’application de bureau devrait s’ouvrir automatiquement pour le développement local. Pour développer l’application web, ouvrez votre navigateur et allez sur `http://localhost:5173`.

Pour exécuter l’extension Chrome Whispering en mode développement :

4. Accédez au dossier de l’extension : `cd apps/extension`
5. Lancez le serveur de développement : `pnpm dev --target=chrome-mv3`

Pour développer l’extension Chrome, chargez-la dans Chrome en allant sur `chrome://extensions`, activez le mode développeur, et chargez le dossier `apps/extension/build/{platform}-{manifest-version}-dev` comme une extension non empaquetée.

## Construisez l’exécutable vous-même

Si vous avez des doutes concernant la fiabilité des installateurs ou si vous souhaitez plus de contrôle, vous pouvez toujours construire l’exécutable vous-même. Cela demande plus de configuration, mais cela garantit que vous exécutez le code attendu. C’est tout l’avantage du logiciel open-source !

### Chrome

1. Accédez au dossier de l’extension : `cd apps/extension`
2. Installez les dépendances nécessaires : `pnpm i`
3. Lancez la construction Plasmo : `pnpm plasmo build --target=chrome-mv3`
4. Le résultat se trouve dans `apps/extension/build/chrome-mv3-prod`, qui peut être chargé dans Chrome comme une extension non empaquetée.
5. Vous pouvez aussi construire l’extension pour le Chrome Web Store : `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Accédez au dossier de l’extension : `cd apps/extension`
2. Installez les dépendances nécessaires : `pnpm i`
3. Lancez la construction Plasmo : `pnpm plasmo build --target=firefox-mv3`
4. Le résultat se trouve dans `apps/extension/build/firefox-mv3-prod`, qui peut être chargé dans Chrome comme une extension non empaquetée.
5. Vous pouvez aussi construire l’extension pour le Chrome Web Store : `pnpm plasmo build --target=firefox-mv3 --release`

### Bureau

1. Accédez au dossier de l’application : `cd apps/app`
2. Installez les dépendances nécessaires : `pnpm i`
3. Lancez la construction Tauri : `pnpm tauri build`
4. Vous trouverez l’exécutable dans le dossier `apps/app/target/release`.

## Contribution

Nous accueillons volontiers les contributions de la communauté ! Si vous souhaitez contribuer à Whispering, veuillez suivre ces étapes :

1. Forkez le dépôt.
2. Créez une nouvelle branche pour votre fonctionnalité ou correction de bug : `git checkout -b feature/nom-de-votre-fonctionnalite` ou `git checkout -b fix/nom-de-votre-correction`
3. Apportez vos modifications et validez-les avec un message descriptif.
4. Poussez votre branche sur votre fork : `git push origin nom-de-votre-branche`
5. Créez une pull request depuis votre fork vers le dépôt d’origine.

Veuillez vous assurer que votre code respecte les conventions établies et est bien documenté.

## Licence

Whispering est distribué sous la [Licence MIT](https://opensource.org/licenses/MIT).

## Sponsors

Ce projet est soutenu par les personnes et organisations incroyables suivantes :

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Support et retours

Si vous rencontrez des problèmes ou avez des suggestions d’amélioration, veuillez ouvrir un ticket sur l’onglet [GitHub issues](https://github.com/braden-w/whispering/issues) ou me contacter à [whispering@bradenwong.com](mailto:whispering@bradenwong.com). J’apprécie vraiment vos retours !

Merci d’utiliser Whispering et bonne écriture !

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---