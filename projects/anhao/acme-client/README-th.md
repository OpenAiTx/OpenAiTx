
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

# ACME Client

ไลบรารี PHP ACME v2 แบบครบวงจรสำหรับการจัดการใบรับรอง SSL/TLS อัตโนมัติด้วย Let's Encrypt, ZeroSSL และหน่วยงานออกใบรับรองที่รองรับ ACME อื่น ๆ

[![github stats](https://img.shields.io/github/stars/anhao/acme-client?style=flat-square&label=github%20stats)](https://github.com/anhao/acme-client)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/anhao/acme-client)
[![PHP Version](https://img.shields.io/badge/PHP-%3E%3D8.2-blue.svg)](https://www.php.net/)

> **ภาษา / 语言**: [อังกฤษ](https://raw.githubusercontent.com/anhao/acme-client/main/README.md) | [中文](https://raw.githubusercontent.com/anhao/acme-client/main/README_ZH.md)

## คุณสมบัติ

- **รองรับโปรโตคอล ACME v2**: เข้ากันได้อย่างสมบูรณ์กับข้อกำหนด ACME v2
- **รองรับ CA หลายตัว**: ใช้งานร่วมกับ Let's Encrypt, ZeroSSL และผู้ให้บริการ ACME อื่นๆ
- **การจัดการบัญชี**: สร้าง เก็บ และจัดการบัญชี ACME
- **การดำเนินการใบรับรอง**: ขอ ต่ออายุ และเพิกถอนใบรับรอง SSL
- **การตรวจสอบโดเมน**: รองรับความท้าทาย HTTP-01 และ DNS-01
- **รองรับ ARI**: ข้อมูลต่ออายุอัตโนมัติสำหรับระยะเวลาต่ออายุที่เหมาะสม
- **ประเภทคีย์ที่ยืดหยุ่น**: รองรับคีย์ RSA และ ECC
- **การบันทึกข้อมูลอย่างครอบคลุม**: ระบบบันทึกข้อมูลที่เข้ากันได้กับ PSR-3
- **การผสานรวมง่าย**: การออกแบบ API ที่เรียบง่ายและเข้าใจง่าย

## ข้อกำหนด

- PHP 8.2 หรือสูงกว่า
- ส่วนขยาย OpenSSL
- ส่วนขยาย cURL
- ส่วนขยาย JSON
- ส่วนขยาย mbstring

## การติดตั้ง

ติดตั้งผ่าน Composer:

```bash
composer require alapi/acme-client
```

## เริ่มต้นใช้งานอย่างรวดเร็ว

### 1. สร้างคีย์บัญชีแบบ Local

คุณมีสองวิธีในการสร้างและจัดการคีย์บัญชี ACME:

**ตัวเลือก A: ใช้คีย์ที่มีอยู่ร่วมกับคลาส Account**

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

**ตัวเลือก B: การใช้ AccountStorage สำหรับการจัดการคีย์แบบไฟล์**

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

### 2. เริ่มต้นไคลเอนต์ ACME

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

### 3. ลงทะเบียนบัญชี ACME

สำหรับ Let's Encrypt (ไม่ต้องใช้ EAB):

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
สำหรับ ZeroSSL (ต้องการ EAB):


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

### 4. ขอใบรับรอง

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

### 5. การตรวจสอบโดเมนแบบสมบูรณ์

หลังจากที่คุณวางไฟล์ท้าทายบนเว็บเซิร์ฟเวอร์ของคุณ:

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

### 6. สร้างและส่ง CSR

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

## การใช้งานขั้นสูง

### DNS-01 Challenge

สำหรับใบรับรองแบบไวลด์การ์ดหรือเมื่อไม่สามารถตรวจสอบผ่าน HTTP ได้:

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

### การต่ออายุใบรับรองด้วย ARI

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

### การเพิกถอนใบรับรอง

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

### หลายหน่วยงานออกใบรับรอง

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

### การกำหนดค่าคลายเอนต์ HTTP แบบกำหนดเอง

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

### การบันทึกล็อก

```php
use Monolog\Logger;
use Monolog\Handler\StreamHandler;

// Create logger
$logger = new Logger('acme');
$logger->pushHandler(new StreamHandler('acme.log', Logger::INFO));

// Set logger on client
$acmeClient->setLogger($logger);
```

## การกำหนดค่า

### ตัวเลือกการจัดการบัญชี

**การใช้ AccountStorage สำหรับการจัดการแบบใช้ไฟล์:**

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

**การใช้คลาส Account สำหรับคีย์ที่มีอยู่แล้ว:**

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

## การจัดการข้อผิดพลาด

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

## การทดสอบ

รันชุดทดสอบ:

```bash
composer test
```

รันการวิเคราะห์แบบสถิต:

```bash
composer analyse
```

ปรับปรุงรูปแบบโค้ด:

```bash
composer cs-fix
```

## ข้อควรพิจารณาด้านความปลอดภัย

1. **กุญแจส่วนตัว**: จัดเก็บกุญแจส่วนตัวไว้อย่างปลอดภัยพร้อมสิทธิ์ไฟล์ที่เหมาะสม (600)
2. **กุญแจบัญชี**: แยกกุญแจบัญชีออกจากกุญแจใบรับรอง
3. **สภาพแวดล้อมทดสอบ**: ใช้สภาพแวดล้อมทดสอบสำหรับการทดสอบ
4. **ขีดจำกัดอัตรา**: ระวังขีดจำกัดอัตราของ CA
5. **การตรวจสอบความถูกต้อง**: ตรวจสอบความถูกต้องของ challenge ในเครื่องก่อนเริ่มกระบวนการตรวจสอบ ACME

## การร่วมพัฒนา

1. Fork repository
2. สร้าง branch สำหรับฟีเจอร์
3. แก้ไขโค้ดของคุณ
4. เพิ่มการทดสอบสำหรับฟังก์ชันใหม่
5. รันชุดทดสอบ
6. ส่ง pull request

## สัญญาอนุญาต

โปรเจกต์นี้ได้รับอนุญาตภายใต้ MIT License - ดูไฟล์ [LICENSE](LICENSE) สำหรับรายละเอียด

## ลิงก์

- [เอกสาร Let's Encrypt](https://letsencrypt.org/docs/)
- [ACME Specification RFC 8555](https://tools.ietf.org/html/rfc8555)
- [ZeroSSL ACME Guide](https://zerossl.com/documentation/acme/)

## การสนับสนุน

หากคุณพบปัญหาหรือมีคำถาม:

1. ตรวจสอบ [เอกสารประกอบ](#quick-start)
2. ค้นหา [ปัญหาที่มีอยู่](https://github.com/anhao/acme-client/issues)
3. สร้าง [ปัญหาใหม่](https://github.com/anhao/acme-client/issues/new) หากจำเป็น


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---