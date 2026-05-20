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

## Tritt dem Vintage LLM Discord bei

Wenn du dich für **historische Sprachmodelle**, **zeitlich spezifische Datensätze** oder die Zukunft von Projekten wie **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** interessierst, dann werde Teil der Community.

Wir nutzen den Server, um Ideen zu besprechen, Fortschritte zu teilen und uns mit anderen Entwicklern in diesem Bereich zu vernetzen.

[Tritt dem Discord bei](https://discord.gg/JeWkk4z5)

##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er Jahre antwortet.
Beispiel: Prompt: "Who art Henry?" und es antwortete: "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens zeittypischer Wortschatz  
- Sätze sind größtenteils unzusammenhängend (erwartet bei ~187MB Trainingsdaten)

### **v0.5-london** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, richtige Zeichensetzung, größtenteils grammatikalisch korrekte Sätze  
- Immer noch hohe Rate faktischer Halluzinationen  
- OCR-Rauschen („Digitized by Google“) weiterhin in den Ausgaben vorhanden

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Erstes Modell, das ein reales historisches Ereignis mit einer tatsächlichen Person aus dem Datensatz verbinden und abrufen kann.

Beispiel: Prompt: "It was the year of our Lord 1834" 

Die Ausgabe: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Zuerst nahm ich an, dass ein Protest zufällig im selben Jahr stattfand, aber sieh dir das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Trainiert mit einer 15GB-Stichprobe aus dem 90GB-Datensatz von v2.
Modell wurde nur bis 10.000 Schritte trainiert.

Es gab ein Problem bei der Tokenisierung, das dazu führt, dass die Ausgabe so aussieht:

EINGABE:
Wer ist Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Korrigiert:

"Wer ist Charles Dickens? Wirkt das mehr von seiner ausgezeichneten bewegenden Art in seinen Theaterstücken, auf der Farm der Großen Gesellschaft? Was habe ich noch von Jack Pickett zu zitieren? Weißt du nicht, dass sie eine Art galoppierender Bewegung waren, oder das Sägen ihrer Brust, oder was in der Zeit zu tun war, als Jackson am Fenster zusah? Was ist der Erfolg eines Engländers, und welchen sein Sohn mir noch nicht offenbart hat, um solch ein Gewicht zu erreichen? Hast du jemals einen Durchgang auf die alte Straße gemacht oder eine Ankerbrise am Fuß unseres Bootes erlebt, die du verlassen musst? Tatsache ist, dass, ob der Wind am Samstagabend oder am Mittag vom Feld aufsteigt, oder gen Norden oder anderswo, wir gezwungen sein werden, eine gewaltige Barriere zu beschreiben, mit denselben Auswirkungen wie heute. In dieser Situation ist es zumindest nicht zu viel zu sagen, dass wir diesen Raum verlassen haben. Ich glaube, es gibt drei Kopien im 'Fünfhundertfachen', auf die verwiesen werden kann, als die ersten Nummern unserer Leser, die t[o]..."

### **v2mini-eval2-london**

Trainiert mit demselben 15GB Sample wie eval1.
Das Modell wurde erneut nur auf 10.000 Schritte trainiert.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Sir, — Der folgende Fall ist für mich interessant: — Ich war zwei Wochen in London und wurde sehr von einem Rheumaanfall betroffen. Der erste Rheumaanfall war eine Woche bevor ich Sie sah, der zweite als ich Sie sah, und der dritte ebenfalls als ich Sie sah, und der dritte zur gleichen Zeit. Der zweite Gichtanfall war jedoch nicht von fieberhaften Symptomen begleitet, sondern ging mit einem erhöhten Harnfluss und einer reichlicheren Harnentleerung einher. Der dritte Anfall war eine Stunde nachdem ich Sie sah und wurde von einer Rückkehr eines Gichtanfalls gefolgt, sowie einer schnelleren Rückkehr der Gicht. Der vierte Anfall war ebenfalls von einem Fieber begleitet, jedoch nicht immer von fieberhaften Symptomen. Der dritte Gichtanfall war zwei Wochen nachdem Sie krank gewesen waren, und der vierte wurde von einem Gichtanfall gefolgt. Der vierte Anfall war zwei Wochen nachdem Sie angegriffen wurden und war begleitet von einem Gefühl

### **v2-london**

Trainiert mit einem 90GB (112GB tokenisierten) Datensatz
Trainiert auf 182.000 Schritte

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Was kommt als Nächstes?**

- Entwicklung von TimeCapsuleLLM v3 hat begonnen
- Skalierung der Datensatzgröße und geografischen Abdeckung
- Erweiterung über London hinaus auf weitere Städte

Die Arbeit wird in Zusammenarbeit mit Forschern des University College London (UCL) durchgeführt und zusätzliche institutionelle Beteiligung wird diskutiert.


##  Datensätze

### **v2**

- 90GB (Rohdaten) London-Texte von 1800-1875
- 136.344 Dokumente
- Der vollständige tokenisierte Datensatz ist jetzt hier verfügbar: https://huggingface.co/datasets/postgrammar/london-llm-1800

### Bias-Statistiken
  ![Pronomen-Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Geografischer Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zeitlicher Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Weitere Informationen finden Sie im [v2 Bias-Bericht](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json).


-


## Anwendungshinweise

Dieses Projekt konzentriert sich hauptsächlich auf die Sammlung historischer Daten, deren Aufbereitung für das Training und den Aufbau eines Tokenizers. Der vollständige LLM-Trainingsprozess wird hier nicht behandelt; hierzu siehe nanoGPT von Andrej Karpathy.

### Schritt 1: Historische Texte sammeln und vorbereiten

- Sammeln Sie .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus Ihrem gewählten Zeitraum (z. B. London 1800-1875)
- Bleiben Sie innerhalb Ihres gewählten Zeit-/Ortsfensters
- Bereinigen Sie die Textdateien mithilfe eines Skripts oder entfernen Sie manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

### Schritt 2: Eigene Tokenizer erstellen

- Führen Sie train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
- Dadurch erhalten Sie vocab.json und merges.txt
- Diese Dateien definieren Vokabular und Merge-Regeln für Ihr Modell

### Schritt 3: Modell trainieren

- Den Trainingsprozess finden Sie bei [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) oder in der Dokumentation Ihrer gewählten Architektur.

# FAQ

## Was ist Selektives Temporales Training?

Selektives Temporales Training (STT) ist eine Methode im maschinellen Lernen, bei der alle Trainingsdaten gezielt so ausgewählt werden, dass sie in einen bestimmten historischen Zeitraum fallen. Ziel ist es, die Sprache und das Wissen jener Epoche ohne Einfluss moderner Konzepte zu modellieren. Zum Beispiel wurde das aktuelle Modell (v0.5) ausschließlich mit Daten aus 1800-1875 trainiert, es wurde nicht feinjustiert, sondern von Grund auf neu trainiert, sodass der Output den Sprachstil und den historischen Kontext dieser Zeit widerspiegelt.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu erstellen, das frei von modernen Vorurteilen ist. Wenn ich etwas wie GPT-2 feinabstimme, ist es bereits vortrainiert und diese Informationen werden nicht verschwinden. Wenn ich das Sprachmodell von Grund auf trainiere, wird es nicht so tun, als wäre es alt, sondern es wird es einfach sein. Das Ziel dieses Projekts ist es derzeit, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern aus den Jahren 1800 bis 1875 argumentieren kann.

## Welche Art von Daten hast du für das Training verwendet?

Ich verwende Bücher, Rechtsdokumente, Zeitungen und andere Schriften aus dem London der Jahre 1800–1875. Die verlinkte Liste (für v0) umfasst etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt ~187 MB verwendet. Eine Liste der Dokumente findest du hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datensatzgrößen:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6,25GB
- v2mini-eval1: 15GB (Auszug aus v2's 90GB)
- v2: 90GB

## Wie groß sind die Modelle?

v0: 16M Parameter

v0.5: 123M Parameter

v1: 700M Parameter

v2mini-eval1: 300M Parameter

v2mini-eval2: 200M Parameter

v2: 1,2B Parameter

## Trainingsspezifikationen?

### v0/v0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5.

### v1
GPU: A100 SXM gemietet

### v2mini-eval1/eval2
GPU: A100 SXM gemietet

### v2
GPU: H100 SXM gemietet

## Verwandte Arbeiten

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B Parameter LLM, trainiert mit 260B Token Texten vor 1930 mit Q&A. Es gibt auch eine [Basisversion](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1,4B Parameter LLM, trainiert mit Texten von 1800-1899 mit Q&A. Es gibt auch eine [160M](https://huggingface.co/zakarth/violet-160m-chat) Version.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M Parameter LLM, trainiert mit über 28.000 Texten zwischen 1837-1899 mit Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - eine Familie von 4B Parameter LLMs basierend auf der Qwen3 Architektur, von Grund auf mit 80B historischen Token bis zu den Wissensstichtagen 1913,1929,1933,1939,1946 trainiert.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT ist ein Feintuning von Mistral-Hermes 2 auf 11.000 frühneuzeitlichen Texten in Englisch, Französisch und Latein, hauptsächlich aus EEBO und Gallica.

## Danksagungen

Ich danke [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) für die akademische Betreuung, Unterstützung bei der Forschungsrahmung und Evaluation sowie Hilfe beim Training des Tokenizers und der Datenvorbereitung für das v2 Release. Sein Feedback und seine Erfahrung waren maßgeblich für die Verbesserung der Präsentation dieser Arbeit.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---