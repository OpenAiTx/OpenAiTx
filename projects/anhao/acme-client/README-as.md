
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=anhao&project=acme-client&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# ACME ক্লায়েন্ট

Let's Encrypt, ZeroSSL, আৰু অন্যান্য ACME-অনুকূল Certificate Authoritiesৰ সৈতে SSL/TLS প্ৰমাণপত্ৰ ব্যৱস্থাপনা স্বয়ংক্ৰিয়কৰণৰ বাবে এটা বিস্তৃত PHP ACME v2 ক্লায়েন্ট লাইব্রেৰী।

[![github stats](https://img.shields.io/github/stars/anhao/acme-client?style=flat-square&label=github%20stats)](https://github.com/anhao/acme-client)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/anhao/acme-client)
[![PHP Version](https://img.shields.io/badge/PHP-%3E%3D8.2-blue.svg)](https://www.php.net/)

> **Language / ভাষা**: [ইংৰাজী](https://raw.githubusercontent.com/anhao/acme-client/main/README.md) | [চীনাৰ](https://raw.githubusercontent.com/anhao/acme-client/main/README_ZH.md)

## বৈশিষ্ট্যসমূহ

- **ACME v2 প্ৰ'ট'কল সমৰ্থন**: ACME v2 স্পেছিফিকেশ্যনৰ সৈতে সম্পূর্ণ সামঞ্জস্যতা
- **বহুবিধ CA সমৰ্থন**: Let's Encrypt, ZeroSSL, আৰু অন্যান্য ACME প্ৰদানকাৰীৰ সৈতে কাম কৰে
- **একাউণ্ট ব্যৱস্থাপনা**: ACME একাউণ্ট সৃষ্টি, সংৰক্ষণ, আৰু পৰিচালনা কৰক
- **প্ৰমাণপত্ৰ অপাৰেশ্যন**: SSL প্ৰমাণপত্ৰ অনুৰোধ, পুনঃনৱীকৰণ, আৰু বাতিল কৰক
- **ডমেইন বৈধতা**: HTTP-01 আৰু DNS-01 চেলেঞ্জ সমৰ্থন
- **ARI সমৰ্থন**: অপ্টিমাল পুনঃনৱীকৰণ সময়ৰ বাবে স্বয়ংক্ৰিয় Renewal Information
- **নমনীয় কি প্ৰকাৰ**: RSA আৰু ECC কি সমৰ্থন
- **বিশদ লগিং**: PSR-3 সংলগ্ন লগিং বিল্ট-ইন
- **সহজ সংহতি**: সহজ আৰু বোধগম্য API ডিজাইন

## প্ৰয়োজনীয়তা

- PHP 8.2 অথবা তাতকৈ উচ্চ
- OpenSSL এক্সটেনশ্যন
- cURL এক্সটেনশ্যন
- JSON এক্সটেনশ্যন
- mbstring এক্সটেনশ্যন

## ইনষ্টলেশ্যন

Composer ব্যৱহাৰ কৰি ইনষ্টল কৰক:

```bash
composer require alapi/acme-client
```

## দ্ৰুত আৰম্ভণি

### ১. স্থানীয় একাউন্ট কী সৃষ্টি কৰক

ACME একাউন্ট কী সৃষ্টি আৰু পৰিচালনা কৰাৰ দুটা উপায় আছে:

**বিকল্প A: Account শ্ৰেণীৰ সৈতে বিদ্যমান কী ব্যৱহাৰ কৰি**

```php
<?php
require_once 'vendor/autoload.php';

use ALAPI\Acme\Accounts\Account;

// Create account from existing private key string
$privateKeyPem = '-----BEGIN PRIVATE KEY-----...-----END PRIVATE KEY-----';
$account = new Account($privateKeyPem);

// Or create account with both private and public keys
$publicKeyPem = '-----BEGIN PUBLIC KEY-----...-----END PUBLIC KEY-----';
$account = new Account($privateKeyPem, $publicKeyPem);

// Or create account from private key only (public key will be extracted)
$account = Account::fromPrivateKey($privateKeyPem);
```

**বিকল্প B: AccountStorage ব্যৱহাৰ কৰি ফাইল-ভিত্তিক চাবি পৰিচালনা**

```php
<?php
require_once 'vendor/autoload.php';

use ALAPI\Acme\Utils\AccountStorage;

// Create new ECC account and save to files (recommended)
$account = AccountStorage::createAndSave(
    directory: 'storage',
    name: 'my-account',
    keyType: 'ECC',
    keySize: 'P-384'
);

// Or create RSA account and save to files
$rsaAccount = AccountStorage::createAndSave(
    directory: 'storage', 
    name: 'my-rsa-account',
    keyType: 'RSA',
    keySize: 4096
);

echo "Account keys created and saved successfully!\n";
```

### 2. ACME ক্লায়েন্ট আৰম্ভ কৰক

```php
<?php
require_once 'vendor/autoload.php';

use ALAPI\Acme\AcmeClient;
use ALAPI\Acme\Accounts\Account;
use ALAPI\Acme\Utils\AccountStorage;
use ALAPI\Acme\Http\Clients\ClientFactory;

// Option A: Load account from files
$account = AccountStorage::loadFromFiles('storage', 'my-account');

// Option B: Create account from existing keys
$privateKey = '-----BEGIN PRIVATE KEY-----...-----END PRIVATE KEY-----';
$account = new Account($privateKey);

// Create HTTP client with optional proxy
$httpClient = ClientFactory::create(timeout: 30, options: [
    // 'proxy' => 'http://proxy.example.com:8080'
]);

// Initialize client for Let's Encrypt production
$acmeClient = new AcmeClient(
    staging: false, // Set to true for testing
    localAccount: $account,
    httpClient: $httpClient
);

// Or use ZeroSSL
$zeroSslClient = new AcmeClient(
    localAccount: $account,
    httpClient: $httpClient,
    baseUrl: 'https://acme.zerossl.com/v2/DV90/directory'
);
```

### ৩. ACME একাউণ্ট ৰেজিষ্টাৰ কৰক

Let's Encrypt-ৰ বাবে (EAB প্ৰয়োজন নহয়):

```php
try {
    // Register account with Let's Encrypt
    $accountData = $acmeClient->account()->create(
        contacts: ['mailto:admin@example.com']
    );
    
    echo "Account registered successfully!\n";
    echo "Account URL: " . $accountData->url . "\n";
} catch (Exception $e) {
    echo "Registration failed: " . $e->getMessage() . "\n";
}
```
জিৰ'এছএছএলৰ বাবে (EAB আৱশ্যক):


```php
try {
    // Get EAB credentials from ZeroSSL dashboard
    $eabKid = 'your-eab-kid';
    $eabHmacKey = 'your-eab-hmac-key';
    
    $accountData = $zeroSslClient->account()->create(
        eabKid: $eabKid,
        eabHmacKey: $eabHmacKey,
        contacts: ['mailto:admin@example.com']
    );
    
    echo "ZeroSSL account registered successfully!\n";
} catch (Exception $e) {
    echo "Registration failed: " . $e->getMessage() . "\n";
}
```

### 4. চাৰ্টিফিকেট অনুৰোধ কৰক

```php
<?php
use ALAPI\Acme\Enums\AuthorizationChallengeEnum;

try {
    // Get account data
    $accountData = $acmeClient->account()->get();
    
    // Create new order for domains
    $domains = ['example.com', 'www.example.com'];
    $order = $acmeClient->order()->new($accountData, $domains);
    
    echo "Order created: " . $order->url . "\n";
    echo "Status: " . $order->status . "\n";
    
    // Check domain validations
    $validations = $acmeClient->domainValidation()->status($order);
    
    foreach ($validations as $validation) {
        $domain = $validation->identifier['value'];
        echo "Domain: $domain - Status: " . $validation->status . "\n";
        
        if ($validation->isPending()) {
            // Get validation data for HTTP-01 challenge
            $challenges = $acmeClient->domainValidation()->getValidationData(
                [$validation], 
                AuthorizationChallengeEnum::HTTP
            );
            
            foreach ($challenges as $challenge) {
                echo "HTTP Challenge for $domain:\n";
                echo "  File: " . $challenge['filename'] . "\n";
                echo "  Content: " . $challenge['content'] . "\n";
                echo "  Place it at: http://$domain/.well-known/acme-challenge/" . $challenge['filename'] . "\n\n";
            }
        }
    }
} catch (Exception $e) {
    echo "Error: " . $e->getMessage() . "\n";
}
```

### ৫. সম্পূৰ্ণ ডোমেইন ভেলিডেচন

আপোনাৰ ৱেব ছাৰ্ভাৰত চেলেঞ্জ ফাইলসমূহ স্থাপন কৰাৰ পিছত:

```php
try {
    // Trigger validation for each domain
    foreach ($validations as $validation) {
        if ($validation->isPending()) {
            $response = $acmeClient->domainValidation()->validate(
                $accountData,
                $validation,
                AuthorizationChallengeEnum::HTTP,
                localTest: true // Performs local validation first
            );
            
            echo "Validation triggered for: " . $validation->identifier['value'] . "\n";
        }
    }
    
    // Wait for validation to complete
    $maxAttempts = 10;
    $attempt = 0;
    
    do {
        sleep(5);
        $attempt++;
        
        // Check order status
        $currentOrder = $acmeClient->order()->get($accountData, $order->url);
        echo "Order status: " . $currentOrder->status . "\n";
        
        if ($currentOrder->status === 'ready') {
            echo "All validations completed successfully!\n";
            break;
        }
        
        if ($currentOrder->status === 'invalid') {
            echo "Order validation failed!\n";
            break;
        }
        
    } while ($attempt < $maxAttempts);
    
} catch (Exception $e) {
    echo "Validation error: " . $e->getMessage() . "\n";
}
```

### 6. CSR সৃষ্টি কৰক আৰু জমা কৰক

```php
use ALAPI\Acme\Security\Cryptography\OpenSsl;

try {
    if ($currentOrder->status === 'ready') {
        // Generate Certificate private key
        $certificatePrivateKey = OpenSsl::generatePrivateKey('RSA', 2048);
        
        // Generate Certificate Signing Request (CSR) using OpenSsl helper
        $csrString = OpenSsl::generateCsr($domains, $certificatePrivateKey);
        
        // Export private key for saving
        $privateKeyString = OpenSsl::openSslKeyToString($certificatePrivateKey);
        
        // Submit CSR to finalize order
        $finalizedOrder = $acmeClient->order()->finalize(
            $accountData,
            $currentOrder,
            $csrString
        );
        
        echo "Order finalized successfully!\n";
        echo "Certificate URL: " . $finalizedOrder->certificateUrl . "\n";
        
        // Download certificate bundle
        $certificateBundle = $acmeClient->certificate()->get(
            $accountData,
            $finalizedOrder->certificateUrl
        );
        
        // Save certificate and private key
        file_put_contents('certificate.pem', $certificateBundle->certificate);
        file_put_contents('fullchain.pem', $certificateBundle->fullchain);
        file_put_contents('private-key.pem', $privateKeyString);
        
        echo "Certificate saved to certificate.pem\n";
        echo "Fullchain certificate saved to fullchain.pem\n";
        echo "Private key saved to private-key.pem\n";
    }
    
} catch (Exception $e) {
    echo "Certificate generation error: " . $e->getMessage() . "\n";
}
```

## উন্নত ব্যৱহাৰ

### DNS-01 চেলেঞ্জ

ৱাইল্ডকাৰ্ড চাৰ্টিফিকেটসমূহৰ বাবে অথবা HTTP প্ৰমাণীকৰণ সম্ভৱ নহ'লে:

```php
// Get DNS challenge data
$dnsChallenge = $acmeClient->domainValidation()->getValidationData(
    [$validation],
    AuthorizationChallengeEnum::DNS
);

foreach ($dnsChallenge as $challenge) {
    echo "DNS Challenge for " . $challenge['domain'] . ":\n";
    echo "  Record Name: " . $challenge['domain'] . "\n";
    echo "  Record Type: TXT\n";
    echo "  Record Value: " . $challenge['digest'] . "\n\n";
}

// After adding DNS records, trigger validation
$response = $acmeClient->domainValidation()->validate(
    $accountData,
    $validation,
    AuthorizationChallengeEnum::DNS,
    localTest: true
);
```

### ARIৰ সৈতে প্ৰমাণপত্ৰ নবীকৰণ

```php
use ALAPI\Acme\Management\RenewalManager;

// Load existing certificate
$certificatePem = file_get_contents('certificate.pem');

// Create renewal manager
$renewalManager = $acmeClient->renewalManager(defaultRenewalDays: 30);

// Check if renewal is needed
if ($renewalManager->shouldRenew($certificatePem)) {
    echo "Certificate needs renewal\n";
    
    // Get ARI information if supported
    if ($acmeClient->directory()->supportsARI()) {
        $renewalInfo = $acmeClient->renewalInfo()->getFromCertificate($certificatePem);
        
        echo "Suggested renewal window:\n";
        echo "  Start: " . $renewalInfo->suggestedWindow['start'] . "\n";
        echo "  End: " . $renewalInfo->suggestedWindow['end'] . "\n";
        
        if ($renewalInfo->shouldRenewNow()) {
            echo "ARI recommends renewing now\n";
            // Proceed with renewal...
        }
    }
} else {
    echo "Certificate renewal not needed yet\n";
}
```

### প্ৰমাণপত্ৰ ৰদ কৰা

```php
try {
    // Load certificate to revoke
    $certificatePem = file_get_contents('certificate.pem');
    
    // Revoke certificate
    $success = $acmeClient->certificate()->revoke(
        $certificatePem,
        reason: 1 // 0=unspecified, 1=keyCompromise, 2=cACompromise, 3=affiliationChanged, 4=superseded, 5=cessationOfOperation
    );
    
    if ($success) {
        echo "Certificate revoked successfully\n";
    } else {
        echo "Certificate revocation failed\n";
    }
    
} catch (Exception $e) {
    echo "Revocation error: " . $e->getMessage() . "\n";
}
```

### একাধিক প্ৰমাণপত্ৰ কৰ্তৃপক্ষ

```php
// Let's Encrypt
$letsEncrypt = new AcmeClient(
    staging: false,
    localAccount: $account,
    httpClient: $httpClient
);

// ZeroSSL
$zeroSSL = new AcmeClient(
    localAccount: $account,
    httpClient: $httpClient,
    baseUrl: 'https://acme.zerossl.com/v2/DV90/directory'
);

// Google Trust Services
$googleCA = new AcmeClient(
    localAccount: $account,
    httpClient: $httpClient,
    baseUrl: 'https://dv.acme-v02.api.pki.goog/directory'
);
```

### কাষ্টম HTTP ক্লায়েন্ট কনফিগাৰেচন

```php
use ALAPI\Acme\Http\Clients\ClientFactory;

$httpClient = ClientFactory::create(30, [
    'proxy' => 'http://proxy.example.com:8080',
    'verify' => true, // SSL verification
    'timeout' => 30,
    'connect_timeout' => 10,
    'headers' => [
        'User-Agent' => 'MyApp ACME Client 1.0'
    ]
]);
```

### লগিং

```php
use Monolog\Logger;
use Monolog\Handler\StreamHandler;

// Create logger
$logger = new Logger('acme');
$logger->pushHandler(new StreamHandler('acme.log', Logger::INFO));

// Set logger on client
$acmeClient->setLogger($logger);
```

## কনফিগাৰেশ্বন

### একাউণ্ট পৰিচালন বিকল্পসমূহ

**AccountStorage ব্যৱহাৰ কৰি ফাইল-ভিত্তিক পৰিচালনাঃ**

```php
use ALAPI\Acme\Utils\AccountStorage;

// Check if account files exist
if (AccountStorage::exists('storage', 'my-account')) {
    $account = AccountStorage::loadFromFiles('storage', 'my-account');
} else {
    $account = AccountStorage::createAndSave('storage', 'my-account');
}

// Load or create account automatically
$account = AccountStorage::loadOrCreate(
    directory: 'storage',
    name: 'my-account',
    keyType: 'ECC',
    keySize: 'P-384'
);
```

**অৱস্থিত চাবিৰ বাবে Account শ্ৰেণী ব্যৱহাৰ কৰা হৈছে:**

```php
use ALAPI\Acme\Accounts\Account;

// From existing private key
$privateKey = file_get_contents('/path/to/private.key');
$account = new Account($privateKey);

// With both private and public keys
$privateKey = file_get_contents('/path/to/private.key');
$publicKey = file_get_contents('/path/to/public.key');
$account = new Account($privateKey, $publicKey);

// Create new account with specific key type
$account = Account::createECC('P-384');  // or 'P-256', 'P-384'
$account = Account::createRSA(4096);     // or 2048, 3072

// Get account information
echo "Key Type: " . $account->getKeyType() . "\n";
echo "Key Size: " . $account->getKeySize() . "\n";
```

## ত্ৰুটি পৰিচালনা

```php
use ALAPI\Acme\Exceptions\AcmeException;
use ALAPI\Acme\Exceptions\AcmeAccountException;
use ALAPI\Acme\Exceptions\DomainValidationException;
use ALAPI\Acme\Exceptions\AcmeCertificateException;

try {
    // ACME operations here
} catch (AcmeAccountException $e) {
    echo "Account error: " . $e->getMessage() . "\n";
    echo "Detail: " . $e->getDetail() . "\n";
    echo "Type: " . $e->getAcmeType() . "\n";
} catch (DomainValidationException $e) {
    echo "Validation error: " . $e->getMessage() . "\n";
} catch (AcmeCertificateException $e) {
    echo "Certificate error: " . $e->getMessage() . "\n";
} catch (AcmeException $e) {
    echo "ACME error: " . $e->getMessage() . "\n";
} catch (Exception $e) {
    echo "General error: " . $e->getMessage() . "\n";
}
```

## পৰীক্ষণ

টেষ্ট ছুটটো চলাও:

```bash
composer test
```

স্থিৰ বিশ্লেষণ চলাও:

```bash
composer analyse
```

কোড শৈলী ঠিক কৰক:

```bash
composer cs-fix
```

## সুৰক্ষা পৰ্যালোচনা

1. **ব্যক্তিগত চাবি**: ব্যক্তিগত চাবি সুৰক্ষিতভাৱে সংৰক্ষণ কৰক, যথাযথ ফাইল অনুমতি (600) সহ
2. **অ্যাকাউণ্ট চাবি**: অ্যাকাউণ্ট চাবি চাৰ্টিফিকেট চাবিৰ পৰা পৃথক কৰি ৰাখক
3. **স্টেজিং পৰিবেশ**: পৰীক্ষাৰ বাবে স্টেজিং পৰিবেশ ব্যৱহাৰ কৰক
4. **ৰেট সীমা**: CA ৰেট সীমাৰ বিষয়ে অৱগত থাকক
5. **যাচাই**: সদায় স্থানীয়ভাৱে চেলেঞ্জ যাচাই কৰক, তাৰপিছতেই ACME যাচাইকৰণ আৰম্ভ কৰক

## অৱদান

1. ৰেপ'জিট'ৰিটো ফর্ক কৰক
2. এটা ফিচাৰ শাখা সৃষ্টি কৰক
3. আপোনাৰ পৰিৱর্তন কৰক
4. নতুন কাৰ্যক্ষমতাৰ বাবে পৰীক্ষা যোগ কৰক
5. পৰীক্ষা চুট চলাওক
6. এটা পুল অনুৰোধ জমা দিয়ক

## লাইচেঞ্চ

এই প্ৰকল্প MIT লাইচেঞ্চৰ অধীনত লাইচেঞ্চ কৰা হৈছে - অধিক তথ্যৰ বাবে [LICENSE](LICENSE) ফাইলটো চাওক।

## লিংকসমূহ

- [Let's Encrypt Documentation](https://letsencrypt.org/docs/)
- [ACME Specification RFC 8555](https://tools.ietf.org/html/rfc8555)
- [ZeroSSL ACME Guide](https://zerossl.com/documentation/acme/)

## সহায়

যদি আপুনি কোনো সমস্যা পায় বা প্ৰশ্ন থাকে:

1. [ডকুমেন্টেশ্বন](#quick-start) চাওক
2. বিদ্যমান [সমস্যাসমূহ](https://github.com/anhao/acme-client/issues)ত সন্ধান কৰক
3. প্ৰয়োজন হলে এটা [নতুন সমস্যা](https://github.com/anhao/acme-client/issues/new) সৃষ্টি কৰক


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---