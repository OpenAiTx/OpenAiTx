Yuebing 🥮
==========
Yuebing est un logiciel open-source pour gérer des sites d’hébergement vidéo.

Yuebing prépare automatiquement vos vidéos sources pour le streaming en utilisant des formats modernes, lisibles sur
n’importe quel appareil et via n’importe quelle connexion.

Yuebing peut utiliser soit Amazon S3 soit Backblaze B2 pour le stockage en backend, et offre de nombreuses fonctionnalités avancées.

### Source
* [yuebing sur GitHub](https://github.com/cobbzilla/yuebing)
* [yuebing sur npm](https://www.npmjs.com/package/yuebing)
* [yuebing sur DockerHub](https://hub.docker.com/r/cobbzilla/yuebing)

# Lire ceci dans une autre langue
Ce document README.md a été traduit, via [hokeylization](https://github.com/cobbzilla/hokeylization), en
plusieurs langues.

Je suis certain que ce n’est pas parfait, mais j’espère que c’est mieux que rien !

&nbsp;&nbsp;&nbsp;[🇸🇦 Arabe](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ar/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇩 Bengali](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/bn/README.md)
&nbsp;&nbsp;&nbsp;[🇩🇪 Allemand](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/de/README.md)
&nbsp;&nbsp;&nbsp;[🇺🇸 Anglais](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/en/README.md)
&nbsp;&nbsp;&nbsp;[🇪🇸 Espagnol](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/es/README.md)
&nbsp;&nbsp;&nbsp;[🇫🇷 Français](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/fr/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇩 Haoussa](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ha/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 Hindi](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/hi/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇩 Indonésien](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/id/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇹 Italien](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/it/README.md)
&nbsp;&nbsp;&nbsp;[🇯🇵 Japonais](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ja/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇷 Coréen](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ko/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 Marathi](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/mr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇱 Polonais](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pl/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇷 Portugais](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pt/README.md)
&nbsp;&nbsp;&nbsp;[🇷🇺 Russe](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ru/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇪 Swahili](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/sw/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇭 Tagalog](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tl/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇷 Turc](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇰 Ourdou](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ur/README.md)
&nbsp;&nbsp;&nbsp;[🇻🇳 Vietnamien](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/vi/README.md)
&nbsp;&nbsp;&nbsp;[🇨🇳 Chinois](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/zh/README.md)
----

# Contenu
* [Inspiration](#Inspiration)
* [Fonctionnalités](#Features)
* [Installation](#Installation)
  * [Docker](#Docker)
  * [package npm](#npm-package)
  * [Depuis la source](#From-source)
* [Configuration](#Configuration)
  * [config nginx](#nginx-config)
* [Pourquoi le nom yuebing ?](#Why-the-name-yuebing?)

## Inspiration
L'année dernière, ma mère a passé beaucoup de temps (et d'argent !) à organiser et numériser une archive de vieilles vidéos familiales.
Certaines dataient des années 1940. Vraiment magnifiques, classiques.

Nous voulions les partager en privé avec la famille, mais *pas avec les grandes entreprises technologiques*.
Utiliser un hébergement vidéo "gratuit" d’un grand fournisseur était exclu.

Ce que nous cherchions :
* Auto-hébergé, mais totalement **facile à utiliser et à maintenir sans intervention**
* Diffusion en formats vidéo modernes, y compris débit adaptatif
* Les vidéos sont lisibles sur n’importe quel appareil, bureau ou mobile
* Avec une connexion à haute bande passante, la qualité vidéo est excellente ; aussi bonne que possible
  * **Même avec une mauvaise connexion**, la lecture est de bonne qualité et *ne saute pas ni ne met en mémoire tampon*
* Stockage chiffré, donc possibilité d’utiliser des solutions de stockage cloud publiques en toute confiance
* Serveur sans état : persister tout ce qui est important dans un stockage très résilient
  * **Je ne veux pas m’inquiéter des sauvegardes !**
  * *C’était un plus. En fait, rien d’existant n’a cela. Yuebing l’a !*
* Après avoir utilisé une instance puissante pour transcodage, la supprimer et utiliser quelque chose de moins cher à long terme
  * Vous pouvez faire tourner Yuebing pour moins de 10 $/mois ; et espérons encore moins à l’avenir en optimisant l’empreinte de Yuebing

J’ai pris quelques semaines pour examiner ce qui existait. J’ai commencé à assouplir beaucoup mes exigences, et pourtant
je n’ai rien trouvé de correct. J’ai regardé plusieurs projets open source, je ne dis pas lesquels car ils avaient tous
plusieurs défauts évidents.

Alors, je me suis dit, ce n’est pas si compliqué ? On connecte S3 à ffmpeg, on met un frontend assez moderne, et c’est fini, non ?
... eh bien, euh, la majeure partie du travail a pris quelques mois, mais c’était trop amusant pour s’arrêter !  
J’espère que vous l’apprécierez aussi !

### <a style="text-decoration: none; color: inherit" href="https://open.spotify.com/track/0HEYFRBo4pBLLWjXsAZjod?si=riLTqMknTji7_X_4XzSkGQ&context=spotify%3Aalbum%3A20KGjm5xRROTqP0UY1EVRg">**Rendons l’auto-hébergement de sites vidéo super facile !**</a>

## Fonctionnalités  
* Transformez un bucket S3 (ou B2) de vidéos en un site vidéo privé pour amis et famille !  
* Connectez un ou plusieurs buckets sources fournissant des fichiers médias bruts  
* Yuebing transcode automatiquement les vidéos sources dans le format le plus récent et le plus largement supporté pour le streaming adaptatif (DASH/mp4)  
* TOUTES les données sont stockées dans le bucket de destination ; vous pouvez détruire le serveur quand vous voulez  
  * Utile pour démarrer initialement sur une instance optimisée CPU pour le transcodage initial, puis utiliser \
    une instance bien moins chère pour un service 24/7/365.  
  * Prend en charge le stockage entièrement chiffré (chiffrement côté application, vous seul avez la clé)  
  * Toujours en lecture seule depuis la source, ne modifie jamais le contenu source  
  * Scan automatique et manuel pour les nouveaux fichiers médias  
* Quel niveau de confidentialité souhaitez-vous ? Yuebing supporte :  
  * Totalement privé : aucun média montré aux utilisateurs anonymes, seules les adresses email approuvées peuvent créer des comptes  
  * Semi-privé : aucun média montré aux utilisateurs anonymes, mais n’importe qui peut créer un compte utilisateur  
  * Public avec inscription limitée : média visible par tous, mais seules les adresses email approuvées peuvent créer des comptes  
  * Totalement public : média visible par tous, et n’importe qui peut créer un compte utilisateur  
* Entièrement internationalisé ! Tout le texte visible par l’utilisateur (et autres éléments spécifiques à la localisation) provient de ressources localisées  
  * [Aidez la communauté, traduisez Yuebing dans de nouvelles langues !](https://github.com/cobbzilla/yuebing/blob/master/docs/localize.md)  
* Console d’administration complète  
* Recherche de vidéos par mots-clés, ou depuis un nuage de tags  
* <a href="https://www.patreon.com/cobbzilla">**Bientôt disponible grâce à votre soutien**</a> :  
  * Support pour plus de types médias (audio, images, etc.)  
  * Médias téléchargés par les utilisateurs  
  * Likes, partages, et notifications push  
  * Nouveau « type source » : une autre instance Yuebing !  
    * Fédération entre instances amies : recherche unifiée, comptes utilisateurs, etc.

## Fonctionnalités pour utilisateurs anonymes (si le site a été configuré pour autoriser les visiteurs anonymes)  
* Parcourir les médias  
* Regarder les médias !  
* Créer un compte (si le site a été configuré pour autoriser l’enregistrement de comptes)

## Fonctionnalités pour utilisateurs connectés  
* Parcourir les médias  
* Regarder les médias !  
* Ajouter un commentaire, modifier votre commentaire, supprimer votre commentaire !
* Inviter des amis  
* Modifier les informations du compte  
* Supprimer le compte, supprime tout ce qui vous appartient y compris tous vos commentaires  

## Fonctionnalités utilisateur admin  
* Modifier les métadonnées des médias, voir les vignettes, changer la vignette sélectionnée  
* Voir la file d'attente de transformation des médias et le statut des tâches  
* Lancer de nouvelles analyses et indexations des médias source  

## Fonctionnalités serveur/backend  
* Convivial pour les environnements transitoires, AUCUNE donnée persistante/importante n'est stockée dans le conteneur.  
  * Toutes les données durables sont conservées dans le bucket de destination ; essentiellement, nous utilisons S3 comme base de données  
* Analyse périodique automatique du bucket source pour les nouveaux médias  
* Ajouter et modifier les métadonnées des médias ; les modifications sont stockées sur le bucket de destination, les médias source ne sont jamais modifiés  
* Profils de sortie configurables. Le profil par défaut est DASH-mp4 avec plusieurs sous-profils  
* Les informations du compte utilisateur sont également stockées sur le bucket de destination, éventuellement cryptées  
  * Si la clé de cryptage est modifiée, l'administrateur peut migrer les utilisateurs vers la nouvelle clé via la console d'administration web  

## Installation  
Vous pouvez installer et exécuter `yuebing` via docker, npm ou directement depuis la source.  

### Docker  
Si vous avez docker, vous pouvez démarrer rapidement avec Yuebing :  

    docker run -it cobbzilla/yuebing  

### paquet npm  
    # installer globalement avec npm  
    npm i -g yuebing  

    # installer globalement avec yarn  
    yarn global add yuebing  

    # Maintenant, la commande 'yuebing' devrait être dans votre PATH  
    yuebing  

### Depuis la source  
Pour exécuter depuis la source, vous aurez besoin de nodejs v16+ et yarn  

    # Cloner la source et installer les dépendances
    git clone https://github.com/cobbzilla/yuebing.git
    cd yuebing
    yarn install

    # Utilisez la commande 'yuebing' depuis le dépôt git
    ./yuebing

    # Ou, puisque vous avez le code source, exécutez n'importe quel script `yarn`
    yarn docker-run-dev    # Construction & démarrage les plus rapides, image docker dev
    yarn docker-run        # Plus rapide à l'exécution, image docker production
    yarn dev               # Exécute yuebing localement en mode dev
    yarn build             # Compile yuebing localement pour le mode production
    yarn start             # Démarre yuebing localement en mode production

Voir la [documentation développeur](https://github.com/cobbzilla/yuebing/blob/master/docs/developer.md) pour plus d'infos

## Configuration
Pour tester Yuebing, il est possible de le lancer sans rien configurer.
Exécutez `yuebing` et vous serez invité à saisir la configuration minimale au démarrage.

Si vous prévoyez d'utiliser Yuebing sur une longue période, consultez la [doc de configuration](https://github.com/cobbzilla/yuebing/blob/master/docs/config.md) pour
plus d'informations sur la mise en place.

### Configuration nginx
Yuebing est une application Nuxt, et attend que vous placiez nginx (ou un autre serveur web) en
amont pour gérer le SSL, la limitation de débit si nécessaire, etc.

Si vous utilisez nginx, voici une [config d'exemple](https://github.com/cobbzilla/yuebing/blob/master/docs/sample-yuebing-nginx.conf) que vous pouvez utiliser.

## Pourquoi le nom yuebing ?
[Oolong le lapin](https://fr.wikipedia.org/wiki/Oolong_(lapin)) était un adorable et célèbre
[mème internet précoce](https://duckduckgo.com/?q=oolong+rabbit&ia=images&iax=images). Oolong est mort en 2003,
deux ans avant qu'un certain service vidéo massivement populaire n'existe !

Le successeur d'Oolong s'appelait Yuebing. Yuebing n'était pas aussi célèbre qu'Oolong, mais cela avait-il de l'importance ?
Yuebing a néanmoins réussi.

Peut-être plus intéressant encore, yuebing signifie [gâteau de lune](https://fr.wikipedia.org/wiki/Gâteau_de_lune)
(chinois : [月饼](https://zh.wikipedia.org/wiki/%E6%9C%88%E9%A5%BC),
japonais : [月餅](https://ja.wikipedia.org/wiki/%E6%9C%88%E9%A4%85)) ; les gâteaux de lune sont très savoureux et se trouvent dans
une grande variété de saveurs et de styles. Profitez d'un style régional traditionnel, ou essayez un gâteau exotique de boulangers contemporains  
qui explorent des territoires délicieusement inexplorés ! Il y a vraiment un yuebing pour tous les goûts !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---