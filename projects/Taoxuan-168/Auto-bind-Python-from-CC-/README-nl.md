<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">Vereenvoudigd Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">Traditioneel Chinees</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

Auto bind Python vanuit CC++
===================

> Een voldoende eenvoudig, gebruiksvriendelijk en configureerbaar project om automatisch C/C++-code te binden aan Python-code en een whl-pakket te genereren

> Dit project is gekloond van:
https://github.com/Neutree/c_cpp_project_framework
en het compileergedeelte is identiek aan de originele repository


> pybind11 automatische binding referentiecode:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Snel aan de slag

* 1. Clone deze repository, ga naar de /examples/demo map
Gebruik python project.py menuconfig om de grafische interface te openen en de toolchain en whl-bestandspakket te configureren
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Waarbij x86 staat voor compilatie op de lokale machine, arm64 voor compilatie op MaixCam2, RISCV64 voor compilatie op MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Schrijf een C/C++ functie en een hpp-headerbestand, de bestandsnaam dient gelijk te zijn aan het whl-pakket voor automatische herkenning:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Schrijf een @modul-commentaar bij de betreffende functie, gevolgd door het functiepad:
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
De eerste regel is een functiebeschrijving, @param is een parameterbeschrijving, @return is een beschrijving van de retourwaarde (optioneel)
Als u alleen hoeft te compileren en te verpakken als een whl-bestand, hoeft u main.cpp niet aan te passen
Gebruik python project build om het compileren en verpakken van het whl-bestand te starten
Na installatie van het gecompileerde whl-bestand kan het direct worden aangeroepen:
```Python
import add
add.test.add(1,1)
```
Opmerking:
-   Een headerbestand vertegenwoordigt een modulenaam, wat aangeeft welke module geïmporteerd moet worden, bijvoorbeeld add.hpp komt overeen met import add, en de modulenaam moet beginnen met add.
-   Door cpp_bind_python.py direct uit te voeren, wordt alleen het gebonden cpp-bestand gegenereerd; als je de parameter --doc DOC toevoegt, wordt documentatie automatisch uit opmerkingen gegenereerd.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---