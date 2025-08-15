
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# ACMEクライアント

Let's Encrypt、ZeroSSL、および他のACME互換認証局とともにSSL/TLS証明書管理を自動化するための、包括的なPHP製ACME v2クライアントライブラリです。

[![github stats](https://img.shields.io/github/stars/anhao/acme-client?style=flat-square&label=github%20stats)](https://github.com/anhao/acme-client)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/anhao/acme-client)
[![PHP Version](https://img.shields.io/badge/PHP-%3E%3D8.2-blue.svg)](https://www.php.net/)

> **Language / 语言**: [英語](https://raw.githubusercontent.com/anhao/acme-client/main/README.md) | [中文](https://raw.githubusercontent.com/anhao/acme-client/main/README_ZH.md)

## 特徴

- **ACME v2 プロトコル対応**: ACME v2 仕様に完全準拠
- **複数CA対応**: Let's Encrypt、ZeroSSL、その他のACMEプロバイダと連携可能
- **アカウント管理**: ACMEアカウントの作成、保存、管理
- **証明書操作**: SSL証明書の申請、更新、失効
- **ドメイン認証**: HTTP-01およびDNS-01チャレンジに対応
- **ARI対応**: 最適な更新タイミングの自動更新情報
- **柔軟な鍵タイプ**: RSAおよびECC鍵に対応
- **包括的なログ機能**: PSR-3互換の組み込みログ
- **簡単な統合**: シンプルかつ直感的なAPI設計

## 必要条件

- PHP 8.2以上
- OpenSSL拡張
- cURL拡張
- JSON拡張
- mbstring拡張

## インストール

Composerでインストール:

```bash
composer require alapi/acme-client
```

## クイックスタート

### 1. ローカルアカウントキーの作成

ACMEアカウントキーの作成と管理には2つの方法があります：

**オプションA: Accountクラスを使って既存のキーを使用する**

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

**オプションB: ファイルベースのキー管理にAccountStorageを使用する**

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

### 2. ACMEクライアントの初期化

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

### 3. ACMEアカウントの登録

Let's Encryptの場合（EAB不要）：

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

ZeroSSLの場合（EABが必要）：

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

### 4. 証明書のリクエスト

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

### 5. 完全なドメイン検証

チャレンジファイルをウェブサーバーに配置した後：

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

### 6. CSRの生成と提出

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

## 高度な使用法

### DNS-01 チャレンジ

ワイルドカード証明書やHTTP検証が不可能な場合:

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

### ARIによる証明書の更新

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

### 証明書の失効

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

### 複数の認証局

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

### カスタムHTTPクライアントの設定

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

### ロギング

```php
use Monolog\Logger;
use Monolog\Handler\StreamHandler;

// Create logger
$logger = new Logger('acme');
$logger->pushHandler(new StreamHandler('acme.log', Logger::INFO));

// Set logger on client
$acmeClient->setLogger($logger);
```

## 設定

### アカウント管理オプション

**ファイルベースの管理にAccountStorageを使用する場合：**

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

**既存のキーに対してAccountクラスを使用する場合：**

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

## エラー処理

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

## テスト

テストスイートを実行する:

```bash
composer test
```

静的解析を実行する：

```bash
composer analyse
```
コードスタイルを修正してください：


```bash
composer cs-fix
```

## セキュリティ上の考慮事項

1. **秘密鍵**: 適切なファイル権限（600）で秘密鍵を安全に保管すること
2. **アカウント鍵**: アカウント鍵は証明書鍵と分けて保管すること
3. **ステージング環境**: テストにはステージング環境を使用すること
4. **レート制限**: CAのレート制限に注意すること
5. **検証**: ACME検証を実行する前に必ずチャレンジをローカルで検証すること

## 貢献方法

1. リポジトリをフォークする
2. 機能ブランチを作成する
3. 変更を加える
4. 新機能のテストを追加する
5. テストスイートを実行する
6. プルリクエストを送信する

## ライセンス

本プロジェクトはMITライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## リンク

- [Let's Encrypt ドキュメント](https://letsencrypt.org/docs/)
- [ACME仕様 RFC 8555](https://tools.ietf.org/html/rfc8555)
- [ZeroSSL ACMEガイド](https://zerossl.com/documentation/acme/)

## サポート

問題が発生した場合や質問がある場合は：

1. [ドキュメント](#quick-start)を確認する
2. 既存の[issues](https://github.com/anhao/acme-client/issues)を検索する
3. 必要に応じて[新しいissue](https://github.com/anhao/acme-client/issues/new)を作成する


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---