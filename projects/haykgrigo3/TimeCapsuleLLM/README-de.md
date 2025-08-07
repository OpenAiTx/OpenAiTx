
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (bald verfügbar)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Koreanisch</a>
        | <a href="#" title="Coming soon">हिन्दी (bald verfügbar)</a> |
        | <a href="#" title="Coming soon">ไทย (bald verfügbar)</a> |
        | <a href="#" title="Coming soon">Französisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Deutsch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Spanisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Italienisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Russisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Portugiesisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Niederländisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Polnisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">العربية (bald verfügbar)</a>
        | <a href="#" title="Coming soon">فارسی (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Türkisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Vietnamesisch (bald verfügbar)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (bald verfügbar)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Ein LLM, das ausschließlich mit Daten aus bestimmten Zeitperioden trainiert wurde, um moderne Verzerrungen zu reduzieren.

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als sei es historisch, sondern es tatsächlich sein.

Basierend auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die Kern-Trainingsskripte und die Modellarchitektur sind seine Arbeit.

# Projektziele 

TimeCapsule LLM ist ein experimentelles Projekt, das nur mit Texten trainiert wird, die in bestimmten Zeitabschnitten geschrieben wurden. Das Ziel ist es, die Weltanschauung und Sprache spezifischer historischer Epochen zu simulieren.

# Warum Fine-Tuning nicht ausreicht 

Wenn Sie nur ein vortrainiertes Modell feinabstimmen, kennt Ihr LLM trotzdem moderne Konzepte. Natürlich ist es schwierig, eine vollständige Freiheit von modernen Verzerrungen zu erreichen, aber ich möchte dem so nahe wie möglich kommen. Um keinerlei moderne Einflüsse zu haben, muss ein Modell von Grund auf neu trainiert werden.

# Erwartete Ergebnisse 

Hoffentlich wird dieses Modell, wenn es fertig ist, keine modernen Konzepte kennen und nicht über das hinaus denken können, worauf es trainiert wurde. Es sollte keine modernen Begriffe/Konzepte erkennen und ich hoffe, dass es kein modernes Wissen halluziniert.

# Fortschrittsberichte

## 9. Juli 2025

Ich habe meine Zeitperiode auf 1800-1850 und die Region: London festgelegt.

Ich habe eine Liste von Texten, Büchern, Dokumenten gesammelt.

Bisher habe ich 50 als .txt-Dateien und werde bald mit dem Training von NanoGPT beginnen.

Ich werde dies weiter aktualisieren, solange Fortschritte gemacht werden.

## 13. Juli 2025

NanoGPT mit 187MB historischen Textdaten trainiert.

## 15. Juli 2025

Ich habe begonnen, Texte für den zweiten Trainingslauf herunterzuladen. Ich beziehe alles aus dem Internet Archive und habe die Zeitspanne auf 1800-1875 erweitert. Um eine vielfältige Auswahl an Texten zu bekommen, kann man im Internet Archive Such- und Themenfilter für Publikationsort, Zeitraum und Themen verwenden.

![Suchfilter](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16. Juli 2025

Ich habe etwa 500 txt-Dateien aus dem Internet Archive heruntergeladen und nach der Bereinigung (nur Leerzeichen, Gutenberg-Kopfzeilen usw. gelöscht) habe ich rund 500MB an Daten. Es ist ein kleines Datenset, aber das letzte Mal habe ich mit 187MB trainiert, also sollte es zumindest einen spürbaren Unterschied in den Ergebnissen nach dem zweiten Training geben. Ich hoffe, dass dieses Modell wenigstens kohärentere Sätze produzieren kann, die einigermaßen Sinn ergeben. Das ist natürlich keine Garantie, denn das Datenset ist immer noch sehr klein, aber es ist mehr als beim letzten Mal.

Das sollte auf meiner eigenen Hardware machbar sein, was gut ist, weil ich hoffentlich Verbesserungen sehe, bevor ich auf ein größeres Datenset umsteige, für das ich eine GPU mieten müsste. Keine Sorge, ich plane trotzdem bald eine GPU zu mieten, aber bevor ich das tue, möchte ich mein Datenset so sorgfältig wie möglich kuratieren und bereinigen. Ein Problem ist das Bereinigen, viele dieser txt-Dateien enthalten Kauderwelsch. Die Skripte, die ich zur Bereinigung verwendet habe, funktionieren, sind aber nicht 100% effektiv.

Ich werde dieses Datenset heute trainieren, und es sollte etwa 4-5 Stunden dauern. Wenn es fertig ist und ich es getestet habe, gebe ich Updates. Nochmals vielen Dank an alle, die sich mein Projekt ansehen; einige Leute haben mir sogar Links zu OCR-Ressourcen geschickt, also Danke! Ich hoffe, mehr Leute probieren das aus und experimentieren mit eigenen Datensets.


### Trainings-Update

Ich habe mit dem Training eines 435MB (108 Mio. Tokens) Korpus begonnen, es läuft gerade ziemlich reibungslos. Der Trainingsverlust ist von 10,9 auf 4,9 in den ersten 2800 Iterationen gesunken. Ich schätze, es wird etwa 8 oder 9 Stunden dauern. Ich poste ein weiteres Update, wenn es fertig ist.

## 17. Juli 2025

Das Training für das zweite Modell ist abgeschlossen, meine 4060 brauchte etwa 8 Stunden und 40 Minuten (3.900 Iters/Stunde) für 33.000 Iterationen (5 Epochen). Der finale Trainingsverlust lag bei 3,73. Die Ergebnisse waren überraschend gut – es erzeugt jetzt tatsächlich kohärente Sätze im Stil des 19. Jahrhunderts.

## 28. Juli 2025 

Ich habe Version 0.5 auf Hugging Face hochgeladen, [schau es dir an](https://huggingface.co/haykgrigorian/TimeCapsuleLLM), wenn du möchtest. Du kannst mein Repository jetzt herunterladen und lokal ausführen. Leider funktioniert nanoGPT nicht nativ mit HuggingFace, du musst das Modell also lokal herunterladen und ausführen.

Außerdem werde ich beginnen, Daten für meinen nächsten Trainingslauf zu kuratieren; ich denke, ich brauche vielleicht 5-10x mehr Daten, um echte Schlussfolgerungsfähigkeiten zu erreichen.

## 2. August 2025

Ich werde bald mit der Arbeit an Version 1 beginnen. Ich muss von der Architektur von nanoGPT zu etwas Modernerem übergehen. Ich habe mehrere Open-Source-LLM-Architekturen im Blick, darunter: OpenLLaMA v3, Phi-2 und Qwen 1.5B. Und um den Sprung zu V1 zu schaffen, muss ich ein viel größeres und vielfältigeres Datenset sorgfältig zusammenstellen. Ich benötige mindestens 5GB an sauberen Trainingsdaten.

# V0 Modellverhalten & Einschränkungen

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten aus dem 19. Jahrhundert antwortet. Zum Beispiel habe ich es mit "Who art Henry?" gefragt und es antwortete: "I know that man, I have did not a black, the storm." und ja, dieser Satz ergibt keinen Sinn, aber das LLM erkennt, dass ich nach einer Person frage.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Es gibt keine Erwähnung moderner Konzepte, die Ausgaben enthalten hauptsächlich Wörter und Formulierungen aus dem 19. Jahrhundert.

Es ist noch viel Arbeit nötig, das Training mit 187MB reicht nicht aus, um ein Modell zu bekommen, das Texte mit komplexem Denken erzeugt.

Im Moment produziert es Sätze, denen eine vollständige Satzstruktur fehlt und die insgesamt einfach keinen Sinn ergeben, aber das ist bei der Trainingsgröße normal.

# V0.5 Modellverhalten & Einschränkungen

Dies ist eine deutliche Verbesserung gegenüber dem letzten Modell. Der Schreibstil und der Wortschatz sind viktorianisch und fast jeder Satz ist grammatikalisch korrekt mit richtiger Zeichensetzung. Und auch das ist von Grund auf trainiert, daher bleibt es bei Themen des 19. Jahrhunderts.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Es gibt viele faktische Halluzinationen. Viele (ca. 100%) der Details (Daten, Ereignisse, historische Persönlichkeiten) sind erfunden. Außerdem haben die Sätze oft keinen Zusammenhang, manchmal beziehen sich vielleicht 2 Sätze aufeinander, aber darüber hinaus nicht. Ein weiteres Problem ist, dass manchmal ein irrtümliches “Digitized by Google”-Fußzeile auftaucht, daher muss ich beim nächsten Training wirklich darauf achten, dass die Texte gut bereinigt sind. Insgesamt bin ich mit den Ergebnissen sehr zufrieden, es ist zwar noch weit von einem LLM entfernt, aber definitiv ein Satzgenerator.

Ich lerne viel und werde in den kommenden Wochen herausfinden, was ich besser machen muss. Ich lade bald Dateien hoch!

# Zukünftige Pläne

(Abgeschlossen) Ich werde mit der Arbeit an Version 0.5 beginnen. Anstatt 50 Bücher zum Training zu verwenden, werde ich idealerweise 500-600 verwenden. Momentan trainiere ich nanoGPT mit Büchern von 1800-1850, speziell aus London. Es gibt Herausforderungen, wie sicherzustellen, dass die gefundenen Bücher nicht überarbeitet wurden oder moderne Interpretationen enthalten, sondern originale Bücher sind, die innerhalb meines gewählten Zeitraums veröffentlicht wurden.

Ich möchte ein neues Modell (v1) mit einem viel größeren Korpus trainieren, vielleicht 5-10x größer als der, den ich für v0.5 verwendet habe. Mein Ziel ist zu sehen, ob sich aus rein selektivem temporalen Training Denkfähigkeiten entwickeln. Das wird schwieriger und ich bin mir nicht einmal sicher, ob es möglich ist, da es historische Datenbeschränkungen gibt. In den kommenden Wochen werde ich versuchen, genug Daten für einen 5-10GB-Korpus zu kuratieren. Ich glaube, wenn ich saubere, hochwertige Daten bekomme und eine GPU miete, wird es Fortschritte geben.

# Wie man dieses Projekt nutzt

Dieses Projekt konzentriert sich hauptsächlich auf das Kuratieren historischer Daten, deren Aufbereitung für das Training und den Bau eines Tokenizers. Ich werde den kompletten LLM-Trainingsprozess nicht abdecken, dafür siehe nanoGPT von Andrej Karpathy.

# Schritt 1: Historische Texte sammeln und vorbereiten

Sammle .txt-Dateien gemeinfreier Bücher, Dokumente usw. aus deinem gewählten Zeitraum (z.B. London 1800-1850)

Du kannst download_texts_improved.py verwenden, um Bücher herunterzuladen, falls du welche benötigst.

Bereinige die Textdateien mit einem Skript oder entferne manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

prepare_dataset.py sollte problemlos funktionieren.

# Schritt 2: Einen eigenen Tokenizer bauen

Führe train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
Dadurch erhältst du vocab.json und merges.txt

Diese Dateien definieren Vokabular und Merge-Regeln für dein Modell

# Schritt 3: Trainiere dein Modell (nanoGPT)

Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess.

Du kannst ein anderes LLM trainieren, wenn du möchtest, aber ich habe nanoGPT verwendet

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine maschinelle Lernmethode, bei der alle Trainingsdaten gezielt so kuratiert werden, dass sie in einen bestimmten historischen Zeitraum fallen. Das wird gemacht, um die Sprache und das Wissen dieser Epoche zu modellieren, ohne Einflüsse moderner Konzepte. Zum Beispiel ist das aktuelle Modell (v0.5) ausschließlich mit Daten von 1800-1875 trainiert, nicht feinjustiert, sondern von Grund auf, sodass die Ausgaben den sprachlichen Stil und Kontext dieser Zeit widerspiegeln.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu erstellen, das nicht von modernen Vorurteilen beeinflusst ist. Wenn ich zum Beispiel ein GPT-2 feinjustiere, ist es bereits vortrainiert und diese Informationen verschwinden nicht mehr. Wenn ich von Grund auf trainiere, tut das Modell nicht so, als wäre es alt, sondern ist es tatsächlich. Das Ziel ist momentan, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1850 argumentieren kann.

## Welche Daten hast du fürs Training benutzt?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1850. Die verlinkte Liste enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt etwa 187 MB verwendet. Eine Liste der Dokumente findest du hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Wie groß ist das Version 0 Modell?

Dieses Modell ist derzeit sehr klein, ich mache das nur zum Spaß und halte mich strikt an die Trainingsregel, keine modernen Quellen zu verwenden. Es hat fast 16 Millionen Parameter, aber ich werde bald mehr alte Texte sammeln, um ein weiteres Modelltraining zu beginnen. Updates folgen!

## Trainingsspezifikationen?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---