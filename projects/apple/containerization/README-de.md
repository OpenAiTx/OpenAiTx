# Containerization

Das Containerization-Paket ermöglicht Anwendungen die Nutzung von Linux-Containern.  
Containerization ist in [Swift](https://www.swift.org) geschrieben und verwendet [Virtualization.framework](https://developer.apple.com/documentation/virtualization) auf Apple Silicon.

Containerization bietet APIs zum:

- [Verwalten von OCI-Images](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interagieren mit entfernten Registries](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Erstellen und Befüllen von ext4-Dateisystemen](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interagieren mit der Netlink-Socket-Familie](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Erstellen eines optimierten Linux-Kernels für schnelle Startzeiten](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Starten leichter virtueller Maschinen und Verwalten der Laufzeitumgebung](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Starten und Interagieren mit containerisierten Prozessen](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Nutzung von Rosetta 2 zum Ausführen von linux/amd64-Containern auf Apple Silicon.

Bitte sehen Sie sich die [API-Dokumentation](https://apple.github.io/containerization/documentation/) für Informationen zu den von Containerization bereitgestellten Swift-Paketen an.

## Design

Containerization führt jeden Linux-Container innerhalb einer eigenen leichten virtuellen Maschine aus. Clients können für jeden Container dedizierte IP-Adressen erstellen, um die Notwendigkeit individueller Portweiterleitungen zu eliminieren. Container erreichen Startzeiten unter einer Sekunde durch eine optimierte [Linux-Kernel-Konfiguration](https://raw.githubusercontent.com/apple/containerization/main/kernel) und ein minimales Root-Dateisystem mit einem leichten Init-System.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) ist ein kleines Init-System, das ein Teilprojekt innerhalb von Containerization ist.  
`vminitd` wird als Initialprozess innerhalb der virtuellen Maschine gestartet und stellt eine GRPC-API über vsock bereit.  
Die API ermöglicht die Konfiguration der Laufzeitumgebung und das Starten containerisierter Prozesse.  
`vminitd` stellt I/O, Signale und Ereignisse für den aufrufenden Prozess bereit, wenn ein Prozess ausgeführt wird.

## Anforderungen

Sie benötigen einen Apple Silicon Mac, um Containerization zu bauen und auszuführen.

Um das Containerization-Paket zu bauen, benötigt Ihr System entweder:

- macOS 15 oder neuer und Xcode 26 Beta
- macOS 26 Beta oder neuer

Mit dem Paket gebaute Anwendungen laufen auf macOS 15 oder höher, jedoch sind die folgenden Funktionen auf macOS 15 nicht verfügbar:

- Nicht-isoliertes Container-Netzwerk – mit macOS 15 können Container im selben vmnet-Netzwerk nicht miteinander kommunizieren

## Beispielanwendung

Für Beispiele, wie einige der Bibliotheken verwendet werden können, ist das cctl-Executable ein guter Startpunkt. Dieses Tool dient primär als Spielplatz zum Ausprobieren der API. Es enthält Befehle, die einige der Kernfunktionen der verschiedenen Produkte testen, wie z.B.:

1. [Manipulation von OCI-Images](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Anmeldung bei Container-Registries](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Erstellen von Root-Dateisystem-Blöcken](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Ausführen einfacher Linux-Container](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Linux-Kernel

Ein Linux-Kernel wird benötigt, um leichte virtuelle Maschinen auf macOS zu starten.  
Containerization stellt eine optimierte Kernel-Konfiguration im Verzeichnis [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) bereit.

Dieses Verzeichnis enthält eine containerisierte Build-Umgebung, um einfach einen Kernel für die Verwendung mit Containerization zu kompilieren.

Die Kernel-Konfiguration ist eine minimale Feature-Auswahl, um schnelle Startzeiten und eine leichte Umgebung zu unterstützen.

Obwohl diese Konfiguration für die Mehrheit der Workloads funktioniert, verstehen wir, dass manche Workloads zusätzliche Features benötigen.  
Um dies zu lösen, stellt Containerization erstklassige APIs bereit, um verschiedene Kernel-Konfigurationen und -Versionen pro Container zu verwenden.  
Dies ermöglicht die Entwicklung und Validierung von Containern über verschiedene Kernel-Versionen hinweg.

Siehe die [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) im Kernel-Verzeichnis für Anweisungen zum Kompilieren des optimierten Kernels.

### Vorgefertigter Kernel

Wenn Sie einen vorgefertigten Kernel verwenden möchten, müssen `VIRTIO`-Treiber in den Kernel kompiliert sein, nicht als Module.

Das [Kata Containers](https://github.com/kata-containers/kata-containers) Projekt bietet einen optimierten Kernel für Container mit allen erforderlichen Konfigurationsoptionen, verfügbar auf der [Releases](https://github.com/kata-containers/kata-containers/releases/) Seite.

Ein Kernel-Image namens `vmlinux.container` befindet sich im Verzeichnis `/opt/kata/share/kata-containers/` der Release-Artefakte.

## Vorbereitung zum Bauen des Pakets

Installieren Sie Swiftly, [Swift](https://www.swift.org) und das [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Wenn Sie eine benutzerdefinierte Terminal-Anwendung verwenden, müssen Sie diesen Befehl möglicherweise von `.zprofile` in `.zshrc` verschieben (ersetzen Sie `<USERNAME>`):

```bash
# Hinzugefügt von swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Starten Sie die Terminal-Anwendung neu. Stellen Sie sicher, dass dieser Befehl `/Users/<USERNAME>/.swiftly/bin/swift` zurückgibt (ersetzen Sie `<USERNAME>`):

```bash
which swift
```

Wenn Sie zuvor ein Static Linux SDK installiert oder verwendet haben, müssen Sie möglicherweise ältere SDK-Versionen vom System entfernen (ersetzen Sie `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Paket bauen

Bauen Sie Containerization aus den Quellen:

```bash
make all
```

## Paket testen

Führen Sie nach dem Bauen grundlegende und Integrationstests aus:

```bash
make test integration
```

Ein Kernel wird benötigt, um Integrationstests auszuführen.  
Wenn Sie lokal keinen Kernel haben, kann ein Standardkernel mit dem Ziel `make fetch-default-kernel` heruntergeladen werden.

Das Herunterladen des Standardkernels ist nur nach einem Initialbuild oder nach `make clean` erforderlich.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization ist abhängig von spezifischen Versionen von `grpc-swift` und `swift-protobuf`. Sie können diese installieren und die RPC-Interfaces neu generieren mit:

```bash
make protos
```

## Dokumentation

Generieren Sie die API-Dokumentation zur lokalen Ansicht mit:

```bash
make docs
make serve-docs
```

Vorschau der Dokumentation durch Ausführen in einem anderen Terminal:

```bash
open http://localhost:8000/documentation/
```

## Mitwirken

Beiträge zu Containerization sind willkommen und werden gefördert. Weitere Informationen finden Sie in [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md).

## Projektstatus

Version 0.1.0 ist die erste offizielle Veröffentlichung von Containerization. Frühere Versionen bieten keine Quellstabilitätsgarantie.

Da sich die Containerization-Bibliothek in aktiver Entwicklung befindet, wird Quellstabilität nur innerhalb von Minor-Versionen garantiert (z.B. zwischen 0.1.1 und 0.1.2). Wenn Sie keine möglicherweise quellbrechenden Paket-Updates wünschen, können Sie Ihre Paketabhängigkeit mit `.upToNextMinorVersion(from: "0.1.0")` angeben.

Zukünftige Minor-Versionen des Pakets können diese Regeln bei Bedarf ändern.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---