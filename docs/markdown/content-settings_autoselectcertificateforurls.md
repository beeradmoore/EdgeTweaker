---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AutoSelectCertificateForUrls | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/autoselectcertificateforurls
breadcrumb_path: /DeployEdge/breadcrumb/toc.json
recommendations: true
feedback_system: Standard
feedback_product_url: https://support.microsoft.com/help/4021566/windows-10-send-feedback-to-microsoft-with-feedback-hub-app
uhfHeaderId: MSDocsHeader-MSEdge
ms.author: jalam
author: vmliramichael
manager: nuyunzhang
ms.date: 2026-05-20T00:00:00.0000000Z
audience: ITPro
ms.topic: reference
ms.service: microsoft-edge
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Automatically select client certificates for these sites'
locale: en-us
document_id: d09ff813-01b6-98da-efa2-cd623d9b3c83
document_version_independent_id: d09ff813-01b6-98da-efa2-cd623d9b3c83
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AutoSelectCertificateForUrls.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AutoSelectCertificateForUrls.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 484
asset_id: microsoft-edge-policies/autoselectcertificateforurls
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AutoSelectCertificateForUrls.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 5d4b6d48-edc6-ff75-7ee5-923aa33aa045
---

# Microsoft Edge Browser Policy Documentation AutoSelectCertificateForUrls | Microsoft Learn

## Automatically select client certificates for these sites

## Supported versions

- Windows: ≥ 77
- macOS: ≥ 77
- Android: ≥ 147
- iOS: Not supported

## Description

Setting the policy lets you make a list of URL patterns that specify sites for which Microsoft Edge can automatically select a client certificate. The value is an array of stringified JSON dictionaries, each with the form { "pattern": "$URL\_PATTERN", "filter" : $FILTER }, where $URL\_PATTERN is a content setting pattern. $FILTER restricts the client certificates the browser automatically selects from. Independent of the filter, only certificates that match the server's certificate request are selected.

Examples for the usage of the $FILTER section:

- When $FILTER is set to { "ISSUER": { "CN": "$ISSUER\_CN" } }, only client certificates issued by a certificate with the CommonName $ISSUER\_CN are selected.
- When $FILTER contains both the "ISSUER" and the "SUBJECT" sections, only client certificates that satisfy both conditions are selected.
- When $FILTER contains a "SUBJECT" section with the "O" value, a certificate needs at least one organization matching the specified value to be selected.
- When $FILTER contains a "SUBJECT" section with a "OU" value, a certificate needs at least one organizational unit matching the specified value to be selected.
- When $FILTER is set to {}, the selection of client certificates isn't additionally restricted. Filters provided by the web server still apply.

If you leave the policy unset, there's no autoselection for any site.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- List of strings

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AutoSelectCertificateForUrls
- GP name: Automatically select client certificates for these sites
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Content settings
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
{"pattern":"https://www.contoso.com","filter":{"ISSUER":{"CN":"certificate issuer name", "L": "certificate issuer location", "O": "certificate issuer org", "OU": "certificate issuer org unit"}, "SUBJECT":{"CN":"certificate subject name", "L": "certificate subject location", "O": "certificate subject org", "OU": "certificate subject org unit"}}}
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge\AutoSelectCertificateForUrls
- Path (Recommended): N/A
- Value name: 1, 2, 3, ...
- Value type: List of REG\_SZ

#### Example registry value

SOFTWARE\Policies\Microsoft\Edge\AutoSelectCertificateForUrls\1 =

```
{"pattern":"https://www.contoso.com","filter":{"ISSUER":{"CN":"certificate issuer name", "L": "certificate issuer location", "O": "certificate issuer org", "OU": "certificate issuer org unit"}, "SUBJECT":{"CN":"certificate subject name", "L": "certificate subject location", "O": "certificate subject org", "OU": "certificate subject org unit"}}}
```

## Mac information and settings

- Preference Key name: AutoSelectCertificateForUrls
- Example value:

```xml
<array>
  <string>{"pattern":"https://www.contoso.com","filter":{"ISSUER":{"CN":"certificate issuer name", "L": "certificate issuer location", "O": "certificate issuer org", "OU": "certificate issuer org unit"}, "SUBJECT":{"CN":"certificate subject name", "L": "certificate subject location", "O": "certificate subject org", "OU": "certificate subject org unit"}}}</string>
</array>
```

## Android information and settings

- Preference Key name: AutoSelectCertificateForUrls
- Example value:

```
["{\"pattern\":\"https://www.contoso.com\",\"filter\":{\"ISSUER\":{\"CN\":\"certificate issuer name\", \"L\": \"certificate issuer location\", \"O\": \"certificate issuer org\", \"OU\": \"certificate issuer org unit\"}, \"SUBJECT\":{\"CN\":\"certificate subject name\", \"L\": \"certificate subject location\", \"O\": \"certificate subject org\", \"OU\": \"certificate subject org unit\"}}}"]
```