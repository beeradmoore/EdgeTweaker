---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation TLS13HardeningForLocalAnchorsEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/tls13hardeningforlocalanchorsenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable a TLS 1.3 security feature for local trust anchors (obsolete)'
locale: en-us
document_id: d1fa7e5d-7639-709d-0f74-e20dcd1a369f
document_version_independent_id: d1fa7e5d-7639-709d-0f74-e20dcd1a369f
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/TLS13HardeningForLocalAnchorsEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/TLS13HardeningForLocalAnchorsEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 290
asset_id: microsoft-edge-policies/tls13hardeningforlocalanchorsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/TLS13HardeningForLocalAnchorsEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8aa8b22e-110e-e225-6a6f-60a1c0ac4ec8
---

# Microsoft Edge Browser Policy Documentation TLS13HardeningForLocalAnchorsEnabled | Microsoft Learn

## Enable a TLS 1.3 security feature for local trust anchors (obsolete)

> 
> OBSOLETE: This policy is obsolete and doesn't work after Microsoft Edge version 85.

## Supported versions

- Windows: 81-85
- macOS: 81-85
- Android: Not supported
- iOS: Not supported

## Description

This policy doesn't work because it was only intended to be a short-term mechanism to give enterprises more time to upgrade affected proxies.

This policy controls a security feature in TLS 1.3 that protects connections against downgrade attacks. It's backwards-compatible and doesn't affect connections to compliant TLS 1.2 servers or proxies. However, older versions of some TLS-intercepting proxies have an implementation flaw which causes them to be incompatible.

If you enable or don't configure this policy, Microsoft Edge enables these security protections for all connections.

If you disable this policy, Microsoft Edge disables these security protections for connections authenticated with locally-installed CA certificates. These protections are always enabled for connections authenticated with publicly-trusted CA certificates.

This policy can be used to test for any affected proxies and upgrade them. Affected proxies are expected to fail connections with an error code of ERR\_TLS13\_DOWNGRADE\_DETECTED.

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: TLS13HardeningForLocalAnchorsEnabled
- GP name: Enable a TLS 1.3 security feature for local trust anchors (obsolete)
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
- Value name: TLS13HardeningForLocalAnchorsEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: TLS13HardeningForLocalAnchorsEnabled
- Example value:

```xml
<true/>
```