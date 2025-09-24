<div id="header" align="center">
  <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/icon.png"/>
</div>

Air Drop Assistant (ADA) vous offre un contrôle plus granulaire sur vos paramètres AirDrop que les contrôles MDM classiques.

Sur iOS, lorsque AirDrop est réglé sur Tout le monde, il revient à Contacts uniquement après 10 minutes.

Sur macOS, AirDrop est soit Désactivé, Contacts uniquement, ou Tout le monde - un réglage que vous devez basculer manuellement via Réglages Système > Général > AirDrop et Handoff ou depuis le menu du Centre de contrôle.

ADA vous permet de définir si AirDrop revient à Contacts uniquement ou Désactivé et le délai avant ce basculement.

Pourquoi voudriez-vous cette fonctionnalité ?
- Vous utilisez fréquemment votre ordinateur dans des espaces publics et ne voulez pas que AirDrop reste ouvert pour recevoir de Tout le monde.
- Les organisations autorisent AirDrop mais souhaitent un contrôle plus granulaire que celui offert par la gestion des appareils Apple.


<div align="center">
    <img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adamenu.png" /><img src="https://raw.githubusercontent.com/boberito/AirDropAssistant/main/adaprefs.png" />
</div>

ADA peut être configuré via un profil de configuration déployé par votre MDM.

**Domaine** `com.ttinc.Air-Drop-Assistant`

`airDropSetting` - **Type : Chaîne**
Valeur acceptable : **Contacts uniquement** ou **Désactivé**
- Lorsqu’il est défini, ADA verrouillera le réglage d’AirDrop sur cette valeur après le délai.

`timing` - **Type : Entier**
Valeur acceptable : **0-1000**
- Durée avant qu’ADA ne bascule AirDrop vers la valeur définie dans `airDropSetting`

`hideMenuIcon` - **Type : Booléen**
Valeur acceptable : **true** ou **false**
- Cache l’icône dans la barre de menu

`icon_mode` - **Type : Chaîne**
Valeur acceptable : **coloré** ou **nb**
- Rend l’icône colorée ou monochrome.
`afterFirstLaunch` - **Type : Boolean**
Valeur acceptable : **true** ou **false**
- Cache la question du premier lancement.

`disableUpdates` - **Type : Boolean**
Valeur acceptable : **true** ou **false**
- Désactive la vérification des mises à jour au lancement et masque l’élément de menu pour la vérification.

ADA peut également être enregistré pour se lancer au démarrage avec l’argument register et supprimé des éléments de démarrage également.

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --register`

et

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/MacOS/Air\ Drop\ Assistant --unregister`

La restriction directionnelle AirDrop d’ADA peut être configurée par MDM.

`/Applications/Utilities/Air\ Drop\ Assistant.app/Contents/Resources/ADA_PF_Helper_Script.sh -argument`

- `-blockOut` bloque AirDrop sortant
- `-blockIn` bloque AirDrop entrant
- `-remove` autorise AirDrop dans les deux sens

Exemple mobileconfig

```
<?xml version="1.0" encoding="UTF-8"?>
<!DOCTYPE plist PUBLIC "-//Apple//DTD PLIST 1.0//EN" "http://www.apple.com/DTDs/PropertyList-1.0.dtd">
<plist version="1.0">
<dict>
    <key>PayloadContent</key>
    <array>
        <dict>
            <key>PayloadIdentifier</key>
            <string>ccom.ttinc.Air-Drop-Assistant.26F7424C-FEF3-4E94-8E78-2673B2B8CDD3</string>
            <key>PayloadType</key>
            <string>com.ttinc.Air-Drop-Assistant</string>
            <key>PayloadUUID</key>
            <string>26F7424C-FEF3-4E94-8E78-2673B2B8CDD3</string>
            <key>PayloadVersion</key>
            <integer>1</integer>
            <key>airDropSetting</key>
            <string>Contacts Only</string>
            <key>timing</key>
            <integer>5</integer>
            <key>hideMenuIcon</key>
            <true/>
            <key>icon_mode</key>
            <string>colorful</string>
            <key>afterFirstLaunch</key>
            <true/>
        </dict>
    </array>
    <key>PayloadDescription</key>
    <string>ADA Settings</string>
    <key>PayloadDisplayName</key>
    <string>ADA</string>
    <key>PayloadIdentifier</key>
    <string>com.ttinc.Air-Drop-Assistant</string>
    <key>PayloadOrganization</key>
    <string>BOB</string>
    <key>PayloadScope</key>
    <string>System</string>
    <key>PayloadType</key>
    <string>Configuration</string>
    <key>PayloadUUID</key>
    <string>1BBD23DE-7ED7-45DF-8126-5085A681ED83</string>
    <key>PayloadVersion</key>
    <integer>1</integer>
</dict>
</plist>
```
Pour configurer les notifications, vous devrez créer un profil `com.apple.notificationsettings` pour inclure ces clés

```
<!--- THIS KEY IS REQUIRED TO IDENTIFY WHAT APP -->
<key>BundleIdentifier</key>
	<string>com.ttinc.Air-Drop-Assistant</string>

<!--- IF YOU WANT ZERO NOTIFICATIONS SET THESE TWO TO FALSE -->
<key>NotificationsEnabled</key>
	<true/>
<key>CriticalAlertEnabled</key>
	<false/>

<!--- THIS CAN BE SET TO 0 (Off), 1 (Temporary), 2 (Persistent) -->
<key>AlertType</key>
	<integer>1</integer>
				
<key>ShowInLockScreen</key>
	<true/>
<key>ShowInNotificationCenter</key>
	<true/>
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-24

---