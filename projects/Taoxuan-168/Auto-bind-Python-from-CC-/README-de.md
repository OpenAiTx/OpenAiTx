
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=Taoxuan-168&project=Auto-bind-Python-from-CC-&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Auto Bind Python aus CC++
===================

> Ein ausreichend einfach zu bedienendes und konfigurierbares Projekt zur automatischen Bindung von C/C++-Code an Python-Code und zur Erstellung von whl-Paketen

> Dieses Projekt wurde geklont von:
https://github.com/Neutree/c_cpp_project_framework
und der Kompilierungsteil ist identisch mit dem ursprünglichen Repository

> Beispielcode für die automatische Bindung mit pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Schnellstart

* 1. Klonen Sie dieses Repository und gehen Sie in das Verzeichnis /examples/demo
Verwenden Sie python project.py menuconfig, um das GUI zur Konfiguration der Toolchain und zum Packen der whl-Datei aufzurufen
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Dabei steht x86 für Kompilierung auf dem lokalen Rechner, arm64 für Kompilierung auf MaixCam2 und RISCV64 für Kompilierung auf MaiCam/Pro
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Schreiben Sie eine C/C++-Funktion sowie eine hpp-Headerdatei; der Name des whl-Pakets sollte als Dateiname verwendet werden, um die automatische Erkennung zu erleichtern:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Schreiben Sie für die entsprechenden Funktionen einen @modul-Kommentar, gefolgt vom Funktionspfad:
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
Die erste Zeile ist die Funktionsbeschreibung, @param beschreibt die Parameter, @return beschreibt den Rückgabewert (kann leer sein)
Wenn Sie nur kompilieren und als whl-Datei verpacken möchten, muss main.cpp nicht geändert werden
Mit python project build können Sie die Kompilierung und das Packen der whl-Datei starten
Nach der Installation der kompilierten whl-Datei kann direkt aufgerufen werden:
```Python
import add
add.test.add(1,1)
```
Beachten:
-   Eine Header-Datei steht für einen Modulnamen und gibt das zu importierende Modul an, z. B. entspricht add.hpp dem Import von add; der Modulname muss mit add beginnen.
-   Wenn Sie cpp_bind_python.py direkt ausführen, wird nur die gebundene cpp-Datei erzeugt; mit dem Zusatz --doc DOC kann die Dokumentation automatisch aus Kommentaren generiert werden.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---