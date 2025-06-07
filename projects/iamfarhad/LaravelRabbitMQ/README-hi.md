# Laravel RabbitMQ Queue Driver

[![Latest Stable Version](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/v/stable?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Total Downloads](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/downloads?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![License](https://poser.pugx.org/iamfarhad/laravel-rabbitmq/license?format=flat-square)](https://packagist.org/packages/iamfarhad/laravel-rabbitmq)
[![Tests](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/tests.yml)
[![Code style](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml/badge.svg)](https://github.com/iamfarhad/LaravelRabbitMQ/actions/workflows/code-style.yml)

Laravel के लिए एक मजबूत RabbitMQ कतार ड्राइवर कार्यान्वयन, जो उच्च प्रदर्शन और विश्वसनीयता के साथ उन्नत संदेश कतार क्षमताएं प्रदान करता है।

## विशेषताएँ

- नेटिव Laravel Queue API एकीकरण
- विलंबित/अनुसूचित जॉब्स का समर्थन
- प्राथमिकता कतारें
- त्रुटि प्रबंधन और स्वचालित पुनः प्रयास
- SSL/TLS सुरक्षित कनेक्शन
- कई उपभोक्ताओं के साथ समानांतर प्रोसेसिंग
- स्वचालित कतार निर्माण और बाइंडिंग
- व्यापक कतार कॉन्फ़िगरेशन विकल्प
- RabbitMQ संदेश विशेषताओं का समर्थन
- डेड लेटर एक्सचेंजेज़
- Quality of Service (QoS) सेटिंग्स
- क्वोरम कतार समर्थन

## समर्थन नीति

केवल नवीनतम संस्करण को नई विशेषताएँ मिलेंगी। बग फिक्स निम्नलिखित योजना के अनुसार प्रदान किए जाएंगे:

| पैकेज संस्करण | Laravel संस्करण | PHP संस्करण | बग फिक्स तक      |                                                                                     |
|--------------|----------------|-------------|-------------------|-------------------------------------------------------------------------------------|
| 0.1          | 10, 11, 12     | ^8.2        | 26 अगस्त, 2025    | [दस्तावेज़ीकरण](https://github.com/iamfarhad/LaravelRabbitMQ/blob/master/README.md) |

## आवश्यकताएँ

- PHP 8.2+
- Laravel 10.x, 11.x, या 12.x
- RabbitMQ सर्वर 3.8+
- ext-pcntl (समानांतर प्रोसेसिंग के लिए)

## स्थापना

Composer के माध्यम से पैकेज इंस्टॉल करें:

```bash
composer require iamfarhad/laravel-rabbitmq
```

पैकेज स्वतः ही Laravel के पैकेज डिस्कवरी के माध्यम से पंजीकृत हो जाएगा।

Lumen के लिए, `bootstrap/app.php` में मैन्युअली सर्विस प्रोवाइडर पंजीकृत करें:

```php
$app->register(iamfarhad\LaravelRabbitMQ\LaravelRabbitQueueServiceProvider::class);
```

## कॉन्फ़िगरेशन

अपने `config/queue.php` फ़ाइल में RabbitMQ कनेक्शन जोड़ें:

```php
'connections' => [
    // ... अन्य कनेक्शन
    
    'rabbitmq' => [
        'driver' => 'rabbitmq',
        'queue'  => env('RABBITMQ_QUEUE', 'default'),

        'hosts' => [
            'host'      => env('RABBITMQ_HOST', '127.0.0.1'),
            'port'      => env('RABBITMQ_PORT', 5672),
            'user'      => env('RABBITMQ_USER', 'guest'),
            'password'  => env('RABBITMQ_PASSWORD', 'guest'),
            'vhost'     => env('RABBITMQ_VHOST', '/'),
            'lazy'      => env('RABBITMQ_LAZY_CONNECTION', true),
            'keepalive' => env('RABBITMQ_KEEPALIVE_CONNECTION', false),
            'heartbeat' => env('RABBITMQ_HEARTBEAT_CONNECTION', 0),
            'secure'    => env('RABBITMQ_SECURE', false),
        ],

        'options' => [
            'ssl_options' => [
                'cafile'      => env('RABBITMQ_SSL_CAFILE', null),
                'local_cert'  => env('RABBITMQ_SSL_LOCALCERT', null),
                'local_key'   => env('RABBITMQ_SSL_LOCALKEY', null),
                'verify_peer' => env('RABBITMQ_SSL_VERIFY_PEER', true),
                'passphrase'  => env('RABBITMQ_SSL_PASSPHRASE', null),
            ],
            'queue' => [
                'job' => \iamfarhad\LaravelRabbitMQ\Jobs\RabbitMQJob::class,
                'qos' => [
                    'prefetch_size'  => 0,
                    'prefetch_count' => 10,
                    'global'         => false
                ]
            ],
        ],
    ],
]
```

इन पर्यावरण वेरिएबल्स को अपनी `.env` फ़ाइल में जोड़ें:

```
QUEUE_CONNECTION=rabbitmq
RABBITMQ_HOST=127.0.0.1
RABBITMQ_PORT=5672
RABBITMQ_USER=guest
RABBITMQ_PASSWORD=guest
RABBITMQ_VHOST=/
```

## मूल उपयोग

एक बार कॉन्फ़िगर करने के बाद, आप सामान्य रूप से Laravel की Queue API का उपयोग कर सकते हैं। यदि आप पहले से ही Laravel कतारों से परिचित हैं, तो आपको अपने कोड में कुछ भी बदलने की आवश्यकता नहीं है।

### जॉब्स डिस्पैच करना

```php
// डिफ़ॉल्ट कतार में जॉब भेजें
dispatch(new ProcessPodcast($podcast));

// किसी विशेष कतार में जॉब भेजें
dispatch(new ProcessPodcast($podcast))->onQueue('podcasts');

// विलंब के साथ जॉब भेजें
dispatch(new ProcessPodcast($podcast))->delay(now()->addMinutes(10));
```

### जॉब्स बनाना

```php
namespace App\Jobs;

use Illuminate\Bus\Queueable;
use Illuminate\Contracts\Queue\ShouldQueue;
use Illuminate\Foundation\Bus\Dispatchable;
use Illuminate\Queue\InteractsWithQueue;
use Illuminate\Queue\SerializesModels;

class ProcessPodcast implements ShouldQueue
{
    use Dispatchable, InteractsWithQueue, Queueable, SerializesModels;

    public function __construct(private $podcast)
    {
        // कस्टम कतार निर्दिष्ट करें
        $this->onQueue('podcasts');
    }

    public function handle()
    {
        // पॉडकास्ट प्रोसेस करें...
    }
}
```

## संदेशों का उपभोग करना

RabbitMQ से संदेश उपभोग करने के दो तरीके हैं:

### 1. मानक Laravel Queue Worker

Laravel का बिल्ट-इन कतार वर्कर, जो `basic_get` का उपयोग करता है:

```bash
php artisan queue:work rabbitmq --queue=default
```

### 2. समर्पित RabbitMQ Consumer

यह पैकेज एक विशेष RabbitMQ कंज्यूमर प्रदान करता है, जो `basic_consume` का उपयोग करता है और बेहतर प्रदर्शन देता है:

```bash
php artisan rabbitmq:consume --queue=default
```

#### कंज्यूमर विकल्प

```bash
php artisan rabbitmq:consume [options]
```

विकल्प:

- `--connection=`: कनेक्शन नाम (डिफ़ॉल्ट कनेक्शन पर सेट)
- `--queue=`: उपभोग करने के लिए कतार का नाम
- `--name=default`: कंज्यूमर का नाम
- `--once`: केवल एक जॉब प्रोसेस करें और बाहर निकलें
- `--stop-when-empty`: जब कतार खाली हो जाए तो रुकें
- `--delay=0`: असफल जॉब्स के लिए विलंब (सेकंड में)
- `--max-jobs=0`: रुकने से पहले प्रोसेस करने के लिए अधिकतम जॉब्स की संख्या
- `--max-time=0`: वर्कर के चलने का अधिकतम समय (सेकंड में)
- `--memory=128`: मेमोरी सीमा (मेगाबाइट में)
- `--timeout=60`: जॉब टाइमआउट (सेकंड में)
- `--tries=1`: जॉब को असफल मानने से पहले प्रयासों की संख्या
- `--max-priority=null`: उपभोग के लिए अधिकतम प्राथमिकता स्तर
- `--num-processes=2`: समानांतर में चलाने के लिए प्रोसेसों की संख्या

## उन्नत विशेषताएँ

### प्राथमिकता कतारें

प्राथमिकता कतारों का उपयोग करने के लिए:

1. अपनी कतार कॉन्फ़िगरेशन में अधिकतम प्राथमिकता सेट करें (1-255, जहाँ अधिक मान अधिक प्राथमिकता है)
2. प्राथमिकता के साथ जॉब्स डिस्पैच करें:

```php
$job = (new ProcessPodcast($podcast))->onQueue('podcasts');
dispatch($job->withProperty('priority', 10));
```

### समानांतर प्रोसेसिंग

कई कंज्यूमर प्रोसेसों को समानांतर में चलाएँ:

```bash
php artisan rabbitmq:consume --queue=default --num-processes=4
```

### Quality of Service (QoS)

अपनी कतार कॉन्फ़िगरेशन में प्रीफ़ेच सेटिंग्स कॉन्फ़िगर करें:

```php
'queue' => [
    'qos' => [
        'prefetch_size'  => 0,    // कोई विशिष्ट आकार सीमा नहीं
        'prefetch_count' => 10,   // एक बार में 10 संदेश प्रोसेस करें
        'global'         => false // प्रति कंज्यूमर लागू, चैनल पर नहीं
    ]
]
```

### SSL/TLS कनेक्शन

सुरक्षित कनेक्शन सक्षम करने के लिए:

1. अपनी कॉन्फ़िगरेशन में `secure` को `true` पर सेट करें
2. उपयुक्त प्रमाणपत्रों और सेटिंग्स के साथ SSL विकल्प कॉन्फ़िगर करें

```php
'secure' => true,
'ssl_options' => [
    'cafile'      => '/path/to/ca.pem',
    'local_cert'  => '/path/to/cert.pem',
    'local_key'   => '/path/to/key.pem',
    'verify_peer' => true,
    'passphrase'  => 'certificate-passphrase',
],
```

## त्रुटि प्रबंधन और पुनः प्रयास

असफल जॉब्स को `--tries` विकल्प के आधार पर स्वचालित रूप से पुनः प्रयास किया जाता है। जो जॉब्स अधिकतम पुनः प्रयास से अधिक हो जाते हैं, वे असफल जॉब्स टेबल में भेज दिए जाते हैं।

आप पुनः प्रयास व्यवहार को अनुकूलित कर सकते हैं:

```php
// अपनी जॉब क्लास में
public function failed(Throwable $exception)
{
    // असफल जॉब को संभालें
}

// कस्टम पुनः प्रयास विलंब
public function retryAfter()
{
    return 30; // सेकंड
}
```

## योगदान

योगदान स्वागत योग्य हैं! कृपया Pull Request सबमिट करने के लिए स्वतंत्र महसूस करें।

1. रिपॉजिटरी को फोर्क करें
2. अपनी फीचर ब्रांच बनाएँ (`git checkout -b feature/amazing-feature`)
3. अपने परिवर्तन कमिट करें (`git commit -m 'Add some amazing feature'`)
4. ब्रांच को पुश करें (`git push origin feature/amazing-feature`)
5. Pull Request खोलें

## लाइसेंस

यह पैकेज [MIT license](LICENSE) के तहत ओपन-सोर्स सॉफ़्टवेयर है।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---