---
layout: Conceptual
title: Microsoft Edge Browser Policy Documentation AmbientAuthenticationInPrivateModesEnabled | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies/ambientauthenticationinprivatemodesenabled
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
description: 'Windows and Mac documentation for supported Microsoft Edge Browser policy: Enable Ambient Authentication for InPrivate and Guest profiles'
locale: en-us
document_id: 714c35fc-e8ae-7e04-e755-f8b0ec3c6b45
document_version_independent_id: 714c35fc-e8ae-7e04-e755-f8b0ec3c6b45
updated_at: 2026-05-22T04:11:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/live/edgeenterprise/microsoft-edge-policies/AmbientAuthenticationInPrivateModesEnabled.md
gitcommit: https://github.com/MicrosoftDocs/Edge-Enterprise-pr/blob/7994bce7d6018fbcf8930c7152ea4c5b85aadcfd/edgeenterprise/microsoft-edge-policies/AmbientAuthenticationInPrivateModesEnabled.md
git_commit_id: 7994bce7d6018fbcf8930c7152ea4c5b85aadcfd
site_name: Docs
depot_name: office.Edge-Enterprise
page_type: conceptual
toc_rel: ../toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/office.Edge-Enterprise/{branchName}{pdfName}
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 395
asset_id: microsoft-edge-policies/ambientauthenticationinprivatemodesenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: edgeenterprise/microsoft-edge-policies/AmbientAuthenticationInPrivateModesEnabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ca140cbb-709b-8719-fb3b-e50840c877fb
---

# Microsoft Edge Browser Policy Documentation AmbientAuthenticationInPrivateModesEnabled | Microsoft Learn

## Enable Ambient Authentication for InPrivate and Guest profiles

## Supported versions

- Windows: ≥ 81
- macOS: ≥ 81
- Android: Not supported
- iOS: Not supported

## Description

Configures this policy to allow/disallow ambient authentication for InPrivate and Guest profiles in Microsoft Edge.

Ambient Authentication is http authentication with default credentials when explicit credentials aren't provided via New Technology LAN Manager (NTLM)/Kerberos/Negotiate challenge/response schemes.

If you set the policy to 'RegularOnly', it allows ambient authentication for Regular sessions only. InPrivate and Guest sessions aren't allowed to ambiently authenticate.

If you set the policy to 'InPrivateAndRegular', it allows ambient authentication for InPrivate and Regular sessions. Guest sessions aren't allowed to ambiently authenticate.

If you set the policy to 'GuestAndRegular', it allows ambient authentication for Guest and Regular sessions. InPrivate sessions aren't allowed to ambiently authenticate

If you set the policy to 'All', it allows ambient authentication for all sessions.

Ambient authentication is always allowed on regular profiles.

In Microsoft Edge version 81 and later, if you don't configure this policy, ambient authentication is enabled in regular sessions only.

Policy options mapping:

- RegularOnly (0) = Enable ambient authentication in regular sessions only
- InPrivateAndRegular (1) = Enable ambient authentication in InPrivate and regular sessions
- GuestAndRegular (2) = Enable ambient authentication in guest and regular sessions
- All (3) = Enable ambient authentication in regular, InPrivate, and guest sessions

Use the preceding information when configuring this policy.

## Policy options mapping:

> 
> Use this information when configuring this policy.

- RegularOnly (0) = Enable ambient authentication in regular sessions only
- InPrivateAndRegular (1) = Enable ambient authentication in InPrivate and regular sessions
- GuestAndRegular (2) = Enable ambient authentication in guest and regular sessions
- All (3) = Enable ambient authentication in regular, InPrivate, and guest sessions

## Supported features

- Can be mandatory: Yes
- Can be recommended: No
- Dynamic Policy Refresh: Yes
- Per Profile: No
- Applies to a profile that is signed in with a Microsoft account: Yes

## Data type

- Integer

## Windows information and settings

### Group Policy (ADMX) info

- GP unique name: AmbientAuthenticationInPrivateModesEnabled
- GP name: Enable Ambient Authentication for InPrivate and Guest profiles
- GP path (Mandatory): Administrative Templates/Microsoft Edge
- GP path (Recommended): N/A
- GP ADMX file name: MSEdge.admx

#### Example value

```
Enable ambient authentication in regular sessions only
```

### Registry settings

- Path (Mandatory): SOFTWARE\Policies\Microsoft\Edge
- Path (Recommended): N/A
- Value name: AmbientAuthenticationInPrivateModesEnabled
- Value type: REG\_DWORD

#### Example registry value

```
0x00000000
```

## Mac information and settings

- Preference Key name: AmbientAuthenticationInPrivateModesEnabled
- Example value:

```xml
<integer>0</integer>
```