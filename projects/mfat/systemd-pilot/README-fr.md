# systemd Pilot

systemd Pilot est une application de bureau pour la gestion des services systemd sur les systèmes GNU/Linux. On peut la décrire comme une interface graphique pour systemctl. 

![image](https://github.com/user-attachments/assets/85ee68be-aa3e-4291-8435-ef9ee7b8b72f)


![Screenshot From 2024-12-31 11-26-27](https://github.com/user-attachments/assets/09a58f8c-7d2b-4bc3-87db-561221295b18)


![Screenshot From 2024-12-31 11-28-58](https://github.com/user-attachments/assets/1c5653ab-31bc-4fd1-b607-1240dd85f831)


![Screenshot From 2024-12-31 11-29-24](https://github.com/user-attachments/assets/b9eb7194-b3dc-4c17-8ecc-8946374a2ca1)

![Screenshot From 2024-12-31 11-29-41](https://github.com/user-attachments/assets/2715e99c-2a96-406b-9d55-4f3512bbc345)


## Fonctionnalités
- Lister les services système sur la machine locale ou des hôtes distants
- Déployer rapidement un nouveau service à l’aide d’un modèle
- Démarrer, Arrêter, Redémarrer les services, afficher le statut
- Recherche facile. Il suffit de commencer à taper et l’application trouvera les services pertinents
- Léger et peu gourmand en ressources système (juste un script Python unique)
  
## Téléchargement
- Téléchargez depuis la section [releases](https://github.com/mfat/systemd-pilot/releases) le paquet pour votre distribution.
  
## Pré-requis
Si vous préférez exécuter directement le script python, voici les prérequis :

Modules Python :
- PyGObject>=3.42.0
- paramiko>=3.0.0
- keyring>=24.0.0
- rich>=13.0.0
- PyYAML

Dépendances Debian :
- `sudo apt install 
    python3-gi 
    python3-gi-cairo 
    gir1.2-gtk-3.0 
    gir1.2-gtksource-4 
    python3-paramiko 
    python3-yaml 
    python3-keyring`
  
Dépendances Fedora/RHEL :
- `sudo dnf install python3
      python3-gobject
      python3-paramiko
      python3-keyring
      python3-rich
      python3-cairo
      python3-gobject
      python3-dbus
      python3-secretstorage
      gtk4
      libadwaita
      gtksourceview4
      systemd`
  


## Soutenir le développement
Bitcoin:`bc1qqtsyf0ft85zshsnw25jgsxnqy45rfa867zqk4t`

Doge:`DRzNb8DycFD65H6oHNLuzyTzY1S5avPHHx`

  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---