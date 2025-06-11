# Django Ninja Shortener - Bitly जैसी शॉर्ट URL सेवा

Django, Django Ninja और Tailwind CSS द्वारा निर्मित आधुनिक शॉर्ट URL सेवा, जिसकी डिज़ाइन प्रेरणा Bitly से ली गई है।

उपयोगकर्ता पंजीकरण और लॉगिन के बाद URL को छोटा कर सकते हैं, और प्रत्येक शॉर्ट URL पर क्लिक की गई संख्या को ट्रैक कर सकते हैं।

इस प्रोजेक्ट में [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) का उपयोग सहायता के लिए किया गया है, देखें [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## स्क्रीनशॉट्स

शॉर्ट URL पेज (बिना पंजीकरण भी उपयोग कर सकते हैं)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

अगर पंजीकरण किया है तो क्लिक ट्रैकिंग भी देख सकते हैं

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ मुख्य विशेषताएँ

* **उपयोगकर्ता प्रमाणीकरण**: उपयोगकर्ता पंजीकरण, लॉगिन, लॉगआउट का समर्थन।
* **शॉर्ट URL बनाना**: लॉगिन किए हुए उपयोगकर्ता लंबे URL के लिए एक यूनिक शॉर्ट URL बना सकते हैं।
* **शॉर्ट URL रीडायरेक्ट**: शॉर्ट URL पर क्लिक करने पर उपयोगकर्ता को मूल लंबे URL पर भेज दिया जाता है।
* **क्लिक काउंट ट्रैकिंग**: सिस्टम प्रत्येक शॉर्ट URL पर क्लिक की गई संख्या को स्वतः गिनता है।
* **पर्सनल डैशबोर्ड**: उपयोगकर्ता अपने बनाए सभी शॉर्ट URL और उनके क्लिक आँकड़े देख सकते हैं।
* **RESTful API**: शॉर्ट URL प्रोग्रामेटिक रूप से बनाने के लिए API एंडपॉइंट्स उपलब्ध।
* **Docker सपोर्ट**: Dockerfile और Docker Compose सेटअप उपलब्ध, जिससे विकास और डिप्लॉयमेंट प्रक्रिया सरल होती है।

## 🛠️ टेक्नोलॉजी स्टैक

* **बैकएंड फ्रेमवर्क**: [Django](https://github.com/twtrubiks/django-tutorial)
* **API फ्रेमवर्क**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **फ्रंटएंड स्टाइलिंग**: [Tailwind CSS](https://tailwindcss.com/) (`django-tailwind` के माध्यम से एकीकृत)
* **डेटाबेस**:
  * डेवलपमेंट: SQLite (डिफ़ॉल्ट)
  * प्रोडक्शन: आसानी से PostgreSQL में बदला जा सकता है (`settings.py` में सेटिंग तैयार)
* **शॉर्ट URL कोड**: `shortuuid` का उपयोग कर जेनरेट किया गया
* **टेस्टिंग**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **कंटेनरीकरण**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 त्वरित प्रारंभ (Docker का उपयोग करके, यही तरीका सुझाया गया है)

यह सबसे अनुशंसित तरीका है जिससे डेवलपमेंट वातावरण की एकरूपता सुनिश्चित होती है।

**चरण:**

1. **सेवा प्रारंभ करें:**

    Docker Compose के माध्यम से सभी सेवाएं एक क्लिक में प्रारंभ करें।

    ```bash
    docker compose up --build
    ```

    यह कमांड Docker इमेज बनाएगा, डिपेंडेंसी इंस्टॉल करेगा, डेटाबेस माइग्रेशन चलाएगा, और डेवलपमेंट सर्वर चालू करेगा।

2. **सुपरयूज़र बनाएँ (वैकल्पिक):**

    यदि Django Admin तक पहुँचना है, तो दूसरे टर्मिनल विंडो में चलाएँ:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **एप्लिकेशन खोलें:**

    * **वेबसाइट होमपेज**: [http://localhost:8000](http://localhost:8000)

    * **API डॉक्स (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 स्थानीय विकास (Docker का उपयोग नहीं करते हुए)

यदि आप सीधे स्थानीय सेटअप पसंद करते हैं।

**पूर्वापेक्षित:**

* Python 3.12
* Node.js और npm (Tailwind CSS के लिए)

**सेटअप चरण:**

1. **वर्चुअल एनवायरनमेंट बनाएँ और सक्रिय करें:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Windows पर, `venv\Scripts\activate` का उपयोग करें
    ```

2. **Python डिपेंडेंसी इंस्टॉल करें:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Tailwind CSS इंस्टॉल और सेटअप करें:**

    `django-tailwind` अधिकांश सेटअप को संभाल लेगा।

    ```bash
    python manage.py tailwind install
    ```

    देखें [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **डेटाबेस माइग्रेशन चलाएँ:**

    ```bash
    python manage.py migrate
    ```

5. **सुपरयूज़र बनाएँ (वैकल्पिक):**

    ```bash
    python manage.py createsuperuser
    ```

6. **डेवलपमेंट सर्वर प्रारंभ करें:**

    आपको Django सर्वर और Tailwind CSS की कंपाइल प्रक्रिया दोनों चालू करनी होंगी।

    ```bash
    python manage.py runserver
    ```

    दूसरी टर्मिनल विंडो में:

    ```bash
    python manage.py tailwind start
    ```

7. **एप्लिकेशन खोलें:**

    * **वेबसाइट होमपेज**: [http://localhost:8000](http://localhost:8000)

    * **API डॉक्स (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 टेस्ट चलाना

इस प्रोजेक्ट में `pytest` का उपयोग टेस्टिंग और कवरेज जेनरेट करने के लिए किया गया है।

टेस्टिंग प्लान के लिए देखें [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Docker के माध्यम से टेस्ट चलाएँ:**

    ```bash
    docker compose --profile test up
    ```

    टेस्ट रिपोर्ट `htmlcov/index.html` में उत्पन्न होगी।

* **स्थानीय रूप से टेस्ट चलाएँ:**

    ```bash
    # सुनिश्चित करें कि डेवलपमेंट डिपेंडेंसी इंस्टॉल हैं
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 API एंडपॉइंट्स

API प्रोग्रामेटिक रूप से शॉर्ट URL सेवा के साथ संवाद करने का तरीका प्रदान करती है। सभी API एंडपॉइंट्स `/api/` पाथ के अंतर्गत हैं।

सीधे जाएं **API डॉक्स (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

[Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt) का उपयोग करते हुए, पहले `/api/token/pair` पर कॉल करें और अपनी यूज़रनेम और पासवर्ड से टोकन प्राप्त करें

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

फिर टोकन को ऊपर दाईं ओर चिपकाएँ, अब आप API कॉल कर सकते हैं

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 प्रोजेक्ट संरचना

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Django प्रोजेक्ट सेटिंग्स
│   ├── settings.py
│   └── urls.py
├── shortener/            # मुख्य शॉर्ट URL ऐप
│   ├── models.py         # डेटाबेस मॉडल (Link)
│   ├── api.py            # Django Ninja API एंडपॉइंट्स
│   ├── views.py          # पेज व्यू और रीडायरेक्ट लॉजिक
│   └── utils.py          # शॉर्ट कोड जेनरेशन टूल्स
└── theme/                # Django थीम और टेम्पलेट्स
    ├── templates/        # HTML टेम्पलेट्स
    └── static_src/       # Tailwind CSS सोर्स फाइल्स
```

## 💡 भविष्य की योजनाएँ

* **PostgreSQL पर स्विच**: प्रोडक्शन के लिए अधिक मजबूत डेटाबेस। (पूरा)
* **विस्तृत एनालिटिक्स डैशबोर्ड**: और भी क्लिक डेटा उपलब्ध कराना, जैसे समय, स्रोत, भौगोलिक स्थिति आदि।
* **कस्टम शॉर्ट URL**: उपयोगकर्ता को शॉर्ट URL कोड को कस्टमाइज़ करने की अनुमति देता है।
* **QR कोड जनरेशन**: प्रत्येक शॉर्ट URL के लिए संबंधित QR कोड जनरेट करता है।
* **असिंक्रोनस टास्क**: डेटा विश्लेषण जैसे समय लेने वाले कार्यों के लिए Celery का उपयोग करता है।

## डोनेशन

सभी लेख मैंने खुद रिसर्च कर के और आत्मसात करने के बाद मूल रूप से लिखे हैं। यदि इससे आपको सहायता मिली है और आप मुझे प्रोत्साहित करना चाहते हैं, तो आप मुझे एक कप कॉफी पिला सकते हैं :laughing:

ग्रीनवर्ल्ड टेक्नोलॉजी ECPAY (सदस्यता की आवश्यकता नहीं है)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[प्रायोजक भुगतान](http://bit.ly/2F7Jrha)

O'Pay (सदस्यता आवश्यक है)

![alt tag](https://i.imgur.com/LRct9xa.png)

[प्रायोजक भुगतान](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## प्रायोजक सूची

[प्रायोजक सूची](https://github.com/twtrubiks/Thank-you-for-donate)

## लाइसेंस

MIT लाइसेंस

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---