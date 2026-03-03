<div align="right">
  <details>
<summary>🌐 Sprache</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)

</details>
</div>


# TimeCapsule LLM

*Ein Sprachmodell, das **von Grund auf** ausschließlich mit Daten aus bestimmten Orten und Zeitperioden trainiert wurde, um moderne Voreingenommenheit zu reduzieren und die Stimme, das Vokabular und die Weltanschauung der jeweiligen Ära nachzuahmen.*

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern wäre es tatsächlich.

v0 und v0.5 basieren auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die Kern-Trainingsskripte und die Modellarchitektur stammen von ihm.

v1 basiert auf [Phi 1.5 von Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basiert auf llamaforcausallm

[Hugging Face Link](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Stand der Forschung
Dieses Projekt wurde unabhängig initiiert und entwickelt.

Derzeit wird es unter akademischer Aufsicht durchgeführt, mit einer zugehörigen Forschungskooperation am Muhlenberg College.

## Zitieren

Wenn Sie diesen Datensatz oder das Modell in wissenschaftlichen Arbeiten verwenden, zitieren Sie bitte:

```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten aus dem 19. Jahrhundert antwortet.
Beispiel: Prompt: "Who art Henry?" und es antwortete: "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens zeitgemäßer Wortschatz  
- Sätze sind größtenteils unzusammenhängend (erwartet bei ~187MB Trainingsdaten)

### **v0.5** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, richtige Zeichensetzung, meist grammatikalisch korrekte Sätze  
- Immer noch hohe Rate an faktischen Halluzinationen  
- OCR-Rauschen („Digitized by Google“) weiterhin in den Ausgaben vorhanden

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Erstes Modell, das ein reales historisches Ereignis mit einer tatsächlichen Figur aus dem Datensatz verbindet und erinnert.

Beispiel: Prompt: "It was the year of our Lord 1834"

Die Ausgabe: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

Zunächst nahm ich an, dass zufällig im selben Jahr ein Protest stattfand, aber sehen Sie sich das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Trainiert mit einer 15GB-Probe aus dem 90GB-Datensatz von v2.
Modell wurde nur bis 10K Schritte trainiert.

Es gab ein Problem mit der Tokenisierung, das dazu führt, dass die Ausgabe so aussieht:

Wer ist Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Korrigiert:

"Wer ist Charles Dickens? Wirkt sich das mehr auf seine hervorragenden bewegenden Werke aus, in seinen Theaterstücken, auf der Farm der Great Company? Was habe ich noch von Jack Pickett zu zitieren? Weißt du nicht, dass sie eine Art Galoppieren waren, oder das Sägen ihrer Brust, oder was zu tun war zu der Zeit, als Jackson aus dem Fenster sah? Was ist der Erfolg eines Engländers, und was hat sein Sohn mir noch nicht offenbart, um solch ein Gewicht zu erreichen? Hast du jemals einen Durchgang auf die alte Fahrbahn gemacht, oder zu einer Ankerbrise am Fuß unseres Bootes, das du uns verlassen musst? Tatsache ist, dass, ob der Wind am Samstagabend oder mittags von der Ebene aufsteigen würde, oder bis zum Norden oder anders, wir gezwungen sein werden, eine gewaltige Barriere zu beschreiben, mit denselben Auswirkungen wie die gegenwärtige. In dieser Situation ist es zumindest nicht zu viel zu sagen, dass wir diesen Raum verlassen haben. Ich glaube, es gibt drei Exemplare im 'Fünfhundertfachen', auf die zu verweisen ist, als die erste Nummer unserer Leser, die w[u]nsch[t]...“

### **v2mini-eval2**

Trainiert mit denselben 15GB Beispieldaten wie eval1.
Das Modell wurde wieder nur bis 10K Schritte trainiert.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Sir, – Folgender Fall ist für mich interessant: – Ich war zwei Wochen in London und wurde stark von einem Rheumaanfall betroffen. Der erste Rheumaanfall war eine Woche, bevor ich Sie sah, und der zweite, als ich Sie sah, und der dritte, als ich Sie sah, und der dritte zur gleichen Zeit. Der zweite Gichtanfall war jedoch nicht von fieberhaften Symptomen begleitet, sondern von einem erhöhten Harnfluss und einer reichlicheren Urinausscheidung. Der dritte Anfall war eine Stunde, nachdem ich Sie sah, und wurde von einer Rückkehr eines Gichtanfalls und einer schnelleren Rückkehr der Gicht gefolgt. Der vierte Anfall war ebenfalls mit Fieber verbunden, aber nicht immer mit fieberhaften Symptomen. Der dritte Gichtanfall war zwei Wochen, nachdem Sie krank gewesen waren, und der vierte wurde von einem Gichtanfall gefolgt. Der vierte Anfall war zwei Wochen nach Ihrem Angriff und war begleitet von einem Gefühl

### **v2**

Trainiert mit einem 90GB (112GB tokenisierten) Datensatz
Trainiert bis 182K Schritte

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Datensätze

### **v2**

- 90GB (Rohdaten) von London-Texten aus den Jahren 1800-1875
- 136.344 Dokumente
- Der vollständige tokenisierte Datensatz ist jetzt hier verfügbar: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Bias-Statistiken 
  ![Pronomen-Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Geografischer Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zeitlicher Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Siehe [v2 Bias-Bericht](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) für weitere Informationen.


## Verwendung

Dieses Projekt konzentriert sich hauptsächlich auf die Zusammenstellung historischer Daten, deren Vorbereitung für das Training und den Aufbau eines Tokenizers. Ich werde den vollständigen LLM-Trainingsprozess nicht abdecken; dafür verweise ich auf nanoGPT von Andrej Karpathy.

### Schritt 1: Historische Texte sammeln und vorbereiten

- Sammeln Sie .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus Ihrem gewählten Zeitraum (z.B. London 1800-1850)
- Halten Sie sich an Ihr ausgewähltes Zeit-/Ortsfenster  
- Säubern Sie die Textdateien mit einem Skript oder entfernen Sie manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

### Schritt 2: Einen eigenen Tokenizer bauen

- Führen Sie train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
- Dadurch erhalten Sie vocab.json und merges.txt
- Diese Dateien definieren Vokabular und Zusammenführungsregeln für Ihr Modell

### Schritt 3: Ihr Modell trainieren

- Für den Trainingsprozess oder die Dokumentation Ihrer gewählten Architektur verweisen Sie auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT).

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine Methode des maschinellen Lernens, bei der alle Trainingsdaten gezielt so kuratiert werden, dass sie in einen bestimmten historischen Zeitraum fallen. Dies geschieht, um die Sprache und das Wissen jener Epoche ohne Einfluss moderner Konzepte zu modellieren. Zum Beispiel wurde das aktuelle Modell (v0.5) ausschließlich mit Daten von 1800-1875 trainiert, nicht feinjustiert, sondern von Grund auf, was zu Ausgaben führt, die den Sprachstil und historischen Kontext jener Zeit widerspiegeln.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu schaffen, das nicht von modernem Bias beeinflusst ist. Wenn ich etwas wie GPT-2 feinjustiere, ist es bereits vortrainiert und diese Informationen verschwinden nicht. Wenn ich von Grund auf trainiere, wird das Sprachmodell nicht so tun, als wäre es alt, sondern es wird es tatsächlich sein. Das Ziel für dieses Projekt ist derzeit, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern von 1800 bis 1875 argumentieren kann.

## Welche Art von Daten haben Sie für das Training verwendet?

Ich verwende Bücher, juristische Dokumente, Zeitungen und andere Schriften aus London von 1800–1875. Die verlinkte Liste (für v0) enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit ca. 187 MB verwendet. Eine Liste der Dokumente finden Sie hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datensatzgrößen:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6,25GB 
- v2mini-eval1: 15GB (aus v2's 90GB entnommen)
- v2: 90GB

## Wie groß sind die Modelle?

v0: 16M Parameter

v0.5 123M Parameter

v1: 700M Parameter

v2mini-eval1: 300M Parameter

v2mini-eval2: 200M Parameter

v2: 1,2B Parameter

## Trainingsspezifikationen?

### v0/v0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
Ram: 16GB DDR5.

### v1
GPU: A100 SXM gemietet

### v2mini-eval1/eval2
GPU: A100 SXM gemietet

### v2
GPU: H100 SXM gemietet

## Danksagungen

Ich möchte [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) für die akademische Betreuung, Unterstützung bei der Forschungsrahmung und -bewertung sowie für Hilfe beim Tokenizer-Training und der Datenvorbereitung für den v2-Release danken. Sein Feedback und seine Erfahrung waren entscheidend für die Verbesserung der Präsentation dieser Arbeit.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---