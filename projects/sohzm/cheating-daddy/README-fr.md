# Cheating Daddy

> [!NOTE]  
> Utilisez la dernière version de MacOS et Windows, les versions antérieures sont partiellement prises en charge

> [!NOTE]  
> Pendant les tests, il ne répondra pas si vous posez une question directement, vous devez simuler un intervieweur posant une question, à laquelle il répondra

Un assistant IA en temps réel qui fournit une aide contextuelle pendant les appels vidéo, entretiens, présentations et réunions grâce à la capture d’écran et à l’analyse audio.

## Fonctionnalités

- **Assistance IA en direct** : Aide en temps réel alimentée par Google Gemini 2.0 Flash Live
- **Capture d’écran et audio** : Analyse ce que vous voyez et entendez pour fournir des réponses contextuelles
- **Profils multiples** : Entretien, appel commercial, réunion d’affaires, présentation, négociation
- **Superposition transparente** : Fenêtre toujours au premier plan, positionnable où vous le souhaitez
- **Mode traversant** : Permettre à la fenêtre d’être transparente aux clics si nécessaire
- **Multi-plateforme** : Fonctionne sur macOS, Windows et Linux (à éviter pour le moment, juste pour tester)

## Installation

1. **Obtenez une clé API Gemini** : Rendez-vous sur [Google AI Studio](https://aistudio.google.com/apikey)
2. **Installez les dépendances** : `npm install`
3. **Lancez l’application** : `npm start`

## Utilisation

1. Entrez votre clé API Gemini dans la fenêtre principale
2. Choisissez votre profil et votre langue dans les paramètres
3. Cliquez sur "Démarrer la session" pour commencer
4. Positionnez la fenêtre à l’aide des raccourcis clavier
5. L’IA fournira une assistance en temps réel basée sur votre écran et les questions posées par l’intervieweur

## Raccourcis clavier

- **Déplacement de la fenêtre** : `Ctrl/Cmd + Flèches` - Déplacer la fenêtre
- **Mode traversant** : `Ctrl/Cmd + M` - Activer/désactiver les événements souris
- **Fermer/Retour** : `Ctrl/Cmd + \` - Fermer la fenêtre ou revenir en arrière
- **Envoyer un message** : `Entrée` - Envoyer le texte à l’IA

## Capture audio

- **macOS** : [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) pour l’audio système 
- **Windows** : Capture audio en boucle (loopback)
- **Linux** : Entrée microphone

## Prérequis

- Système d’exploitation compatible Electron (macOS, Windows, Linux)
- Clé API Gemini
- Permissions d’enregistrement d’écran
- Permissions pour le microphone/audio

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---