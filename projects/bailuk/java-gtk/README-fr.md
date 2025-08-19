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

## Construction et exécution
`./gradlew generate` ou `make gen`  
Compile et exécute le générateur de code. Cela générera du code Java à partir des fichiers [GIR](https://gi.readthedocs.io/en/latest/).

- Entrée : `generator/src/resources/gir/*`
- Sortie Java : `java-gtk/build/generated/src/main/java/[...]/*.java`
- Configuration : [generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt](https://raw.githubusercontent.com/bailuk/java-gtk/stage/generator/src/main/kotlin/ch/bailu/gtk/Configuration.kt)

`./gradlew build` ou `make`  
Crée la bibliothèque, la javadoc et exécute les tests

- Sortie : jar, javadoc.jar et sources.jar dans `libray/build/libs/` 

`./gradlew run` ou `make run`  
Exécute l’application de démonstration par défaut.
Il existe d’autres applications de démonstration dans [examples/src/main/java/examples](examples/src/main/java/examples) incluant des exemples GeoClue2 et Adwaita.

- Pour exécuter sous Windows voir [doc/windows.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/windows.md)
- Pour exécuter sous MacOS voir [doc/macos.md](https://raw.githubusercontent.com/bailuk/java-gtk/stage/doc/macos.md)

`make install`  
Compile la bibliothèque Java, génère l’archive JAR et copie l’archive JAR comme artefact dans le dépôt Maven local (`~/.m2/repository`).

## Intégration
La bibliothèque et la [Javadoc](https://javadoc.jitpack.io/com/github/bailuk/java-gtk/0.6.1/javadoc/) sont disponibles via [JitPack](https://jitpack.io).

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
- `generator/` : application Kotlin qui génère du code Java à partir des fichiers GIR (parseur xml -> constructeur de modèle -> écrivain). Les fichiers GIR proviennent des paquets Debian dev.
- `java-gtk/` : la bibliothèque java-gtk dépend du code Java généré.
- `examples/` : Quelques exemples pour tester les liaisons. Principalement portés de [https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo).
 
## Licence
- Les fichiers dans [generator/src/main/resources/gir/](generator/src/main/resources/gir) proviennent du [projet GTK](https://gitlab.gnome.org/GNOME/gtk) et sont donc sous licence GNU Library General Public License.
- Les exemples dans [examples/src/main/java/examples/gtk4_demo](examples/src/main/java/examples/gtk4_demo) sont portés du [projet GTK](https://gitlab.gnome.org/GNOME/gtk/-/tree/main/demos/gtk-demo) et sont donc sous licence GNU Library General Public License.   
- Tout le reste est sous licence [MIT License](https://en.wikipedia.org/wiki/MIT_License)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---