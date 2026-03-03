<div align="right">
  <details>
<summary>🌐 Language</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)

</details>
</div>


# TimeCapsule LLM

*A language model trained **from scratch** exclusively on data from certain places and time periods to reduce modern bias and emulate the voice, vocabulary, and worldview of the era.*

Imagine if an AI model didn't just pretend to be historical but actually was.

v0 and v0.5 built on [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) Core training scripts and model architecture are his work. 

v1 built on [Phi 1.5 by Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 built on llamaforcausallm

[Hugging Face Link](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Research Status
This project was initiated and developed independently.

It is currently conducted under academic supervision, with an affiliated research collaboration at Muhlenberg College.

## Citation

If you use this dataset or model in academic work, please cite:

```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Model Behavior & Limitations

### **v0**  

Early prompts show the model responding with 1800's language and behavior. 
Example: Prompt: "Who art Henry?" and it replied "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- No mention of modern concepts  
- Mostly era-accurate vocabulary  
- Sentences are mostly incoherent (expected for ~187MB training data)

### **v0.5** 

A significant improvement over v0.  
- Victorian writing style, proper punctuation, mostly grammatical sentences  
- Still high factual hallucination rate  
- OCR noise (“Digitized by Google”) still present in outputs

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

First model to recall and connect a real historical event with an actual figure from the dataset.

Example: Prompt: "It was the year of our Lord 1834" 

The output: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

At first I assumed that a protest might have coincidentally taken place the same year but take a look at this: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Trained using a 15GB sample from v2's 90GB dataset.
Model trained to 10K steps only.

There was an issue with tokenization that causes output to look like this:

Charles Dickens was a famous English writer and social critic.
He is best known for his novels such as "Oliver Twist," "A Christmas Carol," and "Great Expectations."
His works often depicted the struggles of the poor and criticized social injustices of Victorian England.
Dickens remains one of the most influential authors in English literature.
W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Corrected:

"Who is Charles Dickens? Is his stirring excellence more evident in his plays or in the Great Company's farm? What have I yet to quote from Jack Pickett? Are you not aware that they were a kind of galloping, or sawing of their chests, or what was to be done at the time when Jackson was looking out the window? What is the achievement of an Englishman, and what has his son yet to reveal to me, so as to accomplish such a burden? Have you ever made a passage into the old roadway, or to an anchor-breeze at the foot of our boat, which you must leave us? The fact is, whether the wind would rise from the plain on Saturday night or midday, or toward the north, or otherwise, we will be forced to describe a formidable barrier, with the same effects as now. In this situation, at least, it is not too much to say we have left that room. I believe there are three copies in the 'Five Hundred-fold,' to be referred to as the first number for readers who wish t[o]..."

### **v2mini-eval2**

Trained using the same 15GB sample used for training eval1.
Model is again trained to 10K steps only.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Sir, — The following case is interesting to me: — I was in London for a fortnight, and was greatly affected by an attack of rheumatism. The first attack of rheumatism was a week before I saw you, the second was when I saw you, and the third was at the same time. The second attack of gout, however, was not accompanied by any feverish symptoms, but was marked by an increased flow of urine and a more abundant discharge. The third attack occurred an hour after I saw you, and was followed by a return of a gout paroxysm, and a more rapid recurrence of the gout. The fourth attack was also accompanied by a fever, but was not always attended by feverish symptoms. The third attack of gout was a fortnight after you had been ill, and the fourth was followed by a gout paroxysm. The fourth attack occurred a fortnight after you were affected, and was accompanied by a sensation

### **v2**

Trained using a 90GB (112GB tokenized) dataset
Trained to 182K steps

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Datasets

### **v2**

- 90GB(raw) of 1800-1875 London texts
- 136,344 documents
- The full tokenized dataset is now available here: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Bias Stats 
  ![Pronoun bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Geographic bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Temporal bias](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Refer to [v2 bias report](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) for more info.


## How to Use

This project mainly focuses on curating historical data, preparing it for training, and building a tokenizer. I will not cover the full LLM training process; for that, refer to nanoGPT by Andrej Karpathy.

### Step 1: Gather and Prepare Historical Texts 

- Collect .txt files of public domain books, documents, etc., from your selected time period (e.g., London 1800-1850) 
- Ensure they stay within your chosen time/place window  
- Clean the text files using a script or manually remove headers/footers from Project Gutenberg, modern annotations, or things like OCR errors.

### Step 2: Build a Custom Tokenizer

- Run train_tokenizer.py or train_tokenizer_hf.py on the cleaned data.
- This will produce vocab.json and merges.txt
- These files define the vocabulary and merge rules for your model

### Step 3: Train Your Model 

- See [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) for the training process or your chosen architecture’s documentation.

# FAQ

## What is Selective Temporal Training ?

Selective Temporal Training (STT) is a machine learning method where all training data is carefully selected to fall within a specific historical time period. This is done to model the language and knowledge of that era without influence from modern concepts. For example, the current model I have now (v0.5) is trained only on data from 1800-1875; it is not fine-tuned but trained from scratch, resulting in output that reflects the linguistic style and historical context of that era.

## Why not just use fine-tuning or LoRA?

For this project, my goal is to create a language model untouched by modern bias. If I fine-tune something like GPT-2, it's already pretrained and that information won't disappear. If I train from scratch, the language model won't pretend to be old, it simply will be. The aim is to build something that can reason exclusively using knowledge from London books published between 1800 and 1875.

## What kind of data did you use for training?

I'm using books, legal documents, newspapers, and other writings from 1800–1875 London. The list I linked (for v0) has around 200, but for the first training I just used 50 files totaling about ~187 MB. You can view a list of the documents:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Dataset sizes:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (sampled from v2's 90GB)
- v2: 90GB

## How large are the models?

v0: 16M Parameters

v0.5: 123M Parameters

v1: 700M Parameters

v2mini-eval1: 300M Parameters

v2mini-eval2: 200M Parameters

v2: 1.2B Parameters

## Training Specs?

### v0/v0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
Ram: 16GB DDR5

### v1
GPU: A100 SXM rented

### v2mini-eval1/eval2
GPU: A100 SXM rented

### v2
GPU: H100 SXM rented

## Acknowledgements

I would like to thank [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) for academic supervision, guidance on research framing and evaluation, and for assistance with tokenizer training and dataset preparation for the v2 release. His feedback and experience were instrumental in refining the presentation of this work.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---