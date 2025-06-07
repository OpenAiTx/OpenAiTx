# Eine Sammlung von `.gitignore`-Vorlagen

Dies ist GitHubs Sammlung von [`.gitignore`][man]-Dateivorlagen.
Wir verwenden diese Liste, um die `.gitignore`-Vorlagen-Auswahl im GitHub.com-Interface beim Erstellen neuer Repositories und Dateien bereitzustellen.

Weitere Informationen darüber, wie `.gitignore`-Dateien funktionieren und wie man sie verwendet, finden Sie in den folgenden Ressourcen:

- Das Kapitel [Dateien ignorieren][chapter] im Buch [Pro Git][progit].
- Der Artikel [Dateien ignorieren][help] auf der GitHub-Hilfeseite.
- Die Handbuchseite [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Ordnerstruktur

Wir unterstützen eine Sammlung von Vorlagen, die wie folgt organisiert sind:

- Der Wurzelordner enthält häufig verwendete Vorlagen, um den Einstieg mit beliebten Programmiersprachen und Technologien zu erleichtern. Diese definieren eine sinnvolle Menge an Regeln, um den Einstieg zu erleichtern und sicherzustellen, dass unwichtige Dateien nicht in Ihr Repository übernommen werden.
- [`Global`](./Global) enthält Vorlagen für verschiedene Editoren, Tools und Betriebssysteme, die in unterschiedlichen Situationen verwendet werden können. Es wird empfohlen, diese entweder [zu Ihrer globalen Vorlage hinzuzufügen](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer) oder diese Regeln in Ihre projektspezifischen Vorlagen zu übernehmen, wenn Sie sie dauerhaft verwenden möchten.
- [`community`](./community) enthält spezialisierte Vorlagen für andere beliebte Sprachen, Tools und Projekte, die derzeit nicht zu den gängigen Vorlagen gehören. Diese sollten Ihrer projektspezifischen Vorlage hinzugefügt werden, wenn Sie das Framework oder Tool verwenden möchten.

## Was macht eine gute Vorlage aus?

Eine Vorlage sollte eine Reihe von Regeln enthalten, die Git-Repositories dabei helfen, mit einer bestimmten Programmiersprache, einem Framework, Tool oder einer Umgebung zu arbeiten.

Wenn es nicht möglich ist, eine kleine, nützliche Menge von Regeln für diese Situation zusammenzustellen, dann ist die Vorlage nicht geeignet für diese Sammlung.

Wenn eine Vorlage hauptsächlich eine Liste von Dateien ist, die von einer bestimmten Version einer Software installiert werden (z.B. ein PHP-Framework), sollte sie im `community`-Verzeichnis abgelegt werden. Siehe [versionierte Vorlagen](#versioned-templates) für weitere Details.

Wenn Sie eine kleine Menge an Regeln haben oder eine Technologie unterstützen möchten, die nicht weit verbreitet ist, und dennoch glauben, dass dies für andere hilfreich sein wird, lesen Sie bitte den Abschnitt über [spezialisierte Vorlagen](#specialized-templates) für weitere Details.

Fügen Sie bitte Details hinzu, wenn Sie einen Pull Request eröffnen, falls die Vorlage wichtig und sichtbar ist. Wir akzeptieren sie möglicherweise nicht sofort, können sie aber später bei entsprechendem Interesse in das Root-Verzeichnis verschieben.

Bitte haben Sie Verständnis dafür, dass wir nicht jedes jemals existierende Tool auflisten können.
Unser Ziel ist es, eine Sammlung der _häufigsten und hilfreichsten_ Vorlagen zusammenzustellen, nicht sicherzustellen, dass wir jedes mögliche Projekt abdecken. Wenn wir uns entscheiden, Ihre Sprache, Ihr Tool oder Ihr Projekt nicht aufzunehmen, heißt das nicht, dass es nicht großartig ist.

## Richtlinien für Beiträge

Wir würden uns freuen, wenn Sie uns helfen, dieses Projekt zu verbessern. Um uns zu helfen, diese Sammlung in hoher Qualität zu halten, bitten wir darum, dass Beiträge den folgenden Richtlinien entsprechen.

- **Geben Sie einen Link zur Homepage der Anwendung oder des Projekts an**. Es besteht die Möglichkeit, dass die Verantwortlichen die Sprache, das Framework, den Editor, die App oder das Projekt, auf das sich Ihre Änderung bezieht, nicht kennen oder verwenden, sofern es nicht extrem populär ist.

- **Geben Sie Links zur Dokumentation an**, die die von Ihnen vorgenommene Änderung unterstützen.
  Aktuelle, maßgebliche Dokumentation, die die zu ignorierenden Dateien erwähnt, ist am besten. Wenn keine Dokumentation verfügbar ist, erläutern Sie so gut wie möglich, wofür die zu ignorierenden Dateien verwendet werden.

- **Erklären Sie, warum Sie eine Änderung vornehmen**. Auch wenn es offensichtlich erscheint, nehmen Sie sich bitte einen oder zwei Sätze Zeit, um zu erläutern, warum Ihre Änderung oder Ergänzung erfolgen sollte.
  Es ist besonders hilfreich, zu erklären, warum diese Änderung für _alle_ gilt, die mit der jeweiligen Technologie arbeiten, und nicht nur für Sie oder Ihr Team.

- **Bitte beachten Sie den Umfang Ihrer Änderung**. Wenn Ihre Änderung spezifisch für eine bestimmte Sprache oder ein Framework ist, stellen Sie bitte sicher, dass die Änderung an der Vorlage für diese Sprache oder dieses Framework vorgenommen wird, und nicht an der Vorlage für einen Editor, ein Tool oder ein Betriebssystem.

- **Bitte ändern Sie pro Pull Request nur _eine Vorlage_**. So bleiben Pull Requests und Rückmeldungen auf ein bestimmtes Projekt oder eine Technologie fokussiert.

Im Allgemeinen gilt: Je mehr Sie dazu beitragen, dass wir Ihre Änderung verstehen, desto wahrscheinlicher ist es, dass wir Ihren Beitrag schnell akzeptieren.

## Versionierte Vorlagen

Einige Vorlagen können sich zwischen Versionen stark unterscheiden, und wenn Sie zu diesem Repository beitragen möchten, müssen wir diesen spezifischen Ablauf befolgen:

- Die Vorlage im Root-Verzeichnis sollte die aktuell unterstützte Version sein
- Die Vorlage im Root-Verzeichnis sollte keinen Versionsnamen im Dateinamen enthalten (also „evergreen“)
- Frühere Versionen von Vorlagen sollten unter `community/` abgelegt werden
- Frühere Versionen der Vorlage sollten die Version im Dateinamen enthalten, zur besseren Lesbarkeit

Das stellt sicher, dass Benutzer die neueste Version erhalten (weil sie das verwenden, was im Root liegt), aber ermöglicht es den Betreuern, ältere Versionen weiterhin zu unterstützen.

## Spezialisierte Vorlagen

Wenn Sie eine Vorlage haben, die Sie beitragen möchten, die aber nicht ganz Mainstream ist, fügen Sie sie bitte in das `community`-Verzeichnis unter einem passenden Unterordner hinzu.

Die Regeln in Ihrer spezialisierten Vorlage sollten spezifisch für das jeweilige Framework oder Tool sein, und alle weiteren Vorlagen sollten in einem Kommentar im Header der Vorlage erwähnt werden.

Beispielsweise könnte diese Vorlage unter `community/DotNet/InforCRM.gitignore` abgelegt werden:

```
# gitignore-Vorlage für InforCRM (früher SalesLogix)
# Webseite: https://www.infor.com/product-summary/cx/infor-crm/
#
# Empfohlen: VisualStudio.gitignore

# Ignoriere automatisch generierte Modelldateien
ModelIndex.xml
ExportedFiles.xml

# Ignoriere Deployment-Dateien
[Mm]odel/[Dd]eployment

# Erzwinge das Einbinden von Portal-SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Workflow für Beiträge

So schlagen wir vor, dass Sie eine Änderung an diesem Projekt vorschlagen:

1. [Forken Sie dieses Projekt][fork] in Ihr Konto.
2. [Erstellen Sie einen Branch][branch] für die geplante Änderung.
3. Nehmen Sie Ihre Änderungen an Ihrem Fork vor.
4. [Senden Sie einen Pull Request][pr] von Ihrem Branch auf unseren `main`-Branch.

Auch das webbasierte Interface zu verwenden ist in Ordnung und hilft Ihnen dabei, das Projekt automatisch zu forken und einen Pull Request zu senden.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Lizenz

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---