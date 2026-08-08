------------------------------------ 20/07/2026 --------------------------------------------
1. Concept of Fatty Controller
    a. MediatR Pattern
    b. CQRS Pattern
    c. Dynamic Migration
    d. Fluent Model Validation
    e. Fluent API Validation
    f. Onion Architecture
    g. CI/CD 
        i) using Github actions
        ii)Devops
    h. Secure Connection using Azure Key Vault

    ------------------------------------ 26/07/2026 --------------------------------------------

1. Key features for Implementing CI/CD
    a. Key Vault -- Config + Encryption + Hashing + Logging + Access Control + Rotation
    b. Sql Server (Azure)
    c. NUnit
    d. Devops (CI/CD)
    e. Github actions (CI/CD)

2. Azure Key Vault supports multiple industry-standard cryptographic algorithms, 
    primarily RSA, Elliptic Curve (EC), and AES (symmetric) for encryption, decryption, 
    signing, and key wrapping. Microsoft recommends using modern algorithms like RSA-OAEP-256, 
    AES-GCM, and ECDSA with NIST curves for stronger security.

    In short, RSA + HSMs (Hardware Security Modules)

3. Another old technique to access Key Vault is App Registration technique.

        ------------------------------------ 30/07/2026 --------------------------------------------

1. Steps for integrating Key Vault
    a. KeyVault URL -- https://genaiproductkeyvault.vault.azure.net/
    b. Add Package -- <PackageReference Include="Azure.Identity" Version="1.21.0" />

2. What kind of configuration you have done in Program.cs.
