---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation WAMAuthBelowWin10RS3Enabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/wamauthbelowwin10rs3enabled
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
ms.subservice: edge-admin
ms.localizationpriority: high
ms.collection: M365-modern-desktop
ms.custom: 
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: WAM for authentication below Windows 10 RS3 enabled'
locale: en-us
document_id: 200933f0-4f6a-737c-db4f-4c72c384c102
document_version_independent_id: 200933f0-4f6a-737c-db4f-4c72c384c102
updated_at: 2026-06-15T22:43:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/WAMAuthBelowWin10RS3Enabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/88a66a0c8d7bd6d32736da12931a68ac6580ed4a/edgeenterprise/microsoft-edge-policies/WAMAuthBelowWin10RS3Enabled.md
git_commit_id: 88a66a0c8d7bd6d32736da12931a68ac6580ed4a
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 235
asset_id: microsoft-edge-policies/wamauthbelowwin10rs3enabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/WAMAuthBelowWin10RS3Enabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/e0ffb20c-01c6-407b-a9bd-29111652a1dc
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/3904bce4-d817-48cf-85fd-b6146fca83b7
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 484ae514-a857-92b0-3671-cd4fd22c8a2b
---

# Microsoft Edge Browser Policy Documentation WAMAuthBelowWin10RS3Enabled | Microsoft Learn

## WAM for authentication below Windows 10 RS3 enabled

## Supported versions

- Windows: ≥ 93
- macOS: Not supported
- Android: Not supported
- iOS: Not supported

## Description

Configure this policy to decide whether WAM is used for authentication in Microsoft Edge on Windows 10 RS1 and RS2.

If you enable this setting, WAM is used in the authentication flow on Windows 10 RS1 and RS2.

If you disable or don't configure this setting, OneAuth libraries are used instead of WAM on Windows 10 RS1 and RS2.

If this policy is enabled, then previous sign-in sessions (which used OneAuth by default) can't be used. Sign out of those profiles.

This policy will only take effect on Windows 10 RS1 and RS2. On Windows 10 RS3 and above, WAM is used for authentication in Microsoft Edge by default.

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

- GP unique name: WAMAuthBelowWin10RS3Enabled
- GP name: WAM for authentication below Windows 10 RS3 enabled
- GP path (Mandatory): Administrative Templates/Microsoft Edge/Identity and sign-in
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enabled
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: WAMAuthBelowWin10RS3Enabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000001
```