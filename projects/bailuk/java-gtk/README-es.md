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

## Compilar y ejecutar
`./gradlew generate` o `make gen`  
Compila y ejecuta el generador de código. Esto generará código Java a partir de archivos [GIR](https://gi.readthedocs.io/en/latest/).

- Entrada: `generator/src/resources/gir/*`
- Salida Java: `java-gtk/build/generated/src/main/java/[...]/*.java`
- Configuración: [generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt](https://raw.githubusercontent.com/bailuk/java-gtk/stage/generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt)

`./gradlew build` o `make`  
Crea la biblioteca, javadoc y ejecuta pruebas

- Salida: jar, javadoc.jar y sources.jar en `libray/build/libs/` 

`./gradlew run` o `make run`  
Ejecuta la aplicación demo predeterminada.
Hay más aplicaciones demo en [examples/src/main/java/examples](examples/src/main/java/examples) incluyendo ejemplos de GeoClue2 y Adwaita.

- Para ejecutar en Windows ver [doc/windows.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/windows.md)
- Para ejecutar en MacOS ver [doc/macos.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/macos.md)

`make install`  
Compila la biblioteca Java, genera el archivo JAR y copia el archivo JAR como artefacto al repositorio local de Maven (`~/.m2/repository`).

## Integración
La biblioteca y el [Javadoc](https://javadoc.jitpack.io/com/github/bailuk/java-gtk/0.6.1/javadoc/) están disponibles vía [JitPack](https://jitpack.io).

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

## Módulos
- `generator/`: Aplicación Kotlin que genera código Java a partir de archivos GIR (analizador xml -> constructor de modelos -> escritor). Los archivos GIR se toman de paquetes Debian para desarrolladores.
- `java-gtk/`: la biblioteca java-gtk depende del código Java generado.
- `examples/`: Algunos ejemplos para probar los enlaces. En su mayoría portados de [https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo).
 
## Licencia
- Los archivos en [generator/src/main/resources/gir/](generator/src/main/resources/gir) provienen del [proyecto GTK](https://gitlab.gnome.org/GNOME/gtk) y por lo tanto están bajo la Licencia Pública General de la Biblioteca GNU.
- Los ejemplos en [examples/src/main/java/examples/gtk4_demo](examples/src/main/java/examples/gtk4_demo) están portados del [proyecto GTK](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo) y por lo tanto están bajo la Licencia Pública General de la Biblioteca GNU.   
- Todo lo demás está licenciado bajo la [Licencia MIT](https://es.wikipedia.org/wiki/Licencia_MIT)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---