<a href="https://buymeacoffee.com/koromix" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# Aperçu

Koffi est un module FFI C rapide et facile à utiliser pour Node.js, offrant :

* Faible surcharge et performance rapide (voir les [benchmarks](https://koffi.dev/benchmarks))
* Support des types de données primitifs et agrégés (structs et tableaux de taille fixe), à la fois par référence (pointeur) et par valeur
* Les fonctions Javascript peuvent être utilisées comme callbacks C (depuis la version 1.2.0)
* Base de code bien testée pour les combinaisons OS/architecture populaires

Les combinaisons suivantes d’OS et d’architectures __sont officiellement supportées et testées__ à ce jour :

ISA / OS           | Windows     | Linux    | macOS       | FreeBSD     | OpenBSD
------------------ | ----------- | -------- | ----------- | ----------- | --------
x86 (IA32) [^1]    | ✅ Oui      | ✅ Oui   | ⬜️ *N/A*    | ✅ Oui      | ✅ Oui
x86_64 (AMD64)     | ✅ Oui      | ✅ Oui   | ✅ Oui      | ✅ Oui      | ✅ Oui
ARM32 LE [^2]      | ⬜️ *N/A*    | ✅ Oui   | ⬜️ *N/A*    | 🟨 Probablement | 🟨 Probablement
ARM64 (AArch64) LE | ✅ Oui      | ✅ Oui   | ✅ Oui      | ✅ Oui      | 🟨 Probablement
RISC-V 64 [^3]     | ⬜️ *N/A*    | ✅ Oui   | ⬜️ *N/A*    | 🟨 Probablement | 🟨 Probablement

[^1]: Les conventions d’appel suivantes sont supportées : cdecl, stdcall, MS fastcall, thiscall.
[^2]: Le binaire précompilé utilise l’ABI hard float et attend un coprocesseur VFP. Compilez depuis la source pour utiliser Koffi avec une ABI différente (softfp, soft).
[^3]: Le binaire précompilé utilise l’ABI LP64D (float double précision). L’ABI LP64 est supportée en théorie si vous compilez Koffi depuis la source mais cela n’a pas été testé. L’ABI LP64F n’est pas supportée.

Utilisez les liens suivants pour plus d’informations :

- Documentation : https://koffi.dev/
- Changelog : https://koffi.dev/changelog
- Code source : https://codeberg.org/Koromix/rygel/ (voir ci-dessous pour une explication)

# Code source

Ce dépôt ne contient pas le code de Koffi mais existe uniquement comme façade. Pour des raisons pratiques, j’ai commencé à utiliser un seul dépôt pour tous mes projets en 2018 car cela est plus facile à gérer.

Le code source est disponible ici : https://codeberg.org/Koromix/rygel/ (dans le sous-répertoire *src/koffi*).

Les monorépertoires ont deux fonctionnalités clés pour moi :

* Refactorisation inter-projets
* Gestion simplifiée des dépendances

Vous pouvez trouver une justification plus détaillée ici : https://danluu.com/monorepo/

# Construire manuellement

Koffi est construit avec un wrapper CMake personnalisé appelé CNoke, qui vit également dans le monorepository. N’essayez pas d’exécuter CMake manuellement car cela échouera.

Suivez les [instructions de construction documentées](https://koffi.dev/contribute#build-from-source) pour construire Koffi à partir des sources.

# Licence

Ce programme est un logiciel libre : vous pouvez le redistribuer et/ou le modifier selon les termes de la **Licence MIT**.

Trouvez plus d’informations ici : https://choosealicense.com/licenses/mit/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---