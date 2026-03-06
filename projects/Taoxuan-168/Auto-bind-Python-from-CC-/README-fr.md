
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Liaison automatique de Python depuis CC++
===================

> Un projet suffisamment simple, facile à utiliser et configurable pour lier automatiquement du code C/C++ à du code Python et générer un paquet whl

> Ce projet est un clone de :
https://github.com/Neutree/c_cpp_project_framework
et la partie compilation du code reste identique au dépôt original

> Exemple de code de référence pour la liaison automatique pybind11 :
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Prise en main rapide

* 1. Clonez ce dépôt et accédez au répertoire /examples/demo
Utilisez python project.py menuconfig pour entrer dans l’interface graphique et configurer la chaîne d’outils de compilation ainsi que l’emballage du fichier whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86 correspond à la compilation locale, arm64 à la compilation pour MaixCam2, RISCV64 à la compilation pour MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Écrivez une fonction C/C++ ainsi qu’un fichier d’en-tête hpp, le nom du fichier doit correspondre à celui du paquet whl pour une reconnaissance automatique :
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---