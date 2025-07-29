<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Ein LLM, das nur mit Daten aus bestimmten Zeiträumen trainiert wurde, um moderne Verzerrungen zu reduzieren.

Stellen Sie sich vor, ein KI-Modell würde nicht nur vorgeben, historisch zu sein, sondern es tatsächlich wäre.

Basiert auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die wichtigsten Trainingsskripte und die Modellarchitektur stammen von ihm.

# Projektziele 

TimeCapsule LLM ist ein experimentelles Projekt, das ausschließlich mit Texten aus bestimmten historischen Zeiträumen trainiert wird. Ziel ist es, die Weltanschauung und Sprache spezifischer Epochen zu simulieren.

# Warum Fine-Tuning nicht ausreicht 

Wenn man nur ein vortrainiertes Modell feinjustiert, kennt das LLM trotzdem moderne Konzepte. Natürlich ist es schwierig, völlige Neutralität gegenüber der Moderne zu erreichen, aber ich möchte diesem Ziel so nahe wie möglich kommen. Keine moderne Voreingenommenheit zu haben, erfordert ein Modell, das von Grund auf neu trainiert wird.

# Erwartete Ergebnisse 

Hoffentlich kennt dieses Modell nach Fertigstellung keine modernen Konzepte und kann nicht über das hinaus argumentieren, was ihm beigebracht wurde. Es sollte moderne Begriffe/Vokabeln nicht erkennen und ich hoffe, dass es kein modernes Wissen halluziniert.

# Fortschritts-Updates

## 9. Juli 2025

Ich habe meinen Zeitraum auf 1800-1850 und die Region: London festgelegt.

Ich habe eine Liste von Texten, Büchern, Dokumenten zusammengestellt.

Bisher habe ich 50 als txt-Dateien erhalten und werde bald mit dem Training von NanoGPT beginnen.

Ich werde dies aktualisieren, solange Fortschritte gemacht werden.

## 13. Juli 2025

NanoGPT wurde mit 187MB historischen Textdaten trainiert.

## 15. Juli 2025

Ich habe begonnen, Texte für den zweiten Trainingslauf herunterzuladen. Ich beziehe alles aus dem Internet Archive und habe den Zeitraum auf 1800-1875 ausgeweitet. Um eine vielfältige Auswahl an Texten zu bekommen, kann man im Internet Archive die Filter für Veröffentlichungsort, Zeitraum und Themen nutzen.

![Suchfilter](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16. Juli 2025

Ich habe etwa 500 txt-Dateien aus dem Internet Archive heruntergeladen und nach dem Säubern (nur Leerzeichen, Gutenberg-Header usw. gelöscht) habe ich etwa 500MB Daten. Es ist ein winziger Datensatz, aber beim letzten Mal habe ich mit 187MB trainiert, also sollte es zumindest einen merklichen Unterschied im Output nach dem Training des zweiten Modells geben. Ich hoffe, dass dieses Modell zumindest zusammenhängendere Sätze erzeugen kann, die einigermaßen Sinn ergeben. Das ist natürlich keine Garantie, da es immer noch ein winziger Datensatz ist, aber mehr als beim letzten Mal.

Das sollte mit meiner eigenen Hardware machbar sein. Das ist auch gut, denn hoffentlich sehe ich so Verbesserungen, bevor ich auf einen größeren Datensatz umsteige, für den ich eine GPU mieten müsste. Aber keine Sorge, ich plane immer noch, bald eine GPU zu mieten, aber bevor ich das tue, will ich sicherstellen, dass mein Datensatz so kuratiert und sauber wie möglich ist. Eines der Probleme ist das Säubern, viele dieser txt-Dateien enthalten Kauderwelsch. Die Skripte, die ich zum Säubern verwendet habe, funktionieren, sind aber nicht 100% effektiv.

Ich werde diesen Datensatz heute trainieren, das sollte etwa 4-5 Stunden dauern. Sobald es fertig ist und ich es getestet habe, gebe ich Updates. Nochmals vielen Dank an alle, die sich mein Projekt anschauen, einige haben mir sogar Links zu OCR-Ressourcen geschickt, also danke! Ich hoffe, mehr Leute probieren das aus und experimentieren mit eigenen Datensätzen.

## 28. Juli 2025

Ich habe v0.5 bei Hugging Face hochgeladen, [Schau es dir an](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) wenn du möchtest. Du kannst jetzt mein Repository herunterladen und lokal ausführen. Leider funktioniert nanoGPT nicht nativ mit HuggingFace, daher musst du das Modell lokal herunterladen und ausführen.

Außerdem beginne ich nun damit, Daten für meinen nächsten Trainingslauf zu kuratieren. Ich glaube, ich brauche vielleicht 5-10x mehr Daten, um logische Fähigkeiten zu erreichen.

### Trainings-Update

Ich habe mit einem 435MB (108 Mio. Tokens) Korpus mit dem Training begonnen, es läuft derzeit ziemlich reibungslos. Der Trainingsverlust fiel in den ersten 2800 Iterationen von 10,9 auf 4,9. Ich erwarte, dass es etwa 8 oder 9 Stunden dauert, bis es abgeschlossen ist. Ich werde ein weiteres Update posten, sobald es fertig ist.

## 17. Juli 2025, 2:13 Uhr

Das Training für das zweite Modell ist abgeschlossen, meine 4060 hat etwa 8 Stunden und 40 Minuten gebraucht (3.900 Iterationen/Stunde) für 33.000 Iterationen (5 Epochen). Der finale Trainingsverlust lag bei 3,73. Die Ergebnisse waren überraschend gut, es generiert jetzt wirklich zusammenhängende Sätze im Stil des 19. Jahrhunderts.

# V0 Modellverhalten & Einschränkungen

Erste Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er reagiert. Zum Beispiel habe ich es mit "Who art Henry?" aufgefordert und es antwortete "I know that man, I have did not a black, the storm." und ja, dieser Satz ergibt keinen Sinn, aber das LLM erkennt, dass ich nach einer Person frage.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)


Es gibt keine Erwähnung moderner Konzepte, die Ausgaben enthalten größtenteils Wörter und Formulierungen aus dem 19. Jahrhundert.

Es ist noch viel Arbeit nötig, das Training mit 187MB wird kein Modell hervorbringen, das Texte mit komplexem logischem Denken erzeugt.

Im Moment produziert es Sätze, die keine vollständige Satzstruktur haben und insgesamt einfach keinen Sinn ergeben, aber das ist bei der Trainingsgröße normal.

# V0.5 Modellverhalten & Einschränkungen

Dies ist eine schöne Verbesserung im Vergleich zum letzten Modell. Der Schreibstil und der Wortschatz sind viktorianisch und fast jeder Satz ist grammatikalisch korrekt mit richtiger Zeichensetzung. Und erneut: Das Modell wurde von Grund auf trainiert, daher bezieht es sich nur auf Themen des 19. Jahrhunderts.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Es gibt viele faktische Halluzinationen. Viele (nahezu 100%) der Details (Daten, Ereignisse, historische Persönlichkeiten) sind erfunden. Außerdem stehen die Sätze nicht wirklich miteinander in Verbindung, manchmal beziehen sich vielleicht 2 Sätze aufeinander, aber darüber hinaus nicht. Ein weiteres Problem ist, dass manchmal eine „Digitized by Google“-Fußzeile auftaucht, daher muss ich beim nächsten Training wirklich sicherstellen, dass die Texte gut bereinigt sind. Insgesamt bin ich mit den Ergebnissen sehr zufrieden, es ist noch kein LLM, aber definitiv ein Satzgenerator.

Ich lerne viel und werde in den kommenden Wochen herausfinden, was ich besser machen muss. Ich werde die Dateien bald hochladen!

# Geplante Vorhaben

(Abgeschlossen) Ich werde mit Version 0.5 beginnen, anstatt mit 50 Büchern zu trainieren, werde ich idealerweise 500–600 verwenden. Aktuell trainiere ich nanoGPT mit Büchern aus den Jahren 1800–1850 und speziell aus London. Es gibt einige Herausforderungen, wie sicherzustellen, dass die gefundenen Bücher nicht aktualisiert oder modern interpretiert sind, sondern unbearbeitete Bücher, die innerhalb meines gewählten Zeitraums veröffentlicht wurden.

Ich möchte ein neues Modell (v1) mit einem viel größeren Korpus trainieren, vielleicht 5–10 Mal größer als der, den ich für v0.5 verwendet habe. Mein Ziel ist es zu sehen, ob sich durch ausschließlich selektives temporales Training logische Fähigkeiten entwickeln können – das wird eine schwierigere Aufgabe und ich bin mir nicht einmal sicher, ob es möglich ist, da es historische Datenbeschränkungen gibt. In den kommenden Wochen werde ich versuchen, genug Daten für einen 5–10GB-Korpus zusammenzustellen. Ich glaube, wenn ich saubere, hochwertige Daten bekomme und eine GPU miete, wird es Fortschritte geben.

# Wie man dieses Projekt benutzt

Dieses Projekt konzentriert sich hauptsächlich auf das Kuratieren historischer Daten, deren Aufbereitung für das Training und den Aufbau eines Tokenizers. Den vollständigen LLM-Trainingsprozess werde ich nicht abdecken, siehe dazu nanoGPT von Andrej Karpathy.

# Schritt 1: Historische Texte sammeln und vorbereiten

Sammle .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus deinem gewählten Zeitraum (z. B. London 1800–1850)

Du kannst download_texts_improved.py verwenden, um Bücher herunterzuladen, falls du welche brauchst.

Bereinige die Textdateien mit einem Skript oder entferne manuell Header/Footers von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

prepare_dataset.py sollte problemlos funktionieren.

# Schritt 2: Einen eigenen Tokenizer bauen

Führe train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
Das gibt dir vocab.json und merges.txt

Diese Dateien definieren Vokabular und Merge-Regeln für dein Modell

# Schritt 3: Trainiere dein Modell (nanoGPT)

Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess.

Du kannst auch ein anderes LLM trainieren, aber ich habe nanoGPT verwendet

# FAQ

## Was ist selektives temporales Training?

Selektives temporales Training (STT) ist eine Machine-Learning-Methodik, bei der alle Trainingsdaten gezielt aus einem bestimmten historischen Zeitraum stammen. Ziel ist es, die Sprache und das Wissen dieser Ära ohne Einfluss moderner Konzepte zu modellieren. Das aktuelle Modell (v0.5) ist z.B. ausschließlich auf Daten von 1800–1875 trainiert, nicht feinabgestimmt, sondern von Grund auf, was zu Ausgaben führt, die den Sprachstil und Kontext jener Zeit widerspiegeln.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt möchte ich ein Sprachmodell schaffen, das nicht von modernen Einflüssen geprägt ist. Wenn ich z. B. GPT-2 feinabstimme, ist es schon vortrainiert und dieses Wissen verschwindet nicht. Wenn ich von Grund auf trainiere, wird das Modell die alte Sprache nicht nur imitieren, sondern sie tatsächlich verwenden. Das Ziel ist, ein Modell zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1850 logische Schlüsse ziehen kann.

## Welche Daten wurden für das Training verwendet?

Ich nutze Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1850. Die verlinkte Liste enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt ca. 187 MB verwendet. Eine Liste der Dokumente findest du hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Wie groß ist das Version-0-Modell?

Das Modell ist aktuell sehr klein, ich mache das nur zum Spaß und folge der strengen Trainingsregel ohne moderne Quellen. Es hat fast 16 Millionen Parameter, aber ich werde bald mehr alte Texte sammeln, um ein weiteres Modelltraining zu starten. Updates folgen.

## Trainingsspezifikationen?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---