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
Ein LLM, das nur mit Daten aus bestimmten Zeitperioden trainiert wurde, um moderne Verzerrungen zu reduzieren.

Stell dir vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern wäre es tatsächlich.

Basierend auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) Die zentralen Trainingsskripte und die Modellarchitektur stammen von ihm.

# Projektziele

TimeCapsule LLM ist ein experimentelles Projekt, das ausschließlich mit Texten aus bestimmten Zeiträumen trainiert wird. Ziel ist es, die Weltanschauung und Sprache bestimmter historischer Epochen zu simulieren.

# Warum Feintuning nicht ausreicht

Wenn man nur ein vortrainiertes Modell finetuned, kennt das LLM trotzdem moderne Konzepte. Natürlich ist es schwierig, eine Verzerrung durch moderne Einflüsse vollständig zu vermeiden, aber ich möchte so nah wie möglich daran kommen. Keine moderne Verzerrung zu erreichen, erfordert ein Training des Modells von Grund auf.

# Erwartete Ergebnisse

Hoffentlich wird dieses Modell, wenn es fertig ist, keine modernen Konzepte kennen und nicht über das hinaus denken können, was es gelernt hat. Es sollte keine modernen Begriffe oder Vokabeln erkennen und ich hoffe, es halluziniert kein modernes Wissen.

# Fortschritts-Updates

## 9. Juli 2025

Ich habe meinen Zeitraum auf 1800–1850 und die Region London festgelegt.

Ich habe eine Liste von Texten, Büchern, Dokumenten zusammengestellt.

Bisher habe ich 50 als txt-Dateien erhalten und werde NanoGPT bald mit dem Training beginnen.

Ich werde dies aktualisieren, solange Fortschritte gemacht werden.

## 13. Juli 2025

NanoGPT mit 187MB historischen Textdaten trainiert.

## 15. Juli 2025

Ich habe begonnen, Texte für den zweiten Trainingslauf herunterzuladen. Ich bekomme alles aus dem Internet Archive und habe den Zeitraum auf 1800–1875 erweitert. Um eine breite Palette an Texten zu erhalten, kann man im Internet Archive die Filter für Veröffentlichungsort, Zeitraum und Themen verwenden.

![Suchfilter](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16. Juli 2025

Ich habe etwa 500 txt-Dateien aus dem Internet Archive heruntergeladen und nach dem Bereinigen (nur Leerzeichen löschen, Gutenberg-Kopfzeilen usw.) habe ich etwa 500MB Daten. Es ist ein winziger Datensatz, aber letztes Mal habe ich mit 187MB trainiert, also sollte es zumindest einen merklichen Unterschied im Output geben, nachdem ich das zweite Modell trainiert habe. Ich hoffe, dieses Modell kann zumindest zusammenhängendere Sätze produzieren, die einigermaßen Sinn ergeben. Das ist natürlich keine Garantie, da es immer noch ein sehr kleiner Datensatz ist, aber mehr als beim letzten Mal.

Das sollte auf meiner eigenen Hardware machbar sein, was gut ist, weil ich hoffentlich Verbesserungen sehe, bevor ich zu einem größeren Datensatz wechsle, für den ich eine GPU mieten müsste. Keine Sorge, ich plane trotzdem bald eine GPU zu mieten, aber vorher möchte ich sicherstellen, dass mein Datensatz so kuratiert und sauber wie möglich ist. Eines der Probleme ist das Bereinigen – viele dieser txt-Dateien enthalten Unsinn. Die Skripte, die ich für das Bereinigen verwendet habe, funktionieren, sind aber nicht 100% effektiv.

Ich werde diesen Datensatz heute trainieren und es sollte etwa 4–5 Stunden dauern. Sobald es fertig ist und ich es getestet habe, gebe ich Updates. Danke nochmal an alle, die sich mein Projekt ansehen, einige haben mir sogar Links zu OCR-Ressourcen geschickt – vielen Dank! Ich hoffe, mehr Leute probieren das aus und experimentieren mit eigenen Datensätzen.


### Trainings-Update

Ich habe mit dem Training auf einem 435MB (108 Mio. Tokens) Korpus begonnen, es läuft aktuell ziemlich reibungslos. Der Trainingsverlust ist von 10,9 auf 4,9 in den ersten 2800 Iterationen gefallen. Ich rechne damit, dass es etwa 8 oder 9 Stunden dauern wird. Ich poste ein weiteres Update, sobald es fertig ist.

## 17. Juli 2025 2:13 Uhr

Das Training für das zweite Modell ist abgeschlossen, meine 4060 hat dafür etwa 8 Stunden und 40 Minuten gebraucht (3.900 Iterationen/Stunde) für 33.000 Iterationen (5 Epochen). Der endgültige Trainingsverlust lag bei 3,73. Die Ergebnisse waren überraschend gut, es generiert jetzt tatsächlich zusammenhängende Sätze im Stil des 19. Jahrhunderts.

## 28. Juli 2025

Ich habe v0.5 bei Hugging Face hochgeladen, [schau es dir an](https://huggingface.co/haykgrigorian/TimeCapsuleLLM), wenn du möchtest. Du kannst jetzt mein Repo herunterladen und lokal ausführen. Leider funktioniert nanoGPT nicht nativ mit HuggingFace, daher musst du das Modell lokal herunterladen und ausführen.

Außerdem werde ich jetzt Daten für meinen nächsten Trainingslauf kuratieren. Ich denke, ich brauche vielleicht 5- bis 10-mal mehr Daten, um echte Argumentationsfähigkeiten zu erreichen.


# V0 Modellverhalten & Einschränkungen

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er reagiert. Zum Beispiel fragte ich: "Who art Henry?" und es antwortete: "I know that man, I have did not a black, the storm." Und ja, dieser Satz ergibt keinen Sinn, aber das LLM erkennt immerhin, dass ich nach einer Person frage.


![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Es gibt keine Erwähnung moderner Konzepte, die Ausgaben enthalten hauptsächlich Wörter und Formulierungen aus dem 19. Jahrhundert.

Es muss noch viel Arbeit geleistet werden, das Training mit 187MB reicht nicht aus, um ein Modell zu erhalten, das Texte mit komplexem Denken produziert.

Momentan erzeugt es Sätze, die keine vollständige Satzstruktur haben und insgesamt einfach keinen Sinn ergeben, aber das ist bei dieser Trainingsgröße normal.

# V0.5 Modellverhalten & Einschränkungen

Dies ist eine schöne Verbesserung im Vergleich zum letzten Modell. Der Schreibstil und der Wortschatz sind viktorianisch und fast jeder Satz ist grammatikalisch korrekt mit richtiger Zeichensetzung. Und erneut: Das Modell wurde von Grund auf trainiert, sodass es bei Themen des 19. Jahrhunderts bleibt.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Es gibt viele faktische Halluzinationen. Sehr viele (fast 100%) der Details (Daten, Ereignisse, historische Figuren) sind erfunden. Außerdem stehen die Sätze nicht wirklich im Zusammenhang zueinander, manchmal beziehen sich vielleicht 2 Sätze aufeinander, aber darüber hinaus nicht. Ein weiteres Problem ist, dass manchmal eine zufällige „Digitized by Google“-Fußzeile auftaucht, deshalb muss ich beim nächsten Training wirklich darauf achten, dass die Texte gut gesäubert sind. Insgesamt bin ich mit den Ergebnissen sehr zufrieden, es ist zwar noch kein LLM, aber definitiv ein Satzgenerator.

Ich lerne viel und werde in den kommenden Wochen herausfinden, was ich besser machen muss. Ich werde bald Dateien hochladen!

# Zukünftige Pläne

(Abgeschlossen) Ich beginne mit der Arbeit an Version 0.5. Anstatt 50 Bücher zu verwenden, werde ich idealerweise 500–600 verwenden. Momentan trainiere ich nanoGPT mit Büchern aus den Jahren 1800–1850, speziell aus London. Es gibt Herausforderungen, wie sicherzustellen, dass die gefundenen Bücher nicht überarbeitet oder modern interpretiert sind, sondern unberührte Bücher, die innerhalb meines gewählten Zeitraums veröffentlicht wurden.

Ich möchte ein neues Modell (v1) mit einem viel größeren Korpus trainieren, vielleicht 5–10x so groß wie der für v0.5 verwendete. Mein Ziel ist es zu sehen, ob sich allein durch Selective Temporal Training Denkfähigkeiten herausbilden können. Das wird schwieriger und ich bin nicht ganz sicher, ob es wegen der historischen Datenbegrenzungen überhaupt möglich ist. In den nächsten Wochen werde ich versuchen, genug Daten für einen 5–10GB großen Korpus zusammenzustellen. Ich glaube, wenn ich saubere, hochwertige Daten bekomme und eine GPU miete, wird es Fortschritte geben.

# So benutzt du dieses Projekt

Dieses Projekt konzentriert sich hauptsächlich auf das Sammeln historischer Daten, deren Aufbereitung für das Training und den Bau eines Tokenizers. Ich werde nicht den gesamten LLM-Trainingsprozess abdecken, dafür verweise ich auf nanoGPT von Andrej Karpathy.

# Schritt 1: Historische Texte sammeln und vorbereiten

Sammle .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus deinem gewählten Zeitraum (z. B. London 1800–1850).

Du kannst download_texts_improved.py verwenden, um Bücher herunterzuladen, falls du welche brauchst.

Bereinige die Textdateien mit einem Skript oder entferne manuell Header/Footers von Project Gutenberg, moderne Anmerkungen oder Fehler wie OCR-Fehler.

prepare_dataset.py sollte gut funktionieren.

# Schritt 2: Einen eigenen Tokenizer bauen

Führe train_tokenizer.py oder train_tokenizer_hf.py auf den gesäuberten Daten aus.
Dadurch erhältst du vocab.json und merges.txt

Diese Dateien definieren Wortschatz und Merge-Regeln für dein Modell.

# Schritt 3: Dein Modell trainieren (nanoGPT)

Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess.

Du kannst auch ein anderes LLM trainieren, aber ich habe nanoGPT verwendet.

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine Machine Learning-Methode, bei der alle Trainingsdaten gezielt aus einem bestimmten historischen Zeitraum stammen. Das geschieht, um Sprache und Wissen jener Epoche ohne Einfluss moderner Konzepte zu modellieren. Das aktuelle Modell (v0.5) wurde beispielsweise ausschließlich mit Daten von 1800–1875 trainiert, nicht feinabgestimmt, sondern von Grund auf. Das Ergebnis spiegelt den Sprachstil und den historischen Kontext jener Zeit wider.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu erschaffen, das nicht von modernen Einflüssen getrübt ist. Wenn ich z. B. GPT-2 feinabstimme, ist es bereits vortrainiert und dieses Wissen bleibt erhalten. Wenn ich von Grund auf trainiere, tut das Sprachmodell nicht so, als wäre es alt – es ist es einfach. Das Ziel ist, ein Modell zu bauen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1850 argumentieren kann.

## Welche Daten hast du zum Training verwendet?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus dem London der Jahre 1800–1850. Die verlinkte Liste enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit rund 187 MB verwendet. Du kannst die Dokumentenliste hier ansehen:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Wie groß ist das Version 0 Modell?

Dieses Modell ist momentan sehr klein, ich mache das nur zum Spaß und folge strikt der Regel, keine modernen Quellen zu verwenden. Es hat fast 16 Millionen Parameter, aber ich beginne bald, mehr alte Texte zu sammeln, um ein weiteres Modell zu trainieren. Updates folgen!

## Trainingsspezifikationen?

GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---