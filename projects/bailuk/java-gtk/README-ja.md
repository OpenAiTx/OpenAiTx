[![Build on Debian](https://github.com/bailuk/java-gtk/actions/workflows/build-on-debian.yml/badge.svg)](https://github.com/bailuk/java-gtk/actions/workflows/build-on-debian.yml)
[![Build on Fedora](https://github.com/bailuk/java-gtk/actions/workflows/build-on-fedora.yml/badge.svg)](https://github.com/bailuk/java-gtk/actions/workflows/build-on-fedora.yml)
[![Build on Ubuntu](https://github.com/bailuk/java-gtk/actions/workflows/build-on-ubuntu.yml/badge.svg)](https://github.com/bailuk/java-gtk/actions/workflows/build-on-ubuntu.yml)
[![Build on Windows](https://github.com/bailuk/java-gtk/actions/workflows/build-on-windows.yml/badge.svg)](https://github.com/bailuk/java-gtk/actions/workflows/build-on-windows.yml)
[![JitPack](https://jitpack.io/v/bailuk/java-gtk.svg)](https://jitpack.io/#bailuk/java-gtk)

# Java-GTK
GTK 4 bindings for Java.
It uses [Java Native Access (JNA)](https://github.com/java-native-access/jna) to access GTK libraries. 

[![POC screenshot](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/screenshot.png)](examples/src/main/java/examples/ImageBridge.java)

## Example

```java
package examples;

import ch.bailu.gtk.gio.ApplicationFlags;
import ch.bailu.gtk.gtk.Application;
import ch.bailu.gtk.gtk.ApplicationWindow;
import ch.bailu.gtk.gtk.Button;
import ch.bailu.gtk.type.Strs;

public class HelloWorld {
    public static void main(String[] args) {
        var app = new Application("com.example.hello",
                ApplicationFlags.FLAGS_NONE);

        app.onActivate(() -> {
            // Create a new window
            var window = new ApplicationWindow(app);

            // Create a new button
            var button = new Button();

            // Set button label
            button.setLabel("Hello, World!");

            // When the button is clicked, close the window
            button.onClicked(window::close);

            window.setChild(button);
            window.show();
        });

        // Start application main loop
        var result = app.run(args.length, new Strs(args));

        // Terminate with exit code
        System.exit(result);
    }
}
```
## ビルドと実行
`./gradlew generate` または `make gen`  
コードジェネレーターをコンパイルして実行します。これにより、[GIR](https://gi.readthedocs.io/en/latest/) ファイルからJavaコードが生成されます。

- 入力: `generator/src/resources/gir/*`
- 出力Java: `java-gtk/build/generated/src/main/java/[...]/*.java`
- 設定: [generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt](https://raw.githubusercontent.com/bailuk/java-gtk/stage/generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt)

`./gradlew build` または `make`  
ライブラリ、javadoc を作成し、テストを実行します

- 出力: `libray/build/libs/` 内の jar、javadoc.jar、sources.jar

`./gradlew run` または `make run`  
デフォルトのデモアプリケーションを実行します。
GeoClue2 や Adwaita サンプルを含む他のデモアプリケーションは [examples/src/main/java/examples](examples/src/main/java/examples) にあります。

- Windowsでの実行については [doc/windows.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/windows.md) を参照してください
- MacOSでの実行については [doc/macos.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/macos.md) を参照してください

`make install`  
Javaライブラリをコンパイルし、JARアーカイブを生成してローカルMavenリポジトリ（`~/.m2/repository`）にアーティファクトとしてコピーします。

## 統合
ライブラリと[Javadoc](https://javadoc.jitpack.io/com/github/bailuk/java-gtk/0.6.1/javadoc/)は[JitPack](https://jitpack.io)経由で利用可能です。


```kotlin
// build.gradle.kts
plugins {
    application
}

repositories {
    maven { url = uri("https://jitpack.io") }
}

dependencies {
    implementation("com.github.bailuk:java-gtk:0.6.1")
}

application {
    mainClass.set("examples.HelloWorld")
}
```

## モジュール
- `generator/`：GIRファイルからJavaコードを生成するKotlinアプリケーション（xmlパーサー -> モデルビルダー -> ライター）。GIRファイルはDebianの開発パッケージから取得。
- `java-gtk/`：java-gtkライブラリは生成されたJavaコードに依存。
- `examples/`：バインディングをテストするためのいくつかの例。主に[https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)から移植。
 
## ライセンス
- [generator/src/main/resources/gir/](generator/src/main/resources/gir)内のファイルは[GTKプロジェクト](https://gitlab.gnome.org/GNOME/gtk)由来であり、GNUライブラリ一般公衆利用許諾書の下でライセンスされています。
- [examples/src/main/java/examples/gtk4_demo](examples/src/main/java/examples/gtk4_demo)内の例は[GTKプロジェクト](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)から移植されており、GNUライブラリ一般公衆利用許諾書の下でライセンスされています。  
- その他すべては[MITライセンス](https://en.wikipedia.org/wiki/MIT_License)の下でライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---