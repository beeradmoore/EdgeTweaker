---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AuthNegotiateDelegateByKdcPolicy | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/authnegotiatedelegatebykdcpolicy
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use KDC policy to delegate credentials.'
locale: en-us
document_id: 95921f43-6978-7974-632c-dad8970ee05e
document_version_independent_id: 95921f43-6978-7974-632c-dad8970ee05e
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateByKdcPolicy.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateByKdcPolicy.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 153
asset_id: microsoft-edge-policies/authnegotiatedelegatebykdcpolicy
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AuthNegotiateDelegateByKdcPolicy.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9a8abd27-848c-22cc-77c9-1336e6d4d35b
---

# Microsoft Edge Browser Policy Documentation AuthNegotiateDelegateByKdcPolicy | Microsoft Learn

## Use KDC policy to delegate credentials.

## Supported versions

- Windows: Not supported
- macOS: ≥ 147
- Android: Not supported
- iOS: Not supported

## Description

If you enable this policy, HTTP authentication honors approval from the Key Distribution Center (KDC). Microsoft Edge delegates user credentials to the requested service only when the KDC sets the OK-AS-DELEGATE flag on the service ticket, as defined in RFC 5896 (https://tools.ietf.org/html/rfc5896.html). The service must also be included in the AuthNegotiateDelegateAllowlist policy.

If you disable or don't configure this policy, Microsoft Edge ignores approval from the Key Distribution Center (KDC) on supported platforms and delegates credentials only to services specified in AuthNegotiateDelegateAllowlist.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: AuthNegotiateDelegateByKdcPolicy
- Example value:

```xml
<true/>
```