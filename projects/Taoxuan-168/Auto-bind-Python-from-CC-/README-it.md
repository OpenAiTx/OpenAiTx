
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Auto bind Python da CC++
===================

> Un progetto sufficientemente semplice da usare e configurabile per il binding automatico del codice C/C++ in codice Python e la generazione di pacchetti whl

> Questo progetto è stato clonato da:
https://github.com/Neutree/c_cpp_project_framework
e la parte di compilazione del codice rimane identica al repository originale

> Codice di riferimento per il binding automatico di pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix

## Guida rapida

* 1. Clona questo repository ed entra nella directory /examples/demo
Usa python project.py menuconfig per accedere all'interfaccia grafica e configurare la toolchain di compilazione e la creazione del file whl
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86 corrisponde alla compilazione locale, arm64 corrisponde alla compilazione per MaixCam2, RISCV64 corrisponde alla compilazione per MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Scrivi una funzione C/C++ e il relativo file di header hpp; il nome del file deve corrispondere al nome del pacchetto whl, per facilitarne il riconoscimento automatico:

```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Scrivi il commento @modul per la funzione corrispondente, seguito dal percorso della funzione:
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
La prima riga è la descrizione della funzione, @param è la descrizione dei parametri, @return è la descrizione del valore di ritorno (può essere vuoto)
Se è necessario solo compilare e impacchettare come file whl, non è necessario modificare main.cpp
Utilizza python project build per iniziare a compilare e impacchettare il file whl
Dopo la compilazione e l'installazione del file whl, puoi richiamarlo direttamente:
```Python
import add
add.test.add(1,1)
```
Nota:
-   Un file header rappresenta un nome di modulo, indica il modulo da importare, ad esempio add.hpp corrisponde a import add, il nome del modulo deve iniziare con add
-   Eseguendo direttamente cpp_bind_python.py si genera solo il file cpp con i binding, aggiungendo il parametro --doc DOC si può generare automaticamente la documentazione dai commenti

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---