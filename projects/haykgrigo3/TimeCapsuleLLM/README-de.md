<div align="right">
  <details>
<summary>🌐 Sprache</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)

</details>
</div>


# TimeCapsule LLM

*Ein Sprachmodell, das **von Grund auf** ausschließlich mit Daten aus bestimmten Orten und Zeitperioden trainiert wurde, um moderne Verzerrungen zu reduzieren und die Stimme, das Vokabular und die Weltanschauung der jeweiligen Ära nachzuahmen.*

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern wäre es tatsächlich.

v0 und v0.5 basieren auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die grundlegenden Trainingsskripte und die Modellarchitektur stammen von ihm.

v1 basiert auf [Phi 1.5 von Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basiert auf llamaforcausallm

[Hugging Face Link](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Forschungsstatus
Dieses Projekt wurde unabhängig initiiert und entwickelt.

Es wird derzeit unter akademischer Aufsicht durchgeführt, mit einer verbundenen Forschungskooperation am Muhlenberg College & Georgia State University.

## Zitation

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

## Trete dem Vintage LLM Discord bei

Wenn du dich für **historische Sprachmodelle**, **zeitlich spezifische Datensätze** oder die Zukunft von Projekten wie **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** interessierst, dann werde Teil unserer Community.

Wir nutzen den Server, um Ideen zu diskutieren, Fortschritte zu teilen und uns mit anderen auszutauschen, die in diesem Bereich aktiv sind.

[Tritt dem Discord bei](https://discord.gg/JeWkk4z5)

## Sponsoren

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

Vielen Dank an DolOffer für die Unterstützung dieses Projekts!

DolOffer ist eine Plattform, die sich auf Empfehlungen für digitale Produkte und das Teilen von Rabatten konzentriert, sodass Nutzer schnell empfehlenswerte Tools, Services und zeitlich begrenzte Angebote entdecken können. Die Plattform bietet eine Vielzahl beliebter Abonnementdienste, darunter YouTube Premium, Claude, ChatGPT Plus, Spotify und Apple Music, zu Preisen von bis zu 30 % des offiziellen Preises oder sogar noch günstiger.

Registriere dich jetzt über diesen exklusiven Link [doloffer](https://doloffer.com/en/) und gib beim Aufladen den Promo-Code AI8888 ein, um einen zusätzlichen 10% Rabatt zu erhalten.

##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten der 1800er Jahre antwortet. 
Beispiel: Prompt: "Who art Henry?" und es antwortete: "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens zeittypischer Wortschatz  
- Sätze sind meist unzusammenhängend (zu erwarten bei ~187MB Trainingsdaten)

### **v0.5-london** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, korrekte Zeichensetzung, überwiegend grammatikalisch korrekte Sätze  
- Immer noch hohe Rate an faktuellen Halluzinationen  
- OCR-Rauschen („Digitalisiert von Google“) ist weiterhin in den Ausgaben vorhanden

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Erstes Modell, das ein reales historisches Ereignis mit einer tatsächlichen Figur aus dem Datensatz verknüpfen und erinnern kann.

Beispiel: Prompt: „Es war das Jahr des Herrn 1834“

Die Ausgabe: „Es war das Jahr des Herrn 1834 und die Straßen Londons waren voller Protest und Petition. Die Ursache, wie viele berichteten, war nicht privater Natur, sondern wurde am selben Tag im Haus von Lord Palmerston aufgenommen, die Öffentlichkeit erhält eine kurze Darstellung der Schwierigkeiten, unter denen das Recht uns erreicht hat. Es ist sehr bedauerlich, dass die aktuellen Ereignisse in der Geschichte der Welt klar sind und folglich bekannt werden. Es ist nicht wahr, dass gerade die Männer, die zuerst das Evangelium in Jerusalem verkündeten, eine so umfassende und interessante Aufzeichnung von Wohlstand und Wohlstand haben sollten“

Zunächst nahm ich an, dass ein Protest zufällig im selben Jahr stattgefunden haben könnte, aber sehen Sie sich das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Trainiert mit einer 15GB-Stichprobe aus dem 90GB-Datensatz von v2.
Modell wurde nur auf 10.000 Schritte trainiert.

Es gab ein Problem mit der Tokenisierung, das dazu führt, dass die Ausgabe so aussieht:

PROMPT:
Wer ist Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Korrigiert:

"Wer ist Charles Dickens? Wirkt sich das mehr auf seine hervorragende Erregung in seinen Theaterstücken, auf der Farm der Großen Gesellschaft aus? Was habe ich noch von Jack Pickett zu zitieren? Weißt du nicht, dass sie eine Art Galoppieren waren, oder das Sägen ihrer Brust, oder was zu tun war zu der Zeit, als Jackson aus dem Fenster schaute? Was ist der Erfolg eines Engländers, und was hat sein Sohn mir noch nicht offenbart, um solch ein Gewicht zu erreichen? Hast du jemals einen Übergang auf die alte Fahrbahn gemacht, oder zu einer Ankerbrise am Fuß unseres Bootes, das du uns verlassen musst? Tatsache ist, dass wir, ob der Wind nun am Samstagabend oder mittags oder bis zum Norden oder anderswo von der Ebene aufsteigt, gezwungen sein werden, eine gewaltige Barriere zu beschreiben, mit den gleichen Auswirkungen wie jetzt. In dieser Situation ist es zumindest nicht übertrieben zu sagen, dass wir diesen Raum verlassen haben. Ich glaube, es gibt drei Exemplare im 'Fünfhundertfachen', auf die verwiesen werden kann, als die ersten Leser, die w...”

### **v2mini-eval2-london**

Trainiert mit demselben 15GB Sample wie eval1.
Das Modell wurde erneut nur auf 10K Schritte trainiert.

PROMPT: Charles Darwin

Charles DarwinECCEMACY. Sir, — Der folgende Fall ist für mich interessant: — Ich war zwei Wochen in London und war sehr betroffen von einem Rheumaanfall. Der erste Rheumaanfall war eine Woche, bevor ich Sie sah, und der zweite, als ich Sie sah, und der dritte, als ich Sie sah, und der dritte zur gleichen Zeit. Der zweite Gichtanfall war jedoch nicht mit irgendwelchen Fiebersymptomen verbunden, sondern mit einem erhöhten Urinfluss und einer reichlicheren Urinausscheidung. Der dritte Anfall war eine Stunde, nachdem ich Sie gesehen hatte, und wurde von einem erneuten Gichtanfall gefolgt, mit schnellerem Wiederauftreten der Gicht. Der vierte Anfall war ebenfalls mit Fieber verbunden, aber nicht immer mit Fiebersymptomen. Der dritte Gichtanfall war zwei Wochen, nachdem Sie krank waren, und der vierte wurde von einem erneuten Gichtanfall gefolgt. Der vierte Anfall war zwei Wochen nach Ihrem Anfall und war begleitet von einem Gefühl

### **v2-london**

Trainiert mit einem 90GB (112GB tokenisiert) Datensatz
Trainiert bis 182K Schritte

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Was kommt als Nächstes?**

- Entwicklung von TimeCapsuleLLM v3 hat begonnen
- Skalierung der Datensatzgröße und geografischen Abdeckung
- Erweiterung über London hinaus auf weitere Städte

Die Arbeit wird in Zusammenarbeit mit Forschern des Muhlenberg College & der Georgia State University durchgeführt.


## Datensätze

### **v2**

- 90GB (roh) an London-Texten von 1800-1875
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
  -  13B Parameter LLM, trainiert auf 260B Token Texten vor 1930 mit Q&A. Es gibt auch eine [Basisversion](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B Parameter LLM, trainiert auf Texten von 1800-1899 mit Q&A. Es gibt auch eine [160M](https://huggingface.co/zakarth/violet-160m-chat) Version.
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M Parameter LLM, trainiert auf über 28.000 Texten zwischen 1837-1899 mit Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Eine Familie von 4B Parameter LLMs, basierend auf der Qwen3-Architektur, von Grund auf trainiert auf 80B Token historischen Daten bis zu den Wissensstichtagen 1913,1929,1933,1939,1946.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - Ein 7,24B History Language Model (LM), ausschließlich vor 1913 auf englischen Texten vortrainiert. Erstellt von Forschern der University of Waterloo, Adelaide University, University of Oxford und University College London. [Link zum Paper](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT ist ein Finetune von Mistral-Hermes 2 auf 11.000 frühneuzeitlichen Texten in Englisch, Französisch und Latein, hauptsächlich aus EEBO und Gallica.

## Danksagungen

Ich möchte [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) für die akademische Betreuung, Unterstützung bei der Forschungsrahmung und Evaluation sowie für Hilfe beim Tokenizer-Training und der Datenaufbereitung für das v2-Release danken. Sein Feedback und seine Erfahrung waren maßgeblich bei der Verfeinerung der Präsentation dieser Arbeit.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---