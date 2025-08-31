# Whispera

Une application native macOS qui remplace la dictée intégrée par Whisper d’OpenAI pour une précision de transcription supérieure. Transcrivez la parole, des fichiers locaux, des vidéos YouTube et des flux réseau – tout est traité localement sur votre Neural Engine.
<div align="center">
  
  ### [⬇️ Télécharger la dernière version](https://github.com/sapoepsilon/Whispera/releases/latest)
  
  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/sapoepsilon/Whispera?style=for-the-badge&logo=github&color=0969da&labelColor=1f2328)](https://github.com/sapoepsilon/Whispera/releases/latest)
  
</div>

## Démonstrations

<table>
  <tr>
    <th>Champ de parole en texte</th>
    <th>Transcription de fichier/URL avec horodatages</th>
  </tr>
  <tr>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/1da72bbb-a1cf-46ee-a997-893f1939e626" controls>
        Votre navigateur ne supporte pas la balise vidéo.
      </video>
    </td>
    <td width="50%">
      <video src="https://github.com/user-attachments/assets/d573bef4-a3b2-49ac-a1fd-3c6735648fdc" controls>
        Votre navigateur ne supporte pas la balise vidéo.
      </video>
    </td>
  </tr>
</table>

## Fonctionnalités

- **Transcription en direct** (bêta)
- **Parole en texte** - Remplace la dictée native macOS par WhisperKit (modèle Whisper d’OpenAI sur Neural Engine) pour une meilleure précision
- **Transcription de fichiers** - Fichiers audio et vidéo
- **Transcription de médias réseau** - Diffusez des URL vidéo/musique
- **Transcription YouTube**

Tous les traitements s'exécutent localement. Internet est requis uniquement pour le téléchargement initial du modèle.  
## Feuille de route

- [x] Support multilingue au-delà de l'anglais  
  - **PR** : https://github.com/sapoepsilon/Whispera/pull/2  
  - **Version** : https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.3  
- [x] Capacités de traduction en temps réel  
  - **PR** : https://github.com/sapoepsilon/Whispera/pull/17  
  - **Version** : https://github.com/sapoepsilon/Whispera/releases/tag/v1.0.18  
- [ ] Options de personnalisation supplémentaires  

## Utilisation

Utilisez simplement votre raccourci global configuré pour commencer la transcription avec Whisper au lieu de la dictée macOS par défaut.

## Problèmes connus

- L'application ne fonctionne pas avec les Mac Intel (voir [Problème 15](https://github.com/sapoepsilon/whispera/issues/15))  
- L'installation automatique ne fonctionne pas, après le téléchargement de l'application, veuillez glisser-déposer manuellement l'application dans votre dossier `/Applications`  
## Exigences

- macOS 13.0 ou version ultérieure  
- Apple Silicon  
- Nous travaillons sur le support pour Mac Intel  

## Crédits

Construit avec :  
- [WhisperKit](https://github.com/argmaxinc/WhisperKit) - Transcription Whisper sur appareil pour Apple Silicon  
- [YouTubeKit](https://github.com/alexeichhorn/YouTubeKit) - Extraction de contenu YouTube  
- [swift-markdown-ui](https://github.com/gonzalezreal/swift-markdown-ui)  

Merci à ces projets d'avoir rendu possible une transcription locale et respectueuse de la vie privée.

## Licence

Licence MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-31

---