---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation ForceCertificatePromptsOnMultipleMatches | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/forcecertificatepromptsonmultiplematches
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Configure whether Microsoft Edge should automatically select a certificate when there are multiple certificate matches for a site configured with &quot;AutoSelectCertificateForUrls&quot; (deprecated)'
locale: en-us
document_id: ccc3fe85-a587-fb82-8b72-b4cb3abab671
document_version_independent_id: ccc3fe85-a587-fb82-8b72-b4cb3abab671
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/ForceCertificatePromptsOnMultipleMatches.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/ForceCertificatePromptsOnMultipleMatches.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 317
asset_id: microsoft-edge-policies/forcecertificatepromptsonmultiplematches
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/ForceCertificatePromptsOnMultipleMatches.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ef0f2fa5-809b-c50a-2093-b8b1ff0a6e37
---

# Microsoft Edge Browser Policy Documentation ForceCertificatePromptsOnMultipleMatches | Microsoft Learn

## Configure whether Microsoft Edge should automatically select a certificate when there are multiple certificate matches for a site configured with "AutoSelectCertificateForUrls" (deprecated)

> 
> DEPRECATED: This policy is deprecated. It is currently supported but will become obsolete in a future release.

## Supported versions

- Windows: ≥ 81
- macOS: ≥ 81
- Android: Not supported
- iOS: Not supported

## Description

This policy is deprecated because we are moving to a new policy. It won't work in Microsoft Edge version 104. The new policy to use is [PromptOnMultipleMatchingCertificates](promptonmultiplematchingcertificates).

Toggles whether users are prompted to select a certificate if there are multiple certificates available and a site is configured with [AutoSelectCertificateForUrls](autoselectcertificateforurls). If you don't configure [AutoSelectCertificateForUrls](autoselectcertificateforurls) for a site, the user is always prompted to select a certificate.

If you enable this policy, Microsoft Edge prompts a user to select a certificate for sites on the list defined in [AutoSelectCertificateForUrls](autoselectcertificateforurls) if and only if there's more than one certificate.

If you disable or don't configure this policy, Microsoft Edge automatically selects a certificate even if there are multiple matches for a certificate. The user won't be prompted to select a certificate for sites on the list defined in [AutoSelectCertificateForUrls](autoselectcertificateforurls).

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: ForceCertificatePromptsOnMultipleMatches
- GP name: Configure whether Microsoft Edge should automatically select a certificate when there are multiple certificate matches for a site configured with "AutoSelectCertificateForUrls" (deprecated)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: ForceCertificatePromptsOnMultipleMatches
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: ForceCertificatePromptsOnMultipleMatches
- Example value:

```xml
<true/>
```