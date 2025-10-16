Simple Config GeoIP pour Quantumult X (QuantumultX), Loon, Stash Le fichier de préconfiguration contient des règles de déblocage Apple News, des règles de filtrage publicitaire, la réécriture de déblocage TikTok, des règles de filtrage Shenji et la réécriture d’analyse vidéo VIP, avec des raccourcis correspondants

## Introduction
> + Utilisation de Quantumult X et des fonctionnalités GeoIP pour intégrer plusieurs configurations de réécriture, éliminer la plupart des règles pour économiser des ressources, et simplifier les règles et fichiers de configuration via le redirection Vercel
- [Méthode d'utilisation](https://github.com/smxl/500#使用方法)
- [Règles de filtrage et réécriture](https://github.com/smxl/500#分流规则和重写)
- [Outils](https://github.com/smxl/500#小工具)
- [Mise à jour des fichiers de configuration](https://github.com/smxl/500#配置文件更新)
- [Recommandations](https://github.com/smxl/500#推荐)

## Déclaration

Disclaimer : Certains scripts et contenus sont écrits par ChatGPT

Ce projet a été optimisé sur plusieurs fichiers de configuration [Quantumult X](https://apps.apple.com/us/app/quantumult-x/id1443988620)

Tout le contenu est à titre informatif uniquement, ce projet n’est pas responsable de tout contenu tiers, ces liens et contenus sont fournis à titre de référence et pour faciliter l’utilisation, ils ne représentent pas une approbation ou un soutien de ce projet

Adresse Github : [https://github.com/smxl/500](https://github.com/smxl/500)

## Méthode d'utilisation

1. Télécharger ou copier le fichier de configuration

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/500.conf](https://cnn.vercel.app/500.conf)

2. Quantumult X - Roue dentée - Fichiers de configuration - Télécharger - Coller - Confirmer

3. Mitm - Générer certificat - Configurer certificat - Installer certificat

4. Système - Réglages - Général - Informations - Faire confiance au certificat

5. Quantumult X - Roue dentée - Nœuds - Références (Abonnement) - Ajouter en haut à droite - Remplir le label et le chemin de la ressource (lien d’abonnement de votre fournisseur)

6. Quantumult X - Roue dentée - Autres réglages - Source GeoLite2 Ajouter GeoIP

7. Choisir GeoIP2-CN (copier le lien ou télécharger et importer)
> - [Loyalsoldier](https://github.com/Loyalsoldier/geoip/raw/release/Country-only-cn-private.mmdb)
> - [Hackl0us](https://github.com/Hackl0us/GeoIP2-CN/raw/release/Country.mmdb)
> - [soffchen](https://github.com/soffchen/GeoIP2-CN/raw/release/Country.mmdb)

8. Si vous n’avez pas votre propre lien d’abonnement, vous pouvez utiliser directement celui-ci, si vous souhaitez utiliser votre propre abonnement, modifiez dans le fichier de configuration sous [server_remote] https://cnn.vercel.app/xv-sub par votre lien d’abonnement

9. Démarrage, comme Quantumult X ne supporte pas le lancement via url schema / url-schema, il est recommandé d’activer dans Autres réglages - VPN - Toujours activé, les autres options à choisir selon les besoins

Note 1 : Le lien d’abonnement par défaut de ce fichier de configuration est une information publique, il n’est pas conseillé aux utilisateurs ayant des exigences élevées en matière de confidentialité de l’utiliser à long terme ~~De plus, ce fichier utilise un certificat MITM public, il est recommandé de le générer et de le remplacer soi-même (pour générer le certificat, lors de l’exportation ne pas saisir de mot de passe pour ignorer la passphrase)~~

Note 2 : Comme QX ne supporte pas NaïveProxy (naiveproxy), la version actuelle est recommandée pour être exécutée sur OpenWRT en réseau local, en utilisant le service local ```socks5=192.168.124.124:1080, tag=LAN``` pour la connexion, et en ajoutant un script de démarrage sur le routeur ```naive /[PATH]/config.json```

## Règles de routage et réécriture

tag | Type | Lien court | Description - le texte barré indique une désactivation
-|-|-|-
ads | Règle | https://cnn.vercel.app/xf-ads | Blocage de publicités
cn | Règle | https://cnn.vercel.app/xf-cn | Connexion directe aux services de Chine continentale
global | Règle | https://cnn.vercel.app/xf-global | Services internationaux
hijacking | Règle | https://cnn.vercel.app/xf-hijacking | Anti-détournement
privacy | Règle | https://cnn.vercel.app/xf-privacy | Confidentialité
tg | Règle | https://cnn.vercel.app/xf-tg | Telegram
unbreak | Règle | https://cnn.vercel.app/xf-unbreak | Correction de règles
-|-|-|-
adlite | Réécriture | https://cnn.vercel.app/xr-adlite | Réécriture pour suppression de publicités
ads | Réécriture | https://cnn.vercel.app/xr-ads | Réécriture pour suppression de publicités
adscript | Réécriture | https://cnn.vercel.app/xr-adscript | Script de suppression de publicités
apple | Réécriture | https://cnn.vercel.app/xr-apple | Déblocage des services Apple restreints, suppression de la météo, compatible iOS16, utiliser Scriptable/IQair/widget « Environnement » pour afficher l’AQI US
bing | Réécriture | https://cnn.vercel.app/xr-bing | Nouveau Bing avec Safari via Edge
bili | Réécriture | https://cnn.vercel.app/xr-bili | Optimisation de l’interface Bilibili
box | Réécriture | https://cnn.vercel.app/xr-box | BoxJS
-|-|-|À ajouter manuellement
covidsc | Réécriture | https://cnn.vercel.app/xr-covidsc | Rapport de test PCR 24h Sichuan Tianfu Health Pass, toutes fonctionnalités - Alipay + WeChat, désactivé par défaut
covidsc | Réécriture | https://cnn.vercel.app/xr-covidhn | Rapport de test PCR 24h Henan Yukan Code, désactivé par défaut
emby | Réécriture | https://cnn.vercel.app/xr-emby | Déblocage Emby, sans notification
fake | Réécriture | https://cnn.vercel.app/xr-fake | Déblocage Fake Pro, simplifié par rapport à lk, ajout de Spotify Pro
jsc | Réécriture | https://cnn.vercel.app/xr-jsc | Script pour récupération de cookies
lk | Réécriture | https://cnn.vercel.app/xr-lk | Fake VIP pour services étrangers
upgrade | Réécriture | https://cnn.vercel.app/xr-upgrade | Blocage de la vérification des mises à jour d’application
res | Réécriture | https://cnn.vercel.app/xr-res | Optimisation pour logiciels chinois
search | Réécriture | https://cnn.vercel.app/xr-search | Réécriture du moteur de recherche DuckDuckGo
v|Réécriture|https://cnn.vercel.app/xr-v|Réécriture de l’analyse vidéo

Vous pouvez ajuster les règles ci-dessus et activer ou non la réécriture selon votre situation, par exemple : si vous utilisez rarement des logiciels étrangers, alors ```lk Réécriture https://cnn.vercel.app/xr-lk Services étrangers Fake VIP``` où plusieurs logiciels avec déblocage VIP/Pro ne vous seront pas utiles [certaines réécritures sont déjà obsolètes]

De même ```fake https://cnn.vercel.app/xr-fake Fake Pro Déblocage``` est une version simplifiée de cette règle

En 2024, en raison des changements de l’API iOS, la nouvelle version de TikTok nécessite uniquement de modifier le pays du système et une règle de routage pour fonctionner ```host-wildcard, *tiktok*, proxy```

## Outils

Outil|Fonction|Lien/Supplément
-|-|-
Recherche rapide|Définir DuckDuckGo comme moteur de recherche par défaut dans Safari|Google par défaut, préfixez par deux lettres pour un autre moteur Baidu:bd/Magi:mm/Twitter:tt/YouTube:yt/WolframAlpha:wa + espace + mot-clé

Après activation de la réécriture fake, ces logiciels sont améliorés : Adguard, Day One, Draft, Documents, Lightroom, PS Express, Memrise, Spotify pro*... L’astérisque* indique une incertitude sur le déblocage des achats intégrés ou la simulation VIP

Après activation de la réécriture res, ces logiciels sont améliorés : Bilibili, Caiyun Weather, WeChat, Baidu Netdisk...

## Mise à jour du fichier de configuration

500.conf

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/q](https://cnn.vercel.app/q)

## Recommandations

Ce fichier de configuration fait référence à certains projets ou services, vous pouvez les trouver dans vercel.json

Pour faciliter l’accès aux projets originaux, les références dans le fichier utilisent le format `https://github.com/utilisateur/projet/raw/branche/répertoire/fichier`

Veuillez copier `https://github.com/utilisateur/projet/` dans la barre d’adresse pour accéder au projet référencé

--

Modèle minimaliste https://cnn.vercel.app Supprime la plupart des configurations inutiles, ne conserve que la structure de base

Remerciements à ilovexjp ILoveNucleicAcidTest etc.

Merci à l'IA, au Web3 et au livre blanc

Merci au divertissement et à vous-même


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---