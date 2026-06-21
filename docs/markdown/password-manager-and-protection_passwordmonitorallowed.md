---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation PasswordMonitorAllowed | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/passwordmonitorallowed
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Allow users to be alerted if their passwords are found to be unsafe'
locale: en-us
document_id: a813c36a-9f4a-6c59-bc06-1883b8e40a10
document_version_independent_id: a813c36a-9f4a-6c59-bc06-1883b8e40a10
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/PasswordMonitorAllowed.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/PasswordMonitorAllowed.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 391
asset_id: microsoft-edge-policies/passwordmonitorallowed
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/PasswordMonitorAllowed.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ca3e20e2-e1b3-6633-caa9-8283630cc1cf
---

# Microsoft Edge Browser Policy Documentation PasswordMonitorAllowed | Microsoft Learn

## Allow users to be alerted if their passwords are found to be unsafe

## Supported versions

- Windows: ≥ 85
- macOS: ≥ 93
- Android: Not supported
- iOS: Not supported

## Description

Allow Microsoft Edge to monitor user passwords.

If you enable this policy, the user gets alerted if any of their passwords stored in Microsoft Edge are found to be unsafe. Microsoft Edge will show an alert and this information will also be available in Settings &gt; Passwords &gt; Password Monitor.

If you disable this policy, users aren't asked for permission to enable this feature. Their passwords aren't scanned, and they aren't alerted either.

If you don't configure the policy, users can turn this feature on or off.

To learn more about how Microsoft Edge finds unsafe passwords see https://go.microsoft.com/fwlink/?linkid=2133833

Additional guidance:

This policy can be set as both Recommended and Mandatory, however with an important callout.

Mandatory enabled: If the policy is set to Mandatory enabled, the UI in Settings will be disabled but remain in 'On' state, and a briefcase icon will be made visible next to it with this description displayed on hover - "This setting is managed by your organization."

Recommended enabled: If the policy is set to Recommended enabled, the UI in Settings will remain in 'Off' state, but a briefcase icon will be made visible next to it with this description displayed on hover - "Your organization recommends a specific value for this setting and you have chosen a different value"

Mandatory and Recommended disabled: Both these states will work the normal way, with the usual captions being shown to users.

## Supported features

- Can be mandatory: Yes
- Can be recommended: Yes
- Dynamic Policy Refresh: Yes
- Per Profile: Yes
- Applies to a profile that is signed in with a Microsoft account: No

## Data type

- Boolean

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: PasswordMonitorAllowed
- GP name: Allow users to be alerted if their passwords are found to be unsafe
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Password manager and protection
- GP path (Recommended): Administrative Templates/Microsoft Edge - Default Settings (users can override)/Password manager and protection
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): SOFTWARE\Policies\Microsoft\Edge\Recommended
- Value name: PasswordMonitorAllowed
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```

## Mac information and settings

- Preference Key name: PasswordMonitorAllowed
- Example value:

```xml
<true/>
```