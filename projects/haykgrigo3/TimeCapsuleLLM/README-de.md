<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Ein Sprachmodell, das **von Grund auf** ausschließlich mit Daten aus bestimmten Orten und Zeitperioden trainiert wurde, um moderne Verzerrungen zu minimieren und die Stimme, den Wortschatz und die Weltanschauung der jeweiligen Epoche nachzuahmen.*

Stellen Sie sich vor, ein KI-Modell würde nicht nur so tun, als wäre es historisch, sondern wäre es wirklich.

v0 und v0.5 basieren auf [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT). Die Kern-Trainingsskripte und die Modellarchitektur sind sein Werk.

v1 basiert auf [Phi 1.5 von Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 basiert auf llamaforcausallm

[Hugging Face Link](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Modellverhalten & Einschränkungen

### **v0**  

Frühe Prompts zeigen, dass das Modell mit Sprache und Verhalten aus dem 19. Jahrhundert antwortet.
Beispiel: Prompt: "Who art Henry?" und es antwortete: "I know that man, I have did not a black, the storm." 

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Keine Erwähnung moderner Konzepte  
- Meistens epochengetreues Vokabular  
- Sätze sind größtenteils unzusammenhängend (erwartet bei ~187MB Trainingsdaten)

### **v0.5** 

Eine deutliche Verbesserung gegenüber v0.  
- Viktorianischer Schreibstil, korrekte Zeichensetzung, meist grammatikalisch richtige Sätze  
- Immer noch hohe Rate an faktischen Halluzinationen  
- OCR-Rauschen („Digitized by Google“) weiterhin in Ausgaben vorhanden

![TimeLockLLM Beispielausgabe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Erstes Modell, das ein echtes historisches Ereignis mit einer tatsächlichen Figur aus dem Datensatz verknüpft.

Beispiel: Prompt: "It was the year of our Lord 1834" 

Die Ausgabe: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Zunächst nahm ich an, dass ein Protest zufällig im selben Jahr stattfand, aber sehen Sie sich das an: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Trainiert mit einer 15GB großen Stichprobe aus dem 90GB-Datensatz von v2.
Modell nur bis zu 10.000 Schritten trainiert.

Es gab ein Problem mit der Tokenisierung, das dazu führt, dass die Ausgabe so aussieht:

PROMPT:
Wer ist Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Korrigiert:

"Wer ist Charles Dickens? Wirkt das mehr von seinem ausgezeichneten, bewegenden Schaffen, in seinen Theaterstücken, auf dem Hof der Großen Gesellschaft? Was habe ich noch von Jack Pickett zu zitieren? Wissen Sie nicht, dass sie eine Art von Galoppieren waren, oder Sägen ihrer Brust, oder was in der Zeit zu tun war, als Jackson am Fenster stand? Was ist der Erfolg eines Engländers, und was hat sein Sohn mir noch nicht entdeckt, wodurch ein solches Gewicht erreicht werden kann? Haben Sie jemals einen Durchgang auf die alte Straße gemacht, oder zu einer Ankerbrise am Fuß unseres Bootes, die Sie uns verlassen müssen? Tatsache ist, dass unabhängig davon, ob der Wind am Samstagabend oder am Mittag vom Feld aufsteigt oder nach Norden zieht, oder anders, wir gezwungen sein werden, eine gewaltige Barriere zu beschreiben, mit denselben Auswirkungen wie derzeit. In dieser Situation ist es zumindest nicht zu viel zu sagen, dass wir diesen Raum verlassen haben. Ich glaube, es gibt drei Exemplare im 'Fünfhundertfachen', auf die verwiesen werden kann, als die erste Nummer unserer Leser, die t[o]..."

### **v2mini-eval2**

Trainiert mit demselben 15GB Sample, das für die Schulung von eval1 verwendet wurde.
Das Modell wurde erneut nur bis zu 10.000 Schritten trainiert.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Sehr geehrter Herr, — Der folgende Fall ist für mich interessant: — Ich war zwei Wochen in London und litt stark unter einem Rheumaanfall. Der erste Rheumaanfall war eine Woche bevor ich Sie sah, und der zweite als ich Sie sah, und der dritte als ich Sie sah, und der dritte zur gleichen Zeit. Der zweite Gichtanfall war jedoch nicht von Fiebersymptomen begleitet, sondern ging mit erhöhter Urinausscheidung und einer reichlicheren Entleerung einher. Der dritte Anfall trat eine Stunde nach unserem Treffen auf und wurde von einer Rückkehr eines Gichtanfalls und einer rascheren Wiederkehr der Gicht gefolgt. Der vierte Anfall ging ebenfalls mit Fieber einher, jedoch nicht immer mit Fiebersymptomen. Der dritte Gichtanfall war zwei Wochen nach Ihrer Erkrankung, und der vierte wurde von einem Gichtanfall gefolgt. Der vierte Anfall war zwei Wochen nach Ihrem Angriff und ging mit einem Gefühl einher


##  Datensätze

### **v2**

- 90GB an London-Texten von 1800-1875
- 136.344 Dokumente
- Das vollständige 90GB-Datenset ist noch nicht verfügbar, da es noch nicht tokenisiert ist, aber eine 15GB-Probe finden Sie hier: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Bias-Statistiken 
  ![Pronomen-Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Geografischer Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zeitlicher Bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Weitere Informationen finden Sie im [v2 Bias Report](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json).


## Verwendung

Dieses Projekt konzentriert sich hauptsächlich auf die Zusammenstellung historischer Daten, deren Aufbereitung für das Training und den Bau eines Tokenizers. Der vollständige LLM-Trainingsprozess wird hier nicht behandelt, dafür verweise ich auf nanoGPT von Andrej Karpathy.

### Schritt 1: Sammeln und Vorbereiten historischer Texte 

- Sammeln Sie .txt-Dateien von gemeinfreien Büchern, Dokumenten usw. aus Ihrer gewählten Zeitperiode (z.B. London 1800-1850) 
- Halten Sie sie innerhalb Ihres gewählten Zeit-/Ortsfensters  
- Bereinigen Sie die Textdateien mit einem Skript oder entfernen Sie manuell Kopf-/Fußzeilen von Project Gutenberg, moderne Anmerkungen oder Dinge wie OCR-Fehler.

### Schritt 2: Eigener Tokenizer bauen

- Führen Sie train_tokenizer.py oder train_tokenizer_hf.py auf den bereinigten Daten aus.
- Das ergibt vocab.json und merges.txt
- Diese Dateien definieren Vokabular und Merge-Regeln für Ihr Modell

### Schritt 3: Trainieren Sie Ihr Modell 

- Orientieren Sie sich für den Trainingsprozess an [nanoGPT von Andrej Karpathy](https://github.com/karpathy/nanoGPT) oder an den Dokumentationen Ihrer gewählten Architektur.

# FAQ

## Was ist Selective Temporal Training?

Selective Temporal Training (STT) ist eine Machine-Learning-Methodik, bei der alle Trainingsdaten gezielt so ausgewählt werden, dass sie in einen bestimmten historischen Zeitraum fallen. Dies geschieht, um die Sprache und das Wissen jener Epoche ohne Einfluss moderner Konzepte zu modellieren. Zum Beispiel ist das aktuelle Modell (v0.5) ausschließlich mit Daten von 1800–1875 trainiert, es ist nicht feinabgestimmt, sondern von Grund auf neu trainiert, sodass die Ausgabe den Sprachstil und historischen Kontext dieser Zeit widerspiegelt.

## Warum nicht einfach Fine-Tuning oder LoRA verwenden?

Für dieses Projekt versuche ich, ein Sprachmodell zu erstellen, das nicht von modernen Verzerrungen beeinflusst ist. Wenn ich z. B. GPT-2 feinabstimme, ist es bereits vortrainiert und diese Informationen verschwinden nicht. Wenn ich von Grund auf neu trainiere, tut das Sprachmodell nicht so, als wäre es alt, sondern es ist es einfach. Das Ziel für dieses Projekt ist derzeit, etwas zu schaffen, das ausschließlich mit Wissen aus Londoner Büchern, die zwischen 1800 und 1875 erschienen sind, argumentieren kann.

## Welche Art von Daten wurde für das Training verwendet?

Ich verwende Bücher, Rechtsdokumente, Zeitungen und andere Schriften aus London von 1800–1875. Die von mir verlinkte Liste (für v0) enthält etwa 200, aber für das erste Training habe ich nur 50 Dateien mit insgesamt ca. 187 MB verwendet. Eine Liste der Dokumente finden Sie hier:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Datensatzgrößen:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6,25GB 
- v2mini-eval1: 15GB

## Wie groß sind die Modelle?

v0: 16M Parameter

v0.5 123M Parameter

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented






























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---