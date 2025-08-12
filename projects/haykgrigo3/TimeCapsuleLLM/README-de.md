
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (demnächst verfügbar)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Koreanisch</a>
        | <a href="#" title="Coming soon">हिन्दी (demnächst verfügbar)</a> |
        | <a href="#" title="Coming soon">ไทย (demnächst verfügbar)</a> |
        | <a href="#" title="Coming soon">Französisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Deutsch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Spanisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Italienisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Russisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Portugiesisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Niederländisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Polnisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">العربية (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">فارسی (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Türkisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Vietnamesisch (demnächst verfügbar)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (demnächst verfügbar)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Ein LLM, der ausschließlich mit Daten aus bestimmten Zeitperioden trainiert wurde, um moderne Verzerrungen zu reduzieren.

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern wäre es tatsächlich.

Basiert auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die zentralen Trainingsskripte und die Modellarchitektur stammen von ihm.

# Projektziele

TimeCapsule LLM ist ein experimentelles Projekt, das ausschließlich mit Texten aus bestimmten Zeitabschnitten trainiert wird. Ziel ist es, die Weltsicht und Sprache spezifischer historischer Epochen zu simulieren.

# Warum Fine-Tuning nicht ausreicht

Wenn man nur ein vortrainiertes Modell feinabstimmt, kennt das LLM trotzdem moderne Konzepte. Natürlich ist es schwierig, einen völlig modernen Bias zu vermeiden, aber ich möchte diesem Ziel so nahe wie möglich kommen. Um keinen modernen Bias zu haben, muss ein Modell von Grund auf neu trainiert werden.

# Erwartete Ergebnisse

Hoffentlich weiß das Modell am Ende nichts von modernen Konzepten und kann nicht über das hinaus argumentieren, worauf es trainiert wurde. Es sollte moderne Begriffe/Vokabeln nicht erkennen und keine modernen Kenntnisse halluzinieren.

# Fortschrittsupdates

## 9. Juli 2025

Ich habe meinen Zeitraum auf 1800-1850 und die Region: London festgelegt

Ich habe eine Liste von Texten, Büchern, Dokumenten zusammengestellt

Bisher habe ich 50 als txt-Dateien und werde bald mit dem Training von NanoGPT beginnen

Ich werde dies aktualisieren, solange Fortschritte gemacht werden

## 13. Juli 2025

NanoGPT mit 187MB historischer Textdaten trainiert.

## 15. Juli 2025

Ich habe begonnen, Texte für den zweiten Trainingslauf herunterzuladen. Ich bekomme alles vom Internet Archive und habe den Zeitraum auf 1800-1875 erweitert. Um eine breite Palette von Texten zu erhalten, kann man auf Internet Archive nach Veröffentlichungsort, Zeitraum und Themen filtern. 

![Suchfilter](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16. Juli 2025

Ich habe etwa 500 txt-Dateien vom Internet Archive heruntergeladen und nach dem Bereinigen (nur Leerzeichen löschen, Gutenberg-Header etc.) habe ich etwa 500MB Daten. Es ist ein winziger Datensatz, aber letztes Mal habe ich mit 187MB trainiert, also sollte es zumindest einen bemerkbaren Unterschied im Output nach dem Training des zweiten Modells geben. Ich hoffe, dieses Modell kann zumindest kohärentere Sätze produzieren, die einigermaßen Sinn ergeben. Das ist natürlich keine Garantie, denn der Datensatz ist immer noch winzig, aber es ist mehr als beim letzten Mal.

Das sollte auf meiner eigenen Hardware machbar sein, was gut ist, weil ich hoffentlich einige Verbesserungen sehe, bevor ich zu einem größeren Datensatz springe, für den ich eine GPU mieten müsste. Aber keine Sorge, ich plane weiterhin, bald eine GPU zu mieten, aber bevor ich das tue, möchte ich sicherstellen, dass mein Datensatz so kuratiert und sauber wie möglich ist. Eines der Probleme ist das Bereinigen, viele dieser txt-Dateien enthalten Kauderwelsch. Die Skripte, die ich zum Bereinigen verwendet habe, funktionieren, sind aber nicht zu 100% effektiv.

Ich werde diesen Datensatz heute trainieren und es sollte etwa 4-5 Stunden dauern. Sobald es fertig ist und ich es getestet habe, gebe ich Updates. Vielen Dank nochmals an alle, die sich mein Projekt ansehen, manche haben mir sogar Links zu OCR-Ressourcen geschickt, also Danke! Ich hoffe, dass mehr Leute das ausprobieren und mit eigenen Datensätzen experimentieren.

## 12. August 2025

Version 1 ist fertiggestellt, diese Version verwendet Phi 1.5 (700M Parameter) und wurde mit einem Datensatz von fast 7000 Texten trainiert. Die Hauptverbesserung bei diesem Modell ist seine Fähigkeit, gelegentlich echte Namen und historische Ereignisse zu referenzieren. Version 0 und 0.5 konnten dies nicht, wenn ich diese Modelle mit etwas wie „Im Jahr 1821“ aufforderte, waren die Ausgaben nur Halluzinationen, Dinge, die nie passiert sind. Ein Beispiel dafür mit Version 1:

Mein Prompt: Es war das Jahr unseres Herrn 1834,

Die Ausgabe: „Es war das Jahr unseres Herrn 1834 und die Straßen Londons waren voller Protest und Petition. Der Grund, wie viele berichteten, lag nicht im Privaten, sondern wurde am selben Tag im Hause von Lord Palmerston aufgenommen, die Öffentlichkeit wird eine kurze Darstellung der Schwierigkeiten erhalten, unter denen das Gesetz uns erreicht hat. Es ist sehr bedauerlich, dass die aktuellen Ereignisse der Weltgeschichte klar sind und folglich bekannt sein werden. Es ist nicht wahr, dass gerade die Männer, die zuerst im Evangelium zu Jerusalem tätig wurden, so umfassende und interessante Aufzeichnungen über den Wohlstand und das Gedeihen besitzen.“

Zuerst dachte ich, das sei Zufall, aber schaut euch das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Trainings-Update

Ich habe mit dem Training auf einem 435MB (108 Mio. Token) Korpus begonnen, es läuft gerade ziemlich reibungslos. Der Trainingsverlust fiel von 10,9 auf 4,9 in den ersten 2800 Iterationen. Ich rechne damit, dass es etwa 8 oder 9 Stunden dauern wird. Ich poste ein weiteres Update, sobald es fertig ist.

## 17. Juli 2025

Das Training für das zweite Modell ist abgeschlossen, meine 4060 hat etwa 8 Stunden und 40 Minuten gebraucht (3.900 Iterationen/Stunde) für 33.000 Iterationen (5 Epochen). Der finale Trainingsverlust lag bei 3,73. Die Ausgaben waren überraschend gut, es generiert jetzt tatsächlich zusammenhängende Sätze im Stil des 19. Jahrhunderts.

## 28. Juli 2025

Ich habe v0.5 auf Hugging Face hochgeladen, [Schaut es euch an](https://huggingface.co/haykgrigorian/TimeCapsuleLLM), wenn ihr möchtet. Ihr könnt jetzt mein Repo herunterladen und lokal ausführen. Leider funktioniert nanoGPT nicht nativ mit HuggingFace, daher müsst ihr das Modell lokal herunterladen und ausführen.

Außerdem beginne ich mit der Auswahl von Daten für meinen nächsten Trainingslauf, ich glaube, ich werde 5-10x mehr Daten benötigen, um Fähigkeiten zum logischen Schlussfolgern zu erreichen.

## 2. August 2025

Ich werde bald mit der Arbeit an Version 1 beginnen. Ich muss von der Architektur von nanoGPT zu etwas Modernerem wechseln. Ich habe mehrere Open-Source-LLM-Architekturen im Blick, darunter: OpenLLaMA v3, Phi-2 und Qwen 1.5B. Und um den Sprung zu V1 zu unterstützen, muss ich einen viel größeren und vielfältigeren Datensatz sorgfältig zusammenstellen. Ich brauche mindestens 5GB saubere Trainingsdaten.

# V0 Modellverhalten & Einschränkungen

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er reagiert. Zum Beispiel habe ich es mit „Who art Henry?“ aufgefordert und es antwortete „I know that man, I have did not a black, the storm.“ und ja, dieser Satz ergibt keinen Sinn, aber das LLM erkennt, dass ich nach einer Person frage.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Es gibt keine Erwähnung moderner Konzepte, die Ausgaben enthalten hauptsächlich Wörter und Formulierungen aus den 1800er Jahren.

Es braucht noch viel Arbeit, das Training mit 187MB reicht nicht aus, um ein Modell zu bekommen, das Texte mit komplexer Argumentation erzeugt.

Im Moment erzeugt das Modell Sätze, die keine vollständige Satzstruktur aufweisen und insgesamt einfach keinen Sinn ergeben, aber das ist bei der Trainingsgröße normal.

# V0.5 Modellverhalten & Einschränkungen

Dies ist eine schöne Verbesserung im Vergleich zum letzten Modell. Der Schreibstil und Wortschatz ist viktorianisch und fast jeder Satz ist grammatikalisch korrekt mit richtiger Zeichensetzung. Und wieder wurde das Modell von Grund auf neu trainiert, daher bezieht es sich auf Themen aus dem 19. Jahrhundert.

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Es gibt viele faktische Halluzinationen. Viele (etwa 100%) der Details (Daten, Ereignisse, historische Figuren) sind erfunden. Außerdem haben die Sätze untereinander keine wirklichen Verbindungen, manchmal beziehen sich vielleicht 2 Sätze aufeinander, aber darüber hinaus nicht. Ein weiteres Problem ist, dass manchmal ein fremder „Digitized by Google“-Footer auftaucht, daher muss ich beim nächsten Training unbedingt darauf achten, dass die Texte gut bereinigt sind. Insgesamt bin ich sehr zufrieden mit den Ergebnissen, es ist zwar noch lange kein LLM, aber definitiv ein Satzgenerator.

Ich lerne viel und werde in den kommenden Wochen herausfinden, was ich besser machen muss. Ich werde bald Dateien hochladen!

# V1 Modellverhalten & Einschränkungen

Ich werde bald einige Beispielausgaben hochladen und auch Vergleiche zwischen den 3 Modellen mit dem gleichen Prompt machen. Ich werde V1 auch auf Huggingface hochladen, wie ich es bei meiner letzten Version gemacht habe, meinen Huggingface-Account findet ihr hier: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Kommende Pläne

(Abgeschlossen) Ich werde mit der Arbeit an Version 0.5 beginnen. Statt mit 50 Büchern zu trainieren, werde ich idealerweise mit 500-600 Büchern trainieren. Im Moment trainiere ich nanoGPT mit Büchern aus 1800-1850 und speziell aus London. Es gibt einige Herausforderungen, wie sicherzustellen, dass die gefundenen Bücher nicht aktualisiert oder modern interpretiert wurden, sondern unveränderte Bücher, die innerhalb meines gewählten Zeitraums veröffentlicht wurden.

Ich möchte ein neues Modell (v1) mit einem viel größeren Korpus trainieren, vielleicht 5-10x größer als der für v0.5 verwendete. Mein Ziel ist es zu sehen, ob durch Selective Temporal Training allein Fähigkeiten zum logischen Denken entstehen können. Dies wird eine schwierigere Aufgabe und ich bin mir nicht einmal sicher, ob es möglich ist, da es Einschränkungen bei historischen Daten gibt. In den nächsten Wochen werde ich versuchen, genug Daten für einen Korpus von 5-10GB zusammenzustellen. Ich glaube, wenn ich saubere, hochwertige Daten bekomme und eine GPU miete, wird es Fortschritte geben.

# Wie man dieses Projekt verwendet

Dieses Projekt konzentriert sich hauptsächlich auf das Kuratieren historischer Daten, deren Vorbereitung für das Training und den Aufbau eines Tokenizers. Ich werde den vollständigen LLM-Trainingsprozess nicht abdecken, dafür verweise ich auf nanoGPT von Andrej Karpathy.

# Schritt 1: Historische Texte sammeln und vorbereiten

Sammle .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus deinem gewählten Zeitraum (z.B. London 1800-1850)

Du kannst download_texts_improved.py verwenden, um Bücher für dich herunterzuladen, falls du das benötigst.

Bereinige die Textdateien mit einem Skript oder entferne manuell Header/Footer von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

prepare_dataset.py sollte einwandfrei funktionieren.

# Schritt 2: Einen eigenen Tokenizer bauen

Führe train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
Dadurch erhältst du vocab.json und merges.txt

Diese Dateien definieren Vokabular und Merge-Regeln für Ihr Modell

# Schritt 3: Trainieren Sie Ihr Modell (nanoGPT)

Beziehen Sie sich auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess.

Sie können ein anderes LLM trainieren, wenn Sie möchten, aber ich habe nanoGPT verwendet

# FAQ

## Was ist Selektives Temporales Training?

Selektives Temporales Training (STT) ist eine Methode des maschinellen Lernens, bei der alle Trainingsdaten gezielt auf einen bestimmten historischen Zeitraum beschränkt werden. Dies dient dazu, die Sprache und das Wissen jener Epoche ohne Einfluss moderner Konzepte zu modellieren. Zum Beispiel wurde das aktuelle Modell (v0.5) ausschließlich mit Daten von 1800–1875 trainiert, nicht feinabgestimmt, sondern von Grund auf neu, wodurch die Ausgabe den Sprachstil und Kontext jener Zeit widerspiegelt.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt möchte ich ein Sprachmodell erschaffen, das frei von modernen Einflüssen ist. Wenn ich etwa GPT-2 feinabstimme, ist es bereits vortrainiert, und diese Informationen bleiben erhalten. Wenn ich von Grund auf trainiere, tut das Sprachmodell nicht so, als wäre es alt, sondern es ist es wirklich. Das Ziel des Projekts ist aktuell, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern zwischen 1800 und 1850 argumentieren kann.

## Welche Daten wurden für das Training verwendet?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1850. Die verlinkte Liste enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit ca. 187 MB genutzt. Eine Liste der Dokumente finden Sie unter:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Wie groß sind die Modelle?

V0: 16M Parameter

V0.5: 123M Parameter

V1: 700M Parameter

# Trainingsspezifikationen?

#V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5.

#V1
GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---