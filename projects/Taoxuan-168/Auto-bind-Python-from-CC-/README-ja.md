<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

Auto bind Python from CC++
===================

> C/C++ コードを Python コードに自動バインドし、whl パッケージを生成するための、十分にシンプルで使いやすく、かつ設定可能なプロジェクト

> 本プロジェクトは下記からクローンされています:
https://github.com/Neutree/c_cpp_project_framework
そして、ビルド部分のコードは元のリポジトリと同一です


> pybind11自動バインディングの参考コード：
https://github.com/sipeed/MaixPy/tree/main/components/maix


## クイックスタート

* 1.本リポジトリをクローンし、/examples/demoディレクトリに移動
python project.py menuconfig を使用して、GUIでビルドツールチェーンやwhlファイルのパッケージ化を設定
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> x86はローカルマシン用、arm64はMaixCam2用、RISCV64はMaiCam/Pro用のビルドに対応
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2.C/C++関数とhppヘッダファイルを書き、whlパッケージ名と同じファイル名にすることで自動認識を容易にする：
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
対応する関数に@modul注釈を付け、その後に関数パスを記載してください:
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
最初の行は関数の説明、@paramはパラメータの説明、@returnは戻り値の説明（省略可能）です  
whlファイルとしてコンパイルおよびパッケージングするだけの場合は、main.cppを変更する必要はありません  
python project buildを使用すると、コンパイルおよびwhlファイルのパッケージングを開始できます  
コンパイル後にwhlをインストールすると、直接呼び出して使用できます:
```Python
import add
add.test.add(1,1)
```
注意:  
-   1つのヘッダーファイルは1つのモジュール名を表し、インポートするモジュールを示します。例えばadd.hppはimport addに対応し、そのモジュール名はaddで始まる必要があります。  
-   cpp_bind_python.pyを直接実行すると、バインドされたcppファイルのみが生成されます。--doc DOCパラメータを追加すると、コメントから自動的にドキュメントが生成されます。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---