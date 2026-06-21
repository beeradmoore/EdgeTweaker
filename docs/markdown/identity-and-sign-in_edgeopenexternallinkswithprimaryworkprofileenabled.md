---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/edgeopenexternallinkswithprimaryworkprofileenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Use Primary Work Profile as default to open external links'
locale: en-us
document_id: d2f4ade0-10de-39de-212d-98af395e1e10
document_version_independent_id: d2f4ade0-10de-39de-212d-98af395e1e10
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 322
asset_id: microsoft-edge-policies/edgeopenexternallinkswithprimaryworkprofileenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/1433a524-c01f-4b87-beab-670c040dea4f
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/312f1f05-a431-4193-8a4d-e6245d5966de
platformId: afd431d6-2ede-eb94-8fb0-caa764f99fcf
---

# Microsoft Edge Browser Policy Documentation EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled | Microsoft Learn

## Use Primary Work Profile as default to open external links

## Supported versions

- Windows: ≥ 138
- macOS: ≥ 138
- Android: Not supported
- iOS: Not supported

## Description

This policy controls whether Microsoft Edge uses the Primary Work Profile as the default profile when opening external links.

1. On Windows, the Primary Work Profile refers to the profile signed in with the Entra ID account used to enroll the device.
2. On macOS and Linux, the Primary Work Profile is the only profile signed in with an Entra ID account. If multiple profiles are signed in with Entra ID accounts, the Primary Work Profile setting doesn't apply.

Policy behavior:

1. If enabled or not configured, Microsoft Edge uses the Primary Work Profile as the default for opening external links.
2. If disabled, the last used profile becomes the default for opening external links.

Note: This policy doesn't override the following scenarios:

1. If the EdgeDefaultProfileEnabled policy is set, it takes precedence over this policy.
2. External links opened from Outlook or Microsoft Teams may be configured to launch in a specific profile, which can override the Primary Work Profile setting.
3. If the user sets a preference for "Default profile for external links" in Profile preferences, that setting takes effect.

## Supported features

- Can be mandatory: No
- Can be recommended: Yes
- Dynamic Policy Refresh: No - Requires browser restart
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled
- GP name: Use Primary Work Profile as default to open external links
- GP path (Mandatory): N/A
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Identity and sign-in
- GP ADMX file name: MSEdge.admx

#### Example value

```
Disabled
```

### Registry settings

- Path (Mandatory): N/A
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: EdgeOpenExternalLinksWithPrimaryWorkProfileEnabled
- Example value:

```xml
<false/>
```