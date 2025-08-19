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
## 构建和运行
`./gradlew generate` 或 `make gen`  
编译并运行代码生成器。这将从 [GIR](https://gi.readthedocs.io/en/latest/) 文件生成 Java 代码。

- 输入：`generator/src/resources/gir/*`
- 输出 Java：`java-gtk/build/generated/src/main/java/[...]/*.java`
- 配置：[generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt](https://raw.githubusercontent.com/bailuk/java-gtk/stage/generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt)

`./gradlew build` 或 `make`  
创建库、javadoc 并运行测试

- 输出：`libray/build/libs/` 中的 jar、javadoc.jar 和 sources.jar 

`./gradlew run` 或 `make run`  
运行默认演示应用程序。  
更多演示应用程序在 [examples/src/main/java/examples](examples/src/main/java/examples) 中，包括 GeoClue2 和 Adwaita 示例。

- 在 Windows 上运行请参见 [doc/windows.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/windows.md)
- 在 MacOS 上运行请参见 [doc/macos.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/macos.md)

`make install`  
编译 Java 库，生成 JAR 包，并将 JAR 包作为制品复制到本地 Maven 仓库（`~/.m2/repository`）。

## 集成
库和 [Javadoc](https://javadoc.jitpack.io/com/github/bailuk/java-gtk/0.6.1/javadoc/) 可通过 [JitPack](https://jitpack.io) 获取。


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

## 模块
- `generator/`：从GIR文件生成Java代码的Kotlin应用程序（XML解析器 -> 模型构建器 -> 写入器）。GIR文件取自Debian开发包。
- `java-gtk/` ：java-gtk库依赖生成的Java代码。
- `examples/` ：一些用于测试绑定的示例。大多移植自[https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)。
 
## 许可证
- [generator/src/main/resources/gir/](generator/src/main/resources/gir)中的文件来自[GTK项目](https://gitlab.gnome.org/GNOME/gtk)，因此采用GNU库通用公共许可证。
- [examples/src/main/java/examples/gtk4_demo](examples/src/main/java/examples/gtk4_demo)中的示例移植自[GTK项目](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)，因此采用GNU库通用公共许可证。  
- 其他所有内容均采用[MIT许可证](https://en.wikipedia.org/wiki/MIT_License)授权。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---