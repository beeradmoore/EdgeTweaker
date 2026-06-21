---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EnforceLocalAnchorConstraintsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/enforcelocalanchorconstraintsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Determines whether the built-in certificate verifier will enforce constraints encoded into trust anchors loaded from the platform trust store (obsolete)'
locale: en-us
document_id: a95b2d4f-e328-c534-4248-a206db6dcf95
document_version_independent_id: a95b2d4f-e328-c534-4248-a206db6dcf95
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EnforceLocalAnchorConstraintsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EnforceLocalAnchorConstraintsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 326
asset_id: microsoft-edge-policies/enforcelocalanchorconstraintsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EnforceLocalAnchorConstraintsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 362e0bff-589c-1ece-289b-872bac253cb2
---

# Microsoft Edge Browser Policy Documentation EnforceLocalAnchorConstraintsEnabled | Microsoft Learn

## Determines whether the built-in certificate verifier will enforce constraints encoded into trust anchors loaded from the platform trust store (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 127.

## Supported versions

- Windows: 113-127
- macOS: 113-127
- Android: Not supported
- iOS: Not supported

## Description

X.509 certificates might encode constraints, such as Name Constraints, in extensions in the certificate. RFC 5280 specifies that enforcing such constraints on trust anchor certificates is optional.

From Microsoft Edge 112, such constraints in certificates loaded from the platform certificate store will now be enforced.

This policy exists as a temporary opt-out in case an enterprise encounters issues with the constraints encoded in their private roots. In that case this policy may be used to temporarily disable enforcement of the constraints while correcting the certificate issues.

If you enable this policy or don't configure it, Microsoft Edge enforces constraints encoded into trust anchors loaded from the platform trust store.

If you disable this policy, Microsoft Edge won't enforce constraints encoded into trust anchors loaded from the platform trust store.

This policy has no effect if the [MicrosoftRootStoreEnabled](microsoftrootstoreenabled) policy is disabled.

This policy was removed in Microsoft Edge version 128. Starting with that version, constraints in trust anchors are always enforced.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EnforceLocalAnchorConstraintsEnabled
- GP name: Determines whether the built-in certificate verifier will enforce constraints encoded into trust anchors loaded from the platform trust store (obsolete)
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: EnforceLocalAnchorConstraintsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EnforceLocalAnchorConstraintsEnabled
- Example value:

```xml
<false/>
```