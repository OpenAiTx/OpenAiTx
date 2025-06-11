# Visage : la bibliothèque UI rencontre le creative coding

**Visage** est une bibliothèque C++ multiplateforme et accélérée par GPU pour les interfaces natives et la 2D graphique. Elle fusionne la structure d'un framework UI avec les fonctionnalités des bibliothèques graphiques créatives.

## Exemple complet de base
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Ouvre une fenêtre de 800 x 600 pixels
  app.runEventLoop(); // Exécute la boucle d'événements de la fenêtre. Retourne à la fermeture.
  return 0;
}
```

## Démos
- [Showcase](https://visage.dev/examples/Showcase/)
- [Modes de fusion](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Dégradés](https://visage.dev/examples/Gradients/)
- [Effets de post-traitement Shader](https://visage.dev/examples/PostEffects/)
- [Édition live de Shader](https://visage.dev/examples/LiveShaderEditing/)
- [Flexibilité du Layout](https://visage.dev/examples/Layout/)

## Fonctionnalités UI

- **Normalisation des événements**  
&nbsp;&nbsp;&nbsp;Support multiplateforme pour la normalisation des entrées clavier et souris.

- **Normalisation des fenêtres**  
&nbsp;&nbsp;&nbsp;Support multiplateforme pour l’ouverture et la gestion des fenêtres.

- **Saisie de texte**  
&nbsp;&nbsp;&nbsp;Saisie Unicode avec édition de texte multi-lignes.

- **✨ Emojis ✨**  
&nbsp;&nbsp;&nbsp;Si vous aimez ce genre de choses 🤷

- **Rendu partiel**  
&nbsp;&nbsp;&nbsp;Redessine uniquement les zones modifiées pour une performance optimale.

## Fonctionnalités graphiques

- **Mouvement fluide**  
&nbsp;&nbsp;&nbsp;Les nouvelles images sont affichées au taux de rafraîchissement du moniteur pour des animations fluides.

- **Regroupement automatique des formes**  
&nbsp;&nbsp;&nbsp;Regroupe automatiquement les formes pour un rendu GPU efficace.

- **Modes de fusion**  
&nbsp;&nbsp;&nbsp;Supporte la fusion des calques en mode additif, soustractif ou par dessin d’un masque personnalisé pour laisser passer l’UI.

- **Shaders**  
&nbsp;&nbsp;&nbsp;Écrivez les shaders une fois et transpilez-les pour Direct3D, Metal et OpenGL.

- **Effets inclus**  
&nbsp;&nbsp;&nbsp;Effets en temps réel comme le flou important et le bloom.

- **Précision pixel**  
&nbsp;&nbsp;&nbsp;Accès à la taille des pixels de l’appareil pour un rendu précis sans flou.

## Plateformes supportées
- **Windows** : Direct3D11
- **MacOS** : Metal  
- **Linux** : Vulkan
- **Web/Emscripten** : WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---