
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

*Ein Sprachmodell, das **von Grund auf** ausschließlich mit Daten aus bestimmten Orten und Zeitperioden trainiert wurde, um moderne Verzerrungen zu reduzieren und die Stimme, den Wortschatz und die Weltanschauung der jeweiligen Epoche zu verkörpern.*

Stellen Sie sich vor, ein KI-Modell würde nicht nur historisch erscheinen, sondern tatsächlich historisch sein.

v0 und v0.5 basieren auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die zentralen Trainingsskripte und die Modellarchitektur stammen von ihm. 

v1 basiert auf [Phi 1.5 von Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Hugging Face Link](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten aus dem 19. Jahrhundert antwortet.
Beispiel: Prompt: "Who art Henry?" und es antwortete "I know that man, I have did not a black, the storm."

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens zeitgemäßer Wortschatz  
- Sätze sind größtenteils unzusammenhängend (erwartet bei ~187MB Trainingsdaten)

### **v0.5** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, korrekte Zeichensetzung, überwiegend grammatikalisch richtige Sätze  
- Weiterhin hohe Rate an faktischen Halluzinationen  
- OCR-Rauschen („Digitized by Google“) weiterhin in den Ausgaben vorhanden

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Erstes Modell, das ein reales historisches Ereignis mit einer tatsächlichen Figur aus dem Datensatz verknüpft.

Beispiel: Prompt: "It was the year of our Lord 1834"

Die Ausgabe: "Es war das Jahr unseres Herrn 1834 und die Straßen Londons waren erfüllt von Protest und Petition. Die Ursache, wie viele berichteten, war nicht privat gebunden, sondern hatte am selben Tag im Hause Lord Palmerston stattgefunden; die Öffentlichkeit wird eine kurze Darstellung der Schwierigkeiten erhalten, unter denen das Gesetz uns erreicht hat. Es ist sehr bedauerlich, dass die aktuellen Ereignisse in der Geschichte der Welt klar sind und folglich bekannt sein werden. Es stimmt nicht, dass gerade die Männer, die das Evangelium zuerst in Jerusalem verbreitet haben, einen so umfangreichen und interessanten Bericht über Wohlstand und Prosperität vorweisen können."

Zunächst nahm ich an, dass ein Protest zufällig im selben Jahr stattgefunden haben könnte, aber sehen Sie sich das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Warum das wichtig ist:

Dies ist das erste Beispiel, in dem eines meiner Modelle ein Jahr mit einem realen historischen Ereignis und einer realen Person, die mit diesem Ereignis verbunden ist (Lord Palmerston), verknüpft. Frühere Modelle (v0 und v0.5) konnten zwar den Schreibstil des 19. Jahrhunderts nachahmen, halluzinierten jedoch stets Ereignisse, Personen und Fakten. Dies zeigt, dass das Modell beginnt, sich an Inhalte aus dem Datensatz zu erinnern.


## Kommende Pläne

- Es gibt fast 175.000 Texte, die zwischen 1800 und 1875 in London veröffentlicht wurden, auf dem Internet Archive
- Ich plane, das Korpus zu erweitern und weiter zu bereinigen, um bessere Argumentationsfähigkeiten zu ermöglichen
- Erweiterung auf andere Regionen und Zeiträume für weitere historische Modelle

## Verwendungshinweise

Dieses Projekt konzentriert sich hauptsächlich auf die Sammlung historischer Daten, deren Vorbereitung für das Training und den Aufbau eines Tokenizers. Ich decke nicht den vollständigen LLM-Trainingsprozess ab, dafür verweise ich auf nanoGPT von Andrej Karpathy.

### Schritt 1: Historische Texte sammeln und vorbereiten

- Sammeln Sie .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus Ihrem gewählten Zeitraum (z. B. London 1800-1850)
- Halten Sie sich innerhalb Ihres gewählten Zeit-/Ortsfensters
- Bereinigen Sie die Textdateien mithilfe eines Skripts oder entfernen Sie manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder beispielsweise OCR-Fehler.

### Schritt 2: Eigener Tokenizer erstellen

- Führen Sie train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
- Dadurch erhalten Sie vocab.json und merges.txt
- Diese Dateien definieren Vokabular und Merge-Regeln für Ihr Modell

### Schritt 3: Modell trainieren

- Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess oder die Dokumentation Ihrer gewählten Architektur.

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine maschinelle Lernmethodik, bei der alle Trainingsdaten gezielt aus einem bestimmten historischen Zeitraum stammen. Dies dient dazu, die Sprache und das Wissen dieser Epoche zu modellieren, ohne Einfluss moderner Konzepte. Zum Beispiel wurde das aktuelle Modell (v0.5) ausschließlich mit Daten von 1800-1875 trainiert, nicht feinabgestimmt, sondern komplett neu, sodass die Ausgabe den sprachlichen Stil und den historischen Kontext dieses Zeitraums widerspiegelt.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt möchte ich ein Sprachmodell erstellen, das frei von modernen Vorurteilen ist. Wenn ich zum Beispiel GPT-2 feinabstimme, ist es bereits vortrainiert und diese Informationen verschwinden nicht. Wenn ich von Grund auf trainiere, wird das Sprachmodell nicht vorgeben, alt zu sein, sondern es wird es wirklich sein. Das Ziel dieses Projekts ist es derzeit, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1875 argumentieren kann.

## Welche Art von Daten wurde für das Training verwendet?


Ich verwende Bücher, Rechtsdokumente, Zeitungen und andere Schriften aus London von 1800–1875. Die verlinkte Liste (für v0) enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit ca. ~187 MB verwendet. Eine Liste der Dokumente kann hier eingesehen werden:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datensatzgrößen:
v0: ~187MB
v0.5: ~435MB
v1: ~6,25GB

## Wie groß sind die Modelle?

V0: 16 Mio. Parameter

V0.5: 123 Mio. Parameter

V1: 700 Mio. Parameter

# Trainingsspezifikationen?

# V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5.

# V1
GPU: A100 gemietet

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---