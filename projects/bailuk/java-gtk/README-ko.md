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
## 빌드 및 실행
`./gradlew generate` 또는 `make gen`  
코드 생성기를 컴파일하고 실행합니다. 이는 [GIR](https://gi.readthedocs.io/en/latest/) 파일로부터 자바 코드를 생성합니다.

- 입력: `generator/src/resources/gir/*`
- 출력 자바: `java-gtk/build/generated/src/main/java/[...]/*.java`
- 구성: [generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt](https://raw.githubusercontent.com/bailuk/java-gtk/stage/generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt)

`./gradlew build` 또는 `make`  
라이브러리, 자바독을 생성하고 테스트를 실행합니다

- 출력: `libray/build/libs/` 내의 jar, javadoc.jar 및 sources.jar 

`./gradlew run` 또는 `make run`  
기본 데모 애플리케이션을 실행합니다.
[examples/src/main/java/examples](examples/src/main/java/examples)에는 GeoClue2 및 Adwaita 샘플을 포함한 더 많은 데모 애플리케이션이 있습니다.

- Windows에서 실행하려면 [doc/windows.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/windows.md)를 참조하세요
- MacOS에서 실행하려면 [doc/macos.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/macos.md)를 참조하세요

`make install`  
자바 라이브러리를 컴파일하고 JAR 아카이브를 생성한 후 JAR 아카이브를 로컬 Maven 저장소(`~/.m2/repository`)에 아티팩트로 복사합니다.

## 통합
라이브러리와 [Javadoc](https://javadoc.jitpack.io/com/github/bailuk/java-gtk/0.6.1/javadoc/)은 [JitPack](https://jitpack.io) 을 통해 제공됩니다.


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
## Modules
- `generator/`: GIR 파일에서 Java 코드를 생성하는 Kotlin 애플리케이션(xml 파서 -> 모델 빌더 -> 작성기). GIR 파일은 Debian 개발 패키지에서 가져옵니다.
- `java-gtk/` : java-gtk 라이브러리는 생성된 Java 코드에 의존합니다.
- `examples/` : 바인딩을 테스트하기 위한 몇 가지 예제입니다. 대부분 [https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)에서 포팅되었습니다.
 
## License
- [generator/src/main/resources/gir/](generator/src/main/resources/gir) 내 파일들은 [GTK 프로젝트](https://gitlab.gnome.org/GNOME/gtk)에서 가져온 것이며 따라서 GNU 라이브러리 일반 공중 사용 허가서 하에 라이선스가 부여됩니다.
- [examples/src/main/java/examples/gtk4_demo](examples/src/main/java/examples/gtk4_demo)의 예제들은 [GTK 프로젝트](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo)에서 포팅된 것이며 따라서 GNU 라이브러리 일반 공중 사용 허가서 하에 라이선스가 부여됩니다.   
- 기타 모든 것은 [MIT 라이선스](https://en.wikipedia.org/wiki/MIT_License) 하에 라이선스가 부여됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---