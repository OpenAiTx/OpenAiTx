<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Koreanisch</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Französisch (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Spanisch (coming soon)</a>
        | <a href="#" title="Coming soon">Italienisch (coming soon)</a>
        | <a href="#" title="Coming soon">Russisch (coming soon)</a>
        | <a href="#" title="Coming soon">Portugiesisch (coming soon)</a>
        | <a href="#" title="Coming soon">Niederländisch (coming soon)</a>
        | <a href="#" title="Coming soon">Polnisch (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkisch (coming soon)</a>
        | <a href="#" title="Coming soon">Vietnamesisch (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Ein LLM, der ausschließlich mit Daten aus bestimmten Zeiträumen trainiert wurde, um moderne Verzerrungen zu reduzieren.

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern es wäre es tatsächlich.

Basiert auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die Kern-Trainingsskripte und die Modellarchitektur stammen von ihm.

# Projektziele

TimeCapsule LLM ist ein experimentelles Projekt, das ausschließlich mit Texten aus bestimmten Zeitperioden trainiert wird. Ziel ist es, Weltanschauung und Sprache spezifischer historischer Epochen zu simulieren.

# Warum Fine-Tuning nicht ausreicht

Wenn man ein vortrainiertes Modell nur feinabstimmt, kennt das LLM trotzdem moderne Konzepte. Natürlich ist es schwierig, eine völlig moderne Verzerrung zu vermeiden, aber ich möchte dem so nahe wie möglich kommen. Um keine moderne Verzerrung zu haben, muss man ein Modell von Grund auf neu trainieren.

# Erwartete Ergebnisse

Hoffentlich wird das fertige Modell keine modernen Konzepte kennen und nicht über das hinaus denken können, was es gelernt hat. Es sollte moderne Begriffe/Vokabeln nicht erkennen, und ich hoffe, es halluziniert kein modernes Wissen.

# Fortschritts-Updates

## 9. Juli 2025

Ich habe meinen Zeitraum auf 1800–1850 und die Region: London festgelegt.

Ich habe eine Liste von Texten, Büchern, Dokumenten gesammelt.

Bisher habe ich 50 als txt-Dateien und werde bald mit dem Training von NanoGPT beginnen.

Ich werde dies aktualisieren, solange Fortschritte gemacht werden.

## 13. Juli 2025

NanoGPT mit 187MB historischen Textdaten trainiert.

## 15. Juli 2025

Ich habe begonnen, Texte für den zweiten Trainingslauf herunterzuladen. Ich bekomme alles vom Internet Archive und habe den Zeitraum auf 1800–1875 erweitert. Um eine breite Vielfalt an Texten zu erhalten, kann man im Internet Archive nach Veröffentlichungsort, Zeitraum und Themen filtern.

![Suchfilter](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16. Juli 2025

Ich habe etwa 500 txt-Dateien vom Internet Archive heruntergeladen und nach dem Bereinigen (nur Leerzeichen löschen, Gutenberg-Kopfzeilen usw.) habe ich etwa 500MB Daten. Es ist ein winziges Datenset, aber das letzte Mal habe ich mit 187MB trainiert, also sollte es zumindest irgendeinen spürbaren Unterschied beim Output nach dem Training des zweiten Modells geben. Ich hoffe, dieses Modell kann zumindest zusammenhängendere Sätze erzeugen, die einigermaßen Sinn ergeben. Das ist natürlich keine Garantie, denn das Datenset ist immer noch winzig klein, aber es ist mehr als beim letzten Mal.

Das sollte auf meiner eigenen Hardware machbar sein, was auch gut ist, weil ich hoffentlich Verbesserungen sehe, bevor ich zu einem größeren Datensatz springe, für den ich eine GPU mieten müsste. Aber keine Sorge, ich plane trotzdem bald eine GPU zu mieten, aber vorher will ich sicherstellen, dass mein Datensatz so kuratiert und sauber wie möglich ist. Ein Problem ist das Bereinigen, viele dieser txt-Dateien enthalten Kauderwelsch. Die Skripte, die ich zum Bereinigen verwendet habe, funktionieren, aber sie sind nicht 100% effektiv.

Ich werde dieses Datenset heute trainieren, das sollte etwa 4–5 Stunden dauern. Sobald es fertig ist und ich es getestet habe, gebe ich Updates. Vielen Dank an alle, die sich mein Projekt ansehen, einige haben mir sogar Links zu OCR-Ressourcen geschickt, also danke! Ich hoffe, mehr Leute probieren das aus und experimentieren mit eigenen Datensätzen.

### Trainings-Update

Ich habe mit dem Training eines 435MB (108 Mio. Tokens) Korpus begonnen, bisher läuft alles ziemlich reibungslos. Der Trainingsverlust fiel von 10,9 auf 4,9 in den ersten 2800 Iterationen. Ich schätze, es wird etwa 8 oder 9 Stunden dauern. Ich poste ein weiteres Update, sobald es fertig ist.

## 17. Juli 2025, 2:13 Uhr

Das Training für das zweite Modell ist abgeschlossen, meine 4060 hat etwa 8 Stunden und 40 Minuten gebraucht (3.900 Iterationen/Stunde) für 33.000 Iterationen (5 Epochen). Der finale Trainingsverlust lag bei 3,73. Die Ausgaben waren überraschend gut, es generiert jetzt tatsächlich zusammenhängende Sätze im Stil des 19. Jahrhunderts.

# V0 Modellverhalten & Einschränkungen

Erste Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er antwortet. Zum Beispiel habe ich mit "Who art Henry?" getestet, und es antwortete: "I know that man, I have did not a black, the storm." – ja, dieser Satz ergibt keinen Sinn, aber das LLM erkennt, dass ich nach einer Person frage.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Es gibt keine Erwähnung moderner Konzepte, die Ausgaben enthalten meist Wörter und Formulierungen aus den 1800ern.

Es ist noch viel Arbeit nötig, mit 187MB Training erhält man kein Modell, das Texte mit komplexer Argumentation erzeugt.

Momentan produziert es Sätze, denen vollständige Satzstruktur fehlt und die insgesamt wenig Sinn ergeben, aber das ist bei der Trainingsgröße normal.

# V0.5 Modellverhalten & Einschränkungen

Dies ist eine schöne Verbesserung im Vergleich zum letzten Modell. Der Schreibstil und der Wortschatz sind viktorianisch und fast jeder Satz ist grammatikalisch korrekt mit richtiger Zeichensetzung. Und wieder wurde das Modell von Grund auf trainiert, sodass es bei Themen des 19. Jahrhunderts bleibt.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Es gibt viele sachliche Halluzinationen. Viele (etwa 100%) der Details (Daten, Ereignisse, historische Persönlichkeiten) sind erfunden. Außerdem stehen die Sätze oft nicht wirklich im Zusammenhang, manchmal beziehen sich vielleicht zwei Sätze aufeinander, aber darüber hinaus nicht. Ein weiteres Problem ist, dass manchmal ein zufälliger „Digitized by Google“-Footer auftaucht, also muss ich beim nächsten Training wirklich sicherstellen, dass die Texte gut bereinigt sind. Insgesamt bin ich sehr zufrieden mit den Ergebnissen, es ist noch lange kein LLM, aber definitiv ein Satzgenerator.

Ich lerne viel und werde in den kommenden Wochen herausfinden, was ich besser machen muss. Dateien werden bald hochgeladen!

# Geplante Vorhaben

(Abgeschlossen) Ich werde mit der Arbeit an Version 0.5 beginnen. Statt mit 50 Büchern zu trainieren, werde ich idealerweise mit 500–600 trainieren. Im Moment trainiere ich nanoGPT mit Büchern aus den Jahren 1800–1850, speziell aus London. Es gibt einige Herausforderungen, wie sicherzustellen, dass die gefundenen Bücher nicht aktualisiert oder modern interpretiert wurden, sondern im gewählten Zeitraum unverändert veröffentlicht wurden.

Ich möchte ein neues Modell (v1) mit einem viel größeren Korpus trainieren, vielleicht 5–10 Mal größer als der, den ich für v0.5 verwendet habe. Mein Ziel ist zu sehen, ob aus rein selektiv-temporalem Training bereits logische Fähigkeiten entstehen können; das wird eine schwierigere Aufgabe und ich bin mir nicht sicher, ob das möglich ist, da es historische Datenbeschränkungen gibt. In den nächsten Wochen werde ich versuchen, genügend Daten für einen 5–10 GB Korpus zusammenzustellen. Ich glaube, wenn ich saubere, hochwertige Daten bekomme und eine GPU miete, wird es Fortschritte geben.

# Wie man dieses Projekt nutzt

Dieses Projekt konzentriert sich hauptsächlich auf das Kuratieren historischer Daten, deren Vorbereitung für das Training und das Erstellen eines Tokenizers. Ich werde den kompletten LLM-Trainingsprozess nicht abdecken; dazu siehe nanoGPT von Andrej Karpathy.

# Schritt 1: Historische Texte sammeln und vorbereiten

Sammle .txt-Dateien von Büchern, Dokumenten usw. aus dem gewünschten Zeitraum (z. B. London 1800–1850), die gemeinfrei sind.

Du kannst download_texts_improved.py verwenden, um für dich Bücher herunterzuladen, falls du das brauchst.

Bereinige die Textdateien mit einem Skript oder entferne manuell Header/Footer von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

prepare_dataset.py sollte problemlos funktionieren.

# Schritt 2: Einen eigenen Tokenizer bauen

Führe train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
Das ergibt vocab.json und merges.txt

Diese Dateien definieren den Wortschatz und die Zusammenführungsregeln für dein Modell

# Schritt 3: Trainiere dein Modell (nanoGPT)

Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess.

Du kannst auch ein anderes LLM trainieren, aber ich habe nanoGPT verwendet

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine Machine-Learning-Methodik, bei der alle Trainingsdaten gezielt so ausgewählt werden, dass sie in einen bestimmten historischen Zeitraum fallen. Ziel ist es, die Sprache und das Wissen dieser Epoche ohne Einfluss moderner Konzepte zu modellieren. Zum Beispiel wurde mein aktuelles Modell (v0.5) ausschließlich mit Daten von 1800–1875 trainiert, nicht feinabgestimmt, sondern von Grund auf, sodass die Ausgaben den Sprachstil und historischen Kontext dieser Zeit widerspiegeln.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

In diesem Projekt versuche ich, ein Sprachmodell zu erstellen, das frei von modernem Bias ist. Wenn ich z. B. GPT-2 feinabstimme, ist es bereits vortrainiert und diese Information bleibt erhalten. Wenn ich von Grund auf trainiere, tut das Modell nicht so, als wäre es alt – es ist es einfach. Ziel des Projekts ist es momentan, etwas zu schaffen, das ausschließlich mit dem Wissen aus Londoner Büchern, die zwischen 1800 und 1850 veröffentlicht wurden, argumentieren kann.

## Welche Daten wurden für das Training verwendet?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1850. Die verlinkte Liste hat etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt ca. 187 MB verwendet. Eine Liste der Dokumente findest du hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Wie groß ist das Version-0-Modell?

Dieses Modell ist derzeit sehr klein, ich mache das nur zum Spaß und halte mich strikt an die Regel, keine modernen Quellen zu verwenden. Es hat fast 16 Millionen Parameter, aber ich werde mehr alte Texte sammeln, um ein weiteres Modelltraining zu beginnen. Updates folgen.

## Trainingsspezifikationen?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---