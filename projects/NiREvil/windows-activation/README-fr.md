# Activation instantanée de Windows 10 & 11 : Solution en 40 secondes.

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Ce dépôt contient une méthode permettant d'activer Windows 10 et 11 en moins de 40 secondes. Les deux méthodes sont compatibles avec les versions Home, Home N, Home Single Lang, Home Country Specific, Professionnel, Éducation et Entreprise de Windows.

## Méthode 1 (recommandée)  
### Activation instantanée de Windows à l'aide de (PowerShell)  
> [!ASTUCE]
> Il existe de nombreuses façons de lancer PowerShell sous Windows 10 & 11. [^1]

L'une des méthodes les plus rapides pour ouvrir PowerShell dans Windows est une recherche via le menu Démarrer. Vous pouvez suivre les étapes ci-dessous :

<br>

### Étape 1  
Il suffit de cliquer sur l’icône démarrer ou de recherche et de taper "PowerShell" dans la barre de recherche.  
> Une autre méthode simple : [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Étape 2  
Ensuite, vous devez cliquer sur `Exécuter en tant qu'administrateur` pour lancer PowerShell, car dans ce cas, il faut l’exécuter avec les **privilèges administrateur**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Étape 3  
Après une courte pause pour permettre l’exécution, veuillez `copier` cette ligne :

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Étape 4  
Collez-la ensuite (clic droit) et appuyez sur la touche entrée. Dans la fenêtre nouvellement ouverte, plusieurs options sont disponibles, parmi lesquelles il faut choisir l’option `1` et patienter quelques secondes pour finaliser.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Félicitations,
votre Windows a été activé.  
Vous pouvez maintenant appuyer sur la touche entrée pour quitter le CMD, fermer PowerShell et vérifier le menu d’activation de Windows [^3]

<br><br><br><br><br><br><br><br>

## Méthode 2  
### Activation instantanée de Windows via CMD (Invite de commandes)

<br>

> [!NOTE]
> Pensez à **vous connecter** à **Internet**
>
> Le VPN n’est **pas nécessaire**

<br>

### Étape 1  
Tout d’abord, cliquez sur l’icône démarrer ou de recherche et tapez "CMD" dans la barre de recherche. Puis, après avoir vu l’option Invite de commandes, exécutez-la en tant qu’**administrateur**  
> autres méthodes simples : [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Liste des CLÉS DE LICENCE

|            **Clé**            |  **Version**   |
| :---------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professionnel |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professionnel N|
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Éducation    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Éducation N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Entreprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Entreprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Étape 2  
Installez la clé client KMS.

Utilisez cette commande :

```CSS
slmgr /ipk votreclédeLicence
```

> [!NOTE]
> Veuillez choisir une des **clés de licence** de la liste qui **correspond à votre version de Windows** et la remplacer par le terme `votreclédeLicence` dans la commande.

> [!ASTUCE]
> Comment vérifier la version de Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Étape 3  
Définissez l’adresse de la machine KMS.

Utilisez la commande :

```CSS
slmgr /skms kms8.msguides.com
```

pour vous connecter à mon serveur KMS.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Étape 4  
Activez votre Windows.  
La dernière étape consiste à activer Windows avec la commande suivante :

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### Étape 5  
Vérifiez à nouveau le statut de l’activation [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Terminé ✅  
Votre Windows est activé avec succès.

<br>

**Soyez curieux 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Montre un soleil illustré en mode clair et une lune avec des étoiles en mode sombre." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 façons de lancer PowerShell sous Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Autre méthode très simple pour lancer PowerShell : **Clic droit** sur le menu Démarrer pour afficher le menu rapide et choisissez **Windows Terminal (admin)** sous Windows 11 ou **Windows PowerShell (admin)** sous Windows 10 dans la liste.
[^3]: Pour vérifier la version de votre Windows : **Clic droit** sur le menu Démarrer et sélectionnez l’option **Système**. La version de Windows apparaît dans la deuxième section sous **Édition**. Vous pouvez également suivre les étapes de la méthode 2 en les **copiant-collant**. Copiez les commandes puis faites un **clic droit** dans le **cmd ou powershell** pour les coller.
[^4]: Version Home Single language.
[^5]: Version Home Country Specific.
[^6]: Pour voir le statut d’activation de Windows, allez dans :  
***Paramètres → Mise à jour et sécurité → menu Activation.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---