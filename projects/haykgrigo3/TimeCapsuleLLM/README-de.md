
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

##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Eingaben zeigen, dass das Modell mit Sprache und Verhalten aus dem 19. Jahrhundert antwortet. 
Beispiel: Eingabe: „Who art Henry?“ und es antwortete: „I know that man, I have did not a black, the storm.“

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens zeitgenössischer Wortschatz  
- Sätze sind größtenteils unzusammenhängend (zu erwarten bei ~187MB Trainingsdaten)

### **v0.5** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, korrekte Interpunktion, meist grammatikalisch korrekte Sätze  
- Immer noch hohe Rate an faktischen Halluzinationen  
- OCR-Rauschen („Digitized by Google“) weiterhin in den Ausgaben enthalten

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Erstes Modell, das ein tatsächliches historisches Ereignis mit einer echten Person aus dem Datensatz verknüpft.

Beispiel: Eingabe: „It was the year of our Lord 1834“

Die Ausgabe: „It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity“

Zunächst nahm ich an, dass zufällig im selben Jahr ein Protest stattgefunden haben könnte, aber sehen Sie sich das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Warum das wichtig ist:

Dies ist das erste Beispiel, bei dem eines meiner Modelle ein Jahr sowohl mit einem realen historischen Ereignis als auch mit einer realen Person, die mit diesem Ereignis verbunden ist (Lord Palmerston), verknüpft. Frühere Modelle (v0 und v0.5) konnten zwar Schreibstile des 19. Jahrhunderts nachahmen, halluzinierten jedoch immer Ereignisse, Personen und Fakten. Dies zeigt, dass das Modell beginnt, sich an Inhalte aus dem Datensatz zu erinnern.

## Kommende Pläne


- Es gibt fast 175.000 Texte, die zwischen 1800-1875 in London veröffentlicht wurden und im Internet Archive verfügbar sind
- Ich plane, das Korpus zu erweitern und weiter zu bereinigen, um bessere Schlussfolgerungsfähigkeiten zu ermöglichen
- Erweiterung auf verschiedene Regionen und Zeiträume für historischere Modelle


## Verwendung

Dieses Projekt konzentriert sich hauptsächlich auf die Kuratierung historischer Daten, deren Vorbereitung für das Training und den Aufbau eines Tokenizers. Ich werde nicht den vollständigen LLM-Trainingsprozess abdecken, dafür siehe nanoGPT von Andrej Karpathy.

### Schritt 1: Historische Texte sammeln und vorbereiten

- Sammle .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus deinem gewählten Zeitraum (z. B. London 1800-1850)
- Halte dich an das gewählte Zeit-/Ortsfenster
- Bereinige die Textdateien mit einem Skript oder entferne manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder Fehler wie OCR-Fehler.

### Schritt 2: Eigenen Tokenizer bauen

- Starte train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten.
- Dies liefert dir vocab.json und merges.txt
- Diese Dateien definieren Vokabular und Zusammenführungsregeln für dein Modell

### Schritt 3: Trainiere dein Modell

- Siehe [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) für den Trainingsprozess oder die Dokumentation deiner gewählten Architektur.

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine Machine-Learning-Methodik, bei der alle Trainingsdaten gezielt so ausgewählt werden, dass sie aus einem bestimmten historischen Zeitraum stammen. Dies dient dazu, die Sprache und das Wissen jener Ära zu modellieren, ohne von modernen Konzepten beeinflusst zu werden. Zum Beispiel: Das aktuelle Modell (v0.5) wurde ausschließlich mit Daten von 1800-1875 trainiert, nicht feinabgestimmt, sondern von Grund auf, wodurch die Ausgabe den Sprachstil und historischen Kontext jener Zeit widerspiegelt.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu erstellen, das nicht von modernem Bias beeinflusst ist. Wenn ich etwa GPT-2 feinabstimme, ist es bereits vortrainiert und diese Information verschwindet nicht. Wenn ich von Grund auf trainiere, tut das Sprachmodell nicht so, als wäre es alt – es ist es einfach. Das Ziel dieses Projekts ist aktuell, etwas zu erschaffen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1875 schlussfolgern kann.

## Welche Daten wurden für das Training verwendet?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1875. Die von mir verlinkte Liste (für v0) enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt ca. 187 MB verwendet. Eine Liste der Dokumente findest du hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datensatzgrößen:
v0: ~187MB
v0.5: ~435MB
v1: ~6,25GB

## Wie groß sind die Modelle?

V0: 16M Parameter

V0.5: 123M Parameter

V1: 700M Parameter

# Trainingsspezifikationen?

# V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
Ram: 16GB DDR5.

# V1
GPU: A100 gemietet














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---