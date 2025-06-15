# C# Sprachdesign

[![Treten Sie dem Chat bei unter https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat auf Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Willkommen im offiziellen Repository für das C#-Sprachdesign. Hier werden neue C#-Sprachfeatures entwickelt, übernommen und spezifiziert.

C# wird vom C# Language Design Team (LDT) in enger Abstimmung mit dem [Roslyn](https://github.com/dotnet/roslyn)-Projekt entworfen, das die Sprache implementiert.

Sie finden:

- Aktive C#-Sprachfeature-Vorschläge im [proposals-Ordner](proposals)
- Notizen aus den C#-Sprachdesign-Meetings im [meetings-Ordner](meetings)
- Zusammenfassung der [Sprachversionshistorie hier](Language-Version-History.md).

Wenn Sie Fehler oder Mängel in den oben genannten Inhalten entdecken, hinterlassen Sie bitte ein Issue, um diese zu melden, oder noch besser: einen Pull Request, um sie zu beheben.

Für *neue Feature-Vorschläge* öffnen Sie bitte zunächst eine [Diskussion](https://github.com/dotnet/csharplang/labels/Discussion), und reichen Sie einen Vorschlag *nur* als Issue oder Pull Request ein, wenn Sie dazu von einem Mitglied des Language Design Teams (einem "Champion") eingeladen wurden.

Der vollständige Designprozess ist [hier](Design-Process.md) beschrieben. Eine kürzere Übersicht folgt unten.

## Diskussionen

Debatten zu Sprachfeatures finden in Form von [Discussions](https://github.com/dotnet/csharplang/discussions) in diesem Repository statt.

Wenn Sie ein Feature vorschlagen, aktuelle Designnotizen oder Vorschläge diskutieren möchten, etc., [öffnen Sie bitte ein neues Diskussionsthema](https://github.com/dotnet/csharplang/discussions/new).

Diskussionen, die kurz und themenbezogen bleiben, werden mit größerer Wahrscheinlichkeit gelesen. Wenn Sie den fünfzigsten Kommentar hinterlassen, werden ihn vermutlich nur wenige Leute lesen. Um Diskussionen übersichtlicher und hilfreicher zu gestalten, beachten Sie bitte einige Grundregeln:

- Diskussionen sollten relevant für das C#-Sprachdesign sein. Wenn nicht, werden sie umgehend geschlossen.
- Wählen Sie ein beschreibendes Thema, das den Umfang der Diskussion klar kommuniziert.
- Bleiben Sie beim Thema der Diskussion. Wenn ein Kommentar abweicht oder ins Detail eines Unterthemas geht, starten Sie eine neue Diskussion und verlinken Sie zurück.
- Ist Ihr Kommentar für andere nützlich zu lesen, oder kann er ausreichend mit einer Emoji-Reaktion auf einen bestehenden Kommentar ausgedrückt werden?

Sprachvorschläge, die bestimmte Syntax verhindern sollen, können mit einem [Roslyn-Analyzer](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers) erreicht werden. Vorschläge, die bestehende Syntax nur optional ungültig machen, werden vom Sprachdesignkomitee abgelehnt, um eine erhöhte Sprachkomplexität zu vermeiden.

## Vorschläge

Wenn ein Mitglied des C# LDM feststellt, dass ein Vorschlag eine nähere Betrachtung durch das gesamte Team verdient, kann es ihn [championieren](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22), was bedeutet, dass der Vorschlag im C# Language Design Meeting vorgestellt wird. Vorschläge werden immer in verlinkten Diskussionen besprochen, nicht im Champion-Issue. Diese Regel wurde nicht immer befolgt, daher gibt es viele Champion-Issues mit Diskussionen; heute werden Issues gesperrt, um neue Diskussionen darauf zu verhindern. Jedes Champion-Issue enthält einen Link zur entsprechenden Diskussion.

## Designprozess

[Proposals](proposals) entwickeln sich durch Entscheidungen in [Language Design Meetings](meetings), die wiederum durch [Diskussionen](https://github.com/dotnet/csharplang/discussions), Experimente und Offline-Designarbeit informiert werden.

In vielen Fällen ist es notwendig, einen Prototyp eines Features zu implementieren und zu teilen, um das richtige Design zu finden und letztlich zu entscheiden, ob das Feature übernommen wird. Prototypen helfen, sowohl Implementierungs- als auch Nutzbarkeitsprobleme eines Features zu entdecken. Ein Prototyp sollte in einem Fork des [Roslyn-Repositorys](https://github.com/dotnet/roslyn) implementiert werden und folgende Anforderungen erfüllen:

- Das Parsen (falls zutreffend) sollte experimentierfreudig sein: Tippen sollte keine Abstürze verursachen.
- Enthält minimale Tests, die das Feature von Anfang bis Ende demonstrieren.
- Enthält minimale IDE-Unterstützung (Schlüsselwort-Highlighting, Formatierung, Vervollständigung).

Nach der Freigabe sollte ein Feature vollständig in [Roslyn](https://github.com/dotnet/roslyn) implementiert und vollständig in der [Sprachspezifikation](spec) spezifiziert werden, woraufhin der Vorschlag in den entsprechenden Ordner für ein abgeschlossenes Feature verschoben wird, z.B. [C# 7.1 proposals](proposals/csharp-7.1).

**HAFTUNGSAUSSCHLUSS**: Ein aktiver Vorschlag wird aktiv für die Aufnahme in eine zukünftige Version der C#-Programmiersprache erwogen, ist jedoch in keiner Weise garantiert, tatsächlich in die nächste oder irgendeine Version der Sprache aufgenommen zu werden. Ein Vorschlag kann jederzeit während einer der oben genannten Phasen auf Basis von Feedback des Designteams, der Community, von Code-Reviewern oder durch Tests verschoben oder abgelehnt werden.

### Meilensteine

Wir haben verschiedene Meilensteine für Issues im Repository:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) ist die Menge der championierten Vorschläge, an denen aktuell aktiv gearbeitet wird. Nicht alles in diesem Meilenstein wird es in die nächste Version von C# schaffen, aber es erhält Designzeit während des kommenden Releases.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) ist die Menge der championierten Vorschläge, die triagiert wurden, an denen aber nicht aktiv gearbeitet wird. Während Diskussionen und Ideen aus der Community zu diesen Vorschlägen willkommen sind, sind die Kosten für Designarbeit und Implementierungsreview für uns zu hoch, um eine Community-Implementierung zu erwägen, bis wir bereit dafür sind.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) ist die Menge der championierten Vorschläge, die triagiert wurden, aber nicht aktiv bearbeitet werden und für die eine Community-Implementierung offen ist. Issues hier können in einem von zwei Zuständen sein: benötigt eine genehmigte Spezifikation, oder benötigt eine Implementierung. Diejenigen, die eine Spezifikation benötigen, müssen noch im LDM präsentiert werden, um die Spezifikation zu genehmigen, aber wir sind bereit, dies bei nächster Gelegenheit zu tun.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) ist die Menge der Vorschläge, die das LDM für die Sprache abgelehnt hat. Ohne starken Bedarf oder Community-Feedback werden diese Vorschläge in Zukunft nicht weiter berücksichtigt.
* Nummerierte Meilensteine sind die Menge der Features, die für diese bestimmte Sprachversion implementiert wurden. Für geschlossene Meilensteine sind dies die Features, die mit diesem Release ausgeliefert wurden. Für offene Meilensteine können Features ggf. später noch entfernt werden, falls wir Kompatibilitäts- oder andere Probleme entdecken, wenn der Release näher rückt.

## Language Design Meetings

Language Design Meetings (LDMs) werden vom LDT und gelegentlich eingeladenen Gästen abgehalten und in den Design Meeting Notes im [meetings](meetings)-Ordner dokumentiert, organisiert in Jahresordnern. Der Lebenszyklus einer Design Meeting Note ist in [meetings/README.md](meetings/README.md) beschrieben. LDMs sind der Ort, an dem Entscheidungen über zukünftige C#-Versionen getroffen werden, einschließlich der Auswahl, an welchen Vorschlägen gearbeitet wird, wie Vorschläge weiterentwickelt werden und ob und wann sie übernommen werden.

## Sprachspezifikation

Die aktuelle ECMA-334-Spezifikation finden Sie in Markdown-Form im Repository [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementierung

Die Referenzimplementierung der C#-Sprache finden Sie im [Roslyn-Repository](https://github.com/dotnet/roslyn). Dieses Repository verfolgt auch den [Implementierungsstatus für Sprachfeatures](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Bis vor kurzem wurden dort auch die Artefakte des Sprachdesigns verfolgt. Bitte haben Sie etwas Geduld, während wir aktive Vorschläge umziehen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---