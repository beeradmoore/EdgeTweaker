---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation BuiltinCertificateVerifierEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/builtincertificateverifierenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Determines whether the built-in certificate verifier will be used to verify server certificates (obsolete)'
locale: en-us
document_id: 80f1a3ca-a064-0610-f530-b37d37ac61ff
document_version_independent_id: 80f1a3ca-a064-0610-f530-b37d37ac61ff
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/BuiltinCertificateVerifierEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/BuiltinCertificateVerifierEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 137
asset_id: microsoft-edge-policies/builtincertificateverifierenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/BuiltinCertificateVerifierEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 66906560-a6c8-af12-9a4c-9852cfdd16f0
---

# Microsoft Edge Browser Policy Documentation BuiltinCertificateVerifierEnabled | Microsoft Learn

## Determines whether the built-in certificate verifier will be used to verify server certificates (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 106.

## Supported versions

- Windows: Not supported
- macOS: 83-106
- Android: Not supported
- iOS: Not supported

## Description

This policy is obsolete because it was a short-term mechanism to give enterprises more time to update their environments and report issues if they're found to be incompatible with the built-in certificate verifier.

The policy doesn't work in Microsoft Edge version 107.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Mac information and settings

- Preference Key name: BuiltinCertificateVerifierEnabled
- Example value:

```xml
<false/>
```