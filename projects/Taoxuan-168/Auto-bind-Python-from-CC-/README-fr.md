Auto bind Python from CC++
===================

> Un projet suffisamment simple, facile à utiliser et configurable pour générer automatiquement des liaisons Python à partir du code C/C++ et créer des paquets whl.

> Ce projet est un clone de :
https://github.com/Neutree/c_cpp_project_framework
et la partie compilation du code reste identique au dépôt original.

> La partie liaison automatique pybind11 s'inspire du code suivant :
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Démarrage rapide

* 1. Clonez ce dépôt, puis rendez-vous dans le répertoire /examples/demo
Utilisez python project.py menuconfig pour accéder à l'interface graphique et configurer la chaîne de compilation ainsi que la génération du fichier whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Ici, x86 correspond à la compilation locale, arm64 à la compilation pour MaixCam2, RISCV64 à la compilation pour MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Écrivez une fonction C/C++ ainsi qu’un fichier d’en-tête hpp, le nom du fichier doit correspondre à celui du paquet whl pour faciliter la reconnaissance automatique :
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Écrivez un commentaire @modul pour la fonction correspondante, suivi du chemin de la fonction :
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
La première ligne est une description de la fonction, @param décrit les paramètres, @return décrit la valeur de retour (peut être vide)  
Si vous souhaitez uniquement compiler et empaqueter en fichier whl, il n’est pas nécessaire de modifier main.cpp  
Utilisez python project build pour commencer la compilation et l’empaquetage du fichier whl  
Après la compilation et l’installation du whl, vous pouvez l’appeler directement :
```Python
import add
add.test.add(1,1)
```
Remarque :  
-   Un fichier d'en-tête représente un nom de module, indiquant le module à importer, par exemple add.hpp correspond à import add, le nom du module doit commencer par add  
-   Exécuter directement cpp_bind_python.py peut uniquement générer le fichier cpp lié, ajouter le paramètre --doc DOC peut générer automatiquement la documentation à partir des commentaires  

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---