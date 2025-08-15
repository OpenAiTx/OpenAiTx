
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

Eine umfassende PHP ACME v2 Client-Bibliothek zur Automatisierung der Verwaltung von SSL/TLS-Zertifikaten mit Let's Encrypt, ZeroSSL und anderen ACME-kompatiblen Zertifizierungsstellen.

[![github stats](https://img.shields.io/github/stars/anhao/acme-client?style=flat-square&label=github%20stats)](https://github.com/anhao/acme-client)
[![Lizenz: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/anhao/acme-client)
[![PHP Version](https://img.shields.io/badge/PHP-%3E%3D8.2-blue.svg)](https://www.php.net/)

> **Sprache / 语言**: [Englisch](https://raw.githubusercontent.com/anhao/acme-client/main/README.md) | [中文](https://raw.githubusercontent.com/anhao/acme-client/main/README_ZH.md)

## Funktionen

- **ACME v2 Protokollunterstützung**: Volle Kompatibilität mit der ACME v2 Spezifikation
- **Mehrere CA-Unterstützung**: Funktioniert mit Let's Encrypt, ZeroSSL und anderen ACME-Anbietern
- **Kontoverwaltung**: Erstellen, Speichern und Verwalten von ACME-Konten
- **Zertifikatsoperationen**: Beantragen, erneuern und widerrufen von SSL-Zertifikaten
- **Domänenvalidierung**: Unterstützung für HTTP-01 und DNS-01 Herausforderungen
- **ARI-Unterstützung**: Automatische Erneuerungsinformationen für optimalen Erneuerungszeitpunkt
- **Flexible Schlüsseltypen**: Unterstützung für RSA- und ECC-Schlüssel
- **Umfassendes Logging**: Integriertes PSR-3 kompatibles Logging
- **Einfache Integration**: Einfache und intuitive API-Gestaltung

## Anforderungen

- PHP 8.2 oder höher
- OpenSSL-Erweiterung
- cURL-Erweiterung
- JSON-Erweiterung
- mbstring-Erweiterung

## Installation

Installation über Composer:

```bash
composer require alapi/acme-client
```

## Schnellstart

### 1. Lokale Account-Schlüssel erstellen

Sie haben zwei Möglichkeiten, ACME-Account-Schlüssel zu erstellen und zu verwalten:

**Option A: Verwendung vorhandener Schlüssel mit der Account-Klasse**

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

**Option B: Verwendung von AccountStorage für dateibasierte Schlüsselverwaltung**

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

### 2. ACME-Client initialisieren

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

### 3. ACME-Konto registrieren

Für Let's Encrypt (keine EAB erforderlich):

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

Für ZeroSSL (EAB erforderlich):

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

### 4. Zertifikat anfordern

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

### 5. Vollständige Domainvalidierung

Nachdem Sie die Challenge-Dateien auf Ihrem Webserver platziert haben:

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

### 6. CSR generieren und einreichen

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

## Erweiterte Verwendung

### DNS-01-Challenge

Für Wildcard-Zertifikate oder wenn eine HTTP-Validierung nicht möglich ist:

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

### Zertifikatserneuerung mit ARI

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

### Zertifikatswiderruf

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

### Mehrere Zertifizierungsstellen

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

### Benutzerdefinierte HTTP-Client-Konfiguration

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

### Protokollierung

```php
use Monolog\Logger;
use Monolog\Handler\StreamHandler;

// Create logger
$logger = new Logger('acme');
$logger->pushHandler(new StreamHandler('acme.log', Logger::INFO));

// Set logger on client
$acmeClient->setLogger($logger);
```

## Konfiguration

### Optionen für Kontoverwaltung

**Verwendung von AccountStorage für dateibasierte Verwaltung:**

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

**Verwendung der Account-Klasse für vorhandene Schlüssel:**

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

## Fehlerbehandlung

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

## Tests

Führen Sie die Test-Suite aus:

```bash
composer test
```
Führen Sie eine statische Analyse durch:


```bash
composer analyse
```

Code-Stil korrigieren:

```bash
composer cs-fix
```

## Sicherheitshinweise

1. **Private Schlüssel**: Private Schlüssel sicher mit geeigneten Dateiberechtigungen (600) speichern
2. **Account-Schlüssel**: Account-Schlüssel getrennt von Zertifikat-Schlüsseln aufbewahren
3. **Staging-Umgebung**: Für Tests die Staging-Umgebung verwenden
4. **Ratenbegrenzungen**: Beachten Sie die CA-Ratenbegrenzungen
5. **Validierung**: Validieren Sie Herausforderungen immer lokal, bevor Sie die ACME-Validierung auslösen

## Beitrag leisten

1. Forken Sie das Repository
2. Erstellen Sie einen Feature-Branch
3. Nehmen Sie Ihre Änderungen vor
4. Fügen Sie Tests für neue Funktionalität hinzu
5. Führen Sie die Testsuite aus
6. Senden Sie eine Pull-Anfrage

## Lizenz

Dieses Projekt steht unter der MIT-Lizenz – Details finden Sie in der [LICENSE](LICENSE)-Datei.

## Links

- [Let's Encrypt Dokumentation](https://letsencrypt.org/docs/)
- [ACME Spezifikation RFC 8555](https://tools.ietf.org/html/rfc8555)
- [ZeroSSL ACME Leitfaden](https://zerossl.com/documentation/acme/)

## Support

Wenn Sie auf Probleme stoßen oder Fragen haben:

1. Prüfen Sie die [Dokumentation](#quick-start)
2. Suchen Sie in den bestehenden [Issues](https://github.com/anhao/acme-client/issues)
3. Erstellen Sie bei Bedarf ein [neues Issue](https://github.com/anhao/acme-client/issues/new)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---